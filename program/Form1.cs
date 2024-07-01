using System; 
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Flappy_Bird_windows_form
{

    public partial class Form1 : Form
    {
       
        Random random = new Random();
        int pipeSpeed = 8;
        bool game_over = true;
        int hearts = 3;

        Image layer_1 = Properties.Resources.sprite_1;
        Image layer_2 = Properties.Resources.sprite_2;
        Image layer_3 = Properties.Resources.sprite_3;

        Layer layer1 = new Layer(0, 600, 2);
        Layer layer2 = new Layer(0, 600, 4);
        Layer layer3 = new Layer(0, 600, 8);
        ScoreManager Scores = new ScoreManager();

        Stopwatch stopwatch = new Stopwatch();
        long elapsedMilliseconds = 0;

        float verticalVelocity = 0f;

        int angle = 45;

        Image flipImageUp = Properties.Resources.bird;
        Image flipImageDown = Properties.Resources.bird;


        public Form1()
        {
            flipImageUp = RotateImage(flipImageUp, angle);
            flipImageDown = RotateImage(flipImageDown, -angle);
            InitializeComponent();
            stopwatch.Start();
            this.DoubleBuffered = true;
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            if (game_over == false)
            {

                pipeBottom.Left -= pipeSpeed;
                pipeTop.Left -= pipeSpeed;
                pipeBottom2.Left -= pipeSpeed;
                pipeTop2.Left -= pipeSpeed;
                scoreText.Text = "Score: " + Scores.Score;
                MaxScore.Text = "Max Score:" + Scores.Max_score;
                layer1.SetLayerPosition();
                layer2.SetLayerPosition();
                layer3.SetLayerPosition();
                Invalidate();
                if (pipeBottom.Left <= -100)
                {

                    pipeBottom.Left = 900;
                    pipeTop.Left = 900;
                    int randomNumber = random.Next(220, 420);
                    pipeBottom.Top = randomNumber;
                    pipeTop.Top = randomNumber - 630;

                    Scores.Score++;
                }
                if (pipeBottom2.Left <= -100)
                {
                    int randomNumber = random.Next(220, 420);
                    pipeBottom2.Left = 900;
                    pipeTop2.Left = 900;
                    pipeBottom2.Top = randomNumber;
                    pipeTop2.Top = randomNumber - 630;
                    Scores.Score++;
                }


                
                if (Scores.Score == 5)
                {
                    layer1.Speed = 4;
                    layer2.Speed = 8;
                    layer3.Speed = 16;
                    pipeSpeed = 16;
                }
            }
            
        }

        private void BirdTick(object sender, EventArgs e)
        {
            if (game_over == false)
            {

                if(Intersection(bird,pipeBottom) || 
                    Intersection(bird, pipeBottom2) || 
                    Intersection(bird, pipeTop) ||
                    Intersection(bird, pipeTop2)
                    )
                {
                    bird.Top = MoveBirdBetweenPipes(bird, pipeBottom, pipeTop);
                    bird.Top = MoveBirdBetweenPipes(bird, pipeBottom2, pipeTop2);
                    endgame();
                }

                else if (bird.Top > 0 && bird.Bottom < 607)
                {
                    float gravity = 0.9f;
                    verticalVelocity += gravity;
                    bird.Top += Math.Min((int)verticalVelocity,10);
                }
                else
                {
                    endgame();
                    bird.Top = 300;   
                }     
                bird.Image = verticalVelocity > 0 ? flipImageUp : flipImageDown;
            }
 
        }
        // ROTATE IMAGE BY ANGLE. MADE BY CHATGPT
        public static Image RotateImage(Image image, float angle)
        {
            Bitmap rotatedImage = new Bitmap(image.Width, image.Height);
            rotatedImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (Graphics g = Graphics.FromImage(rotatedImage))
            {

                g.TranslateTransform(image.Width / 2, image.Height / 2);
                g.RotateTransform(angle);
                g.TranslateTransform(-image.Width / 2, -image.Height / 2);

                g.DrawImage(image, new Point(0, 0));
            }

            return rotatedImage;
        }
        private bool Intersection(PictureBox bird, PictureBox obj)
        {
            if (bird.Bounds.IntersectsWith(obj.Bounds))
            {
                return true;
            }
            return false;

        }
        private int MoveBirdBetweenPipes(PictureBox bird, PictureBox pipeBottom, PictureBox pipeTop)
        {
            if((pipeTop.Left <= bird.Right && bird.Right <= pipeTop.Left + pipeTop.Width) ||
                (pipeBottom.Left <= bird.Right && bird.Right <= pipeBottom.Left + pipeBottom.Width))
            {

                return pipeBottom.Top - 100;
            }

            return bird.Top;
        }

        private void gameKeyisdown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space)
            {
                verticalVelocity = -8f; 
            }
            if (e.KeyCode == Keys.Space && game_over == true)
            {
                RestartGame();
            }
        }

        private void endgame()
        {
            if (stopwatch.ElapsedMilliseconds - elapsedMilliseconds > 1000)
            {
                hearts -= 1;
                if (hearts == 2) { 
                heart1.Visible = false;
                 }
                if (hearts == 1)
                {
                    heart2.Visible = false;
                }
                if (hearts == 0)
                {
                    heart3.Visible = false;
                }
                elapsedMilliseconds = stopwatch.ElapsedMilliseconds;
            }

            if (hearts <= 0)
            {
                gameTimer.Stop();
                Scores.UpdateMaxScore();
                GameOverLabel.Visible = true;
                game_over = true;
            }
        }


        private void RestartGame()
        {
            game_over = false;
            GameOverLabel.Visible = false;
            CountDown();
            bird.Location = new Point(66, 280);
            pipeBottom.Location = new Point(250, 400);
            pipeTop.Location = new Point(250, -230);
            pipeBottom2.Location = new Point(750, 500);
            pipeTop2.Location = new Point(750, -130);
            layer1.layerReset();
            layer2.layerReset();
            layer3.layerReset();
            heart1.Visible= heart2.Visible=heart3.Visible = true;
            Scores.Score = 0;
            pipeSpeed = 5;
            Invalidate();
            hearts= 3;
            gameTimer.Start(); 
        }

        private void CountDown()
        {
                Thread.Sleep(500);  
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(layer_1, layer1.cut1_pos, 0, 600, 700);
            e.Graphics.DrawImage(layer_1, layer1.cut2_pos, 0, 600, 700);
            e.Graphics.DrawImage(layer_2, layer2.cut1_pos, 0, 600, 700);
            e.Graphics.DrawImage(layer_2, layer2.cut2_pos, 0, 600, 700);
            e.Graphics.DrawImage(layer_3, layer3.cut1_pos, -93, 600, 700);
            e.Graphics.DrawImage(layer_3, layer3.cut2_pos, -93, 600, 700);
        }


    }
}
