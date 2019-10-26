namespace QLThuVien
{
    partial class DangNhap
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
            this.lbl_TT = new System.Windows.Forms.Label();
            this.lbl_User = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.btn_Log = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lbl_TTlogin = new System.Windows.Forms.Label();
            this.chk_show = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbl_TT
            // 
            this.lbl_TT.AutoSize = true;
            this.lbl_TT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_TT.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TT.ForeColor = System.Drawing.Color.Red;
            this.lbl_TT.Location = new System.Drawing.Point(214, 19);
            this.lbl_TT.Name = "lbl_TT";
            this.lbl_TT.Size = new System.Drawing.Size(174, 22);
            this.lbl_TT.TabIndex = 0;
            this.lbl_TT.Text = "Đăng nhập hệ thống";
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_User.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User.Location = new System.Drawing.Point(122, 63);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(48, 22);
            this.lbl_User.TabIndex = 1;
            this.lbl_User.Text = "User";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_pass.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pass.Location = new System.Drawing.Point(122, 113);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(90, 22);
            this.lbl_pass.TabIndex = 2;
            this.lbl_pass.Text = "Password";
            // 
            // txt_user
            // 
            this.txt_user.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.Location = new System.Drawing.Point(218, 60);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(241, 29);
            this.txt_user.TabIndex = 3;
            // 
            // txt_pass
            // 
            this.txt_pass.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(218, 110);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(241, 29);
            this.txt_pass.TabIndex = 4;
            // 
            // btn_Log
            // 
            this.btn_Log.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log.ForeColor = System.Drawing.Color.Red;
            this.btn_Log.Location = new System.Drawing.Point(218, 195);
            this.btn_Log.Name = "btn_Log";
            this.btn_Log.Size = new System.Drawing.Size(74, 32);
            this.btn_Log.TabIndex = 5;
            this.btn_Log.Text = "Login";
            this.btn_Log.UseVisualStyleBackColor = true;
            this.btn_Log.Click += new System.EventHandler(this.btn_Log_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.Color.Red;
            this.btn_Cancel.Location = new System.Drawing.Point(371, 195);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(88, 32);
            this.btn_Cancel.TabIndex = 6;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // lbl_TTlogin
            // 
            this.lbl_TTlogin.AutoSize = true;
            this.lbl_TTlogin.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TTlogin.ForeColor = System.Drawing.Color.Red;
            this.lbl_TTlogin.Location = new System.Drawing.Point(12, 195);
            this.lbl_TTlogin.Name = "lbl_TTlogin";
            this.lbl_TTlogin.Size = new System.Drawing.Size(95, 15);
            this.lbl_TTlogin.TabIndex = 7;
            this.lbl_TTlogin.Text = "Chưa đăng nhập";
            // 
            // chk_show
            // 
            this.chk_show.AutoSize = true;
            this.chk_show.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_show.Location = new System.Drawing.Point(222, 162);
            this.chk_show.Name = "chk_show";
            this.chk_show.Size = new System.Drawing.Size(105, 19);
            this.chk_show.TabIndex = 8;
            this.chk_show.Text = "Show password";
            this.chk_show.UseVisualStyleBackColor = true;
            this.chk_show.CheckedChanged += new System.EventHandler(this.chk_show_CheckedChanged);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.None;
            this.BackgroundImageStore = global::QLThuVien.Properties.Resources.Login_Manager;
            this.ClientSize = new System.Drawing.Size(515, 239);
            this.Controls.Add(this.chk_show);
            this.Controls.Add(this.lbl_TTlogin);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Log);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_User);
            this.Controls.Add(this.lbl_TT);
            this.DoubleBuffered = true;
            this.Name = "DangNhap";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.DangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_TT;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.Label lbl_pass;
        public System.Windows.Forms.TextBox txt_user;
        public System.Windows.Forms.TextBox txt_pass;
        public System.Windows.Forms.Button btn_Log;
        public System.Windows.Forms.Button btn_Cancel;
        public System.Windows.Forms.Label lbl_TTlogin;
        private System.Windows.Forms.CheckBox chk_show;
    }
}