﻿namespace QLPhongGym.GUI
{
    partial class HLV_FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HLV_FormMain));
            this.btn_lichlamviec = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lb_home = new System.Windows.Forms.Label();
            this.lb_acc = new System.Windows.Forms.Label();
            this.pn_tkhlv = new System.Windows.Forms.Panel();
            this.btn_doimatkhau = new System.Windows.Forms.Button();
            this.btn_updatethongtin = new System.Windows.Forms.Button();
            this.lb_gmailhlv = new System.Windows.Forms.Label();
            this.lb_tenhlv = new System.Windows.Forms.Label();
            this.pb_updateimage = new System.Windows.Forms.PictureBox();
            this.pb_hlv = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pb_acc = new System.Windows.Forms.PictureBox();
            this.pb_home = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pn_tkhlv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_updateimage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_hlv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_acc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_lichlamviec
            // 
            this.btn_lichlamviec.BackColor = System.Drawing.Color.Black;
            this.btn_lichlamviec.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_lichlamviec.FlatAppearance.BorderSize = 0;
            this.btn_lichlamviec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lichlamviec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lichlamviec.ForeColor = System.Drawing.Color.White;
            this.btn_lichlamviec.Location = new System.Drawing.Point(0, 175);
            this.btn_lichlamviec.Name = "btn_lichlamviec";
            this.btn_lichlamviec.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btn_lichlamviec.Size = new System.Drawing.Size(273, 91);
            this.btn_lichlamviec.TabIndex = 1;
            this.btn_lichlamviec.Text = "Lịch làm việc";
            this.btn_lichlamviec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_lichlamviec.UseVisualStyleBackColor = false;
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.Black;
            this.btn_thoat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_thoat.FlatAppearance.BorderSize = 0;
            this.btn_thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.Color.White;
            this.btn_thoat.Location = new System.Drawing.Point(0, 266);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btn_thoat.Size = new System.Drawing.Size(273, 86);
            this.btn_thoat.TabIndex = 5;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.btn_thoat);
            this.panel1.Controls.Add(this.btn_lichlamviec);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 613);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 175);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Linen;
            this.panel3.Controls.Add(this.pb_acc);
            this.panel3.Controls.Add(this.pb_home);
            this.panel3.Controls.Add(this.lb_home);
            this.panel3.Controls.Add(this.lb_acc);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(273, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(891, 83);
            this.panel3.TabIndex = 4;
            // 
            // lb_home
            // 
            this.lb_home.AutoSize = true;
            this.lb_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_home.ForeColor = System.Drawing.Color.Black;
            this.lb_home.Location = new System.Drawing.Point(79, 49);
            this.lb_home.Name = "lb_home";
            this.lb_home.Size = new System.Drawing.Size(78, 29);
            this.lb_home.TabIndex = 3;
            this.lb_home.Text = "Home";
            this.lb_home.Click += new System.EventHandler(this.lb_home_Click);
            // 
            // lb_acc
            // 
            this.lb_acc.AutoSize = true;
            this.lb_acc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_acc.Location = new System.Drawing.Point(262, 49);
            this.lb_acc.Name = "lb_acc";
            this.lb_acc.Size = new System.Drawing.Size(182, 29);
            this.lb_acc.TabIndex = 1;
            this.lb_acc.Text = "Huấn luyện viên";
            this.lb_acc.Click += new System.EventHandler(this.lb_acc_Click);
            // 
            // pn_tkhlv
            // 
            this.pn_tkhlv.BackColor = System.Drawing.Color.White;
            this.pn_tkhlv.Controls.Add(this.btn_doimatkhau);
            this.pn_tkhlv.Controls.Add(this.btn_updatethongtin);
            this.pn_tkhlv.Controls.Add(this.pb_updateimage);
            this.pn_tkhlv.Controls.Add(this.lb_gmailhlv);
            this.pn_tkhlv.Controls.Add(this.lb_tenhlv);
            this.pn_tkhlv.Controls.Add(this.pb_hlv);
            this.pn_tkhlv.Location = new System.Drawing.Point(474, 89);
            this.pn_tkhlv.Name = "pn_tkhlv";
            this.pn_tkhlv.Size = new System.Drawing.Size(525, 157);
            this.pn_tkhlv.TabIndex = 4;
            // 
            // btn_doimatkhau
            // 
            this.btn_doimatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_doimatkhau.Location = new System.Drawing.Point(298, 102);
            this.btn_doimatkhau.Name = "btn_doimatkhau";
            this.btn_doimatkhau.Size = new System.Drawing.Size(205, 42);
            this.btn_doimatkhau.TabIndex = 8;
            this.btn_doimatkhau.Text = "Đổi mật khẩu";
            this.btn_doimatkhau.UseVisualStyleBackColor = true;
            this.btn_doimatkhau.Click += new System.EventHandler(this.btn_doimatkhau_Click);
            // 
            // btn_updatethongtin
            // 
            this.btn_updatethongtin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updatethongtin.Location = new System.Drawing.Point(21, 102);
            this.btn_updatethongtin.Name = "btn_updatethongtin";
            this.btn_updatethongtin.Size = new System.Drawing.Size(233, 42);
            this.btn_updatethongtin.TabIndex = 7;
            this.btn_updatethongtin.Text = "Cật nhật thông tin";
            this.btn_updatethongtin.UseVisualStyleBackColor = true;
            this.btn_updatethongtin.Click += new System.EventHandler(this.btn_updatethongtin_Click);
            // 
            // lb_gmailhlv
            // 
            this.lb_gmailhlv.AutoSize = true;
            this.lb_gmailhlv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_gmailhlv.Location = new System.Drawing.Point(128, 57);
            this.lb_gmailhlv.Name = "lb_gmailhlv";
            this.lb_gmailhlv.Size = new System.Drawing.Size(217, 25);
            this.lb_gmailhlv.TabIndex = 5;
            this.lb_gmailhlv.Text = "minh32405@gmail.com";
            // 
            // lb_tenhlv
            // 
            this.lb_tenhlv.AutoSize = true;
            this.lb_tenhlv.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tenhlv.Location = new System.Drawing.Point(127, 14);
            this.lb_tenhlv.Name = "lb_tenhlv";
            this.lb_tenhlv.Size = new System.Drawing.Size(229, 36);
            this.lb_tenhlv.TabIndex = 4;
            this.lb_tenhlv.Text = "Lâm Nhật Minh";
            // 
            // pb_updateimage
            // 
            this.pb_updateimage.Image = ((System.Drawing.Image)(resources.GetObject("pb_updateimage.Image")));
            this.pb_updateimage.Location = new System.Drawing.Point(74, 57);
            this.pb_updateimage.Name = "pb_updateimage";
            this.pb_updateimage.Size = new System.Drawing.Size(33, 25);
            this.pb_updateimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_updateimage.TabIndex = 6;
            this.pb_updateimage.TabStop = false;
            this.pb_updateimage.Click += new System.EventHandler(this.pb_updateimage_Click);
            // 
            // pb_hlv
            // 
            this.pb_hlv.Image = ((System.Drawing.Image)(resources.GetObject("pb_hlv.Image")));
            this.pb_hlv.Location = new System.Drawing.Point(21, 14);
            this.pb_hlv.Name = "pb_hlv";
            this.pb_hlv.Size = new System.Drawing.Size(86, 68);
            this.pb_hlv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_hlv.TabIndex = 3;
            this.pb_hlv.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(273, 83);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(891, 530);
            this.panel4.TabIndex = 5;
            // 
            // pb_acc
            // 
            this.pb_acc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_acc.Image = ((System.Drawing.Image)(resources.GetObject("pb_acc.Image")));
            this.pb_acc.Location = new System.Drawing.Point(201, 17);
            this.pb_acc.Name = "pb_acc";
            this.pb_acc.Size = new System.Drawing.Size(55, 61);
            this.pb_acc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_acc.TabIndex = 0;
            this.pb_acc.TabStop = false;
            this.pb_acc.Click += new System.EventHandler(this.pb_acc_Click);
            // 
            // pb_home
            // 
            this.pb_home.BackColor = System.Drawing.Color.Transparent;
            this.pb_home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_home.BackgroundImage")));
            this.pb_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_home.Location = new System.Drawing.Point(18, 17);
            this.pb_home.Name = "pb_home";
            this.pb_home.Size = new System.Drawing.Size(55, 61);
            this.pb_home.TabIndex = 2;
            this.pb_home.TabStop = false;
            this.pb_home.Click += new System.EventHandler(this.pb_home_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::QLPhongGym.Properties.Resources.output_7bZFQx;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(273, 175);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // HLV_FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 613);
            this.Controls.Add(this.pn_tkhlv);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "HLV_FormMain";
            this.Text = "HLV_formmain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pn_tkhlv.ResumeLayout(false);
            this.pn_tkhlv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_updateimage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_hlv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_acc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_lichlamviec;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lb_acc;
        private System.Windows.Forms.PictureBox pb_acc;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pb_home;
        private System.Windows.Forms.Label lb_home;
        private System.Windows.Forms.Panel pn_tkhlv;
        private System.Windows.Forms.Button btn_doimatkhau;
        private System.Windows.Forms.Button btn_updatethongtin;
        private System.Windows.Forms.PictureBox pb_updateimage;
        private System.Windows.Forms.Label lb_gmailhlv;
        private System.Windows.Forms.Label lb_tenhlv;
        private System.Windows.Forms.PictureBox pb_hlv;
    }
}