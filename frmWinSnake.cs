using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinSnake
{
    public partial class frmSnake : Form
    {
        Game Game;
        
        Graphics canvas;
        int Grid = 25;
        
        
        public frmSnake()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            canvas = pnlCanvas.CreateGraphics();
            Game = new Game(canvas, Grid);
        }

        


        private void frmSnake_KeyDown(object sender, KeyEventArgs e)
        {
            Game.Key = e;
        }

 

        private void timer1_Tick(object sender, EventArgs e)
        {
            Game.Tick();
        }
        
    }
}
