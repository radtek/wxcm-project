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
    public partial class UserAdd : Form
    {
        private GridCheckMarksSelection selection;
        // private string StrCon = FrmLogin.strCon;
        private string StrCon = FrmLogin.strDataCent;
        public UserAdd()
        {
            InitializeComponent();
            //  XpoDefault.ConnectionString = OracleConnectionProvider.GetConnectionString("XINHUA", "xxb", "pass");
            XpoDefault.ConnectionString = FrmLogin.xpoDataCentStr;
            selection = new GridCheckMarksSelection(gridView1);
            selection.CheckMarkColumn.VisibleIndex = 0;
            xpServerCollectionSource1.FixedFilterString = "[DEPARTMENTID] Is Null";
            txtName.Focus();
            this.gridView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gridView1_MouseUp);
            this.treeView1.AfterCheck+=new TreeViewEventHandler(treeView1_AfterCheck);
            this.txtName.Validating+=new CancelEventHandler(txtName_Validating);
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
            catch(Exception ex)
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
                node.Text = listView1.Items[i].SubItems[0].Text.ToString(); ;   //显示在节点上的文本 
                p_node.Nodes.Add(node);
            }





        }
        private void selectParentNode(TreeNode node, bool check)
        {


            if (node.Parent is TreeNode)
            {
                bool fgcheck = true;
                TreeNode pnode = (TreeNode)node.Parent;
                int j = 0;
                for (int i = 0; i < pnode.Nodes.Count;i++ )
                {
                    if (pnode.Nodes[i].Checked == check)
                    { j++; }
                    if(j>1)
                    { fgcheck = false; break; }
                   
                }
                if (j < 1)
                {
                    fgcheck = false; pnode.Checked = false;
                }
 
               if(fgcheck==true)
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
        private void txtName_Validating(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                MessageBox.Show("您还没有输入用户名");
                txtName.Focus();
            }
            else
            {
                int i = 0;
                string strUser = "select count(*) from SYS_USER where username = '" + txtName.Text.Trim() + "'";
                OracleConnection connection = new OracleConnection(StrCon);
                OracleCommand comm = new OracleCommand(strUser, connection);
                try
                {
                    connection.Open();
                    OracleDataReader reader = comm.ExecuteReader();
                    while(reader.Read())
                    {
                        i = Convert.ToInt32(reader.GetValue(0));
                    }
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                    finally
                {
                    connection.Close();
                }
                if(i!=0)
                {
                    MessageBox.Show("您输入的用户已存在");
                    txtName.Text = "";
                    txtName.Focus();
                }

            }
        }

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            selectParentNode(e.Node, e.Node.Checked);   

        }
        private void btnSelectEmploee_Click(object sender, EventArgs e)
        {
             EmpoeeTable EmpoeeTable = new EmpoeeTable();
             if (EmpoeeTable.ShowDialog() == DialogResult.OK)
             {
                 this.txtEmploee.Text = EmpoeeTable.GetEmployname.ToString();
                 this.txtEmploee.Tag = EmpoeeTable.GetEmployid.ToString();
             }
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

        private void btnQuery_Click(object sender, EventArgs e)
        {
            selection.ClearSelection();
            gridView1.ShowFilterEditor(gridView1.FocusedColumn);
            xpServerCollectionSource1.Reload();
            if (!String.IsNullOrEmpty(gridView1.ActiveFilterString))
            {
                xpServerCollectionSource1.FixedFilterString = gridView1.ActiveFilterString;
                gridView1.BestFitColumns();
            }
        }

        private void UserAdd1_Load(object sender, EventArgs e)
        {
            LoadRoleList();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCannel_Click(object sender, EventArgs e)
        {
            txtCheckpass.Text = "";
            txtDiscri.Text = "";
            txtEmploee.Text = "";
            txtName.Text = "";
            txtPass.Text="";
            selection.ClearSelection();
            treeView1.Nodes.Clear();
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
        private int GetTreeSelect()
        {
            int e=0;
             for (int i = 0; i <treeView1.Nodes.Count;i++ )
           {
             if (treeView1.Nodes[i].Checked == true) 
             {
                   e++;
              }
           }
            return e;

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool fgcheck = false;
            if(string.IsNullOrEmpty(txtName.Text))
            {
                fgcheck = false;
                MessageBox.Show("请输入名字");

            }
            else if(string.IsNullOrEmpty(txtEmploee.Text))
            {
                fgcheck = false;
                MessageBox.Show("请选择员工");
            }
            else if(string.IsNullOrEmpty(txtPass.Text))
            {
                fgcheck = false;
                MessageBox.Show("请输入密码");
            }
            else if(txtPass.Text.ToString()!=txtCheckpass.Text.ToString())
            {
                fgcheck = false;
                MessageBox.Show("密码不一致");
            }
            else if(selection.SelectedCount==0)
            {
                fgcheck = false;
                MessageBox.Show("请选择相对应的部门");
            }
            else if (GetTreeSelect()== 0)
            {
                fgcheck = false;
                MessageBox.Show("请选择相对应的角色");
            }
            else
            {
                fgcheck = true;
            }
            if(fgcheck==true)
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
                        cmd.CommandText = "insert into sys_user (userid,username,islock,password,description,empid) values(seq_sys_user_userid.nextval,'" + txtName.Text.ToString() + "','" + GetLack() + "','" + txtPass.Text.ToString() + "','" + txtDiscri.Text + "','" + txtEmploee.Tag.ToString() + "')";
                        cmd.ExecuteNonQuery();
                        for (int j = 0; j < i;j++ )
                        {
                            if (treeView1.Nodes[j].Checked == true) 
                            {
                                cmd.CommandText = "insert into SYS_USER_DEPARTMENT t (t.id, t.username, t.departmentid) values (seq_sys_user_department_id.nextval, '" + txtName.Text.ToString() + "', '" + treeView1.Nodes[j].Tag.ToString() + "')";
                                cmd.ExecuteNonQuery();
                                for (int ii = 0; ii < treeView1.Nodes[j].Nodes.Count;ii++ )
                                {
                                    if( treeView1.Nodes[j].Nodes[ii].Checked==true)
                                    {
                                        cmd.CommandText = "insert into SYS_USER_ROLE t  (t.id, t.username, t.deptid, t.roleid)  values  (seq_sys_user_role_id.nextval, '" + txtName.Text.ToString() + "', '" + treeView1.Nodes[j].Tag.ToString() + "', '" + treeView1.Nodes[j].Nodes[ii].Tag.ToString() + "')";
                                        cmd.ExecuteNonQuery();
                                    }

                                }
                            }
                        }
                        transaction.Commit();
                    }
                    catch(Exception ex)
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
