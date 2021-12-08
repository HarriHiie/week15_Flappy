namespace FlappyBird
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PipeTop = new System.Windows.Forms.PictureBox();
            this.PipeBottom = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Bird = new System.Windows.Forms.PictureBox();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).BeginInit();
            this.SuspendLayout();
            // 
            // PipeTop
            // 
            this.PipeTop.Image = ((System.Drawing.Image)(resources.GetObject("PipeTop.Image")));
            this.PipeTop.Location = new System.Drawing.Point(226, 0);
            this.PipeTop.Name = "PipeTop";
            this.PipeTop.Size = new System.Drawing.Size(110, 182);
            this.PipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeTop.TabIndex = 0;
            this.PipeTop.TabStop = false;
            // 
            // PipeBottom
            // 
            this.PipeBottom.Image = ((System.Drawing.Image)(resources.GetObject("PipeBottom.Image")));
            this.PipeBottom.Location = new System.Drawing.Point(226, 345);
            this.PipeBottom.Name = "PipeBottom";
            this.PipeBottom.Size = new System.Drawing.Size(110, 188);
            this.PipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeBottom.TabIndex = 1;
            this.PipeBottom.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 451);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(429, 82);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // Bird
            // 
            this.Bird.Image = ((System.Drawing.Image)(resources.GetObject("Bird.Image")));
            this.Bird.Location = new System.Drawing.Point(34, 237);
            this.Bird.Name = "Bird";
            this.Bird.Size = new System.Drawing.Size(90, 69);
            this.Bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bird.TabIndex = 3;
            this.Bird.TabStop = false;
            this.Bird.Click += new System.EventHandler(this.Bird_Click);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("SimSun", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.Location = new System.Drawing.Point(12, 27);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(177, 37);
            this.ScoreLabel.TabIndex = 4;
            this.ScoreLabel.Text = "Score: 0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer_1Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(428, 534);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.Bird);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.PipeBottom);
            this.Controls.Add(this.PipeTop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.PipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PipeTop;
        private System.Windows.Forms.PictureBox PipeBottom;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox Bird;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Timer timer1;
    }
}

