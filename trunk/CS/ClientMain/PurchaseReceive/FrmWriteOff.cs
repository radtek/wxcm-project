using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ClientMain
{
    public partial class FrmWriteOff : DevExpress.XtraEditors.XtraForm
    {
        public FrmWriteOff()
        {
            InitializeComponent();
        }

        public string getWriteOffDate()
        {
            return dateEdit1.EditValue.ToString().Trim();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            if (dateEdit1.EditValue == null)
            {
                MessageBox.Show("请选择核销日期");
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}