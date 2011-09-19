namespace ClientMain
{
    partial class FrmSaleStageSelectcase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSaleStageSelectcase));
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.btniuquire = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.xpServerCollectionSource1 = new DevExpress.Xpo.XPServerCollectionSource();
            this.unitOfWork1 = new DevExpress.Xpo.UnitOfWork();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSJLX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXSDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKHMC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZDRQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPZS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXSSL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXSSY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYSSL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXSMY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYSSY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYSMY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCZRQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXSBMID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXSDID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWLBMID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKHID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCZYID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYSFSID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYZT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJSDWID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJSFSID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpServerCollectionSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 26);
            this.panel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnConfirm,
            this.btnCancel,
            this.btniuquire});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(842, 26);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(49, 23);
            this.btnConfirm.Text = "确定";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(49, 23);
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btniuquire
            // 
            this.btniuquire.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btniuquire.Image = ((System.Drawing.Image)(resources.GetObject("btniuquire.Image")));
            this.btniuquire.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btniuquire.Name = "btniuquire";
            this.btniuquire.Size = new System.Drawing.Size(69, 23);
            this.btniuquire.Text = "   查询   ";
            this.btniuquire.Click += new System.EventHandler(this.btniuquire_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(842, 540);
            this.panel2.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.xpServerCollectionSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(842, 540);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // xpServerCollectionSource1
            // 
            this.xpServerCollectionSource1.ObjectType = typeof(XINHUA.JT_C_XSD);
            this.xpServerCollectionSource1.Session = this.unitOfWork1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSJLX,
            this.colXSDH,
            this.colYDH,
            this.colKHMC,
            this.colZDRQ,
            this.colPZS,
            this.colXSSL,
            this.colXSSY,
            this.colYSSL,
            this.colXSMY,
            this.colYSSY,
            this.colYSMY,
            this.colSL,
            this.colBZ,
            this.colCZRQ,
            this.colXSBMID,
            this.colXSDID,
            this.colWLBMID,
            this.colKHID,
            this.colCZYID,
            this.colYSFSID,
            this.colZT,
            this.colYZT,
            this.colZTID,
            this.colJSDWID,
            this.colJSFSID});
            this.gridView1.FooterPanelHeight = 45;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsPrint.AutoWidth = false;
            this.gridView1.OptionsPrint.PrintSelectedRowsOnly = true;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colSJLX
            // 
            this.colSJLX.Caption = "数据类型";
            this.colSJLX.FieldName = "SJLX";
            this.colSJLX.Name = "colSJLX";
            this.colSJLX.SummaryItem.DisplayFormat = "总计：";
            this.colSJLX.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Custom;
            this.colSJLX.Visible = true;
            this.colSJLX.VisibleIndex = 0;
            // 
            // colXSDH
            // 
            this.colXSDH.Caption = "销售单号";
            this.colXSDH.FieldName = "XSDH";
            this.colXSDH.Name = "colXSDH";
            this.colXSDH.Visible = true;
            this.colXSDH.VisibleIndex = 1;
            // 
            // colYDH
            // 
            this.colYDH.Caption = "原单号";
            this.colYDH.FieldName = "YDH";
            this.colYDH.Name = "colYDH";
            this.colYDH.Visible = true;
            this.colYDH.VisibleIndex = 2;
            // 
            // colKHMC
            // 
            this.colKHMC.Caption = "客户名称";
            this.colKHMC.FieldName = "KHMC";
            this.colKHMC.Name = "colKHMC";
            this.colKHMC.Visible = true;
            this.colKHMC.VisibleIndex = 3;
            // 
            // colZDRQ
            // 
            this.colZDRQ.Caption = "制单日期";
            this.colZDRQ.FieldName = "ZDRQ";
            this.colZDRQ.Name = "colZDRQ";
            this.colZDRQ.Visible = true;
            this.colZDRQ.VisibleIndex = 4;
            // 
            // colPZS
            // 
            this.colPZS.Caption = "品种数";
            this.colPZS.FieldName = "PZS";
            this.colPZS.Name = "colPZS";
            this.colPZS.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colPZS.Visible = true;
            this.colPZS.VisibleIndex = 5;
            // 
            // colXSSL
            // 
            this.colXSSL.Caption = "销售数量";
            this.colXSSL.FieldName = "XSSL";
            this.colXSSL.Name = "colXSSL";
            this.colXSSL.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colXSSL.Visible = true;
            this.colXSSL.VisibleIndex = 6;
            // 
            // colXSSY
            // 
            this.colXSSY.Caption = "销售实洋";
            this.colXSSY.FieldName = "XSSY";
            this.colXSSY.Name = "colXSSY";
            this.colXSSY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colXSSY.Visible = true;
            this.colXSSY.VisibleIndex = 7;
            // 
            // colYSSL
            // 
            this.colYSSL.Caption = "应收数量";
            this.colYSSL.FieldName = "YSSL";
            this.colYSSL.Name = "colYSSL";
            this.colYSSL.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colYSSL.Visible = true;
            this.colYSSL.VisibleIndex = 8;
            // 
            // colXSMY
            // 
            this.colXSMY.Caption = "销售码洋";
            this.colXSMY.FieldName = "XSMY";
            this.colXSMY.Name = "colXSMY";
            this.colXSMY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colXSMY.Visible = true;
            this.colXSMY.VisibleIndex = 9;
            // 
            // colYSSY
            // 
            this.colYSSY.Caption = "应收码洋";
            this.colYSSY.FieldName = "YSSY";
            this.colYSSY.Name = "colYSSY";
            this.colYSSY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colYSSY.Visible = true;
            this.colYSSY.VisibleIndex = 10;
            // 
            // colYSMY
            // 
            this.colYSMY.Caption = "应收码洋";
            this.colYSMY.FieldName = "YSMY";
            this.colYSMY.Name = "colYSMY";
            this.colYSMY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colYSMY.Visible = true;
            this.colYSMY.VisibleIndex = 11;
            // 
            // colSL
            // 
            this.colSL.Caption = "税率";
            this.colSL.FieldName = "SL";
            this.colSL.Name = "colSL";
            this.colSL.Visible = true;
            this.colSL.VisibleIndex = 12;
            // 
            // colBZ
            // 
            this.colBZ.Caption = "备注";
            this.colBZ.FieldName = "BZ";
            this.colBZ.Name = "colBZ";
            this.colBZ.Visible = true;
            this.colBZ.VisibleIndex = 13;
            // 
            // colCZRQ
            // 
            this.colCZRQ.Caption = "操作日期";
            this.colCZRQ.FieldName = "CZRQ";
            this.colCZRQ.Name = "colCZRQ";
            this.colCZRQ.Visible = true;
            this.colCZRQ.VisibleIndex = 14;
            // 
            // colXSBMID
            // 
            this.colXSBMID.Caption = "销售部门ID";
            this.colXSBMID.FieldName = "XSBMID";
            this.colXSBMID.Name = "colXSBMID";
            this.colXSBMID.OptionsFilter.AllowFilter = false;
            // 
            // colXSDID
            // 
            this.colXSDID.Caption = "销售单ID";
            this.colXSDID.FieldName = "XSDID";
            this.colXSDID.Name = "colXSDID";
            this.colXSDID.OptionsFilter.AllowFilter = false;
            // 
            // colWLBMID
            // 
            this.colWLBMID.Caption = "物流部门ID";
            this.colWLBMID.FieldName = "WLBMID";
            this.colWLBMID.Name = "colWLBMID";
            this.colWLBMID.OptionsFilter.AllowFilter = false;
            // 
            // colKHID
            // 
            this.colKHID.Caption = "客户ID";
            this.colKHID.FieldName = "KHID";
            this.colKHID.Name = "colKHID";
            this.colKHID.OptionsFilter.AllowFilter = false;
            // 
            // colCZYID
            // 
            this.colCZYID.Caption = "操作员ID";
            this.colCZYID.FieldName = "CZYID";
            this.colCZYID.Name = "colCZYID";
            this.colCZYID.OptionsFilter.AllowFilter = false;
            // 
            // colYSFSID
            // 
            this.colYSFSID.Caption = "应发方式ID";
            this.colYSFSID.FieldName = "YSFSID";
            this.colYSFSID.Name = "colYSFSID";
            this.colYSFSID.OptionsFilter.AllowFilter = false;
            // 
            // colZT
            // 
            this.colZT.Caption = "状态ID";
            this.colZT.FieldName = "ZT";
            this.colZT.Name = "colZT";
            this.colZT.OptionsFilter.AllowFilter = false;
            // 
            // colYZT
            // 
            this.colYZT.Caption = "原状态ID";
            this.colYZT.FieldName = "YZT";
            this.colYZT.Name = "colYZT";
            // 
            // colZTID
            // 
            this.colZTID.Caption = "帐套ID";
            this.colZTID.FieldName = "ZTID";
            this.colZTID.Name = "colZTID";
            // 
            // colJSDWID
            // 
            this.colJSDWID.Caption = "结算单位ID";
            this.colJSDWID.FieldName = "JSDWID";
            this.colJSDWID.Name = "colJSDWID";
            // 
            // colJSFSID
            // 
            this.colJSFSID.Caption = "结算方式ID";
            this.colJSFSID.FieldName = "JSFSID";
            this.colJSFSID.Name = "colJSFSID";
            // 
            //GRIDVIEW
            //
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            this.gridView1.CustomDrawFooterCell += new DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventHandler(this.gridView1_CustomDrawFooterCell);
            this.gridView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gridView1_MouseUp);
            //
            // FrmSaleStageSelectcase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 566);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "FrmSaleStageSelectcase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "销售单整单结算选单";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpServerCollectionSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnConfirm;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripButton btniuquire;
        private DevExpress.Xpo.XPServerCollectionSource xpServerCollectionSource1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colXSDID;
        private DevExpress.XtraGrid.Columns.GridColumn colXSDH;
        private DevExpress.XtraGrid.Columns.GridColumn colXSBMID;
        private DevExpress.XtraGrid.Columns.GridColumn colWLBMID;
        private DevExpress.XtraGrid.Columns.GridColumn colKHID;
        private DevExpress.XtraGrid.Columns.GridColumn colKHMC;
        private DevExpress.XtraGrid.Columns.GridColumn colZDRQ;
        private DevExpress.XtraGrid.Columns.GridColumn colCZYID;
        private DevExpress.XtraGrid.Columns.GridColumn colXSSL;
        private DevExpress.XtraGrid.Columns.GridColumn colXSSY;
        private DevExpress.XtraGrid.Columns.GridColumn colXSMY;
        private DevExpress.XtraGrid.Columns.GridColumn colYSSL;
        private DevExpress.XtraGrid.Columns.GridColumn colYSSY;
        private DevExpress.XtraGrid.Columns.GridColumn colYSFSID;
        private DevExpress.XtraGrid.Columns.GridColumn colYSMY;
        private DevExpress.XtraGrid.Columns.GridColumn colZT;
        private DevExpress.XtraGrid.Columns.GridColumn colYZT;
        private DevExpress.XtraGrid.Columns.GridColumn colBZ;
        private DevExpress.XtraGrid.Columns.GridColumn colCZRQ;
        private DevExpress.XtraGrid.Columns.GridColumn colYDH;
        private DevExpress.XtraGrid.Columns.GridColumn colZTID;
        private DevExpress.XtraGrid.Columns.GridColumn colSJLX;
        private DevExpress.XtraGrid.Columns.GridColumn colJSDWID;
        private DevExpress.XtraGrid.Columns.GridColumn colSL;
        private DevExpress.XtraGrid.Columns.GridColumn colJSFSID;
        private DevExpress.XtraGrid.Columns.GridColumn colPZS;
        private DevExpress.Xpo.UnitOfWork unitOfWork1;
    }
}