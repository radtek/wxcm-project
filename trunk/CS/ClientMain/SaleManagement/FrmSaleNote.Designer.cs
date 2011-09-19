namespace ClientMain
{
    partial class FrmSaleNote
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
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.MasterQuery = new DevExpress.XtraBars.BarButtonItem();
            this.btnDetailQuery = new DevExpress.XtraBars.BarButtonItem();
            this.btnConfirm = new DevExpress.XtraBars.BarButtonItem();
            this.btnSummarize = new DevExpress.XtraBars.BarButtonItem();
            this.btnVoucher = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.btnPrintGrid = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrintDetail = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.btnExportGrid = new DevExpress.XtraBars.BarButtonItem();
            this.btnShowError = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem3 = new DevExpress.XtraBars.BarSubItem();
            this.btnColCustomize = new DevExpress.XtraBars.BarButtonItem();
            this.btnSaveLayout = new DevExpress.XtraBars.BarButtonItem();
            this.btnLoadLayout = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.xpServerCollectionSource1 = new DevExpress.Xpo.XPServerCollectionSource();
            this.unitOfWork1 = new DevExpress.Xpo.UnitOfWork();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colXSDID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTATUSMC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXSDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXSBMMC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWLBMMC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKHMC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZDRQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJSFSMC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXSHZDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFHPZH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCZYID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPZS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXSSL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXSSY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXSMY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZZSL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZZSY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZZMY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYSSL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYSSY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYSMY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFHDZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFHPZID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXSHZDID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZTMC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCZYXM = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpServerCollectionSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.MasterQuery,
            this.btnDetailQuery,
            this.btnConfirm,
            this.btnSummarize,
            this.btnVoucher,
            this.barSubItem1,
            this.btnPrintGrid,
            this.btnPrintDetail,
            this.barSubItem2,
            this.btnExportGrid,
            this.btnShowError,
            this.barSubItem3,
            this.btnColCustomize,
            this.btnSaveLayout,
            this.btnLoadLayout});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 15;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            this.bar1.Visible = false;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.MasterQuery),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDetailQuery),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnConfirm),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSummarize),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnVoucher),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnShowError),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem3)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // MasterQuery
            // 
            this.MasterQuery.Caption = "主单查询";
            this.MasterQuery.Id = 0;
            this.MasterQuery.Name = "MasterQuery";
            this.MasterQuery.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.MasterQuery_ItemClick);
            // 
            // btnDetailQuery
            // 
            this.btnDetailQuery.Caption = "明细查询";
            this.btnDetailQuery.Id = 1;
            this.btnDetailQuery.Name = "btnDetailQuery";
            this.btnDetailQuery.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDetailQuery_ItemClick);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Caption = "确认";
            this.btnConfirm.Id = 2;
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnConfirm_ItemClick);
            // 
            // btnSummarize
            // 
            this.btnSummarize.Caption = "汇总";
            this.btnSummarize.Id = 3;
            this.btnSummarize.Name = "btnSummarize";
            this.btnSummarize.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSummarize_ItemClick);
            // 
            // btnVoucher
            // 
            this.btnVoucher.Caption = "凭证";
            this.btnVoucher.Id = 4;
            this.btnVoucher.Name = "btnVoucher";
            this.btnVoucher.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnVoucher_ItemClick);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "打印";
            this.barSubItem1.Id = 5;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPrintGrid),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPrintDetail)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // btnPrintGrid
            // 
            this.btnPrintGrid.Caption = "打印表格";
            this.btnPrintGrid.Id = 6;
            this.btnPrintGrid.Name = "btnPrintGrid";
            this.btnPrintGrid.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrintGrid_ItemClick);
            // 
            // btnPrintDetail
            // 
            this.btnPrintDetail.Caption = "打印明细";
            this.btnPrintDetail.Id = 7;
            this.btnPrintDetail.Name = "btnPrintDetail";
            this.btnPrintDetail.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrintDetail_ItemClick);
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "导出";
            this.barSubItem2.Id = 8;
            this.barSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExportGrid)});
            this.barSubItem2.Name = "barSubItem2";
            // 
            // btnExportGrid
            // 
            this.btnExportGrid.Caption = "导出表格";
            this.btnExportGrid.Id = 9;
            this.btnExportGrid.Name = "btnExportGrid";
            this.btnExportGrid.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExportGrid_ItemClick);
            // 
            // btnShowError
            // 
            this.btnShowError.Caption = "显示差错";
            this.btnShowError.Id = 10;
            this.btnShowError.Name = "btnShowError";
            this.btnShowError.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnShowError_ItemClick);
            // 
            // barSubItem3
            // 
            this.barSubItem3.Caption = "视图";
            this.barSubItem3.Id = 11;
            this.barSubItem3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnColCustomize),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSaveLayout),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLoadLayout)});
            this.barSubItem3.Name = "barSubItem3";
            // 
            // btnColCustomize
            // 
            this.btnColCustomize.Caption = "列定制";
            this.btnColCustomize.Id = 12;
            this.btnColCustomize.Name = "btnColCustomize";
            this.btnColCustomize.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnColCustomize_ItemClick);
            // 
            // btnSaveLayout
            // 
            this.btnSaveLayout.Caption = "保存视图";
            this.btnSaveLayout.Id = 13;
            this.btnSaveLayout.Name = "btnSaveLayout";
            this.btnSaveLayout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaveLayout_ItemClick);
            // 
            // btnLoadLayout
            // 
            this.btnLoadLayout.Caption = "载入视图";
            this.btnLoadLayout.Id = 14;
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
            this.barDockControlTop.Size = new System.Drawing.Size(913, 53);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 239);
            this.barDockControlBottom.Size = new System.Drawing.Size(913, 23);
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
            this.barDockControlRight.Location = new System.Drawing.Point(913, 53);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 186);
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
            this.gridControl1.Size = new System.Drawing.Size(913, 186);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // xpServerCollectionSource1
            // 
            this.xpServerCollectionSource1.ObjectType = typeof(XINHUA.VIEW_JT_X_XSD);
            this.xpServerCollectionSource1.Session = this.unitOfWork1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colXSDID,
            this.colSTATUSMC,
            this.colXSDH,
            this.colXSBMMC,
            this.colWLBMMC,
            this.colKHMC,
            this.colZDRQ,
            this.colJSFSMC,
            this.colXSHZDH,
            this.colFHPZH,
            this.colCZYID,
            this.colPZS,
            this.colXSSL,
            this.colXSSY,
            this.colXSMY,
            this.colZZSL,
            this.colZZSY,
            this.colZZMY,
            this.colYSSL,
            this.colYSSY,
            this.colYSMY,
            this.colZT,
            this.colBZ,
            this.colFHDZ,
            this.colFHPZID,
            this.colXSHZDID,
            this.colZTMC,
            this.colCZYXM});
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
            // colXSDID
            // 
            this.colXSDID.Caption = "销售单ID";
            this.colXSDID.FieldName = "XSDID";
            this.colXSDID.Name = "colXSDID";
            this.colXSDID.OptionsFilter.AllowFilter = false;
            // 
            // colSTATUSMC
            // 
            this.colSTATUSMC.Caption = "状态";
            this.colSTATUSMC.FieldName = "STATUSMC";
            this.colSTATUSMC.Name = "colSTATUSMC";
            this.colSTATUSMC.SummaryItem.DisplayFormat = "总计:";
            this.colSTATUSMC.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Custom;
            this.colSTATUSMC.Visible = true;
            this.colSTATUSMC.VisibleIndex = 0;
            // 
            // colXSDH
            // 
            this.colXSDH.Caption = "销售单号";
            this.colXSDH.FieldName = "XSDH";
            this.colXSDH.Name = "colXSDH";
            this.colXSDH.Visible = true;
            this.colXSDH.VisibleIndex = 1;
            // 
            // colXSBMMC
            // 
            this.colXSBMMC.Caption = "销售部门";
            this.colXSBMMC.FieldName = "XSBMMC";
            this.colXSBMMC.Name = "colXSBMMC";
            this.colXSBMMC.Visible = true;
            this.colXSBMMC.VisibleIndex = 2;
            // 
            // colWLBMMC
            // 
            this.colWLBMMC.Caption = "物流部门";
            this.colWLBMMC.FieldName = "WLBMMC";
            this.colWLBMMC.Name = "colWLBMMC";
            this.colWLBMMC.Visible = true;
            this.colWLBMMC.VisibleIndex = 3;
            // 
            // colKHMC
            // 
            this.colKHMC.Caption = "客户名称";
            this.colKHMC.FieldName = "KHMC";
            this.colKHMC.Name = "colKHMC";
            this.colKHMC.Visible = true;
            this.colKHMC.VisibleIndex = 4;
            // 
            // colZDRQ
            // 
            this.colZDRQ.Caption = "制单日期";
            this.colZDRQ.FieldName = "ZDRQ";
            this.colZDRQ.Name = "colZDRQ";
            this.colZDRQ.Visible = true;
            this.colZDRQ.VisibleIndex = 5;
            // 
            // colJSFSMC
            // 
            this.colJSFSMC.Caption = "结算方式";
            this.colJSFSMC.FieldName = "JSFSMC";
            this.colJSFSMC.Name = "colJSFSMC";
            this.colJSFSMC.Visible = true;
            this.colJSFSMC.VisibleIndex = 6;
            // 
            // colXSHZDH
            // 
            this.colXSHZDH.Caption = "销售汇总单号";
            this.colXSHZDH.FieldName = "XSHZDH";
            this.colXSHZDH.Name = "colXSHZDH";
            this.colXSHZDH.Visible = true;
            this.colXSHZDH.VisibleIndex = 7;
            // 
            // colFHPZH
            // 
            this.colFHPZH.Caption = "发货凭证号";
            this.colFHPZH.FieldName = "FHPZH";
            this.colFHPZH.Name = "colFHPZH";
            this.colFHPZH.Visible = true;
            this.colFHPZH.VisibleIndex = 8;
            // 
            // colCZYID
            // 
            this.colCZYID.Caption = "操作员ID";
            this.colCZYID.FieldName = "CZYID";
            this.colCZYID.Name = "colCZYID";
            this.colCZYID.OptionsFilter.AllowFilter = false;
            // 
            // colPZS
            // 
            this.colPZS.Caption = "品种数";
            this.colPZS.FieldName = "PZS";
            this.colPZS.Name = "colPZS";
            this.colPZS.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colPZS.Visible = true;
            this.colPZS.VisibleIndex = 9;
            // 
            // colXSSL
            // 
            this.colXSSL.Caption = "销售数量";
            this.colXSSL.FieldName = "XSSL";
            this.colXSSL.Name = "colXSSL";
            this.colXSSL.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colXSSL.Visible = true;
            this.colXSSL.VisibleIndex = 10;
            // 
            // colXSSY
            // 
            this.colXSSY.Caption = "销售实洋";
            this.colXSSY.FieldName = "XSSY";
            this.colXSSY.Name = "colXSSY";
            this.colXSSY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colXSSY.Visible = true;
            this.colXSSY.VisibleIndex = 11;
            // 
            // colXSMY
            // 
            this.colXSMY.Caption = "销售码洋";
            this.colXSMY.FieldName = "XSMY";
            this.colXSMY.Name = "colXSMY";
            this.colXSMY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colXSMY.Visible = true;
            this.colXSMY.VisibleIndex = 12;
            // 
            // colZZSL
            // 
            this.colZZSL.Caption = "做账数量";
            this.colZZSL.FieldName = "ZZSL";
            this.colZZSL.Name = "colZZSL";
            this.colZZSL.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colZZSL.Visible = true;
            this.colZZSL.VisibleIndex = 13;
            // 
            // colZZSY
            // 
            this.colZZSY.Caption = "做账实洋";
            this.colZZSY.FieldName = "ZZSY";
            this.colZZSY.Name = "colZZSY";
            this.colZZSY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colZZSY.Visible = true;
            this.colZZSY.VisibleIndex = 14;
            // 
            // colZZMY
            // 
            this.colZZMY.Caption = "做账码洋";
            this.colZZMY.FieldName = "ZZMY";
            this.colZZMY.Name = "colZZMY";
            this.colZZMY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colZZMY.Visible = true;
            this.colZZMY.VisibleIndex = 15;
            // 
            // colYSSL
            // 
            this.colYSSL.Caption = "已结数量";
            this.colYSSL.FieldName = "YSSL";
            this.colYSSL.Name = "colYSSL";
            this.colYSSL.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colYSSL.Visible = true;
            this.colYSSL.VisibleIndex = 16;
            // 
            // colYSSY
            // 
            this.colYSSY.Caption = "已结实洋";
            this.colYSSY.FieldName = "YSSY";
            this.colYSSY.Name = "colYSSY";
            this.colYSSY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colYSSY.Visible = true;
            this.colYSSY.VisibleIndex = 17;
            // 
            // colYSMY
            // 
            this.colYSMY.Caption = "已结码洋";
            this.colYSMY.FieldName = "YSMY";
            this.colYSMY.Name = "colYSMY";
            this.colYSMY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colYSMY.Visible = true;
            this.colYSMY.VisibleIndex = 18;
            // 
            // colZT
            // 
            this.colZT.Caption = "状态ID";
            this.colZT.FieldName = "ZT";
            this.colZT.Name = "colZT";
            this.colZT.OptionsFilter.AllowFilter = false;
            // 
            // colBZ
            // 
            this.colBZ.Caption = "备注";
            this.colBZ.FieldName = "BZ";
            this.colBZ.Name = "colBZ";
            this.colBZ.Visible = true;
            this.colBZ.VisibleIndex = 19;
            // 
            // colFHDZ
            // 
            this.colFHDZ.Caption = "发货地址";
            this.colFHDZ.FieldName = "FHDZ";
            this.colFHDZ.Name = "colFHDZ";
            this.colFHDZ.Visible = true;
            this.colFHDZ.VisibleIndex = 20;
            // 
            // colFHPZID
            // 
            this.colFHPZID.Caption = "发货凭证ID";
            this.colFHPZID.FieldName = "FHPZID";
            this.colFHPZID.Name = "colFHPZID";
            this.colFHPZID.OptionsFilter.AllowFilter = false;
            // 
            // colXSHZDID
            // 
            this.colXSHZDID.Caption = "销售汇总单ID";
            this.colXSHZDID.FieldName = "XSHZDID";
            this.colXSHZDID.Name = "colXSHZDID";
            this.colXSHZDID.OptionsFilter.AllowFilter = false;
            // 
            // colZTMC
            // 
            this.colZTMC.Caption = "账套名称";
            this.colZTMC.FieldName = "ZTMC";
            this.colZTMC.Name = "colZTMC";
            this.colZTMC.Visible = true;
            this.colZTMC.VisibleIndex = 21;
            // 
            // colCZYXM
            // 
            this.colCZYXM.Caption = "操作员";
            this.colCZYXM.FieldName = "CZYXM";
            this.colCZYXM.Name = "colCZYXM";
            this.colCZYXM.Visible = true;
            this.colCZYXM.VisibleIndex = 22;
            // 
            // FrmSaleNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 262);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmSaleNote";
            this.Text = "销售单列表";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpServerCollectionSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.Xpo.XPServerCollectionSource xpServerCollectionSource1;
        private DevExpress.Xpo.UnitOfWork unitOfWork1;
        private DevExpress.XtraBars.BarButtonItem MasterQuery;
        private DevExpress.XtraBars.BarButtonItem btnDetailQuery;
        private DevExpress.XtraBars.BarButtonItem btnConfirm;
        private DevExpress.XtraBars.BarButtonItem btnSummarize;
        private DevExpress.XtraBars.BarButtonItem btnVoucher;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem btnPrintGrid;
        private DevExpress.XtraBars.BarButtonItem btnPrintDetail;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarButtonItem btnExportGrid;
        private DevExpress.XtraBars.BarButtonItem btnShowError;
        private DevExpress.XtraBars.BarSubItem barSubItem3;
        private DevExpress.XtraBars.BarButtonItem btnColCustomize;
        private DevExpress.XtraBars.BarButtonItem btnSaveLayout;
        private DevExpress.XtraBars.BarButtonItem btnLoadLayout;
        private DevExpress.XtraGrid.Columns.GridColumn colXSDID;
        private DevExpress.XtraGrid.Columns.GridColumn colSTATUSMC;
        private DevExpress.XtraGrid.Columns.GridColumn colXSDH;
        private DevExpress.XtraGrid.Columns.GridColumn colXSBMMC;
        private DevExpress.XtraGrid.Columns.GridColumn colWLBMMC;
        private DevExpress.XtraGrid.Columns.GridColumn colKHMC;
        private DevExpress.XtraGrid.Columns.GridColumn colZDRQ;
        private DevExpress.XtraGrid.Columns.GridColumn colJSFSMC;
        private DevExpress.XtraGrid.Columns.GridColumn colXSHZDH;
        private DevExpress.XtraGrid.Columns.GridColumn colFHPZH;
        private DevExpress.XtraGrid.Columns.GridColumn colCZYID;
        private DevExpress.XtraGrid.Columns.GridColumn colPZS;
        private DevExpress.XtraGrid.Columns.GridColumn colXSSL;
        private DevExpress.XtraGrid.Columns.GridColumn colXSSY;
        private DevExpress.XtraGrid.Columns.GridColumn colXSMY;
        private DevExpress.XtraGrid.Columns.GridColumn colZZSL;
        private DevExpress.XtraGrid.Columns.GridColumn colZZSY;
        private DevExpress.XtraGrid.Columns.GridColumn colZZMY;
        private DevExpress.XtraGrid.Columns.GridColumn colYSSL;
        private DevExpress.XtraGrid.Columns.GridColumn colYSSY;
        private DevExpress.XtraGrid.Columns.GridColumn colYSMY;
        private DevExpress.XtraGrid.Columns.GridColumn colZT;
        private DevExpress.XtraGrid.Columns.GridColumn colBZ;
        private DevExpress.XtraGrid.Columns.GridColumn colFHDZ;
        private DevExpress.XtraGrid.Columns.GridColumn colFHPZID;
        private DevExpress.XtraGrid.Columns.GridColumn colXSHZDID;
        private DevExpress.XtraGrid.Columns.GridColumn colZTMC;
        private DevExpress.XtraGrid.Columns.GridColumn colCZYXM;
    }
}