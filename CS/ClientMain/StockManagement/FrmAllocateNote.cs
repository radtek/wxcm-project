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
    public partial class FrmAllocateNote : DevExpress.XtraEditors.XtraForm
    {
        

        GridCheckMarksSelection selection;

        double dDBMY = 0;
        double dDBSY = 0;
        Int64 i8DBSL = 0;

        public FrmAllocateNote(string strDBDID = null)
        {
            XpoDefault.ConnectionString = FrmLogin.xpoDataCentStr;

            InitializeComponent();

            if (String.IsNullOrEmpty(strDBDID))
            {
                xpServerCollectionSource1.FixedFilterString = "[DBDID] Is Null";
            }
            else
            {
                xpServerCollectionSource1.FixedFilterString = strDBDID;
            }

            selection = new GridCheckMarksSelection(gridView1);
            selection.CheckMarkColumn.VisibleIndex = 0;

            gridView1.BestFitColumns();
        }

        private void gridView1_CustomDrawFooterCell(object sender, DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventArgs e)
        {
            FrmLogin.vDrawFootCell(e, colSTATUSMC, "选计：");
            FrmLogin.vDrawFootCell(e, colDBSY, dDBSY.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colDBMY, dDBMY.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colDBSL, i8DBSL.ToString());
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
                if ((hitInfo.Column != null) && (hitInfo.Column == colDBDH))
                {
                    string strTemp = view.GetRowCellDisplayText(hitInfo.RowHandle, colDBDID);
                    string strDBDID = "[DBDID] = \'" + strTemp + "\'";
                    if (fc["FrmAllocateDetail"] != null)
                    {
                        fc["FrmAllocateDetail"].Close();
                    }
                    FrmAllocateDetail FrmAD = new FrmAllocateDetail(strDBDID);
                    FrmAD.Show();
                    FrmAD.Activate();
                }
                else if ((hitInfo.Column != null) && (hitInfo.Column == colDBPZH))
                {
                    string strTemp = view.GetRowCellDisplayText(hitInfo.RowHandle, colDBPZID);
                    string strDBPZH = view.GetRowCellDisplayText(hitInfo.RowHandle, colDBPZH);
                    if (!String.IsNullOrEmpty(strDBPZH))
                    {
                        string strDBPZID = "[VOUCHERID] = \'" + strTemp + "\'";
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
                        double.TryParse(colDBSY.SummaryText, out dDBSY);
                        double.TryParse(colDBMY.SummaryText, out dDBMY);                        
                        Int64.TryParse(colDBSL.SummaryText, out i8DBSL);
                    }
                    else
                    {
                        dDBMY = 0;
                        dDBSY = 0;                        
                        i8DBSL = 0;
                    }

                }
                if (hitInfo.InRowCell)
                {
                    if (selection.IsRowSelected(hitInfo.RowHandle))
                    {
                        dDBMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colDBMY));
                        dDBSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colDBSY));                        
                        i8DBSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colDBSL));
                    }
                    else
                    {
                        dDBMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colDBMY));
                        dDBSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colDBSY));
                        i8DBSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colDBSL));
                    }
                }
            }                      
        }

        private void vClearSelectSummary()
        {
            dDBMY = 0;
            dDBSY = 0;
            i8DBSL = 0;
        }

        private void btnMasterQuery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            gridView1.ShowFilterEditor(colDBDH);

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
                    FrmAllocateDetail FrmAD = new FrmAllocateDetail();
                    FrmAD.Show();
                    FrmAD.Activate();
                }

            }
            else
            {
                string strDBDID = null;
                for (int i = 0; i < selection.SelectedCount; ++i)
                {
                    int RowIndex = selection.GetSelectedRowIndex(i);
                    int RowHandle = gridView1.GetRowHandle(RowIndex);

                    string strTemp = gridView1.GetRowCellDisplayText(RowHandle, colDBDID);
                    strDBDID += "[DBDID] = \'" + strTemp + "\' Or ";
                }

                int index = strDBDID.LastIndexOf("'");
                strDBDID = strDBDID.Substring(0, index + 1).Trim();

                FrmAllocateDetail FrmAD = new FrmAllocateDetail(strDBDID);
                FrmAD.Show();
                FrmAD.Activate();
            }
        }

        private void btnConfirm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strDBDID = "";
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
                        string strTemp = gridView1.GetRowCellDisplayText(RowHandle, colDBDID);
                        strDBDID += "\'" + strTemp + "\', ";
                    }
                    else
                    {
                        strDBDID = "";
                        MessageBox.Show("所选记录已被确认，请重新选择！");
                        break;
                    }

                }

                selection.ClearSelection();
                vClearSelectSummary();
                if (!String.IsNullOrEmpty(strDBDID))
                {
                    using (OracleConnection connection = new OracleConnection(FrmLogin.strDataCent))
                    {
                        connection.Open();
                        OracleCommand command = connection.CreateCommand();
                        OracleTransaction transaction = connection.BeginTransaction();
                        command.Connection = connection;
                        command.Transaction = transaction;

                        int index = strDBDID.LastIndexOf("'");
                        strDBDID = strDBDID.Substring(0, index + 1).Trim();

                        try
                        {
                            string strSQL = "update jt_c_dbd set zt = '15', czrq = sysdate where DBDID in (" + strDBDID + ")";
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

                                int i4Status = Convert.ToInt32(gridView1.GetRowCellDisplayText(RowHandle, colZT));
                                if (i4Status < 15)
                                {
                                    fgVoucherStop = true;
                                    MessageBox.Show("所选记录未被审核，请重新选择！");
                                    break;
                                }

                                string strDBDID = gridView1.GetRowCellDisplayText(RowHandle, colDBDID);
                                command.CommandText = "INSERT INTO TEMP_SAVE_ID (TEMPID, ID) Values (temp_id_seq.nextval, '" + strDBDID + "')";
                                command.ExecuteNonQuery();
                            }

                            selection.ClearSelection();
                            vClearSelectSummary();
                            if (!fgVoucherStop)
                            {
                                command.CommandType = CommandType.StoredProcedure;
                                command.CommandText = "JT_C_DBD_TO_DBPZ";


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

        private void btnExportDetail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (selection.SelectedCount == 0)
            {
                MessageBox.Show("请先选择需要导出明细的记录");
            }
            else
            {
                string strDBDID = null;
                for (int i = 0; i < selection.SelectedCount; ++i)
                {
                    int RowIndex = selection.GetSelectedRowIndex(i);
                    int RowHandle = gridView1.GetRowHandle(RowIndex);

                    string strTemp = gridView1.GetRowCellDisplayText(RowHandle, colDBDID);
                    strDBDID += "[DBDID] = \'" + strTemp + "\' Or ";
                }

                int index = strDBDID.LastIndexOf("'");
                strDBDID = strDBDID.Substring(0, index + 1).Trim();

                FrmAllocateDetail FrmAD = new FrmAllocateDetail(strDBDID);
                FrmAD.btnExportGrid_ItemClick(sender, e);
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
                string strDBDID = null;
                for (int i = 0; i < selection.SelectedCount; ++i)
                {
                    int RowIndex = selection.GetSelectedRowIndex(i);
                    int RowHandle = gridView1.GetRowHandle(RowIndex);

                    string strTemp = gridView1.GetRowCellDisplayText(RowHandle, colDBDID);
                    strDBDID += "[CCDID] = \'" + strTemp + "\' Or ";
                }

                int index = strDBDID.LastIndexOf("'");
                strDBDID = strDBDID.Substring(0, index + 1).Trim();

                FrmAllocateErrorNote FrmAEN = new FrmAllocateErrorNote(strDBDID);
                FrmAEN.Show();
                FrmAEN.Activate();
            }
        }

        private void btnColCustomize_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.ShowCustomization();
        }

        private void btnSaveLayout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strLayout = FrmLogin.getUser + "_AllocateNoteLayout.xml";
            FileStream stream = new FileStream(strLayout, FileMode.Create);
            gridView1.SaveLayoutToStream(stream);
            stream.Close();
        }

        private void btnLoadLayout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strLayout = FrmLogin.getUser + "_AllocateNoteLayout.xml";
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
    }
}