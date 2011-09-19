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
using System.Data.OracleClient;
using System.IO;

namespace ClientMain
{
    public partial class FrmSaleDetail : DevExpress.XtraEditors.XtraForm
    {
        

        GridCheckMarksSelection selection;

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
        
        public FrmSaleDetail(bool fgBranch, string strXSDID= null)
        {
            XpoDefault.ConnectionString = OracleConnectionProvider.GetConnectionString("XINHUA", "xxb", "pass");

            InitializeComponent();
            if (String.IsNullOrEmpty(strXSDID))
            {
                xpServerCollectionSource1.FixedFilterString = "[XSDMXID] Is Null";
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
            FrmLogin.vDrawFootCell(e, colXSDH, "选计：");
            FrmLogin.vDrawFootCell(e, colXSMY, dXSMY.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colXSSY, dXSSY.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colZZMY, dZZMY.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colZZSY, dZZSY.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colYSSY, dYSSY.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colYSMY, dYSMY.ToString("F2"));            
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
                    }
                    else
                    {
                        dXSMY = 0;
                        dXSSY = 0;
                        dYSMY = 0;
                        dYSSY = 0;
                        dZZMY = 0;
                        dZZSY = 0;                        
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
                        i8XSSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colXSSL));
                        i8YSSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colYSSL));
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
                if ((hitInfo.Column != null) && (hitInfo.Column == colXSDH))
                {
                    string strTemp = view.GetRowCellDisplayText(hitInfo.RowHandle, colXSDID);
                    string strXSDID = "[XSDID] = \'" + strTemp + "\'";
                    if (fc["FrmSaleNote"] != null)
                    {
                        fc["FrmSaleNote"].Close();
                    }
                    FrmSaleNote FrmSN = new FrmSaleNote(m_fgBranch, strXSDID);
                    FrmSN.Show();
                    FrmSN.Activate();
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
            i8YSSL = 0;
            i8XSSL = 0;
            i8ZZSL = 0;
        }

        private void btnDetailQuery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        private void btnCorrect_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (selection.SelectedCount == 0)
            {
                MessageBox.Show("请先选择需要更正的记录");
            }
            else if (selection.SelectedCount > 1)
            {
                MessageBox.Show("每次只能更正一条记录，请重新选择！");
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

                        string strXSDID = gridView1.GetRowCellDisplayText(RowHandle, colXSDID);
                        string strXSDMXID = gridView1.GetRowCellDisplayText(RowHandle, colXSDMXID);
                        string strXZ = gridView1.GetRowCellDisplayText(RowHandle, colXZ);
                        string strXJ = gridView1.GetRowCellDisplayText(RowHandle, colXJ);

                        FrmSaleDiscountCorrection FrmSDC = new FrmSaleDiscountCorrection(strXZ);
                        if (FrmSDC.ShowDialog() == DialogResult.OK)
                        {
                            bool fgCorrectStop = false;

                            selection.ClearSelection();
                            vClearSelectSummary();
                            if (!fgCorrectStop)
                            {
                                command.CommandType = CommandType.StoredProcedure;
                                command.CommandText = "JT_X_XSDMX_XZ_GZ";

                                command.Parameters.Add("ls_xsdid", OracleType.VarChar).Value = strXSDID;
                                command.Parameters.Add("ls_xsdmxid", OracleType.VarChar).Value = strXSDMXID;
                                command.Parameters.Add("ls_xz", OracleType.Double).Value = FrmSDC.getNewDiscount();
                                command.Parameters.Add("ls_xj", OracleType.Double).Value = FrmSDC.getNewDiscount();
                                command.Parameters.Add("Userid", OracleType.VarChar).Value = FrmLogin.getUserID;

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
            string strLayout = FrmLogin.getUser + "_SaleDetailLayout.xml";
            FileStream stream = new FileStream(strLayout, FileMode.Create);
            gridView1.SaveLayoutToStream(stream);
            stream.Close();
        }

        private void btnLoadLayout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strLayout = FrmLogin.getUser + "_SaleDetailLayout.xml";
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