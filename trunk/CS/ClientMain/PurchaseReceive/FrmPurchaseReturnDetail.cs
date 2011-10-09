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
    public partial class FrmPurchaseReturnDetail : DevExpress.XtraEditors.XtraForm
    {
        

        GridCheckMarksSelection selection;

        double dDJ = 0;
        double dJJ = 0;
        double dJZ = 0;
        double dJTMY = 0;
        double dJTSY = 0;
        Int64 i8JTSL = 0;

        bool m_fgBranch = false;

        public FrmPurchaseReturnDetail(bool fgBranch, string strJTDID = null)
        {
            XpoDefault.ConnectionString = FrmLogin.xpoDataCentStr;

            InitializeComponent();
            if (String.IsNullOrEmpty(strJTDID))
            {
                xpServerCollectionSource1.FixedFilterString = "[JTDMXID] Is Null";
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

        private void vClearSelectSummary()
        {
            dJTMY = 0;
            dJTSY = 0;
            dJJ = 0;
            i8JTSL = 0;
            dJZ = 0;
            dDJ = 0;   
        }

        private void btnDetailQuery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        private void btnColCustomize_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.ShowCustomization();
        }

        private void btnSaveLayout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strLayout = FrmLogin.getUser + "_PurchaseReturnDetailLayout.xml";
            FileStream stream = new FileStream(strLayout, FileMode.Create);
            gridView1.SaveLayoutToStream(stream);
            stream.Close();
        }

        private void btnLoadLayout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strLayout = FrmLogin.getUser + "_PurchaseReturnDetailLayout.xml";
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


        private void gridView1_CustomDrawFooterCell(object sender, DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventArgs e)
        {
            FrmLogin.vDrawFootCell(e, colJTDH, "选计：");
            FrmLogin.vDrawFootCell(e, colDJ, dDJ.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colJJ, dJJ.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colJZ, dJZ.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colJTSL, i8JTSL.ToString());
            FrmLogin.vDrawFootCell(e, colJTMY, dJTMY.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colJTSY, dJTSY.ToString("F2"));
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
                if ((hitInfo.Column != null) && (hitInfo.Column == colJTDH))
                {
                    string strTemp = view.GetRowCellDisplayText(hitInfo.RowHandle, colJTDID);
                    string strJTDID = "[JTDID] = \'" + strTemp + "\'";
                    if (fc["FrmPurchaseReturnNote"] != null)
                    {
                        fc["FrmPurchaseReturnNote"].Close();
                    }
                    FrmPurchaseReturnNote FrmPRN = new FrmPurchaseReturnNote(m_fgBranch, strJTDID);
                    FrmPRN.Show();
                    FrmPRN.Activate();
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
                        double.TryParse(colJTMY.SummaryText, out dJTMY);
                        double.TryParse(colJTSY.SummaryText, out dJTSY);
                        double.TryParse(colJJ.SummaryText, out dJJ);
                        double.TryParse(colJZ.SummaryText, out dJZ);
                        double.TryParse(colDJ.SummaryText, out dDJ);
                        Int64.TryParse(colJTSL.SummaryText, out i8JTSL);
                    }
                    else
                    {
                        dJTMY = 0;
                        dJTSY = 0;                        
                        dJJ = 0;
                        i8JTSL = 0;
                        dJZ = 0;
                        dDJ = 0;                        
                    }

                }
                if (hitInfo.InRowCell)
                {
                    if (selection.IsRowSelected(hitInfo.RowHandle))
                    {
                        dJTMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJTMY));
                        dJTMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJTMY));                        
                        dJJ += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJJ));
                        i8JTSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colJTSL));
                        dJZ += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJZ));
                        dDJ += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colDJ));                        
                    }
                    else
                    {
                        dJTMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJTMY));
                        dJTMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJTMY));                        
                        dJJ -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJJ));
                        i8JTSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colJTSL));
                        dJZ -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJZ));
                        dDJ -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colDJ));                        
                    }
                }
            }
        }
    }
}