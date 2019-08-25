namespace quanlyhocsinh
{
    partial class Formgiaovien
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
            this.bt_themgv = new System.Windows.Forms.Button();
            this.bt_suagv = new System.Windows.Forms.Button();
            this.bt_xoagv = new System.Windows.Forms.Button();
            this.bt_timkiemgv = new System.Windows.Forms.Button();
            this.dataGridViewGiaoVien = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGiaoVien)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_themgv
            // 
            this.bt_themgv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt_themgv.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_themgv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bt_themgv.Location = new System.Drawing.Point(66, 42);
            this.bt_themgv.Name = "bt_themgv";
            this.bt_themgv.Size = new System.Drawing.Size(98, 37);
            this.bt_themgv.TabIndex = 0;
            this.bt_themgv.Text = "Thêm";
            this.bt_themgv.UseVisualStyleBackColor = false;
            // 
            // bt_suagv
            // 
            this.bt_suagv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt_suagv.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_suagv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bt_suagv.Location = new System.Drawing.Point(66, 108);
            this.bt_suagv.Name = "bt_suagv";
            this.bt_suagv.Size = new System.Drawing.Size(98, 37);
            this.bt_suagv.TabIndex = 0;
            this.bt_suagv.Text = "Sửa";
            this.bt_suagv.UseVisualStyleBackColor = false;
            // 
            // bt_xoagv
            // 
            this.bt_xoagv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt_xoagv.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoagv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bt_xoagv.Location = new System.Drawing.Point(66, 183);
            this.bt_xoagv.Name = "bt_xoagv";
            this.bt_xoagv.Size = new System.Drawing.Size(98, 37);
            this.bt_xoagv.TabIndex = 0;
            this.bt_xoagv.Text = "Xóa";
            this.bt_xoagv.UseVisualStyleBackColor = false;
            // 
            // bt_timkiemgv
            // 
            this.bt_timkiemgv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt_timkiemgv.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_timkiemgv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bt_timkiemgv.Location = new System.Drawing.Point(66, 265);
            this.bt_timkiemgv.Name = "bt_timkiemgv";
            this.bt_timkiemgv.Size = new System.Drawing.Size(98, 37);
            this.bt_timkiemgv.TabIndex = 0;
            this.bt_timkiemgv.Text = "Tìm Kiếm";
            this.bt_timkiemgv.UseVisualStyleBackColor = false;
            // 
            // dataGridViewGiaoVien
            // 
            this.dataGridViewGiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGiaoVien.Location = new System.Drawing.Point(225, 20);
            this.dataGridViewGiaoVien.Name = "dataGridViewGiaoVien";
            this.dataGridViewGiaoVien.RowHeadersWidth = 51;
            this.dataGridViewGiaoVien.RowTemplate.Height = 24;
            this.dataGridViewGiaoVien.Size = new System.Drawing.Size(804, 382);
            this.dataGridViewGiaoVien.TabIndex = 1;
            // 
            // Formgiaovien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 492);
            this.Controls.Add(this.dataGridViewGiaoVien);
            this.Controls.Add(this.bt_timkiemgv);
            this.Controls.Add(this.bt_xoagv);
            this.Controls.Add(this.bt_suagv);
            this.Controls.Add(this.bt_themgv);
            this.Name = "Formgiaovien";
            this.Text = "Formgiaovien";
            this.Load += new System.EventHandler(this.Formgiaovien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGiaoVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_themgv;
        private System.Windows.Forms.Button bt_suagv;
        private System.Windows.Forms.Button bt_xoagv;
        private System.Windows.Forms.Button bt_timkiemgv;
        private System.Windows.Forms.DataGridView dataGridViewGiaoVien;
    }
}