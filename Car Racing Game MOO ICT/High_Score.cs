using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Car_Racing_Game_MOO_ICT
{
    public partial class frmHighCore : Form
    {
        public frmHighCore()
        {
            InitializeComponent();
        }

        private void High_Score_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.ExitApplication();
        }

        private void frmHighCore_Load(object sender, EventArgs e)
        {
            // Đọc dữ liệu từ file và lưu vào một danh sách các giá trị số
            List<int> scores = new List<int>();
            using (StreamReader reader = new StreamReader("C:\\Users\\Admin\\Documents\\Project_Work\\VISUAL CODE\\Car-Racing-C-winform\\Car Racing Game MOO ICT\\Score\\score.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (int.TryParse(line, out int score))
                    {
                        scores.Add(score);
                    }
                }
            }

            // Sắp xếp danh sách giá trị điểm số giảm dần
            scores.Sort();
            scores.Reverse();

            // Đặt giá trị của các label tương ứng
            if (scores.Count > 0)
            {
                txtScore1.Text = scores[0].ToString();
            }
            if (scores.Count > 1)
            {
                txtScore2.Text = scores[1].ToString();
            }
            if (scores.Count > 2)
            {
                txtScore3.Text = scores[2].ToString();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmManHinhChinh frmManHinhChinh = new frmManHinhChinh();
            this.Hide();
            frmManHinhChinh.Show();
        }
    }
}
