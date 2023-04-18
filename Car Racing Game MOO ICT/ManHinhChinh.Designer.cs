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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.frmGame2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("#9Slide05 SVNUT Triumph", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(201, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1057, 113);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chào Mừng Bạn Đến Với Game Đua Xe\r\n                    Siêu Cấp Vip Pro";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(427, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 55);
            this.button1.TabIndex = 1;
            this.button1.Text = "1 Người Chơi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Blue;
            this.button2.Location = new System.Drawing.Point(427, 410);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(221, 55);
            this.button2.TabIndex = 3;
            this.button2.Text = "Thông Tin";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmGame2
            // 
            this.frmGame2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.frmGame2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmGame2.ForeColor = System.Drawing.Color.Blue;
            this.frmGame2.Location = new System.Drawing.Point(427, 251);
            this.frmGame2.Name = "frmGame2";
            this.frmGame2.Size = new System.Drawing.Size(221, 55);
            this.frmGame2.TabIndex = 2;
            this.frmGame2.Text = "2 Người Chơi";
            this.frmGame2.UseVisualStyleBackColor = true;
            this.frmGame2.Click += new System.EventHandler(this.button3_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Blue;
            this.button3.Location = new System.Drawing.Point(427, 332);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(221, 55);
            this.button3.TabIndex = 4;
            this.button3.Text = "Điểm Cao";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // frmManHinhChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 543);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.frmGame2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManHinhChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManHinhChinh";
            this.Deactivate += new System.EventHandler(this.frmManHinhChinh_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmManHinhChinh_FormClosing);
            this.Load += new System.EventHandler(this.frmManHinhChinh_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button frmGame2;
        private System.Windows.Forms.Button button3;
    }
}