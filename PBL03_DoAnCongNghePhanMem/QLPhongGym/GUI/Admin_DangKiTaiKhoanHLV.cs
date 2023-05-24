using QLPhongGym.BLL;
using QLPhongGym.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPhongGym.GUI
{
    public partial class Admin_DangKiTaiKhoanHLV : Form
    {
        public Admin_DangKiTaiKhoanHLV()
        {
            InitializeComponent();
            Load_Datahlv();
            Load_DataTK();
        }
        public void Load_Datahlv()
        {
            dataGridView2.DataSource = TKHLV_BLL.Instance.GetDataTableByList_BLL();
            dataGridView2.Columns["ID"].Visible = false;
        }
        public void Load_DataTK()
        {
            dataGridView1.DataSource = TKHLV_BLL.Instance.GetDataTableByList2_BLL();
            dataGridView1.Columns["ID"].Visible = false;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 1)
            {
                if (dataGridView2.SelectedRows[0].Cells["ID"] != null && dataGridView2.SelectedRows[0].Cells["ID"].Value != null)
                {
                    int hlvID = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["ID"].Value.ToString());
                    bool hlvHasAccount = TKHLV_BLL.Instance.CheckHLVHasAccount_BLL(hlvID);
                    if (hlvHasAccount)
                    {
                        // HLV đã có tài khoản
                        MessageBox.Show("HLV đã có tài khoản");
                    }
                    else
                    {
                        string msp = dataGridView2.SelectedRows[0].Cells["ID"].Value.ToString();
                        Admin_FormThemTKHLV f = new Admin_FormThemTKHLV(msp,"");
                        f.d += new Admin_FormThemTKHLV.Mydel(Load_DataTK);
                        f.ShowDialog();
                    }
                }
            }
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedcount = dataGridView1.SelectedRows.Count;
                if (selectedcount > 0)
                {
                    DialogResult result = MessageBox.Show(string.Format("Bạn có chắc chắn muốn xóa {0} hàng đã chọn?", selectedcount),
                                                         "Xóa dữ liệu",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        List<string> list = new List<string>();
                        // Xóa các hàng được chọn
                        foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                        {
                            if (row.Cells["ID"] != null && row.Cells["ID"].Value != null)
                            {
                                int id = Convert.ToInt32(row.Cells["ID"].Value);
                                TKHLV_BLL.Instance.Delete_BLL(id);
                            }

                        }
                    }
                    Load_DataTK();

                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                if (dataGridView1.SelectedRows[0].Cells["ID"] != null && dataGridView1.SelectedRows[0].Cells["ID"].Value != null)
                {

                        string msp = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();
                        string ten = dataGridView1.SelectedRows[0].Cells["Tên TK"].Value.ToString();
                        Admin_FormThemTKHLV f = new Admin_FormThemTKHLV(msp,ten);
                        f.d += new Admin_FormThemTKHLV.Mydel(Load_DataTK);
                        f.ShowDialog();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView2.DataSource = TKHLV_BLL.Instance.SearchSP_BLL(textBox1.Text);
            dataGridView1.DataSource = TKHLV_BLL.Instance.SearchSP_BLL2(textBox1.Text);
        }
    }
}
