namespace ClientMain
{
    partial class FrmUnusualStockInput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUnusualStockInput));
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnADD = new System.Windows.Forms.ToolStripButton();
            this.btnAlter = new System.Windows.Forms.ToolStripButton();
            this.btnLook = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnCirfrom = new System.Windows.Forms.ToolStripButton();
            this.btnInquire = new System.Windows.Forms.ToolStripButton();
            this.btnInput = new System.Windows.Forms.ToolStripButton();
            this.btnOutputMod = new System.Windows.Forms.ToolStripButton();
            this.btnPrintTable = new System.Windows.Forms.ToolStripButton();
            this.btnExportGrid = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.xpServerCollectionSource1 = new DevExpress.Xpo.XPServerCollectionSource();
            this.unitOfWork1 = new DevExpress.Xpo.UnitOfWork();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colYCKCID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSPXXID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCZYID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZTIDMC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSPBH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSPMC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDJ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYCCS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKTCS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYTCS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCZRQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCLZT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCZYMC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGYSID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBDWID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCLZTMC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(839, 23);
            this.panel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnADD,
            this.btnAlter,
            this.btnLook,
            this.btnDelete,
            this.btnCirfrom,
            this.btnInquire,
            this.btnInput,
            this.btnOutputMod,
            this.btnPrintTable,
            this.btnExportGrid});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(839, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnADD
            // 
            this.btnADD.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnADD.Image = ((System.Drawing.Image)(resources.GetObject("btnADD.Image")));
            this.btnADD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(45, 22);
            this.btnADD.Text = " 新增 ";
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // btnAlter
            // 
            this.btnAlter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAlter.Image = ((System.Drawing.Image)(resources.GetObject("btnAlter.Image")));
            this.btnAlter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.Size = new System.Drawing.Size(45, 22);
            this.btnAlter.Text = " 修改 ";
            this.btnAlter.Click += new System.EventHandler(this.btnAlter_Click);
            // 
            // btnLook
            // 
            this.btnLook.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnLook.Image = ((System.Drawing.Image)(resources.GetObject("btnLook.Image")));
            this.btnLook.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLook.Name = "btnLook";
            this.btnLook.Size = new System.Drawing.Size(45, 22);
            this.btnLook.Text = " 查看 ";
            this.btnLook.Click += new System.EventHandler(this.btnLook_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(45, 22);
            this.btnDelete.Text = " 删除 ";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCirfrom
            // 
            this.btnCirfrom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCirfrom.Image = ((System.Drawing.Image)(resources.GetObject("btnCirfrom.Image")));
            this.btnCirfrom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCirfrom.Name = "btnCirfrom";
            this.btnCirfrom.Size = new System.Drawing.Size(45, 22);
            this.btnCirfrom.Text = " 确认 ";
            this.btnCirfrom.Click += new System.EventHandler(this.btnCirfrom_Click);
            // 
            // btnInquire
            // 
            this.btnInquire.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnInquire.Image = ((System.Drawing.Image)(resources.GetObject("btnInquire.Image")));
            this.btnInquire.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInquire.Name = "btnInquire";
            this.btnInquire.Size = new System.Drawing.Size(45, 22);
            this.btnInquire.Text = " 查询 ";
            this.btnInquire.Click += new System.EventHandler(this.btnInquire_Click);
            // 
            // btnInput
            // 
            this.btnInput.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnInput.Image = ((System.Drawing.Image)(resources.GetObject("btnInput.Image")));
            this.btnInput.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(45, 22);
            this.btnInput.Text = " 导入 ";
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnOutputMod
            // 
            this.btnOutputMod.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnOutputMod.Image = ((System.Drawing.Image)(resources.GetObject("btnOutputMod.Image")));
            this.btnOutputMod.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOutputMod.Name = "btnOutputMod";
            this.btnOutputMod.Size = new System.Drawing.Size(57, 22);
            this.btnOutputMod.Text = "导出模板";
            this.btnOutputMod.Click += new System.EventHandler(this.btnOutputMod_Click);
            // 
            // btnPrintTable
            // 
            this.btnPrintTable.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintTable.Image")));
            this.btnPrintTable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrintTable.Name = "btnPrintTable";
            this.btnPrintTable.Size = new System.Drawing.Size(73, 22);
            this.btnPrintTable.Text = "打印表格";
            this.btnPrintTable.Click += new System.EventHandler(this.btnPrintTable_Click);
            // 
            // btnExportGrid
            // 
            this.btnExportGrid.Image = ((System.Drawing.Image)(resources.GetObject("btnExportGrid.Image")));
            this.btnExportGrid.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExportGrid.Name = "btnExportGrid";
            this.btnExportGrid.Size = new System.Drawing.Size(73, 22);
            this.btnExportGrid.Text = "导出表格";
            this.btnExportGrid.Click += new System.EventHandler(this.btnExportGrid_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.toolStrip2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 283);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(839, 23);
            this.panel2.TabIndex = 1;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(839, 23);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 23);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(839, 260);
            this.panelControl1.TabIndex = 2;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.xpServerCollectionSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(835, 256);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // xpServerCollectionSource1
            // 
            this.xpServerCollectionSource1.ObjectType = typeof(XINHUA.VIEW_JC_C_YCKC);
            this.xpServerCollectionSource1.Session = this.unitOfWork1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colYCKCID,
            this.colSPXXID,
            this.colZTID,
            this.colCZYID,
            this.colZTIDMC,
            this.colSPBH,
            this.colSPMC,
            this.colDJ,
            this.colYCCS,
            this.colKTCS,
            this.colYTCS,
            this.colCZRQ,
            this.colCLZT,
            this.colCZYMC,
            this.colGYSID,
            this.colBDWID,
            this.colCLZTMC});
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
            // colYCKCID
            // 
            this.colYCKCID.Caption = "异常库存ID";
            this.colYCKCID.FieldName = "YCKCID";
            this.colYCKCID.Name = "colYCKCID";
            this.colYCKCID.OptionsFilter.AllowFilter = false;
            // 
            // colSPXXID
            // 
            this.colSPXXID.Caption = "商品信息ID";
            this.colSPXXID.FieldName = "SPXXID";
            this.colSPXXID.Name = "colSPXXID";
            this.colSPXXID.OptionsFilter.AllowFilter = false;
            // 
            // colZTID
            // 
            this.colZTID.Caption = "帐套ID";
            this.colZTID.FieldName = "ZTID";
            this.colZTID.Name = "colZTID";
            this.colZTID.OptionsFilter.AllowFilter = false;
            // 
            // colCZYID
            // 
            this.colCZYID.Caption = "操作员ID";
            this.colCZYID.FieldName = "CZYID";
            this.colCZYID.Name = "colCZYID";
            this.colCZYID.OptionsFilter.AllowFilter = false;
            // 
            // colZTIDMC
            // 
            this.colZTIDMC.Caption = "帐套";
            this.colZTIDMC.FieldName = "ZTIDMC";
            this.colZTIDMC.Name = "colZTIDMC";
            // 
            // colSPBH
            // 
            this.colSPBH.Caption = "商品编号";
            this.colSPBH.FieldName = "SPBH";
            this.colSPBH.Name = "colSPBH";
            this.colSPBH.SummaryItem.DisplayFormat = "总计：";
            this.colSPBH.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Custom;
            this.colSPBH.Visible = true;
            this.colSPBH.VisibleIndex = 0;
            // 
            // colSPMC
            // 
            this.colSPMC.Caption = "商品品名";
            this.colSPMC.FieldName = "SPMC";
            this.colSPMC.Name = "colSPMC";
            this.colSPMC.Visible = true;
            this.colSPMC.VisibleIndex = 1;
            // 
            // colDJ
            // 
            this.colDJ.Caption = "定价";
            this.colDJ.FieldName = "DJ";
            this.colDJ.Name = "colDJ";
            this.colDJ.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colDJ.Visible = true;
            this.colDJ.VisibleIndex = 2;
            // 
            // colYCCS
            // 
            this.colYCCS.Caption = "异常册数";
            this.colYCCS.FieldName = "YCCS";
            this.colYCCS.Name = "colYCCS";
            this.colYCCS.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colYCCS.Visible = true;
            this.colYCCS.VisibleIndex = 3;
            // 
            // colKTCS
            // 
            this.colKTCS.Caption = "可退册数";
            this.colKTCS.FieldName = "KTCS";
            this.colKTCS.Name = "colKTCS";
            this.colKTCS.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colKTCS.Visible = true;
            this.colKTCS.VisibleIndex = 4;
            // 
            // colYTCS
            // 
            this.colYTCS.Caption = "已退册数";
            this.colYTCS.FieldName = "YTCS";
            this.colYTCS.Name = "colYTCS";
            this.colYTCS.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colYTCS.Visible = true;
            this.colYTCS.VisibleIndex = 5;
            // 
            // colCZRQ
            // 
            this.colCZRQ.Caption = "操作日期";
            this.colCZRQ.FieldName = "CZRQ";
            this.colCZRQ.Name = "colCZRQ";
            this.colCZRQ.Visible = true;
            this.colCZRQ.VisibleIndex = 6;
            // 
            // colCLZT
            // 
            this.colCLZT.Caption = "处理状态ID";
            this.colCLZT.FieldName = "CLZT";
            this.colCLZT.Name = "colCLZT";
            this.colCLZT.Visible = true;
            this.colCLZT.VisibleIndex = 7;
            // 
            // colCZYMC
            // 
            this.colCZYMC.Caption = "操作员";
            this.colCZYMC.FieldName = "CZYMC";
            this.colCZYMC.Name = "colCZYMC";
            this.colCZYMC.Visible = true;
            this.colCZYMC.VisibleIndex = 8;
            // 
            // colGYSID
            // 
            this.colGYSID.Caption = "供应商ID";
            this.colGYSID.FieldName = "GYSID";
            this.colGYSID.Name = "colGYSID";
            this.colGYSID.OptionsFilter.AllowFilter = false;
            // 
            // colBDWID
            // 
            this.colBDWID.Caption = "本单位ID";
            this.colBDWID.FieldName = "BDWID";
            this.colBDWID.Name = "colBDWID";
            this.colBDWID.OptionsFilter.AllowFilter = false;
            // 
            // colCLZTMC
            // 
            this.colCLZTMC.Caption = "处理状态";
            this.colCLZTMC.FieldName = "CLZTMC";
            this.colCLZTMC.Name = "colCLZTMC";
            this.colCLZTMC.Visible = true;
            this.colCLZTMC.VisibleIndex = 9;
            // 
            // FrmUnusualStockInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 306);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmUnusualStockInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "异常库存管理——录入";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmUnusualStockInput_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpServerCollectionSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnADD;
        private System.Windows.Forms.ToolStripButton btnAlter;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnCirfrom;
        private System.Windows.Forms.ToolStripButton btnInquire;
        private System.Windows.Forms.ToolStripButton btnInput;
        private System.Windows.Forms.ToolStripButton btnPrintTable;
        private System.Windows.Forms.ToolStripButton btnExportGrid;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.Xpo.XPServerCollectionSource xpServerCollectionSource1;
        private DevExpress.Xpo.UnitOfWork unitOfWork1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private DevExpress.XtraGrid.Columns.GridColumn colYCKCID;
        private DevExpress.XtraGrid.Columns.GridColumn colSPXXID;
        private DevExpress.XtraGrid.Columns.GridColumn colZTID;
        private DevExpress.XtraGrid.Columns.GridColumn colSPMC;
        private DevExpress.XtraGrid.Columns.GridColumn colYCCS;
        private DevExpress.XtraGrid.Columns.GridColumn colCZYID;
        private DevExpress.XtraGrid.Columns.GridColumn colCZRQ;
        private DevExpress.XtraGrid.Columns.GridColumn colCLZT;
        private DevExpress.XtraGrid.Columns.GridColumn colKTCS;
        private DevExpress.XtraGrid.Columns.GridColumn colYTCS;
        private DevExpress.XtraGrid.Columns.GridColumn colZTIDMC;
        private DevExpress.XtraGrid.Columns.GridColumn colCZYMC;
        private DevExpress.XtraGrid.Columns.GridColumn colSPBH;
        private DevExpress.XtraGrid.Columns.GridColumn colDJ;
        private DevExpress.XtraGrid.Columns.GridColumn colGYSID;
        private DevExpress.XtraGrid.Columns.GridColumn colBDWID;
        private System.Windows.Forms.ToolStripButton btnOutputMod;
        private System.Windows.Forms.ToolStripButton btnLook;
        private DevExpress.XtraGrid.Columns.GridColumn colCLZTMC;
    }
}