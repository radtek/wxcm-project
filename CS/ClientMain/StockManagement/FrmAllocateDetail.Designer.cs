namespace ClientMain
{
    partial class FrmAllocateDetail
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
            this.colDBDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDJ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDBDID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZDDM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDBSL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDBSY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDBMY = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.xpServerCollectionSource1.ObjectType = typeof(XINHUA.VIEW_JT_C_DBDMX);
            this.xpServerCollectionSource1.Session = this.unitOfWork1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDBDH,
            this.colPM,
            this.colDJ,
            this.colDBDID,
            this.colZDDM,
            this.colDBSL,
            this.colDBSY,
            this.colDBMY,
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
            // colDBDH
            // 
            this.colDBDH.Caption = "调拨单号";
            this.colDBDH.FieldName = "DBDH";
            this.colDBDH.Name = "colDBDH";
            this.colDBDH.SummaryItem.DisplayFormat = "总计：";
            this.colDBDH.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Custom;
            this.colDBDH.Visible = true;
            this.colDBDH.VisibleIndex = 0;
            // 
            // colPM
            // 
            this.colPM.Caption = "商品名称";
            this.colPM.FieldName = "PM";
            this.colPM.Name = "colPM";
            this.colPM.Visible = true;
            this.colPM.VisibleIndex = 1;
            // 
            // colDJ
            // 
            this.colDJ.Caption = "定价";
            this.colDJ.FieldName = "DJ";
            this.colDJ.Name = "colDJ";
            this.colDJ.Visible = true;
            this.colDJ.VisibleIndex = 2;
            // 
            // colDBDID
            // 
            this.colDBDID.Caption = "调拨单ID";
            this.colDBDID.FieldName = "DBDID";
            this.colDBDID.Name = "colDBDID";
            this.colDBDID.OptionsFilter.AllowFilter = false;
            // 
            // colZDDM
            // 
            this.colZDDM.Caption = "征订代码";
            this.colZDDM.FieldName = "ZDDM";
            this.colZDDM.Name = "colZDDM";
            this.colZDDM.Visible = true;
            this.colZDDM.VisibleIndex = 3;
            // 
            // colDBSL
            // 
            this.colDBSL.Caption = "调拨数量";
            this.colDBSL.FieldName = "DBSL";
            this.colDBSL.Name = "colDBSL";
            this.colDBSL.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colDBSL.Visible = true;
            this.colDBSL.VisibleIndex = 4;
            // 
            // colDBSY
            // 
            this.colDBSY.Caption = "调拨实洋";
            this.colDBSY.FieldName = "DBSY";
            this.colDBSY.Name = "colDBSY";
            this.colDBSY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colDBSY.Visible = true;
            this.colDBSY.VisibleIndex = 5;
            // 
            // colDBMY
            // 
            this.colDBMY.Caption = "调拨码洋";
            this.colDBMY.FieldName = "DBMY";
            this.colDBMY.Name = "colDBMY";
            this.colDBMY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colDBMY.Visible = true;
            this.colDBMY.VisibleIndex = 6;
            // 
            // colCZYXM
            // 
            this.colCZYXM.Caption = "操作员";
            this.colCZYXM.FieldName = "CZYXM";
            this.colCZYXM.Name = "colCZYXM";
            this.colCZYXM.Visible = true;
            this.colCZYXM.VisibleIndex = 7;
            // 
            // FrmAllocateDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 262);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmAllocateDetail";
            this.Text = "调拨单明细列表";
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
        private DevExpress.XtraBars.BarButtonItem btnDetailQuery;
        private DevExpress.XtraBars.BarButtonItem btnPrintGrid;
        private DevExpress.XtraBars.BarButtonItem btnExportGrid;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem btnColCustomize;
        private DevExpress.XtraBars.BarButtonItem btnSaveLayout;
        private DevExpress.XtraBars.BarButtonItem btnLoadLayout;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.Xpo.XPServerCollectionSource xpServerCollectionSource1;
        private DevExpress.Xpo.UnitOfWork unitOfWork1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colDBDH;
        private DevExpress.XtraGrid.Columns.GridColumn colPM;
        private DevExpress.XtraGrid.Columns.GridColumn colDJ;
        private DevExpress.XtraGrid.Columns.GridColumn colDBDID;
        private DevExpress.XtraGrid.Columns.GridColumn colZDDM;
        private DevExpress.XtraGrid.Columns.GridColumn colDBSL;
        private DevExpress.XtraGrid.Columns.GridColumn colDBSY;
        private DevExpress.XtraGrid.Columns.GridColumn colDBMY;
        private DevExpress.XtraGrid.Columns.GridColumn colCZYXM;
    }
}