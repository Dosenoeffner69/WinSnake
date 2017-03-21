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
            this.btnStart = new System.Windows.Forms.Button();
            this.Tick = new System.Windows.Forms.Timer(this.components);
            this.btnStop = new System.Windows.Forms.Button();
            this.rbtnEinSpieler = new System.Windows.Forms.RadioButton();
            this.rbtnZweiSpieler = new System.Windows.Forms.RadioButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.SuspendLayout();
            // 
            // pnlCanvas
            // 
            resources.ApplyResources(this.pnlCanvas, "pnlCanvas");
            this.pnlCanvas.Name = "pnlCanvas";
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
            this.Tick.Tick += new System.EventHandler(this.Tick_Tick);
            // 
            // btnStop
            // 
            resources.ApplyResources(this.btnStop, "btnStop");
            this.btnStop.Name = "btnStop";
            this.btnStop.TabStop = false;
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // rbtnEinSpieler
            // 
            resources.ApplyResources(this.rbtnEinSpieler, "rbtnEinSpieler");
            this.rbtnEinSpieler.Checked = true;
            this.rbtnEinSpieler.Name = "rbtnEinSpieler";
            this.rbtnEinSpieler.TabStop = true;
            this.rbtnEinSpieler.UseVisualStyleBackColor = true;
            // 
            // rbtnZweiSpieler
            // 
            resources.ApplyResources(this.rbtnZweiSpieler, "rbtnZweiSpieler");
            this.rbtnZweiSpieler.Name = "rbtnZweiSpieler";
            this.rbtnZweiSpieler.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Name = "toolStrip1";
            // 
            // frmSnake
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pnlCanvas);
            this.Controls.Add(this.rbtnZweiSpieler);
            this.Controls.Add(this.rbtnEinSpieler);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.KeyPreview = true;
            this.Name = "frmSnake";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSnake_KeyDown);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmSnake_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCanvas;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer Tick;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.RadioButton rbtnEinSpieler;
        private System.Windows.Forms.RadioButton rbtnZweiSpieler;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}

