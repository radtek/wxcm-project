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
    public partial class FrmDiscountCorrection : DevExpress.XtraEditors.XtraForm
    {
        public FrmDiscountCorrection(string strJZ)
        {
            InitializeComponent();
            teOldDiscount.Text = strJZ + "%";

        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            if(teNewDiscout.EditValue == null)
            {
                MessageBox.Show("请输入新的折扣");
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        public double getNewDiscount()
        {
            return Convert.ToDouble(teNewDiscout.EditValue);
        }


    }
}