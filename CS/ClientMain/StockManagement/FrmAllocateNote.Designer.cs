namespace ClientMain
{
    partial class FrmAllocateNote
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
            this.btnVoucher = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.btnPrintGrid = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.btnExportGrid = new DevExpress.XtraBars.BarButtonItem();
            this.btnExportDetail = new DevExpress.XtraBars.BarButtonItem();
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
            this.colSTATUSMC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDBDID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDBDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDCBMMC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDRBMMC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZDRQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDBSL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDBSY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDBMY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDBPZH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCZYXM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCZYID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDBPZID = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.btnVoucher,
            this.barSubItem1,
            this.btnPrintGrid,
            this.barSubItem2,
            this.btnExportGrid,
            this.btnExportDetail,
            this.btnShowError,
            this.barSubItem3,
            this.btnColCustomize,
            this.btnSaveLayout,
            this.btnLoadLayout});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 14;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnVoucher),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnShowError),
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
            // btnVoucher
            // 
            this.btnVoucher.Caption = "凭证";
            this.btnVoucher.Id = 3;
            this.btnVoucher.Name = "btnVoucher";
            this.btnVoucher.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnVoucher_ItemClick);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "打印";
            this.barSubItem1.Id = 4;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPrintGrid)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // btnPrintGrid
            // 
            this.btnPrintGrid.Caption = "打印表格";
            this.btnPrintGrid.Id = 5;
            this.btnPrintGrid.Name = "btnPrintGrid";
            this.btnPrintGrid.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrintGrid_ItemClick);
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
            this.btnExportGrid.Id = 7;
            this.btnExportGrid.Name = "btnExportGrid";
            this.btnExportGrid.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExportGrid_ItemClick);
            // 
            // btnExportDetail
            // 
            this.btnExportDetail.Caption = "导出明细";
            this.btnExportDetail.Id = 8;
            this.btnExportDetail.Name = "btnExportDetail";
            this.btnExportDetail.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExportDetail_ItemClick);
            // 
            // btnShowError
            // 
            this.btnShowError.Caption = "显示差错";
            this.btnShowError.Id = 9;
            this.btnShowError.Name = "btnShowError";
            this.btnShowError.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnShowError_ItemClick);
            // 
            // barSubItem3
            // 
            this.barSubItem3.Caption = "视图";
            this.barSubItem3.Id = 10;
            this.barSubItem3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnColCustomize),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSaveLayout),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLoadLayout)});
            this.barSubItem3.Name = "barSubItem3";
            // 
            // btnColCustomize
            // 
            this.btnColCustomize.Caption = "列定制";
            this.btnColCustomize.Id = 11;
            this.btnColCustomize.Name = "btnColCustomize";
            this.btnColCustomize.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnColCustomize_ItemClick);
            // 
            // btnSaveLayout
            // 
            this.btnSaveLayout.Caption = "保存视图";
            this.btnSaveLayout.Id = 12;
            this.btnSaveLayout.Name = "btnSaveLayout";
            this.btnSaveLayout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaveLayout_ItemClick);
            // 
            // btnLoadLayout
            // 
            this.btnLoadLayout.Caption = "载入视图";
            this.btnLoadLayout.Id = 13;
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
            this.barDockControlTop.Size = new System.Drawing.Size(564, 53);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 239);
            this.barDockControlBottom.Size = new System.Drawing.Size(564, 23);
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
            this.barDockControlRight.Location = new System.Drawing.Point(564, 53);
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
            this.gridControl1.Size = new System.Drawing.Size(564, 186);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // xpServerCollectionSource1
            // 
            this.xpServerCollectionSource1.ObjectType = typeof(XINHUA.VIEW_JT_C_DBD);
            this.xpServerCollectionSource1.Session = this.unitOfWork1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTATUSMC,
            this.colDBDID,
            this.colDBDH,
            this.colDCBMMC,
            this.colDRBMMC,
            this.colSL,
            this.colZDRQ,
            this.colDBSL,
            this.colDBSY,
            this.colDBMY,
            this.colDBPZH,
            this.colZT,
            this.colCZYXM,
            this.colCZYID,
            this.colDBPZID});
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
            this.colSTATUSMC.SummaryItem.DisplayFormat = "总计:";
            this.colSTATUSMC.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Custom;
            this.colSTATUSMC.Visible = true;
            this.colSTATUSMC.VisibleIndex = 0;
            // 
            // colDBDID
            // 
            this.colDBDID.Caption = "调拨单ID";
            this.colDBDID.FieldName = "DBDID";
            this.colDBDID.Name = "colDBDID";
            this.colDBDID.OptionsFilter.AllowFilter = false;
            // 
            // colDBDH
            // 
            this.colDBDH.Caption = "调拨单号";
            this.colDBDH.FieldName = "DBDH";
            this.colDBDH.Name = "colDBDH";
            this.colDBDH.Visible = true;
            this.colDBDH.VisibleIndex = 1;
            // 
            // colDCBMMC
            // 
            this.colDCBMMC.Caption = "调出部门";
            this.colDCBMMC.FieldName = "DCBMMC";
            this.colDCBMMC.Name = "colDCBMMC";
            this.colDCBMMC.Visible = true;
            this.colDCBMMC.VisibleIndex = 2;
            // 
            // colDRBMMC
            // 
            this.colDRBMMC.Caption = "调入部门";
            this.colDRBMMC.FieldName = "DRBMMC";
            this.colDRBMMC.Name = "colDRBMMC";
            this.colDRBMMC.Visible = true;
            this.colDRBMMC.VisibleIndex = 3;
            // 
            // colSL
            // 
            this.colSL.Caption = "税率";
            this.colSL.FieldName = "SL";
            this.colSL.Name = "colSL";
            this.colSL.Visible = true;
            this.colSL.VisibleIndex = 4;
            // 
            // colZDRQ
            // 
            this.colZDRQ.Caption = "制单日期";
            this.colZDRQ.FieldName = "ZDRQ";
            this.colZDRQ.Name = "colZDRQ";
            this.colZDRQ.Visible = true;
            this.colZDRQ.VisibleIndex = 5;
            // 
            // colDBSL
            // 
            this.colDBSL.Caption = "调拨数量";
            this.colDBSL.FieldName = "DBSL";
            this.colDBSL.Name = "colDBSL";
            this.colDBSL.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colDBSL.Visible = true;
            this.colDBSL.VisibleIndex = 6;
            // 
            // colDBSY
            // 
            this.colDBSY.Caption = "调拨实洋";
            this.colDBSY.FieldName = "DBSY";
            this.colDBSY.Name = "colDBSY";
            this.colDBSY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colDBSY.Visible = true;
            this.colDBSY.VisibleIndex = 7;
            // 
            // colDBMY
            // 
            this.colDBMY.Caption = "调拨码洋";
            this.colDBMY.FieldName = "DBMY";
            this.colDBMY.Name = "colDBMY";
            this.colDBMY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colDBMY.Visible = true;
            this.colDBMY.VisibleIndex = 8;
            // 
            // colDBPZH
            // 
            this.colDBPZH.Caption = "调拨凭证";
            this.colDBPZH.FieldName = "DBPZH";
            this.colDBPZH.Name = "colDBPZH";
            this.colDBPZH.Visible = true;
            this.colDBPZH.VisibleIndex = 9;
            // 
            // colZT
            // 
            this.colZT.Caption = "状态ID";
            this.colZT.FieldName = "ZT";
            this.colZT.Name = "colZT";
            this.colZT.OptionsFilter.AllowFilter = false;
            // 
            // colCZYXM
            // 
            this.colCZYXM.Caption = "操作员";
            this.colCZYXM.FieldName = "CZYXM";
            this.colCZYXM.Name = "colCZYXM";
            this.colCZYXM.Visible = true;
            this.colCZYXM.VisibleIndex = 10;
            // 
            // colCZYID
            // 
            this.colCZYID.Caption = "操作员ID";
            this.colCZYID.FieldName = "CZYID";
            this.colCZYID.Name = "colCZYID";
            this.colCZYID.OptionsFilter.AllowFilter = false;
            // 
            // colDBPZID
            // 
            this.colDBPZID.Caption = "调拨凭证ID";
            this.colDBPZID.FieldName = "DBPZID";
            this.colDBPZID.Name = "colDBPZID";
            this.colDBPZID.OptionsFilter.AllowFilter = false;
            // 
            // FrmAllocateNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 262);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmAllocateNote";
            this.Text = "调拨单列表";
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
        private DevExpress.XtraBars.BarButtonItem btnMasterQuery;
        private DevExpress.XtraBars.BarButtonItem btnDetailQuery;
        private DevExpress.XtraBars.BarButtonItem btnConfirm;
        private DevExpress.XtraBars.BarButtonItem btnVoucher;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem btnPrintGrid;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarButtonItem btnExportGrid;
        private DevExpress.XtraBars.BarButtonItem btnExportDetail;
        private DevExpress.XtraBars.BarButtonItem btnShowError;
        private DevExpress.XtraBars.BarSubItem barSubItem3;
        private DevExpress.XtraBars.BarButtonItem btnColCustomize;
        private DevExpress.XtraBars.BarButtonItem btnSaveLayout;
        private DevExpress.XtraBars.BarButtonItem btnLoadLayout;
        private DevExpress.XtraGrid.Columns.GridColumn colSTATUSMC;
        private DevExpress.XtraGrid.Columns.GridColumn colDBDID;
        private DevExpress.XtraGrid.Columns.GridColumn colDBDH;
        private DevExpress.XtraGrid.Columns.GridColumn colDCBMMC;
        private DevExpress.XtraGrid.Columns.GridColumn colDRBMMC;
        private DevExpress.XtraGrid.Columns.GridColumn colSL;
        private DevExpress.XtraGrid.Columns.GridColumn colZDRQ;
        private DevExpress.XtraGrid.Columns.GridColumn colDBSL;
        private DevExpress.XtraGrid.Columns.GridColumn colDBSY;
        private DevExpress.XtraGrid.Columns.GridColumn colDBMY;
        private DevExpress.XtraGrid.Columns.GridColumn colDBPZH;
        private DevExpress.XtraGrid.Columns.GridColumn colZT;
        private DevExpress.XtraGrid.Columns.GridColumn colCZYXM;
        private DevExpress.XtraGrid.Columns.GridColumn colCZYID;
        private DevExpress.XtraGrid.Columns.GridColumn colDBPZID;
    }
}