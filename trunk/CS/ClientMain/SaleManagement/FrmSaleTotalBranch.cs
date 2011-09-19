﻿using System;
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
    public partial class FrmSaleTotalBranch : DevExpress.XtraEditors.XtraForm
    {
        

        GridCheckMarksSelection selection;

        Int64 i8FXFLSL1 = 0;
        Int64 i8FXFLSL2 = 0;
        Int64 i8FXFLSL3 = 0;
        Int64 i8FXFLSL4 = 0;
        Int64 i8FXFLSL5 = 0;
        Int64 i8FXFLSL6 = 0;
        Int64 i8FXFLSL7 = 0;
        Int64 i8FXFLSL8 = 0;
        Int64 i8FXFLSL9 = 0;
        Int64 i8FXFLSL10 = 0;
        double dFXFLJE1 = 0;
        double dFXFLJE2 = 0;
        double dFXFLJE3 = 0;
        double dFXFLJE4 = 0;
        double dFXFLJE5 = 0;
        double dFXFLJE6 = 0;
        double dFXFLJE7 = 0;
        double dFXFLJE8 = 0;
        double dFXFLJE9 = 0;
        double dFXFLJE10 = 0;
        bool m_fgBranch = false;
        public FrmSaleTotalBranch(bool fgBranch, string strXSHZDID = null)
        {
            XpoDefault.ConnectionString = OracleConnectionProvider.GetConnectionString("XINHUA", "xxb", "pass");

            InitializeComponent();
            if (String.IsNullOrEmpty(strXSHZDID))
            {
                xpServerCollectionSource1.FixedFilterString = "[XSHZDID] Is Null";
            }
            else
            {
                xpServerCollectionSource1.FixedFilterString = strXSHZDID;
            }
            selection = new GridCheckMarksSelection(gridView1);
            selection.CheckMarkColumn.VisibleIndex = 0;

            gridView1.BestFitColumns();
            m_fgBranch = fgBranch;
        }

 
        private void gridView1_CustomDrawFooterCell(object sender, DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventArgs e)
        {
            FrmLogin.vDrawFootCell(e, colSTATUSMC, "选计：");
            FrmLogin.vDrawFootCell(e, colFXFLJE1, dFXFLJE1.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colFXFLJE2, dFXFLJE2.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colFXFLJE3, dFXFLJE3.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colFXFLJE4, dFXFLJE4.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colFXFLJE5, dFXFLJE5.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colFXFLJE6, dFXFLJE6.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colFXFLJE7, dFXFLJE7.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colFXFLJE8, dFXFLJE8.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colFXFLJE9, dFXFLJE9.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colFXFLJE10, dFXFLJE10.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colFXFLSL1, i8FXFLSL1.ToString());
            FrmLogin.vDrawFootCell(e, colFXFLSL2, i8FXFLSL2.ToString());
            FrmLogin.vDrawFootCell(e, colFXFLSL3, i8FXFLSL3.ToString());
            FrmLogin.vDrawFootCell(e, colFXFLSL4, i8FXFLSL4.ToString());
            FrmLogin.vDrawFootCell(e, colFXFLSL5, i8FXFLSL5.ToString());
            FrmLogin.vDrawFootCell(e, colFXFLSL6, i8FXFLSL6.ToString());
            FrmLogin.vDrawFootCell(e, colFXFLSL7, i8FXFLSL7.ToString());
            FrmLogin.vDrawFootCell(e, colFXFLSL8, i8FXFLSL8.ToString());
            FrmLogin.vDrawFootCell(e, colFXFLSL9, i8FXFLSL9.ToString());
            FrmLogin.vDrawFootCell(e, colFXFLSL10, i8FXFLSL10.ToString());
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
            FormCollection fc = Application.OpenForms;
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));
            if (hitInfo.HitTest == GridHitTest.RowCell)
            {
                if ((hitInfo.Column != null) && (hitInfo.Column == colXSHZDH))
                {
                    string strTemp = view.GetRowCellDisplayText(hitInfo.RowHandle, colXSHZDID);
                    string strXSHZDID = "[XSHZDID] = \'" + strTemp + "\'";
                    if (fc["FrmSaleTotalDetailBranch"] != null)
                    {
                        fc["FrmSaleTotalDetailBranch"].Close();
                    }
                    FrmSaleTotalDetailBranch FrmSTDB = new FrmSaleTotalDetailBranch(m_fgBranch, strXSHZDID);
                    FrmSTDB.Show();
                    FrmSTDB.Activate();
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
                        double.TryParse(colFXFLJE1.SummaryText, out dFXFLJE1);
                        double.TryParse(colFXFLJE2.SummaryText, out dFXFLJE2);
                        double.TryParse(colFXFLJE3.SummaryText, out dFXFLJE3);
                        double.TryParse(colFXFLJE4.SummaryText, out dFXFLJE4);
                        double.TryParse(colFXFLJE5.SummaryText, out dFXFLJE5);
                        double.TryParse(colFXFLJE6.SummaryText, out dFXFLJE6);
                        double.TryParse(colFXFLJE7.SummaryText, out dFXFLJE7);
                        double.TryParse(colFXFLJE8.SummaryText, out dFXFLJE8);
                        double.TryParse(colFXFLJE9.SummaryText, out dFXFLJE9);
                        double.TryParse(colFXFLJE10.SummaryText, out dFXFLJE10); 
                        Int64.TryParse(colFXFLSL1.SummaryText, out i8FXFLSL1);
                        Int64.TryParse(colFXFLSL2.SummaryText, out i8FXFLSL2);
                        Int64.TryParse(colFXFLSL3.SummaryText, out i8FXFLSL3);
                        Int64.TryParse(colFXFLSL4.SummaryText, out i8FXFLSL4);
                        Int64.TryParse(colFXFLSL5.SummaryText, out i8FXFLSL5);
                        Int64.TryParse(colFXFLSL6.SummaryText, out i8FXFLSL6);
                        Int64.TryParse(colFXFLSL7.SummaryText, out i8FXFLSL7);
                        Int64.TryParse(colFXFLSL8.SummaryText, out i8FXFLSL8);
                        Int64.TryParse(colFXFLSL9.SummaryText, out i8FXFLSL9);
                        Int64.TryParse(colFXFLSL10.SummaryText, out i8FXFLSL10);
                    }
                    else
                    {
                        dFXFLJE1 = 0;
                        dFXFLJE2 = 0;
                        dFXFLJE3 = 0;
                        dFXFLJE4 = 0;
                        dFXFLJE5 = 0;
                        dFXFLJE6 = 0;
                        dFXFLJE7 = 0;
                        dFXFLJE8 = 0;
                        dFXFLJE9 = 0;
                        dFXFLJE10 = 0;
                        i8FXFLSL1 = 0;
                        i8FXFLSL2 = 0;
                        i8FXFLSL3 = 0;
                        i8FXFLSL4 = 0;
                        i8FXFLSL5 = 0;
                        i8FXFLSL6 = 0;
                        i8FXFLSL7 = 0;
                        i8FXFLSL8 = 0;
                        i8FXFLSL9 = 0;
                        i8FXFLSL10 = 0;
                    }

                }
                if (hitInfo.InRowCell)
                {
                    if (selection.IsRowSelected(hitInfo.RowHandle))
                    {
                        dFXFLJE1 += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colFXFLJE1));
                        dFXFLJE2 += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colFXFLJE2));
                        dFXFLJE3 += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colFXFLJE3));
                        dFXFLJE4 += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colFXFLJE4));
                        dFXFLJE5 += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colFXFLJE5));
                        dFXFLJE6 += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colFXFLJE6));
                        dFXFLJE7 += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colFXFLJE7));
                        dFXFLJE8 += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colFXFLJE8));
                        dFXFLJE9 += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colFXFLJE9));
                        dFXFLJE10 += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colFXFLJE10));
                        i8FXFLSL1 += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colFXFLSL1));
                        i8FXFLSL2 += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colFXFLSL2));
                        i8FXFLSL3 += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colFXFLSL3));
                        i8FXFLSL4 += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colFXFLSL4));
                        i8FXFLSL5 += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colFXFLSL5));
                        i8FXFLSL6 += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colFXFLSL6));
                        i8FXFLSL7 += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colFXFLSL7));
                        i8FXFLSL8 += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colFXFLSL8));
                        i8FXFLSL9 += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colFXFLSL9));
                        i8FXFLSL10 += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colFXFLSL10));
                    }
                    else
                    {
                        dFXFLJE1 -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colFXFLJE1));
                        dFXFLJE2 -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colFXFLJE2));
                        dFXFLJE3 -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colFXFLJE3));
                        dFXFLJE4 -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colFXFLJE4));
                        dFXFLJE5 -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colFXFLJE5));
                        dFXFLJE6 -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colFXFLJE6));
                        dFXFLJE7 -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colFXFLJE7));
                        dFXFLJE8 -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colFXFLJE8));
                        dFXFLJE9 -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colFXFLJE9));
                        dFXFLJE10 -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colFXFLJE10));
                        i8FXFLSL1 -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colFXFLSL1));
                        i8FXFLSL2 -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colFXFLSL2));
                        i8FXFLSL3 -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colFXFLSL3));
                        i8FXFLSL4 -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colFXFLSL4));
                        i8FXFLSL5 -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colFXFLSL5));
                        i8FXFLSL6 -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colFXFLSL6));
                        i8FXFLSL7 -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colFXFLSL7));
                        i8FXFLSL8 -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colFXFLSL8));
                        i8FXFLSL9 -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colFXFLSL9));
                        i8FXFLSL10 -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colFXFLSL10));
                    }
                }
            }    
        }

        private void vClearSelectSummary()
        {
            dFXFLJE1 = 0;
            dFXFLJE2 = 0;
            dFXFLJE3 = 0;
            dFXFLJE4 = 0;
            dFXFLJE5 = 0;
            dFXFLJE6 = 0;
            dFXFLJE7 = 0;
            dFXFLJE8 = 0;
            dFXFLJE9 = 0;
            dFXFLJE10 = 0;
            i8FXFLSL1 = 0;
            i8FXFLSL2 = 0;
            i8FXFLSL3 = 0;
            i8FXFLSL4 = 0;
            i8FXFLSL5 = 0;
            i8FXFLSL6 = 0;
            i8FXFLSL7 = 0;
            i8FXFLSL8 = 0;
            i8FXFLSL9 = 0;
            i8FXFLSL10 = 0;
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
                FrmSaleTotalDetailBranch FrmSTDB = new FrmSaleTotalDetailBranch(m_fgBranch);
                FrmSTDB.Show();
                FrmSTDB.Activate();
                //}

            }
            else
            {
                string strXSHZDID = null;
                for (int i = 0; i < selection.SelectedCount; ++i)
                {
                    int RowIndex = selection.GetSelectedRowIndex(i);
                    int RowHandle = gridView1.GetRowHandle(RowIndex);

                    string strTemp = gridView1.GetRowCellDisplayText(RowHandle, colXSHZDID);
                    strXSHZDID += "[XSHZDID] = \'" + strTemp + "\' Or ";
                }

                int index = strXSHZDID.LastIndexOf("'");
                strXSHZDID = strXSHZDID.Substring(0, index + 1).Trim();

                FrmSaleTotalDetailBranch FrmSTDB = new FrmSaleTotalDetailBranch(m_fgBranch, strXSHZDID);
                FrmSTDB.Show();
                FrmSTDB.Activate();
            }
        }

        private void btnConfirm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strXSHZDID = "";
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
                        string strTemp = gridView1.GetRowCellDisplayText(RowHandle, colXSHZDID);
                        strXSHZDID += "\'" + strTemp + "\', ";
                    }
                    else
                    {
                        strXSHZDID = "";
                        MessageBox.Show("所选记录已被确认，请重新选择！");
                        break;
                    }

                }

                selection.ClearSelection();
                vClearSelectSummary();
                if (!String.IsNullOrEmpty(strXSHZDID))
                {
                    using (OracleConnection connection = new OracleConnection(FrmLogin.strCon))
                    {
                        connection.Open();
                        OracleCommand command = connection.CreateCommand();
                        OracleTransaction transaction = connection.BeginTransaction();
                        command.Connection = connection;
                        command.Transaction = transaction;

                        int index = strXSHZDID.LastIndexOf("'");
                        strXSHZDID = strXSHZDID.Substring(0, index + 1).Trim();

                        try
                        {
                            string strSQL = "update jc_c_xshzd set zt = '15', czrq = sysdate where XSHZDID in (" + strXSHZDID + ")";
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

        private void btnColCustomize_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.ShowCustomization();
        }

        private void btnSaveLayout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strLayout = FrmLogin.getUser + "_SaleTotalLayout.xml";
            FileStream stream = new FileStream(strLayout, FileMode.Create);
            gridView1.SaveLayoutToStream(stream);
            stream.Close();
        }

        private void btnLoadLayout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strLayout = FrmLogin.getUser + "_SaleTotalLayout.xml";
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

        private void btnPrintNote_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strXSHZDID = "";
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

                    string strTemp = gridView1.GetRowCellDisplayText(RowHandle, colXSHZDID);
                    strXSHZDID += "\'" + strTemp + "\', ";
                }

                int index = strXSHZDID.LastIndexOf("'");
                strXSHZDID = strXSHZDID.Substring(0, index + 1).Trim();

                XSHZDReport report = new XSHZDReport(strXSHZDID, m_fgBranch);
                report.ShowPreviewDialog();
            }
        }

        private void btnSummaryPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strXSHZDID = "";
            string strXSHZDH = "";
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

                    string strTemp = gridView1.GetRowCellDisplayText(RowHandle, colXSHZDID);
                    string strTempDH = gridView1.GetRowCellDisplayText(RowHandle, colXSHZDH);
                    strXSHZDID += "\'" + strTemp + "\', ";
                    strXSHZDH += strTempDH + Environment.NewLine;
                }

                int index = strXSHZDID.LastIndexOf("'");
                strXSHZDID = strXSHZDID.Substring(0, index + 1).Trim();

                XSHZDTotalReport report = new XSHZDTotalReport(strXSHZDID, strXSHZDH, m_fgBranch);
                report.ShowPreviewDialog();
            }
        }
    }
}