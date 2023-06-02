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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HLV_FormDanhSachKH));
            this.txb_ten_sdt = new System.Windows.Forms.TextBox();
            this.lb_ten_sdt = new System.Windows.Forms.Label();
            this.dgv_kh = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_description = new System.Windows.Forms.Label();
            this.lb_gioitinh = new System.Windows.Forms.Label();
            this.lb_tenkh = new System.Windows.Forms.Label();
            this.pb_kh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kh)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_kh)).BeginInit();
            this.SuspendLayout();
            // 
            // txb_ten_sdt
            // 
            this.txb_ten_sdt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_ten_sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_ten_sdt.Location = new System.Drawing.Point(105, 41);
            this.txb_ten_sdt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_ten_sdt.Name = "txb_ten_sdt";
            this.txb_ten_sdt.Size = new System.Drawing.Size(266, 34);
            this.txb_ten_sdt.TabIndex = 58;
            // 
            // lb_ten_sdt
            // 
            this.lb_ten_sdt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_ten_sdt.AutoSize = true;
            this.lb_ten_sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ten_sdt.Location = new System.Drawing.Point(3, 44);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_kh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_kh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_kh.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_kh.Location = new System.Drawing.Point(8, 83);
            this.dgv_kh.Name = "dgv_kh";
            this.dgv_kh.ReadOnly = true;
            this.dgv_kh.RowHeadersWidth = 51;
            this.dgv_kh.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_kh.RowTemplate.Height = 24;
            this.dgv_kh.RowTemplate.ReadOnly = true;
            this.dgv_kh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_kh.Size = new System.Drawing.Size(791, 695);
            this.dgv_kh.TabIndex = 59;
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
            this.groupBox2.Size = new System.Drawing.Size(989, 377);
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
            this.lb_description.Location = new System.Drawing.Point(351, 58);
            this.lb_description.Name = "lb_description";
            this.lb_description.Size = new System.Drawing.Size(515, 313);
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
            this.pb_kh.Size = new System.Drawing.Size(339, 300);
            this.pb_kh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_kh.TabIndex = 0;
            this.pb_kh.TabStop = false;
            // 
            // HLV_FormDanhSachKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1811, 781);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgv_kh);
            this.Controls.Add(this.txb_ten_sdt);
            this.Controls.Add(this.lb_ten_sdt);
            this.Name = "HLV_FormDanhSachKH";
            this.Text = "HLV_FormDanhSachKH";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kh)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_kh)).EndInit();
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
    }
}