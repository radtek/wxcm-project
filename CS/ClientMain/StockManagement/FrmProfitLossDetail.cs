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
    public partial class FrmProfitLossDetail : DevExpress.XtraEditors.XtraForm
    {
        

        GridCheckMarksSelection selection;

        double dYKMY = 0;
        double dYKSY = 0;
        Int64 i8YKCS = 0;


        public FrmProfitLossDetail(string strSYDID=null)
        {
            XpoDefault.ConnectionString = OracleConnectionProvider.GetConnectionString("XINHUA", "xxb", "pass");

            InitializeComponent();

            if (String.IsNullOrEmpty(strSYDID))
            {
                xpServerCollectionSource1.FixedFilterString = "[SYDMXID] Is Null";
            }
            else
            {
                xpServerCollectionSource1.FixedFilterString = strSYDID;
            }

            selection = new GridCheckMarksSelection(gridView1);
            selection.CheckMarkColumn.VisibleIndex = 0;

            gridView1.BestFitColumns();
        }

        private void gridView1_CustomDrawFooterCell(object sender, DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventArgs e)
        {
            FrmLogin.vDrawFootCell(e, colSYDH, "选计：");
            FrmLogin.vDrawFootCell(e, colYKSY, dYKSY.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colYKMY, dYKMY.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colYKCS, i8YKCS.ToString());
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
                    if (fc["FrmProfitLossNote"] != null)
                    {
                        fc["FrmProfitLossNote"].Close();
                    }
                    FrmProfitLossNote FrmPLN = new FrmProfitLossNote(strSYDID);
                    FrmPLN.Show();
                    FrmPLN.Activate();
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
                        double.TryParse(colYKSY.SummaryText, out dYKSY);
                        double.TryParse(colYKMY.SummaryText, out dYKMY);
                        Int64.TryParse(colYKCS.SummaryText, out i8YKCS);
                    }
                    else
                    {
                        dYKMY = 0;
                        dYKSY = 0;
                        i8YKCS = 0;
                    }

                }
                if (hitInfo.InRowCell)
                {
                    if (selection.IsRowSelected(hitInfo.RowHandle))
                    {
                        dYKMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colYKMY));
                        dYKSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colYKSY));
                        i8YKCS += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colYKCS));
                    }
                    else
                    {
                        dYKMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colYKMY));
                        dYKSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colYKSY));
                        i8YKCS -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colYKCS));
                    }
                }
            }                      
        }

        private void vClearSelectSummary()
        {
            dYKMY = 0;
            dYKSY = 0;
            i8YKCS = 0;
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

        private void btnColCustomize_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.ShowCustomization();
        }

        private void btnSaveLayout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strLayout = FrmLogin.getUser + "_ProfitLossDetailLayout.xml";
            FileStream stream = new FileStream(strLayout, FileMode.Create);
            gridView1.SaveLayoutToStream(stream);
            stream.Close();
        }

        private void btnLoadLayout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strLayout = FrmLogin.getUser + "_ProfitLossDetailLayout.xml";
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