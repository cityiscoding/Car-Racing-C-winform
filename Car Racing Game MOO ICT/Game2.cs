using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Racing_Game_MOO_ICT
{
    public partial class frmGame2 : Form
    {

        int roadSpeed;
        int trafficSpeed;
        int playerSpeed = 12;
        int score;
        int carImage;

        Random rand = new Random();
        Random carPosition = new Random();

        bool goleft, goright , goup, godown;
        bool goleft1, goright1;

        public frmGame2()
        {
            InitializeComponent();
            ResetGame();
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft1 = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright1 = true;
            }
            if (e.KeyCode == Keys.A)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.D)
            {
                goright = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft1 = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright1 = false;
            }
            if (e.KeyCode == Keys.A)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.D)
            {
                goright = false;
            }
        }
        private void keyisdown1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft1 = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright1 = true;
            }
        }

        private void keyisup1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft1 = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright1 = false;
            }
        }




        private void changeAIcars(PictureBox tempCar)
        {

            carImage = rand.Next(1, 9);

            switch (carImage)
            {

                case 1:
                    tempCar.Image = Properties.Resources.ambulance;
                    break;
                case 2:
                    tempCar.Image = Properties.Resources.carGreen;
                    break;
                case 3:
                    tempCar.Image = Properties.Resources.carGrey;
                    break;
                case 4:
                    tempCar.Image = Properties.Resources.carOrange;
                    break;
                case 5:
                    tempCar.Image = Properties.Resources.carPink;
                    break;
                case 6:
                    tempCar.Image = Properties.Resources.CarRed;
                    break;
                case 7:
                    tempCar.Image = Properties.Resources.carYellow;
                    break;
                case 8:
                    tempCar.Image = Properties.Resources.TruckBlue;
                    break;
                case 9:
                    tempCar.Image = Properties.Resources.TruckWhite;
                    break;
            }


            tempCar.Top = carPosition.Next(100, 400) * -1;


            if ((string)tempCar.Tag == "carLeft")
            {
                tempCar.Left = carPosition.Next(5, 200);
            }
            if ((string)tempCar.Tag == "carRight")
            {
                tempCar.Left = carPosition.Next(245, 422);
            }
        }

        private void gameOver()
        {
            playSound();
            playSound2();
            gameTimer.Stop();
            explosion.Visible = true;
            player.Controls.Add(explosion);
            explosion.Location = new Point(-8, 5);
            explosion.BackColor = Color.Transparent;
            explosion2.Visible = true;
            player1.Controls.Add(explosion2);
            explosion2.Location = new Point(-8, 5);
            explosion2.BackColor = Color.Transparent;
            award.Visible = true;
            award.BringToFront();
            btnStart.Enabled = true;
        }
        private void playSound2()
        {
            System.Media.SoundPlayer player2 = new System.Media.SoundPlayer(Properties.Resources.hit);
            player2.Play();
        }

        private void ResetGame()
        {
            btnStart.Enabled = false;
            explosion.Visible = false;
            award.Visible = false;
            goleft = false;
            goright = false;
            score = 0;
            award.Image = Properties.Resources.bronze;

            roadSpeed = 12;
            trafficSpeed = 15;

            AI1.Top = carPosition.Next(200, 500) * -1;
            AI1.Left = carPosition.Next(5, 200);

            AI2.Top = carPosition.Next(200, 500) * -1;
            AI2.Left = carPosition.Next(245, 422);

            gameTimer.Start();
        }

        private void restartGame(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void frmGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.ExitApplication();
        }

        private void btnThoatGame_Click(object sender, EventArgs e)
        {
            frmManHinhChinh mhc = new frmManHinhChinh();
            this.Hide();
            mhc.Show();
        }


        private void frmGame2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.ExitApplication();
        }

          private void gameTimer_Tick(object sender, EventArgs e)
    {
        txtScore.Text = "Score: " + score;
        score++;

        if (goleft == true && player.Left > 10)
        {
            player.Left -= playerSpeed;
        }
        if (goright == true && player.Left < 415)
        {
            player.Left += playerSpeed;
        }

        if (goleft1 == true && player1.Left > 10)
        {
            player1.Left -= playerSpeed;
        }
        if (goright1 == true && player1.Left < 415)
        {
            player1.Left += playerSpeed;
        }

        roadTrack1.Top += roadSpeed;
        roadTrack2.Top += roadSpeed;

        if (roadTrack2.Top > 519)
        {
            roadTrack2.Top = -519;
        }
        if (roadTrack1.Top > 519)
        {
            roadTrack1.Top = -519;
        }

        AI1.Top += trafficSpeed;
        AI2.Top += trafficSpeed;


        if (AI1.Top > 530)
        {
            changeAIcars(AI1);
        }

        if (AI2.Top > 530)
        {
            changeAIcars(AI2);
        }

        if (player.Bounds.IntersectsWith(AI1.Bounds) || player.Bounds.IntersectsWith(AI2.Bounds) || player1.Bounds.IntersectsWith(AI1.Bounds) || player1.Bounds.IntersectsWith(AI2.Bounds))
        {
            gameOver();
        }
    }

        private void restart(object sender, EventArgs e)
        {

        }

        private void playSound()
        {
            System.Media.SoundPlayer playCrash = new System.Media.SoundPlayer(Properties.Resources.hit);
            playCrash.Play();
        }
    }
}
