namespace ClientMain
{
    partial class MeunMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MeunMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnAlter = new System.Windows.Forms.ToolStripButton();
            this.btnLook = new System.Windows.Forms.ToolStripButton();
            this.btnSadd = new System.Windows.Forms.ToolStripButton();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItem_add = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_alter = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_look = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_sadd = new System.Windows.Forms.ToolStripMenuItem();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.xpServerCollectionSource1 = new DevExpress.Xpo.XPServerCollectionSource();
            this.unitOfWork1 = new DevExpress.Xpo.UnitOfWork();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMODELNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFATHERNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTYPENAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLINK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colISVISABLED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMODEL_SORTNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMODEL_DLL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDBTYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSYSTYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPARENLEV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPARENTMODEL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCHILDMODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOURMODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpServerCollectionSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bindingNavigator1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1204, 26);
            this.panel1.TabIndex = 0;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btnDelete,
            this.btnAlter,
            this.btnLook,
            this.btnSadd,
            this.btnExit,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorSeparator2});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(1204, 26);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // btnAdd
            // 
            this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(69, 23);
            this.btnAdd.Text = "   增加   ";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(63, 23);
            this.btnDelete.Text = "  删除   ";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAlter
            // 
            this.btnAlter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAlter.Image = ((System.Drawing.Image)(resources.GetObject("btnAlter.Image")));
            this.btnAlter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.Size = new System.Drawing.Size(69, 23);
            this.btnAlter.Text = "   修改   ";
            this.btnAlter.Click += new System.EventHandler(this.btnAlter_Click);
            // 
            // btnLook
            // 
            this.btnLook.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnLook.Image = ((System.Drawing.Image)(resources.GetObject("btnLook.Image")));
            this.btnLook.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLook.Name = "btnLook";
            this.btnLook.Size = new System.Drawing.Size(63, 23);
            this.btnLook.Text = "  查看   ";
            this.btnLook.Click += new System.EventHandler(this.btnLook_Click);
            // 
            // btnSadd
            // 
            this.btnSadd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSadd.Image = ((System.Drawing.Image)(resources.GetObject("btnSadd.Image")));
            this.btnSadd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSadd.Name = "btnSadd";
            this.btnSadd.Size = new System.Drawing.Size(81, 23);
            this.btnSadd.Text = "一级菜单增加";
            this.btnSadd.Click += new System.EventHandler(this.btnSadd_Click);
            // 
            // btnExit
            // 
            this.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(63, 23);
            this.btnExit.Text = "   退出  ";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 26);
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 26);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 26);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_add,
            this.MenuItem_delete,
            this.MenuItem_alter,
            this.MenuItem_look,
            this.MenuItem_sadd});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(143, 114);
            // 
            // MenuItem_add
            // 
            this.MenuItem_add.Name = "MenuItem_add";
            this.MenuItem_add.Size = new System.Drawing.Size(142, 22);
            this.MenuItem_add.Text = "增加";
            this.MenuItem_add.Click += new System.EventHandler(this.MenuItem_add_Click);
            // 
            // MenuItem_delete
            // 
            this.MenuItem_delete.Name = "MenuItem_delete";
            this.MenuItem_delete.Size = new System.Drawing.Size(142, 22);
            this.MenuItem_delete.Text = "删除";
            this.MenuItem_delete.Click += new System.EventHandler(this.MenuItem_delete_Click);
            // 
            // MenuItem_alter
            // 
            this.MenuItem_alter.Name = "MenuItem_alter";
            this.MenuItem_alter.Size = new System.Drawing.Size(142, 22);
            this.MenuItem_alter.Text = "修改";
            this.MenuItem_alter.Click += new System.EventHandler(this.MenuItem_alter_Click);
            // 
            // MenuItem_look
            // 
            this.MenuItem_look.Name = "MenuItem_look";
            this.MenuItem_look.Size = new System.Drawing.Size(142, 22);
            this.MenuItem_look.Text = "查看";
            this.MenuItem_look.Click += new System.EventHandler(this.MenuItem_look_Click);
            // 
            // MenuItem_sadd
            // 
            this.MenuItem_sadd.Name = "MenuItem_sadd";
            this.MenuItem_sadd.Size = new System.Drawing.Size(142, 22);
            this.MenuItem_sadd.Text = "一级菜单增加";
            this.MenuItem_sadd.Click += new System.EventHandler(this.MenuItem_sadd_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 26);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 496);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // treeView1
            // 
            this.treeView1.ContextMenuStrip = this.contextMenuStrip1;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Font = new System.Drawing.Font("华文中宋", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeView1.ForeColor = System.Drawing.Color.Blue;
            this.treeView1.LineColor = System.Drawing.Color.DodgerBlue;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(400, 496);
            this.treeView1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 26);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(1201, 496);
            this.splitContainer1.SplitterDistance = 400;
            this.splitContainer1.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gridControl1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(797, 468);
            this.panel3.TabIndex = 2;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.xpServerCollectionSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(797, 468);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // xpServerCollectionSource1
            // 
            this.xpServerCollectionSource1.ObjectType = typeof(XINHUA.VIEW_SYS_MODEL);
            this.xpServerCollectionSource1.Session = this.unitOfWork1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colMODELNAME,
            this.colFATHERNAME,
            this.colTYPENAME,
            this.colLINK,
            this.colISVISABLED,
            this.colMODEL_SORTNO,
            this.colMODEL_DLL,
            this.colDBTYPE,
            this.colSYSTYPE,
            this.colPARENLEV,
            this.colPARENTMODEL,
            this.colCHILDMODE,
            this.colSOURMODE});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            // 
            // colID
            // 
            this.colID.Caption = "菜单ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colMODELNAME
            // 
            this.colMODELNAME.Caption = "菜单名称";
            this.colMODELNAME.FieldName = "MODELNAME";
            this.colMODELNAME.Name = "colMODELNAME";
            this.colMODELNAME.Visible = true;
            this.colMODELNAME.VisibleIndex = 1;
            // 
            // colFATHERNAME
            // 
            this.colFATHERNAME.Caption = "上级菜单名称";
            this.colFATHERNAME.FieldName = "FATHERNAME";
            this.colFATHERNAME.Name = "colFATHERNAME";
            this.colFATHERNAME.Visible = true;
            this.colFATHERNAME.VisibleIndex = 2;
            // 
            // colTYPENAME
            // 
            this.colTYPENAME.Caption = "系统类型";
            this.colTYPENAME.FieldName = "TYPENAME";
            this.colTYPENAME.Name = "colTYPENAME";
            this.colTYPENAME.Visible = true;
            this.colTYPENAME.VisibleIndex = 3;
            // 
            // colLINK
            // 
            this.colLINK.Caption = "页面链接";
            this.colLINK.FieldName = "LINK";
            this.colLINK.Name = "colLINK";
            this.colLINK.Visible = true;
            this.colLINK.VisibleIndex = 4;
            // 
            // colISVISABLED
            // 
            this.colISVISABLED.Caption = "是否可显示";
            this.colISVISABLED.FieldName = "ISVISABLED";
            this.colISVISABLED.Name = "colISVISABLED";
            this.colISVISABLED.Visible = true;
            this.colISVISABLED.VisibleIndex = 5;
            // 
            // colMODEL_SORTNO
            // 
            this.colMODEL_SORTNO.Caption = "菜单排序码";
            this.colMODEL_SORTNO.FieldName = "MODEL_SORTNO";
            this.colMODEL_SORTNO.Name = "colMODEL_SORTNO";
            this.colMODEL_SORTNO.Visible = true;
            this.colMODEL_SORTNO.VisibleIndex = 6;
            // 
            // colMODEL_DLL
            // 
            this.colMODEL_DLL.Caption = "菜单模块名称";
            this.colMODEL_DLL.FieldName = "MODEL_DLL";
            this.colMODEL_DLL.Name = "colMODEL_DLL";
            this.colMODEL_DLL.Visible = true;
            this.colMODEL_DLL.VisibleIndex = 7;
            // 
            // colDBTYPE
            // 
            this.colDBTYPE.Caption = "数据库类型";
            this.colDBTYPE.FieldName = "DBTYPE";
            this.colDBTYPE.Name = "colDBTYPE";
            this.colDBTYPE.Visible = true;
            this.colDBTYPE.VisibleIndex = 8;
            // 
            // colSYSTYPE
            // 
            this.colSYSTYPE.Caption = "系统类型ID";
            this.colSYSTYPE.FieldName = "SYSTYPE";
            this.colSYSTYPE.Name = "colSYSTYPE";
            // 
            // colPARENLEV
            // 
            this.colPARENLEV.Caption = "是否有上级菜单";
            this.colPARENLEV.FieldName = "PARENLEV";
            this.colPARENLEV.Name = "colPARENLEV";
            // 
            // colPARENTMODEL
            // 
            this.colPARENTMODEL.Caption = "上级菜单ID";
            this.colPARENTMODEL.FieldName = "PARENTMODEL";
            this.colPARENTMODEL.Name = "colPARENTMODEL";
            // 
            // colCHILDMODE
            // 
            this.colCHILDMODE.Caption = "下级菜单";
            this.colCHILDMODE.FieldName = "CHILDMODE";
            this.colCHILDMODE.Name = "colCHILDMODE";
            // 
            // colSOURMODE
            // 
            this.colSOURMODE.Caption = "上级菜单";
            this.colSOURMODE.FieldName = "SOURMODE";
            this.colSOURMODE.Name = "colSOURMODE";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.toolStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 468);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(797, 28);
            this.panel2.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(797, 28);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // MeunMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1204, 522);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(150, 120);
            this.Name = "MeunMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "菜单管理";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MeunMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpServerCollectionSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_add;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_delete;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_alter;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_look;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_sadd;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnAlter;
        private System.Windows.Forms.ToolStripButton btnLook;
        private System.Windows.Forms.ToolStripButton btnSadd;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.Xpo.XPServerCollectionSource xpServerCollectionSource1;
        private DevExpress.Xpo.UnitOfWork unitOfWork1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colMODELNAME;
        private DevExpress.XtraGrid.Columns.GridColumn colPARENTMODEL;
        private DevExpress.XtraGrid.Columns.GridColumn colLINK;
        private DevExpress.XtraGrid.Columns.GridColumn colISVISABLED;
        private DevExpress.XtraGrid.Columns.GridColumn colMODEL_SORTNO;
        private DevExpress.XtraGrid.Columns.GridColumn colMODEL_DLL;
        private DevExpress.XtraGrid.Columns.GridColumn colSOURMODE;
        private DevExpress.XtraGrid.Columns.GridColumn colPARENLEV;
        private DevExpress.XtraGrid.Columns.GridColumn colCHILDMODE;
        private DevExpress.XtraGrid.Columns.GridColumn colDBTYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colSYSTYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colFATHERNAME;
        private DevExpress.XtraGrid.Columns.GridColumn colTYPENAME;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}