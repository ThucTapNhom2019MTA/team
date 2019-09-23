namespace quanlyhocsinh
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
            this.pb_hs = new System.Windows.Forms.PictureBox();
            this.pb_gv = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_hs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_gv)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_hs
            // 
            this.pb_hs.Image = global::quanlyhocsinh.Properties.Resources.hocsinh;
            this.pb_hs.Location = new System.Drawing.Point(544, 105);
            this.pb_hs.Name = "pb_hs";
            this.pb_hs.Size = new System.Drawing.Size(180, 180);
            this.pb_hs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_hs.TabIndex = 0;
            this.pb_hs.TabStop = false;
            this.pb_hs.Click += new System.EventHandler(this.Pb_hs_Click);
            // 
            // pb_gv
            // 
            this.pb_gv.Image = global::quanlyhocsinh.Properties.Resources.giaovien;
            this.pb_gv.Location = new System.Drawing.Point(184, 105);
            this.pb_gv.Name = "pb_gv";
            this.pb_gv.Size = new System.Drawing.Size(180, 180);
            this.pb_gv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_gv.TabIndex = 0;
            this.pb_gv.TabStop = false;
            this.pb_gv.Click += new System.EventHandler(this.Pb_gv_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 510);
            this.Controls.Add(this.pb_hs);
            this.Controls.Add(this.pb_gv);
            this.Name = "Form1";
            this.Text = "QUẢN LÝ HỌC SINH";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_hs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_gv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_gv;
        private System.Windows.Forms.PictureBox pb_hs;
    }
}

