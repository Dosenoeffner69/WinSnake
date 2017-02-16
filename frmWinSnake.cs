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
        Schlange S;
        Graphics canvas;
        int Grid = 25;
        int frame = 0;
        int FPS;
        
        public frmSnake()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            canvas = pnlCanvas.CreateGraphics();
            S = new Schlange(canvas,Grid);
        }

        public void show()
        {
            canvas.FillRectangle(Brushes.Black, 0, 0, pnlCanvas.Width, pnlCanvas.Height);
            S.show();
        }



        private void frmSnake_KeyDown(object sender, KeyEventArgs e)
        {
           if (e.KeyCode == Keys.Up)
            {
                S.richtung(0, -1);
            }
            if (e.KeyCode == Keys.Down)
            {
                S.richtung(0, 1);
            }
            if (e.KeyCode == Keys.Left)
            {
                S.richtung(-1, 0);
            }
            if (e.KeyCode == Keys.Right)
            {
                S.richtung(1, 0);
            }

            if (e.KeyCode == Keys.P)
            {
                S.eat();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            S.eat();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            S.update();
        }
        
        private void timer2_Tick(object sender, EventArgs e)
        {
            show();
            frame++;
            this.Text = "FPS: " + (Convert.ToString(FPS)) + " Teile: " + Convert.ToString(S.Tail.Count);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            FPS = frame;
            frame = 0;
        }
    }
}
