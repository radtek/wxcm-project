using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClientMain
{
    public partial class FrmDeptMtChild : DevExpress.XtraEditors.XtraForm
    {
        public string getBank()
        {
            return teBank.Text.Trim();
        }

        public string getAccount()
        {
            return teAccount.Text.Trim();
        }

        public string getTaxNum()
        {
            return teTaxNum.Text.Trim();
        }

        public string getTel()
        {
            return teTel.Text.Trim();
        }

        public string getAddr()
        {
            return teAddr.Text.Trim();
        }

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
            return ((DataRowView)cbAcctChose.SelectedItem).Row["ZTID"].ToString();
        }

        public string getISZT()
        {
            return cbISAcct.SelectedIndex.ToString();
        }

        public string getUnitProp()
        {
            string str = "";
            if (cbUnitProp.Text != "")
            { 
                str = ((DataRowView)cbUnitProp.SelectedItem).Row["DWSXID"].ToString();
            }
            return str;
        }

        public string getPressType()
        {
            
            string str = "";
            if (cbPressType.Text != "")
            {
                str = ((DataRowView)cbPressType.SelectedItem).Row["CBSLXID"].ToString();
            }
            return str;
        }

        public string getFacType()
        {
            
            string str = "";
            if (cbFacType.Text != "")
            {
                str = ((DataRowView)cbFacType.SelectedItem).Row["YSCLXID"].ToString();
            }
            return str;
        }

        public string getWareType()
        {
            
            string str = "";
            if (cbWareType.Text != "")
            {
                str = ((DataRowView)cbWareType.SelectedItem).Row["KFLXID"].ToString();
            }
            return str;
        }

        public string getTransType()
        {
            
            string str = "";
            if (cbTransType.Text != "")
            {
                str = ((DataRowView)cbTransType.SelectedItem).Row["YSDWLXID"].ToString();
            }
            return str;
        }

        public string getDeptType()
        {
            
            string str = "";
            if (cbDeptType.Text != "")
            {
                str = ((DataRowView)cbDeptType.SelectedItem).Row["DEPARTTYPEID"].ToString();
            }
            return str;
        }

        public string getClientType()
        {
            
            string str = "";
            if (cbClientType.Text != "")
            {
                str = ((DataRowView)cbClientType.SelectedItem).Row["KHLXID"].ToString();
            }
            return str;
        }

        public string getSuperUnit()
        {
           
            string str = "";
            if (cbSuperUnit.Text != "")
            {
                str = ((DataRowView)cbSuperUnit.SelectedItem).Row["DEPARTMENTID"].ToString();
            }
            return str;
        }

        public string getSupType()
        {
            
            string str = "";
            if (cbSupType.Text != "")
            {
                str = ((DataRowView)cbSupType.SelectedItem).Row["GYSLXID"].ToString();
            }
            return str;
        }

       

        public FrmDeptMtChild(OracleConnection Con, OracleTransaction Trans, string strDeptName = null, string strDeptDesc = null, string strZTID = null, string strDeptNum = null, string strSFZT = null,
                              string strUnitProp = null, string strDeptType = null, string strClientType = null, string strSupType = null,
                              string strPressType = null, string strFacType = null, string strWareType = null, string strTransType = null,
                              string strSuperUnit = null, string strKHD = null, string strJCJC = null, string strYTH = null, string strTaxNum = null,
                              string strBank = null, string strAccount = null, string strAddr = null, string strTel = null)
        {
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

            InitializeComponent();

            string sqlTransType = "select YSDWLXID, YSDWLX from JT_J_YSDWLX where ZT = '1'";
            AdaTransType = new OracleDataAdapter(sqlTransType, Con);
            AdaTransType.SelectCommand.Transaction = Trans;

            string sqlClientType = "select KHLXID, KHLXMC from JT_J_KHLX where ZT = '1'";
            AdaClientType = new OracleDataAdapter(sqlClientType, Con);
            AdaClientType.SelectCommand.Transaction = Trans;

            string sqlDeptType = "select DEPARTTYPEID, DEPARTTYPENAME from BASE_DEPARTTYPE where ZT = '1'";
            AdaDeptType = new OracleDataAdapter(sqlDeptType, Con);
            AdaDeptType.SelectCommand.Transaction = Trans;

            string sqlPressType = "select CBSLXID, CBSLX from JT_J_CBSLX where ZT = '1'";
            AdaPressType = new OracleDataAdapter(sqlPressType, Con);
            AdaPressType.SelectCommand.Transaction = Trans;

            string sqlFacType = "select YSCLXID, YSCDWLX from JT_J_YSCLX where ZT = '1'";
            AdaFacType = new OracleDataAdapter(sqlFacType, Con);
            AdaFacType.SelectCommand.Transaction = Trans;

            string sqlSupType = "select GYSLXID, GYSLX from JT_J_GYSLX where ZT = '1'";
            AdaSupType = new OracleDataAdapter(sqlSupType, Con);
            AdaSupType.SelectCommand.Transaction = Trans;

            string sqlUnitProp = "select DWSXID, DWSX from JT_J_DWSX where ZT = '1'";
            AdaUnitProp = new OracleDataAdapter(sqlUnitProp, Con);
            AdaUnitProp.SelectCommand.Transaction = Trans;

            string sqlWareType = "select KFLXID, KFLX from JT_J_KFLX where ZT = '1'";
            AdaWareType = new OracleDataAdapter(sqlWareType, Con);
            AdaWareType.SelectCommand.Transaction = Trans;

            string sqlSuperUnit = "select DEPARTMENTID, DEPARTMENTNAME from SYS_DEPARTMENT";
            AdaSuperUnit = new OracleDataAdapter(sqlSuperUnit, Con);
            AdaSuperUnit.SelectCommand.Transaction = Trans;

            string sqlZTBM = "select ZTID, ZTMC from SYS_ZTBM";
            AdaZTBM = new OracleDataAdapter(sqlZTBM, Con);
            AdaZTBM.SelectCommand.Transaction = Trans;

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
            cbClientType.SelectedItem = strClientType;

            cbTransType.DataSource = ds.Tables["JT_J_YSDWLX"];
            cbTransType.ValueMember = "YSDWLXID";
            cbTransType.DisplayMember = "YSDWLX";
            cbTransType.SelectedItem = strTransType;

            cbDeptType.DataSource = ds.Tables["BASE_DEPARTTYPE"];
            cbDeptType.ValueMember = "DEPARTTYPEID";
            cbDeptType.DisplayMember = "DEPARTTYPENAME";
            cbDeptType.SelectedItem = strDeptType;

            cbPressType.DataSource = ds.Tables["JT_J_CBSLX"];
            cbPressType.ValueMember = "CBSLXID";
            cbPressType.DisplayMember = "CBSLX";
            cbPressType.SelectedItem = strPressType;

            cbFacType.DataSource = ds.Tables["JT_J_YSCLX"];
            cbFacType.ValueMember = "YSCLXID";
            cbFacType.DisplayMember = "YSCDWLX";
            cbFacType.SelectedItem = strFacType;

            cbSupType.DataSource = ds.Tables["JT_J_GYSLX"];
            cbSupType.ValueMember = "GYSLXID";
            cbSupType.DisplayMember = "GYSLX";
            cbSupType.SelectedItem = strSupType;

            cbUnitProp.DataSource = ds.Tables["JT_J_DWSX"];
            cbUnitProp.ValueMember = "DWSXID";
            cbUnitProp.DisplayMember = "DWSX";
            cbUnitProp.SelectedItem = strUnitProp;

            cbWareType.DataSource = ds.Tables["JT_J_KFLX"];
            cbWareType.ValueMember = "KFLXID";
            cbWareType.DisplayMember = "KFLX";
            cbWareType.SelectedItem = strWareType;

            cbSuperUnit.DataSource = ds.Tables["SYS_DEPARTMENT"];
            cbSuperUnit.ValueMember = "DEPARTMENTID";
            cbSuperUnit.DisplayMember = "DEPARTMENTNAME";
            cbSuperUnit.SelectedItem = strSuperUnit;

            cbAcctChose.DataSource = ds.Tables["SYS_ZTBM"];
            cbAcctChose.ValueMember = "ZTID";
            cbAcctChose.DisplayMember = "ZTMC";
            cbAcctChose.SelectedItem = strZTID;

            int iAcct = 0;
            int.TryParse(strSFZT, out iAcct);
            this.cbISAcct.Items.Add("否");
            this.cbISAcct.Items.Add("是");
            this.cbISAcct.SelectedIndex = iAcct;

            this.txtDeptDsc.Text = strDeptDesc;
            this.txtDeptNum.Text = strDeptNum;
            this.txtDeptName.Text = strDeptName;
            this.tbJCJC.Text = strJCJC;
            this.tbYTH.Text = strYTH;
            this.tbKHD.Text = strKHD;
            teAccount.Text = strAccount;
            teAddr.Text = strAddr;
            teBank.Text = strBank;
            teTel.Text = strTel;
            teTaxNum.Text = strTaxNum;

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
