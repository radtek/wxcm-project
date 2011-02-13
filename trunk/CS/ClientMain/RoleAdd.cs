using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;
using System.Runtime.Serialization.Formatters.Binary;
namespace ClientMain
{

    public partial class RoleAdd : Form
    {

        public RoleAdd()
        {
            InitializeComponent();
            this.treeView1.AfterCheck += new TreeViewEventHandler(treeView1_AfterCheck); 
        }


       //定义窗体公用的数据库连接参数
        private OracleConnection MyConn = null;
        private OracleCommand MyComm;
        //private OracleDataAdapter myAdapter;
        //private OracleDataReader myReader;
        //private OracleCommandBuilder myCommandBuilder;
        private DataSet ds = null;
        //private DataTable dt;
        //private DataRow dr; 
        //定义数据库连接
    
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
        private void OpSql(string sqlstr) 
        { 
            this.Open();
            MyComm = new OracleCommand(sqlstr, MyConn); 
            MyComm.ExecuteNonQuery();
            MyComm.Dispose(); 
            this.sClose(); 
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
        private void roleaddtoolStripBtn3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // //以下3个函数实现动态加载无限联级的树控件
        //级联子节点
        private void GetChildren(TreeNode p_node, DataTable p_dataTable, string p_IDField, string p_NameField, string p_ParentIDField, string ParentValue)
        {
            DataView dv = new DataView(p_dataTable);
            //找出它的子级 
            dv.RowFilter = "PARENTMODEL=   ' " + ParentValue + " ' ";
            foreach (DataRowView dr in dv)
            {
                TreeNode node = new TreeNode();

                node.Tag = dr.Row[p_IDField].ToString();       //值 
                node.Text = dr.Row[p_NameField].ToString();   //显示在节点上的文本 
                p_node.Nodes.Add(node);
                string nextvalue2 = dr.Row[p_IDField].ToString();
                //递归找出他的子级 
                GetChildren(node, p_dataTable, p_IDField, p_NameField, p_ParentIDField, nextvalue2);

            }

        }
        //初始化树控件
        private void InitializeTreeView()
        {
            this.Open();
            string firstnode = "select * from SYS_MODEL ";
            OracleDataAdapter adp = new OracleDataAdapter();
            OracleCommand oraquer = new OracleCommand(firstnode, MyConn);
            adp.SelectCommand = oraquer;

            DataSet ds1 = new DataSet("SYS_MODEL");
            adp.Fill(ds1, "SYS_MODEL");
            DataTable dt1 = ds1.Tables["SYS_MODEL"];

            CreateTreeView(treeView1, dt1, "ID", "MODELNAME", "PARENTMODEL", "0");
        }
        //设定根节点
        private void CreateTreeView(TreeView p_treeView, DataTable p_dataTable, string p_IDField, string p_NameField, string p_ParentIDField, string RootValue)
        {
            // this.Open();
            // DataSet ds1 = new DataSet("SYS_MODEL");
            // OracleDataAdapter adapter1=new OracleDataAdapter();
            // DataTable dt1 = new DataTable("SYS_MODEL");
            // adapter1.Fill(ds1);
            DataView dv1 = new DataView(p_dataTable);
            dv1.RowFilter = "PARENTMODEL=' " + RootValue + " ' ";


            foreach (DataRowView dr in dv1)
            {
                TreeNode node = new TreeNode();
                node.Tag = dr.Row[p_IDField].ToString();//节点的ID值 
                node.Text = dr.Row[p_NameField].ToString();//节点显示的选项值
                p_treeView.Nodes.Add(node);
                //为当前节点添加它的子节点 
                int i = Convert.ToInt32(RootValue);
                i = i + 1;
                string alter = Convert.ToString(i);
                string nextvalue1 = dr.Row[p_IDField].ToString();
                GetChildren(node, p_dataTable, p_IDField, p_NameField, p_ParentIDField, nextvalue1);

            };
            //  treeView1.Nodes.Clear();
            //  treeView1.BeginUpdate();
            //  string str1="select * from where ROLE_ID='"+a+"'";
            //  string str2 = "select * from SYS_MODEL";



        }
        // //以上三个函数实现动态加载无限联级的树控件
       

        private void RoleAdd_Load(object sender, EventArgs e)
        {
            InitializeTreeView();

        }
        //依据部门名称反取部门ID
        private string seid (string e)
        {
            this.Open();
            string strid = "Select ID from SYS_MODEL where MODELNAME='" + e + "'";
            OracleCommand sid = new OracleCommand(strid,MyConn);
            OracleDataReader sidreader;
            sidreader = sid.ExecuteReader();
            string svalue ;
            sidreader.Read();
              
           svalue = sidreader.GetValue(0).ToString();
          sidreader.Close();       
           return svalue;
        }
      
        private void roleaddtoolStripBtn1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                MessageBox.Show("请您输入角色名称", "警告", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
            else
            {
                string rolename = this.textBox1.Text.ToString();
                string description = this.textBox2.Text.ToString();
                int sum1 = treeView1.GetNodeCount(true);
                int a1=0;
                int a2=0 ;
                int a3 =0;
                int a4 = 0;
                int a5 = 0;
                if (treeView1.Nodes[0].Nodes[0].Nodes[0].Checked == true)
                { a1 = 2; }
                else if (treeView1.Nodes[0].Nodes[0].Nodes[1].Checked == true)
                { a2 = 3; }
                else if (treeView1.Nodes[0].Nodes[1].Nodes[0].Checked == true)
                { a3 = 81; }
                else if(treeView1.Nodes[0].Nodes[1].Nodes[1].Checked == true)
                { a4 = 22; }
                else if (treeView1.Nodes[0].Nodes[1].Nodes[2].Checked == true)
                { a4 = 24; }
                else
                { };
                this.Open();
                string strSQL = "select * from sys_role";

              //  OracleDataAdapter ada = new OracleDataAdapter(strSQL, MyConn);
              //  OracleCommandBuilder cd = new OracleCommandBuilder(ada);
              //  DataTable dt=new DataTable();
                           
              //  DataSet dset = new DataSet("sys_role");
              //  ada.Fill(dset);
              //  dt = dset.Tables["sys_role"];
                string adro = "insert into sys_role (role_id,role_name,super_id,description) values (seq_sys_role_role_id.nextval,'" + rolename + "','0','" + description + "')";
                OracleCommand inset = new OracleCommand(adro,MyConn);
              //  ada.InsertCommand = inset;
               // ada.InsertCommand.ExecuteNonQuery();
               // ada.Update(dset, "sys_role");
                inset.ExecuteNonQuery();
                inset.UpdatedRowSource.ToString();
                OracleDataAdapter ada = new OracleDataAdapter(strSQL, MyConn);
                 OracleCommandBuilder cd = new OracleCommandBuilder(ada);
                 DataTable dt=new DataTable();

                DataSet dset = new DataSet("sys_role");
                ada.Fill(dset);
                dt = dset.Tables["sys_role"];
               // this.Close();

                
                if(a1!=0)
                {
                    string sqlstr = "insert into SYS_ROLE_MODULE (ID,role_id,module_id) values (seq_SYS_ROLE_MODULE_id.nextval,seq_sys_role_role_id.currval,'" + a1.ToString() + "')";
                    this.OpSql(sqlstr);
                }
                else if(a2!=0)
                {
                    string sqlstr = "insert into SYS_ROLE_MODULE (ID,role_id,module_id) values (seq_SYS_ROLE_MODULE_id.nextval,seq_sys_role_role_id.currval,'" + a2.ToString() + "')";
                    this.OpSql(sqlstr);
                }
                else if(a3!=0)
                {
                    string sqlstr = "insert into SYS_ROLE_MODULE (ID,role_id,module_id) values (seq_SYS_ROLE_MODULE_id.nextval,seq_sys_role_role_id.currval,'" + a3.ToString() + "')";
                    this.OpSql(sqlstr);
                }
                else if (a4 != 0)
                {
                    string sqlstr = "insert into SYS_ROLE_MODULE (ID,role_id,module_id) values (seq_SYS_ROLE_MODULE_id.nextval,seq_sys_role_role_id.currval,'" + a4.ToString() + "')";
                    this.OpSql(sqlstr);
                }
                else if (a5 != 0)
                {
                    string sqlstr = "insert into SYS_ROLE_MODULE (ID,role_id,module_id) values (seq_SYS_ROLE_MODULE_id.nextval,seq_sys_role_role_id.currval,'" + a5.ToString() + "')";
                    this.OpSql(sqlstr);
                }
                else if ((a1 + a2 + a3 + a4 + a5) == 0)
                { MessageBox.Show("请选择部门与权限", "警告", MessageBoxButtons.OK, MessageBoxIcon.Stop); }
                else
                { };
                MessageBox.Show("保存结果", "已经保存完毕", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Close();
            }
            

        }

       
    }
}

        


    


