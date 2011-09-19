namespace ClientMain
{
    partial class FrmLossVoucherDetail
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
            this.colENTRY_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKMMC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVOUCHERID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colABSTRACT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDOCUMENT_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDEBIT_QUANTITY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPRIMARY_DEBIT_AMOUNT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCREDIT_QUANTITY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPRIMARY_CREDIT_AMOUNT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAUXILIARY_ACCOUNTING_ITEM1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAUXILIARY_ACCOUNTING_ITEM2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAUXILIARY_ACCOUNTING_ITEM3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAUXILIARY_ACCOUNTING_ITEM4 = new DevExpress.XtraGrid.Columns.GridColumn();
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDetailQuery),
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
            this.barDockControlTop.Size = new System.Drawing.Size(499, 53);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 239);
            this.barDockControlBottom.Size = new System.Drawing.Size(499, 23);
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
            this.barDockControlRight.Location = new System.Drawing.Point(499, 53);
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
            this.gridControl1.Size = new System.Drawing.Size(499, 186);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // xpServerCollectionSource1
            // 
            this.xpServerCollectionSource1.ObjectType = typeof(XINHUA.VIEW_JT_C_BFPZMX);
            this.xpServerCollectionSource1.Session = this.unitOfWork1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colENTRY_ID,
            this.colKMMC,
            this.colVOUCHERID,
            this.colABSTRACT,
            this.colDOCUMENT_DATE,
            this.colDEBIT_QUANTITY,
            this.colPRIMARY_DEBIT_AMOUNT,
            this.colCREDIT_QUANTITY,
            this.colPRIMARY_CREDIT_AMOUNT,
            this.colAUXILIARY_ACCOUNTING_ITEM1,
            this.colAUXILIARY_ACCOUNTING_ITEM2,
            this.colAUXILIARY_ACCOUNTING_ITEM3,
            this.colAUXILIARY_ACCOUNTING_ITEM4});
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
            // colENTRY_ID
            // 
            this.colENTRY_ID.Caption = "分录号";
            this.colENTRY_ID.FieldName = "ENTRY_ID";
            this.colENTRY_ID.Name = "colENTRY_ID";
            this.colENTRY_ID.Visible = true;
            this.colENTRY_ID.VisibleIndex = 0;
            // 
            // colKMMC
            // 
            this.colKMMC.Caption = "科目";
            this.colKMMC.FieldName = "KMMC";
            this.colKMMC.Name = "colKMMC";
            this.colKMMC.Visible = true;
            this.colKMMC.VisibleIndex = 1;
            // 
            // colVOUCHERID
            // 
            this.colVOUCHERID.Caption = "凭证ID";
            this.colVOUCHERID.FieldName = "VOUCHERID";
            this.colVOUCHERID.Name = "colVOUCHERID";
            this.colVOUCHERID.OptionsFilter.AllowFilter = false;
            // 
            // colABSTRACT
            // 
            this.colABSTRACT.Caption = "摘要";
            this.colABSTRACT.FieldName = "ABSTRACT";
            this.colABSTRACT.Name = "colABSTRACT";
            this.colABSTRACT.Visible = true;
            this.colABSTRACT.VisibleIndex = 2;
            // 
            // colDOCUMENT_DATE
            // 
            this.colDOCUMENT_DATE.Caption = "票据日期";
            this.colDOCUMENT_DATE.FieldName = "DOCUMENT_DATE";
            this.colDOCUMENT_DATE.Name = "colDOCUMENT_DATE";
            this.colDOCUMENT_DATE.Visible = true;
            this.colDOCUMENT_DATE.VisibleIndex = 3;
            // 
            // colDEBIT_QUANTITY
            // 
            this.colDEBIT_QUANTITY.Caption = "借方数量";
            this.colDEBIT_QUANTITY.FieldName = "DEBIT_QUANTITY";
            this.colDEBIT_QUANTITY.Name = "colDEBIT_QUANTITY";
            this.colDEBIT_QUANTITY.Visible = true;
            this.colDEBIT_QUANTITY.VisibleIndex = 4;
            // 
            // colPRIMARY_DEBIT_AMOUNT
            // 
            this.colPRIMARY_DEBIT_AMOUNT.Caption = "原币借方发生额";
            this.colPRIMARY_DEBIT_AMOUNT.FieldName = "PRIMARY_DEBIT_AMOUNT";
            this.colPRIMARY_DEBIT_AMOUNT.Name = "colPRIMARY_DEBIT_AMOUNT";
            this.colPRIMARY_DEBIT_AMOUNT.Visible = true;
            this.colPRIMARY_DEBIT_AMOUNT.VisibleIndex = 5;
            // 
            // colCREDIT_QUANTITY
            // 
            this.colCREDIT_QUANTITY.Caption = "贷方数据";
            this.colCREDIT_QUANTITY.FieldName = "CREDIT_QUANTITY";
            this.colCREDIT_QUANTITY.Name = "colCREDIT_QUANTITY";
            this.colCREDIT_QUANTITY.Visible = true;
            this.colCREDIT_QUANTITY.VisibleIndex = 6;
            // 
            // colPRIMARY_CREDIT_AMOUNT
            // 
            this.colPRIMARY_CREDIT_AMOUNT.Caption = "原币贷方发生额";
            this.colPRIMARY_CREDIT_AMOUNT.FieldName = "PRIMARY_CREDIT_AMOUNT";
            this.colPRIMARY_CREDIT_AMOUNT.Name = "colPRIMARY_CREDIT_AMOUNT";
            this.colPRIMARY_CREDIT_AMOUNT.Visible = true;
            this.colPRIMARY_CREDIT_AMOUNT.VisibleIndex = 7;
            // 
            // colAUXILIARY_ACCOUNTING_ITEM1
            // 
            this.colAUXILIARY_ACCOUNTING_ITEM1.Caption = "部门";
            this.colAUXILIARY_ACCOUNTING_ITEM1.FieldName = "AUXILIARY_ACCOUNTING_ITEM1";
            this.colAUXILIARY_ACCOUNTING_ITEM1.Name = "colAUXILIARY_ACCOUNTING_ITEM1";
            this.colAUXILIARY_ACCOUNTING_ITEM1.Visible = true;
            this.colAUXILIARY_ACCOUNTING_ITEM1.VisibleIndex = 8;
            // 
            // colAUXILIARY_ACCOUNTING_ITEM2
            // 
            this.colAUXILIARY_ACCOUNTING_ITEM2.Caption = "客商辅助核算";
            this.colAUXILIARY_ACCOUNTING_ITEM2.FieldName = "AUXILIARY_ACCOUNTING_ITEM2";
            this.colAUXILIARY_ACCOUNTING_ITEM2.Name = "colAUXILIARY_ACCOUNTING_ITEM2";
            this.colAUXILIARY_ACCOUNTING_ITEM2.Visible = true;
            this.colAUXILIARY_ACCOUNTING_ITEM2.VisibleIndex = 9;
            // 
            // colAUXILIARY_ACCOUNTING_ITEM3
            // 
            this.colAUXILIARY_ACCOUNTING_ITEM3.Caption = "增值税税率";
            this.colAUXILIARY_ACCOUNTING_ITEM3.FieldName = "AUXILIARY_ACCOUNTING_ITEM3";
            this.colAUXILIARY_ACCOUNTING_ITEM3.Name = "colAUXILIARY_ACCOUNTING_ITEM3";
            this.colAUXILIARY_ACCOUNTING_ITEM3.Visible = true;
            this.colAUXILIARY_ACCOUNTING_ITEM3.VisibleIndex = 10;
            // 
            // colAUXILIARY_ACCOUNTING_ITEM4
            // 
            this.colAUXILIARY_ACCOUNTING_ITEM4.Caption = "现金流量";
            this.colAUXILIARY_ACCOUNTING_ITEM4.FieldName = "AUXILIARY_ACCOUNTING_ITEM4";
            this.colAUXILIARY_ACCOUNTING_ITEM4.Name = "colAUXILIARY_ACCOUNTING_ITEM4";
            this.colAUXILIARY_ACCOUNTING_ITEM4.Visible = true;
            this.colAUXILIARY_ACCOUNTING_ITEM4.VisibleIndex = 11;
            // 
            // FrmLossVoucherDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 262);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmLossVoucherDetail";
            this.Text = "报废凭证明细";
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
        private DevExpress.XtraGrid.Columns.GridColumn colENTRY_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colKMMC;
        private DevExpress.XtraGrid.Columns.GridColumn colVOUCHERID;
        private DevExpress.XtraGrid.Columns.GridColumn colABSTRACT;
        private DevExpress.XtraGrid.Columns.GridColumn colDOCUMENT_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn colDEBIT_QUANTITY;
        private DevExpress.XtraGrid.Columns.GridColumn colPRIMARY_DEBIT_AMOUNT;
        private DevExpress.XtraGrid.Columns.GridColumn colCREDIT_QUANTITY;
        private DevExpress.XtraGrid.Columns.GridColumn colPRIMARY_CREDIT_AMOUNT;
        private DevExpress.XtraGrid.Columns.GridColumn colAUXILIARY_ACCOUNTING_ITEM1;
        private DevExpress.XtraGrid.Columns.GridColumn colAUXILIARY_ACCOUNTING_ITEM2;
        private DevExpress.XtraGrid.Columns.GridColumn colAUXILIARY_ACCOUNTING_ITEM3;
        private DevExpress.XtraGrid.Columns.GridColumn colAUXILIARY_ACCOUNTING_ITEM4;
        private DevExpress.XtraBars.BarButtonItem btnDetailQuery;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem btnColCustomize;
        private DevExpress.XtraBars.BarButtonItem btnSaveLayout;
        private DevExpress.XtraBars.BarButtonItem btnLoadLayout;
    }
}