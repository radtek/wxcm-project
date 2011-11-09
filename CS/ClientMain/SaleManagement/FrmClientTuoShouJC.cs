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
    public partial class FrmClientTuoShouJC : Form
    {
        GridCheckMarksSelection selection1;
        GridCheckMarksSelection selection2;
        const int MAXROWCOUNT = 50000;
        // private string StrCon = FrmLogin.strCon;
        private string StrCon = FrmLogin.strDataCent;
        //托收单选计
        double dTSJE = 0;
        //托收单明细选计
        Int64 iSL = 0;
        double WSJE = 0;
        double SE = 0;
        double JSHJ = 0;
        public FrmClientTuoShouJC()
        {
            InitializeComponent();
            //  XpoDefault.ConnectionString = OracleConnectionProvider.GetConnectionString("XINHUA", "xxb", "pass");
            XpoDefault.ConnectionString = FrmLogin.xpoDataCentStr;
            selection1 = new GridCheckMarksSelection(gridView1);
            selection1.CheckMarkColumn.VisibleIndex = 0;
            xpServerCollectionSource1.FixedFilterString = " [XSTSDID] Is Null";

            selection2 = new GridCheckMarksSelection(gridView2);
            selection2.CheckMarkColumn.VisibleIndex = 0;
            xpServerCollectionSource2.FixedFilterString = " [XSTSDMXID] Is Null";
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
            vDrawFootCell(e, colTSJE, dTSJE.ToString("F2"));

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

                        dTSJE = Convert.ToDouble(colTSJE.SummaryText);


                    }
                    else
                    {

                        dTSJE = 0;

                    }

                }
                if (hitInfo.InRowCell)
                {
                    if (selection1.IsRowSelected(hitInfo.RowHandle))
                    {

                        dTSJE += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colTSJE));

                    }
                    else
                    {
                        dTSJE -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colTSJE));

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
            vDrawFootCell(e, colXSTSDH, "选计：");
            vDrawFootCell(e, colSL1, iSL.ToString());
            vDrawFootCell(e, colWSJE1, WSJE.ToString("F2"));
            vDrawFootCell(e, colSE1, SE.ToString("F2"));
            vDrawFootCell(e, colJSHJ1, JSHJ.ToString("F2"));

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
                        iSL = Convert.ToInt64(colSL1.SummaryText);
                        WSJE = Convert.ToDouble(colWSJE1.SummaryText);
                        SE = Convert.ToDouble(colSE1.SummaryText);
                        JSHJ = Convert.ToDouble(colJSHJ1.SummaryText);


                    }
                    else
                    {
                        iSL = 0;
                        WSJE = 0;
                        SE = 0;
                        JSHJ = 0;

                    }

                }
                if (hitInfo.InRowCell)
                {
                    if (selection1.IsRowSelected(hitInfo.RowHandle))
                    {
                        iSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colSL1));
                        WSJE += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colWSJE1));
                        SE += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colSE1));
                        JSHJ += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJSHJ1));

                    }
                    else
                    {
                        iSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colSL1));
                        WSJE -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colWSJE1));
                        SE -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colSE1));
                        JSHJ -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJSHJ1));
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
                if ((hitInfo.Column != null) && (hitInfo.Column == colXSTSDH))
                {
                    string strTemp = view.GetRowCellDisplayText(hitInfo.RowHandle, colXSTSDID);
                    //    string strCGSHID = "[CGSHID] = \'" + strTemp + "\'";
                    if (fc["FrmPurchaseReceiveDetail"] != null)
                    {
                        fc["FrmPurchaseReceiveDetail"].Close();
                    }
                    this.Tag = "JT_C_KHTSDMC";

                    xpServerCollectionSource2.FixedFilterString = " [XSTSDID] = \'" + strTemp + "\'";
                    gridView2.BestFitColumns();


                }


            }


        }
        private void JC_C_KHTSD_Load()
        {
            this.btnBillAdd.Visible = true;
            this.btnBillAlter.Visible = true;
            this.btnBillDel.Visible = true;
            this.btnBillLook.Visible = true;
            this.btnBillQuery.Visible = true;
            this.btnConfirm.Visible = true;
            this.btnHexiao.Visible = true;
            this.btnHKPZ.Visible = true;
            this.btnJuFu.Visible = true;
            this.btnPreview.Visible = true;
            this.btnToFP.Visible = true;
            this.gridControl1.Dock = DockStyle.Fill;
            this.gridControl1.Visible = true;
            this.gridControl2.Visible = false;
            this.xpServerCollectionSource2.Dispose();
        }
        private void JC_C_KHTSDMX_Load()
        {
            this.gridControl1.Visible = false;
            this.xpServerCollectionSource1.Dispose();
            this.btnBillAdd.Visible = false;
            this.btnBillAlter.Visible = false;
            this.btnBillDel.Visible = false;
            this.btnBillLook.Visible = false;
            this.btnBillQuery.Visible = false;
            this.btnConfirm.Visible = false;
            this.btnHexiao.Visible = false;
            this.btnHKPZ.Visible = false;
            this.btnJuFu.Visible = false;
            this.btnPreview.Visible = false;
            this.btnToFP.Visible = false;
            this.gridControl2.Visible = true;

            this.gridControl2.Dock = DockStyle.Fill;
            this.Text = "客户托收单明细";
        }
        private void SelectCountClear()
        {
            dTSJE = 0;

            iSL = 0;
            WSJE = 0;
            SE = 0;
            JSHJ = 0;
        }
        private void FrmClientTuoShouJC_Load(object sender, EventArgs e)
        {
            if (this.Tag.ToString() == "JC_C_KHTSD")
            {
                JC_C_KHTSD_Load();

            }
            else if (this.Tag.ToString() == "JC_C_KHTSDMC")
            {
                JC_C_KHTSDMX_Load();
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

        private void btnBillAdd_Click(object sender, EventArgs e)
        {
            selection1.ClearSelection();
            selection2.ClearSelection();
            FrmClientTuoShouJCAdd frm = new FrmClientTuoShouJCAdd("0");
            frm.Text = "市县客户托收单增加";
            frm.Tag = "JC_KHTSD_ADD";
            if (frm.ShowDialog() == DialogResult.OK)
            {
                unitOfWork1.DropIdentityMap();
                xpServerCollectionSource1.Reload();
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
                string strXSTSDID = gridView1.GetRowCellValue(RowHandle, colXSTSDID).ToString();
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

                    FrmClientTuoShouJCAdd frm = new FrmClientTuoShouJCAdd(strXSTSDID);
                    frm.Text = "市县——客户托收单——修改";
                    frm.Tag = "JC_KHTSD_ALTER";
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        selection1.ClearSelection();
                        SelectCountClear();
                        unitOfWork1.DropIdentityMap();
                        xpServerCollectionSource1.Reload();
                        gridView1.BestFitColumns();
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
                    MessageBox.Show("请先选择需要删除的托收单");
                }
                else
                {
                    bool fgcheck = true;
                    for (int i = 0; i < selection1.SelectedCount; ++i)
                    {
                        int RowIndex = selection1.GetSelectedRowIndex(i);
                        int RowHandle = gridView1.GetRowHandle(RowIndex);

                        string strZTID = gridView1.GetRowCellDisplayText(RowHandle, colZTID).ToString().Trim();
                        string strZT = gridView1.GetRowCellDisplayText(RowHandle, colZT).ToString().Trim();
                        string strXSTSDH = gridView1.GetRowCellDisplayText(RowHandle, colXSTSDH).ToString().Trim();
                        string strczyid = gridView1.GetRowCellDisplayText(RowHandle, colCZYID).ToString().Trim();

                        if (strZT != "02")
                        {
                            fgcheck = false;
                            MessageBox.Show("单号" + strXSTSDH + "无法删除，您只有权限删除状态为存盘托收单");
                            break;
                        }
                        else if (strZTID != FrmLogin.getZTID.ToString())
                        {
                            fgcheck = false;
                            MessageBox.Show("单号" + strXSTSDH + "无法删除，您只有权限删除本部门帐套下的采购单");
                            break;
                        }
                        else if (strczyid != FrmLogin.getUserID.ToString())
                        {
                            fgcheck = false;
                            MessageBox.Show("单号" + strXSTSDH + "无法删除，您只有权限删除本人新建的结算单");
                            break;

                        }
                        else
                        {
                            fgcheck = true;

                        }


                    }
                    if (fgcheck == true)
                    {
                        OracleConnection connection = new OracleConnection(StrCon);
                        string alarm = "0";
                        for (int i = 0; i < selection1.SelectedCount; ++i)
                        {
                            try
                            {
                                connection.Open();

                                OracleCommand cmd = connection.CreateCommand();
                                int RowIndex = selection1.GetSelectedRowIndex(i);
                                int RowHandle = gridView1.GetRowHandle(RowIndex);
                                string strXSTSDH = gridView1.GetRowCellDisplayText(RowHandle, colXSTSDH).ToString();
                                string strXSTSDID = gridView1.GetRowCellValue(RowHandle, colXSTSDID).ToString();
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.CommandText = "JC_c_XSTSD_delete";
                                cmd.Parameters.Add("LS_XSTSDid", OracleType.VarChar).Value = strXSTSDID;
                                cmd.Parameters.Add("Descerr", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
                                cmd.Parameters.Add("Message", OracleType.VarChar, 255).Direction = ParameterDirection.Output;

                                cmd.ExecuteNonQuery();

                                alarm = cmd.Parameters["Descerr"].Value.ToString();
                                if (alarm == "1")
                                {

                                    MessageBox.Show("单号" + strXSTSDH + cmd.Parameters["Message"].Value.ToString());

                                    break;
                                }

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                            finally
                            {
                                connection.Close();
                            }
                        }

                        selection1.ClearSelection();
                        unitOfWork1.DropIdentityMap();
                        SelectCountClear();
                        xpServerCollectionSource1.Reload();
                        if (alarm == "0")
                        {

                            MessageBox.Show("所选择的托收单删除完毕");

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
            { check = false; MessageBox.Show("每次只能查看一张采购销售单"); }
            else
            { check = true; }
            if (check == true)
            {
                int RowIndex = selection1.GetSelectedRowIndex(0);
                int RowHandle = gridView1.GetRowHandle(RowIndex);
                string strXSTSDID = gridView1.GetRowCellValue(RowHandle, colXSTSDID).ToString();
                FrmClientTuoShouJTAdd frm = new FrmClientTuoShouJTAdd(strXSTSDID);
                frm.Text = "市县——客户托收单——查看";
                frm.Tag = "JC_KHTSD_LOOK";
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    selection1.ClearSelection();
                    SelectCountClear();
                    unitOfWork1.DropIdentityMap();
                    xpServerCollectionSource1.Reload();
                    gridView1.BestFitColumns();
                }

            }
        }

        private void btnDirQuery_Click(object sender, EventArgs e)
        {
            if (this.Tag.ToString() == "JC_C_KHTSD")
            {
                if (selection1.SelectedCount == 0)
                {
                    gridView2.ShowFilterEditor(colXSJSDH);

                    if (!String.IsNullOrEmpty(gridView2.ActiveFilterString))
                    {
                        this.Tag = "JC_C_KHTSDMX";

                        JC_C_KHTSDMX_Load();
                        xpServerCollectionSource2.FixedFilterString = gridView2.ActiveFilterString + " And [ZTID] = \'" + FrmLogin.getZTID + "\'";
                        gridView2.BestFitColumns();

                    }
                }
                else
                {
                    string strXSTSDID = null;
                    for (int i = 0; i < selection1.SelectedCount; ++i)
                    {
                        int RowIndex = selection1.GetSelectedRowIndex(i);
                        int RowHandle = gridView1.GetRowHandle(RowIndex);

                        string strTemp = gridView1.GetRowCellDisplayText(RowHandle, colXSTSDID);
                        strXSTSDID += "[XSTSDID] = \'" + strTemp + "\' Or ";
                    }

                    int index = strXSTSDID.LastIndexOf("'");
                    strXSTSDID = strXSTSDID.Substring(0, index + 1).Trim();
                    this.Tag = "JC_C_KHTSDMX";
                    selection1.ClearSelection();
                    SelectCountClear();
                    JC_C_KHTSDMX_Load();
                    xpServerCollectionSource2.FixedFilterString = strXSTSDID;
                    gridView2.BestFitColumns();

                }

            }
            else if (this.Tag.ToString() == "JC_C_KHTSDMX")
            {
                selection2.ClearSelection();
                gridView2.ShowFilterEditor(colZTMC);

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
                        string strXSTSDH = gridView1.GetRowCellValue(RowHandle, colXSTSDH).ToString();
                        if (strZT != "02")
                        {
                            fgcheck = false;
                            MessageBox.Show("账号" + strXSTSDH + "只有存盘的采购单才可以确认审核");
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
                                string strXSTSDID = gridView1.GetRowCellDisplayText(RowHandle, colXSTSDID).ToString();
                                string strUpdata = "update jc_c_XSTSD set CZRQ = sysdate,ZT = '15'where xstsdid ='" + strXSTSDID + "'and zt='02'";
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
                            SelectCountClear();
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
                    MessageBox.Show("请先选择需要生成发票的客户托收单");
                }
                else
                {
                    bool fgcheck = false;
                    for (int i = 0; i < selection1.SelectedCount; ++i)
                    {
                        int RowIndex = selection1.GetSelectedRowIndex(i);
                        int RowHandle = gridView1.GetRowHandle(RowIndex);

                        string strXSFPH = gridView1.GetRowCellDisplayText(RowHandle, colXSFPH).ToString();
                        string strZT = gridView1.GetRowCellDisplayText(RowHandle, colZT).ToString();
                        string strXSTSDH = gridView1.GetRowCellValue(RowHandle, colXSTSDH).ToString();

                        if (!String.IsNullOrEmpty(strXSFPH))
                        {
                            fgcheck = false;
                            MessageBox.Show("账号" + strXSTSDH + "已经生成了结算发票");
                            break;

                        }
                        else if (strZT != "15")
                        {
                            fgcheck = false;
                            MessageBox.Show("账号" + strXSTSDH + "只有审核状态的托收单才能生成发票");
                            break;
                        }
                        else
                        {
                            fgcheck = true;
                        }

                    }
                    if (fgcheck == true)
                    {
                        OracleConnection connection = new OracleConnection(StrCon);
                        string alarm = "0";
                        for (int i = 0; i < selection1.SelectedCount; ++i)
                        {
                            try
                            {
                                connection.Open();

                                OracleCommand cmd = connection.CreateCommand();
                                int RowIndex = selection1.GetSelectedRowIndex(i);
                                int RowHandle = gridView1.GetRowHandle(RowIndex);
                                string strXSTSDH = gridView1.GetRowCellDisplayText(RowHandle, colXSTSDH).ToString();
                                string strXSTSDID = gridView1.GetRowCellValue(RowHandle, colXSTSDID).ToString();
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.CommandText = "JC_C_XSTSD_TO_XSFP";
                                cmd.Parameters.Add("LS_XSTSDid", OracleType.VarChar).Value = strXSTSDID;
                                cmd.Parameters.Add("Descerr", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
                                cmd.Parameters.Add("Message", OracleType.VarChar, 255).Direction = ParameterDirection.Output;

                                cmd.ExecuteNonQuery();

                                alarm = cmd.Parameters["Descerr"].Value.ToString();
                                if (alarm == "1")
                                {

                                    MessageBox.Show("单号" + strXSTSDH + cmd.Parameters["Message"].Value.ToString());

                                    break;
                                }

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                            finally
                            {
                                connection.Close();
                            }
                        }

                        selection1.ClearSelection();
                        unitOfWork1.DropIdentityMap();
                        SelectCountClear();
                        xpServerCollectionSource1.Reload();
                        if (alarm == "0")
                        {

                            MessageBox.Show("所选择的托收发票完毕");

                        }
                    }

                }

            }
        }

        private void btnTuoShou_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要进行托收操作吗", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                if (selection1.SelectedCount == 0)
                {
                    MessageBox.Show("请先选择需要生成托收的客户托收单");
                }
                else
                {
                    bool fgcheck = false;


                    for (int i = 0; i < selection1.SelectedCount; ++i)
                    {
                        int RowIndex = selection1.GetSelectedRowIndex(i);
                        int RowHandle = gridView1.GetRowHandle(RowIndex);

                        string strXSTSDID = gridView1.GetRowCellDisplayText(RowHandle, colXSTSDID).ToString();
                        string strZT = gridView1.GetRowCellDisplayText(RowHandle, colZT).ToString();
                        string strXSTSDH = gridView1.GetRowCellDisplayText(RowHandle, colXSTSDH).ToString();
                        string strXSFPID = gridView1.GetRowCellDisplayText(RowHandle, colXSFPID).ToString();
                        if (strZT == "45")
                        {
                            fgcheck = false;
                            MessageBox.Show("账号" + strXSTSDH + "已经托收完毕");
                            break;

                        }
                        else if (strZT != "15")
                        {
                            fgcheck = false;
                            MessageBox.Show("账号" + strXSTSDH + "只有审核的托收单才能托收");
                            break;
                        }
                        else if (String.IsNullOrEmpty(strXSFPID))
                        {
                            fgcheck = false;
                            MessageBox.Show("账号" + strXSTSDH + "还没有生成发票");
                            break;
                        }
                        else
                        {
                            fgcheck = true;
                        }
                    }
                    if (fgcheck == true)
                    {
                        OracleConnection connection = new OracleConnection(StrCon);
                        {
                            connection.Open();
                            string alarm = "0";
                            for (int i = 0; i < selection1.SelectedCount; ++i)
                            {
                                try
                                {


                                    OracleCommand cmd = connection.CreateCommand();
                                    int RowIndex = selection1.GetSelectedRowIndex(i);
                                    int RowHandle = gridView1.GetRowHandle(RowIndex);
                                    string strXSTSDH = gridView1.GetRowCellDisplayText(RowHandle, colXSTSDH).ToString();
                                    string strXSTSDID = gridView1.GetRowCellValue(RowHandle, colXSTSDID).ToString();
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.CommandText = "JC_C_XSTSD_TS";
                                    cmd.Parameters.Add("LS_XSTSDid", OracleType.VarChar).Value = strXSTSDID;
                                    cmd.Parameters.Add("Descerr", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
                                    cmd.Parameters.Add("Message", OracleType.VarChar, 255).Direction = ParameterDirection.Output;

                                    cmd.ExecuteNonQuery();

                                    alarm = cmd.Parameters["Descerr"].Value.ToString();
                                    if (alarm == "1")
                                    {

                                        MessageBox.Show("单号" + strXSTSDH + cmd.Parameters["Message"].Value.ToString());

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
                            SelectCountClear();
                            xpServerCollectionSource1.Reload();

                            if (alarm == "0")
                            {

                                MessageBox.Show("所选择的托收单删除完毕");

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
                    MessageBox.Show("请先选择需要核销的托收单");
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
                            string strXSFPID = gridView1.GetRowCellDisplayText(RowHandle, colXSFPID).ToString();
                            string strXSTSDH = gridView1.GetRowCellDisplayText(RowHandle, colXSTSDH).ToString();
                            string strZT = gridView1.GetRowCellDisplayText(RowHandle, colZT).ToString();
                            string strZDRQ = gridView1.GetRowCellDisplayText(RowHandle, colZDRQ).ToString();
                            DateTime dt1 = Convert.ToDateTime(strZDRQ);
                            DateTime dt2 = Convert.ToDateTime(time);
                            if (Convert.ToInt32(strZT) < 15)
                            {
                                fgcheck = false;
                                MessageBox.Show("单号为" + strXSTSDH + "还未审核，无法核销");
                                break;

                            }
                            else if (Convert.ToInt32(strZT) == 44)
                            {
                                fgcheck = false;
                                MessageBox.Show("单号为" + strXSTSDH + "已经核销");
                                break;
                            }
                            else if (string.IsNullOrEmpty(time))
                            {
                                fgcheck = false;
                                MessageBox.Show("单号为" + strXSTSDH + "没有选定核销时间");
                                break;
                            }
                            else if (DateTime.Compare(dt1, dt2) > 0)
                            {
                                fgcheck = false;
                                MessageBox.Show("单号为" + strXSTSDH + "核销时间小于制单时间");
                                break;
                            }
                            else if (string.IsNullOrEmpty(strXSFPID))
                            {
                                fgcheck = false;
                                MessageBox.Show("单号为" + strXSTSDH + "还未生成发票，无法核销");
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
                                        string strXSTSDID = gridView1.GetRowCellDisplayText(RowHandle, colXSTSDID);
                                        string strXSTSDH = gridView1.GetRowCellDisplayText(RowHandle, colXSTSDH);
                                        cmd.CommandType = CommandType.StoredProcedure;
                                        cmd.CommandText = "JC_C_XSTSD_Hx";
                                        cmd.Parameters.Add("ls_xstsdid", OracleType.VarChar).Value = strXSTSDID;
                                        cmd.Parameters.Add("Ls_Hkrq", OracleType.VarChar).Value = time;
                                        cmd.Parameters.Add("Descerr", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
                                        cmd.Parameters.Add("Message", OracleType.VarChar, 255).Direction = ParameterDirection.Output;

                                        cmd.ExecuteNonQuery();
                                        alarm = cmd.Parameters["Descerr"].Value.ToString();
                                        if (alarm == "1")
                                        {
                                            MessageBox.Show("单号" + strXSTSDH + cmd.Parameters["Message"].Value.ToString());

                                            break;
                                        }


                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                    }

                                }
                                selection1.ClearSelection();
                                SelectCountClear();
                                unitOfWork1.DropIdentityMap();
                                xpServerCollectionSource1.Reload();
                                if (alarm == "0")
                                {
                                    connection.Close();

                                    MessageBox.Show("所选择的托收算单核销完毕");

                                }

                            }
                        }

                    }
                }
            }
        }

        private void btnJuFu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要进行拒付操作吗", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (selection1.SelectedCount == 0)
                {
                    MessageBox.Show("请先选择需要拒付客户托收单");
                }
                else
                {

                    using (OracleConnection connection = new OracleConnection(StrCon))
                    {
                        connection.Open();
                        string alarm = "0";
                        for (int i = 0; i < selection1.SelectedCount; ++i)
                        {
                            try
                            {
                                OracleCommand cmd = connection.CreateCommand();
                                int RowIndex = selection1.GetSelectedRowIndex(i);
                                int RowHandle = gridView1.GetRowHandle(RowIndex);
                                string strXSTSDH = gridView1.GetRowCellDisplayText(RowHandle, colXSTSDH).ToString();
                                string strXSTSDID = gridView1.GetRowCellValue(RowHandle, colXSTSDID).ToString();
                                string strZT = gridView1.GetRowCellDisplayText(RowHandle, colZT);
                                if (strZT == "45")
                                {
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.CommandText = "JC_C_XSTSD_JF";
                                    cmd.Parameters.Add("LS_XSTSDid", OracleType.VarChar).Value = strXSTSDID;
                                    cmd.Parameters.Add("Descerr", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
                                    cmd.Parameters.Add("Message", OracleType.VarChar, 255).Direction = ParameterDirection.Output;

                                    cmd.ExecuteNonQuery();
                                    alarm = cmd.Parameters["Descerr"].Value.ToString();
                                    if (alarm == "1")
                                    {

                                        MessageBox.Show("单号" + strXSTSDH + cmd.Parameters["Message"].Value.ToString());

                                        break;
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("只有托收状态才可以拒付");
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
                        SelectCountClear();
                        xpServerCollectionSource1.Reload();

                        if (alarm == "0")
                        {

                            MessageBox.Show("前面托收状态托收单拒付完毕");

                        }

                    }


                }
            }
        }

        private void btnHKPZ_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要进行回款凭证操作吗", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (selection1.SelectedCount == 0)
                {
                    MessageBox.Show("请先选择需要生成应收凭证的的销售结算单");
                }
                else
                {
                    string str = "0";
                    OracleConnection conn = new OracleConnection(StrCon);
                    try
                    {
                        conn.Open();
                        for (int i = 0; i < selection1.SelectedCount; ++i)
                        {
                            int RowIndex = selection1.GetSelectedRowIndex(i);
                            int RowHandle = gridView1.GetRowHandle(RowIndex);
                            string strXSTSDID = gridView1.GetRowCellValue(RowHandle, colXSTSDID).ToString();
                            string selectxsjsdid = "select XSJSDID from JC_C_XSTSDMX where XSTSDID='" + strXSTSDID + "'";
                            OracleCommand comm = new OracleCommand(selectxsjsdid, conn);
                            OracleDataReader reader = comm.ExecuteReader();
                            while (reader.Read())
                            {
                                str = str + "," + reader.GetValue(0).ToString();
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }

                    using (OracleConnection connection = new OracleConnection(StrCon))
                    {
                        connection.Open();
                        OracleCommand cmd = connection.CreateCommand();
                        OracleTransaction transaction;
                        transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);
                        cmd.Transaction = transaction;
                        try
                        {

                            cmd.CommandText = "INSERT INTO TEMP_SAVE_ID (TEMPID, ID) select temp_save_id_seq.nextval,xsjsdid from jt_c_xsjsd where xsjsdid in (" + str + ")";
                            cmd.ExecuteNonQuery();
                            selection1.ClearSelection();
                            SelectCountClear();

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.CommandText = "JC_C_XSJSD_TO_SKPZ";
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
                fgCheck = true;

            }
            if (fgCheck == true)
            {
                int RowIndex = selection1.GetSelectedRowIndex(0);
                int RowHandle = gridView1.GetRowHandle(RowIndex);
                string strXSTSDID = gridView1.GetRowCellValue(RowHandle, colXSTSDID).ToString();
                XtraReportXSTSDjt report = new XtraReportXSTSDjt(strXSTSDID);
                report.ShowPreviewDialog();


            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            if (this.Tag.ToString() == "JC_C_KHTSD")
            {
                unitOfWork1.DropIdentityMap();

                xpServerCollectionSource1.Reload();
            }
            else if (this.Tag.ToString() == "JC_C_KHTSDMX")
            {
                unitOfWork2.DropIdentityMap();

                xpServerCollectionSource2.Reload();
            }
        }

        private void btnExportGrid_Click(object sender, EventArgs e)
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

        private void btnPrintTable_Click(object sender, EventArgs e)
        {
            gridView1.Columns["CheckMarkSelection"].Visible = false;

            gridView1.SelectAll();
            gridControl1.ShowPrintPreview();

            gridView1.Columns["CheckMarkSelection"].Visible = true;
            gridView1.Columns["CheckMarkSelection"].VisibleIndex = 0;
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
                            string strXSTSDID = gridView1.GetRowCellValue(RowHandle, colXSTSDID).ToString();
                            XtraReportXSTSDjc report = new XtraReportXSTSDjc(strXSTSDID);
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

        private void btnColCustomize_Click(object sender, EventArgs e)
        {
            if (this.Tag.ToString() == "JC_C_KHTSD")
            {
                gridView1.ShowCustomization();

            }
            else if (this.Tag.ToString() == "JC_C_KHTSDMC")
            {
                gridView2.ShowCustomization();
            }
        }

        private void btnSaveLayout_Click(object sender, EventArgs e)
        {
            if (this.Tag.ToString() == "JC_C_KHTSD")
            {
                string strLayout = FrmLogin.getUser + "_FrmClientTuoShouJCLayout.xml";
                FileStream stream = new FileStream(strLayout, FileMode.Create);
                gridView1.SaveLayoutToStream(stream);
                stream.Close();

            }
            else if (this.Tag.ToString() == "JC_C_KHTSDMC")
            {
                string strLayout = FrmLogin.getUser + "_FrmClientTuoShouJCMXLayout.xml";
                FileStream stream = new FileStream(strLayout, FileMode.Create);
                gridView2.SaveLayoutToStream(stream);
                stream.Close();
            }
        }

        private void btnLoadLayout_Click(object sender, EventArgs e)
        {
            if (this.Tag.ToString() == "JC_C_KHTSD")
            {
                string strLayout = FrmLogin.getUser + "_FrmClientTuoShouJCLayout.xml";
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
            else if (this.Tag.ToString() == "JC_C_KHTSDMC")
            {
                string strLayout = FrmLogin.getUser + "_FrmClientTuoShouJCMXLayout.xml";
                if (File.Exists(strLayout))
                {
                    gridView2.RestoreLayoutFromXml(strLayout);
                    MessageBox.Show("载入视图成功！");
                }
                else
                {
                    MessageBox.Show("未发现视图保存文件，请确认是否曾经保存！");
                }
            }
        }
    }
}
