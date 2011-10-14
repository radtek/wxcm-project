namespace ClientMain
{
    partial class FrmDeliveryVoucherNote
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
            this.btnMaterQuery = new DevExpress.XtraBars.BarButtonItem();
            this.btnDetailQuery = new DevExpress.XtraBars.BarButtonItem();
            this.btnConfirm = new DevExpress.XtraBars.BarButtonItem();
            this.btnSend = new DevExpress.XtraBars.BarButtonItem();
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
            this.colSTATUSMC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVOUCHERID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVOUCHER_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDWBH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVOUCHER_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFISCAL_YEAR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACCOUNTING_PERIOD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colATTACHMENT_NUMBER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPREPAREDDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZDRXM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHRXM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJZRXM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCNXM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPOSTING_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCZRQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSIGNATURE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colORISTATUSMC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZTMC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colENTER = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.btnMaterQuery,
            this.btnDetailQuery,
            this.btnConfirm,
            this.btnSend,
            this.barSubItem1,
            this.btnColCustomize,
            this.btnSaveLayout,
            this.btnLoadLayout});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnMaterQuery),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDetailQuery),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnConfirm),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSend),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnMaterQuery
            // 
            this.btnMaterQuery.Caption = "主单查询";
            this.btnMaterQuery.Id = 0;
            this.btnMaterQuery.Name = "btnMaterQuery";
            this.btnMaterQuery.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMaterQuery_ItemClick);
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
            // btnSend
            // 
            this.btnSend.Caption = "发送";
            this.btnSend.Id = 3;
            this.btnSend.Name = "btnSend";
            this.btnSend.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSend_ItemClick);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "视图";
            this.barSubItem1.Id = 4;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnColCustomize),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSaveLayout),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLoadLayout)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // btnColCustomize
            // 
            this.btnColCustomize.Caption = "列定制";
            this.btnColCustomize.Id = 5;
            this.btnColCustomize.Name = "btnColCustomize";
            this.btnColCustomize.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnColCustomize_ItemClick);
            // 
            // btnSaveLayout
            // 
            this.btnSaveLayout.Caption = "保存视图";
            this.btnSaveLayout.Id = 6;
            this.btnSaveLayout.Name = "btnSaveLayout";
            this.btnSaveLayout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaveLayout_ItemClick);
            // 
            // btnLoadLayout
            // 
            this.btnLoadLayout.Caption = "载入视图";
            this.btnLoadLayout.Id = 7;
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
            this.barDockControlTop.Size = new System.Drawing.Size(550, 53);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 239);
            this.barDockControlBottom.Size = new System.Drawing.Size(550, 23);
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
            this.barDockControlRight.Location = new System.Drawing.Point(550, 53);
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
            this.gridControl1.Size = new System.Drawing.Size(550, 186);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // xpServerCollectionSource1
            // 
            this.xpServerCollectionSource1.ObjectType = typeof(XINHUA.VIEW_JT_C_FHPZ);
            this.xpServerCollectionSource1.Session = this.unitOfWork1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTATUSMC,
            this.colVOUCHERID,
            this.colVOUCHER_ID,
            this.colDWBH,
            this.colVOUCHER_TYPE,
            this.colFISCAL_YEAR,
            this.colACCOUNTING_PERIOD,
            this.colATTACHMENT_NUMBER,
            this.colPREPAREDDATE,
            this.colZDRXM,
            this.colSHRXM,
            this.colJZRXM,
            this.colCNXM,
            this.colPOSTING_DATE,
            this.colCZRQ,
            this.colSIGNATURE,
            this.colZT,
            this.colORISTATUSMC,
            this.colBZ,
            this.colZTMC,
            this.colENTER});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.IndicatorWidth = 50;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsPrint.AutoWidth = false;
            this.gridView1.OptionsPrint.PrintSelectedRowsOnly = true;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colSTATUSMC
            // 
            this.colSTATUSMC.Caption = "状态";
            this.colSTATUSMC.FieldName = "STATUSMC";
            this.colSTATUSMC.Name = "colSTATUSMC";
            this.colSTATUSMC.Visible = true;
            this.colSTATUSMC.VisibleIndex = 0;
            // 
            // colVOUCHERID
            // 
            this.colVOUCHERID.Caption = "凭证ID";
            this.colVOUCHERID.FieldName = "VOUCHERID";
            this.colVOUCHERID.Name = "colVOUCHERID";
            this.colVOUCHERID.OptionsFilter.AllowFilter = false;
            // 
            // colVOUCHER_ID
            // 
            this.colVOUCHER_ID.Caption = "凭证号";
            this.colVOUCHER_ID.FieldName = "VOUCHER_ID";
            this.colVOUCHER_ID.Name = "colVOUCHER_ID";
            this.colVOUCHER_ID.Visible = true;
            this.colVOUCHER_ID.VisibleIndex = 1;
            // 
            // colDWBH
            // 
            this.colDWBH.Caption = "单位编号";
            this.colDWBH.FieldName = "DWBH";
            this.colDWBH.Name = "colDWBH";
            this.colDWBH.Visible = true;
            this.colDWBH.VisibleIndex = 2;
            // 
            // colVOUCHER_TYPE
            // 
            this.colVOUCHER_TYPE.Caption = "凭证类别";
            this.colVOUCHER_TYPE.FieldName = "VOUCHER_TYPE";
            this.colVOUCHER_TYPE.Name = "colVOUCHER_TYPE";
            this.colVOUCHER_TYPE.Visible = true;
            this.colVOUCHER_TYPE.VisibleIndex = 3;
            // 
            // colFISCAL_YEAR
            // 
            this.colFISCAL_YEAR.Caption = "会计年度";
            this.colFISCAL_YEAR.FieldName = "FISCAL_YEAR";
            this.colFISCAL_YEAR.Name = "colFISCAL_YEAR";
            this.colFISCAL_YEAR.Visible = true;
            this.colFISCAL_YEAR.VisibleIndex = 4;
            // 
            // colACCOUNTING_PERIOD
            // 
            this.colACCOUNTING_PERIOD.Caption = "会计月份";
            this.colACCOUNTING_PERIOD.FieldName = "ACCOUNTING_PERIOD";
            this.colACCOUNTING_PERIOD.Name = "colACCOUNTING_PERIOD";
            this.colACCOUNTING_PERIOD.Visible = true;
            this.colACCOUNTING_PERIOD.VisibleIndex = 5;
            // 
            // colATTACHMENT_NUMBER
            // 
            this.colATTACHMENT_NUMBER.Caption = "附单据数";
            this.colATTACHMENT_NUMBER.FieldName = "ATTACHMENT_NUMBER";
            this.colATTACHMENT_NUMBER.Name = "colATTACHMENT_NUMBER";
            this.colATTACHMENT_NUMBER.Visible = true;
            this.colATTACHMENT_NUMBER.VisibleIndex = 6;
            // 
            // colPREPAREDDATE
            // 
            this.colPREPAREDDATE.Caption = "制单日期";
            this.colPREPAREDDATE.FieldName = "PREPAREDDATE";
            this.colPREPAREDDATE.Name = "colPREPAREDDATE";
            this.colPREPAREDDATE.Visible = true;
            this.colPREPAREDDATE.VisibleIndex = 7;
            // 
            // colZDRXM
            // 
            this.colZDRXM.Caption = "制单人";
            this.colZDRXM.FieldName = "ZDRXM";
            this.colZDRXM.Name = "colZDRXM";
            this.colZDRXM.Visible = true;
            this.colZDRXM.VisibleIndex = 8;
            // 
            // colSHRXM
            // 
            this.colSHRXM.Caption = "审核人";
            this.colSHRXM.FieldName = "SHRXM";
            this.colSHRXM.Name = "colSHRXM";
            this.colSHRXM.Visible = true;
            this.colSHRXM.VisibleIndex = 9;
            // 
            // colJZRXM
            // 
            this.colJZRXM.Caption = "记账人";
            this.colJZRXM.FieldName = "JZRXM";
            this.colJZRXM.Name = "colJZRXM";
            this.colJZRXM.Visible = true;
            this.colJZRXM.VisibleIndex = 10;
            // 
            // colCNXM
            // 
            this.colCNXM.Caption = "出纳";
            this.colCNXM.FieldName = "CNXM";
            this.colCNXM.Name = "colCNXM";
            this.colCNXM.Visible = true;
            this.colCNXM.VisibleIndex = 11;
            // 
            // colPOSTING_DATE
            // 
            this.colPOSTING_DATE.Caption = "记账日期";
            this.colPOSTING_DATE.FieldName = "POSTING_DATE";
            this.colPOSTING_DATE.Name = "colPOSTING_DATE";
            this.colPOSTING_DATE.Visible = true;
            this.colPOSTING_DATE.VisibleIndex = 12;
            // 
            // colCZRQ
            // 
            this.colCZRQ.Caption = "操作日期";
            this.colCZRQ.FieldName = "CZRQ";
            this.colCZRQ.Name = "colCZRQ";
            this.colCZRQ.Visible = true;
            this.colCZRQ.VisibleIndex = 13;
            // 
            // colSIGNATURE
            // 
            this.colSIGNATURE.Caption = "是否签字";
            this.colSIGNATURE.FieldName = "SIGNATURE";
            this.colSIGNATURE.Name = "colSIGNATURE";
            this.colSIGNATURE.Visible = true;
            this.colSIGNATURE.VisibleIndex = 14;
            // 
            // colZT
            // 
            this.colZT.Caption = "状态ID";
            this.colZT.FieldName = "ZT";
            this.colZT.Name = "colZT";
            this.colZT.OptionsFilter.AllowFilter = false;
            // 
            // colORISTATUSMC
            // 
            this.colORISTATUSMC.Caption = "原状态";
            this.colORISTATUSMC.FieldName = "ORISTATUSMC";
            this.colORISTATUSMC.Name = "colORISTATUSMC";
            this.colORISTATUSMC.Visible = true;
            this.colORISTATUSMC.VisibleIndex = 15;
            // 
            // colBZ
            // 
            this.colBZ.Caption = "备注";
            this.colBZ.FieldName = "BZ";
            this.colBZ.Name = "colBZ";
            this.colBZ.Visible = true;
            this.colBZ.VisibleIndex = 16;
            // 
            // colZTMC
            // 
            this.colZTMC.Caption = "账套";
            this.colZTMC.FieldName = "ZTMC";
            this.colZTMC.Name = "colZTMC";
            this.colZTMC.Visible = true;
            this.colZTMC.VisibleIndex = 17;
            // 
            // colENTER
            // 
            this.colENTER.Caption = "制单人ID";
            this.colENTER.FieldName = "ENTER";
            this.colENTER.Name = "colENTER";
            this.colENTER.OptionsFilter.AllowFilter = false;
            // 
            // FrmDeliveryVoucherNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 262);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmDeliveryVoucherNote";
            this.Text = "发货凭证";
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
        private DevExpress.XtraGrid.Columns.GridColumn colSTATUSMC;
        private DevExpress.XtraGrid.Columns.GridColumn colVOUCHERID;
        private DevExpress.XtraGrid.Columns.GridColumn colVOUCHER_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colDWBH;
        private DevExpress.XtraGrid.Columns.GridColumn colVOUCHER_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colFISCAL_YEAR;
        private DevExpress.XtraGrid.Columns.GridColumn colACCOUNTING_PERIOD;
        private DevExpress.XtraGrid.Columns.GridColumn colATTACHMENT_NUMBER;
        private DevExpress.XtraGrid.Columns.GridColumn colPREPAREDDATE;
        private DevExpress.XtraGrid.Columns.GridColumn colZDRXM;
        private DevExpress.XtraGrid.Columns.GridColumn colSHRXM;
        private DevExpress.XtraGrid.Columns.GridColumn colJZRXM;
        private DevExpress.XtraGrid.Columns.GridColumn colCNXM;
        private DevExpress.XtraGrid.Columns.GridColumn colPOSTING_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn colCZRQ;
        private DevExpress.XtraGrid.Columns.GridColumn colZT;
        private DevExpress.XtraGrid.Columns.GridColumn colORISTATUSMC;
        private DevExpress.XtraGrid.Columns.GridColumn colBZ;
        private DevExpress.XtraGrid.Columns.GridColumn colZTMC;
        private DevExpress.XtraBars.BarButtonItem btnMaterQuery;
        private DevExpress.XtraBars.BarButtonItem btnDetailQuery;
        private DevExpress.XtraBars.BarButtonItem btnConfirm;
        private DevExpress.XtraBars.BarButtonItem btnSend;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem btnColCustomize;
        private DevExpress.XtraBars.BarButtonItem btnSaveLayout;
        private DevExpress.XtraBars.BarButtonItem btnLoadLayout;
        private DevExpress.XtraGrid.Columns.GridColumn colENTER;
        private DevExpress.XtraGrid.Columns.GridColumn colSIGNATURE;
    }
}