namespace ClientMain
{
    partial class FrmStaffMtChild
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbStaffNum = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbMobile = new System.Windows.Forms.TextBox();
            this.tbTel = new System.Windows.Forms.TextBox();
            this.tbFastCode = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnSaveEnd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSaveContinue = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.jTJDWXXBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sleDepart = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDWID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDWMC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDWBH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZJM = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.jTJDWXXBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sleDepart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "员工编号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "员工姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "助记码";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "性别";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "出生年月";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(350, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 14);
            this.label6.TabIndex = 5;
            this.label6.Text = "电子邮箱";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 14);
            this.label7.TabIndex = 6;
            this.label7.Text = "固定电话";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(350, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 14);
            this.label8.TabIndex = 7;
            this.label8.Text = "移动电话";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 14);
            this.label9.TabIndex = 8;
            this.label9.Text = "通讯地址";
            // 
            // tbStaffNum
            // 
            this.tbStaffNum.Location = new System.Drawing.Point(100, 20);
            this.tbStaffNum.Name = "tbStaffNum";
            this.tbStaffNum.Size = new System.Drawing.Size(200, 22);
            this.tbStaffNum.TabIndex = 0;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(100, 140);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(200, 22);
            this.tbAddress.TabIndex = 8;
            // 
            // tbMobile
            // 
            this.tbMobile.Location = new System.Drawing.Point(430, 110);
            this.tbMobile.Name = "tbMobile";
            this.tbMobile.Size = new System.Drawing.Size(200, 22);
            this.tbMobile.TabIndex = 7;
            // 
            // tbTel
            // 
            this.tbTel.Location = new System.Drawing.Point(100, 110);
            this.tbTel.Name = "tbTel";
            this.tbTel.Size = new System.Drawing.Size(200, 22);
            this.tbTel.TabIndex = 6;
            // 
            // tbFastCode
            // 
            this.tbFastCode.Location = new System.Drawing.Point(100, 80);
            this.tbFastCode.Name = "tbFastCode";
            this.tbFastCode.Size = new System.Drawing.Size(200, 22);
            this.tbFastCode.TabIndex = 4;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(430, 80);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(200, 22);
            this.tbEmail.TabIndex = 5;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(430, 20);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(200, 22);
            this.tbName.TabIndex = 1;
            // 
            // btnSaveEnd
            // 
            this.btnSaveEnd.Location = new System.Drawing.Point(223, 183);
            this.btnSaveEnd.Name = "btnSaveEnd";
            this.btnSaveEnd.Size = new System.Drawing.Size(75, 23);
            this.btnSaveEnd.TabIndex = 11;
            this.btnSaveEnd.Text = "保存退出";
            this.btnSaveEnd.UseVisualStyleBackColor = true;
            this.btnSaveEnd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(460, 183);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(430, 50);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.Value = new System.DateTime(2011, 2, 10, 0, 0, 0, 0);
            // 
            // cbGender
            // 
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(100, 50);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(200, 22);
            this.cbGender.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(80, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 14);
            this.label10.TabIndex = 22;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(411, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 14);
            this.label11.TabIndex = 23;
            this.label11.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(350, 140);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 14);
            this.label12.TabIndex = 24;
            this.label12.Text = "上级单位";
            // 
            // btnSaveContinue
            // 
            this.btnSaveContinue.Location = new System.Drawing.Point(112, 183);
            this.btnSaveContinue.Name = "btnSaveContinue";
            this.btnSaveContinue.Size = new System.Drawing.Size(75, 23);
            this.btnSaveContinue.TabIndex = 10;
            this.btnSaveContinue.Text = "保存继续";
            this.btnSaveContinue.UseVisualStyleBackColor = true;
            this.btnSaveContinue.Click += new System.EventHandler(this.btnSaveContinue_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(341, 183);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "重置";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // sleDepart
            // 
            this.sleDepart.EditValue = "";
            this.sleDepart.Location = new System.Drawing.Point(430, 140);
            this.sleDepart.Name = "sleDepart";
            this.sleDepart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sleDepart.Properties.DataSource = this.jTJDWXXBindingSource;
            this.sleDepart.Properties.DisplayMember = "DWMC";
            this.sleDepart.Properties.NullText = "";
            this.sleDepart.Properties.ValueMember = "DWID";
            this.sleDepart.Properties.View = this.searchLookUpEdit1View;
            this.sleDepart.Size = new System.Drawing.Size(200, 21);
            this.sleDepart.TabIndex = 9;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDWID,
            this.colDWMC,
            this.colDWBH,
            this.colZJM});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colDWID
            // 
            this.colDWID.Caption = "单位ID";
            this.colDWID.FieldName = "DWID";
            this.colDWID.Name = "colDWID";
            this.colDWID.Visible = true;
            this.colDWID.VisibleIndex = 0;
            // 
            // colDWMC
            // 
            this.colDWMC.Caption = "单位名称";
            this.colDWMC.FieldName = "DWMC";
            this.colDWMC.Name = "colDWMC";
            this.colDWMC.Visible = true;
            this.colDWMC.VisibleIndex = 1;
            // 
            // colDWBH
            // 
            this.colDWBH.Caption = "单位编号";
            this.colDWBH.FieldName = "DWBH";
            this.colDWBH.Name = "colDWBH";
            this.colDWBH.Visible = true;
            this.colDWBH.VisibleIndex = 2;
            // 
            // colZJM
            // 
            this.colZJM.Caption = "助记码";
            this.colZJM.FieldName = "ZJM";
            this.colZJM.Name = "colZJM";
            this.colZJM.Visible = true;
            this.colZJM.VisibleIndex = 3;
            // 
            // FrmStaffMtChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 232);
            this.Controls.Add(this.sleDepart);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSaveContinue);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSaveEnd);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbFastCode);
            this.Controls.Add(this.tbTel);
            this.Controls.Add(this.tbMobile);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbStaffNum);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmStaffMtChild";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmStaffMtChild_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jTJDWXXBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sleDepart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbStaffNum;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbMobile;
        private System.Windows.Forms.TextBox tbTel;
        private System.Windows.Forms.TextBox tbFastCode;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnSaveEnd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSaveContinue;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.BindingSource jTJDWXXBindingSource;
        private DevExpress.XtraEditors.SearchLookUpEdit sleDepart;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colDWID;
        private DevExpress.XtraGrid.Columns.GridColumn colDWMC;
        private DevExpress.XtraGrid.Columns.GridColumn colDWBH;
        private DevExpress.XtraGrid.Columns.GridColumn colZJM;
    }
}