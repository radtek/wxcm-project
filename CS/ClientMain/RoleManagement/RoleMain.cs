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
    public partial class RoleMain : Form
    {
        private GridCheckMarksSelection selection;
        private string StrCon = ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString;
        bool m_fgAdd;
        bool m_fgDel;
        bool m_fgUpdate;
        bool m_fgQuery;
        public RoleMain(bool fgAdd, bool fgDel, bool fgUpdate, bool fgQuery)
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RoleMain1_Load(object sender, EventArgs e)
        {
            if (m_fgAdd)
            {
                this.btnAdd.Visible = true;
            }
            else
            {
                this.btnAdd.Visible = false;
            }

            if (m_fgDel)
            {
                this.btnDelete.Visible = true;

            }
            else
            {
                this.btnDelete.Visible = false;
            }

            if (m_fgUpdate)
            {
                this.btnEdit.Visible = true;
            }
            else
            {
                this.btnEdit.Visible = false;
            }
            if (m_fgQuery)
            {
                this.btnLook.Visible = true;
            }
            else
            {
                this.btnLook.Visible = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            RoleAdd RoleAdd = new RoleAdd();
            if (RoleAdd.ShowDialog() == DialogResult.OK)
            {
                unitOfWork1.DropIdentityMap();
                xpServerCollectionSource1.Reload();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selection.SelectedCount == 1)
            {
                int RowIndex = selection.GetSelectedRowIndex(0);
                int RowHandle = gridView1.GetRowHandle(RowIndex);
                string strRoleid = this.gridView1.GetRowCellDisplayText(RowHandle, "ROLE_ID");
                RoleEdit RoleEdit = new RoleEdit(strRoleid);
                RoleEdit.Tag = "ALTER";
                RoleEdit.Text = "角色修改";
                if (RoleEdit.ShowDialog() == DialogResult.OK)
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

        private void btnDelete_Click(object sender, EventArgs e)
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
                            string strRoleid = this.gridView1.GetRowCellDisplayText(RowHandle, "ROLE_ID");
                            connection.Open();
                            OracleCommand cmd = connection.CreateCommand();
                            OracleTransaction transaction;
                            transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);
                            cmd.Transaction = transaction;
                            try
                            {
                                cmd.CommandText = "delete  from SYS_ROLE_MODULE_ACTION where roleid='" + strRoleid + "'";
                                cmd.ExecuteNonQuery();
                                cmd.CommandText = "delete  from SYS_ROLE_MODULE where role_id='" + strRoleid + "'";
                                cmd.ExecuteNonQuery();
                                cmd.CommandText = "delete  from sys_role where role_id='"+strRoleid+"'";
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

        private void btnLook_Click(object sender, EventArgs e)
        {
            if (selection.SelectedCount == 1)
            {
                int RowIndex = selection.GetSelectedRowIndex(0);
                int RowHandle = gridView1.GetRowHandle(RowIndex);
                string strRoleid = this.gridView1.GetRowCellDisplayText(RowHandle, "ROLE_ID");
                RoleEdit RoleEdit = new RoleEdit(strRoleid);
                RoleEdit.Tag = "LOOK";
                RoleEdit.Text = "角色查看";
                RoleEdit.ShowDialog();

            }
            else
            { MessageBox.Show("请选择一项进行修改"); }
            selection.ClearSelection();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            unitOfWork1.DropIdentityMap();
            xpServerCollectionSource1.Reload();
        }
    }
}
