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
        List<Schlange> listSnakes = new List<Schlange>();
        Piece Essen; 
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
            listSnakes.Add(new Schlange(canvas, Grid)); //Erstellt oben links das erste Snakepiece
            Punktgenerieren();
        }

        public void show()
        {
            canvas.FillRectangle(Brushes.Black, 0, 0, pnlCanvas.Width, pnlCanvas.Height);
            foreach(Schlange Snake in listSnakes)
            {

                Snake.show();

            }
            Essen.show();
        }

        private void frmSnake_KeyDown(object sender, KeyEventArgs e)
        {
           if (e.KeyCode == Keys.Up)
            {
                listSnakes[0].richtung(0, -1);
            }
            if (e.KeyCode == Keys.Down)
            {
                listSnakes[0].richtung(0, 1);
            }
            if (e.KeyCode == Keys.Left)
            {
                listSnakes[0].richtung(-1, 0);
            }
            if (e.KeyCode == Keys.Right)
            {
                listSnakes[0].richtung(1, 0);
            }

            if (e.KeyCode == Keys.P)
            {
                listSnakes[0].eat();
            }

        }

       
        


        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach(Schlange Snake in listSnakes)
            {
                if (Snake.Bordercrash == false) Snake.update();

                /*else
                {
                    Move.Enabled = false;
                    MessageBox.Show("Test");        Grenzenüberschreitung - Funktoniert noch nicht richtig
                }*/
            }
          

        }
        
        private void timer2_Tick(object sender, EventArgs e)
        {
            show();
            frame++;
            this.Text = "FPS: " + (Convert.ToString(FPS)) + " Teile: " + Convert.ToString(listSnakes[0].Tail.Count);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            FPS = frame;
            frame = 0;
        }

        private void pnlCanvas_Paint(object sender, PaintEventArgs e)
        {

        }

        public void Punktgenerieren()
        {
            Random tmp = new Random();
            Random rnd = new Random();
            Brush b = new SolidBrush(Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255))); //Zufälige Farbe

            //Tail.Add(new Piece(b, canvas, Tail[Tail.Count - 1].PosX, Tail[Tail.Count - 1].PosY, Grid, false));
            Essen = new Piece(b, canvas, 25*tmp.Next(0, pnlCanvas.Width / 25-1),25*tmp.Next(0,pnlCanvas.Height /25-1),25,true);
        }

        private void Check()
        {

        }
    }
}
