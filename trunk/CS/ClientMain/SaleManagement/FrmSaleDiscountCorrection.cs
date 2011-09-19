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
    public partial class FrmSaleDiscountCorrection : DevExpress.XtraEditors.XtraForm
    {
        public FrmSaleDiscountCorrection(string strXZ)
        {
            InitializeComponent();
            teOldDiscount.Text = strXZ + "%";
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            if (teNewDiscout.EditValue == null)
            {
                MessageBox.Show("请输入新的折扣");
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

        public double getNewDiscount()
        {
            return Convert.ToDouble(teNewDiscout.EditValue);
        }
    }
}