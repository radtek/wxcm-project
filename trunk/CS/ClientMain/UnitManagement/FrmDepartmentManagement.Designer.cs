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
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.xpServerCollectionSource1 = new DevExpress.Xpo.XPServerCollectionSource();
            this.unitOfWork1 = new DevExpress.Xpo.UnitOfWork();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDEPARTMENTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDEPARTMENTNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDESCRIPTION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZTMC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDEPARTMENTNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSFZT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDWSX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKHDNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJCJCNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYTHNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDWJC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKHYH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBMLXID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCBSLXID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGYSLXID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKFLXID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKHLXID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSJDWID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYSBMLXID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYSCLXID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZTID = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.btnDel});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 4;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDel)});
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
            this.xpServerCollectionSource1.ObjectType = typeof(XINHUA.VIEW_SYS_DEPARTMENT);
            this.xpServerCollectionSource1.Session = this.unitOfWork1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDEPARTMENTID,
            this.colDEPARTMENTNAME,
            this.colDESCRIPTION,
            this.colZTMC,
            this.colDEPARTMENTNO,
            this.colSFZT,
            this.colDWSX,
            this.colKHDNO,
            this.colJCJCNO,
            this.colYTHNO,
            this.colDWJC,
            this.colKHYH,
            this.colSH,
            this.colZH,
            this.colDH,
            this.colBMLXID,
            this.colCBSLXID,
            this.colGYSLXID,
            this.colKFLXID,
            this.colKHLXID,
            this.colSJDWID,
            this.colYSBMLXID,
            this.colYSCLXID,
            this.colZTID});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.IndicatorWidth = 50;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsPrint.AutoWidth = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            // 
            // colDEPARTMENTID
            // 
            this.colDEPARTMENTID.Caption = "部门ID";
            this.colDEPARTMENTID.FieldName = "DEPARTMENTID";
            this.colDEPARTMENTID.Name = "colDEPARTMENTID";
            this.colDEPARTMENTID.OptionsFilter.AllowFilter = false;
            // 
            // colDEPARTMENTNAME
            // 
            this.colDEPARTMENTNAME.Caption = "部门名称";
            this.colDEPARTMENTNAME.FieldName = "DEPARTMENTNAME";
            this.colDEPARTMENTNAME.Name = "colDEPARTMENTNAME";
            this.colDEPARTMENTNAME.Visible = true;
            this.colDEPARTMENTNAME.VisibleIndex = 0;
            // 
            // colDESCRIPTION
            // 
            this.colDESCRIPTION.Caption = "描述";
            this.colDESCRIPTION.FieldName = "DESCRIPTION";
            this.colDESCRIPTION.Name = "colDESCRIPTION";
            this.colDESCRIPTION.Visible = true;
            this.colDESCRIPTION.VisibleIndex = 1;
            // 
            // colZTMC
            // 
            this.colZTMC.Caption = "所属账套";
            this.colZTMC.FieldName = "ZTMC";
            this.colZTMC.Name = "colZTMC";
            this.colZTMC.Visible = true;
            this.colZTMC.VisibleIndex = 2;
            // 
            // colDEPARTMENTNO
            // 
            this.colDEPARTMENTNO.Caption = "部门编号";
            this.colDEPARTMENTNO.FieldName = "DEPARTMENTNO";
            this.colDEPARTMENTNO.Name = "colDEPARTMENTNO";
            this.colDEPARTMENTNO.Visible = true;
            this.colDEPARTMENTNO.VisibleIndex = 3;
            // 
            // colSFZT
            // 
            this.colSFZT.Caption = "是否账套";
            this.colSFZT.FieldName = "SFZT";
            this.colSFZT.Name = "colSFZT";
            this.colSFZT.Visible = true;
            this.colSFZT.VisibleIndex = 4;
            // 
            // colDWSX
            // 
            this.colDWSX.Caption = "单位属性";
            this.colDWSX.FieldName = "DWSX";
            this.colDWSX.Name = "colDWSX";
            this.colDWSX.Visible = true;
            this.colDWSX.VisibleIndex = 5;
            // 
            // colKHDNO
            // 
            this.colKHDNO.Caption = "连锁客户端编号";
            this.colKHDNO.FieldName = "KHDNO";
            this.colKHDNO.Name = "colKHDNO";
            this.colKHDNO.Visible = true;
            this.colKHDNO.VisibleIndex = 10;
            // 
            // colJCJCNO
            // 
            this.colJCJCNO.Caption = "基层教材编号";
            this.colJCJCNO.FieldName = "JCJCNO";
            this.colJCJCNO.Name = "colJCJCNO";
            this.colJCJCNO.Visible = true;
            this.colJCJCNO.VisibleIndex = 12;
            // 
            // colYTHNO
            // 
            this.colYTHNO.Caption = "一体化平台编号";
            this.colYTHNO.FieldName = "YTHNO";
            this.colYTHNO.Name = "colYTHNO";
            this.colYTHNO.Visible = true;
            this.colYTHNO.VisibleIndex = 13;
            // 
            // colDWJC
            // 
            this.colDWJC.Caption = "单位简称";
            this.colDWJC.FieldName = "DWJC";
            this.colDWJC.Name = "colDWJC";
            this.colDWJC.Visible = true;
            this.colDWJC.VisibleIndex = 6;
            // 
            // colKHYH
            // 
            this.colKHYH.Caption = "开户银行";
            this.colKHYH.FieldName = "KHYH";
            this.colKHYH.Name = "colKHYH";
            this.colKHYH.Visible = true;
            this.colKHYH.VisibleIndex = 7;
            // 
            // colSH
            // 
            this.colSH.Caption = "税号";
            this.colSH.FieldName = "SH";
            this.colSH.Name = "colSH";
            this.colSH.Visible = true;
            this.colSH.VisibleIndex = 8;
            // 
            // colZH
            // 
            this.colZH.Caption = "账号";
            this.colZH.FieldName = "ZH";
            this.colZH.Name = "colZH";
            this.colZH.Visible = true;
            this.colZH.VisibleIndex = 9;
            // 
            // colDH
            // 
            this.colDH.Caption = "电话";
            this.colDH.FieldName = "DH";
            this.colDH.Name = "colDH";
            this.colDH.Visible = true;
            this.colDH.VisibleIndex = 11;
            // 
            // colBMLXID
            // 
            this.colBMLXID.FieldName = "BMLXID";
            this.colBMLXID.Name = "colBMLXID";
            this.colBMLXID.OptionsFilter.AllowFilter = false;
            // 
            // colCBSLXID
            // 
            this.colCBSLXID.FieldName = "CBSLXID";
            this.colCBSLXID.Name = "colCBSLXID";
            this.colCBSLXID.OptionsFilter.AllowFilter = false;
            // 
            // colGYSLXID
            // 
            this.colGYSLXID.FieldName = "GYSLXID";
            this.colGYSLXID.Name = "colGYSLXID";
            this.colGYSLXID.OptionsFilter.AllowFilter = false;
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
            // colSJDWID
            // 
            this.colSJDWID.FieldName = "SJDWID";
            this.colSJDWID.Name = "colSJDWID";
            this.colSJDWID.OptionsFilter.AllowFilter = false;
            // 
            // colYSBMLXID
            // 
            this.colYSBMLXID.FieldName = "YSBMLXID";
            this.colYSBMLXID.Name = "colYSBMLXID";
            this.colYSBMLXID.OptionsFilter.AllowFilter = false;
            // 
            // colYSCLXID
            // 
            this.colYSCLXID.FieldName = "YSCLXID";
            this.colYSCLXID.Name = "colYSCLXID";
            this.colYSCLXID.OptionsFilter.AllowFilter = false;
            // 
            // colZTID
            // 
            this.colZTID.FieldName = "ZTID";
            this.colZTID.Name = "colZTID";
            this.colZTID.OptionsFilter.AllowFilter = false;
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
        private DevExpress.XtraGrid.Columns.GridColumn colDEPARTMENTID;
        private DevExpress.XtraGrid.Columns.GridColumn colDEPARTMENTNAME;
        private DevExpress.XtraGrid.Columns.GridColumn colDESCRIPTION;
        private DevExpress.XtraGrid.Columns.GridColumn colZTMC;
        private DevExpress.XtraGrid.Columns.GridColumn colDEPARTMENTNO;
        private DevExpress.XtraGrid.Columns.GridColumn colSFZT;
        private DevExpress.XtraGrid.Columns.GridColumn colDWSX;
        private DevExpress.XtraGrid.Columns.GridColumn colKHDNO;
        private DevExpress.XtraGrid.Columns.GridColumn colJCJCNO;
        private DevExpress.XtraGrid.Columns.GridColumn colYTHNO;
        private DevExpress.XtraBars.BarButtonItem btnQuery;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnUpdate;
        private DevExpress.XtraBars.BarButtonItem btnDel;
        private DevExpress.XtraGrid.Columns.GridColumn colDWJC;
        private DevExpress.XtraGrid.Columns.GridColumn colKHYH;
        private DevExpress.XtraGrid.Columns.GridColumn colSH;
        private DevExpress.XtraGrid.Columns.GridColumn colZH;
        private DevExpress.XtraGrid.Columns.GridColumn colDH;
        private DevExpress.XtraGrid.Columns.GridColumn colBMLXID;
        private DevExpress.XtraGrid.Columns.GridColumn colCBSLXID;
        private DevExpress.XtraGrid.Columns.GridColumn colGYSLXID;
        private DevExpress.XtraGrid.Columns.GridColumn colKFLXID;
        private DevExpress.XtraGrid.Columns.GridColumn colKHLXID;
        private DevExpress.XtraGrid.Columns.GridColumn colSJDWID;
        private DevExpress.XtraGrid.Columns.GridColumn colYSBMLXID;
        private DevExpress.XtraGrid.Columns.GridColumn colYSCLXID;
        private DevExpress.XtraGrid.Columns.GridColumn colZTID;
    }
}