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
using System.IO;


namespace ClientMain
{
    public partial class FrmPurchaseReceiveNote : DevExpress.XtraEditors.XtraForm
    {
        const int MAXROWCOUNT = 50000;

        GridCheckMarksSelection selection;
        
        public FrmPurchaseReceiveNote()
        {
            XpoDefault.ConnectionString = OracleConnectionProvider.GetConnectionString("XINHUA", "xxb", "pass");

            //string conn = OracleConnectionProvider.GetConnectionString("XINHUA", "xxb", "pass");
            //XpoDefault.DataLayer = XpoDefault.GetDataLayer(conn, AutoCreateOption.DatabaseAndSchema);
            //XpoDefault.Session = null;

            InitializeComponent();

            this.xpServerCollectionSource1.FixedFilterString = "[ZTID] = \'" + FrmLogin.getZTID + "\'"; 

            selection = new GridCheckMarksSelection(gridView1);
            selection.CheckMarkColumn.VisibleIndex = 0;
        }

        private void FrmPurchaseReceiveNote_Load(object sender, EventArgs e)
        {
            gridView1.BestFitColumns();
        }

        private void btnMasterQuery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.ShowFilterEditor(gridView1.FocusedColumn);

        }

        private void gridView1_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator & e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString().Trim();
            }
        }

        private void btnPreview_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (selection.SelectedCount != 0)
            {
                gridView1.ClearSelection();
                for (int i = 0; i < selection.SelectedCount; ++i)
                {
                    int RowIndex = selection.GetSelectedRowIndex(i);
                    int RowHandle = gridView1.GetRowHandle(RowIndex);
                    gridView1.SelectRow(RowHandle);
                }

                gridView1.Columns["CheckMarkSelection"].Visible = false;

                gridControl1.ShowPrintPreview();

                gridView1.Columns["CheckMarkSelection"].Visible = true;
                gridView1.Columns["CheckMarkSelection"].VisibleIndex = 0;
            }
            else
            {
                MessageBox.Show("请先选择需要预览的单据");
            }
        }

        private void btnPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (selection.SelectedCount != 0)
            {
                gridView1.ClearSelection();
                for (int i = 0; i < selection.SelectedCount; ++i)
                {
                    int RowIndex = selection.GetSelectedRowIndex(i);
                    int RowHandle = gridView1.GetRowHandle(RowIndex);
                    gridView1.SelectRow(RowHandle);
                }

                gridView1.Columns["CheckMarkSelection"].Visible = false;

                gridControl1.Print();

                gridView1.Columns["CheckMarkSelection"].Visible = true;
                gridView1.Columns["CheckMarkSelection"].VisibleIndex = 0;
            }
            else
            {
                MessageBox.Show("请先选择需要打印的单据");
            }
        }

        private void btnExport2PDF_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            GridView View = gridControl1.MainView as GridView;
            if (View != null)
            {
                if (View.RowCount < MAXROWCOUNT)
                {
                    SaveFileDialog saveDialog = new SaveFileDialog();
                    saveDialog.Filter = "PDF文件|*.pdf";
                    saveDialog.Title = "导出PDF文件";
                    saveDialog.DefaultExt = "pdf";
                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        gridView1.Columns["CheckMarkSelection"].Visible = false;
                        View.ExportToPdf(saveDialog.FileName);
                        gridView1.Columns["CheckMarkSelection"].Visible = true;
                        gridView1.Columns["CheckMarkSelection"].VisibleIndex = 0;
                        MessageBox.Show("导出PDF成功！");
                    }
                }
                else
                {
                    MessageBox.Show("记录数超过50000条，不能导出！");
                }
            }

           
        }

        private void btnExport2XLSX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            GridView View = gridControl1.MainView as GridView;
            if (View != null)
            {
                if (View.RowCount <= MAXROWCOUNT)
                {
                    SaveFileDialog saveDialog = new SaveFileDialog();
                    saveDialog.Filter = "XLSX文件|*.xlsx";
                    saveDialog.Title = "导出Excel文件";
                    saveDialog.DefaultExt = "xlsx";
                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        gridView1.Columns["CheckMarkSelection"].Visible = false;
                        View.ExportToXlsx(saveDialog.FileName);
                        gridView1.Columns["CheckMarkSelection"].Visible = true;
                        gridView1.Columns["CheckMarkSelection"].VisibleIndex = 0;
                        MessageBox.Show("导出XLSX成功！");
                    }
                }
                else
                {
                    MessageBox.Show("记录数超过50000条，不能导出！");
                }
            }

            
        }

        private void btnExport2XLS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            

            GridView View = gridControl1.MainView as GridView;
            if (View != null)
            {
                if (View.DataRowCount <= MAXROWCOUNT)
                {
                    SaveFileDialog saveDialog = new SaveFileDialog();
                    saveDialog.Filter = "XLS文件|*.xls";
                    saveDialog.Title = "导出Excel文件";
                    saveDialog.DefaultExt = "xls";
                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        gridView1.Columns["CheckMarkSelection"].Visible = false;

                        View.ExportToXls(saveDialog.FileName);

                        gridView1.Columns["CheckMarkSelection"].Visible = true;
                        gridView1.Columns["CheckMarkSelection"].VisibleIndex = 0;

                        MessageBox.Show("导出XLS成功！");

                    }
                }
                else
                {
                    MessageBox.Show("记录数超过50000条，不能导出！");
                }
            }

            
        }

        private void btnSaveLayout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strLayout = FrmLogin.getUser + "_PRNLayout.xml";
            FileStream stream = new FileStream(strLayout, FileMode.Create);
            gridView1.SaveLayoutToStream(stream);
            stream.Close();
        }

        private void btnLoadLayout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strLayout = FrmLogin.getUser + "_PRNLayout.xml";
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

        private void btnColCustomize_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.ShowCustomization();
        }

        private void btnDetailQuery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmPurchaseReceiveDetail FrmPRD = new FrmPurchaseReceiveDetail();
            FrmPRD.ShowDialog();
        }

        private void btnConfirm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            
        }

              
    }
    
}