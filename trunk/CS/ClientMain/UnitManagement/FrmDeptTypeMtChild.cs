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
        public FrmDeptTypeMtChild(string strName=null, string strNo=null, string strZT=null)
        {
            InitializeComponent();

            cbStatus.Items.Add("录入");
            cbStatus.Items.Add("启用");
            cbStatus.Items.Add("停用");
            cbStatus.SelectedItem = strZT;

            tbNum.Text = strNo;
            tbType.Text = strName;
        }

        private void FrmDeptTypeMtChild_Load(object sender, EventArgs e)
        {
            
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
            string str = "";
            if (!String.IsNullOrEmpty(cbStatus.Text))
            {
                str = this.cbStatus.SelectedIndex.ToString().Trim();
            }
            return str;
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