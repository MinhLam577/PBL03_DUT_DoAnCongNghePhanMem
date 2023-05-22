namespace QLPhongGym.GUI
{
    partial class QuenMatKhauForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuenMatKhauForm));
            this.lb_em = new System.Windows.Forms.Label();
            this.gb_resetpass = new System.Windows.Forms.GroupBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_laylaimk = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_Email = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gb_resetpass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_em
            // 
            this.lb_em.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_em.AutoSize = true;
            this.lb_em.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_em.ForeColor = System.Drawing.Color.Red;
            this.lb_em.Location = new System.Drawing.Point(122, 389);
            this.lb_em.Name = "lb_em";
            this.lb_em.Size = new System.Drawing.Size(111, 38);
            this.lb_em.TabIndex = 3;
            this.lb_em.Text = "Gmail:";
            // 
            // gb_resetpass
            // 
            this.gb_resetpass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_resetpass.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gb_resetpass.Controls.Add(this.btn_exit);
            this.gb_resetpass.Controls.Add(this.btn_laylaimk);
            this.gb_resetpass.Controls.Add(this.label2);
            this.gb_resetpass.Controls.Add(this.txb_Email);
            this.gb_resetpass.Controls.Add(this.pictureBox2);
            this.gb_resetpass.Controls.Add(this.lb_em);
            this.gb_resetpass.Location = new System.Drawing.Point(958, -7);
            this.gb_resetpass.Name = "gb_resetpass";
            this.gb_resetpass.Size = new System.Drawing.Size(819, 771);
            this.gb_resetpass.TabIndex = 4;
            this.gb_resetpass.TabStop = false;
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(540, 564);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(124, 45);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "Back";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_laylaimk
            // 
            this.btn_laylaimk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_laylaimk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_laylaimk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_laylaimk.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_laylaimk.ForeColor = System.Drawing.Color.White;
            this.btn_laylaimk.Location = new System.Drawing.Point(223, 564);
            this.btn_laylaimk.Name = "btn_laylaimk";
            this.btn_laylaimk.Size = new System.Drawing.Size(124, 45);
            this.btn_laylaimk.TabIndex = 3;
            this.btn_laylaimk.Text = "Submit";
            this.btn_laylaimk.UseVisualStyleBackColor = false;
            this.btn_laylaimk.Click += new System.EventHandler(this.btn_laylaimk_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(272, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 46);
            this.label2.TabIndex = 5;
            this.label2.Text = "Reset Password";
            // 
            // txb_Email
            // 
            this.txb_Email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txb_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Email.ForeColor = System.Drawing.Color.Red;
            this.txb_Email.Location = new System.Drawing.Point(352, 389);
            this.txb_Email.Name = "txb_Email";
            this.txb_Email.Size = new System.Drawing.Size(375, 34);
            this.txb_Email.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(333, 83);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(179, 111);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(955, 763);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // QuenMatKhauForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1781, 762);
            this.Controls.Add(this.gb_resetpass);
            this.Controls.Add(this.pictureBox1);
            this.Name = "QuenMatKhauForm";
            this.Text = "Quên mật khẩu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gb_resetpass.ResumeLayout(false);
            this.gb_resetpass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lb_em;
        private System.Windows.Forms.GroupBox gb_resetpass;
        private System.Windows.Forms.TextBox txb_Email;
        private System.Windows.Forms.Button btn_laylaimk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_exit;
    }
}