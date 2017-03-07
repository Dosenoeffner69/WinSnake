using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WinSnake
{
    class Schlange
    {
        int SpeedX;
        int SpeedY;
        Graphics canvas;
        int Grid;
        public List<Piece> Tail;
        public bool selfeaten;



        public Schlange(Graphics c,int Grid)
        {
            
            SpeedX = 1;
            SpeedY = 0;
            canvas = c;
            this.Grid = Grid;
            Tail = new List<Piece>();
            Tail.Add(new Piece(Brushes.White, canvas, 0, 0, Grid, true));
            selfeaten = false;


        }

        public void update()
        {
            for(int x = Tail.Count - 1; x > 0; x--)
            {
                Tail[x].PosX = Tail[x - 1].PosX;
                Tail[x].PosY = Tail[x - 1].PosY;
                Tail[x].aktiv = true;
            }
            //Tail.Add(new Piece(Brushes.White, canvas, 0, 0, Grid, true));
            Tail[0].PosX= LimitToRange(Tail[0].PosX += SpeedX * Grid, 0, Convert.ToInt32(canvas.VisibleClipBounds.Width) - Grid);
            Tail[0].PosY= LimitToRange(Tail[0].PosY += SpeedY * Grid, 0, Convert.ToInt32(canvas.VisibleClipBounds.Height) - Grid);
            //check();
        }

        public void eat()
        {
            Random rnd = new Random();
            Brush b = new SolidBrush(Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255)));
            Tail.Add(new Piece(b, canvas, Tail[Tail.Count-1].PosX, Tail[Tail.Count-1].PosY, Grid,false));
        }

        public bool check()
        {
            for(int x = Tail.Count - 1; x > 0; x--)
            {
                if (Tail[x].PosX == Tail[0].PosX && Tail[x].PosY == Tail[0].PosY)
                {
                    return true;
                }            
            }
            return false;
        }

        public void richtung(int X, int Y)
        {
            SpeedX = X;
            SpeedY = Y;
        }

        public void show()
        {
           foreach(Piece p in Tail)
            {
                if(p.aktiv) p.show();
            }
        }

        public int LimitToRange(int value, int inclusiveMinimum, int inlusiveMaximum)
        {
            if (value >= inclusiveMinimum)
            {
                if (value <= inlusiveMaximum)
                {
                    return value;
                }
                return 0;
            }

            return Convert.ToInt32(canvas.VisibleClipBounds.Height-Grid);
        }
    }
}
