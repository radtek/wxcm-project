using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClientMain
{
    public partial class FrmDeptQuery : Form
    {
        public FrmDeptQuery()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string getDeptName()
        {
            return this.tbDeptName.Text.Trim();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (tbDeptName.Text == "")
            {
                if (MessageBox.Show("部门名称不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Stop) == DialogResult.OK)
                {
                    this.tbDeptName.Focus();
                }
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }  
        }
    }
}
