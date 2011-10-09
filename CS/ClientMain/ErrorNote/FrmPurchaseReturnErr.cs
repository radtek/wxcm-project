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
    public partial class FrmPurchaseReturnErr : DevExpress.XtraEditors.XtraForm
    {
        

        GridCheckMarksSelection selection;

        Int64 i8CCSL = 0;
        Int64 i8CCPZ = 0;
        double dCCSY = 0;
        double dCCMY = 0;

 
        public FrmPurchaseReturnErr(string strCCDID=null)
        {
            XpoDefault.ConnectionString = FrmLogin.xpoDataCentStr;

            InitializeComponent();

            if (String.IsNullOrEmpty(strCCDID))
            {
                xpServerCollectionSource1.FixedFilterString = "[CCDID] Is Null";
            }
            else
            {
                xpServerCollectionSource1.FixedFilterString = strCCDID;
            }

            selection = new GridCheckMarksSelection(gridView1);
            selection.CheckMarkColumn.VisibleIndex = 0;

            gridView1.BestFitColumns(); 
        }


        private void gridView1_CustomDrawFooterCell(object sender, DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventArgs e)
        {
            FrmLogin.vDrawFootCell(e, colCCDH, "选计：");
            FrmLogin.vDrawFootCell(e, colCCSL, i8CCSL.ToString());
            FrmLogin.vDrawFootCell(e, colCCPZ, i8CCPZ.ToString());
            FrmLogin.vDrawFootCell(e, colCCSY, dCCSY.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colCCMY, dCCMY.ToString("F2"));
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
                if ((hitInfo.Column != null) && (hitInfo.Column == colCCDH))
                {
                    string strTemp = view.GetRowCellDisplayText(hitInfo.RowHandle, colCCDID);
                    string strCCDID = "[CCDID] = \'" + strTemp + "\'";
                    if (fc["FrmPurchaseReturnErrDetail"] != null)
                    {
                        fc["FrmPurchaseReturnErrDetail"].Close();
                    }
                    FrmPurchaseReturnErrDetail FrmPRED = new FrmPurchaseReturnErrDetail(strCCDID);
                    FrmPRED.Show();
                    FrmPRED.Activate();
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
                        double.TryParse(colCCMY.SummaryText, out dCCMY);
                        Int64.TryParse(colCCPZ.SummaryText, out i8CCPZ);
                        double.TryParse(colCCSY.SummaryText, out dCCSY);
                        Int64.TryParse(colCCSL.SummaryText, out i8CCSL);
                    }
                    else
                    {
                        dCCMY = 0;
                        dCCSY = 0;
                        i8CCPZ = 0;
                        i8CCSL = 0;
                    }

                }
                if (hitInfo.InRowCell)
                {
                    if (selection.IsRowSelected(hitInfo.RowHandle))
                    {
                        dCCMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colCCMY));
                        dCCSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colCCSY));
                        i8CCPZ += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colCCPZ));
                        i8CCSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colCCSL));
                    }
                    else
                    {
                        dCCMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colCCMY));
                        dCCSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colCCSY));
                        i8CCPZ -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colCCPZ));
                        i8CCSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colCCSL));
                    }
                }
            }                      
        }

        private void vClearSelectSummary()
        {
            dCCMY = 0;
            dCCSY = 0;
            i8CCPZ = 0;
            i8CCSL = 0;
        }

        private void btnMasterQuery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            gridView1.ShowFilterEditor(colCCDH);

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
                FrmPurchaseReceiveErrDetail FrmPRED = new FrmPurchaseReceiveErrDetail();
                FrmPRED.Show();
                FrmPRED.Activate();
                //}

            }
            else
            {
                string strCCDID = null;
                for (int i = 0; i < selection.SelectedCount; ++i)
                {
                    int RowIndex = selection.GetSelectedRowIndex(i);
                    int RowHandle = gridView1.GetRowHandle(RowIndex);

                    string strTemp = gridView1.GetRowCellDisplayText(RowHandle, colCCDID);
                    strCCDID += "[CCDID] = \'" + strTemp + "\' Or ";
                }

                int index = strCCDID.LastIndexOf("'");
                strCCDID = strCCDID.Substring(0, index + 1).Trim();

                FrmPurchaseReceiveErrDetail FrmPRED = new FrmPurchaseReceiveErrDetail(strCCDID);
                FrmPRED.Show();
                FrmPRED.Activate();
            }
        }

        private void btnStastics_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (selection.SelectedCount == 0)
            {
                MessageBox.Show("请选择需要统计的记录！");
            }
            else
            {
                string strCCDID = null;
                for (int i = 0; i < selection.SelectedCount; ++i)
                {
                    int RowIndex = selection.GetSelectedRowIndex(i);
                    int RowHandle = gridView1.GetRowHandle(RowIndex);

                    string strTemp = gridView1.GetRowCellDisplayText(RowHandle, colCCDID);
                    strCCDID += "[CCDID] = \'" + strTemp + "\' Or ";
                }

                int index = strCCDID.LastIndexOf("'");
                strCCDID = strCCDID.Substring(0, index + 1).Trim();

                FrmPurchaseReturnErrStatistic FrmPRES = new FrmPurchaseReturnErrStatistic(strCCDID);
                FrmPRES.Show();
                FrmPRES.Activate();
            }
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

        private void btnPrintGrid_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.Columns["CheckMarkSelection"].Visible = false;

            gridView1.SelectAll();
            gridControl1.ShowPrintPreview();

            gridView1.Columns["CheckMarkSelection"].Visible = true;
            gridView1.Columns["CheckMarkSelection"].VisibleIndex = 0;
        }

        private void btnColCustomize_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.ShowCustomization();
        }

        private void btnColSaveLayout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strLayout = FrmLogin.getUser + "_PurchaseReturnErrorLayout.xml";
            FileStream stream = new FileStream(strLayout, FileMode.Create);
            gridView1.SaveLayoutToStream(stream);
            stream.Close();
        }

        private void btnLoadLayout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strLayout = FrmLogin.getUser + "_PurchaseReturnErrorLayout.xml";
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