namespace BanHangSieuThi
{
    partial class QuanLyNguoiDung
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
            this.dgvQuanLiNguoiDung = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLiNguoiDung)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvQuanLiNguoiDung
            // 
            this.dgvQuanLiNguoiDung.AllowUserToAddRows = false;
            this.dgvQuanLiNguoiDung.AllowUserToDeleteRows = false;
            this.dgvQuanLiNguoiDung.AllowUserToResizeColumns = false;
            this.dgvQuanLiNguoiDung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuanLiNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLiNguoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQuanLiNguoiDung.Location = new System.Drawing.Point(0, 0);
            this.dgvQuanLiNguoiDung.Name = "dgvQuanLiNguoiDung";
            this.dgvQuanLiNguoiDung.ReadOnly = true;
            this.dgvQuanLiNguoiDung.RowTemplate.Height = 24;
            this.dgvQuanLiNguoiDung.Size = new System.Drawing.Size(800, 450);
            this.dgvQuanLiNguoiDung.TabIndex = 0;
            // 
            // QuanLyNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvQuanLiNguoiDung);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "QuanLyNguoiDung";
            this.Text = "Quản lý người dùng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLiNguoiDung)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvQuanLiNguoiDung;
    }
}