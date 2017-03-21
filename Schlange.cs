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
        public bool eaten;
        public bool wall;
        public bool otherSnake;
        Point Startpunkt;

        public Schlange(Graphics c,int Grid,int X, int Y,int moveX, int moveY)
        { 
            SpeedX = moveX;
            SpeedY = moveY;
            canvas = c;
            this.Grid = Grid;
            Tail = new List<Piece>();
            Tail.Add(new Piece(Brushes.White, canvas,X,Y, Grid));
            Console.WriteLine(Startpunkt);
        }

        public void update()
        {
            for (int x = Tail.Count - 1; x > 0; x--)
            {
                Tail[x].Pos = Tail[x - 1].Pos;
               
            }
            Tail[0].Pos.X = LimitToRange(Tail[0].Pos.X += SpeedX * Grid, 0, Convert.ToInt32(canvas.VisibleClipBounds.Width) - Grid);
            Tail[0].Pos.Y = LimitToRange(Tail[0].Pos.Y += SpeedY * Grid, 0, Convert.ToInt32(canvas.VisibleClipBounds.Height) - Grid);
            //Console.WriteLine("{0},{1}",Tail[0].PosX, Tail[0].PosY);
        }

        public void eat()
        {
            Random rnd = new Random();
            Brush b = new SolidBrush(Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255)));
            Tail.Add(new Piece(b, canvas, Tail[Tail.Count-1].Pos.X, Tail[Tail.Count-1].Pos.Y, Grid));
        }

        public void check()
        {
            for(int x = Tail.Count - 1; x > 1; x--)
            {
                if (Tail[x].Pos.X == Tail[0].Pos.X && Tail[x].Pos.Y == Tail[0].Pos.Y)
                {
                    eaten=true; 
                }            
            }
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
                p.show();
            }
        }

        int LimitToRange(int value, int inclusiveMinimum, int inlusiveMaximum)
        {
            if (value >= inclusiveMinimum)
            {
                if (value <= inlusiveMaximum)
                {
                    return value;
                }
                wall = true;
                return 0;
            }
            wall = true;
            return Convert.ToInt32(canvas.VisibleClipBounds.Height-Grid);
        }
    }
}
