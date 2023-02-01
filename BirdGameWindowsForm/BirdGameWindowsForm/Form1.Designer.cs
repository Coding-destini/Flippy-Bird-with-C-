namespace BirdGameWindowsForm
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
            this.Score = new System.Windows.Forms.Label();
            this.Gametimer = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.Coin1 = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.PoleUp = new System.Windows.Forms.PictureBox();
            this.PoleDown = new System.Windows.Forms.PictureBox();
            this.Bird = new System.Windows.Forms.PictureBox();
            this.Coin2 = new System.Windows.Forms.PictureBox();
            this.Coin5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Coin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PoleUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PoleDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin5)).BeginInit();
            this.SuspendLayout();
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.BackColor = System.Drawing.Color.Orange;
            this.Score.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(224, 502);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(109, 31);
            this.Score.TabIndex = 4;
            this.Score.Text = "Score: 0";
            // 
            // Gametimer
            // 
            this.Gametimer.Enabled = true;
            this.Gametimer.Interval = 20;
            this.Gametimer.Tick += new System.EventHandler(this.gamesTimerEvent);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Coin1
            // 
            this.Coin1.Image = global::BirdGameWindowsForm.Properties.Resources._1Coin;
            this.Coin1.Location = new System.Drawing.Point(443, 350);
            this.Coin1.Name = "Coin1";
            this.Coin1.Size = new System.Drawing.Size(32, 34);
            this.Coin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Coin1.TabIndex = 5;
            this.Coin1.TabStop = false;
            // 
            // ground
            // 
            this.ground.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ground.Image = global::BirdGameWindowsForm.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-12, 463);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(883, 117);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 0;
            this.ground.TabStop = false;
            // 
            // PoleUp
            // 
            this.PoleUp.Image = global::BirdGameWindowsForm.Properties.Resources.pipedown;
            this.PoleUp.Location = new System.Drawing.Point(431, -32);
            this.PoleUp.Name = "PoleUp";
            this.PoleUp.Size = new System.Drawing.Size(107, 218);
            this.PoleUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PoleUp.TabIndex = 3;
            this.PoleUp.TabStop = false;
            // 
            // PoleDown
            // 
            this.PoleDown.Image = global::BirdGameWindowsForm.Properties.Resources.pipe;
            this.PoleDown.Location = new System.Drawing.Point(213, 295);
            this.PoleDown.Name = "PoleDown";
            this.PoleDown.Size = new System.Drawing.Size(107, 204);
            this.PoleDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PoleDown.TabIndex = 2;
            this.PoleDown.TabStop = false;
            this.PoleDown.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Bird
            // 
            this.Bird.Image = global::BirdGameWindowsForm.Properties.Resources.bird;
            this.Bird.Location = new System.Drawing.Point(38, 175);
            this.Bird.Name = "Bird";
            this.Bird.Size = new System.Drawing.Size(59, 51);
            this.Bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bird.TabIndex = 1;
            this.Bird.TabStop = false;
            this.Bird.Click += new System.EventHandler(this.Bird_Click);
            // 
            // Coin2
            // 
            this.Coin2.Image = global::BirdGameWindowsForm.Properties.Resources._1Coin;
            this.Coin2.Location = new System.Drawing.Point(287, 204);
            this.Coin2.Name = "Coin2";
            this.Coin2.Size = new System.Drawing.Size(33, 36);
            this.Coin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Coin2.TabIndex = 6;
            this.Coin2.TabStop = false;
            // 
            // Coin5
            // 
            this.Coin5.Image = global::BirdGameWindowsForm.Properties.Resources._5Coins;
            this.Coin5.Location = new System.Drawing.Point(642, 204);
            this.Coin5.Name = "Coin5";
            this.Coin5.Size = new System.Drawing.Size(43, 43);
            this.Coin5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Coin5.TabIndex = 7;
            this.Coin5.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(843, 542);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.PoleUp);
            this.Controls.Add(this.PoleDown);
            this.Controls.Add(this.Bird);
            this.Controls.Add(this.Coin1);
            this.Controls.Add(this.Coin2);
            this.Controls.Add(this.Coin5);
            this.Name = "Form1";
            this.Text = "Happy Bird Game - Akash Shah";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisUp);
            ((System.ComponentModel.ISupportInitialize)(this.Coin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PoleUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PoleDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox Bird;
        private System.Windows.Forms.PictureBox PoleDown;
        private System.Windows.Forms.PictureBox PoleUp;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Timer Gametimer;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.PictureBox Coin1;
        private System.Windows.Forms.PictureBox Coin2;
        private System.Windows.Forms.PictureBox Coin5;
    }
}

