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
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports;
using DevExpress.XtraPrinting.Localization; 


namespace ClientMain
{
    public partial class FrmSaleStageJT : Form
    {
        GridCheckMarksSelection selection1;
        GridCheckMarksSelection selection2;
        const int MAXROWCOUNT = 50000;
        private double TuoShouXianE;//从托收限额模块得到限额
        // private string StrCon = FrmLogin.strCon;
        private string StrCon = FrmLogin.strDataCent;
        //销售结算单选计
        private double dSE = 0;
        private double dJSHJ = 0;
        private double dZKE = 0;


        private Int64 iXSSL = 0;
        private double dXSSY = 0;
        private double dXSMY = 0;

        private Int64 iYSSL = 0;
        private double dYSJE = 0;
        private double dYSMY = 0;

        private Int64 iTSZSL = 0;
        private double dTSZSY = 0;
        private double dTSZMY = 0;

        private double dPJZK = 0;
        private double dPJDJ = 0;

        //明细单选计

        Int64 XSSL = 0;
        double XSSY = 0;
        double XSMY = 0;

        Int64 YJSL = 0;
        double YJSY = 0;
        double YJMY = 0;

        public FrmSaleStageJT()
        {
            InitializeComponent();
            //  XpoDefault.ConnectionString = OracleConnectionProvider.GetConnectionString("XINHUA", "xxb", "pass");
            XpoDefault.ConnectionString = FrmLogin.xpoDataCentStr;
            selection1 = new GridCheckMarksSelection(gridView1);
            selection1.CheckMarkColumn.VisibleIndex = 0;
            xpServerCollectionSource1.FixedFilterString = "[XSJSDID] Is Null";


            selection2 = new GridCheckMarksSelection(gridView2);
            selection2.CheckMarkColumn.VisibleIndex = 0;
            xpServerCollectionSource2.FixedFilterString = "[XSJSDMXID] Is Null";

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
        private void gridView1_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator & e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString().Trim();
            }
        }
        private void gridView1_CustomDrawFooterCell(object sender, FooterCellCustomDrawEventArgs e)
        {
            vDrawFootCell(e, colZTMC, "选计：");
            vDrawFootCell(e, colXSSL, iXSSL.ToString());
            vDrawFootCell(e, colXSSY, dXSSY.ToString("F2"));
            vDrawFootCell(e, colXSMY, dXSMY.ToString("F2"));

            vDrawFootCell(e, colYSSL, iYSSL.ToString());
            vDrawFootCell(e, colYSJE, dYSJE.ToString("F2"));
            vDrawFootCell(e, colYSMY, dYSMY.ToString("F2"));

            vDrawFootCell(e, colTSZSL, iTSZSL.ToString());
            vDrawFootCell(e, colTSZSY, dTSZSY.ToString("F2"));
            vDrawFootCell(e, colTSZMY, dTSZMY.ToString("F2"));


            vDrawFootCell(e, colSE, dSE.ToString("F2"));
            vDrawFootCell(e, colJSHJ, dJSHJ.ToString("F2"));


            vDrawFootCell(e, colZKE, dZKE.ToString("F2"));
            vDrawFootCell(e, colPJZK, dPJZK.ToString("F2"));


            vDrawFootCell(e, colPJDJ, dPJDJ.ToString("F2"));


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
                        iXSSL = Convert.ToInt64(colXSSL.SummaryText);
                        dXSSY = Convert.ToDouble(colXSSY.SummaryText);
                        dXSMY = Convert.ToDouble(colXSMY.SummaryText);

                        iYSSL = Convert.ToInt64(colYSSL.SummaryText);
                        dYSJE = Convert.ToDouble(colYSJE.SummaryText);
                        dYSMY = Convert.ToDouble(colYSMY.SummaryText);

                        iTSZSL = Convert.ToInt64(colTSZSL.SummaryText);
                        dTSZSY = Convert.ToDouble(colTSZSY.SummaryText);
                        dTSZMY = Convert.ToDouble(colTSZMY.SummaryText);


                        dSE = Convert.ToDouble(colSE.SummaryText);
                        dJSHJ = Convert.ToDouble(colJSHJ.SummaryText);

                        dZKE = Convert.ToDouble(colZKE.SummaryText);
                        dPJZK = Convert.ToDouble(colPJZK.SummaryText);

                        dPJDJ = Convert.ToDouble(colPJDJ.SummaryText);

                    }
                    else
                    {
                        iXSSL = 0;
                        dXSSY = 0;
                        dXSMY = 0;

                        iYSSL = 0;
                        dYSJE = 0;
                        dYSMY = 0;

                        iTSZSL = 0;
                        dTSZSY = 0;
                        dTSZMY = 0;

                        dSE = 0;
                        dJSHJ = 0;
                        dZKE = 0;

                        dPJZK = 0;
                        dPJDJ = 0;

                    }

                }
                if (hitInfo.InRowCell)
                {
                    if (selection1.IsRowSelected(hitInfo.RowHandle))
                    {
                        iXSSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colXSSL));
                        dXSSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colXSSY));
                        dXSMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colXSMY));

                        iYSSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colYSSL));
                        dYSJE += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colYSJE));
                        dYSMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colYSMY));

                        iTSZSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colTSZSL));
                        dTSZSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colTSZSY));
                        dTSZMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colTSZMY));


                        dSE += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colSE));
                        dJSHJ += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJSHJ));


                        dZKE += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZKE));
                        dPJZK += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colPJZK));


                        dPJDJ += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colPJDJ));


                    }
                    else
                    {
                        iXSSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colXSSL));
                        dXSSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colXSSY));
                        dXSMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colXSMY));

                        iYSSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colYSSL));
                        dYSJE -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colYSJE));
                        dYSMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colYSMY));

                        iTSZSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colTSZSL));
                        dTSZSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colTSZSY));
                        dTSZMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colTSZMY));


                        dSE -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colSE));
                        dJSHJ -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJSHJ));


                        dZKE -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZKE));
                        dPJZK -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colPJZK));


                        dPJDJ -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colPJDJ));
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
            vDrawFootCell(e, colSJLX, "选计：");
            vDrawFootCell(e, colXSSL1, XSSL.ToString());
            vDrawFootCell(e, colXSSY1, XSSY.ToString("F2"));
            vDrawFootCell(e, colXSMY1, XSMY.ToString("F2"));

            vDrawFootCell(e, colYJSL1, YJSL.ToString());
            vDrawFootCell(e, colYJSY1, YJSY.ToString("F2"));
            vDrawFootCell(e, colYJMY1, YJMY.ToString("F2"));


        }
        private void gridView2_MouseUp(object sender, MouseEventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));
            if ((hitInfo.Column != null) && (hitInfo.Column.GetCaption() == "选择"))
            {
                if (hitInfo.InColumn)
                {
                    if (selection1.SelectedCount == view.DataRowCount)
                    {
                        XSSL = Convert.ToInt64(colXSSL1.SummaryText);
                        XSSY = Convert.ToDouble(colXSSY1.SummaryText);
                        XSMY = Convert.ToDouble(colXSMY1.SummaryText);

                        YJSL = Convert.ToInt64(colYJSL1.SummaryText);
                        YJSY = Convert.ToDouble(colYJSY1.SummaryText);
                        YJMY = Convert.ToDouble(colYJMY1.SummaryText);


                    }
                    else
                    {
                        XSSL = 0;
                        XSSY = 0;
                        XSMY = 0;

                        YJSL = 0;
                        YJSY = 0;
                        YJMY = 0;

                    }

                }
                if (hitInfo.InRowCell)
                {
                    if (selection1.IsRowSelected(hitInfo.RowHandle))
                    {
                        XSSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colXSSL1));
                        XSSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colXSSY1));
                        XSMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colXSMY1));

                        YJSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colYJSL1));
                        YJSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colYJSY1));
                        YJMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colYJMY1));


                    }
                    else
                    {
                        XSSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colXSSL1));
                        XSSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colXSSY1));
                        XSMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colXSMY1));

                        YJSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colYJSL1));
                        YJSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colYJSY1));
                        YJMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colYJMY1));
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
                if ((hitInfo.Column != null) && (hitInfo.Column == colXSJSDH))
                {
                    string strTemp = view.GetRowCellDisplayText(hitInfo.RowHandle, colXSJSDID);
                    if (fc["FrmPurchaseReceiveDetail"] != null)
                    {
                        fc["FrmPurchaseReceiveDetail"].Close();
                    }

                    xpServerCollectionSource2.FixedFilterString = " [XSJSDID] = \'" + strTemp + "\'";
                    XSJSDMX_Load();
                    gridView2.BestFitColumns();
                  
                }


            }


        }
        private void XSJSD_Load()
        {
            this.btnBillQuery.Visible = true;
            this.btnBillAdd.Visible = true;
            this.btnBillAlter.Visible = true;
            this.btnBillDel.Visible = true;
            this.btnBillLook.Visible = true;
            this.btnConfirm.Visible = true;
            this.btnFreeze.Visible = true;
            this.btnunfreeze.Visible = true;
            this.btnHexiao.Visible = true;
            this.btnPreview.Visible = true;
            this.btnToFP.Visible = true;
            this.btnYSPZ.Visible = true;
            this.btnTuoShou.Visible = true;
            this.btnSKPZ.Visible = true;
            this.btnJZCB.Visible = true;

            this.gridControl1.Visible = true;
            this.gridControl1.Dock = DockStyle.Fill;
            this.gridControl2.Visible = false;

            this.xpServerCollectionSource2.Dispose();




        }
        private void XSJSDMX_Load()
        {
            this.btnBillQuery.Visible = false;
            this.btnBillAdd.Visible = false;
            this.btnBillAlter.Visible = false;
            this.btnBillDel.Visible = false;
            this.btnBillLook.Visible = false;
            this.btnConfirm.Visible = false;
            this.btnFreeze.Visible = false;
            this.btnunfreeze.Visible = false;
            this.btnHexiao.Visible = false;
            this.btnPreview.Visible = false;
            this.btnToFP.Visible = false;
            this.btnYSPZ.Visible = false;
            this.btnTuoShou.Visible = false;
            this.btnSKPZ.Visible = false;
            this.btnJZCB.Visible = false;


            this.gridControl1.Visible = false;
            this.gridControl2.Visible = true;
            this.gridControl2.Dock = DockStyle.Fill;

            this.xpServerCollectionSource1.Dispose();

        }
        private void SlelectCountClear()
        {
          dSE = 0;
       dJSHJ = 0;
         dZKE = 0;


       iXSSL = 0;
        dXSSY = 0;
       dXSMY = 0;

         iYSSL = 0;
         dYSJE = 0;
         dYSMY = 0;

        iTSZSL = 0;
         dTSZSY = 0;
         dTSZMY = 0;

        dPJZK = 0;
        dPJDJ = 0;
 
        }

        private void btnBillAlter_Click(object sender, EventArgs e)
        {
            bool check = false;
            if (selection1.SelectedCount == 0)
            { check = false; MessageBox.Show("请选择要修改的采购销售单"); }
            else if (selection1.SelectedCount != 1)
            { check = false; MessageBox.Show("每次只能修改一张采购销售单"); }
            else
            { check = true; }
            if (check == true)
            {
                bool fgshowfrom = false;
                int RowIndex = selection1.GetSelectedRowIndex(0);
                int RowHandle = gridView1.GetRowHandle(RowIndex);
                string strZT = gridView1.GetRowCellDisplayText(RowHandle, colZT).ToString().Trim();
                string strZTID = gridView1.GetRowCellValue(RowHandle, colZTID).ToString();
                string strXSJSDID = gridView1.GetRowCellValue(RowHandle, colXSJSDID).ToString();
                string strCZYID = gridView1.GetRowCellDisplayText(RowHandle, colCZYID).ToString().Trim();
                if (strZT != "02")
                {
                    fgshowfrom = false;
                    MessageBox.Show("只有存盘状态下的结算单才可以被修改");
                }
                else if (strZTID != FrmLogin.getZTID.ToString())
                {
                    fgshowfrom = false;
                    MessageBox.Show("只有自己帐套下的结算单才可以被修改");
                }
                else if (strCZYID != FrmLogin.getUserID.ToString())
                {
                    fgshowfrom = false;
                    MessageBox.Show("只有自己新建的结算单才可以被修改");

                }
                else
                { fgshowfrom = true; }
                if (fgshowfrom == true)
                {
                    if (this.Tag.ToString() == "JT_C_XSJSD_ZDJS")
                    {

                        FrmSaleStageJTAdd frm = new FrmSaleStageJTAdd(strXSJSDID);
                        frm.Text = "集团——采购结算单——整单结算——修改";
                        frm.Tag = "JT_XSJSD_ZDJS_ALTER";
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            selection1.ClearSelection();
                            SlelectCountClear();
                            unitOfWork1.DropIdentityMap();
                            xpServerCollectionSource1.Reload();
                            gridView1.BestFitColumns();
                        }
                    }
                    else if (this.Tag.ToString() == "JT_C_XSJSD_SXSJ")
                    {

                        FrmSaleStageJTAdd frm = new FrmSaleStageJTAdd(strXSJSDID);
                        frm.Text = "集团——采购结算单——实销实结——修改";
                        frm.Tag = "JT_XSJSD_SXSJ_ALTER";
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            selection1.ClearSelection();
                            unitOfWork1.DropIdentityMap();
                            SlelectCountClear();
                            xpServerCollectionSource1.Reload();
                            gridView1.BestFitColumns();
                        }
                    }


                }

            }
        }



        private void btnBillQuery_Click(object sender, EventArgs e)
        {
            selection1.ClearSelection();
            gridView1.ShowFilterEditor(colZTMC);

            if (!String.IsNullOrEmpty(gridView1.ActiveFilterString))
            {
                xpServerCollectionSource1.FixedFilterString = gridView1.ActiveFilterString + " And [ZTID] = \'" + FrmLogin.getZTID + "\'";
                gridView1.BestFitColumns();
            }

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要进行确认审核操作", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (selection1.SelectedCount == 0)
                {
                    MessageBox.Show("请先选择需要确认审核的采购结算单");
                }
                else
                {
                    bool fgcheck = false;
                    for (int i = 0; i < selection1.SelectedCount; ++i)
                    {
                        int RowIndex = selection1.GetSelectedRowIndex(i);
                        int RowHandle = gridView1.GetRowHandle(RowIndex);
                        string strZT = gridView1.GetRowCellDisplayText(RowHandle, colZT);
                        string strXSJSDH = gridView1.GetRowCellDisplayText(RowHandle, colXSJSDH);
                        string strJSHJ = gridView1.GetRowCellDisplayText(RowHandle, colJSHJ);
                        if (strZT!="02")
                        {
                            fgcheck = false;
                            MessageBox.Show("账号" + strXSJSDH + "状态不为存盘");
                            break;
                        }

                        else if (string.IsNullOrEmpty(strJSHJ))
                        {
                            fgcheck = false;
                            MessageBox.Show("账号" + strXSJSDH + "价税合计为零不能确认审核");
                            break;
                        }
                        else
                        {
                            fgcheck = true;
                        }

                    }
                    if (fgcheck == true)
                    {

                        OracleConnection conn = new OracleConnection(StrCon);
                        try
                        {
                            conn.Open();
                            for (int i = 0; i < selection1.SelectedCount; ++i)
                            {
                                int RowIndex = selection1.GetSelectedRowIndex(i);
                                int RowHandle = gridView1.GetRowHandle(RowIndex);
                                string strXSJSDID = gridView1.GetRowCellDisplayText(RowHandle, colXSJSDID).ToString();
                                string strXSJSDH = gridView1.GetRowCellDisplayText(RowHandle, colXSJSDH).ToString();
                                string strUpdata = " update jt_c_xsjsd set CZRQ = sysdate, ZT = '15' where xsjsdid = '" + strXSJSDID + "' and zt='02'";
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

        private void btnToFP_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要进行发票操作吗", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (selection1.SelectedCount == 0)
                {
                    MessageBox.Show("请先选择需要生成发票的销售结算单");
                }
                else
                {
                    bool fgcheck = false;
                    for (int i = 0; i < selection1.SelectedCount; ++i)
                    {
                        int RowIndex = selection1.GetSelectedRowIndex(i);
                        int RowHandle = gridView1.GetRowHandle(RowIndex);

                        string strXSFPID = gridView1.GetRowCellDisplayText(RowHandle, colXSFPID);
                        string strXSJSDH = gridView1.GetRowCellDisplayText(RowHandle, colXSJSDH);
                        string strJSFS = gridView1.GetRowCellDisplayText(RowHandle, colJSFSMC);
                        string strZT = gridView1.GetRowCellDisplayText(RowHandle, colZT);
                        if (!String.IsNullOrEmpty(strXSFPID))
                        {
                            fgcheck = false;
                            MessageBox.Show("账号" + strXSJSDH + "已经生成了结算发票");
                            break;

                        }
                        else if (String.IsNullOrEmpty(strZT))
                        {
                            fgcheck = false;
                            MessageBox.Show("账号" + strXSJSDH + "状态为空无法生成结算发票");
                            break;
                        }
                        else if (Convert.ToInt32(strZT) < 15)
                        {
                            fgcheck = false;
                            MessageBox.Show("账号" + strXSJSDH + "还未审核无法生成结算发票");
                            break;
                        }

                        else if (strJSFS == "托收")
                        {
                            fgcheck = false;
                            MessageBox.Show("账号" + strXSJSDH + "已经托收无法生成结算发票");
                            break;
                        }
                        else
                        {
                            fgcheck = true;
                        }

                    }
                    if (fgcheck == true)
                    {
                        using (OracleConnection connection = new OracleConnection(StrCon))
                        {
                            connection.Open();
                            OracleCommand cmd = connection.CreateCommand();
                            OracleTransaction transaction;
                            transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);
                            cmd.Transaction = transaction;


                            try
                            {
                                for (int i = 0; i < selection1.SelectedCount; ++i)
                                {
                                    int RowIndex = selection1.GetSelectedRowIndex(i);
                                    int RowHandle = gridView1.GetRowHandle(RowIndex);
                                    string strXSJSDID = gridView1.GetRowCellValue(RowHandle, colXSJSDID).ToString();
                                    cmd.CommandText = "INSERT INTO TEMP_SAVE_ID (TEMPID, ID) Values (temp_save_id_seq.nextval, '" + strXSJSDID + "')";
                                    cmd.ExecuteNonQuery();
                                }
                                selection1.ClearSelection();
                                SlelectCountClear();
                                
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.CommandText = "Jt_c_xsjsd_To_Xsfp";
                                    cmd.Parameters.Add("Userid", OracleType.VarChar).Value = FrmLogin.getUserID;
                                    cmd.Parameters.Add("ls_cwbmid", OracleType.VarChar).Value = FrmLogin.getDeptID;
                                    cmd.Parameters.Add("Ls_Ztid", OracleType.VarChar).Value = FrmLogin.getZTID;
                                    cmd.Parameters.Add("Descerr", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
                                    cmd.Parameters.Add("Message", OracleType.VarChar, 255).Direction = ParameterDirection.Output;

                                    cmd.ExecuteNonQuery();
                                    transaction.Commit();

                                    unitOfWork1.DropIdentityMap();

                                    xpServerCollectionSource1.Reload();

                                    MessageBox.Show(cmd.Parameters["Message"].Value.ToString());
                                

                            }
                            catch (OracleException ex)
                            {
                                transaction.Rollback();
                                MessageBox.Show(ex.Message);
                            }
                            finally
                            {
                                connection.Close();
                            }

                        }

                    }

                }

            }

        }

        private void btnHexiao_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要进行核销操作吗", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (selection1.SelectedCount == 0)
                {
                    MessageBox.Show("请先选择需要核销的销售结算单");
                }
                else
                {
                    FrmHeXiaoDate from = new FrmHeXiaoDate();
                    if (from.ShowDialog() == DialogResult.OK)
                    {
                        string time = FrmHeXiaoDate.getSelectTime.ToString();
                        bool fgcheck = false;
                        for (int i = 0; i < selection1.SelectedCount; ++i)
                        {
                            int RowIndex = selection1.GetSelectedRowIndex(i);
                            int RowHandle = gridView1.GetRowHandle(RowIndex);
                            string strXSFPID = gridView1.GetRowCellDisplayText(RowHandle, colXSFPID);
                            string strXSJSDH = gridView1.GetRowCellDisplayText(RowHandle, colXSJSDH);
                            string strZT = gridView1.GetRowCellDisplayText(RowHandle, colZT);
                            string strZDRQ = gridView1.GetRowCellDisplayText(RowHandle, colZDRQ);
                            DateTime dt1 = Convert.ToDateTime(strZDRQ);
                            DateTime dt2 = Convert.ToDateTime(time);
                            if (string.IsNullOrEmpty(strZT)||Convert.ToInt32(strZT) < 15)
                            {
                                fgcheck = false;
                                MessageBox.Show("单号为" + strXSJSDH + "还未审核，无法核销");
                                break;

                            }
                            else if (Convert.ToInt32(strZT) == 44)
                            {
                                fgcheck = false;
                                MessageBox.Show("单号为" + strXSJSDH + "已经核销");
                                break;
                            }
                            else if (string.IsNullOrEmpty(time))
                            {
                                fgcheck = false;
                                MessageBox.Show("单号为" + strXSJSDH + "没有选定核销时间");
                                break;
                            }
                            else if (DateTime.Compare(dt1, dt2) > 0)
                            {
                                fgcheck = false;
                                MessageBox.Show("单号为" + strXSJSDH + "核销时间小于制单时间");
                                break;
                            }
                            else if (string.IsNullOrEmpty(strXSFPID))
                            {
                                fgcheck = false;
                                MessageBox.Show("单号为" + strXSJSDH + "还未生成发票，无法核销");
                                break;
                            }
                            else
                            {
                                fgcheck = true;
                            }

                        }
                        if (fgcheck == true)
                        {
                            using (OracleConnection connection = new OracleConnection(StrCon))
                            {
                                connection.Open();
                                string alarm = "0";
                                for (int i = 0; i < selection1.SelectedCount; ++i)
                                {
                                    OracleCommand cmd = connection.CreateCommand();
                                    try
                                    {
                                        int RowIndex = selection1.GetSelectedRowIndex(i);
                                        int RowHandle = gridView1.GetRowHandle(RowIndex);
                                        string strXSJSDID = gridView1.GetRowCellDisplayText(RowHandle, colXSJSDID);
                                        string strXSJSDH = gridView1.GetRowCellDisplayText(RowHandle, colXSJSDH);
                                        cmd.CommandType = CommandType.StoredProcedure;
                                        cmd.CommandText = "Jt_c_xsjsd_Hx";
                                        cmd.Parameters.Add("ls_xsjsdid", OracleType.VarChar).Value = strXSJSDID;
                                        cmd.Parameters.Add("Ls_Hkrq", OracleType.VarChar).Value = time;
                                        cmd.Parameters.Add("Descerr", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
                                        cmd.Parameters.Add("Message", OracleType.VarChar, 255).Direction = ParameterDirection.Output;

                                        cmd.ExecuteNonQuery();
                                        alarm = cmd.Parameters["Descerr"].Value.ToString();
                                        if (alarm == "1")
                                        {
                                            MessageBox.Show("单号" + strXSJSDH + cmd.Parameters["Message"].Value.ToString());

                                            break;
                                        }


                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                    }

                                }
                                selection1.ClearSelection();
                                SlelectCountClear();
                                unitOfWork1.DropIdentityMap();
                                xpServerCollectionSource1.Reload();
                                if (alarm == "0")
                                {
                                    connection.Close();

                                    MessageBox.Show("所选择的采购结算单核销完毕");

                                }

                            }
                        }

                    }
                }
            }
        }

        private void btnSKPZ_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要进行收款凭证操作吗", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (selection1.SelectedCount == 0)
                {
                    MessageBox.Show("请先选择需要生成收款凭证的的销售结算单");
                }
                else
                {
                    bool fgcheck = false;
                    for (int i = 0; i < selection1.SelectedCount; ++i)
                    {
                        int RowIndex = selection1.GetSelectedRowIndex(i);
                        int RowHandle = gridView1.GetRowHandle(RowIndex);

                        string strSKPZID = gridView1.GetRowCellDisplayText(RowHandle, colSKPZID).ToString();
                        string strXSJSDH = gridView1.GetRowCellValue(RowHandle, colXSJSDH).ToString();
                        string strHKRQ = gridView1.GetRowCellDisplayText(RowHandle, colHKRQ).ToString();

                        if (!String.IsNullOrEmpty(strSKPZID))
                        {
                            fgcheck = false;
                            MessageBox.Show("账号" + strXSJSDH + "已经生成了收货凭证");
                            break;

                        }
                        else if (String.IsNullOrEmpty(strHKRQ))
                        {
                            fgcheck = false;
                            MessageBox.Show("账号" + strXSJSDH + "未核销无法生成收货凭证");
                            break;
                        }

                        else
                        {
                            fgcheck = true;
                        }

                    }
                    if (fgcheck == true)
                    {
                        using (OracleConnection connection = new OracleConnection(StrCon))
                        {
                            connection.Open();
                            OracleCommand cmd = connection.CreateCommand();
                            OracleTransaction transaction;
                            transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);
                            cmd.Transaction = transaction;
                            try
                            {
                                for (int i = 0; i < selection1.SelectedCount; ++i)
                                {
                                    int RowIndex = selection1.GetSelectedRowIndex(i);
                                    int RowHandle = gridView1.GetRowHandle(RowIndex);
                                    string strXSJSDH = gridView1.GetRowCellDisplayText(RowHandle, colXSJSDH);
                                    string strXSJSDID = gridView1.GetRowCellValue(RowHandle, colXSJSDID).ToString();
                                    cmd.CommandText = "INSERT INTO TEMP_SAVE_ID (TEMPID, ID) Values (temp_save_id_seq.nextval, '" + strXSJSDID + "')";
                                    cmd.ExecuteNonQuery();
                                }
                                selection1.ClearSelection();
                                SlelectCountClear();
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.CommandText = "JT_C_XSJSD_TO_SKPZ";
                                cmd.Parameters.Add("Userid", OracleType.VarChar).Value = FrmLogin.getUserID;
                                cmd.Parameters.Add("Departmentid", OracleType.VarChar).Value = FrmLogin.getDeptID;
                                cmd.Parameters.Add("Ls_Ztid", OracleType.VarChar).Value = FrmLogin.getZTID;
                                cmd.Parameters.Add("Descerr", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
                                cmd.Parameters.Add("Message", OracleType.VarChar, 255).Direction = ParameterDirection.Output;

                                cmd.ExecuteNonQuery();
                                transaction.Commit();
                                unitOfWork1.DropIdentityMap();
                                xpServerCollectionSource1.Reload();
                                MessageBox.Show(cmd.Parameters["Message"].Value.ToString());
                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback();
                                MessageBox.Show(ex.Message);
                            }
                            finally
                            {
                                connection.Close();
                                transaction.Dispose();
                            }

                        }

                    }

                }

            }
        }

        private void btnJZCB_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("确定要进行结转成本操作吗", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (selection1.SelectedCount == 0)
                {
                    MessageBox.Show("请先选择需要生成结转成本凭证的的销售结算单");
                }
                else
                {
                    bool fgcheck = false;
                    for (int i = 0; i < selection1.SelectedCount; ++i)
                    {
                        int RowIndex = selection1.GetSelectedRowIndex(i);
                        int RowHandle = gridView1.GetRowHandle(RowIndex);

                        string strJZCBPZID = gridView1.GetRowCellDisplayText(RowHandle, colJZCBPZID).ToString();
                        string strXSJSDH = gridView1.GetRowCellDisplayText(RowHandle, colXSJSDH).ToString();
                        string strZT = gridView1.GetRowCellDisplayText(RowHandle, colZT).ToString();

                        if (!String.IsNullOrEmpty(strJZCBPZID))
                        {
                            fgcheck = false;
                            MessageBox.Show("账号" + strXSJSDH + "已经生成了结转成本凭证");
                            break;

                        }
                        else if (Convert.ToInt32(strZT) < 15)
                        {
                            fgcheck = false;
                            MessageBox.Show("账号" + strXSJSDH + "没有审核无法生成结转成本凭证");
                            break;

                        }
                        else
                        {
                            fgcheck = true;
                        }

                    }
                    if (fgcheck == true)
                    {
                        using (OracleConnection connection = new OracleConnection(StrCon))
                        {
                            connection.Open();
                            OracleCommand cmd = connection.CreateCommand();
                            OracleTransaction transaction;
                            transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);
                            cmd.Transaction = transaction;
                            try
                            {

                                for (int i = 0; i < selection1.SelectedCount; ++i)
                                {
                                    int RowIndex = selection1.GetSelectedRowIndex(i);
                                    int RowHandle = gridView1.GetRowHandle(RowIndex);
                                    string strXSJSDID = gridView1.GetRowCellValue(RowHandle, colXSJSDID).ToString();
                                    cmd.CommandText = "INSERT INTO TEMP_SAVE_ID (TEMPID, ID) Values (temp_save_id_seq.nextval, '" + strXSJSDID + "')";
                                    cmd.ExecuteNonQuery();
                                }
                                selection1.ClearSelection();
                                SlelectCountClear();
                                

                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.CommandText = "JT_C_XSJSD_TO_JZCBPZ";
                                    cmd.Parameters.Add("Userid", OracleType.VarChar).Value = FrmLogin.getUserID;
                                    cmd.Parameters.Add("Departmentid", OracleType.VarChar).Value = FrmLogin.getDeptID;
                                    cmd.Parameters.Add("Ls_Ztid", OracleType.VarChar).Value = FrmLogin.getZTID;
                                    cmd.Parameters.Add("Descerr", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
                                    cmd.Parameters.Add("Message", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
                                    cmd.ExecuteNonQuery();
                                    transaction.Commit();
                                    unitOfWork1.DropIdentityMap();
                                    xpServerCollectionSource1.Reload();
                                    MessageBox.Show(cmd.Parameters["Message"].Value.ToString());  

                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback();
                                MessageBox.Show(ex.Message);

                            }
                            finally
                            {
                                connection.Close();
                            }

                        }

                    }

                }

            }
        }

        private void btnYSPZ_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要进行应收凭证操作吗", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (selection1.SelectedCount == 0)
                {
                    MessageBox.Show("请先选择需要生成应收凭证的的销售结算单");
                }
                else
                {
                    bool fgcheck = false;
                    for (int i = 0; i < selection1.SelectedCount; ++i)
                    {
                        int RowIndex = selection1.GetSelectedRowIndex(i);
                        int RowHandle = gridView1.GetRowHandle(RowIndex);

                        string strYSPZID = gridView1.GetRowCellDisplayText(RowHandle, colYSPZID).ToString();
                        string strXSJSDH = gridView1.GetRowCellDisplayText(RowHandle, colXSJSDH).ToString();
                        string strZT = gridView1.GetRowCellDisplayText(RowHandle, colZT).ToString();

                        if (!String.IsNullOrEmpty(strYSPZID))
                        {
                            fgcheck = false;
                            MessageBox.Show("账号" + strXSJSDH + "已经生成了应收凭证");
                            break;

                        }
 
                        else if (string.IsNullOrEmpty(strZT)||Convert.ToInt64(strZT) <= 15)
                        {
                            fgcheck = false;
                            MessageBox.Show("账号" + strXSJSDH + "没有审核无法生成应收凭证");
                            break;

                        }
                        else if (FrmLogin.getZTID.ToString().Trim() != "306")
                        {
                            fgcheck = false;
                            MessageBox.Show("该操作只有连锁音像的权限才可以操作");
                            break;

                        }
                        else
                        {
                            fgcheck = true;
                        }

                    }
                    if (fgcheck == true)
                    {
                        using (OracleConnection connection = new OracleConnection(StrCon))
                        {
                            connection.Open();
                            OracleCommand cmd = connection.CreateCommand();
                            OracleTransaction transaction;
                            transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);
                            cmd.Transaction = transaction;
                            try
                            {

                                for (int i = 0; i < selection1.SelectedCount; ++i)
                                {
                                    int RowIndex = selection1.GetSelectedRowIndex(i);
                                    int RowHandle = gridView1.GetRowHandle(RowIndex);
                                    string strXSJSDH = gridView1.GetRowCellDisplayText(RowHandle, colXSJSDH).ToString();
                                    string strXSJSDID = gridView1.GetRowCellValue(RowHandle, colXSJSDID).ToString();
                                    cmd.CommandText = "INSERT INTO TEMP_SAVE_ID (TEMPID, ID) Values (TEMP_SAVE_ID_SEQ.nextval, '" + strXSJSDID + "')";
                                    cmd.ExecuteNonQuery();
                                }
                                selection1.ClearSelection();
                                SlelectCountClear();

                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.CommandText = "JT_C_XSJSD_TO_YSPZ";
                                    cmd.Parameters.Add("Userid", OracleType.VarChar).Value = FrmLogin.getUserID;
                                    cmd.Parameters.Add("Departmentid", OracleType.VarChar).Value = FrmLogin.getDeptID;
                                    cmd.Parameters.Add("Ls_Ztid", OracleType.VarChar).Value = FrmLogin.getZTID;
                                    cmd.Parameters.Add("Descerr", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
                                    cmd.Parameters.Add("Message", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
                                    cmd.ExecuteNonQuery();
                                    transaction.Commit();
                                    unitOfWork1.DropIdentityMap();
                                    xpServerCollectionSource1.Reload();
                                    MessageBox.Show(cmd.Parameters["Message"].Value.ToString());

                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback();
                                MessageBox.Show(ex.Message);
                            }
                            finally
                            {
                                connection.Close();
                            }

                        }

                    }

                }

            }
        }

        private void btnExportGrid_Click(object sender, EventArgs e)
        {
            if (this.Tag.ToString() == "JT_C_XSJSD_ZDJS" || this.Tag.ToString() == "JT_C_XSJSD_SXSJ")
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
            else if (this.Tag.ToString() == "JT_C_XSJSDMX")
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

        private void btnPrintTable_Click(object sender, EventArgs e)
        {
            if (this.Tag.ToString() == "JT_C_XSJSD_ZDJS" || this.Tag.ToString() == "JT_C_XSJSD_SXSJ")
            {

                gridView1.Columns["CheckMarkSelection"].Visible = false;

                gridView1.SelectAll();
                gridControl1.ShowPrintPreview();

                gridView1.Columns["CheckMarkSelection"].Visible = true;
                gridView1.Columns["CheckMarkSelection"].VisibleIndex = 0;
            }
            else if (this.Tag.ToString() == "JT_C_XSJSDMX")
            {

                gridView2.Columns["CheckMarkSelection"].Visible = false;

                gridView2.SelectAll();
                gridControl2.ShowPrintPreview();

                gridView2.Columns["CheckMarkSelection"].Visible = true;
                gridView2.Columns["CheckMarkSelection"].VisibleIndex = 0;
            }
           

        }

        private void btnBillAdd_Click(object sender, EventArgs e)
        {
            selection1.ClearSelection();
            selection2.ClearSelection();
            if (this.Tag.ToString() == "JT_C_XSJSD_ZDJS")
            {
                FrmSaleStageJTAdd frm = new FrmSaleStageJTAdd("0");
                frm.Text = "集团——销售结算单——整单结算——增加";
                frm.Tag = "JT_XSJSD_ZDJS_ADD";
                if (frm.ShowDialog() == DialogResult.OK)
                {
                //    if (string.IsNullOrEmpty(this.gridView1.ActiveFilterString))
                 //   {
                //        xpServerCollectionSource1.FixedFilterString = "[CZYID] = \'" + FrmLogin.getUserID + "\'And [ZTID] = \'" + FrmLogin.getZTID + "\'And [ZT] = \'" + "02" + "\'";
                //    }

                    unitOfWork1.DropIdentityMap();
                    SlelectCountClear();
                    xpServerCollectionSource1.Reload();
                    gridView1.BestFitColumns();
                }
            }
            else if (this.Tag.ToString() == "JT_C_XSJSD_SXSJ")
            {
                FrmSaleStageJTAdd frm = new FrmSaleStageJTAdd("0");
                frm.Text = "集团——销售结算单——实销实结——增加";
                frm.Tag = "JT_XSJSD_SXSJ_ADD";
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    if (string.IsNullOrEmpty(this.gridView1.ActiveFilterString))
                    {
                        xpServerCollectionSource1.FixedFilterString = "[CZYID] = \'" + FrmLogin.getUserID + "\'And [ZTID] = \'" + FrmLogin.getZTID + "\'And [ZT] = \'" + "02" + "\'";
                    }
                    unitOfWork1.DropIdentityMap();
                    SlelectCountClear();
                    xpServerCollectionSource1.Reload();
                    gridView1.BestFitColumns();
                }
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            if (this.Tag.ToString() == "JT_C_XSJSD_ZDJS" || this.Tag.ToString() == "JT_C_XSJSD_SXSJ")
            {
                unitOfWork1.DropIdentityMap();

                xpServerCollectionSource1.Reload();
            }
            else if (this.Tag.ToString() == "JT_C_XSJSDMX")
            {
                unitOfWork2.DropIdentityMap();
                xpServerCollectionSource2.Reload();
            }

           
        }


        private void btnMXDirQuery_Click(object sender, EventArgs e)
        {
            gridView2.ShowFilterEditor(gridView2.FocusedColumn);

            if (!String.IsNullOrEmpty(gridView2.ActiveFilterString))
            {
                // xpServerCollectionSource2.FixedFilterString = gridView2.ActiveFilterString;
                xpServerCollectionSource2.FixedFilterString = gridView2.ActiveFilterString;
                gridView2.BestFitColumns();
         

                
            }
        }

        private void btnTuoShou_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要进行托收操作吗", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                
                if (selection1.SelectedCount == 0)
                {
                    MessageBox.Show("请先选择需要生成托收的销售结算单");
                }
                else
                {
                    bool fgcheck = false;
                    bool fgCheckXE = false;

                
                     for (int i = 0; i < selection1.SelectedCount; ++i)
                     {
                         int RowIndex = selection1.GetSelectedRowIndex(i);
                         int RowHandle = gridView1.GetRowHandle(RowIndex);

                         string strTSDMXID = gridView1.GetRowCellDisplayText(RowHandle, colTSDMXID);
                         string strJSFS = gridView1.GetRowCellDisplayText(RowHandle, colJSFSMC);
                         string strXSJSDH = gridView1.GetRowCellDisplayText(RowHandle, colXSJSDH);
                         string strZT= gridView1.GetRowCellDisplayText(RowHandle, colZT);
                         string strJSHJ = gridView1.GetRowCellDisplayText(RowHandle, colJSHJ);
                         if (!String.IsNullOrEmpty(strTSDMXID))
                         {
                             fgcheck = false;
                             MessageBox.Show("账号" + strXSJSDH + "已经托收完毕");
                             break;

                         }
                         else if (strJSFS != "托收")
                         {
                             fgcheck = false;
                             MessageBox.Show("账号" + strXSJSDH + "不是托收方式无法生成托收单");
                             break;
                         }
                         else if (String.IsNullOrEmpty(strZT) || Convert.ToInt32(strZT) < 15)
                         {
                             fgcheck = false;
                             MessageBox.Show("账号" + strXSJSDH + "还未审核");
                             break;
                         }
                         else if (Convert.ToDecimal(strJSHJ) < 800)
                         {
                             fgcheck = false;
                             MessageBox.Show("账号" + strXSJSDH + "价税合计低于800无法生成托收单");
                             break;
                         }
                         else
                         {
                             fgcheck = true;
                         }
                     }
                     if (fgcheck == true)
                    {
                        FrmTuoShouData frm = new FrmTuoShouData();
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            TuoShouXianE = FrmTuoShouData.GetXe;

                        }
                        if (String.IsNullOrEmpty(TuoShouXianE.ToString()))
                        {
                            fgCheckXE = false;
                            MessageBox.Show("您还没有选择限额");


                        }
                        else
                        {
                            fgCheckXE = true;

                        }

                     }
                   if (fgcheck == true && fgCheckXE == true)
                        
                     {
                          using (OracleConnection connection = new OracleConnection(StrCon))
                          {
                              connection.Open();
                              OracleCommand cmd = connection.CreateCommand();
                              OracleTransaction transaction;
                              transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);
                              cmd.Transaction = transaction;

                              try 
                              {
                                  for (int i = 0; i < selection1.SelectedCount; ++i)
                                  {
                                      int RowIndex = selection1.GetSelectedRowIndex(i);
                                      int RowHandle = gridView1.GetRowHandle(RowIndex);
                                      string strXSJSDH = gridView1.GetRowCellDisplayText(RowHandle, colXSJSDH).ToString();
                                      string strXSJSDID = gridView1.GetRowCellValue(RowHandle, colXSJSDID).ToString();
                                      cmd.CommandText = "INSERT INTO TEMP_SAVE_ID (TEMPID, ID) Values (temp_save_id_seq.nextval, '" + strXSJSDID + "')";
                                      cmd.ExecuteNonQuery();
                                  }
                                  selection1.ClearSelection();
                                  SlelectCountClear();

                                  cmd.CommandType = CommandType.StoredProcedure;
                                  cmd.CommandText = "Jt_c_XSjsd_To_XStsd";
                                  cmd.Parameters.Add("Userid", OracleType.VarChar).Value = FrmLogin.getUserID;
                                  cmd.Parameters.Add("Departmentid", OracleType.VarChar).Value = FrmLogin.getDeptID;
                                  cmd.Parameters.Add("Ls_Ztid", OracleType.VarChar).Value = FrmLogin.getZTID;
                                  cmd.Parameters.Add("tsxe", OracleType.Number).Value = TuoShouXianE;

                                  cmd.Parameters.Add("Descerr", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
                                  cmd.Parameters.Add("Message", OracleType.VarChar, 255).Direction = ParameterDirection.Output;

                                  cmd.ExecuteNonQuery();
                                  transaction.Commit();

                                  unitOfWork1.DropIdentityMap();

                                  xpServerCollectionSource1.Reload();

                                      MessageBox.Show(cmd.Parameters["Message"].Value.ToString());
                                  
                              }
                              catch (OracleException ex)
                              {
                                  transaction.Rollback();
                                  MessageBox.Show(ex.Message);

                              }
                              finally
                              {
                                  connection.Close();
                              }
                          }

 
                     }
                   
                    
                }
 
            }
        }

        private void btnDirQuery_Click(object sender, EventArgs e)
        {
            if (this.Tag.ToString() == "JT_C_XSJSD_ZDJS" || this.Tag.ToString() == "JT_C_XSJSD_SXSJ")
            {
                if (selection1.SelectedCount == 0)
                {
                    gridView2.ShowFilterEditor(colSJLX);

                    if (!String.IsNullOrEmpty(gridView2.ActiveFilterString))
                    {
                        this.Tag = "JT_C_XSJSDMX";
                        XSJSDMX_Load();
                        xpServerCollectionSource2.FixedFilterString = gridView2.ActiveFilterString + " And [ZTID] = \'" + FrmLogin.getZTID + "\'";
                        gridView2.BestFitColumns();

                    }
                }
                else
                {
                    string strXSJSDID = null;
                    for (int i = 0; i < selection1.SelectedCount; ++i)
                    {
                        int RowIndex = selection1.GetSelectedRowIndex(i);
                        int RowHandle = gridView1.GetRowHandle(RowIndex);

                        string strTemp = gridView1.GetRowCellDisplayText(RowHandle, colXSJSDID);
                        strXSJSDID += "[XSJSDID] = \'" + strTemp + "\' Or ";
                    }

                    int index = strXSJSDID.LastIndexOf("'");
                    strXSJSDID = strXSJSDID.Substring(0, index + 1).Trim();
                    this.Tag = "JT_C_XSJSDMX";
                    XSJSDMX_Load();
                    xpServerCollectionSource2.FixedFilterString = strXSJSDID;
                    gridView2.BestFitColumns();

                }

            }
            else if (this.Tag.ToString() == "JT_C_XSJSDMX")
            {
                selection2.ClearSelection();
                gridView2.ShowFilterEditor(colSJLX);

                if (!String.IsNullOrEmpty(gridView1.ActiveFilterString))
                {

                   xpServerCollectionSource2.FixedFilterString = gridView2.ActiveFilterString + " And [ZTID] = \'" + FrmLogin.getZTID + "\'";
                    gridView2.BestFitColumns();
                }

            }
          
        }

        private void FrmSaleStageJT_Load(object sender, EventArgs e)
        {
            if (this.Tag.ToString() == "JT_C_XSJSD_ZDJS" || this.Tag.ToString() == "JT_C_XSJSD_SXSJ")
            {
                XSJSD_Load();
            }
            else if (this.Tag.ToString() == "JT_C_XSJSDMX")
            {
                XSJSDMX_Load();
            }
        }

        private void btnFreeze_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要进行冻结操作", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (selection1.SelectedCount == 0)
                {
                    MessageBox.Show("请先选择需要冻结的销售结算单");
                }
                else
                {
                    bool fgcheck = false;
                    for (int i = 0; i < selection1.SelectedCount; ++i)
                    {
                        int RowIndex = selection1.GetSelectedRowIndex(i);
                        int RowHandle = gridView1.GetRowHandle(RowIndex);

                        string strZT = gridView1.GetRowCellDisplayText(RowHandle, colZT);
                        string strXSJSDH = gridView1.GetRowCellDisplayText(RowHandle, colXSJSDH);
                        if (strZT == "88")
                        {
                            fgcheck = false;
                            MessageBox.Show("账号" + strXSJSDH + "只有存盘的销售单已经冻结");
                            break;
                        }

                        else
                        {
                            fgcheck = true;
                        }

                    }
                    if (fgcheck == true)
                    {
                        OracleConnection conn = new OracleConnection(StrCon);
                        try
                        {
                            conn.Open();
                            for (int i = 0; i < selection1.SelectedCount; ++i)
                            {
                                int RowIndex = selection1.GetSelectedRowIndex(i);
                                int RowHandle = gridView1.GetRowHandle(RowIndex);
                                string strXSJSDID = gridView1.GetRowCellDisplayText(RowHandle, colXSJSDID).ToString();
                                string strUpdata = " update JT_C_XSJSD set CZRQ = sysdate,YZT = zt, ZT = '88' where XSJSDID ='" + strXSJSDID + "'";
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
                            SlelectCountClear();
                            unitOfWork1.DropIdentityMap();
                            xpServerCollectionSource1.Reload();
                            MessageBox.Show("全部冻结成功");
                            conn.Close();

                        }

                    }
                }

            }
        }

        private void btnunfreeze_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要进行解冻操作", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (selection1.SelectedCount == 0)
                {
                    MessageBox.Show("请先选择需要解冻的销售结算单");
                }
                else
                {
                    bool fgcheck = false;
                    for (int i = 0; i < selection1.SelectedCount; ++i)
                    {
                        int RowIndex = selection1.GetSelectedRowIndex(i);
                        int RowHandle = gridView1.GetRowHandle(RowIndex);
                        string strZT = gridView1.GetRowCellValue(RowHandle, colZT).ToString();
                        string strXSJSDH = gridView1.GetRowCellValue(RowHandle, colXSJSDH).ToString();
                        if (strZT != "88")
                        {
                            fgcheck = false;
                            MessageBox.Show("账号" + strXSJSDH + "销售结算单无须解冻");
                            break;
                        }

                        else
                        {
                            fgcheck = true;
                        }

                    }
                    if (fgcheck == true)
                    {
                        OracleConnection conn = new OracleConnection(StrCon);
                        try
                        {
                            conn.Open();
                            for (int i = 0; i < selection1.SelectedCount; ++i)
                            {
                                int RowIndex = selection1.GetSelectedRowIndex(i);
                                int RowHandle = gridView1.GetRowHandle(RowIndex);
                                string strXSJSDID = gridView1.GetRowCellDisplayText(RowHandle, colXSJSDID).ToString();
                                string strUpdata = "update jt_c_xsjsd set  CZRQ = sysdate,ZT = Yzt where xsjsdid = '" + strXSJSDID + "'";
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
                            MessageBox.Show("全部解冻成功");
                            conn.Close();

                        }

                    }
                }

            }
        }

        private void btnPreview_Click_1(object sender, EventArgs e)
        {
            bool fgCheck = false;
            if (selection1.SelectedCount == 0)
            {

                fgCheck = false;
                MessageBox.Show("请先选择需要预览的采购结算单");
            }
            else if (selection1.SelectedCount != 1)
            {
                fgCheck = false;
                MessageBox.Show("每次只能预览一张采购结算单");
            }
            else
            {
                fgCheck = true;

            }
            if (fgCheck == true)
            {
                int RowIndex = selection1.GetSelectedRowIndex(0);
                int RowHandle = gridView1.GetRowHandle(RowIndex);
                string strXSJSDID = gridView1.GetRowCellValue(RowHandle, colXSJSDID).ToString();
                XtraReportXSJSDjt report = new XtraReportXSJSDjt(strXSJSDID);
                report.ShowPreviewDialog();


            }
        }

        private void btnBillLook_Click(object sender, EventArgs e)
        {
            bool check = false;
            if (selection1.SelectedCount == 0)
            { check = false; MessageBox.Show("请选择要查看的采购销售单"); }
            else if (selection1.SelectedCount != 1)
            { check = false; MessageBox.Show("每次只能看看一张采购销售单"); }
            else
            { check = true; }
            if (check == true)
            {
                int RowIndex = selection1.GetSelectedRowIndex(0);
                int RowHandle = gridView1.GetRowHandle(RowIndex);
                string strXSJSDID = gridView1.GetRowCellValue(RowHandle, colXSJSDID).ToString();
                if (this.Tag.ToString() == "JT_C_XSJSD_ZDJS")
                {

                    FrmSaleStageJTAdd frm = new FrmSaleStageJTAdd(strXSJSDID);
                    frm.Text = "集团——采购结算单——整单结算——查看";
                    frm.Tag = "JT_XSJSD_ZDJS_LOOK";
                    selection1.ClearSelection();
                    frm.ShowDialog();

                }
                else if (this.Tag.ToString() == "JT_C_XSJSD_SXSJ")
                {
                    FrmSaleStageJTAdd frm = new FrmSaleStageJTAdd(strXSJSDID);
                    frm.Text = "集团——采购结算单——实销实结——查看";
                    frm.Tag = "JT_XSJSD_SXSJ_LOOK";
                    selection1.ClearSelection();
                    frm.ShowDialog();
                }

            }
        }

        private void btnBillDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要进行删除操作", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (selection1.SelectedCount == 0)
                {
                    MessageBox.Show("请先选择需要删除的采购单");
                }
                else
                {
                    bool fgcheck = false;
                    for (int i = 0; i < selection1.SelectedCount; ++i)
                    {
                        int RowIndex = selection1.GetSelectedRowIndex(i);
                        int RowHandle = gridView1.GetRowHandle(RowIndex);

                        string strZTID = gridView1.GetRowCellDisplayText(RowHandle, colZTID).ToString().Trim();
                        string strZT = gridView1.GetRowCellDisplayText(RowHandle, colZT).ToString().Trim();
                        string strXSJSDH = gridView1.GetRowCellDisplayText(RowHandle, colXSJSDH).ToString().Trim();
                        string strCZYID = gridView1.GetRowCellDisplayText(RowHandle, colCZYID).ToString().Trim();

                        if (strZT != "02")
                        {
                            fgcheck = false;
                            MessageBox.Show("单号" + strXSJSDH + "采购单不是存盘状态无法删除");
                            break;
                        }
                        else if (strZTID != FrmLogin.getZTID.ToString())
                        {
                            fgcheck = false;
                            MessageBox.Show("单号" + strXSJSDH + "无法删除，您只有权限删除本部门帐套下的结算单");
                            break;
                        }
                        else if (strCZYID != FrmLogin.getUserID.ToString())
                        {
                            fgcheck = false;
                            MessageBox.Show("单号" + strXSJSDH + "无法删除，您只有权限删除本人新建的结算单");
                            break;

                        }
                        else
                        {
                            fgcheck = true;

                        }


                    }
                    if (fgcheck == true)
                    {


                        using (OracleConnection connection = new OracleConnection(StrCon))
                        {
                            connection.Open();
                            string alarm = "0";
                            string StoredProcedureName = "";
                            for (int i = 0; i < selection1.SelectedCount; ++i)
                            {
                                try
                                {
                                    OracleCommand cmd = connection.CreateCommand();

                                    int RowIndex = selection1.GetSelectedRowIndex(i);
                                    int RowHandle = gridView1.GetRowHandle(RowIndex);
                                    string strXSJSDH = gridView1.GetRowCellDisplayText(RowHandle, colXSJSDH).ToString();
                                    string strXSJSDID = gridView1.GetRowCellValue(RowHandle, colXSJSDID).ToString();
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    if (this.Tag.ToString() == "JT_C_XSJSD_ZDJS")
                                    {
                                        StoredProcedureName = "Jt_c_XSJS_ZDSC";//调用整单删除的存储
                                    }
                                    else if (this.Tag.ToString() == "JT_C_XSJSD_SXSJ")
                                    {
                                        StoredProcedureName = "Jt_c_XSJS_SXSC";//调用实销删除的存储
                                    }
                                    cmd.CommandText = StoredProcedureName;


                                    cmd.Parameters.Add("LS_XSJSDid", OracleType.VarChar).Value = strXSJSDID;

                                    cmd.Parameters.Add("Descerr", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
                                    cmd.Parameters.Add("Message", OracleType.VarChar, 255).Direction = ParameterDirection.Output;

                                    cmd.ExecuteNonQuery();

                                    alarm = cmd.Parameters["Descerr"].Value.ToString();
                                    if (alarm == "1")
                                    {

                                        MessageBox.Show("单号" + strXSJSDH + cmd.Parameters["Message"].Value.ToString());

                                        break;
                                    }

                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }

                            }
                            selection1.ClearSelection();
                            unitOfWork1.DropIdentityMap();
                            SlelectCountClear();
                            xpServerCollectionSource1.Reload();
                            if (alarm == "0")
                            {
                                connection.Close();
                                MessageBox.Show("所选择的结算单删除完毕");

                            }

                        }

                    }

                }
            }
        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要进行套打吗？这样占用较多时间，请不要关闭窗口", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (selection1.SelectedCount == 0)
                {
                    MessageBox.Show("请先选择需要打印报表的采购结算单");
                }
                else
                {
                    try
                    {
                        for (int i = 0; i < selection1.SelectedCount; ++i)
                        {
                            int RowIndex = selection1.GetSelectedRowIndex(i);
                            int RowHandle = gridView1.GetRowHandle(RowIndex);
                            string strXSJSDID = gridView1.GetRowCellValue(RowHandle, colXSJSDID).ToString();
                            XtraReportXSJSDjt report = new XtraReportXSJSDjt(strXSJSDID);
                            report.Print();
                            System.Threading.Thread.Sleep(1000);
                            report.Dispose();
                        }

                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }


                }
            }
        }

   
       





      

 
       

       


    }
}
