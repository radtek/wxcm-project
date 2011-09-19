namespace ClientMain
{
    partial class FrmPurchaseReturnNote
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
            this.btnShowErrNote = new DevExpress.XtraBars.BarButtonItem();
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
            this.colJTDID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTATUSMC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJTDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGYSMC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJTBMMC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYWYXM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHHZDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHHZRQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHPZDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHPZID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHHZDID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHPZRQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZDRQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFHDWMC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCZRQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCZYXM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJTPZS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJTZSL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJTZMY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJTZSY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYFSL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYFSY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYFMY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZZSL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZZSY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZZMY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZTMC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCZYID = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.btnMasterQuery,
            this.btnDetailQuery,
            this.btnConfirm,
            this.btnSummarize,
            this.btnVoucher,
            this.barSubItem1,
            this.barSubItem2,
            this.btnShowErrNote,
            this.barSubItem3,
            this.btnPrintGrid,
            this.btnPrintDetail,
            this.btnExportGrid,
            this.btnExportDetail,
            this.btnColCustomize,
            this.btnSaveLayout,
            this.btnLoadLayout});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 17;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnShowErrNote),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem3)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnMasterQuery
            // 
            this.btnMasterQuery.Caption = "主单查询";
            this.btnMasterQuery.Id = 0;
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
            this.btnVoucher.Caption = "收货凭证";
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
            this.btnPrintGrid.Id = 10;
            this.btnPrintGrid.Name = "btnPrintGrid";
            this.btnPrintGrid.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrintGrid_ItemClick);
            // 
            // btnPrintDetail
            // 
            this.btnPrintDetail.Caption = "打印明细";
            this.btnPrintDetail.Id = 11;
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
            this.btnExportGrid.Id = 12;
            this.btnExportGrid.Name = "btnExportGrid";
            this.btnExportGrid.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExportGrid_ItemClick);
            // 
            // btnExportDetail
            // 
            this.btnExportDetail.Caption = "导出明细";
            this.btnExportDetail.Id = 13;
            this.btnExportDetail.Name = "btnExportDetail";
            this.btnExportDetail.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExportDetail_ItemClick);
            // 
            // btnShowErrNote
            // 
            this.btnShowErrNote.Caption = "显示差错";
            this.btnShowErrNote.Id = 7;
            this.btnShowErrNote.Name = "btnShowErrNote";
            this.btnShowErrNote.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnShowErrNote_ItemClick);
            // 
            // barSubItem3
            // 
            this.barSubItem3.Caption = "视图";
            this.barSubItem3.Id = 9;
            this.barSubItem3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnColCustomize),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSaveLayout),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLoadLayout)});
            this.barSubItem3.Name = "barSubItem3";
            // 
            // btnColCustomize
            // 
            this.btnColCustomize.Caption = "列定制";
            this.btnColCustomize.Id = 14;
            this.btnColCustomize.Name = "btnColCustomize";
            this.btnColCustomize.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnColCustomize_ItemClick);
            // 
            // btnSaveLayout
            // 
            this.btnSaveLayout.Caption = "保存视图";
            this.btnSaveLayout.Id = 15;
            this.btnSaveLayout.Name = "btnSaveLayout";
            this.btnSaveLayout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaveLayout_ItemClick);
            // 
            // btnLoadLayout
            // 
            this.btnLoadLayout.Caption = "载入视图";
            this.btnLoadLayout.Id = 16;
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
            this.barDockControlTop.Size = new System.Drawing.Size(697, 53);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 239);
            this.barDockControlBottom.Size = new System.Drawing.Size(697, 23);
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
            this.barDockControlRight.Location = new System.Drawing.Point(697, 53);
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
            this.gridControl1.Size = new System.Drawing.Size(697, 186);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // xpServerCollectionSource1
            // 
            this.xpServerCollectionSource1.ObjectType = typeof(XINHUA.VIEW_JT_G_JTD);
            this.xpServerCollectionSource1.Session = this.unitOfWork1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colJTDID,
            this.colSTATUSMC,
            this.colJTDH,
            this.colBZ,
            this.colGYSMC,
            this.colJTBMMC,
            this.colYWYXM,
            this.colSHHZDH,
            this.colSHHZRQ,
            this.colSHPZDH,
            this.colSHPZID,
            this.colSHHZDID,
            this.colSHPZRQ,
            this.colZDRQ,
            this.colFHDWMC,
            this.colCZRQ,
            this.colCZYXM,
            this.colJTPZS,
            this.colJTZSL,
            this.colJTZMY,
            this.colJTZSY,
            this.colYFSL,
            this.colYFSY,
            this.colYFMY,
            this.colZZSL,
            this.colZZSY,
            this.colZZMY,
            this.colZT,
            this.colZTMC,
            this.colCZYID});
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
            // colJTDID
            // 
            this.colJTDID.Caption = "进退单ID";
            this.colJTDID.FieldName = "JTDID";
            this.colJTDID.Name = "colJTDID";
            this.colJTDID.OptionsFilter.AllowFilter = false;
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
            // colJTDH
            // 
            this.colJTDH.Caption = "进退单号";
            this.colJTDH.FieldName = "JTDH";
            this.colJTDH.Name = "colJTDH";
            this.colJTDH.Visible = true;
            this.colJTDH.VisibleIndex = 1;
            // 
            // colBZ
            // 
            this.colBZ.Caption = "备注";
            this.colBZ.FieldName = "BZ";
            this.colBZ.Name = "colBZ";
            this.colBZ.Visible = true;
            this.colBZ.VisibleIndex = 2;
            // 
            // colGYSMC
            // 
            this.colGYSMC.Caption = "供应商名称";
            this.colGYSMC.FieldName = "GYSMC";
            this.colGYSMC.Name = "colGYSMC";
            this.colGYSMC.Visible = true;
            this.colGYSMC.VisibleIndex = 3;
            // 
            // colJTBMMC
            // 
            this.colJTBMMC.Caption = "进退部门名称";
            this.colJTBMMC.FieldName = "JTBMMC";
            this.colJTBMMC.Name = "colJTBMMC";
            this.colJTBMMC.Visible = true;
            this.colJTBMMC.VisibleIndex = 4;
            // 
            // colYWYXM
            // 
            this.colYWYXM.Caption = "业务员";
            this.colYWYXM.FieldName = "YWYXM";
            this.colYWYXM.Name = "colYWYXM";
            this.colYWYXM.Visible = true;
            this.colYWYXM.VisibleIndex = 5;
            // 
            // colSHHZDH
            // 
            this.colSHHZDH.Caption = "收货汇总单号";
            this.colSHHZDH.FieldName = "SHHZDH";
            this.colSHHZDH.Name = "colSHHZDH";
            this.colSHHZDH.Visible = true;
            this.colSHHZDH.VisibleIndex = 6;
            // 
            // colSHHZRQ
            // 
            this.colSHHZRQ.Caption = "收货汇总日期";
            this.colSHHZRQ.FieldName = "SHHZRQ";
            this.colSHHZRQ.Name = "colSHHZRQ";
            this.colSHHZRQ.Visible = true;
            this.colSHHZRQ.VisibleIndex = 7;
            // 
            // colSHPZDH
            // 
            this.colSHPZDH.Caption = "收货凭证单号";
            this.colSHPZDH.FieldName = "SHPZDH";
            this.colSHPZDH.Name = "colSHPZDH";
            this.colSHPZDH.Visible = true;
            this.colSHPZDH.VisibleIndex = 8;
            // 
            // colSHPZID
            // 
            this.colSHPZID.Caption = "收货凭证ID";
            this.colSHPZID.FieldName = "SHPZID";
            this.colSHPZID.Name = "colSHPZID";
            this.colSHPZID.OptionsFilter.AllowFilter = false;
            // 
            // colSHHZDID
            // 
            this.colSHHZDID.Caption = "收货汇总ID";
            this.colSHHZDID.FieldName = "SHHZDID";
            this.colSHHZDID.Name = "colSHHZDID";
            this.colSHHZDID.OptionsFilter.AllowFilter = false;
            // 
            // colSHPZRQ
            // 
            this.colSHPZRQ.Caption = "收货凭证日期";
            this.colSHPZRQ.FieldName = "SHPZRQ";
            this.colSHPZRQ.Name = "colSHPZRQ";
            this.colSHPZRQ.Visible = true;
            this.colSHPZRQ.VisibleIndex = 9;
            // 
            // colZDRQ
            // 
            this.colZDRQ.Caption = "制单日期";
            this.colZDRQ.FieldName = "ZDRQ";
            this.colZDRQ.Name = "colZDRQ";
            this.colZDRQ.Visible = true;
            this.colZDRQ.VisibleIndex = 10;
            // 
            // colFHDWMC
            // 
            this.colFHDWMC.Caption = "发货单位名称";
            this.colFHDWMC.FieldName = "FHDWMC";
            this.colFHDWMC.Name = "colFHDWMC";
            this.colFHDWMC.Visible = true;
            this.colFHDWMC.VisibleIndex = 11;
            // 
            // colCZRQ
            // 
            this.colCZRQ.Caption = "操作日期";
            this.colCZRQ.FieldName = "CZRQ";
            this.colCZRQ.Name = "colCZRQ";
            this.colCZRQ.Visible = true;
            this.colCZRQ.VisibleIndex = 12;
            // 
            // colCZYXM
            // 
            this.colCZYXM.Caption = "操作员";
            this.colCZYXM.FieldName = "CZYXM";
            this.colCZYXM.Name = "colCZYXM";
            this.colCZYXM.Visible = true;
            this.colCZYXM.VisibleIndex = 13;
            // 
            // colJTPZS
            // 
            this.colJTPZS.Caption = "进退品种";
            this.colJTPZS.FieldName = "JTPZS";
            this.colJTPZS.Name = "colJTPZS";
            this.colJTPZS.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colJTPZS.Visible = true;
            this.colJTPZS.VisibleIndex = 14;
            // 
            // colJTZSL
            // 
            this.colJTZSL.Caption = "进退数量";
            this.colJTZSL.FieldName = "JTZSL";
            this.colJTZSL.Name = "colJTZSL";
            this.colJTZSL.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colJTZSL.Visible = true;
            this.colJTZSL.VisibleIndex = 15;
            // 
            // colJTZMY
            // 
            this.colJTZMY.Caption = "进退码洋";
            this.colJTZMY.FieldName = "JTZMY";
            this.colJTZMY.Name = "colJTZMY";
            this.colJTZMY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colJTZMY.Visible = true;
            this.colJTZMY.VisibleIndex = 16;
            // 
            // colJTZSY
            // 
            this.colJTZSY.Caption = "进退实洋";
            this.colJTZSY.FieldName = "JTZSY";
            this.colJTZSY.Name = "colJTZSY";
            this.colJTZSY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colJTZSY.Visible = true;
            this.colJTZSY.VisibleIndex = 17;
            // 
            // colYFSL
            // 
            this.colYFSL.Caption = "已付数量";
            this.colYFSL.FieldName = "YFSL";
            this.colYFSL.Name = "colYFSL";
            this.colYFSL.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colYFSL.Visible = true;
            this.colYFSL.VisibleIndex = 18;
            // 
            // colYFSY
            // 
            this.colYFSY.Caption = "已付实洋";
            this.colYFSY.FieldName = "YFSY";
            this.colYFSY.Name = "colYFSY";
            this.colYFSY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colYFSY.Visible = true;
            this.colYFSY.VisibleIndex = 19;
            // 
            // colYFMY
            // 
            this.colYFMY.Caption = "已付码洋";
            this.colYFMY.FieldName = "YFMY";
            this.colYFMY.Name = "colYFMY";
            this.colYFMY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colYFMY.Visible = true;
            this.colYFMY.VisibleIndex = 20;
            // 
            // colZZSL
            // 
            this.colZZSL.Caption = "做账数量";
            this.colZZSL.FieldName = "ZZSL";
            this.colZZSL.Name = "colZZSL";
            this.colZZSL.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colZZSL.Visible = true;
            this.colZZSL.VisibleIndex = 21;
            // 
            // colZZSY
            // 
            this.colZZSY.Caption = "做账实洋";
            this.colZZSY.FieldName = "ZZSY";
            this.colZZSY.Name = "colZZSY";
            this.colZZSY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colZZSY.Visible = true;
            this.colZZSY.VisibleIndex = 22;
            // 
            // colZZMY
            // 
            this.colZZMY.Caption = "做账码洋";
            this.colZZMY.FieldName = "ZZMY";
            this.colZZMY.Name = "colZZMY";
            this.colZZMY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colZZMY.Visible = true;
            this.colZZMY.VisibleIndex = 23;
            // 
            // colZT
            // 
            this.colZT.Caption = "状态ID";
            this.colZT.FieldName = "ZT";
            this.colZT.Name = "colZT";
            this.colZT.OptionsFilter.AllowFilter = false;
            // 
            // colZTMC
            // 
            this.colZTMC.Caption = "账套名称";
            this.colZTMC.FieldName = "ZTMC";
            this.colZTMC.Name = "colZTMC";
            this.colZTMC.Visible = true;
            this.colZTMC.VisibleIndex = 24;
            // 
            // colCZYID
            // 
            this.colCZYID.Caption = "操作员ID";
            this.colCZYID.FieldName = "CZYID";
            this.colCZYID.Name = "colCZYID";
            this.colCZYID.OptionsFilter.AllowFilter = false;
            // 
            // FrmPurchaseReturnNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 262);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmPurchaseReturnNote";
            this.Text = "进退单列表";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPurchaseReturnNote_Load);
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
        private DevExpress.Xpo.UnitOfWork unitOfWork1;
        private DevExpress.Xpo.XPServerCollectionSource xpServerCollectionSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colJTDID;
        private DevExpress.XtraGrid.Columns.GridColumn colSTATUSMC;
        private DevExpress.XtraGrid.Columns.GridColumn colJTDH;
        private DevExpress.XtraGrid.Columns.GridColumn colBZ;
        private DevExpress.XtraGrid.Columns.GridColumn colGYSMC;
        private DevExpress.XtraGrid.Columns.GridColumn colJTBMMC;
        private DevExpress.XtraGrid.Columns.GridColumn colYWYXM;
        private DevExpress.XtraGrid.Columns.GridColumn colSHHZDH;
        private DevExpress.XtraGrid.Columns.GridColumn colSHHZRQ;
        private DevExpress.XtraGrid.Columns.GridColumn colSHPZDH;
        private DevExpress.XtraGrid.Columns.GridColumn colSHPZID;
        private DevExpress.XtraGrid.Columns.GridColumn colSHHZDID;
        private DevExpress.XtraGrid.Columns.GridColumn colSHPZRQ;
        private DevExpress.XtraGrid.Columns.GridColumn colZDRQ;
        private DevExpress.XtraGrid.Columns.GridColumn colFHDWMC;
        private DevExpress.XtraGrid.Columns.GridColumn colCZRQ;
        private DevExpress.XtraGrid.Columns.GridColumn colCZYXM;
        private DevExpress.XtraGrid.Columns.GridColumn colJTPZS;
        private DevExpress.XtraGrid.Columns.GridColumn colJTZSL;
        private DevExpress.XtraGrid.Columns.GridColumn colJTZMY;
        private DevExpress.XtraGrid.Columns.GridColumn colJTZSY;
        private DevExpress.XtraGrid.Columns.GridColumn colYFSL;
        private DevExpress.XtraGrid.Columns.GridColumn colYFSY;
        private DevExpress.XtraGrid.Columns.GridColumn colYFMY;
        private DevExpress.XtraGrid.Columns.GridColumn colZZSL;
        private DevExpress.XtraGrid.Columns.GridColumn colZZSY;
        private DevExpress.XtraGrid.Columns.GridColumn colZZMY;
        private DevExpress.XtraGrid.Columns.GridColumn colZT;
        private DevExpress.XtraGrid.Columns.GridColumn colZTMC;
        private DevExpress.XtraBars.BarButtonItem btnMasterQuery;
        private DevExpress.XtraBars.BarButtonItem btnDetailQuery;
        private DevExpress.XtraBars.BarButtonItem btnConfirm;
        private DevExpress.XtraBars.BarButtonItem btnSummarize;
        private DevExpress.XtraBars.BarButtonItem btnVoucher;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem btnPrintGrid;
        private DevExpress.XtraBars.BarButtonItem btnPrintDetail;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarButtonItem btnExportGrid;
        private DevExpress.XtraBars.BarButtonItem btnExportDetail;
        private DevExpress.XtraBars.BarButtonItem btnShowErrNote;
        private DevExpress.XtraBars.BarSubItem barSubItem3;
        private DevExpress.XtraBars.BarButtonItem btnColCustomize;
        private DevExpress.XtraBars.BarButtonItem btnSaveLayout;
        private DevExpress.XtraBars.BarButtonItem btnLoadLayout;
        private DevExpress.XtraGrid.Columns.GridColumn colCZYID;
    }
}