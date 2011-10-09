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

namespace ClientMain
{
    public partial class FrmClientAccount : DevExpress.XtraEditors.XtraForm
    {

         

        GridCheckMarksSelection selection;

        Int64 i8QCKC = 0;
        double dQCMY = 0;
        double dQCSY = 0;
        Int64 i8JHSL = 0;
        double dJHMY = 0;
        double dJHSY = 0;
        Int64 i8XSSL = 0;
        double dXSMY = 0;
        double dXSSY = 0;
        Int64 i8JTSL = 0;
        double dJTSY = 0;
        double dJTMY = 0;
        Int64 i8QMKC = 0;
        double dQMMY = 0;
        double dQMSY = 0;
        Int64 i8ZZSL = 0;
        double dZZSY = 0;
        double dZZMY = 0;
        Int64 i8SYSL = 0;
        double dSYMY = 0;
        double dSYSY = 0;
        Int64 i8YJSL = 0;
        double dYJMY = 0;
        double dYJSY = 0;
        Int64 i8JHCS = 0;
        Int64 i8THCS = 0;
        Int64 i8KTZSL = 0;



        public FrmClientAccount(string strZTBMKHSPTZID=null)
        {
            XpoDefault.ConnectionString = FrmLogin.xpoDataCentStr;

            InitializeComponent();

            if (String.IsNullOrEmpty(strZTBMKHSPTZID))
            {
                xpServerCollectionSource1.FixedFilterString = "[ZTBMKHSPTZID] Is Null";
            }
            else
            {
                xpServerCollectionSource1.FixedFilterString = strZTBMKHSPTZID;
            }

            selection = new GridCheckMarksSelection(gridView1);
            selection.CheckMarkColumn.VisibleIndex = 0;

            gridView1.BestFitColumns();
        }


        private void gridView1_CustomDrawFooterCell(object sender, FooterCellCustomDrawEventArgs e)
        {
            FrmLogin.vDrawFootCell(e, colYWBMMC, "选计：");
            FrmLogin.vDrawFootCell(e, colZZSY, dZZSY.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colZZMY, dZZMY.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colSYMY, dSYMY.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colSYSY, dSYSY.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colJTSY, dJTSY.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colJTMY, dJTMY.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colQCSY, dQCSY.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colQCMY, dQCMY.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colQMSY, dQMSY.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colQMMY, dQMMY.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colJHSY, dJHSY.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colJHMY, dJHMY.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colXSSY, dXSSY.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colXSMY, dXSMY.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colYJSY, dYJSY.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colYJMY, dYJMY.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colYJSL, i8YJSL.ToString());
            FrmLogin.vDrawFootCell(e, colKTZSL, i8KTZSL.ToString());
            FrmLogin.vDrawFootCell(e, colXSSL, i8XSSL.ToString());
            FrmLogin.vDrawFootCell(e, colJHSL, i8JHSL.ToString());
            FrmLogin.vDrawFootCell(e, colQMKC, i8QMKC.ToString());
            FrmLogin.vDrawFootCell(e, colQCKC, i8QCKC.ToString());
            FrmLogin.vDrawFootCell(e, colJTSL, i8JTSL.ToString());
            FrmLogin.vDrawFootCell(e, colZZSL, i8ZZSL.ToString());
            FrmLogin.vDrawFootCell(e, colJHCS, i8JHCS.ToString());
            FrmLogin.vDrawFootCell(e, colTHCS, i8THCS.ToString());
            FrmLogin.vDrawFootCell(e, colSYSL, i8SYSL.ToString());
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
                if ((hitInfo.Column != null) && (hitInfo.Column == colYWBMMC))
                {
                    string strTemp = view.GetRowCellDisplayText(hitInfo.RowHandle, colZTBMKHSPTZID);
                    string strZTBMKHSPTZID = "[ZTBMKHSPTZID] = \'" + strTemp + "\'";
                    if (fc["FrmClientAccountDetail"] != null)
                    {
                        fc["FrmClientAccountDetail"].Close();
                    }
                    FrmClientAccountDetail FrmCAD = new FrmClientAccountDetail(strZTBMKHSPTZID);
                    FrmCAD.Show();
                    FrmCAD.Activate();
                }
            }
        }

        private void vClearSelectSummary()
        {
            i8QCKC = 0;
            dQCMY = 0;
            dQCSY = 0;
            i8JHSL = 0;
            dJHMY = 0;
            dJHSY = 0;
            i8XSSL = 0;
            dXSMY = 0;
            dXSSY = 0;
            i8KTZSL = 0;
            i8JTSL = 0;
            dJTSY = 0;
            dJTMY = 0;
            i8QMKC = 0;
            dQMMY = 0;
            dQMSY = 0;
            i8ZZSL = 0;
            dZZSY = 0;
            dZZMY = 0;
            i8SYSL = 0;
            dSYMY = 0;
            dSYSY = 0;
            i8YJSL = 0;
            dYJMY = 0;
            dYJSY = 0;
            i8JHCS = 0;
            i8THCS = 0;
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
                        double.TryParse(colXSSY.SummaryText, out dXSSY);
                        double.TryParse(colXSMY.SummaryText, out dXSMY);
                        double.TryParse(colJHSY.SummaryText, out dJHSY);
                        double.TryParse(colJHMY.SummaryText, out dJHMY);
                        double.TryParse(colSYSY.SummaryText, out dSYSY);
                        double.TryParse(colSYMY.SummaryText, out dSYMY);
                        double.TryParse(colQCSY.SummaryText, out dQCSY);
                        double.TryParse(colQCMY.SummaryText, out dQCMY);
                        double.TryParse(colQMSY.SummaryText, out dQMSY);
                        double.TryParse(colQMMY.SummaryText, out dQMMY);
                        double.TryParse(colZZSY.SummaryText, out dZZSY);
                        double.TryParse(colZZMY.SummaryText, out dZZMY);
                        double.TryParse(colJTSY.SummaryText, out dJTSY);
                        double.TryParse(colJTMY.SummaryText, out dJTMY);
                        double.TryParse(colYJSY.SummaryText, out dYJSY);
                        double.TryParse(colYJMY.SummaryText, out dYJMY);
                        Int64.TryParse(colJHCS.SummaryText, out i8JHCS);
                        Int64.TryParse(colTHCS.SummaryText, out i8THCS);
                        Int64.TryParse(colQMKC.SummaryText, out i8QMKC);
                        Int64.TryParse(colQCKC.SummaryText, out i8QCKC);
                        Int64.TryParse(colKTZSL.SummaryText, out i8KTZSL);
                        Int64.TryParse(colJTSL.SummaryText, out i8JTSL);
                        Int64.TryParse(colXSSL.SummaryText, out i8XSSL);
                        Int64.TryParse(colSYSL.SummaryText, out i8SYSL);
                        Int64.TryParse(colZZSL.SummaryText, out i8ZZSL);
                        Int64.TryParse(colYJSL.SummaryText, out i8YJSL);
                        Int64.TryParse(colJHSL.SummaryText, out i8JHSL);
                    }
                    else
                    {
                        i8QCKC = 0;
                        dQCMY = 0;
                        dQCSY = 0;
                        i8JHSL = 0;
                        dJHMY = 0;
                        dJHSY = 0;
                        i8XSSL = 0;
                        dXSMY = 0;
                        dXSSY = 0;
                        i8KTZSL = 0;
                        i8JTSL = 0;
                        dJTSY = 0;
                        dJTMY = 0;
                        i8QMKC = 0;
                        dQMMY = 0;
                        dQMSY = 0;
                        i8ZZSL = 0;
                        dZZSY = 0;
                        dZZMY = 0;
                        i8SYSL = 0;
                        dSYMY = 0;
                        dSYSY = 0;
                        i8YJSL = 0;
                        dYJMY = 0;
                        dYJSY = 0;
                        i8JHCS = 0;
                        i8THCS = 0;
                    }
                }
                if (hitInfo.InRowCell)
                {
                    if (selection.IsRowSelected(hitInfo.RowHandle))
                    {
                        dXSMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colXSMY));
                        dXSSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colXSSY));
                        dJHMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJHMY));
                        dJHSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJHSY));
                        dSYMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colSYMY));
                        dSYSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colSYSY));
                        dQCMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colQCMY));
                        dQCSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colQCSY));
                        dQMMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colQMMY));
                        dQMSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colQMSY));
                        dJTMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJTMY));
                        dJTSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJTSY));
                        dYJMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colYJMY));
                        dYJSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colYJSY));
                        dZZMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZZMY));
                        dZZSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZZSY));
                        i8JHCS += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colJHCS));
                        i8THCS += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colTHCS));
                        i8YJSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colYJSL));
                        i8KTZSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colKTZSL));
                        i8JTSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colJTSL));
                        i8ZZSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colZZSL));
                        i8QCKC += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colQCKC));
                        i8QMKC += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colQMKC));
                        i8XSSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colXSSL));
                        i8SYSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colSYSL));
                        i8JHSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colJHSL));
                    }
                    else
                    {
                        dXSMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colXSMY));
                        dXSSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colXSSY));
                        dJHMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJHMY));
                        dJHSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJHSY));
                        dSYMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colSYMY));
                        dSYSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colSYSY));
                        dQCMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colQCMY));
                        dQCSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colQCSY));
                        dQMMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colQMMY));
                        dQMSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colQMSY));
                        dJTMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJTMY));
                        dJTSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJTSY));
                        dYJMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colYJMY));
                        dYJSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colYJSY));
                        dZZMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZZMY));
                        dZZSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZZSY));
                        i8JHCS -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colJHCS));
                        i8THCS -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colTHCS));
                        i8YJSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colYJSL));
                        i8KTZSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colKTZSL));
                        i8JTSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colJTSL));
                        i8ZZSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colZZSL));
                        i8QCKC -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colQCKC));
                        i8QMKC -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colQMKC));
                        i8XSSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colXSSL));
                        i8SYSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colSYSL));
                        i8JHSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colJHSL));
                    }
                }
            }
        }

        private void btnMasterQuery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            gridView1.ShowFilterEditor(colYWBMMC);

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
                    FrmClientAccountDetail FrmCAD = new FrmClientAccountDetail();
                    FrmCAD.Show();
                    FrmCAD.Activate();
                }

            }
            else
            {
                string strZTBMKHSPTZID = null;
                for (int i = 0; i < selection.SelectedCount; ++i)
                {
                    int RowIndex = selection.GetSelectedRowIndex(i);
                    int RowHandle = gridView1.GetRowHandle(RowIndex);

                    string strTemp = gridView1.GetRowCellDisplayText(RowHandle, colZTBMKHSPTZID);
                    strZTBMKHSPTZID += "[ZTBMKHSPTZID] = \'" + strTemp + "\' Or ";
                }

                int index = strZTBMKHSPTZID.LastIndexOf("'");
                strZTBMKHSPTZID = strZTBMKHSPTZID.Substring(0, index + 1).Trim();

                FrmClientAccountDetail FrmCAD = new FrmClientAccountDetail(strZTBMKHSPTZID);
                FrmCAD.Show();
                FrmCAD.Activate();
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
            string strLayout = FrmLogin.getUser + "_ClientAccountLayout.xml";
            FileStream stream = new FileStream(strLayout, FileMode.Create);
            gridView1.SaveLayoutToStream(stream);
            stream.Close();
        }

        private void btnLoadLayout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strLayout = FrmLogin.getUser + "_ClientAccountLayout.xml";
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