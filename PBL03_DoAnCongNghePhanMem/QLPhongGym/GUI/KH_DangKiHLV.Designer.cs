namespace QLPhongGym.GUI
{
    partial class KH_DangKiHLV
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
            this.lbNgayLam = new System.Windows.Forms.Label();
            this.mkh = new System.Windows.Forms.Label();
            this.lbMahlv = new System.Windows.Forms.Label();
            this.lbTenhlv = new System.Windows.Forms.Label();
            this.lbCa = new System.Windows.Forms.Label();
            this.dateNgayLam = new System.Windows.Forms.DateTimePicker();
            this.textMa = new System.Windows.Forms.TextBox();
            this.textTen = new System.Windows.Forms.TextBox();
            this.cbbCa = new System.Windows.Forms.ComboBox();
            this.cbbHlv = new System.Windows.Forms.ComboBox();
            this.cbbma = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_dongia = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDangKi = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNgayLam
            // 
            this.lbNgayLam.AutoSize = true;
            this.lbNgayLam.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayLam.Location = new System.Drawing.Point(106, 206);
            this.lbNgayLam.Name = "lbNgayLam";
            this.lbNgayLam.Size = new System.Drawing.Size(129, 29);
            this.lbNgayLam.TabIndex = 0;
            this.lbNgayLam.Text = "Ngày Làm";
            // 
            // mkh
            // 
            this.mkh.AutoSize = true;
            this.mkh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkh.Location = new System.Drawing.Point(40, 301);
            this.mkh.Name = "mkh";
            this.mkh.Size = new System.Drawing.Size(195, 29);
            this.mkh.TabIndex = 1;
            this.mkh.Text = "Mã Khách Hàng";
            // 
            // lbMahlv
            // 
            this.lbMahlv.AutoSize = true;
            this.lbMahlv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMahlv.Location = new System.Drawing.Point(579, 396);
            this.lbMahlv.Name = "lbMahlv";
            this.lbMahlv.Size = new System.Drawing.Size(250, 29);
            this.lbMahlv.TabIndex = 3;
            this.lbMahlv.Text = "Mã Huấn Luyện Viên";
            // 
            // lbTenhlv
            // 
            this.lbTenhlv.AutoSize = true;
            this.lbTenhlv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenhlv.Location = new System.Drawing.Point(568, 291);
            this.lbTenhlv.Name = "lbTenhlv";
            this.lbTenhlv.Size = new System.Drawing.Size(261, 29);
            this.lbTenhlv.TabIndex = 4;
            this.lbTenhlv.Text = "Tên Huấn Luyện Viên";
            // 
            // lbCa
            // 
            this.lbCa.AutoSize = true;
            this.lbCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCa.Location = new System.Drawing.Point(717, 201);
            this.lbCa.Name = "lbCa";
            this.lbCa.Size = new System.Drawing.Size(112, 29);
            this.lbCa.TabIndex = 5;
            this.lbCa.Text = "Ca Thuê";
            // 
            // dateNgayLam
            // 
            this.dateNgayLam.CustomFormat = "yyyy-MM-dd";
            this.dateNgayLam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayLam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgayLam.Location = new System.Drawing.Point(261, 200);
            this.dateNgayLam.Name = "dateNgayLam";
            this.dateNgayLam.Size = new System.Drawing.Size(268, 36);
            this.dateNgayLam.TabIndex = 6;
            this.dateNgayLam.Value = new System.DateTime(2023, 6, 2, 0, 0, 0, 0);
            this.dateNgayLam.ValueChanged += new System.EventHandler(this.dateNgayLam_ValueChanged);
            // 
            // textMa
            // 
            this.textMa.Enabled = false;
            this.textMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMa.Location = new System.Drawing.Point(261, 298);
            this.textMa.Name = "textMa";
            this.textMa.Size = new System.Drawing.Size(268, 36);
            this.textMa.TabIndex = 7;
            // 
            // textTen
            // 
            this.textTen.Enabled = false;
            this.textTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTen.Location = new System.Drawing.Point(261, 398);
            this.textTen.Name = "textTen";
            this.textTen.Size = new System.Drawing.Size(268, 36);
            this.textTen.TabIndex = 8;
            // 
            // cbbCa
            // 
            this.cbbCa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCa.FormattingEnabled = true;
            this.cbbCa.Location = new System.Drawing.Point(863, 198);
            this.cbbCa.Name = "cbbCa";
            this.cbbCa.Size = new System.Drawing.Size(303, 37);
            this.cbbCa.TabIndex = 9;
            this.cbbCa.DropDown += new System.EventHandler(this.cbbCa_DropDown);
            this.cbbCa.SelectedIndexChanged += new System.EventHandler(this.cbbCa_SelectedIndexChanged);
            // 
            // cbbHlv
            // 
            this.cbbHlv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbHlv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbHlv.FormattingEnabled = true;
            this.cbbHlv.Location = new System.Drawing.Point(863, 288);
            this.cbbHlv.Name = "cbbHlv";
            this.cbbHlv.Size = new System.Drawing.Size(303, 37);
            this.cbbHlv.TabIndex = 10;
            this.cbbHlv.DropDown += new System.EventHandler(this.comboBox2_DropDown);
            this.cbbHlv.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cbbma
            // 
            this.cbbma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbma.FormattingEnabled = true;
            this.cbbma.Location = new System.Drawing.Point(863, 388);
            this.cbbma.Name = "cbbma";
            this.cbbma.Size = new System.Drawing.Size(303, 37);
            this.cbbma.TabIndex = 11;
            this.cbbma.DropDown += new System.EventHandler(this.cbbma_DropDown);
            this.cbbma.SelectedIndexChanged += new System.EventHandler(this.cbbma_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 405);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 29);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tên Khách Hàng";
            // 
            // lb_dongia
            // 
            this.lb_dongia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dongia.Location = new System.Drawing.Point(863, 486);
            this.lb_dongia.Name = "lb_dongia";
            this.lb_dongia.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lb_dongia.Size = new System.Drawing.Size(303, 29);
            this.lb_dongia.TabIndex = 103;
            this.lb_dongia.Text = "00";
            this.lb_dongia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(722, 486);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 29);
            this.label1.TabIndex = 104;
            this.label1.Text = "Đơn Giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(299, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(637, 48);
            this.label2.TabIndex = 105;
            this.label2.Text = "Thuê Tập Cùng Huấn Luyện Viên";
            // 
            // btnDangKi
            // 
            this.btnDangKi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKi.Location = new System.Drawing.Point(207, 558);
            this.btnDangKi.Name = "btnDangKi";
            this.btnDangKi.Size = new System.Drawing.Size(122, 63);
            this.btnDangKi.TabIndex = 106;
            this.btnDangKi.Text = "Đăng Kí";
            this.btnDangKi.UseVisualStyleBackColor = true;
            this.btnDangKi.Click += new System.EventHandler(this.btnDangKi_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(901, 558);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 63);
            this.btnCancel.TabIndex = 107;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // KH_DangKiHLV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1220, 688);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDangKi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_dongia);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbbma);
            this.Controls.Add(this.cbbHlv);
            this.Controls.Add(this.cbbCa);
            this.Controls.Add(this.textTen);
            this.Controls.Add(this.textMa);
            this.Controls.Add(this.dateNgayLam);
            this.Controls.Add(this.lbCa);
            this.Controls.Add(this.lbTenhlv);
            this.Controls.Add(this.lbMahlv);
            this.Controls.Add(this.mkh);
            this.Controls.Add(this.lbNgayLam);
            this.MaximumSize = new System.Drawing.Size(1238, 735);
            this.MinimumSize = new System.Drawing.Size(1238, 735);
            this.Name = "KH_DangKiHLV";
            this.Text = "KH_DangKiHLV";
            this.Load += new System.EventHandler(this.KH_DangKiHLV_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNgayLam;
        private System.Windows.Forms.Label mkh;
        private System.Windows.Forms.Label lbMahlv;
        private System.Windows.Forms.Label lbTenhlv;
        private System.Windows.Forms.Label lbCa;
        private System.Windows.Forms.DateTimePicker dateNgayLam;
        private System.Windows.Forms.TextBox textMa;
        private System.Windows.Forms.TextBox textTen;
        private System.Windows.Forms.ComboBox cbbCa;
        private System.Windows.Forms.ComboBox cbbHlv;
        private System.Windows.Forms.ComboBox cbbma;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_dongia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDangKi;
        private System.Windows.Forms.Button btnCancel;
    }
}