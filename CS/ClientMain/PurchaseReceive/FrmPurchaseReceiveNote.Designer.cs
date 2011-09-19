namespace ClientMain
{
    partial class FrmPurchaseReceiveNote
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
            this.components = new System.ComponentModel.Container();
            this.xpServerCollectionSource1 = new DevExpress.Xpo.XPServerCollectionSource();
            this.unitOfWork1 = new DevExpress.Xpo.UnitOfWork();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnMasterQuery = new DevExpress.XtraBars.BarButtonItem();
            this.btnDetailQuery = new DevExpress.XtraBars.BarButtonItem();
            this.btnConfirm = new DevExpress.XtraBars.BarButtonItem();
            this.btnSummarize = new DevExpress.XtraBars.BarButtonItem();
            this.btnVoucher = new DevExpress.XtraBars.BarButtonItem();
            this.btnCorrection = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem3 = new DevExpress.XtraBars.BarSubItem();
            this.btnPrintGrid = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrintDetailNote = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.btnExportGrid = new DevExpress.XtraBars.BarButtonItem();
            this.btnExportDetailNote = new DevExpress.XtraBars.BarButtonItem();
            this.btnShowErrNote = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.btnColCustomize = new DevExpress.XtraBars.BarButtonItem();
            this.btnSaveLayout = new DevExpress.XtraBars.BarButtonItem();
            this.btnLoadLayout = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCGSHDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTATUSMC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYSDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGYSMC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCGBMMC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHBMMC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHRQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZDRQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYDZPZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYDZSL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYDZSY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYDZMY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSSZPZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSSZSL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSSZSY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSSZMY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZPZSL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZPZSY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZPZMY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZZSL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZZSY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZZMY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYFSL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYFMY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYFSY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHHZRQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHPZRQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZTMC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHHZDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHRXM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCZYXM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCGSHID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHPZDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHRID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCZYID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGYSID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHHZDID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHPZID = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.xpServerCollectionSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // xpServerCollectionSource1
            // 
            this.xpServerCollectionSource1.ObjectType = typeof(XINHUA.VIEW_JT_G_CGSH);
            this.xpServerCollectionSource1.Session = this.unitOfWork1;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3,
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.btnMasterQuery,
            this.btnDetailQuery,
            this.btnConfirm,
            this.btnSummarize,
            this.btnVoucher,
            this.btnCorrection,
            this.barSubItem1,
            this.btnShowErrNote,
            this.barSubItem2,
            this.btnExportGrid,
            this.btnExportDetailNote,
            this.btnSaveLayout,
            this.btnLoadLayout,
            this.btnColCustomize,
            this.barStaticItem1,
            this.barSubItem3,
            this.btnPrintGrid,
            this.btnPrintDetailNote});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 23;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnMasterQuery),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDetailQuery),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnConfirm),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSummarize),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnVoucher),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCorrection),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnShowErrNote),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem2)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnMasterQuery
            // 
            this.btnMasterQuery.Caption = "主单查询";
            this.btnMasterQuery.Id = 1;
            this.btnMasterQuery.Name = "btnMasterQuery";
            this.btnMasterQuery.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMasterQuery_ItemClick);
            // 
            // btnDetailQuery
            // 
            this.btnDetailQuery.Caption = "明细查询";
            this.btnDetailQuery.Id = 2;
            this.btnDetailQuery.Name = "btnDetailQuery";
            this.btnDetailQuery.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDetailQuery_ItemClick);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Caption = "确认";
            this.btnConfirm.Id = 3;
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnConfirm_ItemClick);
            // 
            // btnSummarize
            // 
            this.btnSummarize.Caption = "汇总";
            this.btnSummarize.Id = 5;
            this.btnSummarize.Name = "btnSummarize";
            this.btnSummarize.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSummarize_ItemClick);
            // 
            // btnVoucher
            // 
            this.btnVoucher.Caption = "收货凭证";
            this.btnVoucher.Id = 6;
            this.btnVoucher.Name = "btnVoucher";
            this.btnVoucher.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnVoucher_ItemClick);
            // 
            // btnCorrection
            // 
            this.btnCorrection.Caption = "更正";
            this.btnCorrection.Id = 7;
            this.btnCorrection.Name = "btnCorrection";
            this.btnCorrection.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCorrection_ItemClick);
            // 
            // barSubItem3
            // 
            this.barSubItem3.Caption = "打印";
            this.barSubItem3.Id = 20;
            this.barSubItem3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPrintGrid),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPrintDetailNote)});
            this.barSubItem3.Name = "barSubItem3";
            // 
            // btnPrintGrid
            // 
            this.btnPrintGrid.Caption = "打印表格";
            this.btnPrintGrid.Id = 21;
            this.btnPrintGrid.Name = "btnPrintGrid";
            this.btnPrintGrid.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrintGrid_ItemClick);
            // 
            // btnPrintDetailNote
            // 
            this.btnPrintDetailNote.Caption = "打印明细";
            this.btnPrintDetailNote.Id = 22;
            this.btnPrintDetailNote.Name = "btnPrintDetailNote";
            this.btnPrintDetailNote.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrintDetailNote_ItemClick);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "导出";
            this.barSubItem1.Id = 10;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExportGrid),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExportDetailNote)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // btnExportGrid
            // 
            this.btnExportGrid.Caption = "导出表格";
            this.btnExportGrid.Id = 14;
            this.btnExportGrid.Name = "btnExportGrid";
            this.btnExportGrid.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExportGrid_ItemClick);
            // 
            // btnExportDetailNote
            // 
            this.btnExportDetailNote.Caption = "导出明细";
            this.btnExportDetailNote.Id = 15;
            this.btnExportDetailNote.Name = "btnExportDetailNote";
            this.btnExportDetailNote.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExportDetailNote_ItemClick);
            // 
            // btnShowErrNote
            // 
            this.btnShowErrNote.Caption = "显示差错";
            this.btnShowErrNote.Id = 11;
            this.btnShowErrNote.Name = "btnShowErrNote";
            this.btnShowErrNote.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnShowErrNote_ItemClick);
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "视图";
            this.barSubItem2.Id = 12;
            this.barSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnColCustomize),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSaveLayout),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLoadLayout)});
            this.barSubItem2.Name = "barSubItem2";
            // 
            // btnColCustomize
            // 
            this.btnColCustomize.Caption = "列定制";
            this.btnColCustomize.Id = 18;
            this.btnColCustomize.Name = "btnColCustomize";
            this.btnColCustomize.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnColCustomize_ItemClick);
            // 
            // btnSaveLayout
            // 
            this.btnSaveLayout.Caption = "保存视图";
            this.btnSaveLayout.Id = 16;
            this.btnSaveLayout.Name = "btnSaveLayout";
            this.btnSaveLayout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaveLayout_ItemClick);
            // 
            // btnLoadLayout
            // 
            this.btnLoadLayout.Caption = "载入视图";
            this.btnLoadLayout.Id = 17;
            this.btnLoadLayout.Name = "btnLoadLayout";
            this.btnLoadLayout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLoadLayout_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 4";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Custom 4";
            this.bar1.Visible = false;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(895, 53);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 239);
            this.barDockControlBottom.Size = new System.Drawing.Size(895, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 53);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 186);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(895, 53);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 186);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "barStaticItem1";
            this.barStaticItem1.Id = 19;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.xpServerCollectionSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Buttons.Append.Enabled = false;
            this.gridControl1.EmbeddedNavigator.Buttons.CancelEdit.Enabled = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Edit.Enabled = false;
            this.gridControl1.EmbeddedNavigator.Buttons.EndEdit.Enabled = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Remove.Enabled = false;
            this.gridControl1.Location = new System.Drawing.Point(0, 53);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(895, 186);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCGSHDH,
            this.colSTATUSMC,
            this.colYSDH,
            this.colGYSMC,
            this.colCGBMMC,
            this.colSHBMMC,
            this.colSHRQ,
            this.colZDRQ,
            this.colYDZPZ,
            this.colYDZSL,
            this.colYDZSY,
            this.colYDZMY,
            this.colSSZPZ,
            this.colSSZSL,
            this.colSSZSY,
            this.colSSZMY,
            this.colZPZSL,
            this.colZPZSY,
            this.colZPZMY,
            this.colZZSL,
            this.colZZSY,
            this.colZZMY,
            this.colYFSL,
            this.colYFMY,
            this.colYFSY,
            this.colBZ,
            this.colSHHZRQ,
            this.colSHPZRQ,
            this.colZTMC,
            this.colSHHZDH,
            this.colSHRXM,
            this.colCZYXM,
            this.colZT,
            this.colCGSHID,
            this.colSHPZDH,
            this.colSHRID,
            this.colCZYID,
            this.colGYSID,
            this.colSHHZDID,
            this.colSHPZID});
            this.gridView1.FooterPanelHeight = 50;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.IndicatorWidth = 50;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsPrint.AutoWidth = false;
            this.gridView1.OptionsPrint.PrintSelectedRowsOnly = true;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            this.gridView1.CustomDrawFooterCell += new DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventHandler(this.gridView1_CustomDrawFooterCell);
            this.gridView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gridView1_MouseUp);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colCGSHDH
            // 
            this.colCGSHDH.Caption = "采购收货单号";
            this.colCGSHDH.FieldName = "CGSHDH";
            this.colCGSHDH.Name = "colCGSHDH";
            this.colCGSHDH.Visible = true;
            this.colCGSHDH.VisibleIndex = 1;
            // 
            // colSTATUSMC
            // 
            this.colSTATUSMC.Caption = "状态";
            this.colSTATUSMC.FieldName = "STATUSMC";
            this.colSTATUSMC.Name = "colSTATUSMC";
            this.colSTATUSMC.SummaryItem.DisplayFormat = "总计：";
            this.colSTATUSMC.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Custom;
            this.colSTATUSMC.Visible = true;
            this.colSTATUSMC.VisibleIndex = 0;
            // 
            // colYSDH
            // 
            this.colYSDH.Caption = "原始单号";
            this.colYSDH.FieldName = "YSDH";
            this.colYSDH.Name = "colYSDH";
            this.colYSDH.Visible = true;
            this.colYSDH.VisibleIndex = 5;
            // 
            // colGYSMC
            // 
            this.colGYSMC.Caption = "供应商";
            this.colGYSMC.FieldName = "GYSMC";
            this.colGYSMC.Name = "colGYSMC";
            this.colGYSMC.Visible = true;
            this.colGYSMC.VisibleIndex = 2;
            // 
            // colCGBMMC
            // 
            this.colCGBMMC.Caption = "采购部门";
            this.colCGBMMC.FieldName = "CGBMMC";
            this.colCGBMMC.Name = "colCGBMMC";
            this.colCGBMMC.Visible = true;
            this.colCGBMMC.VisibleIndex = 4;
            // 
            // colSHBMMC
            // 
            this.colSHBMMC.Caption = "收货部门";
            this.colSHBMMC.FieldName = "SHBMMC";
            this.colSHBMMC.Name = "colSHBMMC";
            this.colSHBMMC.Visible = true;
            this.colSHBMMC.VisibleIndex = 3;
            // 
            // colSHRQ
            // 
            this.colSHRQ.Caption = "审核日期";
            this.colSHRQ.FieldName = "SHRQ";
            this.colSHRQ.Name = "colSHRQ";
            this.colSHRQ.Visible = true;
            this.colSHRQ.VisibleIndex = 11;
            // 
            // colZDRQ
            // 
            this.colZDRQ.Caption = "制单日期";
            this.colZDRQ.FieldName = "ZDRQ";
            this.colZDRQ.Name = "colZDRQ";
            this.colZDRQ.Visible = true;
            this.colZDRQ.VisibleIndex = 12;
            // 
            // colYDZPZ
            // 
            this.colYDZPZ.Caption = "原单总品种数";
            this.colYDZPZ.FieldName = "YDZPZ";
            this.colYDZPZ.Name = "colYDZPZ";
            this.colYDZPZ.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colYDZPZ.Visible = true;
            this.colYDZPZ.VisibleIndex = 13;
            // 
            // colYDZSL
            // 
            this.colYDZSL.Caption = "原单总数量";
            this.colYDZSL.FieldName = "YDZSL";
            this.colYDZSL.Name = "colYDZSL";
            this.colYDZSL.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colYDZSL.Visible = true;
            this.colYDZSL.VisibleIndex = 14;
            // 
            // colYDZSY
            // 
            this.colYDZSY.Caption = "原单总实洋";
            this.colYDZSY.FieldName = "YDZSY";
            this.colYDZSY.Name = "colYDZSY";
            this.colYDZSY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colYDZSY.Visible = true;
            this.colYDZSY.VisibleIndex = 15;
            // 
            // colYDZMY
            // 
            this.colYDZMY.Caption = "原单总码洋";
            this.colYDZMY.FieldName = "YDZMY";
            this.colYDZMY.Name = "colYDZMY";
            this.colYDZMY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colYDZMY.Visible = true;
            this.colYDZMY.VisibleIndex = 16;
            // 
            // colSSZPZ
            // 
            this.colSSZPZ.Caption = "实收总品种数";
            this.colSSZPZ.FieldName = "SSZPZ";
            this.colSSZPZ.Name = "colSSZPZ";
            this.colSSZPZ.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colSSZPZ.Visible = true;
            this.colSSZPZ.VisibleIndex = 17;
            // 
            // colSSZSL
            // 
            this.colSSZSL.Caption = "实收总数量";
            this.colSSZSL.FieldName = "SSZSL";
            this.colSSZSL.Name = "colSSZSL";
            this.colSSZSL.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colSSZSL.Visible = true;
            this.colSSZSL.VisibleIndex = 18;
            // 
            // colSSZSY
            // 
            this.colSSZSY.Caption = "实收总实洋";
            this.colSSZSY.FieldName = "SSZSY";
            this.colSSZSY.Name = "colSSZSY";
            this.colSSZSY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colSSZSY.Visible = true;
            this.colSSZSY.VisibleIndex = 19;
            // 
            // colSSZMY
            // 
            this.colSSZMY.Caption = "实收总码洋";
            this.colSSZMY.FieldName = "SSZMY";
            this.colSSZMY.Name = "colSSZMY";
            this.colSSZMY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colSSZMY.Visible = true;
            this.colSSZMY.VisibleIndex = 20;
            // 
            // colZPZSL
            // 
            this.colZPZSL.Caption = "赠品总数量";
            this.colZPZSL.FieldName = "ZPZSL";
            this.colZPZSL.Name = "colZPZSL";
            this.colZPZSL.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colZPZSL.Visible = true;
            this.colZPZSL.VisibleIndex = 21;
            // 
            // colZPZSY
            // 
            this.colZPZSY.Caption = "赠品总实洋";
            this.colZPZSY.FieldName = "ZPZSY";
            this.colZPZSY.Name = "colZPZSY";
            this.colZPZSY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colZPZSY.Visible = true;
            this.colZPZSY.VisibleIndex = 22;
            // 
            // colZPZMY
            // 
            this.colZPZMY.Caption = "赠品总码洋";
            this.colZPZMY.FieldName = "ZPZMY";
            this.colZPZMY.Name = "colZPZMY";
            this.colZPZMY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colZPZMY.Visible = true;
            this.colZPZMY.VisibleIndex = 23;
            // 
            // colZZSL
            // 
            this.colZZSL.Caption = "做账数量";
            this.colZZSL.FieldName = "ZZSL";
            this.colZZSL.Name = "colZZSL";
            this.colZZSL.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colZZSL.Visible = true;
            this.colZZSL.VisibleIndex = 24;
            // 
            // colZZSY
            // 
            this.colZZSY.Caption = "做账实洋";
            this.colZZSY.FieldName = "ZZSY";
            this.colZZSY.Name = "colZZSY";
            this.colZZSY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colZZSY.Visible = true;
            this.colZZSY.VisibleIndex = 25;
            // 
            // colZZMY
            // 
            this.colZZMY.Caption = "做账码洋";
            this.colZZMY.FieldName = "ZZMY";
            this.colZZMY.Name = "colZZMY";
            this.colZZMY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colZZMY.Visible = true;
            this.colZZMY.VisibleIndex = 26;
            // 
            // colYFSL
            // 
            this.colYFSL.Caption = "已付数量";
            this.colYFSL.FieldName = "YFSL";
            this.colYFSL.Name = "colYFSL";
            this.colYFSL.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colYFSL.Visible = true;
            this.colYFSL.VisibleIndex = 27;
            // 
            // colYFMY
            // 
            this.colYFMY.Caption = "已付码洋";
            this.colYFMY.FieldName = "YFMY";
            this.colYFMY.Name = "colYFMY";
            this.colYFMY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colYFMY.Visible = true;
            this.colYFMY.VisibleIndex = 28;
            // 
            // colYFSY
            // 
            this.colYFSY.Caption = "已付实洋";
            this.colYFSY.FieldName = "YFSY";
            this.colYFSY.Name = "colYFSY";
            this.colYFSY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colYFSY.Visible = true;
            this.colYFSY.VisibleIndex = 29;
            // 
            // colBZ
            // 
            this.colBZ.Caption = "备注";
            this.colBZ.FieldName = "BZ";
            this.colBZ.Name = "colBZ";
            this.colBZ.Visible = true;
            this.colBZ.VisibleIndex = 30;
            // 
            // colSHHZRQ
            // 
            this.colSHHZRQ.Caption = "收货汇总日期";
            this.colSHHZRQ.FieldName = "SHHZRQ";
            this.colSHHZRQ.Name = "colSHHZRQ";
            this.colSHHZRQ.Visible = true;
            this.colSHHZRQ.VisibleIndex = 7;
            // 
            // colSHPZRQ
            // 
            this.colSHPZRQ.Caption = "收货凭证日期";
            this.colSHPZRQ.FieldName = "SHPZRQ";
            this.colSHPZRQ.Name = "colSHPZRQ";
            this.colSHPZRQ.Visible = true;
            this.colSHPZRQ.VisibleIndex = 9;
            // 
            // colZTMC
            // 
            this.colZTMC.Caption = "账套";
            this.colZTMC.FieldName = "ZTMC";
            this.colZTMC.Name = "colZTMC";
            this.colZTMC.Visible = true;
            this.colZTMC.VisibleIndex = 31;
            // 
            // colSHHZDH
            // 
            this.colSHHZDH.Caption = "收货汇总单号";
            this.colSHHZDH.FieldName = "SHHZDH";
            this.colSHHZDH.Name = "colSHHZDH";
            this.colSHHZDH.Visible = true;
            this.colSHHZDH.VisibleIndex = 6;
            // 
            // colSHRXM
            // 
            this.colSHRXM.Caption = "审核人";
            this.colSHRXM.FieldName = "SHRXM";
            this.colSHRXM.Name = "colSHRXM";
            this.colSHRXM.Visible = true;
            this.colSHRXM.VisibleIndex = 10;
            // 
            // colCZYXM
            // 
            this.colCZYXM.Caption = "操作员";
            this.colCZYXM.FieldName = "CZYXM";
            this.colCZYXM.Name = "colCZYXM";
            this.colCZYXM.Visible = true;
            this.colCZYXM.VisibleIndex = 32;
            // 
            // colZT
            // 
            this.colZT.Caption = "状态ID";
            this.colZT.FieldName = "ZT";
            this.colZT.Name = "colZT";
            this.colZT.OptionsFilter.AllowFilter = false;
            // 
            // colCGSHID
            // 
            this.colCGSHID.Caption = "采购收货单ID";
            this.colCGSHID.FieldName = "CGSHID";
            this.colCGSHID.Name = "colCGSHID";
            this.colCGSHID.OptionsFilter.AllowFilter = false;
            // 
            // colSHPZDH
            // 
            this.colSHPZDH.Caption = "收货凭证单号";
            this.colSHPZDH.FieldName = "SHPZDH";
            this.colSHPZDH.Name = "colSHPZDH";
            this.colSHPZDH.Visible = true;
            this.colSHPZDH.VisibleIndex = 8;
            // 
            // colSHRID
            // 
            this.colSHRID.Caption = "审核人ID";
            this.colSHRID.FieldName = "SHRID";
            this.colSHRID.Name = "colSHRID";
            this.colSHRID.OptionsFilter.AllowFilter = false;
            // 
            // colCZYID
            // 
            this.colCZYID.Caption = "操作员ID";
            this.colCZYID.FieldName = "CZYID";
            this.colCZYID.Name = "colCZYID";
            this.colCZYID.OptionsFilter.AllowFilter = false;
            // 
            // colGYSID
            // 
            this.colGYSID.Caption = "供应商ID";
            this.colGYSID.FieldName = "GYSID";
            this.colGYSID.Name = "colGYSID";
            this.colGYSID.OptionsFilter.AllowFilter = false;
            // 
            // colSHHZDID
            // 
            this.colSHHZDID.Caption = "收货汇总单ID";
            this.colSHHZDID.FieldName = "SHHZDID";
            this.colSHHZDID.Name = "colSHHZDID";
            this.colSHHZDID.OptionsFilter.AllowFilter = false;
            // 
            // colSHPZID
            // 
            this.colSHPZID.Caption = "收货凭证ID";
            this.colSHPZID.FieldName = "SHPZID";
            this.colSHPZID.Name = "colSHPZID";
            this.colSHPZID.OptionsFilter.AllowFilter = false;
            // 
            // FrmPurchaseReceiveNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 262);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmPurchaseReceiveNote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "采购收货单列表";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPurchaseReceiveNote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xpServerCollectionSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Xpo.XPServerCollectionSource xpServerCollectionSource1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnMasterQuery;
        private DevExpress.XtraBars.BarButtonItem btnDetailQuery;
        private DevExpress.XtraBars.BarButtonItem btnConfirm;
        private DevExpress.XtraBars.BarButtonItem btnSummarize;
        private DevExpress.XtraBars.BarButtonItem btnVoucher;
        private DevExpress.XtraBars.BarButtonItem btnCorrection;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem btnExportGrid;
        private DevExpress.XtraBars.BarButtonItem btnExportDetailNote;
        private DevExpress.XtraBars.BarButtonItem btnShowErrNote;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarButtonItem btnSaveLayout;
        private DevExpress.XtraBars.BarButtonItem btnLoadLayout;
        private DevExpress.Xpo.UnitOfWork unitOfWork1;
        private DevExpress.XtraBars.BarButtonItem btnColCustomize;
        private DevExpress.XtraGrid.Columns.GridColumn colCGSHDH;
        private DevExpress.XtraGrid.Columns.GridColumn colYSDH;
        private DevExpress.XtraGrid.Columns.GridColumn colSHRQ;
        private DevExpress.XtraGrid.Columns.GridColumn colZDRQ;
        private DevExpress.XtraGrid.Columns.GridColumn colYDZPZ;
        private DevExpress.XtraGrid.Columns.GridColumn colYDZSL;
        private DevExpress.XtraGrid.Columns.GridColumn colYDZSY;
        private DevExpress.XtraGrid.Columns.GridColumn colYDZMY;
        private DevExpress.XtraGrid.Columns.GridColumn colSSZPZ;
        private DevExpress.XtraGrid.Columns.GridColumn colSSZSL;
        private DevExpress.XtraGrid.Columns.GridColumn colSSZSY;
        private DevExpress.XtraGrid.Columns.GridColumn colSSZMY;
        private DevExpress.XtraGrid.Columns.GridColumn colZPZSL;
        private DevExpress.XtraGrid.Columns.GridColumn colZPZSY;
        private DevExpress.XtraGrid.Columns.GridColumn colZPZMY;
        private DevExpress.XtraGrid.Columns.GridColumn colZZSL;
        private DevExpress.XtraGrid.Columns.GridColumn colZZSY;
        private DevExpress.XtraGrid.Columns.GridColumn colZZMY;
        private DevExpress.XtraGrid.Columns.GridColumn colYFSL;
        private DevExpress.XtraGrid.Columns.GridColumn colYFMY;
        private DevExpress.XtraGrid.Columns.GridColumn colYFSY;
        private DevExpress.XtraGrid.Columns.GridColumn colBZ;
        private DevExpress.XtraGrid.Columns.GridColumn colSHHZRQ;
        private DevExpress.XtraGrid.Columns.GridColumn colSHPZRQ;
        private DevExpress.XtraGrid.Columns.GridColumn colZTMC;
        private DevExpress.XtraGrid.Columns.GridColumn colGYSMC;
        private DevExpress.XtraGrid.Columns.GridColumn colCGBMMC;
        private DevExpress.XtraGrid.Columns.GridColumn colSHBMMC;
        private DevExpress.XtraGrid.Columns.GridColumn colSTATUSMC;
        private DevExpress.XtraGrid.Columns.GridColumn colSHHZDH;
        private DevExpress.XtraGrid.Columns.GridColumn colSHRXM;
        private DevExpress.XtraGrid.Columns.GridColumn colCZYXM;
        private DevExpress.XtraGrid.Columns.GridColumn colZT;
        private DevExpress.XtraGrid.Columns.GridColumn colCGSHID;
        private DevExpress.XtraGrid.Columns.GridColumn colSHPZDH;
        private DevExpress.XtraGrid.Columns.GridColumn colSHRID;
        private DevExpress.XtraGrid.Columns.GridColumn colCZYID;
        private DevExpress.XtraGrid.Columns.GridColumn colGYSID;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colSHHZDID;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarSubItem barSubItem3;
        private DevExpress.XtraBars.BarButtonItem btnPrintGrid;
        private DevExpress.XtraBars.BarButtonItem btnPrintDetailNote;
        private DevExpress.XtraGrid.Columns.GridColumn colSHPZID;
    }
}