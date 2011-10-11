using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;
using System.Configuration;
using DevExpress.XtraEditors;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System.IO;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports;
using DevExpress.XtraPrinting.Localization; 

namespace ClientMain
{
    public partial class UserEdit : Form
    {
        private GridCheckMarksSelection selection;
        // private string StrCon = FrmLogin.strCon;
        private string StrCon = FrmLogin.strCon;
        public UserEdit(string id)
        {
            InitializeComponent();
            txtName.Tag = id;
            //  XpoDefault.ConnectionString = OracleConnectionProvider.GetConnectionString("XINHUA", "xxb", "pass");
            XpoDefault.ConnectionString = FrmLogin.xpoConStr;
            selection = new GridCheckMarksSelection(gridView1);
            selection.CheckMarkColumn.VisibleIndex = 0;

            this.gridView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gridView1_MouseUp);
            this.treeView1.AfterCheck += new TreeViewEventHandler(treeView1_AfterCheck);

        }
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
        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            selectParentNode(e.Node, e.Node.Checked);

        }
        private void gridView1_MouseUp(object sender, MouseEventArgs e)
        {

            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));
            if ((hitInfo.Column != null) && (hitInfo.Column.GetCaption() == "选择"))
            {
                if (selection.SelectedCount > 0)
                {
                    treeView1.Nodes.Clear();
                    for (int i = 0; i < selection.SelectedCount; i++)
                    {
                        ListViewItem Item = new ListViewItem();
                        TreeNode node = new TreeNode();
                        int RowIndex = selection.GetSelectedRowIndex(i);
                        int RowHandle = gridView1.GetRowHandle(RowIndex);
                        string strDEPARTMENTNAME = this.gridView1.GetRowCellDisplayText(RowHandle, "DEPARTMENTNAME");
                        string strDEPARTMENTID = this.gridView1.GetRowCellDisplayText(RowHandle, "DEPARTMENTID");
                        node.Tag = strDEPARTMENTID;
                        node.Text = strDEPARTMENTNAME;
                        treeView1.Nodes.Add(node);
                        MakeChildRole(node);


                    }

                }
                else
                {
                    treeView1.Nodes.Clear();
                }

            }
        }

        private bool GetCheckLockValue(string str)
        {
            bool i = false;
            if (str == "0")
            { i = true; }
            else
            { i = false; }
            return i;
        }
        private void LoadRoleList()
        {
            listView1.Items.Clear();
            string strCom = "select * from SYS_ROLE";
            OracleConnection connection = new OracleConnection(StrCon);
            try
            {
                connection.Open();
                OracleCommand comm = new OracleCommand(strCom, connection);
                OracleDataReader reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem Item = new ListViewItem();
                    Item.SubItems.Clear();
                    Item.SubItems[0].Text = reader["ROLE_NAME"].ToString();//读取数据库中字段   
                    Item.SubItems[0].Tag = reader["ROLE_ID"].ToString();
                    listView1.Items.Add(Item);//显示   

                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }



        }
        private void MakeChildRole(TreeNode p_node)
        {
            int sum = listView1.Items.Count;

            for (int i = 0; i < sum; i++)
            {
                ListViewItem Item = new ListViewItem();
                TreeNode node = new TreeNode();
                node.Tag = listView1.Items[i].SubItems[0].Tag.ToString();       //值 
                node.Text = listView1.Items[i].SubItems[0].Text.ToString();  //显示在节点上的文本 
                p_node.Nodes.Add(node);
            }

        }
        private void Load_Control_LOOK()
        {
            btnSave.Visible = false;
            btnCannel.Visible = false;
            btnSelectEmploee.Enabled = false;
            gridControl1.Enabled = false;
            btnQuery.Enabled = false;
           
        }
        private void Load_Content()
        {
            LoadRoleList();
            OracleConnection connection = new OracleConnection(StrCon);
            string strSelect = "select USERNAME,NAME,EMPID,PASSWORD,nvl(DESCRIPTION,''),nvl(ISLOCK,'') from VIEW_SYS_USER where USERID='"+txtName.Tag.ToString()+"'";
            OracleCommand comm = new OracleCommand(strSelect,connection);
            try
            {
                connection.Open();
                OracleDataReader reader = comm.ExecuteReader();
                while(reader.Read())
                {
                    txtName.Text = reader["USERNAME"].ToString();
                    txtEmploee.Text = reader["NAME"].ToString();
                    txtEmploee.Tag = reader["EMPID"].ToString();
                    txtDiscri.Text = reader["nvl(DESCRIPTION,'')"].ToString();
                   txtCheckpass.Text= txtPass.Text = reader["PASSWORD"].ToString();
                   checkLock.Checked = GetCheckLockValue(reader["nvl(ISLOCK,'')"].ToString());

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            { connection.Close(); }
            string strDepar = "select departmentid from SYS_USER_DEPARTMENT where username='" + txtName.Text.Trim()+ "'";
            OracleCommand commstrDepar = new OracleCommand(strDepar, connection);
            string strdepartmentid = null;
            try
            {
                connection.Open();
                OracleDataReader reader = commstrDepar.ExecuteReader();
                while (reader.Read())
                {
                    string strTemp = reader["departmentid"].ToString();
                    strdepartmentid += "[DEPARTMENTID] = \'" + strTemp + "\' Or ";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            { 
                connection.Close();
               int index = strdepartmentid.LastIndexOf("'");
               strdepartmentid = strdepartmentid.Substring(0, index + 1).Trim();
               xpServerCollectionSource1.FixedFilterString = strdepartmentid;
               gridView1.BestFitColumns();
               selection.SelectAll();

            }
            //构造权限树
            treeView1.Nodes.Clear();
            for (int i = 0; i < selection.SelectedCount; i++)
            {
                ListViewItem Item = new ListViewItem();
                TreeNode node = new TreeNode();
                int RowIndex = selection.GetSelectedRowIndex(i);
                int RowHandle = gridView1.GetRowHandle(RowIndex);
                string strDEPARTMENTNAME = this.gridView1.GetRowCellDisplayText(RowHandle, "DEPARTMENTNAME");
                string strDEPARTMENTID = this.gridView1.GetRowCellDisplayText(RowHandle, "DEPARTMENTID");
                node.Tag = strDEPARTMENTID;
                node.Text = strDEPARTMENTNAME;
                treeView1.Nodes.Add(node);
                MakeChildRole(node);


            }
            TraverseTree();
            

           
        }
        private void TraverseTree()//初始化遍历角色树
        {
            for (int i = 0; i < treeView1.Nodes.Count;i++ )
            {
                treeView1.Nodes[i].Checked = true;
                for (int j = 0; j < treeView1.Nodes[i].Nodes.Count;j++ )
                {
                    int ii = 0;
                    OracleConnection connection = new OracleConnection(StrCon);
                    string strCount = "select count(*) from SYS_USER_ROLE where username='" + txtName.Text.Trim() + "' and deptid='" + treeView1.Nodes[i].Tag.ToString() + "' and roleid='" + treeView1.Nodes[i].Nodes[j].Tag.ToString()+ "'";
                    OracleCommand comm = new OracleCommand(strCount, connection);
                    try
                    {
                        connection.Open();
                        OracleDataReader reader = comm.ExecuteReader();
                        while (reader.Read())
                        {
                            ii = Convert.ToInt32(reader.GetValue(0));
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    { connection.Close(); }
                    if (ii == 0)
                    {
                        treeView1.Nodes[i].Nodes[j].Checked = false;
                    }
                    else
                    {
                        treeView1.Nodes[i].Nodes[j].Checked = true;
                    }
                }
            }
        }
        private void UserEdit1_Load(object sender, EventArgs e)
        {

            Load_Content();
            if (this.Tag.ToString() == "ALTER")
            {}
            else if (this.Tag.ToString() == "LOOK")
            {
                Load_Control_LOOK();
            }

        }
        private int GetTreeSelect()
        {
            int e = 0;
            for (int i = 0; i < treeView1.Nodes.Count; i++)
            {
                if (treeView1.Nodes[i].Checked == true)
                {
                    e++;
                }
            }
            return e;

        }
        private string GetLack()
        {
            int flag;
            if (this.checkLock.Checked == true)
            { flag = 0; }
            else
            { flag = 1; }

            return flag.ToString();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool fgcheck = false;
        
            if (string.IsNullOrEmpty(txtEmploee.Text))
            {
                fgcheck = false;
                MessageBox.Show("请选择员工");
            }
            else if (string.IsNullOrEmpty(txtPass.Text))
            {
                fgcheck = false;
                MessageBox.Show("请输入密码");
            }
            else if (txtPass.Text.ToString() != txtCheckpass.Text.ToString())
            {
                fgcheck = false;
                MessageBox.Show("密码不一致");
            }
            else if (selection.SelectedCount == 0)
            {
                fgcheck = false;
                MessageBox.Show("请选择相对应的部门");
            }
            else if (GetTreeSelect() == 0)
            {
                fgcheck = false;
                MessageBox.Show("请选择相对应的角色");
            }
            else
            {
                fgcheck = true;
            }
            if (fgcheck == true)
            {
                using (OracleConnection connection = new OracleConnection(StrCon))
                {
                    connection.Open();
                    OracleCommand cmd = connection.CreateCommand();
                    OracleTransaction transaction;
                    transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);
                    cmd.Transaction = transaction;
                    int i = treeView1.Nodes.Count;


                    try
                    {
                        cmd.CommandText = "update  sys_user set islock='" + GetLack() + "',password='" + txtPass.Text.Trim()+ "',description='" + txtDiscri.Text.Trim() + "' where USERID='" + txtName.Tag.ToString() + "'";
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = "delete  from SYS_USER_DEPARTMENT where USERNAME='" + txtName.Text.Trim() + "'";
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = "delete  from SYS_USER_ROLE where USERNAME='" + txtName.Text.Trim() + "'";
                        cmd.ExecuteNonQuery();
                        for (int j = 0; j < i; j++)
                        {
                            if (treeView1.Nodes[j].Checked == true)
                            {
                                cmd.CommandText = "insert into SYS_USER_DEPARTMENT t (t.id, t.username, t.departmentid) values (seq_sys_user_department_id.nextval, '" + txtName.Text.ToString() + "', '" + treeView1.Nodes[j].Tag.ToString() + "')";
                                cmd.ExecuteNonQuery();

                                for (int ii = 0; ii < treeView1.Nodes[j].Nodes.Count; ii++)
                                {
                                    if (treeView1.Nodes[j].Nodes[ii].Checked == true)
                                    {
                                        cmd.CommandText = "insert into SYS_USER_ROLE t  (t.id, t.username, t.deptid, t.roleid)  values  (seq_sys_user_role_id.nextval, '" + txtName.Text.ToString() + "', '" + treeView1.Nodes[j].Tag.ToString() + "', '" + treeView1.Nodes[j].Nodes[ii].Tag.ToString() + "')";
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

        private void btnQuery_Click(object sender, EventArgs e)
        {

            gridView1.ShowFilterEditor(gridView1.FocusedColumn);
            xpServerCollectionSource1.Reload();
            if (!String.IsNullOrEmpty(gridView1.ActiveFilterString))
            {
                xpServerCollectionSource1.FixedFilterString = gridView1.ActiveFilterString;
                gridView1.BestFitColumns();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
