namespace Pelotas_Rebotan
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.limit1 = new System.Windows.Forms.PictureBox();
            this.limit2 = new System.Windows.Forms.PictureBox();
            this.ball2 = new System.Windows.Forms.PictureBox();
            this.ball3 = new System.Windows.Forms.PictureBox();
            this.ball4 = new System.Windows.Forms.PictureBox();
            this.ball5 = new System.Windows.Forms.PictureBox();
            this.ball1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.limit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.limit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball1)).BeginInit();
            this.SuspendLayout();
            // 
            // limit1
            // 
            this.limit1.Location = new System.Drawing.Point(-5, 20);
            this.limit1.Name = "limit1";
            this.limit1.Size = new System.Drawing.Size(10, 240);
            this.limit1.TabIndex = 0;
            this.limit1.TabStop = false;
            // 
            // limit2
            // 
            this.limit2.Location = new System.Drawing.Point(565, 12);
            this.limit2.Name = "limit2";
            this.limit2.Size = new System.Drawing.Size(10, 240);
            this.limit2.TabIndex = 1;
            this.limit2.TabStop = false;
            // 
            // ball2
            // 
            this.ball2.Image = global::Pelotas_Rebotan.Properties.Resources.rolling_football_ball_gif;
            this.ball2.Location = new System.Drawing.Point(12, 88);
            this.ball2.Name = "ball2";
            this.ball2.Size = new System.Drawing.Size(42, 40);
            this.ball2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball2.TabIndex = 2;
            this.ball2.TabStop = false;
            this.ball2.Tag = "ball";
            // 
            // ball3
            // 
            this.ball3.Image = global::Pelotas_Rebotan.Properties.Resources.rolling_football_ball_gif;
            this.ball3.Location = new System.Drawing.Point(67, 220);
            this.ball3.Name = "ball3";
            this.ball3.Size = new System.Drawing.Size(42, 40);
            this.ball3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball3.TabIndex = 3;
            this.ball3.TabStop = false;
            this.ball3.Tag = "ball";
            // 
            // ball4
            // 
            this.ball4.Image = global::Pelotas_Rebotan.Properties.Resources.rolling_football_ball_gif;
            this.ball4.Location = new System.Drawing.Point(230, 118);
            this.ball4.Name = "ball4";
            this.ball4.Size = new System.Drawing.Size(24, 29);
            this.ball4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball4.TabIndex = 4;
            this.ball4.TabStop = false;
            this.ball4.Tag = "ball";
            // 
            // ball5
            // 
            this.ball5.Image = global::Pelotas_Rebotan.Properties.Resources.rolling_football_ball_gif;
            this.ball5.Location = new System.Drawing.Point(253, 227);
            this.ball5.Name = "ball5";
            this.ball5.Size = new System.Drawing.Size(32, 33);
            this.ball5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball5.TabIndex = 5;
            this.ball5.TabStop = false;
            this.ball5.Tag = "ball";
            // 
            // ball1
            // 
            this.ball1.Image = global::Pelotas_Rebotan.Properties.Resources.rolling_football_ball_gif;
            this.ball1.Location = new System.Drawing.Point(253, 204);
            this.ball1.Name = "ball1";
            this.ball1.Size = new System.Drawing.Size(17, 17);
            this.ball1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball1.TabIndex = 6;
            this.ball1.TabStop = false;
            this.ball1.Tag = "ball";
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(259, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Bouncing";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 272);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ball1);
            this.Controls.Add(this.ball5);
            this.Controls.Add(this.ball4);
            this.Controls.Add(this.ball3);
            this.Controls.Add(this.ball2);
            this.Controls.Add(this.limit2);
            this.Controls.Add(this.limit1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.limit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.limit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox limit1;
        private PictureBox limit2;
        private PictureBox ball2;
        private PictureBox ball3;
        private PictureBox ball4;
        private PictureBox ball5;
        private PictureBox ball1;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
    }
}