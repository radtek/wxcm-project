namespace ClientMain
{
    partial class FrmPurchaseStageSelectCase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPurchaseStageSelectCase));
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.xpServerCollectionSource1 = new DevExpress.Xpo.XPServerCollectionSource();
            this.unitOfWork1 = new DevExpress.Xpo.UnitOfWork();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCGSHID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSJLX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCGBMID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWLBMID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGYSID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZDRQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCZYID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSSPZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSSSL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSSSY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSSMY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYFSL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYFSY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYFMY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYZT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCZRQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYSDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJSDWID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.btnJHinquire = new System.Windows.Forms.ToolStripButton();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpServerCollectionSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.xpServerCollectionSource1.ObjectType = typeof(XINHUA.JT_C_CGSH);
            this.xpServerCollectionSource1.Session = this.unitOfWork1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCGSHID,
            this.colSJLX,
            this.colSHDH,
            this.colCGBMID,
            this.colWLBMID,
            this.colGYSID,
            this.colZDRQ,
            this.colSL,
            this.colCZYID,
            this.colSSPZ,
            this.colSSSL,
            this.colSSSY,
            this.colSSMY,
            this.colYFSL,
            this.colYFSY,
            this.colYFMY,
            this.colZT,
            this.colYZT,
            this.colBZ,
            this.colCZRQ,
            this.colYSDH,
            this.colZTID,
            this.colJSDWID});
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
            // colCGSHID
            // 
            this.colCGSHID.Caption = "选单ID";
            this.colCGSHID.FieldName = "CGSHID";
            this.colCGSHID.Name = "colCGSHID";
            this.colCGSHID.OptionsFilter.AllowFilter = false;
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
            // colSHDH
            // 
            this.colSHDH.Caption = "单号";
            this.colSHDH.FieldName = "SHDH";
            this.colSHDH.Name = "colSHDH";
            this.colSHDH.Visible = true;
            this.colSHDH.VisibleIndex = 1;
            // 
            // colCGBMID
            // 
            this.colCGBMID.Caption = "采购部门ID";
            this.colCGBMID.FieldName = "CGBMID";
            this.colCGBMID.Name = "colCGBMID";
            this.colCGBMID.OptionsFilter.AllowFilter = false;
            // 
            // colWLBMID
            // 
            this.colWLBMID.Caption = "物流部门ID";
            this.colWLBMID.FieldName = "WLBMID";
            this.colWLBMID.Name = "colWLBMID";
            this.colWLBMID.OptionsFilter.AllowFilter = false;
            // 
            // colGYSID
            // 
            this.colGYSID.Caption = "供应商ID";
            this.colGYSID.FieldName = "GYSID";
            this.colGYSID.Name = "colGYSID";
            this.colGYSID.OptionsFilter.AllowFilter = false;
            // 
            // colZDRQ
            // 
            this.colZDRQ.Caption = "制单日期";
            this.colZDRQ.FieldName = "ZDRQ";
            this.colZDRQ.Name = "colZDRQ";
            this.colZDRQ.Visible = true;
            this.colZDRQ.VisibleIndex = 2;
            // 
            // colSL
            // 
            this.colSL.Caption = "税率 ";
            this.colSL.FieldName = "SL";
            this.colSL.Name = "colSL";
            this.colSL.Visible = true;
            this.colSL.VisibleIndex = 12;
            // 
            // colCZYID
            // 
            this.colCZYID.Caption = "操作员ID";
            this.colCZYID.FieldName = "CZYID";
            this.colCZYID.Name = "colCZYID";
            this.colCZYID.OptionsFilter.AllowFilter = false;
            // 
            // colSSPZ
            // 
            this.colSSPZ.Caption = "实收品种";
            this.colSSPZ.FieldName = "SSPZ";
            this.colSSPZ.Name = "colSSPZ";
            this.colSSPZ.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colSSPZ.Visible = true;
            this.colSSPZ.VisibleIndex = 3;
            // 
            // colSSSL
            // 
            this.colSSSL.Caption = "实收数量";
            this.colSSSL.FieldName = "SSSL";
            this.colSSSL.Name = "colSSSL";
            this.colSSSL.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colSSSL.Visible = true;
            this.colSSSL.VisibleIndex = 4;
            // 
            // colSSSY
            // 
            this.colSSSY.Caption = "实收实洋";
            this.colSSSY.FieldName = "SSSY";
            this.colSSSY.Name = "colSSSY";
            this.colSSSY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colSSSY.Visible = true;
            this.colSSSY.VisibleIndex = 5;
            // 
            // colSSMY
            // 
            this.colSSMY.Caption = "实收码洋";
            this.colSSMY.FieldName = "SSMY";
            this.colSSMY.Name = "colSSMY";
            this.colSSMY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colSSMY.Visible = true;
            this.colSSMY.VisibleIndex = 13;
            // 
            // colYFSL
            // 
            this.colYFSL.Caption = "应发数量";
            this.colYFSL.FieldName = "YFSL";
            this.colYFSL.Name = "colYFSL";
            this.colYFSL.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colYFSL.Visible = true;
            this.colYFSL.VisibleIndex = 6;
            // 
            // colYFSY
            // 
            this.colYFSY.Caption = "应发实洋";
            this.colYFSY.FieldName = "YFSY";
            this.colYFSY.Name = "colYFSY";
            this.colYFSY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colYFSY.Visible = true;
            this.colYFSY.VisibleIndex = 7;
            // 
            // colYFMY
            // 
            this.colYFMY.Caption = "应发码洋 ";
            this.colYFMY.FieldName = "YFMY";
            this.colYFMY.Name = "colYFMY";
            this.colYFMY.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colYFMY.Visible = true;
            this.colYFMY.VisibleIndex = 8;
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
            this.colYZT.Caption = "原状态 ID";
            this.colYZT.FieldName = "YZT";
            this.colYZT.Name = "colYZT";
            this.colYZT.OptionsFilter.AllowFilter = false;
            // 
            // colBZ
            // 
            this.colBZ.Caption = "备注 ";
            this.colBZ.FieldName = "BZ";
            this.colBZ.Name = "colBZ";
            this.colBZ.Visible = true;
            this.colBZ.VisibleIndex = 9;
            // 
            // colCZRQ
            // 
            this.colCZRQ.Caption = "操作日期 ";
            this.colCZRQ.FieldName = "CZRQ";
            this.colCZRQ.Name = "colCZRQ";
            this.colCZRQ.Visible = true;
            this.colCZRQ.VisibleIndex = 10;
            // 
            // colYSDH
            // 
            this.colYSDH.Caption = "应收单号";
            this.colYSDH.FieldName = "YSDH";
            this.colYSDH.Name = "colYSDH";
            this.colYSDH.Visible = true;
            this.colYSDH.VisibleIndex = 11;
            // 
            // colZTID
            // 
            this.colZTID.Caption = "帐套ID";
            this.colZTID.FieldName = "ZTID";
            this.colZTID.Name = "colZTID";
            this.colZTID.OptionsFilter.AllowFilter = false;
            // 
            // colJSDWID
            // 
            this.colJSDWID.Caption = "结算单位 ID";
            this.colJSDWID.FieldName = "JSDWID";
            this.colJSDWID.Name = "colJSDWID";
            this.colJSDWID.OptionsFilter.AllowFilter = false;
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
            this.btnJHinquire});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(842, 26);
            this.toolStrip1.TabIndex = 0;
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
            // btnJHinquire
            // 
            this.btnJHinquire.Image = ((System.Drawing.Image)(resources.GetObject("btnJHinquire.Image")));
            this.btnJHinquire.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnJHinquire.Name = "btnJHinquire";
            this.btnJHinquire.Size = new System.Drawing.Size(73, 23);
            this.btnJHinquire.Text = "  查询  ";
            this.btnJHinquire.Click += new System.EventHandler(this.btnJHinquire_Click);
            // 

            //grieviewx1
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            this.gridView1.CustomDrawFooterCell += new DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventHandler(this.gridView1_CustomDrawFooterCell);
            this.gridView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gridView1_MouseUp);
            //
            // FrmPurchaseStageSelectCase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 566);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "FrmPurchaseStageSelectCase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "采购单整单结算选单";
            this.Load += new System.EventHandler(this.FrmPurchaseStageSelectCase_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpServerCollectionSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private DevExpress.Xpo.XPServerCollectionSource xpServerCollectionSource1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnConfirm;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.ToolStripButton btnJHinquire;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCGSHID;
        private DevExpress.XtraGrid.Columns.GridColumn colSHDH;
        private DevExpress.XtraGrid.Columns.GridColumn colCGBMID;
        private DevExpress.XtraGrid.Columns.GridColumn colWLBMID;
        private DevExpress.XtraGrid.Columns.GridColumn colGYSID;
        private DevExpress.XtraGrid.Columns.GridColumn colZDRQ;
        private DevExpress.XtraGrid.Columns.GridColumn colCZYID;
        private DevExpress.XtraGrid.Columns.GridColumn colSSPZ;
        private DevExpress.XtraGrid.Columns.GridColumn colSSSL;
        private DevExpress.XtraGrid.Columns.GridColumn colSSSY;
        private DevExpress.XtraGrid.Columns.GridColumn colYFSL;
        private DevExpress.XtraGrid.Columns.GridColumn colYFSY;
        private DevExpress.XtraGrid.Columns.GridColumn colYFMY;
        private DevExpress.XtraGrid.Columns.GridColumn colZT;
        private DevExpress.XtraGrid.Columns.GridColumn colYZT;
        private DevExpress.XtraGrid.Columns.GridColumn colBZ;
        private DevExpress.XtraGrid.Columns.GridColumn colCZRQ;
        private DevExpress.XtraGrid.Columns.GridColumn colYSDH;
        private DevExpress.XtraGrid.Columns.GridColumn colZTID;
        private DevExpress.XtraGrid.Columns.GridColumn colSJLX;
        private DevExpress.XtraGrid.Columns.GridColumn colJSDWID;
        private DevExpress.XtraGrid.Columns.GridColumn colSL;
        private DevExpress.XtraGrid.Columns.GridColumn colSSMY;
        private DevExpress.Xpo.UnitOfWork unitOfWork1;

    }
}