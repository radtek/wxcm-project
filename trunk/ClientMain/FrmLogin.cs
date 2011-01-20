﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.Odbc;
//using System.Data;
using System.Data.OracleClient;



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
            this.loginpassword.GotFocus+=new EventHandler(loginpassword_GotFocus);
            
        }
        //传递的三个权限值
        public string username;
        public string userdepartment;
        public string useraccount;

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
            

            
            this.loginpassword.Enabled = false;
        }

        private void login_Load(object sender, EventArgs e)
        {
           
            

   


        }

        private void loginuser_TextChanged(object sender, EventArgs e)
        {
            this.loginpassword.Enabled = true;
        }



        private void loginpassword_GotFocus(object sender, EventArgs e)
        {
            //将用户输出
            username = this.loginuser.Text.ToString();

            //查询数据库，排除空用户
            System.Data.OleDb.OleDbConnection loginconnect1;
            loginconnect1 = new System.Data.OleDb.OleDbConnection();
            loginconnect1.ConnectionString = "Provider=OraOLEDB.Oracle.10g;" + "User ID=xxb;" + "Password=pass;" + "Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.8.222)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = XINHUA) ) )";
            string queryusername = "SELECT * FROM SYS_USER WHERE USERID=" + username;
            OleDbCommand logincommand1 = new OleDbCommand(queryusername, loginconnect1);
            loginconnect1.Open();
            OleDbDataReader loginread = logincommand1.ExecuteReader();






            try
            {
                if (loginread.Read() == false)
                {
                   //如果用户名为非法用户则提示用户并清空用户名
                    
                   // if (MessageBox.Show(this, "请您输入正确的用户名", "本系统不存在该用户", MessageBoxButtons.OK) == DialogResult.OK)
                   //MessageBox.Show(this,"请您输入正确的用户名", "本系统不存在该用户");
                    this.alarm.Text = "系统里没有您输入的用户请重新输入";
                        loginread.Close();
                        loginconnect1.Close();
                        this.loginuser.Text = "";
                        //this.loginpassword.Text = "";
                       
                        this.loginpassword.Enabled = false;
                    

                }
                else
                {
                    this.alarm.Text = "";




                }

                ;


            }
            finally
            {
                loginread.Close();
                loginconnect1.Close();
            }

        }
       // private void loginpassword_TextChanged(object sender, EventArgs e)
       // {
       //    
       // }

        private void loginuser_TextChanged_1(object sender, EventArgs e)
        {
            this.loginpassword.Enabled = true;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }


    }
}
