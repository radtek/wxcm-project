namespace ClientMain
{
    partial class FrmPurchaseReceiveDetail
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
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnDetailQuery = new DevExpress.XtraBars.BarButtonItem();
            this.btnCorrect = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrintGrid = new DevExpress.XtraBars.BarButtonItem();
            this.btnExportGrid = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.btnColCustomize = new DevExpress.XtraBars.BarButtonItem();
            this.btnSaveLayout = new DevExpress.XtraBars.BarButtonItem();
            this.btnLoadLayout = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.xpServerCollectionSource1 = new DevExpress.Xpo.XPServerCollectionSource();
            this.unitOfWork1 = new DevExpress.Xpo.UnitOfWork();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCGSHDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSPBH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZDDM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDJ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJJ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYDSL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYDSY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYDMY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSSSL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSSSY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSSMY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZPSL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZPSY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZPMY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZZSL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZZSY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZZMY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYFSL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYFMY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYFSY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCGSHID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCGSHMXID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xpInstantFeedbackSource1 = new DevExpress.Xpo.XPInstantFeedbackSource();
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
            this.bar2,
            this.bar3,
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnDetailQuery,
            this.btnCorrect,
            this.barSubItem1,
            this.btnColCustomize,
            this.btnSaveLayout,
            this.btnLoadLayout,
            this.btnPrintGrid,
            this.btnExportGrid});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDetailQuery),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCorrect),
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
            // btnCorrect
            // 
            this.btnCorrect.Caption = "更正";
            this.btnCorrect.Id = 1;
            this.btnCorrect.Name = "btnCorrect";
            this.btnCorrect.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCorrect_ItemClick);
            // 
            // btnPrintGrid
            // 
            this.btnPrintGrid.Caption = "打印表格";
            this.btnPrintGrid.Id = 6;
            this.btnPrintGrid.Name = "btnPrintGrid";
            this.btnPrintGrid.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrintGrid_ItemClick);
            // 
            // btnExportGrid
            // 
            this.btnExportGrid.Caption = "导出表格";
            this.btnExportGrid.Id = 7;
            this.btnExportGrid.Name = "btnExportGrid";
            this.btnExportGrid.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExportGrid_ItemClick);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "视图";
            this.barSubItem1.Id = 2;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnColCustomize),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSaveLayout),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLoadLayout)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // btnColCustomize
            // 
            this.btnColCustomize.Caption = "列定制";
            this.btnColCustomize.Id = 3;
            this.btnColCustomize.Name = "btnColCustomize";
            this.btnColCustomize.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnColCustomize_ItemClick);
            // 
            // btnSaveLayout
            // 
            this.btnSaveLayout.Caption = "保存视图";
            this.btnSaveLayout.Id = 4;
            this.btnSaveLayout.Name = "btnSaveLayout";
            this.btnSaveLayout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaveLayout_ItemClick);
            // 
            // btnLoadLayout
            // 
            this.btnLoadLayout.Caption = "载入视图";
            this.btnLoadLayout.Id = 5;
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
            this.barDockControlTop.Size = new System.Drawing.Size(720, 55);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 249);
            this.barDockControlBottom.Size = new System.Drawing.Size(720, 27);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 55);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 194);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(720, 55);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 194);
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
            this.gridControl1.Location = new System.Drawing.Point(0, 55);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(720, 194);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // xpServerCollectionSource1
            // 
            this.xpServerCollectionSource1.ObjectType = typeof(XINHUA.VIEW_JT_G_CGSHMX);
            this.xpServerCollectionSource1.Session = this.unitOfWork1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCGSHDH,
            this.colSPBH,
            this.colPM,
            this.colZDDM,
            this.colDJ,
            this.colJJ,
            this.colJZ,
            this.colYDSL,
            this.colYDSY,
            this.colYDMY,
            this.colSSSL,
            this.colSSSY,
            this.colSSMY,
            this.colZPSL,
            this.colZPSY,
            this.colZPMY,
            this.colZZSL,
            this.colZZSY,
            this.colZZMY,
            this.colYFSL,
            this.colYFMY,
            this.colYFSY,
            this.colCGSHID,
            this.colCGSHMXID});
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
            this.colCGSHDH.Caption = "收货单号";
            this.colCGSHDH.FieldName = "CGSHDH";
            this.colCGSHDH.Name = "colCGSHDH";
            this.colCGSHDH.SummaryItem.DisplayFormat = "总计：";
            this.colCGSHDH.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Custom;
            this.colCGSHDH.Visible = true;
            this.colCGSHDH.VisibleIndex = 0;
            // 
            // colSPBH
            // 
            this.colSPBH.Caption = "商品编号";
            this.colSPBH.FieldName = "SPBH";
            this.colSPBH.Name = "colSPBH";
            this.colSPBH.Visible = true;
            this.colSPBH.VisibleIndex = 1;
            // 
            // colPM
            // 
            this.colPM.Caption = "品名";
            this.colPM.FieldName = "PM";
            this.colPM.Name = "colPM";
            this.colPM.Visible = true;
            this.colPM.VisibleIndex = 2;
            // 
            // colZDDM
            // 
            this.colZDDM.Caption = "征订代码";
            this.colZDDM.FieldName = "ZDDM";
            this.colZDDM.Name = "colZDDM";
            this.colZDDM.Visible = true;
            this.colZDDM.VisibleIndex = 3;
            // 
            // colDJ
            // 
            this.colDJ.Caption = "定价";
            this.colDJ.FieldName = "DJ";
            this.colDJ.Name = "colDJ";
            this.colDJ.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colDJ.Visible = true;
            this.colDJ.VisibleIndex = 4;
            // 
            // colJJ
            // 
            this.colJJ.Caption = "进价";
            this.colJJ.FieldName = "JJ";
            this.colJJ.Name = "colJJ";
            this.colJJ.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colJJ.Visible = true;
            this.colJJ.VisibleIndex = 6;
            // 
            // colJZ
            // 
            this.colJZ.Caption = "进折";
            this.colJZ.FieldName = "JZ";
            this.colJZ.Name = "colJZ";
            this.colJZ.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colJZ.Visible = true;
            this.colJZ.VisibleIndex = 5;
            // 
            // colYDSL
            // 
            this.colYDSL.Caption = "原单数量";
            this.colYDSL.FieldName = "YDSL";
            this.colYDSL.Name = "colYDSL";
            this.colYDSL.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colYDSL.Visible = true;
            this.colYDSL.VisibleIndex = 7;
            // 
            // colYDSY
            // 
            this.colYDSY.Caption = "原单实洋";
            this.colYDSY.FieldName = "YDSY";
            this.colYDSY.Name = "colYDSY";
            this.colYDSY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colYDSY.Visible = true;
            this.colYDSY.VisibleIndex = 8;
            // 
            // colYDMY
            // 
            this.colYDMY.Caption = "原单码洋";
            this.colYDMY.FieldName = "YDMY";
            this.colYDMY.Name = "colYDMY";
            this.colYDMY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colYDMY.Visible = true;
            this.colYDMY.VisibleIndex = 9;
            // 
            // colSSSL
            // 
            this.colSSSL.Caption = "实收数量";
            this.colSSSL.FieldName = "SSSL";
            this.colSSSL.Name = "colSSSL";
            this.colSSSL.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colSSSL.Visible = true;
            this.colSSSL.VisibleIndex = 10;
            // 
            // colSSSY
            // 
            this.colSSSY.Caption = "实收实洋";
            this.colSSSY.FieldName = "SSSY";
            this.colSSSY.Name = "colSSSY";
            this.colSSSY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colSSSY.Visible = true;
            this.colSSSY.VisibleIndex = 11;
            // 
            // colSSMY
            // 
            this.colSSMY.Caption = "实收码洋";
            this.colSSMY.FieldName = "SSMY";
            this.colSSMY.Name = "colSSMY";
            this.colSSMY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colSSMY.Visible = true;
            this.colSSMY.VisibleIndex = 12;
            // 
            // colZPSL
            // 
            this.colZPSL.Caption = "赠品数量";
            this.colZPSL.FieldName = "ZPSL";
            this.colZPSL.Name = "colZPSL";
            this.colZPSL.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colZPSL.Visible = true;
            this.colZPSL.VisibleIndex = 13;
            // 
            // colZPSY
            // 
            this.colZPSY.Caption = "赠品实洋";
            this.colZPSY.FieldName = "ZPSY";
            this.colZPSY.Name = "colZPSY";
            this.colZPSY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colZPSY.Visible = true;
            this.colZPSY.VisibleIndex = 14;
            // 
            // colZPMY
            // 
            this.colZPMY.Caption = "赠品码洋";
            this.colZPMY.FieldName = "ZPMY";
            this.colZPMY.Name = "colZPMY";
            this.colZPMY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colZPMY.Visible = true;
            this.colZPMY.VisibleIndex = 15;
            // 
            // colZZSL
            // 
            this.colZZSL.Caption = "做账数量";
            this.colZZSL.FieldName = "ZZSL";
            this.colZZSL.Name = "colZZSL";
            this.colZZSL.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colZZSL.Visible = true;
            this.colZZSL.VisibleIndex = 16;
            // 
            // colZZSY
            // 
            this.colZZSY.Caption = "做账实洋";
            this.colZZSY.FieldName = "ZZSY";
            this.colZZSY.Name = "colZZSY";
            this.colZZSY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colZZSY.Visible = true;
            this.colZZSY.VisibleIndex = 17;
            // 
            // colZZMY
            // 
            this.colZZMY.Caption = "做账码洋";
            this.colZZMY.FieldName = "ZZMY";
            this.colZZMY.Name = "colZZMY";
            this.colZZMY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colZZMY.Visible = true;
            this.colZZMY.VisibleIndex = 18;
            // 
            // colYFSL
            // 
            this.colYFSL.Caption = "已付数量";
            this.colYFSL.FieldName = "YFSL";
            this.colYFSL.Name = "colYFSL";
            this.colYFSL.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colYFSL.Visible = true;
            this.colYFSL.VisibleIndex = 19;
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
            // colYFSY
            // 
            this.colYFSY.Caption = "已付实洋";
            this.colYFSY.FieldName = "YFSY";
            this.colYFSY.Name = "colYFSY";
            this.colYFSY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colYFSY.Visible = true;
            this.colYFSY.VisibleIndex = 21;
            // 
            // colCGSHID
            // 
            this.colCGSHID.Caption = "采购收货ID";
            this.colCGSHID.FieldName = "CGSHID";
            this.colCGSHID.Name = "colCGSHID";
            this.colCGSHID.OptionsFilter.AllowFilter = false;
            // 
            // colCGSHMXID
            // 
            this.colCGSHMXID.Caption = "采购收货明细ID";
            this.colCGSHMXID.FieldName = "CGSHMXID";
            this.colCGSHMXID.Name = "colCGSHMXID";
            this.colCGSHMXID.OptionsFilter.AllowFilter = false;
            // 
            // xpInstantFeedbackSource1
            // 
            this.xpInstantFeedbackSource1.ObjectType = typeof(XINHUA.VIEW_JT_G_CGSHMX);
            // 
            // FrmPurchaseReceiveDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 276);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmPurchaseReceiveDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "采购收货单明细";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPurchaseReceiveDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpServerCollectionSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
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
        private DevExpress.XtraBars.BarButtonItem btnCorrect;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem btnColCustomize;
        private DevExpress.XtraBars.BarButtonItem btnSaveLayout;
        private DevExpress.XtraBars.BarButtonItem btnLoadLayout;
        private DevExpress.XtraGrid.Columns.GridColumn colCGSHDH;
        private DevExpress.XtraGrid.Columns.GridColumn colSPBH;
        private DevExpress.XtraGrid.Columns.GridColumn colPM;
        private DevExpress.XtraGrid.Columns.GridColumn colZDDM;
        private DevExpress.XtraGrid.Columns.GridColumn colDJ;
        private DevExpress.XtraGrid.Columns.GridColumn colJJ;
        private DevExpress.XtraGrid.Columns.GridColumn colJZ;
        private DevExpress.XtraGrid.Columns.GridColumn colYDSL;
        private DevExpress.XtraGrid.Columns.GridColumn colYDSY;
        private DevExpress.XtraGrid.Columns.GridColumn colYDMY;
        private DevExpress.XtraGrid.Columns.GridColumn colSSSL;
        private DevExpress.XtraGrid.Columns.GridColumn colSSSY;
        private DevExpress.XtraGrid.Columns.GridColumn colSSMY;
        private DevExpress.XtraGrid.Columns.GridColumn colZPSL;
        private DevExpress.XtraGrid.Columns.GridColumn colZPSY;
        private DevExpress.XtraGrid.Columns.GridColumn colZPMY;
        private DevExpress.XtraGrid.Columns.GridColumn colZZSL;
        private DevExpress.XtraGrid.Columns.GridColumn colZZSY;
        private DevExpress.XtraGrid.Columns.GridColumn colZZMY;
        private DevExpress.XtraGrid.Columns.GridColumn colYFSL;
        private DevExpress.XtraGrid.Columns.GridColumn colYFMY;
        private DevExpress.XtraGrid.Columns.GridColumn colYFSY;
        private DevExpress.Xpo.XPInstantFeedbackSource xpInstantFeedbackSource1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraGrid.Columns.GridColumn colCGSHID;
        private DevExpress.XtraGrid.Columns.GridColumn colCGSHMXID;
        private DevExpress.XtraBars.BarButtonItem btnPrintGrid;
        private DevExpress.XtraBars.BarButtonItem btnExportGrid;
    }
}