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
    public struct structDWXX
    {
        public string strDWID;
        public string strDWBH;
        public string strDWMC;
        public string strDWJC;
        public string strZJM;
        public string strSJDWID;
        public string strDWSX;
        public string strBMLXID;
        public string strGYSLXID;
        public string strKHLXID;
        public string strKFLXID;
        public string strYINSDWLXID;
        public string strCBSLXID;
        public string strYSDWLXID;
        public string strBMZTID;
        public string strSFZT;
        public string strDWJB;
        public string strDWFR;
        public string strSFID;
        public string strDQID;
        public string strYZBM;
        public string strTXDZ;
        public string strDH;
        public string strCZ;
        public string strLXR;
        public string strKHYH;
        public string strZH;
        public string strSH;
        public string strEMAIL;
        public string strWZ;
        public string strJSFSID;
        public string strTSSX;
        public string strTSXX;
        public string strSDSX;
        public string strSDXX;
        public string strZKSX;
        public string strZKXX;
        public string strJSDWID;
        public string strDJSDBZ;
        public string strTSJSDBZ;
        public string strKHZZYFBZ;
        public string strKHZZBZFBZ;
        public string strKHZZQTFYBZ;
        public string strCGJSZQ;
        public string strTSJSZQ;
        public string strSHDZ;
        public string strKJDZ;
        public string strMJDZ;
        public string strYSFSID;
        public string strYSFXID;
        public string strZZDBZ;
        public string strYZDBH;
        public string strEZDBH;
        public string strKFDZ;
        public string strTDYZS;
        public string strDWTJBH;
        public string strCGJSYXJB;
        public string strXSJSYXJB;
        public string strPHYXJB;
        public string strXTYXJB;
        public string strJTYXJB;
        public string strCGYXJB;
        public string strWEBYH;
        public string strWEBMM;
        public string strZT;
        public string strBZ;
    }

    public partial class FrmDepartmentManagement : DevExpress.XtraEditors.XtraForm
    {
        GridCheckMarksSelection selection;

        public FrmDepartmentManagement(bool fgAdd, bool fgDel, bool fgUpdate, bool fgQuery, string strDWID = null)
        {
            XpoDefault.ConnectionString = FrmLogin.xpoDataCentStr;

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

            if (String.IsNullOrEmpty(strDWID))
            {
                xpServerCollectionSource1.FixedFilterString = "[DWID] Is Null";
            }
            else
            {
                xpServerCollectionSource1.FixedFilterString = strDWID;
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
            
            gridView1.ShowFilterEditor(colDWBH);

            if (!String.IsNullOrEmpty(gridView1.ActiveFilterString))
            {
                selection.ClearSelection();
                xpServerCollectionSource1.FixedFilterString = gridView1.ActiveFilterString; //+ " And [ZTID] = \'" + FrmLogin.getZTID + "\'";
                gridView1.BestFitColumns();
            }
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            structDWXX sDWXX = new structDWXX();

            FrmDeptChild frmAdd = new FrmDeptChild(sDWXX);
            frmAdd.Text = "增加单位";
            frmAdd.ShowDialog();

            selection.ClearSelection();
            unitOfWork1.DropIdentityMap();
            xpServerCollectionSource1.Reload();
        }

        private void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
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
                int RowIndex = selection.GetSelectedRowIndex(0);
                RowHandle = gridView1.GetRowHandle(RowIndex);

                structDWXX sDWXX = new structDWXX();
                sDWXX.strDWID = gridView1.GetRowCellDisplayText(RowHandle, colDWID);
                sDWXX.strDWBH = gridView1.GetRowCellDisplayText(RowHandle, colDWBH);
                sDWXX.strDWFR = gridView1.GetRowCellDisplayText(RowHandle, colDWFR);
                sDWXX.strDWJB = gridView1.GetRowCellDisplayText(RowHandle, colDWJB);
                sDWXX.strDWJC = gridView1.GetRowCellDisplayText(RowHandle, colDWJC);
                sDWXX.strDWMC = gridView1.GetRowCellDisplayText(RowHandle, colDWMC);
                sDWXX.strDWSX = gridView1.GetRowCellDisplayText(RowHandle, colDWSX);
                sDWXX.strDWTJBH = gridView1.GetRowCellDisplayText(RowHandle, colDWTJBH);
                sDWXX.strBMLXID = gridView1.GetRowCellDisplayText(RowHandle, colBMLXID);
                sDWXX.strBMZTID = gridView1.GetRowCellDisplayText(RowHandle, colBMZTID);
                sDWXX.strBZ = gridView1.GetRowCellDisplayText(RowHandle, colBZ);
                sDWXX.strCBSLXID = gridView1.GetRowCellDisplayText(RowHandle, colCBSLXID);
                sDWXX.strCGJSYXJB = gridView1.GetRowCellDisplayText(RowHandle, colCGJSYXJB);
                sDWXX.strCGJSZQ = gridView1.GetRowCellDisplayText(RowHandle, colCGJSZQ);
                sDWXX.strCGYXJB = gridView1.GetRowCellDisplayText(RowHandle, colCGYXJB);
                sDWXX.strCZ = gridView1.GetRowCellDisplayText(RowHandle, colCZ);
                sDWXX.strDH = gridView1.GetRowCellDisplayText(RowHandle, colDH);
                sDWXX.strDJSDBZ = gridView1.GetRowCellDisplayText(RowHandle, colDJSDBZ);
                sDWXX.strDQID = gridView1.GetRowCellDisplayText(RowHandle, colDQID);
                sDWXX.strEMAIL = gridView1.GetRowCellDisplayText(RowHandle, colEMAIL);
                sDWXX.strEZDBH = gridView1.GetRowCellDisplayText(RowHandle, colEZDBH);
                sDWXX.strGYSLXID = gridView1.GetRowCellDisplayText(RowHandle, colGYSLXID);
                sDWXX.strJSDWID = gridView1.GetRowCellDisplayText(RowHandle, colJSDWID);
                sDWXX.strJSFSID = gridView1.GetRowCellDisplayText(RowHandle, colJSFSID);
                sDWXX.strJTYXJB = gridView1.GetRowCellDisplayText(RowHandle, colJTYXJB);
                sDWXX.strKFDZ = gridView1.GetRowCellDisplayText(RowHandle, colKFDZ);
                sDWXX.strKFLXID = gridView1.GetRowCellDisplayText(RowHandle, colKFLXID);
                sDWXX.strKHLXID = gridView1.GetRowCellDisplayText(RowHandle, colKHLXID);
                sDWXX.strKHYH = gridView1.GetRowCellDisplayText(RowHandle, colKHYH);
                sDWXX.strKHZZBZFBZ = gridView1.GetRowCellDisplayText(RowHandle, colKHZZBZFBZ);
                sDWXX.strKHZZQTFYBZ = gridView1.GetRowCellDisplayText(RowHandle, colKHZZQTFYBZ);
                sDWXX.strKHZZYFBZ = gridView1.GetRowCellDisplayText(RowHandle, colKHZZYFBZ);
                sDWXX.strKJDZ = gridView1.GetRowCellDisplayText(RowHandle, colKJDZ);
                sDWXX.strLXR = gridView1.GetRowCellDisplayText(RowHandle, colLXR);
                sDWXX.strMJDZ = gridView1.GetRowCellDisplayText(RowHandle, colMJDZ);
                sDWXX.strPHYXJB = gridView1.GetRowCellDisplayText(RowHandle, colPHYXJB);
                sDWXX.strSDSX = gridView1.GetRowCellDisplayText(RowHandle, colSDSX);
                sDWXX.strSDXX = gridView1.GetRowCellDisplayText(RowHandle, colSDXX);
                sDWXX.strSFID = gridView1.GetRowCellDisplayText(RowHandle, colSFID);
                sDWXX.strSFZT = gridView1.GetRowCellDisplayText(RowHandle, colSFZT);
                sDWXX.strSH = gridView1.GetRowCellDisplayText(RowHandle, colSH);
                sDWXX.strSHDZ = gridView1.GetRowCellDisplayText(RowHandle, colSHDZ);
                sDWXX.strSJDWID = gridView1.GetRowCellDisplayText(RowHandle, colSJDWID);
                sDWXX.strTDYZS = gridView1.GetRowCellDisplayText(RowHandle, colTDYZS);
                sDWXX.strTSJSDBZ = gridView1.GetRowCellDisplayText(RowHandle, colTSJSDBZ);
                sDWXX.strTSJSZQ = gridView1.GetRowCellDisplayText(RowHandle, colTSJSZQ);
                sDWXX.strTSSX = gridView1.GetRowCellDisplayText(RowHandle, colTSSX);
                sDWXX.strTSXX = gridView1.GetRowCellDisplayText(RowHandle, colTSXX);
                sDWXX.strTXDZ = gridView1.GetRowCellDisplayText(RowHandle, colTXDZ);
                sDWXX.strWEBMM = gridView1.GetRowCellDisplayText(RowHandle, colWEBMM);
                sDWXX.strWEBYH = gridView1.GetRowCellDisplayText(RowHandle, colWEBYH);
                sDWXX.strWZ = gridView1.GetRowCellDisplayText(RowHandle, colWZ);
                sDWXX.strXSJSYXJB = gridView1.GetRowCellDisplayText(RowHandle, colXSJSYXJB);
                sDWXX.strXTYXJB = gridView1.GetRowCellDisplayText(RowHandle, colXTYXJB);
                sDWXX.strYINSDWLXID = gridView1.GetRowCellDisplayText(RowHandle, colYINSDWLXID);
                sDWXX.strYSDWLXID = gridView1.GetRowCellDisplayText(RowHandle, colYSDWLXID);
                sDWXX.strYSFSID = gridView1.GetRowCellDisplayText(RowHandle, colYSFSID);
                sDWXX.strYSFXID = gridView1.GetRowCellDisplayText(RowHandle, colYSFXID);
                sDWXX.strYZBM = gridView1.GetRowCellDisplayText(RowHandle, colYZBM);
                sDWXX.strYZDBH = gridView1.GetRowCellDisplayText(RowHandle, colYZDBH);
                sDWXX.strZH = gridView1.GetRowCellDisplayText(RowHandle, colZH);
                sDWXX.strZJM = gridView1.GetRowCellDisplayText(RowHandle, colZJM);
                sDWXX.strZKSX = gridView1.GetRowCellDisplayText(RowHandle, colZKSX);
                sDWXX.strZKXX = gridView1.GetRowCellDisplayText(RowHandle, colZKXX);
                sDWXX.strZT = gridView1.GetRowCellDisplayText(RowHandle, colZT);
                sDWXX.strZZDBZ = gridView1.GetRowCellDisplayText(RowHandle, colZZDBZ);

                FrmDeptChild frmUpdate = new FrmDeptChild(sDWXX);
                frmUpdate.Text = "修改单位";
                frmUpdate.ShowDialog();

                selection.ClearSelection();
                unitOfWork1.DropIdentityMap();
                xpServerCollectionSource1.Reload();

                gridView1.FocusedRowHandle = RowHandle;
                
            }
        }

        private void btnDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strDWID = "";

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

                    string strZT = gridView1.GetRowCellDisplayText(RowHandle, colZT);
                    if (strZT == "录入")
                    {
                        string strTemp = gridView1.GetRowCellDisplayText(RowHandle, colDWID);
                        strDWID += "\'" + strTemp + "\', ";
                    }
                    else
                    {
                        strDWID = "";
                        MessageBox.Show("非录入状态不能删除，请重新选择！");
                        break;
                    }
                }

                selection.ClearSelection();

                if (!String.IsNullOrEmpty(strDWID))
                {
                    int index = strDWID.LastIndexOf("'");
                    strDWID = strDWID.Substring(0, index + 1).Trim();

                    using (OracleConnection connection = new OracleConnection(FrmLogin.strDataCent))
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
                                string strDel = "delete from jt_j_dwxx where dwid in (" + strDWID + ")";
                                command.CommandText = strDel;

                                command.ExecuteNonQuery();

                                transaction.Commit();

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

        private void btnEnable_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strDWID = "";

            if (selection.SelectedCount == 0)
            {
                MessageBox.Show("请先选择需要启用的记录");
            }
            else
            {

                for (int i = 0; i < selection.SelectedCount; ++i)
                {
                    int RowIndex = selection.GetSelectedRowIndex(i);
                    int RowHandle = gridView1.GetRowHandle(RowIndex);

                    string strTemp = gridView1.GetRowCellDisplayText(RowHandle, colDWID);
                    strDWID += "\'" + strTemp + "\', ";
                }

                int index = strDWID.LastIndexOf("'");
                strDWID = strDWID.Substring(0, index + 1).Trim();

                using (OracleConnection connection = new OracleConnection(FrmLogin.strDataCent))
                {
                    connection.Open();
                    OracleCommand command = connection.CreateCommand();
                    OracleTransaction transaction = connection.BeginTransaction();
                    command.Connection = connection;
                    command.Transaction = transaction;

                    try
                    {
                        const string message = "确定启用吗?";
                        const string caption = "启用?";
                        var result = MessageBox.Show(message, caption,
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            string strEnable = "update jt_j_dwxx set zt = '启用', czrq = sysdate, tyr = '' where DWID in (" + strDWID + ")";
                            command.CommandText = strEnable;

                            command.ExecuteNonQuery();

                            transaction.Commit();

                            selection.ClearSelection();

                            unitOfWork1.DropIdentityMap();

                            xpServerCollectionSource1.Reload();

                            MessageBox.Show("启用成功！");
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

        private void btnDisable_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strDWID = "";

            if (selection.SelectedCount == 0)
            {
                MessageBox.Show("请先选择需要停用的记录");
            }
            else
            {

                for (int i = 0; i < selection.SelectedCount; ++i)
                {
                    int RowIndex = selection.GetSelectedRowIndex(i);
                    int RowHandle = gridView1.GetRowHandle(RowIndex);

                    string strTemp = gridView1.GetRowCellDisplayText(RowHandle, colDWID);
                    strDWID += "\'" + strTemp + "\', ";
                }

                int index = strDWID.LastIndexOf("'");
                strDWID = strDWID.Substring(0, index + 1).Trim();

                using (OracleConnection connection = new OracleConnection(FrmLogin.strDataCent))
                {
                    connection.Open();
                    OracleCommand command = connection.CreateCommand();
                    OracleTransaction transaction = connection.BeginTransaction();
                    command.Connection = connection;
                    command.Transaction = transaction;

                    try
                    {
                        const string message = "确定停用吗?";
                        const string caption = "停用?";
                        var result = MessageBox.Show(message, caption,
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            string strDisable = "update jt_j_dwxx set zt = '停用', czrq = sysdate, tyr = '" 
                                              + FrmLogin.getUserName + "' where DWID in (" + strDWID + ")";
                            command.CommandText = strDisable;

                            command.ExecuteNonQuery();

                            transaction.Commit();

                            selection.ClearSelection();

                            unitOfWork1.DropIdentityMap();

                            xpServerCollectionSource1.Reload();

                            MessageBox.Show("停用成功！");
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