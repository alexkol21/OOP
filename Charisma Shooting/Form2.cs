using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Charisma_Shooting
{
    public partial class Form2 : Form
    {
        SoundPlayer firing = new SoundPlayer(soundLocation: @"zap_c_07-82067.wav");
        SoundPlayer enemychaser = new SoundPlayer(soundLocation: @"pixel-death-66829.wav");


        List<int> BestScores = new List<int>();
        PictureBox[] stars;
        int bgspeed;
        Random random;
        int plSpeed;
        int score;
        int enemySpeed;
        int bulletSpeed;
        bool isGameOver;
        bool BulletExists;

        Random enemrnd = new Random();




        List<PictureBox> shooting = new List<PictureBox>();

        public Form2()
        {
            InitializeComponent();
            resetGame();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            deserialize();


            bgspeed = 7;
            plSpeed = 10;




            stars = new PictureBox[35];
            random = new Random();

            for (int i = 0; i < stars.Length; i++)
            {
                stars[i] = new PictureBox();
                stars[i].BorderStyle = BorderStyle.None;
                stars[i].Location = new Point(random.Next(20, 1001), random.Next(-10, 675));
                if (i % 2 == 1)
                {
                    stars[i].Size = new Size(3, 3);
                    stars[i].BackColor = Color.Yellow;
                }
                else
                {
                    stars[i].Size = new Size(5, 5);
                    stars[i].BackColor = Color.DarkSlateGray;
                }

                this.Controls.Add(stars[i]);



            }
        }

        private void BgMove_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < stars.Length; i++)
            {
                stars[i].Top += bgspeed;
                if (stars[i].Top >= this.Height)
                {
                    stars[i].Top = -stars[i].Height;
                }
            }

            for (int i = stars.Length / 2; i < stars.Length; i++)
            {
                stars[i].Top += bgspeed - 2;

                if (stars[i].Top >= this.Height)
                {
                    stars[i].Top = -stars[i].Height;
                }
            }
        }

        private void Uptimer_Tick(object sender, EventArgs e)
        {
            if (Player.Top > 5)
            {
                Player.Top -= plSpeed;
            }
        }

        private void DownTimer_Tick(object sender, EventArgs e)
        {
            if (Player.Top < 616)
            {
                Player.Top += plSpeed;
            }
        }

        private void LeftTimer_Tick(object sender, EventArgs e)
        {
            if (Player.Left > -15)
            {
                Player.Left -= plSpeed;
            }
        }

        private void RightTimer_Tick(object sender, EventArgs e)
        {
            if (Player.Right < 1001)
            {
                Player.Left += plSpeed;
            }
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                RightTimer.Start();
            }
            if (e.KeyCode == Keys.Left)
            {
                LeftTimer.Start();
            }
            if (e.KeyCode == Keys.Up)
            {
                Uptimer.Start();
            }
            if (e.KeyCode == Keys.Down)
            {
                DownTimer.Start();
            }
            if (e.KeyCode == Keys.Space)
            {
                shotfired(Player.Location.X);
            }
            if (e.KeyCode == Keys.Back && BulletExists == false)
            {
                BulletExists = true;
                Form1 form1 = new Form1();
                form1.Show();
                Hide();
            }
            if (e.KeyCode == Keys.Tab && isGameOver == true)
            {
                resetGame();
            }
        }

        private void shotfired(int firX)
        {
            PictureBox shot = new PictureBox();
            shot.Image = PBbullet.Image;
            shot.Location = new Point(firX + 50, Player.Location.Y - 10);
            shot.Size = new Size(40, 50);
            shot.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(shot);
            shooting.Add(shot);
            firing.Play();

            if (shot.Bounds.IntersectsWith(enemy1.Bounds))
            {
                shot.Location = new Point(-100, 500);
                score += 1;
                enemy1.Top = -450;
                enemy1.Left = enemrnd.Next(20, 950);
                BulletExists = false;
                enemychaser.Play();

            }
            if (shot.Bounds.IntersectsWith(enemy2.Bounds))
            {
                shot.Location = new Point(-100, 500);
                score += 1;
                enemy2.Top = -650;
                enemy2.Left = enemrnd.Next(20, 950);
                BulletExists = false;
                enemychaser.Play();
            }
        }


        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {
            RightTimer.Stop();
            LeftTimer.Stop();
            Uptimer.Stop();
            DownTimer.Stop();
        }



        private void GameTimer_Tick(object sender, EventArgs e)
        {

            label1.Text = score.ToString();
            enemy1.Top += enemySpeed;
            enemy2.Top += enemySpeed;

            if (enemy1.Top > 675 || enemy2.Top > 675)
            {
                GameOver();
            }

            foreach (PictureBox shot in shooting)
            {
                if (shot.Bounds.IntersectsWith(enemy1.Bounds))
                {
                    shot.Location = new Point(-100, 500);
                    score += 1;
                    enemy1.Top = -450;
                    enemy1.Left = enemrnd.Next(20, 950);
                    BulletExists = false;
                    enemychaser.Play();
                }
                if (shot.Bounds.IntersectsWith(enemy2.Bounds))
                {
                    shot.Location = new Point(-100, 500);
                    score += 1;
                    enemy2.Top = -700;
                    enemy2.Left = enemrnd.Next(20, 950);
                    BulletExists = false;
                    enemychaser.Play();
                }
            }
            if (score >= 5)
            {
                enemySpeed = 8;
                plSpeed = 10;
            }
            if (score >= 15)
            {
                enemySpeed = 10;
                plSpeed = 14;
            }
            if (score >= 30)
            {
                enemySpeed = 15;
                plSpeed = 18;
            }
        }

        private void resetGame()
        {
            GameTimer.Start();
            enemySpeed = 4;

            enemy1.Left = enemrnd.Next(20, 950);
            enemy2.Left = enemrnd.Next(20, 950);

            enemy1.Top = enemrnd.Next(0, 200) * -1;
            enemy2.Top = enemrnd.Next(0, 650) * -1;

            score = 0;
            bulletSpeed = 0;
            BulletExists = false;


            label1.Text = score.ToString();
            label1.Size = new Size(91, 59);
            label1.Location = new Point(465, 287);

        }

        private void GameOver()
        {
            isGameOver = true;
            GameTimer.Stop();
            label1.Size = new Size(982, 226);
            label1.Location = new Point(0, 202);
            label1.Text = score + Environment.NewLine + "Game Over!" + Environment.NewLine + "Press Backspace to return to the main menu" + Environment.NewLine + "Press Tab to restart the game";
            serialize();
        }

        private void PBbullet_Click(object sender, EventArgs e)
        {

        }

        private void BulletMoving_Tick(object sender, EventArgs e)
        {
            foreach (PictureBox shot in shooting)
            {
                shot.Location = new Point(shot.Location.X, shot.Location.Y - 10);
            }
        }
        private void serialize()
        {
            BestScores.Add(score);
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("TopScores.ser", FileMode.OpenOrCreate, FileAccess.Write);
            formatter.Serialize(stream, BestScores);
            stream.Close();
        }

        private void deserialize()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("TopScores.ser", FileMode.Open, FileAccess.Read);
            BestScores = (List<int>)formatter.Deserialize(stream);
            stream.Close();
        }
    }
}
