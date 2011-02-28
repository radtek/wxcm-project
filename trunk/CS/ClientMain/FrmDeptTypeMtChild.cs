using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ClientMain
{
    public partial class FrmDeptTypeMtChild : DevExpress.XtraEditors.XtraForm
    {
        string m_strName;
        string m_strNo;
        string m_strZT;

        public FrmDeptTypeMtChild()
        {
            InitializeComponent();
        }

        public FrmDeptTypeMtChild(string strName, string strNo, string strZT)
        {
            InitializeComponent();
            m_strName = strName;
            m_strNo = strNo;
            m_strZT = strZT;
        }

        private void FrmDeptTypeMtChild_Load(object sender, EventArgs e)
        {
            cbStatus.Items.Add("录入");
            cbStatus.Items.Add("启用");
            cbStatus.Items.Add("停用");
            cbStatus.SelectedItem = m_strZT;

            tbNum.Text = m_strNo;
            tbType.Text = m_strName;
        }
        public string getName()
        {
            return tbType.Text.Trim();
        }

        public string getNum()
        {
            return tbNum.Text.Trim();
        }

        public string getStatus()
        {
            return cbStatus.Text.Trim();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbNum.Text == "" || tbType.Text == "")
            {
                if (MessageBox.Show("类型及类型编号不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Stop) == DialogResult.OK)
                {
                    tbNum.Focus();
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
    }
}