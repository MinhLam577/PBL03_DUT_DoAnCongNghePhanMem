﻿using QLPhongGym.BLL;
using QLPhongGym.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPhongGym.GUI
{
    public partial class Admin_FormDanhSachGoiTap : Form
    {
        public Admin_FormDanhSachGoiTap()
        {
            InitializeComponent();
            LoadDTG();
        }
        public void LoadDTG()
        {
            dataGridView1.DataSource = GoiTapBLL.Instance.GetData_BLL();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show(string.Format("Bạn có chắc chắn muốn xóa {0} hàng đã chọn?", dataGridView1.SelectedRows.Count),
                                                      "Xóa dữ liệu",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    // Xóa các hàng được chọn
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        if (row.Cells["Mã gói tập"] != null && row.Cells["Mã gói tập"].Value != null)
                        {
                            int id = Convert.ToInt32(row.Cells["Mã gói tập"].Value);
                            
                            GoiTapBLL.Instance.DeleteGT(GoiTapBLL.Instance.GetGTByID(id));
                        }

                    }
                }
                Reset();
                LoadDTG();
            }
        }
        public void Reset()
        {
            txt_MGT.Text = "";
            txt_Price.Text = "";
            txt_TenGT.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txt_MGT.Text = row.Cells["Mã gói tập"].Value.ToString();
                txt_TenGT.Text = row.Cells["Gói tập"].Value.ToString();
                txt_Price.Text = row.Cells["Giá(vnđ)"].Value.ToString();
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_MGT.Text == "")
            {
                GoiTap tb = new GoiTap();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["Gói tập"].Value != null)
                    {
                        if (txt_TenGT.Text == row.Cells["Gói tập"].Value.ToString())
                        {
                            MessageBox.Show("Gói tập đã tồn tại trong danh sách, vui lòng tạo gói khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                if(txt_TenGT.Text == "")
                {
                    MessageBox.Show("Gói tập chưa có tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!int.TryParse(txt_Price.Text, out int price) || price <= 0)
                {
                    MessageBox.Show("Giá gói tập không hợp lệ, vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                tb.NameGT = txt_TenGT.Text;
                tb.Price = Convert.ToDouble(txt_Price.Text);
                GoiTapBLL.Instance.AddGT(tb);
                MessageBox.Show("Đã thêm thành công!!!");
                Reset();
            }
            LoadDTG();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            GoiTap tb = new GoiTap();
            if (txt_MGT.Text != "")
            {
                if (txt_TenGT.Text == "")
                {
                    MessageBox.Show(" Cần nhập tên thiết bị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!int.TryParse(txt_Price.Text, out int price) || price <= 0)
                {
                    MessageBox.Show("Giá thiết bị không hợp lệ, vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                tb.IDGT = Convert.ToInt32(txt_MGT.Text);
                tb.Price = Convert.ToDouble(txt_Price.Text);
                tb.NameGT = txt_TenGT.Text;
                GoiTapBLL.Instance.UpdateGT(tb);
                MessageBox.Show("Đã sửa thành công!!!");
                Reset();
            }
            LoadDTG();
        }
    }
}