using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace ClientMain
{
    public partial class UserWatch : Form
    {
        public UserWatch()
        {
            InitializeComponent();
        }
        private OracleConnection MyConn = null;
     //   private OracleCommand MyComm;
   
        // private OracleCommandBuilder myCommandBuilder;
   //     private DataSet ds;
  
    //    private DataRow dr;
        private string current_emploee;//当前雇员的姓名
        private void Open()
        {
            MyConn = new OracleConnection("Data Source=XINHUA;User Id=xxb;Password=pass;Integrated Security=no;");
            if (MyConn.State.ToString() != "Open")
                MyConn.Open();
        }
        private void sClose()
        {
          //  if (ds != null)
          //  { ds.Dispose(); }
            if (MyConn != null & MyConn.State.ToString() != "Closed")
            { MyConn.Close(); }
        }
        private void GetEmploeeName() 
        {
          
            try 
            {
                this.Open();
                string str1 = "select * from SYS_EMPLOYEES";
                OracleDataAdapter adp1 = new OracleDataAdapter();
                OracleCommand comm1 = new OracleCommand(str1, MyConn);
                adp1.SelectCommand = comm1;
                DataSet ds1 = new DataSet();
                adp1.Fill(ds1, "SYS_EMPLOYEES");
                string str2 = "select name from SYS_EMPLOYEES where EMPLOYEEID='" + UserManger.user_watch_emplyid.ToString() + "'";
                 OracleCommand comm2=new OracleCommand(str2,MyConn);
                OracleDataReader myreader=comm2.ExecuteReader();
                while(myreader.Read())
                {

                    current_emploee= myreader.GetValue(0).ToString();
                }
               
                


            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message); }
            
        }
        private void CreatRoleNode(TreeNode p_node,string a)
        {
            try
            {
                this.Open();
                string str1 = "select * from SYS_USER_ROLE";
                OracleDataAdapter adp1 = new OracleDataAdapter();
                OracleCommand comm1 = new OracleCommand(str1, MyConn);
                adp1.SelectCommand = comm1;
                DataSet ds1 = new DataSet();
                adp1.Fill(ds1, "SYS_USER_ROLE");
                string str2 = "select ROLEID from SYS_USER_ROLE where  USERNAME='" + UserManger.user_watch_name + "' and DEPTID='"+a+"'";
                OracleCommand comm2 = new OracleCommand(str2, MyConn);
                OracleDataReader myreader = comm2.ExecuteReader();
                while(myreader.Read())
                {
                    string role_id=myreader.GetValue(0).ToString();
                    string str3 = "select ROLE_NAME from SYS_ROLE where ROLE_ID='"+role_id+"'";
                    OracleCommand comm3 = new OracleCommand(str3,MyConn);
                    OracleDataReader myreader2 = comm3.ExecuteReader();
                    while(myreader2.Read())
                    {
                        TreeNode node = new TreeNode();
                        node.Text = myreader2.GetValue(0).ToString();
                        p_node.Nodes.Add(node);
                    }
                }
            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        private void CreatLoodTree(TreeView p_treeView)
        {
            try
            {
                this.Open();
                string str1 = "select * from SYS_USER_DEPARTMENT";
                OracleDataAdapter adp1 = new OracleDataAdapter();
                OracleCommand comm1 = new OracleCommand(str1, MyConn);
                adp1.SelectCommand = comm1;
                DataSet ds1 = new DataSet();
                adp1.Fill(ds1, "SYS_USER_DEPARTMENT");

                string str2 = "select DEPARTMENTID from SYS_USER_DEPARTMENT where  USERNAME='" + UserManger.user_watch_name + "'";
                OracleCommand comm2 = new OracleCommand(str2,MyConn);
                OracleDataReader myreader = comm2.ExecuteReader();
                while(myreader.Read())
                {
                    TreeNode node = new TreeNode();
                    node.Tag = myreader.GetValue(0).ToString();//节点的ID值 
                    string strdepname = "select DEPARTMENTNAME from SYS_DEPARTMENT where DEPARTMENTID='" + node.Tag.ToString() + "'";
                    OracleCommand comm_dapername = new OracleCommand(strdepname, MyConn);
                    OracleDataReader reader1 = comm_dapername.ExecuteReader();
                    while (reader1.Read())
                    {
                        node.Text = reader1.GetValue(0).ToString();//节点显示的选项值
                    }
                    CreatRoleNode(node,node.Tag.ToString());
                    p_treeView.Nodes.Add(node);
                }

                this.sClose();
               


            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message); }
            
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.sClose();
            this.Close();
        }

        private void UserWatch_Load(object sender, EventArgs e)
        {
            this.textBox1.Text = UserManger.user_watch_name.ToString();
            GetEmploeeName();
            this.textBox2.Text = current_emploee;
            CreatLoodTree(treeView1);
        }
    }
}
