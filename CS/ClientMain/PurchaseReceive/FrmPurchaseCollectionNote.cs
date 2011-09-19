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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System.IO;
using System.Data.OracleClient;

namespace ClientMain
{
    public partial class FrmPurchaseCollectionNote : DevExpress.XtraEditors.XtraForm
    {       
        

        GridCheckMarksSelection selection;

        double dTSJE = 0;

        public FrmPurchaseCollectionNote(string strCGTSDID = null)
        {
            XpoDefault.ConnectionString = OracleConnectionProvider.GetConnectionString("XINHUA", "xxb", "pass");

            InitializeComponent();
            if (String.IsNullOrEmpty(strCGTSDID))
            {
                xpServerCollectionSource1.FixedFilterString = "[CGTSDID] Is Null";
            }
            else
            {
                xpServerCollectionSource1.FixedFilterString = strCGTSDID;
            }
            selection = new GridCheckMarksSelection(gridView1);
            selection.CheckMarkColumn.VisibleIndex = 0;

            gridView1.BestFitColumns();
        }


        private void gridView1_CustomDrawFooterCell(object sender, FooterCellCustomDrawEventArgs e)
        {
            FrmLogin.vDrawFootCell(e, colSTATUSMC, "选计：");
            FrmLogin.vDrawFootCell(e, colTSJE, dTSJE.ToString("F2"));
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
                if ((hitInfo.Column != null) && (hitInfo.Column == colCGTSDH))
                {
                    string strTemp = view.GetRowCellDisplayText(hitInfo.RowHandle, colCGTSDID);
                    string strCGTSDID = "[CGTSDID] = \'" + strTemp + "\'";
                    if (fc["FrmPurchaseCollectionDetail"] != null)
                    {
                        fc["FrmPurchaseCollectionDetail"].Close();
                    }
                    FrmPurchaseCollectionDetail FrmPCD = new FrmPurchaseCollectionDetail(strCGTSDID);
                    FrmPCD.Show();
                    FrmPCD.Activate();
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
                        double.TryParse(colTSJE.SummaryText, out dTSJE);                        
                    }
                    else
                    {
                        dTSJE = 0;
                    }

                }
                if (hitInfo.InRowCell)
                {
                    if (selection.IsRowSelected(hitInfo.RowHandle))
                    {
                        dTSJE += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colTSJE));
                    }
                    else
                    {
                        dTSJE -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colTSJE));
                    }
                }
            }        
        }

        private void vClearSelectSummary()
        {
            
            dTSJE = 0;
        }

        private void btnMasterQuery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            gridView1.ShowFilterEditor(gridView1.FocusedColumn);

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
                //const string message = "没有勾选主单进行的详单查询时间会比较久（3分钟左右），继续么？";
                //const string caption = "详单查询?";
                //var result = MessageBox.Show(message, caption,
                //                             MessageBoxButtons.YesNo,
                //                             MessageBoxIcon.Question);
                //if (result == DialogResult.Yes)
                //{
                FrmPurchaseCollectionDetail FrmPCD = new FrmPurchaseCollectionDetail();
                FrmPCD.Show();
                FrmPCD.Activate();
                //}

            }
            else
            {
                string strCGTSDID = null;
                for (int i = 0; i < selection.SelectedCount; ++i)
                {
                    int RowIndex = selection.GetSelectedRowIndex(i);
                    int RowHandle = gridView1.GetRowHandle(RowIndex);

                    string strTemp = gridView1.GetRowCellDisplayText(RowHandle, colCGTSDID);
                    strCGTSDID += "[CGTSDID] = \'" + strTemp + "\' Or ";
                }

                int index = strCGTSDID.LastIndexOf("'");
                strCGTSDID = strCGTSDID.Substring(0, index + 1).Trim();

                FrmPurchaseCollectionDetail FrmPCD = new FrmPurchaseCollectionDetail(strCGTSDID);
                FrmPCD.Show();
                FrmPCD.Activate();
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
            if (selection.SelectedCount <= FrmLogin.MAXROWCOUNT)
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
            else
            {
                MessageBox.Show("记录数超过50000条，请缩小查找范围后再导出！");
            }
        }

        private void btnColCustomize_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.ShowCustomization();
        }

        private void btnSaveLayout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strLayout = FrmLogin.getUser + "_PurchaseCollectionNoteLayout.xml";
            FileStream stream = new FileStream(strLayout, FileMode.Create);
            gridView1.SaveLayoutToStream(stream);
            stream.Close();
        }

        private void btnLoadLayout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strLayout = FrmLogin.getUser + "_PurchaseCollectionNoteLayout.xml";
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

        private void btnConfirm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strCGTSDID = "";
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
                        string strTemp = gridView1.GetRowCellDisplayText(RowHandle, colCGTSDID);
                        strCGTSDID += "\'" + strTemp + "\', ";
                    }
                    else
                    {
                        strCGTSDID = "";
                        MessageBox.Show("所选记录已被确认，请重新选择！");
                        break;
                    }

                }

                selection.ClearSelection();
                vClearSelectSummary();
                if (!String.IsNullOrEmpty(strCGTSDID))
                {
                    using (OracleConnection connection = new OracleConnection(FrmLogin.strCon))
                    {
                        connection.Open();
                        OracleCommand command = connection.CreateCommand();
                        OracleTransaction transaction = connection.BeginTransaction();
                        command.Connection = connection;
                        command.Transaction = transaction;

                        int index = strCGTSDID.LastIndexOf("'");
                        strCGTSDID = strCGTSDID.Substring(0, index + 1).Trim();

                        try
                        {
                            string strSQL = "update jc_c_cgtsd set zt = '15', czrq = sysdate where CGTSDID in (" + strCGTSDID + ")";
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

        private void btnWirteOff_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (selection.SelectedCount == 0)
            {
                MessageBox.Show("请先选择需要核销的记录");
            }
            else if (selection.SelectedCount > 1)
            {
                MessageBox.Show("每次只能核销一条记录，请重新选择！");
            }
            else
            {
                using (OracleConnection connection = new OracleConnection(FrmLogin.strCon))
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
                        int RowIndex = selection.GetSelectedRowIndex(0);
                        int RowHandle = gridView1.GetRowHandle(RowIndex);

                        string strCGTSDID = gridView1.GetRowCellDisplayText(RowHandle, colCGTSDID);
                        int i4Status = Convert.ToInt32(gridView1.GetRowCellDisplayText(RowHandle, colZT));
                        if (i4Status < 15)
                        {
                            MessageBox.Show("所选记录未被审核，请重新选择！");
                        }
                        else
                        {
                            FrmWriteOff FrmWO = new FrmWriteOff();
                            if (FrmWO.ShowDialog() == DialogResult.OK)
                            {
                                selection.ClearSelection();
                                vClearSelectSummary();
                                command.CommandType = CommandType.StoredProcedure;
                                command.CommandText = "JC_C_CGTSD_HX";

                                command.Parameters.Add("ls_CGtsdid", OracleType.VarChar).Value = strCGTSDID;

                                command.Parameters.Add("Ls_Fkrq", OracleType.VarChar).Value = FrmWO.getWriteOffDate();

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
    }
}