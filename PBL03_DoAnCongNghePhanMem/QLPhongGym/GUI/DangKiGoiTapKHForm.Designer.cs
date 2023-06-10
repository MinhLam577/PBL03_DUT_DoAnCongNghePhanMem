namespace QLPhongGym.GUI
{
    partial class DangKiGoiTapKHForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangKiGoiTapKHForm));
            this.lb_main = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_ngayketthuc = new System.Windows.Forms.DateTimePicker();
            this.txb_ghichu = new System.Windows.Forms.TextBox();
            this.cb_gt = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_ngaydangki = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cb_inhoadon = new System.Windows.Forms.CheckBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.numeric_giamgia = new System.Windows.Forms.NumericUpDown();
            this.rb_voucher = new System.Windows.Forms.RadioButton();
            this.rb_tienmat = new System.Windows.Forms.RadioButton();
            this.lb_thanhtoan = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lb_thanhtien = new System.Windows.Forms.Label();
            this.lb_dongia = new System.Windows.Forms.Label();
            this.cb_giamgia = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_giamgia)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_main
            // 
            this.lb_main.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_main.AutoSize = true;
            this.lb_main.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_main.Location = new System.Drawing.Point(468, 21);
            this.lb_main.Name = "lb_main";
            this.lb_main.Size = new System.Drawing.Size(522, 48);
            this.lb_main.TabIndex = 0;
            this.lb_main.Text = "Đăng kí gói tập khách hàng";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 29);
            this.label2.TabIndex = 97;
            this.label2.Text = "Ngày kết thúc:";
            // 
            // dtp_ngayketthuc
            // 
            this.dtp_ngayketthuc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_ngayketthuc.CustomFormat = "dd/MM/yyyy";
            this.dtp_ngayketthuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ngayketthuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngayketthuc.Location = new System.Drawing.Point(225, 207);
            this.dtp_ngayketthuc.Name = "dtp_ngayketthuc";
            this.dtp_ngayketthuc.ShowUpDown = true;
            this.dtp_ngayketthuc.Size = new System.Drawing.Size(388, 34);
            this.dtp_ngayketthuc.TabIndex = 4;
            // 
            // txb_ghichu
            // 
            this.txb_ghichu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txb_ghichu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_ghichu.Location = new System.Drawing.Point(3, 423);
            this.txb_ghichu.Multiline = true;
            this.txb_ghichu.Name = "txb_ghichu";
            this.txb_ghichu.Size = new System.Drawing.Size(610, 289);
            this.txb_ghichu.TabIndex = 5;
            // 
            // cb_gt
            // 
            this.cb_gt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_gt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_gt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_gt.FormattingEnabled = true;
            this.cb_gt.Location = new System.Drawing.Point(225, 102);
            this.cb_gt.Name = "cb_gt";
            this.cb_gt.Size = new System.Drawing.Size(1154, 37);
            this.cb_gt.TabIndex = 2;
            this.cb_gt.SelectedIndexChanged += new System.EventHandler(this.cb_gt_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(92, 391);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 29);
            this.label4.TabIndex = 91;
            this.label4.Text = "Ghi chú:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(97, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 29);
            this.label6.TabIndex = 88;
            this.label6.Text = "Gói tập:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 29);
            this.label1.TabIndex = 86;
            this.label1.Text = "Ngày đăng kí:";
            // 
            // dtp_ngaydangki
            // 
            this.dtp_ngaydangki.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_ngaydangki.CustomFormat = "dd/MM/yyyy";
            this.dtp_ngaydangki.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ngaydangki.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngaydangki.Location = new System.Drawing.Point(225, 157);
            this.dtp_ngaydangki.Name = "dtp_ngaydangki";
            this.dtp_ngaydangki.ShowUpDown = true;
            this.dtp_ngaydangki.Size = new System.Drawing.Size(388, 34);
            this.dtp_ngaydangki.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.cb_inhoadon);
            this.panel2.Controls.Add(this.btn_cancel);
            this.panel2.Controls.Add(this.btn_save);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dtp_ngayketthuc);
            this.panel2.Controls.Add(this.txb_ghichu);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dtp_ngaydangki);
            this.panel2.Location = new System.Drawing.Point(0, -1);
            this.panel2.MaximumSize = new System.Drawing.Size(1432, 728);
            this.panel2.MinimumSize = new System.Drawing.Size(1432, 728);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1432, 728);
            this.panel2.TabIndex = 53;
            // 
            // cb_inhoadon
            // 
            this.cb_inhoadon.AutoSize = true;
            this.cb_inhoadon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_inhoadon.Location = new System.Drawing.Point(847, 684);
            this.cb_inhoadon.Name = "cb_inhoadon";
            this.cb_inhoadon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cb_inhoadon.Size = new System.Drawing.Size(175, 30);
            this.cb_inhoadon.TabIndex = 9;
            this.cb_inhoadon.Text = "IN HÓA ĐƠN";
            this.cb_inhoadon.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_cancel.BackColor = System.Drawing.Color.White;
            this.btn_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btn_cancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.Black;
            this.btn_cancel.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancel.Image")));
            this.btn_cancel.Location = new System.Drawing.Point(1243, 651);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(150, 74);
            this.btn_cancel.TabIndex = 11;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_save.BackColor = System.Drawing.Color.White;
            this.btn_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btn_save.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.Black;
            this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            this.btn_save.Location = new System.Drawing.Point(1058, 651);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(150, 74);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "Save";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.numeric_giamgia);
            this.panel3.Controls.Add(this.rb_voucher);
            this.panel3.Controls.Add(this.rb_tienmat);
            this.panel3.Controls.Add(this.lb_thanhtoan);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.lb_thanhtien);
            this.panel3.Controls.Add(this.lb_dongia);
            this.panel3.Controls.Add(this.cb_giamgia);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(676, 150);
            this.panel3.Name = "panel3";
            this.panel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel3.Size = new System.Drawing.Size(756, 427);
            this.panel3.TabIndex = 101;
            // 
            // numeric_giamgia
            // 
            this.numeric_giamgia.Enabled = false;
            this.numeric_giamgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeric_giamgia.Location = new System.Drawing.Point(261, 81);
            this.numeric_giamgia.Name = "numeric_giamgia";
            this.numeric_giamgia.ReadOnly = true;
            this.numeric_giamgia.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numeric_giamgia.Size = new System.Drawing.Size(442, 41);
            this.numeric_giamgia.TabIndex = 7;
            this.numeric_giamgia.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numeric_giamgia.ValueChanged += new System.EventHandler(this.numeric_giamgia_ValueChanged);
            // 
            // rb_voucher
            // 
            this.rb_voucher.AutoSize = true;
            this.rb_voucher.Enabled = false;
            this.rb_voucher.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_voucher.Location = new System.Drawing.Point(32, 272);
            this.rb_voucher.Name = "rb_voucher";
            this.rb_voucher.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rb_voucher.Size = new System.Drawing.Size(130, 33);
            this.rb_voucher.TabIndex = 8;
            this.rb_voucher.TabStop = true;
            this.rb_voucher.Text = "Voucher";
            this.rb_voucher.UseVisualStyleBackColor = true;
            // 
            // rb_tienmat
            // 
            this.rb_tienmat.AutoSize = true;
            this.rb_tienmat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_tienmat.Location = new System.Drawing.Point(32, 300);
            this.rb_tienmat.Name = "rb_tienmat";
            this.rb_tienmat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rb_tienmat.Size = new System.Drawing.Size(136, 33);
            this.rb_tienmat.TabIndex = 110;
            this.rb_tienmat.TabStop = true;
            this.rb_tienmat.Text = "Tiền mặt";
            this.rb_tienmat.UseVisualStyleBackColor = true;
            // 
            // lb_thanhtoan
            // 
            this.lb_thanhtoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_thanhtoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_thanhtoan.Location = new System.Drawing.Point(407, 239);
            this.lb_thanhtoan.Name = "lb_thanhtoan";
            this.lb_thanhtoan.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lb_thanhtoan.Size = new System.Drawing.Size(301, 29);
            this.lb_thanhtoan.TabIndex = 109;
            this.lb_thanhtoan.Text = "00";
            this.lb_thanhtoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(22, 244);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label13.Size = new System.Drawing.Size(150, 29);
            this.label13.TabIndex = 103;
            this.label13.Text = "Thanh toán:";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(29, 150);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label12.Size = new System.Drawing.Size(143, 29);
            this.label12.TabIndex = 108;
            this.label12.Text = "Thành tiền:";
            // 
            // lb_thanhtien
            // 
            this.lb_thanhtien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_thanhtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_thanhtien.Location = new System.Drawing.Point(407, 150);
            this.lb_thanhtien.Name = "lb_thanhtien";
            this.lb_thanhtien.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lb_thanhtien.Size = new System.Drawing.Size(301, 29);
            this.lb_thanhtien.TabIndex = 107;
            this.lb_thanhtien.Text = "00";
            this.lb_thanhtien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_dongia
            // 
            this.lb_dongia.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lb_dongia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dongia.Location = new System.Drawing.Point(402, 10);
            this.lb_dongia.Name = "lb_dongia";
            this.lb_dongia.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lb_dongia.Size = new System.Drawing.Size(306, 29);
            this.lb_dongia.TabIndex = 102;
            this.lb_dongia.Text = "00";
            this.lb_dongia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cb_giamgia
            // 
            this.cb_giamgia.AutoSize = true;
            this.cb_giamgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_giamgia.Location = new System.Drawing.Point(261, 45);
            this.cb_giamgia.Name = "cb_giamgia";
            this.cb_giamgia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cb_giamgia.Size = new System.Drawing.Size(119, 33);
            this.cb_giamgia.TabIndex = 6;
            this.cb_giamgia.Text = "Giảm%";
            this.cb_giamgia.UseVisualStyleBackColor = true;
            this.cb_giamgia.CheckedChanged += new System.EventHandler(this.cb_giamgia_CheckedChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(46, 93);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(124, 29);
            this.label7.TabIndex = 103;
            this.label7.Text = "Giảm giá:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 10);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(110, 29);
            this.label5.TabIndex = 102;
            this.label5.Text = "Đơn giá:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_main);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cb_gt);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.MaximumSize = new System.Drawing.Size(1432, 142);
            this.panel1.MinimumSize = new System.Drawing.Size(1432, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1432, 142);
            this.panel1.TabIndex = 100;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // DangKiGoiTapKHForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1433, 728);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.MaximumSize = new System.Drawing.Size(1451, 775);
            this.MinimumSize = new System.Drawing.Size(1451, 775);
            this.Name = "DangKiGoiTapKHForm";
            this.Text = "Admin_FormDKiGoiTapKH";
            this.Load += new System.EventHandler(this.DangKiGoiTapFormKH_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_giamgia)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_main;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_ngayketthuc;
        private System.Windows.Forms.TextBox txb_ghichu;
        private System.Windows.Forms.ComboBox cb_gt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_ngaydangki;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown numeric_giamgia;
        private System.Windows.Forms.RadioButton rb_voucher;
        private System.Windows.Forms.RadioButton rb_tienmat;
        private System.Windows.Forms.Label lb_thanhtoan;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lb_thanhtien;
        private System.Windows.Forms.Label lb_dongia;
        private System.Windows.Forms.CheckBox cb_giamgia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.CheckBox cb_inhoadon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}