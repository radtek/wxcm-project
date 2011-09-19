namespace ClientMain
{
    partial class FrmClientAccountDetail
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
            this.btnDetailQuery = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrintGrid = new DevExpress.XtraBars.BarButtonItem();
            this.btnExportGrid = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
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
            this.colPM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJZRQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDJ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJJ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQCKC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQCMY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQCSY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJTSL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJTMY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJTSY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQMKC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQMMY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQMSY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTHCS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYJSL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYJSY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYJMY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZZSL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZZSY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZZMY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKTSL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSYSL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSYSY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSYMY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJHSL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJHMY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJHSY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXSSL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXSMY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXSSY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTHQX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSFTZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZTBMKHSPTZID = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.btnDetailQuery,
            this.btnPrintGrid,
            this.btnExportGrid,
            this.barSubItem1,
            this.btnColCustomize,
            this.btnSaveLayout,
            this.btnLoadLayout});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDetailQuery),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPrintGrid),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExportGrid),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnDetailQuery
            // 
            this.btnDetailQuery.Caption = "明细查询";
            this.btnDetailQuery.Id = 0;
            this.btnDetailQuery.Name = "btnDetailQuery";
            this.btnDetailQuery.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDetailQuery_ItemClick);
            // 
            // btnPrintGrid
            // 
            this.btnPrintGrid.Caption = "打印表格";
            this.btnPrintGrid.Id = 1;
            this.btnPrintGrid.Name = "btnPrintGrid";
            this.btnPrintGrid.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrintGrid_ItemClick);
            // 
            // btnExportGrid
            // 
            this.btnExportGrid.Caption = "导出表格";
            this.btnExportGrid.Id = 2;
            this.btnExportGrid.Name = "btnExportGrid";
            this.btnExportGrid.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExportGrid_ItemClick);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "视图";
            this.barSubItem1.Id = 3;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnColCustomize),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSaveLayout),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLoadLayout)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // btnColCustomize
            // 
            this.btnColCustomize.Caption = "列定制";
            this.btnColCustomize.Id = 4;
            this.btnColCustomize.Name = "btnColCustomize";
            this.btnColCustomize.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnColCustomize_ItemClick);
            // 
            // btnSaveLayout
            // 
            this.btnSaveLayout.Caption = "保存视图";
            this.btnSaveLayout.Id = 5;
            this.btnSaveLayout.Name = "btnSaveLayout";
            this.btnSaveLayout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaveLayout_ItemClick);
            // 
            // btnLoadLayout
            // 
            this.btnLoadLayout.Caption = "载入视图";
            this.btnLoadLayout.Id = 6;
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
            this.barDockControlTop.Size = new System.Drawing.Size(552, 53);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 239);
            this.barDockControlBottom.Size = new System.Drawing.Size(552, 23);
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
            this.barDockControlRight.Location = new System.Drawing.Point(552, 53);
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
            this.gridControl1.Size = new System.Drawing.Size(552, 186);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // xpServerCollectionSource1
            // 
            this.xpServerCollectionSource1.ObjectType = typeof(XINHUA.VIEW_JT_C_ZTBMKHSPMX);
            this.xpServerCollectionSource1.Session = this.unitOfWork1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPM,
            this.colJZRQ,
            this.colDJ,
            this.colJJ,
            this.colJZ,
            this.colQCKC,
            this.colQCMY,
            this.colQCSY,
            this.colJTSL,
            this.colJTMY,
            this.colJTSY,
            this.colQMKC,
            this.colQMMY,
            this.colQMSY,
            this.colTHCS,
            this.colYJSL,
            this.colYJSY,
            this.colYJMY,
            this.colZZSL,
            this.colZZSY,
            this.colZZMY,
            this.colKTSL,
            this.colSYSL,
            this.colSYSY,
            this.colSYMY,
            this.colJHSL,
            this.colJHMY,
            this.colJHSY,
            this.colXSSL,
            this.colXSMY,
            this.colXSSY,
            this.colTHQX,
            this.colSFTZ,
            this.colZTBMKHSPTZID});
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
            // colPM
            // 
            this.colPM.Caption = "品名";
            this.colPM.FieldName = "PM";
            this.colPM.Name = "colPM";
            this.colPM.SummaryItem.DisplayFormat = "总计：";
            this.colPM.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Custom;
            this.colPM.Visible = true;
            this.colPM.VisibleIndex = 0;
            // 
            // colJZRQ
            // 
            this.colJZRQ.Caption = "建账日期";
            this.colJZRQ.FieldName = "JZRQ";
            this.colJZRQ.Name = "colJZRQ";
            this.colJZRQ.Visible = true;
            this.colJZRQ.VisibleIndex = 1;
            // 
            // colDJ
            // 
            this.colDJ.Caption = "定价";
            this.colDJ.FieldName = "DJ";
            this.colDJ.Name = "colDJ";
            this.colDJ.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colDJ.Visible = true;
            this.colDJ.VisibleIndex = 2;
            // 
            // colJJ
            // 
            this.colJJ.Caption = "进价";
            this.colJJ.FieldName = "JJ";
            this.colJJ.Name = "colJJ";
            this.colJJ.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colJJ.Visible = true;
            this.colJJ.VisibleIndex = 3;
            // 
            // colJZ
            // 
            this.colJZ.Caption = "进折";
            this.colJZ.FieldName = "JZ";
            this.colJZ.Name = "colJZ";
            this.colJZ.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colJZ.Visible = true;
            this.colJZ.VisibleIndex = 4;
            // 
            // colQCKC
            // 
            this.colQCKC.Caption = "期初库存";
            this.colQCKC.FieldName = "QCKC";
            this.colQCKC.Name = "colQCKC";
            this.colQCKC.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colQCKC.Visible = true;
            this.colQCKC.VisibleIndex = 5;
            // 
            // colQCMY
            // 
            this.colQCMY.Caption = "期初码洋";
            this.colQCMY.FieldName = "QCMY";
            this.colQCMY.Name = "colQCMY";
            this.colQCMY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colQCMY.Visible = true;
            this.colQCMY.VisibleIndex = 6;
            // 
            // colQCSY
            // 
            this.colQCSY.Caption = "期初实洋";
            this.colQCSY.FieldName = "QCSY";
            this.colQCSY.Name = "colQCSY";
            this.colQCSY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colQCSY.Visible = true;
            this.colQCSY.VisibleIndex = 7;
            // 
            // colJTSL
            // 
            this.colJTSL.Caption = "进退数量";
            this.colJTSL.FieldName = "JTSL";
            this.colJTSL.Name = "colJTSL";
            this.colJTSL.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colJTSL.Visible = true;
            this.colJTSL.VisibleIndex = 32;
            // 
            // colJTMY
            // 
            this.colJTMY.Caption = "进退码洋";
            this.colJTMY.FieldName = "JTMY";
            this.colJTMY.Name = "colJTMY";
            this.colJTMY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colJTMY.Visible = true;
            this.colJTMY.VisibleIndex = 8;
            // 
            // colJTSY
            // 
            this.colJTSY.Caption = "进退实洋";
            this.colJTSY.FieldName = "JTSY";
            this.colJTSY.Name = "colJTSY";
            this.colJTSY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colJTSY.Visible = true;
            this.colJTSY.VisibleIndex = 9;
            // 
            // colQMKC
            // 
            this.colQMKC.Caption = "期末库存";
            this.colQMKC.FieldName = "QMKC";
            this.colQMKC.Name = "colQMKC";
            this.colQMKC.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colQMKC.Visible = true;
            this.colQMKC.VisibleIndex = 10;
            // 
            // colQMMY
            // 
            this.colQMMY.Caption = "期末码洋";
            this.colQMMY.FieldName = "QMMY";
            this.colQMMY.Name = "colQMMY";
            this.colQMMY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colQMMY.Visible = true;
            this.colQMMY.VisibleIndex = 11;
            // 
            // colQMSY
            // 
            this.colQMSY.Caption = "期末实洋";
            this.colQMSY.FieldName = "QMSY";
            this.colQMSY.Name = "colQMSY";
            this.colQMSY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colQMSY.Visible = true;
            this.colQMSY.VisibleIndex = 12;
            // 
            // colTHCS
            // 
            this.colTHCS.Caption = "退货次数";
            this.colTHCS.FieldName = "THCS";
            this.colTHCS.Name = "colTHCS";
            this.colTHCS.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colTHCS.Visible = true;
            this.colTHCS.VisibleIndex = 13;
            // 
            // colYJSL
            // 
            this.colYJSL.Caption = "已结数量";
            this.colYJSL.FieldName = "YJSL";
            this.colYJSL.Name = "colYJSL";
            this.colYJSL.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colYJSL.Visible = true;
            this.colYJSL.VisibleIndex = 14;
            // 
            // colYJSY
            // 
            this.colYJSY.Caption = "已结实洋";
            this.colYJSY.FieldName = "YJSY";
            this.colYJSY.Name = "colYJSY";
            this.colYJSY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colYJSY.Visible = true;
            this.colYJSY.VisibleIndex = 15;
            // 
            // colYJMY
            // 
            this.colYJMY.Caption = "已结码洋";
            this.colYJMY.FieldName = "YJMY";
            this.colYJMY.Name = "colYJMY";
            this.colYJMY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colYJMY.Visible = true;
            this.colYJMY.VisibleIndex = 16;
            // 
            // colZZSL
            // 
            this.colZZSL.Caption = "做账数量";
            this.colZZSL.FieldName = "ZZSL";
            this.colZZSL.Name = "colZZSL";
            this.colZZSL.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colZZSL.Visible = true;
            this.colZZSL.VisibleIndex = 17;
            // 
            // colZZSY
            // 
            this.colZZSY.Caption = "做账实洋";
            this.colZZSY.FieldName = "ZZSY";
            this.colZZSY.Name = "colZZSY";
            this.colZZSY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colZZSY.Visible = true;
            this.colZZSY.VisibleIndex = 18;
            // 
            // colZZMY
            // 
            this.colZZMY.Caption = "做账码洋";
            this.colZZMY.FieldName = "ZZMY";
            this.colZZMY.Name = "colZZMY";
            this.colZZMY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colZZMY.Visible = true;
            this.colZZMY.VisibleIndex = 19;
            // 
            // colKTSL
            // 
            this.colKTSL.Caption = "可退数量";
            this.colKTSL.FieldName = "KTSL";
            this.colKTSL.Name = "colKTSL";
            this.colKTSL.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colKTSL.Visible = true;
            this.colKTSL.VisibleIndex = 20;
            // 
            // colSYSL
            // 
            this.colSYSL.Caption = "损益数量";
            this.colSYSL.FieldName = "SYSL";
            this.colSYSL.Name = "colSYSL";
            this.colSYSL.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colSYSL.Visible = true;
            this.colSYSL.VisibleIndex = 21;
            // 
            // colSYSY
            // 
            this.colSYSY.Caption = "损益实洋";
            this.colSYSY.FieldName = "SYSY";
            this.colSYSY.Name = "colSYSY";
            this.colSYSY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colSYSY.Visible = true;
            this.colSYSY.VisibleIndex = 22;
            // 
            // colSYMY
            // 
            this.colSYMY.Caption = "损益码洋";
            this.colSYMY.FieldName = "SYMY";
            this.colSYMY.Name = "colSYMY";
            this.colSYMY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colSYMY.Visible = true;
            this.colSYMY.VisibleIndex = 23;
            // 
            // colJHSL
            // 
            this.colJHSL.Caption = "进货数量";
            this.colJHSL.FieldName = "JHSL";
            this.colJHSL.Name = "colJHSL";
            this.colJHSL.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colJHSL.Visible = true;
            this.colJHSL.VisibleIndex = 24;
            // 
            // colJHMY
            // 
            this.colJHMY.Caption = "进货码洋";
            this.colJHMY.FieldName = "JHMY";
            this.colJHMY.Name = "colJHMY";
            this.colJHMY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colJHMY.Visible = true;
            this.colJHMY.VisibleIndex = 25;
            // 
            // colJHSY
            // 
            this.colJHSY.Caption = "进货实洋";
            this.colJHSY.FieldName = "JHSY";
            this.colJHSY.Name = "colJHSY";
            this.colJHSY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colJHSY.Visible = true;
            this.colJHSY.VisibleIndex = 26;
            // 
            // colXSSL
            // 
            this.colXSSL.Caption = "销售数量";
            this.colXSSL.FieldName = "XSSL";
            this.colXSSL.Name = "colXSSL";
            this.colXSSL.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colXSSL.Visible = true;
            this.colXSSL.VisibleIndex = 27;
            // 
            // colXSMY
            // 
            this.colXSMY.Caption = "销售码洋";
            this.colXSMY.FieldName = "XSMY";
            this.colXSMY.Name = "colXSMY";
            this.colXSMY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colXSMY.Visible = true;
            this.colXSMY.VisibleIndex = 28;
            // 
            // colXSSY
            // 
            this.colXSSY.Caption = "销售实洋";
            this.colXSSY.FieldName = "XSSY";
            this.colXSSY.Name = "colXSSY";
            this.colXSSY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colXSSY.Visible = true;
            this.colXSSY.VisibleIndex = 29;
            // 
            // colTHQX
            // 
            this.colTHQX.Caption = "退货期限";
            this.colTHQX.FieldName = "THQX";
            this.colTHQX.Name = "colTHQX";
            this.colTHQX.Visible = true;
            this.colTHQX.VisibleIndex = 30;
            // 
            // colSFTZ
            // 
            this.colSFTZ.Caption = "是否调整";
            this.colSFTZ.FieldName = "SFTZ";
            this.colSFTZ.Name = "colSFTZ";
            this.colSFTZ.Visible = true;
            this.colSFTZ.VisibleIndex = 31;
            // 
            // colZTBMKHSPTZID
            // 
            this.colZTBMKHSPTZID.Caption = "客户台账ID";
            this.colZTBMKHSPTZID.FieldName = "ZTBMKHSPTZID";
            this.colZTBMKHSPTZID.Name = "colZTBMKHSPTZID";
            this.colZTBMKHSPTZID.OptionsFilter.AllowFilter = false;
            // 
            // FrmClientAccountDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 262);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmClientAccountDetail";
            this.Text = "客户商品台账明细";
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
        private DevExpress.XtraBars.BarButtonItem btnDetailQuery;
        private DevExpress.XtraBars.BarButtonItem btnPrintGrid;
        private DevExpress.XtraBars.BarButtonItem btnExportGrid;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem btnColCustomize;
        private DevExpress.XtraBars.BarButtonItem btnSaveLayout;
        private DevExpress.XtraBars.BarButtonItem btnLoadLayout;
        private DevExpress.XtraGrid.Columns.GridColumn colPM;
        private DevExpress.XtraGrid.Columns.GridColumn colJTMY;
        private DevExpress.XtraGrid.Columns.GridColumn colJTSY;
        private DevExpress.XtraGrid.Columns.GridColumn colQMKC;
        private DevExpress.XtraGrid.Columns.GridColumn colQMMY;
        private DevExpress.XtraGrid.Columns.GridColumn colQMSY;
        private DevExpress.XtraGrid.Columns.GridColumn colJZRQ;
        private DevExpress.XtraGrid.Columns.GridColumn colTHCS;
        private DevExpress.XtraGrid.Columns.GridColumn colYJSL;
        private DevExpress.XtraGrid.Columns.GridColumn colYJSY;
        private DevExpress.XtraGrid.Columns.GridColumn colYJMY;
        private DevExpress.XtraGrid.Columns.GridColumn colZZSL;
        private DevExpress.XtraGrid.Columns.GridColumn colZZSY;
        private DevExpress.XtraGrid.Columns.GridColumn colZZMY;
        private DevExpress.XtraGrid.Columns.GridColumn colKTSL;
        private DevExpress.XtraGrid.Columns.GridColumn colTHQX;
        private DevExpress.XtraGrid.Columns.GridColumn colSFTZ;
        private DevExpress.XtraGrid.Columns.GridColumn colSYSL;
        private DevExpress.XtraGrid.Columns.GridColumn colSYSY;
        private DevExpress.XtraGrid.Columns.GridColumn colSYMY;
        private DevExpress.XtraGrid.Columns.GridColumn colZTBMKHSPTZID;
        private DevExpress.XtraGrid.Columns.GridColumn colDJ;
        private DevExpress.XtraGrid.Columns.GridColumn colJZ;
        private DevExpress.XtraGrid.Columns.GridColumn colJJ;
        private DevExpress.XtraGrid.Columns.GridColumn colQCKC;
        private DevExpress.XtraGrid.Columns.GridColumn colQCMY;
        private DevExpress.XtraGrid.Columns.GridColumn colQCSY;
        private DevExpress.XtraGrid.Columns.GridColumn colJHSL;
        private DevExpress.XtraGrid.Columns.GridColumn colJHMY;
        private DevExpress.XtraGrid.Columns.GridColumn colJHSY;
        private DevExpress.XtraGrid.Columns.GridColumn colXSSL;
        private DevExpress.XtraGrid.Columns.GridColumn colXSMY;
        private DevExpress.XtraGrid.Columns.GridColumn colXSSY;
        private DevExpress.XtraGrid.Columns.GridColumn colJTSL;
    }
}