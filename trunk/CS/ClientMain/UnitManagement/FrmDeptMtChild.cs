using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace ClientMain
{
    public partial class FrmDeptMtChild : Form
    {
        string m_strDeptName;
        string m_strDeptDesc;
        string m_strZTID;
        string m_strDeptNum;
        string m_strSFZT;
        string m_strUnitProp;
        string m_strDeptType;
        string m_strClientType;
        string m_strSupType;
        string m_strPressType;
        string m_strFacType;
        string m_strWareType;
        string m_strTransType;
        string m_strSuperUnit;
        string m_strKHD;
        string m_strYTH;
        string m_strJCJC;

        OracleConnection Con;
        OracleDataAdapter AdaUnitProp;
        OracleDataAdapter AdaDeptType;
        OracleDataAdapter AdaClientType;
        OracleDataAdapter AdaSupType;
        OracleDataAdapter AdaPressType;
        OracleDataAdapter AdaFacType;
        OracleDataAdapter AdaWareType;
        OracleDataAdapter AdaTransType;
        OracleDataAdapter AdaSuperUnit;
        OracleDataAdapter AdaZTBM;
        DataSet ds;       
        
        

        public string getDeptName()
        {
            return this.txtDeptName.Text.Trim();
        }

        public string getKHDNum()
        {
            return this.tbKHD.Text.Trim();
        }

        public string getJCJCNum()
        {
            return this.tbJCJC.Text.Trim();
        }

        public string getYTHNum()
        {
            return this.tbYTH.Text.Trim();
        }

        public string getDeptDesc()
        {
            return this.txtDeptDsc.Text.Trim();
        }

        public string getDeptNum()
        {
            return this.txtDeptNum.Text.Trim();
        }

        public string getZTID()
        {
            return cbAcctChose.Text.Trim();
        }

        public string getISZT()
        {
            return this.cbISAcct.SelectedIndex.ToString().Trim();
        }

        public string getUnitProp()
        {
            string str = null;
            if (cbUnitProp.Text != "")
            { 
                str = ((DataRowView)cbUnitProp.SelectedItem).Row["DWSXID"].ToString();
            }
            return str;
        }

        public string getPressType()
        {
            
            string str = null;
            if (cbPressType.Text != "")
            {
                str = ((DataRowView)cbPressType.SelectedItem).Row["CBSLXID"].ToString();
            }
            return str;
        }

        public string getFacType()
        {
            
            string str = null;
            if (cbFacType.Text != "")
            {
                str = ((DataRowView)cbFacType.SelectedItem).Row["YSCLXID"].ToString();
            }
            return str;
        }

        public string getWareType()
        {
            
            string str = null;
            if (cbWareType.Text != "")
            {
                str = ((DataRowView)cbWareType.SelectedItem).Row["KFLXID"].ToString();
            }
            return str;
        }

        public string getTransType()
        {
            
            string str = null;
            if (cbTransType.Text != "")
            {
                str = ((DataRowView)cbTransType.SelectedItem).Row["YSDWLXID"].ToString();
            }
            return str;
        }

        public string getDeptType()
        {
            
            string str = null;
            if (cbDeptType.Text != "")
            {
                str = ((DataRowView)cbDeptType.SelectedItem).Row["DEPARTTYPEID"].ToString();
            }
            return str;
        }

        public string getClientType()
        {
            
            string str = null;
            if (cbClientType.Text != "")
            {
                str = ((DataRowView)cbClientType.SelectedItem).Row["KHLXID"].ToString();
            }
            return str;
        }

        public string getSuperUnit()
        {
           
            string str = null;
            if (cbSuperUnit.Text != "")
            {
                str = ((DataRowView)cbSuperUnit.SelectedItem).Row["DEPARTMENTID"].ToString();
            }
            return str;
        }

        public string getSupType()
        {
            
            string str = null;
            if (cbSupType.Text != "")
            {
                str = ((DataRowView)cbSupType.SelectedItem).Row["GYSLXID"].ToString();
            }
            return str;
        }

        public FrmDeptMtChild()
        {
            InitializeComponent();
        }

        public FrmDeptMtChild(string strDeptName, string strDeptDesc, string strZTID, string strDeptNum, string strSFZT, string strUnitProp, 
                              string strDeptType, string strClientType, string strSupType, string strPressType, string strFacType, string strWareType,
                              string strTransType, string strSuperUnit, string strKHD, string strJCJC, string strYTH)
        {
            InitializeComponent();

            m_strSFZT = strSFZT;
            m_strDeptDesc = strDeptDesc;
            m_strDeptName = strDeptName;
            m_strDeptNum = strDeptNum;
            m_strZTID = strZTID;
            m_strUnitProp = strUnitProp;
            m_strDeptType = strDeptType;
            m_strClientType = strClientType;
            m_strSupType = strSupType;
            m_strPressType = strPressType;
            m_strFacType = strFacType;
            m_strWareType = strWareType;
            m_strTransType = strTransType;
            m_strSuperUnit = strSuperUnit;
            m_strYTH = strYTH;
            m_strJCJC = strJCJC;
            m_strKHD = strKHD;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if(txtDeptName.Text == "" || cbAcctChose.Text == "" || txtDeptNum.Text == "")
            {
                if (MessageBox.Show("部门名称、编号和账套不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Stop) == DialogResult.OK)
                {
                    this.txtDeptName.Focus();
                }
            }
            else
	        {
	            this.DialogResult = DialogResult.OK;       
                this.Close(); 
	        }  
        }

        private void FrmDeptMtChild_Load(object sender, EventArgs e)
        {
            string strCon = ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString;
            Con = new OracleConnection(strCon);

            string sqlTransType = "select YSDWLXID, YSDWLX from JT_J_YSDWLX where ZT = '1'";
            AdaTransType = new OracleDataAdapter(sqlTransType, Con);

            string sqlClientType = "select KHLXID, KHLXMC from JT_J_KHLX where ZT = '1'";
            AdaClientType = new OracleDataAdapter(sqlClientType, Con);

            string sqlDeptType = "select DEPARTTYPEID, DEPARTTYPENAME from BASE_DEPARTTYPE where ZT = '1'";
            AdaDeptType = new OracleDataAdapter(sqlDeptType, Con);

            string sqlPressType = "select CBSLXID, CBSLX from JT_J_CBSLX where ZT = '1'";
            AdaPressType = new OracleDataAdapter(sqlPressType, Con);

            string sqlFacType = "select YSCLXID, YSCDWLX from JT_J_YSCLX where ZT = '1'";
            AdaFacType = new OracleDataAdapter(sqlFacType, Con);

            string sqlSupType = "select GYSLXID, GYSLX from JT_J_GYSLX where ZT = '1'";
            AdaSupType = new OracleDataAdapter(sqlSupType, Con);

            string sqlUnitProp = "select DWSXID, DWSX from JT_J_DWSX where ZT = '1'";
            AdaUnitProp = new OracleDataAdapter(sqlUnitProp, Con);

            string sqlWareType = "select KFLXID, KFLX from JT_J_KFLX where ZT = '1'";
            AdaWareType = new OracleDataAdapter(sqlWareType, Con);

            string sqlSuperUnit = "select DEPARTMENTID, DEPARTMENTNAME from SYS_DEPARTMENT";
            AdaSuperUnit = new OracleDataAdapter(sqlSuperUnit, Con);

            string sqlZTBM = "select ZTID, ZTMC from SYS_ZTBM";
            AdaZTBM = new OracleDataAdapter(sqlZTBM, Con);
       
            ds = new DataSet();
            AdaTransType.Fill(ds, "JT_J_YSDWLX");
            AdaClientType.Fill(ds, "JT_J_KHLX");
            AdaDeptType.Fill(ds, "BASE_DEPARTTYPE");
            AdaPressType.Fill(ds, "JT_J_CBSLX");
            AdaFacType.Fill(ds, "JT_J_YSCLX");
            AdaSupType.Fill(ds, "JT_J_GYSLX");
            AdaUnitProp.Fill(ds, "JT_J_DWSX");
            AdaWareType.Fill(ds, "JT_J_KFLX");
            AdaSuperUnit.Fill(ds, "SYS_DEPARTMENT");
            AdaZTBM.Fill(ds, "SYS_ZTBM");

            cbClientType.DataSource = ds.Tables["JT_J_KHLX"];
            cbClientType.ValueMember = "KHLXID";
            cbClientType.DisplayMember = "KHLXMC";
            cbClientType.SelectedItem = m_strClientType;

            cbTransType.DataSource = ds.Tables["JT_J_YSDWLX"];
            cbTransType.ValueMember = "YSDWLXID";
            cbTransType.DisplayMember = "YSDWLX";
            cbTransType.SelectedItem = m_strTransType;

            cbDeptType.DataSource = ds.Tables["BASE_DEPARTTYPE"];
            cbDeptType.ValueMember = "DEPARTTYPEID";
            cbDeptType.DisplayMember = "DEPARTTYPENAME";
            cbDeptType.SelectedItem = m_strDeptType;

            cbPressType.DataSource = ds.Tables["JT_J_CBSLX"];
            cbPressType.ValueMember = "CBSLXID";
            cbPressType.DisplayMember = "CBSLX";
            cbPressType.SelectedItem = m_strPressType;

            cbFacType.DataSource = ds.Tables["JT_J_YSCLX"];
            cbFacType.ValueMember = "YSCLXID";
            cbFacType.DisplayMember = "YSCDWLX";
            cbFacType.SelectedItem = m_strFacType;

            cbSupType.DataSource = ds.Tables["JT_J_GYSLX"];
            cbSupType.ValueMember = "GYSLXID";
            cbSupType.DisplayMember = "GYSLX";
            cbSupType.SelectedItem = m_strSupType;

            cbUnitProp.DataSource = ds.Tables["JT_J_DWSX"];
            cbUnitProp.ValueMember = "DWSXID";
            cbUnitProp.DisplayMember = "DWSX";
            cbUnitProp.SelectedItem = m_strUnitProp;

            cbWareType.DataSource = ds.Tables["JT_J_KFLX"];
            cbWareType.ValueMember = "KFLXID";
            cbWareType.DisplayMember = "KFLX";
            cbWareType.SelectedItem = m_strWareType;

            cbSuperUnit.DataSource = ds.Tables["SYS_DEPARTMENT"];
            cbSuperUnit.ValueMember = "DEPARTMENTID";
            cbSuperUnit.DisplayMember = "DEPARTMENTNAME";
            cbSuperUnit.SelectedItem = m_strSuperUnit;

            cbAcctChose.DataSource = ds.Tables["SYS_ZTBM"];
            cbAcctChose.ValueMember = "ZTID";
            cbAcctChose.DisplayMember = "ZTMC";
            cbAcctChose.SelectedItem = m_strZTID;

            int iAcct = 0;
            int.TryParse(m_strSFZT, out iAcct);
            this.cbISAcct.Items.Add("否");
            this.cbISAcct.Items.Add("是");
            this.cbISAcct.SelectedIndex = iAcct;

            this.txtDeptDsc.Text = m_strDeptDesc;
            this.txtDeptNum.Text = m_strDeptNum;
            this.txtDeptName.Text = m_strDeptName;
            this.tbJCJC.Text = m_strJCJC;
            this.tbYTH.Text = m_strYTH;
            this.tbKHD.Text = m_strKHD;

        }

        private void cbISAcct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbISAcct.Text == "是")
            {                
                this.cbAcctChose.Visible = false;
                this.cbAcctChose.Text = "";
                this.label4.Visible = false;
            }
            else
            {
                this.cbAcctChose.Visible = true;
                this.label4.Visible = true;   
            }
        }

        

    }
}
