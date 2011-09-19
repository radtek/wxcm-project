namespace ClientMain
{
    partial class FrmSaleTotalBranch
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
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.btnPrintGrid = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrintNote = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.btnExportGrid = new DevExpress.XtraBars.BarButtonItem();
            this.btnSummaryPrint = new DevExpress.XtraBars.BarButtonItem();
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
            this.colXSHZDID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXSHZDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFXFLSL1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFXFLJE1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFXFLSL2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFXFLJE2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFXFLSL3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFXFLJE3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFXFLSL4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFXFLJE4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFXFLSL5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFXFLJE5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFXFLSL6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFXFLJE6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFXFLSL7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFXFLJE7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFXFLSL8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFXFLJE8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFXFLSL9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFXFLJE9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFXFLSL10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFXFLJE10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZDRQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCZYID = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.btnMasterQuery,
            this.btnDetailQuery,
            this.btnConfirm,
            this.barSubItem1,
            this.barSubItem2,
            this.btnSummaryPrint,
            this.barSubItem3,
            this.btnPrintGrid,
            this.btnPrintNote,
            this.btnExportGrid,
            this.btnColCustomize,
            this.btnSaveLayout,
            this.btnLoadLayout});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 13;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSummaryPrint),
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
            // barSubItem1
            // 
            this.barSubItem1.Caption = "打印";
            this.barSubItem1.Id = 3;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPrintGrid),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPrintNote)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // btnPrintGrid
            // 
            this.btnPrintGrid.Caption = "打印表格";
            this.btnPrintGrid.Id = 7;
            this.btnPrintGrid.Name = "btnPrintGrid";
            this.btnPrintGrid.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrintGrid_ItemClick);
            // 
            // btnPrintNote
            // 
            this.btnPrintNote.Caption = "打印单据";
            this.btnPrintNote.Id = 8;
            this.btnPrintNote.Name = "btnPrintNote";
            this.btnPrintNote.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrintNote_ItemClick);
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "导出";
            this.barSubItem2.Id = 4;
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
            // btnSummaryPrint
            // 
            this.btnSummaryPrint.Caption = "汇总打印";
            this.btnSummaryPrint.Id = 5;
            this.btnSummaryPrint.Name = "btnSummaryPrint";
            this.btnSummaryPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSummaryPrint_ItemClick);
            // 
            // barSubItem3
            // 
            this.barSubItem3.Caption = "视图";
            this.barSubItem3.Id = 6;
            this.barSubItem3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnColCustomize),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSaveLayout),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLoadLayout)});
            this.barSubItem3.Name = "barSubItem3";
            // 
            // btnColCustomize
            // 
            this.btnColCustomize.Caption = "列定制";
            this.btnColCustomize.Id = 10;
            this.btnColCustomize.Name = "btnColCustomize";
            this.btnColCustomize.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnColCustomize_ItemClick);
            // 
            // btnSaveLayout
            // 
            this.btnSaveLayout.Caption = "保存视图";
            this.btnSaveLayout.Id = 11;
            this.btnSaveLayout.Name = "btnSaveLayout";
            this.btnSaveLayout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaveLayout_ItemClick);
            // 
            // btnLoadLayout
            // 
            this.btnLoadLayout.Caption = "载入视图";
            this.btnLoadLayout.Id = 12;
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
            this.barDockControlTop.Size = new System.Drawing.Size(598, 53);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 239);
            this.barDockControlBottom.Size = new System.Drawing.Size(598, 23);
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
            this.barDockControlRight.Location = new System.Drawing.Point(598, 53);
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
            this.gridControl1.Size = new System.Drawing.Size(598, 186);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // xpServerCollectionSource1
            // 
            this.xpServerCollectionSource1.ObjectType = typeof(XINHUA.VIEW_JC_C_XSHZD);
            this.xpServerCollectionSource1.Session = this.unitOfWork1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTATUSMC,
            this.colXSHZDID,
            this.colXSHZDH,
            this.colFXFLSL1,
            this.colFXFLJE1,
            this.colFXFLSL2,
            this.colFXFLJE2,
            this.colFXFLSL3,
            this.colFXFLJE3,
            this.colFXFLSL4,
            this.colFXFLJE4,
            this.colFXFLSL5,
            this.colFXFLJE5,
            this.colFXFLSL6,
            this.colFXFLJE6,
            this.colFXFLSL7,
            this.colFXFLJE7,
            this.colFXFLSL8,
            this.colFXFLJE8,
            this.colFXFLSL9,
            this.colFXFLJE9,
            this.colFXFLSL10,
            this.colFXFLJE10,
            this.colZDRQ,
            this.colZT,
            this.colCZYID,
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
            // colXSHZDID
            // 
            this.colXSHZDID.Caption = "销售汇总单ID";
            this.colXSHZDID.FieldName = "XSHZDID";
            this.colXSHZDID.Name = "colXSHZDID";
            this.colXSHZDID.OptionsFilter.AllowFilter = false;
            // 
            // colXSHZDH
            // 
            this.colXSHZDH.Caption = "销售汇总单号";
            this.colXSHZDH.FieldName = "XSHZDH";
            this.colXSHZDH.Name = "colXSHZDH";
            this.colXSHZDH.Visible = true;
            this.colXSHZDH.VisibleIndex = 1;
            // 
            // colFXFLSL1
            // 
            this.colFXFLSL1.Caption = "哲学、社会科学数量";
            this.colFXFLSL1.FieldName = "FXFLSL1";
            this.colFXFLSL1.Name = "colFXFLSL1";
            this.colFXFLSL1.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colFXFLSL1.Visible = true;
            this.colFXFLSL1.VisibleIndex = 2;
            // 
            // colFXFLJE1
            // 
            this.colFXFLJE1.Caption = "哲学、社会科学金额";
            this.colFXFLJE1.FieldName = "FXFLJE1";
            this.colFXFLJE1.Name = "colFXFLJE1";
            this.colFXFLJE1.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colFXFLJE1.Visible = true;
            this.colFXFLJE1.VisibleIndex = 3;
            // 
            // colFXFLSL2
            // 
            this.colFXFLSL2.Caption = "文化、教育数量";
            this.colFXFLSL2.FieldName = "FXFLSL2";
            this.colFXFLSL2.Name = "colFXFLSL2";
            this.colFXFLSL2.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colFXFLSL2.Visible = true;
            this.colFXFLSL2.VisibleIndex = 4;
            // 
            // colFXFLJE2
            // 
            this.colFXFLJE2.Caption = "文化、教育金额";
            this.colFXFLJE2.FieldName = "FXFLJE2";
            this.colFXFLJE2.Name = "colFXFLJE2";
            this.colFXFLJE2.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colFXFLJE2.Visible = true;
            this.colFXFLJE2.VisibleIndex = 5;
            // 
            // colFXFLSL3
            // 
            this.colFXFLSL3.Caption = "文学、艺术数量";
            this.colFXFLSL3.FieldName = "FXFLSL3";
            this.colFXFLSL3.Name = "colFXFLSL3";
            this.colFXFLSL3.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colFXFLSL3.Visible = true;
            this.colFXFLSL3.VisibleIndex = 6;
            // 
            // colFXFLJE3
            // 
            this.colFXFLJE3.Caption = "文学、艺术金额";
            this.colFXFLJE3.FieldName = "FXFLJE3";
            this.colFXFLJE3.Name = "colFXFLJE3";
            this.colFXFLJE3.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colFXFLJE3.Visible = true;
            this.colFXFLJE3.VisibleIndex = 7;
            // 
            // colFXFLSL4
            // 
            this.colFXFLSL4.Caption = "自然科学、技术数量";
            this.colFXFLSL4.FieldName = "FXFLSL4";
            this.colFXFLSL4.Name = "colFXFLSL4";
            this.colFXFLSL4.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colFXFLSL4.Visible = true;
            this.colFXFLSL4.VisibleIndex = 8;
            // 
            // colFXFLJE4
            // 
            this.colFXFLJE4.Caption = "自然科学、技术金额";
            this.colFXFLJE4.FieldName = "FXFLJE4";
            this.colFXFLJE4.Name = "colFXFLJE4";
            this.colFXFLJE4.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colFXFLJE4.Visible = true;
            this.colFXFLJE4.VisibleIndex = 9;
            // 
            // colFXFLSL5
            // 
            this.colFXFLSL5.Caption = "少儿读物数量";
            this.colFXFLSL5.FieldName = "FXFLSL5";
            this.colFXFLSL5.Name = "colFXFLSL5";
            this.colFXFLSL5.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colFXFLSL5.Visible = true;
            this.colFXFLSL5.VisibleIndex = 10;
            // 
            // colFXFLJE5
            // 
            this.colFXFLJE5.Caption = "少儿读物金额";
            this.colFXFLJE5.FieldName = "FXFLJE5";
            this.colFXFLJE5.Name = "colFXFLJE5";
            this.colFXFLJE5.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colFXFLJE5.Visible = true;
            this.colFXFLJE5.VisibleIndex = 11;
            // 
            // colFXFLSL6
            // 
            this.colFXFLSL6.Caption = "大中专教材数量";
            this.colFXFLSL6.FieldName = "FXFLSL6";
            this.colFXFLSL6.Name = "colFXFLSL6";
            this.colFXFLSL6.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colFXFLSL6.Visible = true;
            this.colFXFLSL6.VisibleIndex = 12;
            // 
            // colFXFLJE6
            // 
            this.colFXFLJE6.Caption = "大中专教材金额";
            this.colFXFLJE6.FieldName = "FXFLJE6";
            this.colFXFLJE6.Name = "colFXFLJE6";
            this.colFXFLJE6.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colFXFLJE6.Visible = true;
            this.colFXFLJE6.VisibleIndex = 13;
            // 
            // colFXFLSL7
            // 
            this.colFXFLSL7.Caption = "课本数量";
            this.colFXFLSL7.FieldName = "FXFLSL7";
            this.colFXFLSL7.Name = "colFXFLSL7";
            this.colFXFLSL7.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colFXFLSL7.Visible = true;
            this.colFXFLSL7.VisibleIndex = 14;
            // 
            // colFXFLJE7
            // 
            this.colFXFLJE7.Caption = "课本金额";
            this.colFXFLJE7.FieldName = "FXFLJE7";
            this.colFXFLJE7.Name = "colFXFLJE7";
            this.colFXFLJE7.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colFXFLJE7.Visible = true;
            this.colFXFLJE7.VisibleIndex = 15;
            // 
            // colFXFLSL8
            // 
            this.colFXFLSL8.Caption = "图片数量";
            this.colFXFLSL8.FieldName = "FXFLSL8";
            this.colFXFLSL8.Name = "colFXFLSL8";
            this.colFXFLSL8.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colFXFLSL8.Visible = true;
            this.colFXFLSL8.VisibleIndex = 16;
            // 
            // colFXFLJE8
            // 
            this.colFXFLJE8.Caption = "图片金额";
            this.colFXFLJE8.FieldName = "FXFLJE8";
            this.colFXFLJE8.Name = "colFXFLJE8";
            this.colFXFLJE8.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colFXFLJE8.Visible = true;
            this.colFXFLJE8.VisibleIndex = 17;
            // 
            // colFXFLSL9
            // 
            this.colFXFLSL9.Caption = "其它出版物数量";
            this.colFXFLSL9.FieldName = "FXFLSL9";
            this.colFXFLSL9.Name = "colFXFLSL9";
            this.colFXFLSL9.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colFXFLSL9.Visible = true;
            this.colFXFLSL9.VisibleIndex = 18;
            // 
            // colFXFLJE9
            // 
            this.colFXFLJE9.Caption = "其它出版物金额";
            this.colFXFLJE9.FieldName = "FXFLJE9";
            this.colFXFLJE9.Name = "colFXFLJE9";
            this.colFXFLJE9.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colFXFLJE9.Visible = true;
            this.colFXFLJE9.VisibleIndex = 19;
            // 
            // colFXFLSL10
            // 
            this.colFXFLSL10.Caption = "非图书商品数量";
            this.colFXFLSL10.FieldName = "FXFLSL10";
            this.colFXFLSL10.Name = "colFXFLSL10";
            this.colFXFLSL10.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colFXFLSL10.Visible = true;
            this.colFXFLSL10.VisibleIndex = 20;
            // 
            // colFXFLJE10
            // 
            this.colFXFLJE10.Caption = "非图书商品金额";
            this.colFXFLJE10.FieldName = "FXFLJE10";
            this.colFXFLJE10.Name = "colFXFLJE10";
            this.colFXFLJE10.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colFXFLJE10.Visible = true;
            this.colFXFLJE10.VisibleIndex = 21;
            // 
            // colZDRQ
            // 
            this.colZDRQ.Caption = "制单日期";
            this.colZDRQ.FieldName = "ZDRQ";
            this.colZDRQ.Name = "colZDRQ";
            this.colZDRQ.Visible = true;
            this.colZDRQ.VisibleIndex = 22;
            // 
            // colZT
            // 
            this.colZT.Caption = "状态ID";
            this.colZT.FieldName = "ZT";
            this.colZT.Name = "colZT";
            this.colZT.OptionsFilter.AllowFilter = false;
            // 
            // colCZYID
            // 
            this.colCZYID.Caption = "操作员ID";
            this.colCZYID.FieldName = "CZYID";
            this.colCZYID.Name = "colCZYID";
            this.colCZYID.OptionsFilter.AllowFilter = false;
            // 
            // colCZYXM
            // 
            this.colCZYXM.Caption = "操作员";
            this.colCZYXM.FieldName = "CZYXM";
            this.colCZYXM.Name = "colCZYXM";
            this.colCZYXM.Visible = true;
            this.colCZYXM.VisibleIndex = 23;
            // 
            // FrmSaleTotalBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 262);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmSaleTotalBranch";
            this.Text = "销售汇总单列表";
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
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarButtonItem btnPrintGrid;
        private DevExpress.XtraBars.BarButtonItem btnPrintNote;
        private DevExpress.XtraBars.BarButtonItem btnExportGrid;
        private DevExpress.XtraBars.BarButtonItem btnSummaryPrint;
        private DevExpress.XtraBars.BarSubItem barSubItem3;
        private DevExpress.XtraBars.BarButtonItem btnColCustomize;
        private DevExpress.XtraBars.BarButtonItem btnSaveLayout;
        private DevExpress.XtraBars.BarButtonItem btnLoadLayout;
        private DevExpress.XtraGrid.Columns.GridColumn colSTATUSMC;
        private DevExpress.XtraGrid.Columns.GridColumn colXSHZDID;
        private DevExpress.XtraGrid.Columns.GridColumn colXSHZDH;
        private DevExpress.XtraGrid.Columns.GridColumn colFXFLSL1;
        private DevExpress.XtraGrid.Columns.GridColumn colFXFLJE1;
        private DevExpress.XtraGrid.Columns.GridColumn colFXFLSL2;
        private DevExpress.XtraGrid.Columns.GridColumn colFXFLJE2;
        private DevExpress.XtraGrid.Columns.GridColumn colFXFLSL3;
        private DevExpress.XtraGrid.Columns.GridColumn colFXFLJE3;
        private DevExpress.XtraGrid.Columns.GridColumn colFXFLSL4;
        private DevExpress.XtraGrid.Columns.GridColumn colFXFLJE4;
        private DevExpress.XtraGrid.Columns.GridColumn colFXFLSL5;
        private DevExpress.XtraGrid.Columns.GridColumn colFXFLJE5;
        private DevExpress.XtraGrid.Columns.GridColumn colFXFLSL6;
        private DevExpress.XtraGrid.Columns.GridColumn colFXFLJE6;
        private DevExpress.XtraGrid.Columns.GridColumn colFXFLSL7;
        private DevExpress.XtraGrid.Columns.GridColumn colFXFLJE7;
        private DevExpress.XtraGrid.Columns.GridColumn colFXFLSL8;
        private DevExpress.XtraGrid.Columns.GridColumn colFXFLJE8;
        private DevExpress.XtraGrid.Columns.GridColumn colFXFLSL9;
        private DevExpress.XtraGrid.Columns.GridColumn colFXFLJE9;
        private DevExpress.XtraGrid.Columns.GridColumn colFXFLSL10;
        private DevExpress.XtraGrid.Columns.GridColumn colFXFLJE10;
        private DevExpress.XtraGrid.Columns.GridColumn colZDRQ;
        private DevExpress.XtraGrid.Columns.GridColumn colZT;
        private DevExpress.XtraGrid.Columns.GridColumn colCZYID;
        private DevExpress.XtraGrid.Columns.GridColumn colCZYXM;
    }
}