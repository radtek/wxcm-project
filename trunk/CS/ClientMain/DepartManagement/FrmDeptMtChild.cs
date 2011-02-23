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
    public partial class FrmDeptMtChild : Form
    {
        string m_strDeptName;
        string m_strDeptDesc;
        string m_strZTID;
        string m_strDeptNum;
        string m_strSFZT;

        public string getDeptName()
        {
            return this.txtDeptName.Text.Trim();
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
            return this.cbAcctChose.Text.Trim();
        }

        public string getISZT()
        {
            return this.cbISAcct.SelectedIndex.ToString().Trim();
        }

        public FrmDeptMtChild()
        {
            InitializeComponent();
        }

        public FrmDeptMtChild(string strDeptName, string strDeptDesc, string strZTID, string strDeptNum, string strSFZT)
        {
            InitializeComponent();
            m_strSFZT = strSFZT;
            m_strDeptDesc = strDeptDesc;
            m_strDeptName = strDeptName;
            m_strDeptNum = strDeptNum;
            m_strZTID = strZTID;

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
            int iAcct = 0;
            int.TryParse(m_strSFZT, out iAcct);
            this.cbISAcct.Items.Add("否");
            this.cbISAcct.Items.Add("是");
            this.cbISAcct.SelectedIndex = iAcct;

            Dictionary<string, string> dict = FrmLogin.getDictID2Name;
            foreach (var item in dict.Values)
            {
                this.cbAcctChose.Items.Add(item);
            }
            this.cbAcctChose.SelectedItem = m_strZTID;

            this.txtDeptDsc.Text = m_strDeptDesc;
            this.txtDeptNum.Text = m_strDeptNum;
            this.txtDeptName.Text = m_strDeptName;

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

        private void txtDeptNum_Validating(object sender, EventArgs e)
        { 
        }

        private void txtDeptName_Validating(object sender, EventArgs e)
        {
        }

        private void txtDeptDsc_Validating(object sender, EventArgs e)
        {
        }

    }
}
