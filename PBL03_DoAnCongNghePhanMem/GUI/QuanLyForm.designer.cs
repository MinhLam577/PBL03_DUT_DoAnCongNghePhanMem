namespace GUI
{
    partial class QuanLyForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyForm));
            this.dgv_showKh = new System.Windows.Forms.DataGridView();
            this.IdKh_lb = new System.Windows.Forms.Label();
            this.NameKh_lb = new System.Windows.Forms.Label();
            this.EmailKh_lb = new System.Windows.Forms.Label();
            this.SdtKh_lb = new System.Windows.Forms.Label();
            this.Idkh_txb = new System.Windows.Forms.TextBox();
            this.NameKh_txb = new System.Windows.Forms.TextBox();
            this.EmailKh_txb = new System.Windows.Forms.TextBox();
            this.SdtKh_txb = new System.Windows.Forms.TextBox();
            this.AddKh_btn = new System.Windows.Forms.Button();
            this.DelKh_btn = new System.Windows.Forms.Button();
            this.EditKh_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ptb_imdynamic = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lb_address = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_showKh)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_imdynamic)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_showKh
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_showKh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_showKh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_showKh.Location = new System.Drawing.Point(63, 347);
            this.dgv_showKh.Name = "dgv_showKh";
            this.dgv_showKh.ReadOnly = true;
            this.dgv_showKh.RowHeadersWidth = 51;
            this.dgv_showKh.RowTemplate.Height = 24;
            this.dgv_showKh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_showKh.Size = new System.Drawing.Size(640, 353);
            this.dgv_showKh.TabIndex = 0;
            // 
            // IdKh_lb
            // 
            this.IdKh_lb.AutoSize = true;
            this.IdKh_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdKh_lb.Location = new System.Drawing.Point(732, 347);
            this.IdKh_lb.Name = "IdKh_lb";
            this.IdKh_lb.Size = new System.Drawing.Size(154, 25);
            this.IdKh_lb.TabIndex = 1;
            this.IdKh_lb.Text = "Mã Khách Hàng";
            // 
            // NameKh_lb
            // 
            this.NameKh_lb.AutoSize = true;
            this.NameKh_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameKh_lb.Location = new System.Drawing.Point(725, 399);
            this.NameKh_lb.Name = "NameKh_lb";
            this.NameKh_lb.Size = new System.Drawing.Size(161, 25);
            this.NameKh_lb.TabIndex = 2;
            this.NameKh_lb.Text = "Tên Khách Hàng";
            // 
            // EmailKh_lb
            // 
            this.EmailKh_lb.AutoSize = true;
            this.EmailKh_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailKh_lb.Location = new System.Drawing.Point(725, 450);
            this.EmailKh_lb.Name = "EmailKh_lb";
            this.EmailKh_lb.Size = new System.Drawing.Size(60, 25);
            this.EmailKh_lb.TabIndex = 3;
            this.EmailKh_lb.Text = "Email";
            // 
            // SdtKh_lb
            // 
            this.SdtKh_lb.AutoSize = true;
            this.SdtKh_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SdtKh_lb.Location = new System.Drawing.Point(725, 515);
            this.SdtKh_lb.Name = "SdtKh_lb";
            this.SdtKh_lb.Size = new System.Drawing.Size(126, 25);
            this.SdtKh_lb.TabIndex = 4;
            this.SdtKh_lb.Text = "Số điện thoại";
            // 
            // Idkh_txb
            // 
            this.Idkh_txb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Idkh_txb.Location = new System.Drawing.Point(903, 510);
            this.Idkh_txb.Name = "Idkh_txb";
            this.Idkh_txb.Size = new System.Drawing.Size(267, 30);
            this.Idkh_txb.TabIndex = 5;
            // 
            // NameKh_txb
            // 
            this.NameKh_txb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameKh_txb.Location = new System.Drawing.Point(903, 445);
            this.NameKh_txb.Name = "NameKh_txb";
            this.NameKh_txb.Size = new System.Drawing.Size(267, 30);
            this.NameKh_txb.TabIndex = 6;
            // 
            // EmailKh_txb
            // 
            this.EmailKh_txb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailKh_txb.Location = new System.Drawing.Point(903, 344);
            this.EmailKh_txb.Name = "EmailKh_txb";
            this.EmailKh_txb.Size = new System.Drawing.Size(267, 30);
            this.EmailKh_txb.TabIndex = 7;
            // 
            // SdtKh_txb
            // 
            this.SdtKh_txb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SdtKh_txb.Location = new System.Drawing.Point(903, 383);
            this.SdtKh_txb.Name = "SdtKh_txb";
            this.SdtKh_txb.Size = new System.Drawing.Size(267, 30);
            this.SdtKh_txb.TabIndex = 8;
            // 
            // AddKh_btn
            // 
            this.AddKh_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddKh_btn.Location = new System.Drawing.Point(730, 581);
            this.AddKh_btn.Name = "AddKh_btn";
            this.AddKh_btn.Size = new System.Drawing.Size(110, 59);
            this.AddKh_btn.TabIndex = 9;
            this.AddKh_btn.Text = "Thêm";
            this.AddKh_btn.UseVisualStyleBackColor = true;
            // 
            // DelKh_btn
            // 
            this.DelKh_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelKh_btn.Location = new System.Drawing.Point(903, 581);
            this.DelKh_btn.Name = "DelKh_btn";
            this.DelKh_btn.Size = new System.Drawing.Size(110, 59);
            this.DelKh_btn.TabIndex = 10;
            this.DelKh_btn.Text = "Xóa";
            this.DelKh_btn.UseVisualStyleBackColor = true; 
            // 
            // EditKh_btn
            // 
            this.EditKh_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditKh_btn.Location = new System.Drawing.Point(1060, 581);
            this.EditKh_btn.Name = "EditKh_btn";
            this.EditKh_btn.Size = new System.Drawing.Size(110, 59);
            this.EditKh_btn.TabIndex = 11;
            this.EditKh_btn.Text = "Sửa";
            this.EditKh_btn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_address);
            this.groupBox1.Controls.Add(this.ptb_imdynamic);
            this.groupBox1.Location = new System.Drawing.Point(1, -6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1554, 344);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // ptb_imdynamic
            // 
            this.ptb_imdynamic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_imdynamic.InitialImage = ((System.Drawing.Image)(resources.GetObject("ptb_imdynamic.InitialImage")));
            this.ptb_imdynamic.Location = new System.Drawing.Point(0, 0);
            this.ptb_imdynamic.Name = "ptb_imdynamic";
            this.ptb_imdynamic.Size = new System.Drawing.Size(319, 175);
            this.ptb_imdynamic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_imdynamic.TabIndex = 13;
            this.ptb_imdynamic.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 4000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lb_address
            // 
            this.lb_address.AutoSize = true;
            this.lb_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_address.Location = new System.Drawing.Point(405, 35);
            this.lb_address.Name = "lb_address";
            this.lb_address.Size = new System.Drawing.Size(267, 32);
            this.lb_address.TabIndex = 14;
            this.lb_address.Text = "67 Phan Châu Trinh";
            // 
            // QuanLyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1550, 775);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.EditKh_btn);
            this.Controls.Add(this.DelKh_btn);
            this.Controls.Add(this.AddKh_btn);
            this.Controls.Add(this.SdtKh_txb);
            this.Controls.Add(this.EmailKh_txb);
            this.Controls.Add(this.NameKh_txb);
            this.Controls.Add(this.Idkh_txb);
            this.Controls.Add(this.SdtKh_lb);
            this.Controls.Add(this.EmailKh_lb);
            this.Controls.Add(this.NameKh_lb);
            this.Controls.Add(this.IdKh_lb);
            this.Controls.Add(this.dgv_showKh);
            this.Name = "QuanLyForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.QuanLyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_showKh)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_imdynamic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_showKh;
        private System.Windows.Forms.Label IdKh_lb;
        private System.Windows.Forms.Label NameKh_lb;
        private System.Windows.Forms.Label EmailKh_lb;
        private System.Windows.Forms.Label SdtKh_lb;
        private System.Windows.Forms.TextBox Idkh_txb;
        private System.Windows.Forms.TextBox NameKh_txb;
        private System.Windows.Forms.TextBox EmailKh_txb;
        private System.Windows.Forms.TextBox SdtKh_txb;
        private System.Windows.Forms.Button AddKh_btn;
        private System.Windows.Forms.Button DelKh_btn;
        private System.Windows.Forms.Button EditKh_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox ptb_imdynamic;
        private System.Windows.Forms.Label lb_address;
    }
}

