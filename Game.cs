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
        bool stop;
        List<Schlange> Spieler=new List<Schlange>();
        Graphics Zeichenfläche;
        int gridSize;
        public KeyEventArgs Key;
        
       

        public Game(Graphics Zeichenfläche,int gridSize)
        {
            this.gridSize = gridSize;
            this.Zeichenfläche = Zeichenfläche;
            Spieler.Add(new Schlange(Zeichenfläche, gridSize));
        }

        void Draw()
        {
            Zeichenfläche.FillRectangle(Brushes.Black, 0, 0, Zeichenfläche.VisibleClipBounds.Width, Zeichenfläche.VisibleClipBounds.Height);
            foreach (Schlange Spieler in Spieler)
            {
                Spieler.show();
            }
        }
        
        public void Tick()
        {
            foreach (Schlange Spieler in Spieler)
            {
                Spieler.update();
            }
            Draw();




            if (Key.KeyCode.Equals(Keys.Up))
            {
                MessageBox.Show("te");
            }

            else
            {

            }

        }
    }
}
