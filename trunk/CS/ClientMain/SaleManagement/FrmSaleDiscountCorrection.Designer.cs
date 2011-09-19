namespace ClientMain
{
    partial class FrmSaleDiscountCorrection
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
            this.btnNo = new DevExpress.XtraEditors.SimpleButton();
            this.btnYes = new DevExpress.XtraEditors.SimpleButton();
            this.teNewDiscout = new DevExpress.XtraEditors.TextEdit();
            this.teOldDiscount = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.teNewDiscout.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teOldDiscount.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(253, 186);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(75, 23);
            this.btnNo.TabIndex = 11;
            this.btnNo.Text = "取消";
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(99, 186);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(75, 23);
            this.btnYes.TabIndex = 10;
            this.btnYes.Text = "确定";
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // teNewDiscout
            // 
            this.teNewDiscout.Location = new System.Drawing.Point(179, 115);
            this.teNewDiscout.Name = "teNewDiscout";
            this.teNewDiscout.Properties.Mask.EditMask = "P";
            this.teNewDiscout.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.teNewDiscout.Size = new System.Drawing.Size(149, 21);
            this.teNewDiscout.TabIndex = 9;
            // 
            // teOldDiscount
            // 
            this.teOldDiscount.Enabled = false;
            this.teOldDiscount.Location = new System.Drawing.Point(179, 53);
            this.teOldDiscount.Name = "teOldDiscount";
            this.teOldDiscount.Properties.Mask.EditMask = "P";
            this.teOldDiscount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.teOldDiscount.Size = new System.Drawing.Size(149, 21);
            this.teOldDiscount.TabIndex = 8;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(99, 122);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "新销折：";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(99, 60);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "原销折：";
            // 
            // FrmSaleDiscountCorrection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 262);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.teNewDiscout);
            this.Controls.Add(this.teOldDiscount);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmSaleDiscountCorrection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "销售单更正";
            ((System.ComponentModel.ISupportInitialize)(this.teNewDiscout.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teOldDiscount.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnNo;
        private DevExpress.XtraEditors.SimpleButton btnYes;
        private DevExpress.XtraEditors.TextEdit teNewDiscout;
        private DevExpress.XtraEditors.TextEdit teOldDiscount;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}