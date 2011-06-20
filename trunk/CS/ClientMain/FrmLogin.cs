using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;
using System.Configuration;
using System.Diagnostics; 



namespace ClientMain
{

    public partial class FrmLogin : Form
    {
        private static string strAcct = "";
        private static string strDeptName = "";
        private static string strUser = "";
        private static string strDeptID = "";
        private static string strZTID = "";
        private static Dictionary<string, string> m_dictName2ID = new Dictionary<string, string>();
        private static Dictionary<string, string> m_dictID2Name = new Dictionary<string, string>();
                
        private string m_PassWord = null;
        private string strCon = ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString;//数据库连接
        private string sofverison = ConfigurationManager.ConnectionStrings["ver"].ConnectionString;//当前版本信息
        private string sofcurrentver = string.Empty;//数据库中当前版本信息
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

        public static  Dictionary<string, string> getDictID2Name
        {
            get
            {
                return m_dictID2Name;
            }
            set
            {
                m_dictID2Name = value;
            }
        }

        public static Dictionary<string, string> getDictName2ID
        {
            get
            {
                return m_dictName2ID;
            }
            set
            {
                m_dictName2ID = value;
            }
        }

        public FrmLogin()
        {
            InitializeComponent();

            this.loginuser.Focus(); 
        }
        private OracleConnection MyConn = null;
        //定义数据库连接
        private void Open()
        {
            string StrCon = ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString;
            MyConn = new OracleConnection(StrCon);
            if (MyConn.State.ToString() != "Open")
                MyConn.Open();
        }
        //定义数据库关闭
        private void sClose()
        {
            //  if (ds != null)
            //  { ds.Dispose(); }
            if (MyConn != null & MyConn.State.ToString() != "Closed")
            { MyConn.Close(); }
        }
        //判断版本是否需要更新
        private bool CheckVeriosn()
        {
            try 
            {
                this.Open();
                string selectverion = "select VERSION from UPDATAVERSION where ID='"+"1'";
                OracleCommand mycomm = new OracleCommand(selectverion,MyConn);
                OracleDataReader myreader = mycomm.ExecuteReader();
                while (myreader.Read())
                {
                    sofcurrentver = myreader.GetValue(0).ToString();
                }
                

            }
            catch (OracleException)
            {
                MessageBox.Show("To run this example, replace the value of the " +
                       "connectionString variable with a connection string that is " +
                       "valid for your system.");
            }
            if (sofverison==sofcurrentver)
            {return false;}
             else
            { return true; }
        
        }
        //以上函数判断版本是否需要更新
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
                    FrmLogin.strUser = this.loginuser.Text.Trim();
                    FrmLogin.strAcct = this.comboBox1.Text.Trim();
                    FrmLogin.strDeptName = this.comboBox2.Text.Trim();
                    FrmLogin.strDeptID = ((DataRowView)comboBox2.SelectedItem).Row["departmentid"].ToString();
                    FrmLogin.strZTID = ((DataRowView)comboBox1.SelectedItem).Row["ZTID"].ToString();
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
            m_dictID2Name.Clear();
            m_dictName2ID.Clear();
            if (CheckVeriosn())
            {
                this.button1.Visible = false;
                this.button2.Visible = false;
                this.button3.Visible = false;
                this.button4.Visible = true;
                this.loginuser.ReadOnly = true;
                this.loginpassword.ReadOnly = false;
                label6.Text = "您的版本需要更新为" + sofcurrentver.ToString();
                timer1.Start();
            }
            else
            {
                this.button4.Visible = false;
            label6.Text = "欢迎使用皖新传媒集团综合运维平台当前版本为V_" + sofverison.ToString();
            timer1.Start();
            OracleConnection Con = new OracleConnection(strCon);
            
            try
            {
                string strZTBM = "select ZTID, ZTMC from SYS_ZTBM";
                OracleDataAdapter adaZTBM = new OracleDataAdapter(strZTBM, Con);
                DataSet ds = new DataSet();
                adaZTBM.Fill(ds, "SYS_ZTBM");
                m_dictID2Name.Add("", "");
                m_dictName2ID.Add("", "");
                foreach (DataRowView theRow in ds.Tables["SYS_ZTBM"].DefaultView)
                {
                    m_dictName2ID.Add(theRow.Row["ZTMC"].ToString(), theRow.Row["ZTID"].ToString());
                    m_dictID2Name.Add(theRow.Row["ZTID"].ToString(), theRow.Row["ZTMC"].ToString());
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
    
            }
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

                string strAccount = "select c.ztid, c.ztmc from sys_ztbm c where c.ztid in " +
                                    "(select distinct b.ztid from sys_department b where " +
                                    "b.departmentid in (select a.departmentid from sys_user_department a " +
                                    "where a.username = '" + this.loginuser.Text + "'))";
                

                OracleConnection Con = new OracleConnection(strCon);
                
                try
                {
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
                string strPass = "select password from SYS_USER where username = '" + this.loginuser.Text + "'";

                OracleConnection Con = new OracleConnection(strCon);
                
                try
                {
                    OracleDataAdapter adapter = new OracleDataAdapter(strPass, Con);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "SYS_USER_PASS");
                    foreach (DataRowView theRow in ds.Tables["SYS_USER_PASS"].DefaultView)
                    {
                        m_PassWord = theRow.Row["PASSWORD"].ToString();
                    }                    
                   
                    if (m_PassWord != this.loginpassword.Text)
                    {
                        error = "密码错误！！";
                    }
                    
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
            string strDepart = "SELECT departmentid, " +
                           "departmentname " +
                           "FROM sys_department " +
                           " WHERE departmentid IN (SELECT departmentid " +
                           " FROM sys_user_department " +
                           " WHERE  username='" + this.loginuser.Text + "') and ztid='" +
                            m_dictName2ID[this.comboBox1.Text] + "'";
            
            this.comboBox2.DataSource = null;
            this.comboBox2.Items.Clear();

            try
            {
                OracleConnection Con = new OracleConnection(strCon);
                OracleDataAdapter Adapter = new OracleDataAdapter(strDepart, Con);
                DataSet ds = new DataSet();
                Adapter.Fill(ds, "CUSTOMDEPT");

                this.comboBox2.DataSource = ds.Tables["CUSTOMDEPT"];
                this.comboBox2.DisplayMember = "departmentname";
                this.comboBox2.ValueMember = "departmentid";
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int FWidth = this.panel2.Width;
             int FHeight = this.panel2.Height;

              Point LPos = new Point(this.label6.Location.X, this.label6.Location.Y);
             if (LPos.X < FWidth)
             {
               this.label6.Location = new Point(LPos.X+2, LPos.Y);
               return;
              }
             else
             {
                 this.label6.Location = new Point(0, 50);
              }


        }

        private void button4_Click(object sender, EventArgs e)
        {

            Process ps = new Process();
            ps.StartInfo.FileName = Application.StartupPath + "\\XHAutoUpdate.exe";
            ps.Start();
            this.Close();

        }

    }
}
