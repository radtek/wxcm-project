namespace ClientMain
{
    partial class FrmSupplierAdjust
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
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdjust = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tbPrice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.cbFinance = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbTaxRate = new DevExpress.XtraEditors.ComboBoxEdit();
            this.tbOldDiscount = new DevExpress.XtraEditors.TextEdit();
            this.tbFloatDiscount = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.leSupplier = new DevExpress.XtraEditors.LookUpEdit();
            this.jTJDWXXBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tbPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFinance.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTaxRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbOldDiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFloatDiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leSupplier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jTJDWXXBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(313, 353);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdjust
            // 
            this.btnAdjust.Location = new System.Drawing.Point(164, 353);
            this.btnAdjust.Name = "btnAdjust";
            this.btnAdjust.Size = new System.Drawing.Size(75, 23);
            this.btnAdjust.TabIndex = 2;
            this.btnAdjust.Text = "调整";
            this.btnAdjust.Click += new System.EventHandler(this.btnAdjust_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(110, 104);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(84, 14);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "请选择供应商：";
            // 
            // tbPrice
            // 
            this.tbPrice.EditValue = "";
            this.tbPrice.Location = new System.Drawing.Point(225, 196);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.tbPrice.Properties.Appearance.Options.UseForeColor = true;
            this.tbPrice.Properties.Mask.EditMask = "c";
            this.tbPrice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tbPrice.Size = new System.Drawing.Size(250, 21);
            this.tbPrice.TabIndex = 5;
            this.tbPrice.ToolTip = "单位： “元”";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(110, 51);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(96, 14);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "请选择财务类型：";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(110, 153);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(72, 14);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "请选择税率：";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(110, 203);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(72, 14);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "请输入码洋：";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(110, 253);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(84, 14);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "请输入原折扣：";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(110, 303);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(96, 14);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "请输入浮动折扣：";
            // 
            // cbFinance
            // 
            this.cbFinance.Location = new System.Drawing.Point(225, 44);
            this.cbFinance.Name = "cbFinance";
            this.cbFinance.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbFinance.Properties.Items.AddRange(new object[] {
            "01:一般图书",
            "02:音像制品（音像品）",
            "03:音像制品（软件）"});
            this.cbFinance.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbFinance.Size = new System.Drawing.Size(250, 21);
            this.cbFinance.TabIndex = 14;
            // 
            // cbTaxRate
            // 
            this.cbTaxRate.Location = new System.Drawing.Point(225, 146);
            this.cbTaxRate.Name = "cbTaxRate";
            this.cbTaxRate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTaxRate.Properties.Items.AddRange(new object[] {
            "13",
            "17"});
            this.cbTaxRate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbTaxRate.Size = new System.Drawing.Size(250, 21);
            this.cbTaxRate.TabIndex = 15;
            // 
            // tbOldDiscount
            // 
            this.tbOldDiscount.Location = new System.Drawing.Point(225, 246);
            this.tbOldDiscount.Name = "tbOldDiscount";
            this.tbOldDiscount.Properties.Mask.EditMask = "P";
            this.tbOldDiscount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tbOldDiscount.Size = new System.Drawing.Size(250, 21);
            this.tbOldDiscount.TabIndex = 16;
            this.tbOldDiscount.ToolTip = "单位： “%”";
            // 
            // tbFloatDiscount
            // 
            this.tbFloatDiscount.Location = new System.Drawing.Point(225, 296);
            this.tbFloatDiscount.Name = "tbFloatDiscount";
            this.tbFloatDiscount.Properties.Mask.EditMask = "P";
            this.tbFloatDiscount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tbFloatDiscount.Size = new System.Drawing.Size(250, 21);
            this.tbFloatDiscount.TabIndex = 17;
            this.tbFloatDiscount.ToolTip = "例如：折扣降低请填“-10”，升高：“10”";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl8.Location = new System.Drawing.Point(2, 3);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(192, 14);
            this.labelControl8.TabIndex = 18;
            this.labelControl8.Text = "注意：本模块仅对供应商进行调整！";
            // 
            // leSupplier
            // 
            this.leSupplier.Location = new System.Drawing.Point(225, 97);
            this.leSupplier.Name = "leSupplier";
            this.leSupplier.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leSupplier.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DWMC", "单位名称", 46, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.leSupplier.Properties.DataSource = this.jTJDWXXBindingSource;
            this.leSupplier.Properties.DisplayMember = "DWMC";
            this.leSupplier.Properties.NullText = "";
            this.leSupplier.Properties.ValueMember = "DWID";
            this.leSupplier.Size = new System.Drawing.Size(250, 21);
            this.leSupplier.TabIndex = 19;
            // 
            // jTJDWXXBindingSource
            // 
            this.jTJDWXXBindingSource.DataMember = "JT_J_DWXX";
            // 
            // FrmSupplierAdjust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 401);
            this.Controls.Add(this.leSupplier);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.tbFloatDiscount);
            this.Controls.Add(this.tbOldDiscount);
            this.Controls.Add(this.cbTaxRate);
            this.Controls.Add(this.cbFinance);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdjust);
            this.Name = "FrmSupplierAdjust";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "供应商折扣调整";
            this.Load += new System.EventHandler(this.FrmSupplierAdjust_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFinance.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTaxRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbOldDiscount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFloatDiscount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leSupplier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jTJDWXXBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnAdjust;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit tbPrice;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.ComboBoxEdit cbFinance;
        private DevExpress.XtraEditors.ComboBoxEdit cbTaxRate;
        private DevExpress.XtraEditors.TextEdit tbOldDiscount;
        private DevExpress.XtraEditors.TextEdit tbFloatDiscount;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LookUpEdit leSupplier;
        private System.Windows.Forms.BindingSource jTJDWXXBindingSource;
    }
}