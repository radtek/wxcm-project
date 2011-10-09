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
    public partial class FrmPurchaseReturnNote : DevExpress.XtraEditors.XtraForm
    {
        

        GridCheckMarksSelection selection;

        Int64 i8JTPZS = 0;
        Int64 i8JTZSL = 0;
        double dJTZMY = 0;
        double dJTZSY = 0;
        Int64 i8YFSL = 0;
        double dYFMY = 0;
        double dYFSY = 0;
        Int64 i8ZZSL = 0;
        double dZZMY = 0;
        double dZZSY = 0;

        bool m_fgBranch = false;

        public FrmPurchaseReturnNote(bool fgBranch, string strJTDID = null)
        {
            XpoDefault.ConnectionString = FrmLogin.xpoDataCentStr;

            InitializeComponent();

            if (String.IsNullOrEmpty(strJTDID))
            {
                xpServerCollectionSource1.FixedFilterString = "[JTDID] Is Null";
            }
            else
            {
                xpServerCollectionSource1.FixedFilterString = strJTDID;
            }

            selection = new GridCheckMarksSelection(gridView1);
            selection.CheckMarkColumn.VisibleIndex = 0;

            gridView1.BestFitColumns();

            m_fgBranch = fgBranch;
        }

        private void FrmPurchaseReturnNote_Load(object sender, EventArgs e)
        {
            
        }

        private void gridView1_CustomDrawFooterCell(object sender, FooterCellCustomDrawEventArgs e)
        {
            FrmLogin.vDrawFootCell(e, colSTATUSMC, "选计：");
            FrmLogin.vDrawFootCell(e, colZZSY, dZZSY.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colZZMY, dZZMY.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colJTZMY, dJTZMY.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colJTZSY, dJTZSY.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colYFSY, dYFSY.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colYFMY, dYFMY.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colYFSL, i8YFSL.ToString());
            FrmLogin.vDrawFootCell(e, colZZSL, i8ZZSL.ToString());
            FrmLogin.vDrawFootCell(e, colJTPZS, i8JTPZS.ToString()); 
            FrmLogin.vDrawFootCell(e, colJTZSL, i8JTZSL.ToString());
        }

        private void gridView1_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator & e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString().Trim();
            }
        }

        private void vClearSelectSummary()
        {
            dJTZMY = 0;
            dJTZSY = 0;
            dYFMY = 0;
            dYFSY = 0;
            dZZMY = 0;
            dZZSY = 0;
            i8JTPZS = 0;
            i8JTZSL = 0;
            i8YFSL = 0;
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
                        double.TryParse(colJTZMY.SummaryText, out dJTZMY);
                        double.TryParse(colJTZSY.SummaryText, out dJTZSY);
                        double.TryParse(colYFMY.SummaryText, out dYFMY);
                        double.TryParse(colYFSY.SummaryText, out dYFSY);
                        double.TryParse(colZZMY.SummaryText, out dZZMY);
                        double.TryParse(colZZSY.SummaryText, out dZZSY);
                        Int64.TryParse(colJTZSL.SummaryText, out i8JTZSL);
                        Int64.TryParse(colJTPZS.SummaryText, out i8JTPZS);
                        Int64.TryParse(colYFSL.SummaryText, out i8YFSL); 
                        Int64.TryParse(colZZSL.SummaryText, out i8ZZSL);
                    }
                    else
                    {
                        dJTZMY = 0;
                        dJTZSY = 0;
                        dYFMY = 0;
                        dYFSY = 0;
                        dZZMY = 0;
                        dZZSY = 0;
                        i8JTPZS = 0;
                        i8JTZSL = 0;
                        i8YFSL = 0;
                        i8ZZSL = 0;
                    }

                }
                if (hitInfo.InRowCell)
                {
                    if (selection.IsRowSelected(hitInfo.RowHandle))
                    {
                        dJTZMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJTZMY));                        
                        dJTZSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJTZSY));                        
                        dYFMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colYFMY));
                        dYFSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colYFSY));                        
                        dZZMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZZMY));
                        dZZSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZZSY));                        
                        i8JTPZS += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colJTPZS));
                        i8YFSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colYFSL));
                        i8JTZSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colJTZSL));
                        i8ZZSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colZZSL));
                    }
                    else
                    {
                        dJTZMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJTZMY));
                        dJTZSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJTZSY));
                        dYFMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colYFMY));
                        dYFSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colYFSY));
                        dZZMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZZMY));
                        dZZSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZZSY));
                        i8JTPZS -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colJTPZS));
                        i8YFSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colYFSL));
                        i8JTZSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colJTZSL));
                        i8ZZSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colZZSL));
                    }
                }
            }                      
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));
            if (hitInfo.HitTest == GridHitTest.RowCell)
            {
                if ((hitInfo.Column != null) && (hitInfo.Column == colJTDH))
                {
                    string strTemp = view.GetRowCellDisplayText(hitInfo.RowHandle, colJTDID);
                    string strJTDID = "[JTDID] = \'" + strTemp + "\'";
                    if (fc["FrmPurchaseReturnDetail"] != null)
                    {
                        fc["FrmPurchaseReturnDetail"].Close();
                    }   
                    FrmPurchaseReturnDetail FrmPRD = new FrmPurchaseReturnDetail(m_fgBranch, strJTDID);
                    FrmPRD.Show();
                    FrmPRD.Activate();
                }
                else if ((hitInfo.Column != null) && (hitInfo.Column == colSHHZDH))
                {
                    string strTemp = view.GetRowCellDisplayText(hitInfo.RowHandle, colSHHZDID);
                    string strSHHZDH = view.GetRowCellDisplayText(hitInfo.RowHandle, colSHHZDH);
                    if (!String.IsNullOrEmpty(strSHHZDH))
                    {
                        string strSHHZDID = "[SHHZDID] = \'" + strTemp + "\'";
                        if (FrmLogin.getZTID == "2314" || FrmLogin.getZTID == "2312" || FrmLogin.getZTID == "306")
                        {
                            if (fc["FrmPurchaseReceiveTotal"] != null)
                            {
                                fc["FrmPurchaseReceiveTotal"].Close();
                            }
                            FrmPurchaseReceiveTotal FrmPRT = new FrmPurchaseReceiveTotal(m_fgBranch, strSHHZDID);
                            FrmPRT.Show();
                            FrmPRT.Activate();
                        }
                        else
                        {
                            if (fc["FrmPurchaseReceiveTotalBranch"] != null)
                            {
                                fc["FrmPurchaseReceiveTotalBranch"].Close();
                            }
                            FrmPurchaseReceiveTotalBranch FrmPRTB = new FrmPurchaseReceiveTotalBranch(m_fgBranch, strSHHZDID);
                            FrmPRTB.Show();
                            FrmPRTB.Activate();
                        }
                    }
                }
                else if ((hitInfo.Column != null) && (hitInfo.Column == colSHPZDH))
                {
                    string strTemp = view.GetRowCellDisplayText(hitInfo.RowHandle, colSHPZID);
                    string strSHPZDH = view.GetRowCellDisplayText(hitInfo.RowHandle, colSHPZDH);
                    if (!String.IsNullOrEmpty(strSHPZDH))
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

        private void btnMasterQuery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.ShowFilterEditor(colJTDH);

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
                    FrmPurchaseReturnDetail FrmPRD = new FrmPurchaseReturnDetail(m_fgBranch);
                    FrmPRD.Show();
                    FrmPRD.Activate();
                }

            }
            else
            {
                string strJTDID = null;
                for (int i = 0; i < selection.SelectedCount; ++i)
                {
                    int RowIndex = selection.GetSelectedRowIndex(i);
                    int RowHandle = gridView1.GetRowHandle(RowIndex);

                    string strTemp = gridView1.GetRowCellDisplayText(RowHandle, colJTDID);
                    strJTDID += "[JTDID] = \'" + strTemp + "\' Or ";
                }

                int index = strJTDID.LastIndexOf("'");
                strJTDID = strJTDID.Substring(0, index + 1).Trim();

                FrmPurchaseReturnDetail FrmPRD = new FrmPurchaseReturnDetail(m_fgBranch, strJTDID);
                FrmPRD.Show();
                FrmPRD.Activate();
            }
            
        }

        private void btnConfirm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strJTDID = "";
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
                        string strTemp = gridView1.GetRowCellDisplayText(RowHandle, colJTDID);
                        strJTDID += "\'" + strTemp + "\', ";
                    }
                    else
                    {
                        strJTDID = "";
                        MessageBox.Show("所选记录已被确认，请重新选择！");
                        break;
                    }

                }

                selection.ClearSelection();
                vClearSelectSummary();

                if (!String.IsNullOrEmpty(strJTDID))
                {
                    using (OracleConnection connection = new OracleConnection(FrmLogin.strDataCent))
                    {
                        connection.Open();
                        OracleCommand command = connection.CreateCommand();
                        OracleTransaction transaction = connection.BeginTransaction();
                        command.Connection = connection;
                        command.Transaction = transaction;

                        int index = strJTDID.LastIndexOf("'");
                        strJTDID = strJTDID.Substring(0, index + 1).Trim();

                        try
                        {
                            string strSQL = "update jt_g_jtd set zt = '15', czrq = sysdate where JTDID in (" + strJTDID + ")";
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

                                string strJTDID = gridView1.GetRowCellDisplayText(RowHandle, colJTDID);
                                command.CommandText = "INSERT INTO TEMP_SAVE_ID (TEMPID, ID) Values (temp_id_seq.nextval, '" + strJTDID + "')";
                                command.ExecuteNonQuery();
                            }

                            selection.ClearSelection();
                            vClearSelectSummary();

                            if (!fgSummarizeStop)
                            {
                                command.CommandType = CommandType.StoredProcedure;
                                if (m_fgBranch)
                                {
                                    command.CommandText = "JT_G_JTD_TO_SHHZD_JC";
                                }
                                else
                                {
                                    command.CommandText = "JT_G_JTD_TO_SHHZD";
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

                                string strSHHZDH = gridView1.GetRowCellDisplayText(RowHandle, colSHHZDH);
                                if (String.IsNullOrEmpty(strSHHZDH))
                                {
                                    fgVoucherStop = true;
                                    MessageBox.Show("所选记录未被汇总，请重新选择！");
                                    break;
                                }

                                string strJTDID = gridView1.GetRowCellDisplayText(RowHandle, colJTDID);
                                command.CommandText = "INSERT INTO TEMP_SAVE_ID (TEMPID, ID) Values (temp_id_seq.nextval, '" + strJTDID + "')";
                                command.ExecuteNonQuery();
                            }

                            selection.ClearSelection();
                            vClearSelectSummary();

                            if (!fgVoucherStop)
                            {
                                command.CommandType = CommandType.StoredProcedure;
                                command.CommandText = "JT_G_JTD_TO_CGSHPZ";


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

        private void btnShowErrNote_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (selection.SelectedCount == 0)
            {
                MessageBox.Show("请先选择需要显示差错的记录");
            }
            else
            {
                string strJTDID = null;
                for (int i = 0; i < selection.SelectedCount; ++i)
                {
                    int RowIndex = selection.GetSelectedRowIndex(i);
                    int RowHandle = gridView1.GetRowHandle(RowIndex);

                    string strTemp = gridView1.GetRowCellDisplayText(RowHandle, colJTDID);
                    strJTDID += "[CCDID] = \'" + strTemp + "\' Or ";
                }

                int index = strJTDID.LastIndexOf("'");
                strJTDID = strJTDID.Substring(0, index + 1).Trim();

                FrmPurchaseReturnErr FrmPRE = new FrmPurchaseReturnErr(strJTDID);
                FrmPRE.Show();
                FrmPRE.Activate();
            }
        }

        private void btnColCustomize_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.ShowCustomization();
        }

        private void btnSaveLayout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strLayout = FrmLogin.getUser + "_PurchaseReturnNoteLayout.xml";
            FileStream stream = new FileStream(strLayout, FileMode.Create);
            gridView1.SaveLayoutToStream(stream);
            stream.Close();
        }

        private void btnLoadLayout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strLayout = FrmLogin.getUser + "_PurchaseReturnNoteLayout.xml";
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

        private void btnExportDetail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (selection.SelectedCount == 0)
            {
                MessageBox.Show("请先选择需要导出明细的记录");
            }
            else
            {
                string strJTDID = null;
                for (int i = 0; i < selection.SelectedCount; ++i)
                {
                    int RowIndex = selection.GetSelectedRowIndex(i);
                    int RowHandle = gridView1.GetRowHandle(RowIndex);

                    string strTemp = gridView1.GetRowCellDisplayText(RowHandle, colJTDID);
                    strJTDID += "[JTDID] = \'" + strTemp + "\' Or ";
                }

                int index = strJTDID.LastIndexOf("'");
                strJTDID = strJTDID.Substring(0, index + 1).Trim();

                FrmPurchaseReturnDetail FrmPRD = new FrmPurchaseReturnDetail(m_fgBranch, strJTDID);
                FrmPRD.btnExportGrid_ItemClick(sender, e);
            }
        }

        private void btnPrintDetail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strJTDID = "";
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

                    string strTemp = gridView1.GetRowCellDisplayText(RowHandle, colJTDID);
                    strJTDID += "\'" + strTemp + "\', ";
                }

                int index = strJTDID.LastIndexOf("'");
                strJTDID = strJTDID.Substring(0, index + 1).Trim();

                JTDReport report = new JTDReport(strJTDID);
                report.ShowPreviewDialog();
            }
                    
        }
                                  
        
    }
}