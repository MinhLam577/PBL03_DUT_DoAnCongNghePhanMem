namespace QLPhongGym.GUI
{
    partial class DangKiAdminOrKHForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangKiAdminOrKHForm));
            this.lb_tenhethong = new System.Windows.Forms.Label();
            this.lb_sex = new System.Windows.Forms.Label();
            this.btn_dangki = new System.Windows.Forms.Button();
            this.lb_hvt = new System.Windows.Forms.Label();
            this.lb_age = new System.Windows.Forms.Label();
            this.lb_address = new System.Windows.Forms.Label();
            this.lb_cmnd = new System.Windows.Forms.Label();
            this.txb_hvt = new System.Windows.Forms.TextBox();
            this.txb_cmnd = new System.Windows.Forms.TextBox();
            this.txb_address = new System.Windows.Forms.TextBox();
            this.cb_sex = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.dtp_ns = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_tenhethong
            // 
            this.lb_tenhethong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_tenhethong.AutoSize = true;
            this.lb_tenhethong.BackColor = System.Drawing.Color.Transparent;
            this.lb_tenhethong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_tenhethong.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tenhethong.ForeColor = System.Drawing.Color.DarkRed;
            this.lb_tenhethong.Location = new System.Drawing.Point(974, 47);
            this.lb_tenhethong.Name = "lb_tenhethong";
            this.lb_tenhethong.Size = new System.Drawing.Size(396, 50);
            this.lb_tenhethong.TabIndex = 0;
            this.lb_tenhethong.Text = "Thông tin cá nhân";
            // 
            // lb_sex
            // 
            this.lb_sex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lb_sex.AutoSize = true;
            this.lb_sex.BackColor = System.Drawing.Color.Transparent;
            this.lb_sex.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sex.ForeColor = System.Drawing.Color.Black;
            this.lb_sex.Location = new System.Drawing.Point(858, 397);
            this.lb_sex.Name = "lb_sex";
            this.lb_sex.Size = new System.Drawing.Size(117, 29);
            this.lb_sex.TabIndex = 19;
            this.lb_sex.Text = "Giới tính:";
            // 
            // btn_dangki
            // 
            this.btn_dangki.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_dangki.BackColor = System.Drawing.Color.Black;
            this.btn_dangki.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dangki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dangki.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangki.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_dangki.Location = new System.Drawing.Point(924, 705);
            this.btn_dangki.Name = "btn_dangki";
            this.btn_dangki.Size = new System.Drawing.Size(177, 44);
            this.btn_dangki.TabIndex = 12;
            this.btn_dangki.Text = "Đăng kí";
            this.btn_dangki.UseVisualStyleBackColor = false;
            this.btn_dangki.Click += new System.EventHandler(this.btn_dangki_Click);
            // 
            // lb_hvt
            // 
            this.lb_hvt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lb_hvt.AutoSize = true;
            this.lb_hvt.BackColor = System.Drawing.Color.Transparent;
            this.lb_hvt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hvt.ForeColor = System.Drawing.Color.Black;
            this.lb_hvt.Location = new System.Drawing.Point(858, 165);
            this.lb_hvt.Name = "lb_hvt";
            this.lb_hvt.Size = new System.Drawing.Size(129, 29);
            this.lb_hvt.TabIndex = 17;
            this.lb_hvt.Text = "Họ và tên:";
            // 
            // lb_age
            // 
            this.lb_age.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lb_age.AutoSize = true;
            this.lb_age.BackColor = System.Drawing.Color.Transparent;
            this.lb_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_age.ForeColor = System.Drawing.Color.Black;
            this.lb_age.Location = new System.Drawing.Point(858, 284);
            this.lb_age.Name = "lb_age";
            this.lb_age.Size = new System.Drawing.Size(135, 29);
            this.lb_age.TabIndex = 18;
            this.lb_age.Text = "Ngày sinh:";
            // 
            // lb_address
            // 
            this.lb_address.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lb_address.AutoSize = true;
            this.lb_address.BackColor = System.Drawing.Color.Transparent;
            this.lb_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_address.ForeColor = System.Drawing.Color.Black;
            this.lb_address.Location = new System.Drawing.Point(858, 615);
            this.lb_address.Name = "lb_address";
            this.lb_address.Size = new System.Drawing.Size(93, 29);
            this.lb_address.TabIndex = 21;
            this.lb_address.Text = "Địa chỉ";
            // 
            // lb_cmnd
            // 
            this.lb_cmnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lb_cmnd.AutoSize = true;
            this.lb_cmnd.BackColor = System.Drawing.Color.Transparent;
            this.lb_cmnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cmnd.ForeColor = System.Drawing.Color.Black;
            this.lb_cmnd.Location = new System.Drawing.Point(858, 507);
            this.lb_cmnd.Name = "lb_cmnd";
            this.lb_cmnd.Size = new System.Drawing.Size(176, 29);
            this.lb_cmnd.TabIndex = 20;
            this.lb_cmnd.Text = "CMND/CCCD:";
            // 
            // txb_hvt
            // 
            this.txb_hvt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txb_hvt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_hvt.Location = new System.Drawing.Point(1118, 162);
            this.txb_hvt.Name = "txb_hvt";
            this.txb_hvt.Size = new System.Drawing.Size(306, 34);
            this.txb_hvt.TabIndex = 5;
            // 
            // txb_cmnd
            // 
            this.txb_cmnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txb_cmnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_cmnd.Location = new System.Drawing.Point(1118, 504);
            this.txb_cmnd.Name = "txb_cmnd";
            this.txb_cmnd.Size = new System.Drawing.Size(306, 34);
            this.txb_cmnd.TabIndex = 8;
            // 
            // txb_address
            // 
            this.txb_address.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txb_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_address.Location = new System.Drawing.Point(1118, 612);
            this.txb_address.Name = "txb_address";
            this.txb_address.Size = new System.Drawing.Size(306, 34);
            this.txb_address.TabIndex = 9;
            // 
            // cb_sex
            // 
            this.cb_sex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cb_sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_sex.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_sex.FormattingEnabled = true;
            this.cb_sex.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cb_sex.Location = new System.Drawing.Point(1118, 394);
            this.cb_sex.Name = "cb_sex";
            this.cb_sex.Size = new System.Drawing.Size(306, 37);
            this.cb_sex.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(753, 783);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btn_back
            // 
            this.btn_back.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_back.BackColor = System.Drawing.Color.Black;
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_back.Location = new System.Drawing.Point(1178, 704);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(177, 45);
            this.btn_back.TabIndex = 13;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // dtp_ns
            // 
            this.dtp_ns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dtp_ns.CustomFormat = "dd/MM/yyyy";
            this.dtp_ns.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ns.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ns.Location = new System.Drawing.Point(1118, 279);
            this.dtp_ns.Name = "dtp_ns";
            this.dtp_ns.Size = new System.Drawing.Size(306, 34);
            this.dtp_ns.TabIndex = 6;
            // 
            // DangKiAdminOrKHForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1490, 781);
            this.Controls.Add(this.dtp_ns);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.cb_sex);
            this.Controls.Add(this.txb_address);
            this.Controls.Add(this.txb_cmnd);
            this.Controls.Add(this.txb_hvt);
            this.Controls.Add(this.lb_cmnd);
            this.Controls.Add(this.lb_address);
            this.Controls.Add(this.lb_age);
            this.Controls.Add(this.lb_hvt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_dangki);
            this.Controls.Add(this.lb_sex);
            this.Controls.Add(this.lb_tenhethong);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DangKiAdminOrKHForm";
            this.Text = "Đăng kí";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_tenhethong;
        private System.Windows.Forms.Label lb_sex;
        private System.Windows.Forms.Button btn_dangki;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_hvt;
        private System.Windows.Forms.Label lb_age;
        private System.Windows.Forms.Label lb_address;
        private System.Windows.Forms.Label lb_cmnd;
        private System.Windows.Forms.TextBox txb_hvt;
        private System.Windows.Forms.TextBox txb_cmnd;
        private System.Windows.Forms.TextBox txb_address;
        private System.Windows.Forms.ComboBox cb_sex;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.DateTimePicker dtp_ns;
    }
}