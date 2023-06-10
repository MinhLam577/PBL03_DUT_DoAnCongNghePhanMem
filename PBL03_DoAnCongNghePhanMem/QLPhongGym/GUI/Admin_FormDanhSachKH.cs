using QLPhongGym.BLL;
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
using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Runtime.InteropServices.ComTypes;

namespace QLPhongGym.GUI
{
    public partial class Admin_FormDanhSachKH : Form
    {
        bool Ispbchange = true;
        static string ImagePath = Application.StartupPath + @"\Resources\User.png";
        public Admin_FormDanhSachKH()
        {
            InitializeComponent();
            LoadListAllKH();
            LoadCBBGT();
            LocDuLieu();
        }
        public void LoadListAllKH()
        {
            dgv_kh.DataSource = KHBLL.Instance.FindListKHByIDOrName("");
            dgv_kh.Columns["IDThe"].Visible = false;
            dgv_kh.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
        }
        private void LoadCBBGT()
        {
            List<string> list = new List<string> { "Tất cả"};
            List<GoiTap> list_gt = GoiTapBLL.Instance.GetAllGT();
            foreach(GoiTap gt in list_gt)
                list.Add(gt.NameGT);
            list.Add("None");
            cb_gt.DataSource = list;
        }
        public void LoadListDKGT(int IDKH)
        {

            dgv_gt.DataSource = DangKiGoiTapBLL.Instance.FitlerListDKGT(IDKH, fitlerDKGT_tsmi.Text, cb_gt.SelectedItem as string);
            dgv_gt.Columns["IDThe"].Visible = false;
            dgv_gt.Columns["Name"].Visible = false;
            dgv_gt.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
            //Lấy ra gói tập có hiệu lực gần nhất có hiệu lực
            DangKiGoiTap dkgt = DangKiGoiTapBLL.Instance.GetDKGT_Newest_ByIDKH(IDKH);
            //Kiểm tra nếu gói tập có tồn tại thì show ghi chú của user lên giao diện
            if (dkgt != null)
                lb_description.Text = dkgt.Description;
            else lb_description.Text = "";
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            //Kiểm tra nếu như có thay đổi sang tìm kiếm bằng số điện thoại và căn cước công dân hay không
            //True là có thay đổi sang tìm kiếm bằng cccd và sdt và false là không thay đổi
            if(Ispbchange) //thay đổi sang tìm kiếm bằng cccd và sdt
            {
                lb_mathe_cccd.Text = "CCCD:"; 
                lb_ten_sdt.Text = "Số điện thoại:";
                Ispbchange = false; //Cật nhật lại biến check thành false để user có thể chuyển về trạng thái tìm kiếm ban đầu
            }
            else  //về lại lúc ban đầu
            {
                lb_mathe_cccd.Text = "Mã thẻ:";
                lb_ten_sdt.Text = "Tên:";
                Ispbchange = true;
            }
            
        }
        private void dgv_kh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgv_kh.SelectedRows.Count > 0)
            {
                try
                {
                    int IDKH = Convert.ToInt32(dgv_kh.SelectedRows[0].Cells["IDThe"].Value.ToString());
                    KH kh = (KH)UsersBLL.Instance.GetUserByID(IDKH);

                    //Show tên khách hàng lên giao diện
                    lb_tenkh.Text = kh.Name;

                    //kiểm tra để show giới tính lên giao diện
                    if ((bool)kh.Sex)
                        lb_gioitinh.Text = "Giới tính: Nam";
                    else lb_gioitinh.Text = "Giới tính: Nữ";
                    LoadListDKGT(kh.IDUsers);
                    if (kh.Image != null)
                        pb_kh.Image = Image.FromFile(Application.StartupPath + @"\PersonImage\" + kh.Image);
                    else pb_kh.Image = Image.FromFile(ImagePath);
                }
                catch 
                {

                }

            }
            
        }
        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddOrEditFormKH addOrEditFormKH = new AddOrEditFormKH("", "");
            addOrEditFormKH.ShowDialog();
        }
        private void sửaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgv_kh.SelectedRows.Count == 1)
            {
                try
                {
                    int IDKH = Convert.ToInt32(dgv_kh.SelectedRows[0].Cells["IDThe"].Value.ToString());
                    AddOrEditFormKH f = new AddOrEditFormKH(IDKH.ToString(), "");
                    f.ThayDoiThanhCong += F_ThayDoiThanhCong;
                    f.ShowDialog();
                }
                catch (Exception ex)
                {
                     MessageBox.Show(ex.Message, "Cật nhật khách hàng thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void F_ThayDoiThanhCong(object sender, EventArgs e)
        {
            (sender as AddOrEditFormKH).Close();
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_kh.SelectedRows.Count > 0)
            {
                try
                {
                    switch (MessageBox.Show("Bạn có chắc chắn muốn xóa không", "Xin chờ một lát", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        case DialogResult.Yes:
                            foreach (DataGridViewRow i in dgv_kh.SelectedRows)
                            {
                                int IDKH = Convert.ToInt32(i.Cells["IDThe"].Value.ToString());

                                //Trước khi xóa user thì phải xóa hết tất cả các gói tập đã đăng kí của user đó ra khỏi hệ thống
                                DangKiGoiTapBLL.Instance.DeleteAllDKGT(DangKiGoiTapBLL.Instance.GetAllDKGTByIDKH(IDKH)); //Xóa tất cả các gói tập đã đăng kí của user

                                //Xóa hóa đơn
                                foreach (HoaDon hd in HoaDonBLL.Instance.GetListHoaDonByIDKH(IDKH))
                                    HoaDonBLL.Instance.DeleteHoaDon(hd);

                                //Trươc khi xóa khách hàng thì phải xóa hết các lịch thuê
                                foreach (LichThueHLV lt in LichThueBLL.Instance.GetLichThueByIDKH(IDKH))
                                    LichThueBLL.Instance.DeleteLichThue(lt.IDLT);

                                //Xóa khách hàng
                                UsersBLL.Instance.DeleteUser(UsersBLL.Instance.GetUserByID(Convert.ToInt32(i.Cells["IDThe"].Value.ToString())));
                            }
                            LoadListAllKH();
                            break;
                        case DialogResult.No:
                            return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Xóa khách hàng thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txb_mathe_gmail_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (lb_mathe_cccd.Text == "Mã thẻ:" && lb_ten_sdt.Text == "Tên:") //Nếu tìm kiếm bằng mã thẻ và tên
                {
                    if (txb_mathe_cccd.Text != "" && txb_ten_sdt.Text == "") //Nếu tìm kiếm bằng mã thẻ
                        dgv_kh.DataSource = KHBLL.Instance.FindListKHByID(txb_mathe_cccd.Text);
                    else if (txb_mathe_cccd.Text != "" && txb_ten_sdt.Text != "") //Nếu tìm kiếm bằng cả mã thẻ và tên
                        dgv_kh.DataSource = KHBLL.Instance.FindListKHByNameAndID(txb_ten_sdt.Text, txb_mathe_cccd.Text);
                }
                else if (lb_mathe_cccd.Text == "CCCD:" && lb_ten_sdt.Text == "Số điện thoại:") //Nếu tìm kiếm bằng cccd và sdt
                {
                    if (txb_mathe_cccd.Text != "" && txb_ten_sdt.Text == "") //Nếu tìm kiếm bằng cccd
                        dgv_kh.DataSource = KHBLL.Instance.FindListKHByCCCD(txb_mathe_cccd.Text);
                    else if (txb_mathe_cccd.Text != "" && txb_ten_sdt.Text != "") //Nếu tìm kiếm bằng cả sdt và cccd
                        dgv_kh.DataSource = KHBLL.Instance.FindListKHBySDTAndCCCD(txb_ten_sdt.Text, txb_mathe_cccd.Text);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Tìm kiếm thất bại");
            }
            

        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadListAllKH();
            dgv_gt.DataSource = null;
            fitlerDKGT_tsmi.Text = "Fitler";
            sortkh_tsmi.Text = "Sắp xếp";
            cb_gt.Text = "None";
            txb_mathe_cccd.Text = "";
            txb_ten_sdt.Text = "";
        }

        private void txb_ten_sdt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (lb_mathe_cccd.Text == "Mã thẻ:" && lb_ten_sdt.Text == "Tên:")//Nếu tìm kiếm bằng mã thẻ và tên
                {
                    if (txb_mathe_cccd.Text == "" && txb_ten_sdt.Text != "") //Nếu tìm kiếm bằng tên
                        dgv_kh.DataSource = KHBLL.Instance.FindListKHByName(txb_ten_sdt.Text);
                    else if (txb_mathe_cccd.Text != "" && txb_ten_sdt.Text != "") //Nếu tìm kiếm bằng cả tên và mã thẻ
                        dgv_kh.DataSource = KHBLL.Instance.FindListKHByNameAndID(txb_ten_sdt.Text, txb_mathe_cccd.Text);
                }
                else if (lb_mathe_cccd.Text == "CCCD:" && lb_ten_sdt.Text == "Số điện thoại:") //Nếu tìm kiếm bằng cccd và số điện thoại
                {
                    if (txb_mathe_cccd.Text == "" && txb_ten_sdt.Text != "") //Nếu tìm kiếm bằng sdt
                        dgv_kh.DataSource = KHBLL.Instance.FindListKHBySDT(txb_ten_sdt.Text);
                    else if (txb_mathe_cccd.Text != "" && txb_ten_sdt.Text != "") //nếu tìm kiếm bằng cả sdt và cccd
                        dgv_kh.DataSource = KHBLL.Instance.FindListKHBySDTAndCCCD(txb_ten_sdt.Text, txb_mathe_cccd.Text);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Tìm kiếm thất bại");
            }
            
        }

        private void mãThẻToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                sortkh_tsmi.Text = "Mã thẻ";
                //Sắp xếp theo dữ liệu tìm kiếm
                //Lọc dữ liệu tìm kiếm theo tên hoặc mã thẻ hoặc cả mã thẻ và tên hoặc tất cả
                if (txb_mathe_cccd.Text != "" && txb_ten_sdt.Text == "") //Nếu dữ liệu tìm kiếm bằng mã thẻ
                    dgv_kh.DataSource = KHBLL.Instance.SortListKHBy("Mã thẻ", KHBLL.Instance.FindListKHByIDOrName(txb_mathe_cccd.Text));
                else if (txb_ten_sdt.Text != "" && txb_mathe_cccd.Text == "") //Nếu dữ liệu tìm kiếm bằng tên
                    dgv_kh.DataSource = KHBLL.Instance.SortListKHBy("Mã thẻ", KHBLL.Instance.FindListKHByIDOrName(txb_ten_sdt.Text));
                else if (txb_mathe_cccd.Text != "" && txb_ten_sdt.Text != "") //Nếu dữ liệu tìm kiếm bằng cả tên và mã thẻ
                    dgv_kh.DataSource = KHBLL.Instance.SortListKHBy("Mã thẻ", KHBLL.Instance.FindListKHByNameAndID(txb_ten_sdt.Text, txb_mathe_cccd.Text));
                else //Nếu dữ liệu tìm kiếm là tất cả
                    dgv_kh.DataSource = KHBLL.Instance.SortListKHBy("Mã thẻ", KHBLL.Instance.FindListKHByIDOrName(""));

            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message, "Sắp xếp thất bại");
            }
            
        }

        private void giớiTínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Tương tự như trên
                sortkh_tsmi.Text = "Giới tính";
                if (txb_mathe_cccd.Text != "" && txb_ten_sdt.Text == "")
                    dgv_kh.DataSource = KHBLL.Instance.SortListKHBy("Giới tính", KHBLL.Instance.FindListKHByIDOrName(txb_mathe_cccd.Text));
                else if (txb_ten_sdt.Text != "" && txb_mathe_cccd.Text == "")
                    dgv_kh.DataSource = KHBLL.Instance.SortListKHBy("Giới tính", KHBLL.Instance.FindListKHByIDOrName(txb_ten_sdt.Text));
                else if (txb_mathe_cccd.Text != "" && txb_ten_sdt.Text != "")
                    dgv_kh.DataSource = KHBLL.Instance.SortListKHBy("Giới tính", KHBLL.Instance.FindListKHByNameAndID(txb_ten_sdt.Text, txb_mathe_cccd.Text));
                else
                    dgv_kh.DataSource = KHBLL.Instance.SortListKHBy("Giới tính", KHBLL.Instance.FindListKHByIDOrName(""));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sắp xếp thất bại");
            }
           
        }

        private void tênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Tương tự như trên
                sortkh_tsmi.Text = "Tên";
                if (txb_mathe_cccd.Text != "" && txb_ten_sdt.Text == "")
                    dgv_kh.DataSource = KHBLL.Instance.SortListKHBy("Tên", KHBLL.Instance.FindListKHByIDOrName(txb_mathe_cccd.Text));
                else if (txb_ten_sdt.Text != "" && txb_mathe_cccd.Text == "")
                    dgv_kh.DataSource = KHBLL.Instance.SortListKHBy("Tên", KHBLL.Instance.FindListKHByIDOrName(txb_ten_sdt.Text));
                else if (txb_mathe_cccd.Text != "" && txb_ten_sdt.Text != "")
                    dgv_kh.DataSource = KHBLL.Instance.SortListKHBy("Tên", KHBLL.Instance.FindListKHByNameAndID(txb_ten_sdt.Text, txb_mathe_cccd.Text));
                else
                    dgv_kh.DataSource = KHBLL.Instance.SortListKHBy("Tên", KHBLL.Instance.FindListKHByIDOrName(""));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sắp xếp thất bại");
            }
            
        }
        private void giaHạnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if(dgv_gt.SelectedRows.Count == 1)
                {
                    //Đăng kí và gia hạn đều sài chung cùng 1 form là đăng kí gói tập khách hàng, truyền vào tham số là khách hàng và tên gói tập
                    //Gia hạn thì truyền vào tên gói tập là tên gói tập đã đăng kí trước đó
                    if (Convert.ToInt32(dgv_gt.SelectedRows[0].Cells["DaysLeft"].Value.ToString()) <= 0)
                    {
                        MessageBox.Show("Chỉ có thể gia hạn gói tập còn hiệu lực(chưa hết hạn sử dụng)");
                        return;
                    }
                    if (Convert.ToBoolean(dgv_gt.SelectedRows[0].Cells["BaoLuu"].Value.ToString()))
                    {
                        MessageBox.Show("Chỉ có thể gia hạn gói tập chưa bảo lưu");
                        return;
                    }
                    int IDKH = Convert.ToInt32(dgv_kh.SelectedRows[0].Cells["IDThe"].Value.ToString());
                    //Lấy tên gói tập
                    string GoiTap = dgv_gt.SelectedRows[0].Cells["GoiTap"].Value.ToString();

                    KH kh = (KH)UsersBLL.Instance.GetUserByID(IDKH);
                    DangKiGoiTapKHForm dkf = new DangKiGoiTapKHForm(kh, GoiTap);
                    dkf.DangKiThanhCong += (o, a) =>
                    {
                        (o as DangKiGoiTapKHForm).Close();
                    };
                    dkf.ShowDialog();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Gia hạn thất bại");
            }
        }

        private void đăngKíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_kh.SelectedRows.Count == 1)
                {
                    //Đăng kí và gia hạn đều sài chung cùng 1 form là đăng kí gói tập khách hàng, truyền vào tham số là khách hàng và tên gói tập
                    //Đăng kí thì truyền vào tên gói tập là rỗng
                    int IDKH = Convert.ToInt32(dgv_kh.SelectedRows[0].Cells["IDThe"].Value.ToString());    
                    KH kh = (KH)UsersBLL.Instance.GetUserByID(IDKH);
                    DangKiGoiTapKHForm dkf = new DangKiGoiTapKHForm(kh, "");
                    dkf.DangKiThanhCong += (o, a) =>
                    {
                        (o as DangKiGoiTapKHForm).Close();
                    };
                    dkf.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Gia hạn thất bại");
            }
        }
        private void xóaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            if(dgv_gt.SelectedRows.Count > 0)
            {
                try
                {
                    
                    int IDKH = Convert.ToInt32(dgv_kh.SelectedRows[0].Cells["IDThe"].Value.ToString());
                    switch(MessageBox.Show("Có chắc chắn muốn xóa?", "Xin chờ một lát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                    {
                        case DialogResult.OK:
                            foreach (DataGridViewRow i in dgv_gt.SelectedRows)
                            {
                                DateTime ngaybatdau = Convert.ToDateTime(i.Cells["NgayDangKi"].Value.ToString()).Date;
                                DateTime ngayketthuc = Convert.ToDateTime(i.Cells["NgayKetThuc"].Value.ToString()).Date;
                                int IDGT = GoiTapBLL.Instance.GetGTByName(i.Cells["GoiTap"].Value.ToString()).IDGT;

                                // Các gói tập đăng kí được phân biệt với nhau dựa vào id user, ngày đăng kí, ngày kết thúc và id gói tập
                                // Muốn xóa gói tập được đăng kí thì phải xác nhận 4 tham số trên
                                DangKiGoiTapBLL.Instance.DeleteDKGT(DangKiGoiTapBLL.Instance.GetDLGTByIDKH_NgayDangKi_NgayKetThuc_IDGT(IDKH, ngaybatdau, ngayketthuc, IDGT));
                            }
                            LoadListDKGT(IDKH);
                            break;
                        case DialogResult.Cancel:
                            break;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Xóa đăng kí gói tập không thành công");
                }
                
            }
        }

        private void bảoLưuToolStripMenuItem_Click(object sender, EventArgs e){
            if(dgv_gt.SelectedRows.Count == 1)
            {
                try
                {
                    //Kiểm tra gói tập đã được bao lưu hay chưa
                    bool IsBaoLuu = Convert.ToBoolean(dgv_gt.SelectedRows[0].Cells["BaoLuu"].Value.ToString());
                    int day = Convert.ToInt32(dgv_gt.SelectedRows[0].Cells["DaysLeft"].Value.ToString());
                    if (IsBaoLuu)
                    {
                        MessageBox.Show("Gói tập đã được bảo lưu rồi");
                        return;
                    }
                    if(day <= 0)
                    {
                        MessageBox.Show("Gói tập đã hết hạn");
                        return;
                    }
                    int songaybaoluu = 0; //Khai báo biến số ngày bảo lưu ban đầu = 0 nghĩa là không bảo lưu
                    do
                    {
                        songaybaoluu = 0;
                        string myvalue = Interaction.InputBox("NHẬP VÀO SỐ NGÀY BẢO LƯU", "Thông báo", "0");
                        if (!string.IsNullOrEmpty(myvalue)) // Nếu nhấn ok, xác nhận bảo lưu
                        {
                            try
                            {
                                songaybaoluu = Convert.ToInt32((myvalue));
                                if (songaybaoluu < 0 || songaybaoluu > 30)
                                    MessageBox.Show("Số ngày bảo lưu phải >= 0 và <= 30");
                            }
                            catch
                            {
                                songaybaoluu = -1;
                                MessageBox.Show("Số ngày bảo lưu không đúng định dạng");
                            }
                        }
                        else songaybaoluu = 0; // Nếu nhấn cancel, hủy bảo lưu
                    }
                    while (songaybaoluu < 0 || songaybaoluu > 30);
                    int IDKH = Convert.ToInt32(dgv_kh.SelectedRows[0].Cells["IDThe"].Value.ToString());
                    DateTime ngaydangki = Convert.ToDateTime(dgv_gt.SelectedRows[0].Cells["NgayDangKi"].Value.ToString()).Date;
                    DateTime ngayketthuc = Convert.ToDateTime(dgv_gt.SelectedRows[0].Cells["NgayKetThuc"].Value.ToString()).Date;
                    int IDGT = GoiTapBLL.Instance.GetGTByName(dgv_gt.SelectedRows[0].Cells["GoiTap"].Value.ToString()).IDGT;

                    //Lấy ra gói tập vừa click
                    DangKiGoiTap dkgt = DangKiGoiTapBLL.Instance.GetDLGTByIDKH_NgayDangKi_NgayKetThuc_IDGT(IDKH, ngaydangki, ngayketthuc, IDGT);

                    //Khoảng thời gian còn lại của gói tập khi bảo lưu = thời gian kết thúc gói tập - thời điểm lúc bảo lưu
                    int lefttime = (dkgt.NgayKetThucGT - DateTime.Today).Value.Days; 

                    //Ngày kết thúc bảo lưu = thời điểm bảo lưu + số ngày bảo lưu
                    DateTime ngayketthucbaoluu = DateTime.Today.AddDays(songaybaoluu).Date;

                    //Nếu số ngày bảo lưu ít nhất 1 ngày(có bảo lưu)
                    if(songaybaoluu > 0)
                    {
                        dkgt.BaoLuu = true;
                        dkgt.SoNgayConLai = lefttime;
                        dkgt.NgayKetThucGT = dkgt.NgayKetThucGT.Value.AddDays(songaybaoluu).Date;
                        //Cật nhật lại gói tập
                        if (DangKiGoiTapBLL.Instance.UpdateDKGT(dkgt))
                            MessageBox.Show("Bảo lưu gói tập thành công");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Bảo lưu gói tập thất bại");
                }
            }
        }
        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dgv_gt.SelectedRows.Count == 1)
            {
                try
                {
                    //Kiểm tra gói tập đã được bảo lưu hay không
                    bool IsBaoLuu = Convert.ToBoolean(dgv_gt.SelectedRows[0].Cells["BaoLuu"].Value.ToString());
                    if (!IsBaoLuu) //không bảo lưu
                    {
                        MessageBox.Show("Gói tập chưa bảo lưu");
                        return;
                    }
                    else // đã bảo lưu
                    {
                        int IDKH = Convert.ToInt32(dgv_kh.SelectedRows[0].Cells["IDThe"].Value.ToString());
                        DateTime ngaydangki = Convert.ToDateTime(dgv_gt.SelectedRows[0].Cells["NgayDangKi"].Value.ToString()).Date;
                        DateTime ngayketthuc = Convert.ToDateTime(dgv_gt.SelectedRows[0].Cells["NgayKetThuc"].Value.ToString()).Date;
                        int IDGT = GoiTapBLL.Instance.GetGTByName(dgv_gt.SelectedRows[0].Cells["GoiTap"].Value.ToString()).IDGT;

                        //Lấy ra gói tập đăng kí vừa click
                        DangKiGoiTap dkgt = DangKiGoiTapBLL.Instance.GetDLGTByIDKH_NgayDangKi_NgayKetThuc_IDGT(IDKH, ngaydangki, ngayketthuc, IDGT);

                        //Khai báo biến hiện tại để tính toán khoảng thời gian sẽ hết hạn của gói tập đăng kí
                        DateTime now = DateTime.Today;

                        //Ngày kết thúc gói tập = thời điểm restore lại gói tập + số ngày còn lại của gói tập
                        if(ngayketthuc >= now)
                        {
                            ngayketthuc = now.AddDays((double)dkgt.SoNgayConLai);
                            //Cật nhật lại gói tập
                            dkgt.BaoLuu = false;
                            dkgt.NgayKetThucGT = ngayketthuc.Date;
                            dkgt.SoNgayConLai = null;
                            if (DangKiGoiTapBLL.Instance.UpdateDKGT(dkgt))
                                MessageBox.Show("Khôi phục lại gói tập đang bảo lưu thành công", "Xin chúc mừng");
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Khôi phục gói tập thất bại");
                }
            }
        }
        public void LocDuLieu(){
            try
            {
                //Lấy tất cả ID khách hàng
                List<int> listKHID = KHBLL.Instance.GetAllKHID();
                foreach (int i in listKHID)
                {
                    //Lấy tất cả gói tập đăng kí của từng khách hàng
                    List<DangKiGoiTap> Listdkgt = DangKiGoiTapBLL.Instance.GetAllDKGTByIDKH(i);
                    foreach (DangKiGoiTap dkgt in Listdkgt)
                    {
                        DateTime now = DateTime.Today;
                        if (dkgt.BaoLuu != null) {
                            if ((bool)dkgt.BaoLuu) //Nếu gói tập đang bảo lưu
                            {
                                if (dkgt.NgayKetThucBaoLuu != null) {
                                    if (dkgt.NgayKetThucBaoLuu < now) //Nếu thời hạn bảo lưu gói tập hết hạn
                                    {
                                        DateTime ngayketthuc = dkgt.NgayKetThucGT.Value;
                                        ngayketthuc = now.AddDays((double)dkgt.SoNgayConLai); //Cật nhật lại ngày kết thúc

                                        //Cật nhật lại gói tập                                                      
                                        dkgt.BaoLuu = false;
                                        dkgt.NgayKetThucGT = ngayketthuc.Date;
                                        dkgt.SoNgayConLai = null;
                                        DangKiGoiTapBLL.Instance.UpdateDKGT(dkgt);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lọc dữ liệu thất bại");
            }
            
        }
        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_kh.SelectedRows.Count == 1)
            {
                fitlerDKGT_tsmi.Text = "Tất cả";
                try
                {
                    int IDKH = Convert.ToInt32(dgv_kh.SelectedRows[0].Cells["IDThe"].Value.ToString());
                    if (fitlerDKGT_tsmi.Text != "Fitler" && fitlerDKGT_tsmi.Text != "None")
                        dgv_gt.DataSource = DangKiGoiTapBLL.Instance.FitlerListDKGT(IDKH, fitlerDKGT_tsmi.Text, cb_gt.SelectedItem as string);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Fitler gói tập đăng kí thất bại, Lỗi: " + ex.Message);
                }
            }
        }

        private void cb_gt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgv_kh.SelectedRows.Count == 1)
            {
                try
                {
                    int IDKH = Convert.ToInt32(dgv_kh.SelectedRows[0].Cells["IDThe"].Value.ToString());
                    if(fitlerDKGT_tsmi.Text != "Fitler" && fitlerDKGT_tsmi.Text != "None")
                        dgv_gt.DataSource = DangKiGoiTapBLL.Instance.FitlerListDKGT(IDKH, fitlerDKGT_tsmi.Text, cb_gt.SelectedItem as string);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fitler thất bại, Lỗi: " + ex.Message);
                }
            }
        }


        private void góiTậpĐangBảoLưuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_kh.SelectedRows.Count == 1)
            {
                fitlerDKGT_tsmi.Text = "Đang bảo lưu";
                try
                {
                    int IDKH = Convert.ToInt32(dgv_kh.SelectedRows[0].Cells["IDThe"].Value.ToString());
                    if (fitlerDKGT_tsmi.Text != "Fitler" && fitlerDKGT_tsmi.Text != "None")
                        dgv_gt.DataSource = DangKiGoiTapBLL.Instance.FitlerListDKGT(IDKH, fitlerDKGT_tsmi.Text, cb_gt.SelectedItem as string);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fitler gói tập đăng kí thất bại, Lỗi: " + ex.Message);
                }
            }
        }

        private void góiTậpSắpHếtHạnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_kh.SelectedRows.Count == 1)
            {
                fitlerDKGT_tsmi.Text = "Đã hết hạn";
                try
                {
                    int IDKH = Convert.ToInt32(dgv_kh.SelectedRows[0].Cells["IDThe"].Value.ToString());
                    if (fitlerDKGT_tsmi.Text != "Fitler" && fitlerDKGT_tsmi.Text != "None")
                        dgv_gt.DataSource = DangKiGoiTapBLL.Instance.FitlerListDKGT(IDKH, fitlerDKGT_tsmi.Text, cb_gt.SelectedItem as string);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fitler gói tập đăng kí thất bại, Lỗi: " + ex.Message);
                }
            }
        }

        private void đăngKíGóiTậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_kh.SelectedRows.Count == 1)
                {
                    //Đăng kí và gia hạn đều sài chung cùng 1 form là đăng kí gói tập khách hàng, truyền vào tham số là khách hàng và tên gói tập
                    //Đăng kí thì truyền vào tên gói tập là rỗng
                    int IDKH = Convert.ToInt32(dgv_kh.SelectedRows[0].Cells["IDThe"].Value.ToString());
                    KH kh = (KH)UsersBLL.Instance.GetUserByID(IDKH);
                    DangKiGoiTapKHForm dkf = new DangKiGoiTapKHForm(kh, "");
                    dkf.DangKiThanhCong += (o, a) =>
                    {
                        (o as DangKiGoiTapKHForm).Close();
                    };
                    dkf.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Gia hạn thất bại");
            }
        }

        private void đangTậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_kh.SelectedRows.Count == 1)
            {
                fitlerDKGT_tsmi.Text = "Đang tập";
                try
                {
                    int IDKH = Convert.ToInt32(dgv_kh.SelectedRows[0].Cells["IDThe"].Value.ToString());
                    if (fitlerDKGT_tsmi.Text != "Fitler" && fitlerDKGT_tsmi.Text != "None")
                        dgv_gt.DataSource = DangKiGoiTapBLL.Instance.FitlerListDKGT(IDKH, fitlerDKGT_tsmi.Text, cb_gt.SelectedItem as string);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fitler gói tập đăng kí thất bại, Lỗi: " + ex.Message);
                }
            }
        }

        private void đăngKíLịchThuêHuấnLuyệnViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KH_DangKiHLV a = new KH_DangKiHLV();
            try
            {
                if (dgv_kh.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn hàng ");
                }
                else
                {
                    DataGridViewRow selectedRow = dgv_kh.SelectedRows[0];
                    // Lấy giá trị của cột đầu tiên trong hàng đã chọn
                    string name = selectedRow.Cells[2].Value.ToString();
                    int ma = Convert.ToInt32(selectedRow.Cells[1].Value.ToString());
                    a.setForm(name, ma);
                }

                a.Show();
            }
            catch { }
            
        }

        private void xemLịchThuêHuấnLuyệnViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // show lịch thue 
            KH_QuanLyLichThue a = new KH_QuanLyLichThue();
            if (dgv_kh.SelectedRows.Count == 0 || dgv_kh.SelectedRows[0].IsNewRow)
            {
                MessageBox.Show("Vui lòng chọn một hàng hợp lệ.");
            }
            else
            {
                DataGridViewRow selectedRow = dgv_kh.SelectedRows[0];
                int ma = Convert.ToInt32(selectedRow.Cells[1].Value.ToString());
                a.idkh = ma;
                a.Show();
            }

        }

        private void dgv_kh_DataSourceChanged(object sender, EventArgs e)
        {
            int cnt = 0;
            for(int i = 0; i < dgv_kh.Rows.Count - 1; i++)
            {
                dgv_kh.Rows[i].Cells["STT"].Value = ++cnt;
            }
        }
    }
}
