namespace ThucTapNhom2019_Project1
{
    partial class FormHelp
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Thêm nhân viên");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Sửa nhân viên");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Xóa nhân viên");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Tìm kiếm");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Màn hình chính", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Các chức năng", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Giới thiệu phần mềm", new System.Windows.Forms.TreeNode[] {
            treeNode6});
            this.txtGioiThieu = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGioiThieu
            // 
            this.txtGioiThieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGioiThieu.Location = new System.Drawing.Point(256, 426);
            this.txtGioiThieu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGioiThieu.Multiline = true;
            this.txtGioiThieu.Name = "txtGioiThieu";
            this.txtGioiThieu.Size = new System.Drawing.Size(544, 24);
            this.txtGioiThieu.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(256, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(544, 426);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "them";
            treeNode1.Text = "Thêm nhân viên";
            treeNode2.Name = "sua";
            treeNode2.Text = "Sửa nhân viên";
            treeNode3.Name = "xoa";
            treeNode3.Text = "Xóa nhân viên";
            treeNode4.Name = "timkiem";
            treeNode4.Text = "Tìm kiếm";
            treeNode5.Name = "manhinhchinh";
            treeNode5.Text = "Màn hình chính";
            treeNode6.Name = "gtChucNang";
            treeNode6.Text = "Các chức năng";
            treeNode7.Name = "gtPhanMem";
            treeNode7.Text = "Giới thiệu phần mềm";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7});
            this.treeView1.Size = new System.Drawing.Size(256, 450);
            this.treeView1.TabIndex = 8;
            // 
            // FormHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtGioiThieu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.treeView1);
            this.Name = "FormHelp";
            this.Text = "FormHelp";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGioiThieu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TreeView treeView1;
    }
}