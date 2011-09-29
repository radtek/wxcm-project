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
    public partial class UserMain : Form
    {
        private GridCheckMarksSelection selection;
        private string StrCon = FrmLogin.strCon;
        bool m_fgAdd;
        bool m_fgDel;
        bool m_fgUpdate;
        bool m_fgQuery;
        public UserMain(bool fgAdd, bool fgDel, bool fgUpdate, bool fgQuery)
        {
            InitializeComponent();
            XpoDefault.ConnectionString = OracleConnectionProvider.GetConnectionString("XINHUA", "xxb", "pass");
            selection = new GridCheckMarksSelection(gridView1);
            selection.CheckMarkColumn.VisibleIndex = 0;
            m_fgAdd = fgAdd;
            m_fgDel = fgDel;
            m_fgQuery = fgQuery;
            m_fgUpdate = fgUpdate;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserMain1_Load(object sender, EventArgs e)
        {
            if (m_fgAdd)
            {
               btnUserAdd.Visible = true;
            }
            else
            {
              btnUserAdd.Visible = false;
            }

            if (m_fgDel)
            {
                btnUserDelete.Visible = true;

            }
            else
            {
                btnUserDelete.Visible = false;
            }

            if (m_fgUpdate)
            {
               btnUserAlter.Visible = true;
            }
            else
            {
                btnUserAlter.Visible = false;
            }
            if (m_fgQuery)
            {
                btnUserLook.Visible = true;
            }
            else
            {
                btnUserLook.Visible = false;
            }
        }

        private void btnUserAdd_Click(object sender, EventArgs e)
        {
            UserAdd UserAdd = new UserAdd();
            if (UserAdd.ShowDialog()==DialogResult.OK)
            {
                unitOfWork1.DropIdentityMap();
                xpServerCollectionSource1.Reload();
                this.gridView1.BestFitColumns();
            }
        }

        private void btnUserAlter_Click(object sender, EventArgs e)
        {
            if (selection.SelectedCount == 1)
            {
                int RowIndex = selection.GetSelectedRowIndex(0);
                int RowHandle = gridView1.GetRowHandle(RowIndex);
                string strUserid = this.gridView1.GetRowCellDisplayText(RowHandle,"USERID");
                UserEdit UserEdit = new UserEdit(strUserid);
                UserEdit.Tag = "ALTER";
                UserEdit.Text = "用户修改";
                if (UserEdit.ShowDialog() == DialogResult.OK)
                {
                    unitOfWork1.DropIdentityMap();
                    xpServerCollectionSource1.Reload();
                    this.gridView1.BestFitColumns();
                }

            }
            else
            { MessageBox.Show("请选择一项进行修改"); }
            selection.ClearSelection();
           
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

        private void btnUserLook_Click(object sender, EventArgs e)
        {
            if (selection.SelectedCount == 1)
            {
                int RowIndex = selection.GetSelectedRowIndex(0);
                int RowHandle = gridView1.GetRowHandle(RowIndex);
                string strUserid = this.gridView1.GetRowCellDisplayText(RowHandle, "USERID");
                UserEdit UserEdit = new UserEdit(strUserid);
                UserEdit.Tag = "LOOK";
                UserEdit.Text = "用户查看";
                if (UserEdit.ShowDialog() == DialogResult.OK)
                {
                    unitOfWork1.DropIdentityMap();
                    xpServerCollectionSource1.Reload();
                    this.gridView1.BestFitColumns();
                }

            }
            else
            { MessageBox.Show("请选择一项进行查看"); }
            selection.ClearSelection();
        }

        private void btnUserReload_Click(object sender, EventArgs e)
        {
                    unitOfWork1.DropIdentityMap();
                    xpServerCollectionSource1.Reload();
                    this.gridView1.BestFitColumns();
        }

        private void btnUserDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要进行删除操作", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (selection.SelectedCount == 0)
                {
                    MessageBox.Show("请先选择需要删除的用户");
                }
                else
                {
                    using (OracleConnection connection = new OracleConnection(StrCon))
                    {

                        for (int i = 0; i < selection.SelectedCount; ++i)
                        {
                            int RowIndex = selection.GetSelectedRowIndex(i);
                            int RowHandle = gridView1.GetRowHandle(RowIndex);
                            string strUserid = this.gridView1.GetRowCellDisplayText(RowHandle, "USERID");
                            string strUsername = this.gridView1.GetRowCellDisplayText(RowHandle, "USERNAME");
                            connection.Open();
                            OracleCommand cmd = connection.CreateCommand();
                            OracleTransaction transaction;
                            transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);
                            cmd.Transaction = transaction;
                            try
                            {

                                cmd.CommandText = "delete from SYS_USER where USERID='" + strUserid + "'";
                                cmd.ExecuteNonQuery();
                                cmd.CommandText = "delete from SYS_USER_DEPARTMENT where USERNAME='" + strUsername + "'";
                                cmd.ExecuteNonQuery();
                                cmd.CommandText = "delete from SYS_USER_ROLE where USERNAME='" + strUsername + "'";
                                cmd.ExecuteNonQuery();
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
                            }
                        }
                        selection.ClearSelection();
                        unitOfWork1.DropIdentityMap();

                        xpServerCollectionSource1.Reload();

                    }
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (selection.SelectedCount == 1)
            {
                int RowIndex = selection.GetSelectedRowIndex(0);
                int RowHandle = gridView1.GetRowHandle(RowIndex);
                string strUserid = this.gridView1.GetRowCellDisplayText(RowHandle, "USERID");
                UserEdit UserEdit = new UserEdit(strUserid);
                UserEdit.Tag = "ALTER";
                UserEdit.Text = "用户修改";
                if (UserEdit.ShowDialog() == DialogResult.OK)
                {
                    unitOfWork1.DropIdentityMap();
                    xpServerCollectionSource1.Reload();
                    this.gridView1.BestFitColumns();
                }

            }
            else
            { MessageBox.Show("请选择一项进行修改"); }
            selection.ClearSelection();
        }


    }
}
