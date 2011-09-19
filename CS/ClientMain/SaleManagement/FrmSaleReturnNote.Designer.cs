namespace ClientMain
{
    partial class FrmSaleReturnNote
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
            this.btnMasterQuery = new DevExpress.XtraBars.BarButtonItem();
            this.btnDetailQuery = new DevExpress.XtraBars.BarButtonItem();
            this.btnConfirm = new DevExpress.XtraBars.BarButtonItem();
            this.btnSummarize = new DevExpress.XtraBars.BarButtonItem();
            this.btnVoucher = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.btnPrintGrid = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrintDetail = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.btnExportGrid = new DevExpress.XtraBars.BarButtonItem();
            this.btnExportDetail = new DevExpress.XtraBars.BarButtonItem();
            this.btnShowError = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem5 = new DevExpress.XtraBars.BarSubItem();
            this.btnColCustomize = new DevExpress.XtraBars.BarButtonItem();
            this.btnSaveLayout = new DevExpress.XtraBars.BarButtonItem();
            this.btnLoadLayout = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.unitOfWork1 = new DevExpress.Xpo.UnitOfWork();
            this.xpServerCollectionSource1 = new DevExpress.Xpo.XPServerCollectionSource();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTATUSMC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXTDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZDRQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCZYID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCZRQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPZS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXTSL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXTSY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXTMY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZZSL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZZSY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZZMY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYSSL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYSSY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYSMY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKHMC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXSBMMC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWLMC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZTMC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJSFSMC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXSHZDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFHPZH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCZYXM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXSHZRQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFHPZRQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFHPZID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXTDID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXSHZDID = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpServerCollectionSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
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
            this.btnDetailQuery,
            this.btnConfirm,
            this.btnSummarize,
            this.btnVoucher,
            this.barSubItem1,
            this.barSubItem2,
            this.btnShowError,
            this.btnPrintGrid,
            this.btnPrintDetail,
            this.btnExportGrid,
            this.btnExportDetail,
            this.barSubItem5,
            this.btnColCustomize,
            this.btnSaveLayout,
            this.btnLoadLayout,
            this.btnMasterQuery});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 22;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnMasterQuery),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDetailQuery),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnConfirm),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSummarize),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnVoucher),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnShowError),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem5)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnMasterQuery
            // 
            this.btnMasterQuery.Caption = "主单查询";
            this.btnMasterQuery.Id = 21;
            this.btnMasterQuery.Name = "btnMasterQuery";
            this.btnMasterQuery.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMasterQuery_ItemClick);
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
            this.btnPrintGrid.Id = 9;
            this.btnPrintGrid.Name = "btnPrintGrid";
            this.btnPrintGrid.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrintGrid_ItemClick);
            // 
            // btnPrintDetail
            // 
            this.btnPrintDetail.Caption = "打印明细";
            this.btnPrintDetail.Id = 10;
            this.btnPrintDetail.Name = "btnPrintDetail";
            this.btnPrintDetail.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrintDetail_ItemClick);
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "导出";
            this.barSubItem2.Id = 6;
            this.barSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExportGrid),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExportDetail)});
            this.barSubItem2.Name = "barSubItem2";
            // 
            // btnExportGrid
            // 
            this.btnExportGrid.Caption = "导出表格";
            this.btnExportGrid.Id = 11;
            this.btnExportGrid.Name = "btnExportGrid";
            this.btnExportGrid.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExportGrid_ItemClick);
            // 
            // btnExportDetail
            // 
            this.btnExportDetail.Caption = "导出明细";
            this.btnExportDetail.Id = 12;
            this.btnExportDetail.Name = "btnExportDetail";
            this.btnExportDetail.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExportDetail_ItemClick);
            // 
            // btnShowError
            // 
            this.btnShowError.Caption = "显示差错";
            this.btnShowError.Id = 7;
            this.btnShowError.Name = "btnShowError";
            this.btnShowError.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnShowError_ItemClick);
            // 
            // barSubItem5
            // 
            this.barSubItem5.Caption = "视图";
            this.barSubItem5.Id = 17;
            this.barSubItem5.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnColCustomize),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSaveLayout),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLoadLayout)});
            this.barSubItem5.Name = "barSubItem5";
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
            this.btnSaveLayout.Id = 19;
            this.btnSaveLayout.Name = "btnSaveLayout";
            this.btnSaveLayout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaveLayout_ItemClick);
            // 
            // btnLoadLayout
            // 
            this.btnLoadLayout.Caption = "载入视图";
            this.btnLoadLayout.Id = 20;
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
            this.barDockControlTop.Size = new System.Drawing.Size(614, 53);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 239);
            this.barDockControlBottom.Size = new System.Drawing.Size(614, 23);
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
            this.barDockControlRight.Location = new System.Drawing.Point(614, 53);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 186);
            // 
            // xpServerCollectionSource1
            // 
            this.xpServerCollectionSource1.ObjectType = typeof(XINHUA.VIEW_JT_X_XTD);
            this.xpServerCollectionSource1.Session = this.unitOfWork1;
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
            this.gridControl1.Size = new System.Drawing.Size(614, 186);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTATUSMC,
            this.colXTDH,
            this.colZDRQ,
            this.colCZYID,
            this.colCZRQ,
            this.colYDH,
            this.colPZS,
            this.colXTSL,
            this.colXTSY,
            this.colXTMY,
            this.colZZSL,
            this.colZZSY,
            this.colZZMY,
            this.colYSSL,
            this.colYSSY,
            this.colYSMY,
            this.colKHMC,
            this.colXSBMMC,
            this.colWLMC,
            this.colZTMC,
            this.colJSFSMC,
            this.colXSHZDH,
            this.colFHPZH,
            this.colCZYXM,
            this.colZT,
            this.colBZ,
            this.colXSHZRQ,
            this.colFHPZRQ,
            this.colSL,
            this.colFHPZID,
            this.colXTDID,
            this.colXSHZDID});
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
            // colXTDH
            // 
            this.colXTDH.Caption = "销退单号";
            this.colXTDH.FieldName = "XTDH";
            this.colXTDH.Name = "colXTDH";
            this.colXTDH.Visible = true;
            this.colXTDH.VisibleIndex = 1;
            // 
            // colZDRQ
            // 
            this.colZDRQ.Caption = "制单日期";
            this.colZDRQ.FieldName = "ZDRQ";
            this.colZDRQ.Name = "colZDRQ";
            this.colZDRQ.Visible = true;
            this.colZDRQ.VisibleIndex = 2;
            // 
            // colCZYID
            // 
            this.colCZYID.Caption = "操作员ID";
            this.colCZYID.FieldName = "CZYID";
            this.colCZYID.Name = "colCZYID";
            this.colCZYID.OptionsFilter.AllowFilter = false;
            // 
            // colCZRQ
            // 
            this.colCZRQ.Caption = "操作日期";
            this.colCZRQ.FieldName = "CZRQ";
            this.colCZRQ.Name = "colCZRQ";
            this.colCZRQ.Visible = true;
            this.colCZRQ.VisibleIndex = 3;
            // 
            // colYDH
            // 
            this.colYDH.Caption = "运单号";
            this.colYDH.FieldName = "YDH";
            this.colYDH.Name = "colYDH";
            this.colYDH.Visible = true;
            this.colYDH.VisibleIndex = 4;
            // 
            // colPZS
            // 
            this.colPZS.Caption = "品种数";
            this.colPZS.FieldName = "PZS";
            this.colPZS.Name = "colPZS";
            this.colPZS.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colPZS.Visible = true;
            this.colPZS.VisibleIndex = 5;
            // 
            // colXTSL
            // 
            this.colXTSL.Caption = "销退数量";
            this.colXTSL.FieldName = "XTSL";
            this.colXTSL.Name = "colXTSL";
            this.colXTSL.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colXTSL.Visible = true;
            this.colXTSL.VisibleIndex = 6;
            // 
            // colXTSY
            // 
            this.colXTSY.Caption = "销退实洋";
            this.colXTSY.FieldName = "XTSY";
            this.colXTSY.Name = "colXTSY";
            this.colXTSY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colXTSY.Visible = true;
            this.colXTSY.VisibleIndex = 7;
            // 
            // colXTMY
            // 
            this.colXTMY.Caption = "销退码洋";
            this.colXTMY.FieldName = "XTMY";
            this.colXTMY.Name = "colXTMY";
            this.colXTMY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colXTMY.Visible = true;
            this.colXTMY.VisibleIndex = 8;
            // 
            // colZZSL
            // 
            this.colZZSL.Caption = "做账数量";
            this.colZZSL.FieldName = "ZZSL";
            this.colZZSL.Name = "colZZSL";
            this.colZZSL.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colZZSL.Visible = true;
            this.colZZSL.VisibleIndex = 9;
            // 
            // colZZSY
            // 
            this.colZZSY.Caption = "做账实洋";
            this.colZZSY.FieldName = "ZZSY";
            this.colZZSY.Name = "colZZSY";
            this.colZZSY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colZZSY.Visible = true;
            this.colZZSY.VisibleIndex = 10;
            // 
            // colZZMY
            // 
            this.colZZMY.Caption = "做账码洋";
            this.colZZMY.FieldName = "ZZMY";
            this.colZZMY.Name = "colZZMY";
            this.colZZMY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colZZMY.Visible = true;
            this.colZZMY.VisibleIndex = 11;
            // 
            // colYSSL
            // 
            this.colYSSL.Caption = "已收数量";
            this.colYSSL.FieldName = "YSSL";
            this.colYSSL.Name = "colYSSL";
            this.colYSSL.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colYSSL.Visible = true;
            this.colYSSL.VisibleIndex = 12;
            // 
            // colYSSY
            // 
            this.colYSSY.Caption = "已收实洋";
            this.colYSSY.FieldName = "YSSY";
            this.colYSSY.Name = "colYSSY";
            this.colYSSY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colYSSY.Visible = true;
            this.colYSSY.VisibleIndex = 13;
            // 
            // colYSMY
            // 
            this.colYSMY.Caption = "已收码洋";
            this.colYSMY.FieldName = "YSMY";
            this.colYSMY.Name = "colYSMY";
            this.colYSMY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colYSMY.Visible = true;
            this.colYSMY.VisibleIndex = 14;
            // 
            // colKHMC
            // 
            this.colKHMC.Caption = "客户名称";
            this.colKHMC.FieldName = "KHMC";
            this.colKHMC.Name = "colKHMC";
            this.colKHMC.Visible = true;
            this.colKHMC.VisibleIndex = 15;
            // 
            // colXSBMMC
            // 
            this.colXSBMMC.Caption = "销售部门";
            this.colXSBMMC.FieldName = "XSBMMC";
            this.colXSBMMC.Name = "colXSBMMC";
            this.colXSBMMC.Visible = true;
            this.colXSBMMC.VisibleIndex = 16;
            // 
            // colWLMC
            // 
            this.colWLMC.Caption = "物流名称";
            this.colWLMC.FieldName = "WLMC";
            this.colWLMC.Name = "colWLMC";
            this.colWLMC.Visible = true;
            this.colWLMC.VisibleIndex = 17;
            // 
            // colZTMC
            // 
            this.colZTMC.Caption = "账套";
            this.colZTMC.FieldName = "ZTMC";
            this.colZTMC.Name = "colZTMC";
            this.colZTMC.Visible = true;
            this.colZTMC.VisibleIndex = 18;
            // 
            // colJSFSMC
            // 
            this.colJSFSMC.Caption = "结算方式";
            this.colJSFSMC.FieldName = "JSFSMC";
            this.colJSFSMC.Name = "colJSFSMC";
            this.colJSFSMC.Visible = true;
            this.colJSFSMC.VisibleIndex = 19;
            // 
            // colXSHZDH
            // 
            this.colXSHZDH.Caption = "销售汇总单号";
            this.colXSHZDH.FieldName = "XSHZDH";
            this.colXSHZDH.Name = "colXSHZDH";
            this.colXSHZDH.Visible = true;
            this.colXSHZDH.VisibleIndex = 20;
            // 
            // colFHPZH
            // 
            this.colFHPZH.Caption = "发货凭证号";
            this.colFHPZH.FieldName = "FHPZH";
            this.colFHPZH.Name = "colFHPZH";
            this.colFHPZH.Visible = true;
            this.colFHPZH.VisibleIndex = 21;
            // 
            // colCZYXM
            // 
            this.colCZYXM.Caption = "操作员";
            this.colCZYXM.FieldName = "CZYXM";
            this.colCZYXM.Name = "colCZYXM";
            this.colCZYXM.Visible = true;
            this.colCZYXM.VisibleIndex = 22;
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
            this.colBZ.VisibleIndex = 23;
            // 
            // colXSHZRQ
            // 
            this.colXSHZRQ.Caption = "汇总日期";
            this.colXSHZRQ.FieldName = "XSHZRQ";
            this.colXSHZRQ.Name = "colXSHZRQ";
            this.colXSHZRQ.Visible = true;
            this.colXSHZRQ.VisibleIndex = 24;
            // 
            // colFHPZRQ
            // 
            this.colFHPZRQ.Caption = "凭证日期";
            this.colFHPZRQ.FieldName = "FHPZRQ";
            this.colFHPZRQ.Name = "colFHPZRQ";
            this.colFHPZRQ.Visible = true;
            this.colFHPZRQ.VisibleIndex = 25;
            // 
            // colSL
            // 
            this.colSL.Caption = "税率";
            this.colSL.FieldName = "SL";
            this.colSL.Name = "colSL";
            this.colSL.Visible = true;
            this.colSL.VisibleIndex = 26;
            // 
            // colFHPZID
            // 
            this.colFHPZID.Caption = "发货凭证ID";
            this.colFHPZID.FieldName = "FHPZID";
            this.colFHPZID.Name = "colFHPZID";
            this.colFHPZID.OptionsFilter.AllowFilter = false;
            // 
            // colXTDID
            // 
            this.colXTDID.Caption = "销退单ID";
            this.colXTDID.FieldName = "XTDID";
            this.colXTDID.Name = "colXTDID";
            this.colXTDID.OptionsFilter.AllowFilter = false;
            // 
            // colXSHZDID
            // 
            this.colXSHZDID.Caption = "销售汇总ID";
            this.colXSHZDID.FieldName = "XSHZDID";
            this.colXSHZDID.Name = "colXSHZDID";
            this.colXSHZDID.OptionsFilter.AllowFilter = false;
            // 
            // FrmSaleReturnNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 262);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmSaleReturnNote";
            this.Text = "销退单列表";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpServerCollectionSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
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
        private DevExpress.Xpo.UnitOfWork unitOfWork1;
        private DevExpress.Xpo.XPServerCollectionSource xpServerCollectionSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colSTATUSMC;
        private DevExpress.XtraGrid.Columns.GridColumn colXTDH;
        private DevExpress.XtraGrid.Columns.GridColumn colZDRQ;
        private DevExpress.XtraGrid.Columns.GridColumn colCZYID;
        private DevExpress.XtraGrid.Columns.GridColumn colCZRQ;
        private DevExpress.XtraGrid.Columns.GridColumn colYDH;
        private DevExpress.XtraGrid.Columns.GridColumn colPZS;
        private DevExpress.XtraGrid.Columns.GridColumn colXTSL;
        private DevExpress.XtraGrid.Columns.GridColumn colXTSY;
        private DevExpress.XtraGrid.Columns.GridColumn colXTMY;
        private DevExpress.XtraGrid.Columns.GridColumn colZZSL;
        private DevExpress.XtraGrid.Columns.GridColumn colZZSY;
        private DevExpress.XtraGrid.Columns.GridColumn colZZMY;
        private DevExpress.XtraGrid.Columns.GridColumn colYSSL;
        private DevExpress.XtraGrid.Columns.GridColumn colYSSY;
        private DevExpress.XtraGrid.Columns.GridColumn colYSMY;
        private DevExpress.XtraGrid.Columns.GridColumn colKHMC;
        private DevExpress.XtraGrid.Columns.GridColumn colXSBMMC;
        private DevExpress.XtraGrid.Columns.GridColumn colWLMC;
        private DevExpress.XtraGrid.Columns.GridColumn colZTMC;
        private DevExpress.XtraGrid.Columns.GridColumn colJSFSMC;
        private DevExpress.XtraGrid.Columns.GridColumn colXSHZDH;
        private DevExpress.XtraGrid.Columns.GridColumn colFHPZH;
        private DevExpress.XtraGrid.Columns.GridColumn colCZYXM;
        private DevExpress.XtraGrid.Columns.GridColumn colZT;
        private DevExpress.XtraGrid.Columns.GridColumn colBZ;
        private DevExpress.XtraGrid.Columns.GridColumn colXSHZRQ;
        private DevExpress.XtraGrid.Columns.GridColumn colFHPZRQ;
        private DevExpress.XtraBars.BarButtonItem btnDetailQuery;
        private DevExpress.XtraBars.BarButtonItem btnConfirm;
        private DevExpress.XtraBars.BarButtonItem btnSummarize;
        private DevExpress.XtraBars.BarButtonItem btnVoucher;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarButtonItem btnShowError;     
        private DevExpress.XtraGrid.Columns.GridColumn colSL;
        private DevExpress.XtraGrid.Columns.GridColumn colFHPZID;
        private DevExpress.XtraGrid.Columns.GridColumn colXTDID;
        private DevExpress.XtraGrid.Columns.GridColumn colXSHZDID;
        private DevExpress.XtraBars.BarButtonItem btnPrintGrid;
        private DevExpress.XtraBars.BarButtonItem btnPrintDetail;
        private DevExpress.XtraBars.BarButtonItem btnExportGrid;
        private DevExpress.XtraBars.BarButtonItem btnExportDetail;
        private DevExpress.XtraBars.BarSubItem barSubItem5;
        private DevExpress.XtraBars.BarButtonItem btnColCustomize;
        private DevExpress.XtraBars.BarButtonItem btnSaveLayout;
        private DevExpress.XtraBars.BarButtonItem btnLoadLayout;
        private DevExpress.XtraBars.BarButtonItem btnMasterQuery;
       
    }
}