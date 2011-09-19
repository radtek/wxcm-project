namespace ClientMain
{
    partial class FrmSaleReturnDetail
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
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.xpServerCollectionSource1 = new DevExpress.Xpo.XPServerCollectionSource();
            this.unitOfWork1 = new DevExpress.Xpo.UnitOfWork();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colXTDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKHMC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSPBH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXTDID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZDDM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDJ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXJ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXTSL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXTSY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXTMY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZZSL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZZSY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZZMY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYSSL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYSSY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYSMY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZDRQ = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.barButtonItem1,
            this.btnPrintGrid,
            this.btnExportGrid,
            this.barSubItem1,
            this.btnColCustomize,
            this.btnSaveLayout,
            this.btnLoadLayout,
            this.btnDetailQuery});
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
            this.btnDetailQuery.Id = 9;
            this.btnDetailQuery.Name = "btnDetailQuery";
            this.btnDetailQuery.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDetailQuery_ItemClick);
            // 
            // btnPrintGrid
            // 
            this.btnPrintGrid.Caption = "打印表格";
            this.btnPrintGrid.Id = 3;
            this.btnPrintGrid.Name = "btnPrintGrid";
            this.btnPrintGrid.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrintGrid_ItemClick);
            // 
            // btnExportGrid
            // 
            this.btnExportGrid.Caption = "导出表格";
            this.btnExportGrid.Id = 4;
            this.btnExportGrid.Name = "btnExportGrid";
            this.btnExportGrid.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExportGrid_ItemClick);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "视图";
            this.barSubItem1.Id = 5;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnColCustomize),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSaveLayout),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLoadLayout)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // btnColCustomize
            // 
            this.btnColCustomize.Caption = "列定制";
            this.btnColCustomize.Id = 6;
            this.btnColCustomize.Name = "btnColCustomize";
            this.btnColCustomize.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnColCustomize_ItemClick);
            // 
            // btnSaveLayout
            // 
            this.btnSaveLayout.Caption = "保存视图";
            this.btnSaveLayout.Id = 7;
            this.btnSaveLayout.Name = "btnSaveLayout";
            this.btnSaveLayout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaveLayout_ItemClick);
            // 
            // btnLoadLayout
            // 
            this.btnLoadLayout.Caption = "载入视图";
            this.btnLoadLayout.Id = 8;
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
            this.barDockControlTop.Size = new System.Drawing.Size(638, 53);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 239);
            this.barDockControlBottom.Size = new System.Drawing.Size(638, 23);
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
            this.barDockControlRight.Location = new System.Drawing.Point(638, 53);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 186);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "明细查询";
            this.barButtonItem1.Id = 2;
            this.barButtonItem1.Name = "barButtonItem1";
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
            this.gridControl1.Size = new System.Drawing.Size(638, 186);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // xpServerCollectionSource1
            // 
            this.xpServerCollectionSource1.ObjectType = typeof(XINHUA.VIEW_JT_X_XTDMX);
            this.xpServerCollectionSource1.Session = this.unitOfWork1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colXTDH,
            this.colKHMC,
            this.colPM,
            this.colSPBH,
            this.colXTDID,
            this.colZDDM,
            this.colDJ,
            this.colXJ,
            this.colXZ,
            this.colXTSL,
            this.colXTSY,
            this.colXTMY,
            this.colZZSL,
            this.colZZSY,
            this.colZZMY,
            this.colYSSL,
            this.colYSSY,
            this.colYSMY,
            this.colZDRQ});
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
            // colXTDH
            // 
            this.colXTDH.Caption = "销退单号";
            this.colXTDH.FieldName = "XTDH";
            this.colXTDH.Name = "colXTDH";
            this.colXTDH.SummaryItem.DisplayFormat = "总计:";
            this.colXTDH.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Custom;
            this.colXTDH.Visible = true;
            this.colXTDH.VisibleIndex = 0;
            // 
            // colKHMC
            // 
            this.colKHMC.Caption = "客户名称";
            this.colKHMC.FieldName = "KHMC";
            this.colKHMC.Name = "colKHMC";
            this.colKHMC.Visible = true;
            this.colKHMC.VisibleIndex = 1;
            // 
            // colPM
            // 
            this.colPM.Caption = "品名";
            this.colPM.FieldName = "PM";
            this.colPM.Name = "colPM";
            this.colPM.Visible = true;
            this.colPM.VisibleIndex = 2;
            // 
            // colSPBH
            // 
            this.colSPBH.Caption = "商品编号";
            this.colSPBH.FieldName = "SPBH";
            this.colSPBH.Name = "colSPBH";
            this.colSPBH.Visible = true;
            this.colSPBH.VisibleIndex = 3;
            // 
            // colXTDID
            // 
            this.colXTDID.Caption = "销退单ID";
            this.colXTDID.FieldName = "XTDID";
            this.colXTDID.Name = "colXTDID";
            this.colXTDID.OptionsFilter.AllowFilter = false;
            // 
            // colZDDM
            // 
            this.colZDDM.Caption = "征订代码";
            this.colZDDM.FieldName = "ZDDM";
            this.colZDDM.Name = "colZDDM";
            this.colZDDM.Visible = true;
            this.colZDDM.VisibleIndex = 4;
            // 
            // colDJ
            // 
            this.colDJ.Caption = "定价";
            this.colDJ.FieldName = "DJ";
            this.colDJ.Name = "colDJ";
            this.colDJ.Visible = true;
            this.colDJ.VisibleIndex = 5;
            // 
            // colXJ
            // 
            this.colXJ.Caption = "销价";
            this.colXJ.FieldName = "XJ";
            this.colXJ.Name = "colXJ";
            this.colXJ.Visible = true;
            this.colXJ.VisibleIndex = 6;
            // 
            // colXZ
            // 
            this.colXZ.Caption = "销折";
            this.colXZ.FieldName = "XZ";
            this.colXZ.Name = "colXZ";
            this.colXZ.Visible = true;
            this.colXZ.VisibleIndex = 7;
            // 
            // colXTSL
            // 
            this.colXTSL.Caption = "销退数量";
            this.colXTSL.FieldName = "XTSL";
            this.colXTSL.Name = "colXTSL";
            this.colXTSL.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colXTSL.Visible = true;
            this.colXTSL.VisibleIndex = 8;
            // 
            // colXTSY
            // 
            this.colXTSY.Caption = "销退实洋";
            this.colXTSY.FieldName = "XTSY";
            this.colXTSY.Name = "colXTSY";
            this.colXTSY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colXTSY.Visible = true;
            this.colXTSY.VisibleIndex = 9;
            // 
            // colXTMY
            // 
            this.colXTMY.Caption = "销退码洋";
            this.colXTMY.FieldName = "XTMY";
            this.colXTMY.Name = "colXTMY";
            this.colXTMY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colXTMY.Visible = true;
            this.colXTMY.VisibleIndex = 10;
            // 
            // colZZSL
            // 
            this.colZZSL.Caption = "做账数量";
            this.colZZSL.FieldName = "ZZSL";
            this.colZZSL.Name = "colZZSL";
            this.colZZSL.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colZZSL.Visible = true;
            this.colZZSL.VisibleIndex = 11;
            // 
            // colZZSY
            // 
            this.colZZSY.Caption = "做账实洋";
            this.colZZSY.FieldName = "ZZSY";
            this.colZZSY.Name = "colZZSY";
            this.colZZSY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colZZSY.Visible = true;
            this.colZZSY.VisibleIndex = 12;
            // 
            // colZZMY
            // 
            this.colZZMY.Caption = "做账码洋";
            this.colZZMY.FieldName = "ZZMY";
            this.colZZMY.Name = "colZZMY";
            this.colZZMY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colZZMY.Visible = true;
            this.colZZMY.VisibleIndex = 13;
            // 
            // colYSSL
            // 
            this.colYSSL.Caption = "已结数量";
            this.colYSSL.FieldName = "YSSL";
            this.colYSSL.Name = "colYSSL";
            this.colYSSL.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colYSSL.Visible = true;
            this.colYSSL.VisibleIndex = 14;
            // 
            // colYSSY
            // 
            this.colYSSY.Caption = "已结实洋";
            this.colYSSY.FieldName = "YSSY";
            this.colYSSY.Name = "colYSSY";
            this.colYSSY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colYSSY.Visible = true;
            this.colYSSY.VisibleIndex = 15;
            // 
            // colYSMY
            // 
            this.colYSMY.Caption = "已结码洋";
            this.colYSMY.FieldName = "YSMY";
            this.colYSMY.Name = "colYSMY";
            this.colYSMY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colYSMY.Visible = true;
            this.colYSMY.VisibleIndex = 16;
            // 
            // colZDRQ
            // 
            this.colZDRQ.Caption = "制单日期";
            this.colZDRQ.FieldName = "ZDRQ";
            this.colZDRQ.Name = "colZDRQ";
            this.colZDRQ.Visible = true;
            this.colZDRQ.VisibleIndex = 17;
            // 
            // FrmSaleReturnDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 262);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmSaleReturnDetail";
            this.Text = "销退单明细";
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
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnPrintGrid;
        private DevExpress.XtraBars.BarButtonItem btnExportGrid;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem btnColCustomize;
        private DevExpress.XtraBars.BarButtonItem btnSaveLayout;
        private DevExpress.XtraBars.BarButtonItem btnLoadLayout;
        private DevExpress.XtraGrid.Columns.GridColumn colXTDH;
        private DevExpress.XtraGrid.Columns.GridColumn colKHMC;
        private DevExpress.XtraGrid.Columns.GridColumn colPM;
        private DevExpress.XtraGrid.Columns.GridColumn colSPBH;
        private DevExpress.XtraGrid.Columns.GridColumn colXTDID;
        private DevExpress.XtraGrid.Columns.GridColumn colZDDM;
        private DevExpress.XtraGrid.Columns.GridColumn colDJ;
        private DevExpress.XtraGrid.Columns.GridColumn colXJ;
        private DevExpress.XtraGrid.Columns.GridColumn colXZ;
        private DevExpress.XtraGrid.Columns.GridColumn colXTSL;
        private DevExpress.XtraGrid.Columns.GridColumn colXTSY;
        private DevExpress.XtraGrid.Columns.GridColumn colXTMY;
        private DevExpress.XtraGrid.Columns.GridColumn colZZSL;
        private DevExpress.XtraGrid.Columns.GridColumn colZZSY;
        private DevExpress.XtraGrid.Columns.GridColumn colZZMY;
        private DevExpress.XtraGrid.Columns.GridColumn colYSSL;
        private DevExpress.XtraGrid.Columns.GridColumn colYSSY;
        private DevExpress.XtraGrid.Columns.GridColumn colYSMY;
        private DevExpress.XtraGrid.Columns.GridColumn colZDRQ;
        private DevExpress.XtraBars.BarButtonItem btnDetailQuery;
    }
}