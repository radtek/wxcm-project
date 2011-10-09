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
    public partial class FrmPurchaseReceiveDetail : DevExpress.XtraEditors.XtraForm
    {
        

        GridCheckMarksSelection selection;

        double dDJ = 0;
        double dJZ = 0;
        double dJJ = 0;
        Int64 i8YDSL = 0;
        double dYDMY = 0;
        double dYDSY = 0;
        Int64 i8SSSL = 0;
        double dSSMY = 0;
        double dSSSY = 0;
        Int64 i8ZPSL = 0;
        double dZPMY = 0;
        double dZPSY = 0;
        Int64 i8ZZSL = 0;
        double dZZMY = 0;
        double dZZSY = 0;
        Int64 i8YFSL = 0;
        double dYFMY = 0;
        double dYFSY = 0;

        bool m_fgBranch = false;

        public FrmPurchaseReceiveDetail(bool fgBranch,string strCGSHID=null)
        {
            XpoDefault.ConnectionString = FrmLogin.xpoDataCentStr;
                        
            InitializeComponent();

            //xpInstantFeedbackSource1.FixedFilterString = strCGSHID;
            //gridControl1.DataSource = xpInstantFeedbackSource1;
            if (String.IsNullOrEmpty(strCGSHID))
            {
                xpServerCollectionSource1.FixedFilterString = "[CGSHMXID] Is Null";
            }
            else
            {
                xpServerCollectionSource1.FixedFilterString = strCGSHID;
            }
            selection = new GridCheckMarksSelection(gridView1);
            selection.CheckMarkColumn.VisibleIndex = 0;

            gridView1.BestFitColumns();
            m_fgBranch = fgBranch;
        }


        private void FrmPurchaseReceiveDetail_Load(object sender, EventArgs e)
        {
            
        }

        private void gridView1_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator & e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString().Trim();
            }
        }

        private void btnColCustomize_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.ShowCustomization();
        }

        private void btnSaveLayout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strLayout = FrmLogin.getUser + "_PurchaseReceiveNoteDetailLayout.xml";
            FileStream stream = new FileStream(strLayout, FileMode.Create);
            gridView1.SaveLayoutToStream(stream);
            stream.Close();
        }

        private void btnLoadLayout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strLayout = FrmLogin.getUser + "_PurchaseReceiveNoteDetailLayout.xml";
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

        private void vClearSelectSummary()
        {
            dSSMY = 0;
            dSSSY = 0;
            dYDMY = 0;
            dYDSY = 0;
            dYFMY = 0;
            dYFSY = 0;
            dZPMY = 0;
            dZPSY = 0;
            dZZMY = 0;
            dZZSY = 0;
            dJJ = 0;
            i8SSSL = 0;
            dJZ = 0;
            dDJ = 0;
            i8YDSL = 0;
            i8YFSL = 0;
            i8ZPSL = 0;
            i8ZZSL = 0;
        }

        private void btnDetailQuery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            gridView1.ShowFilterEditor(colCGSHDH);

            if (!String.IsNullOrEmpty(gridView1.ActiveFilterString))
            {
                selection.ClearSelection();
                vClearSelectSummary();
                xpServerCollectionSource1.FixedFilterString = gridView1.ActiveFilterString + " And [ZTID] = \'" + FrmLogin.getZTID + "\'";
                
                gridView1.BestFitColumns();
            }

            
            //if (!String.IsNullOrEmpty(gridView1.ActiveFilterString))
            //{
            //    xpInstantFeedbackSource1.FixedFilterString = gridView1.ActiveFilterString + " And [ZTID] = \'" + FrmLogin.getZTID + "\'";
            
            //    gridView1.BestFitColumns();
            //}
            
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
                        int RowIndex = selection.GetSelectedRowIndex(0);
                        int RowHandle = gridView1.GetRowHandle(RowIndex);

                        string strCGSHID = gridView1.GetRowCellDisplayText(RowHandle, colCGSHID);
                        string strCGSHMXID = gridView1.GetRowCellDisplayText(RowHandle, colCGSHMXID);                       
                        string strJZ = gridView1.GetRowCellDisplayText(RowHandle, colJZ);

                        FrmDiscountCorrection FrmDC = new FrmDiscountCorrection(strJZ);
                        if (FrmDC.ShowDialog() == DialogResult.OK)
                        {
                            bool fgCorrectStop = false;

                            selection.ClearSelection();
                            vClearSelectSummary();
                            if (!fgCorrectStop)
                            {
                                command.CommandType = CommandType.StoredProcedure;
                                command.CommandText = "JT_G_CGSHMX_JZ_GZ";

                                command.Parameters.Add("ls_cgshid", OracleType.VarChar).Value = strCGSHID;
                                command.Parameters.Add("ls_cgshmxid", OracleType.VarChar).Value = strCGSHMXID;
                                command.Parameters.Add("ls_jz", OracleType.Double).Value = FrmDC.getNewDiscount();
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

        public void btnExportGrid_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        private void gridView1_CustomDrawFooterCell(object sender, FooterCellCustomDrawEventArgs e)
        {
            FrmLogin.vDrawFootCell(e, colCGSHDH, "选计：");
            FrmLogin.vDrawFootCell(e, colDJ, dDJ.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colJJ, dJJ.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colJZ, dJZ.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colYDSL, i8YDSL.ToString());
            FrmLogin.vDrawFootCell(e, colYDMY, dYDMY.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colYDSY, dYDSY.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colSSSL, i8SSSL.ToString());
            FrmLogin.vDrawFootCell(e, colSSMY, dSSMY.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colSSSY, dSSSY.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colZZSL, i8ZZSL.ToString());
            FrmLogin.vDrawFootCell(e, colZZMY, dZZMY.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colZZSY, dZZSY.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colZPSL, i8ZPSL.ToString());
            FrmLogin.vDrawFootCell(e, colZPSY, dZPSY.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colZPMY, dZPMY.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colYFMY, dYFMY.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colYFSY, dYFSY.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colYFSL, i8YFSL.ToString());

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
                        double.TryParse(colSSMY.SummaryText, out dSSMY);
                        double.TryParse(colSSSY.SummaryText, out dSSSY);
                        double.TryParse(colYDMY.SummaryText, out dYDMY);
                        double.TryParse(colYDSY.SummaryText, out dYDSY);
                        double.TryParse(colYFMY.SummaryText, out dYFMY);
                        double.TryParse(colYFSY.SummaryText, out dYFSY);
                        double.TryParse(colZPMY.SummaryText, out dZPMY);
                        double.TryParse(colZPSY.SummaryText, out dZPSY);
                        double.TryParse(colZZMY.SummaryText, out dZZMY);
                        double.TryParse(colZZSY.SummaryText, out dZZSY);
                        double.TryParse(colJJ.SummaryText, out dJJ);
                        double.TryParse(colJZ.SummaryText, out dJZ);
                        double.TryParse(colDJ.SummaryText, out dDJ);
                        Int64.TryParse(colSSSL.SummaryText, out i8SSSL);
                        Int64.TryParse(colZZSL.SummaryText, out i8ZZSL); 
                        Int64.TryParse(colZPSL.SummaryText, out i8ZPSL);
                        Int64.TryParse(colYDSL.SummaryText, out i8YDSL);
                        Int64.TryParse(colYFSL.SummaryText, out i8YFSL);
                    }
                    else
                    {
                        dSSMY = 0;
                        dSSSY = 0;
                        dYDMY = 0;
                        dYDSY = 0;
                        dYFMY = 0;
                        dYFSY = 0;
                        dZPMY = 0;
                        dZPSY = 0;
                        dZZMY = 0;
                        dZZSY = 0;
                        dJJ = 0;
                        i8SSSL = 0;
                        dJZ = 0;
                        dDJ = 0;
                        i8YDSL = 0;
                        i8YFSL = 0;
                        i8ZPSL = 0;
                        i8ZZSL = 0;
                    }

                }
                if (hitInfo.InRowCell)
                {
                    if (selection.IsRowSelected(hitInfo.RowHandle))
                    {
                        dYDMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colYDMY));
                        dSSMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colSSMY));
                        dSSSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colSSSY));
                        dYDSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colYDSY));
                        dYFMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colYFMY));
                        dYFSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colYFSY));
                        dZPMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZPMY));
                        dZPSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZPSY));
                        dZZMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZZMY));
                        dZZSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZZSY));
                        dJJ += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJJ));
                        i8SSSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colSSSL));
                        dJZ += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJZ));
                        dDJ += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colDJ));
                        i8YDSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colYDSL));
                        i8YFSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colYFSL));
                        i8ZPSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colZPSL));
                        i8ZZSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colZZSL));
                    }
                    else
                    {
                        dYDMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colYDMY));
                        dSSMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colSSMY));
                        dSSSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colSSSY));
                        dYDSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colYDSY));
                        dYFMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colYFMY));
                        dYFSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colYFSY));
                        dZPMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZPMY));
                        dZPSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZPSY));
                        dZZMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZZMY));
                        dZZSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZZSY));
                        dJJ -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJJ));
                        i8SSSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colSSSL));
                        dJZ -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJZ));
                        dDJ -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colDJ));
                        i8YDSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colYDSL));
                        i8YFSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colYFSL));
                        i8ZPSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colZPSL));
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
                if ((hitInfo.Column != null) && (hitInfo.Column == colCGSHDH))
                {
                    string strTemp = view.GetRowCellDisplayText(hitInfo.RowHandle, colCGSHID);
                    string strCGSHID = "[CGSHID] = \'" + strTemp + "\'";
                    if (fc["FrmPurchaseReceiveNote"] != null)
                    {
                        fc["FrmPurchaseReceiveNote"].Close();
                    }         
                    FrmPurchaseReceiveNote FrmPRN = new FrmPurchaseReceiveNote(m_fgBranch, strCGSHID);
                    FrmPRN.Show();
                    FrmPRN.Activate();
                }
            }
        }
        //private void xpInstantFeedbackSource1_DismissSession(object sender, ResolveSessionEventArgs e)
        //{
        //    IDisposable session = e.Session as IDisposable;
        //    if (session != null)
        //    {
        //        session.Dispose();
        //    }
        //}

        //private void xpInstantFeedbackSource1_ResolveSession(object sender, ResolveSessionEventArgs e)
        //{
        //    unitOfWork1.ConnectionString = OracleConnectionProvider.GetConnectionString("XINHUA", "xxb", "pass");
        //    unitOfWork1.Connect();
        //    e.Session = unitOfWork1;
        //}         

    }
}