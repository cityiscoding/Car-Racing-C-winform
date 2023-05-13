namespace Car_Racing_Game_MOO_ICT
{
    partial class frmManHinhChinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManHinhChinh));
            this.label1 = new System.Windows.Forms.Label();
            this.frmGame1 = new System.Windows.Forms.Button();
            this.btnThongTin = new System.Windows.Forms.Button();
            this.frmGame2 = new System.Windows.Forms.Button();
            this.btnDiemCao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("#9Slide05 SVNUT Triumph", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1109, 113);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chào Mừng Bạn Đến Với Game Đua Xe\r\n Siêu Cấp Vip Pro";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmGame1
            // 
            this.frmGame1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.frmGame1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmGame1.ForeColor = System.Drawing.Color.Blue;
            this.frmGame1.Location = new System.Drawing.Point(436, 152);
            this.frmGame1.Name = "frmGame1";
            this.frmGame1.Size = new System.Drawing.Size(221, 55);
            this.frmGame1.TabIndex = 1;
            this.frmGame1.Text = "1 Người Chơi";
            this.frmGame1.UseVisualStyleBackColor = true;
            this.frmGame1.Click += new System.EventHandler(this.frmGame1_Click);
            // 
            // btnThongTin
            // 
            this.btnThongTin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongTin.ForeColor = System.Drawing.Color.Blue;
            this.btnThongTin.Location = new System.Drawing.Point(436, 395);
            this.btnThongTin.Name = "btnThongTin";
            this.btnThongTin.Size = new System.Drawing.Size(221, 55);
            this.btnThongTin.TabIndex = 3;
            this.btnThongTin.Text = "Thông Tin";
            this.btnThongTin.UseVisualStyleBackColor = true;
            this.btnThongTin.Click += new System.EventHandler(this.btnThongTin_Click);
            // 
            // frmGame2
            // 
            this.frmGame2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.frmGame2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmGame2.ForeColor = System.Drawing.Color.Blue;
            this.frmGame2.Location = new System.Drawing.Point(436, 236);
            this.frmGame2.Name = "frmGame2";
            this.frmGame2.Size = new System.Drawing.Size(221, 55);
            this.frmGame2.TabIndex = 2;
            this.frmGame2.Text = "2 Người Chơi";
            this.frmGame2.UseVisualStyleBackColor = true;
            this.frmGame2.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnDiemCao
            // 
            this.btnDiemCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiemCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiemCao.ForeColor = System.Drawing.Color.Blue;
            this.btnDiemCao.Location = new System.Drawing.Point(436, 317);
            this.btnDiemCao.Name = "btnDiemCao";
            this.btnDiemCao.Size = new System.Drawing.Size(221, 55);
            this.btnDiemCao.TabIndex = 4;
            this.btnDiemCao.Text = "Điểm Cao";
            this.btnDiemCao.UseVisualStyleBackColor = true;
            this.btnDiemCao.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // frmManHinhChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1109, 543);
            this.Controls.Add(this.btnDiemCao);
            this.Controls.Add(this.frmGame2);
            this.Controls.Add(this.btnThongTin);
            this.Controls.Add(this.frmGame1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManHinhChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManHinhChinh";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmManHinhChinh_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button frmGame1;
        private System.Windows.Forms.Button btnThongTin;
        private System.Windows.Forms.Button frmGame2;
        private System.Windows.Forms.Button btnDiemCao;
    }
}