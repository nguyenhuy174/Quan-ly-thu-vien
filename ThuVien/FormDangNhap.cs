using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThuVien
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btndangnhap_MouseHover(object sender, EventArgs e)
        {
            btndangnhap.BackColor= SystemColors.ControlDarkDark;
        }

        private void btndangnhap_MouseLeave(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxclose_Click(object sender, EventArgs e)
        {
            
        }
        private void msgError(string msg)
        {
            Iberrormessage.Text = "            " + msg;
            Iberrormessage.Visible = true;
        }
        private void btndangnhap_Click(object sender, EventArgs e)
        {
            if (textBoxuser.Text != "Username" && textBoxuser.TextLength > 2)
            {
                if (textBoxpass.Text != "Password")
                {
                    Models.Taikhoan user = new Models.Taikhoan();
                    var validLogin = user.Login(textBoxuser.Text, textBoxpass.Text);
                    if (validLogin == true)
                    {
                        this.Hide();
                        Manage mainMenu = new Manage();
                        mainMenu.Show();
                        mainMenu.FormClosed += LogOut;
                    }
                    else
                    {
                        msgError("Tài khoản hoặc mật khẩu không chính xác. \n" + "        " + "   Hãy thử lại.");
                        textBoxpass.Text = "Password";
                        textBoxpass.UseSystemPasswordChar = false;
                        textBoxpass.Clear();
                        textBoxuser.Clear();
                        textBoxuser.Focus();
                    }
                }
                else msgError("Vui lòng nhập mật khẩu.");
            }
            else msgError("Vui lòng nhập tên người dùng.");
        }

        private void textBoxuser_Enter(object sender, EventArgs e)
        {
            if (textBoxuser.Text == "Tên đăng nhập")
            {
                textBoxuser.Text = "";
                textBoxuser.ForeColor = Color.Black;
            }
        }

        private void textBoxuser_Leave(object sender, EventArgs e)
        {
            if (textBoxuser.Text == "")
            {
                textBoxuser.Text = "Tên đăng nhập";
                textBoxuser.ForeColor = Color.Black;
            }
        }

        private void textBoxpass_Leave(object sender, EventArgs e)
        {
            if (textBoxpass.Text == "")
            {
                textBoxpass.Text = "PassWord";
                textBoxpass.ForeColor = Color.Black;
                textBoxpass.UseSystemPasswordChar = false;
            }
        }

        private void textBoxpass_Enter(object sender, EventArgs e)
        {
            if (textBoxpass.Text == "PassWord")
            {
                textBoxpass.Text = "";
                textBoxpass.ForeColor = Color.Black;
                textBoxpass.UseSystemPasswordChar = true;
            }
        }
        private void LogOut(object sender, FormClosedEventArgs e)
        {
            textBoxuser.Clear();
            textBoxpass.Clear();
            Iberrormessage.Visible = false;
            this.Show();
            textBoxuser.Focus();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FormDangKy ts = new FormDangKy();
            ts.Show();
            ts.FormClosed += LogOut;
            this.Hide();
        }

        private void textBoxuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
