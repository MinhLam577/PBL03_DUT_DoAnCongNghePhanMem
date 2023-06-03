﻿namespace QLPhongGym.GUI
{
    partial class Admin_DangKiTaiKhoanHLV
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
            this.dgv_tkhlv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_xoa = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_hlv = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_bantk = new System.Windows.Forms.Button();
            this.btn_moban = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_tk = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tkhlv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hlv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_tkhlv
            // 
            this.dgv_tkhlv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_tkhlv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_tkhlv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_tkhlv.BackgroundColor = System.Drawing.Color.White;
            this.dgv_tkhlv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tkhlv.Location = new System.Drawing.Point(668, 153);
            this.dgv_tkhlv.Name = "dgv_tkhlv";
            this.dgv_tkhlv.ReadOnly = true;
            this.dgv_tkhlv.RowHeadersWidth = 51;
            this.dgv_tkhlv.RowTemplate.Height = 24;
            this.dgv_tkhlv.Size = new System.Drawing.Size(706, 600);
            this.dgv_tkhlv.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(525, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tài khoản huấn luyện viên";
            // 
            // button_add
            // 
            this.button_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_add.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.ForeColor = System.Drawing.Color.Aqua;
            this.button_add.Location = new System.Drawing.Point(496, 328);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(138, 49);
            this.button_add.TabIndex = 2;
            this.button_add.Text = "Thêm tài khoản";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_edit
            // 
            this.button_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_edit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_edit.ForeColor = System.Drawing.Color.Aqua;
            this.button_edit.Location = new System.Drawing.Point(496, 422);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(138, 44);
            this.button_edit.TabIndex = 3;
            this.button_edit.Text = "Quên mật khẩu";
            this.button_edit.UseVisualStyleBackColor = false;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_xoa
            // 
            this.button_xoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_xoa.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_xoa.ForeColor = System.Drawing.Color.Aqua;
            this.button_xoa.Location = new System.Drawing.Point(496, 511);
            this.button_xoa.Name = "button_xoa";
            this.button_xoa.Size = new System.Drawing.Size(138, 47);
            this.button_xoa.TabIndex = 4;
            this.button_xoa.Text = "Xóa tài khoản";
            this.button_xoa.UseVisualStyleBackColor = false;
            this.button_xoa.Click += new System.EventHandler(this.button_xoa_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(665, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Danh sách tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Danh sách huấn luyện viên";
            // 
            // dgv_hlv
            // 
            this.dgv_hlv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgv_hlv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_hlv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_hlv.BackgroundColor = System.Drawing.Color.White;
            this.dgv_hlv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hlv.Location = new System.Drawing.Point(31, 153);
            this.dgv_hlv.Name = "dgv_hlv";
            this.dgv_hlv.ReadOnly = true;
            this.dgv_hlv.RowHeadersWidth = 51;
            this.dgv_hlv.RowTemplate.Height = 24;
            this.dgv_hlv.Size = new System.Drawing.Size(426, 600);
            this.dgv_hlv.TabIndex = 12;
            this.dgv_hlv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_hlv_CellClick);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1145, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Search";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(1218, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 27);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_bantk
            // 
            this.btn_bantk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_bantk.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_bantk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bantk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bantk.ForeColor = System.Drawing.Color.Aqua;
            this.btn_bantk.Location = new System.Drawing.Point(496, 602);
            this.btn_bantk.Name = "btn_bantk";
            this.btn_bantk.Size = new System.Drawing.Size(138, 47);
            this.btn_bantk.TabIndex = 16;
            this.btn_bantk.Text = "Ban tài khoản";
            this.btn_bantk.UseVisualStyleBackColor = false;
            this.btn_bantk.Click += new System.EventHandler(this.btn_bantk_Click);
            // 
            // btn_moban
            // 
            this.btn_moban.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_moban.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_moban.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_moban.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_moban.ForeColor = System.Drawing.Color.Aqua;
            this.btn_moban.Location = new System.Drawing.Point(496, 681);
            this.btn_moban.Name = "btn_moban";
            this.btn_moban.Size = new System.Drawing.Size(138, 72);
            this.btn_moban.TabIndex = 17;
            this.btn_moban.Text = "Mở ban tài khoản";
            this.btn_moban.UseVisualStyleBackColor = false;
            this.btn_moban.Click += new System.EventHandler(this.btn_moban_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(644, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Lọc";
            // 
            // cb_tk
            // 
            this.cb_tk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cb_tk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_tk.FormattingEnabled = true;
            this.cb_tk.Items.AddRange(new object[] {
            "Tất cả",
            "Tài khoản cá nhân",
            "Tài khoản đang hoạt động",
            "Tài khoản bị ban"});
            this.cb_tk.Location = new System.Drawing.Point(697, 64);
            this.cb_tk.Name = "cb_tk";
            this.cb_tk.Size = new System.Drawing.Size(333, 28);
            this.cb_tk.TabIndex = 62;
            this.cb_tk.SelectedIndexChanged += new System.EventHandler(this.cb_gt_SelectedIndexChanged);
            // 
            // Admin_DangKiTaiKhoanHLV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1423, 768);
            this.Controls.Add(this.cb_tk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_moban);
            this.Controls.Add(this.btn_bantk);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_hlv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_xoa);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_tkhlv);
            this.Name = "Admin_DangKiTaiKhoanHLV";
            this.Text = "Admin_DangKiTaiKhoanHLV";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tkhlv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hlv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_tkhlv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_xoa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_hlv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_bantk;
        private System.Windows.Forms.Button btn_moban;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_tk;
    }
}