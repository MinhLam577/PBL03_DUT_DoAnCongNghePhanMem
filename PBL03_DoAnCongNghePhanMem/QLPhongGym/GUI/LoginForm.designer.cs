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
            this.lb_SystemName = new System.Windows.Forms.Label();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.txb_mk = new System.Windows.Forms.TextBox();
            this.txb_TenTk = new System.Windows.Forms.TextBox();
            this.lb_Matkhau = new System.Windows.Forms.Label();
            this.lb_QuenMk = new System.Windows.Forms.Label();
            this.lb_Tk = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pb_eye = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_eye)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_SystemName
            // 
            this.lb_SystemName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_SystemName.AutoSize = true;
            this.lb_SystemName.BackColor = System.Drawing.Color.Transparent;
            this.lb_SystemName.Font = new System.Drawing.Font("Calisto MT", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SystemName.ForeColor = System.Drawing.Color.Red;
            this.lb_SystemName.Location = new System.Drawing.Point(773, 129);
            this.lb_SystemName.Name = "lb_SystemName";
            this.lb_SystemName.Size = new System.Drawing.Size(432, 70);
            this.lb_SystemName.TabIndex = 33;
            this.lb_SystemName.Text = "California GYM";
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_DangNhap.BackColor = System.Drawing.Color.Black;
            this.btn_DangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangNhap.ForeColor = System.Drawing.Color.Aqua;
            this.btn_DangNhap.Location = new System.Drawing.Point(872, 466);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(172, 55);
            this.btn_DangNhap.TabIndex = 34;
            this.btn_DangNhap.Text = "Đăng nhập";
            this.btn_DangNhap.UseVisualStyleBackColor = false;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // txb_mk
            // 
            this.txb_mk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txb_mk.BackColor = System.Drawing.Color.White;
            this.txb_mk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_mk.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_mk.ForeColor = System.Drawing.Color.Black;
            this.txb_mk.Location = new System.Drawing.Point(872, 376);
            this.txb_mk.Name = "txb_mk";
            this.txb_mk.PasswordChar = '*';
            this.txb_mk.Size = new System.Drawing.Size(363, 31);
            this.txb_mk.TabIndex = 32;
            // 
            // txb_TenTk
            // 
            this.txb_TenTk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txb_TenTk.BackColor = System.Drawing.Color.White;
            this.txb_TenTk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_TenTk.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_TenTk.ForeColor = System.Drawing.Color.Black;
            this.txb_TenTk.Location = new System.Drawing.Point(872, 288);
            this.txb_TenTk.Name = "txb_TenTk";
            this.txb_TenTk.Size = new System.Drawing.Size(363, 31);
            this.txb_TenTk.TabIndex = 31;
            // 
            // lb_Matkhau
            // 
            this.lb_Matkhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_Matkhau.AutoSize = true;
            this.lb_Matkhau.BackColor = System.Drawing.Color.Transparent;
            this.lb_Matkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Matkhau.ForeColor = System.Drawing.Color.Black;
            this.lb_Matkhau.Location = new System.Drawing.Point(670, 375);
            this.lb_Matkhau.Name = "lb_Matkhau";
            this.lb_Matkhau.Size = new System.Drawing.Size(138, 32);
            this.lb_Matkhau.TabIndex = 38;
            this.lb_Matkhau.Text = "Mật khẩu:";
            // 
            // lb_QuenMk
            // 
            this.lb_QuenMk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_QuenMk.AutoSize = true;
            this.lb_QuenMk.BackColor = System.Drawing.Color.Transparent;
            this.lb_QuenMk.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_QuenMk.ForeColor = System.Drawing.Color.Black;
            this.lb_QuenMk.Location = new System.Drawing.Point(847, 556);
            this.lb_QuenMk.Name = "lb_QuenMk";
            this.lb_QuenMk.Size = new System.Drawing.Size(223, 32);
            this.lb_QuenMk.TabIndex = 36;
            this.lb_QuenMk.Text = "Quên mật khẩu?";
            this.lb_QuenMk.Click += new System.EventHandler(this.lb_QuenMk_Click_1);
            // 
            // lb_Tk
            // 
            this.lb_Tk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_Tk.AutoSize = true;
            this.lb_Tk.BackColor = System.Drawing.Color.Transparent;
            this.lb_Tk.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Tk.ForeColor = System.Drawing.Color.Black;
            this.lb_Tk.ImageKey = "(none)";
            this.lb_Tk.Location = new System.Drawing.Point(614, 288);
            this.lb_Tk.Name = "lb_Tk";
            this.lb_Tk.Size = new System.Drawing.Size(194, 32);
            this.lb_Tk.TabIndex = 37;
            this.lb_Tk.Text = "Tên tài khoản:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(586, 784);
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // pb_eye
            // 
            this.pb_eye.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_eye.BackColor = System.Drawing.Color.White;
            this.pb_eye.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_eye.BackgroundImage")));
            this.pb_eye.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_eye.Location = new System.Drawing.Point(1206, 376);
            this.pb_eye.Name = "pb_eye";
            this.pb_eye.Size = new System.Drawing.Size(29, 31);
            this.pb_eye.TabIndex = 39;
            this.pb_eye.TabStop = false;
            this.pb_eye.MouseLeave += new System.EventHandler(this.pb_eye_MouseLeave);
            this.pb_eye.MouseHover += new System.EventHandler(this.pb_eye_MouseHover);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Linen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1405, 784);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lb_SystemName);
            this.Controls.Add(this.pb_eye);
            this.Controls.Add(this.btn_DangNhap);
            this.Controls.Add(this.txb_mk);
            this.Controls.Add(this.txb_TenTk);
            this.Controls.Add(this.lb_Matkhau);
            this.Controls.Add(this.lb_QuenMk);
            this.Controls.Add(this.lb_Tk);
            this.ForeColor = System.Drawing.Color.White;
            this.HelpButton = true;
            this.MaximumSize = new System.Drawing.Size(1423, 831);
            this.MinimumSize = new System.Drawing.Size(1423, 831);
            this.Name = "LoginForm";
            this.Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_eye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_SystemName;
        private System.Windows.Forms.PictureBox pb_eye;
        private System.Windows.Forms.Button btn_DangNhap;
        private System.Windows.Forms.TextBox txb_mk;
        private System.Windows.Forms.TextBox txb_TenTk;
        private System.Windows.Forms.Label lb_Matkhau;
        private System.Windows.Forms.Label lb_QuenMk;
        private System.Windows.Forms.Label lb_Tk;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}