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

    public partial class FrmPurchaseStageJT : Form
    {
        GridCheckMarksSelection selection1;
        GridCheckMarksSelection selection2;
        const int MAXROWCOUNT = 50000;
        private string[] StrArrySetRepotr = new string[7];//传递到报表中的数组
        // private string StrCon = FrmLogin.strCon;
        private string StrCon = FrmLogin.strDataCent;
        //采购单选计
        private Int64 iPZS = 0;
        private Int64 iSHSL = 0;
        private double dSE = 0;
        private double dWSJE = 0;
        private double dZKE = 0;
        private double dSHSY = 0;
        private double dSHMY = 0;
        private double dPJZK = 0;
        private double dPJDJ = 0;
        private double dJSHJ = 0;
        //明细选计

        private double dJJ = 0;
        private double dSHSY1 = 0;
        private double dSHMY1 = 0;
        private Int64 iSHSL1 = 0;
        public FrmPurchaseStageJT()
        {
            InitializeComponent();
            //  XpoDefault.ConnectionString = OracleConnectionProvider.GetConnectionString("XINHUA", "xxb", "pass");
            XpoDefault.ConnectionString = FrmLogin.xpoDataCentStr;
            selection1 = new GridCheckMarksSelection(gridView1);
            selection1.CheckMarkColumn.VisibleIndex = 0;
            xpServerCollectionSource1.FixedFilterString = "[CGJSDID] Is Null";


            selection2 = new GridCheckMarksSelection(gridView2);
            selection2.CheckMarkColumn.VisibleIndex = 0;
            xpServerCollectionSource2.FixedFilterString = "[CGJSDMXID] Is Null";
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
            vDrawFootCell(e, colPZS, iPZS.ToString());
            vDrawFootCell(e, colSHSL, iSHSL.ToString());
            vDrawFootCell(e, colSE, dSE.ToString("F2"));
            vDrawFootCell(e, colJSHJ, dJSHJ.ToString("F2"));
            vDrawFootCell(e, colWSJE, dWSJE.ToString("F2"));
            vDrawFootCell(e, colZKE, dZKE.ToString("F2"));
            vDrawFootCell(e, colSHSY, dSHSY.ToString("F2"));
            vDrawFootCell(e, colSHMY, dSHMY.ToString("F2"));
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
                        iPZS = Convert.ToInt64(colPZS.SummaryText);
                        iSHSL = Convert.ToInt64(colSHSL.SummaryText);
                        dSE = Convert.ToDouble(colSE.SummaryText);
                        dWSJE = Convert.ToDouble(colWSJE.SummaryText);
                        dZKE = Convert.ToDouble(colZKE.SummaryText);
                        dSHSY = Convert.ToDouble(colSHSY.SummaryText);
                        dSHMY = Convert.ToDouble(colSHMY.SummaryText);
                        dPJZK = Convert.ToDouble(colPJZK.SummaryText);
                        dPJDJ = Convert.ToDouble(colPJDJ.SummaryText);
                        dJSHJ = Convert.ToDouble(colJSHJ.SummaryText);


                    }
                    else
                    {
                        iPZS = 0;
                        iSHSL = 0;
                        dSE = 0;
                        dWSJE = 0;
                        dZKE = 0;
                        dSHSY = 0;
                        dSHMY = 0;
                        dPJZK = 0;
                        dPJDJ = 0;
                        dJSHJ = 0;

                    }

                }
                if (hitInfo.InRowCell)
                {
                    if (selection1.IsRowSelected(hitInfo.RowHandle))
                    {
                        iPZS += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colPZS));
                        iSHSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colSHSL));
                        dSE += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colSE));
                        dWSJE += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colWSJE));
                        dZKE += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZKE));
                        dSHSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colSHSY));
                        dSHMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colSHMY));
                        dPJZK += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colPJZK));
                        dPJDJ += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colPJDJ));
                        dJSHJ += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJSHJ));

                    }
                    else
                    {
                        iPZS -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colPZS));
                        iSHSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colSHSL));
                        dSE -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colSE));
                        dWSJE -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colWSJE));
                        dZKE -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZKE));
                        dSHSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colSHSY));
                        dSHMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colSHMY));
                        dPJZK -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colPJZK));
                        dPJDJ -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colPJDJ));
                        dJSHJ -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJSHJ));
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
                if ((hitInfo.Column != null) && (hitInfo.Column == colCGJSDH))
                {
                    string strTemp = view.GetRowCellDisplayText(hitInfo.RowHandle, colCGJSDID);
                    //    string strCGSHID = "[CGSHID] = \'" + strTemp + "\'";
                    if (fc["FrmPurchaseReceiveDetail"] != null)
                    {
                        fc["FrmPurchaseReceiveDetail"].Close();
                    }
                    this.Tag = "JT_C_CGJSDMX";

                    xpServerCollectionSource2.FixedFilterString = " [CGJSDID] = \'" + strTemp + "\'";
                    gridView2.BestFitColumns();
                    CGJSDMX_Load();
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
            vDrawFootCell(e, colSJLX1, "选计：");
            vDrawFootCell(e, colSHSL1, iSHSL1.ToString());
           
            vDrawFootCell(e, colJJ1, dJJ.ToString("F2"));
            vDrawFootCell(e, colSHSY1, dSHSY1.ToString("F2"));
            vDrawFootCell(e, colSHMY1, dSHMY1.ToString("F2"));



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
                        iSHSL1 = Convert.ToInt64(colSHSL1.SummaryText);
                       
                        dJJ = Convert.ToDouble(colJJ1.SummaryText);
                        dSHSY1 = Convert.ToDouble(colSHSY1.SummaryText);
                        dSHMY1 = Convert.ToDouble(colSHMY1.SummaryText);

                    }
                    else
                    {
                        iSHSL1 = 0;
                 
                        dJJ = 0;
                        dSHSY1 = 0;
                        dSHMY1 = 0;
                    }

                }
                if (hitInfo.InRowCell)
                {
                    if (selection2.IsRowSelected(hitInfo.RowHandle))
                    {

                        iSHSL1 += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colSHSL1));
                        dJJ += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJJ1));
                        dSHSY1 += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colSHSY1));
                        dSHMY1 += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colSHMY1));

                    }
                    else
                    {
                        iSHSL1 -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colSHSL1));
                        dJJ -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJJ1));
                        dSHSY1 -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colSHSY1));
                        dSHMY1 -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colSHMY1));
                    }
                }
            }

        }
        private void SlelectCountClear()
        {
             iPZS = 0;
           iSHSL = 0;
             dSE = 0;
           dWSJE = 0;
            dZKE = 0;
            dSHSY = 0;
            dSHMY = 0;
            dPJZK = 0;
           dPJDJ = 0;
           dJSHJ = 0;
        }//清空选计
        private void CGJSD_Load()
        {
            this.btnBillQuery.Visible = true;
            this.btnBillAdd.Visible = true;
            this.btnBillAlter.Visible = true;
            this.btnBillDel.Visible = true;
            this.btnBillLook.Visible = true;
            this.btnConfirm.Visible = true;
            this.btnCGJSDFreeze.Visible = true;
            this.btnCGJSDunfreeze.Visible = true;
            this.btnHexiao.Visible = true;
            this.btnPreview.Visible = true;
            this.btnToFP.Visible = true;
            this.btnFKPZ.Visible = true;

            this.gridControl1.Visible = true;
            this.gridControl1.Dock = DockStyle.Fill;
            this.gridControl2.Visible = false;

            this.xpServerCollectionSource2.Dispose();




        }
        private void CGJSDMX_Load()
        {
            this.btnBillQuery.Visible = false;
            this.btnBillAdd.Visible = false;
            this.btnBillAlter.Visible = false;
            this.btnBillDel.Visible = false;
            this.btnBillLook.Visible = false;
            this.btnConfirm.Visible = false;
            this.btnCGJSDFreeze.Visible = false;
            this.btnCGJSDunfreeze.Visible = false;
            this.btnHexiao.Visible = false;
            this.btnPreview.Visible = false;
            this.btnToFP.Visible = false;
            this.btnFKPZ.Visible = false;
            this.btnPrintReport.Visible = false;

            this.gridControl1.Visible = false;
            this.gridControl2.Visible = true;
            this.gridControl2.Dock = DockStyle.Fill;

            this.xpServerCollectionSource1.Dispose();

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

        private void FrmCGJSDZDJS_Load(object sender, EventArgs e)
        {
            if (this.Tag.ToString() == "JT_C_CGJSD_ZDJS" || this.Tag.ToString() == "JT_C_CGJSD_SXSJ")
            {
                CGJSD_Load();
            }
            else if (this.Tag.ToString() == "JT_C_CGJSDMX")
            {
                CGJSDMX_Load();
            }
        }

        private void btnBillAdd_Click(object sender, EventArgs e)
        {

            selection1.ClearSelection();
            selection2.ClearSelection();
            if (this.Tag.ToString() == "JT_C_CGJSD_ZDJS")
            {
                FrmPurchaseStageJTAdd frm = new FrmPurchaseStageJTAdd("0");
                frm.Text = "集团——采购结算单——整单结算——增加";
                frm.Tag = "JT_CGJSD_ZDJS_ADD";
                if (frm.ShowDialog() == DialogResult.OK)
                {
                 //   if (string.IsNullOrEmpty(this.gridView1.ActiveFilterString))
                 //   {
                 //       xpServerCollectionSource1.FixedFilterString = "[CZYID] = \'" + FrmLogin.getUserID + "\'And [ZTID] = \'" + FrmLogin.getZTID + "\'And [ZT] = \'" + "02"+ "\'";
                 //   }
                    
                    unitOfWork1.DropIdentityMap();
                    SlelectCountClear();
                    xpServerCollectionSource1.Reload();
                    gridView1.BestFitColumns();
                }
            }
            else if (this.Tag.ToString() == "JT_C_CGJSD_SXSJ")
            {
                FrmPurchaseStageJTAdd frm = new FrmPurchaseStageJTAdd("0");
                frm.Text = "集团——采购结算单——实销实结——增加";
                frm.Tag = "JT_CGJSD_SXSJ_ADD";
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
                string strCGJSDID = gridView1.GetRowCellValue(RowHandle, colCGJSDID).ToString();
                string strCZYID = gridView1.GetRowCellDisplayText(RowHandle, colCZYID).ToString().Trim();
                if (strZT != "02")
                {
                    fgshowfrom = false;
                    MessageBox.Show("只有存盘状态下的结算单才可以被修改");
                }
                else if (strZTID!=FrmLogin.getZTID.ToString())
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
                    if (this.Tag.ToString() == "JT_C_CGJSD_ZDJS")
                    {
                       
                        FrmPurchaseStageJTAdd frm = new FrmPurchaseStageJTAdd(strCGJSDID);
                        frm.Text = "集团——采购结算单——整单结算——修改";
                        frm.Tag = "JT_CGJSD_ZDJS_ALTER";
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            selection1.ClearSelection();
                            SlelectCountClear();
                            unitOfWork1.DropIdentityMap();
                            xpServerCollectionSource1.Reload();
                            gridView1.BestFitColumns();
                        }
                    }
                    else if (this.Tag.ToString() == "JT_C_CGJSD_SXSJ")
                    {
                       
                        FrmPurchaseStageJTAdd frm = new FrmPurchaseStageJTAdd(strCGJSDID);
                        frm.Text = "集团——采购结算单——实销实结——修改";
                        frm.Tag = "JT_C_CGJSD_SXSJ_ALTER";
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
                        string strCGJSDH = gridView1.GetRowCellDisplayText(RowHandle, colCGJSDH).ToString().Trim();
                        string strCZYID= gridView1.GetRowCellDisplayText(RowHandle, colCZYID).ToString().Trim();

                        if (strZT!="02")
                        {
                            fgcheck = false;
                            MessageBox.Show("单号" + strCGJSDH + "采购单不是存盘状态无法删除");
                            break;
                        }
                        else if (strZTID != FrmLogin.getZTID.ToString())
                        {
                            fgcheck = false;
                            MessageBox.Show("单号" + strCGJSDH + "无法删除，您只有权限删除本部门帐套下的采购单");
                            break;
                        }
                        else if (strCZYID != FrmLogin.getUserID.ToString())
                        {
                            fgcheck = false;
                            MessageBox.Show("单号" + strCGJSDH + "无法删除，您只有权限删除本人新建的结算单");
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
                                    string strCGJSDH = gridView1.GetRowCellDisplayText(RowHandle, colCGJSDH).ToString();
                                    string strCGJSDID = gridView1.GetRowCellValue(RowHandle, colCGJSDID).ToString();
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    if (this.Tag.ToString() == "JT_C_CGJSD_ZDJS")
                                    {
                                        StoredProcedureName = "Jt_c_CGJS_ZDSC";//调用整单删除的存储
                                    }
                                    else if (this.Tag.ToString() == "JT_C_CGJSD_SXSJ")
                                    {
                                        StoredProcedureName = "Jt_c_CGJS_SXSC";//调用实销删除的存储
                                    }
                                    cmd.CommandText = StoredProcedureName;


                                    cmd.Parameters.Add("LS_CGJSDid", OracleType.VarChar).Value = strCGJSDID;

                                    cmd.Parameters.Add("Descerr", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
                                    cmd.Parameters.Add("Message", OracleType.VarChar, 255).Direction = ParameterDirection.Output;

                                    cmd.ExecuteNonQuery();

                                    alarm = cmd.Parameters["Descerr"].Value.ToString();
                                    if (alarm == "1")
                                    {

                                        MessageBox.Show("单号" + strCGJSDH + cmd.Parameters["Message"].Value.ToString());

                                        break;
                                    }

                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }

                            }
                            connection.Close();
                            selection1.ClearSelection();
                            unitOfWork1.DropIdentityMap();
                            SlelectCountClear();
                            xpServerCollectionSource1.Reload();
                            if (alarm == "0")
                            {

                                MessageBox.Show("所选择的采购结算单删除完毕");
                               
                            }

                        }

                    }

                }
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
            if (check ==true)
            {
                int RowIndex = selection1.GetSelectedRowIndex(0);
                int RowHandle = gridView1.GetRowHandle(RowIndex);
                string strZT = gridView1.GetRowCellDisplayText(RowHandle, colZT).ToString().Trim();
                string strZTID = gridView1.GetRowCellValue(RowHandle, colZTID).ToString();
                string strCGJSDID = gridView1.GetRowCellValue(RowHandle, colCGJSDID).ToString();
                string strCZYID = gridView1.GetRowCellDisplayText(RowHandle, colCZYID).ToString().Trim();

                if (this.Tag.ToString() == "JT_C_CGJSD_ZDJS")
                {

                    FrmPurchaseStageJTAdd frm = new FrmPurchaseStageJTAdd(strCGJSDID);
                    frm.Text = "集团——采购结算单——整单结算——查看";
                    frm.Tag = "JT_CGJSD_ZDJS_LOOK";
                    selection1.ClearSelection();
                    frm.ShowDialog();

                }
                else if (this.Tag.ToString() == "JT_C_CGJSD_SXSJ")
                {
                    FrmPurchaseStageJTAdd frm = new FrmPurchaseStageJTAdd(strCGJSDID);
                    frm.Text = "集团——采购结算单——实销实结——查看";
                    frm.Tag = "JT_CGJSD_SXSJ_LOOK";
                    selection1.ClearSelection();
                    frm.ShowDialog();
                }

            }

        }

        private void btnDirQuery_Click(object sender, EventArgs e)
        {
            if (this.Tag.ToString() == "JT_C_CGJSD_ZDJS" || this.Tag.ToString() == "JT_C_CGJSD_SXSJ")
            {
                if (selection1.SelectedCount == 0)
                {
                    gridView2.ShowFilterEditor(colSJLX1);

                    if (!String.IsNullOrEmpty(gridView2.ActiveFilterString))
                    {
                        this.Tag = "JT_C_CGJSDMX";
                       
                        CGJSDMX_Load();
                        xpServerCollectionSource2.FixedFilterString = gridView2.ActiveFilterString + " And [ZTID] = \'" + FrmLogin.getZTID + "\'";
                        gridView2.BestFitColumns();

                    }
                }
                else
                {
                    string strCGJSDID = null;
                    for (int i = 0; i < selection1.SelectedCount; ++i)
                    {
                        int RowIndex = selection1.GetSelectedRowIndex(i);
                        int RowHandle = gridView1.GetRowHandle(RowIndex);

                        string strTemp = gridView1.GetRowCellDisplayText(RowHandle, colCGJSDID);
                        strCGJSDID += "[CGJSDID] = \'" + strTemp + "\' Or ";
                    }

                    int index = strCGJSDID.LastIndexOf("'");
                    strCGJSDID = strCGJSDID.Substring(0, index + 1).Trim();
                    this.Tag = "JT_C_CGJSDMX";
                    selection1.ClearSelection();
                    CGJSDMX_Load();
                    xpServerCollectionSource2.FixedFilterString = strCGJSDID;
                    gridView2.BestFitColumns();

                }

            }
            else if (this.Tag.ToString() == "JT_C_CGJSDMX")
            {
                selection2.ClearSelection();
                gridView2.ShowFilterEditor(colSJLX1);

                if (!String.IsNullOrEmpty(gridView1.ActiveFilterString))
                {
                    xpServerCollectionSource2.FixedFilterString = gridView2.ActiveFilterString + " And [ZTID] = \'" + FrmLogin.getZTID + "\'";
                    gridView2.BestFitColumns();
                }

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

                        string strZT = gridView1.GetRowCellValue(RowHandle, colZT).ToString();
                        string strCGJSDH = gridView1.GetRowCellValue(RowHandle, colCGJSDH).ToString();
                        if (strZT != "02")
                        {
                            fgcheck = false;
                            MessageBox.Show("账号" + strCGJSDH + "只有存盘的采购单才可以确认审核");
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
                                      string strCGJSDID = gridView1.GetRowCellDisplayText(RowHandle, colCGJSDID).ToString();
                                      string strUpdata="update jt_c_cgjsd set CZRQ = sysdate,ZT = '15'where cgjsdid ='"+strCGJSDID+"'and zt='02'";
                                      OracleCommand comm=new OracleCommand(strUpdata,conn);
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

        private void btnCGJSDFreeze_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要进行冻结操作", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (selection1.SelectedCount == 0)
                {
                    MessageBox.Show("请先选择需要冻结的采购结算单");
                }
                else
                {
                    bool fgcheck = false;
                    for (int i = 0; i < selection1.SelectedCount; ++i)
                    {
                        int RowIndex = selection1.GetSelectedRowIndex(i);
                        int RowHandle = gridView1.GetRowHandle(RowIndex);
                        string strZT = gridView1.GetRowCellDisplayText(RowHandle, colZT);
                        string strCGJSDH = gridView1.GetRowCellDisplayText(RowHandle, colCGJSDH);
                        if (strZT == "88")
                        {
                            fgcheck = false;
                            MessageBox.Show("账号" + strCGJSDH + "已经冻结");
                            break;
                        }

                        else
                        {
                            fgcheck = true;
                        }

                    }
                    if (fgcheck== true)
                    {
                        OracleConnection conn = new OracleConnection(StrCon);
                        try
                        {
                            conn.Open();
                            for (int i = 0; i < selection1.SelectedCount; ++i)
                            {
                                int RowIndex = selection1.GetSelectedRowIndex(i);
                                int RowHandle = gridView1.GetRowHandle(RowIndex);
                                string strCGJSDID = gridView1.GetRowCellDisplayText(RowHandle, colCGJSDID).ToString();
                                string strUpdata = " update jt_c_cgjsd set CZRQ = sysdate,YZT = zt, ZT = '88' where cgjsdid ='"+strCGJSDID+"'";
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

        private void btnCGJSDunfreeze_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要进行解冻操作", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (selection1.SelectedCount == 0)
                {
                    MessageBox.Show("请先选择需要解冻的采购结算单");
                }
                else
                {
                    bool fgcheck = false;
                    for (int i = 0; i < selection1.SelectedCount; ++i)
                    {
                        int RowIndex = selection1.GetSelectedRowIndex(i);
                        int RowHandle = gridView1.GetRowHandle(RowIndex);
                        string strZT = gridView1.GetRowCellDisplayText(RowHandle, colZT);
                        string strCGJSDH = gridView1.GetRowCellDisplayText(RowHandle, colCGJSDH);
                        if (strZT != "88")
                        {
                            fgcheck = false;
                            MessageBox.Show("账号" + strCGJSDH + "无须解冻");
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
                                string strCGJSDID = gridView1.GetRowCellDisplayText(RowHandle, colCGJSDID).ToString();
                                string strUpdata = "update jt_c_cgjsd set  CZRQ = sysdate,ZT = Yzt where cgjsdid = '" + strCGJSDID + "'";
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
                            string strCGFPID = gridView1.GetRowCellDisplayText(RowHandle, colCGFPID).ToString();
                            string strCGJSDH = gridView1.GetRowCellDisplayText(RowHandle, colCGJSDH).ToString();
                            string strZT = gridView1.GetRowCellDisplayText(RowHandle, colZT).ToString();
                            //补充核销条件，根据状态全部付款（44）进行是否核销的判断-------更新

                            string strZDRQ = gridView1.GetRowCellDisplayText(RowHandle, colZDRQ).ToString();
                            DateTime dt1 = Convert.ToDateTime(strZDRQ);
                            DateTime dt2 = Convert.ToDateTime(time);
                            if (Convert.ToInt32(strZT) < 15)
                            {
                                fgcheck = false;
                                MessageBox.Show("单号为" + strCGJSDH + "还未审核，无法核销");
                                break;

                            }
                            else if (Convert.ToInt32(strZT) == 44)
                            {
                                fgcheck = false;
                                MessageBox.Show("单号为" + strCGJSDH + "已经核销完毕");
                                break;
                            }
                            else if (string.IsNullOrEmpty(time))
                            {
                                fgcheck = false;
                                MessageBox.Show("单号为" + strCGJSDH + "没有选定核销时间");
                                break;
                            }
                            else if (DateTime.Compare(dt1, dt2) > 0)
                            {
                                fgcheck = false;
                                MessageBox.Show("单号为" + strCGJSDH + "核销时间小于制单时间");
                                break;
                            }
                            else if (string.IsNullOrEmpty(strCGFPID))
                            {
                                fgcheck = false;
                                MessageBox.Show("单号为" + strCGJSDH + "还未生成发票，无法核销");
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
                                        string strCGJSDID = gridView1.GetRowCellDisplayText(RowHandle, colCGJSDID);
                                        string strCGJSDH = gridView1.GetRowCellDisplayText(RowHandle, colCGJSDH);
                                     //   System.Data.OracleClient.OracleDateTime currentTime;
                                    //    currentTime = System.Data.OracleClient.OracleDateTime.Parse(time);
                                        cmd.CommandType = CommandType.StoredProcedure;
                                        cmd.CommandText = "Jt_c_cgjsd_Hx";
                                        cmd.Parameters.Add("LS_CGJSDID", OracleType.VarChar).Value = strCGJSDID;
                                        cmd.Parameters.Add("Ls_Fkrq", OracleType.VarChar).Value = time;
                                        cmd.Parameters.Add("Descerr", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
                                        cmd.Parameters.Add("Message", OracleType.VarChar, 255).Direction = ParameterDirection.Output;

                                        cmd.ExecuteNonQuery();
                                        alarm = cmd.Parameters["Descerr"].Value.ToString();
                                        if (alarm == "1")
                                        {
                                            MessageBox.Show("单号" + strCGJSDH + cmd.Parameters["Message"].Value.ToString());

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

        private void btnFKPZ_Click(object sender, EventArgs e)
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

                        string strFKPZID = gridView1.GetRowCellDisplayText(RowHandle, colFKPZID).ToString();
                        string strCGJSDH = gridView1.GetRowCellValue(RowHandle, colCGJSDH).ToString();
                 //       string strFKRQ = gridView1.GetRowCellDisplayText(RowHandle, colFKRQ).ToString();
                        string strZT = gridView1.GetRowCellDisplayText(RowHandle, colZT).ToString();

                        if (!String.IsNullOrEmpty(strFKPZID))
                        {
                            fgcheck = false;
                           MessageBox.Show("账号" + strCGJSDH + "已经生成了付款凭证");
                            break;

                        }

                        else if (Convert.ToInt32(strZT)<44)
                        {
                            fgcheck = false;
                            MessageBox.Show("账号" + strCGJSDH + "还未核销");
                          break;
                        }
                        else
                        {
                            fgcheck = true;
                        }

                    }
                    if (fgcheck==true)
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
                                    string strCGJSDID = gridView1.GetRowCellValue(RowHandle, colCGJSDID).ToString();
                                    cmd.CommandText = "INSERT INTO TEMP_SAVE_ID (TEMPID, ID) Values (temp_save_id_seq.nextval, '" + strCGJSDID + "')";
                                    cmd.ExecuteNonQuery();
                                }
                                    selection1.ClearSelection();
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.CommandText = "JT_C_CGJSD_TO_FKPZ";
                                    cmd.Parameters.Add("Userid", OracleType.VarChar).Value = FrmLogin.getUserID;
                                    cmd.Parameters.Add("Departmentid", OracleType.VarChar).Value = FrmLogin.getDeptID;
                                    cmd.Parameters.Add("Ls_Ztid", OracleType.VarChar).Value = FrmLogin.getZTID;
                                    cmd.Parameters.Add("Descerr", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
                                    cmd.Parameters.Add("Message", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
                                    cmd.ExecuteNonQuery();
                                    transaction.Commit();
                                    unitOfWork1.DropIdentityMap();
                                    SlelectCountClear();
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

        private void btnReload_Click(object sender, EventArgs e)
        {
            if (this.Tag.ToString() == "JT_C_CGJSD_ZDJS" || this.Tag.ToString() == "JT_C_CGJSD_SXSJ")
            {
                unitOfWork1.DropIdentityMap();

                xpServerCollectionSource1.Reload();
            }
            else if (this.Tag.ToString() == "JT_C_CGJSDMX")
            {
                unitOfWork2.DropIdentityMap();
                xpServerCollectionSource2.Reload();
            }

           

        }

        private void btnExportGrid_Click(object sender, EventArgs e)
        {
            if (this.Tag.ToString() == "JT_C_CGJSD_ZDJS" || this.Tag.ToString() == "JT_C_CGJSD_SXSJ")
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
            else if (this.Tag.ToString() == "JT_C_CGJSDMX")
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
            if (this.Tag.ToString() == "JT_C_CGJSD_ZDJS" || this.Tag.ToString() == "JT_C_CGJSD_SXSJ")
            {

                gridView1.Columns["CheckMarkSelection"].Visible = false;

                gridView1.SelectAll();
                gridControl1.ShowPrintPreview();

                gridView1.Columns["CheckMarkSelection"].Visible = true;
                gridView1.Columns["CheckMarkSelection"].VisibleIndex = 0;
            }
            else if (this.Tag.ToString() == "JT_C_CGJSDMX")
            {

                gridView2.Columns["CheckMarkSelection"].Visible = false;

                gridView2.SelectAll();
                gridControl2.ShowPrintPreview();

                gridView2.Columns["CheckMarkSelection"].Visible = true;
                gridView2.Columns["CheckMarkSelection"].VisibleIndex = 0;
            }
           

        }

      
        private void btnPreview_Click(object sender, EventArgs e)
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
                fgCheck =true;
 
            }
            if(fgCheck==true)
            {
                int RowIndex = selection1.GetSelectedRowIndex(0);
                int RowHandle = gridView1.GetRowHandle(RowIndex);
                string strCGJSDID = gridView1.GetRowCellValue(RowHandle, colCGJSDID).ToString();
                MakeStrArry(strCGJSDID);
                XtraReportCGJSD report = new XtraReportCGJSD(GetTempDataSet(strCGJSDID), StrArrySetRepotr);
                report.ShowPreviewDialog();


            }

        }
        private void MakeStrArry(string id)
        {
            string StrCon = FrmLogin.strCon;
            OracleConnection connection = new OracleConnection(StrCon);
            string str = "select ztidmc,dwmc,cgjsdh,jsfsmc,jsr,czrmc,zhjsrq from view_jt_c_cgjsd where cgjsdid='"+id+"'";
            OracleCommand comm = new OracleCommand(str,connection);
  
            try
            {
                connection.Open();
                OracleDataReader reader = comm.ExecuteReader();
                while(reader.Read())
                {
                    StrArrySetRepotr[0] = reader.GetValue(0).ToString();
                    StrArrySetRepotr[1] = reader.GetValue(1).ToString();
                    StrArrySetRepotr[2] = reader.GetValue(2).ToString();
                    StrArrySetRepotr[3] = reader.GetValue(3).ToString();
                    StrArrySetRepotr[4] = reader.GetValue(4).ToString();
                    StrArrySetRepotr[5] = reader.GetValue(5).ToString();
                    StrArrySetRepotr[6] = reader.GetValue(6).ToString();
            
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }



        }
        private DataSet GetTempDataSet(string id)
        {
            DataSet ds = new DataSet();

            OracleConnection connection = new OracleConnection(StrCon);
            try
            {
                connection.Open();
                string str = "select shdh,pzs,shsl,shsy,shmy from view_jt_c_cgjsdmx where cgjsdid='" + id + "'";
                OracleDataAdapter adp = new OracleDataAdapter(str, connection);
                adp.Fill(ds);
                
            }
            catch(Exception ex)
            {
                throw ex;
            }
                finally
            {
                connection.Close();
            }

               return ds;
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
                            string strCGJSDID = gridView1.GetRowCellValue(RowHandle, colCGJSDID).ToString();
                            MakeStrArry(strCGJSDID);
                            XtraReportCGJSD report = new XtraReportCGJSD(GetTempDataSet(strCGJSDID), StrArrySetRepotr);
                            report.Print();
                            System.Threading.Thread.Sleep(1000);
                            report.Dispose();
                        }
 
                    }
                    catch(Exception ex)
                    {
                        throw ex;
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

                        string strCGFPID = gridView1.GetRowCellDisplayText(RowHandle, colCGFPID);
                        string strCGJSDH = gridView1.GetRowCellDisplayText(RowHandle, colCGJSDH);
                        string strZT = gridView1.GetRowCellDisplayText(RowHandle, colZT);
                        if (!String.IsNullOrEmpty(strCGFPID))
                        {
                            fgcheck = false;
                            MessageBox.Show("账号" + strCGJSDH + "已经生成了结算发票");
                            break;

                        }
                        else if (String.IsNullOrEmpty(strZT))
                        {
                            fgcheck = false;
                          MessageBox.Show("账号" + strCGJSDH + "状态为空无法生成结算发票");
                           break;
                        }
                        else if (Convert.ToInt32(strZT)<15)
                        {
                            fgcheck = false;
                            MessageBox.Show("账号" + strCGJSDH + "还未审核无法生成结算发票");
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
                            OracleCommand cmd = connection.CreateCommand();
                            OracleTransaction transaction;
                            connection.Open();
                            transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);
                            cmd.Transaction = transaction;


                            try
                            {
                                for (int i = 0; i < selection1.SelectedCount; ++i)
                                {
                                    int RowIndex = selection1.GetSelectedRowIndex(i);
                                    int RowHandle = gridView1.GetRowHandle(RowIndex);
                                    string strCGJSDID = gridView1.GetRowCellValue(RowHandle, colCGJSDID).ToString();
                                    cmd.CommandText = "INSERT INTO TEMP_SAVE_ID (TEMPID, ID) Values (temp_save_id_seq.nextval, '" + strCGJSDID + "')";
                                    cmd.ExecuteNonQuery();
                                }
                                selection1.ClearSelection();

                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.CommandText = "JT_C_CGJSD_TO_cgFP";
                                    cmd.Parameters.Add("Userid", OracleType.VarChar).Value = FrmLogin.getUserID;
                                    cmd.Parameters.Add("ls_cwbmid", OracleType.VarChar).Value = FrmLogin.getDeptID;
                                    cmd.Parameters.Add("Ls_Ztid", OracleType.VarChar).Value = FrmLogin.getZTID;
                                    cmd.Parameters.Add("Descerr", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
                                    cmd.Parameters.Add("Message", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
                                    cmd.ExecuteNonQuery();
                                    transaction.Commit();

                                    unitOfWork1.DropIdentityMap();
                                    SlelectCountClear();
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
    }
}
