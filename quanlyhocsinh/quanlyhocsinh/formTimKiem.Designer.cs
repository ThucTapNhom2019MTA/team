namespace quanlyhocsinh
{
    partial class formTimKiem
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_back = new System.Windows.Forms.Button();
            this.bt_timkiem = new System.Windows.Forms.Button();
            this.tb_timkiem = new System.Windows.Forms.TextBox();
            this.cbTimKiemGV = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbTimkiemSV = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nhập từ khóa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tìm kiếm theo";
            // 
            // bt_back
            // 
            this.bt_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bt_back.Location = new System.Drawing.Point(159, 357);
            this.bt_back.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_back.Name = "bt_back";
            this.bt_back.Size = new System.Drawing.Size(112, 41);
            this.bt_back.TabIndex = 9;
            this.bt_back.Text = "BACK";
            this.bt_back.UseVisualStyleBackColor = false;
            this.bt_back.Click += new System.EventHandler(this.bt_back_Click);
            // 
            // bt_timkiem
            // 
            this.bt_timkiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bt_timkiem.Location = new System.Drawing.Point(13, 357);
            this.bt_timkiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_timkiem.Name = "bt_timkiem";
            this.bt_timkiem.Size = new System.Drawing.Size(120, 41);
            this.bt_timkiem.TabIndex = 8;
            this.bt_timkiem.Text = "TÌM KIẾM";
            this.bt_timkiem.UseVisualStyleBackColor = false;
            // 
            // tb_timkiem
            // 
            this.tb_timkiem.Location = new System.Drawing.Point(44, 260);
            this.tb_timkiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_timkiem.Name = "tb_timkiem";
            this.tb_timkiem.Size = new System.Drawing.Size(151, 26);
            this.tb_timkiem.TabIndex = 7;
            // 
            // cbTimKiemGV
            // 
            this.cbTimKiemGV.FormattingEnabled = true;
            this.cbTimKiemGV.Items.AddRange(new object[] {
            "ID",
            "Name",
            "Phone",
            "Address",
            "Speciality"});
            this.cbTimKiemGV.Location = new System.Drawing.Point(44, 50);
            this.cbTimKiemGV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbTimKiemGV.Name = "cbTimKiemGV";
            this.cbTimKiemGV.Size = new System.Drawing.Size(151, 28);
            this.cbTimKiemGV.TabIndex = 6;
            this.cbTimKiemGV.Text = "ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(357, 17);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(431, 422);
            this.dataGridView1.TabIndex = 12;
            // 
            // cbTimkiemSV
            // 
            this.cbTimkiemSV.FormattingEnabled = true;
            this.cbTimkiemSV.Items.AddRange(new object[] {
            "ID",
            "Name",
            "Phone",
            "Address"});
            this.cbTimkiemSV.Location = new System.Drawing.Point(44, 50);
            this.cbTimkiemSV.Name = "cbTimkiemSV";
            this.cbTimkiemSV.Size = new System.Drawing.Size(151, 28);
            this.cbTimkiemSV.TabIndex = 13;
            this.cbTimkiemSV.Text = "ID";
            // 
            // formTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbTimkiemSV);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_back);
            this.Controls.Add(this.bt_timkiem);
            this.Controls.Add(this.tb_timkiem);
            this.Controls.Add(this.cbTimKiemGV);
            this.Name = "formTimKiem";
            this.Text = "formTimKiem";
            this.Load += new System.EventHandler(this.formTimKiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_back;
        private System.Windows.Forms.Button bt_timkiem;
        private System.Windows.Forms.TextBox tb_timkiem;
        private System.Windows.Forms.ComboBox cbTimKiemGV;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbTimkiemSV;
    }
}