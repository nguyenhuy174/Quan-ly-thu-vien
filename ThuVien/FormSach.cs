using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThuVien.Models;

namespace ThuVien
{
    public partial class FormSach : Form
    {
        public FormSach()
        {
            InitializeComponent();
            showTableSach();
            txtmasach.Enabled = false;
            design();
        }
        public void showTableSach()
        {
            DataTable dataTable = Sach.getListBook();
            dtgvSach.DataSource = dataTable;
        }

        private void dtgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtmasach.Text = dtgvSach.Rows[index].Cells["Masach"].Value.ToString();
                txttensach.Text = dtgvSach.Rows[index].Cells["Tensach"].Value.ToString();
                txttacgia.Text = dtgvSach.Rows[index].Cells["Tacgia"].Value.ToString();
                txttheloai.Text = dtgvSach.Rows[index].Cells["Theloai"].Value.ToString();
                txtnhaxuatban.Text = dtgvSach.Rows[index].Cells["Nhaxuatban"].Value.ToString();
                txtgiasach.Text = dtgvSach.Rows[index].Cells["Giasach"].Value.ToString();
                nb_SoLuong.Text = dtgvSach.Rows[index].Cells["Soluong"].Value.ToString();
                txttinhtrang.Text = dtgvSach.Rows[index].Cells["Tinhtrang"].Value.ToString();
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (searchChoice_cbx.SelectedIndex == 0)// ma sach
            {
                //do something
                if (txttimkiem.Text != "")
                {
                    DataTable search_rs = Sach.getTableSachById(txttimkiem.Text);
                    dtgvSach.DataSource = search_rs;
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập mã sách để tìm kiếm.");
                }

            }
            else if (searchChoice_cbx.SelectedIndex == 1)// ten sach
            {
                if (txttimkiem.Text != "")
                {
                    DataTable search_rs = Sach.getTableSachByName(txttimkiem.Text);
                    dtgvSach.DataSource = search_rs;
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập tên sách để tìm kiếm.");
                }
            }
            else if (searchChoice_cbx.SelectedIndex == 2)// tac gia
            {
                if (txttimkiem.Text != "")
                {
                    DataTable search_rs = Sach.getTableSachByAuthor(txttimkiem.Text);
                    dtgvSach.DataSource = search_rs;
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập tên tác giả để tìm kiếm.");
                }
            }
            else if (searchChoice_cbx.SelectedIndex == 3)// the loai    
            {
                if (txttimkiem.Text != "")
                {
                    DataTable search_rs = Sach.getTableSachByType(txttimkiem.Text);
                    dtgvSach.DataSource = search_rs;
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập thể loại sách để tìm kiếm.");
                }
            }
            else if (searchChoice_cbx.SelectedIndex == 4)// nha xuat ban
            {
                if (txttimkiem.Text != "")
                {
                    DataTable search_rs = Sach.getTableSachByPubliser(txttimkiem.Text);
                    dtgvSach.DataSource = search_rs;
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập tên NXB để tìm kiếm.");
                }
            }
            else if (searchChoice_cbx.SelectedIndex == 5)// gia sach
            {
                if (txttimkiem.Text != "")
                {
                    DataTable search_rs = Sach.getTableSachByPrice(txttimkiem.Text);
                    dtgvSach.DataSource = search_rs;
                }
                else
                {
                    MessageBox.Show("Nhập giá sách để tìm kiếm.");
                }
            }
            else if (searchChoice_cbx.SelectedIndex == 6)//so luong
            {
                if (txttimkiem.Text != "")
                {
                    DataTable search_rs = Sach.getTableSachByAmount(txttimkiem.Text);
                    dtgvSach.DataSource = search_rs;
                }
                else
                {
                    MessageBox.Show("Nhập vào số lượng để tìm kiếm.");
                }
            }
            else if (searchChoice_cbx.SelectedIndex == 7)// tinh trang
            {
                if (txttimkiem.Text != "")
                {
                    DataTable search_rs = Sach.getTableSachByState(txttimkiem.Text);
                    dtgvSach.DataSource = search_rs;
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập tình trạng sách để tìm kiếm.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập thông tin để tìm kiếm.");
            }
        }
        private void clearData()
        {
            txttensach.Text = "";
            txttacgia.Text = "";
            txttheloai.Text = "";
            txtnhaxuatban.Text = "";
            txtgiasach.Text = "";
            txttinhtrang.Text = "";
            nb_SoLuong.Value = 0;
        }
        private void Add_Click(object sender, EventArgs e)
        {
            clearData();
            Save_btn.Tag = "ADD";
            txtmasach.Text = "MS" + dtgvSach.Rows.Count.ToString("0000");
            txtmasach.Enabled = true;
            btnReload();
        }

        void btnReload()
        {
            Repair_btn.Visible = Remove_btn.Visible =
                Add_btn.Visible = !Add_btn.Visible;
            Save_btn.Visible = Cancel_btn.Visible = !Save_btn.Visible;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (Save_btn.Tag.ToString() == "ADD")
            {
                Sach s = new Sach(txtmasach.Text, txttensach.Text, txttacgia.Text, txttheloai.Text
                                , txtnhaxuatban.Text, Convert.ToInt32(txtgiasach.Text), Convert.ToInt32(nb_SoLuong.Value), txttinhtrang.Text);
                var i = s.insertSach();
                if (i == 0)
                {
                    MessageBox.Show("Thêm sách không thành công");
                }
                else
                {
                    MessageBox.Show("Thêm sách thành công");
                    showTableSach();
                }
                btnReload();
            }
            else if (Save_btn.Tag.ToString() == "Repair")
            {
                Sach s = new Sach(txtmasach.Text, txttensach.Text, txttacgia.Text, txttheloai.Text
                                , txtnhaxuatban.Text, Convert.ToInt32(txtgiasach.Text), Convert.ToInt32(nb_SoLuong.Value), txttinhtrang.Text);
                int i = s.updateBook();
                if (i == 0)
                    MessageBox.Show("Cập nhật sách không thành công");
                else
                {
                    MessageBox.Show("Cập nhật sách thành công");
                    showTableSach();
                }
                btnReload();
            }
        }

        private void Repair_Click(object sender, EventArgs e)
        {
            Save_btn.Tag = "Repair";
            btnReload();
            txtmasach.Enabled = false;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            clearData();
            btnReload();
            txtmasach.Enabled = false;
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (txtmasach.Text != "")
            {
                Sach s = new Sach(txtmasach.Text);
                var i = s.deleteBook();
                if (i > 0)
                {
                    showTableSach();
                }
                else MessageBox.Show("Xóa sách không thành công");
            }
            else { MessageBox.Show("Chọn 1 hàng để xóa."); }
        }
        void design()
        {
            dtgvSach.BorderStyle = BorderStyle.None;
            dtgvSach.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dtgvSach.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtgvSach.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dtgvSach.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dtgvSach.BackgroundColor = Color.White;
            dtgvSach.EnableHeadersVisualStyles = false;
            dtgvSach.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtgvSach.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dtgvSach.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dtgvSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void FormSach_Load(object sender, EventArgs e)
        {
            if (Taikhoan.Quyen == Quyentruy.User)
            {
                Add_btn.Visible = false;
                Repair_btn.Visible = false;
                Save_btn.Visible = false;
                Cancel_btn.Visible = false;
                Remove_btn.Visible = false;
            }
        }
    }
}
