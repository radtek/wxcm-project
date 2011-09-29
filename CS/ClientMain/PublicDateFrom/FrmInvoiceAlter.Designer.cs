namespace ClientMain
{
    partial class FrmInvoiceAlter
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxFPLX = new System.Windows.Forms.ComboBox();
            this.btnSELECT = new System.Windows.Forms.Button();
            this.txtKPR = new System.Windows.Forms.TextBox();
            this.txtSJPH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btncanncle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxFPLX);
            this.groupBox1.Controls.Add(this.btnSELECT);
            this.groupBox1.Controls.Add(this.txtKPR);
            this.groupBox1.Controls.Add(this.txtSJPH);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(620, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "修改明细";
            // 
            // comboBoxFPLX
            // 
            this.comboBoxFPLX.FormattingEnabled = true;
            this.comboBoxFPLX.Location = new System.Drawing.Point(89, 66);
            this.comboBoxFPLX.Name = "comboBoxFPLX";
            this.comboBoxFPLX.Size = new System.Drawing.Size(207, 20);
            this.comboBoxFPLX.TabIndex = 6;
            // 
            // btnSELECT
            // 
            this.btnSELECT.Location = new System.Drawing.Point(565, 23);
            this.btnSELECT.Name = "btnSELECT";
            this.btnSELECT.Size = new System.Drawing.Size(55, 23);
            this.btnSELECT.TabIndex = 5;
            this.btnSELECT.Text = "选择";
            this.btnSELECT.UseVisualStyleBackColor = true;
            this.btnSELECT.Click += new System.EventHandler(this.btnSELECT_Click);
            // 
            // txtKPR
            // 
            this.txtKPR.Location = new System.Drawing.Point(355, 25);
            this.txtKPR.Name = "txtKPR";
            this.txtKPR.ReadOnly = true;
            this.txtKPR.Size = new System.Drawing.Size(210, 21);
            this.txtKPR.TabIndex = 4;
            // 
            // txtSJPH
            // 
            this.txtSJPH.Location = new System.Drawing.Point(88, 25);
            this.txtSJPH.Name = "txtSJPH";
            this.txtSJPH.Size = new System.Drawing.Size(208, 21);
            this.txtSJPH.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(10, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "发票类型";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(302, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "开票人";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(10, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "实际票号";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(52, 128);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(105, 23);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btncanncle
            // 
            this.btncanncle.Location = new System.Drawing.Point(223, 128);
            this.btncanncle.Name = "btncanncle";
            this.btncanncle.Size = new System.Drawing.Size(103, 23);
            this.btncanncle.TabIndex = 2;
            this.btncanncle.Text = "取消";
            this.btncanncle.UseVisualStyleBackColor = true;
            this.btncanncle.Click += new System.EventHandler(this.btncanncle_Click);
            // 
            // FrmInvoiceAlter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 172);
            this.Controls.Add(this.btncanncle);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FrmInvoiceAlter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "采购发票修改";
            this.Load += new System.EventHandler(this.FrmInvoiceAlter_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxFPLX;
        private System.Windows.Forms.Button btnSELECT;
        private System.Windows.Forms.TextBox txtKPR;
        private System.Windows.Forms.TextBox txtSJPH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btncanncle;

    }
}