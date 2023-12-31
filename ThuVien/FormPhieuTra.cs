﻿using System;
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
    public partial class FormPhieuTra : Form
    {
        Models.Phieutra myPT;
        public FormPhieuTra()
        {
            InitializeComponent();
            hienthidanhsach();
            design();
        }

        public void hienthidanhsach()
        {
            dgvphieutra.DataSource = Models.Phieutra.getTable_Phieutra();
        }
        void btnReload()
        {
            btnSVSua.Visible = btnSVXoa.Visible =
                btnSVThem.Visible = !btnSVSua.Visible;
            btnSVHuy.Visible = btnSVLuu.Visible = !btnSVLuu.Visible;
        }
        private void clearData()
        {
            txtmaphieu.Text = "";
            cbbmaphieumuon.Text = "";
            dtpngaytra.Refresh();
            dtpngaytra.Refresh();
        }
        private void btnSVThem_Click(object sender, EventArgs e)
        {
            clearData();
            txtmaphieu.Text = "PT" + dgvphieutra.Rows.Count.ToString("0000");
            btnSVLuu.Tag = "Them";
            btnSVHuy.Tag = "Them";
            btnReload();
        }

        private void btnSVSua_Click(object sender, EventArgs e)
        {
            btnReload();
            btnSVLuu.Tag = "Sua";
            btnSVHuy.Tag = "Sua";
        }
        string convertToDateSQL(string dateC)
        {
            string result;
            string date = dateC.Split(' ')[0];
            var X = date.Split('/');
            result = X[2] + "-" + X[1] + "-" + X[0];
            return result;
        }
        private void btnSVXoa_Click(object sender, EventArgs e)
        {
            string _maphieumuon = "";
            try
            {
                _maphieumuon = txtmaphieu.Text;
                MessageBox.Show(_maphieumuon);
            }
            catch { }
            DialogResult dr = MessageBox.Show(" Bạn có chắc chắn xóa ?", "Xác nhận ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                string ngaytra = convertToDateSQL(dtpngaytra.Value.ToString("dd/MM/yyy"));
                myPT = new Models.Phieutra(txtmaphieu.Text, cbbmaphieumuon.Text,ngaytra, txttinhtrang.Text);
                var i = myPT.DeletePhieutra();
                if (i > 0)
                {
                    MessageBox.Show("Xóa phiếu trả thành công");

                }
                else
                    MessageBox.Show("Xóa phiếu trả không thành công");
            }
            hienthidanhsach();
        }

        private void btnSVHuy_Click(object sender, EventArgs e)
        {
            if (btnSVHuy.Tag.ToString() == "Them")
            {
                txtmaphieu.Text = "";
                cbbmaphieumuon.Text = "";
                dtpngaytra.Refresh();
                txttinhtrang.Text = "";
            }
            if (btnSVHuy.Tag.ToString() == "Sua")
            {
                txtmaphieu.Text = "";
                cbbmaphieumuon.Text = "";
                dtpngaytra.Refresh();
                txttinhtrang.Text = "";
            }
            btnReload();
        }

        private void btnSVLuu_Click(object sender, EventArgs e)
        {
            if (btnSVLuu.Tag.ToString() == "Them")
            {
                string ngaytra = convertToDateSQL(dtpngaytra.Value.ToString("dd/MM/yyy"));
                myPT = new Models.Phieutra(txtmaphieu.Text, cbbmaphieumuon.Text, ngaytra, txttinhtrang.Text);
                var i = myPT.InsertPhieutra();
                if (i == 0)
                {
                    MessageBox.Show("Thêm phiếu trả thất bại");
                }
                else
                {
                    MessageBox.Show("Thêm phiếu trả thành công");
                    hienthidanhsach();
                }
                clearData();
                btnReload();
            }
            if (btnSVLuu.Tag.ToString() == "Sua")
            {
                string ngaytra = convertToDateSQL(dtpngaytra.Value.ToString("dd/MM/yyy"));
                myPT = new Models.Phieutra(txtmaphieu.Text, cbbmaphieumuon.Text, ngaytra, txttinhtrang.Text);
                var i = myPT.UpdatePhieutra();
                if (i == 0)
                {
                    MessageBox.Show("Sửa phiếu trả thất bại");
                }
                else
                {
                    MessageBox.Show("Sửa phiếu trả thành công");
                    hienthidanhsach();
                }
                clearData();
                btnReload();
            }
        }

        private void dgvphieutra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtmaphieu.Text = dgvphieutra.Rows[index].Cells["MaPhieuTra"].Value.ToString();
                cbbmaphieumuon.Text = dgvphieutra.Rows[index].Cells["MaPhieuMuon"].Value.ToString();
                dtpngaytra.Text = dgvphieutra.Rows[index].Cells["NgayTra"].Value.ToString();
                txttinhtrang.Text = dgvphieutra.Rows[index].Cells["TinhTrang"].Value.ToString();
            }
        }
        public void SearchByKey(string query, string value)
        {
            query = query + "N'%" + value + "%'";
            DataTable data = Models.Connection.SeachInDataBase(query);
            if (data.Rows.Count == 0) MessageBox.Show("Không tìm thấy phiếu trả");
            else dgvphieutra.DataSource = data;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string GiaTri = cbp_chon.GetItemText(this.cbp_chon.SelectedItem).Trim();

            string keyRow = txttimkiem.Text;
            if (GiaTri == "" || keyRow == "")
            {
                MessageBox.Show("Chưa nhập thông tin cần tìm");
            }
            else
            {

                string query = "";
                //set value of query if valuaCol change 
                if (GiaTri == "MaPhieuTra") query = "Select * from PHIEUTRA where MaPhieuTra like ";
                if (GiaTri == "MaPhieuMuon") query = "Select * from PHIEUTRA where MaPhieuMuon like ";
                if (GiaTri == "NgayTra") query = "Select * from PHIEUTRA where NgayTra like ";
                SearchByKey(query, keyRow);
            }
        }

        private void btntatca_Click(object sender, EventArgs e)
        {
            hienthidanhsach();
        }
        void design()
        {
            dgvphieutra.BorderStyle = BorderStyle.None;
            dgvphieutra.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvphieutra.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvphieutra.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvphieutra.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvphieutra.BackgroundColor = Color.White;
            dgvphieutra.EnableHeadersVisualStyles = false;
            dgvphieutra.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvphieutra.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvphieutra.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvphieutra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void cbbmaphieumuon_Click(object sender, EventArgs e)
        {
            cbbmaphieumuon.DataSource = Models.Phieutra.listdangmuon();
            cbbmaphieumuon.DisplayMember = "MaPhieuMuon";
        }
    }
}
