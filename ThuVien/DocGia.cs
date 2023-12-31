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
    public partial class DocGia : Form
    {
        _DocGia myDG;
        public DocGia()
        {
            InitializeComponent();
            HienThiDanhSachDG();
            design();
            txtMaDG.Enabled = false;
            //En();
            textBoxChangeState(false);
        }
        public void HienThiDanhSachDG()
        {
            var dataTable = _DocGia.getTable_DocGia();
            dgvDG.ReadOnly = true;
            dgvDG.DataSource = dataTable;
        }
        private void clearData()
        {
            txtMaDG.Text = "";
            txtTenDN.Text = "";
            txtHoTen.Text = " ";
            cbGioitinh.Text = "-Chọn giới tính-";
            dtNamSinh.Refresh();
            txtDiaChi.Text = "";
        }
        void btnReload()
        {
            btnSVSua.Visible = btnSVXoa.Visible =
                btnSVThem.Visible = !btnSVSua.Visible;
            btnSVHuy.Visible = btnSVLuu.Visible = !btnSVLuu.Visible;
        }
        string convertToDateSQL(string dateC)
        {
            string result;
            string date = dateC.Split(' ')[0];
            var X = date.Split('/');
            result = X[2] + "-" + X[1] + "-" + X[0];
            return result;
        }

        //public void En()
        //{
        //    txtHoTen.Enabled = false;
        //    txtTenDN.Enabled = false;
        //    txtDiaChi.Enabled = false;
        //    cbGioitinh.Enabled = false;
        //    dtNamSinh.Enabled = false;
        //}
        public void textBoxChangeState(bool En)
        {
            txtTenDN.Enabled = En;
            txtHoTen.Enabled = En;
            cbGioitinh.Enabled = En;
            dtNamSinh.Enabled = En;
            txtDiaChi.Enabled = En;
        }
        private void dgvDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtMaDG.Text = dgvDG.Rows[index].Cells["MaDG"].Value.ToString();
                txtTenDN.Text = dgvDG.Rows[index].Cells["TenDN"].Value.ToString();
                txtHoTen.Text = dgvDG.Rows[index].Cells["HoTen"].Value.ToString();
                cbGioitinh.Text = dgvDG.Rows[index].Cells["GioiTinh"].Value.ToString();
                dtNamSinh.Text = dgvDG.Rows[index].Cells["NamSinh "].Value.ToString();
                txtDiaChi.Text = dgvDG.Rows[index].Cells["DiaChi"].Value.ToString();

            }
        }
        public void SearchByKey(string query, string value)
        {

            query = query + "N'%" + value + "%'";
            DataTable data = Connection.SeachInDataBase(query);
            if (data.Rows.Count == 0) MessageBox.Show("Không tìm thấy độc giả");
            else dgvDG.DataSource = data;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string GiaTri = cbTimKiem.GetItemText(this.cbTimKiem.SelectedItem).Trim();

            string keyRow = txttimkiem.Text;
            if (GiaTri == "" || keyRow == "")
            {
                MessageBox.Show("Chưa nhập thông tin cần tìm");
            }
            else
            {
                string query = "";
                //set value of query if valuaCol change 
                if (GiaTri == "MaDocGia") query = "Select * from DocGia where MaDocGia like ";
                if (GiaTri == "TenDangNhap") query = "Select * from DocGia where TenDangNhap like ";
                if (GiaTri == "HoTen") query = "Select * from DocGia where HoTen like ";
                if (GiaTri == "DiaChi") query = "Select * from DocGia where DiaChi like ";
                SearchByKey(query, keyRow);
            }

        }

        private void DocGia_FormClosing(object sender, FormClosingEventArgs e)
        {
            Connection.close();
        }

        private void dgvDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtMaDG.Text = dgvDG.Rows[index].Cells["MaDG"].Value.ToString();
                txtTenDN.Text = dgvDG.Rows[index].Cells["TenDN"].Value.ToString();
                txtHoTen.Text = dgvDG.Rows[index].Cells["HoTen"].Value.ToString();
                cbGioitinh.Text = dgvDG.Rows[index].Cells["GioiTinh"].Value.ToString();
                dtNamSinh.Text = dgvDG.Rows[index].Cells["NamSinh"].Value.ToString();
                txtDiaChi.Text = dgvDG.Rows[index].Cells["DiaChi"].Value.ToString();
            }
        }

        private void btnSVThem_Click(object sender, EventArgs e)
        {
            clearData();
            txtMaDG.Text = "ID_" + dgvDG.Rows.Count.ToString("000");
            btnSVLuu.Tag = "Them";
            btnSVHuy.Tag = "Them";
            btnReload();
            textBoxChangeState(true);
        }

        private void btnSVSua_Click(object sender, EventArgs e)
        {
            btnReload();
            btnSVLuu.Tag = "Sua";
            btnSVHuy.Tag = "Sua";
            textBoxChangeState(true);
        }

        private void btnSVLuu_Click(object sender, EventArgs e)
        {
            if (btnSVLuu.Tag.ToString() == "Them")
            {
                string NgaySinh = convertToDateSQL(dtNamSinh.Value.ToString("dd/MM/yyy"));
                myDG = new _DocGia(txtMaDG.Text, txtTenDN.Text, txtHoTen.Text, cbGioitinh.Text, NgaySinh, txtDiaChi.Text);
                var i = myDG.InsertDocGia();
                if (i == 0)
                {
                    MessageBox.Show("Thêm mới độc giả thất bại");
                }
                else
                {
                    MessageBox.Show("Thêm mới độc giả thành công");
                    HienThiDanhSachDG();
                }
                textBoxChangeState(false);
                btnReload();
            }
            if (btnSVLuu.Tag.ToString() == "Sua")
            {
                string NgaySinh = convertToDateSQL(dtNamSinh.Value.ToString("dd/MM/yyy"));
                myDG = new _DocGia(txtMaDG.Text, txtTenDN.Text, txtHoTen.Text, cbGioitinh.Text, NgaySinh, txtDiaChi.Text);
                var i = myDG.UpdateDocGia();
                if (i == 0)
                {
                    MessageBox.Show("Sửa thất bại");
                }
                else
                {
                    MessageBox.Show("Sửa thành công");
                    HienThiDanhSachDG();
                }
                textBoxChangeState(false);
                btnReload();
            }
        }

        private void btnSVHuy_Click(object sender, EventArgs e)
        {
            if (btnSVHuy.Tag.ToString() == "Them")
            {
                txtMaDG.Text = "";
                txtTenDN.Text = "";
                txtHoTen.Text = " ";
                cbGioitinh.Text = "-Chọn giới tính-";
                dtNamSinh.Refresh();
                txtDiaChi.Text = "";
                textBoxChangeState(false);
            }
            if (btnSVHuy.Tag.ToString() == "Sua")
            {
                txtMaDG.Text = "";
                txtTenDN.Text = "";
                txtHoTen.Text = " ";
                cbGioitinh.Text = "-Chọn giới tính-";
                dtNamSinh.Refresh();
                txtDiaChi.Text = "";
                textBoxChangeState(false);
            }
            btnReload();
        }

        private void btnSVXoa_Click(object sender, EventArgs e)
        {
            string _MaDG = "";
            try
            {
                _MaDG = txtMaDG.Text;
                MessageBox.Show("Bạn muốn xóa độc giả với ID: " + _MaDG);
            }
            catch { }
            DialogResult dr = MessageBox.Show(" Bạn có chắc chắn xóa ?", "Xác nhận ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                string NgaySinh = convertToDateSQL(dtNamSinh.Value.ToString("dd/MM/yyy"));
                myDG = new _DocGia(txtMaDG.Text, txtTenDN.Text, txtHoTen.Text, cbGioitinh.Text, NgaySinh, txtDiaChi.Text);
                var i = myDG.DeleteDocGia();
                if (i > 0)
                {
                    MessageBox.Show("Xóa thành công");

                }
                else
                    MessageBox.Show("Xóa không thành công");
            }
            HienThiDanhSachDG();
        }
        void design()
        {
            dgvDG.BorderStyle = BorderStyle.None;
            dgvDG.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvDG.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDG.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvDG.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvDG.BackgroundColor = Color.White;
            dgvDG.EnableHeadersVisualStyles = false;
            dgvDG.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvDG.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvDG.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvDG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HienThiDanhSachDG();
        }

        private void cbTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
