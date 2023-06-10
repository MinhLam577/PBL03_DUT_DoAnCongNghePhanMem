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
            dgv_hlv.DataSource = TKHLV_BLL.Instance.GetDataTableByList_BLL();
            dgv_hlv.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
            dgv_hlv.Columns["ID"].Visible = false;
        }
        public void Load_DataTK()
        {
            dgv_tkhlv.DataSource = TKHLV_BLL.Instance.GetDataTableByList2_BLL();
            dgv_tkhlv.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
            dgv_tkhlv.Columns["ID"].Visible = false;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (dgv_hlv.SelectedRows.Count == 1)
            {
                if (dgv_hlv.SelectedRows[0].Cells["ID"] != null && dgv_hlv.SelectedRows[0].Cells["ID"].Value != null)
                {
                    int hlvID = Convert.ToInt32(dgv_hlv.SelectedRows[0].Cells["ID"].Value.ToString());
                    bool hlvHasAccount = TKHLV_BLL.Instance.CheckHLVHasAccount_BLL(hlvID);
                    if (hlvHasAccount)
                    {
                        // HLV đã có tài khoản
                        MessageBox.Show("HLV đã có tài khoản");
                    }
                    else
                    {
                        string msp = dgv_hlv.SelectedRows[0].Cells["ID"].Value.ToString();
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
                int selectedcount = dgv_tkhlv.SelectedRows.Count;
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
                        foreach (DataGridViewRow row in dgv_tkhlv.SelectedRows)
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
            if (dgv_tkhlv.SelectedRows.Count == 1)
            {
                if (dgv_tkhlv.SelectedRows[0].Cells["ID"] != null && dgv_tkhlv.SelectedRows[0].Cells["ID"].Value != null)
                {
                        string msp = dgv_tkhlv.SelectedRows[0].Cells["ID"].Value.ToString();
                        string ten = dgv_tkhlv.SelectedRows[0].Cells["Tên TK"].Value.ToString();
                        Admin_FormThemTKHLV f = new Admin_FormThemTKHLV(msp,ten);
                        f.d += new Admin_FormThemTKHLV.Mydel(Load_DataTK);
                        f.ShowDialog();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgv_hlv.DataSource = TKHLV_BLL.Instance.SearchSP_BLL(textBox1.Text);
            dgv_tkhlv.DataSource = TKHLV_BLL.Instance.SearchSP_BLL2(textBox1.Text);
        }

        private void btn_bantk_Click(object sender, EventArgs e)
        {
            if (dgv_tkhlv.SelectedRows.Count == 1)
            {
                if (dgv_tkhlv.SelectedRows[0].Cells["ID"] != null && dgv_tkhlv.SelectedRows[0].Cells["ID"].Value != null)
                {
                    try
                    {
                        string ten = dgv_tkhlv.SelectedRows[0].Cells["Tên TK"].Value.ToString();
                        TK tk = TKBLL.Instance.GetTKByTenTK(ten);
                        if(tk.TrangThai != null && tk.TrangThai == true)
                        {
                            tk.TrangThai = false;
                            if (TKBLL.Instance.UpdateTK(tk))
                                MessageBox.Show("Ban tài khoản thành công");
                            
                        }
                        else MessageBox.Show("tài khoản đã bị ban");
                    }
                    catch
                    {
                        MessageBox.Show("Ban tài khoản thất bại");
                    }
                    
                }
            }
        }

        private void btn_moban_Click(object sender, EventArgs e)
        {
            if (dgv_tkhlv.SelectedRows.Count == 1)
            {
                if (dgv_tkhlv.SelectedRows[0].Cells["ID"] != null && dgv_tkhlv.SelectedRows[0].Cells["ID"].Value != null)
                {
                    try
                    {
                        string ten = dgv_tkhlv.SelectedRows[0].Cells["Tên TK"].Value.ToString();
                        TK tk = TKBLL.Instance.GetTKByTenTK(ten);
                        if (tk.TrangThai != null && tk.TrangThai == false)
                        {
                            tk.TrangThai = true;
                            if (TKBLL.Instance.UpdateTK(tk))
                                MessageBox.Show("Mở ban tài khoản thành công");
                        }
                        else MessageBox.Show("tài khoản chưa bị ban");
                    }
                    catch
                    {
                        MessageBox.Show("Ban tài khoản thất bại");
                    }

                }
            }
        }

        private void cb_gt_SelectedIndexChanged(object sender, EventArgs e)
        {
            string require = cb_tk.Text;
            try
            {
                if (require != null)
                {
                    if(require != "Tài khoản cá nhân")
                    {
                        dgv_tkhlv.DataSource = TKHLV_BLL.Instance.FitlerTaiKhoanBy(require, "");
                        dgv_tkhlv.Columns["ID"].Visible = false;
                    }
                    else
                    {
                        if (dgv_hlv.SelectedRows.Count == 1)
                        {
                            string IDHLV = dgv_hlv.SelectedRows[0].Cells["ID"].Value.ToString();
                            dgv_tkhlv.DataSource = TKHLV_BLL.Instance.FitlerTaiKhoanBy(require, IDHLV);
                            dgv_tkhlv.Columns["ID"].Visible = false;
                        }
                    }
                    
                }
            }
            catch
            {
                MessageBox.Show("Lọc thất bại");
            }
        }

        private void dgv_hlv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int cur_row = dgv_hlv.CurrentRow.Index;
            string require = cb_tk.Text;
            try
            {
                if (cur_row != -1 && require != null)
                {
                    string IDHLV = dgv_hlv.Rows[cur_row].Cells["ID"].Value.ToString();
                    dgv_tkhlv.DataSource = TKHLV_BLL.Instance.FitlerTaiKhoanBy(require, IDHLV);
                    dgv_tkhlv.Columns["ID"].Visible = false;
                }
            }
            catch
            {
                
            }
            
        }

        private void dgv_hlv_DataSourceChanged(object sender, EventArgs e)
        {
            int cnt = 0;
            for (int i = 0; i < dgv_hlv.Rows.Count - 1; i++)
            {
                dgv_hlv.Rows[i].Cells["STT"].Value = ++cnt;
            }
        }

        private void dgv_tkhlv_DataSourceChanged(object sender, EventArgs e)
        {
            int cnt = 0;
            for (int i = 0; i < dgv_tkhlv.Rows.Count - 1; i++)
            {
                dgv_tkhlv.Rows[i].Cells["STT"].Value = ++cnt;
            }
        }
    }
}
