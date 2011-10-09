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

namespace ClientMain
{
    public partial class FrmSaleReturnDetail : DevExpress.XtraEditors.XtraForm
    {
        

        GridCheckMarksSelection selection;

        Int64 i8XTSL = 0;
        double dXTMY = 0;
        double dXTSY = 0;
        Int64 i8YSSL = 0;
        double dYSMY = 0;
        double dYSSY = 0;
        Int64 i8ZZSL = 0;
        double dZZMY = 0;
        double dZZSY = 0;

        bool m_fgBranch = false;

        public FrmSaleReturnDetail(bool fgBranch, string strXTDID=null)
        {
            XpoDefault.ConnectionString = FrmLogin.xpoDataCentStr;

            InitializeComponent();
            if (String.IsNullOrEmpty(strXTDID))
            {
                xpServerCollectionSource1.FixedFilterString = "[XTDMXID] Is Null";
            }
            else
            {
                xpServerCollectionSource1.FixedFilterString = strXTDID;
            }
            selection = new GridCheckMarksSelection(gridView1);
            selection.CheckMarkColumn.VisibleIndex = 0;

            gridView1.BestFitColumns();

            m_fgBranch = fgBranch;
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

        private void gridView1_CustomDrawFooterCell(object sender, DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventArgs e)
        {
            FrmLogin.vDrawFootCell(e, colXTDH, "选计：");
            FrmLogin.vDrawFootCell(e, colZZSY, dZZSY.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colZZMY, dZZMY.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colXTMY, dXTMY.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colXTSY, dXTSY.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colYSSY, dYSSY.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colYSMY, dYSMY.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colYSSL, i8YSSL.ToString());
            FrmLogin.vDrawFootCell(e, colZZSL, i8ZZSL.ToString());            
            FrmLogin.vDrawFootCell(e, colXTSL, i8XTSL.ToString());
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
                if ((hitInfo.Column != null) && (hitInfo.Column == colXTDH))
                {
                    string strTemp = view.GetRowCellDisplayText(hitInfo.RowHandle, colXTDID);
                    string strXTDID = "[XTDID] = \'" + strTemp + "\'";
                    if (fc["FrmSaleReturnNote"] != null)
                    {
                        fc["FrmSaleReturnNote"].Close();
                    }
                    FrmSaleReturnNote FrmSRN = new FrmSaleReturnNote(m_fgBranch, strXTDID);
                    FrmSRN.Show();
                    FrmSRN.Activate();
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
                        double.TryParse(colZZSY.SummaryText, out dZZSY);
                        double.TryParse(colZZMY.SummaryText, out dZZMY);
                        double.TryParse(colXTSY.SummaryText, out dXTSY);
                        double.TryParse(colXTMY.SummaryText, out dXTMY);
                        double.TryParse(colYSSY.SummaryText, out dYSSY);
                        double.TryParse(colYSMY.SummaryText, out dYSMY);
                        Int64.TryParse(colYSSL.SummaryText, out i8YSSL);
                        Int64.TryParse(colXTSL.SummaryText, out i8XTSL);
                        Int64.TryParse(colZZSL.SummaryText, out i8ZZSL);
                    }
                    else
                    {
                        dXTMY = 0;
                        dXTSY = 0;
                        dYSMY = 0;
                        dYSSY = 0;
                        dZZMY = 0;
                        dZZSY = 0;
                        i8XTSL = 0;
                        i8YSSL = 0;
                        i8ZZSL = 0;
                    }

                }
                if (hitInfo.InRowCell)
                {
                    if (selection.IsRowSelected(hitInfo.RowHandle))
                    {
                        dXTMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colXTMY));
                        dXTSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colXTSY));
                        dYSMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colYSMY));
                        dYSSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colYSSY));
                        dZZMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZZMY));
                        dZZSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZZSY));
                        i8YSSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colYSSL));
                        i8XTSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colXTSL));
                        i8ZZSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colZZSL));
                    }
                    else
                    {
                        dXTMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colXTMY));
                        dXTSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colXTSY));
                        dYSMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colYSMY));
                        dYSSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colYSSY));
                        dZZMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZZMY));
                        dZZSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZZSY));
                        i8YSSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colYSSL));
                        i8XTSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colXTSL));
                        i8ZZSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colZZSL));
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

        private void vClearSelectSummary()
        {
            dXTMY = 0;
            dXTSY = 0;
            dYSMY = 0;
            dYSSY = 0;
            dZZMY = 0;
            dZZSY = 0;
            i8XTSL = 0;
            i8YSSL = 0;
            i8ZZSL = 0;
        }

        private void btnDetailQuery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            gridView1.ShowFilterEditor(colXTDH);

            if (!String.IsNullOrEmpty(gridView1.ActiveFilterString))
            {
                selection.ClearSelection();
                vClearSelectSummary();
                xpServerCollectionSource1.FixedFilterString = gridView1.ActiveFilterString + " And [ZTID] = \'" + FrmLogin.getZTID + "\'";

                gridView1.BestFitColumns();
            }
        }

        private void btnColCustomize_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.ShowCustomization();
        }

        private void btnSaveLayout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strLayout = FrmLogin.getUser + "_SaleReturnDetailLayout.xml";
            FileStream stream = new FileStream(strLayout, FileMode.Create);
            gridView1.SaveLayoutToStream(stream);
            stream.Close();
        }

        private void btnLoadLayout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strLayout = FrmLogin.getUser + "_SaleReturnDetailLayout.xml";
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