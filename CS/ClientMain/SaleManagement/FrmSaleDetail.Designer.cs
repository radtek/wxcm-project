namespace ClientMain
{
    partial class FrmSaleDetail
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
            this.btnCorrect = new DevExpress.XtraBars.BarButtonItem();
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
            this.xpServerCollectionSource1 = new DevExpress.Xpo.XPServerCollectionSource();
            this.unitOfWork1 = new DevExpress.Xpo.UnitOfWork();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colXSDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSPBH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJSFSMC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKHMC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXSDMXID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXSDID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZDDM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDJ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXJ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXSSL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXSSY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXSMY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZZSL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZZSY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZZMY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYSSL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYSSY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYSMY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCZYXM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFHDZ = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpServerCollectionSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
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
            this.btnCorrect,
            this.btnPrintGrid,
            this.btnExportGrid,
            this.barSubItem1,
            this.btnColCustomize,
            this.btnSaveLayout,
            this.btnLoadLayout});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 10;
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
            this.btnDetailQuery.Id = 2;
            this.btnDetailQuery.Name = "btnDetailQuery";
            this.btnDetailQuery.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDetailQuery_ItemClick);
            // 
            // btnCorrect
            // 
            this.btnCorrect.Caption = "更正";
            this.btnCorrect.Id = 3;
            this.btnCorrect.Name = "btnCorrect";
            this.btnCorrect.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCorrect_ItemClick);
            // 
            // btnPrintGrid
            // 
            this.btnPrintGrid.Caption = "打印表格";
            this.btnPrintGrid.Id = 4;
            this.btnPrintGrid.Name = "btnPrintGrid";
            this.btnPrintGrid.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrintGrid_ItemClick);
            // 
            // btnExportGrid
            // 
            this.btnExportGrid.Caption = "导出表格";
            this.btnExportGrid.Id = 5;
            this.btnExportGrid.Name = "btnExportGrid";
            this.btnExportGrid.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExportGrid_ItemClick);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "视图";
            this.barSubItem1.Id = 6;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnColCustomize),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSaveLayout),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLoadLayout)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // btnColCustomize
            // 
            this.btnColCustomize.Caption = "列定制";
            this.btnColCustomize.Id = 7;
            this.btnColCustomize.Name = "btnColCustomize";
            this.btnColCustomize.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnColCustomize_ItemClick);
            // 
            // btnSaveLayout
            // 
            this.btnSaveLayout.Caption = "保存视图";
            this.btnSaveLayout.Id = 8;
            this.btnSaveLayout.Name = "btnSaveLayout";
            this.btnSaveLayout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaveLayout_ItemClick);
            // 
            // btnLoadLayout
            // 
            this.btnLoadLayout.Caption = "载入视图";
            this.btnLoadLayout.Id = 9;
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
            this.barDockControlTop.Size = new System.Drawing.Size(581, 53);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 239);
            this.barDockControlBottom.Size = new System.Drawing.Size(581, 23);
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
            this.barDockControlRight.Location = new System.Drawing.Point(581, 53);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 186);
            // 
            // xpServerCollectionSource1
            // 
            this.xpServerCollectionSource1.ObjectType = typeof(XINHUA.VIEW_JT_X_XSDMX);
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
            this.gridControl1.Size = new System.Drawing.Size(581, 186);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colXSDH,
            this.colPM,
            this.colSPBH,
            this.colJSFSMC,
            this.colKHMC,
            this.colXSDMXID,
            this.colXSDID,
            this.colZDDM,
            this.colDJ,
            this.colXJ,
            this.colXZ,
            this.colSL,
            this.colXSSL,
            this.colXSSY,
            this.colXSMY,
            this.colZZSL,
            this.colZZSY,
            this.colZZMY,
            this.colYSSL,
            this.colYSSY,
            this.colYSMY,
            this.colCZYXM,
            this.colFHDZ});
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
            // colXSDH
            // 
            this.colXSDH.Caption = "销售单号";
            this.colXSDH.FieldName = "XSDH";
            this.colXSDH.Name = "colXSDH";
            this.colXSDH.SummaryItem.DisplayFormat = "总计：";
            this.colXSDH.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Custom;
            this.colXSDH.Visible = true;
            this.colXSDH.VisibleIndex = 0;
            // 
            // colPM
            // 
            this.colPM.Caption = "品名";
            this.colPM.FieldName = "PM";
            this.colPM.Name = "colPM";
            this.colPM.Visible = true;
            this.colPM.VisibleIndex = 1;
            // 
            // colSPBH
            // 
            this.colSPBH.Caption = "商品编号";
            this.colSPBH.FieldName = "SPBH";
            this.colSPBH.Name = "colSPBH";
            this.colSPBH.Visible = true;
            this.colSPBH.VisibleIndex = 2;
            // 
            // colJSFSMC
            // 
            this.colJSFSMC.Caption = "结算方式";
            this.colJSFSMC.FieldName = "JSFSMC";
            this.colJSFSMC.Name = "colJSFSMC";
            this.colJSFSMC.Visible = true;
            this.colJSFSMC.VisibleIndex = 3;
            // 
            // colKHMC
            // 
            this.colKHMC.Caption = "客户";
            this.colKHMC.FieldName = "KHMC";
            this.colKHMC.Name = "colKHMC";
            this.colKHMC.Visible = true;
            this.colKHMC.VisibleIndex = 4;
            // 
            // colXSDMXID
            // 
            this.colXSDMXID.Caption = "销售单明细ID";
            this.colXSDMXID.FieldName = "XSDMXID";
            this.colXSDMXID.Name = "colXSDMXID";
            this.colXSDMXID.OptionsFilter.AllowFilter = false;
            // 
            // colXSDID
            // 
            this.colXSDID.Caption = "销售单ID";
            this.colXSDID.FieldName = "XSDID";
            this.colXSDID.Name = "colXSDID";
            this.colXSDID.OptionsFilter.AllowFilter = false;
            // 
            // colZDDM
            // 
            this.colZDDM.Caption = "征订代码";
            this.colZDDM.FieldName = "ZDDM";
            this.colZDDM.Name = "colZDDM";
            this.colZDDM.Visible = true;
            this.colZDDM.VisibleIndex = 5;
            // 
            // colDJ
            // 
            this.colDJ.Caption = "定价";
            this.colDJ.FieldName = "DJ";
            this.colDJ.Name = "colDJ";
            this.colDJ.Visible = true;
            this.colDJ.VisibleIndex = 6;
            // 
            // colXJ
            // 
            this.colXJ.Caption = "销价";
            this.colXJ.FieldName = "XJ";
            this.colXJ.Name = "colXJ";
            this.colXJ.Visible = true;
            this.colXJ.VisibleIndex = 7;
            // 
            // colXZ
            // 
            this.colXZ.Caption = "销折";
            this.colXZ.FieldName = "XZ";
            this.colXZ.Name = "colXZ";
            this.colXZ.Visible = true;
            this.colXZ.VisibleIndex = 8;
            // 
            // colSL
            // 
            this.colSL.Caption = "税率";
            this.colSL.FieldName = "SL";
            this.colSL.Name = "colSL";
            this.colSL.Visible = true;
            this.colSL.VisibleIndex = 9;
            // 
            // colXSSL
            // 
            this.colXSSL.Caption = "销售数量";
            this.colXSSL.FieldName = "XSSL";
            this.colXSSL.Name = "colXSSL";
            this.colXSSL.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Custom;
            this.colXSSL.Visible = true;
            this.colXSSL.VisibleIndex = 10;
            // 
            // colXSSY
            // 
            this.colXSSY.Caption = "销售实洋";
            this.colXSSY.FieldName = "XSSY";
            this.colXSSY.Name = "colXSSY";
            this.colXSSY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Custom;
            this.colXSSY.Visible = true;
            this.colXSSY.VisibleIndex = 11;
            // 
            // colXSMY
            // 
            this.colXSMY.Caption = "销售码洋";
            this.colXSMY.FieldName = "XSMY";
            this.colXSMY.Name = "colXSMY";
            this.colXSMY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Custom;
            this.colXSMY.Visible = true;
            this.colXSMY.VisibleIndex = 12;
            // 
            // colZZSL
            // 
            this.colZZSL.Caption = "做账数量";
            this.colZZSL.FieldName = "ZZSL";
            this.colZZSL.Name = "colZZSL";
            this.colZZSL.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Custom;
            this.colZZSL.Visible = true;
            this.colZZSL.VisibleIndex = 13;
            // 
            // colZZSY
            // 
            this.colZZSY.Caption = "做账实洋";
            this.colZZSY.FieldName = "ZZSY";
            this.colZZSY.Name = "colZZSY";
            this.colZZSY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Custom;
            this.colZZSY.Visible = true;
            this.colZZSY.VisibleIndex = 14;
            // 
            // colZZMY
            // 
            this.colZZMY.Caption = "做账码洋";
            this.colZZMY.FieldName = "ZZMY";
            this.colZZMY.Name = "colZZMY";
            this.colZZMY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Custom;
            this.colZZMY.Visible = true;
            this.colZZMY.VisibleIndex = 15;
            // 
            // colYSSL
            // 
            this.colYSSL.Caption = "已结数量";
            this.colYSSL.FieldName = "YSSL";
            this.colYSSL.Name = "colYSSL";
            this.colYSSL.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Custom;
            this.colYSSL.Visible = true;
            this.colYSSL.VisibleIndex = 16;
            // 
            // colYSSY
            // 
            this.colYSSY.Caption = "已结实洋";
            this.colYSSY.FieldName = "YSSY";
            this.colYSSY.Name = "colYSSY";
            this.colYSSY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Custom;
            this.colYSSY.Visible = true;
            this.colYSSY.VisibleIndex = 17;
            // 
            // colYSMY
            // 
            this.colYSMY.Caption = "已结码洋";
            this.colYSMY.FieldName = "YSMY";
            this.colYSMY.Name = "colYSMY";
            this.colYSMY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Custom;
            this.colYSMY.Visible = true;
            this.colYSMY.VisibleIndex = 18;
            // 
            // colCZYXM
            // 
            this.colCZYXM.Caption = "操作员";
            this.colCZYXM.FieldName = "CZYXM";
            this.colCZYXM.Name = "colCZYXM";
            this.colCZYXM.Visible = true;
            this.colCZYXM.VisibleIndex = 19;
            // 
            // colFHDZ
            // 
            this.colFHDZ.Caption = "发货地址";
            this.colFHDZ.FieldName = "FHDZ";
            this.colFHDZ.Name = "colFHDZ";
            this.colFHDZ.Visible = true;
            this.colFHDZ.VisibleIndex = 20;
            // 
            // FrmSaleDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 262);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmSaleDetail";
            this.Text = "销售单明细";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpServerCollectionSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
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
        private DevExpress.Xpo.XPServerCollectionSource xpServerCollectionSource1;
        private DevExpress.Xpo.UnitOfWork unitOfWork1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colXSDH;
        private DevExpress.XtraGrid.Columns.GridColumn colPM;
        private DevExpress.XtraGrid.Columns.GridColumn colSPBH;
        private DevExpress.XtraGrid.Columns.GridColumn colJSFSMC;
        private DevExpress.XtraGrid.Columns.GridColumn colKHMC;
        private DevExpress.XtraGrid.Columns.GridColumn colXSDMXID;
        private DevExpress.XtraGrid.Columns.GridColumn colXSDID;
        private DevExpress.XtraGrid.Columns.GridColumn colZDDM;
        private DevExpress.XtraGrid.Columns.GridColumn colDJ;
        private DevExpress.XtraGrid.Columns.GridColumn colXJ;
        private DevExpress.XtraGrid.Columns.GridColumn colXZ;
        private DevExpress.XtraGrid.Columns.GridColumn colSL;
        private DevExpress.XtraGrid.Columns.GridColumn colXSSL;
        private DevExpress.XtraGrid.Columns.GridColumn colXSSY;
        private DevExpress.XtraGrid.Columns.GridColumn colXSMY;
        private DevExpress.XtraGrid.Columns.GridColumn colZZSL;
        private DevExpress.XtraGrid.Columns.GridColumn colZZSY;
        private DevExpress.XtraGrid.Columns.GridColumn colZZMY;
        private DevExpress.XtraGrid.Columns.GridColumn colYSSL;
        private DevExpress.XtraGrid.Columns.GridColumn colYSSY;
        private DevExpress.XtraGrid.Columns.GridColumn colYSMY;
        private DevExpress.XtraGrid.Columns.GridColumn colCZYXM;
        private DevExpress.XtraBars.BarButtonItem btnDetailQuery;
        private DevExpress.XtraBars.BarButtonItem btnCorrect;
        private DevExpress.XtraBars.BarButtonItem btnPrintGrid;
        private DevExpress.XtraBars.BarButtonItem btnExportGrid;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem btnColCustomize;
        private DevExpress.XtraBars.BarButtonItem btnSaveLayout;
        private DevExpress.XtraBars.BarButtonItem btnLoadLayout;
        private DevExpress.XtraGrid.Columns.GridColumn colFHDZ;
    }
}