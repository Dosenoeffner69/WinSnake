using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WinSnake
{
    class Game
    {
        bool stop=false;
        List<Schlange> Spieler=new List<Schlange>();
        Graphics Zeichenfläche;
        int gridSize, gridX, gridY;
        Piece Essen;
        
     
        public Game(Graphics Zeichenfläche,int gridSize)
        {
            this.gridSize = gridSize;
            this.Zeichenfläche = Zeichenfläche;
            gridX = Convert.ToInt32(Zeichenfläche.VisibleClipBounds.Width) / gridSize;
            gridY = Convert.ToInt32(Zeichenfläche.VisibleClipBounds.Height) / gridSize;
            Spieler.Add(new Schlange(Zeichenfläche, gridSize,0,0,1,0));
            Spieler.Add(new Schlange(Zeichenfläche, gridSize, gridSize*gridX-1, gridSize*gridX-1,-1,0));
            neuesEssen();
        }

        public void Controls(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down) Spieler[0].richtung(0, 1);
            if (e.KeyCode == Keys.Up) Spieler[0].richtung(0, -1);
            if (e.KeyCode == Keys.Left) Spieler[0].richtung(-1, 0);
            if (e.KeyCode == Keys.Right) Spieler[0].richtung(1, 0);
        }

        void Draw()
        {
            Zeichenfläche.FillRectangle(Brushes.Black, 0, 0, Zeichenfläche.VisibleClipBounds.Width, Zeichenfläche.VisibleClipBounds.Height);
            Essen.show();
            foreach (Schlange s in Spieler)
            {
                s.show();
            }
        }

        void update()
        {
            foreach (Schlange Spieler in Spieler)
            {
                Spieler.update();
            }
        }


        void Check()
        { 
            foreach(Schlange S in Spieler)
            {
                //prüfe auf essen
                if (S.Tail[0].Pos == Essen.Pos)
                {
                    S.eat();
                    neuesEssen();
                }
                
                //prüfe auf kollision mit sich selbst oder wand
                S.check();
                if (S.eaten || S.wall) stop = true;

                //prüfe auf kollison mit anderer Schlange
                foreach (Schlange S2 in Spieler)
                {
                    foreach (Piece p1 in S.Tail)
                    {
                        foreach (Piece p2 in S2.Tail)
                        {
                           // if (p1.Pos == p2.Pos&&S!=S2) this.stop = true; ;
                        }
                    }
                }
            }

           
            
        }

        void neuesEssen()
        {
            Random rnd = new Random();
            int X = rnd.Next(0, gridX);
            int Y = rnd.Next(0, gridY);
            Console.WriteLine("Neue essenskoordinaten:{0},{1}",X*gridSize,Y*gridSize);
            Essen= new Piece(Brushes.Red, Zeichenfläche, gridSize*X, gridSize*Y, gridSize);
        }
        
        public void Tick()
        {
            if (!this.stop) update();
            if (!this.stop) Check();
            if (!this.stop) Draw();
        }
    }
}
