namespace Car_Racing_Game_MOO_ICT
{
    partial class frmHighCore
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtScore1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtScore2 = new System.Windows.Forms.Label();
            this.txtScore3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("#9Slide05 SVNUT Triumph", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(351, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 62);
            this.label1.TabIndex = 1;
            this.label1.Text = "Xếp Hạng Thành Tích";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("#9Slide05 SVNUT Triumph", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(351, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 62);
            this.label2.TabIndex = 2;
            this.label2.Text = "Top1: ";
            // 
            // txtScore1
            // 
            this.txtScore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore1.Location = new System.Drawing.Point(503, 157);
            this.txtScore1.Name = "txtScore1";
            this.txtScore1.Size = new System.Drawing.Size(126, 23);
            this.txtScore1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("#9Slide05 SVNUT Triumph", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(351, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 62);
            this.label4.TabIndex = 4;
            this.label4.Text = "Top3: ";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("#9Slide05 SVNUT Triumph", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(351, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 62);
            this.label5.TabIndex = 5;
            this.label5.Text = "Top2: ";
            // 
            // txtScore2
            // 
            this.txtScore2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore2.Location = new System.Drawing.Point(503, 240);
            this.txtScore2.Name = "txtScore2";
            this.txtScore2.Size = new System.Drawing.Size(126, 23);
            this.txtScore2.TabIndex = 2;
            // 
            // txtScore3
            // 
            this.txtScore3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore3.Location = new System.Drawing.Point(503, 317);
            this.txtScore3.Name = "txtScore3";
            this.txtScore3.Size = new System.Drawing.Size(126, 23);
            this.txtScore3.TabIndex = 3;
            // 
            // frmHighCore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 543);
            this.Controls.Add(this.txtScore3);
            this.Controls.Add(this.txtScore2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtScore1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHighCore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "High_Score";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.High_Score_FormClosing);
            this.Load += new System.EventHandler(this.frmHighCore_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtScore1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtScore2;
        private System.Windows.Forms.Label txtScore3;
    }
}