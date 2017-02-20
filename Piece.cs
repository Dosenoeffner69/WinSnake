using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using WinSnake;

namespace WinSnake
{
    class Piece
    {
        public int PosX, PosY,grid;
        Brush color;
        Graphics canvas;
        public bool aktiv;

        public Piece(Brush color,Graphics canvas,int x,int y,int grid,bool aktiv)
        {
            this.color = color;
            this.canvas = canvas;
            this.grid = grid;
            this.PosX = x;
            this.PosY = y;
            this.aktiv = aktiv; 
        }
        
        public void show()
        {
            canvas.FillRectangle(color, PosX, PosY, grid, grid);
        }
    }
}
