namespace ClientMain
{
    partial class UserEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserEdit));
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnCannel = new System.Windows.Forms.ToolStripButton();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.panel3 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnQuery = new System.Windows.Forms.Button();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.xpServerCollectionSource1 = new DevExpress.Xpo.XPServerCollectionSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDEPARTMENTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDEPARTMENTNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDEPARTMENTNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZTMC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDWJC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSFZT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKHYH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDESCRIPTION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYTHNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKHDNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJCJCNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDWSX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSJDWID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBMLXID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKHLXID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKFLXID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGYSLXID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCBSLXID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYSCLXID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYSBMLXID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnSelectEmploee = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmploee = new System.Windows.Forms.TextBox();
            this.checkLock = new System.Windows.Forms.CheckBox();
            this.txtDiscri = new System.Windows.Forms.TextBox();
            this.txtCheckpass = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpServerCollectionSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1062, 30);
            this.panel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.btnCannel,
            this.btnExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1062, 30);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(57, 27);
            this.btnSave.Text = "  保存  ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCannel
            // 
            this.btnCannel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCannel.Image = ((System.Drawing.Image)(resources.GetObject("btnCannel.Image")));
            this.btnCannel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCannel.Name = "btnCannel";
            this.btnCannel.Size = new System.Drawing.Size(57, 27);
            this.btnCannel.Text = "  还原  ";
            // 
            // btnExit
            // 
            this.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(69, 27);
            this.btnExit.Text = "   退出   ";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.toolStrip2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 433);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1062, 30);
            this.panel2.TabIndex = 1;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1062, 30);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.splitContainer1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1062, 403);
            this.panel3.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 147);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnQuery);
            this.splitContainer1.Panel1.Controls.Add(this.gridControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.treeView1);
            this.splitContainer1.Size = new System.Drawing.Size(1062, 256);
            this.splitContainer1.SplitterDistance = 699;
            this.splitContainer1.TabIndex = 1;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(3, 6);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 2;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.xpServerCollectionSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(699, 256);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // xpServerCollectionSource1
            // 
            this.xpServerCollectionSource1.ObjectType = typeof(XINHUA.VIEW_SYS_DEPARTMENT);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDEPARTMENTID,
            this.colDEPARTMENTNO,
            this.colDEPARTMENTNAME,
            this.colZTMC,
            this.colDWJC,
            this.colSFZT,
            this.colKHYH,
            this.colSH,
            this.colZH,
            this.colDESCRIPTION,
            this.colDH,
            this.colYTHNO,
            this.colKHDNO,
            this.colJCJCNO,
            this.colDWSX,
            this.colSJDWID,
            this.colBMLXID,
            this.colKHLXID,
            this.colKFLXID,
            this.colGYSLXID,
            this.colCBSLXID,
            this.colYSCLXID,
            this.colYSBMLXID,
            this.colZTID});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsPrint.AutoWidth = false;
            this.gridView1.OptionsPrint.PrintSelectedRowsOnly = true;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            // 
            // colDEPARTMENTID
            // 
            this.colDEPARTMENTID.Caption = "部门ID";
            this.colDEPARTMENTID.FieldName = "DEPARTMENTID";
            this.colDEPARTMENTID.Name = "colDEPARTMENTID";
            this.colDEPARTMENTID.Visible = true;
            this.colDEPARTMENTID.VisibleIndex = 0;
            // 
            // colDEPARTMENTNO
            // 
            this.colDEPARTMENTNO.Caption = "部门编号";
            this.colDEPARTMENTNO.FieldName = "DEPARTMENTNO";
            this.colDEPARTMENTNO.Name = "colDEPARTMENTNO";
            this.colDEPARTMENTNO.Visible = true;
            this.colDEPARTMENTNO.VisibleIndex = 1;
            // 
            // colDEPARTMENTNAME
            // 
            this.colDEPARTMENTNAME.Caption = "部门名称";
            this.colDEPARTMENTNAME.FieldName = "DEPARTMENTNAME";
            this.colDEPARTMENTNAME.Name = "colDEPARTMENTNAME";
            this.colDEPARTMENTNAME.Visible = true;
            this.colDEPARTMENTNAME.VisibleIndex = 2;
            // 
            // colZTMC
            // 
            this.colZTMC.Caption = "所属账套";
            this.colZTMC.FieldName = "ZTMC";
            this.colZTMC.Name = "colZTMC";
            this.colZTMC.Visible = true;
            this.colZTMC.VisibleIndex = 3;
            // 
            // colDWJC
            // 
            this.colDWJC.Caption = "地址";
            this.colDWJC.FieldName = "DWJC";
            this.colDWJC.Name = "colDWJC";
            this.colDWJC.Visible = true;
            this.colDWJC.VisibleIndex = 4;
            // 
            // colSFZT
            // 
            this.colSFZT.Caption = "是否为帐套";
            this.colSFZT.FieldName = "SFZT";
            this.colSFZT.Name = "colSFZT";
            this.colSFZT.Visible = true;
            this.colSFZT.VisibleIndex = 5;
            // 
            // colKHYH
            // 
            this.colKHYH.Caption = "开户银行";
            this.colKHYH.FieldName = "KHYH";
            this.colKHYH.Name = "colKHYH";
            this.colKHYH.Visible = true;
            this.colKHYH.VisibleIndex = 6;
            // 
            // colSH
            // 
            this.colSH.Caption = "税号";
            this.colSH.FieldName = "SH";
            this.colSH.Name = "colSH";
            this.colSH.Visible = true;
            this.colSH.VisibleIndex = 7;
            // 
            // colZH
            // 
            this.colZH.Caption = "帐号";
            this.colZH.FieldName = "ZH";
            this.colZH.Name = "colZH";
            this.colZH.Visible = true;
            this.colZH.VisibleIndex = 8;
            // 
            // colDESCRIPTION
            // 
            this.colDESCRIPTION.Caption = "描述";
            this.colDESCRIPTION.FieldName = "DESCRIPTION";
            this.colDESCRIPTION.Name = "colDESCRIPTION";
            this.colDESCRIPTION.Visible = true;
            this.colDESCRIPTION.VisibleIndex = 9;
            // 
            // colDH
            // 
            this.colDH.Caption = "电话";
            this.colDH.FieldName = "DH";
            this.colDH.Name = "colDH";
            this.colDH.Visible = true;
            this.colDH.VisibleIndex = 10;
            // 
            // colYTHNO
            // 
            this.colYTHNO.Caption = "一体化平台编号";
            this.colYTHNO.FieldName = "YTHNO";
            this.colYTHNO.Name = "colYTHNO";
            this.colYTHNO.Visible = true;
            this.colYTHNO.VisibleIndex = 14;
            // 
            // colKHDNO
            // 
            this.colKHDNO.Caption = "连锁客户端编号";
            this.colKHDNO.FieldName = "KHDNO";
            this.colKHDNO.Name = "colKHDNO";
            this.colKHDNO.Visible = true;
            this.colKHDNO.VisibleIndex = 12;
            // 
            // colJCJCNO
            // 
            this.colJCJCNO.Caption = "基层教材编号";
            this.colJCJCNO.FieldName = "JCJCNO";
            this.colJCJCNO.Name = "colJCJCNO";
            this.colJCJCNO.Visible = true;
            this.colJCJCNO.VisibleIndex = 13;
            // 
            // colDWSX
            // 
            this.colDWSX.Caption = "单位属性";
            this.colDWSX.FieldName = "DWSX";
            this.colDWSX.Name = "colDWSX";
            this.colDWSX.Visible = true;
            this.colDWSX.VisibleIndex = 11;
            // 
            // colSJDWID
            // 
            this.colSJDWID.Caption = "上级单位ID";
            this.colSJDWID.FieldName = "SJDWID";
            this.colSJDWID.Name = "colSJDWID";
            this.colSJDWID.OptionsFilter.AllowFilter = false;
            // 
            // colBMLXID
            // 
            this.colBMLXID.Caption = "部门类型ID";
            this.colBMLXID.FieldName = "BMLXID";
            this.colBMLXID.Name = "colBMLXID";
            this.colBMLXID.OptionsFilter.AllowFilter = false;
            // 
            // colKHLXID
            // 
            this.colKHLXID.Caption = "客户类型ID";
            this.colKHLXID.FieldName = "KHLXID";
            this.colKHLXID.Name = "colKHLXID";
            this.colKHLXID.OptionsFilter.AllowFilter = false;
            // 
            // colKFLXID
            // 
            this.colKFLXID.Caption = "库房类型ID";
            this.colKFLXID.FieldName = "KFLXID";
            this.colKFLXID.Name = "colKFLXID";
            this.colKFLXID.OptionsFilter.AllowFilter = false;
            // 
            // colGYSLXID
            // 
            this.colGYSLXID.Caption = "供应商类型ID";
            this.colGYSLXID.FieldName = "GYSLXID";
            this.colGYSLXID.Name = "colGYSLXID";
            this.colGYSLXID.OptionsFilter.AllowFilter = false;
            // 
            // colCBSLXID
            // 
            this.colCBSLXID.Caption = "出版社类型ID";
            this.colCBSLXID.FieldName = "CBSLXID";
            this.colCBSLXID.Name = "colCBSLXID";
            this.colCBSLXID.OptionsFilter.AllowFilter = false;
            // 
            // colYSCLXID
            // 
            this.colYSCLXID.Caption = "印刷厂类型ID";
            this.colYSCLXID.FieldName = "YSCLXID";
            this.colYSCLXID.Name = "colYSCLXID";
            this.colYSCLXID.OptionsFilter.AllowFilter = false;
            // 
            // colYSBMLXID
            // 
            this.colYSBMLXID.Caption = "运输部门类型ID";
            this.colYSBMLXID.FieldName = "YSBMLXID";
            this.colYSBMLXID.Name = "colYSBMLXID";
            this.colYSBMLXID.OptionsFilter.AllowFilter = false;
            // 
            // colZTID
            // 
            this.colZTID.Caption = "所属账套ID";
            this.colZTID.FieldName = "ZTID";
            this.colZTID.Name = "colZTID";
            this.colZTID.OptionsFilter.AllowFilter = false;
            // 
            // treeView1
            // 
            this.treeView1.AllowDrop = true;
            this.treeView1.CheckBoxes = true;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(359, 256);
            this.treeView1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1062, 147);
            this.panel4.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.btnSelectEmploee);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtEmploee);
            this.groupBox1.Controls.Add(this.checkLock);
            this.groupBox1.Controls.Add(this.txtDiscri);
            this.groupBox1.Controls.Add(this.txtCheckpass);
            this.groupBox1.Controls.Add(this.txtPass);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1062, 147);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本信息";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(861, 6);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 138);
            this.listView1.TabIndex = 21;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.Visible = false;
            // 
            // btnSelectEmploee
            // 
            this.btnSelectEmploee.Location = new System.Drawing.Point(405, 32);
            this.btnSelectEmploee.Name = "btnSelectEmploee";
            this.btnSelectEmploee.Size = new System.Drawing.Size(75, 23);
            this.btnSelectEmploee.TabIndex = 20;
            this.btnSelectEmploee.Text = "绑定员工";
            this.btnSelectEmploee.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(416, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 19;
            this.label4.Text = "密码确认";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 18;
            this.label3.Text = "描述";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "密码";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "登录名";
            // 
            // txtEmploee
            // 
            this.txtEmploee.Location = new System.Drawing.Point(486, 32);
            this.txtEmploee.Name = "txtEmploee";
            this.txtEmploee.ReadOnly = true;
            this.txtEmploee.Size = new System.Drawing.Size(284, 21);
            this.txtEmploee.TabIndex = 15;
            // 
            // checkLock
            // 
            this.checkLock.AutoSize = true;
            this.checkLock.Location = new System.Drawing.Point(408, 99);
            this.checkLock.Name = "checkLock";
            this.checkLock.Size = new System.Drawing.Size(72, 16);
            this.checkLock.TabIndex = 14;
            this.checkLock.Text = "是否锁定";
            this.checkLock.UseVisualStyleBackColor = true;
            // 
            // txtDiscri
            // 
            this.txtDiscri.Location = new System.Drawing.Point(91, 94);
            this.txtDiscri.Name = "txtDiscri";
            this.txtDiscri.Size = new System.Drawing.Size(284, 21);
            this.txtDiscri.TabIndex = 13;
            // 
            // txtCheckpass
            // 
            this.txtCheckpass.Location = new System.Drawing.Point(486, 64);
            this.txtCheckpass.Name = "txtCheckpass";
            this.txtCheckpass.Size = new System.Drawing.Size(284, 21);
            this.txtCheckpass.TabIndex = 12;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(91, 64);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(284, 21);
            this.txtPass.TabIndex = 11;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(91, 32);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(284, 21);
            this.txtName.TabIndex = 10;
            // 
            // UserEdit1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 463);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UserEdit1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户管理修改";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UserEdit1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpServerCollectionSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnCannel;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnSelectEmploee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmploee;
        private System.Windows.Forms.CheckBox checkLock;
        private System.Windows.Forms.TextBox txtDiscri;
        private System.Windows.Forms.TextBox txtCheckpass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colDEPARTMENTID;
        private DevExpress.XtraGrid.Columns.GridColumn colDEPARTMENTNO;
        private DevExpress.XtraGrid.Columns.GridColumn colDEPARTMENTNAME;
        private DevExpress.XtraGrid.Columns.GridColumn colZTMC;
        private DevExpress.XtraGrid.Columns.GridColumn colDWJC;
        private DevExpress.XtraGrid.Columns.GridColumn colSFZT;
        private DevExpress.XtraGrid.Columns.GridColumn colKHYH;
        private DevExpress.XtraGrid.Columns.GridColumn colSH;
        private DevExpress.XtraGrid.Columns.GridColumn colZH;
        private DevExpress.XtraGrid.Columns.GridColumn colDESCRIPTION;
        private DevExpress.XtraGrid.Columns.GridColumn colDH;
        private DevExpress.XtraGrid.Columns.GridColumn colYTHNO;
        private DevExpress.XtraGrid.Columns.GridColumn colKHDNO;
        private DevExpress.XtraGrid.Columns.GridColumn colJCJCNO;
        private DevExpress.XtraGrid.Columns.GridColumn colDWSX;
        private DevExpress.XtraGrid.Columns.GridColumn colSJDWID;
        private DevExpress.XtraGrid.Columns.GridColumn colBMLXID;
        private DevExpress.XtraGrid.Columns.GridColumn colKHLXID;
        private DevExpress.XtraGrid.Columns.GridColumn colKFLXID;
        private DevExpress.XtraGrid.Columns.GridColumn colGYSLXID;
        private DevExpress.XtraGrid.Columns.GridColumn colCBSLXID;
        private DevExpress.XtraGrid.Columns.GridColumn colYSCLXID;
        private DevExpress.XtraGrid.Columns.GridColumn colYSBMLXID;
        private DevExpress.XtraGrid.Columns.GridColumn colZTID;
        private DevExpress.Xpo.XPServerCollectionSource xpServerCollectionSource1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnQuery;
    }
}