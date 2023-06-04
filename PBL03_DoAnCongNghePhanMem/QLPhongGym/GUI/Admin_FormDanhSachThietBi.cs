using QLPhongGym.BLL;
using QLPhongGym.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPhongGym.GUI
{
    public partial class Admin_FormDanhSachThietBi : Form
    {
        static string ImagePath = Application.StartupPath + @"\Resources\No_Image_Available.jpg";
        public Admin_FormDanhSachThietBi()
        {
            InitializeComponent();
            ShowData();
        }
        public void ShowData()
        {
            dataGridView1.DataSource = ThietBi_BLL.Instance.GetAllThietBi_BLL();
            dataGridView1.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
            dataGridView1.Columns["ID"].Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ThietBi_BLL.Instance.Search_BLL(txt_Search.Text);
            dataGridView1.Columns["ID"].Visible = false;
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            int selectedCount = dataGridView1.SelectedRows.Count;
            if (selectedCount > 0)
            {
                DialogResult result = MessageBox.Show(string.Format("Bạn có chắc chắn muốn xóa {0} hàng đã chọn?", selectedCount),
                                                       "Xóa dữ liệu",
                                                       MessageBoxButtons.YesNo,
                                                       MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        if (row.Cells["ID"] != null && row.Cells["ID"].Value != null)
                        {
                            int id = Convert.ToInt32(row.Cells["ID"].Value);
                            ThietBi_BLL.Instance.DeleteTB_BLL(id);
                        }

                    }
                }
                ShowData();

            }
        }

        private void btn_sort_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null) // chọn một giá trị trong combobox
            {
                dataGridView1.DataSource = ThietBi_BLL.Instance.Sort_BLL(comboBox1.SelectedItem.ToString(), txt_Search.Text);
            }
            else
            {
                MessageBox.Show("Chọn thứ bạn muốn sắp xếp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dataGridView1.Columns["ID"].Visible = false;
        }

        private void btn_xem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                if (dataGridView1.SelectedRows[0].Cells["ID"] != null && dataGridView1.SelectedRows[0].Cells["ID"].Value != null)
                {
                    string id = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();
                    Admin_FormDetailThietBi f = new Admin_FormDetailThietBi(id);
                    f.d += new Admin_FormDetailThietBi.Mydel(ShowData);
                    f.ShowDialog();
                }
                dataGridView1.Columns["ID"].Visible = false;
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            Admin_FormDetailThietBi f = new Admin_FormDetailThietBi("");
            f.d += new Admin_FormDetailThietBi.Mydel(ShowData);
            f.ShowDialog();
            dataGridView1.Columns["ID"].Visible = false;
        }

        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            int cnt = 0;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                dataGridView1.Rows[i].Cells["STT"].Value = ++cnt;
            }
        }
    }
}