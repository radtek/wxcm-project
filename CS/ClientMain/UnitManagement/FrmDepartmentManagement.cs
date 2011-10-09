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
    public partial class FrmDepartmentManagement : DevExpress.XtraEditors.XtraForm
    {
        GridCheckMarksSelection selection;

        public FrmDepartmentManagement(bool fgAdd, bool fgDel, bool fgUpdate, bool fgQuery, string strDEPARTMENTID = null)
        {
            XpoDefault.ConnectionString = FrmLogin.xpoConStr;

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

            if (String.IsNullOrEmpty(strDEPARTMENTID))
            {
                xpServerCollectionSource1.FixedFilterString = "[DEPARTMENTID] Is Null";
            }
            else
            {
                xpServerCollectionSource1.FixedFilterString = strDEPARTMENTID;
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

        private void btnQuery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            gridView1.ShowFilterEditor(colDEPARTMENTNAME);

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

                FrmDeptMtChild frmAdd = new FrmDeptMtChild(connection, transaction);
                frmAdd.Text = "增加单位";

                try
                {
                    if (frmAdd.ShowDialog() == DialogResult.OK)
                    { 
                        string strIns = "INSERT INTO SYS_DEPARTMENT (DEPARTMENTID, DEPARTMENTNAME, DESCRIPTION, ZTID, DEPARTMENTNO, SFZT, "
                              + "SJDWID, DWSX, BMLXID, KHLXID, GYSLXID, CBSLXID, YSCLXID, YSBMLXID, KFLXID, KHDNO, JCJCNO, YTHNO, DWJC, KHYH, SH, ZH, DH) "
                              + "VALUES (SEQ_SYS_DEPARTMENT_ID.nextval, :DEPARTMENTNAME, :DESCRIPTION, :ZTID, :DEPARTMENTNO, :SFZT, "
                              + ":SJDWID, :DWSX, :BMLXID, :KHLXID, :GYSLXID, :CBSLXID, :YSCLXID, :YSBMLXID, :KFLXID, :KHDNO, :JCJCNO, :YTHNO, "
                              + ":DWJC, :KHYH, :SH, :ZH, :DH)";

                        command.CommandText = strIns;
                        command.Parameters.Add(new OracleParameter("DEPARTMENTNAME", OracleType.VarChar)).Value = frmAdd.getDeptName();
                        command.Parameters.Add(new OracleParameter("DESCRIPTION", OracleType.VarChar)).Value = frmAdd.getDeptDesc();
                        command.Parameters.Add(new OracleParameter("ZTID", OracleType.VarChar)).Value = frmAdd.getZTID();
                        command.Parameters.Add(new OracleParameter("DEPARTMENTNO", OracleType.VarChar)).Value = frmAdd.getDeptNum();
                        command.Parameters.Add(new OracleParameter("SFZT", OracleType.VarChar)).Value = frmAdd.getISZT();                        
                        command.Parameters.Add(new OracleParameter("SJDWID", OracleType.VarChar)).Value = frmAdd.getSuperUnit();
                        command.Parameters.Add(new OracleParameter("DWSX", OracleType.VarChar)).Value = frmAdd.getUnitProp();
                        command.Parameters.Add(new OracleParameter("BMLXID", OracleType.VarChar)).Value = frmAdd.getDeptType();
                        command.Parameters.Add(new OracleParameter("KHLXID", OracleType.VarChar)).Value = frmAdd.getClientType();
                        command.Parameters.Add(new OracleParameter("GYSLXID", OracleType.VarChar)).Value = frmAdd.getSupType();
                        command.Parameters.Add(new OracleParameter("CBSLXID", OracleType.VarChar)).Value = frmAdd.getPressType();
                        command.Parameters.Add(new OracleParameter("YSCLXID", OracleType.VarChar)).Value = frmAdd.getFacType();
                        command.Parameters.Add(new OracleParameter("YSBMLXID", OracleType.VarChar)).Value = frmAdd.getTransType();
                        command.Parameters.Add(new OracleParameter("KFLXID", OracleType.VarChar)).Value = frmAdd.getWareType();
                        command.Parameters.Add(new OracleParameter("KHDNO", OracleType.VarChar)).Value = frmAdd.getKHDNum();
                        command.Parameters.Add(new OracleParameter("JCJCNO", OracleType.VarChar)).Value = frmAdd.getJCJCNum();
                        command.Parameters.Add(new OracleParameter("YTHNO", OracleType.VarChar)).Value = frmAdd.getYTHNum();
                        command.Parameters.Add(new OracleParameter("DWJC", OracleType.VarChar)).Value = frmAdd.getAddr();
                        command.Parameters.Add(new OracleParameter("KHYH", OracleType.VarChar)).Value = frmAdd.getBank();
                        command.Parameters.Add(new OracleParameter("SH", OracleType.VarChar)).Value = frmAdd.getTaxNum();
                        command.Parameters.Add(new OracleParameter("ZH", OracleType.VarChar)).Value = frmAdd.getAccount();
                        command.Parameters.Add(new OracleParameter("DH", OracleType.VarChar)).Value = frmAdd.getTel();

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
            string strDEPARTMENTID = "";
            string strDEPARTMENTNAME = "";
            string strDESCRIPTION = "";
            string strZTID = "";
            string strDEPARTMENTNO = "";
            string strSFZT = "";
            string strSJDWID = "";
            string strDWSX = "";
            string strBMLXID="";
            string strKHLXID="";
            string strGYSLXID="";
            string strCBSLXID="";
            string strYSCLXID="";
            string strYSBMLXID="";
            string strKFLXID="";
            string strKHDNO="";
            string strJCJCNO="";
            string strYTHNO="";
            string strDWJC="";
            string strKHYH="";
            string strSH="";
            string strZH="";
            string strDH="";

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

                    strDEPARTMENTID = gridView1.GetRowCellDisplayText(RowHandle, colDEPARTMENTID);
                    strDEPARTMENTNAME = gridView1.GetRowCellDisplayText(RowHandle, colDEPARTMENTNAME);
                    strDEPARTMENTNO = gridView1.GetRowCellDisplayText(RowHandle, colDEPARTMENTNO);
                    strDESCRIPTION = gridView1.GetRowCellDisplayText(RowHandle, colDESCRIPTION);
                    strBMLXID = gridView1.GetRowCellDisplayText(RowHandle, colBMLXID);
                    strCBSLXID = gridView1.GetRowCellDisplayText(RowHandle, colCBSLXID);
                    strDH = gridView1.GetRowCellDisplayText(RowHandle, colDH);
                    strDWJC = gridView1.GetRowCellDisplayText(RowHandle, colDWJC);
                    strDWSX = gridView1.GetRowCellDisplayText(RowHandle, colDWSX);
                    strGYSLXID = gridView1.GetRowCellDisplayText(RowHandle, colGYSLXID);
                    strZH = gridView1.GetRowCellDisplayText(RowHandle, colZH);
                    strZTID = gridView1.GetRowCellDisplayText(RowHandle, colZTID);
                    strSFZT = gridView1.GetRowCellDisplayText(RowHandle, colSFZT);
                    strSJDWID = gridView1.GetRowCellDisplayText(RowHandle, colSJDWID);
                    strKHDNO = gridView1.GetRowCellDisplayText(RowHandle, colKHDNO);
                    strKHLXID = gridView1.GetRowCellDisplayText(RowHandle, colKHLXID);
                    strYSCLXID = gridView1.GetRowCellDisplayText(RowHandle, colYSCLXID);
                    strYSBMLXID = gridView1.GetRowCellDisplayText(RowHandle, colYSBMLXID);
                    strKFLXID = gridView1.GetRowCellDisplayText(RowHandle, colKFLXID);
                    strJCJCNO = gridView1.GetRowCellDisplayText(RowHandle, colJCJCNO);
                    strYTHNO = gridView1.GetRowCellDisplayText(RowHandle, colYTHNO);
                    strKHYH = gridView1.GetRowCellDisplayText(RowHandle, colKHYH);
                    strSH = gridView1.GetRowCellDisplayText(RowHandle, colSH);
                }
                using (OracleConnection connection = new OracleConnection(FrmLogin.strCon))
                {
                    connection.Open();
                    OracleCommand command = connection.CreateCommand();
                    OracleTransaction transaction = connection.BeginTransaction();
                    command.Connection = connection;
                    command.Transaction = transaction;

                    FrmDeptMtChild frmUpdate = new FrmDeptMtChild(connection, transaction, strDEPARTMENTNAME, strDESCRIPTION, strZTID,
                                                                  strDEPARTMENTNO, strSFZT, strDWSX, strBMLXID, strKHLXID, strGYSLXID, strCBSLXID,
                                                                  strYSCLXID, strKFLXID, strYSBMLXID, strSJDWID, strKHDNO, strJCJCNO, strYTHNO,
                                                                  strSH, strKHYH, strZH, strDWJC, strDH);
                    frmUpdate.Text = "修改单位";

                    try
                    {
                        if (frmUpdate.ShowDialog() == DialogResult.OK)
                        {
                            string strUpdate = "update SYS_DEPARTMENT set DEPARTMENTNAME = :DEPARTMENTNAME, DESCRIPTION = :DESCRIPTION, "
                                             + "ZTID = :ZTID, DEPARTMENTNO = :DEPARTMENTNO, SFZT = :SFZT, SJDWID = :SJDWID, DWSX = :DWSX, "
                                             + "BMLXID = :BMLXID, KHLXID = :KHLXID, GYSLXID = :GYSLXID, CBSLXID = :CBSLXID, YSCLXID = :YSCLXID,"
                                             + "YSBMLXID = :YSBMLXID, KFLXID = :KFLXID, KHDNO = :KHDNO, JCJCNO = :JCJCNO, YTHNO = :YTHNO,"
                                             + "DWJC = :DWJC, KHYH = :KHYH, SH = :SH, ZH = :ZH, DH = :DH "
                                             + "where DEPARTMENTID = '" + strDEPARTMENTID + "'";

                            command.CommandText = strUpdate;
                            command.Parameters.Add(new OracleParameter("DEPARTMENTNAME", OracleType.VarChar)).Value = frmUpdate.getDeptName();
                            command.Parameters.Add(new OracleParameter("DESCRIPTION", OracleType.VarChar)).Value = frmUpdate.getDeptDesc();
                            command.Parameters.Add(new OracleParameter("ZTID", OracleType.VarChar)).Value = frmUpdate.getZTID();
                            command.Parameters.Add(new OracleParameter("DEPARTMENTNO", OracleType.VarChar)).Value = frmUpdate.getDeptNum();
                            command.Parameters.Add(new OracleParameter("SFZT", OracleType.VarChar)).Value = frmUpdate.getISZT();
                            command.Parameters.Add(new OracleParameter("SJDWID", OracleType.VarChar)).Value = frmUpdate.getSuperUnit();
                            command.Parameters.Add(new OracleParameter("DWSX", OracleType.VarChar)).Value = frmUpdate.getUnitProp();
                            command.Parameters.Add(new OracleParameter("BMLXID", OracleType.VarChar)).Value = frmUpdate.getDeptType();
                            command.Parameters.Add(new OracleParameter("KHLXID", OracleType.VarChar)).Value = frmUpdate.getClientType();
                            command.Parameters.Add(new OracleParameter("GYSLXID", OracleType.VarChar)).Value = frmUpdate.getSupType();
                            command.Parameters.Add(new OracleParameter("CBSLXID", OracleType.VarChar)).Value = frmUpdate.getPressType();
                            command.Parameters.Add(new OracleParameter("YSCLXID", OracleType.VarChar)).Value = frmUpdate.getFacType();
                            command.Parameters.Add(new OracleParameter("YSBMLXID", OracleType.VarChar)).Value = frmUpdate.getTransType();
                            command.Parameters.Add(new OracleParameter("KFLXID", OracleType.VarChar)).Value = frmUpdate.getWareType();
                            command.Parameters.Add(new OracleParameter("KHDNO", OracleType.VarChar)).Value = frmUpdate.getKHDNum();
                            command.Parameters.Add(new OracleParameter("JCJCNO", OracleType.VarChar)).Value = frmUpdate.getJCJCNum();
                            command.Parameters.Add(new OracleParameter("YTHNO", OracleType.VarChar)).Value = frmUpdate.getYTHNum();
                            command.Parameters.Add(new OracleParameter("DWJC", OracleType.VarChar)).Value = frmUpdate.getAddr();
                            command.Parameters.Add(new OracleParameter("KHYH", OracleType.VarChar)).Value = frmUpdate.getBank();
                            command.Parameters.Add(new OracleParameter("SH", OracleType.VarChar)).Value = frmUpdate.getTaxNum();
                            command.Parameters.Add(new OracleParameter("ZH", OracleType.VarChar)).Value = frmUpdate.getAccount();
                            command.Parameters.Add(new OracleParameter("DH", OracleType.VarChar)).Value = frmUpdate.getTel();

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
            string strDEPARTMENTID = "";

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

                    string strTemp = gridView1.GetRowCellDisplayText(RowHandle, colDEPARTMENTID);
                    strDEPARTMENTID += "\'" + strTemp + "\', ";
                }

                int index = strDEPARTMENTID.LastIndexOf("'");
                strDEPARTMENTID = strDEPARTMENTID.Substring(0, index + 1).Trim();

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
                            string strDel = "delete from SYS_DEPARTMENT where DEPARTMENTID in (" + strDEPARTMENTID + ")";
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