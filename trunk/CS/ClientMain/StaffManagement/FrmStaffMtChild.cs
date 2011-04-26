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
    public partial class FrmStaffMtChild : Form
    {
        string m_StaffNum;
        string m_StaffName;
        string m_FastCode;
        string m_Gender;
        string m_Birth;
        string m_Email;
        string m_Address;
        string m_Tel;
        string m_Mobile;
        string m_SuperUnit;

        OracleConnection Con;
        OracleDataAdapter AdaSuperUnit;
        DataSet ds;     

        public FrmStaffMtChild()
        {
            InitializeComponent();
        }

        public FrmStaffMtChild(string strStaffNum, string strStaffName, string strFastCode, 
                               string strGender, string strBirth, string strEmail,
                               string strAddress, string strTel, string strMobile, string strSuperUnit)
        { 
            InitializeComponent();

            m_StaffNum = strStaffNum;
            m_StaffName = strStaffName;
            m_FastCode = strFastCode;
            m_Gender = strGender;
            m_Birth = strBirth;
            m_Email = strEmail;
            m_Address = strAddress;
            m_Tel = strTel;
            m_Mobile = strMobile;
            m_SuperUnit = strSuperUnit;
        }
        

        private void FrmStaffMtChild_Load(object sender, EventArgs e)
        {
            string strCon = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.8.222)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XINHUA)));User Id=xxb;Password=pass;Integrated Security=no;";
            Con = new OracleConnection(strCon);

            string sqlSuperUnit = "select DEPARTMENTID, DEPARTMENTNAME from SYS_DEPARTMENT";
            AdaSuperUnit = new OracleDataAdapter(sqlSuperUnit, Con);
            ds = new DataSet();
            AdaSuperUnit.Fill(ds, "SYS_DEPARTMENT");

            cbSuperUnit.DataSource = ds.Tables["SYS_DEPARTMENT"];
            cbSuperUnit.ValueMember = "DEPARTMENTID";
            cbSuperUnit.DisplayMember = "DEPARTMENTNAME";
            cbSuperUnit.SelectedItem = m_SuperUnit;

            this.comboBox1.Items.Add("女");
            this.comboBox1.Items.Add("男");            
            this.comboBox1.SelectedItem = m_Gender;

            this.tbAddress.Text = m_Address;
            this.tbEmail.Text = m_Email;
            this.tbFastCode.Text = m_FastCode;
            this.tbMobile.Text = m_Mobile;
            this.tbName.Text = m_StaffName;
            this.tbStaffNum.Text = m_StaffNum;
            this.tbTel.Text = m_Tel;
            this.dateTimePicker1.Text = m_Birth;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || tbStaffNum.Text == "" || cbSuperUnit.Text == "")
            {
                if (MessageBox.Show("员工姓名、编号和上级部门不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Stop) == DialogResult.OK)
                {
                    this.tbName.Focus();
                }
            }
            else
            {
                string sql = "select * from SYS_EMPLOYEES where EMPLOYEENO = '" + tbStaffNum.Text +"'";
                OracleDataAdapter Ada = new OracleDataAdapter(sql, Con);
                DataSet dataset = new DataSet();
                Ada.Fill(dataset, "SYS_EMPLOYEES");
                if ((dataset.Tables["SYS_EMPLOYEES"].Rows.Count != 0) && (this.Text == "增加员工"))
                {
                    if (MessageBox.Show("员工编号必须唯一！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Stop) == DialogResult.OK)
                    {
                        this.tbStaffNum.Focus();
                    }
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string getName()
        {
            return this.tbName.Text.Trim();
        }

        public string getNum()
        {
            return this.tbStaffNum.Text.Trim();
        }

        public string getFastCode()
        {
            return this.tbFastCode.Text.Trim();
        }

        public string getGender()
        {
            return this.comboBox1.Text.Trim();
        }

        public string getBirth()
        {
            return this.dateTimePicker1.Text.Trim();
        }

        public string getMobile()
        {
            return this.tbMobile.Text.Trim();
        }

        public string getTel()
        {
            return this.tbTel.Text.Trim();
        }

        public string getEmail()
        {
            return this.tbEmail.Text.Trim();
        }

        public string getAddress()
        {
            return this.tbAddress.Text.Trim();
        }

        public string getSuperUnit()
        {
            return ((DataRowView)cbSuperUnit.SelectedItem).Row["DEPARTMENTID"].ToString();
        }
    }
}
