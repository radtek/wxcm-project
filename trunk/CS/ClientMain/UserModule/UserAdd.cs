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
    public partial class UserAdd : Form
    {
        public UserAdd()
        {
            InitializeComponent();
            this.textBox1.Focus();
           // this.textBox3.Validating += new System.ComponentModel.CancelEventHandler(this.textBox3_Validating);
           
        }
       // Dictionary<string, string> m_Dict = new Dictionary<string, string>();
        private OracleConnection MyConn = null;
      //  private OracleCommand MyComm;
        private DataSet ds;
        private string sums;//判断用户是否唯一时候使用
        string BackName = null;//EmpoeeTable.lastname.ToString();
      string BackCode =null; //EmpoeeTable.lastcode.ToString();
        private string[] str_group;//role_listview 's selectde id stringgoup
        private int j;
        private void Open()
        {
            MyConn = new OracleConnection("Data Source=XINHUA;User Id=xxb;Password=pass;Integrated Security=no;");
            if (MyConn.State.ToString() != "Open")
                MyConn.Open();
        }
        //定义数据库关闭
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
             { flag=0;}
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
        private void LoopUserRole(TreeView c_treeview)
        {
             
            TreeNodeCollection allnode;
            allnode = c_treeview.Nodes;
            foreach (TreeNode TNode in allnode)
            {
                try
                {
                    this.Open();
                    string str1 = "select * from SYS_USER_ROLE ";
                    OracleDataAdapter adp1 = new OracleDataAdapter();
                    OracleCommand comm3 = new OracleCommand(str1, MyConn);
                    adp1.SelectCommand = comm3;
                    DataSet ds1 = new DataSet();
                    adp1.Fill(ds1, "SYS_USER_ROLE");
                    string strdep = TNode.Tag.ToString();
                    int sum = listView3.Items.Count;
                    for (int i = 0; i < sum; i++)
                    {
                        if(TNode.Nodes[i].Checked==true)
                        {
                            string username = GetUserName();
                            string strro=TNode.Nodes[i].Tag.ToString();
                            string str2 = "insert into SYS_USER_ROLE t" + "  (t.id, t.username, t.deptid, t.roleid)" + "values" + "  (seq_sys_user_role_id.nextval, '" + username + "', '" + strdep + "', '" + strro + "')";
                            adp1.InsertCommand = new OracleCommand(str2, MyConn);
                            adp1.InsertCommand.ExecuteNonQuery();
                            adp1.Update(ds1, "SYS_USER_ROLE");
                        }
                    }
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
            }
 
        }
        private void InsetUserRole()
        {
            LoopUserRole(treeView1);

        }
        private void InsetUser()
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
            string employee = EmpoeeTable.lastcode.ToString();
            string clinet1 = this.textBox7.Text.Trim().ToString();
            string clinet2 = this.textBox8.Text.Trim().ToString();
            string clinet3 = this.textBox9.Text.Trim().ToString();
            string str2 = "insert into sys_user (userid,username,islock,password,description,empid,LSKHDNO,JCDJCNO,YTHPTNO) values(seq_sys_user_userid.nextval,'" + username + "','" + lock1 + "','" + sure_pass + "','" + description + "','" + employee + "','"+clinet1+"','"+clinet2+"','"+clinet3+"')";
            adp1.InsertCommand = new OracleCommand(str2, MyConn);
            adp1.InsertCommand.ExecuteNonQuery();
            adp1.Update(ds1, "sys_user");
            this.sClose();
        }
        private void LoopUserDepar(TreeView c_treeview)
        {
            
            TreeNodeCollection allnode;
            allnode = c_treeview.Nodes;
            foreach (TreeNode TNode in allnode)
            {
                if (TNode.Checked==true)
                {
                    string str1 = "select * from SYS_USER_DEPARTMENT ";
                    OracleDataAdapter adp1 = new OracleDataAdapter();
                    OracleCommand comm3 = new OracleCommand(str1, MyConn);
                    adp1.SelectCommand = comm3;
                    DataSet ds1 = new DataSet();
                    adp1.Fill(ds1, "SYS_USER_DEPARTMENT");
                    string strdep = TNode.Tag.ToString();
                    string username = GetUserName();
                    string str2 = "insert into SYS_USER_DEPARTMENT t" + "  (t.id, t.username, t.departmentid)" + "values" + "  (seq_sys_user_department_id.nextval, '" + username + "', '" + strdep + "')";
                    adp1.InsertCommand = new OracleCommand(str2, MyConn);
                    adp1.InsertCommand.ExecuteNonQuery();
                    adp1.Update(ds1, "SYS_USER_DEPARTMENT");
                }
            }
               
        }
        private void InsetUserDepar()
        {
            try
            {
                this.Open();
              
                LoopUserDepar(treeView1);
               
                
                this.sClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
 
        }
        private void ConnectComboxList()
        {
 
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            string str_name = GetUserName();
            this.Open();
            string str1 = "select * from SYS_USER";
            string check_user = "SELECT * FROM SYS_USER where USERNAME='"+GetUserName()+"'";
            OracleDataAdapter adp_user = new OracleDataAdapter();
            OracleCommand comm = new OracleCommand(str1, MyConn);
            adp_user.SelectCommand = comm;
            DataSet ds1 = new DataSet();
            adp_user.Fill(ds1, "SYS_USER");
            OracleCommand check = new OracleCommand(check_user,MyConn);
            OracleDataReader myreader = check.ExecuteReader();
            try
            {
                while (myreader.Read())
                {
                    sums = myreader.GetValue(0).ToString();
                }
            }
            finally { myreader.Close(); }

        
               
            if (str_name == "")
            {
                MessageBox.Show("请先填写登陆名称","警告");
            }
            else if (sums != null)
            {
                MessageBox.Show("已经存在该用户名，请重新输入", "警告");
            }
            else
            {
                EmpoeeTable EmpoeeTable = new EmpoeeTable();
                EmpoeeTable.ShowDialog();
                this.Show();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ClearAllContent()
        {
            this.textBox3.Text ="";
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.textBox4.Text = "";
            this.textBox5.Text = "";
            this.textBox6.Text = "";
            this.checkBox1.Checked = false;
            this.comboBox1.Text = "";

        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ClearAllContent();
        }
  
        private void empleeshow()
        {
            if ( EmpoeeTable.i == true)
            {
                this.textBox3.Text = EmpoeeTable.lastname;
            }
            else
            {
                this.textBox3.Text = null;
            }
        }
        private void SelectDepar()
    {
        string error = null;
        if (EmpoeeTable.lastname == null)
        { this.textBox3.Text = null; }
        else
        { this.textBox3.Text = EmpoeeTable.lastname.ToString(); }
        if (string.IsNullOrEmpty(textBox3.Text.Trim()))
        {
            error = "请您选择员工！！";
            //this.textBox3.Focus();
            this.comboBox1.Items.Clear();
          //  this.comboBox2.Items.Clear();
        }
        else
        {

            try
            {

                string str_selectdepar = "select s.departmentid, s.departmentname from sys_department s where s.departmentid in (select t.departmentid   from SYS_EMPEE_DEPARTMENT t where t.employeeid = '" + EmpoeeTable.lastcode.ToString() + "')";

                this.Open();
                string str1 = "select * from SYS_EMPEE_DEPARTMENT ";
                OracleDataAdapter adp1 = new OracleDataAdapter();
                OracleCommand comm3 = new OracleCommand(str1, MyConn);
                adp1.SelectCommand = comm3;
                DataSet ds1 = new DataSet();
                adp1.Fill(ds1, "SYS_EMPEE_DEPARTMENT");
                OracleCommand comm1 = new OracleCommand(str_selectdepar, MyConn);
                OracleDataReader reder1 = comm1.ExecuteReader();
                while (reder1.Read())
                {
                    if (!this.comboBox1.Items.Contains(reder1.GetString(1)))
                    {
                        this.comboBox1.Items.Add(reder1.GetString(1));
                      // m_Dict.Add(reder1.GetString(1), reder1.GetString(0));
                        this.comboBox1.Tag = reder1.GetString(0).ToString();
                    }
                    if (this.comboBox1.Items.Count != 0)
                    {
                        this.comboBox1.SelectedIndex = 0;
                    }
                }
                reder1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
                
    }

        
        private void UserAdd_Load(object sender, EventArgs e)
        {
            LoadRoleList();
            LoadGroupList();
            LoadDerpartList();
            CreateModuleRole(treeView1);
        }
        private void LoadRoleList()
        {
            listView3.Items.Clear();
            string strCom = "select * from SYS_ROLE";
            this.Open();
            OracleCommand comm1 = new OracleCommand(strCom,MyConn);
            OracleDataReader reader1 = comm1.ExecuteReader();
         
            while(reader1.Read())
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
                //listView1.Items[0].Text = reader2["GROUPNAME"].ToString();

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
        private void listView3_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
           
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            empleeshow();
           // SelectDepar();
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
                else
                {
                    if (this.textBox3.Text.ToString() == "")
                    { MessageBox.Show("您还没有选择用户所属员工", "警告"); }
                    else
                    {
                       
                            InsetUser();
                            InsetUserDepar();
                            InsetUserRole();
                            
                            this.Close();
                       
                    }

                }
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
               //下面是关于LIST控件与数组的四重循环，谁也不准改我的。。。。。。谁改谁遭雷劈，花了我整一天的时间
                int a = listView3.Items.Count;
                j = 0;
                for (int i = 0; i < a;i++ )
                {
                        if(listView3.Items[i].Checked==true)
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
                { MessageBox.Show("请选择角色","警告"); }
                string lastrole=null;
               foreach(string str1 in str_group)
               { lastrole = lastrole + str1; }
               this.textBox6.Text = lastrole;
        }
        private void setcheck(TreeNode node)
        {
            int i;
            TreeNodeCollection ChildNode;
            ChildNode = node.Nodes;
            //首先处理其上级节点的状态
            if (!node.Checked)//如果没有选中，那么其所有的父节点状态都是未选中
            {
                TreeNode ParentNode = node.Parent;
                while (ParentNode != null && ParentNode.Checked)
                {
                    ParentNode.Checked = false;
                    ParentNode = ParentNode.Parent;
                }
            }
            else     //如果选中，那么检查同级节点，如果都选中，那么自动选中父节点，并且再检查父节点的同级节点
            {
                TreeNode ParentNode = node;
                while ((ParentNode = ParentNode.Parent) != null)
                {
                    int j = 0;
                    TreeNodeCollection BrotherNodes;
                    BrotherNodes = ParentNode.Nodes;
                    for (i = 0; i < BrotherNodes.Count; i++)
                    {
                        if (BrotherNodes[i].Checked == true)
                        {
                            j = j + 1;
                        }
                        else
                        {
                            i = i + 1;
                            break;
                        }
                    }
                    if (i == j)
                    {
                        ParentNode.Checked = true;
                    }
                    else break;
                }
            }
            //现在处理子节点，将所有子节点都选中，或者取消选中
            for (i = 0; i < ChildNode.Count; i++)
            {
                TreeNode cNode;
                cNode = ChildNode[i];
                cNode.Checked = node.Checked;
                if (cNode.Nodes.Count != 0)
                    setcheck(cNode);
            }
        }

        //树控件的check事件并调用父子联动
        bool tag = false;
        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (tag == false)
            {
                tag = true;
                setcheck(e.Node);
                tag = false;

            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

    }
}
