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
        private string m_PassWord = null;

        public FrmLogin()
        {
            InitializeComponent();

            this.loginuser.Focus(); 
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
                this.loginuser.Focus();
                this.comboBox1.Items.Clear();
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
                    this.Close();
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    if (MessageBox.Show("用户名密码不一致，登陆失败！！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Stop) == DialogResult.OK)
                    {
                        this.loginuser.Text = "";
                        this.loginpassword.Text = "";
                        this.comboBox1.Items.Clear();
                        this.comboBox2.Items.Clear();
                        this.loginuser.Focus();

                    }

                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.loginuser.Text = "";
            this.loginpassword.Text = "";
            this.comboBox1.Items.Clear();
            this.comboBox2.Items.Clear();
            this.errorProvider1.Clear();
            this.errorProvider2.Clear();
            this.loginuser.Focus();
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
            
        }

        private void loginuser_Validating(object sender, EventArgs e)
        {
            string error = null;
            if (string.IsNullOrEmpty(loginuser.Text.Trim()))
            {
                error = "请您输入用户！！";
                this.loginuser.Focus();
                this.comboBox1.Items.Clear();
                this.comboBox2.Items.Clear();
            }
            else
            {
                string strUser = "select * from SYS_USER where username = '" + this.loginuser.Text + "'";

                string strAccount = "select e.ztid,e.ztmc from sys_user  a " +
                "left join  sys_employees b  on b.employeeid=a.empid " +
                "left join  sys_empee_department c on c.employeeid=b.employeeid " +
                "left join  sys_department  d on d.departmentid=c.departmentid " +
                "left join  sys_ztbm  e on e.ztid=d.ztid " +
                "where a.username='" + this.loginuser.Text + "'";



                try
                {
                    OracleCommand cmdUser = new OracleCommand(strUser, m_cnn);
                    OracleCommand cmdAccount = new OracleCommand(strAccount, m_cnn);

                    OracleDataReader rdrUser = cmdUser.ExecuteReader();
                    // Always call Read before accessing data.
                    if (rdrUser.Read())
                    {
                        OracleDataReader rdrAccount = cmdAccount.ExecuteReader();
                        while (rdrAccount.Read())
                        {
                            if (!this.comboBox1.Items.Contains(rdrAccount.GetString(1)))
                            {
                                this.comboBox1.Items.Add(rdrAccount.GetString(1));
                            }

                            string strDepart = "SELECT departmentid, " +
                           "departmentname " +
                           "FROM sys_department " +
                           " WHERE departmentid IN (SELECT departmentid " +
                           " FROM sys_empee_department " +
                           " WHERE employeeid=(select empid from sys_user where username='" + this.loginuser.Text + "')) and ztid='" +
                           rdrAccount.GetString(0) + "'";

                            OracleCommand cmdDepart = new OracleCommand(strDepart, m_cnn);
                            OracleDataReader rdrDept = cmdDepart.ExecuteReader();
                            while (rdrDept.Read())
                            {
                                if (!this.comboBox2.Items.Contains(rdrDept.GetString(1)))
                                {
                                    this.comboBox2.Items.Add(rdrDept.GetString(1));
                                }
                            }
                            rdrDept.Close();


                        }
                        this.comboBox1.SelectedIndex = 0;
                        this.comboBox2.SelectedIndex = 0;
                        // always call Close when done reading.
                        rdrAccount.Close();
                    }
                    else
                    {
                        error = "数据库中无此用户！！";
                        this.loginuser.Focus();
                        this.comboBox1.Items.Clear();
                        this.comboBox2.Items.Clear();                        
                    }
                    rdrUser.Close();


                    

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

                try
                {
                    OracleCommand command = new OracleCommand(strPass, m_cnn);
                    OracleDataReader reader;
                    reader = command.ExecuteReader();
                    reader.Read();
                    m_PassWord = reader.GetString(0);
                    // Always call Read before accessing data.
                    if (m_PassWord != this.loginpassword.Text)
                    {
                        error = "密码错误！！";
                    }
                    // always call Close when done reading.
                    reader.Close();
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
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

    }
}
