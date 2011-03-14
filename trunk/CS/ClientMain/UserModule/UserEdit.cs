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
    public partial class UserEdit : Form
    {
        public UserEdit(string sourname)
        {
            InitializeComponent();
            this.button1.Visible = false;
            this.sourname = sourname;
        }
        private OracleConnection MyConn = null;
        private OracleCommand MyComm;
        private DataSet ds;
        private string sums;//查询用户是否可用时用到
        private string current_userepid;//当前用于对应得员工ID
        private string[] str_group;//role_listview 's selectde id stringgoup
        private int j;//循环LIST
        private string sourname;
        private string username;//所需修改的用户名称
        private void Open()
        {
            MyConn = new OracleConnection("Data Source=XINHUA;User Id=xxb;Password=pass;Integrated Security=no;");
            if (MyConn.State.ToString() != "Open")
                MyConn.Open();
        }
        private void sClose()
        {
            if (ds != null)
            { ds.Dispose(); }
            if (MyConn != null & MyConn.State.ToString() != "Closed")
            { MyConn.Close(); }
        }
        private bool ComparePass()
        {
            bool i;
            if (this.textBox4.Text.Trim().ToString() == null)
            {
                MessageBox.Show("警告", "您没有输入密码");
                i = false;
                return i;
            }
            else
            {
                if (this.textBox4.Text.Trim().ToString() == this.textBox2.Text.Trim().ToString())
                { i = true; }
                else
                { i = false; }
                return i;
            }


        }
        private string GetUserName()
        {

            return this.textBox1.Text.Trim().ToString();
        }
        private string GetUserDirs()
        {
            return this.textBox5.Text.Trim().ToString();
        }
        private string GetLack()
        {
            int flag;
            if (this.checkBox1.Checked == true)
            { flag = 0; }
            else
            { flag = 1; }

            return flag.ToString();
        }
        private string GetDepartment()
        {
            return this.comboBox1.Text.Trim().ToString();
        }
        private string GetEmpName()
        {
            if (this.textBox3.Text.Trim().ToString() == null)
            {
                MessageBox.Show("警告", "您还没有选择员工");

            }
            else
            {

            }
            return EmpoeeTable.lastname.ToString();
        }
        private string GetUserPass()
        {
            bool i;
            i = ComparePass();
            if (i == false)
            {
                MessageBox.Show("你两次输入的密码不一致，请重新输入", "警告");
            }

            return this.textBox2.Text.Trim().ToString();
        }
        private string GetUserDescription()
        {
            return this.textBox5.Text.Trim().ToString();
        }
        private void LoadRoleList()
        {
            listView3.Items.Clear();
            string strCom = "select * from SYS_ROLE";
            this.Open();
            OracleCommand comm1 = new OracleCommand(strCom, MyConn);
            OracleDataReader reader1 = comm1.ExecuteReader();

            while (reader1.Read())
            {
                ListViewItem Item = new ListViewItem();
                Item.SubItems.Clear();
                Item.SubItems[0].Text = reader1["ROLE_NAME"].ToString();//读取数据库中字段   
                Item.SubItems[0].Tag = reader1["ROLE_ID"].ToString();
                listView3.Items.Add(Item);//显示   

            }
            reader1.Close();

        }
        private void LoadGroupList()
        {
            listView1.Items.Clear();
            string strCom = "select * from SYS_GROUP";
            this.Open();
            OracleCommand comm2 = new OracleCommand(strCom, MyConn);
            OracleDataReader reader2 = comm2.ExecuteReader();

            while (reader2.Read())
            {
                ListViewItem Item = new ListViewItem();
                Item.SubItems.Clear();
                Item.SubItems[0].Text = reader2["GROUPNAME"].ToString();//读取数据库中字段   
                Item.SubItems[0].Tag = reader2["GROUPID"].ToString();
                listView1.Items.Add(Item);//显示   

            }
            reader2.Close();
        }
        private void LoadDerpartList()
        {
            listView2.Items.Clear();
            string strCom = "select * from SYS_DEPARTMENT";
            this.Open();
            OracleCommand comm2 = new OracleCommand(strCom, MyConn);
            OracleDataReader reader2 = comm2.ExecuteReader();

            while (reader2.Read())
            {
                ListViewItem Item = new ListViewItem();
                Item.SubItems.Clear();
                Item.SubItems[0].Text = reader2["DEPARTMENTNAME"].ToString();//读取数据库中字段   
                Item.SubItems[0].Tag = reader2["DEPARTMENTID"].ToString();
                listView2.Items.Add(Item);//显示   

            }
            reader2.Close();
        }
        private void checkacchildnode(string str1,string str2, TreeNode node, int i)
        {
            try
            {
                this.Open();
                string str = "select * from SYS_USER_ROLE ";
                OracleDataAdapter adp1 = new OracleDataAdapter();
                OracleCommand comm1 = new OracleCommand(str, MyConn);
                adp1.SelectCommand = comm1;
                DataSet ds_show = new DataSet();
                adp1.Fill(ds_show, "SYS_USER_ROLE");
                string str3 = "select ROLEID from SYS_USER_ROLE where USERNAME='" + str1 + "'and DEPTID='" + str2 + "'";
                OracleDataAdapter adp2 = new OracleDataAdapter();
                OracleCommand comm2 = new OracleCommand(str3, MyConn);
                OracleDataReader reader2 = comm2.ExecuteReader();
                int j = treeView1.Nodes[i].GetNodeCount(true);
                while (reader2.Read())
                {
                    for (int ii = 0; ii < j; ii++)
                    {
                        if (reader2.GetValue(0).ToString() == treeView1.Nodes[i].Nodes[ii].Tag.ToString())
                        {
                            treeView1.Nodes[i].Nodes[ii].Checked = true;
                        }


                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }




        }
        private void ShowUserTree(TreeView u_treeview,string str)
        {   
            
            string username = str;
            int deparsum = listView2.Items.Count;
            for (int i = 0; i < deparsum; i++)
            {
                TreeNode node = new TreeNode();
                string ac_mod = treeView1.Nodes[i].Tag.ToString();//部门ID
                try
                {
                    this.Open();
                    string str2 = "select * from SYS_USER_DEPARTMENT ";
                    OracleDataAdapter adp2 = new OracleDataAdapter();
                    OracleCommand comm2 = new OracleCommand(str2, MyConn);
                    adp2.SelectCommand = comm2;
                    DataSet ds = new DataSet();
                    adp2.Fill(ds, "SYS_USER_DEPARTMENT");
                    DataTable dt_user_depar = ds.Tables["SYS_USER_DEPARTMENT"];
                    DataRow[] rows;
                    rows = dt_user_depar.Select("USERNAME='" + username + "'");
                    foreach(DataRow row in rows)
                    {
                        if (row["DEPARTMENTID"].ToString()==ac_mod )
                        {
                            treeView1.Nodes[i].Checked = true;
                            checkacchildnode(username, ac_mod, node, i);
                        }
                        
                    }

                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
                
            }
               
        }
        private void LoadAllInformation()
        { 
             this.Open();

             string str1 = "select * from SYS_USER ";
            
             string str3 = "select * from SYS_EMPLOYEES ";
             
            
             OracleDataAdapter adp1 = new OracleDataAdapter();
             OracleDataAdapter adp3 = new OracleDataAdapter();
            
             OracleCommand comm1 = new OracleCommand(str1, MyConn);
             adp1.SelectCommand = comm1;
             OracleCommand comm3 = new OracleCommand(str3,MyConn);
             adp3.SelectCommand = comm3;
             DataSet ds_edit = new DataSet();
             adp1.Fill(ds_edit, "SYS_USER");
            
             adp3.Fill(ds_edit, "SYS_EMPLOYEES");
            //提取涉及到用户的信息
             DataTable user_table = ds_edit.Tables["SYS_USER"];
             DataView dv_user = new DataView(user_table);
             string a = UserManger.userwatch.ToString();
             dv_user.RowFilter = "USERID='" + a + "'";
             foreach (DataRowView dr in dv_user)
             {
                 this.textBox1.Text = dr.Row["USERNAME"].ToString();
                 username = dr.Row["USERNAME"].ToString();
                 this.textBox2.Text = dr.Row["PASSWORD"].ToString();
                 this.textBox4.Text = dr.Row["PASSWORD"].ToString();
                 this.textBox5.Text = dr.Row["DESCRIPTION"].ToString();
                 this.textBox7.Text = dr.Row["LSKHDNO"].ToString();
                 this.textBox8.Text = dr.Row["JCDJCNO"].ToString();
                 this.textBox9.Text = dr.Row["YTHPTNO"].ToString();
                 current_userepid = dr.Row["EMPID"].ToString();
                 string is_loack = dr.Row["ISLOCK"].ToString();
                 if(is_loack=="0")
                 {
                     this.checkBox1.Checked = true;
                 }
                 else
                 {
                     this.checkBox1.Checked = false;
                 }

             }
            //提取涉及到员工姓名的信息
             DataTable emploee_table = ds_edit.Tables["SYS_EMPLOYEES"];
             DataView dv_emploee = new DataView(emploee_table);
             dv_emploee.RowFilter = "EMPLOYEEID='" + current_userepid + "'";
             foreach (DataRowView dr in dv_emploee)
             {
                 this.textBox3.Text = dr.Row["NAME"].ToString();
                 this.textBox3.Tag = current_userepid.ToString();
             }
            //提取涉及到员工部门以及角色的信息，循环显示在树空间上
             ShowUserTree(treeView1,textBox1.Text.Trim().ToString());

             //this.Open();
            // string str_selectdepar = "select s.departmentid, s.departmentname from sys_department s where s.departmentid in (select t.departmentid   from SYS_EMPEE_DEPARTMENT t where t.employeeid = '" + current_userepid + "')";
            // OracleCommand comm4 = new OracleCommand(str_selectdepar, MyConn);
            // OracleDataReader reder4 = comm4.ExecuteReader();
            // while (reder4.Read())
            // {
             //    if (!this.comboBox1.Items.Contains(reder4.GetString(1)))
              //   {
                  //   this.comboBox1.Items.Add(reder4.GetString(1));
                     // m_Dict.Add(reder1.GetString(1), reder1.GetString(0));
                  //   this.comboBox1.Tag = reder4.GetString(0).ToString();
               //  }
               //  if (this.comboBox1.Items.Count != 0)
               //  {
              //       this.comboBox1.SelectedIndex = 0;
               //  }
            // }
             //reder4.Close();

        }
        private void UpdataUser()
        {
            this.Open();
            string str1 = "select * from sys_user ";
            OracleDataAdapter adp1 = new OracleDataAdapter();
            OracleCommand comm3 = new OracleCommand(str1, MyConn);
            adp1.SelectCommand = comm3;
            DataSet ds1 = new DataSet();
            adp1.Fill(ds1, "sys_user");
            string username = GetUserName();
            string department = GetDepartment();
            string lock1 = GetLack();
            string sure_pass = GetUserPass();
            string description = GetUserDescription();
           // string employee = current_userepid;
            string str2 = "update  sys_user set islock='"+lock1+"',password='"+sure_pass+"',description='"+description+"' where USERID='"+UserManger.userwatch.ToString()+"'";
                           
            adp1.UpdateCommand = new OracleCommand(str2, MyConn);
            adp1.UpdateCommand.ExecuteNonQuery();
            adp1.Update(ds1, "sys_user");
            this.sClose();
        }
        private void UpdataUserRole(int i, string strdep)
        {
            int sumrole = treeView1.Nodes[i].Nodes.Count;
            for (int j = 0; j < sumrole;j++ )
            {   
                if(treeView1.Nodes[i].Nodes[j].Checked==true)
                {
                try
                {
                    this.Open();
                    string str = "select * from SYS_USER_ROLE";
                    OracleDataAdapter adp_user_role = new OracleDataAdapter();
                    OracleCommand comm_user_role = new OracleCommand(str,MyConn);
                    adp_user_role.SelectCommand = comm_user_role;
                    DataSet ds1 = new DataSet();
                    adp_user_role.Fill(ds1, "SYS_USER_ROLE");
                    string strro = treeView1.Nodes[i].Nodes[j].Tag.ToString();
                    string str2 = "insert into SYS_USER_ROLE t" + "  (t.id, t.username, t.deptid, t.roleid)" + "values" + "  (seq_sys_user_role_id.nextval, '" + username + "', '" + strdep + "', '" + strro + "')";
                    OracleCommand comm_in_userrole = new OracleCommand(str2,MyConn);
                    adp_user_role.InsertCommand = comm_in_userrole;
                    adp_user_role.InsertCommand.ExecuteNonQuery();
                    adp_user_role.Update(ds1, "SYS_USER_ROLE");
                }
                catch(Exception ex)
                { MessageBox.Show(ex.Message); }
                }
            }


           
           
        }
        //清空用于与模块和角色原有的对照关系
        private void ClearUserDeaprRole()
        {
            try 
            {
                this.Open();
                string str1 = "select * from SYS_USER_DEPARTMENT";
                string str2 = "select * from SYS_USER_ROLE";
                OracleDataAdapter adp1 = new OracleDataAdapter();
                OracleDataAdapter adp2 = new OracleDataAdapter();
                OracleCommand comm1 = new OracleCommand(str1,MyConn);
                OracleCommand comm2 = new OracleCommand(str2,MyConn);
                adp1.SelectCommand = comm1;
                adp2.SelectCommand = comm2;
                DataSet ds1 = new DataSet();
                adp1.Fill(ds1, "SYS_USER_DEPARTMENT");
                adp2.Fill(ds1, "SYS_USER_ROLE");
                string delstr1 = "delete  from SYS_USER_DEPARTMENT where USERNAME='"+username+"'";
                string delstr2 = "delete  from SYS_USER_ROLE where USERNAME='" + username + "'";
                adp1.DeleteCommand = new OracleCommand(delstr1,MyConn);
                adp1.DeleteCommand.ExecuteNonQuery();
                adp1.Update(ds1, "SYS_USER_DEPARTMENT");
                adp2.DeleteCommand = new OracleCommand(delstr2,MyConn);
                adp2.DeleteCommand.ExecuteNonQuery();
                adp2.Update(ds1, "SYS_USER_ROLE");


            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message); }
 
        }
        private void UpdataUserDeapr()
        {
            ClearUserDeaprRole();
            int sum_depar = listView2.Items.Count;
            for (int i = 0; i < sum_depar;i++ )
            {
                if(treeView1.Nodes[i].Checked==true)
                {
                    try
                    {
                        this.Open();
                        string str = "select * from SYS_USER_DEPARTMENT";
                        OracleDataAdapter adp1 = new OracleDataAdapter();
                        OracleCommand comm1 = new OracleCommand(str,MyConn);
                        adp1.SelectCommand = comm1;
                        DataSet ds1 = new DataSet();
                        adp1.Fill(ds1, "SYS_USER_DEPARTMENT");
                        string strdep = treeView1.Nodes[i].Tag.ToString();
                        string str2 = "insert into SYS_USER_DEPARTMENT t" + "  (t.id, t.username, t.departmentid)" + "values" + "  (seq_sys_user_department_id.nextval, '" + username + "', '" + strdep + "')";
                        OracleCommand comm_indap = new OracleCommand(str2,MyConn);
                        adp1.InsertCommand = comm_indap;
                        adp1.InsertCommand.ExecuteNonQuery();
                        adp1.Update(ds1, "SYS_USER_DEPARTMENT");
                        UpdataUserRole(i, strdep);
 
                    }
                    catch (Exception ex)
                    { MessageBox.Show(ex.Message); }
                }
            }
        }
        private void CreateModuleRole(TreeView p_treeView)
        {
            int sum = listView2.Items.Count;

            for (int i = 0; i < sum; i++)
            {
                ListViewItem Item = new ListViewItem();
                TreeNode node = new TreeNode();
                node.Tag = listView2.Items[i].SubItems[0].Tag.ToString();
                node.Text = listView2.Items[i].SubItems[0].Text.ToString();
                //node.Checked = true;
                p_treeView.Nodes.Add(node);
                MakeChildRole(node);
            }

        }
        private void MakeChildRole(TreeNode p_node)
        {
            int sum = listView3.Items.Count;
            // this.Open();
            // string str = "select * from SYS_ACTION";
            // DataSet ds1 = new DataSet("SYS_ACTION");
            // OracleDataAdapter adapter1 = new OracleDataAdapter();
            //  OracleCommand comm = new OracleCommand(str, MyConn);
            //  adapter1.SelectCommand = comm;
            //  adapter1.Fill(ds1, "SYS_ACTION");
            //  DataTable dt_ac = ds1.Tables["SYS_ACTION"];
            //  DataView dv = new DataView(dt_ac);
            for (int i = 0; i < sum; i++)
            {
                ListViewItem Item = new ListViewItem();
                TreeNode node = new TreeNode();
                node.Tag = listView3.Items[i].SubItems[0].Tag.ToString();       //值 
                node.Text = listView3.Items[i].SubItems[0].Text.ToString(); ;   //显示在节点上的文本 
                p_node.Nodes.Add(node);
            }





        }
      
        private void UserEdit_Load(object sender, EventArgs e)
        {
            LoadRoleList();
            LoadGroupList();
            LoadDerpartList();
            CreateModuleRole(treeView1);
            LoadAllInformation();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            LoadAllInformation();
            
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ClearAllContent()
        {
            
          //  this.textBox3.Text = "";
          //  this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.textBox4.Text = "";
            this.textBox5.Text = "";
            this.textBox6.Text = "";
            this.textBox7.Text = "";
            this.textBox8.Text = "";
            this.textBox9.Text = "";
            this.checkBox1.Checked = false;
            int i = listView2.Items.Count;
            int j = listView3.Items.Count;
            for(int ii=0;ii<i;ii++)
            {
                treeView1.Nodes[ii].Checked = false;
                for(int jj=0;jj<j;jj++)
                {
                    treeView1.Nodes[ii].Nodes[jj].Checked=false;
                }
            }
           // this.comboBox1.Text = "";

        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ClearAllContent();
            
          
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要保存这个用户吗", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {   
                 bool i;
                i = ComparePass();
                if (i == false)
                {
                    MessageBox.Show("你两次输入的密码不一致，请重新输入", "警告");
                }
              //  else if()
            //    {}
                else
                {
                    UpdataUser();
                    UpdataUserDeapr();
                    //UpdataUserRole();
                   
                }
            }
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string str_name = GetUserName();
            this.Open();
            string str1 = "select * from SYS_USER";
            string check_user = "SELECT * FROM SYS_USER where USERNAME='" + GetUserName() + "'";
            OracleDataAdapter adp_user = new OracleDataAdapter();
            OracleCommand comm = new OracleCommand(str1, MyConn);
            adp_user.SelectCommand = comm;
            DataSet ds1 = new DataSet();
            adp_user.Fill(ds1, "SYS_USER");
            OracleCommand check = new OracleCommand(check_user, MyConn);
            OracleDataReader myreader = check.ExecuteReader();
            try
            {
                while (myreader.Read())
                {
                    sums = myreader.GetValue(0).ToString();
                }
            }
            finally { myreader.Close(); }
            if (sums != null)
            {
                MessageBox.Show("已经存在该用户名，请重新输入", "警告");
            }
            else
            { MessageBox.Show("该用户名可以使用", "提醒"); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = listView3.Items.Count;
            j = 0;
            for (int i = 0; i < a; i++)
            {
                if (listView3.Items[i].Checked == true)
                {
                    j++;
                }

            }
            str_group = new string[j];
            if (j != 0)
            {
                int count = 0;
                for (int i = 0; i < j; i++)
                {

                    do
                    {

                        if (listView3.Items[count].Checked == true)
                        {
                            str_group[i] = listView3.Items[count].SubItems[0].Tag.ToString();
                            count++;
                        }
                        else { count++; }

                    }
                    while (str_group[i] == null);
                }
            }
            else
            { MessageBox.Show("请选择角色", "警告"); }
            string lastrole = null;
            foreach (string str1 in str_group)
            { lastrole = lastrole + str1; }
            this.textBox6.Text = lastrole;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

    
    }
}
