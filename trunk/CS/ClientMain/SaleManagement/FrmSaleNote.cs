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
    public partial class FrmSaleNote : DevExpress.XtraEditors.XtraForm
    {
        

        GridCheckMarksSelection selection;

        Int64 i8PZS = 0;
        Int64 i8XSSL = 0;
        double dXSMY = 0;
        double dXSSY = 0;
        Int64 i8ZZSL = 0;
        double dZZSY = 0;
        double dZZMY = 0;
        Int64 i8YSSL = 0;
        double dYSSY = 0;
        double dYSMY = 0;
        bool m_fgBranch = false;
        public FrmSaleNote(bool fgBranch, string strXSDID = null)
        {
            XpoDefault.ConnectionString = FrmLogin.xpoDataCentStr;

            InitializeComponent();

            if (String.IsNullOrEmpty(strXSDID))
            {
                xpServerCollectionSource1.FixedFilterString = "[XSDID] Is Null";
            }
            else
            {
                xpServerCollectionSource1.FixedFilterString = strXSDID;
            }
            
            selection = new GridCheckMarksSelection(gridView1);
            selection.CheckMarkColumn.VisibleIndex = 0;

            gridView1.BestFitColumns();

            m_fgBranch = fgBranch;
        }

        private void gridView1_CustomDrawFooterCell(object sender, DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventArgs e)
        {
            FrmLogin.vDrawFootCell(e, colSTATUSMC, "选计：");
            FrmLogin.vDrawFootCell(e, colXSMY, dXSMY.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colXSSY, dXSSY.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colZZMY, dZZMY.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colZZSY, dZZSY.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colYSSY, dYSSY.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colYSMY, dYSMY.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colPZS, i8PZS.ToString());
            FrmLogin.vDrawFootCell(e, colXSSL, i8XSSL.ToString());
            FrmLogin.vDrawFootCell(e, colZZSL, i8ZZSL.ToString());
            FrmLogin.vDrawFootCell(e, colYSSL, i8YSSL.ToString());
        }

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator & e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString().Trim();
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));

            FormCollection fc = Application.OpenForms;

            if (hitInfo.HitTest == GridHitTest.RowCell)
            {
                if ((hitInfo.Column != null) && (hitInfo.Column == colXSDH))
                {
                    string strTemp = view.GetRowCellDisplayText(hitInfo.RowHandle, colXSDID);
                    string strXSDID = "[XSDID] = \'" + strTemp + "\'";
                    if (fc["FrmSaleDetail"] != null)
                    {
                        fc["FrmSaleDetail"].Close();
                    }
                    FrmSaleDetail FrmSD = new FrmSaleDetail(m_fgBranch, strXSDID);
                    FrmSD.Show();
                    FrmSD.Activate();
                }
                else if ((hitInfo.Column != null) && (hitInfo.Column == colXSHZDH))
                {
                    string strTemp = view.GetRowCellDisplayText(hitInfo.RowHandle, colXSHZDID);
                    string strXSHZDH = view.GetRowCellDisplayText(hitInfo.RowHandle, colXSHZDH);
                    if (!String.IsNullOrEmpty(strXSHZDH))
                    {
                        string strXSHZDID = "[XSHZDID] = \'" + strTemp + "\'";
                        if (FrmLogin.getZTID == "2314" || FrmLogin.getZTID == "2312" || FrmLogin.getZTID == "306")
                        {
                            if (fc["FrmSaleTotal"] != null)
                            {
                                fc["FrmSaleTotal"].Close();
                            }
                            FrmSaleTotal FrmST = new FrmSaleTotal(m_fgBranch, strXSHZDID);
                            FrmST.Show();
                            FrmST.Activate();
                        }
                        else
                        {
                            if (fc["FrmSaleTotalBranch"] != null)
                            {
                                fc["FrmSaleTotalBranch"].Close();
                            }
                            FrmSaleTotalBranch FrmSTB = new FrmSaleTotalBranch(m_fgBranch, strXSHZDID);
                            FrmSTB.Show();
                            FrmSTB.Activate();
                        }
                    }
                }
                else if ((hitInfo.Column != null) && (hitInfo.Column == colFHPZH))
                {
                    string strTemp = view.GetRowCellDisplayText(hitInfo.RowHandle, colFHPZID);
                    string strFHPZH = view.GetRowCellDisplayText(hitInfo.RowHandle, colFHPZH);
                    if (!String.IsNullOrEmpty(strFHPZH))
                    {
                        string strSHPZID = "[VOUCHERID] = \'" + strTemp + "\'";
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

        private void vClearSelectSummary()
        {
            dXSMY = 0;
            dXSSY = 0;
            dYSMY = 0;
            dYSSY = 0;
            dZZMY = 0;
            dZZSY = 0;
            i8PZS = 0;
            i8YSSL = 0;
            i8XSSL = 0;
            i8ZZSL = 0; 
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
                        double.TryParse(colZZSY.SummaryText, out dZZSY);
                        double.TryParse(colZZMY.SummaryText, out dZZMY);
                        double.TryParse(colXSSY.SummaryText, out dXSSY);
                        double.TryParse(colXSMY.SummaryText, out dXSMY);
                        double.TryParse(colYSSY.SummaryText, out dYSSY);
                        double.TryParse(colYSMY.SummaryText, out dYSMY);
                        Int64.TryParse(colYSSL.SummaryText, out i8YSSL);
                        Int64.TryParse(colXSSL.SummaryText, out i8XSSL);
                        Int64.TryParse(colZZSL.SummaryText, out i8ZZSL);
                        Int64.TryParse(colPZS.SummaryText, out i8PZS);
                    }
                    else
                    {
                        dXSMY = 0;
                        dXSSY = 0;
                        dYSMY = 0;
                        dYSSY = 0;
                        dZZMY = 0;
                        dZZSY = 0;
                        i8PZS = 0;
                        i8YSSL = 0;
                        i8XSSL = 0;
                        i8ZZSL = 0; 
                    }

                }
                if (hitInfo.InRowCell)
                {
                    if (selection.IsRowSelected(hitInfo.RowHandle))
                    {
                        dYSMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colYSMY));
                        dXSMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colXSMY));
                        dYSSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colYSSY));
                        dXSSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colXSSY));                        
                        dZZMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZZMY));
                        dZZSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZZSY));
                        i8PZS += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colPZS));                        
                        i8XSSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colXSSL));
                        i8YSSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colYSSL));
                        i8ZZSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colZZSL));
                    }
                    else
                    {
                        dYSMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colYSMY));
                        dXSMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colXSMY));
                        dYSSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colYSSY));
                        dXSSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colXSSY));
                        dZZMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZZMY));
                        dZZSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZZSY));
                        i8PZS -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colPZS));
                        i8XSSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colXSSL));
                        i8YSSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colYSSL));
                        i8ZZSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colZZSL));
                    }
                }
            }                      
        }

        private void MasterQuery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            selection.ClearSelection();
            vClearSelectSummary();
            gridView1.ShowFilterEditor(colXSDH);

            if (!String.IsNullOrEmpty(gridView1.ActiveFilterString))
            {
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
                    FrmSaleDetail FrmSD = new FrmSaleDetail(m_fgBranch);
                    FrmSD.Show();
                    FrmSD.Activate();
                }

            }
            else
            {
                string strXSDID = null;
                for (int i = 0; i < selection.SelectedCount; ++i)
                {
                    int RowIndex = selection.GetSelectedRowIndex(i);
                    int RowHandle = gridView1.GetRowHandle(RowIndex);

                    string strTemp = gridView1.GetRowCellDisplayText(RowHandle, colXSDID);
                    strXSDID += "[XSDID] = \'" + strTemp + "\' Or ";
                }

                int index = strXSDID.LastIndexOf("'");
                strXSDID = strXSDID.Substring(0, index + 1).Trim();

                FrmSaleDetail FrmSD = new FrmSaleDetail(m_fgBranch,strXSDID);
                FrmSD.Show();
                FrmSD.Activate();
            }
        }

        private void btnConfirm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strXSDID = "";
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
                        string strTemp = gridView1.GetRowCellDisplayText(RowHandle, colXSDID);
                        strXSDID += "\'" + strTemp + "\', ";
                    }
                    else
                    {
                        strXSDID = "";
                        MessageBox.Show("所选记录已被确认，请重新选择！");
                        break;
                    }

                }

                selection.ClearSelection();
                vClearSelectSummary();
                if (!String.IsNullOrEmpty(strXSDID))
                {
                    using (OracleConnection connection = new OracleConnection(FrmLogin.strDataCent))
                    {
                        connection.Open();
                        OracleCommand command = connection.CreateCommand();
                        OracleTransaction transaction = connection.BeginTransaction();
                        command.Connection = connection;
                        command.Transaction = transaction;

                        int index = strXSDID.LastIndexOf("'");
                        strXSDID = strXSDID.Substring(0, index + 1).Trim();

                        try
                        {
                            string strSQL = "update jt_x_xsd set zt = '15', czrq = sysdate where XSDID in (" + strXSDID + ")";
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

        private void btnSummarize_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (selection.SelectedCount == 0)
            {
                MessageBox.Show("请先选择需要汇总的记录");
            }
            else
            {
                using (OracleConnection connection = new OracleConnection(FrmLogin.strDataCent))
                {
                    connection.Open();

                    OracleCommand command = connection.CreateCommand();
                    OracleTransaction transaction;

                    // Start a local transaction
                    transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);
                    // Assign transaction object for a pending local transaction
                    command.Transaction = transaction;

                    try
                    {
                        const string message = "确定汇总吗?";
                        const string caption = "汇总?";
                        var result = MessageBox.Show(message, caption,
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            bool fgSummarizeStop = false;
                            for (int i = 0; i < selection.SelectedCount; ++i)
                            {
                                int RowIndex = selection.GetSelectedRowIndex(i);
                                int RowHandle = gridView1.GetRowHandle(RowIndex);

                                int i4Status = Convert.ToInt32(gridView1.GetRowCellDisplayText(RowHandle, colZT));
                                if (i4Status < 15)
                                {
                                    fgSummarizeStop = true;
                                    MessageBox.Show("所选记录未被审核，请重新选择！");
                                    break;
                                }

                                string strXSDID = gridView1.GetRowCellDisplayText(RowHandle, colXSDID);
                                command.CommandText = "INSERT INTO TEMP_SAVE_ID (TEMPID, ID) Values (temp_id_seq.nextval, '" + strXSDID + "')";
                                command.ExecuteNonQuery();
                            }

                            selection.ClearSelection();
                            vClearSelectSummary();
                            if (!fgSummarizeStop)
                            {
                                command.CommandType = CommandType.StoredProcedure;
                                if (m_fgBranch)
                                {
                                    command.CommandText = "JT_X_XSD_TO_XSHZD_JC";
                                }
                                else
                                {
                                    command.CommandText = "JT_X_XSD_TO_XSHZD";
                                }
                                command.Parameters.Add("Userid", OracleType.VarChar).Value = FrmLogin.getUserID;

                                command.Parameters.Add("Departmentid", OracleType.VarChar).Value = FrmLogin.getDeptID;
                                command.Parameters.Add("Ls_Ztid", OracleType.VarChar).Value = FrmLogin.getZTID;

                                command.Parameters.Add("Descerr", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
                                command.Parameters.Add("Message", OracleType.VarChar, 255).Direction = ParameterDirection.Output;

                                command.ExecuteNonQuery();
                                transaction.Commit();

                                unitOfWork1.DropIdentityMap();

                                xpServerCollectionSource1.Reload();

                                MessageBox.Show(command.Parameters["Message"].Value.ToString());
                            }
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

                    OracleCommand command = connection.CreateCommand();
                    OracleTransaction transaction;

                    // Start a local transaction
                    transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);
                    // Assign transaction object for a pending local transaction
                    command.Transaction = transaction;

                    try
                    {
                        const string message = "确定产生凭证吗?";
                        const string caption = "产生凭证?";
                        var result = MessageBox.Show(message, caption,
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            bool fgVoucherStop = false;
                            for (int i = 0; i < selection.SelectedCount; ++i)
                            {
                                int RowIndex = selection.GetSelectedRowIndex(i);
                                int RowHandle = gridView1.GetRowHandle(RowIndex);

                                string strXSHZDH = gridView1.GetRowCellDisplayText(RowHandle, colXSHZDH);
                                if (String.IsNullOrEmpty(strXSHZDH))
                                {
                                    fgVoucherStop = true;
                                    MessageBox.Show("所选记录未被汇总，请重新选择！");
                                    break;
                                }

                                string strXSDID = gridView1.GetRowCellDisplayText(RowHandle, colXSDID);
                                command.CommandText = "INSERT INTO TEMP_SAVE_ID (TEMPID, ID) Values (temp_id_seq.nextval, '" + strXSDID + "')";
                                command.ExecuteNonQuery();
                            }

                            selection.ClearSelection();
                            vClearSelectSummary();
                            if (!fgVoucherStop)
                            {
                                command.CommandType = CommandType.StoredProcedure;
                                command.CommandText = "JT_X_XSD_TO_FHPZ";


                                command.Parameters.Add("Userid", OracleType.VarChar).Value = FrmLogin.getUserID;

                                command.Parameters.Add("Departmentid", OracleType.VarChar).Value = FrmLogin.getDeptID;
                                command.Parameters.Add("Ls_Ztid", OracleType.VarChar).Value = FrmLogin.getZTID;

                                command.Parameters.Add("Descerr", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
                                command.Parameters.Add("Message", OracleType.VarChar, 255).Direction = ParameterDirection.Output;

                                command.ExecuteNonQuery();
                                transaction.Commit();

                                unitOfWork1.DropIdentityMap();

                                xpServerCollectionSource1.Reload();

                                MessageBox.Show(command.Parameters["Message"].Value.ToString());
                            }
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

        private void btnPrintGrid_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.Columns["CheckMarkSelection"].Visible = false;

            gridView1.SelectAll();
            gridControl1.ShowPrintPreview();

            gridView1.Columns["CheckMarkSelection"].Visible = true;
            gridView1.Columns["CheckMarkSelection"].VisibleIndex = 0;
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

        private void btnShowError_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (selection.SelectedCount == 0)
            {
                MessageBox.Show("请先选择需要显示差错的记录");
            }
            else
            {
                string strXSDID = null;
                for (int i = 0; i < selection.SelectedCount; ++i)
                {
                    int RowIndex = selection.GetSelectedRowIndex(i);
                    int RowHandle = gridView1.GetRowHandle(RowIndex);

                    string strTemp = gridView1.GetRowCellDisplayText(RowHandle, colXSDID);
                    strXSDID += "[CCDID] = \'" + strTemp + "\' Or ";
                }

                int index = strXSDID.LastIndexOf("'");
                strXSDID = strXSDID.Substring(0, index + 1).Trim();

                FrmSaleErrorNote FrmSEN = new FrmSaleErrorNote(strXSDID);
                FrmSEN.Show();
                FrmSEN.Activate();
            }
        }

        private void btnColCustomize_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.ShowCustomization();
        }

        private void btnSaveLayout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strLayout = FrmLogin.getUser + "_SaleNoteLayout.xml";
            FileStream stream = new FileStream(strLayout, FileMode.Create);
            gridView1.SaveLayoutToStream(stream);
            stream.Close();
        }

        private void btnLoadLayout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strLayout = FrmLogin.getUser + "_SaleNoteLayout.xml";
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
            string strXSDID = "";
            if (selection.SelectedCount == 0)
            {
                MessageBox.Show("请先选择需要打印的记录");
            }
            else
            {
                for (int i = 0; i < selection.SelectedCount; ++i)
                {
                    int RowIndex = selection.GetSelectedRowIndex(i);
                    int RowHandle = gridView1.GetRowHandle(RowIndex);

                    string strTemp = gridView1.GetRowCellDisplayText(RowHandle, colXSDID);
                    strXSDID += "\'" + strTemp + "\', ";
                }

                int index = strXSDID.LastIndexOf("'");
                strXSDID = strXSDID.Substring(0, index + 1).Trim();

                XSDReport report = new XSDReport(strXSDID);
                report.ShowPreviewDialog();
            }
            
        }
    }
}