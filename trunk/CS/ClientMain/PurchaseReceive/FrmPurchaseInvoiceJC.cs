using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;
using System.Configuration;
using DevExpress.XtraEditors;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System.IO;

namespace ClientMain
{

    public partial class FrmPurchaseInvoiceJC : Form
    {
        GridCheckMarksSelection selection1;
        GridCheckMarksSelection selection2;
        const int MAXROWCOUNT = 50000;
       // private string StrCon = FrmLogin.strCon;
      private string StrCon = FrmLogin.strDataCent;
        //主单的选计
        private double dWSJE = 0;
        private double dSE = 0;
        private double dJSHJ = 0;
        private Int64 iSL = 0;
        //明细单的选计

        private double dMXPJDJ = 0;
        private double dMXJSHJ = 0;
        private double dMXSE = 0;
        private double dMXWSJE = 0;
        private Int64 iMXSHSL = 0;
        public FrmPurchaseInvoiceJC()
        {
            InitializeComponent();
          //  XpoDefault.ConnectionString = OracleConnectionProvider.GetConnectionString("XINHUA", "xxb", "pass");
            XpoDefault.ConnectionString = FrmLogin.xpoDataCentStr;
            selection1 = new GridCheckMarksSelection(gridView1);
            selection1.CheckMarkColumn.VisibleIndex = 0;
            xpServerCollectionSource1.FixedFilterString = "[CGFPID] Is Null";

            selection2 = new GridCheckMarksSelection(gridView2);
            selection2.CheckMarkColumn.VisibleIndex = 0;
            xpServerCollectionSource2.FixedFilterString = "[CGFPMXID] Is Null";
        }
        private void gridView1_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator & e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString().Trim();
            }
        }
        private void vDrawFootCell(FooterCellCustomDrawEventArgs e, DevExpress.XtraGrid.Columns.GridColumn col, string strSum)
        {
            if (e.Column == col)
            {
                e.Painter.DrawObject(e.Info);
                Rectangle r = e.Info.Bounds;
                string text = e.Info.DisplayText;
                e.Info.Bounds = new Rectangle(e.Info.Bounds.Left, e.Info.Bounds.Bottom + 1, e.Info.Bounds.Width, e.Info.Bounds.Height);
                e.Info.DisplayText = strSum;
                e.Painter.DrawObject(e.Info);
                e.Handled = true;
                e.Info.Bounds = r;
                e.Info.DisplayText = text;
            }
        }
        private void gridView1_CustomDrawFooterCell(object sender, FooterCellCustomDrawEventArgs e)
        {
            vDrawFootCell(e, colZTMC, "选计：");
            vDrawFootCell(e, colWSJE, dWSJE.ToString("F2"));
            vDrawFootCell(e, colSE, dSE.ToString("F2"));
            vDrawFootCell(e, colJSHJ, dJSHJ.ToString("F2"));
            vDrawFootCell(e, colSL, iSL.ToString());


        }
        private void gridView1_MouseUp(object sender, MouseEventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));
            if ((hitInfo.Column != null) && (hitInfo.Column.GetCaption() == "选择"))
            {
                if (hitInfo.InColumn)
                {
                    if (selection1.SelectedCount == view.DataRowCount)
                    {
                        dWSJE = Convert.ToDouble(colWSJE.SummaryText);
                        dSE = Convert.ToDouble(colSE.SummaryText);
                        dJSHJ = Convert.ToDouble(colJSHJ.SummaryText);
                        iSL = Convert.ToInt64(colSL.SummaryText);

                    }
                    else
                    {

                        dWSJE = 0;
                        dSE = 0;
                        dJSHJ = 0;
                         iSL = 0;
                    }

                }
                if (hitInfo.InRowCell)
                {
                    if (selection1.IsRowSelected(hitInfo.RowHandle))
                    {
                        dWSJE += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colWSJE));
                        dSE += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colSE));
                        dJSHJ += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJSHJ));
                        iSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colSL));
                    }
                    else
                    {
                        dWSJE -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colWSJE));
                        dSE -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colSE));
                        dJSHJ -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJSHJ));
                        iSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colSL));

                    }
                }
            }

        }

        private void gridView2_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator & e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString().Trim();
            }
        }
        private void gridView2_CustomDrawFooterCell(object sender, FooterCellCustomDrawEventArgs e)
        {
            vDrawFootCell(e, colCGFPH1, "选计：");
            vDrawFootCell(e, colPJDJ1, dMXPJDJ.ToString("F2"));
            vDrawFootCell(e, colSE1, dMXSE.ToString("F2"));
            vDrawFootCell(e, colJSHJ1, dMXJSHJ.ToString("F2"));
            vDrawFootCell(e, colWSJE1, dMXWSJE.ToString("F2"));
            vDrawFootCell(e, colSHSL1, iMXSHSL.ToString());


        }
        private void gridView2_MouseUp(object sender, MouseEventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));
            if ((hitInfo.Column != null) && (hitInfo.Column.GetCaption() == "选择"))
            {
                if (hitInfo.InColumn)
                {
                    if (selection2.SelectedCount == view.DataRowCount)
                    {
                        dMXPJDJ = Convert.ToDouble(colPJDJ1.SummaryText);
                        dMXSE = Convert.ToDouble(colSE1.SummaryText);
                        dMXJSHJ = Convert.ToDouble(colJSHJ1.SummaryText);
                        dMXWSJE = Convert.ToDouble(colWSJE1.SummaryText);
                        iMXSHSL = Convert.ToInt64(colSHSL1.SummaryText);

                    }
                    else
                    {

                        dMXPJDJ = 0;
                        dMXJSHJ = 0;
                        dMXSE = 0;
                        dMXWSJE = 0;
                        iMXSHSL = 0;
                    }

                }
                if (hitInfo.InRowCell)
                {
                    if (selection2.IsRowSelected(hitInfo.RowHandle))
                    {
                        dMXPJDJ += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colPJDJ1));
                        dMXJSHJ += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colSE1));
                        dMXSE += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJSHJ1));
                        dMXWSJE += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colWSJE1));
                        iMXSHSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colSHSL1));
                    }
                    else
                    {
                        dMXPJDJ -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colPJDJ1));
                        dMXJSHJ -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colSE1));
                        dMXSE -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJSHJ1));
                        dMXWSJE -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colWSJE1));
                        iMXSHSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colSHSL1));

                    }
                }
            }

        }
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));

            FormCollection fc = Application.OpenForms;

            if (hitInfo.HitTest == GridHitTest.RowCell)
            {
                if ((hitInfo.Column != null) && (hitInfo.Column == colCGFPH))
                {
                    string strTemp = view.GetRowCellDisplayText(hitInfo.RowHandle, colCGFPID);
                    //    string strCGSHID = "[CGSHID] = \'" + strTemp + "\'";
                    if (fc["FrmPurchaseReceiveDetail"] != null)
                    {
                        fc["FrmPurchaseReceiveDetail"].Close();
                    }
                    this.Tag = "JC_C_CGFPMX";
                    CGFPMX_Load();
                    xpServerCollectionSource2.FixedFilterString = " [CGFPID] = \'" + strTemp + "\'";
                    gridView2.BestFitColumns();
                }


            }


        }
        private void CGFP_Load()
        {
            this.btnBillQuery.Visible = true;
            this.btnConfirm.Visible = true;
            this.btnAlter.Visible = true;
            this.xpServerCollectionSource2.Dispose();
            this.gridControl2.Visible = false;
            this.gridControl1.Visible = true;
            this.gridControl1.Dock = DockStyle.Fill;
        }
        private void CGFPMX_Load()
        {
            this.btnBillQuery.Visible = false;
            this.btnConfirm.Visible = false;
            this.btnAlter.Visible = false;
            this.xpServerCollectionSource1.Dispose();
            this.gridControl1.Visible = false;
            this.gridControl2.Visible = true;
            this.gridControl2.Dock = DockStyle.Fill;
        }
        private void SlelectCountClear()
        {
            dWSJE = 0;
            dSE = 0;
            dJSHJ = 0;
            iSL = 0;
        }
        private void FrmPurchaseInvoiceJC_Load(object sender, EventArgs e)
        {
            if (this.Tag.ToString() == "JC_C_CGFP")
           {
               CGFP_Load();
           }
            else if (this.Tag.ToString() == "JC_C_CGFPMX") 
           {
               CGFPMX_Load();
           }

        }

        private void btnBillQuery_Click(object sender, EventArgs e)
        {
            selection1.ClearSelection();
            gridView1.ShowFilterEditor(colZTMC);
            xpServerCollectionSource1.Reload();
            if (!String.IsNullOrEmpty(gridView1.ActiveFilterString))
            {
                xpServerCollectionSource1.FixedFilterString = gridView1.ActiveFilterString + " And [ZTID] = \'" + FrmLogin.getZTID + "\'";
                gridView1.BestFitColumns();
            }
        }

        private void btnDetailQuery_Click(object sender, EventArgs e)
        {
            if (this.Tag.ToString() == "JC_C_CGFP")
            {
                if (selection1.SelectedCount == 0)
                {
                    gridView2.ShowFilterEditor(colCGFPH1);

                    if (!String.IsNullOrEmpty(gridView2.ActiveFilterString))
                    {
                        this.Tag = "JC_C_CGFPMX";

                        CGFPMX_Load();
                        xpServerCollectionSource2.FixedFilterString = gridView2.ActiveFilterString + "And [ZTID] = \'" + FrmLogin.getZTID + "\'";
                        gridView2.BestFitColumns();

                    }
                }
                else
                {
                    string strCGFPID = null;
                    for (int i = 0; i < selection1.SelectedCount; ++i)
                    {
                        int RowIndex = selection1.GetSelectedRowIndex(i);
                        int RowHandle = gridView1.GetRowHandle(RowIndex);

                        string strTemp = gridView1.GetRowCellDisplayText(RowHandle, colCGFPID);
                        strCGFPID += "[CGFPID] = \'" + strTemp + "\' Or ";
                    }

                    int index = strCGFPID.LastIndexOf("'");
                    strCGFPID = strCGFPID.Substring(0, index + 1).Trim();
                    this.Tag = "JC_C_CGFPMX";
                    selection1.ClearSelection();
                    CGFPMX_Load();
                    xpServerCollectionSource2.FixedFilterString = strCGFPID;
                    gridView2.BestFitColumns();

                }

            }
            else if (this.Tag.ToString() == "JC_C_CGFPMX")
            {
                selection2.ClearSelection();
                gridView2.ShowFilterEditor(colCGFPH1);

                if (!String.IsNullOrEmpty(gridView1.ActiveFilterString))
                {
                    xpServerCollectionSource2.FixedFilterString = gridView2.ActiveFilterString + "And [ZTID] = \'" + FrmLogin.getZTID + "\'";
                    gridView2.BestFitColumns();
                }

            }
        }

        private void btnAlter_Click(object sender, EventArgs e)
        {
            if (selection1.SelectedCount == 1)
            {
                bool fgcgeck = false;
                int RowIndex = selection1.GetSelectedRowIndex(0);
                int RowHandle = gridView1.GetRowHandle(RowIndex);
                string strZT = this.gridView1.GetRowCellDisplayText(RowHandle, "ZT");
                string strZTID = this.gridView1.GetRowCellDisplayText(RowHandle, "ZTID");
                string strCGFPID = this.gridView1.GetRowCellDisplayText(RowHandle, "CGFPID");
                string strKPRMC = this.gridView1.GetRowCellDisplayText(RowHandle, "KPRMC").Trim();
                string strFPLXMC = this.gridView1.GetRowCellDisplayText(RowHandle, "FPLXMC").Trim();
                string strKPRID = this.gridView1.GetRowCellDisplayText(RowHandle, "KPRID").Trim();
                string strSJPH = this.gridView1.GetRowCellDisplayText(RowHandle, "SJPH").Trim();
                if (strZTID != FrmLogin.getZTID.ToString())
                {
                    fgcgeck = false;
                    MessageBox.Show("只有自己帐套下的发票才可以修改");
                }
                else if (string.IsNullOrEmpty(strZT))
                {
                    fgcgeck = false;
                    MessageBox.Show("发票无状态");

                }
                else if (Convert.ToInt32(strZT) > 3)
                {
                    fgcgeck = false;
                    MessageBox.Show("发票已经审核，无法再修改");

                }
                else
                {
                    fgcgeck = true;

                }

                if (fgcgeck == true)
                {
                    FrmInvoiceAlter frm = new FrmInvoiceAlter(strCGFPID, strKPRMC, strFPLXMC, strSJPH, strKPRID);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        OracleConnection conn = new OracleConnection(StrCon);
                        try
                        {
                            conn.Open();
                            OracleCommand cmd = new OracleCommand("JC_C_CGFP_UPDATE", conn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("LS_CGfpid", OracleType.VarChar).Value = strCGFPID;
                            cmd.Parameters.Add("LS_SJPH", OracleType.VarChar).Value = FrmInvoiceAlter.getInvoiceSJPH.ToString().Trim();
                            cmd.Parameters.Add("LS_FPLXID", OracleType.VarChar).Value = FrmInvoiceAlter.getInvoiceFPLXID.ToString().Trim();
                            cmd.Parameters.Add("LS_KPRID", OracleType.VarChar).Value = FrmInvoiceAlter.getInvoiceKPRID.ToString().Trim();
                            cmd.Parameters.Add("Descerr", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
                            cmd.Parameters.Add("Message", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
                            cmd.ExecuteNonQuery();
                            string mess = cmd.Parameters["Message"].Value.ToString();
                            selection1.ClearSelection();
                            unitOfWork1.DropIdentityMap();
                            xpServerCollectionSource1.Reload();
                            MessageBox.Show(mess);
                        }
                        catch (OracleException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            conn.Close();
                        }
                    }


                }


            }

            else
            {
                MessageBox.Show("您只能选择一项进行修改", "系统提示");
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要进行确认审核操作", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (selection1.SelectedCount == 0)
                {
                    MessageBox.Show("请先选择需要确认审核的发票");
                }
                else
                {
                    bool fgcgeck = false;
                    for (int i = 0; i < selection1.SelectedCount; ++i)
                    {
                        int RowIndex = selection1.GetSelectedRowIndex(i);
                        int RowHandle = gridView1.GetRowHandle(RowIndex);
                        string strZT = gridView1.GetRowCellDisplayText(RowHandle, colZT);
                        string strCGFPH = gridView1.GetRowCellDisplayText(RowHandle, colCGFPH);
                        string strSJPH = gridView1.GetRowCellDisplayText(RowHandle, colSJPH);

                        if (string.IsNullOrEmpty(strZT))
                        {
                            fgcgeck = false;
                            MessageBox.Show(strCGFPH + "发票无状态");

                        }
                        else if (Convert.ToInt32(strZT) > 3)
                        {
                            fgcgeck = false;
                            MessageBox.Show(strCGFPH + "发票已经审核，无法再修改");

                        }
                        else if (string.IsNullOrEmpty(strSJPH))
                        {
                            fgcgeck = false;
                            MessageBox.Show(strCGFPH + "还未填写实际票号");

                        }
                        else
                        {
                            fgcgeck = true;
                        }

                    }
                    if (fgcgeck == true)
                    {
                        OracleConnection conn = new OracleConnection(StrCon);
                        try
                        {
                            conn.Open();
                            for (int i = 0; i < selection1.SelectedCount; ++i)
                            {
                                int RowIndex = selection1.GetSelectedRowIndex(i);
                                int RowHandle = gridView1.GetRowHandle(RowIndex);
                                string strCGFPID = this.gridView1.GetRowCellDisplayText(RowHandle, "CGFPID");
                                string strUpdata = "update JC_C_CGFP set CZRQ = sysdate,  ZT = '15' where CGFPid = '" + strCGFPID + "' and zt='02'";
                                OracleCommand comm = new OracleCommand(strUpdata, conn);
                                comm.ExecuteNonQuery();

                            }


                        }
                        catch (Exception ex)
                        {
                            selection1.ClearSelection();
                            MessageBox.Show(ex.Message + "请重新选择");

                        }
                        finally
                        {
                            selection1.ClearSelection();
                            unitOfWork1.DropIdentityMap();
                            SlelectCountClear();
                            xpServerCollectionSource1.Reload();
                            MessageBox.Show("全部确认审核成功");
                            conn.Close();

                        }

                    }
                }

            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {

            if (this.Tag.ToString() == "JC_C_CGFP")
            {
                unitOfWork1.DropIdentityMap();
                xpServerCollectionSource1.Reload();
            }
            else if (this.Tag.ToString() == "JC_C_CGFPMX")
            {
                unitOfWork2.DropIdentityMap();
                xpServerCollectionSource2.Reload();
            }
        }

        private void btnPrintGrid_Click(object sender, EventArgs e)
        {
            if (this.Tag.ToString() == "JC_C_CGFP")
            {
                gridView1.Columns["CheckMarkSelection"].Visible = false;

                gridView1.SelectAll();
                gridControl1.ShowPrintPreview();

                gridView1.Columns["CheckMarkSelection"].Visible = true;
                gridView1.Columns["CheckMarkSelection"].VisibleIndex = 0;
            }
            else if (this.Tag.ToString() == "JC_C_CGFPMX")
            {
                gridView2.Columns["CheckMarkSelection"].Visible = false;

                gridView2.SelectAll();
                gridControl2.ShowPrintPreview();

                gridView2.Columns["CheckMarkSelection"].Visible = true;
                gridView2.Columns["CheckMarkSelection"].VisibleIndex = 0;
            }
        }

        private void btnExportGrid_Click(object sender, EventArgs e)
        {
            if (this.Tag.ToString() == "JC_C_CGFP")
            {
                if (gridView1.DataRowCount > MAXROWCOUNT)
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
            else if (this.Tag.ToString() == "JC_C_CGFPMX")
            {
                if (gridView2.DataRowCount > MAXROWCOUNT)
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
                        gridView2.Columns["CheckMarkSelection"].Visible = false;

                        gridView2.SelectAll();
                        gridView2.ExportToXls(saveDialog.FileName);

                        gridView2.Columns["CheckMarkSelection"].Visible = true;
                        gridView2.Columns["CheckMarkSelection"].VisibleIndex = 0;

                        MessageBox.Show("导出成功！");

                    }
                }
            }
         
        }
    }
}
