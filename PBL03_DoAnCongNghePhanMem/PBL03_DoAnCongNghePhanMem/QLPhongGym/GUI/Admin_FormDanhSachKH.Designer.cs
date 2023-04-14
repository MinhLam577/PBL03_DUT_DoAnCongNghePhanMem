namespace QLPhongGym.GUI
{
    partial class Admin_FormDanhSachKH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_FormDanhSachKH));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txb_search = new System.Windows.Forms.TextBox();
            this.cb_sapxep = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_sapxep = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.pb_kh = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_kh)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.txb_search);
            this.panel1.Controls.Add(this.cb_sapxep);
            this.panel1.Controls.Add(this.btn_sapxep);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1560, 442);
            this.panel1.TabIndex = 64;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(0, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1557, 288);
            this.dataGridView1.TabIndex = 49;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txb_search
            // 
            this.txb_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txb_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_search.Location = new System.Drawing.Point(0, 113);
            this.txb_search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_search.Name = "txb_search";
            this.txb_search.Size = new System.Drawing.Size(368, 34);
            this.txb_search.TabIndex = 44;
            // 
            // cb_sapxep
            // 
            this.cb_sapxep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_sapxep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_sapxep.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_sapxep.FormattingEnabled = true;
            this.cb_sapxep.Items.AddRange(new object[] {
            "Mã",
            "Tên",
            "Giới tính",
            "Gói tập"});
            this.cb_sapxep.Location = new System.Drawing.Point(1281, 112);
            this.cb_sapxep.Name = "cb_sapxep";
            this.cb_sapxep.Size = new System.Drawing.Size(276, 37);
            this.cb_sapxep.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(534, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 38);
            this.label1.TabIndex = 48;
            this.label1.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_search.BackgroundImage")));
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(375, 114);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(42, 30);
            this.btn_search.TabIndex = 45;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_sapxep
            // 
            this.btn_sapxep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sapxep.BackColor = System.Drawing.Color.Black;
            this.btn_sapxep.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sapxep.ForeColor = System.Drawing.Color.Cyan;
            this.btn_sapxep.Image = ((System.Drawing.Image)(resources.GetObject("btn_sapxep.Image")));
            this.btn_sapxep.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_sapxep.Location = new System.Drawing.Point(1136, 108);
            this.btn_sapxep.Name = "btn_sapxep";
            this.btn_sapxep.Size = new System.Drawing.Size(139, 44);
            this.btn_sapxep.TabIndex = 47;
            this.btn_sapxep.Text = "Sắp xếp";
            this.btn_sapxep.UseVisualStyleBackColor = false;
            this.btn_sapxep.Click += new System.EventHandler(this.btn_sapxep_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_xoa.BackColor = System.Drawing.Color.Black;
            this.btn_xoa.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.Color.Cyan;
            this.btn_xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoa.Image")));
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_xoa.Location = new System.Drawing.Point(443, 568);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(139, 44);
            this.btn_xoa.TabIndex = 13;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_sua.BackColor = System.Drawing.Color.Black;
            this.btn_sua.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.Color.Cyan;
            this.btn_sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_sua.Image")));
            this.btn_sua.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_sua.Location = new System.Drawing.Point(750, 568);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(139, 44);
            this.btn_sua.TabIndex = 12;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_them.BackColor = System.Drawing.Color.Black;
            this.btn_them.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.Cyan;
            this.btn_them.Image = ((System.Drawing.Image)(resources.GetObject("btn_them.Image")));
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_them.Location = new System.Drawing.Point(135, 568);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(139, 44);
            this.btn_them.TabIndex = 10;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // pb_kh
            // 
            this.pb_kh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_kh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_kh.Image = ((System.Drawing.Image)(resources.GetObject("pb_kh.Image")));
            this.pb_kh.Location = new System.Drawing.Point(1083, 450);
            this.pb_kh.Name = "pb_kh";
            this.pb_kh.Size = new System.Drawing.Size(344, 265);
            this.pb_kh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_kh.TabIndex = 63;
            this.pb_kh.TabStop = false;
            // 
            // Admin_FormDanhSachKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1559, 717);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.pb_kh);
            this.Name = "Admin_FormDanhSachKH";
            this.Text = "Admin_FormDanhSachKH";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_kh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.PictureBox pb_kh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txb_search;
        private System.Windows.Forms.ComboBox cb_sapxep;
        private System.Windows.Forms.Button btn_sapxep;
        private System.Windows.Forms.Label label1;
    }
}