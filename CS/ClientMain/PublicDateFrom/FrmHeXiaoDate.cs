using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
 
using System.Text;
using System.Windows.Forms;
using System.Diagnostics; 

namespace ClientMain
{
    public partial class FrmHeXiaoDate : Form
    {
        public FrmHeXiaoDate()
        {
            InitializeComponent();
        }
        private static string Selecttime="";
        public static string getSelectTime
        {
            get
            {
                return Selecttime;
            }
            set
            {
                Selecttime = value;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Selecttime = "";
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
    
            Selecttime = this.dateTimePicker1.Value.ToShortDateString();
            this.DialogResult = DialogResult.OK;
            this.Close();


        }

        private void FrmHeXiaoDate_Load(object sender, EventArgs e)
        {
            
        }


     

       
    }
}
