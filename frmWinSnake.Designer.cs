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
            this.btnStart = new System.Windows.Forms.Button();
            this.Tick = new System.Windows.Forms.Timer(this.components);
            this.rbtnEinSpieler = new System.Windows.Forms.RadioButton();
            this.rbtnZweiSpieler = new System.Windows.Forms.RadioButton();
            this.pbCanvas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            resources.ApplyResources(this.btnStart, "btnStart");
            this.btnStart.Name = "btnStart";
            this.btnStart.TabStop = false;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Tick
            // 
            this.Tick.Interval = 250;
            this.Tick.Tick += new System.EventHandler(this.Tick_Tick);
            // 
            // rbtnEinSpieler
            // 
            resources.ApplyResources(this.rbtnEinSpieler, "rbtnEinSpieler");
            this.rbtnEinSpieler.Checked = true;
            this.rbtnEinSpieler.Name = "rbtnEinSpieler";
            this.rbtnEinSpieler.TabStop = true;
            this.rbtnEinSpieler.UseVisualStyleBackColor = false;
            // 
            // rbtnZweiSpieler
            // 
            resources.ApplyResources(this.rbtnZweiSpieler, "rbtnZweiSpieler");
            this.rbtnZweiSpieler.Name = "rbtnZweiSpieler";
            this.rbtnZweiSpieler.UseVisualStyleBackColor = false;
            // 
            // pbCanvas
            // 
            resources.ApplyResources(this.pbCanvas, "pbCanvas");
            this.pbCanvas.Name = "pbCanvas";
            this.pbCanvas.TabStop = false;
            // 
            // frmSnake
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbCanvas);
            this.Controls.Add(this.rbtnZweiSpieler);
            this.Controls.Add(this.rbtnEinSpieler);
            this.Controls.Add(this.btnStart);
            this.KeyPreview = true;
            this.Name = "frmSnake";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSnake_KeyDown);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmSnake_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer Tick;
        private System.Windows.Forms.PictureBox pbCanvas;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.RadioButton rbtnEinSpieler;
        private System.Windows.Forms.RadioButton rbtnZweiSpieler;
    }
}

