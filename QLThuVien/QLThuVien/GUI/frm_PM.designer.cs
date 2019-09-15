namespace QLThuVien.GUI
{
    partial class frm_PM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_PM));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txt_NT = new DevExpress.XtraEditors.DateEdit();
            this.txt_NM = new DevExpress.XtraEditors.DateEdit();
            this.cmb_MaCS = new System.Windows.Forms.ComboBox();
            this.cmb_TenTT = new System.Windows.Forms.ComboBox();
            this.cmb_TenTS = new System.Windows.Forms.ComboBox();
            this.cmb_TenDG = new System.Windows.Forms.ComboBox();
            this.txt_MaPM = new DevExpress.XtraEditors.TextEdit();
            this.txt_TT = new DevExpress.XtraEditors.ComboBoxEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lci_MaPM = new DevExpress.XtraLayout.LayoutControlItem();
            this.lbl_TenTT = new DevExpress.XtraLayout.LayoutControlItem();
            this.lci_TTr = new DevExpress.XtraLayout.LayoutControlItem();
            this.lbl_TenTS = new DevExpress.XtraLayout.LayoutControlItem();
            this.lbl_MaCS = new DevExpress.XtraLayout.LayoutControlItem();
            this.lbl_TenDG = new DevExpress.XtraLayout.LayoutControlItem();
            this.lbl_NM = new DevExpress.XtraLayout.LayoutControlItem();
            this.lbl_NT = new DevExpress.XtraLayout.LayoutControlItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_cancel = new DevExpress.XtraEditors.SimpleButton();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_update = new DevExpress.XtraEditors.SimpleButton();
            this.btn_insert = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NT.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NM.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaPM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_MaPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_TenTT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_TTr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_TenTS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_MaCS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_TenDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_NM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_NT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutControl1.Controls.Add(this.txt_NT);
            this.layoutControl1.Controls.Add(this.txt_NM);
            this.layoutControl1.Controls.Add(this.cmb_MaCS);
            this.layoutControl1.Controls.Add(this.cmb_TenTT);
            this.layoutControl1.Controls.Add(this.cmb_TenTS);
            this.layoutControl1.Controls.Add(this.cmb_TenDG);
            this.layoutControl1.Controls.Add(this.txt_MaPM);
            this.layoutControl1.Controls.Add(this.txt_TT);
            this.layoutControl1.Location = new System.Drawing.Point(27, 3);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(858, 163);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txt_NT
            // 
            this.txt_NT.EditValue = null;
            this.txt_NT.Location = new System.Drawing.Point(517, 65);
            this.txt_NT.Name = "txt_NT";
            this.txt_NT.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NT.Properties.Appearance.Options.UseFont = true;
            this.txt_NT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_NT.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_NT.Size = new System.Drawing.Size(329, 24);
            this.txt_NT.StyleController = this.layoutControl1;
            this.txt_NT.TabIndex = 20;
            // 
            // txt_NM
            // 
            this.txt_NM.EditValue = null;
            this.txt_NM.Location = new System.Drawing.Point(122, 65);
            this.txt_NM.Name = "txt_NM";
            this.txt_NM.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NM.Properties.Appearance.Options.UseFont = true;
            this.txt_NM.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_NM.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_NM.Size = new System.Drawing.Size(281, 24);
            this.txt_NM.StyleController = this.layoutControl1;
            this.txt_NM.TabIndex = 19;
            // 
            // cmb_MaCS
            // 
            this.cmb_MaCS.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_MaCS.FormattingEnabled = true;
            this.cmb_MaCS.Location = new System.Drawing.Point(517, 40);
            this.cmb_MaCS.Name = "cmb_MaCS";
            this.cmb_MaCS.Size = new System.Drawing.Size(329, 25);
            this.cmb_MaCS.TabIndex = 18;
            this.cmb_MaCS.Click += new System.EventHandler(this.cmb_MaCS_Click);
            // 
            // cmb_TenTT
            // 
            this.cmb_TenTT.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_TenTT.FormattingEnabled = true;
            this.cmb_TenTT.Location = new System.Drawing.Point(122, 118);
            this.cmb_TenTT.Name = "cmb_TenTT";
            this.cmb_TenTT.Size = new System.Drawing.Size(724, 25);
            this.cmb_TenTT.TabIndex = 17;
            // 
            // cmb_TenTS
            // 
            this.cmb_TenTS.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_TenTS.FormattingEnabled = true;
            this.cmb_TenTS.Location = new System.Drawing.Point(122, 40);
            this.cmb_TenTS.Name = "cmb_TenTS";
            this.cmb_TenTS.Size = new System.Drawing.Size(281, 25);
            this.cmb_TenTS.TabIndex = 16;
            // 
            // cmb_TenDG
            // 
            this.cmb_TenDG.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_TenDG.FormattingEnabled = true;
            this.cmb_TenDG.Location = new System.Drawing.Point(122, 93);
            this.cmb_TenDG.Name = "cmb_TenDG";
            this.cmb_TenDG.Size = new System.Drawing.Size(724, 25);
            this.cmb_TenDG.TabIndex = 15;
            // 
            // txt_MaPM
            // 
            this.txt_MaPM.Enabled = false;
            this.txt_MaPM.Location = new System.Drawing.Point(122, 12);
            this.txt_MaPM.Name = "txt_MaPM";
            this.txt_MaPM.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaPM.Properties.Appearance.Options.UseFont = true;
            this.txt_MaPM.Size = new System.Drawing.Size(281, 24);
            this.txt_MaPM.StyleController = this.layoutControl1;
            this.txt_MaPM.TabIndex = 4;
            // 
            // txt_TT
            // 
            this.txt_TT.Location = new System.Drawing.Point(517, 12);
            this.txt_TT.Name = "txt_TT";
            this.txt_TT.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TT.Properties.Appearance.Options.UseFont = true;
            this.txt_TT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_TT.Properties.Items.AddRange(new object[] {
            "Tốt",
            "Cũ"});
            this.txt_TT.Size = new System.Drawing.Size(329, 24);
            this.txt_TT.StyleController = this.layoutControl1;
            this.txt_TT.TabIndex = 14;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lci_MaPM,
            this.lbl_TenTT,
            this.lci_TTr,
            this.lbl_TenDG,
            this.lbl_NM,
            this.lbl_NT,
            this.lbl_TenTS,
            this.lbl_MaCS});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(858, 163);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lci_MaPM
            // 
            this.lci_MaPM.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lci_MaPM.AppearanceItemCaption.Options.UseFont = true;
            this.lci_MaPM.Control = this.txt_MaPM;
            this.lci_MaPM.Location = new System.Drawing.Point(0, 0);
            this.lci_MaPM.Name = "lci_MaPM";
            this.lci_MaPM.Size = new System.Drawing.Size(395, 28);
            this.lci_MaPM.Text = "Mã Phiếu Mượn";
            this.lci_MaPM.TextSize = new System.Drawing.Size(107, 17);
            // 
            // lbl_TenTT
            // 
            this.lbl_TenTT.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenTT.AppearanceItemCaption.Options.UseFont = true;
            this.lbl_TenTT.Control = this.cmb_TenTT;
            this.lbl_TenTT.Location = new System.Drawing.Point(0, 106);
            this.lbl_TenTT.Name = "lbl_TenTT";
            this.lbl_TenTT.Size = new System.Drawing.Size(838, 37);
            this.lbl_TenTT.Text = "Thủ thư";
            this.lbl_TenTT.TextSize = new System.Drawing.Size(107, 17);
            // 
            // lci_TTr
            // 
            this.lci_TTr.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lci_TTr.AppearanceItemCaption.Options.UseFont = true;
            this.lci_TTr.Control = this.txt_TT;
            this.lci_TTr.Location = new System.Drawing.Point(395, 0);
            this.lci_TTr.Name = "lci_TTr";
            this.lci_TTr.Size = new System.Drawing.Size(443, 28);
            this.lci_TTr.Text = "Tình trạng";
            this.lci_TTr.TextSize = new System.Drawing.Size(107, 17);
            // 
            // lbl_TenTS
            // 
            this.lbl_TenTS.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenTS.AppearanceItemCaption.Options.UseFont = true;
            this.lbl_TenTS.Control = this.cmb_TenTS;
            this.lbl_TenTS.Location = new System.Drawing.Point(0, 28);
            this.lbl_TenTS.Name = "lbl_TenTS";
            this.lbl_TenTS.Size = new System.Drawing.Size(395, 25);
            this.lbl_TenTS.Text = "Tựa sách";
            this.lbl_TenTS.TextSize = new System.Drawing.Size(107, 17);
            // 
            // lbl_MaCS
            // 
            this.lbl_MaCS.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaCS.AppearanceItemCaption.Options.UseFont = true;
            this.lbl_MaCS.Control = this.cmb_MaCS;
            this.lbl_MaCS.Location = new System.Drawing.Point(395, 28);
            this.lbl_MaCS.Name = "lbl_MaCS";
            this.lbl_MaCS.Size = new System.Drawing.Size(443, 25);
            this.lbl_MaCS.Text = "Mã Cuốn sách";
            this.lbl_MaCS.TextSize = new System.Drawing.Size(107, 17);
            // 
            // lbl_TenDG
            // 
            this.lbl_TenDG.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenDG.AppearanceItemCaption.Options.UseFont = true;
            this.lbl_TenDG.Control = this.cmb_TenDG;
            this.lbl_TenDG.Location = new System.Drawing.Point(0, 81);
            this.lbl_TenDG.Name = "lbl_TenDG";
            this.lbl_TenDG.Size = new System.Drawing.Size(838, 25);
            this.lbl_TenDG.Text = "Độc Giả";
            this.lbl_TenDG.TextSize = new System.Drawing.Size(107, 17);
            // 
            // lbl_NM
            // 
            this.lbl_NM.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NM.AppearanceItemCaption.Options.UseFont = true;
            this.lbl_NM.Control = this.txt_NM;
            this.lbl_NM.Location = new System.Drawing.Point(0, 53);
            this.lbl_NM.Name = "lbl_NM";
            this.lbl_NM.Size = new System.Drawing.Size(395, 28);
            this.lbl_NM.Text = "Ngày mượn";
            this.lbl_NM.TextSize = new System.Drawing.Size(107, 17);
            // 
            // lbl_NT
            // 
            this.lbl_NT.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NT.AppearanceItemCaption.Options.UseFont = true;
            this.lbl_NT.Control = this.txt_NT;
            this.lbl_NT.Location = new System.Drawing.Point(395, 53);
            this.lbl_NT.Name = "lbl_NT";
            this.lbl_NT.Size = new System.Drawing.Size(443, 28);
            this.lbl_NT.Text = "Ngày trả";
            this.lbl_NT.TextSize = new System.Drawing.Size(107, 17);
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
            this.panelControl1.Location = new System.Drawing.Point(36, 172);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(837, 59);
            this.panelControl1.TabIndex = 8;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Appearance.Options.UseFont = true;
            this.btn_cancel.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancel.Image")));
            this.btn_cancel.Location = new System.Drawing.Point(426, 12);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(100, 35);
            this.btn_cancel.TabIndex = 20;
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
            this.txt_search.Size = new System.Drawing.Size(285, 35);
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
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(36, 237);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(837, 205);
            this.gridControl1.TabIndex = 9;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn7,
            this.gridColumn4,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn6,
            this.gridColumn10,
            this.gridColumn11});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 2;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn7, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn1, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.Click += new System.EventHandler(this.gridView1_Click);
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn1.AppearanceCell.Options.UseFont = true;
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.Caption = "Mã PM";
            this.gridColumn1.FieldName = "MaPM";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn7
            // 
            this.gridColumn7.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn7.AppearanceCell.Options.UseFont = true;
            this.gridColumn7.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn7.AppearanceHeader.Options.UseFont = true;
            this.gridColumn7.Caption = "Độc giả";
            this.gridColumn7.FieldName = "TenDG";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn4.AppearanceCell.Options.UseFont = true;
            this.gridColumn4.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn4.AppearanceHeader.Options.UseFont = true;
            this.gridColumn4.Caption = "Mã CS";
            this.gridColumn4.FieldName = "MaCS";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            this.gridColumn4.Width = 101;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn2.AppearanceCell.Options.UseFont = true;
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.Caption = "Ngày Mượn";
            this.gridColumn2.FieldName = "NgayMuon";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 89;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn3.AppearanceCell.Options.UseFont = true;
            this.gridColumn3.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn3.AppearanceHeader.Options.UseFont = true;
            this.gridColumn3.Caption = "Ngày trả";
            this.gridColumn3.FieldName = "NgayTra";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 77;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn6.AppearanceCell.Options.UseFont = true;
            this.gridColumn6.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn6.AppearanceHeader.Options.UseFont = true;
            this.gridColumn6.Caption = "Tựa sách";
            this.gridColumn6.FieldName = "TenTS";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 3;
            this.gridColumn6.Width = 105;
            // 
            // gridColumn10
            // 
            this.gridColumn10.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn10.AppearanceCell.Options.UseFont = true;
            this.gridColumn10.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn10.AppearanceHeader.Options.UseFont = true;
            this.gridColumn10.Caption = "Thủ thư";
            this.gridColumn10.FieldName = "TenTT";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 4;
            this.gridColumn10.Width = 115;
            // 
            // gridColumn11
            // 
            this.gridColumn11.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn11.AppearanceCell.Options.UseFont = true;
            this.gridColumn11.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn11.AppearanceHeader.Options.UseFont = true;
            this.gridColumn11.Caption = "Tình trạng";
            this.gridColumn11.FieldName = "TinhTrang";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 5;
            this.gridColumn11.Width = 82;
            // 
            // frm_PM
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frm_PM";
            this.Size = new System.Drawing.Size(900, 450);
            this.Load += new System.EventHandler(this.frm_PM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_NT.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NM.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaPM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_MaPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_TenTT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_TTr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_TenTS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_MaCS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_TenDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_NM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_NT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txt_MaPM;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem lci_MaPM;
        private DevExpress.XtraLayout.LayoutControlItem lci_TTr;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.TextBox txt_search;
        private DevExpress.XtraEditors.SimpleButton btn_save;
        private DevExpress.XtraEditors.SimpleButton btn_delete;
        private DevExpress.XtraEditors.SimpleButton btn_update;
        private DevExpress.XtraEditors.SimpleButton btn_insert;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private System.Windows.Forms.ComboBox cmb_TenTT;
        private System.Windows.Forms.ComboBox cmb_TenTS;
        private System.Windows.Forms.ComboBox cmb_TenDG;
        private DevExpress.XtraLayout.LayoutControlItem lbl_TenTT;
        private DevExpress.XtraLayout.LayoutControlItem lbl_TenDG;
        private DevExpress.XtraLayout.LayoutControlItem lbl_TenTS;
        private System.Windows.Forms.ComboBox cmb_MaCS;
        private DevExpress.XtraLayout.LayoutControlItem lbl_MaCS;
        private DevExpress.XtraEditors.SimpleButton btn_cancel;
        private DevExpress.XtraEditors.DateEdit txt_NT;
        private DevExpress.XtraEditors.DateEdit txt_NM;
        private DevExpress.XtraLayout.LayoutControlItem lbl_NM;
        private DevExpress.XtraLayout.LayoutControlItem lbl_NT;
        private DevExpress.XtraEditors.ComboBoxEdit txt_TT;
    }
}
