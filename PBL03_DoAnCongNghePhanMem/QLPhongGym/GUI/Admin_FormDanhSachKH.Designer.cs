namespace QLPhongGym.GUI
{
    partial class Admin_FormDanhSachKH
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_FormDanhSachKH));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_nu = new System.Windows.Forms.RadioButton();
            this.rb_nam = new System.Windows.Forms.RadioButton();
            this.btn_sapxep = new System.Windows.Forms.Button();
            this.cb_sapxep = new System.Windows.Forms.ComboBox();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.pb_kh = new System.Windows.Forms.PictureBox();
            this.dtp_ns = new System.Windows.Forms.DateTimePicker();
            this.txb_tenkh = new System.Windows.Forms.TextBox();
            this.txb_sdt = new System.Windows.Forms.TextBox();
            this.txb_diachi = new System.Windows.Forms.TextBox();
            this.txb_makh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_resetdata = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.txb_CCCD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_upload = new System.Windows.Forms.Button();
            this.txb_gmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_kh)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.rb_nu);
            this.groupBox1.Controls.Add(this.rb_nam);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(40, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 56);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giới tính";
            // 
            // rb_nu
            // 
            this.rb_nu.AutoSize = true;
            this.rb_nu.Location = new System.Drawing.Point(345, 18);
            this.rb_nu.Name = "rb_nu";
            this.rb_nu.Size = new System.Drawing.Size(60, 29);
            this.rb_nu.TabIndex = 5;
            this.rb_nu.TabStop = true;
            this.rb_nu.Text = "Nữ";
            this.rb_nu.UseVisualStyleBackColor = true;
            // 
            // rb_nam
            // 
            this.rb_nam.AutoSize = true;
            this.rb_nam.Location = new System.Drawing.Point(194, 18);
            this.rb_nam.Name = "rb_nam";
            this.rb_nam.Size = new System.Drawing.Size(79, 29);
            this.rb_nam.TabIndex = 4;
            this.rb_nam.TabStop = true;
            this.rb_nam.Text = "Nam";
            this.rb_nam.UseVisualStyleBackColor = true;
            // 
            // btn_sapxep
            // 
            this.btn_sapxep.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_sapxep.BackColor = System.Drawing.Color.Black;
            this.btn_sapxep.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sapxep.ForeColor = System.Drawing.Color.Cyan;
            this.btn_sapxep.Image = ((System.Drawing.Image)(resources.GetObject("btn_sapxep.Image")));
            this.btn_sapxep.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_sapxep.Location = new System.Drawing.Point(1348, 57);
            this.btn_sapxep.Name = "btn_sapxep";
            this.btn_sapxep.Size = new System.Drawing.Size(139, 44);
            this.btn_sapxep.TabIndex = 15;
            this.btn_sapxep.Text = "Sắp xếp";
            this.btn_sapxep.UseVisualStyleBackColor = false;
            this.btn_sapxep.Click += new System.EventHandler(this.btn_sapxep_Click);
            // 
            // cb_sapxep
            // 
            this.cb_sapxep.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cb_sapxep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_sapxep.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_sapxep.FormattingEnabled = true;
            this.cb_sapxep.Items.AddRange(new object[] {
            "Mã",
            "Tên",
            "Giới tính"});
            this.cb_sapxep.Location = new System.Drawing.Point(1536, 62);
            this.cb_sapxep.Name = "cb_sapxep";
            this.cb_sapxep.Size = new System.Drawing.Size(276, 37);
            this.cb_sapxep.TabIndex = 14;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_xoa.BackColor = System.Drawing.Color.Black;
            this.btn_xoa.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.Color.Cyan;
            this.btn_xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoa.Image")));
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_xoa.Location = new System.Drawing.Point(681, 355);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(139, 44);
            this.btn_xoa.TabIndex = 13;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_sua.BackColor = System.Drawing.Color.Black;
            this.btn_sua.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.Color.Cyan;
            this.btn_sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_sua.Image")));
            this.btn_sua.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_sua.Location = new System.Drawing.Point(366, 355);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(139, 44);
            this.btn_sua.TabIndex = 12;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_them.BackColor = System.Drawing.Color.Black;
            this.btn_them.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.Cyan;
            this.btn_them.Image = ((System.Drawing.Image)(resources.GetObject("btn_them.Image")));
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_them.Location = new System.Drawing.Point(67, 355);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(139, 44);
            this.btn_them.TabIndex = 10;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // pb_kh
            // 
            this.pb_kh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_kh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_kh.Image = ((System.Drawing.Image)(resources.GetObject("pb_kh.Image")));
            this.pb_kh.Location = new System.Drawing.Point(1302, 20);
            this.pb_kh.Name = "pb_kh";
            this.pb_kh.Size = new System.Drawing.Size(461, 311);
            this.pb_kh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_kh.TabIndex = 63;
            this.pb_kh.TabStop = false;
            // 
            // dtp_ns
            // 
            this.dtp_ns.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_ns.CustomFormat = "dd/MM/yyyy";
            this.dtp_ns.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ns.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ns.Location = new System.Drawing.Point(185, 168);
            this.dtp_ns.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtp_ns.Name = "dtp_ns";
            this.dtp_ns.Size = new System.Drawing.Size(297, 34);
            this.dtp_ns.TabIndex = 3;
            // 
            // txb_tenkh
            // 
            this.txb_tenkh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txb_tenkh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_tenkh.Location = new System.Drawing.Point(185, 102);
            this.txb_tenkh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_tenkh.Name = "txb_tenkh";
            this.txb_tenkh.Size = new System.Drawing.Size(297, 30);
            this.txb_tenkh.TabIndex = 2;
            // 
            // txb_sdt
            // 
            this.txb_sdt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txb_sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_sdt.Location = new System.Drawing.Point(813, 173);
            this.txb_sdt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_sdt.Name = "txb_sdt";
            this.txb_sdt.Size = new System.Drawing.Size(297, 30);
            this.txb_sdt.TabIndex = 7;
            // 
            // txb_diachi
            // 
            this.txb_diachi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txb_diachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_diachi.Location = new System.Drawing.Point(813, 231);
            this.txb_diachi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_diachi.Name = "txb_diachi";
            this.txb_diachi.Size = new System.Drawing.Size(297, 30);
            this.txb_diachi.TabIndex = 8;
            // 
            // txb_makh
            // 
            this.txb_makh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txb_makh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_makh.Location = new System.Drawing.Point(185, 45);
            this.txb_makh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_makh.Name = "txb_makh";
            this.txb_makh.ReadOnly = true;
            this.txb_makh.Size = new System.Drawing.Size(297, 30);
            this.txb_makh.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(62, 105);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 25);
            this.label6.TabIndex = 53;
            this.label6.Text = "Tên KH:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(696, 236);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 25);
            this.label5.TabIndex = 52;
            this.label5.Text = "Địa chỉ:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(720, 176);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 25);
            this.label4.TabIndex = 51;
            this.label4.Text = "SĐT:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 175);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 50;
            this.label3.Text = "Ngày sinh:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 49;
            this.label2.Text = "Mã KH:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btn_resetdata);
            this.panel2.Controls.Add(this.btn_reset);
            this.panel2.Controls.Add(this.txb_CCCD);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btn_upload);
            this.panel2.Controls.Add(this.txb_gmail);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.btn_xoa);
            this.panel2.Controls.Add(this.btn_sua);
            this.panel2.Controls.Add(this.btn_them);
            this.panel2.Controls.Add(this.pb_kh);
            this.panel2.Controls.Add(this.dtp_ns);
            this.panel2.Controls.Add(this.txb_tenkh);
            this.panel2.Controls.Add(this.txb_sdt);
            this.panel2.Controls.Add(this.txb_diachi);
            this.panel2.Controls.Add(this.txb_makh);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(2, 533);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1810, 416);
            this.panel2.TabIndex = 42;
            // 
            // btn_resetdata
            // 
            this.btn_resetdata.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_resetdata.BackColor = System.Drawing.Color.Black;
            this.btn_resetdata.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_resetdata.ForeColor = System.Drawing.Color.Cyan;
            this.btn_resetdata.Image = ((System.Drawing.Image)(resources.GetObject("btn_resetdata.Image")));
            this.btn_resetdata.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_resetdata.Location = new System.Drawing.Point(971, 355);
            this.btn_resetdata.Name = "btn_resetdata";
            this.btn_resetdata.Size = new System.Drawing.Size(139, 44);
            this.btn_resetdata.TabIndex = 14;
            this.btn_resetdata.Text = "Reset";
            this.btn_resetdata.UseVisualStyleBackColor = false;
            this.btn_resetdata.Click += new System.EventHandler(this.btn_resetdata_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_reset.BackColor = System.Drawing.Color.Black;
            this.btn_reset.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.Color.Cyan;
            this.btn_reset.Image = ((System.Drawing.Image)(resources.GetObject("btn_reset.Image")));
            this.btn_reset.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_reset.Location = new System.Drawing.Point(1569, 355);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(139, 44);
            this.btn_reset.TabIndex = 41;
            this.btn_reset.Text = "Delete";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // txb_CCCD
            // 
            this.txb_CCCD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txb_CCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_CCCD.Location = new System.Drawing.Point(813, 48);
            this.txb_CCCD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_CCCD.Name = "txb_CCCD";
            this.txb_CCCD.Size = new System.Drawing.Size(297, 30);
            this.txb_CCCD.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(702, 51);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 25);
            this.label8.TabIndex = 74;
            this.label8.Text = "CCCD:";
            // 
            // btn_upload
            // 
            this.btn_upload.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_upload.BackColor = System.Drawing.Color.Black;
            this.btn_upload.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_upload.ForeColor = System.Drawing.Color.Cyan;
            this.btn_upload.Image = ((System.Drawing.Image)(resources.GetObject("btn_upload.Image")));
            this.btn_upload.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_upload.Location = new System.Drawing.Point(1372, 355);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(139, 44);
            this.btn_upload.TabIndex = 40;
            this.btn_upload.Text = "UpLoad";
            this.btn_upload.UseVisualStyleBackColor = false;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // txb_gmail
            // 
            this.txb_gmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txb_gmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_gmail.Location = new System.Drawing.Point(813, 105);
            this.txb_gmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_gmail.Name = "txb_gmail";
            this.txb_gmail.Size = new System.Drawing.Size(297, 30);
            this.txb_gmail.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(622, 107);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 25);
            this.label7.TabIndex = 72;
            this.label7.Text = "Gmail(Nếu có):";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(634, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 38);
            this.label1.TabIndex = 19;
            this.label1.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // txb_search
            // 
            this.txb_search.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txb_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_search.Location = new System.Drawing.Point(2, 67);
            this.txb_search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_search.Name = "txb_search";
            this.txb_search.Size = new System.Drawing.Size(368, 34);
            this.txb_search.TabIndex = 0;
            // 
            // btn_search
            // 
            this.btn_search.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_search.BackgroundImage")));
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(387, 69);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(42, 30);
            this.btn_search.TabIndex = 1;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Location = new System.Drawing.Point(2, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1810, 418);
            this.dataGridView1.TabIndex = 43;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Admin_FormDanhSachKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1815, 944);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txb_search);
            this.Controls.Add(this.cb_sapxep);
            this.Controls.Add(this.btn_sapxep);
            this.Controls.Add(this.label1);
            this.Name = "Admin_FormDanhSachKH";
            this.Text = "Admin_FormDanhSachKH";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_kh)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_nu;
        private System.Windows.Forms.RadioButton rb_nam;
        private System.Windows.Forms.Button btn_sapxep;
        private System.Windows.Forms.ComboBox cb_sapxep;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.PictureBox pb_kh;
        private System.Windows.Forms.DateTimePicker dtp_ns;
        private System.Windows.Forms.TextBox txb_tenkh;
        private System.Windows.Forms.TextBox txb_sdt;
        private System.Windows.Forms.TextBox txb_diachi;
        private System.Windows.Forms.TextBox txb_makh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txb_gmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txb_CCCD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_resetdata;
    }
}