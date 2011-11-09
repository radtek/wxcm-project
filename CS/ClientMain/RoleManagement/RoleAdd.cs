using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;
using System.Runtime.Serialization.Formatters.Binary;
using System.Configuration;

namespace ClientMain
{
    public partial class RoleAdd : Form
    {
        // private string StrCon = FrmLogin.strCon;
        private string StrCon = FrmLogin.strDataCent;
        public RoleAdd()
        {
            InitializeComponent();
            this.treeView1.AfterCheck += new TreeViewEventHandler(treeView1_AfterCheck);
            this.treeView2.AfterCheck += new TreeViewEventHandler(treeView2_AfterCheck);
            this.treeView1.MouseUp+=new MouseEventHandler(treeView1_MouseUp);
        }
        //判定字符串的第一个逗号前的字符
        private string StrMakeFirst(string str1)
        {
            string str = str1;
            String[] strs = str.Split(',');
            return strs[0];
        }
        //判定字符串的第一个逗号后的字符
        private string StrMakeSend(string str1)
        {
            string str = str1;
            String[] strs = str.Split(',');
            return strs[1];
        }
        //根据权限表构造权限树二级的叶子节点
        //tree1父子联动代码
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
        bool tag = false;//treeview1的父子联动判断中间量
        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (tag == false)
            {
                tag = true;
                setcheck(e.Node);
                tag = false;

            }
        }
        //tree2父子联动
        private void selectParentNode(TreeNode node, bool check)
        {


            if (node.Parent is TreeNode)
            {
                bool fgcheck = true;
                TreeNode pnode = (TreeNode)node.Parent;
                int j = 0;
                for (int i = 0; i < pnode.Nodes.Count; i++)
                {
                    if (pnode.Nodes[i].Checked == check)
                    { j++; }
                    if (j > 1)
                    { fgcheck = false; break; }

                }
                if (j < 1)
                {
                    fgcheck = false; pnode.Checked = false;
                }

                if (fgcheck == true)
                {
                    pnode.Checked = check;
                    selectParentNode(pnode, check);
                }

            }
            else
            {
                //根节点
            }
        }
        private void treeView2_AfterCheck(object sender, TreeViewEventArgs e)
        {
            selectParentNode(e.Node, e.Node.Checked);

        }
        //依据部门名称反取部门ID
        private string seid(string e)
        {
               string svalue=null;
               string strid = "Select ID from SYS_MODEL where MODELNAME='" + e + "'";
            OracleConnection MyConn = new OracleConnection(StrCon);
            try
            {
                MyConn.Open();
                OracleCommand sid = new OracleCommand(strid, MyConn);
                OracleDataReader sidreader;
                sidreader = sid.ExecuteReader();
                while (sidreader.Read())
                {
                    svalue = sidreader.GetValue(0).ToString();
                }
            }

            catch(Exception ex)
            { MessageBox.Show(ex.Message); }
            finally
            {
                MyConn.Close();
            }
            return svalue;
        }
        //构造部门的权限树
        private void CreatActionTree(TreeView p_treeView)
        {
            int sum = listBox1.Items.Count;
            for (int i = 0; i < sum; i++)
            {
                TreeNode node = new TreeNode();
                node.Tag = StrMakeFirst(listBox1.Items[i].ToString()).ToString();
                node.Text = StrMakeSend(listBox1.Items[i].ToString()).ToString();
             //   node.Checked = true;
                p_treeView.Nodes.Add(node);
                MakeChildAction(node);
            }

        }
        //根据权限表构造权限树二级的叶子节点
        private void MakeChildAction(TreeNode p_node)
        {
            OracleConnection MyConn = new OracleConnection(StrCon);
            try
            {
                MyConn.Open();
                string str = "select * from SYS_ACTION";
                DataSet ds1 = new DataSet("SYS_ACTION");
                OracleDataAdapter adapter1 = new OracleDataAdapter();
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
                  //  node.Checked = true;
                    p_node.Nodes.Add(node);
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            finally
            { MyConn.Close(); }



        }
        private void treeView1_MouseUp(object sender, MouseEventArgs e)
        {
            listBox1.Items.Clear();
            foreach (TreeNode tn in treeView1.Nodes)
            { FindNodes(tn); }
            //构造部门的权限树
            treeView2.Nodes.Clear();
            CreatActionTree(treeView2);
        }
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
            OracleConnection MyConn = new OracleConnection(StrCon);
            string firstnode = "select * from SYS_MODEL ";

            try
            {
                MyConn.Open();
                OracleDataAdapter adp = new OracleDataAdapter();
                OracleCommand oraquer = new OracleCommand(firstnode, MyConn);
                adp.SelectCommand = oraquer;

                DataSet ds1 = new DataSet("SYS_MODEL");
                adp.Fill(ds1, "SYS_MODEL");
                DataTable dt1 = ds1.Tables["SYS_MODEL"];

                CreateTreeView(treeView1, dt1, "ID", "MODELNAME", "PARENTMODEL", "0"); 
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MyConn.Close();
            }
           
        }
        //设定根节点
        private void CreateTreeView(TreeView p_treeView, DataTable p_dataTable, string p_IDField, string p_NameField, string p_ParentIDField, string RootValue)
        {

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
        private void RoleAdd1_Load(object sender, EventArgs e)
        {
            InitializeTreeView();
            listBox1.Items.Clear();
            foreach (TreeNode tn in treeView1.Nodes)
            { FindNodes(tn); }
            this.Height = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtRoleName.Text = "";
            this.txtRoleDirs.Text = "";
            treeView2.Nodes.Clear();
            treeView1.Nodes.Clear();
            InitializeTreeView();
            listBox1.Items.Clear();
            foreach (TreeNode tn in treeView1.Nodes)
            { FindNodes(tn); }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRoleName.Text.Trim()))
            {
                MessageBox.Show("请输入角色名称");
                txtRoleName.Focus();
            }
            else
            {
                using (OracleConnection connection = new OracleConnection(StrCon))
                {
                    connection.Open();
                    OracleCommand cmd = connection.CreateCommand();
                    OracleTransaction transaction;
                    transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);
                    cmd.Transaction = transaction;
                    try
                    {
                        cmd.CommandText = "insert into sys_role (role_id,role_name,super_id,description) values (seq_sys_role_role_id.nextval,'" + txtRoleName.Text.Trim() + "','0','" + txtRoleDirs.Text.Trim() + "')";
                        cmd.ExecuteNonQuery();
                        for (int i = 0; i < treeView2.Nodes.Count;i++ )
                        {
                            if (treeView2.Nodes[i].Checked == true)
                            {
                                cmd.CommandText = "insert into SYS_ROLE_MODULE (ID,role_id,module_id) values (seq_SYS_ROLE_MODULE_id.nextval,seq_sys_role_role_id.currval,'" + treeView2.Nodes[i].Tag.ToString() + "')";
                                cmd.ExecuteNonQuery();
                                for (int j = 0; j < treeView2.Nodes[i].Nodes.Count;j++ )
                                {
                                    if (treeView2.Nodes[i].Nodes[j].Checked == true)
                                    {
                                        cmd.CommandText = "insert into SYS_ROLE_MODULE_ACTION t" +
                                                           "  (t.id, t.roleid, t.modeleid, t.actioncode)" +
                                                               "values" +
                                                              "  (seq_action.nextval,seq_sys_role_role_id.currval, '" + treeView2.Nodes[i].Tag.ToString() + "', '" + treeView2.Nodes[i].Nodes[j].Tag.ToString() + "')";
                                        cmd.ExecuteNonQuery();
                                    }
                                }
                            }
                        }
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
        }
    }
}
