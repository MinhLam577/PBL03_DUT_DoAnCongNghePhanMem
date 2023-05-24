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
    public partial class Admin_FormThemTKHLV : Form
    {
        public delegate void Mydel();
        public Mydel d { get; set; }
        public string ID { get; set; }
        public string Ten { get; set; }
        public Admin_FormThemTKHLV(string id, string txtText)
        {
            ID = id;
            Ten = txtText;
            InitializeComponent();
            if(txtText != "")
            {
                GUI2();
            }
            else 
            {
                GUI();
            };
            
        }
        public void GUI()
        {
            if (ID != "")
            {
                txt_MaHLV.Text = ID;
                HLV a = new HLV();
                a = TKHLV_BLL.Instance.GetHLVByID_BLL(Convert.ToInt32(ID));
                Txt_TenHLV.Text = a.Name;
                txt_MaHLV.Enabled = false;
                Txt_TenHLV.Enabled = false;
            }
        }
        public void GUI2()
        {
            if (ID != "")
            {
                txt_MaHLV.Text = ID;
                HLV a = new HLV();
                a = TKHLV_BLL.Instance.GetHLVByID_BLL(Convert.ToInt32(ID));
                Txt_TenHLV.Text = a.Name;
                Txt_TK.Text = Ten;
                txt_MaHLV.Enabled = false;
                Txt_TenHLV.Enabled = false;
            }
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            TK a = new TK();
            if (Txt_TK.Text == "")
            {
                MessageBox.Show("Cân nhập tên tài khoản");
                return;
            }
            a.TenTK = Txt_TK.Text;
            if(Txt_Mk.Text != Txt_NhapLai.Text || Txt_Mk.Text == "")
            {
                MessageBox.Show("Mật khẩu nhập lại chưa đúng với mật khẩu! Bạn xem lại");
                return ;
            }
            a.MatkhauTK = Txt_NhapLai.Text;
            a.IDQuyen = 2;
            a.IDUser = Convert.ToInt32(ID);
            if (Ten == "")
            {
                TKHLV_BLL.Instance.ADD_BLL(a);
                d();
            }
            else
            {
                TKHLV_BLL.Instance.UpdateTK_BLl(a);
                d();
            }
            this.Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
