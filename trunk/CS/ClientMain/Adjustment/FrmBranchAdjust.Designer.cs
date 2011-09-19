namespace ClientMain
{
    partial class FrmBranchAdjust
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
            this.btnAdjust = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.cbFinance = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbTaxRate = new DevExpress.XtraEditors.ComboBoxEdit();
            this.tbPrice = new DevExpress.XtraEditors.TextEdit();
            this.tbOldDiscount = new DevExpress.XtraEditors.TextEdit();
            this.tbFloatDiscount = new DevExpress.XtraEditors.TextEdit();
            this.leClient = new DevExpress.XtraEditors.LookUpEdit();
            this.jTJZTBMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cbFinance.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTaxRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbOldDiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFloatDiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leClient.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jTJZTBMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdjust
            // 
            this.btnAdjust.Location = new System.Drawing.Point(169, 351);
            this.btnAdjust.Name = "btnAdjust";
            this.btnAdjust.Size = new System.Drawing.Size(75, 23);
            this.btnAdjust.TabIndex = 0;
            this.btnAdjust.Text = "调整";
            this.btnAdjust.Click += new System.EventHandler(this.btnAdjust_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(318, 351);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Location = new System.Drawing.Point(2, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(204, 14);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "注意：本模块仅对子分公司进行调整！";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(110, 100);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(72, 14);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "请选择客户：";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(110, 47);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(96, 14);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "请选择财务类型：";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(110, 151);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(72, 14);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "请选择税率：";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(110, 201);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(72, 14);
            this.labelControl6.TabIndex = 7;
            this.labelControl6.Text = "请输入码洋：";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(110, 251);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(84, 14);
            this.labelControl7.TabIndex = 8;
            this.labelControl7.Text = "请输入原折扣：";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(110, 301);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(96, 14);
            this.labelControl8.TabIndex = 9;
            this.labelControl8.Text = "请输入浮动折扣：";
            // 
            // cbFinance
            // 
            this.cbFinance.Location = new System.Drawing.Point(225, 40);
            this.cbFinance.Name = "cbFinance";
            this.cbFinance.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbFinance.Properties.Items.AddRange(new object[] {
            "01:一般图书",
            "02:音像制品（音像品）",
            "03:音像制品（软件）"});
            this.cbFinance.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbFinance.Size = new System.Drawing.Size(250, 21);
            this.cbFinance.TabIndex = 12;
            // 
            // cbTaxRate
            // 
            this.cbTaxRate.Location = new System.Drawing.Point(225, 144);
            this.cbTaxRate.Name = "cbTaxRate";
            this.cbTaxRate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTaxRate.Properties.Items.AddRange(new object[] {
            "13",
            "17"});
            this.cbTaxRate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbTaxRate.Size = new System.Drawing.Size(250, 21);
            this.cbTaxRate.TabIndex = 13;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(225, 194);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Properties.Mask.EditMask = "c";
            this.tbPrice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tbPrice.Size = new System.Drawing.Size(250, 21);
            this.tbPrice.TabIndex = 14;
            this.tbPrice.ToolTip = "单位： “元”";
            // 
            // tbOldDiscount
            // 
            this.tbOldDiscount.Location = new System.Drawing.Point(225, 244);
            this.tbOldDiscount.Name = "tbOldDiscount";
            this.tbOldDiscount.Properties.Mask.EditMask = "P";
            this.tbOldDiscount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tbOldDiscount.Size = new System.Drawing.Size(250, 21);
            this.tbOldDiscount.TabIndex = 15;
            this.tbOldDiscount.ToolTip = "单位： “%”";
            // 
            // tbFloatDiscount
            // 
            this.tbFloatDiscount.Location = new System.Drawing.Point(225, 294);
            this.tbFloatDiscount.Name = "tbFloatDiscount";
            this.tbFloatDiscount.Properties.Mask.EditMask = "P";
            this.tbFloatDiscount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tbFloatDiscount.Size = new System.Drawing.Size(250, 21);
            this.tbFloatDiscount.TabIndex = 16;
            this.tbFloatDiscount.ToolTip = "例如：折扣降低请填“-10”，升高：“10”";
            // 
            // leClient
            // 
            this.leClient.Location = new System.Drawing.Point(225, 93);
            this.leClient.Name = "leClient";
            this.leClient.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leClient.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ZTMC", "账套名称", 41, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.leClient.Properties.DataSource = this.jTJZTBMBindingSource;
            this.leClient.Properties.DisplayMember = "ZTMC";
            this.leClient.Properties.NullText = "";
            this.leClient.Properties.ValueMember = "ZTID";
            this.leClient.Size = new System.Drawing.Size(250, 21);
            this.leClient.TabIndex = 17;
            // 
            // FrmBranchAdjust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 402);
            this.Controls.Add(this.leClient);
            this.Controls.Add(this.tbFloatDiscount);
            this.Controls.Add(this.tbOldDiscount);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.cbTaxRate);
            this.Controls.Add(this.cbFinance);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdjust);
            this.Name = "FrmBranchAdjust";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "子分公司折扣调整";
            this.Load += new System.EventHandler(this.FrmBranchAdjust_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbFinance.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTaxRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbOldDiscount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFloatDiscount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leClient.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jTJZTBMBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnAdjust;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.ComboBoxEdit cbFinance;
        private DevExpress.XtraEditors.ComboBoxEdit cbTaxRate;
        private DevExpress.XtraEditors.TextEdit tbPrice;
        private DevExpress.XtraEditors.TextEdit tbOldDiscount;
        private DevExpress.XtraEditors.TextEdit tbFloatDiscount;
        private DevExpress.XtraEditors.LookUpEdit leClient;
        private System.Windows.Forms.BindingSource jTJZTBMBindingSource;
        
    }
}