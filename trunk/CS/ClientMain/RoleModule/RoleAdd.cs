﻿using System;
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
   //     private OracleDataReader myReader;
    //    private OracleCommandBuilder myCommandBuilder;
   //     private DataSet ds;
    //    private DataTable dt;
     //   private DataRow dr; 
        //定义数据库连接
        public string lastid;
        private void Open()
        {
            MyConn = new OracleConnection("Data Source=XINHUA;User Id=xxb;Password=pass;Integrated Security=no;"); 
            if (MyConn.State.ToString() != "Open")        
             MyConn.Open(); 
        }
        private void sClose() 
        { 
           // if (ds != null)
           //   { ds.Dispose(); } 
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
            this.sClose();
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
            



        }
        // //以上三个函数实现动态加载无限联级的树控件
       //以下函数遍历树的子节点并显示在LISTBOX控件中
        private void FindNodes(TreeNode node)
        {
            try 
            {
                if (node.Nodes.Count > 0)
                {
                    foreach (TreeNode n in node.Nodes)
                    {
                        FindNodes(n);
                    }
                }
                else 
                {
                    if (node.Checked == true)
                    {
                        listBox1.Items.Add(node.Tag.ToString() + "," + node.Text);
                        
                    }
                }
            }
            catch
            { listBox1.Items.Add(node.Text); }
        }
       //判定字符串的第一个逗号前的字符
        private string StrMakeFirst(string str1)
        {       
               string str=str1;
               String[] strs = str.Split(','); 
               return strs[0];
         }
        //判定字符串的第一个逗号后的字符
        private string StrMakeSend(string str1)
        {  
                string str=str1;
               String[] strs = str.Split(','); 
               return strs[1];
        }
        //根据权限表构造权限树二级的叶子节点
    
        private void RoleAdd_Load(object sender, EventArgs e)
        {
            InitializeTreeView();
            listBox1.Items.Clear();
            foreach (TreeNode tn in treeView1.Nodes)
            { FindNodes(tn); }
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
        //构造部门的权限树
        private void CreatActionTree(TreeView p_treeView)
        {
            int sum = listBox1.Items.Count;
            for (int i = 0; i <sum; i++)
            {
                TreeNode node = new TreeNode();
                node.Tag = StrMakeFirst(listBox1.Items[i].ToString()).ToString();
                node.Text = StrMakeSend(listBox1.Items[i].ToString()).ToString();
                node.Checked = true;
                 p_treeView.Nodes.Add(node);
                 MakeChildAction(node);
            }
 
        }
        //根据权限表构造权限树二级的叶子节点
        private void MakeChildAction(TreeNode p_node)
        {
             this.Open();
             string str = "select * from SYS_ACTION";
             DataSet ds1 = new DataSet("SYS_ACTION");
             OracleDataAdapter adapter1=new OracleDataAdapter();
             OracleCommand comm = new OracleCommand(str, MyConn);
             adapter1.SelectCommand = comm;
             adapter1.Fill(ds1, "SYS_ACTION");
             DataTable dt_ac = ds1.Tables["SYS_ACTION"];
             DataView dv = new DataView(dt_ac);
             foreach (DataRowView dr in dv)
            {
                TreeNode node = new TreeNode();
                node.Tag = dr.Row["actioncode"].ToString();       //值 
                node.Text = dr.Row["ACTIONNAME"].ToString();   //显示在节点上的文本 
                p_node.Nodes.Add(node);
             }




        }

        private void LoopTreeView(TreeView c_treeview)
        {
            TreeNodeCollection allnode;
            allnode = c_treeview.Nodes;

            GetNode(allnode);



        }
        private void GetNode(TreeNodeCollection tc)
        {
            foreach (TreeNode TNode in tc)
            {
                if (TNode.Checked == true)
                {
                    string CurrentId = TNode.Tag.ToString();
                    this.Open();
                    string str3 = "select * from SYS_ROLE_MODULE ";
                    OracleDataAdapter adp3 = new OracleDataAdapter();
                    OracleCommand comm3 = new OracleCommand(str3, MyConn);
                    adp3.SelectCommand = comm3;
                    DataSet ds_show = new DataSet();
                    adp3.Fill(ds_show, "SYS_ROLE_MODULE");
                    adp3.InsertCommand = new OracleCommand("insert into SYS_ROLE_MODULE (ID,role_id,module_id) values (seq_SYS_ROLE_MODULE_id.nextval,"+lastid+",'" + CurrentId + "')", MyConn);
                    adp3.InsertCommand.ExecuteNonQuery();
                    adp3.Update(ds_show, "SYS_ROLE_MODULE");
                    LoopActionTreeView(treeView2,CurrentId);
                    GetNode(TNode.Nodes);

                }

            }
        }
        private void LoopActionTreeView(TreeView c_treeview,string str)
        {
            TreeNodeCollection allnode;
            allnode = c_treeview.Nodes;
            foreach (TreeNode TNode in allnode)
            {
                if (TNode.Tag.ToString() == str.ToString())
                {
                    GetActionChildNode(TNode,str);
                }
            }
        }
        private void GetActionChildNode(TreeNode TNode,string str)
        {
            this.Open();
            string str4 = "select * from SYS_ROLE_MODULE_ACTION";
            OracleDataAdapter adp4 = new OracleDataAdapter();
            OracleCommand comm4 = new OracleCommand(str4, MyConn);
            adp4.SelectCommand = comm4;
            DataSet ds = new DataSet();
            adp4.Fill(ds, "SYS_ROLE_MODULE_ACTION");

            int i = TNode.GetNodeCount(false);
            for (int j = 0; j < i;j++ )
            {
               if(TNode.Nodes[j].Checked==true)
               {
                   string str5 = "insert into SYS_ROLE_MODULE_ACTION t" +
                                 "  (t.id, t.roleid, t.modeleid, t.actioncode)" +
                                 "values" +
                                 "  (seq_action.nextval, '" + lastid + "', '" + str + "', '" + TNode.Nodes[j].Tag.ToString() + "')";
                   adp4.InsertCommand = new OracleCommand(str5,MyConn);
                   adp4.InsertCommand.ExecuteNonQuery();
                   adp4.Update(ds, "SYS_ROLE_MODULE_ACTION");
               }
            }
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
                this.Open();
                string str2 = "select * from SYS_ROLE ";//SYS_ROLE 
                OracleDataAdapter adp2 = new OracleDataAdapter();
                OracleCommand comm2 = new OracleCommand(str2, MyConn);
                adp2.SelectCommand = comm2;
                DataSet ds_role = new DataSet();
                adp2.Fill(ds_role, "SYS_ROLE");
                adp2.InsertCommand = new OracleCommand("insert into sys_role (role_id,role_name,super_id,description) values (seq_sys_role_role_id.nextval,'" + rolename + "','0','" + description + "')", MyConn);
                adp2.InsertCommand.ExecuteNonQuery();
                adp2.Update(ds_role, "SYS_ROLE");
                string strSql = "SELECT   MAX(role_id)   AS   Num   FROM   SYS_ROLE "; 
                OracleDataAdapter   da=new   OracleDataAdapter();
                OracleCommand linshi = new OracleCommand(strSql, MyConn);
                OracleDataReader myder;
                myder = linshi.ExecuteReader();

                try {
                    while (myder.Read())
                    {
                        lastid = myder.GetValue(0).ToString();
                    }

                }
                finally { myder.Close(); this.sClose(); }



                this.LoopTreeView(treeView1);
               // this.LoopActionTreeView();

            }


         
               this.Close();
            }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach(TreeNode tn in treeView1.Nodes)
            { FindNodes(tn); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //构造部门的权限树
            treeView2.Nodes.Clear();
            CreatActionTree(treeView2);
        }

     
            

        }

       
    }


        


    


