namespace ClientMain
{
    partial class FrmSupplierCorrection
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
            this.btnYes = new DevExpress.XtraEditors.SimpleButton();
            this.btnNo = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.sleSupplier = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.jTJDWXXBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDWID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDWMC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.teOldSupplier = new DevExpress.XtraEditors.TextEdit();
            this.colDWBH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZJM = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.sleSupplier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jTJDWXXBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teOldSupplier.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(141, 175);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(75, 23);
            this.btnYes.TabIndex = 0;
            this.btnYes.Text = "确定";
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(271, 175);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(75, 23);
            this.btnNo.TabIndex = 1;
            this.btnNo.Text = "取消";
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(80, 105);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 14);
            this.labelControl1.TabIndex = 20;
            this.labelControl1.Text = "新供应商：";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(80, 48);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 14);
            this.labelControl2.TabIndex = 22;
            this.labelControl2.Text = "原供应商：";
            // 
            // sleSupplier
            // 
            this.sleSupplier.EditValue = "";
            this.sleSupplier.Location = new System.Drawing.Point(158, 98);
            this.sleSupplier.Name = "sleSupplier";
            this.sleSupplier.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sleSupplier.Properties.DataSource = this.jTJDWXXBindingSource;
            this.sleSupplier.Properties.DisplayMember = "DWMC";
            this.sleSupplier.Properties.ValueMember = "DWID";
            this.sleSupplier.Properties.View = this.searchLookUpEdit1View;
            this.sleSupplier.Size = new System.Drawing.Size(250, 21);
            this.sleSupplier.TabIndex = 25;
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
            this.searchLookUpEdit1View.OptionsBehavior.Editable = false;
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colDWID
            // 
            this.colDWID.Caption = "供应商ID";
            this.colDWID.FieldName = "DWID";
            this.colDWID.Name = "colDWID";
            this.colDWID.Visible = true;
            this.colDWID.VisibleIndex = 0;
            // 
            // colDWMC
            // 
            this.colDWMC.Caption = "供应商名称";
            this.colDWMC.FieldName = "DWMC";
            this.colDWMC.Name = "colDWMC";
            this.colDWMC.Visible = true;
            this.colDWMC.VisibleIndex = 1;
            // 
            // teOldSupplier
            // 
            this.teOldSupplier.Enabled = false;
            this.teOldSupplier.Location = new System.Drawing.Point(158, 41);
            this.teOldSupplier.Name = "teOldSupplier";
            this.teOldSupplier.Size = new System.Drawing.Size(250, 21);
            this.teOldSupplier.TabIndex = 26;
            // 
            // colDWBH
            // 
            this.colDWBH.Caption = "供应商编号";
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
            // FrmSupplierCorrection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 242);
            this.Controls.Add(this.teOldSupplier);
            this.Controls.Add(this.sleSupplier);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Name = "FrmSupplierCorrection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "更正供应商";
            this.Load += new System.EventHandler(this.FrmSupplierCorrection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sleSupplier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jTJDWXXBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teOldSupplier.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnYes;
        private DevExpress.XtraEditors.SimpleButton btnNo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SearchLookUpEdit sleSupplier;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colDWID;
        private DevExpress.XtraGrid.Columns.GridColumn colDWMC;
        private DevExpress.XtraEditors.TextEdit teOldSupplier;
        private System.Windows.Forms.BindingSource jTJDWXXBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colDWBH;
        private DevExpress.XtraGrid.Columns.GridColumn colZJM;
        
    }
}