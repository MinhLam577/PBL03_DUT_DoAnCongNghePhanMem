namespace QLPhongGym.GUI
{
    partial class HLV_FormDanhSachKH
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HLV_FormDanhSachKH));
            this.txb_ten_sdt = new System.Windows.Forms.TextBox();
            this.lb_ten_sdt = new System.Windows.Forms.Label();
            this.dgv_kh = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_description = new System.Windows.Forms.Label();
            this.lb_gioitinh = new System.Windows.Forms.Label();
            this.lb_tenkh = new System.Windows.Forms.Label();
            this.pb_kh = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_batdau = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_ketthuc = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_nt = new System.Windows.Forms.DateTimePicker();
            this.cb_tenca = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_detailca = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_gt = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kh)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_kh)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txb_ten_sdt
            // 
            this.txb_ten_sdt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_ten_sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_ten_sdt.Location = new System.Drawing.Point(136, 121);
            this.txb_ten_sdt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_ten_sdt.Name = "txb_ten_sdt";
            this.txb_ten_sdt.Size = new System.Drawing.Size(632, 34);
            this.txb_ten_sdt.TabIndex = 58;
            this.txb_ten_sdt.TextChanged += new System.EventHandler(this.txb_ten_sdt_TextChanged);
            // 
            // lb_ten_sdt
            // 
            this.lb_ten_sdt.AutoSize = true;
            this.lb_ten_sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ten_sdt.Location = new System.Drawing.Point(35, 124);
            this.lb_ten_sdt.Name = "lb_ten_sdt";
            this.lb_ten_sdt.Size = new System.Drawing.Size(95, 29);
            this.lb_ten_sdt.TabIndex = 57;
            this.lb_ten_sdt.Text = "Search:";
            this.lb_ten_sdt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgv_kh
            // 
            this.dgv_kh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_kh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_kh.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_kh.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_kh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_kh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_kh.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_kh.Location = new System.Drawing.Point(8, 192);
            this.dgv_kh.Name = "dgv_kh";
            this.dgv_kh.ReadOnly = true;
            this.dgv_kh.RowHeadersWidth = 51;
            this.dgv_kh.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_kh.RowTemplate.Height = 24;
            this.dgv_kh.RowTemplate.ReadOnly = true;
            this.dgv_kh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_kh.Size = new System.Drawing.Size(791, 586);
            this.dgv_kh.TabIndex = 59;
            this.dgv_kh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_kh_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lb_description);
            this.groupBox2.Controls.Add(this.lb_gioitinh);
            this.groupBox2.Controls.Add(this.lb_tenkh);
            this.groupBox2.Controls.Add(this.pb_kh);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(805, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(814, 402);
            this.groupBox2.TabIndex = 60;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết";
            // 
            // lb_description
            // 
            this.lb_description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_description.ForeColor = System.Drawing.Color.Blue;
            this.lb_description.Location = new System.Drawing.Point(351, 71);
            this.lb_description.Name = "lb_description";
            this.lb_description.Size = new System.Drawing.Size(381, 325);
            this.lb_description.TabIndex = 4;
            // 
            // lb_gioitinh
            // 
            this.lb_gioitinh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_gioitinh.AutoSize = true;
            this.lb_gioitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_gioitinh.ForeColor = System.Drawing.Color.Blue;
            this.lb_gioitinh.Location = new System.Drawing.Point(360, 30);
            this.lb_gioitinh.Name = "lb_gioitinh";
            this.lb_gioitinh.Size = new System.Drawing.Size(0, 38);
            this.lb_gioitinh.TabIndex = 3;
            this.lb_gioitinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_tenkh
            // 
            this.lb_tenkh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_tenkh.AutoSize = true;
            this.lb_tenkh.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tenkh.ForeColor = System.Drawing.Color.Blue;
            this.lb_tenkh.Location = new System.Drawing.Point(5, 34);
            this.lb_tenkh.Name = "lb_tenkh";
            this.lb_tenkh.Size = new System.Drawing.Size(0, 38);
            this.lb_tenkh.TabIndex = 2;
            this.lb_tenkh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pb_kh
            // 
            this.pb_kh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pb_kh.Image = ((System.Drawing.Image)(resources.GetObject("pb_kh.Image")));
            this.pb_kh.Location = new System.Drawing.Point(6, 71);
            this.pb_kh.Name = "pb_kh";
            this.pb_kh.Size = new System.Drawing.Size(339, 325);
            this.pb_kh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_kh.TabIndex = 0;
            this.pb_kh.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.cb_gt);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cb_detailca);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.lb_ketthuc);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lb_batdau);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(805, 420);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(814, 358);
            this.groupBox3.TabIndex = 61;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin tập luyện";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(440, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 29);
            this.label1.TabIndex = 65;
            this.label1.Text = "Ca:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 29);
            this.label3.TabIndex = 67;
            this.label3.Text = "Thời gian bắt đầu:";
            // 
            // lb_batdau
            // 
            this.lb_batdau.AutoSize = true;
            this.lb_batdau.Location = new System.Drawing.Point(362, 204);
            this.lb_batdau.Name = "lb_batdau";
            this.lb_batdau.Size = new System.Drawing.Size(41, 29);
            this.lb_batdau.TabIndex = 68;
            this.lb_batdau.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 29);
            this.label4.TabIndex = 69;
            this.label4.Text = "Thời gian kết thúc:";
            // 
            // lb_ketthuc
            // 
            this.lb_ketthuc.AutoSize = true;
            this.lb_ketthuc.Location = new System.Drawing.Point(362, 281);
            this.lb_ketthuc.Name = "lb_ketthuc";
            this.lb_ketthuc.Size = new System.Drawing.Size(41, 29);
            this.lb_ketthuc.TabIndex = 70;
            this.lb_ketthuc.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 29);
            this.label5.TabIndex = 71;
            this.label5.Text = "Ngày thuê:";
            // 
            // dtp_nt
            // 
            this.dtp_nt.CustomFormat = "dd/MM/yyyy";
            this.dtp_nt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_nt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_nt.Location = new System.Drawing.Point(136, 46);
            this.dtp_nt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtp_nt.Name = "dtp_nt";
            this.dtp_nt.ShowUpDown = true;
            this.dtp_nt.Size = new System.Drawing.Size(260, 41);
            this.dtp_nt.TabIndex = 72;
            this.dtp_nt.ValueChanged += new System.EventHandler(this.dtp_ns_ValueChanged);
            // 
            // cb_tenca
            // 
            this.cb_tenca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_tenca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tenca.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_tenca.FormattingEnabled = true;
            this.cb_tenca.Location = new System.Drawing.Point(495, 48);
            this.cb_tenca.Name = "cb_tenca";
            this.cb_tenca.Size = new System.Drawing.Size(273, 37);
            this.cb_tenca.TabIndex = 73;
            this.cb_tenca.SelectedIndexChanged += new System.EventHandler(this.cb_tenca_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 29);
            this.label2.TabIndex = 74;
            this.label2.Text = "Ca:";
            // 
            // cb_detailca
            // 
            this.cb_detailca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_detailca.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_detailca.FormattingEnabled = true;
            this.cb_detailca.Location = new System.Drawing.Point(367, 124);
            this.cb_detailca.Name = "cb_detailca";
            this.cb_detailca.Size = new System.Drawing.Size(348, 37);
            this.cb_detailca.TabIndex = 75;
            this.cb_detailca.SelectedIndexChanged += new System.EventHandler(this.cb_detailca_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(172, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 29);
            this.label6.TabIndex = 76;
            this.label6.Text = "Gói tập:";
            // 
            // cb_gt
            // 
            this.cb_gt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_gt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_gt.FormattingEnabled = true;
            this.cb_gt.Location = new System.Drawing.Point(367, 56);
            this.cb_gt.Name = "cb_gt";
            this.cb_gt.Size = new System.Drawing.Size(348, 37);
            this.cb_gt.TabIndex = 77;
            // 
            // HLV_FormDanhSachKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1811, 781);
            this.Controls.Add(this.dtp_nt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_tenca);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgv_kh);
            this.Controls.Add(this.txb_ten_sdt);
            this.Controls.Add(this.lb_ten_sdt);
            this.Controls.Add(this.label1);
            this.Name = "HLV_FormDanhSachKH";
            this.Text = "HLV_FormDanhSachKH";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kh)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_kh)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txb_ten_sdt;
        private System.Windows.Forms.Label lb_ten_sdt;
        private System.Windows.Forms.DataGridView dgv_kh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lb_description;
        private System.Windows.Forms.Label lb_gioitinh;
        private System.Windows.Forms.Label lb_tenkh;
        private System.Windows.Forms.PictureBox pb_kh;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lb_ketthuc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_batdau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_nt;
        private System.Windows.Forms.ComboBox cb_tenca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_detailca;
        private System.Windows.Forms.ComboBox cb_gt;
        private System.Windows.Forms.Label label6;
    }
}