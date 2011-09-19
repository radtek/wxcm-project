namespace ClientMain
{
    partial class FrmTuoShouData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTuoShouData));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnQueRen = new System.Windows.Forms.ToolStripButton();
            this.btnZhiKong = new System.Windows.Forms.ToolStripButton();
            this.txtInputNumber = new System.Windows.Forms.TextBox();
            this.btnTuiChu = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panel1);
            this.panelControl1.Controls.Add(this.txtInputNumber);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(465, 128);
            this.panelControl1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 29);
            this.panel1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnQueRen,
            this.btnZhiKong,
            this.btnTuiChu});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(461, 29);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnQueRen
            // 
            this.btnQueRen.Image = ((System.Drawing.Image)(resources.GetObject("btnQueRen.Image")));
            this.btnQueRen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQueRen.Name = "btnQueRen";
            this.btnQueRen.Size = new System.Drawing.Size(49, 26);
            this.btnQueRen.Text = "确认";
            this.btnQueRen.Click += new System.EventHandler(this.btnQueRen_Click);
            // 
            // btnZhiKong
            // 
            this.btnZhiKong.Image = ((System.Drawing.Image)(resources.GetObject("btnZhiKong.Image")));
            this.btnZhiKong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnZhiKong.Name = "btnZhiKong";
            this.btnZhiKong.Size = new System.Drawing.Size(49, 26);
            this.btnZhiKong.Text = "置空";
            this.btnZhiKong.Click += new System.EventHandler(this.btnZhiKong_Click);
            // 
            // txtInputNumber
            // 
            this.txtInputNumber.Location = new System.Drawing.Point(42, 51);
            this.txtInputNumber.Name = "txtInputNumber";
            this.txtInputNumber.Size = new System.Drawing.Size(393, 21);
            this.txtInputNumber.TabIndex = 0;
            // 
            // btnTuiChu
            // 
            this.btnTuiChu.Image = ((System.Drawing.Image)(resources.GetObject("btnTuiChu.Image")));
            this.btnTuiChu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTuiChu.Name = "btnTuiChu";
            this.btnTuiChu.Size = new System.Drawing.Size(49, 26);
            this.btnTuiChu.Text = "退出";
            this.btnTuiChu.Click += new System.EventHandler(this.btnTuiChu_Click);
            // 
            // FrmTuoShouData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 128);
            this.Controls.Add(this.panelControl1);
            this.MaximizeBox = false;
            this.Name = "FrmTuoShouData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "托收限额";
            this.Load += new System.EventHandler(this.FrmTuoShouData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.TextBox txtInputNumber;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnQueRen;
        private System.Windows.Forms.ToolStripButton btnZhiKong;
        private System.Windows.Forms.ToolStripButton btnTuiChu;

    }
}