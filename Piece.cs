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
        public Point Pos;
        public int grid;
        Brush color;
        Graphics canvas;
        
        public Piece(Brush color,Graphics canvas,int x,int y,int grid)
        {
            this.color = color;
            this.canvas = canvas;
            this.grid = grid;
            this.Pos.X = x;
            this.Pos.Y = y;
        }
        
        public void show()
        {
            canvas.FillRectangle(color, Pos.X, Pos.Y, grid, grid);
            canvas.DrawRectangle(Pens.Black, Pos.X, Pos.Y, grid, grid);
        }
    }
}
