using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinSnake
{
    class Schlange
    {

        int SpeedX;
        int SpeedY;
        Graphics canvas; //panelbox-zeichenfläche
        int Grid; //Größe
        public List<Piece> Tail = new List<Piece>(); //Snake-pieces
        public bool Bordercrash = false;

        public Schlange(Graphics c,int Grid)
        {
            SpeedX = 0;
            SpeedY = 0;
            canvas = c;
            this.Grid = Grid; //this. = Das Grid aus der Klasse
            Tail.Add(new Piece(Brushes.White, canvas, 0, 0, Grid,true)); //Erstes Rechteck anzeigen
        }

        public void update()
        {
            for(int x = Tail.Count - 1; x > 0; x--)
            {
                Tail[x].PosX = Tail[x - 1].PosX; //Wertübergabe der Position X und Y
                Tail[x].PosY = Tail[x - 1].PosY;
                Tail[x].aktiv = true;
            }
    
            Tail[0].PosX= LimitToRange(Tail[0].PosX += SpeedX * Grid, 0, Convert.ToInt32(canvas.VisibleClipBounds.Width) - Grid); //Grenzüberschreitung
            Tail[0].PosY= LimitToRange(Tail[0].PosY += SpeedY * Grid, 0, Convert.ToInt32(canvas.VisibleClipBounds.Height) - Grid);
        }

        public bool eat(int PositionX, int PositionY) 
        {

            if(Tail[0].PosX == PositionX && Tail[0].PosY == PositionY)
            {
                Random rnd = new Random();
                Brush b = new SolidBrush(Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255))); //Zufälige Farbe
                Tail.Add(new Piece(b, canvas, Tail[Tail.Count - 1].PosX, Tail[Tail.Count - 1].PosY, Grid, false));

                return true;
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

                Bordercrash = true;
                return 0;               
            }
            Bordercrash = true;
            return Convert.ToInt32(canvas.VisibleClipBounds.Height - Grid);
        }
        

    }
}
