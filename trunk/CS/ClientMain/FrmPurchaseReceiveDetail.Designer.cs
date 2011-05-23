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
            this.colCGSHMXID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCGSHID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCGMXDID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJHFSID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZDDM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSPXXID = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.colQSZZRQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZHZZRQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYFSL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYFMY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYFSY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQSFKRQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZHFKRQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLYDJBID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLYDJID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLYDJMXID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLYBMID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHTZMXID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJSHJ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZKE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWSJE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYZT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDJ = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.bar3});
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
            this.btnLoadLayout});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
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
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(720, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 253);
            this.barDockControlBottom.Size = new System.Drawing.Size(720, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 229);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(720, 24);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 229);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.xpServerCollectionSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 24);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(720, 229);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // xpServerCollectionSource1
            // 
            this.xpServerCollectionSource1.ObjectType = typeof(XINHUA.JT_G_CGSHMX_TEST);
            this.xpServerCollectionSource1.Session = this.unitOfWork1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCGSHMXID,
            this.colCGSHID,
            this.colCGMXDID,
            this.colJHFSID,
            this.colZDDM,
            this.colSPXXID,
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
            this.colQSZZRQ,
            this.colZHZZRQ,
            this.colYFSL,
            this.colYFMY,
            this.colYFSY,
            this.colQSFKRQ,
            this.colZHFKRQ,
            this.colLYDJBID,
            this.colLYDJID,
            this.colLYDJMXID,
            this.colLYBMID,
            this.colSHTZMXID,
            this.colJSHJ,
            this.colZKE,
            this.colSE,
            this.colWSJE,
            this.colZT,
            this.colYZT,
            this.colBZ,
            this.colDJ});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.IndicatorWidth = 50;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsPrint.AutoWidth = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            // 
            // colCGSHMXID
            // 
            this.colCGSHMXID.FieldName = "CGSHMXID";
            this.colCGSHMXID.Name = "colCGSHMXID";
            this.colCGSHMXID.Visible = true;
            this.colCGSHMXID.VisibleIndex = 0;
            // 
            // colCGSHID
            // 
            this.colCGSHID.FieldName = "CGSHID";
            this.colCGSHID.Name = "colCGSHID";
            this.colCGSHID.Visible = true;
            this.colCGSHID.VisibleIndex = 1;
            // 
            // colCGMXDID
            // 
            this.colCGMXDID.FieldName = "CGMXDID";
            this.colCGMXDID.Name = "colCGMXDID";
            this.colCGMXDID.Visible = true;
            this.colCGMXDID.VisibleIndex = 2;
            // 
            // colJHFSID
            // 
            this.colJHFSID.FieldName = "JHFSID";
            this.colJHFSID.Name = "colJHFSID";
            this.colJHFSID.Visible = true;
            this.colJHFSID.VisibleIndex = 3;
            // 
            // colZDDM
            // 
            this.colZDDM.FieldName = "ZDDM";
            this.colZDDM.Name = "colZDDM";
            this.colZDDM.Visible = true;
            this.colZDDM.VisibleIndex = 4;
            // 
            // colSPXXID
            // 
            this.colSPXXID.FieldName = "SPXXID";
            this.colSPXXID.Name = "colSPXXID";
            this.colSPXXID.Visible = true;
            this.colSPXXID.VisibleIndex = 5;
            // 
            // colJJ
            // 
            this.colJJ.FieldName = "JJ";
            this.colJJ.Name = "colJJ";
            this.colJJ.Visible = true;
            this.colJJ.VisibleIndex = 6;
            // 
            // colJZ
            // 
            this.colJZ.FieldName = "JZ";
            this.colJZ.Name = "colJZ";
            this.colJZ.Visible = true;
            this.colJZ.VisibleIndex = 7;
            // 
            // colYDSL
            // 
            this.colYDSL.FieldName = "YDSL";
            this.colYDSL.Name = "colYDSL";
            this.colYDSL.Visible = true;
            this.colYDSL.VisibleIndex = 8;
            // 
            // colYDSY
            // 
            this.colYDSY.FieldName = "YDSY";
            this.colYDSY.Name = "colYDSY";
            this.colYDSY.Visible = true;
            this.colYDSY.VisibleIndex = 9;
            // 
            // colYDMY
            // 
            this.colYDMY.FieldName = "YDMY";
            this.colYDMY.Name = "colYDMY";
            this.colYDMY.Visible = true;
            this.colYDMY.VisibleIndex = 10;
            // 
            // colSSSL
            // 
            this.colSSSL.FieldName = "SSSL";
            this.colSSSL.Name = "colSSSL";
            this.colSSSL.Visible = true;
            this.colSSSL.VisibleIndex = 11;
            // 
            // colSSSY
            // 
            this.colSSSY.FieldName = "SSSY";
            this.colSSSY.Name = "colSSSY";
            this.colSSSY.Visible = true;
            this.colSSSY.VisibleIndex = 12;
            // 
            // colSSMY
            // 
            this.colSSMY.FieldName = "SSMY";
            this.colSSMY.Name = "colSSMY";
            this.colSSMY.Visible = true;
            this.colSSMY.VisibleIndex = 13;
            // 
            // colZPSL
            // 
            this.colZPSL.FieldName = "ZPSL";
            this.colZPSL.Name = "colZPSL";
            this.colZPSL.Visible = true;
            this.colZPSL.VisibleIndex = 14;
            // 
            // colZPSY
            // 
            this.colZPSY.FieldName = "ZPSY";
            this.colZPSY.Name = "colZPSY";
            this.colZPSY.Visible = true;
            this.colZPSY.VisibleIndex = 15;
            // 
            // colZPMY
            // 
            this.colZPMY.FieldName = "ZPMY";
            this.colZPMY.Name = "colZPMY";
            this.colZPMY.Visible = true;
            this.colZPMY.VisibleIndex = 16;
            // 
            // colZZSL
            // 
            this.colZZSL.FieldName = "ZZSL";
            this.colZZSL.Name = "colZZSL";
            this.colZZSL.Visible = true;
            this.colZZSL.VisibleIndex = 17;
            // 
            // colZZSY
            // 
            this.colZZSY.FieldName = "ZZSY";
            this.colZZSY.Name = "colZZSY";
            this.colZZSY.Visible = true;
            this.colZZSY.VisibleIndex = 18;
            // 
            // colZZMY
            // 
            this.colZZMY.FieldName = "ZZMY";
            this.colZZMY.Name = "colZZMY";
            this.colZZMY.Visible = true;
            this.colZZMY.VisibleIndex = 19;
            // 
            // colQSZZRQ
            // 
            this.colQSZZRQ.FieldName = "QSZZRQ";
            this.colQSZZRQ.Name = "colQSZZRQ";
            this.colQSZZRQ.Visible = true;
            this.colQSZZRQ.VisibleIndex = 20;
            // 
            // colZHZZRQ
            // 
            this.colZHZZRQ.FieldName = "ZHZZRQ";
            this.colZHZZRQ.Name = "colZHZZRQ";
            this.colZHZZRQ.Visible = true;
            this.colZHZZRQ.VisibleIndex = 21;
            // 
            // colYFSL
            // 
            this.colYFSL.FieldName = "YFSL";
            this.colYFSL.Name = "colYFSL";
            this.colYFSL.Visible = true;
            this.colYFSL.VisibleIndex = 22;
            // 
            // colYFMY
            // 
            this.colYFMY.FieldName = "YFMY";
            this.colYFMY.Name = "colYFMY";
            this.colYFMY.Visible = true;
            this.colYFMY.VisibleIndex = 23;
            // 
            // colYFSY
            // 
            this.colYFSY.FieldName = "YFSY";
            this.colYFSY.Name = "colYFSY";
            this.colYFSY.Visible = true;
            this.colYFSY.VisibleIndex = 24;
            // 
            // colQSFKRQ
            // 
            this.colQSFKRQ.FieldName = "QSFKRQ";
            this.colQSFKRQ.Name = "colQSFKRQ";
            this.colQSFKRQ.Visible = true;
            this.colQSFKRQ.VisibleIndex = 25;
            // 
            // colZHFKRQ
            // 
            this.colZHFKRQ.FieldName = "ZHFKRQ";
            this.colZHFKRQ.Name = "colZHFKRQ";
            this.colZHFKRQ.Visible = true;
            this.colZHFKRQ.VisibleIndex = 26;
            // 
            // colLYDJBID
            // 
            this.colLYDJBID.FieldName = "LYDJBID";
            this.colLYDJBID.Name = "colLYDJBID";
            this.colLYDJBID.Visible = true;
            this.colLYDJBID.VisibleIndex = 27;
            // 
            // colLYDJID
            // 
            this.colLYDJID.FieldName = "LYDJID";
            this.colLYDJID.Name = "colLYDJID";
            this.colLYDJID.Visible = true;
            this.colLYDJID.VisibleIndex = 28;
            // 
            // colLYDJMXID
            // 
            this.colLYDJMXID.FieldName = "LYDJMXID";
            this.colLYDJMXID.Name = "colLYDJMXID";
            this.colLYDJMXID.Visible = true;
            this.colLYDJMXID.VisibleIndex = 29;
            // 
            // colLYBMID
            // 
            this.colLYBMID.FieldName = "LYBMID";
            this.colLYBMID.Name = "colLYBMID";
            this.colLYBMID.Visible = true;
            this.colLYBMID.VisibleIndex = 30;
            // 
            // colSHTZMXID
            // 
            this.colSHTZMXID.FieldName = "SHTZMXID";
            this.colSHTZMXID.Name = "colSHTZMXID";
            this.colSHTZMXID.Visible = true;
            this.colSHTZMXID.VisibleIndex = 31;
            // 
            // colJSHJ
            // 
            this.colJSHJ.FieldName = "JSHJ";
            this.colJSHJ.Name = "colJSHJ";
            this.colJSHJ.Visible = true;
            this.colJSHJ.VisibleIndex = 32;
            // 
            // colZKE
            // 
            this.colZKE.FieldName = "ZKE";
            this.colZKE.Name = "colZKE";
            this.colZKE.Visible = true;
            this.colZKE.VisibleIndex = 33;
            // 
            // colSE
            // 
            this.colSE.FieldName = "SE";
            this.colSE.Name = "colSE";
            this.colSE.Visible = true;
            this.colSE.VisibleIndex = 34;
            // 
            // colWSJE
            // 
            this.colWSJE.FieldName = "WSJE";
            this.colWSJE.Name = "colWSJE";
            this.colWSJE.Visible = true;
            this.colWSJE.VisibleIndex = 35;
            // 
            // colZT
            // 
            this.colZT.FieldName = "ZT";
            this.colZT.Name = "colZT";
            this.colZT.Visible = true;
            this.colZT.VisibleIndex = 36;
            // 
            // colYZT
            // 
            this.colYZT.FieldName = "YZT";
            this.colYZT.Name = "colYZT";
            this.colYZT.Visible = true;
            this.colYZT.VisibleIndex = 37;
            // 
            // colBZ
            // 
            this.colBZ.FieldName = "BZ";
            this.colBZ.Name = "colBZ";
            this.colBZ.Visible = true;
            this.colBZ.VisibleIndex = 38;
            // 
            // colDJ
            // 
            this.colDJ.FieldName = "DJ";
            this.colDJ.Name = "colDJ";
            this.colDJ.Visible = true;
            this.colDJ.VisibleIndex = 39;
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
        private DevExpress.XtraGrid.Columns.GridColumn colCGSHMXID;
        private DevExpress.XtraGrid.Columns.GridColumn colCGSHID;
        private DevExpress.XtraGrid.Columns.GridColumn colCGMXDID;
        private DevExpress.XtraGrid.Columns.GridColumn colJHFSID;
        private DevExpress.XtraGrid.Columns.GridColumn colZDDM;
        private DevExpress.XtraGrid.Columns.GridColumn colSPXXID;
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
        private DevExpress.XtraGrid.Columns.GridColumn colQSZZRQ;
        private DevExpress.XtraGrid.Columns.GridColumn colZHZZRQ;
        private DevExpress.XtraGrid.Columns.GridColumn colYFSL;
        private DevExpress.XtraGrid.Columns.GridColumn colYFMY;
        private DevExpress.XtraGrid.Columns.GridColumn colYFSY;
        private DevExpress.XtraGrid.Columns.GridColumn colQSFKRQ;
        private DevExpress.XtraGrid.Columns.GridColumn colZHFKRQ;
        private DevExpress.XtraGrid.Columns.GridColumn colLYDJBID;
        private DevExpress.XtraGrid.Columns.GridColumn colLYDJID;
        private DevExpress.XtraGrid.Columns.GridColumn colLYDJMXID;
        private DevExpress.XtraGrid.Columns.GridColumn colLYBMID;
        private DevExpress.XtraGrid.Columns.GridColumn colSHTZMXID;
        private DevExpress.XtraGrid.Columns.GridColumn colJSHJ;
        private DevExpress.XtraGrid.Columns.GridColumn colZKE;
        private DevExpress.XtraGrid.Columns.GridColumn colSE;
        private DevExpress.XtraGrid.Columns.GridColumn colWSJE;
        private DevExpress.XtraGrid.Columns.GridColumn colZT;
        private DevExpress.XtraGrid.Columns.GridColumn colYZT;
        private DevExpress.XtraGrid.Columns.GridColumn colBZ;
        private DevExpress.XtraGrid.Columns.GridColumn colDJ;
    }
}