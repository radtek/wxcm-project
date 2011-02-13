using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClientMain
{
    public partial class FrmStaffQuery : Form
    {
        public FrmStaffQuery()
        {
            InitializeComponent();
        }

        
        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "")
            {
                if (MessageBox.Show("员工姓名不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Stop) == DialogResult.OK)
                {
                    this.tbName.Focus();
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

        public string getName()
        {
            return this.tbName.Text.Trim();
        }
    }
}
