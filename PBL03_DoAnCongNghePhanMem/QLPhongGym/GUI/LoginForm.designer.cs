namespace QLPhongGym.GUI
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel3 = new System.Windows.Forms.Panel();
            this.lb_SystemName = new System.Windows.Forms.Label();
            this.pb_eye = new System.Windows.Forms.PictureBox();
            this.lb_Dangki = new System.Windows.Forms.Label();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.txb_mk = new System.Windows.Forms.TextBox();
            this.txb_TenTk = new System.Windows.Forms.TextBox();
            this.lb_Matkhau = new System.Windows.Forms.Label();
            this.lb_QuenMk = new System.Windows.Forms.Label();
            this.lb_Tk = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_eye)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.lb_SystemName);
            this.panel3.Controls.Add(this.pb_eye);
            this.panel3.Controls.Add(this.lb_Dangki);
            this.panel3.Controls.Add(this.btn_DangNhap);
            this.panel3.Controls.Add(this.txb_mk);
            this.panel3.Controls.Add(this.txb_TenTk);
            this.panel3.Controls.Add(this.lb_Matkhau);
            this.panel3.Controls.Add(this.lb_QuenMk);
            this.panel3.Controls.Add(this.lb_Tk);
            this.panel3.Location = new System.Drawing.Point(591, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1216, 771);
            this.panel3.TabIndex = 2;
            // 
            // lb_SystemName
            // 
            this.lb_SystemName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_SystemName.AutoSize = true;
            this.lb_SystemName.BackColor = System.Drawing.Color.Transparent;
            this.lb_SystemName.Font = new System.Drawing.Font("Calisto MT", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SystemName.ForeColor = System.Drawing.Color.SpringGreen;
            this.lb_SystemName.Location = new System.Drawing.Point(195, 96);
            this.lb_SystemName.Name = "lb_SystemName";
            this.lb_SystemName.Size = new System.Drawing.Size(777, 70);
            this.lb_SystemName.TabIndex = 24;
            this.lb_SystemName.Text = "Phần mềm quản lý phòng gym";
            // 
            // pb_eye
            // 
            this.pb_eye.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_eye.BackColor = System.Drawing.Color.Transparent;
            this.pb_eye.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_eye.BackgroundImage")));
            this.pb_eye.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_eye.Location = new System.Drawing.Point(881, 356);
            this.pb_eye.Name = "pb_eye";
            this.pb_eye.Size = new System.Drawing.Size(29, 31);
            this.pb_eye.TabIndex = 30;
            this.pb_eye.TabStop = false;
            this.pb_eye.MouseLeave += new System.EventHandler(this.pb_eye_MouseLeave);
            this.pb_eye.MouseHover += new System.EventHandler(this.pb_eye_MouseHover);
            // 
            // lb_Dangki
            // 
            this.lb_Dangki.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_Dangki.AutoSize = true;
            this.lb_Dangki.BackColor = System.Drawing.Color.Transparent;
            this.lb_Dangki.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Dangki.ForeColor = System.Drawing.Color.Aqua;
            this.lb_Dangki.Location = new System.Drawing.Point(355, 558);
            this.lb_Dangki.Name = "lb_Dangki";
            this.lb_Dangki.Size = new System.Drawing.Size(126, 32);
            this.lb_Dangki.TabIndex = 26;
            this.lb_Dangki.Text = "Đăng kí?";
            this.lb_Dangki.Click += new System.EventHandler(this.lb_Dangki_Click);
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_DangNhap.BackColor = System.Drawing.Color.Black;
            this.btn_DangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangNhap.ForeColor = System.Drawing.Color.Aqua;
            this.btn_DangNhap.Location = new System.Drawing.Point(521, 423);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(172, 55);
            this.btn_DangNhap.TabIndex = 25;
            this.btn_DangNhap.Text = "Đăng nhập";
            this.btn_DangNhap.UseVisualStyleBackColor = false;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // txb_mk
            // 
            this.txb_mk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txb_mk.BackColor = System.Drawing.Color.Black;
            this.txb_mk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_mk.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_mk.ForeColor = System.Drawing.Color.Cyan;
            this.txb_mk.Location = new System.Drawing.Point(521, 355);
            this.txb_mk.Name = "txb_mk";
            this.txb_mk.PasswordChar = '*';
            this.txb_mk.Size = new System.Drawing.Size(363, 31);
            this.txb_mk.TabIndex = 23;
            // 
            // txb_TenTk
            // 
            this.txb_TenTk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txb_TenTk.BackColor = System.Drawing.Color.Black;
            this.txb_TenTk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_TenTk.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_TenTk.ForeColor = System.Drawing.Color.Aqua;
            this.txb_TenTk.Location = new System.Drawing.Point(521, 239);
            this.txb_TenTk.Name = "txb_TenTk";
            this.txb_TenTk.Size = new System.Drawing.Size(363, 31);
            this.txb_TenTk.TabIndex = 22;
            // 
            // lb_Matkhau
            // 
            this.lb_Matkhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_Matkhau.AutoSize = true;
            this.lb_Matkhau.BackColor = System.Drawing.Color.Transparent;
            this.lb_Matkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Matkhau.ForeColor = System.Drawing.Color.Aqua;
            this.lb_Matkhau.Location = new System.Drawing.Point(263, 355);
            this.lb_Matkhau.Name = "lb_Matkhau";
            this.lb_Matkhau.Size = new System.Drawing.Size(130, 32);
            this.lb_Matkhau.TabIndex = 29;
            this.lb_Matkhau.Text = "Mật khẩu";
            // 
            // lb_QuenMk
            // 
            this.lb_QuenMk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_QuenMk.AutoSize = true;
            this.lb_QuenMk.BackColor = System.Drawing.Color.Transparent;
            this.lb_QuenMk.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_QuenMk.ForeColor = System.Drawing.Color.Aqua;
            this.lb_QuenMk.Location = new System.Drawing.Point(629, 558);
            this.lb_QuenMk.Name = "lb_QuenMk";
            this.lb_QuenMk.Size = new System.Drawing.Size(223, 32);
            this.lb_QuenMk.TabIndex = 27;
            this.lb_QuenMk.Text = "Quên mật khẩu?";
            this.lb_QuenMk.Click += new System.EventHandler(this.lb_QuenMk_Click_1);
            // 
            // lb_Tk
            // 
            this.lb_Tk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_Tk.AutoSize = true;
            this.lb_Tk.BackColor = System.Drawing.Color.Transparent;
            this.lb_Tk.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Tk.ForeColor = System.Drawing.Color.Aqua;
            this.lb_Tk.ImageKey = "(none)";
            this.lb_Tk.Location = new System.Drawing.Point(263, 238);
            this.lb_Tk.Name = "lb_Tk";
            this.lb_Tk.Size = new System.Drawing.Size(186, 32);
            this.lb_Tk.TabIndex = 28;
            this.lb_Tk.Text = "Tên tài khoản";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Location = new System.Drawing.Point(0, -11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1807, 797);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1804, 784);
            this.Controls.Add(this.groupBox1);
            this.HelpButton = true;
            this.Name = "LoginForm";
            this.Text = "Đăng nhập";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_eye)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pb_eye;
        private System.Windows.Forms.Label lb_Dangki;
        private System.Windows.Forms.Button btn_DangNhap;
        private System.Windows.Forms.TextBox txb_mk;
        private System.Windows.Forms.TextBox txb_TenTk;
        private System.Windows.Forms.Label lb_Matkhau;
        private System.Windows.Forms.Label lb_QuenMk;
        private System.Windows.Forms.Label lb_Tk;
        private System.Windows.Forms.Label lb_SystemName;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}