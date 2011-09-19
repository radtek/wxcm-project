namespace ClientMain
{
    partial class FrmDiscountCorrection
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.teOldDiscount = new DevExpress.XtraEditors.TextEdit();
            this.teNewDiscout = new DevExpress.XtraEditors.TextEdit();
            this.btnYes = new DevExpress.XtraEditors.SimpleButton();
            this.btnNo = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.teOldDiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNewDiscout.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(71, 50);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "原折扣：";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(71, 112);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "新折扣：";
            // 
            // teOldDiscount
            // 
            this.teOldDiscount.Enabled = false;
            this.teOldDiscount.Location = new System.Drawing.Point(151, 43);
            this.teOldDiscount.Name = "teOldDiscount";
            this.teOldDiscount.Properties.Mask.EditMask = "P";
            this.teOldDiscount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.teOldDiscount.Size = new System.Drawing.Size(149, 21);
            this.teOldDiscount.TabIndex = 2;
            // 
            // teNewDiscout
            // 
            this.teNewDiscout.Location = new System.Drawing.Point(151, 105);
            this.teNewDiscout.Name = "teNewDiscout";
            this.teNewDiscout.Properties.Mask.EditMask = "P";
            this.teNewDiscout.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.teNewDiscout.Size = new System.Drawing.Size(149, 21);
            this.teNewDiscout.TabIndex = 3;
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(71, 176);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(75, 23);
            this.btnYes.TabIndex = 4;
            this.btnYes.Text = "确定";
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(225, 176);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(75, 23);
            this.btnNo.TabIndex = 5;
            this.btnNo.Text = "取消";
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // FrmDiscountCorrection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 242);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.teNewDiscout);
            this.Controls.Add(this.teOldDiscount);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmDiscountCorrection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "折扣更正";
            ((System.ComponentModel.ISupportInitialize)(this.teOldDiscount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNewDiscout.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit teOldDiscount;
        private DevExpress.XtraEditors.TextEdit teNewDiscout;
        private DevExpress.XtraEditors.SimpleButton btnYes;
        private DevExpress.XtraEditors.SimpleButton btnNo;
    }
}