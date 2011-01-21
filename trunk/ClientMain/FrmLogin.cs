using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;



namespace ClientMain
{
    public partial class FrmLogin : Form
    {
        OracleConnection m_cnn = null;

        public FrmLogin()
        {
            InitializeComponent();

            if (this.loginuser.Text == "")
                this.loginpassword.Enabled = false;
            else
                this.loginpassword.Enabled = true; 
        }

        public string getAccount()
        {
            return this.comboBox1.Text.Trim();
        }

        public string getUser()
        {
            return this.loginuser.Text.Trim();
        }

        public string getDepartment()
        {
            return this.comboBox2.Text.Trim();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(loginuser.Text.Trim()))
            {
                MessageBox.Show("请您输入用户！！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.loginuser.Text = "";
                this.loginuser.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(loginpassword.Text.Trim()))
            {
                MessageBox.Show("请您输入登陆密码！！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.loginpassword.Text = "";
                this.loginpassword.Focus();
                return;
            }
            if (true)
            {
                FrmClientMain frmClient = new FrmClientMain(this.getAccount(), this.getUser(), this.getDepartment());
                frmClient.Show();
                this.Hide();
            }
            else
            {
                if(MessageBox.Show("用户名密码不一致，登陆失败！！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Stop) == DialogResult.OK)
                {
                    this.loginuser.Text = "";
                    this.loginpassword.Text = "";
                    this.loginpassword.Enabled = false;
                    this.comboBox1.Text = "";
                    this.comboBox2.Text = "";
                    this.loginuser.Focus(); 
                }
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            GC.Collect();
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.loginuser.Text = "";
            this.loginpassword.Text = "";
            this.loginpassword.Enabled = false;
            this.comboBox1.Text = "";
            this.comboBox2.Text = "";
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            string strCon = "Data Source=XINHUA;User Id=xxb;Password=pass;Integrated Security=no;";
            m_cnn = new OracleConnection();
            m_cnn.ConnectionString = strCon;
            try
            {
                m_cnn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //if (cnn.State != ConnectionState.Closed)
                //{
                //    cnn.Close();
                //}
            }
        }

        private void loginuser_TextChanged(object sender, EventArgs e)
        {
            this.loginpassword.Enabled = true;
        }

        private void loginpassword_Enter(object sender, EventArgs e)
        {
            string strSQLAccount = "select e.ztid,e.ztmc from sys_user  a " +
            "left join  sys_employees b  on b.employeeid=a.empid " +
            "left join  sys_empee_department c on c.employeeid=b.employeeid " +
            "left join  sys_department  d on d.departmentid=c.departmentid " +
            "left join  sys_ztbm  e on e.ztid=d.ztid " +
            "where a.username='" + this.loginuser.Text + "'";

            string strSQLDepart = "SELECT departmentid, " +
           "departmentname " +
           "FROM sys_department " +
           " WHERE departmentid IN (SELECT departmentid " +
           " FROM sys_empee_department " +
           " WHERE employeeid=(select empid from sys_user where username='" + this.loginuser.Text + "')) and ztid='" + this.comboBox1.Text + "'";

            OracleDataAdapter myDa = new OracleDataAdapter();
            myDa.SelectCommand = new OracleCommand(strSQLAccount, m_cnn); 
            DataSet myDs = new DataSet();
            myDa.Fill(myDs);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

    }
}
