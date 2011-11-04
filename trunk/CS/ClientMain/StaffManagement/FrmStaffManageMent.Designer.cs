namespace ClientMain
{
    partial class FrmStaffManageMent
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
            this.colOPERATORNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOPERATORNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFASTCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSEX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBIRTHDAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEMAIL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTELEPHONE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMOBILETELEPHONE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOPERATORID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCONTACTADDRESS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDEPARTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBMMC = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.btnQuery.Caption = "查找";
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
            this.barDockControlTop.Size = new System.Drawing.Size(524, 53);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 239);
            this.barDockControlBottom.Size = new System.Drawing.Size(524, 23);
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
            this.barDockControlRight.Location = new System.Drawing.Point(524, 53);
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
            this.gridControl1.Size = new System.Drawing.Size(524, 186);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // xpServerCollectionSource1
            // 
            this.xpServerCollectionSource1.ObjectType = typeof(XINHUA.VIEW_BASE_OPERATOR);
            this.xpServerCollectionSource1.Session = this.unitOfWork1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOPERATORNO,
            this.colOPERATORNAME,
            this.colFASTCODE,
            this.colSEX,
            this.colBIRTHDAY,
            this.colEMAIL,
            this.colTELEPHONE,
            this.colMOBILETELEPHONE,
            this.colOPERATORID,
            this.colCONTACTADDRESS,
            this.colDEPARTID,
            this.colBMMC});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.IndicatorWidth = 50;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsPrint.AutoWidth = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            // 
            // colOPERATORNO
            // 
            this.colOPERATORNO.Caption = "员工编号";
            this.colOPERATORNO.FieldName = "OPERATORNO";
            this.colOPERATORNO.Name = "colOPERATORNO";
            this.colOPERATORNO.Visible = true;
            this.colOPERATORNO.VisibleIndex = 0;
            // 
            // colOPERATORNAME
            // 
            this.colOPERATORNAME.Caption = "员工姓名";
            this.colOPERATORNAME.FieldName = "OPERATORNAME";
            this.colOPERATORNAME.Name = "colOPERATORNAME";
            this.colOPERATORNAME.Visible = true;
            this.colOPERATORNAME.VisibleIndex = 2;
            // 
            // colFASTCODE
            // 
            this.colFASTCODE.Caption = "助记码";
            this.colFASTCODE.FieldName = "FASTCODE";
            this.colFASTCODE.Name = "colFASTCODE";
            this.colFASTCODE.Visible = true;
            this.colFASTCODE.VisibleIndex = 1;
            // 
            // colSEX
            // 
            this.colSEX.Caption = "性别";
            this.colSEX.FieldName = "SEX";
            this.colSEX.Name = "colSEX";
            this.colSEX.Visible = true;
            this.colSEX.VisibleIndex = 3;
            // 
            // colBIRTHDAY
            // 
            this.colBIRTHDAY.Caption = "生日";
            this.colBIRTHDAY.FieldName = "BIRTHDAY";
            this.colBIRTHDAY.Name = "colBIRTHDAY";
            this.colBIRTHDAY.Visible = true;
            this.colBIRTHDAY.VisibleIndex = 4;
            // 
            // colEMAIL
            // 
            this.colEMAIL.Caption = "电子邮件";
            this.colEMAIL.FieldName = "EMAIL";
            this.colEMAIL.Name = "colEMAIL";
            this.colEMAIL.Visible = true;
            this.colEMAIL.VisibleIndex = 5;
            // 
            // colTELEPHONE
            // 
            this.colTELEPHONE.Caption = "电话";
            this.colTELEPHONE.FieldName = "TELEPHONE";
            this.colTELEPHONE.Name = "colTELEPHONE";
            this.colTELEPHONE.Visible = true;
            this.colTELEPHONE.VisibleIndex = 6;
            // 
            // colMOBILETELEPHONE
            // 
            this.colMOBILETELEPHONE.Caption = "移动电话";
            this.colMOBILETELEPHONE.FieldName = "MOBILETELEPHONE";
            this.colMOBILETELEPHONE.Name = "colMOBILETELEPHONE";
            this.colMOBILETELEPHONE.Visible = true;
            this.colMOBILETELEPHONE.VisibleIndex = 7;
            // 
            // colOPERATORID
            // 
            this.colOPERATORID.Caption = "员工ID";
            this.colOPERATORID.FieldName = "OPERATORID";
            this.colOPERATORID.Name = "colOPERATORID";
            this.colOPERATORID.OptionsFilter.AllowFilter = false;
            // 
            // colCONTACTADDRESS
            // 
            this.colCONTACTADDRESS.Caption = "地址";
            this.colCONTACTADDRESS.FieldName = "CONTACTADDRESS";
            this.colCONTACTADDRESS.Name = "colCONTACTADDRESS";
            this.colCONTACTADDRESS.Visible = true;
            this.colCONTACTADDRESS.VisibleIndex = 8;
            // 
            // colDEPARTID
            // 
            this.colDEPARTID.Caption = "部门ID";
            this.colDEPARTID.FieldName = "DEPARTID";
            this.colDEPARTID.Name = "colDEPARTID";
            this.colDEPARTID.OptionsFilter.AllowFilter = false;
            // 
            // colBMMC
            // 
            this.colBMMC.Caption = "部门";
            this.colBMMC.FieldName = "BMMC";
            this.colBMMC.Name = "colBMMC";
            this.colBMMC.Visible = true;
            this.colBMMC.VisibleIndex = 9;
            // 
            // FrmStaffManageMent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 262);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmStaffManageMent";
            this.Text = "员工管理";
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
        private DevExpress.XtraGrid.Columns.GridColumn colFASTCODE;
        private DevExpress.XtraGrid.Columns.GridColumn colSEX;
        private DevExpress.XtraGrid.Columns.GridColumn colBIRTHDAY;
        private DevExpress.XtraGrid.Columns.GridColumn colEMAIL;
        private DevExpress.XtraGrid.Columns.GridColumn colTELEPHONE;
        private DevExpress.XtraGrid.Columns.GridColumn colMOBILETELEPHONE;
        private DevExpress.XtraGrid.Columns.GridColumn colOPERATORNO;
        private DevExpress.XtraGrid.Columns.GridColumn colOPERATORNAME;
        private DevExpress.XtraGrid.Columns.GridColumn colOPERATORID;
        private DevExpress.XtraGrid.Columns.GridColumn colCONTACTADDRESS;
        private DevExpress.XtraGrid.Columns.GridColumn colDEPARTID;
        private DevExpress.XtraGrid.Columns.GridColumn colBMMC;
    }
}