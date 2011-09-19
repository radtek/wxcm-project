using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System.IO;
using System.Data.OracleClient;

namespace ClientMain
{
    public partial class FrmClientTypeMt : DevExpress.XtraEditors.XtraForm
    {
        GridCheckMarksSelection selection;

        public FrmClientTypeMt(bool fgAdd, bool fgDel, bool fgUpdate, bool fgQuery, string strKHLXID = null)
        {
            XpoDefault.ConnectionString = OracleConnectionProvider.GetConnectionString("XINHUA", "xxb", "pass");

            InitializeComponent();

            if (fgAdd)
            {
                btnAdd.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else
            {
                btnAdd.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            if (fgDel)
            {
                btnDel.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else
            {
                btnDel.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            if (fgUpdate)
            {
                btnUpdate.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else
            {
                btnUpdate.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            if (fgQuery)
            {
                btnQuery.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else
            {
                btnQuery.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }

            if (String.IsNullOrEmpty(strKHLXID))
            {
                xpServerCollectionSource1.FixedFilterString = "[KHLXID] Is Null";
            }
            else
            {
                xpServerCollectionSource1.FixedFilterString = strKHLXID;
            }

            selection = new GridCheckMarksSelection(gridView1);
            selection.CheckMarkColumn.VisibleIndex = 0;

            gridView1.BestFitColumns();
        }

        private void gridView1_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator & e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString().Trim();
            }
        }

        private void gridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column == colZT)
            {
                if (e.Value.ToString() == "0")
                {
                    e.DisplayText = "录入";
                }
                else if (e.Value.ToString() == "1")
                {
                    e.DisplayText = "启用";
                }
                else if (e.Value.ToString() == "2")
                {
                    e.DisplayText = "停用";
                }
            }
        }

        private void btnQuery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            gridView1.ShowFilterEditor(gridView1.FocusedColumn);

            if (!String.IsNullOrEmpty(gridView1.ActiveFilterString))
            {
                selection.ClearSelection();
                xpServerCollectionSource1.FixedFilterString = gridView1.ActiveFilterString;
                gridView1.BestFitColumns();
            }
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            selection.ClearSelection();

            using (OracleConnection connection = new OracleConnection(FrmLogin.strCon))
            {
                connection.Open();
                OracleCommand command = connection.CreateCommand();
                OracleTransaction transaction = connection.BeginTransaction();
                command.Connection = connection;
                command.Transaction = transaction;

                FrmDeptTypeMtChild frmAdd = new FrmDeptTypeMtChild();
                frmAdd.Text = "增加客户类型";
                frmAdd.lbName.Text = "客户类型";

                try
                {
                    if (frmAdd.ShowDialog() == DialogResult.OK)
                    {
                        string strIns = "INSERT INTO JT_J_KHLX (KHLXID, KHLXBH, KHLXMC, ZT) VALUES (JT_J_KHLX_SEQ.nextval, :KHLXBH, :KHLXMC, :ZT)";

                        command.CommandText = strIns;
                        command.Parameters.Add(new OracleParameter("KHLXBH", OracleType.VarChar)).Value = frmAdd.getNum();
                        command.Parameters.Add(new OracleParameter("KHLXMC", OracleType.VarChar)).Value = frmAdd.getName();
                        command.Parameters.Add(new OracleParameter("ZT", OracleType.VarChar)).Value = frmAdd.getStatus();                        

                        command.ExecuteNonQuery();

                        transaction.Commit();

                        unitOfWork1.DropIdentityMap();

                        xpServerCollectionSource1.Reload();

                        MessageBox.Show("增加成功！");
                    }
                }
                catch (Exception exception)
                {
                    transaction.Rollback();
                    MessageBox.Show(exception.ToString());
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strKHLXID = "";
            string strKHLXBH = "";
            string strKHLXMC = "";
            string strZT = "";            

            int RowHandle = 0;
            if (selection.SelectedCount == 0)
            {
                MessageBox.Show("请先选择需要修改的记录");
            }
            else if (selection.SelectedCount > 1)
            {
                MessageBox.Show("一次只能修改一条记录，请重新选择！");
            }
            else
            {
                for (int i = 0; i < selection.SelectedCount; ++i)
                {
                    int RowIndex = selection.GetSelectedRowIndex(i);
                    RowHandle = gridView1.GetRowHandle(RowIndex);

                    strKHLXID = gridView1.GetRowCellDisplayText(RowHandle, colKHLXID);
                    strKHLXBH = gridView1.GetRowCellDisplayText(RowHandle, colKHLXBH);
                    strKHLXMC = gridView1.GetRowCellDisplayText(RowHandle, colKHLXMC);
                    strZT = gridView1.GetRowCellDisplayText(RowHandle, colZT);
                    
                }
                using (OracleConnection connection = new OracleConnection(FrmLogin.strCon))
                {
                    connection.Open();
                    OracleCommand command = connection.CreateCommand();
                    OracleTransaction transaction = connection.BeginTransaction();
                    command.Connection = connection;
                    command.Transaction = transaction;

                    FrmDeptTypeMtChild frmUpdate = new FrmDeptTypeMtChild(strKHLXMC, strKHLXBH, strZT);
                    frmUpdate.Text = "修改客户类型";
                    frmUpdate.lbName.Text = "客户类型";

                    try
                    {
                        if (frmUpdate.ShowDialog() == DialogResult.OK)
                        {
                            string strUpdate = "update JT_J_KHLX set KHLXBH = :KHLXBH, KHLXMC = :KHLXMC, ZT = :ZT where KHLXID = '" + strKHLXID + "'";                                             

                            command.CommandText = strUpdate;
                            command.Parameters.Add(new OracleParameter("KHLXMC", OracleType.VarChar)).Value = frmUpdate.getName();
                            command.Parameters.Add(new OracleParameter("KHLXBH", OracleType.VarChar)).Value = frmUpdate.getNum();
                            command.Parameters.Add(new OracleParameter("ZT", OracleType.VarChar)).Value = frmUpdate.getStatus();
                           
                            command.ExecuteNonQuery();

                            transaction.Commit();

                            selection.ClearSelection();

                            unitOfWork1.DropIdentityMap();

                            xpServerCollectionSource1.Reload();

                            MessageBox.Show("修改成功！");

                            gridView1.FocusedRowHandle = RowHandle;
                        }
                    }
                    catch (Exception exception)
                    {
                        transaction.Rollback();
                        MessageBox.Show(exception.ToString());
                    }
                    finally
                    {
                        connection.Close();
                    }

                }
            }
        }

        private void btnDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strKHLXID = "";

            if (selection.SelectedCount == 0)
            {
                MessageBox.Show("请先选择需要删除的记录");
            }
            else
            {

                for (int i = 0; i < selection.SelectedCount; ++i)
                {
                    int RowIndex = selection.GetSelectedRowIndex(i);
                    int RowHandle = gridView1.GetRowHandle(RowIndex);

                    string strTemp = gridView1.GetRowCellDisplayText(RowHandle, colKHLXID);
                    strKHLXID += "\'" + strTemp + "\', ";
                }

                int index = strKHLXID.LastIndexOf("'");
                strKHLXID = strKHLXID.Substring(0, index + 1).Trim();

                using (OracleConnection connection = new OracleConnection(FrmLogin.strCon))
                {
                    connection.Open();
                    OracleCommand command = connection.CreateCommand();
                    OracleTransaction transaction = connection.BeginTransaction();
                    command.Connection = connection;
                    command.Transaction = transaction;

                    try
                    {
                        const string message = "确定删除吗?";
                        const string caption = "删除?";
                        var result = MessageBox.Show(message, caption,
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            string strDel = "delete from JT_J_KHLX where KHLXID in (" + strKHLXID + ")";
                            command.CommandText = strDel;

                            command.ExecuteNonQuery();

                            transaction.Commit();

                            selection.ClearSelection();

                            unitOfWork1.DropIdentityMap();

                            xpServerCollectionSource1.Reload();

                            MessageBox.Show("删除成功！");
                        }
                    }
                    catch (Exception exception)
                    {
                        transaction.Rollback();
                        MessageBox.Show(exception.ToString());
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }
    }
}