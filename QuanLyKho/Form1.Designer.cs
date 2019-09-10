namespace QuanLyKho
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dMHàngHóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dMNhàCungCấpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dMKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpKhoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtKhoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyKho.Properties.Resources.KhoSITCDV2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(585, 277);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.danhMụcToolStripMenuItem,
            this.báoCáoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(586, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýTàiKhoảnToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ Thống";
            this.hệThốngToolStripMenuItem.Click += new System.EventHandler(this.hệThốngToolStripMenuItem_Click);
            // 
            // quảnLýTàiKhoảnToolStripMenuItem
            // 
            this.quảnLýTàiKhoảnToolStripMenuItem.Name = "quảnLýTàiKhoảnToolStripMenuItem";
            this.quảnLýTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.quảnLýTàiKhoảnToolStripMenuItem.Text = "Quản Lý Tài Khoản";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dMHàngHóaToolStripMenuItem,
            this.dMNhàCungCấpToolStripMenuItem,
            this.dMKháchHàngToolStripMenuItem});
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.danhMụcToolStripMenuItem.Text = "Danh Mục";
            // 
            // dMHàngHóaToolStripMenuItem
            // 
            this.dMHàngHóaToolStripMenuItem.Name = "dMHàngHóaToolStripMenuItem";
            this.dMHàngHóaToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.dMHàngHóaToolStripMenuItem.Text = "DM Hàng Hóa";
            // 
            // dMNhàCungCấpToolStripMenuItem
            // 
            this.dMNhàCungCấpToolStripMenuItem.Name = "dMNhàCungCấpToolStripMenuItem";
            this.dMNhàCungCấpToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.dMNhàCungCấpToolStripMenuItem.Text = "DM Nhà Cung Cấp";
            // 
            // dMKháchHàngToolStripMenuItem
            // 
            this.dMKháchHàngToolStripMenuItem.Name = "dMKháchHàngToolStripMenuItem";
            this.dMKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.dMKháchHàngToolStripMenuItem.Text = "DM Khách Hàng";
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhậpKhoToolStripMenuItem1,
            this.xuấtKhoToolStripMenuItem1,
            this.báoCáoToolStripMenuItem1});
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.báoCáoToolStripMenuItem.Text = "Chức Năng";
            // 
            // nhậpKhoToolStripMenuItem1
            // 
            this.nhậpKhoToolStripMenuItem1.Name = "nhậpKhoToolStripMenuItem1";
            this.nhậpKhoToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.nhậpKhoToolStripMenuItem1.Text = "Nhập Kho";
            // 
            // xuấtKhoToolStripMenuItem1
            // 
            this.xuấtKhoToolStripMenuItem1.Name = "xuấtKhoToolStripMenuItem1";
            this.xuấtKhoToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.xuấtKhoToolStripMenuItem1.Text = "Xuất Kho";
            // 
            // báoCáoToolStripMenuItem1
            // 
            this.báoCáoToolStripMenuItem1.Name = "báoCáoToolStripMenuItem1";
            this.báoCáoToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.báoCáoToolStripMenuItem1.Text = "Báo Cáo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 305);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dMHàngHóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dMNhàCungCấpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dMKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpKhoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem xuấtKhoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem1;
    }
}

