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
        int anzahlSpieler;
        
     
        public Game(Graphics Zeichenfläche,int gridSize,int anzahlSpieler)
        {
            this.gridSize = gridSize;
            this.Zeichenfläche = Zeichenfläche;
            this.anzahlSpieler = anzahlSpieler;
            gridX = Convert.ToInt32(Zeichenfläche.VisibleClipBounds.Width) / gridSize;
            gridY = Convert.ToInt32(Zeichenfläche.VisibleClipBounds.Height) / gridSize;
            Spieler.Add(new Schlange(Zeichenfläche, gridSize,0,0,2,Brushes.Green));
            if(anzahlSpieler==2) Spieler.Add(new Schlange(Zeichenfläche, gridSize, gridSize * (gridX - 1), gridSize * (gridX - 1),4,Brushes.Blue));
            neuesEssen();
        }

        public void Controls(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down && Spieler[0].Richtung!=1) Spieler[0].richtung(3);
            if (e.KeyCode == Keys.Up&&Spieler[0].Richtung!=3) Spieler[0].richtung(1);
            if (e.KeyCode == Keys.Left && Spieler[0].Richtung != 2) Spieler[0].richtung(4);
            if (e.KeyCode == Keys.Right && Spieler[0].Richtung != 4) Spieler[0].richtung(2);

            if (anzahlSpieler == 2)
            {
                if (e.KeyCode == Keys.S && Spieler[0].Richtung != 1) Spieler[1].richtung(3);
                if (e.KeyCode == Keys.W && Spieler[0].Richtung != 3) Spieler[1].richtung(1);
                if (e.KeyCode == Keys.A && Spieler[0].Richtung != 2) Spieler[1].richtung(4);
                if (e.KeyCode == Keys.D && Spieler[0].Richtung != 4) Spieler[1].richtung(2);
            }
        }

        void Draw()
        {
            Zeichenfläche.FillRectangle(Brushes.White, 0, 0, Zeichenfläche.VisibleClipBounds.Width, Zeichenfläche.VisibleClipBounds.Height);
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
                            if (p1.Pos == p2.Pos&&S!=S2) this.stop = true; ;
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

            bool check = false;
            Piece temp = new Piece(Brushes.Red, Zeichenfläche, gridSize * X, gridSize * Y, gridSize);

            while (check == false)
            {
                check = true;
                foreach (Schlange S in Spieler)
                {
                    foreach (Piece p in S.Tail)
                    {
                        if (p.Pos == temp.Pos) check = false;
                    }
                }

                if (check == true) Essen = new Piece(Brushes.Red, Zeichenfläche, gridSize * X, gridSize * Y, gridSize);

            }
        }
        
        public void Tick()
        {
            if (!this.stop) update();
            if (!this.stop) Check();
            if (!this.stop) Draw();
        }
    }
}
