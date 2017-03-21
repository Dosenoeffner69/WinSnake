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
        int Grid = 15;
        
        
        public frmSnake()
        {
            InitializeComponent();
            int X = pnlCanvas.Width;
            int Y = pnlCanvas.Height;

            int Xoff = pnlCanvas.Width % Grid;
            int Yoff = pnlCanvas.Height % Grid;

            pnlCanvas.Height = (X-Xoff);
            pnlCanvas.Width =(Y-Yoff);
            pnlCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            
            Console.WriteLine("Zeichenfläche(Breite:{0},Höhe:{1})",pnlCanvas.Width,pnlCanvas.Height);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            canvas = pnlCanvas.CreateGraphics();
            // Console.WriteLine(canvas.VisibleClipBounds);
            Game = new Game(canvas, Grid);
            Tick.Start();
        }

        private void frmSnake_KeyDown(object sender, KeyEventArgs e)
        {
            Game.Controls(sender, e);
        }
        

        private void btnStart_Click(object sender, EventArgs e)
        {
            //canvas = pnlCanvas.CreateGraphics();
            //// Console.WriteLine(canvas.VisibleClipBounds);
            //Game = new Game(canvas, Grid);
            //Tick.Start();
        }

        private void Tick_Tick(object sender, EventArgs e)
        {
            Game.Tick();
        }

        private void frmSnake_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
         //   if (e.KeyCode == Keys.F) MessageBox.Show("dsg");
        }
    }
}
