using System;
using System.Windows.Forms;

namespace ThuVien
{
    partial class Manage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFullScreen = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btndangxuat = new System.Windows.Forms.Button();
            this.btntaikhoan = new System.Windows.Forms.Button();
            this.btndocgia = new System.Windows.Forms.Button();
            this.pnQLS = new System.Windows.Forms.Panel();
            this.btnsach = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panQLP = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnphieumuon = new System.Windows.Forms.Button();
            this.btnphieu = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnQLS.SuspendLayout();
            this.panQLP.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnFullScreen);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1414, 62);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(0, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(437, 51);
            this.label5.TabIndex = 0;
            this.label5.Text = "QUẢN LÝ THƯ VIỆN";
            // 
            // btnFullScreen
            // 
            this.btnFullScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFullScreen.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnFullScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFullScreen.Location = new System.Drawing.Point(1072, 12);
            this.btnFullScreen.Name = "btnFullScreen";
            this.btnFullScreen.Size = new System.Drawing.Size(204, 44);
            this.btnFullScreen.TabIndex = 0;
            this.btnFullScreen.Text = "Toàn màn hình";
            this.btnFullScreen.UseVisualStyleBackColor = false;
            this.btnFullScreen.Click += new System.EventHandler(this.btnFullScreen_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.Location = new System.Drawing.Point(952, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(114, 44);
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.Text = "Cửa sổ";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(1282, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(120, 44);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Thoát";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.btndangxuat);
            this.panel2.Controls.Add(this.btntaikhoan);
            this.panel2.Controls.Add(this.btndocgia);
            this.panel2.Controls.Add(this.pnQLS);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.panQLP);
            this.panel2.Controls.Add(this.btnphieu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(282, 680);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 580);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(282, 100);
            this.panel4.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(146, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tai khoan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(146, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tai khoan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(15, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Quyền:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tên tài khoản:";
            // 
            // btndangxuat
            // 
            this.btndangxuat.BackColor = System.Drawing.Color.SteelBlue;
            this.btndangxuat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btndangxuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndangxuat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btndangxuat.Location = new System.Drawing.Point(0, 486);
            this.btndangxuat.Name = "btndangxuat";
            this.btndangxuat.Size = new System.Drawing.Size(282, 60);
            this.btndangxuat.TabIndex = 10;
            this.btndangxuat.Text = "ĐĂNG XUẤT";
            this.btndangxuat.UseVisualStyleBackColor = false;
            this.btndangxuat.Click += new System.EventHandler(this.btndangxuat_Click);
            // 
            // btntaikhoan
            // 
            this.btntaikhoan.BackColor = System.Drawing.Color.SteelBlue;
            this.btntaikhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btntaikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntaikhoan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btntaikhoan.Location = new System.Drawing.Point(0, 426);
            this.btntaikhoan.Name = "btntaikhoan";
            this.btntaikhoan.Size = new System.Drawing.Size(282, 60);
            this.btntaikhoan.TabIndex = 5;
            this.btntaikhoan.Text = "TÀI KHOẢN";
            this.btntaikhoan.UseVisualStyleBackColor = false;
            this.btntaikhoan.Click += new System.EventHandler(this.button7_Click);
            // 
            // btndocgia
            // 
            this.btndocgia.BackColor = System.Drawing.Color.SteelBlue;
            this.btndocgia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btndocgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndocgia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btndocgia.Location = new System.Drawing.Point(0, 365);
            this.btndocgia.Name = "btndocgia";
            this.btndocgia.Size = new System.Drawing.Size(282, 61);
            this.btndocgia.TabIndex = 4;
            this.btndocgia.Text = "ĐỘC GIẢ";
            this.btndocgia.UseVisualStyleBackColor = false;
            this.btndocgia.Click += new System.EventHandler(this.button6_Click);
            // 
            // pnQLS
            // 
            this.pnQLS.Controls.Add(this.btnsach);
            this.pnQLS.Controls.Add(this.button4);
            this.pnQLS.Controls.Add(this.button5);
            this.pnQLS.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnQLS.Location = new System.Drawing.Point(0, 208);
            this.pnQLS.Name = "pnQLS";
            this.pnQLS.Size = new System.Drawing.Size(282, 157);
            this.pnQLS.TabIndex = 3;
            // 
            // btnsach
            // 
            this.btnsach.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnsach.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnsach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsach.Location = new System.Drawing.Point(0, 106);
            this.btnsach.Name = "btnsach";
            this.btnsach.Size = new System.Drawing.Size(282, 53);
            this.btnsach.TabIndex = 3;
            this.btnsach.Text = "Kho sách";
            this.btnsach.UseVisualStyleBackColor = false;
            this.btnsach.Click += new System.EventHandler(this.btnsach_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(0, 53);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(282, 53);
            this.button4.TabIndex = 2;
            this.button4.Text = "Sách đã trả";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(0, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(282, 53);
            this.button5.TabIndex = 1;
            this.button5.Text = "Sách đang mượn";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SteelBlue;
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(0, 155);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(282, 53);
            this.button3.TabIndex = 2;
            this.button3.Text = "QUẢN LÝ SÁCH";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panQLP
            // 
            this.panQLP.Controls.Add(this.button2);
            this.panQLP.Controls.Add(this.btnphieumuon);
            this.panQLP.Dock = System.Windows.Forms.DockStyle.Top;
            this.panQLP.Location = new System.Drawing.Point(0, 53);
            this.panQLP.Name = "panQLP";
            this.panQLP.Size = new System.Drawing.Size(282, 102);
            this.panQLP.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(0, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(282, 49);
            this.button2.TabIndex = 2;
            this.button2.Text = "Trả sách";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnphieumuon
            // 
            this.btnphieumuon.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnphieumuon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnphieumuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnphieumuon.Location = new System.Drawing.Point(0, 0);
            this.btnphieumuon.Name = "btnphieumuon";
            this.btnphieumuon.Size = new System.Drawing.Size(282, 53);
            this.btnphieumuon.TabIndex = 1;
            this.btnphieumuon.Text = "Mượn sách";
            this.btnphieumuon.UseVisualStyleBackColor = false;
            this.btnphieumuon.Click += new System.EventHandler(this.btnphieumuon_Click);
            // 
            // btnphieu
            // 
            this.btnphieu.BackColor = System.Drawing.Color.SteelBlue;
            this.btnphieu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnphieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnphieu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnphieu.Location = new System.Drawing.Point(0, 0);
            this.btnphieu.Name = "btnphieu";
            this.btnphieu.Size = new System.Drawing.Size(282, 53);
            this.btnphieu.TabIndex = 0;
            this.btnphieu.Text = "MƯỢN/TRẢ SÁCH";
            this.btnphieu.UseVisualStyleBackColor = false;
            this.btnphieu.Click += new System.EventHandler(this.btnphieu_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(282, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1132, 680);
            this.panel3.TabIndex = 2;
            // 
            // Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 742);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Manage";
            this.Text = "Manage";
            this.Load += new System.EventHandler(this.Manage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pnQLS.ResumeLayout(false);
            this.panQLP.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnphieu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnQLS;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panQLP;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnphieumuon;
        private System.Windows.Forms.Button btntaikhoan;
        private System.Windows.Forms.Button btndocgia;
        private System.Windows.Forms.Button btnsach;
        private System.Windows.Forms.Button btndangxuat;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMinimize;
        private Button btnFullScreen;
        private Button buttonClose;
        private Label label5;
    }
}