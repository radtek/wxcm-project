namespace ClientMain
{
    partial class UserMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnUserAdd = new System.Windows.Forms.ToolStripButton();
            this.btnUserAlter = new System.Windows.Forms.ToolStripButton();
            this.btnUserLook = new System.Windows.Forms.ToolStripButton();
            this.btnUserDelete = new System.Windows.Forms.ToolStripButton();
            this.btnUserReload = new System.Windows.Forms.ToolStripButton();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.xpServerCollectionSource1 = new DevExpress.Xpo.XPServerCollectionSource();
            this.unitOfWork1 = new DevExpress.Xpo.UnitOfWork();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUSERID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSERNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colISLOCK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPASSWORD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDESCRIPTION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTARTDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTOPDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEMPID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLSKHDNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJCDJCNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYTHPTNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(977, 22);
            this.panel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnUserAdd,
            this.btnUserAlter,
            this.btnUserLook,
            this.btnUserDelete,
            this.btnUserReload,
            this.btnQuery});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(977, 22);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnUserAdd
            // 
            this.btnUserAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnUserAdd.Image")));
            this.btnUserAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUserAdd.Name = "btnUserAdd";
            this.btnUserAdd.Size = new System.Drawing.Size(49, 19);
            this.btnUserAdd.Text = "添加";
            this.btnUserAdd.Click += new System.EventHandler(this.btnUserAdd_Click);
            // 
            // btnUserAlter
            // 
            this.btnUserAlter.Image = ((System.Drawing.Image)(resources.GetObject("btnUserAlter.Image")));
            this.btnUserAlter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUserAlter.Name = "btnUserAlter";
            this.btnUserAlter.Size = new System.Drawing.Size(49, 19);
            this.btnUserAlter.Text = "编辑";
            this.btnUserAlter.Click += new System.EventHandler(this.btnUserAlter_Click);
            // 
            // btnUserLook
            // 
            this.btnUserLook.Image = ((System.Drawing.Image)(resources.GetObject("btnUserLook.Image")));
            this.btnUserLook.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUserLook.Name = "btnUserLook";
            this.btnUserLook.Size = new System.Drawing.Size(49, 19);
            this.btnUserLook.Text = "查看";
            this.btnUserLook.Click += new System.EventHandler(this.btnUserLook_Click);
            // 
            // btnUserDelete
            // 
            this.btnUserDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnUserDelete.Image")));
            this.btnUserDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUserDelete.Name = "btnUserDelete";
            this.btnUserDelete.Size = new System.Drawing.Size(49, 19);
            this.btnUserDelete.Text = "删除";
            this.btnUserDelete.Click += new System.EventHandler(this.btnUserDelete_Click);
            // 
            // btnUserReload
            // 
            this.btnUserReload.Image = ((System.Drawing.Image)(resources.GetObject("btnUserReload.Image")));
            this.btnUserReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUserReload.Name = "btnUserReload";
            this.btnUserReload.Size = new System.Drawing.Size(49, 19);
            this.btnUserReload.Text = "刷新";
            this.btnUserReload.Click += new System.EventHandler(this.btnUserReload_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnQuery.Image")));
            this.btnQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(49, 19);
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.toolStrip2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 362);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(977, 22);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(977, 22);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gridControl1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(977, 340);
            this.panel3.TabIndex = 2;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.xpServerCollectionSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(977, 340);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // xpServerCollectionSource1
            // 
            this.xpServerCollectionSource1.ObjectType = typeof(XINHUA.VIEW_SYS_USER);
            this.xpServerCollectionSource1.Session = this.unitOfWork1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUSERID,
            this.colUSERNAME,
            this.colNAME,
            this.colISLOCK,
            this.colPASSWORD,
            this.colDESCRIPTION,
            this.colSTARTDATE,
            this.colSTOPDATE,
            this.colEMPID,
            this.colLSKHDNO,
            this.colJCDJCNO,
            this.colYTHPTNO});
            this.gridView1.FooterPanelHeight = 45;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsPrint.AutoWidth = false;
            this.gridView1.OptionsPrint.PrintSelectedRowsOnly = true;
            this.gridView1.OptionsSelection.MultiSelect = true;
            // 
            // colUSERID
            // 
            this.colUSERID.Caption = "用户ID";
            this.colUSERID.FieldName = "USERID";
            this.colUSERID.Name = "colUSERID";
            this.colUSERID.Visible = true;
            this.colUSERID.VisibleIndex = 0;
            // 
            // colUSERNAME
            // 
            this.colUSERNAME.Caption = "用户名称";
            this.colUSERNAME.FieldName = "USERNAME";
            this.colUSERNAME.Name = "colUSERNAME";
            this.colUSERNAME.Visible = true;
            this.colUSERNAME.VisibleIndex = 1;
            // 
            // colNAME
            // 
            this.colNAME.Caption = "员工姓名";
            this.colNAME.FieldName = "NAME";
            this.colNAME.Name = "colNAME";
            this.colNAME.Visible = true;
            this.colNAME.VisibleIndex = 2;
            // 
            // colISLOCK
            // 
            this.colISLOCK.Caption = "是否锁定";
            this.colISLOCK.FieldName = "ISLOCK";
            this.colISLOCK.Name = "colISLOCK";
            this.colISLOCK.Visible = true;
            this.colISLOCK.VisibleIndex = 3;
            // 
            // colPASSWORD
            // 
            this.colPASSWORD.Caption = "密码";
            this.colPASSWORD.FieldName = "PASSWORD";
            this.colPASSWORD.Name = "colPASSWORD";
            // 
            // colDESCRIPTION
            // 
            this.colDESCRIPTION.Caption = "描述";
            this.colDESCRIPTION.FieldName = "DESCRIPTION";
            this.colDESCRIPTION.Name = "colDESCRIPTION";
            this.colDESCRIPTION.Visible = true;
            this.colDESCRIPTION.VisibleIndex = 4;
            // 
            // colSTARTDATE
            // 
            this.colSTARTDATE.Caption = "启用日期";
            this.colSTARTDATE.FieldName = "STARTDATE";
            this.colSTARTDATE.Name = "colSTARTDATE";
            this.colSTARTDATE.Visible = true;
            this.colSTARTDATE.VisibleIndex = 5;
            // 
            // colSTOPDATE
            // 
            this.colSTOPDATE.Caption = "停止日期";
            this.colSTOPDATE.FieldName = "STOPDATE";
            this.colSTOPDATE.Name = "colSTOPDATE";
            this.colSTOPDATE.Visible = true;
            this.colSTOPDATE.VisibleIndex = 6;
            // 
            // colEMPID
            // 
            this.colEMPID.Caption = "员工ID";
            this.colEMPID.FieldName = "EMPID";
            this.colEMPID.Name = "colEMPID";
            this.colEMPID.OptionsFilter.AllowFilter = false;
            // 
            // colLSKHDNO
            // 
            this.colLSKHDNO.Caption = "连锁客户编号";
            this.colLSKHDNO.FieldName = "LSKHDNO";
            this.colLSKHDNO.Name = "colLSKHDNO";
            this.colLSKHDNO.Visible = true;
            this.colLSKHDNO.VisibleIndex = 7;
            // 
            // colJCDJCNO
            // 
            this.colJCDJCNO.Caption = "基层用户编号";
            this.colJCDJCNO.FieldName = "JCDJCNO";
            this.colJCDJCNO.Name = "colJCDJCNO";
            this.colJCDJCNO.Visible = true;
            this.colJCDJCNO.VisibleIndex = 8;
            // 
            // colYTHPTNO
            // 
            this.colYTHPTNO.Caption = "一体化平台用户";
            this.colYTHPTNO.FieldName = "YTHPTNO";
            this.colYTHPTNO.Name = "colYTHPTNO";
            this.colYTHPTNO.Visible = true;
            this.colYTHPTNO.VisibleIndex = 9;
            // 
            // UserMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 384);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UserMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户管理";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UserMain1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpServerCollectionSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnUserAdd;
        private System.Windows.Forms.ToolStripButton btnUserAlter;
        private System.Windows.Forms.ToolStripButton btnUserLook;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStripButton btnUserDelete;
        private System.Windows.Forms.ToolStripButton btnUserReload;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.Xpo.UnitOfWork unitOfWork1;
        private DevExpress.Xpo.XPServerCollectionSource xpServerCollectionSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colUSERID;
        private DevExpress.XtraGrid.Columns.GridColumn colUSERNAME;
        private DevExpress.XtraGrid.Columns.GridColumn colISLOCK;
        private DevExpress.XtraGrid.Columns.GridColumn colPASSWORD;
        private DevExpress.XtraGrid.Columns.GridColumn colDESCRIPTION;
        private DevExpress.XtraGrid.Columns.GridColumn colSTARTDATE;
        private DevExpress.XtraGrid.Columns.GridColumn colSTOPDATE;
        private DevExpress.XtraGrid.Columns.GridColumn colEMPID;
        private DevExpress.XtraGrid.Columns.GridColumn colLSKHDNO;
        private DevExpress.XtraGrid.Columns.GridColumn colJCDJCNO;
        private DevExpress.XtraGrid.Columns.GridColumn colYTHPTNO;
        private DevExpress.XtraGrid.Columns.GridColumn colNAME;
    }
}