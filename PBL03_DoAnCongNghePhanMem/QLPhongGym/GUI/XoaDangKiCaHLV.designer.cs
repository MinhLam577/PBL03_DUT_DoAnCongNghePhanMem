namespace QLPhongGym.GUI
{
    partial class XoaDangKiCaHLV
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
            this.btnXoa = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnNgaylamviec = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.ngaylamviec = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbCaLam = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(12, 228);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 23);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(133, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(625, 213);
            this.dataGridView1.TabIndex = 15;
            // 
            // btnNgaylamviec
            // 
            this.btnNgaylamviec.Location = new System.Drawing.Point(192, 12);
            this.btnNgaylamviec.Name = "btnNgaylamviec";
            this.btnNgaylamviec.Size = new System.Drawing.Size(117, 23);
            this.btnNgaylamviec.TabIndex = 44;
            this.btnNgaylamviec.Text = "Ngày Làm";
            this.btnNgaylamviec.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(594, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 43;
            this.label8.Text = "Hôm Nay";
            // 
            // ngaylamviec
            // 
            this.ngaylamviec.CustomFormat = "yyyy-MM-dd";
            this.ngaylamviec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngaylamviec.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngaylamviec.Location = new System.Drawing.Point(386, 12);
            this.ngaylamviec.Name = "ngaylamviec";
            this.ngaylamviec.Size = new System.Drawing.Size(175, 27);
            this.ngaylamviec.TabIndex = 42;
            this.ngaylamviec.Value = new System.DateTime(2023, 4, 21, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 48;
            this.label1.Text = "Ca Làm Việc ";
            // 
            // cbbCaLam
            // 
            this.cbbCaLam.FormattingEnabled = true;
            this.cbbCaLam.Items.AddRange(new object[] {
            "Ca 1",
            "Ca 2",
            "Ca 3",
            "Ca 4"});
            this.cbbCaLam.Location = new System.Drawing.Point(386, 101);
            this.cbbCaLam.Name = "cbbCaLam";
            this.cbbCaLam.Size = new System.Drawing.Size(121, 24);
            this.cbbCaLam.TabIndex = 47;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 297);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 23);
            this.btnCancel.TabIndex = 49;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // XoaDangKiCaHLV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbCaLam);
            this.Controls.Add(this.btnNgaylamviec);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ngaylamviec);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnXoa);
            this.Name = "XoaDangKiCaHLV";
            this.Text = "XoaDangKiCaHLV";
            this.Load += new System.EventHandler(this.XoaDangKiCaHLV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNgaylamviec;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker ngaylamviec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbCaLam;
        private System.Windows.Forms.Button btnCancel;
    }
}