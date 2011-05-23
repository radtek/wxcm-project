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
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.btnPreview = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrint = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.btnExport2XLSX = new DevExpress.XtraBars.BarButtonItem();
            this.btnExport2XLS = new DevExpress.XtraBars.BarButtonItem();
            this.btnExport2PDF = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.btnColCustomize = new DevExpress.XtraBars.BarButtonItem();
            this.btnSaveLayout = new DevExpress.XtraBars.BarButtonItem();
            this.btnLoadLayout = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCGSHDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYSDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCGBMID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGYSID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHRID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHRQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHBMID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCZYID = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.colZT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHPZID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHHZRQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHHZDID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHPZRQ = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.xpServerCollectionSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // xpServerCollectionSource1
            // 
            this.xpServerCollectionSource1.ObjectType = typeof(XINHUA.JT_G_CGSH_TEST);
            this.xpServerCollectionSource1.Session = this.unitOfWork1;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
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
            this.barButtonItem5,
            this.barButtonItem6,
            this.barButtonItem7,
            this.barButtonItem8,
            this.btnPreview,
            this.btnPrint,
            this.barSubItem1,
            this.barButtonItem11,
            this.barSubItem2,
            this.btnExport2PDF,
            this.btnExport2XLSX,
            this.btnExport2XLS,
            this.btnSaveLayout,
            this.btnLoadLayout,
            this.btnColCustomize});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 19;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem5),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem6),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem7),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem8),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPreview),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPrint),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem11),
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
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "审核";
            this.barButtonItem5.Id = 4;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "汇总";
            this.barButtonItem6.Id = 5;
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "收货凭证";
            this.barButtonItem7.Id = 6;
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "更正";
            this.barButtonItem8.Id = 7;
            this.barButtonItem8.Name = "barButtonItem8";
            // 
            // btnPreview
            // 
            this.btnPreview.Caption = "预览";
            this.btnPreview.Id = 8;
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPreview_ItemClick);
            // 
            // btnPrint
            // 
            this.btnPrint.Caption = "打印";
            this.btnPrint.Id = 9;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrint_ItemClick);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "导出";
            this.barSubItem1.Id = 10;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExport2XLSX),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExport2XLS),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExport2PDF)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // btnExport2XLSX
            // 
            this.btnExport2XLSX.Caption = "成XLSX";
            this.btnExport2XLSX.Id = 14;
            this.btnExport2XLSX.Name = "btnExport2XLSX";
            this.btnExport2XLSX.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExport2XLSX_ItemClick);
            // 
            // btnExport2XLS
            // 
            this.btnExport2XLS.Caption = "成XLS";
            this.btnExport2XLS.Id = 15;
            this.btnExport2XLS.Name = "btnExport2XLS";
            this.btnExport2XLS.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExport2XLS_ItemClick);
            // 
            // btnExport2PDF
            // 
            this.btnExport2PDF.Caption = "成PDF";
            this.btnExport2PDF.Id = 13;
            this.btnExport2PDF.Name = "btnExport2PDF";
            this.btnExport2PDF.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExport2PDF_ItemClick);
            // 
            // barButtonItem11
            // 
            this.barButtonItem11.Caption = "显示差错";
            this.barButtonItem11.Id = 11;
            this.barButtonItem11.Name = "barButtonItem11";
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
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(895, 24);
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
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 215);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(895, 24);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 215);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.xpServerCollectionSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 24);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(895, 215);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCGSHDH,
            this.colYSDH,
            this.colZTID,
            this.colCGBMID,
            this.colGYSID,
            this.colSHRID,
            this.colSHRQ,
            this.colSHBMID,
            this.colCZYID,
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
            this.colZT,
            this.colBZ,
            this.colSHPZID,
            this.colSHHZRQ,
            this.colSHHZDID,
            this.colSHPZRQ});
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
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colCGSHDH
            // 
            this.colCGSHDH.Caption = "收货单号";
            this.colCGSHDH.FieldName = "CGSHDH";
            this.colCGSHDH.Name = "colCGSHDH";
            this.colCGSHDH.Visible = true;
            this.colCGSHDH.VisibleIndex = 0;
            // 
            // colYSDH
            // 
            this.colYSDH.Caption = "原始单号";
            this.colYSDH.FieldName = "YSDH";
            this.colYSDH.Name = "colYSDH";
            this.colYSDH.Visible = true;
            this.colYSDH.VisibleIndex = 1;
            // 
            // colZTID
            // 
            this.colZTID.Caption = "账套";
            this.colZTID.FieldName = "ZTID";
            this.colZTID.Name = "colZTID";
            this.colZTID.Visible = true;
            this.colZTID.VisibleIndex = 2;
            // 
            // colCGBMID
            // 
            this.colCGBMID.Caption = "采购部门";
            this.colCGBMID.FieldName = "CGBMID";
            this.colCGBMID.Name = "colCGBMID";
            this.colCGBMID.Visible = true;
            this.colCGBMID.VisibleIndex = 3;
            // 
            // colGYSID
            // 
            this.colGYSID.Caption = "供应商";
            this.colGYSID.FieldName = "GYSID";
            this.colGYSID.Name = "colGYSID";
            this.colGYSID.Visible = true;
            this.colGYSID.VisibleIndex = 4;
            // 
            // colSHRID
            // 
            this.colSHRID.Caption = "审核人";
            this.colSHRID.FieldName = "SHRID";
            this.colSHRID.Name = "colSHRID";
            this.colSHRID.Visible = true;
            this.colSHRID.VisibleIndex = 5;
            // 
            // colSHRQ
            // 
            this.colSHRQ.Caption = "审核日期";
            this.colSHRQ.FieldName = "SHRQ";
            this.colSHRQ.Name = "colSHRQ";
            this.colSHRQ.Visible = true;
            this.colSHRQ.VisibleIndex = 6;
            // 
            // colSHBMID
            // 
            this.colSHBMID.Caption = "收货部门";
            this.colSHBMID.FieldName = "SHBMID";
            this.colSHBMID.Name = "colSHBMID";
            this.colSHBMID.Visible = true;
            this.colSHBMID.VisibleIndex = 7;
            // 
            // colCZYID
            // 
            this.colCZYID.Caption = "操作员";
            this.colCZYID.FieldName = "CZYID";
            this.colCZYID.Name = "colCZYID";
            this.colCZYID.Visible = true;
            this.colCZYID.VisibleIndex = 8;
            // 
            // colZDRQ
            // 
            this.colZDRQ.Caption = "制单日期";
            this.colZDRQ.FieldName = "ZDRQ";
            this.colZDRQ.Name = "colZDRQ";
            this.colZDRQ.Visible = true;
            this.colZDRQ.VisibleIndex = 9;
            // 
            // colYDZPZ
            // 
            this.colYDZPZ.Caption = "原单总品种数";
            this.colYDZPZ.FieldName = "YDZPZ";
            this.colYDZPZ.Name = "colYDZPZ";
            this.colYDZPZ.Visible = true;
            this.colYDZPZ.VisibleIndex = 10;
            // 
            // colYDZSL
            // 
            this.colYDZSL.Caption = "原单总数量";
            this.colYDZSL.FieldName = "YDZSL";
            this.colYDZSL.Name = "colYDZSL";
            this.colYDZSL.Visible = true;
            this.colYDZSL.VisibleIndex = 11;
            // 
            // colYDZSY
            // 
            this.colYDZSY.Caption = "原单总实洋";
            this.colYDZSY.FieldName = "YDZSY";
            this.colYDZSY.Name = "colYDZSY";
            this.colYDZSY.Visible = true;
            this.colYDZSY.VisibleIndex = 12;
            // 
            // colYDZMY
            // 
            this.colYDZMY.Caption = "原单总码洋";
            this.colYDZMY.FieldName = "YDZMY";
            this.colYDZMY.Name = "colYDZMY";
            this.colYDZMY.Visible = true;
            this.colYDZMY.VisibleIndex = 13;
            // 
            // colSSZPZ
            // 
            this.colSSZPZ.Caption = "实收总品种";
            this.colSSZPZ.FieldName = "SSZPZ";
            this.colSSZPZ.Name = "colSSZPZ";
            this.colSSZPZ.Visible = true;
            this.colSSZPZ.VisibleIndex = 14;
            // 
            // colSSZSL
            // 
            this.colSSZSL.Caption = "实收总数量";
            this.colSSZSL.FieldName = "SSZSL";
            this.colSSZSL.Name = "colSSZSL";
            this.colSSZSL.Visible = true;
            this.colSSZSL.VisibleIndex = 15;
            // 
            // colSSZSY
            // 
            this.colSSZSY.Caption = "实收总实洋";
            this.colSSZSY.FieldName = "SSZSY";
            this.colSSZSY.Name = "colSSZSY";
            this.colSSZSY.Visible = true;
            this.colSSZSY.VisibleIndex = 16;
            // 
            // colSSZMY
            // 
            this.colSSZMY.Caption = "实收总码洋";
            this.colSSZMY.FieldName = "SSZMY";
            this.colSSZMY.Name = "colSSZMY";
            this.colSSZMY.Visible = true;
            this.colSSZMY.VisibleIndex = 17;
            // 
            // colZPZSL
            // 
            this.colZPZSL.Caption = "赠品总数量";
            this.colZPZSL.FieldName = "ZPZSL";
            this.colZPZSL.Name = "colZPZSL";
            this.colZPZSL.Visible = true;
            this.colZPZSL.VisibleIndex = 18;
            // 
            // colZPZSY
            // 
            this.colZPZSY.Caption = "赠品总实洋";
            this.colZPZSY.FieldName = "ZPZSY";
            this.colZPZSY.Name = "colZPZSY";
            this.colZPZSY.Visible = true;
            this.colZPZSY.VisibleIndex = 19;
            // 
            // colZPZMY
            // 
            this.colZPZMY.Caption = "赠品总码洋";
            this.colZPZMY.FieldName = "ZPZMY";
            this.colZPZMY.Name = "colZPZMY";
            this.colZPZMY.Visible = true;
            this.colZPZMY.VisibleIndex = 20;
            // 
            // colZZSL
            // 
            this.colZZSL.Caption = "做账数量";
            this.colZZSL.FieldName = "ZZSL";
            this.colZZSL.Name = "colZZSL";
            this.colZZSL.Visible = true;
            this.colZZSL.VisibleIndex = 21;
            // 
            // colZZSY
            // 
            this.colZZSY.Caption = "做账实洋";
            this.colZZSY.FieldName = "ZZSY";
            this.colZZSY.Name = "colZZSY";
            this.colZZSY.Visible = true;
            this.colZZSY.VisibleIndex = 22;
            // 
            // colZZMY
            // 
            this.colZZMY.Caption = "做账码洋";
            this.colZZMY.FieldName = "ZZMY";
            this.colZZMY.Name = "colZZMY";
            this.colZZMY.Visible = true;
            this.colZZMY.VisibleIndex = 23;
            // 
            // colYFSL
            // 
            this.colYFSL.Caption = "已付数量";
            this.colYFSL.FieldName = "YFSL";
            this.colYFSL.Name = "colYFSL";
            this.colYFSL.Visible = true;
            this.colYFSL.VisibleIndex = 24;
            // 
            // colYFMY
            // 
            this.colYFMY.Caption = "已付码洋";
            this.colYFMY.FieldName = "YFMY";
            this.colYFMY.Name = "colYFMY";
            this.colYFMY.Visible = true;
            this.colYFMY.VisibleIndex = 25;
            // 
            // colYFSY
            // 
            this.colYFSY.Caption = "已付实洋";
            this.colYFSY.FieldName = "YFSY";
            this.colYFSY.Name = "colYFSY";
            this.colYFSY.Visible = true;
            this.colYFSY.VisibleIndex = 26;
            // 
            // colZT
            // 
            this.colZT.Caption = "状态";
            this.colZT.FieldName = "ZT";
            this.colZT.Name = "colZT";
            this.colZT.Visible = true;
            this.colZT.VisibleIndex = 27;
            // 
            // colBZ
            // 
            this.colBZ.Caption = "备注";
            this.colBZ.FieldName = "BZ";
            this.colBZ.Name = "colBZ";
            this.colBZ.Visible = true;
            this.colBZ.VisibleIndex = 28;
            // 
            // colSHPZID
            // 
            this.colSHPZID.Caption = "收货凭证号";
            this.colSHPZID.FieldName = "SHPZID";
            this.colSHPZID.Name = "colSHPZID";
            this.colSHPZID.Visible = true;
            this.colSHPZID.VisibleIndex = 29;
            // 
            // colSHHZRQ
            // 
            this.colSHHZRQ.Caption = "收货汇总日期";
            this.colSHHZRQ.FieldName = "SHHZRQ";
            this.colSHHZRQ.Name = "colSHHZRQ";
            this.colSHHZRQ.Visible = true;
            this.colSHHZRQ.VisibleIndex = 30;
            // 
            // colSHHZDID
            // 
            this.colSHHZDID.Caption = "收货汇总单号";
            this.colSHHZDID.FieldName = "SHHZDID";
            this.colSHHZDID.Name = "colSHHZDID";
            this.colSHHZDID.Visible = true;
            this.colSHHZDID.VisibleIndex = 31;
            // 
            // colSHPZRQ
            // 
            this.colSHPZRQ.Caption = "凭证日期";
            this.colSHPZRQ.FieldName = "SHPZRQ";
            this.colSHPZRQ.Name = "colSHPZRQ";
            this.colSHPZRQ.Visible = true;
            this.colSHPZRQ.VisibleIndex = 32;
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
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem btnPreview;
        private DevExpress.XtraBars.BarButtonItem btnPrint;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem btnExport2PDF;
        private DevExpress.XtraBars.BarButtonItem btnExport2XLSX;
        private DevExpress.XtraBars.BarButtonItem btnExport2XLS;
        private DevExpress.XtraBars.BarButtonItem barButtonItem11;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarButtonItem btnSaveLayout;
        private DevExpress.XtraBars.BarButtonItem btnLoadLayout;
        private DevExpress.XtraGrid.Columns.GridColumn colCGSHDH;
        private DevExpress.XtraGrid.Columns.GridColumn colYSDH;
        private DevExpress.XtraGrid.Columns.GridColumn colZTID;
        private DevExpress.XtraGrid.Columns.GridColumn colCGBMID;
        private DevExpress.XtraGrid.Columns.GridColumn colGYSID;
        private DevExpress.XtraGrid.Columns.GridColumn colSHRID;
        private DevExpress.XtraGrid.Columns.GridColumn colSHRQ;
        private DevExpress.XtraGrid.Columns.GridColumn colSHBMID;
        private DevExpress.XtraGrid.Columns.GridColumn colCZYID;
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
        private DevExpress.XtraGrid.Columns.GridColumn colZT;
        private DevExpress.XtraGrid.Columns.GridColumn colBZ;
        private DevExpress.XtraGrid.Columns.GridColumn colSHPZID;
        private DevExpress.XtraGrid.Columns.GridColumn colSHHZRQ;
        private DevExpress.XtraGrid.Columns.GridColumn colSHHZDID;
        private DevExpress.XtraGrid.Columns.GridColumn colSHPZRQ;
        private DevExpress.Xpo.UnitOfWork unitOfWork1;
        private DevExpress.XtraBars.BarButtonItem btnColCustomize;
    }
}