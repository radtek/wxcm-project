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
    public partial class FrmBranchAdjust : DevExpress.XtraEditors.XtraForm
    {
        string m_strZTID;
        string m_strDeptID;
        string m_strUser;

        OracleConnection Conn;
        public FrmBranchAdjust()
        {
            InitializeComponent();
        }

        public FrmBranchAdjust(string strUser, string strZTID, string strDeptID)
        {
            Conn = new OracleConnection(FrmLogin.strCon);
            string strSQL = "select ZTID, ZTMC from SYS_ZTBM";
            OracleDataAdapter ada = new OracleDataAdapter(strSQL, Conn);
            DataSet ds = new DataSet();
            ada.Fill(ds, "SYS_ZTBM");

            InitializeComponent();

            jTJZTBMBindingSource.DataSource = ds;
            jTJZTBMBindingSource.DataMember = "SYS_ZTBM";

            m_strZTID = strZTID;
            m_strDeptID = strDeptID;
            m_strUser = strUser;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdjust_Click(object sender, EventArgs e)
        {
            string strUserID = getUserID(m_strUser);
            string strDeptID = getDWID(m_strDeptID);
            string strZTID = getDWID(m_strZTID);

            if ((leClient.EditValue == null) || ((m_strDeptID == "306") && (cbFinance.Text.Trim() == "")) ||
                (tbPrice.Text.Trim() == "") || (cbTaxRate.Text.Trim() == "") || (tbOldDiscount.Text.Trim() == "") ||
                (tbFloatDiscount.Text.Trim() == ""))
            {
                MessageBox.Show("所有项不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (strUserID.Equals(""))
            {
                MessageBox.Show("您所登录的账号在一体化平台中没有对应操作员，请检查配置！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (strZTID.Equals("") || strDeptID.Equals(""))
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

               
                OracleCommand cmd = new OracleCommand("Z_KHZKTZ", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("ztid", OracleType.VarChar).Value = strZTID;
                cmd.Parameters.Add("bmid", OracleType.VarChar).Value = strDeptID;
                cmd.Parameters.Add("khid", OracleType.VarChar).Value = leClient.EditValue.ToString().Trim();
                cmd.Parameters.Add("cwlx", OracleType.VarChar).Value = strFinaceID;
                cmd.Parameters.Add("my", OracleType.Double).Value = double.Parse(tbPrice.Text.Trim());
                cmd.Parameters.Add("sl", OracleType.Double).Value = double.Parse(cbTaxRate.Text.Trim());
                cmd.Parameters.Add("yzk", OracleType.Double).Value = double.Parse(tbOldDiscount.Text.Trim());
                cmd.Parameters.Add("fdzk", OracleType.Double).Value = double.Parse(tbFloatDiscount.Text.Trim());
                cmd.Parameters.Add("operator", OracleType.VarChar).Value = strUserID;

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

        private void FrmBranchAdjust_Load(object sender, EventArgs e)
        {
            

            if (m_strDeptID == "306")
            {
                cbFinance.Visible = true;
                labelControl4.Visible = true;
            }
            else
            {
                cbFinance.Visible = false;
                labelControl4.Visible = false;
            }

        }

        private string getDWID(string strID)
        {
            string strDWID = "";
            string strTemp = "";

            string srcSQL = "select t.ythno from SYS_DEPARTMENT t where t.departmentid = '" + strID + "'";
            OracleDataAdapter srcAda = new OracleDataAdapter(srcSQL, Conn);
            DataSet srcDS = new DataSet();
            srcAda.Fill(srcDS, "SYS_DEPARTMENT");
            foreach (DataRowView theRow in srcDS.Tables["SYS_DEPARTMENT"].DefaultView)
            {
                strTemp = theRow.Row["ythno"].ToString().Trim();
            }


            string strCon = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.1.11)(PORT=1521))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=QUERY)));User Id=jt_user;Password=jt_user;";
            OracleConnection dstCon = new OracleConnection(strCon);
            string dstSQL = "select t.dwid from jt_j_dwxx t where t.dwbh = '" + strTemp + "'";
            OracleDataAdapter dstAda = new OracleDataAdapter(dstSQL, dstCon);
            DataSet dstDS = new DataSet();
            dstAda.Fill(dstDS, "jt_j_dwxx");
            foreach (DataRowView theRow in dstDS.Tables["jt_j_dwxx"].DefaultView)
            {
                strDWID = theRow.Row["dwid"].ToString().Trim();
            }

            return strDWID;
        }

        private string getUserID(string strUserName)
        {
            string strUserID = "";
            string strTemp = "";

            string srcSQL = "select t.ythptno from SYS_USER t where t.username = '" + strUserName + "'";
            OracleDataAdapter srcAda = new OracleDataAdapter(srcSQL, Conn);
            DataSet srcDS = new DataSet();
            srcAda.Fill(srcDS, "SYS_USER");
            foreach (DataRowView theRow in srcDS.Tables["SYS_USER"].DefaultView)
            {
                strTemp = theRow.Row["ythptno"].ToString().Trim();
            }


            string strCon = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.1.11)(PORT=1521))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=QUERY)));User Id=jt_user;Password=jt_user;";
            OracleConnection dstCon = new OracleConnection(strCon);
            string dstSQL = "select t.operatorid from base_operator t where t.operatorno = '" + strTemp + "'";
            OracleDataAdapter dstAda = new OracleDataAdapter(dstSQL, dstCon);
            DataSet dstDS = new DataSet();
            dstAda.Fill(dstDS, "base_operator");
            foreach (DataRowView theRow in dstDS.Tables["base_operator"].DefaultView)
            {
                strUserID = theRow.Row["operatorid"].ToString().Trim();
            }

            return strUserID;
        }
    }
}