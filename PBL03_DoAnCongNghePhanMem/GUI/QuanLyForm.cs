using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace GUI
{
    public partial class QuanLyForm : Form
    {
        public QuanLyForm()
        {
            InitializeComponent();
        }
        private void QuanLyForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            ptb_imdynamic.Image = new Bitmap("E:\\PBL_03_DUT_DoAnCongNghePhanMem\\GUI\\Resources\\5.jpg");
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            switch(r.Next(1, 5))
            {
                case 5:
                    ptb_imdynamic.Image = new Bitmap(@"E:\PBL_03_DUT_DoAnCongNghePhanMem\GUI\Resources\5.jpg");
                    break;
                case 1:
                    ptb_imdynamic.Image = new Bitmap(@"E:\PBL_03_DUT_DoAnCongNghePhanMem\GUI\Resources\1.png");
                    break;
                case 2:
                    ptb_imdynamic.Image = new Bitmap(@"E:\PBL_03_DUT_DoAnCongNghePhanMem\GUI\Resources\2.jpg");
                    break;
                case 3:
                    ptb_imdynamic.Image = new Bitmap(@"E:\PBL_03_DUT_DoAnCongNghePhanMem\GUI\Resources\3.png");
                    break;
                case 4:
                    ptb_imdynamic.Image = new Bitmap(@"E:\PBL_03_DUT_DoAnCongNghePhanMem\GUI\Resources\4.jpg");
                    break;
            }
            
        }
    }
}
