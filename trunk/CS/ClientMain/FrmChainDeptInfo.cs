using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Sybase.Data.AseClient;

namespace ClientMain
{
    public partial class FrmChainDeptInfo : DevExpress.XtraEditors.XtraForm
    {
        public FrmChainDeptInfo()
        {
            InitializeComponent();
        }

        private void FrmChainDeptInfo_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingSource1;

            const string strCon = "Data Source='192.8.30.1';Port='5000';Database='ssxd_db';Uid='sa';Pwd='';";
            AseConnection conn = new AseConnection(strCon);

            string strSQL = "select F_BMBH,F_BMMC from C_MSBM";
            AseDataAdapter Ada = new AseDataAdapter(strSQL, conn);
            
            DataSet ds = new DataSet();
            Ada.Fill(ds, "C_MSBM");

            bindingSource1.DataSource = ds;
            bindingSource1.DataMember = "C_MSBM";

        }
    }
}