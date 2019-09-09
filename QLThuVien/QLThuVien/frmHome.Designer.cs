namespace QLThuVien
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.backstageViewControl1 = new DevExpress.XtraBars.Ribbon.BackstageViewControl();
            this.backstageViewClientControl1 = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
            this.backstageViewTabItem1 = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.ribbonPageCC = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btn_NCC = new DevExpress.XtraBars.BarButtonItem();
            this.btn_PN = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageMT = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btn_TTMT = new DevExpress.XtraBars.BarButtonItem();
            this.btn_TK = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageQLS = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btn_TS = new DevExpress.XtraBars.BarButtonItem();
            this.btn_TG = new DevExpress.XtraBars.BarButtonItem();
            this.btn_NXB = new DevExpress.XtraBars.BarButtonItem();
            this.btn_KS = new DevExpress.XtraBars.BarButtonItem();
            this.btn_TST = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageTV = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btn_TT = new DevExpress.XtraBars.BarButtonItem();
            this.btn_DG = new DevExpress.XtraBars.BarButtonItem();
            this.btn_GTC = new DevExpress.XtraBars.BarButtonItem();
            this.btn_QDC = new DevExpress.XtraBars.BarButtonItem();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_TTBT = new System.Windows.Forms.Button();
            this.btn_DN = new System.Windows.Forms.Button();
            this.btn_DX = new System.Windows.Forms.Button();
            this.btn_CS = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.backstageViewControl1)).BeginInit();
            this.backstageViewControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // backstageViewControl1
            // 
            this.backstageViewControl1.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Yellow;
            this.backstageViewControl1.Controls.Add(this.backstageViewClientControl1);
            this.backstageViewControl1.Items.Add(this.backstageViewTabItem1);
            resources.ApplyResources(this.backstageViewControl1, "backstageViewControl1");
            this.backstageViewControl1.Name = "backstageViewControl1";
            this.backstageViewControl1.SelectedTab = null;
            // 
            // backstageViewClientControl1
            // 
            resources.ApplyResources(this.backstageViewClientControl1, "backstageViewClientControl1");
            this.backstageViewClientControl1.Name = "backstageViewClientControl1";
            // 
            // backstageViewTabItem1
            // 
            resources.ApplyResources(this.backstageViewTabItem1, "backstageViewTabItem1");
            this.backstageViewTabItem1.ContentControl = this.backstageViewClientControl1;
            this.backstageViewTabItem1.Name = "backstageViewTabItem1";
            this.backstageViewTabItem1.Selected = false;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("xtraTabControl1.Appearance.BackColor")));
            this.xtraTabControl1.Appearance.Options.UseBackColor = true;
            resources.ApplyResources(this.xtraTabControl1, "xtraTabControl1");
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.CloseButtonClick += new System.EventHandler(this.xtraTabControl1_CloseButtonClick);
            this.xtraTabControl1.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.xtraTabControl1_ControlAdded);
            // 
            // ribbonPageCC
            // 
            this.ribbonPageCC.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("ribbonPageCC.Appearance.Font")));
            this.ribbonPageCC.Appearance.Options.UseFont = true;
            this.ribbonPageCC.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPageCC.Name = "ribbonPageCC";
            resources.ApplyResources(this.ribbonPageCC, "ribbonPageCC");
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_NCC);
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_PN);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // btn_NCC
            // 
            resources.ApplyResources(this.btn_NCC, "btn_NCC");
            this.btn_NCC.Enabled = false;
            this.btn_NCC.Id = 1;
            this.btn_NCC.LargeGlyph = global::QLThuVien.Properties.Resources.tt_nxb;
            this.btn_NCC.Name = "btn_NCC";
            this.btn_NCC.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btn_NCC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_NCC_ItemClick);
            // 
            // btn_PN
            // 
            resources.ApplyResources(this.btn_PN, "btn_PN");
            this.btn_PN.Enabled = false;
            this.btn_PN.Id = 2;
            this.btn_PN.LargeGlyph = global::QLThuVien.Properties.Resources.pm;
            this.btn_PN.Name = "btn_PN";
            this.btn_PN.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btn_PN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_PN_ItemClick);
            // 
            // ribbonPageMT
            // 
            this.ribbonPageMT.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("ribbonPageMT.Appearance.Font")));
            this.ribbonPageMT.Appearance.Options.UseFont = true;
            this.ribbonPageMT.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPageMT.Name = "ribbonPageMT";
            resources.ApplyResources(this.ribbonPageMT, "ribbonPageMT");
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.AllowTextClipping = false;
            this.ribbonPageGroup4.ItemLinks.Add(this.btn_TTMT);
            this.ribbonPageGroup4.ItemLinks.Add(this.btn_TK);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.ShowCaptionButton = false;
            // 
            // btn_TTMT
            // 
            resources.ApplyResources(this.btn_TTMT, "btn_TTMT");
            this.btn_TTMT.Enabled = false;
            this.btn_TTMT.Id = 10;
            this.btn_TTMT.LargeGlyph = global::QLThuVien.Properties.Resources.report_docgia;
            this.btn_TTMT.Name = "btn_TTMT";
            this.btn_TTMT.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btn_TTMT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_TTMT_ItemClick);
            // 
            // btn_TK
            // 
            resources.ApplyResources(this.btn_TK, "btn_TK");
            this.btn_TK.Enabled = false;
            this.btn_TK.Id = 11;
            this.btn_TK.LargeGlyph = global::QLThuVien.Properties.Resources.report_sach;
            this.btn_TK.Name = "btn_TK";
            this.btn_TK.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btn_TK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_TK_ItemClick);
            // 
            // ribbonPageQLS
            // 
            this.ribbonPageQLS.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("ribbonPageQLS.Appearance.Font")));
            this.ribbonPageQLS.Appearance.Options.UseFont = true;
            this.ribbonPageQLS.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPageQLS.Name = "ribbonPageQLS";
            resources.ApplyResources(this.ribbonPageQLS, "ribbonPageQLS");
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_TS);
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_TG);
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_NXB);
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_KS);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            // 
            // btn_TS
            // 
            resources.ApplyResources(this.btn_TS, "btn_TS");
            this.btn_TS.Enabled = false;
            this.btn_TS.Id = 14;
            this.btn_TS.LargeGlyph = global::QLThuVien.Properties.Resources.ebook;
            this.btn_TS.Name = "btn_TS";
            this.btn_TS.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btn_TS.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_TS_ItemClick);
            // 
            // btn_TG
            // 
            resources.ApplyResources(this.btn_TG, "btn_TG");
            this.btn_TG.Enabled = false;
            this.btn_TG.Id = 8;
            this.btn_TG.LargeGlyph = global::QLThuVien.Properties.Resources.edit_tacgia;
            this.btn_TG.Name = "btn_TG";
            this.btn_TG.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btn_TG.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_TG_ItemClick);
            // 
            // btn_NXB
            // 
            resources.ApplyResources(this.btn_NXB, "btn_NXB");
            this.btn_NXB.Enabled = false;
            this.btn_NXB.Id = 9;
            this.btn_NXB.LargeGlyph = global::QLThuVien.Properties.Resources.nxb;
            this.btn_NXB.Name = "btn_NXB";
            this.btn_NXB.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btn_NXB.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_NXB_ItemClick);
            // 
            // btn_KS
            // 
            resources.ApplyResources(this.btn_KS, "btn_KS");
            this.btn_KS.Enabled = false;
            this.btn_KS.Id = 10;
            this.btn_KS.LargeGlyph = global::QLThuVien.Properties.Resources.tl;
            this.btn_KS.Name = "btn_KS";
            this.btn_KS.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btn_KS.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_KS_ItemClick);
            // 
            // btn_TST
            // 
            resources.ApplyResources(this.btn_TST, "btn_TST");
            this.btn_TST.CloseRadialMenuOnItemClick = true;
            this.btn_TST.Id = 3;
            this.btn_TST.LargeGlyph = global::QLThuVien.Properties.Resources.ebook;
            this.btn_TST.Name = "btn_TST";
            this.btn_TST.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // ribbonPageTV
            // 
            this.ribbonPageTV.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("ribbonPageTV.Appearance.Font")));
            this.ribbonPageTV.Appearance.Options.UseFont = true;
            this.ribbonPageTV.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPageTV.Name = "ribbonPageTV";
            resources.ApplyResources(this.ribbonPageTV, "ribbonPageTV");
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_TT);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_DG);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_GTC);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_QDC);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            // 
            // btn_TT
            // 
            this.btn_TT.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            resources.ApplyResources(this.btn_TT, "btn_TT");
            this.btn_TT.Enabled = false;
            this.btn_TT.Id = 1;
            this.btn_TT.LargeGlyph = global::QLThuVien.Properties.Resources.group;
            this.btn_TT.Name = "btn_TT";
            this.btn_TT.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btn_TT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbt_TT_ItemClick);
            // 
            // btn_DG
            // 
            resources.ApplyResources(this.btn_DG, "btn_DG");
            this.btn_DG.Enabled = false;
            this.btn_DG.Id = 4;
            this.btn_DG.LargeGlyph = global::QLThuVien.Properties.Resources.student;
            this.btn_DG.Name = "btn_DG";
            this.btn_DG.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btn_DG.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_DG_ItemClick);
            // 
            // btn_GTC
            // 
            resources.ApplyResources(this.btn_GTC, "btn_GTC");
            this.btn_GTC.Id = 5;
            this.btn_GTC.LargeGlyph = global::QLThuVien.Properties.Resources.pm;
            this.btn_GTC.Name = "btn_GTC";
            this.btn_GTC.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btn_GTC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_GTC_ItemClick);
            // 
            // btn_QDC
            // 
            resources.ApplyResources(this.btn_QDC, "btn_QDC");
            this.btn_QDC.Id = 7;
            this.btn_QDC.LargeGlyph = global::QLThuVien.Properties.Resources.pp;
            this.btn_QDC.Name = "btn_QDC";
            this.btn_QDC.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // ribbon
            // 
            this.ribbon.AutoSizeItems = true;
            this.ribbon.BackColor = System.Drawing.Color.GhostWhite;
            resources.ApplyResources(this.ribbon, "ribbon");
            this.ribbon.ExpandCollapseItem.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btn_TT,
            this.btn_TST,
            this.btn_DG,
            this.btn_GTC,
            this.btn_QDC,
            this.btn_TG,
            this.btn_NXB,
            this.btn_KS,
            this.btn_NCC,
            this.btn_PN,
            this.btn_TTMT,
            this.btn_TK,
            this.btn_TS});
            this.ribbon.MaxItemId = 15;
            this.ribbon.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageTV,
            this.ribbonPageQLS,
            this.ribbonPageMT,
            this.ribbonPageCC});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            // 
            // btn_TTBT
            // 
            this.btn_TTBT.BackColor = System.Drawing.Color.Aquamarine;
            resources.ApplyResources(this.btn_TTBT, "btn_TTBT");
            this.btn_TTBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_TTBT.Image = global::QLThuVien.Properties.Resources.report_docgia;
            this.btn_TTBT.Name = "btn_TTBT";
            this.btn_TTBT.UseVisualStyleBackColor = false;
            this.btn_TTBT.Click += new System.EventHandler(this.btn_TTBT_Click);
            // 
            // btn_DN
            // 
            this.btn_DN.BackColor = System.Drawing.Color.Aquamarine;
            resources.ApplyResources(this.btn_DN, "btn_DN");
            this.btn_DN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_DN.Image = global::QLThuVien.Properties.Resources.password;
            this.btn_DN.Name = "btn_DN";
            this.btn_DN.UseVisualStyleBackColor = false;
            this.btn_DN.Click += new System.EventHandler(this.btn_DN_Click_1);
            // 
            // btn_DX
            // 
            this.btn_DX.BackColor = System.Drawing.Color.Aquamarine;
            resources.ApplyResources(this.btn_DX, "btn_DX");
            this.btn_DX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_DX.Image = global::QLThuVien.Properties.Resources.exit;
            this.btn_DX.Name = "btn_DX";
            this.btn_DX.UseVisualStyleBackColor = false;
            this.btn_DX.Click += new System.EventHandler(this.btn_DX_Click);
            // 
            // btn_CS
            // 
            resources.ApplyResources(this.btn_CS, "btn_CS");
            this.btn_CS.Enabled = false;
            this.btn_CS.Id = 6;
            this.btn_CS.LargeGlyph = global::QLThuVien.Properties.Resources.theloai;
            this.btn_CS.Name = "btn_CS";
            this.btn_CS.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_CS.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_CS_ItemClick);
            // 
            // frmHome
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.Appearance.Options.UseFont = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_DX);
            this.Controls.Add(this.btn_DN);
            this.Controls.Add(this.btn_TTBT);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.backstageViewControl1);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "frmHome";
            this.Ribbon = this.ribbon;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmHome_FormClosed);
            this.Load += new System.EventHandler(this.frmHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.backstageViewControl1)).EndInit();
            this.backstageViewControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraBars.Ribbon.BackstageViewControl backstageViewControl1;
        private DevExpress.XtraBars.Ribbon.BackstageViewClientControl backstageViewClientControl1;
        private DevExpress.XtraBars.Ribbon.BackstageViewTabItem backstageViewTabItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageCC;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        public DevExpress.XtraBars.BarButtonItem btn_NCC;
        public DevExpress.XtraBars.BarButtonItem btn_PN;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageMT;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageQLS;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        public DevExpress.XtraBars.BarButtonItem btn_TST;
        public DevExpress.XtraBars.BarButtonItem btn_TG;
        public DevExpress.XtraBars.BarButtonItem btn_NXB;
        public DevExpress.XtraBars.BarButtonItem btn_KS;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageTV;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        public DevExpress.XtraBars.BarButtonItem btn_TT;
        public DevExpress.XtraBars.BarButtonItem btn_DG;
        private DevExpress.XtraBars.BarButtonItem btn_GTC;
        public DevExpress.XtraBars.BarButtonItem btn_QDC;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        public DevExpress.XtraBars.BarButtonItem btn_TTMT;
        public DevExpress.XtraBars.BarButtonItem btn_TK;
        public DevExpress.XtraBars.BarButtonItem btn_TS;
        public System.Windows.Forms.Button btn_TTBT;
        public System.Windows.Forms.Button btn_DN;
        public System.Windows.Forms.Button btn_DX;
        public DevExpress.XtraBars.BarButtonItem btn_CS;
    }
}