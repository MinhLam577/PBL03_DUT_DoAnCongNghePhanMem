namespace QLPhongGym.GUI
{
    partial class Admin_FormDanhSachThietBi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_FormDanhSachThietBi));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_MTB = new System.Windows.Forms.TextBox();
            this.txt_Mota = new System.Windows.Forms.TextBox();
            this.txt_SLHong = new System.Windows.Forms.TextBox();
            this.txt_NhaCungCap = new System.Windows.Forms.TextBox();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.txt_TenThietbi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.Btn_sort = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_DoiAnh = new System.Windows.Forms.Button();
            this.Btn_thêm = new System.Windows.Forms.Button();
            this.Btn_Sửa = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(290, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN THIẾT BỊ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 438);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1834, 489);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SandyBrown;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1834, 63);
            this.panel3.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(356, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Mã thiết bị :";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(357, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Tên thiết bị:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(381, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Số lượng:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(742, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "Nhà cung cấp:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(817, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 25);
            this.label9.TabIndex = 24;
            this.label9.Text = "Mô tả:";
            // 
            // txt_MTB
            // 
            this.txt_MTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_MTB.Enabled = false;
            this.txt_MTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MTB.Location = new System.Drawing.Point(505, 118);
            this.txt_MTB.Name = "txt_MTB";
            this.txt_MTB.Size = new System.Drawing.Size(183, 34);
            this.txt_MTB.TabIndex = 0;
            // 
            // txt_Mota
            // 
            this.txt_Mota.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_Mota.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Mota.Location = new System.Drawing.Point(927, 193);
            this.txt_Mota.Name = "txt_Mota";
            this.txt_Mota.Size = new System.Drawing.Size(358, 34);
            this.txt_Mota.TabIndex = 5;
            // 
            // txt_SLHong
            // 
            this.txt_SLHong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_SLHong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SLHong.Location = new System.Drawing.Point(503, 357);
            this.txt_SLHong.Name = "txt_SLHong";
            this.txt_SLHong.Size = new System.Drawing.Size(183, 34);
            this.txt_SLHong.TabIndex = 3;
            // 
            // txt_NhaCungCap
            // 
            this.txt_NhaCungCap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_NhaCungCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NhaCungCap.Location = new System.Drawing.Point(927, 118);
            this.txt_NhaCungCap.Name = "txt_NhaCungCap";
            this.txt_NhaCungCap.Size = new System.Drawing.Size(358, 34);
            this.txt_NhaCungCap.TabIndex = 4;
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_SoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoLuong.Location = new System.Drawing.Point(505, 281);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(183, 34);
            this.txt_SoLuong.TabIndex = 2;
            // 
            // txt_TenThietbi
            // 
            this.txt_TenThietbi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_TenThietbi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenThietbi.Location = new System.Drawing.Point(505, 193);
            this.txt_TenThietbi.Name = "txt_TenThietbi";
            this.txt_TenThietbi.Size = new System.Drawing.Size(183, 34);
            this.txt_TenThietbi.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(381, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 25);
            this.label8.TabIndex = 23;
            this.label8.Text = "SL Hỏng:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(841, 270);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 25);
            this.label10.TabIndex = 34;
            this.label10.Text = "Giá:";
            // 
            // txt_Price
            // 
            this.txt_Price.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Price.Location = new System.Drawing.Point(927, 262);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(183, 34);
            this.txt_Price.TabIndex = 6;
            // 
            // Btn_sort
            // 
            this.Btn_sort.BackColor = System.Drawing.Color.Black;
            this.Btn_sort.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_sort.ForeColor = System.Drawing.Color.Cyan;
            this.Btn_sort.Image = ((System.Drawing.Image)(resources.GetObject("Btn_sort.Image")));
            this.Btn_sort.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Btn_sort.Location = new System.Drawing.Point(1407, 332);
            this.Btn_sort.Name = "Btn_sort";
            this.Btn_sort.Size = new System.Drawing.Size(139, 49);
            this.Btn_sort.TabIndex = 36;
            this.Btn_sort.Text = "Sắp xếp";
            this.Btn_sort.UseVisualStyleBackColor = false;
            this.Btn_sort.Click += new System.EventHandler(this.Btn_sort_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Giá",
            "Tên thiết bị",
            "Nhà cung cấp"});
            this.comboBox1.Location = new System.Drawing.Point(1620, 342);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(177, 33);
            this.comboBox1.TabIndex = 38;
            // 
            // btn_DoiAnh
            // 
            this.btn_DoiAnh.BackColor = System.Drawing.Color.Black;
            this.btn_DoiAnh.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DoiAnh.ForeColor = System.Drawing.Color.Cyan;
            this.btn_DoiAnh.Image = ((System.Drawing.Image)(resources.GetObject("btn_DoiAnh.Image")));
            this.btn_DoiAnh.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_DoiAnh.Location = new System.Drawing.Point(93, 373);
            this.btn_DoiAnh.Name = "btn_DoiAnh";
            this.btn_DoiAnh.Size = new System.Drawing.Size(163, 46);
            this.btn_DoiAnh.TabIndex = 39;
            this.btn_DoiAnh.Text = "Đổi";
            this.btn_DoiAnh.UseVisualStyleBackColor = false;
            this.btn_DoiAnh.Click += new System.EventHandler(this.btn_DoiAnh_Click);
            // 
            // Btn_thêm
            // 
            this.Btn_thêm.BackColor = System.Drawing.Color.Black;
            this.Btn_thêm.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_thêm.ForeColor = System.Drawing.Color.Cyan;
            this.Btn_thêm.Image = ((System.Drawing.Image)(resources.GetObject("Btn_thêm.Image")));
            this.Btn_thêm.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Btn_thêm.Location = new System.Drawing.Point(1407, 152);
            this.Btn_thêm.Name = "Btn_thêm";
            this.Btn_thêm.Size = new System.Drawing.Size(139, 44);
            this.Btn_thêm.TabIndex = 40;
            this.Btn_thêm.Text = "Thêm";
            this.Btn_thêm.UseVisualStyleBackColor = false;
            this.Btn_thêm.Click += new System.EventHandler(this.Btn_thêm_Click);
            // 
            // Btn_Sửa
            // 
            this.Btn_Sửa.BackColor = System.Drawing.Color.Black;
            this.Btn_Sửa.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Sửa.ForeColor = System.Drawing.Color.Cyan;
            this.Btn_Sửa.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Sửa.Image")));
            this.Btn_Sửa.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Btn_Sửa.Location = new System.Drawing.Point(1407, 247);
            this.Btn_Sửa.Name = "Btn_Sửa";
            this.Btn_Sửa.Size = new System.Drawing.Size(139, 44);
            this.Btn_Sửa.TabIndex = 41;
            this.Btn_Sửa.Text = "Sửa";
            this.Btn_Sửa.UseVisualStyleBackColor = false;
            this.Btn_Sửa.Click += new System.EventHandler(this.Btn_Sửa_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.Black;
            this.btn_Xoa.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.Cyan;
            this.btn_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.Image")));
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Xoa.Location = new System.Drawing.Point(1620, 152);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(139, 44);
            this.btn_Xoa.TabIndex = 42;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(1589, 75);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(197, 34);
            this.txt_search.TabIndex = 43;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.Black;
            this.btn_reset.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.Color.Cyan;
            this.btn_reset.Image = ((System.Drawing.Image)(resources.GetObject("btn_reset.Image")));
            this.btn_reset.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_reset.Location = new System.Drawing.Point(1620, 247);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(139, 44);
            this.btn_reset.TabIndex = 45;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1455, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 25);
            this.label5.TabIndex = 46;
            this.label5.Text = "Tìm kiếm:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 255);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btn_reset);
            this.panel2.Controls.Add(this.txt_search);
            this.panel2.Controls.Add(this.btn_Xoa);
            this.panel2.Controls.Add(this.Btn_Sửa);
            this.panel2.Controls.Add(this.Btn_thêm);
            this.panel2.Controls.Add(this.btn_DoiAnh);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.Btn_sort);
            this.panel2.Controls.Add(this.txt_Price);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txt_TenThietbi);
            this.panel2.Controls.Add(this.txt_SoLuong);
            this.panel2.Controls.Add(this.txt_NhaCungCap);
            this.panel2.Controls.Add(this.txt_SLHong);
            this.panel2.Controls.Add(this.txt_Mota);
            this.panel2.Controls.Add(this.txt_MTB);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1834, 439);
            this.panel2.TabIndex = 9;
            // 
            // Admin_FormDanhSachThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1834, 927);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "Admin_FormDanhSachThietBi";
            this.Text = "Admin_FormDanhSachThietBi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_MTB;
        private System.Windows.Forms.TextBox txt_Mota;
        private System.Windows.Forms.TextBox txt_SLHong;
        private System.Windows.Forms.TextBox txt_NhaCungCap;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.TextBox txt_TenThietbi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.Button Btn_sort;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_DoiAnh;
        private System.Windows.Forms.Button Btn_thêm;
        private System.Windows.Forms.Button Btn_Sửa;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
    }
}