using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Xpo.DB;

//for test
namespace ClientMain
{

    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        private static string strAcct = "";
        private static string strDeptName = "";
        private static string strUser = "";
        private static string strUserID = "";
        private static string strDeptID = "";
        private static string strZTID = "";
        private static string strUserName = "";
        private static string strZTMC = "";

        private string m_PassWord = null;
        public const string strCon = "Data Source=DATACENT;Persist Security Info=True;User ID=jt_user;Password=jt_user;Unicode=True";
        public const string strDataCent = "Data Source=DATACENT;Persist Security Info=True;User ID=jt_user;Password=jt_user;Unicode=True";
        public static string xpoConStr = OracleConnectionProvider.GetConnectionString("DATACENT", "jt_user", "jt_user");
        public static string xpoDataCentStr = OracleConnectionProvider.GetConnectionString("DATACENT", "jt_user", "jt_user");

        //public const string strCon = "Data Source=QUERYSERVER;Persist Security Info=True;User ID=jt_user;Password=jt_user;Unicode=True";
        //public const string strDataCent = "Data Source=QUERYSERVER;Persist Security Info=True;User ID=jt_user;Password=jt_user;Unicode=True";
        //public static string xpoConStr = OracleConnectionProvider.GetConnectionString("QUERYSERVER ", "jt_user", "jt_user");
        //public static string xpoDataCentStr = OracleConnectionProvider.GetConnectionString("QUERYSERVER ", "jt_user", "jt_user");
        
        public const int MAXROWCOUNT = 50000;

        public static void vDrawFootCell(FooterCellCustomDrawEventArgs e, DevExpress.XtraGrid.Columns.GridColumn col, string strSum)
        {
            if (e.Column == col)
            {
                e.Painter.DrawObject(e.Info);
                Rectangle r = e.Info.Bounds;
                string text = e.Info.DisplayText;
                e.Info.Bounds = new Rectangle(e.Info.Bounds.Left, e.Info.Bounds.Bottom + 1, e.Info.Bounds.Width, e.Info.Bounds.Height);
                e.Info.DisplayText = strSum;
                e.Painter.DrawObject(e.Info);
                e.Handled = true;
                e.Info.Bounds = r;
                e.Info.DisplayText = text;
            }
        }

        public static string getAccount
        {
            get
            {
                return strAcct;
            }
            set
            {
                strAcct = value;
            }
        }

        public static string getUserName
        {
            get
            {
                return strUserName;
            }
            set
            {
                strUserName = value;
            }
        }

        public static string getDeptID
        {
            get
            {
                return strDeptID;
            }
            set
            {
                strDeptID = value;
            }
        }

        public static string getZTID
        {
            get
            {
                return strZTID;
            }
            set
            {
                strZTID = value;
            }
        }

        public static string getZTMC
        {
            get
            {
                return strZTMC;
            }
            set
            {
                strZTMC = value;
            }
        }

        public static string getUser
        {
            get
            {
                return strUser;
            }
            set
            {
                strUser = value;
            }
        }

        public static string getUserID
        {
            get
            {
                return strUserID;
            }
            set
            {
                strUserID = value;
            }
        }

        public static string getDeptName
        {
            get
            {
                return strDeptName;
            }
            set
            {
                strDeptName = value;
            }
        }

        //usage:  xpServerCollectionSource1.FixedFilterString = gridView1.ActiveFilterString + " And (" + FrmLogin.getChildZTID(FrmLogin.getZTID) + "[ZTID] = \'" + FrmLogin.getZTID + "\')";
        public static string getChildZTID(string strZTID)
        {
            string strChildZTID = "";
            try
            {
                OracleConnection Con = new OracleConnection(strDataCent);
                string strZFGX = "select SON_ZTID from BASE_ZFGX where ZTID = '" + strZTID + "'";
                OracleDataAdapter adaZFGX = new OracleDataAdapter(strZFGX, Con);
                DataSet ds = new DataSet();
                adaZFGX.Fill(ds, "BASE_ZFGX");

                foreach (DataRowView theRow in ds.Tables["BASE_ZFGX"].DefaultView)
                {
                    strChildZTID += "[ZTID] = \'" + theRow.Row["SON_ZTID"].ToString() + "\' Or ";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return strChildZTID;
        }

        public FrmLogin()
        {
            InitializeComponent();

            this.loginuser.Focus();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(loginuser.Text.Trim()))
            {
                MessageBox.Show("请您输入用户！！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.loginuser.Focus();
                this.comboBox1.DataSource = null;
                this.comboBox1.Items.Clear();
                this.comboBox2.DataSource = null;
                this.comboBox2.Items.Clear();
            }
            else if (string.IsNullOrEmpty(loginpassword.Text.Trim()))
            {
                MessageBox.Show("请您输入登陆密码！！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.loginpassword.Focus();
            }
            else
            {
                if (m_PassWord == this.loginpassword.Text)
                {
                    strUser = this.loginuser.Text.Trim();
                    strAcct = this.comboBox1.Text.Trim();
                    strDeptName = this.comboBox2.Text.Trim();
                    strDeptID = ((DataRowView)comboBox2.SelectedItem).Row["dwid"].ToString();
                    strZTID = ((DataRowView)comboBox1.SelectedItem).Row["ZTID"].ToString();
                    strZTMC = ((DataRowView)comboBox1.SelectedItem).Row["ZTMC"].ToString();
                    this.Close();
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    if (MessageBox.Show("用户名密码不一致，登陆失败！！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Stop) == DialogResult.OK)
                    {
                        this.loginuser.Text = "";
                        this.loginpassword.Text = "";
                        this.loginuser.Focus();
                        this.comboBox1.DataSource = null;
                        this.comboBox1.Items.Clear();
                        this.comboBox2.DataSource = null;
                        this.comboBox2.Items.Clear();
                    }

                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.loginuser.Text = "";
            this.loginpassword.Text = "";
            this.comboBox1.DataSource = null;
            this.comboBox1.Items.Clear();
            this.comboBox2.DataSource = null;
            this.comboBox2.Items.Clear();
            this.errorProvider1.Clear();
            this.errorProvider2.Clear();
            this.loginuser.Focus();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
        }

        private void loginuser_Validating(object sender, EventArgs e)
        {
            string error = null;
            this.comboBox1.DataSource = null;
            this.comboBox1.Items.Clear();


            if (string.IsNullOrEmpty(loginuser.Text.Trim()))
            {
                error = "请您输入用户！！";
                this.loginuser.Focus();
                this.comboBox1.DataSource = null;
                this.comboBox1.Items.Clear();
                this.comboBox2.DataSource = null;
                this.comboBox2.Items.Clear();
            }
            else
            {
                string strUser = "select * from SYS_USER where username = '" + this.loginuser.Text + "'";

                string strAccount = "select c.ztid, c.ztmc from jt_j_ztbm c where c.ztid in " +
                                    "(select distinct b.bmztid from jt_j_dwxx b where " +
                                    "b.dwid in (select a.departmentid from sys_user_department a " +
                                    "where a.username = '" + this.loginuser.Text + "'))";


                try
                {
                    OracleConnection Con = new OracleConnection(strDataCent);
                    DataSet ds = new DataSet();
                    OracleDataAdapter adaUser = new OracleDataAdapter(strUser, Con);
                    adaUser.Fill(ds, "USER");

                    OracleDataAdapter adaAcct = new OracleDataAdapter(strAccount, Con);
                    adaAcct.Fill(ds, "ACCOUNT");

                    if (ds.Tables["USER"].Rows.Count != 0)
                    {
                        this.comboBox1.DataSource = ds.Tables["ACCOUNT"];
                        this.comboBox1.DisplayMember = "ztmc";
                        this.comboBox1.ValueMember = "ztid";
                    }
                    else
                    {
                        error = "数据库中无此用户！！";
                        this.loginuser.Focus();
                        this.comboBox1.DataSource = null;
                        this.comboBox1.Items.Clear();
                        this.comboBox2.DataSource = null;
                        this.comboBox2.Items.Clear();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

            errorProvider1.SetError((Control)sender, error);

        }

        private void loginpassword_Validating(object sender, EventArgs e)
        {
            string error = null;
            if (string.IsNullOrEmpty(loginpassword.Text.Trim()))
            {
                error = "请您输入登陆密码！！";
            }
            else
            {
                string strPass = "select * from SYS_USER where username = '" + this.loginuser.Text + "'";

                try
                {
                    OracleConnection Con = new OracleConnection(strDataCent);
                    OracleDataAdapter adapter = new OracleDataAdapter(strPass, Con);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    m_PassWord = ds.Tables[0].Rows[0]["PASSWORD"].ToString();
                    strUserID = ds.Tables[0].Rows[0]["EMPID"].ToString();

                    if (m_PassWord != this.loginpassword.Text)
                    {
                        error = "密码错误！！";
                    }

                    string sqlUSERNAME = "select t.operatorname from base_operator t where t.operatorid = '" + strUserID + "'";

                    OracleDataAdapter adaUserName = new OracleDataAdapter(sqlUSERNAME, Con);
                    DataSet dsUserName = new DataSet();
                    adaUserName.Fill(dsUserName);
                    strUserName = dsUserName.Tables[0].Rows[0]["OPERATORNAME"].ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

            errorProvider2.SetError((Control)sender, error);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                string strDepart = "SELECT dwid, dwmc FROM jt_j_dwxx  WHERE dwid IN (SELECT departmentid "
                                 + "FROM sys_user_department WHERE  username='" + this.loginuser.Text + "') and bmztid = '"
                                 + ((DataRowView)comboBox1.SelectedItem).Row["ZTID"].ToString() + "'";

                this.comboBox2.DataSource = null;
                this.comboBox2.Items.Clear();

                try
                {
                    OracleConnection Con = new OracleConnection(strDataCent);
                    OracleDataAdapter Adapter = new OracleDataAdapter(strDepart, Con);
                    DataSet ds = new DataSet();
                    Adapter.Fill(ds, "CUSTOMDEPT");

                    this.comboBox2.DataSource = ds.Tables["CUSTOMDEPT"];
                    this.comboBox2.DisplayMember = "dwmc";
                    this.comboBox2.ValueMember = "dwid";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void loginpassword_TextChanged(object sender, EventArgs e)
        {

        }



    }
}
