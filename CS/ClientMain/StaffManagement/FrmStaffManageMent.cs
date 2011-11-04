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
    public struct structStaff
    {
        public string strOPERATORID;
        public string strOPERATORNAME;
        public string strOPERATORNO;
        public string strFASTCODE;
        public string strSEX;
        public string strBIRTHDAY;
        public string strEMAIL;
        public string strCONTACTADDRESS;
        public string strTELEPHONE;
        public string strMOBILETELEPHONE;
        public string strDEPARTID;
    }


    public partial class FrmStaffManageMent : DevExpress.XtraEditors.XtraForm
    {
        GridCheckMarksSelection selection;

        public FrmStaffManageMent(bool fgAdd, bool fgDel, bool fgUpdate, bool fgQuery, string strOPERATORID = null)
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

            if (String.IsNullOrEmpty(strOPERATORID))
            {
                xpServerCollectionSource1.FixedFilterString = "[OPERATORID] Is Null";
            }
            else
            {
                xpServerCollectionSource1.FixedFilterString = strOPERATORID;
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
            
            gridView1.ShowFilterEditor(colOPERATORNAME);

            if (!String.IsNullOrEmpty(gridView1.ActiveFilterString))
            {
                selection.ClearSelection();
                xpServerCollectionSource1.FixedFilterString = gridView1.ActiveFilterString; //+ " And [ZTID] = \'" + FrmLogin.getZTID + "\'";
                gridView1.BestFitColumns();
            }
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            structStaff sStaff = new structStaff();

            FrmStaffMtChild frmAdd = new FrmStaffMtChild(sStaff);
            frmAdd.Text = "增加员工";
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

                structStaff sStaff = new structStaff();
                sStaff.strOPERATORID = gridView1.GetRowCellDisplayText(RowHandle, colOPERATORID);
                sStaff.strOPERATORNO = gridView1.GetRowCellDisplayText(RowHandle, colOPERATORNO);
                sStaff.strOPERATORNAME = gridView1.GetRowCellDisplayText(RowHandle, colOPERATORNAME);
                sStaff.strFASTCODE = gridView1.GetRowCellDisplayText(RowHandle, colFASTCODE);
                sStaff.strSEX = gridView1.GetRowCellDisplayText(RowHandle, colSEX);
                sStaff.strDEPARTID = gridView1.GetRowCellDisplayText(RowHandle, colDEPARTID);
                sStaff.strBIRTHDAY = gridView1.GetRowCellDisplayText(RowHandle, colBIRTHDAY);
                sStaff.strTELEPHONE = gridView1.GetRowCellDisplayText(RowHandle, colTELEPHONE);
                sStaff.strCONTACTADDRESS = gridView1.GetRowCellDisplayText(RowHandle, colCONTACTADDRESS);
                sStaff.strMOBILETELEPHONE = gridView1.GetRowCellDisplayText(RowHandle, colMOBILETELEPHONE);
                sStaff.strEMAIL = gridView1.GetRowCellDisplayText(RowHandle, colEMAIL);

                FrmStaffMtChild frmUpdate = new FrmStaffMtChild(sStaff);
                frmUpdate.Text = "修改员工";                
                frmUpdate.ShowDialog();

                selection.ClearSelection();
                unitOfWork1.DropIdentityMap();
                xpServerCollectionSource1.Reload();

                gridView1.FocusedRowHandle = RowHandle;
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

                    string strTemp = gridView1.GetRowCellDisplayText(RowHandle, colOPERATORID);
                    strEMPLOYEEID += "\'" + strTemp + "\', ";
                }

                int index = strEMPLOYEEID.LastIndexOf("'");
                strEMPLOYEEID = strEMPLOYEEID.Substring(0, index + 1).Trim();

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
                            string strDel = "delete from BASE_OPERATOR where OPERATORID in (" + strEMPLOYEEID + ")";
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