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
    public partial class frmManHinhChinh : Form
    {
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

        private void frmManHinhChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.ExitApplication();
        }
    }
}
