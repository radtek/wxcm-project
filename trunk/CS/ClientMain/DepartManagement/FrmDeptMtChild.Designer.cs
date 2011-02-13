namespace ClientMain
{
    partial class FrmDeptMtChild
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDeptNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDeptName = new System.Windows.Forms.TextBox();
            this.txtDeptDsc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbISAcct = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbAcctChose = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "部门编号";
            // 
            // txtDeptNum
            // 
            this.txtDeptNum.Location = new System.Drawing.Point(235, 31);
            this.txtDeptNum.Name = "txtDeptNum";
            this.txtDeptNum.Size = new System.Drawing.Size(224, 21);
            this.txtDeptNum.TabIndex = 1;
            this.txtDeptNum.Validating += new System.ComponentModel.CancelEventHandler(this.txtDeptNum_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "部门名称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "描述";
            // 
            // txtDeptName
            // 
            this.txtDeptName.Location = new System.Drawing.Point(235, 78);
            this.txtDeptName.Name = "txtDeptName";
            this.txtDeptName.Size = new System.Drawing.Size(224, 21);
            this.txtDeptName.TabIndex = 4;
            this.txtDeptName.Validating += new System.ComponentModel.CancelEventHandler(this.txtDeptName_Validating);
            // 
            // txtDeptDsc
            // 
            this.txtDeptDsc.Location = new System.Drawing.Point(235, 117);
            this.txtDeptDsc.Name = "txtDeptDsc";
            this.txtDeptDsc.Size = new System.Drawing.Size(224, 21);
            this.txtDeptDsc.TabIndex = 5;
            this.txtDeptDsc.Validating += new System.ComponentModel.CancelEventHandler(this.txtDeptDsc_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "是否账套";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(186, 244);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(312, 244);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbISAcct
            // 
            this.cbISAcct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbISAcct.FormattingEnabled = true;
            this.cbISAcct.Location = new System.Drawing.Point(235, 154);
            this.cbISAcct.Name = "cbISAcct";
            this.cbISAcct.Size = new System.Drawing.Size(224, 20);
            this.cbISAcct.TabIndex = 10;
            this.cbISAcct.SelectedIndexChanged += new System.EventHandler(this.cbISAcct_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "所属账套";
            // 
            // cbAcctChose
            // 
            this.cbAcctChose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAcctChose.FormattingEnabled = true;
            this.cbAcctChose.Location = new System.Drawing.Point(235, 191);
            this.cbAcctChose.Name = "cbAcctChose";
            this.cbAcctChose.Size = new System.Drawing.Size(224, 20);
            this.cbAcctChose.TabIndex = 12;
            // 
            // FrmDeptMtChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 300);
            this.Controls.Add(this.cbAcctChose);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbISAcct);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDeptDsc);
            this.Controls.Add(this.txtDeptName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDeptNum);
            this.Controls.Add(this.label1);
            this.Name = "FrmDeptMtChild";
            this.Text = "部门管理";
            this.Load += new System.EventHandler(this.FrmDeptMtChild_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDeptNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDeptName;
        private System.Windows.Forms.TextBox txtDeptDsc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbISAcct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbAcctChose;
    }
}