namespace QLPhongGym.GUI
{
    partial class UpdateImageAccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateImageAccountForm));
            this.btn_change = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.pb_imageacc = new System.Windows.Forms.PictureBox();
            this.btn_luu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imageacc)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_change
            // 
            this.btn_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_change.ForeColor = System.Drawing.Color.Blue;
            this.btn_change.Location = new System.Drawing.Point(89, 542);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(106, 66);
            this.btn_change.TabIndex = 1;
            this.btn_change.Text = "Thay đổi";
            this.btn_change.UseVisualStyleBackColor = true;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.Blue;
            this.btn_delete.Location = new System.Drawing.Point(277, 542);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(106, 66);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.Color.Blue;
            this.btn_thoat.Location = new System.Drawing.Point(690, 542);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(106, 66);
            this.btn_thoat.TabIndex = 3;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // pb_imageacc
            // 
            this.pb_imageacc.Image = ((System.Drawing.Image)(resources.GetObject("pb_imageacc.Image")));
            this.pb_imageacc.Location = new System.Drawing.Point(196, 42);
            this.pb_imageacc.Name = "pb_imageacc";
            this.pb_imageacc.Size = new System.Drawing.Size(473, 438);
            this.pb_imageacc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_imageacc.TabIndex = 0;
            this.pb_imageacc.TabStop = false;
            // 
            // btn_luu
            // 
            this.btn_luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.ForeColor = System.Drawing.Color.Blue;
            this.btn_luu.Location = new System.Drawing.Point(493, 542);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(106, 66);
            this.btn_luu.TabIndex = 4;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // UpdateImageAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(874, 641);
            this.ControlBox = false;
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.pb_imageacc);
            this.MaximumSize = new System.Drawing.Size(892, 688);
            this.MinimumSize = new System.Drawing.Size(892, 688);
            this.Name = "UpdateImageAccountForm";
            this.Text = "UpdateImageAccount";
            ((System.ComponentModel.ISupportInitialize)(this.pb_imageacc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_imageacc;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_luu;
    }
}