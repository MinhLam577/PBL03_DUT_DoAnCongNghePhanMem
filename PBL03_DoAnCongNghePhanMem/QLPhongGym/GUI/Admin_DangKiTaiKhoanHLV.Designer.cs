namespace QLPhongGym.GUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dgv_tkhlv.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dgv_tkhlv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_tkhlv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_tkhlv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_tkhlv.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_tkhlv.EnableHeadersVisualStyles = false;
            this.dgv_tkhlv.Location = new System.Drawing.Point(668, 153);
            this.dgv_tkhlv.Name = "dgv_tkhlv";
            this.dgv_tkhlv.ReadOnly = true;
            this.dgv_tkhlv.RowHeadersVisible = false;
            this.dgv_tkhlv.RowHeadersWidth = 51;
            this.dgv_tkhlv.RowTemplate.Height = 24;
            this.dgv_tkhlv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tkhlv.Size = new System.Drawing.Size(750, 614);
            this.dgv_tkhlv.TabIndex = 0;
            this.dgv_tkhlv.DataSourceChanged += new System.EventHandler(this.dgv_tkhlv_DataSourceChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(-1, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(662, 63);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tài khoản huấn luyện viên";
            // 
            // button_add
            // 
            this.button_add.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_add.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.ForeColor = System.Drawing.Color.Aqua;
            this.button_add.Location = new System.Drawing.Point(470, 171);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(138, 73);
            this.button_add.TabIndex = 2;
            this.button_add.Text = "Thêm tài khoản";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_edit
            // 
            this.button_edit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_edit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_edit.ForeColor = System.Drawing.Color.Aqua;
            this.button_edit.Location = new System.Drawing.Point(470, 286);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(138, 64);
            this.button_edit.TabIndex = 3;
            this.button_edit.Text = "Quên mật khẩu";
            this.button_edit.UseVisualStyleBackColor = false;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_xoa
            // 
            this.button_xoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_xoa.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_xoa.ForeColor = System.Drawing.Color.Aqua;
            this.button_xoa.Location = new System.Drawing.Point(470, 384);
            this.button_xoa.Name = "button_xoa";
            this.button_xoa.Size = new System.Drawing.Size(138, 67);
            this.button_xoa.TabIndex = 4;
            this.button_xoa.Text = "Xóa tài khoản";
            this.button_xoa.UseVisualStyleBackColor = false;
            this.button_xoa.Click += new System.EventHandler(this.button_xoa_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(663, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 26);
            this.label5.TabIndex = 11;
            this.label5.Text = "Danh sách tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 26);
            this.label2.TabIndex = 13;
            this.label2.Text = "Danh sách huấn luyện viên";
            // 
            // dgv_hlv
            // 
            this.dgv_hlv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgv_hlv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_hlv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_hlv.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dgv_hlv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_hlv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_hlv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_hlv.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_hlv.EnableHeadersVisualStyles = false;
            this.dgv_hlv.Location = new System.Drawing.Point(1, 153);
            this.dgv_hlv.Name = "dgv_hlv";
            this.dgv_hlv.ReadOnly = true;
            this.dgv_hlv.RowHeadersVisible = false;
            this.dgv_hlv.RowHeadersWidth = 51;
            this.dgv_hlv.RowTemplate.Height = 24;
            this.dgv_hlv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_hlv.Size = new System.Drawing.Size(463, 614);
            this.dgv_hlv.TabIndex = 12;
            this.dgv_hlv.DataSourceChanged += new System.EventHandler(this.dgv_hlv_DataSourceChanged);
            this.dgv_hlv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_hlv_CellClick);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1134, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Search";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(1215, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 27);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_bantk
            // 
            this.btn_bantk.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_bantk.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_bantk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bantk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bantk.ForeColor = System.Drawing.Color.Aqua;
            this.btn_bantk.Location = new System.Drawing.Point(470, 481);
            this.btn_bantk.Name = "btn_bantk";
            this.btn_bantk.Size = new System.Drawing.Size(138, 67);
            this.btn_bantk.TabIndex = 16;
            this.btn_bantk.Text = "Ban tài khoản";
            this.btn_bantk.UseVisualStyleBackColor = false;
            this.btn_bantk.Click += new System.EventHandler(this.btn_bantk_Click);
            // 
            // btn_moban
            // 
            this.btn_moban.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_moban.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_moban.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_moban.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_moban.ForeColor = System.Drawing.Color.Aqua;
            this.btn_moban.Location = new System.Drawing.Point(470, 576);
            this.btn_moban.Name = "btn_moban";
            this.btn_moban.Size = new System.Drawing.Size(138, 92);
            this.btn_moban.TabIndex = 17;
            this.btn_moban.Text = "Mở ban tài khoản";
            this.btn_moban.UseVisualStyleBackColor = false;
            this.btn_moban.Click += new System.EventHandler(this.btn_moban_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(667, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 26);
            this.label4.TabIndex = 18;
            this.label4.Text = "Lọc";
            // 
            // cb_tk
            // 
            this.cb_tk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_tk.FormattingEnabled = true;
            this.cb_tk.Items.AddRange(new object[] {
            "Tất cả",
            "Tài khoản cá nhân",
            "Tài khoản đang hoạt động",
            "Tài khoản bị ban"});
            this.cb_tk.Location = new System.Drawing.Point(728, 45);
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