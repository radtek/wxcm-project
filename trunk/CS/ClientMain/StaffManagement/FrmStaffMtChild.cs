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
    public partial class FrmStaffMtChild : DevExpress.XtraEditors.XtraForm
    {
        OracleConnection m_Con;
        OracleTransaction m_Trans;
        public FrmStaffMtChild(OracleConnection Con, OracleTransaction Trans,
                               string strStaffNum = null, string strStaffName = null, string strFastCode = null,
                               string strGender = null, string strBirth = null, string strEmail = null,
                               string strAddress = null, string strTel = null, string strMobile = null, string strSuperUnit = null)
        {
            m_Con = Con;
            m_Trans = Trans;
            OracleDataAdapter AdaSuperUnit;
            DataSet ds;     

            InitializeComponent();

            string sqlSuperUnit = "select DEPARTMENTID, DEPARTMENTNAME from SYS_DEPARTMENT";
            AdaSuperUnit = new OracleDataAdapter(sqlSuperUnit, Con);
            AdaSuperUnit.SelectCommand.Transaction = Trans;

            ds = new DataSet();
            AdaSuperUnit.Fill(ds, "SYS_DEPARTMENT");

            cbSuperUnit.DataSource = ds.Tables["SYS_DEPARTMENT"];
            cbSuperUnit.ValueMember = "DEPARTMENTID";
            cbSuperUnit.DisplayMember = "DEPARTMENTNAME";
            cbSuperUnit.SelectedItem = strSuperUnit;

            this.comboBox1.Items.Add("女");
            this.comboBox1.Items.Add("男");
            this.comboBox1.SelectedItem = strGender;

            this.tbAddress.Text = strAddress;
            this.tbEmail.Text = strEmail;
            this.tbFastCode.Text = strFastCode;
            this.tbMobile.Text = strMobile;
            this.tbName.Text = strStaffName;
            this.tbStaffNum.Text = strStaffNum;
            this.tbTel.Text = strTel;
            this.dateTimePicker1.Text = strBirth;
        }
        

        private void FrmStaffMtChild_Load(object sender, EventArgs e)
        {
            
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
                OracleDataAdapter Ada = new OracleDataAdapter(sql, m_Con);
                Ada.SelectCommand.Transaction = m_Trans;
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
            string str = "";
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                str = this.comboBox1.SelectedIndex.ToString().Trim();
            }
            return str;
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
