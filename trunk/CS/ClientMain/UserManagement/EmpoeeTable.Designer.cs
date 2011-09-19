namespace ClientMain
{
    partial class EmpoeeTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpoeeTable));
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnCanncle = new System.Windows.Forms.ToolStripButton();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.xpServerCollectionSource1 = new DevExpress.Xpo.XPServerCollectionSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEMPLOYEEID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEMPLOYEENO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFASTCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSEX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBIRTHDAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEMAIL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTXDZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTELEPHONE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMOBILETELEPHONE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSJDWID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJCJCNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKHDNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDEPARTMENTNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpServerCollectionSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 29);
            this.panel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.btnCanncle,
            this.btnQuery,
            this.btnExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(815, 29);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(57, 26);
            this.btnSave.Text = "  确定  ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCanncle
            // 
            this.btnCanncle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCanncle.Image = ((System.Drawing.Image)(resources.GetObject("btnCanncle.Image")));
            this.btnCanncle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCanncle.Name = "btnCanncle";
            this.btnCanncle.Size = new System.Drawing.Size(57, 26);
            this.btnCanncle.Text = "  取消  ";
            this.btnCanncle.Click += new System.EventHandler(this.btnCanncle_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnQuery.Image")));
            this.btnQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(69, 26);
            this.btnQuery.Text = "   查询   ";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnExit
            // 
            this.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(63, 26);
            this.btnExit.Text = "  退出   ";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.toolStrip2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 333);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(815, 31);
            this.panel2.TabIndex = 1;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(815, 31);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gridControl1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(815, 304);
            this.panel3.TabIndex = 2;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.xpServerCollectionSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(815, 304);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // xpServerCollectionSource1
            // 
            this.xpServerCollectionSource1.ObjectType = typeof(XINHUA.VIEW_SYS_EMPLOYEES_SELECT);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEMPLOYEEID,
            this.colEMPLOYEENO,
            this.colNAME,
            this.colFASTCODE,
            this.colSEX,
            this.colBIRTHDAY,
            this.colEMAIL,
            this.colTXDZ,
            this.colTELEPHONE,
            this.colMOBILETELEPHONE,
            this.colSJDWID,
            this.colJCJCNO,
            this.colKHDNO,
            this.colDEPARTMENTNAME});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsPrint.AutoWidth = false;
            this.gridView1.OptionsPrint.PrintSelectedRowsOnly = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            // 
            // colEMPLOYEEID
            // 
            this.colEMPLOYEEID.Caption = "员工ID";
            this.colEMPLOYEEID.FieldName = "EMPLOYEEID";
            this.colEMPLOYEEID.Name = "colEMPLOYEEID";
            this.colEMPLOYEEID.Visible = true;
            this.colEMPLOYEEID.VisibleIndex = 0;
            // 
            // colEMPLOYEENO
            // 
            this.colEMPLOYEENO.Caption = "员工编号";
            this.colEMPLOYEENO.FieldName = "EMPLOYEENO";
            this.colEMPLOYEENO.Name = "colEMPLOYEENO";
            this.colEMPLOYEENO.Visible = true;
            this.colEMPLOYEENO.VisibleIndex = 1;
            // 
            // colNAME
            // 
            this.colNAME.Caption = "员工姓名";
            this.colNAME.FieldName = "NAME";
            this.colNAME.Name = "colNAME";
            this.colNAME.Visible = true;
            this.colNAME.VisibleIndex = 2;
            // 
            // colFASTCODE
            // 
            this.colFASTCODE.Caption = "助记码";
            this.colFASTCODE.FieldName = "FASTCODE";
            this.colFASTCODE.Name = "colFASTCODE";
            this.colFASTCODE.Visible = true;
            this.colFASTCODE.VisibleIndex = 3;
            // 
            // colSEX
            // 
            this.colSEX.Caption = "性别";
            this.colSEX.FieldName = "SEX";
            this.colSEX.Name = "colSEX";
            this.colSEX.Visible = true;
            this.colSEX.VisibleIndex = 4;
            // 
            // colBIRTHDAY
            // 
            this.colBIRTHDAY.Caption = "出身年月";
            this.colBIRTHDAY.FieldName = "BIRTHDAY";
            this.colBIRTHDAY.Name = "colBIRTHDAY";
            this.colBIRTHDAY.Visible = true;
            this.colBIRTHDAY.VisibleIndex = 5;
            // 
            // colEMAIL
            // 
            this.colEMAIL.Caption = "EMAIL";
            this.colEMAIL.FieldName = "EMAIL";
            this.colEMAIL.Name = "colEMAIL";
            this.colEMAIL.Visible = true;
            this.colEMAIL.VisibleIndex = 6;
            // 
            // colTXDZ
            // 
            this.colTXDZ.Caption = "通讯地址";
            this.colTXDZ.FieldName = "TXDZ";
            this.colTXDZ.Name = "colTXDZ";
            this.colTXDZ.Visible = true;
            this.colTXDZ.VisibleIndex = 7;
            // 
            // colTELEPHONE
            // 
            this.colTELEPHONE.Caption = "电话";
            this.colTELEPHONE.FieldName = "TELEPHONE";
            this.colTELEPHONE.Name = "colTELEPHONE";
            this.colTELEPHONE.Visible = true;
            this.colTELEPHONE.VisibleIndex = 8;
            // 
            // colMOBILETELEPHONE
            // 
            this.colMOBILETELEPHONE.Caption = "移动电话";
            this.colMOBILETELEPHONE.FieldName = "MOBILETELEPHONE";
            this.colMOBILETELEPHONE.Name = "colMOBILETELEPHONE";
            this.colMOBILETELEPHONE.Visible = true;
            this.colMOBILETELEPHONE.VisibleIndex = 9;
            // 
            // colSJDWID
            // 
            this.colSJDWID.Caption = "上级单位ID";
            this.colSJDWID.FieldName = "SJDWID";
            this.colSJDWID.Name = "colSJDWID";
            this.colSJDWID.OptionsFilter.AllowFilter = false;
            // 
            // colJCJCNO
            // 
            this.colJCJCNO.Caption = "基层编号";
            this.colJCJCNO.FieldName = "JCJCNO";
            this.colJCJCNO.Name = "colJCJCNO";
            this.colJCJCNO.Visible = true;
            this.colJCJCNO.VisibleIndex = 10;
            // 
            // colKHDNO
            // 
            this.colKHDNO.Caption = "客户编号";
            this.colKHDNO.FieldName = "KHDNO";
            this.colKHDNO.Name = "colKHDNO";
            this.colKHDNO.Visible = true;
            this.colKHDNO.VisibleIndex = 11;
            // 
            // colDEPARTMENTNAME
            // 
            this.colDEPARTMENTNAME.Caption = "上级单位名称";
            this.colDEPARTMENTNAME.FieldName = "DEPARTMENTNAME";
            this.colDEPARTMENTNAME.Name = "colDEPARTMENTNAME";
            this.colDEPARTMENTNAME.Visible = true;
            this.colDEPARTMENTNAME.VisibleIndex = 12;
            // 
            // EmpoeeTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 364);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "EmpoeeTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "员工表";
            this.Load += new System.EventHandler(this.EmpoeeTable1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpServerCollectionSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnCanncle;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.Xpo.XPServerCollectionSource xpServerCollectionSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colEMPLOYEEID;
        private DevExpress.XtraGrid.Columns.GridColumn colEMPLOYEENO;
        private DevExpress.XtraGrid.Columns.GridColumn colNAME;
        private DevExpress.XtraGrid.Columns.GridColumn colFASTCODE;
        private DevExpress.XtraGrid.Columns.GridColumn colSEX;
        private DevExpress.XtraGrid.Columns.GridColumn colBIRTHDAY;
        private DevExpress.XtraGrid.Columns.GridColumn colEMAIL;
        private DevExpress.XtraGrid.Columns.GridColumn colTXDZ;
        private DevExpress.XtraGrid.Columns.GridColumn colTELEPHONE;
        private DevExpress.XtraGrid.Columns.GridColumn colMOBILETELEPHONE;
        private DevExpress.XtraGrid.Columns.GridColumn colSJDWID;
        private DevExpress.XtraGrid.Columns.GridColumn colJCJCNO;
        private DevExpress.XtraGrid.Columns.GridColumn colKHDNO;
        private DevExpress.XtraGrid.Columns.GridColumn colDEPARTMENTNAME;
    }
}