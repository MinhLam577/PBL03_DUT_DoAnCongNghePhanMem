using QLPhongGym.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPhongGym.GUI
{
    public partial class FormEditLichLamViec : Form
    {
        public delegate void mydelegate(int idca,int idhlv,DateTime start,DateTime ngaylam);
        public mydelegate buon;

        
        int luachon = 1;
        public int idca { get; set; }
        public int idhlv { get; set; }
        public DateTime ngaybatdau { get; set; }
        public DateTime ngayketthuc { get; set; }
        public DateTime ngaylam { get; set; }
        public FormEditLichLamViec()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {   // lay o form 2 
                //LichLamViecTrongTuan aa = new LichLamViecTrongTuan();
                int IDCa = Convert.ToInt32(cbbCa.SelectedItem.ToString().Trim());    
                int IDHLV = Convert.ToInt32(textIdHLV.Text.ToString().Trim());
                DateTime NgayBatDau = Convert.ToDateTime(dateTimeNgayStart.Value.ToString().Trim());
                //DateTime NgayKetThuc = Convert.ToDateTime(timeEnd.Value.ToString().Trim());*/
                DateTime NgayLam = Convert.ToDateTime(timeNgaylam.Value.ToString().Trim());
                buon(IDCa,IDHLV,NgayBatDau,/*NgayKetThuc,*/NgayLam);
                //editHLV(dateTimeNgayStart.Value);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }      
        private void FormEditLichLamViec_Load(object sender, EventArgs e)
        {              
            cbbCa.SelectedItem = idca.ToString().Trim();
            textIdHLV.Text = idhlv.ToString();
            timeNgaylam.Value = Convert.ToDateTime(ngaylam);
            /*timeStart.Value = Convert.ToDateTime(ngaybatdau);
            timeEnd.Value = Convert.ToDateTime(ngayketthuc);*/
            dateTimeNgayStart.Value = ngaybatdau;
            dateTimeNgayEnd.Value = ngayketthuc;
            

            
        }
    }
}
