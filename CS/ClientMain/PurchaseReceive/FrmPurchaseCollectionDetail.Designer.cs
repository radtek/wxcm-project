namespace ClientMain
{
    partial class FrmPurchaseCollectionDetail
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
            this.colCGTSDID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCGTSDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCGJSDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWSJE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJSHJ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBZ = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.barDockControlTop.Size = new System.Drawing.Size(559, 53);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 239);
            this.barDockControlBottom.Size = new System.Drawing.Size(559, 23);
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
            this.barDockControlRight.Location = new System.Drawing.Point(559, 53);
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
            this.gridControl1.Size = new System.Drawing.Size(559, 186);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // xpServerCollectionSource1
            // 
            this.xpServerCollectionSource1.ObjectType = typeof(XINHUA.VIEW_JC_C_CGTSDMX);
            this.xpServerCollectionSource1.Session = this.unitOfWork1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCGTSDID,
            this.colCGTSDH,
            this.colCGJSDH,
            this.colSL,
            this.colWSJE,
            this.colSE,
            this.colJSHJ,
            this.colSHL,
            this.colBZ});
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
            // colCGTSDID
            // 
            this.colCGTSDID.Caption = "采购托收单ID";
            this.colCGTSDID.FieldName = "CGTSDID";
            this.colCGTSDID.Name = "colCGTSDID";
            this.colCGTSDID.OptionsFilter.AllowFilter = false;
            // 
            // colCGTSDH
            // 
            this.colCGTSDH.Caption = "采购托收单号";
            this.colCGTSDH.FieldName = "CGTSDH";
            this.colCGTSDH.Name = "colCGTSDH";
            this.colCGTSDH.SummaryItem.DisplayFormat = "总计：";
            this.colCGTSDH.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Custom;
            this.colCGTSDH.Visible = true;
            this.colCGTSDH.VisibleIndex = 0;
            // 
            // colCGJSDH
            // 
            this.colCGJSDH.Caption = "采购结算单号";
            this.colCGJSDH.FieldName = "CGJSDH";
            this.colCGJSDH.Name = "colCGJSDH";
            this.colCGJSDH.Visible = true;
            this.colCGJSDH.VisibleIndex = 1;
            // 
            // colSL
            // 
            this.colSL.Caption = "总数量";
            this.colSL.FieldName = "SL";
            this.colSL.Name = "colSL";
            this.colSL.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colSL.Visible = true;
            this.colSL.VisibleIndex = 2;
            // 
            // colWSJE
            // 
            this.colWSJE.Caption = "无税金额";
            this.colWSJE.FieldName = "WSJE";
            this.colWSJE.Name = "colWSJE";
            this.colWSJE.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colWSJE.Visible = true;
            this.colWSJE.VisibleIndex = 3;
            // 
            // colSE
            // 
            this.colSE.Caption = "税额";
            this.colSE.FieldName = "SE";
            this.colSE.Name = "colSE";
            this.colSE.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colSE.Visible = true;
            this.colSE.VisibleIndex = 4;
            // 
            // colJSHJ
            // 
            this.colJSHJ.Caption = "价税合计";
            this.colJSHJ.FieldName = "JSHJ";
            this.colJSHJ.Name = "colJSHJ";
            this.colJSHJ.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colJSHJ.Visible = true;
            this.colJSHJ.VisibleIndex = 5;
            // 
            // colSHL
            // 
            this.colSHL.Caption = "税率";
            this.colSHL.FieldName = "SHL";
            this.colSHL.Name = "colSHL";
            this.colSHL.Visible = true;
            this.colSHL.VisibleIndex = 6;
            // 
            // colBZ
            // 
            this.colBZ.Caption = "备注";
            this.colBZ.FieldName = "BZ";
            this.colBZ.Name = "colBZ";
            this.colBZ.Visible = true;
            this.colBZ.VisibleIndex = 7;
            // 
            // FrmPurchaseCollectionDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 262);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmPurchaseCollectionDetail";
            this.Text = "采购托收单明细";
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
        private DevExpress.XtraGrid.Columns.GridColumn colCGTSDID;
        private DevExpress.XtraGrid.Columns.GridColumn colCGTSDH;
        private DevExpress.XtraGrid.Columns.GridColumn colSL;
        private DevExpress.XtraGrid.Columns.GridColumn colWSJE;
        private DevExpress.XtraGrid.Columns.GridColumn colSE;
        private DevExpress.XtraGrid.Columns.GridColumn colJSHJ;
        private DevExpress.XtraGrid.Columns.GridColumn colBZ;
        private DevExpress.XtraGrid.Columns.GridColumn colCGJSDH;
        private DevExpress.XtraGrid.Columns.GridColumn colSHL;
    }
}