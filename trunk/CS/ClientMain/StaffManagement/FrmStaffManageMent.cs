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
    public partial class FrmStaffManageMent : DevExpress.XtraEditors.XtraForm
    {
        GridCheckMarksSelection selection;

        public FrmStaffManageMent(bool fgAdd, bool fgDel, bool fgUpdate, bool fgQuery, string strEMPLOYEEID = null)
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

            if (String.IsNullOrEmpty(strEMPLOYEEID))
            {
                xpServerCollectionSource1.FixedFilterString = "[EMPLOYEEID] Is Null";
            }
            else
            {
                xpServerCollectionSource1.FixedFilterString = strEMPLOYEEID;
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
            if (e.Column == colSEX)
            {
                if (e.Value.ToString() == "0")
                {
                    e.DisplayText = "女";
                }
                else if (e.Value.ToString() == "1")
                {
                    e.DisplayText = "男";
                }
            }
        }

        private void btnQuery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            gridView1.ShowFilterEditor(gridView1.FocusedColumn);

            if (!String.IsNullOrEmpty(gridView1.ActiveFilterString))
            {
                selection.ClearSelection();
                xpServerCollectionSource1.FixedFilterString = gridView1.ActiveFilterString; //+ " And [ZTID] = \'" + FrmLogin.getZTID + "\'";
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

                FrmStaffMtChild frmAdd = new FrmStaffMtChild(connection, transaction);
                frmAdd.Text = "增加员工";

                try
                {
                    if (frmAdd.ShowDialog() == DialogResult.OK)
                    {
                        string strIns = "INSERT INTO SYS_EMPLOYEES (EMPLOYEEID, NAME, EMPLOYEENO, FASTCODE, SEX, BIRTHDAY, EMAIL, TXDZ, TELEPHONE, "
                                      + "MOBILETELEPHONE, SJDWID) VALUES (seq_sys_employees_employeeid.nextval, :NAME, :EMPLOYEENO, :FASTCODE, :SEX, "
                                      + ":BIRTHDAY, :EMAIL, :TXDZ, :TELEPHONE, :MOBILETELEPHONE, :SJDWID)";

                        command.CommandText = strIns;
                        command.Parameters.Add(new OracleParameter("NAME", OracleType.VarChar)).Value = frmAdd.getName();
                        command.Parameters.Add(new OracleParameter("EMPLOYEENO", OracleType.VarChar)).Value = frmAdd.getNum();
                        command.Parameters.Add(new OracleParameter("FASTCODE", OracleType.VarChar)).Value = frmAdd.getFastCode();
                        command.Parameters.Add(new OracleParameter("SEX", OracleType.VarChar)).Value = frmAdd.getGender();
                        command.Parameters.Add(new OracleParameter("BIRTHDAY", OracleType.DateTime)).Value = frmAdd.getBirth();
                        command.Parameters.Add(new OracleParameter("EMAIL", OracleType.VarChar)).Value = frmAdd.getEmail();
                        command.Parameters.Add(new OracleParameter("TXDZ", OracleType.VarChar)).Value = frmAdd.getAddress();
                        command.Parameters.Add(new OracleParameter("TELEPHONE", OracleType.VarChar)).Value = frmAdd.getTel();
                        command.Parameters.Add(new OracleParameter("MOBILETELEPHONE", OracleType.VarChar)).Value = frmAdd.getMobile();
                        command.Parameters.Add(new OracleParameter("SJDWID", OracleType.VarChar)).Value = frmAdd.getSuperUnit();

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
            string strEMPLOYEEID = "";
            string strNAME = "";
            string strEMPLOYEENO = "";
            string strFASTCODE = "";
            string strSEX = "";
            string strBIRTHDAY = "";
            string strEMAIL = "";
            string strTXDZ = "";
            string strTELEPHONE = "";
            string strMOBILETELEPHONE = "";
            string strSJDWID = "";

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

                    strEMPLOYEEID = gridView1.GetRowCellDisplayText(RowHandle, colEMPLOYEEID);
                    strEMPLOYEENO = gridView1.GetRowCellDisplayText(RowHandle, colEMPLOYEENO);
                    strNAME = gridView1.GetRowCellDisplayText(RowHandle, colNAME);
                    strFASTCODE = gridView1.GetRowCellDisplayText(RowHandle, colFASTCODE);
                    strSEX = gridView1.GetRowCellDisplayText(RowHandle, colSEX);
                    strSJDWID = gridView1.GetRowCellDisplayText(RowHandle, colSJDWID);
                    strBIRTHDAY = gridView1.GetRowCellDisplayText(RowHandle, colBIRTHDAY);
                    strTELEPHONE = gridView1.GetRowCellDisplayText(RowHandle, colTELEPHONE);
                    strTXDZ = gridView1.GetRowCellDisplayText(RowHandle, colTXDZ);
                    strMOBILETELEPHONE = gridView1.GetRowCellDisplayText(RowHandle, colMOBILETELEPHONE);
                    strEMAIL = gridView1.GetRowCellDisplayText(RowHandle, colEMAIL);
                }
                using (OracleConnection connection = new OracleConnection(FrmLogin.strCon))
                {
                    connection.Open();
                    OracleCommand command = connection.CreateCommand();
                    OracleTransaction transaction = connection.BeginTransaction();
                    command.Connection = connection;
                    command.Transaction = transaction;

                    FrmStaffMtChild frmUpdate = new FrmStaffMtChild(connection, transaction, strEMPLOYEENO, strNAME, strFASTCODE,
                                                                    strSEX, strBIRTHDAY, strEMAIL, strTXDZ, strTELEPHONE, 
                                                                    strMOBILETELEPHONE, strSJDWID);
                    frmUpdate.Text = "修改员工";

                    try
                    {
                        if (frmUpdate.ShowDialog() == DialogResult.OK)
                        {
                            string strUpdate = "update SYS_EMPLOYEES set EMPLOYEENO = :EMPLOYEENO, NAME = :NAME, "
                                             + "FASTCODE = :FASTCODE, SEX = :SEX, BIRTHDAY = :BIRTHDAY, EMAIL = :EMAIL, TXDZ = :TXDZ, "
                                             + "TELEPHONE = :TELEPHONE, MOBILETELEPHONE = :MOBILETELEPHONE, SJDWID = :SJDWID "
                                             + "where EMPLOYEEID = '" + strEMPLOYEEID + "'";

                            command.CommandText = strUpdate;
                            command.Parameters.Add(new OracleParameter("NAME", OracleType.VarChar)).Value = frmUpdate.getName();
                            command.Parameters.Add(new OracleParameter("EMPLOYEENO", OracleType.VarChar)).Value = frmUpdate.getNum();
                            command.Parameters.Add(new OracleParameter("FASTCODE", OracleType.VarChar)).Value = frmUpdate.getFastCode();
                            command.Parameters.Add(new OracleParameter("SEX", OracleType.VarChar)).Value = frmUpdate.getGender();
                            command.Parameters.Add(new OracleParameter("BIRTHDAY", OracleType.DateTime)).Value = frmUpdate.getBirth();
                            command.Parameters.Add(new OracleParameter("EMAIL", OracleType.VarChar)).Value = frmUpdate.getEmail();
                            command.Parameters.Add(new OracleParameter("TXDZ", OracleType.VarChar)).Value = frmUpdate.getAddress();
                            command.Parameters.Add(new OracleParameter("TELEPHONE", OracleType.VarChar)).Value = frmUpdate.getTel();
                            command.Parameters.Add(new OracleParameter("MOBILETELEPHONE", OracleType.VarChar)).Value = frmUpdate.getMobile();
                            command.Parameters.Add(new OracleParameter("SJDWID", OracleType.VarChar)).Value = frmUpdate.getSuperUnit();

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
            string strEMPLOYEEID = "";

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

                    string strTemp = gridView1.GetRowCellDisplayText(RowHandle, colEMPLOYEEID);
                    strEMPLOYEEID += "\'" + strTemp + "\', ";
                }

                int index = strEMPLOYEEID.LastIndexOf("'");
                strEMPLOYEEID = strEMPLOYEEID.Substring(0, index + 1).Trim();

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
                            string strDel = "delete from SYS_EMPLOYEES where EMPLOYEEID in (" + strEMPLOYEEID + ")";
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