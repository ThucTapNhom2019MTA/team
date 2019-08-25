namespace quanlyhocsinh
{
    partial class Formhocsinh
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
            this.dataGridViewHocSinh = new System.Windows.Forms.DataGridView();
            this.bt_timkiemhs = new System.Windows.Forms.Button();
            this.bt_xoahs = new System.Windows.Forms.Button();
            this.bt_suahs = new System.Windows.Forms.Button();
            this.bt_themhs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHocSinh)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewHocSinh
            // 
            this.dataGridViewHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHocSinh.Location = new System.Drawing.Point(260, 17);
            this.dataGridViewHocSinh.Name = "dataGridViewHocSinh";
            this.dataGridViewHocSinh.RowHeadersWidth = 51;
            this.dataGridViewHocSinh.RowTemplate.Height = 24;
            this.dataGridViewHocSinh.Size = new System.Drawing.Size(795, 382);
            this.dataGridViewHocSinh.TabIndex = 6;
            // 
            // bt_timkiemhs
            // 
            this.bt_timkiemhs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt_timkiemhs.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_timkiemhs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bt_timkiemhs.Location = new System.Drawing.Point(71, 263);
            this.bt_timkiemhs.Name = "bt_timkiemhs";
            this.bt_timkiemhs.Size = new System.Drawing.Size(98, 37);
            this.bt_timkiemhs.TabIndex = 2;
            this.bt_timkiemhs.Text = "Tìm Kiếm";
            this.bt_timkiemhs.UseVisualStyleBackColor = false;
            // 
            // bt_xoahs
            // 
            this.bt_xoahs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt_xoahs.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoahs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bt_xoahs.Location = new System.Drawing.Point(71, 181);
            this.bt_xoahs.Name = "bt_xoahs";
            this.bt_xoahs.Size = new System.Drawing.Size(98, 37);
            this.bt_xoahs.TabIndex = 3;
            this.bt_xoahs.Text = "Xóa";
            this.bt_xoahs.UseVisualStyleBackColor = false;
            // 
            // bt_suahs
            // 
            this.bt_suahs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt_suahs.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_suahs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bt_suahs.Location = new System.Drawing.Point(71, 106);
            this.bt_suahs.Name = "bt_suahs";
            this.bt_suahs.Size = new System.Drawing.Size(98, 37);
            this.bt_suahs.TabIndex = 4;
            this.bt_suahs.Text = "Sửa";
            this.bt_suahs.UseVisualStyleBackColor = false;
            // 
            // bt_themhs
            // 
            this.bt_themhs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt_themhs.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_themhs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bt_themhs.Location = new System.Drawing.Point(71, 40);
            this.bt_themhs.Name = "bt_themhs";
            this.bt_themhs.Size = new System.Drawing.Size(98, 37);
            this.bt_themhs.TabIndex = 5;
            this.bt_themhs.Text = "Thêm";
            this.bt_themhs.UseVisualStyleBackColor = false;
            // 
            // Formhocsinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 517);
            this.Controls.Add(this.dataGridViewHocSinh);
            this.Controls.Add(this.bt_timkiemhs);
            this.Controls.Add(this.bt_xoahs);
            this.Controls.Add(this.bt_suahs);
            this.Controls.Add(this.bt_themhs);
            this.Name = "Formhocsinh";
            this.Text = "Formhocsinh";
            this.Load += new System.EventHandler(this.Formhocsinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHocSinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewHocSinh;
        private System.Windows.Forms.Button bt_timkiemhs;
        private System.Windows.Forms.Button bt_xoahs;
        private System.Windows.Forms.Button bt_suahs;
        private System.Windows.Forms.Button bt_themhs;
    }
}