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
        public int Richtung;
        Brush color;
        public bool moved=false;

        public Schlange(Graphics c,int Grid,int X, int Y,int Richtung,Brush color)
        {
            this.color = color;
            this.Richtung = Richtung;
            canvas = c;
            this.Grid = Grid;
            Tail = new List<Piece>();
            Tail.Add(new Piece(color, canvas,X,Y, Grid));
            Console.WriteLine(Startpunkt);
            switch (Richtung)
            {
                case 1: SpeedX = 0;SpeedY = -1;break; //unten
                case 2: SpeedX = 1;SpeedY = 0;break; //rechts
                case 3:SpeedX = 0;SpeedY = 1;break; //oben
                case 4:SpeedX = -1;SpeedY = 0;break; //links
            }
        }

        public void update()
        {
            for (int x = Tail.Count - 1; x > 0; x--)
            {
                Tail[x].Pos = Tail[x - 1].Pos;
            }
            Tail[0].Pos.X = LimitToRange(Tail[0].Pos.X += SpeedX * Grid, 0, Convert.ToInt32(canvas.VisibleClipBounds.Width) - Grid);
            Tail[0].Pos.Y = LimitToRange(Tail[0].Pos.Y += SpeedY * Grid, 0, Convert.ToInt32(canvas.VisibleClipBounds.Height) - Grid);
            this.moved = false;
        }

        public void eat()
        {
            Tail.Add(new Piece(color, canvas, Tail[Tail.Count-1].Pos.X, Tail[Tail.Count-1].Pos.Y, Grid));
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

        public void richtung(int richtung)
        {
            this.moved = true;
            this.Richtung = richtung;
            switch (Richtung)
            {
                case 1: SpeedX = 0; SpeedY = -1; break;
                case 2: SpeedX = 1; SpeedY = 0; break;
                case 3: SpeedX = 0; SpeedY = 1; break;
                case 4: SpeedX = -1; SpeedY = 0; break;
            }
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
