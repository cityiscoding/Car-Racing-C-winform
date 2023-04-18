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

        private void frmManHinhChinh_Deactivate(object sender, EventArgs e)
        {
            if (player != null)
            {
                player.Stop(); // Dừng phát âm thanh nếu đang phát
            }
        }

        private void frmManHinhChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.ExitApplication();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            frmHighCore frmHighCore = new frmHighCore();
            this.Hide();
            frmHighCore.Show();
        }

        private void picBackgound_Click(object sender, EventArgs e)
        {
            // Tạo mới một PictureBox
            PictureBox pictureBox1 = new PictureBox();

            // Thiết lập kích thước và vị trí của PictureBox
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.Location = new Point(50, 50);

            // Thiết lập hình ảnh cho PictureBox
            pictureBox1.Image = Image.FromFile("C:\\Project_Work\\Visual studio\\Top-Down-Car-Racing-game-in-windows-form\\Car Racing Game MOO ICT\\Resources\\mainpic.jpg");

            // Đưa PictureBox xuống vị trí dưới cùng của các control khác trên form
            pictureBox1.SendToBack();
            button1.BringToFront();
            button2.BringToFront();
            button3.BringToFront();
            frmGame2.BringToFront();
            label1.BringToFront();

            // Thêm PictureBox vào form
            this.Controls.Add(pictureBox1);

            // Đặt thuộc tính TabStop của PictureBox thành false
            pictureBox1.TabStop = false;
        }

    }
}
