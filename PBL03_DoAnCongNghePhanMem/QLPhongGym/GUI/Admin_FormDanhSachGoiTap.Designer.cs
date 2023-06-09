namespace QLPhongGym.GUI
{
    partial class Admin_FormDanhSachGoiTap
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
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_TenGT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.txt_MGT = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_reset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_thoihan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Price
            // 
            this.txt_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Price.Location = new System.Drawing.Point(167, 386);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(194, 30);
            this.txt_Price.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 25);
            this.label4.TabIndex = 37;
            this.label4.Text = "Giá:";
            // 
            // txt_TenGT
            // 
            this.txt_TenGT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenGT.Location = new System.Drawing.Point(167, 274);
            this.txt_TenGT.Name = "txt_TenGT";
            this.txt_TenGT.Size = new System.Drawing.Size(194, 30);
            this.txt_TenGT.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "Gói tập:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "Mã gói tập:";
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.Cyan;
            this.btn_them.Location = new System.Drawing.Point(26, 465);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 44);
            this.btn_them.TabIndex = 4;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.Cyan;
            this.btn_Xoa.Location = new System.Drawing.Point(412, 465);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 44);
            this.btn_Xoa.TabIndex = 7;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.Color.Cyan;
            this.btn_Sua.Location = new System.Drawing.Point(154, 465);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 44);
            this.btn_Sua.TabIndex = 5;
            this.btn_Sua.Text = "Sửa ";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // txt_MGT
            // 
            this.txt_MGT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MGT.Location = new System.Drawing.Point(167, 219);
            this.txt_MGT.Name = "txt_MGT";
            this.txt_MGT.ReadOnly = true;
            this.txt_MGT.Size = new System.Drawing.Size(194, 30);
            this.txt_MGT.TabIndex = 42;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Linen;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(522, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(475, 489);
            this.dataGridView1.TabIndex = 43;
            this.dataGridView1.DataSourceChanged += new System.EventHandler(this.dataGridView1_DataSourceChanged);
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.Color.Cyan;
            this.btn_reset.Location = new System.Drawing.Point(281, 465);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 44);
            this.btn_reset.TabIndex = 6;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(403, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 50);
            this.label2.TabIndex = 45;
            this.label2.Text = "Gói tập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 25);
            this.label5.TabIndex = 46;
            this.label5.Text = "Thời hạn:";
            // 
            // txt_thoihan
            // 
            this.txt_thoihan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_thoihan.Location = new System.Drawing.Point(167, 327);
            this.txt_thoihan.Name = "txt_thoihan";
            this.txt_thoihan.Size = new System.Drawing.Size(117, 30);
            this.txt_thoihan.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(290, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 25);
            this.label6.TabIndex = 48;
            this.label6.Text = "Tháng";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(517, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 26);
            this.label7.TabIndex = 49;
            this.label7.Text = "Danh sách gói tập";
            // 
            // Admin_FormDanhSachGoiTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1009, 664);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_thoihan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_MGT);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_TenGT);
            this.Controls.Add(this.label3);
            this.MinimumSize = new System.Drawing.Size(1027, 711);
            this.Name = "Admin_FormDanhSachGoiTap";
            this.Text = "Admin_FormDanhSachGoiTap";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_TenGT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.TextBox txt_MGT;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_thoihan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}