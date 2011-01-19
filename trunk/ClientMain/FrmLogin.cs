using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClientMain
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();

            if (this.loginuser.Text == "")
                this.loginpassword.Enabled = false;
            else
                this.loginpassword.Enabled = true; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmClientMain frmClient = new FrmClientMain();
            frmClient.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loginuser.Text = "";
            loginpassword.Text = "";
            this.loginpassword.Enabled = false;
        }

        private void login_Load(object sender, EventArgs e)
        {
            System.Data.OleDb.OleDbConnection loginconnect1;
            loginconnect1 = new System.Data.OleDb.OleDbConnection();
            //loginconnect1.ConnectionString="

        }

        private void loginuser_TextChanged(object sender, EventArgs e)
        {
            this.loginpassword.Enabled = true;
        }


    }
}
