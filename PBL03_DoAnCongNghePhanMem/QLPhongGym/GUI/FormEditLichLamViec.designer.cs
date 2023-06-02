namespace QLPhongGym.GUI
{
    partial class FormEditLichLamViec
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
            this.CA = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textIdHLV = new System.Windows.Forms.TextBox();
            this.cbbCa = new System.Windows.Forms.ComboBox();
            this.btnEDIT = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.timeNgaylam = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimeNgayEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimeNgayStart = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // CA
            // 
            this.CA.AutoSize = true;
            this.CA.Location = new System.Drawing.Point(160, 107);
            this.CA.Name = "CA";
            this.CA.Size = new System.Drawing.Size(38, 16);
            this.CA.TabIndex = 0;
            this.CA.Text = "IDCA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "IDHLV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "NGÀY LÀM";
            // 
            // textIdHLV
            // 
            this.textIdHLV.Location = new System.Drawing.Point(345, 174);
            this.textIdHLV.Name = "textIdHLV";
            this.textIdHLV.Size = new System.Drawing.Size(200, 22);
            this.textIdHLV.TabIndex = 5;
            // 
            // cbbCa
            // 
            this.cbbCa.FormattingEnabled = true;
            this.cbbCa.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbbCa.Location = new System.Drawing.Point(345, 99);
            this.cbbCa.Name = "cbbCa";
            this.cbbCa.Size = new System.Drawing.Size(200, 24);
            this.cbbCa.TabIndex = 8;
            // 
            // btnEDIT
            // 
            this.btnEDIT.Location = new System.Drawing.Point(199, 351);
            this.btnEDIT.Name = "btnEDIT";
            this.btnEDIT.Size = new System.Drawing.Size(75, 23);
            this.btnEDIT.TabIndex = 9;
            this.btnEDIT.Text = "OKI";
            this.btnEDIT.UseVisualStyleBackColor = true;
            this.btnEDIT.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(470, 351);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // timeNgaylam
            // 
            this.timeNgaylam.CustomFormat = "yyyy-MM-dd";
            this.timeNgaylam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeNgaylam.Location = new System.Drawing.Point(345, 251);
            this.timeNgaylam.Name = "timeNgaylam";
            this.timeNgaylam.Size = new System.Drawing.Size(200, 22);
            this.timeNgaylam.TabIndex = 12;
            this.timeNgaylam.Value = new System.DateTime(2023, 4, 21, 0, 0, 0, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(432, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 16);
            this.label10.TabIndex = 68;
            this.label10.Text = "To";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(123, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 16);
            this.label11.TabIndex = 67;
            this.label11.Text = "From";
            // 
            // dateTimeNgayEnd
            // 
            this.dateTimeNgayEnd.CustomFormat = "yyyy-MM-dd";
            this.dateTimeNgayEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeNgayEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeNgayEnd.Location = new System.Drawing.Point(497, 6);
            this.dateTimeNgayEnd.Name = "dateTimeNgayEnd";
            this.dateTimeNgayEnd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimeNgayEnd.Size = new System.Drawing.Size(155, 27);
            this.dateTimeNgayEnd.TabIndex = 66;
            this.dateTimeNgayEnd.Value = new System.DateTime(2023, 4, 21, 0, 0, 0, 0);
            // 
            // dateTimeNgayStart
            // 
            this.dateTimeNgayStart.CustomFormat = "yyyy-MM-dd";
            this.dateTimeNgayStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeNgayStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeNgayStart.Location = new System.Drawing.Point(223, 6);
            this.dateTimeNgayStart.Name = "dateTimeNgayStart";
            this.dateTimeNgayStart.Size = new System.Drawing.Size(155, 27);
            this.dateTimeNgayStart.TabIndex = 65;
            this.dateTimeNgayStart.Value = new System.DateTime(2023, 4, 21, 0, 0, 0, 0);
            // 
            // FormEditLichLamViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dateTimeNgayEnd);
            this.Controls.Add(this.dateTimeNgayStart);
            this.Controls.Add(this.timeNgaylam);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEDIT);
            this.Controls.Add(this.cbbCa);
            this.Controls.Add(this.textIdHLV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CA);
            this.Name = "FormEditLichLamViec";
            this.Text = "FormEditLichLamViec";
            this.Load += new System.EventHandler(this.FormEditLichLamViec_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textIdHLV;
        private System.Windows.Forms.ComboBox cbbCa;
        private System.Windows.Forms.Button btnEDIT;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker timeNgaylam;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimeNgayEnd;
        private System.Windows.Forms.DateTimePicker dateTimeNgayStart;
    }
}