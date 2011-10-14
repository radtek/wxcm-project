using System;
using System.Collections.Generic;
using System.Collections;
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
    public partial class FrmProfitLossNote : DevExpress.XtraEditors.XtraForm
    {
        

        GridCheckMarksSelection selection;

        double dZMY = 0;
        double dZSY = 0;
        Int64 i8ZPZ = 0;
        Int64 i8ZSL = 0;


        public FrmProfitLossNote(string strSYDID=null)
        {
            XpoDefault.ConnectionString = FrmLogin.xpoDataCentStr;

            InitializeComponent();

            if (String.IsNullOrEmpty(strSYDID))
            {
                xpServerCollectionSource1.FixedFilterString = "[SYDID] Is Null";
            }
            else
            {
                xpServerCollectionSource1.FixedFilterString = strSYDID;
            }

            selection = new GridCheckMarksSelection(gridView1);
            selection.CheckMarkColumn.VisibleIndex = 0;

            gridView1.BestFitColumns();
        }

        private void gridView1_CustomDrawFooterCell(object sender, FooterCellCustomDrawEventArgs e)
        {
            FrmLogin.vDrawFootCell(e, colSTATUSMC, "选计：");
            FrmLogin.vDrawFootCell(e, colZSY, dZSY.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colZMY, dZMY.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colZSL, i8ZSL.ToString());
            FrmLogin.vDrawFootCell(e, colZPZ, i8ZPZ.ToString());
        }

        private void gridView1_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator & e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString().Trim();
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));
            if (hitInfo.HitTest == GridHitTest.RowCell)
            {
                if ((hitInfo.Column != null) && (hitInfo.Column == colSYDH))
                {
                    string strTemp = view.GetRowCellDisplayText(hitInfo.RowHandle, colSYDID);
                    string strSYDID = "[SYDID] = \'" + strTemp + "\'";
                    if (fc["FrmProfitLossDetail"] != null)
                    {
                        fc["FrmProfitLossDetail"].Close();
                    }
                    FrmProfitLossDetail FrmPLD = new FrmProfitLossDetail(strSYDID);
                    FrmPLD.Show();
                    FrmPLD.Activate();
                }
                else if ((hitInfo.Column != null) && (hitInfo.Column == colPZH))
                {
                    string strTemp = view.GetRowCellDisplayText(hitInfo.RowHandle, colPZID);
                    string strPZH = view.GetRowCellDisplayText(hitInfo.RowHandle, colPZH);
                    if (!String.IsNullOrEmpty(strPZH))
                    {
                        string strPZID = "[VOUCHERID] = \'" + strTemp + "\'";
                        //if (fc["FrmPurchaseReceiveTotal"] != null)
                        //{
                        //    fc["FrmPurchaseReceiveTotal"].Close();
                        //}
                        //FrmPurchaseReceiveTotal FrmPRT = new FrmPurchaseReceiveTotal(strSHHZDID);
                        //FrmPRT.Show();
                        //FrmPRT.Activate();
                    }
                }
            }
        }

        private void gridView1_MouseUp(object sender, MouseEventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));
            if ((hitInfo.Column != null) && (hitInfo.Column.GetCaption() == "选择"))
            {
                if (hitInfo.InColumn)
                {
                    if (selection.SelectedCount == view.DataRowCount)
                    {
                        double.TryParse(colZSY.SummaryText, out dZSY);
                        double.TryParse(colZMY.SummaryText, out dZMY);
                        Int64.TryParse(colZSL.SummaryText, out i8ZSL);
                        Int64.TryParse(colZPZ.SummaryText, out i8ZPZ);
                    }
                    else
                    {
                        dZMY = 0;
                        dZSY = 0;
                        i8ZSL = 0;
                        i8ZPZ = 0;
                    }

                }
                if (hitInfo.InRowCell)
                {
                    if (selection.IsRowSelected(hitInfo.RowHandle))
                    {
                        dZMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZMY));
                        dZSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZSY));
                        i8ZSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colZSL));
                        i8ZPZ += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colZPZ));
                    }
                    else
                    {
                        dZMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZMY));
                        dZSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZSY));
                        i8ZSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colZSL));
                        i8ZPZ -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colZPZ));
                    }
                }
            }
        }


        private void vClearSelectSummary()
        {
            dZMY = 0;
            dZSY = 0;
            i8ZSL = 0;
            i8ZPZ = 0;
        }

        private void btnMasterQuery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
            gridView1.ShowFilterEditor(colSYDH);

            if (!String.IsNullOrEmpty(gridView1.ActiveFilterString))
            {
                selection.ClearSelection();
                vClearSelectSummary();

                xpServerCollectionSource1.FixedFilterString = gridView1.ActiveFilterString + " And [ZTID] = \'" + FrmLogin.getZTID + "\'";
                gridView1.BestFitColumns();
            }
        }

        private void btnDetailQuery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (selection.SelectedCount == 0)
            {
                const string message = "没有勾选主单进行的详单查询时间会比较久（3分钟左右），继续么？";
                const string caption = "详单查询?";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    FrmProfitLossDetail FrmPLD = new FrmProfitLossDetail();
                    FrmPLD.Show();
                    FrmPLD.Activate();
                }

            }
            else
            {
                string strSYDID = null;
                for (int i = 0; i < selection.SelectedCount; ++i)
                {
                    int RowIndex = selection.GetSelectedRowIndex(i);
                    int RowHandle = gridView1.GetRowHandle(RowIndex);

                    string strTemp = gridView1.GetRowCellDisplayText(RowHandle, colSYDID);
                    strSYDID += "[SYDID] = \'" + strTemp + "\' Or ";
                }

                int index = strSYDID.LastIndexOf("'");
                strSYDID = strSYDID.Substring(0, index + 1).Trim();

                FrmProfitLossDetail FrmPLD = new FrmProfitLossDetail(strSYDID);
                FrmPLD.Show();
                FrmPLD.Activate();
            }
        }

        private void btnConfirm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strSYDID = "";
            if (selection.SelectedCount == 0)
            {
                MessageBox.Show("请先选择需要确认的记录");
            }
            else
            {
                for (int i = 0; i < selection.SelectedCount; ++i)
                {
                    int RowIndex = selection.GetSelectedRowIndex(i);
                    int RowHandle = gridView1.GetRowHandle(RowIndex);

                    string strZT = gridView1.GetRowCellValue(RowHandle, colZT).ToString();

                    if (strZT == "02")
                    {
                        string strTemp = gridView1.GetRowCellDisplayText(RowHandle, colSYDID);
                        strSYDID += "\'" + strTemp + "\', ";
                    }
                    else
                    {
                        strSYDID = "";
                        MessageBox.Show("所选记录已被确认，请重新选择！");
                        break;
                    }

                }

                selection.ClearSelection();
                vClearSelectSummary();
                if (!String.IsNullOrEmpty(strSYDID))
                {
                    using (OracleConnection connection = new OracleConnection(FrmLogin.strDataCent))
                    {
                        connection.Open();
                        OracleCommand command = connection.CreateCommand();
                        OracleTransaction transaction = connection.BeginTransaction();
                        command.Connection = connection;
                        command.Transaction = transaction;

                        int index = strSYDID.LastIndexOf("'");
                        strSYDID = strSYDID.Substring(0, index + 1).Trim();

                        try
                        {
                            string strSQL = "update jt_c_syd set zt = '15', czrq = sysdate where SYDID in (" + strSYDID + ")";
                            command.CommandText = strSQL;

                            command.ExecuteNonQuery();
                            transaction.Commit();

                            unitOfWork1.DropIdentityMap();
                            xpServerCollectionSource1.Reload();
                            MessageBox.Show("所选记录已确认成功");
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

        private void btnVoucher_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            if (selection.SelectedCount == 0)
            {
                MessageBox.Show("请先选择需要产生收货凭证的记录");
            }
            else
            {
                using (OracleConnection connection = new OracleConnection(FrmLogin.strDataCent))
                {
                    connection.Open();

                    
                    //// Start a local transaction
                    //transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);
                    //// Assign transaction object for a pending local transaction
                    //command.Transaction = transaction;

                    try
                    {
                        const string message = "确定产生凭证吗?";
                        const string caption = "产生凭证?";
                        var result = MessageBox.Show(message, caption,
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {                           
                            ArrayList alBFPZ = new ArrayList();
                            ArrayList alPDYKPZ = new ArrayList();

                            for (int i = 0; i < selection.SelectedCount; ++i)
                            {
                                int RowIndex = selection.GetSelectedRowIndex(i);
                                int RowHandle = gridView1.GetRowHandle(RowIndex);

                                int i4Status = Convert.ToInt32(gridView1.GetRowCellDisplayText(RowHandle, colZT));
                                if (i4Status < 15)
                                {
                                    alBFPZ.Clear();
                                    alPDYKPZ.Clear();
                                    MessageBox.Show("所选记录未被审核，请重新选择！");
                                    break;
                                }

                                string strSYDID = gridView1.GetRowCellDisplayText(RowHandle, colSYDID);
                                string strSYLXMC = gridView1.GetRowCellDisplayText(RowHandle, colSYLXMC);
                                if (String.Equals(strSYLXMC, "报废"))
                                {
                                    alBFPZ.Add(strSYDID);
                                }
                                else
                                {
                                    alPDYKPZ.Add(strSYDID);                                
                                }
                            }

                            selection.ClearSelection();
                            vClearSelectSummary();

                            if (alBFPZ.Count > 0)
                            {
                                OracleCommand cmdBFPZ = connection.CreateCommand();
                                // Start a local transaction
                                OracleTransaction transBFPZ = connection.BeginTransaction(IsolationLevel.ReadCommitted);
                                // Assign transaction object for a pending local transaction
                                cmdBFPZ.Transaction = transBFPZ;

                                for (int i = 0; i < alBFPZ.Count; ++i)
                                {
                                    cmdBFPZ.CommandText = "INSERT INTO TEMP_SAVE_ID(TEMPID, ID) Values ('" + i.ToString() + "','" + alBFPZ[i].ToString() + "')";
                                    cmdBFPZ.ExecuteNonQuery();
                                }
                                cmdBFPZ.CommandType = CommandType.StoredProcedure;
                                cmdBFPZ.CommandText = "JT_C_SYD_TO_BFPZ";

                                cmdBFPZ.Parameters.Add("Userid", OracleType.VarChar).Value = FrmLogin.getUserID;

                                cmdBFPZ.Parameters.Add("Departmentid", OracleType.VarChar).Value = FrmLogin.getDeptID;
                                cmdBFPZ.Parameters.Add("Ls_Ztid", OracleType.VarChar).Value = FrmLogin.getZTID;

                                cmdBFPZ.Parameters.Add("Descerr", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
                                cmdBFPZ.Parameters.Add("Message", OracleType.VarChar, 255).Direction = ParameterDirection.Output;

                                cmdBFPZ.ExecuteNonQuery();
                                transBFPZ.Commit();

                                unitOfWork1.DropIdentityMap();

                                xpServerCollectionSource1.Reload();

                                alBFPZ.Clear();

                                MessageBox.Show(cmdBFPZ.Parameters["Message"].Value.ToString());
                            }

                            if (alPDYKPZ.Count > 0)
                            {
                                OracleCommand cmdPDYKPZ = connection.CreateCommand();
                                // Start a local transaction
                                OracleTransaction transPDYKPZ = connection.BeginTransaction(IsolationLevel.ReadCommitted);
                                // Assign transaction object for a pending local transaction
                                cmdPDYKPZ.Transaction = transPDYKPZ;

                                for (int i = 0; i < alPDYKPZ.Count; ++i)
                                {                                    
                                    cmdPDYKPZ.CommandText = "INSERT INTO TEMP_SAVE_ID(TEMPID, ID) Values ('" + i.ToString() + "','" + alPDYKPZ[i].ToString() + "')";
                                    cmdPDYKPZ.ExecuteNonQuery();
                                }

                                cmdPDYKPZ.CommandType = CommandType.StoredProcedure;
                                cmdPDYKPZ.CommandText = "JT_C_SYD_TO_PDYKPZ";

                                cmdPDYKPZ.Parameters.Add("Userid", OracleType.VarChar).Value = FrmLogin.getUserID;

                                cmdPDYKPZ.Parameters.Add("Departmentid", OracleType.VarChar).Value = FrmLogin.getDeptID;
                                cmdPDYKPZ.Parameters.Add("Ls_Ztid", OracleType.VarChar).Value = FrmLogin.getZTID;

                                cmdPDYKPZ.Parameters.Add("Descerr", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
                                cmdPDYKPZ.Parameters.Add("Message", OracleType.VarChar, 255).Direction = ParameterDirection.Output;

                                cmdPDYKPZ.ExecuteNonQuery();
                                transPDYKPZ.Commit();

                                unitOfWork1.DropIdentityMap();

                                xpServerCollectionSource1.Reload();

                                alPDYKPZ.Clear();

                                MessageBox.Show(cmdPDYKPZ.Parameters["Message"].Value.ToString());
                            }

                          
                        }

                    }
                    catch (Exception exception)
                    {
                        //transaction.Rollback();
                        MessageBox.Show(exception.ToString());
                    }
                    finally
                    {
                        connection.Close();
                    }
                }

            }
        }

        private void btnExportGrid_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.DataRowCount > FrmLogin.MAXROWCOUNT)
            {
                MessageBox.Show("记录数超过50000条，请缩小查找范围后再导出！");
            }
            else
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "XLS文件|*.xls";
                saveDialog.Title = "导出Excel文件";
                saveDialog.DefaultExt = "xls";
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    gridView1.Columns["CheckMarkSelection"].Visible = false;

                    gridView1.SelectAll();
                    gridView1.ExportToXls(saveDialog.FileName);

                    gridView1.Columns["CheckMarkSelection"].Visible = true;
                    gridView1.Columns["CheckMarkSelection"].VisibleIndex = 0;

                    MessageBox.Show("导出成功！");

                }
            }
        }

        private void btnExportDetail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (selection.SelectedCount == 0)
            {
                MessageBox.Show("请先选择需要导出明细的记录");
            }
            else
            {
                string strSYDID = null;
                for (int i = 0; i < selection.SelectedCount; ++i)
                {
                    int RowIndex = selection.GetSelectedRowIndex(i);
                    int RowHandle = gridView1.GetRowHandle(RowIndex);

                    string strTemp = gridView1.GetRowCellDisplayText(RowHandle, colSYDID);
                    strSYDID += "[SYDID] = \'" + strTemp + "\' Or ";
                }

                int index = strSYDID.LastIndexOf("'");
                strSYDID = strSYDID.Substring(0, index + 1).Trim();

                FrmProfitLossDetail FrmPLD = new FrmProfitLossDetail(strSYDID);
                FrmPLD.btnExportGrid_ItemClick(sender, e);
            }
        }

        private void btnPrintGrid_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.Columns["CheckMarkSelection"].Visible = false;

            gridView1.SelectAll();
            gridControl1.ShowPrintPreview();

            gridView1.Columns["CheckMarkSelection"].Visible = true;
            gridView1.Columns["CheckMarkSelection"].VisibleIndex = 0;
        }

        private void btnShowError_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (selection.SelectedCount == 0)
            {
                MessageBox.Show("请先选择需要显示差错的记录");
            }
            else
            {
                string strSYDID = null;
                for (int i = 0; i < selection.SelectedCount; ++i)
                {
                    int RowIndex = selection.GetSelectedRowIndex(i);
                    int RowHandle = gridView1.GetRowHandle(RowIndex);

                    string strTemp = gridView1.GetRowCellDisplayText(RowHandle, colSYDID);
                    strSYDID += "[CCDID] = \'" + strTemp + "\' Or ";
                }

                int index = strSYDID.LastIndexOf("'");
                strSYDID = strSYDID.Substring(0, index + 1).Trim();

                FrmProfitLossErrorNote FrmPLEN = new FrmProfitLossErrorNote(strSYDID);
                FrmPLEN.Show();
                FrmPLEN.Activate();
            }
        }

        private void btnColCustomize_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.ShowCustomization();
        }

        private void btnSaveLayout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strLayout = FrmLogin.getUser + "_ProfitLossNoteLayout.xml";
            FileStream stream = new FileStream(strLayout, FileMode.Create);
            gridView1.SaveLayoutToStream(stream);
            stream.Close();
        }

        private void btnLoadLayout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strLayout = FrmLogin.getUser + "_ProfitLossNoteLayout.xml";
            if (File.Exists(strLayout))
            {
                gridView1.RestoreLayoutFromXml(strLayout);
                MessageBox.Show("载入视图成功！");
            }
            else
            {
                MessageBox.Show("未发现视图保存文件，请确认是否曾经保存！");
            }
        }

        private void btnPrintDetail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}