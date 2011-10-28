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
    public partial class FrmSupplierAdjust : DevExpress.XtraEditors.XtraForm
    {
        string m_strZTID;
        string m_strDeptID;
        string m_strUserID;
        OracleConnection Conn;

        public FrmSupplierAdjust()
        {
            InitializeComponent();
        }
        

        public FrmSupplierAdjust(string strUserID, string strZTID, string strDeptID)
        {
            Conn = new OracleConnection(FrmLogin.strDataCent);
            string strSQL = "select DWID, DWMC from JT_J_DWXX";
            OracleDataAdapter ada = new OracleDataAdapter(strSQL, Conn);
            DataSet ds = new DataSet();
            ada.Fill(ds, "JT_J_DWXX");

            InitializeComponent();

            jTJDWXXBindingSource.DataSource = ds;
            jTJDWXXBindingSource.DataMember = "JT_J_DWXX";

            m_strZTID = strZTID;
            m_strDeptID = strDeptID;
            m_strUserID = strUserID;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdjust_Click(object sender, EventArgs e)
        {

            if((leSupplier.EditValue == null) || ((m_strDeptID == "306") && (cbFinance.Text.Trim() == "")) ||
                (tbPrice.Text.Trim() == "") || (cbTaxRate.Text.Trim() == "") || (tbOldDiscount.Text.Trim() == "") ||
                (tbFloatDiscount.Text.Trim() == ""))
            {
                MessageBox.Show("所有项不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Stop);                   
            }
            else if(m_strUserID.Equals(""))
            {
                MessageBox.Show("您所登录的账号在一体化平台中没有对应操作员，请检查配置！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Stop); 
            }
            else if (m_strZTID.Equals("") || m_strDeptID.Equals(""))
            {
                MessageBox.Show("您所登录的账套或部门在一体化平台中没有对应单位，请检查配置！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Stop); 
            }
            else
            {
                string strFinaceID;
                if (m_strDeptID == "306")
                {
                    int index = cbFinance.Text.LastIndexOf(":");
                    strFinaceID = cbFinance.Text.Substring(0, index).Trim();

                }
                else
                {
                    strFinaceID = "";
                }
                                
                OracleCommand cmd = new OracleCommand("Z_GYSZKTZ", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("ztid", OracleType.VarChar).Value = m_strZTID;
                cmd.Parameters.Add("bmid", OracleType.VarChar).Value = m_strDeptID;
                cmd.Parameters.Add("gysid", OracleType.VarChar).Value = leSupplier.EditValue.ToString().Trim();
                cmd.Parameters.Add("cwlx", OracleType.VarChar).Value = strFinaceID;
                cmd.Parameters.Add("my", OracleType.Double).Value = double.Parse(tbPrice.Text.Trim());
                cmd.Parameters.Add("sl", OracleType.Double).Value = double.Parse(cbTaxRate.Text.Trim());
                cmd.Parameters.Add("yzk", OracleType.Double).Value = double.Parse(tbOldDiscount.Text.Trim());
                cmd.Parameters.Add("fdzk", OracleType.Double).Value = double.Parse(tbFloatDiscount.Text.Trim());
                cmd.Parameters.Add("operator", OracleType.VarChar).Value = m_strUserID;
                
                cmd.Parameters.Add("msg", OracleType.VarChar, 255).Direction = ParameterDirection.Output;

                try
                {
                    Conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(cmd.Parameters["msg"].Value.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Conn.Close();
                }
            }
        }

        private void FrmSupplierAdjust_Load(object sender, EventArgs e)
        {
           
           
            if (m_strDeptID == "306")
            {
                cbFinance.Visible = true;
                labelControl3.Visible = true;
            }
            else
            {
                cbFinance.Visible = false;
                labelControl3.Visible = false;
            }

        }
    }
}