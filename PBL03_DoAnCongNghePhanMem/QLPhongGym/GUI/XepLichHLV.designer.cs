namespace QLPhongGym.GUI
{
    partial class XepLichHLV
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
            this.cbbCaLam = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnXem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.textTimebatdau = new System.Windows.Forms.TextBox();
            this.textTimeEnd = new System.Windows.Forms.TextBox();
            this.ngaylamviec = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.btnNgaylamviec = new System.Windows.Forms.Button();
            this.btntru = new System.Windows.Forms.Button();
            this.btnCong = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimeNgayEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimeNgayStart = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbCaLam
            // 
            this.cbbCaLam.FormattingEnabled = true;
            this.cbbCaLam.Items.AddRange(new object[] {
            "Ca 1",
            "Ca 2",
            "Ca 3",
            "Ca 4"});
            this.cbbCaLam.Location = new System.Drawing.Point(759, 133);
            this.cbbCaLam.Name = "cbbCaLam";
            this.cbbCaLam.Size = new System.Drawing.Size(121, 24);
            this.cbbCaLam.TabIndex = 1;
            this.cbbCaLam.SelectedIndexChanged += new System.EventHandler(this.cbbCaLam_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(596, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ca Làm Việc ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(596, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kết Thúc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(596, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bắt Đầu";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(198, 501);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 23);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(266, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Danh Sách Huấn Luyện Viên";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.IntegralHeight = false;
            this.checkedListBox1.Location = new System.Drawing.Point(64, 154);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(210, 273);
            this.checkedListBox1.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(345, 446);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(766, 323);
            this.dataGridView1.TabIndex = 14;
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(64, 501);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(100, 23);
            this.btnXem.TabIndex = 15;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(127, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "(Mã,Tên)";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(64, 446);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(210, 23);
            this.btnThem.TabIndex = 18;
            this.btnThem.Text = "Đăng Kí";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // textTimebatdau
            // 
            this.textTimebatdau.Location = new System.Drawing.Point(759, 237);
            this.textTimebatdau.Name = "textTimebatdau";
            this.textTimebatdau.Size = new System.Drawing.Size(121, 22);
            this.textTimebatdau.TabIndex = 19;
            // 
            // textTimeEnd
            // 
            this.textTimeEnd.Location = new System.Drawing.Point(759, 192);
            this.textTimeEnd.Name = "textTimeEnd";
            this.textTimeEnd.Size = new System.Drawing.Size(121, 22);
            this.textTimeEnd.TabIndex = 20;
            // 
            // ngaylamviec
            // 
            this.ngaylamviec.CustomFormat = "yyyy-MM-dd";
            this.ngaylamviec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngaylamviec.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngaylamviec.Location = new System.Drawing.Point(599, 31);
            this.ngaylamviec.Name = "ngaylamviec";
            this.ngaylamviec.Size = new System.Drawing.Size(175, 27);
            this.ngaylamviec.TabIndex = 22;
            this.ngaylamviec.Value = new System.DateTime(2023, 4, 21, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(798, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 27;
            this.label8.Text = "Hôm Nay";
            // 
            // btnNgaylamviec
            // 
            this.btnNgaylamviec.Location = new System.Drawing.Point(458, 33);
            this.btnNgaylamviec.Name = "btnNgaylamviec";
            this.btnNgaylamviec.Size = new System.Drawing.Size(117, 23);
            this.btnNgaylamviec.TabIndex = 28;
            this.btnNgaylamviec.Text = "Ngày Làm";
            this.btnNgaylamviec.UseVisualStyleBackColor = true;
            this.btnNgaylamviec.Click += new System.EventHandler(this.btnNgaylamviec_Click);
            // 
            // btntru
            // 
            this.btntru.Location = new System.Drawing.Point(423, 33);
            this.btntru.Name = "btntru";
            this.btntru.Size = new System.Drawing.Size(29, 23);
            this.btntru.TabIndex = 40;
            this.btntru.Text = "-";
            this.btntru.UseVisualStyleBackColor = true;
            this.btntru.Click += new System.EventHandler(this.btntru_Click);
            // 
            // btnCong
            // 
            this.btnCong.Location = new System.Drawing.Point(858, 33);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(22, 23);
            this.btnCong.TabIndex = 41;
            this.btnCong.Text = "+";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(447, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(556, 43);
            this.button1.TabIndex = 46;
            this.button1.Text = "THÔNG TIN LỊCH LÀM VIỆC CUA HUẤN LUYỆN VIÊN ĐÓ ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(121, 548);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 23);
            this.btnCancel.TabIndex = 48;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1150, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 16);
            this.label10.TabIndex = 64;
            this.label10.Text = "To";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(930, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 16);
            this.label11.TabIndex = 63;
            this.label11.Text = "From";
            // 
            // dateTimeNgayEnd
            // 
            this.dateTimeNgayEnd.CustomFormat = "yyyy-MM-dd";
            this.dateTimeNgayEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeNgayEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeNgayEnd.Location = new System.Drawing.Point(1200, 31);
            this.dateTimeNgayEnd.Name = "dateTimeNgayEnd";
            this.dateTimeNgayEnd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimeNgayEnd.Size = new System.Drawing.Size(155, 27);
            this.dateTimeNgayEnd.TabIndex = 62;
            this.dateTimeNgayEnd.Value = new System.DateTime(2023, 4, 21, 0, 0, 0, 0);
            // 
            // dateTimeNgayStart
            // 
            this.dateTimeNgayStart.CustomFormat = "yyyy-MM-dd";
            this.dateTimeNgayStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeNgayStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeNgayStart.Location = new System.Drawing.Point(974, 31);
            this.dateTimeNgayStart.Name = "dateTimeNgayStart";
            this.dateTimeNgayStart.Size = new System.Drawing.Size(155, 27);
            this.dateTimeNgayStart.TabIndex = 61;
            this.dateTimeNgayStart.Value = new System.DateTime(2023, 4, 21, 0, 0, 0, 0);
            // 
            // XepLichHLV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1367, 794);
            this.ControlBox = false;
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dateTimeNgayEnd);
            this.Controls.Add(this.dateTimeNgayStart);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.btntru);
            this.Controls.Add(this.btnNgaylamviec);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ngaylamviec);
            this.Controls.Add(this.textTimeEnd);
            this.Controls.Add(this.textTimebatdau);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbCaLam);
            this.Name = "XepLichHLV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XepLichHLV";
            this.Load += new System.EventHandler(this.XepLichHLV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbbCaLam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox textTimebatdau;
        private System.Windows.Forms.TextBox textTimeEnd;
        private System.Windows.Forms.DateTimePicker ngaylamviec;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnNgaylamviec;
        private System.Windows.Forms.Button btntru;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimeNgayEnd;
        private System.Windows.Forms.DateTimePicker dateTimeNgayStart;
    }
}