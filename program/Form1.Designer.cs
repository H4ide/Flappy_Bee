using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace Flappy_Bird_windows_form
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
            this.scoreText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.pipeTop2 = new System.Windows.Forms.PictureBox();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.bird = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipeBottom = new System.Windows.Forms.PictureBox();
            this.pipeBottom2 = new System.Windows.Forms.PictureBox();
            this.heart1 = new System.Windows.Forms.PictureBox();
            this.heart2 = new System.Windows.Forms.PictureBox();
            this.heart3 = new System.Windows.Forms.PictureBox();
            this.GameOverLabel = new System.Windows.Forms.Label();
            this.Bird_tick = new System.Windows.Forms.Timer(this.components);
            this.roof = new System.Windows.Forms.PictureBox();
            this.MaxScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roof)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.scoreText.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.ForeColor = System.Drawing.Color.Transparent;
            this.scoreText.Location = new System.Drawing.Point(0, 621);
            this.scoreText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(142, 35);
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = "Score: 0 ";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 16;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // pipeTop2
            // 
            this.pipeTop2.BackColor = System.Drawing.Color.Transparent;
            this.pipeTop2.Image = global::Flappy_Bird_windows_form.Properties.Resources.pipedown;
            this.pipeTop2.Location = new System.Drawing.Point(750, -130);
            this.pipeTop2.Margin = new System.Windows.Forms.Padding(2);
            this.pipeTop2.Name = "pipeTop2";
            this.pipeTop2.Size = new System.Drawing.Size(100, 488);
            this.pipeTop2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop2.TabIndex = 6;
            this.pipeTop2.TabStop = false;
            // 
            // pipeTop
            // 
            this.pipeTop.BackColor = System.Drawing.Color.Transparent;
            this.pipeTop.Image = global::Flappy_Bird_windows_form.Properties.Resources.pipedown;
            this.pipeTop.Location = new System.Drawing.Point(250, -230);
            this.pipeTop.Margin = new System.Windows.Forms.Padding(2);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(100, 488);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop.TabIndex = 0;
            this.pipeTop.TabStop = false;
            // 
            // bird
            // 
            this.bird.BackColor = System.Drawing.Color.Transparent;
            this.bird.Image = ((System.Drawing.Image)(resources.GetObject("bird.Image")));
            this.bird.Location = new System.Drawing.Point(37, 292);
            this.bird.Margin = new System.Windows.Forms.Padding(2);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(57, 46);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 1;
            this.bird.TabStop = false;
            // 
            // ground
            // 
            this.ground.BackColor = System.Drawing.Color.Transparent;
            this.ground.Image = global::Flappy_Bird_windows_form.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-4, 607);
            this.ground.Margin = new System.Windows.Forms.Padding(2);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(592, 58);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // pipeBottom
            // 
            this.pipeBottom.BackColor = System.Drawing.Color.Transparent;
            this.pipeBottom.Image = global::Flappy_Bird_windows_form.Properties.Resources.pipe;
            this.pipeBottom.Location = new System.Drawing.Point(250, 400);
            this.pipeBottom.Margin = new System.Windows.Forms.Padding(2);
            this.pipeBottom.Name = "pipeBottom";
            this.pipeBottom.Size = new System.Drawing.Size(100, 488);
            this.pipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom.TabIndex = 2;
            this.pipeBottom.TabStop = false;
            // 
            // pipeBottom2
            // 
            this.pipeBottom2.BackColor = System.Drawing.Color.Transparent;
            this.pipeBottom2.Image = global::Flappy_Bird_windows_form.Properties.Resources.pipe;
            this.pipeBottom2.Location = new System.Drawing.Point(750, 500);
            this.pipeBottom2.Margin = new System.Windows.Forms.Padding(2);
            this.pipeBottom2.Name = "pipeBottom2";
            this.pipeBottom2.Size = new System.Drawing.Size(100, 488);
            this.pipeBottom2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom2.TabIndex = 5;
            this.pipeBottom2.TabStop = false;
            // 
            // heart1
            // 
            this.heart1.Image = global::Flappy_Bird_windows_form.Properties.Resources.heart;
            this.heart1.Location = new System.Drawing.Point(458, 621);
            this.heart1.Name = "heart1";
            this.heart1.Size = new System.Drawing.Size(34, 31);
            this.heart1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heart1.TabIndex = 7;
            this.heart1.TabStop = false;
            // 
            // heart2
            // 
            this.heart2.Image = global::Flappy_Bird_windows_form.Properties.Resources.heart;
            this.heart2.Location = new System.Drawing.Point(498, 621);
            this.heart2.Name = "heart2";
            this.heart2.Size = new System.Drawing.Size(34, 31);
            this.heart2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heart2.TabIndex = 8;
            this.heart2.TabStop = false;
            // 
            // heart3
            // 
            this.heart3.Image = global::Flappy_Bird_windows_form.Properties.Resources.heart;
            this.heart3.Location = new System.Drawing.Point(538, 621);
            this.heart3.Name = "heart3";
            this.heart3.Size = new System.Drawing.Size(34, 31);
            this.heart3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heart3.TabIndex = 9;
            this.heart3.TabStop = false;
            // 
            // GameOverLabel
            // 
            this.GameOverLabel.AutoSize = true;
            this.GameOverLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.GameOverLabel.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameOverLabel.ForeColor = System.Drawing.Color.Black;
            this.GameOverLabel.Location = new System.Drawing.Point(130, 47);
            this.GameOverLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GameOverLabel.Name = "GameOverLabel";
            this.GameOverLabel.Size = new System.Drawing.Size(344, 70);
            this.GameOverLabel.TabIndex = 10;
            this.GameOverLabel.Text = "         Game Over\r\nPress Space to Restart";
            this.GameOverLabel.Visible = false;
            // 
            // Bird_tick
            // 
            this.Bird_tick.Enabled = true;
            this.Bird_tick.Interval = 16;
            this.Bird_tick.Tick += new System.EventHandler(this.BirdTick);
            // 
            // roof
            // 
            this.roof.Location = new System.Drawing.Point(0, -20);
            this.roof.Name = "roof";
            this.roof.Size = new System.Drawing.Size(200, 20);
            this.roof.TabIndex = 11;
            this.roof.TabStop = false;
            // 
            // MaxScore
            // 
            this.MaxScore.AutoSize = true;
            this.MaxScore.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.MaxScore.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxScore.ForeColor = System.Drawing.Color.Transparent;
            this.MaxScore.Location = new System.Drawing.Point(219, 621);
            this.MaxScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MaxScore.Name = "MaxScore";
            this.MaxScore.Size = new System.Drawing.Size(201, 35);
            this.MaxScore.TabIndex = 12;
            this.MaxScore.Text = "MaxScore: 0 ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(584, 661);
            this.Controls.Add(this.MaxScore);
            this.Controls.Add(this.roof);
            this.Controls.Add(this.GameOverLabel);
            this.Controls.Add(this.heart3);
            this.Controls.Add(this.heart2);
            this.Controls.Add(this.heart1);
            this.Controls.Add(this.pipeTop2);
            this.Controls.Add(this.pipeTop);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipeBottom);
            this.Controls.Add(this.pipeBottom2);
            this.Controls.Add(this.bird);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(600, 700);
            this.MinimumSize = new System.Drawing.Size(600, 700);
            this.Name = "Form1";
            this.Text = "Flappy Bee game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyisdown);
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roof)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox pipeBottom;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox pipeBottom2;
        private System.Windows.Forms.PictureBox pipeTop2;
        private PictureBox heart1;
        private PictureBox heart2;
        private PictureBox heart3;
        private System.Windows.Forms.Label GameOverLabel;
        private Timer Bird_tick;
        private PictureBox roof;
        private System.Windows.Forms.Label MaxScore;
    }
}

