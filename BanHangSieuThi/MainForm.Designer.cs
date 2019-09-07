namespace BanHangSieuThi
{
    partial class MainForm
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
            this.btnQuanLyND = new System.Windows.Forms.Button();
            this.btnNhapHang = new System.Windows.Forms.Button();
            this.btnBanHang = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThongKeHang = new System.Windows.Forms.Button();
            this.btnQuanLyKH = new System.Windows.Forms.Button();
            this.btnThongKeLL = new System.Windows.Forms.Button();
            this.btnQuanLyNV = new System.Windows.Forms.Button();
            this.btnNhapHangCu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQuanLyND
            // 
            this.btnQuanLyND.Location = new System.Drawing.Point(100, 74);
            this.btnQuanLyND.Name = "btnQuanLyND";
            this.btnQuanLyND.Size = new System.Drawing.Size(255, 43);
            this.btnQuanLyND.TabIndex = 0;
            this.btnQuanLyND.Text = "Quản lý người dùng";
            this.btnQuanLyND.UseVisualStyleBackColor = true;
            this.btnQuanLyND.Click += new System.EventHandler(this.btnQuanLyND_Click);
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.Location = new System.Drawing.Point(445, 149);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(255, 43);
            this.btnNhapHang.TabIndex = 0;
            this.btnNhapHang.Text = "Thêm mặt hàng mới";
            this.btnNhapHang.UseVisualStyleBackColor = true;
            this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click);
            // 
            // btnBanHang
            // 
            this.btnBanHang.Location = new System.Drawing.Point(100, 149);
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.Size = new System.Drawing.Size(255, 43);
            this.btnBanHang.TabIndex = 0;
            this.btnBanHang.Text = "Bán hàng";
            this.btnBanHang.UseVisualStyleBackColor = true;
            this.btnBanHang.Click += new System.EventHandler(this.btnBanHang_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(445, 224);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(255, 43);
            this.btnTimKiem.TabIndex = 0;
            this.btnTimKiem.Text = "Tìm kiếm hàng";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThongKeHang
            // 
            this.btnThongKeHang.Location = new System.Drawing.Point(100, 227);
            this.btnThongKeHang.Name = "btnThongKeHang";
            this.btnThongKeHang.Size = new System.Drawing.Size(255, 43);
            this.btnThongKeHang.TabIndex = 0;
            this.btnThongKeHang.Text = "Thống kê hàng trong kho";
            this.btnThongKeHang.UseVisualStyleBackColor = true;
            // 
            // btnQuanLyKH
            // 
            this.btnQuanLyKH.Location = new System.Drawing.Point(100, 302);
            this.btnQuanLyKH.Name = "btnQuanLyKH";
            this.btnQuanLyKH.Size = new System.Drawing.Size(255, 43);
            this.btnQuanLyKH.TabIndex = 0;
            this.btnQuanLyKH.Text = "Quản lý khách hàng";
            this.btnQuanLyKH.UseVisualStyleBackColor = true;
            // 
            // btnThongKeLL
            // 
            this.btnThongKeLL.Location = new System.Drawing.Point(445, 302);
            this.btnThongKeLL.Name = "btnThongKeLL";
            this.btnThongKeLL.Size = new System.Drawing.Size(255, 43);
            this.btnThongKeLL.TabIndex = 0;
            this.btnThongKeLL.Text = "Thống kê lưu lượng nhập bán";
            this.btnThongKeLL.UseVisualStyleBackColor = true;
            // 
            // btnQuanLyNV
            // 
            this.btnQuanLyNV.Location = new System.Drawing.Point(445, 377);
            this.btnQuanLyNV.Name = "btnQuanLyNV";
            this.btnQuanLyNV.Size = new System.Drawing.Size(255, 43);
            this.btnQuanLyNV.TabIndex = 0;
            this.btnQuanLyNV.Text = "Quản lý nhân viên";
            this.btnQuanLyNV.UseVisualStyleBackColor = true;
            // 
            // btnNhapHangCu
            // 
            this.btnNhapHangCu.Location = new System.Drawing.Point(445, 74);
            this.btnNhapHangCu.Name = "btnNhapHangCu";
            this.btnNhapHangCu.Size = new System.Drawing.Size(255, 43);
            this.btnNhapHangCu.TabIndex = 0;
            this.btnNhapHangCu.Text = "Nhập hàng";
            this.btnNhapHangCu.UseVisualStyleBackColor = true;
            this.btnNhapHangCu.Click += new System.EventHandler(this.btnNhapHangCu_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 450);
            this.Controls.Add(this.btnQuanLyNV);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnThongKeLL);
            this.Controls.Add(this.btnNhapHangCu);
            this.Controls.Add(this.btnNhapHang);
            this.Controls.Add(this.btnQuanLyKH);
            this.Controls.Add(this.btnBanHang);
            this.Controls.Add(this.btnThongKeHang);
            this.Controls.Add(this.btnQuanLyND);
            this.Name = "MainForm";
            this.Text = "Phần mềm quản lí bán hàng";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuanLyND;
        private System.Windows.Forms.Button btnNhapHang;
        private System.Windows.Forms.Button btnBanHang;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThongKeHang;
        private System.Windows.Forms.Button btnQuanLyKH;
        private System.Windows.Forms.Button btnThongKeLL;
        private System.Windows.Forms.Button btnQuanLyNV;
        private System.Windows.Forms.Button btnNhapHangCu;
    }
}