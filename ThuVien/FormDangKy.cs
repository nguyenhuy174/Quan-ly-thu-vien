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
    public partial class FormDangKy : Form
    {
        public FormDangKy()
        {
            InitializeComponent();
            txtposition.Enabled = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "Nhập tài khoản")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.Black;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "Nhập tài khoản";
                txtuser.ForeColor = Color.Black;
            }
        }

        private void txtmk_Enter(object sender, EventArgs e)
        {
            if (txtmk.Text == "Nhập mật khẩu")
            {
                txtmk.Text = "";
                txtmk.ForeColor = Color.Black;
                txtmk.UseSystemPasswordChar = true;
            }
        }

        private void txtmk_Leave(object sender, EventArgs e)
        {
            if (txtmk.Text == "")
            {
                txtmk.Text = "Nhập mật khẩu";
                txtmk.ForeColor = Color.Black;
                txtmk.UseSystemPasswordChar = false;
            }
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            string LoginName = "";
            try
            {
                LoginName = txtuser.Text;
            }
            catch { }
            string Password = "";
            try
            {
                Password = txtmk.Text;
            }
            catch { }        
            if (txtuser.Text != "Nhập tài khoản" & txtuser.Text != "")
            {
                if (txtmk.Text != "Nhập mật khẩu" & txtmk.Text != "")
                {
                    Models.Taikhoan Tk = new Models.Taikhoan(txtMaDocGia.Text, txtuser.Text, txtmk.Text, txtposition.Text);
                    var NV = Tk.InsertTaikhoan();
                    if (NV == 0)
                    {                       
                        MessageBox.Show("Tạo không thành công");
                    }
                    else
                    {
                        MessageBox.Show("Tạo tài khoản thành công");
                    }
                }
                else msgError2("Bạn chưa nhập mật khẩu");
                txtuser.Focus();
            }
            else msgError1("Bạn chưa nhập tài khoản");
            txtuser.Focus();
        }
        private void msgError1(string msg)
        {
            sai1.Text = "            " + msg;
            sai1.Visible = true;
        }
        private void msgError2(string msg)
        {
            sai2.Text = "            " + msg;
            sai2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormDangNhap ts = new FormDangNhap();
            ts.Show();
            //ts.FormClosed += LogOut;
            this.Hide();
        }
    }
}
