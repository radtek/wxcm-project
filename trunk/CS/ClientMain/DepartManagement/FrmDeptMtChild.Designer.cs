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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.客户类型 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cbSupType = new System.Windows.Forms.ComboBox();
            this.cbUnitProp = new System.Windows.Forms.ComboBox();
            this.cbDeptType = new System.Windows.Forms.ComboBox();
            this.cbClientType = new System.Windows.Forms.ComboBox();
            this.cbPressType = new System.Windows.Forms.ComboBox();
            this.cbFacType = new System.Windows.Forms.ComboBox();
            this.cbSuperUnit = new System.Windows.Forms.ComboBox();
            this.cbWareType = new System.Windows.Forms.ComboBox();
            this.cbTransType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "单位编号";
            // 
            // txtDeptNum
            // 
            this.txtDeptNum.Location = new System.Drawing.Point(141, 30);
            this.txtDeptNum.Name = "txtDeptNum";
            this.txtDeptNum.Size = new System.Drawing.Size(224, 21);
            this.txtDeptNum.TabIndex = 1;
            this.txtDeptNum.Validating += new System.ComponentModel.CancelEventHandler(this.txtDeptNum_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(419, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "单位名称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "描述";
            // 
            // txtDeptName
            // 
            this.txtDeptName.Location = new System.Drawing.Point(511, 30);
            this.txtDeptName.Name = "txtDeptName";
            this.txtDeptName.Size = new System.Drawing.Size(224, 21);
            this.txtDeptName.TabIndex = 4;
            this.txtDeptName.Validating += new System.ComponentModel.CancelEventHandler(this.txtDeptName_Validating);
            // 
            // txtDeptDsc
            // 
            this.txtDeptDsc.Location = new System.Drawing.Point(141, 69);
            this.txtDeptDsc.Name = "txtDeptDsc";
            this.txtDeptDsc.Size = new System.Drawing.Size(224, 21);
            this.txtDeptDsc.TabIndex = 5;
            this.txtDeptDsc.Validating += new System.ComponentModel.CancelEventHandler(this.txtDeptDsc_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "是否账套";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(276, 321);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(407, 321);
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
            this.cbISAcct.Location = new System.Drawing.Point(141, 110);
            this.cbISAcct.Name = "cbISAcct";
            this.cbISAcct.Size = new System.Drawing.Size(224, 20);
            this.cbISAcct.TabIndex = 10;
            this.cbISAcct.SelectedIndexChanged += new System.EventHandler(this.cbISAcct_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "所属账套";
            // 
            // cbAcctChose
            // 
            this.cbAcctChose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAcctChose.FormattingEnabled = true;
            this.cbAcctChose.Location = new System.Drawing.Point(141, 150);
            this.cbAcctChose.Name = "cbAcctChose";
            this.cbAcctChose.Size = new System.Drawing.Size(224, 20);
            this.cbAcctChose.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(110, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(471, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(421, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "单位属性";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(421, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 16;
            this.label9.Text = "部门类型";
            // 
            // 客户类型
            // 
            this.客户类型.AutoSize = true;
            this.客户类型.Location = new System.Drawing.Point(421, 150);
            this.客户类型.Name = "客户类型";
            this.客户类型.Size = new System.Drawing.Size(53, 12);
            this.客户类型.TabIndex = 17;
            this.客户类型.Text = "客户类型";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(58, 190);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 18;
            this.label11.Text = "供应商类型";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(419, 270);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 19;
            this.label12.Text = "上级单位";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(58, 270);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 12);
            this.label13.TabIndex = 20;
            this.label13.Text = "运输单位类型";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(58, 230);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 21;
            this.label14.Text = "库房类型";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(421, 230);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 12);
            this.label15.TabIndex = 22;
            this.label15.Text = "印刷厂类型";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(421, 190);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 12);
            this.label16.TabIndex = 23;
            this.label16.Text = "出版社类型";
            // 
            // cbSupType
            // 
            this.cbSupType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSupType.FormattingEnabled = true;
            this.cbSupType.Location = new System.Drawing.Point(141, 190);
            this.cbSupType.Name = "cbSupType";
            this.cbSupType.Size = new System.Drawing.Size(224, 20);
            this.cbSupType.TabIndex = 24;
            // 
            // cbUnitProp
            // 
            this.cbUnitProp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnitProp.FormattingEnabled = true;
            this.cbUnitProp.Location = new System.Drawing.Point(511, 70);
            this.cbUnitProp.Name = "cbUnitProp";
            this.cbUnitProp.Size = new System.Drawing.Size(224, 20);
            this.cbUnitProp.TabIndex = 25;
            // 
            // cbDeptType
            // 
            this.cbDeptType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDeptType.FormattingEnabled = true;
            this.cbDeptType.Location = new System.Drawing.Point(511, 110);
            this.cbDeptType.Name = "cbDeptType";
            this.cbDeptType.Size = new System.Drawing.Size(224, 20);
            this.cbDeptType.TabIndex = 26;
            // 
            // cbClientType
            // 
            this.cbClientType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClientType.FormattingEnabled = true;
            this.cbClientType.Location = new System.Drawing.Point(511, 150);
            this.cbClientType.Name = "cbClientType";
            this.cbClientType.Size = new System.Drawing.Size(224, 20);
            this.cbClientType.TabIndex = 27;
            // 
            // cbPressType
            // 
            this.cbPressType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPressType.FormattingEnabled = true;
            this.cbPressType.Location = new System.Drawing.Point(511, 190);
            this.cbPressType.Name = "cbPressType";
            this.cbPressType.Size = new System.Drawing.Size(224, 20);
            this.cbPressType.TabIndex = 28;
            // 
            // cbFacType
            // 
            this.cbFacType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFacType.FormattingEnabled = true;
            this.cbFacType.Location = new System.Drawing.Point(511, 230);
            this.cbFacType.Name = "cbFacType";
            this.cbFacType.Size = new System.Drawing.Size(224, 20);
            this.cbFacType.TabIndex = 29;
            // 
            // cbSuperUnit
            // 
            this.cbSuperUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSuperUnit.FormattingEnabled = true;
            this.cbSuperUnit.Location = new System.Drawing.Point(511, 270);
            this.cbSuperUnit.Name = "cbSuperUnit";
            this.cbSuperUnit.Size = new System.Drawing.Size(224, 20);
            this.cbSuperUnit.TabIndex = 30;
            // 
            // cbWareType
            // 
            this.cbWareType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWareType.FormattingEnabled = true;
            this.cbWareType.Location = new System.Drawing.Point(141, 230);
            this.cbWareType.Name = "cbWareType";
            this.cbWareType.Size = new System.Drawing.Size(224, 20);
            this.cbWareType.TabIndex = 31;
            // 
            // cbTransType
            // 
            this.cbTransType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTransType.FormattingEnabled = true;
            this.cbTransType.Location = new System.Drawing.Point(141, 270);
            this.cbTransType.Name = "cbTransType";
            this.cbTransType.Size = new System.Drawing.Size(224, 20);
            this.cbTransType.TabIndex = 32;
            // 
            // FrmDeptMtChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 364);
            this.Controls.Add(this.cbTransType);
            this.Controls.Add(this.cbWareType);
            this.Controls.Add(this.cbSuperUnit);
            this.Controls.Add(this.cbFacType);
            this.Controls.Add(this.cbPressType);
            this.Controls.Add(this.cbClientType);
            this.Controls.Add(this.cbDeptType);
            this.Controls.Add(this.cbUnitProp);
            this.Controls.Add(this.cbSupType);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.客户类型);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "单位信息";
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label 客户类型;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbSupType;
        private System.Windows.Forms.ComboBox cbUnitProp;
        private System.Windows.Forms.ComboBox cbDeptType;
        private System.Windows.Forms.ComboBox cbClientType;
        private System.Windows.Forms.ComboBox cbPressType;
        private System.Windows.Forms.ComboBox cbFacType;
        private System.Windows.Forms.ComboBox cbSuperUnit;
        private System.Windows.Forms.ComboBox cbWareType;
        private System.Windows.Forms.ComboBox cbTransType;
    }
}