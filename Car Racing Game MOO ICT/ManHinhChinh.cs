using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Racing_Game_MOO_ICT
{
    public partial class frmManHinhChinh : Form
    {
        private SoundPlayer player;
        public frmManHinhChinh()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmGame frmGame = new frmGame();
            this.Hide();
            frmGame.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmThongTin frmThongTin = new frmThongTin();
            this.Hide();
            frmThongTin.Show();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            frmGame2 frmGame2 = new frmGame2();
            this.Hide();
            frmGame2.Show();
        }

        private void frmManHinhChinh_Load(object sender, EventArgs e)
        {
            // Khởi tạo đối tượng SoundPlayer để phát âm thanh
            player = new SoundPlayer(@"C:\Project_Work\Visual studio\Top-Down-Car-Racing-game-in-windows-form\Car Racing Game MOO ICT\Resources\music.wav");
            player.PlayLooping(); // Phát âm thanh liên tục 
        }
        private void frmManHinhChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (player != null)
            {
                player.Stop(); // Dừng phát âm thanh nếu đang phát
                player.Dispose(); // Giải phóng tài nguyên của đối tượng SoundPlayer
            }
            Program.ExitApplication();
        }

        private void frmManHinhChinh_Deactivate(object sender, EventArgs e)
        {
            if (player != null)
            {
                player.Stop(); // Dừng phát âm thanh nếu đang phát
            }
        }
    }
}
