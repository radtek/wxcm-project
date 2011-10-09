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
    public partial class FrmPurchaseCollectionDetail : DevExpress.XtraEditors.XtraForm
    {
        

        GridCheckMarksSelection selection;

        Int64 i8SL = 0;
        double dSE = 0;
        double dWSJE = 0;
        double dJSHJ = 0;

        public FrmPurchaseCollectionDetail(string strCGTSDID=null)
        {
            XpoDefault.ConnectionString = FrmLogin.xpoDataCentStr;

            InitializeComponent();
            if (String.IsNullOrEmpty(strCGTSDID))
            {
                xpServerCollectionSource1.FixedFilterString = "[CGTSDMXID] Is Null";
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
            FrmLogin.vDrawFootCell(e, colCGTSDH, "选计：");
            FrmLogin.vDrawFootCell(e, colJSHJ, dJSHJ.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colWSJE, dWSJE.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colSE, dSE.ToString("F2"));            
            FrmLogin.vDrawFootCell(e, colSL, i8SL.ToString());
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
                    if (fc["FrmPurchaseCollectionNote"] != null)
                    {
                        fc["FrmPurchaseCollectionNote"].Close();
                    }
                    FrmPurchaseCollectionNote FrmPCN = new FrmPurchaseCollectionNote(strCGTSDID);
                    FrmPCN.Show();
                    FrmPCN.Activate();
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
                        double.TryParse(colSE.SummaryText, out dSE);
                        double.TryParse(colJSHJ.SummaryText, out dJSHJ);
                        double.TryParse(colWSJE.SummaryText, out dWSJE);                       
                        Int64.TryParse(colSL.SummaryText, out i8SL);
                    }
                    else
                    {
                        dSE = 0;
                        dJSHJ = 0;
                        dWSJE = 0;                        
                        i8SL = 0;
                    }

                }
                if (hitInfo.InRowCell)
                {
                    if (selection.IsRowSelected(hitInfo.RowHandle))
                    {
                        dSE += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colSE));
                        dJSHJ += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJSHJ));
                        dWSJE += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colWSJE));                        
                        i8SL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colSL));
                    }
                    else
                    {
                        dSE -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colSE));
                        dJSHJ -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJSHJ));
                        dWSJE -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colWSJE));
                        i8SL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colSL));
                    }
                }
            }        
        }


        private void vClearSelectSummary()
        {
            dSE = 0;
            dJSHJ = 0;
            dWSJE = 0;
            i8SL = 0;
        }


        private void btnDetailQuery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            gridView1.ShowFilterEditor(colCGTSDH);

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
            string strLayout = FrmLogin.getUser + "_PurchaseCollectionDetailLayout.xml";
            FileStream stream = new FileStream(strLayout, FileMode.Create);
            gridView1.SaveLayoutToStream(stream);
            stream.Close();
        }

        private void btnLoadLayout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strLayout = FrmLogin.getUser + "_PurchaseCollectionDetailLayout.xml";
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