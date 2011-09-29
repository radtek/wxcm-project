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
    public partial class FrmUnusualStockReturns : Form
    {
        GridCheckMarksSelection selection1;
        GridCheckMarksSelection selection2;
        const int MAXROWCOUNT = 50000;
        //JTD选计
        Int64 iJTPZS = 0;
        Int64 iJTZSL = 0;
        double dJTZSY = 0;
        double dJTZMY = 0;
        //JTDMX选计
        Int64 iJTSL = 0;
        double dJTSY = 0;
        double dJTMY = 0;
        double dDJ = 0;
        string[] StrArrySetRepotr = new string[9];

        public FrmUnusualStockReturns()
        {
            InitializeComponent();
            XpoDefault.ConnectionString = OracleConnectionProvider.GetConnectionString("XINHUA", "xxb", "pass");
            selection1 = new GridCheckMarksSelection(gridView1);
            selection1.CheckMarkColumn.VisibleIndex = 0;
            xpServerCollectionSource1.FixedFilterString = "[JTDID] Is Null";
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            this.gridView1.CustomDrawFooterCell += new DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventHandler(this.gridView1_CustomDrawFooterCell);
            this.gridView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gridView1_MouseUp);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);

            selection2 = new GridCheckMarksSelection(gridView2);
            selection2.CheckMarkColumn.VisibleIndex = 0;
            xpServerCollectionSource2.FixedFilterString = "[JTDMXID] Is Null";
            this.gridView2.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView2_CustomDrawRowIndicator);
            this.gridView2.CustomDrawFooterCell += new DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventHandler(this.gridView2_CustomDrawFooterCell);
            this.gridView2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gridView2_MouseUp);
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
            vDrawFootCell(e, colJTPZS, iJTPZS.ToString());
            vDrawFootCell(e, colJTZSL, iJTZSL.ToString());
            vDrawFootCell(e, colJTZSY, dJTZSY.ToString("F2"));
            vDrawFootCell(e, colJTZMY, dJTZMY.ToString("F2"));


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
                        iJTPZS = Convert.ToInt64(colJTPZS.SummaryText);
                        iJTZSL = Convert.ToInt64(colJTZSL.SummaryText);
                        dJTZSY = Convert.ToDouble(colJTZSY.SummaryText);
                        dJTZMY = Convert.ToDouble(colJTZMY.SummaryText);

                    }
                    else
                    {
                        dJTZMY = 0;
                        dJTZSY = 0;
                        iJTZSL = 0;
                        iJTPZS = 0;

                    }

                }
                if (hitInfo.InRowCell)
                {
                    if (selection1.IsRowSelected(hitInfo.RowHandle))
                    {
                        iJTZSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colJTZSL));
                        iJTPZS += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colJTPZS));
                        dJTZSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJTZSY));

                        dJTZMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJTZMY));


                    }
                    else
                    {
                        iJTZSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colJTZSL));
                        iJTPZS -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colJTPZS));
                        dJTZSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJTZSY));

                        dJTZMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJTZMY));
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
            vDrawFootCell(e, colJTDHZTMC1, "选计：");
            vDrawFootCell(e, colJTSL1, iJTSL.ToString());
            vDrawFootCell(e, colJTSY1, dJTSY.ToString("F2"));
            vDrawFootCell(e, colJTMY1, dJTMY.ToString("F2"));
            vDrawFootCell(e, colDJ1, dDJ.ToString("F2"));


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
                        iJTSL = Convert.ToInt64(colJTSL1.SummaryText);
                        dJTSY = Convert.ToDouble(colJTSY1.SummaryText);
                        dJTMY = Convert.ToDouble(colJTMY1.SummaryText);
                        dDJ = Convert.ToDouble(colDJ1.SummaryText);

                    }
                    else
                    {
                        iJTSL = 0;
                        dJTSY = 0;
                        dJTMY = 0;
                        dDJ = 0;

                    }

                }
                if (hitInfo.InRowCell)
                {
                    if (selection2.IsRowSelected(hitInfo.RowHandle))
                    {
                        iJTSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colJTSL1));
                        dJTSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJTSY1));
                        dJTMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJTMY1));

                        dDJ += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colDJ1));


                    }
                    else
                    {
                        iJTSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colJTSL1));
                        dJTSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJTSY1));
                        dJTMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJTMY1));

                        dDJ -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colDJ1));
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
                if ((hitInfo.Column != null) && (hitInfo.Column == colJTDH))
                {
                    string strTemp = view.GetRowCellDisplayText(hitInfo.RowHandle, colJTDID);
                    //    string strCGSHID = "[CGSHID] = \'" + strTemp + "\'";
                    if (fc["FrmPurchaseReceiveDetail"] != null)
                    {
                        fc["FrmPurchaseReceiveDetail"].Close();
                    }
                    this.Tag = "JC_G_JTDMX";

                    xpServerCollectionSource2.FixedFilterString = " [JTDID] = \'" + strTemp + "\'";
                    gridView2.BestFitColumns();
                    Control_Load_JTDMX();
                }


            }


        }
        private void Control_Load_JTD()
        {
            this.gridControl1.Visible = true;
            this.gridControl1.Dock = DockStyle.Fill;

            this.gridControl2.Visible = false;
            this.xpServerCollectionSource2.Dispose();

            this.btnBillAdd.Visible = true;
            this.btnBillCheck.Visible = true;
            this.btnBillDelete.Visible = true;
            this.btnBillEdit.Visible = true;
            this.btnBillInput.Visible = true;
            this.btnBillLook.Visible = true;
            this.btnBillQuery.Visible = true;
            this.btnBoxPriview.Visible = true;
            this.btnDetirQuery.Visible = true;
            this.btnDirtePriview.Visible = true;
            this.btnModelOutput.Visible = true;
            this.btnPrint.Visible = true;

        }
        private void Control_Load_JTDMX()
        {
            this.btnBillAdd.Visible = false;
            this.btnBillCheck.Visible = false;
            this.btnBillEdit.Visible = false;
            this.btnBillInput.Visible = false;
            this.btnBillLook.Visible = false;
            this.btnBillQuery.Visible = false;
            this.btnBoxPriview.Visible = false;
            this.btnDirtePriview.Visible = false;
            this.btnModelOutput.Visible = false;
            this.btnBillDelete.Visible = false;
            this.xpServerCollectionSource1.Dispose();
            this.gridControl1.Visible = false;
            this.gridControl2.Visible = true;
            this.gridControl2.Dock = DockStyle.Fill;
        }

        private void btnBillQuery_Click(object sender, EventArgs e)
        {
            selection1.ClearSelection();
            gridView1.ShowFilterEditor(gridView1.FocusedColumn);

            if (!String.IsNullOrEmpty(gridView1.ActiveFilterString))
            {
                // xpServerCollectionSource1.FixedFilterString = gridView1.ActiveFilterString;
                xpServerCollectionSource1.FixedFilterString = gridView1.ActiveFilterString + " And [ZTID] = \'" + FrmLogin.getZTID + "\'";
                gridView1.BestFitColumns();
            }
        }

        private void btnBillDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要进行删除操作", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (selection1.SelectedCount == 0)
                {
                    MessageBox.Show("请先选择需要删除的采购单");
                }
                else
                {
                    bool fgCheck = false;
                    for (int i = 0; i < selection1.SelectedCount; ++i)
                    {
                        int RowIndex = selection1.GetSelectedRowIndex(i);
                        int RowHandle = gridView1.GetRowHandle(RowIndex);

                        string strZTID = gridView1.GetRowCellDisplayText(RowHandle, colZTID).ToString().Trim();
                        string strZT = gridView1.GetRowCellDisplayText(RowHandle, colZT).ToString().Trim();
                        string strJTDH = gridView1.GetRowCellDisplayText(RowHandle, colJTDH).ToString().Trim();
                        string strczyid = gridView1.GetRowCellDisplayText(RowHandle, colCZYID).ToString().Trim();

                        if (Convert.ToInt32(strZT) > 02)
                        {
                            fgCheck = false;
                            MessageBox.Show("这个单子已经确认过了无法删除");
                        }
                        else if (strZTID != FrmLogin.getZTID.ToString())
                        {
                            fgCheck = false;
                            MessageBox.Show("只有自己帐套下建立的单子才可以删除");

                        }
                        else if (string.IsNullOrEmpty(strJTDH))
                        {
                            fgCheck = false;
                            MessageBox.Show("该进退单为空号");

                        }
                        else if (strczyid != FrmLogin.getUserID.ToString())
                        {
                            fgCheck = false;
                            MessageBox.Show("只能删除自己建立的进退单");
                        }
                        else
                        {
                            fgCheck = true;
                        }
                    }

                    if (fgCheck == true)
                    {
                        string alarm = "0";
                        string StrCon = FrmLogin.strCon;
                        using (OracleConnection connection = new OracleConnection(StrCon))
                        {
                            connection.Open();
                            for (int i = 0; i < selection1.SelectedCount; ++i)
                            {
                                OracleCommand cmd = connection.CreateCommand();
                                OracleTransaction transaction;
                                transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);
                                cmd.Transaction = transaction;

                                int RowIndex = selection1.GetSelectedRowIndex(i);
                                int RowHandle = gridView1.GetRowHandle(RowIndex);
                                try
                                {


                                    string strJTDHID = gridView1.GetRowCellValue(RowHandle, colJTDID).ToString();
                                    string strJTDH = gridView1.GetRowCellValue(RowHandle, colJTDH).ToString();
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.CommandText = "jc_g_jtd_delete";
                                    cmd.Parameters.Add("LS_JTDID", OracleType.VarChar).Value = strJTDHID;
                                    cmd.Parameters.Add("DescErr", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
                                    cmd.Parameters.Add("Message", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
                                    cmd.ExecuteNonQuery();
                                    transaction.Commit();
                                    alarm = cmd.Parameters["DescErr"].Value.ToString();
                                    if (alarm == "1")
                                    {
                                        MessageBox.Show("单号为" + strJTDH + cmd.Parameters["Message"].Value.ToString());
                                        break;
                                    }

                                }
                                catch (Exception ex)
                                {
                                    transaction.Rollback();
                                    MessageBox.Show(ex.Message);
                                }
                                finally
                                { }


                            }
                            unitOfWork1.DropIdentityMap();
                            xpServerCollectionSource1.Reload();
                            if (alarm == "0")
                            { MessageBox.Show("全部删除成功"); }
                            connection.Close();
                        }
                    }

                }
            }
        }

        private void FrmUnusualStockReturns_Load(object sender, EventArgs e)
        {
            if (this.Tag.ToString() == "JC_G_JTD")
            {
                Control_Load_JTD();
            }
        }

        private void btnBillAdd_Click(object sender, EventArgs e)
        {
            FrmUnusualStockReturnsAdd from = new FrmUnusualStockReturnsAdd();
            from.Tag = "JC_G_JTD_ADD";
            from.Text = "非正常库存退货功能";
            if (from.ShowDialog() == DialogResult.OK)
            {
                if (!String.IsNullOrEmpty(gridView1.ActiveFilterString))
                {
                    xpServerCollectionSource1.FixedFilterString = gridView1.ActiveFilterString + " And [ZTID] = \'" + FrmLogin.getZTID + "\'";
                }
                else
                {
                    xpServerCollectionSource1.FixedFilterString = "[CZYID] = \'" + FrmLogin.getUserID + "\'";

                }
                this.unitOfWork1.DropIdentityMap();
                this.xpServerCollectionSource1.Reload();
            }


        }

        private void btnModelOutput_Click(object sender, EventArgs e)
        {
            string primitivefilepath = System.Windows.Forms.Application.StartupPath;
            string primitivefilename = primitivefilepath + "\\notNormalBack_report.xls";
            FolderBrowserDialog Fbd = new FolderBrowserDialog();
            if (Fbd.ShowDialog() == DialogResult.OK)
            {
                string loadpath = Fbd.SelectedPath;
                string loadfilename = loadpath + "\\notNormalBack_report.xls";

                File.Copy(primitivefilename, loadfilename, true);
                MessageBox.Show("导出完毕");
                //  string i = "1";
            }



        }

        private void btnBillEdit_Click(object sender, EventArgs e)
        {
            bool fgCheck = false;
            string selectid = "";
            if (selection1.SelectedCount != 1)
            {
                fgCheck = false;
                MessageBox.Show("请选择一张进退单编辑");
            }
            else
            {
                int RowIndex = selection1.GetSelectedRowIndex(0);
                int RowHandle = gridView1.GetRowHandle(RowIndex);
                string strZTID = gridView1.GetRowCellDisplayText(RowHandle, colZTID).ToString().Trim();
                string strZT = gridView1.GetRowCellDisplayText(RowHandle, colZT).ToString().Trim();
                string strJTDH = gridView1.GetRowCellDisplayText(RowHandle, colJTDH).ToString().Trim();
                string strczyid = gridView1.GetRowCellDisplayText(RowHandle, colCZYID).ToString().Trim();
                string strJTDID = gridView1.GetRowCellDisplayText(RowHandle, colJTDID).ToString().Trim();
                if (Convert.ToInt32(strZT) > 02)
                {
                    fgCheck = false;
                    MessageBox.Show("这个单子已经确认过了无法删除");
                }
                else if (strZTID != FrmLogin.getZTID.ToString())
                {
                    fgCheck = false;
                    MessageBox.Show("只有自己帐套下建立的单子才可以删除");

                }
                else if (string.IsNullOrEmpty(strJTDH))
                {
                    fgCheck = false;
                    MessageBox.Show("该进退单为空号");

                }
                else if (strczyid != FrmLogin.getUserID.ToString())
                {
                    fgCheck = false;
                    MessageBox.Show("只能删除自己建立的进退单");
                }
                else
                {
                    selectid = strJTDID;
                    fgCheck = true;

                }



            }
            if (fgCheck == true)
            {
                FrmUnusualStockReturnsAdd from = new FrmUnusualStockReturnsAdd(selectid);
                from.Tag = "JC_G_JTD_EDIT";
                from.Text = "非正常库存退货功能";
                if (from.ShowDialog() == DialogResult.OK)
                {
                    if (!String.IsNullOrEmpty(gridView1.ActiveFilterString))
                    {
                        xpServerCollectionSource1.FixedFilterString = gridView1.ActiveFilterString + " And [ZTID] = \'" + FrmLogin.getZTID + "\'";
                    }
                    else
                    {
                        xpServerCollectionSource1.FixedFilterString = "[CZYID] = \'" + FrmLogin.getUserID + "\'";

                    }
                    this.unitOfWork1.DropIdentityMap();
                    this.xpServerCollectionSource1.Reload();
                }

            }



        }

        private void btnBillLook_Click(object sender, EventArgs e)
        {

            if (selection1.SelectedCount != 1)
            {
                MessageBox.Show("请选择一张进退单产查看");
            }
            else
            {
                int RowIndex = selection1.GetSelectedRowIndex(0);
                int RowHandle = gridView1.GetRowHandle(RowIndex);
                string strZTID = gridView1.GetRowCellDisplayText(RowHandle, colZTID).ToString().Trim();
                string strZT = gridView1.GetRowCellDisplayText(RowHandle, colZT).ToString().Trim();
                string strJTDH = gridView1.GetRowCellDisplayText(RowHandle, colJTDH).ToString().Trim();
                string strczyid = gridView1.GetRowCellDisplayText(RowHandle, colCZYID).ToString().Trim();
                string strJTDID = gridView1.GetRowCellDisplayText(RowHandle, colJTDID).ToString().Trim();

                FrmUnusualStockReturnsAdd from = new FrmUnusualStockReturnsAdd(strJTDID);
                from.Tag = "JC_G_JTD_LOOK";
                from.Text = "非正常库存退货功能";
                from.ShowDialog();



            }



        }

        private void btnDetirQuery_Click(object sender, EventArgs e)
        {
            if (selection1.SelectedCount == 0)
            {
                gridView2.ShowFilterEditor(gridView2.FocusedColumn);

                if (!String.IsNullOrEmpty(gridView2.ActiveFilterString))
                {
                    // xpServerCollectionSource2.FixedFilterString = gridView2.ActiveFilterString;
                    xpServerCollectionSource2.FixedFilterString = gridView2.ActiveFilterString;
                    gridView2.BestFitColumns();
                    this.Tag = "JC_G_JTDMX";
                    Control_Load_JTDMX();
                }
            }
            else
            {
                string strJTDID = null;
                for (int i = 0; i < selection1.SelectedCount; ++i)
                {
                    int RowIndex = selection1.GetSelectedRowIndex(i);
                    int RowHandle = gridView1.GetRowHandle(RowIndex);

                    string strTemp = gridView1.GetRowCellDisplayText(RowHandle, colJTDID);
                    strJTDID += "[JTDID] = \'" + strTemp + "\' Or ";
                }

                int index = strJTDID.LastIndexOf("'");
                strJTDID = strJTDID.Substring(0, index + 1).Trim();
                xpServerCollectionSource2.FixedFilterString = strJTDID;
                selection1.ClearSelection();
                this.Tag = "JC_G_JTDMX";
                gridView2.BestFitColumns();
                Control_Load_JTDMX();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (this.Tag.ToString() == "JC_G_JTD")
            {
                gridView1.Columns["CheckMarkSelection"].Visible = false;

                gridView1.SelectAll();
                gridControl1.ShowPrintPreview();

                gridView1.Columns["CheckMarkSelection"].Visible = true;
                gridView1.Columns["CheckMarkSelection"].VisibleIndex = 0;
            }
            else if (this.Tag.ToString() == "JC_G_JTDMX")
            {
                gridView2.Columns["CheckMarkSelection"].Visible = false;

                gridView2.SelectAll();
                gridControl2.ShowPrintPreview();

                gridView2.Columns["CheckMarkSelection"].Visible = true;
                gridView2.Columns["CheckMarkSelection"].VisibleIndex = 0;
            }
        }

        private void btnBillCheck_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要进行确认操作", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (selection1.SelectedCount == 0)
                {
                    MessageBox.Show("请先选择需要确认的采购单");
                }
                else
                {
                    bool fgCheck = false;
                    for (int i = 0; i < selection1.SelectedCount; ++i)
                    {
                        int RowIndex = selection1.GetSelectedRowIndex(i);
                        int RowHandle = gridView1.GetRowHandle(RowIndex);

                        string strZTID = gridView1.GetRowCellDisplayText(RowHandle, colZTID).ToString().Trim();
                        string strZT = gridView1.GetRowCellDisplayText(RowHandle, colZT).ToString().Trim();
                        string strJTDH = gridView1.GetRowCellDisplayText(RowHandle, colJTDH).ToString().Trim();

                        if (Convert.ToInt32(strZT) > 02)
                        {
                            fgCheck = false;
                            MessageBox.Show("这个单子已经确认过了无法再确认");
                        }
                        else if (strZTID != FrmLogin.getZTID.ToString())
                        {
                            fgCheck = false;
                            MessageBox.Show("只能确认自己帐套下建立的单子才可以删除");

                        }
                        else if (string.IsNullOrEmpty(strJTDH))
                        {
                            fgCheck = false;
                            MessageBox.Show("该进退单为空号");

                        }

                        else
                        {
                            fgCheck = true;
                        }
                    }
                    if (fgCheck == true)
                    {
                        string alarm = "0";
                        string StrCon = FrmLogin.strCon;
                        using (OracleConnection connection = new OracleConnection(StrCon))
                        {
                            connection.Open();
                            for (int i = 0; i < selection1.SelectedCount; ++i)
                            {
                                OracleCommand cmd = connection.CreateCommand();
                                OracleTransaction transaction;
                                transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);
                                cmd.Transaction = transaction;

                                int RowIndex = selection1.GetSelectedRowIndex(i);
                                int RowHandle = gridView1.GetRowHandle(RowIndex);
                                try
                                {


                                    string strJTDHID = gridView1.GetRowCellValue(RowHandle, colJTDID).ToString();
                                    string strJTDH = gridView1.GetRowCellValue(RowHandle, colJTDH).ToString();
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.CommandText = "JC_G_JTD_QR";
                                    cmd.Parameters.Add("LS_JTDID", OracleType.VarChar).Value = strJTDHID;
                                    cmd.Parameters.Add("DescErr", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
                                    cmd.Parameters.Add("Message", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
                                    cmd.ExecuteNonQuery();
                                    transaction.Commit();
                                    alarm = cmd.Parameters["DescErr"].Value.ToString();
                                    if (alarm == "1")
                                    {
                                        MessageBox.Show("单号为" + strJTDH + cmd.Parameters["Message"].Value.ToString());
                                        break;
                                    }

                                }
                                catch (Exception ex)
                                {
                                    transaction.Rollback();
                                    MessageBox.Show(ex.Message);
                                }
                                finally
                                { }


                            }
                            unitOfWork1.DropIdentityMap();
                            xpServerCollectionSource1.Reload();
                            if (alarm == "0")
                            { MessageBox.Show("全部确认成功"); }
                            connection.Close();
                        }
                    }

                }

            }
        }

        private void btnExportTable_Click(object sender, EventArgs e)
        {
            if (this.Tag.ToString() == "JC_G_JTD")
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
            else if (this.Tag.ToString() == "JC_G_JTDMX")
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

        private void btnBillInput_Click(object sender, EventArgs e)
        {
            if (selection1.SelectedCount != 1)
            {
                MessageBox.Show("必须选择一条进退单进行明细导入");
            }
            else
            {
                bool fgCheck = false;


                int RowIndex = selection1.GetSelectedRowIndex(0);
                int RowHandle = gridView1.GetRowHandle(RowIndex);

                string strZTID = gridView1.GetRowCellDisplayText(RowHandle, colZTID).ToString().Trim();
                string strZT = gridView1.GetRowCellDisplayText(RowHandle, colZT).ToString().Trim();
                string strJTDH = gridView1.GetRowCellDisplayText(RowHandle, colJTDH).ToString().Trim();
                string strJTDID = gridView1.GetRowCellDisplayText(RowHandle, colJTDID).ToString().Trim();
                string strczyid = gridView1.GetRowCellDisplayText(RowHandle, colCZYID).ToString().Trim();

                if (Convert.ToInt32(strZT) > 02)
                {
                    fgCheck = false;
                    MessageBox.Show("这个单子已经确认过了无法导入");
                }
                else if (strZTID != FrmLogin.getZTID.ToString())
                {
                    fgCheck = false;
                    MessageBox.Show("只有自己帐套下建立的单子才可以导入");

                }
                else if (string.IsNullOrEmpty(strJTDH))
                {
                    fgCheck = false;
                    MessageBox.Show("该进退单为空号");

                }
                else if (strczyid != FrmLogin.getUserID.ToString())
                {
                    fgCheck = false;
                    MessageBox.Show("只能导入自己建立的进退单");
                }
                else
                {
                    fgCheck = true;
                }

                if (fgCheck == true)
                {
                    string LoadFile = null;
                    OpenFileDialog openexcle = new OpenFileDialog();
                    openexcle.Filter = "excel files (*.xls)|*.xls";
                    openexcle.ShowHelp = true;
                    if (openexcle.ShowDialog() == DialogResult.OK)
                    {
                        LoadFile = openexcle.FileName.ToString();
                        if (!string.IsNullOrEmpty(LoadFile))
                        {
                            FrmUnusualStockImporCheck from = new FrmUnusualStockImporCheck(LoadFile, strJTDID);
                            from.Tag = "JC_G_JTD_CHECK";
                            from.Text = "非正常库存导入EXCEL数据检测";
                            if (from.ShowDialog() == DialogResult.OK)
                            {

                                selection1.ClearSelection();
                                //    xpServerCollectionSource1.FixedFilterString = "[CZYID] =\'" + FrmLogin.getUserID + "\'";
                                this.unitOfWork1.DropIdentityMap();
                                xpServerCollectionSource1.Reload();
                                //    SetCZLXMC();
                                this.gridView1.BestFitColumns();
                            }
                            //  CheckInputData(LoadFile);
                        }
                        else
                        {
                            MessageBox.Show("你还没有加载文件");
                        }

                    }

                }

            }

        }

        private void btnDirtePriview_Click(object sender, EventArgs e)
        {

            if (selection1.SelectedCount != 1)
            {
                MessageBox.Show("请选择一张进退单明细产查看");
            }
            else
            {
                int RowIndex = selection1.GetSelectedRowIndex(0);
                int RowHandle = gridView1.GetRowHandle(RowIndex);
                string strJTDID = gridView1.GetRowCellDisplayText(RowHandle, colJTDID).ToString().Trim();
                MakeStrArry(strJTDID);
                XtraReportJTDMX report = new XtraReportJTDMX(GetTempDataSet(strJTDID), StrArrySetRepotr);
                report.ShowPreviewDialog();
 
            }
        }
        private void MakeStrArry(string id)
        {
            string StrCon = FrmLogin.strCon;
            OracleConnection connection = new OracleConnection(StrCon);
            string str = "select GYSMC,JTDH,JTBMMC,ZDRQ,JTPZS,JTZSL,JTZMY,JTZSY from view_jc_g_jtd where JTDID='" + id + "'";
            OracleCommand comm = new OracleCommand(str, connection);

            try
            {
                connection.Open();
                OracleDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    StrArrySetRepotr[0] = reader["GYSMC"].ToString();
                    StrArrySetRepotr[1] = reader["JTDH"].ToString();
                    StrArrySetRepotr[2] = reader["JTBMMC"].ToString();
                    StrArrySetRepotr[3] = reader["ZDRQ"].ToString();
                    StrArrySetRepotr[4] = reader["JTPZS"].ToString();
                    StrArrySetRepotr[5] = reader["JTZSL"].ToString();
                    StrArrySetRepotr[6] = reader["JTZMY"].ToString();
                    StrArrySetRepotr[7] = reader["JTZSY"].ToString();
                    StrArrySetRepotr[8] = "0";

                }
            }
            catch (Exception ex)
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
            string StrCon = FrmLogin.strCon;
            OracleConnection connection = new OracleConnection(StrCon);
            try
            {
                connection.Open();
                string str = "select SPBH,SPMC,GYSMC,DJ,JTSL,JZ ,JTSY  from view_jc_g_jtdmx where JTDID='" + id + "'";
                OracleDataAdapter adp = new OracleDataAdapter(str, connection);
                adp.Fill(ds);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

            return ds;
        }
    }
}
