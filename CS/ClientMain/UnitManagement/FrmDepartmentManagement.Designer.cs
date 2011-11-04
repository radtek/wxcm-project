namespace ClientMain
{
    partial class FrmDepartmentManagement
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
            this.btnQuery = new DevExpress.XtraBars.BarButtonItem();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.btnDel = new DevExpress.XtraBars.BarButtonItem();
            this.btnEnable = new DevExpress.XtraBars.BarButtonItem();
            this.btnDisable = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.xpServerCollectionSource1 = new DevExpress.Xpo.XPServerCollectionSource();
            this.unitOfWork1 = new DevExpress.Xpo.UnitOfWork();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDWID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDWBH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDWMC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDWJC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZJM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCZRQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCJR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTYR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCBSLXMC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDWSXMC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGYSLXMC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKHLXMC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBMLXID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBMZTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCBSLXID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCGJSYXJB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCGYXJB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDJSDBZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDQID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDWFR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDWJB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDWSX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDWTJBH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEMAIL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEZDBH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGYSLXID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJSDWID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJSFSID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJTYXJB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKFDZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKFLXID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKHLXID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKHYH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKHZZBZFBZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKHZZQTFYBZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKHZZYFBZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKJDZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLXR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMJDZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHYXJB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDSX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDXX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSFID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSFZT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHDZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSJDWID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTDYZS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTSJSDBZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTSJSZQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTSSX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTSXX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTXDZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWEBMM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWEBYH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXSJSYXJB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXTYXJB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYINSDWLXID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYSDWLXID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYSFSID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYSFXID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZKSX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZKXX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYZBM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYZDBH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZZDBZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGZLID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCGJSZQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCWXTID = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.btnQuery,
            this.btnAdd,
            this.btnUpdate,
            this.btnDel,
            this.btnEnable,
            this.btnDisable});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnQuery),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnUpdate),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDel),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEnable),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDisable)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnQuery
            // 
            this.btnQuery.Caption = "查询";
            this.btnQuery.Id = 0;
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQuery_ItemClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Caption = "增加";
            this.btnAdd.Id = 1;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdd_ItemClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Caption = "修改";
            this.btnUpdate.Id = 2;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUpdate_ItemClick);
            // 
            // btnDel
            // 
            this.btnDel.Caption = "删除";
            this.btnDel.Id = 3;
            this.btnDel.Name = "btnDel";
            this.btnDel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDel_ItemClick);
            // 
            // btnEnable
            // 
            this.btnEnable.Caption = "启用";
            this.btnEnable.Id = 4;
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEnable_ItemClick);
            // 
            // btnDisable
            // 
            this.btnDisable.Caption = "停用";
            this.btnDisable.Id = 5;
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDisable_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(490, 53);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 239);
            this.barDockControlBottom.Size = new System.Drawing.Size(490, 23);
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
            this.barDockControlRight.Location = new System.Drawing.Point(490, 53);
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
            this.gridControl1.Size = new System.Drawing.Size(490, 186);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // xpServerCollectionSource1
            // 
            this.xpServerCollectionSource1.ObjectType = typeof(XINHUA.VIEW_JT_J_DWXX);
            this.xpServerCollectionSource1.Session = this.unitOfWork1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDWID,
            this.colDWBH,
            this.colDWMC,
            this.colDWJC,
            this.colZJM,
            this.colZT,
            this.colCZRQ,
            this.colCJR,
            this.colTYR,
            this.colCBSLXMC,
            this.colDWSXMC,
            this.colGYSLXMC,
            this.colKHLXMC,
            this.colBMLXID,
            this.colBMZTID,
            this.colBZ,
            this.colCBSLXID,
            this.colCGJSYXJB,
            this.colCGYXJB,
            this.colCZ,
            this.colDH,
            this.colDJSDBZ,
            this.colDQID,
            this.colDWFR,
            this.colDWJB,
            this.colDWSX,
            this.colDWTJBH,
            this.colEMAIL,
            this.colEZDBH,
            this.colGYSLXID,
            this.colJSDWID,
            this.colJSFSID,
            this.colJTYXJB,
            this.colKFDZ,
            this.colKFLXID,
            this.colKHLXID,
            this.colKHYH,
            this.colKHZZBZFBZ,
            this.colKHZZQTFYBZ,
            this.colKHZZYFBZ,
            this.colKJDZ,
            this.colLXR,
            this.colMJDZ,
            this.colPHYXJB,
            this.colSDSX,
            this.colSDXX,
            this.colSFID,
            this.colSFZT,
            this.colSH,
            this.colSHDZ,
            this.colSJDWID,
            this.colTDYZS,
            this.colTSJSDBZ,
            this.colTSJSZQ,
            this.colTSSX,
            this.colTSXX,
            this.colTXDZ,
            this.colWEBMM,
            this.colWEBYH,
            this.colWZ,
            this.colXSJSYXJB,
            this.colXTYXJB,
            this.colYINSDWLXID,
            this.colYSDWLXID,
            this.colYSFSID,
            this.colYSFXID,
            this.colZKSX,
            this.colZKXX,
            this.colZH,
            this.colYZBM,
            this.colYZDBH,
            this.colZZDBZ,
            this.colGZLID,
            this.colCGJSZQ,
            this.colCWXTID});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.IndicatorWidth = 50;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsPrint.AutoWidth = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            // 
            // colDWID
            // 
            this.colDWID.Caption = "单位ID";
            this.colDWID.FieldName = "DWID";
            this.colDWID.Name = "colDWID";
            this.colDWID.OptionsFilter.AllowFilter = false;
            this.colDWID.Visible = true;
            this.colDWID.VisibleIndex = 0;
            // 
            // colDWBH
            // 
            this.colDWBH.Caption = "单位编号";
            this.colDWBH.FieldName = "DWBH";
            this.colDWBH.Name = "colDWBH";
            this.colDWBH.Visible = true;
            this.colDWBH.VisibleIndex = 1;
            // 
            // colDWMC
            // 
            this.colDWMC.Caption = "单位名称";
            this.colDWMC.FieldName = "DWMC";
            this.colDWMC.Name = "colDWMC";
            this.colDWMC.Visible = true;
            this.colDWMC.VisibleIndex = 2;
            // 
            // colDWJC
            // 
            this.colDWJC.Caption = "单位简称";
            this.colDWJC.FieldName = "DWJC";
            this.colDWJC.Name = "colDWJC";
            this.colDWJC.Visible = true;
            this.colDWJC.VisibleIndex = 3;
            // 
            // colZJM
            // 
            this.colZJM.Caption = "助记码";
            this.colZJM.FieldName = "ZJM";
            this.colZJM.Name = "colZJM";
            this.colZJM.Visible = true;
            this.colZJM.VisibleIndex = 4;
            // 
            // colZT
            // 
            this.colZT.Caption = "状态";
            this.colZT.FieldName = "ZT";
            this.colZT.Name = "colZT";
            this.colZT.Visible = true;
            this.colZT.VisibleIndex = 5;
            // 
            // colCZRQ
            // 
            this.colCZRQ.Caption = "操作日期";
            this.colCZRQ.FieldName = "CZRQ";
            this.colCZRQ.Name = "colCZRQ";
            this.colCZRQ.OptionsFilter.AllowFilter = false;
            this.colCZRQ.Visible = true;
            this.colCZRQ.VisibleIndex = 6;
            // 
            // colCJR
            // 
            this.colCJR.Caption = "创建人";
            this.colCJR.FieldName = "CJR";
            this.colCJR.Name = "colCJR";
            this.colCJR.OptionsFilter.AllowFilter = false;
            this.colCJR.Visible = true;
            this.colCJR.VisibleIndex = 7;
            // 
            // colTYR
            // 
            this.colTYR.Caption = "停用人";
            this.colTYR.FieldName = "TYR";
            this.colTYR.Name = "colTYR";
            this.colTYR.OptionsFilter.AllowFilter = false;
            this.colTYR.Visible = true;
            this.colTYR.VisibleIndex = 8;
            // 
            // colCBSLXMC
            // 
            this.colCBSLXMC.Caption = "客户类型";
            this.colCBSLXMC.FieldName = "CBSLXMC";
            this.colCBSLXMC.Name = "colCBSLXMC";
            // 
            // colDWSXMC
            // 
            this.colDWSXMC.Caption = "单位属性";
            this.colDWSXMC.FieldName = "DWSXMC";
            this.colDWSXMC.Name = "colDWSXMC";
            // 
            // colGYSLXMC
            // 
            this.colGYSLXMC.Caption = "供应商类型";
            this.colGYSLXMC.FieldName = "GYSLXMC";
            this.colGYSLXMC.Name = "colGYSLXMC";
            // 
            // colKHLXMC
            // 
            this.colKHLXMC.Caption = "客户类型";
            this.colKHLXMC.FieldName = "KHLXMC";
            this.colKHLXMC.Name = "colKHLXMC";
            // 
            // colBMLXID
            // 
            this.colBMLXID.FieldName = "BMLXID";
            this.colBMLXID.Name = "colBMLXID";
            this.colBMLXID.OptionsFilter.AllowFilter = false;
            // 
            // colBMZTID
            // 
            this.colBMZTID.FieldName = "BMZTID";
            this.colBMZTID.Name = "colBMZTID";
            this.colBMZTID.OptionsFilter.AllowFilter = false;
            // 
            // colBZ
            // 
            this.colBZ.FieldName = "BZ";
            this.colBZ.Name = "colBZ";
            this.colBZ.OptionsFilter.AllowFilter = false;
            // 
            // colCBSLXID
            // 
            this.colCBSLXID.FieldName = "CBSLXID";
            this.colCBSLXID.Name = "colCBSLXID";
            this.colCBSLXID.OptionsFilter.AllowFilter = false;
            // 
            // colCGJSYXJB
            // 
            this.colCGJSYXJB.FieldName = "CGJSYXJB";
            this.colCGJSYXJB.Name = "colCGJSYXJB";
            this.colCGJSYXJB.OptionsFilter.AllowFilter = false;
            // 
            // colCGYXJB
            // 
            this.colCGYXJB.FieldName = "CGYXJB";
            this.colCGYXJB.Name = "colCGYXJB";
            this.colCGYXJB.OptionsFilter.AllowFilter = false;
            // 
            // colCZ
            // 
            this.colCZ.FieldName = "CZ";
            this.colCZ.Name = "colCZ";
            this.colCZ.OptionsFilter.AllowFilter = false;
            // 
            // colDH
            // 
            this.colDH.FieldName = "DH";
            this.colDH.Name = "colDH";
            this.colDH.OptionsFilter.AllowFilter = false;
            // 
            // colDJSDBZ
            // 
            this.colDJSDBZ.FieldName = "DJSDBZ";
            this.colDJSDBZ.Name = "colDJSDBZ";
            this.colDJSDBZ.OptionsFilter.AllowFilter = false;
            // 
            // colDQID
            // 
            this.colDQID.FieldName = "DQID";
            this.colDQID.Name = "colDQID";
            this.colDQID.OptionsFilter.AllowFilter = false;
            // 
            // colDWFR
            // 
            this.colDWFR.FieldName = "DWFR";
            this.colDWFR.Name = "colDWFR";
            this.colDWFR.OptionsFilter.AllowFilter = false;
            // 
            // colDWJB
            // 
            this.colDWJB.FieldName = "DWJB";
            this.colDWJB.Name = "colDWJB";
            this.colDWJB.OptionsFilter.AllowFilter = false;
            // 
            // colDWSX
            // 
            this.colDWSX.FieldName = "DWSX";
            this.colDWSX.Name = "colDWSX";
            this.colDWSX.OptionsFilter.AllowFilter = false;
            // 
            // colDWTJBH
            // 
            this.colDWTJBH.FieldName = "DWTJBH";
            this.colDWTJBH.Name = "colDWTJBH";
            this.colDWTJBH.OptionsFilter.AllowFilter = false;
            // 
            // colEMAIL
            // 
            this.colEMAIL.FieldName = "EMAIL";
            this.colEMAIL.Name = "colEMAIL";
            this.colEMAIL.OptionsFilter.AllowFilter = false;
            // 
            // colEZDBH
            // 
            this.colEZDBH.FieldName = "EZDBH";
            this.colEZDBH.Name = "colEZDBH";
            this.colEZDBH.OptionsFilter.AllowFilter = false;
            // 
            // colGYSLXID
            // 
            this.colGYSLXID.FieldName = "GYSLXID";
            this.colGYSLXID.Name = "colGYSLXID";
            this.colGYSLXID.OptionsFilter.AllowFilter = false;
            // 
            // colJSDWID
            // 
            this.colJSDWID.FieldName = "JSDWID";
            this.colJSDWID.Name = "colJSDWID";
            this.colJSDWID.OptionsFilter.AllowFilter = false;
            // 
            // colJSFSID
            // 
            this.colJSFSID.FieldName = "JSFSID";
            this.colJSFSID.Name = "colJSFSID";
            this.colJSFSID.OptionsFilter.AllowFilter = false;
            // 
            // colJTYXJB
            // 
            this.colJTYXJB.FieldName = "JTYXJB";
            this.colJTYXJB.Name = "colJTYXJB";
            this.colJTYXJB.OptionsFilter.AllowFilter = false;
            // 
            // colKFDZ
            // 
            this.colKFDZ.FieldName = "KFDZ";
            this.colKFDZ.Name = "colKFDZ";
            this.colKFDZ.OptionsFilter.AllowFilter = false;
            // 
            // colKFLXID
            // 
            this.colKFLXID.FieldName = "KFLXID";
            this.colKFLXID.Name = "colKFLXID";
            this.colKFLXID.OptionsFilter.AllowFilter = false;
            // 
            // colKHLXID
            // 
            this.colKHLXID.FieldName = "KHLXID";
            this.colKHLXID.Name = "colKHLXID";
            this.colKHLXID.OptionsFilter.AllowFilter = false;
            // 
            // colKHYH
            // 
            this.colKHYH.FieldName = "KHYH";
            this.colKHYH.Name = "colKHYH";
            this.colKHYH.OptionsFilter.AllowFilter = false;
            // 
            // colKHZZBZFBZ
            // 
            this.colKHZZBZFBZ.FieldName = "KHZZBZFBZ";
            this.colKHZZBZFBZ.Name = "colKHZZBZFBZ";
            this.colKHZZBZFBZ.OptionsFilter.AllowFilter = false;
            // 
            // colKHZZQTFYBZ
            // 
            this.colKHZZQTFYBZ.FieldName = "KHZZQTFYBZ";
            this.colKHZZQTFYBZ.Name = "colKHZZQTFYBZ";
            this.colKHZZQTFYBZ.OptionsFilter.AllowFilter = false;
            // 
            // colKHZZYFBZ
            // 
            this.colKHZZYFBZ.FieldName = "KHZZYFBZ";
            this.colKHZZYFBZ.Name = "colKHZZYFBZ";
            this.colKHZZYFBZ.OptionsFilter.AllowFilter = false;
            // 
            // colKJDZ
            // 
            this.colKJDZ.FieldName = "KJDZ";
            this.colKJDZ.Name = "colKJDZ";
            this.colKJDZ.OptionsFilter.AllowFilter = false;
            // 
            // colLXR
            // 
            this.colLXR.FieldName = "LXR";
            this.colLXR.Name = "colLXR";
            this.colLXR.OptionsFilter.AllowFilter = false;
            // 
            // colMJDZ
            // 
            this.colMJDZ.FieldName = "MJDZ";
            this.colMJDZ.Name = "colMJDZ";
            this.colMJDZ.OptionsFilter.AllowFilter = false;
            // 
            // colPHYXJB
            // 
            this.colPHYXJB.FieldName = "PHYXJB";
            this.colPHYXJB.Name = "colPHYXJB";
            this.colPHYXJB.OptionsFilter.AllowFilter = false;
            // 
            // colSDSX
            // 
            this.colSDSX.FieldName = "SDSX";
            this.colSDSX.Name = "colSDSX";
            this.colSDSX.OptionsFilter.AllowFilter = false;
            // 
            // colSDXX
            // 
            this.colSDXX.FieldName = "SDXX";
            this.colSDXX.Name = "colSDXX";
            this.colSDXX.OptionsFilter.AllowFilter = false;
            // 
            // colSFID
            // 
            this.colSFID.FieldName = "SFID";
            this.colSFID.Name = "colSFID";
            this.colSFID.OptionsFilter.AllowFilter = false;
            // 
            // colSFZT
            // 
            this.colSFZT.FieldName = "SFZT";
            this.colSFZT.Name = "colSFZT";
            this.colSFZT.OptionsFilter.AllowFilter = false;
            // 
            // colSH
            // 
            this.colSH.FieldName = "SH";
            this.colSH.Name = "colSH";
            this.colSH.OptionsFilter.AllowFilter = false;
            // 
            // colSHDZ
            // 
            this.colSHDZ.FieldName = "SHDZ";
            this.colSHDZ.Name = "colSHDZ";
            this.colSHDZ.OptionsFilter.AllowFilter = false;
            // 
            // colSJDWID
            // 
            this.colSJDWID.FieldName = "SJDWID";
            this.colSJDWID.Name = "colSJDWID";
            this.colSJDWID.OptionsFilter.AllowFilter = false;
            // 
            // colTDYZS
            // 
            this.colTDYZS.FieldName = "TDYZS";
            this.colTDYZS.Name = "colTDYZS";
            this.colTDYZS.OptionsFilter.AllowFilter = false;
            // 
            // colTSJSDBZ
            // 
            this.colTSJSDBZ.FieldName = "TSJSDBZ";
            this.colTSJSDBZ.Name = "colTSJSDBZ";
            this.colTSJSDBZ.OptionsFilter.AllowFilter = false;
            // 
            // colTSJSZQ
            // 
            this.colTSJSZQ.FieldName = "TSJSZQ";
            this.colTSJSZQ.Name = "colTSJSZQ";
            this.colTSJSZQ.OptionsFilter.AllowFilter = false;
            // 
            // colTSSX
            // 
            this.colTSSX.FieldName = "TSSX";
            this.colTSSX.Name = "colTSSX";
            this.colTSSX.OptionsFilter.AllowFilter = false;
            // 
            // colTSXX
            // 
            this.colTSXX.FieldName = "TSXX";
            this.colTSXX.Name = "colTSXX";
            this.colTSXX.OptionsFilter.AllowFilter = false;
            // 
            // colTXDZ
            // 
            this.colTXDZ.FieldName = "TXDZ";
            this.colTXDZ.Name = "colTXDZ";
            this.colTXDZ.OptionsFilter.AllowFilter = false;
            // 
            // colWEBMM
            // 
            this.colWEBMM.FieldName = "WEBMM";
            this.colWEBMM.Name = "colWEBMM";
            this.colWEBMM.OptionsFilter.AllowFilter = false;
            // 
            // colWEBYH
            // 
            this.colWEBYH.FieldName = "WEBYH";
            this.colWEBYH.Name = "colWEBYH";
            this.colWEBYH.OptionsFilter.AllowFilter = false;
            // 
            // colWZ
            // 
            this.colWZ.FieldName = "WZ";
            this.colWZ.Name = "colWZ";
            this.colWZ.OptionsFilter.AllowFilter = false;
            // 
            // colXSJSYXJB
            // 
            this.colXSJSYXJB.FieldName = "XSJSYXJB";
            this.colXSJSYXJB.Name = "colXSJSYXJB";
            this.colXSJSYXJB.OptionsFilter.AllowFilter = false;
            // 
            // colXTYXJB
            // 
            this.colXTYXJB.FieldName = "XTYXJB";
            this.colXTYXJB.Name = "colXTYXJB";
            this.colXTYXJB.OptionsFilter.AllowFilter = false;
            // 
            // colYINSDWLXID
            // 
            this.colYINSDWLXID.FieldName = "YINSDWLXID";
            this.colYINSDWLXID.Name = "colYINSDWLXID";
            this.colYINSDWLXID.OptionsFilter.AllowFilter = false;
            // 
            // colYSDWLXID
            // 
            this.colYSDWLXID.FieldName = "YSDWLXID";
            this.colYSDWLXID.Name = "colYSDWLXID";
            this.colYSDWLXID.OptionsFilter.AllowFilter = false;
            // 
            // colYSFSID
            // 
            this.colYSFSID.FieldName = "YSFSID";
            this.colYSFSID.Name = "colYSFSID";
            this.colYSFSID.OptionsFilter.AllowFilter = false;
            // 
            // colYSFXID
            // 
            this.colYSFXID.FieldName = "YSFXID";
            this.colYSFXID.Name = "colYSFXID";
            this.colYSFXID.OptionsFilter.AllowFilter = false;
            // 
            // colZKSX
            // 
            this.colZKSX.FieldName = "ZKSX";
            this.colZKSX.Name = "colZKSX";
            this.colZKSX.OptionsFilter.AllowFilter = false;
            // 
            // colZKXX
            // 
            this.colZKXX.FieldName = "ZKXX";
            this.colZKXX.Name = "colZKXX";
            this.colZKXX.OptionsFilter.AllowFilter = false;
            // 
            // colZH
            // 
            this.colZH.FieldName = "ZH";
            this.colZH.Name = "colZH";
            this.colZH.OptionsFilter.AllowFilter = false;
            // 
            // colYZBM
            // 
            this.colYZBM.FieldName = "YZBM";
            this.colYZBM.Name = "colYZBM";
            this.colYZBM.OptionsFilter.AllowFilter = false;
            // 
            // colYZDBH
            // 
            this.colYZDBH.FieldName = "YZDBH";
            this.colYZDBH.Name = "colYZDBH";
            this.colYZDBH.OptionsFilter.AllowFilter = false;
            // 
            // colZZDBZ
            // 
            this.colZZDBZ.FieldName = "ZZDBZ";
            this.colZZDBZ.Name = "colZZDBZ";
            this.colZZDBZ.OptionsFilter.AllowFilter = false;
            // 
            // colGZLID
            // 
            this.colGZLID.FieldName = "GZLID";
            this.colGZLID.Name = "colGZLID";
            this.colGZLID.OptionsFilter.AllowFilter = false;
            // 
            // colCGJSZQ
            // 
            this.colCGJSZQ.FieldName = "CGJSZQ";
            this.colCGJSZQ.Name = "colCGJSZQ";
            this.colCGJSZQ.OptionsFilter.AllowFilter = false;
            // 
            // colCWXTID
            // 
            this.colCWXTID.FieldName = "CWXTID";
            this.colCWXTID.Name = "colCWXTID";
            this.colCWXTID.OptionsFilter.AllowFilter = false;
            // 
            // FrmDepartmentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 262);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmDepartmentManagement";
            this.Text = "单位管理";
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
        private DevExpress.Xpo.UnitOfWork unitOfWork1;
        private DevExpress.Xpo.XPServerCollectionSource xpServerCollectionSource1;
        private DevExpress.XtraBars.BarButtonItem btnQuery;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnUpdate;
        private DevExpress.XtraBars.BarButtonItem btnDel;
        private DevExpress.XtraBars.BarButtonItem btnEnable;
        private DevExpress.XtraBars.BarButtonItem btnDisable;
        private DevExpress.XtraGrid.Columns.GridColumn colDWID;
        private DevExpress.XtraGrid.Columns.GridColumn colDWBH;
        private DevExpress.XtraGrid.Columns.GridColumn colDWMC;
        private DevExpress.XtraGrid.Columns.GridColumn colDWJC;
        private DevExpress.XtraGrid.Columns.GridColumn colZJM;
        private DevExpress.XtraGrid.Columns.GridColumn colZT;
        private DevExpress.XtraGrid.Columns.GridColumn colCZRQ;
        private DevExpress.XtraGrid.Columns.GridColumn colCJR;
        private DevExpress.XtraGrid.Columns.GridColumn colTYR;
        private DevExpress.XtraGrid.Columns.GridColumn colCBSLXMC;
        private DevExpress.XtraGrid.Columns.GridColumn colDWSXMC;
        private DevExpress.XtraGrid.Columns.GridColumn colGYSLXMC;
        private DevExpress.XtraGrid.Columns.GridColumn colKHLXMC;
        private DevExpress.XtraGrid.Columns.GridColumn colBMLXID;
        private DevExpress.XtraGrid.Columns.GridColumn colBMZTID;
        private DevExpress.XtraGrid.Columns.GridColumn colBZ;
        private DevExpress.XtraGrid.Columns.GridColumn colCBSLXID;
        private DevExpress.XtraGrid.Columns.GridColumn colCGJSYXJB;
        private DevExpress.XtraGrid.Columns.GridColumn colCGYXJB;
        private DevExpress.XtraGrid.Columns.GridColumn colCZ;
        private DevExpress.XtraGrid.Columns.GridColumn colDH;
        private DevExpress.XtraGrid.Columns.GridColumn colDJSDBZ;
        private DevExpress.XtraGrid.Columns.GridColumn colDQID;
        private DevExpress.XtraGrid.Columns.GridColumn colDWFR;
        private DevExpress.XtraGrid.Columns.GridColumn colDWJB;
        private DevExpress.XtraGrid.Columns.GridColumn colDWSX;
        private DevExpress.XtraGrid.Columns.GridColumn colDWTJBH;
        private DevExpress.XtraGrid.Columns.GridColumn colEMAIL;
        private DevExpress.XtraGrid.Columns.GridColumn colEZDBH;
        private DevExpress.XtraGrid.Columns.GridColumn colGYSLXID;
        private DevExpress.XtraGrid.Columns.GridColumn colJSDWID;
        private DevExpress.XtraGrid.Columns.GridColumn colJSFSID;
        private DevExpress.XtraGrid.Columns.GridColumn colJTYXJB;
        private DevExpress.XtraGrid.Columns.GridColumn colKFDZ;
        private DevExpress.XtraGrid.Columns.GridColumn colKFLXID;
        private DevExpress.XtraGrid.Columns.GridColumn colKHLXID;
        private DevExpress.XtraGrid.Columns.GridColumn colKHYH;
        private DevExpress.XtraGrid.Columns.GridColumn colKHZZBZFBZ;
        private DevExpress.XtraGrid.Columns.GridColumn colKHZZQTFYBZ;
        private DevExpress.XtraGrid.Columns.GridColumn colKHZZYFBZ;
        private DevExpress.XtraGrid.Columns.GridColumn colKJDZ;
        private DevExpress.XtraGrid.Columns.GridColumn colLXR;
        private DevExpress.XtraGrid.Columns.GridColumn colMJDZ;
        private DevExpress.XtraGrid.Columns.GridColumn colPHYXJB;
        private DevExpress.XtraGrid.Columns.GridColumn colSDSX;
        private DevExpress.XtraGrid.Columns.GridColumn colSDXX;
        private DevExpress.XtraGrid.Columns.GridColumn colSFID;
        private DevExpress.XtraGrid.Columns.GridColumn colSFZT;
        private DevExpress.XtraGrid.Columns.GridColumn colSH;
        private DevExpress.XtraGrid.Columns.GridColumn colSHDZ;
        private DevExpress.XtraGrid.Columns.GridColumn colSJDWID;
        private DevExpress.XtraGrid.Columns.GridColumn colTDYZS;
        private DevExpress.XtraGrid.Columns.GridColumn colTSJSDBZ;
        private DevExpress.XtraGrid.Columns.GridColumn colTSJSZQ;
        private DevExpress.XtraGrid.Columns.GridColumn colTSSX;
        private DevExpress.XtraGrid.Columns.GridColumn colTSXX;
        private DevExpress.XtraGrid.Columns.GridColumn colTXDZ;
        private DevExpress.XtraGrid.Columns.GridColumn colWEBMM;
        private DevExpress.XtraGrid.Columns.GridColumn colWEBYH;
        private DevExpress.XtraGrid.Columns.GridColumn colWZ;
        private DevExpress.XtraGrid.Columns.GridColumn colXSJSYXJB;
        private DevExpress.XtraGrid.Columns.GridColumn colXTYXJB;
        private DevExpress.XtraGrid.Columns.GridColumn colYINSDWLXID;
        private DevExpress.XtraGrid.Columns.GridColumn colYSDWLXID;
        private DevExpress.XtraGrid.Columns.GridColumn colYSFSID;
        private DevExpress.XtraGrid.Columns.GridColumn colYSFXID;
        private DevExpress.XtraGrid.Columns.GridColumn colZKSX;
        private DevExpress.XtraGrid.Columns.GridColumn colZKXX;
        private DevExpress.XtraGrid.Columns.GridColumn colZH;
        private DevExpress.XtraGrid.Columns.GridColumn colYZBM;
        private DevExpress.XtraGrid.Columns.GridColumn colYZDBH;
        private DevExpress.XtraGrid.Columns.GridColumn colZZDBZ;
        private DevExpress.XtraGrid.Columns.GridColumn colGZLID;
        private DevExpress.XtraGrid.Columns.GridColumn colCGJSZQ;
        private DevExpress.XtraGrid.Columns.GridColumn colCWXTID;
    }
}