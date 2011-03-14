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
    public partial class FrmDBMtChild : DevExpress.XtraEditors.XtraForm
    {
        string m_strZTID;
        string m_strSysType;
        string m_strDBType;
        string m_strServer;
        string m_strPass;
        string m_strUser;
        string m_strDBName;

        OracleConnection Con;
        OracleDataAdapter AdaZT;
        OracleDataAdapter AdaDBType;
        OracleDataAdapter AdaSysType;
        DataSet ds;

        public FrmDBMtChild(string strZTID, string strSysType, string strDBType, string strServer, string strUser, string strPass, string strDBName)
        {
            InitializeComponent();

            m_strZTID = strZTID;
            m_strSysType = strSysType;
            m_strDBType = strDBType;
            m_strServer = strServer;
            m_strPass = strPass;
            m_strUser = strUser;
            m_strDBName = strDBName;
        }

        public FrmDBMtChild()
        {
            InitializeComponent();
        }

        private void FrmDBMtChild_Load(object sender, EventArgs e)
        {
            string strCon = "Data Source=XINHUA;User Id=xxb;Password=pass;Integrated Security=no;";
            Con = new OracleConnection(strCon);

            string sqlZT = "select ZTID, ZTMC from SYS_ZTBM";
            AdaZT = new OracleDataAdapter(sqlZT, Con);

            string sqlDB = "select TYPEID, TYPENAME from BASE_DBTYPE";
            AdaDBType = new OracleDataAdapter(sqlDB, Con);

            string sqlSys = "select TYPEID, TYPENAME from BASE_SYSTYPE";
            AdaSysType = new OracleDataAdapter(sqlSys, Con);

            ds = new DataSet();
            AdaDBType.Fill(ds, "BASE_DBTYPE");
            AdaSysType.Fill(ds, "BASE_SYSTYPE");
            AdaZT.Fill(ds, "SYS_ZTBM");

            cbAccount.DataSource = ds.Tables["SYS_ZTBM"];
            cbAccount.ValueMember = "ZTID";
            cbAccount.DisplayMember = "ZTMC";
            cbAccount.Text = m_strZTID;

            cbDBType.DataSource = ds.Tables["BASE_DBTYPE"];
            cbDBType.ValueMember = "TYPEID";
            cbDBType.DisplayMember = "TYPENAME";
            cbDBType.Text = m_strDBType;

            cbSysType.DataSource = ds.Tables["BASE_SYSTYPE"];
            cbSysType.ValueMember =  "TYPEID";
            cbSysType.DisplayMember = "TYPENAME";
            cbSysType.Text = m_strSysType;

            tbPass.Text = m_strPass;
            tbServer.Text = m_strServer;
            tbUser.Text = m_strUser;
            tbDBName.Text = m_strDBName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbUser.Text == "" || tbDBName.Text == "" || tbServer.Text == "" || cbAccount.Text == "" || cbDBType.Text == "" || cbSysType.Text == "")
            {
                if (MessageBox.Show("除密码外其他不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Stop) == DialogResult.OK)
                {
                    this.tbUser.Focus();
                }
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            } 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string getSysType()
        {
            return ((DataRowView)cbSysType.SelectedItem).Row["TYPEID"].ToString();
        }

        public string getDBType()
        {
            return ((DataRowView)cbDBType.SelectedItem).Row["TYPEID"].ToString();
        }

        public string getZT()
        {
            return ((DataRowView)cbAccount.SelectedItem).Row["ZTID"].ToString();
        }

        public string getUser()
        {
            return tbUser.Text.Trim();
        }

        public string getPass()
        {
            return tbPass.Text.Trim();
        }

        public string getServer()
        {
            return tbServer.Text.Trim();
        }

        public string getDBName()
        {
            return tbDBName.Text.Trim();
        }
    }
}