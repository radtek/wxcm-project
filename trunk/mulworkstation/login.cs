using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using System.Runtime.Remoting;
//using System.Runtime.Remoting.Channels;
//using System.Runtime.Remoting.Channels.Tcp;
//using System.Runtime.InteropServices;
//using Oracle.DataAccess.Client;
//using Oracle.DataAccess.Types;
using ClientMain;

namespace mulworkstation
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();

            if (this.loginuser.Text == "")
                this.loginpassword.Enabled = false;
            else
                this.loginpassword.Enabled = true; 
                    
        }

                


        private void button3_Click(object sender, EventArgs e)
        {
            loginuser.Text = "";
            loginpassword.Text = "";
            this.loginpassword.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_Load(object sender, EventArgs e)
        {
            System.Data.OleDb.OleDbConnection  loginconnect1;
            loginconnect1 = new System.Data.OleDb.OleDbConnection();
            //loginconnect1.ConnectionString="

        }

        private void loginuser_TextChanged(object sender, EventArgs e)
        {
            this.loginpassword.Enabled = true; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmClientMain frmClient = new FrmClientMain();
            frmClient.Show();
            this.Hide();
        }
    }
}
