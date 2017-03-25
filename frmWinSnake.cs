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
            pbCanvas.Height = 302;
            pbCanvas.Width = 302;
            pbCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {   
        }

        private void frmSnake_KeyDown(object sender, KeyEventArgs e)
        {
            Game.Controls(sender, e);
        }
        

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            rbtnEinSpieler.Enabled = false;
            rbtnZweiSpieler.Enabled = false;


            Console.WriteLine("Zeichenfläche(Breite:{0},Höhe:{1})", pbCanvas.Width, pbCanvas.Height);
            canvas = pbCanvas.CreateGraphics();
            if (rbtnEinSpieler.Checked == true) Game = new Game(canvas, Grid,1);
            else Game = new Game(canvas, Grid, 2);

            Tick.Start();
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
