namespace WindowsFormsApp1
{
    partial class Form1
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
            this.btn_chao = new System.Windows.Forms.Button();
            this.lb_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_chao
            // 
            this.btn_chao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chao.Location = new System.Drawing.Point(112, 75);
            this.btn_chao.Name = "btn_chao";
            this.btn_chao.Size = new System.Drawing.Size(143, 88);
            this.btn_chao.TabIndex = 0;
            this.btn_chao.Text = "Chào bạn";
            this.btn_chao.UseVisualStyleBackColor = true;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.Location = new System.Drawing.Point(325, 102);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(205, 32);
            this.lb_name.TabIndex = 1;
            this.lb_name.Text = "Lâm Nhật Minh";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 595);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.btn_chao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_chao;
        private System.Windows.Forms.Label lb_name;
    }
}

