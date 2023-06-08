namespace QLPhongGym.GUI
{
    partial class KH_QuanLyLichThue
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
            this.label1 = new System.Windows.Forms.Label();
            this.datagrid_LichThue = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_LichThue)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(248, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lịch Thuê Huấn Luyện Viên";
            // 
            // datagrid_LichThue
            // 
            this.datagrid_LichThue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid_LichThue.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.datagrid_LichThue.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.datagrid_LichThue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_LichThue.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagrid_LichThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagrid_LichThue.DefaultCellStyle = dataGridViewCellStyle2;
            this.datagrid_LichThue.Location = new System.Drawing.Point(91, 99);
            this.datagrid_LichThue.Name = "datagrid_LichThue";
            this.datagrid_LichThue.ReadOnly = true;
            this.datagrid_LichThue.RowHeadersVisible = false;
            this.datagrid_LichThue.RowHeadersWidth = 51;
            this.datagrid_LichThue.RowTemplate.Height = 24;
            this.datagrid_LichThue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid_LichThue.Size = new System.Drawing.Size(795, 372);
            this.datagrid_LichThue.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(183, 497);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 65);
            this.button1.TabIndex = 2;
            this.button1.Text = "Xóa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Blue;
            this.button2.Location = new System.Drawing.Point(672, 497);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 65);
            this.button2.TabIndex = 3;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // KH_QuanLyLichThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(963, 582);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.datagrid_LichThue);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(981, 629);
            this.MinimumSize = new System.Drawing.Size(981, 629);
            this.Name = "KH_QuanLyLichThue";
            this.Text = "KH_QuanLyLichThue";
            this.Load += new System.EventHandler(this.KH_QuanLyLichThue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_LichThue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView datagrid_LichThue;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}