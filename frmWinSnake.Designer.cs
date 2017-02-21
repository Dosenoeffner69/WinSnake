namespace WinSnake
{
    partial class frmSnake
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSnake));
            this.pnlCanvas = new System.Windows.Forms.Panel();
            this.Move = new System.Windows.Forms.Timer(this.components);
            this.Draw = new System.Windows.Forms.Timer(this.components);
            this.Second = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pnlCanvas
            // 
            resources.ApplyResources(this.pnlCanvas, "pnlCanvas");
            this.pnlCanvas.Name = "pnlCanvas";
            this.pnlCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCanvas_Paint);
            // 
            // Move
            // 
            this.Move.Enabled = true;
            this.Move.Interval = 250;
            this.Move.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Draw
            // 
            this.Draw.Enabled = true;
            this.Draw.Interval = 1;
            this.Draw.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Second
            // 
            this.Second.Enabled = true;
            this.Second.Interval = 1000;
            this.Second.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // frmSnake
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlCanvas);
            this.Name = "frmSnake";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSnake_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCanvas;
        private System.Windows.Forms.Timer Move;
        private System.Windows.Forms.Timer Draw;
        private System.Windows.Forms.Timer Second;
    }
}

