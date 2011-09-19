namespace ClientMain
{
    partial class FrmUnusualStockInputAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUnusualStockInputAdd));
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSaveExit = new System.Windows.Forms.ToolStripButton();
            this.btnSaveGoon = new System.Windows.Forms.ToolStripButton();
            this.btnReset = new System.Windows.Forms.ToolStripButton();
            this.btnAlterExit = new System.Windows.Forms.ToolStripButton();
            this.btnReload = new System.Windows.Forms.ToolStripButton();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtCZYMC = new System.Windows.Forms.TextBox();
            this.txtECCS = new System.Windows.Forms.TextBox();
            this.txtZTIDMC = new System.Windows.Forms.TextBox();
            this.txtPM = new System.Windows.Forms.TextBox();
            this.txtDJ = new System.Windows.Forms.TextBox();
            this.txtSPBH = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(665, 27);
            this.panel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSaveExit,
            this.btnSaveGoon,
            this.btnReset,
            this.btnAlterExit,
            this.btnReload,
            this.btnExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(665, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSaveExit
            // 
            this.btnSaveExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSaveExit.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveExit.Image")));
            this.btnSaveExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveExit.Name = "btnSaveExit";
            this.btnSaveExit.Size = new System.Drawing.Size(57, 24);
            this.btnSaveExit.Text = "保存退出";
            this.btnSaveExit.Click += new System.EventHandler(this.btnSaveExit_Click);
            // 
            // btnSaveGoon
            // 
            this.btnSaveGoon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSaveGoon.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveGoon.Image")));
            this.btnSaveGoon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveGoon.Name = "btnSaveGoon";
            this.btnSaveGoon.Size = new System.Drawing.Size(57, 24);
            this.btnSaveGoon.Text = "保存继续";
            this.btnSaveGoon.Click += new System.EventHandler(this.btnSaveGoon_Click);
            // 
            // btnReset
            // 
            this.btnReset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(33, 24);
            this.btnReset.Text = "重置";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAlterExit
            // 
            this.btnAlterExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAlterExit.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterExit.Image")));
            this.btnAlterExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAlterExit.Name = "btnAlterExit";
            this.btnAlterExit.Size = new System.Drawing.Size(69, 24);
            this.btnAlterExit.Text = "修改完退出";
            this.btnAlterExit.Click += new System.EventHandler(this.btnAlterExit_Click);
            // 
            // btnReload
            // 
            this.btnReload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
            this.btnReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(33, 24);
            this.btnReload.Text = "还原";
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnExit
            // 
            this.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(33, 24);
            this.btnExit.Text = "退出";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.dateTimePicker1);
            this.panelControl1.Controls.Add(this.txtCZYMC);
            this.panelControl1.Controls.Add(this.txtECCS);
            this.panelControl1.Controls.Add(this.txtZTIDMC);
            this.panelControl1.Controls.Add(this.txtPM);
            this.panelControl1.Controls.Add(this.txtDJ);
            this.panelControl1.Controls.Add(this.txtSPBH);
            this.panelControl1.Controls.Add(this.label8);
            this.panelControl1.Controls.Add(this.label7);
            this.panelControl1.Controls.Add(this.label6);
            this.panelControl1.Controls.Add(this.label5);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 27);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(665, 253);
            this.panelControl1.TabIndex = 1;
            // 
            // txtCZYMC
            // 
            this.txtCZYMC.Location = new System.Drawing.Point(391, 159);
            this.txtCZYMC.Name = "txtCZYMC";
            this.txtCZYMC.ReadOnly = true;
            this.txtCZYMC.Size = new System.Drawing.Size(244, 22);
            this.txtCZYMC.TabIndex = 14;
            // 
            // txtECCS
            // 
            this.txtECCS.Location = new System.Drawing.Point(92, 161);
            this.txtECCS.Name = "txtECCS";
            this.txtECCS.Size = new System.Drawing.Size(244, 22);
            this.txtECCS.TabIndex = 13;
            // 
            // txtZTIDMC
            // 
            this.txtZTIDMC.Location = new System.Drawing.Point(92, 131);
            this.txtZTIDMC.Name = "txtZTIDMC";
            this.txtZTIDMC.ReadOnly = true;
            this.txtZTIDMC.Size = new System.Drawing.Size(543, 22);
            this.txtZTIDMC.TabIndex = 12;
            // 
            // txtPM
            // 
            this.txtPM.Location = new System.Drawing.Point(92, 98);
            this.txtPM.Name = "txtPM";
            this.txtPM.ReadOnly = true;
            this.txtPM.Size = new System.Drawing.Size(543, 22);
            this.txtPM.TabIndex = 11;
            // 
            // txtDJ
            // 
            this.txtDJ.Location = new System.Drawing.Point(391, 60);
            this.txtDJ.Name = "txtDJ";
            this.txtDJ.ReadOnly = true;
            this.txtDJ.Size = new System.Drawing.Size(244, 22);
            this.txtDJ.TabIndex = 10;
            // 
            // txtSPBH
            // 
            this.txtSPBH.Location = new System.Drawing.Point(92, 63);
            this.txtSPBH.Name = "txtSPBH";
            this.txtSPBH.Size = new System.Drawing.Size(244, 22);
            this.txtSPBH.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 14);
            this.label8.TabIndex = 8;
            this.label8.Text = "操作日期";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(342, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 14);
            this.label7.TabIndex = 7;
            this.label7.Text = "操作员";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 14);
            this.label6.TabIndex = 6;
            this.label6.Text = "异常册数";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 14);
            this.label5.TabIndex = 5;
            this.label5.Text = "品名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "定价";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "帐套";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "商品编号";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "非正常库存录入功能";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(91, 194);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(245, 22);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // FrmUnusualStockInputAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 280);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUnusualStockInputAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "非正常库存录入功能";
            this.Load += new System.EventHandler(this.FrmUnusualStockInputAdd_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCZYMC;
        private System.Windows.Forms.TextBox txtECCS;
        private System.Windows.Forms.TextBox txtZTIDMC;
        private System.Windows.Forms.TextBox txtPM;
        private System.Windows.Forms.TextBox txtDJ;
        private System.Windows.Forms.TextBox txtSPBH;
        private System.Windows.Forms.ToolStripButton btnSaveExit;
        private System.Windows.Forms.ToolStripButton btnSaveGoon;
        private System.Windows.Forms.ToolStripButton btnReset;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripButton btnAlterExit;
        private System.Windows.Forms.ToolStripButton btnReload;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}