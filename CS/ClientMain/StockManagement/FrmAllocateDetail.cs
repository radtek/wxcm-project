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
    public partial class FrmAllocateDetail : DevExpress.XtraEditors.XtraForm
    {
        

        GridCheckMarksSelection selection;

        double dDBMY = 0;
        double dDBSY = 0;
        Int64 i8DBSL = 0;

        public FrmAllocateDetail(string strDBDID=null)
        {
            XpoDefault.ConnectionString = FrmLogin.xpoDataCentStr;

            InitializeComponent();
            if (String.IsNullOrEmpty(strDBDID))
            {
                xpServerCollectionSource1.FixedFilterString = "[DBDMXID] Is Null";
            }
            else
            {
                xpServerCollectionSource1.FixedFilterString = strDBDID;
            }
            selection = new GridCheckMarksSelection(gridView1);
            selection.CheckMarkColumn.VisibleIndex = 0;

            gridView1.BestFitColumns();
        }

        private void vClearSelectSummary()
        {
            dDBMY = 0;
            dDBSY = 0;
            i8DBSL = 0;
        }

        private void btnDetailQuery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        private void gridView1_CustomDrawFooterCell(object sender, FooterCellCustomDrawEventArgs e)
        {
            FrmLogin.vDrawFootCell(e, colDBDH, "选计：");
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
                    if (fc["FrmAllocateNote"] != null)
                    {
                        fc["FrmAllocateNote"].Close();
                    }
                    FrmAllocateNote FrmAN = new FrmAllocateNote(strDBDID);
                    FrmAN.Show();
                    FrmAN.Activate();
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
            string strLayout = FrmLogin.getUser + "_AllocateDetailLayout.xml";
            FileStream stream = new FileStream(strLayout, FileMode.Create);
            gridView1.SaveLayoutToStream(stream);
            stream.Close();
        }

        private void btnLoadLayout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strLayout = FrmLogin.getUser + "_AllocateDetailLayout.xml";
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