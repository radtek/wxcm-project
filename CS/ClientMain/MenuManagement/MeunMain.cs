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
    public partial class MeunMain : Form
    {
        bool m_fgAdd;
        bool m_fgDel;
        bool m_fgUpdate;
        bool m_fgQuery;
        public MeunMain(bool fgAdd, bool fgDel, bool fgUpdate, bool fgQuery)
        {
            InitializeComponent();
            //  XpoDefault.ConnectionString = OracleConnectionProvider.GetConnectionString("XINHUA", "xxb", "pass");
            XpoDefault.ConnectionString = FrmLogin.xpoConStr;
            
            m_fgAdd = fgAdd;
            m_fgDel = fgDel;
            m_fgQuery = fgQuery;
            m_fgUpdate = fgUpdate;
        }
        private OracleConnection MyConn = null;
        //定义数据库连接
        private void Open()
        {
            string StrCon = FrmLogin.strCon;
            MyConn = new OracleConnection(StrCon);
            if (MyConn.State.ToString() != "Open")
                MyConn.Open();
        }
        //定义数据库关闭
        private void sClose()
        {
            if (MyConn != null & MyConn.State.ToString() != "Closed")
            { MyConn.Close(); }
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
       //以上三个函数初始化树控件

        private void MeunMain_Load(object sender, EventArgs e)
        {
            InitializeTreeView();
            if (m_fgAdd)
            {
                MenuItem_add.Visible = true;
                btnAdd.Visible = true;
                btnSadd.Visible = true;
                MenuItem_sadd.Visible = true;

            }
            else
            {
                MenuItem_add.Visible =false ;
                btnAdd.Visible = false;
                btnSadd.Visible = false;
                MenuItem_sadd.Visible = false;

            }

            if (m_fgDel)
            {
                btnDelete.Visible = true;
                MenuItem_delete.Visible = true;
            }
            else
            {
                btnDelete.Visible = false;
                MenuItem_delete.Visible = false;
            }

            if (m_fgUpdate)
            {
                btnAlter.Visible = true;
                MenuItem_alter.Visible = true;
            }
            else
            {
                btnAlter.Visible = false;
                MenuItem_alter.Visible = false;
            }
            if (m_fgQuery)
            {
                btnLook.Visible = true;
                MenuItem_look.Visible = true;
            }
            else
            {
                btnLook.Visible = false;
                MenuItem_look.Visible = false;
            }
            gridView1.BestFitColumns();
        }
        private void treeView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)//判断你点的是不是右键
            {
                //  TreeView treev = sender as TreeView;
                // Point point = treev.PointToClient(Cursor.Position);
                Point ClickPoint = new Point(e.X, e.Y);
                TreeNode CurrentNode = treeView1.GetNodeAt(ClickPoint);
                if (CurrentNode != null)//判断你点的是不是一个节点
                {
                    CurrentNode.ContextMenuStrip = contextMenuStrip1;
                    treeView1.SelectedNode = CurrentNode;//选中这个节点

                }

            }


        }
        private void DelectCurrentMenu(string code)
        {
            try
            {

                string str1 = "select * from SYS_MODEL ";
                OracleDataAdapter adp1 = new OracleDataAdapter();
                OracleCommand comm3 = new OracleCommand(str1, MyConn);
                adp1.SelectCommand = comm3;
                DataSet ds1 = new DataSet();
                adp1.Fill(ds1, "SYS_MODEL");
                string str2 = "delete from SYS_MODEL where id='" + code + "'";
                string str3 = "select id from SYS_MODEL where PARENTMODEL='" + code + "'";
                OracleCommand comm1 = new OracleCommand(str3, MyConn);
                OracleDataReader reader1 = comm1.ExecuteReader();
                while (reader1.Read())
                {
                    string nextcode = reader1.GetValue(0).ToString();
                    DelectCurrentMenu(nextcode);
                }
                adp1.DeleteCommand = new OracleCommand(str2, MyConn);
                adp1.DeleteCommand.ExecuteNonQuery();
                adp1.Update(ds1, "SYS_MODEL");

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void MenuItem_add_Click(object sender, EventArgs e)
        {
            string conn_menuid = treeView1.SelectedNode.Tag.ToString();
            MeunAdd MeunAdd = new MeunAdd(conn_menuid);
            if (MeunAdd.ShowDialog() == DialogResult.OK)
            {

                treeView1.Nodes.Clear();
                InitializeTreeView();
                unitOfWork1.DropIdentityMap();
                xpServerCollectionSource1.Reload();
            }
        }



        private void MenuItem_alter_Click(object sender, EventArgs e)
        {
            string conn_menuid = treeView1.SelectedNode.Tag.ToString();
            MenuEdit MenuEdit = new MenuEdit(conn_menuid);
            if (MenuEdit.ShowDialog() == DialogResult.OK)
            {
                treeView1.Nodes.Clear();
                InitializeTreeView();
                unitOfWork1.DropIdentityMap();
                xpServerCollectionSource1.Reload();
            }

        }



        private void MenuItem_look_Click(object sender, EventArgs e)
        {
            string conn_menuid = treeView1.SelectedNode.Tag.ToString();
            MenuShow MenuShow = new MenuShow(conn_menuid);
            MenuShow.ShowDialog();
        }




        private void MenuItem_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要删除这个菜单吗", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string conn_menuid = treeView1.SelectedNode.Tag.ToString();
                DelectCurrentMenu(conn_menuid);
                treeView1.Nodes.Clear();
                InitializeTreeView();
                unitOfWork1.DropIdentityMap();
                xpServerCollectionSource1.Reload();

            }
        }

        private void MenuItem_sadd_Click(object sender, EventArgs e)
        {
            MenuFirstDegreeAdd MenuFirstDegreeAdd = new MenuFirstDegreeAdd();

            if (MenuFirstDegreeAdd.ShowDialog() == DialogResult.OK)
            {
                unitOfWork1.DropIdentityMap();
                xpServerCollectionSource1.Reload();
                treeView1.Nodes.Clear();
                InitializeTreeView();
            }
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            this.sClose();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string conn_menuid = treeView1.SelectedNode.Tag.ToString();
            MeunAdd MeunAdd = new MeunAdd(conn_menuid);
            if (MeunAdd.ShowDialog() == DialogResult.OK)
            {

                treeView1.Nodes.Clear();
                InitializeTreeView();
                unitOfWork1.DropIdentityMap();
                xpServerCollectionSource1.Reload();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要删除这个菜单吗", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string conn_menuid = treeView1.SelectedNode.Tag.ToString();
                DelectCurrentMenu(conn_menuid);
                treeView1.Nodes.Clear();
                InitializeTreeView();
                unitOfWork1.DropIdentityMap();
                xpServerCollectionSource1.Reload();

            }
        }

        private void btnAlter_Click(object sender, EventArgs e)
        {
            string conn_menuid = treeView1.SelectedNode.Tag.ToString();
            MenuEdit MenuEdit = new MenuEdit(conn_menuid);
            if (MenuEdit.ShowDialog() == DialogResult.OK)
            {

                treeView1.Nodes.Clear();
                InitializeTreeView();
                unitOfWork1.DropIdentityMap();
                xpServerCollectionSource1.Reload();
            }
        }

        private void btnLook_Click(object sender, EventArgs e)
        {
            string conn_menuid = treeView1.SelectedNode.Tag.ToString();
            MenuShow MenuShow = new MenuShow(conn_menuid);
            MenuShow.ShowDialog();
        }

        private void btnSadd_Click(object sender, EventArgs e)
        {
            MenuFirstDegreeAdd MenuFirstDegreeAdd = new MenuFirstDegreeAdd();

            if (MenuFirstDegreeAdd.ShowDialog() == DialogResult.OK)
            {
                unitOfWork1.DropIdentityMap();
                xpServerCollectionSource1.Reload();
                treeView1.Nodes.Clear();
                InitializeTreeView();
            }
        }
    }
}
