using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClientMain
{
    public partial class FrmTuoShouData : Form
    {
        public FrmTuoShouData()
        {
            InitializeComponent();
        }

        private void FrmTuoShouData_Load(object sender, EventArgs e)
        {//

        }
        private static double Input;
        public static double GetXe
        {
            get
            {
                return Input;
            }
            set
            {
                Input = value;
            }
        }
        private bool IsNum(String str)
        {
            double a = 0;
            if (Double.TryParse(txtInputNumber.Text.ToString(), out a))
            {
                return true;
            }
                else
            {
                return false;
            }
        }

        private void btnZhiKong_Click(object sender, EventArgs e)
        {
            this.txtInputNumber.Text = "";
          //  string str = this.txtInputNumber.Text.ToString();
           
       
        }

        private void btnTuiChu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQueRen_Click(object sender, EventArgs e)
        {
            bool fgcheck = false;
            
            if(this.txtInputNumber.ToString().Trim()=="")
            {
                fgcheck = false;
                MessageBox.Show("您还没有输入数据");
            }
            else if (IsNum(this.txtInputNumber.ToString().Trim())==false)
            {
                fgcheck = false;
                MessageBox.Show("您输入的不是纯数字");
            }

            else
            {
                double num = Convert.ToDouble(this.txtInputNumber.Text.ToString());
                if (num < Convert.ToDouble("0"))
                {
                    fgcheck = false;
                    MessageBox.Show("限额不能为负数");

                }
                else
                {
                    fgcheck = true;
 
                }

            }
            if (fgcheck == true)
            {
                double num = Convert.ToDouble(this.txtInputNumber.Text.ToString());
                Input = num;
                this.DialogResult = DialogResult.OK;
                this.Close();
 
            }

        }


    }
}
