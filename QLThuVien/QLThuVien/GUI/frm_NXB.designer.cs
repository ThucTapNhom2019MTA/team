namespace QLThuVien.GUI
{
    partial class frm_NXB
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_NXB));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_cancel = new DevExpress.XtraEditors.SimpleButton();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_update = new DevExpress.XtraEditors.SimpleButton();
            this.btn_insert = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txt_Email = new DevExpress.XtraEditors.TextEdit();
            this.txt_SDT = new DevExpress.XtraEditors.TextEdit();
            this.txt_DC = new DevExpress.XtraEditors.TextEdit();
            this.txt_TenNXB = new DevExpress.XtraEditors.TextEdit();
            this.txt_MaNXB = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lci_MaNXB = new DevExpress.XtraLayout.LayoutControlItem();
            this.lci_DC = new DevExpress.XtraLayout.LayoutControlItem();
            this.lci_Email = new DevExpress.XtraLayout.LayoutControlItem();
            this.lci_TenNXB = new DevExpress.XtraLayout.LayoutControlItem();
            this.lci_SDT = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Email.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenNXB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaNXB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_MaNXB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_DC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_Email)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_TenNXB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_SDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.btn_cancel);
            this.panelControl1.Controls.Add(this.txt_search);
            this.panelControl1.Controls.Add(this.btn_save);
            this.panelControl1.Controls.Add(this.btn_delete);
            this.panelControl1.Controls.Add(this.btn_update);
            this.panelControl1.Controls.Add(this.btn_insert);
            this.panelControl1.Location = new System.Drawing.Point(38, 161);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(825, 59);
            this.panelControl1.TabIndex = 3;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Appearance.Options.UseFont = true;
            this.btn_cancel.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancel.Image")));
            this.btn_cancel.Location = new System.Drawing.Point(426, 12);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(100, 35);
            this.btn_cancel.TabIndex = 19;
            this.btn_cancel.Text = "CANCEL";
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // txt_search
            // 
            this.txt_search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_search.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txt_search.Location = new System.Drawing.Point(532, 12);
            this.txt_search.Multiline = true;
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(270, 35);
            this.txt_search.TabIndex = 17;
            this.txt_search.Text = "Search";
            this.txt_search.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_search_MouseClick);
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // btn_save
            // 
            this.btn_save.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Appearance.Options.UseFont = true;
            this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            this.btn_save.Location = new System.Drawing.Point(320, 12);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(100, 35);
            this.btn_save.TabIndex = 15;
            this.btn_save.Text = "SAVE";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Appearance.Options.UseFont = true;
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.Location = new System.Drawing.Point(214, 12);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(100, 35);
            this.btn_delete.TabIndex = 14;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Appearance.Options.UseFont = true;
            this.btn_update.Image = ((System.Drawing.Image)(resources.GetObject("btn_update.Image")));
            this.btn_update.Location = new System.Drawing.Point(108, 12);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(100, 35);
            this.btn_update.TabIndex = 13;
            this.btn_update.Text = "UPDATE";
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert.Appearance.Options.UseFont = true;
            this.btn_insert.Image = ((System.Drawing.Image)(resources.GetObject("btn_insert.Image")));
            this.btn_insert.Location = new System.Drawing.Point(2, 12);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(100, 35);
            this.btn_insert.TabIndex = 12;
            this.btn_insert.Text = "INSERT";
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutControl1.Controls.Add(this.txt_Email);
            this.layoutControl1.Controls.Add(this.txt_SDT);
            this.layoutControl1.Controls.Add(this.txt_DC);
            this.layoutControl1.Controls.Add(this.txt_TenNXB);
            this.layoutControl1.Controls.Add(this.txt_MaNXB);
            this.layoutControl1.Location = new System.Drawing.Point(27, 16);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(848, 139);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(82, 68);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.Properties.Appearance.Options.UseFont = true;
            this.txt_Email.Size = new System.Drawing.Size(754, 24);
            this.txt_Email.StyleController = this.layoutControl1;
            this.txt_Email.TabIndex = 8;
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(496, 40);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SDT.Properties.Appearance.Options.UseFont = true;
            this.txt_SDT.Size = new System.Drawing.Size(340, 24);
            this.txt_SDT.StyleController = this.layoutControl1;
            this.txt_SDT.TabIndex = 7;
            // 
            // txt_DC
            // 
            this.txt_DC.Location = new System.Drawing.Point(82, 40);
            this.txt_DC.Name = "txt_DC";
            this.txt_DC.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DC.Properties.Appearance.Options.UseFont = true;
            this.txt_DC.Size = new System.Drawing.Size(340, 24);
            this.txt_DC.StyleController = this.layoutControl1;
            this.txt_DC.TabIndex = 6;
            // 
            // txt_TenNXB
            // 
            this.txt_TenNXB.Location = new System.Drawing.Point(495, 12);
            this.txt_TenNXB.Name = "txt_TenNXB";
            this.txt_TenNXB.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenNXB.Properties.Appearance.Options.UseFont = true;
            this.txt_TenNXB.Size = new System.Drawing.Size(341, 24);
            this.txt_TenNXB.StyleController = this.layoutControl1;
            this.txt_TenNXB.TabIndex = 5;
            // 
            // txt_MaNXB
            // 
            this.txt_MaNXB.Enabled = false;
            this.txt_MaNXB.Location = new System.Drawing.Point(82, 12);
            this.txt_MaNXB.Name = "txt_MaNXB";
            this.txt_MaNXB.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaNXB.Properties.Appearance.Options.UseFont = true;
            this.txt_MaNXB.Size = new System.Drawing.Size(339, 24);
            this.txt_MaNXB.StyleController = this.layoutControl1;
            this.txt_MaNXB.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lci_MaNXB,
            this.lci_DC,
            this.lci_Email,
            this.lci_TenNXB,
            this.lci_SDT});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(848, 139);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lci_MaNXB
            // 
            this.lci_MaNXB.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lci_MaNXB.AppearanceItemCaption.Options.UseFont = true;
            this.lci_MaNXB.Control = this.txt_MaNXB;
            this.lci_MaNXB.Location = new System.Drawing.Point(0, 0);
            this.lci_MaNXB.Name = "lci_MaNXB";
            this.lci_MaNXB.Size = new System.Drawing.Size(413, 28);
            this.lci_MaNXB.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment;
            this.lci_MaNXB.Text = "Mã NXB";
            this.lci_MaNXB.TextSize = new System.Drawing.Size(67, 17);
            // 
            // lci_DC
            // 
            this.lci_DC.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lci_DC.AppearanceItemCaption.Options.UseFont = true;
            this.lci_DC.Control = this.txt_DC;
            this.lci_DC.Location = new System.Drawing.Point(0, 28);
            this.lci_DC.Name = "lci_DC";
            this.lci_DC.Size = new System.Drawing.Size(414, 28);
            this.lci_DC.Text = "Địa chỉ";
            this.lci_DC.TextSize = new System.Drawing.Size(67, 17);
            // 
            // lci_Email
            // 
            this.lci_Email.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lci_Email.AppearanceItemCaption.Options.UseFont = true;
            this.lci_Email.Control = this.txt_Email;
            this.lci_Email.Location = new System.Drawing.Point(0, 56);
            this.lci_Email.Name = "lci_Email";
            this.lci_Email.Size = new System.Drawing.Size(828, 63);
            this.lci_Email.Text = "Email";
            this.lci_Email.TextSize = new System.Drawing.Size(67, 17);
            // 
            // lci_TenNXB
            // 
            this.lci_TenNXB.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lci_TenNXB.AppearanceItemCaption.Options.UseFont = true;
            this.lci_TenNXB.Control = this.txt_TenNXB;
            this.lci_TenNXB.Location = new System.Drawing.Point(413, 0);
            this.lci_TenNXB.Name = "lci_TenNXB";
            this.lci_TenNXB.Size = new System.Drawing.Size(415, 28);
            this.lci_TenNXB.Text = "Tên NXB";
            this.lci_TenNXB.TextSize = new System.Drawing.Size(67, 17);
            // 
            // lci_SDT
            // 
            this.lci_SDT.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lci_SDT.AppearanceItemCaption.Options.UseFont = true;
            this.lci_SDT.Control = this.txt_SDT;
            this.lci_SDT.Location = new System.Drawing.Point(414, 28);
            this.lci_SDT.Name = "lci_SDT";
            this.lci_SDT.Size = new System.Drawing.Size(414, 28);
            this.lci_SDT.Text = "Điện thoại";
            this.lci_SDT.TextSize = new System.Drawing.Size(67, 17);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(38, 226);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(825, 204);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_Click);
            this.gridView1.Click += new System.EventHandler(this.gridView1_Click);
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn1.AppearanceCell.Options.UseFont = true;
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.Caption = "Mã NXB";
            this.gridColumn1.FieldName = "MaNXB";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 100;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn2.AppearanceCell.Options.UseFont = true;
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.Caption = "Tên NXB";
            this.gridColumn2.FieldName = "TenNXB";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 196;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn3.AppearanceCell.Options.UseFont = true;
            this.gridColumn3.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn3.AppearanceHeader.Options.UseFont = true;
            this.gridColumn3.Caption = "Địa chỉ";
            this.gridColumn3.FieldName = "DiaChi";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 168;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn4.AppearanceCell.Options.UseFont = true;
            this.gridColumn4.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn4.AppearanceHeader.Options.UseFont = true;
            this.gridColumn4.Caption = "Điện thoại";
            this.gridColumn4.FieldName = "SDT";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 168;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn5.AppearanceCell.Options.UseFont = true;
            this.gridColumn5.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn5.AppearanceHeader.Options.UseFont = true;
            this.gridColumn5.Caption = "Email";
            this.gridColumn5.FieldName = "Email";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 175;
            // 
            // frm_NXB
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "frm_NXB";
            this.Size = new System.Drawing.Size(900, 450);
            this.Load += new System.EventHandler(this.frm_NXB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_Email.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenNXB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaNXB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_MaNXB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_DC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_Email)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_TenNXB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_SDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.TextBox txt_search;
        private DevExpress.XtraEditors.SimpleButton btn_save;
        private DevExpress.XtraEditors.SimpleButton btn_delete;
        private DevExpress.XtraEditors.SimpleButton btn_update;
        private DevExpress.XtraEditors.SimpleButton btn_insert;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit txt_TenNXB;
        private DevExpress.XtraEditors.TextEdit txt_MaNXB;
        private DevExpress.XtraLayout.LayoutControlItem lci_MaNXB;
        private DevExpress.XtraLayout.LayoutControlItem lci_TenNXB;
        private DevExpress.XtraEditors.TextEdit txt_Email;
        private DevExpress.XtraEditors.TextEdit txt_SDT;
        private DevExpress.XtraEditors.TextEdit txt_DC;
        private DevExpress.XtraLayout.LayoutControlItem lci_DC;
        private DevExpress.XtraLayout.LayoutControlItem lci_SDT;
        private DevExpress.XtraLayout.LayoutControlItem lci_Email;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.SimpleButton btn_cancel;
    }
}
