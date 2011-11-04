using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.OracleClient;

namespace ClientMain
{
    public partial class FrmSupplierCorrection : DevExpress.XtraEditors.XtraForm
    {
        
        public FrmSupplierCorrection(OracleConnection Conn, OracleTransaction Trans, string strGYSMC)
        {
            string strSQL = "select DWID, DWMC, DWBH, ZJM from JT_J_DWXX";
            OracleDataAdapter ada = new OracleDataAdapter(strSQL, Conn);
            ada.SelectCommand.Transaction = Trans;
            DataSet ds = new DataSet();
            ada.Fill(ds, "JT_J_DWXX");

            InitializeComponent();

            jTJDWXXBindingSource.DataSource = ds;
            jTJDWXXBindingSource.DataMember = "JT_J_DWXX";

            teOldSupplier.Text = strGYSMC;
        }

        private void FrmSupplierCorrection_Load(object sender, EventArgs e)
        {
           
            
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            if (sleSupplier.EditValue == null)
            {
                MessageBox.Show("请选择新的供应商");
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            
        }

        public string getSupplierID()
        {
           return sleSupplier.EditValue.ToString().Trim();
        }
    }
}