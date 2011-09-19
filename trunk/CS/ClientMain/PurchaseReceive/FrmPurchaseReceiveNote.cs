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
using System.Data.OracleClient;


namespace ClientMain
{
    public partial class FrmPurchaseReceiveNote : DevExpress.XtraEditors.XtraForm
    {
        

        GridCheckMarksSelection selection;

        Int64 i8YDZPZ = 0;
        Int64 i8YDZSL = 0;
        double dYDZSY = 0;
        double dYDZMY = 0;
        Int64 i8SSZPZ = 0;
        Int64 i8SSZSL = 0;
        double dSSZSY = 0;
        double dSSZMY = 0;
        Int64 i8ZPZSL = 0;
        double dZPZSY = 0;
        double dZPZMY = 0;
        Int64 i8ZZSL = 0;
        double dZZSY = 0;
        double dZZMY = 0;
        Int64 i8YFSL = 0;
        double dYFMY = 0;
        double dYFSY = 0;

        bool m_fgBranch = false;
        public FrmPurchaseReceiveNote(bool fgBranch, string strCGSHID = null)
        {
            XpoDefault.ConnectionString = OracleConnectionProvider.GetConnectionString("XINHUA", "xxb", "pass");
            
            InitializeComponent();
            if (String.IsNullOrEmpty(strCGSHID))
            {
                xpServerCollectionSource1.FixedFilterString = "[CGSHID] Is Null";
            }
            else
            {
                xpServerCollectionSource1.FixedFilterString = strCGSHID;
            }
           
            selection = new GridCheckMarksSelection(gridView1);
            selection.CheckMarkColumn.VisibleIndex = 0;

            gridView1.BestFitColumns();

            m_fgBranch = fgBranch;
        }


        private void FrmPurchaseReceiveNote_Load(object sender, EventArgs e)
        {
                        
        }

        private void vClearSelectSummary()
        {
            dSSZMY = 0;
            dSSZSY = 0;
            dYDZMY = 0;
            dYDZSY = 0;
            dYFMY = 0;
            dYFSY = 0;
            dZPZMY = 0;
            dZPZSY = 0;
            dZZMY = 0;
            dZZSY = 0;
            i8SSZPZ = 0;
            i8SSZSL = 0;
            i8YDZPZ = 0;
            i8YDZSL = 0;
            i8YFSL = 0;
            i8ZPZSL = 0;
            i8ZZSL = 0; 
        }

        private void btnMasterQuery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            gridView1.ShowFilterEditor(gridView1.FocusedColumn);

            if (!String.IsNullOrEmpty(gridView1.ActiveFilterString))
            {
                selection.ClearSelection();
                vClearSelectSummary();

                xpServerCollectionSource1.FixedFilterString = gridView1.ActiveFilterString + " And [ZTID] = \'" + FrmLogin.getZTID + "\'";                
                gridView1.BestFitColumns();
            }
            
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

        private void btnExport2XLS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
                if (selection.SelectedCount == 0)
                {
                    MessageBox.Show("请先选择需要导出的记录");
                }
                else if (selection.SelectedCount <= FrmLogin.MAXROWCOUNT)
                {
                    gridView1.ClearSelection();
                    for (int i = 0; i < selection.SelectedCount; ++i)
                    {
                        int RowIndex = selection.GetSelectedRowIndex(i);
                        int RowHandle = gridView1.GetRowHandle(RowIndex);
                        gridView1.SelectRow(RowHandle);
                    }

                    SaveFileDialog saveDialog = new SaveFileDialog();
                    saveDialog.Filter = "XLS文件|*.xls";
                    saveDialog.Title = "导出Excel文件";
                    saveDialog.DefaultExt = "xls";
                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        gridView1.Columns["CheckMarkSelection"].Visible = false;

                        gridView1.ExportToXls(saveDialog.FileName);

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

        private void btnSaveLayout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strLayout = FrmLogin.getUser + "_PurchaseReceiveNoteLayout.xml";
            FileStream stream = new FileStream(strLayout, FileMode.Create);
            gridView1.SaveLayoutToStream(stream);
            stream.Close();
        }

        private void btnLoadLayout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strLayout = FrmLogin.getUser + "_PurchaseReceiveNoteLayout.xml";
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
            if (selection.SelectedCount == 0)
            {
                const string message = "没有勾选主单进行的详单查询时间会比较久（3分钟左右），继续么？";
                const string caption = "详单查询?";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    FrmPurchaseReceiveDetail FrmPRD = new FrmPurchaseReceiveDetail(m_fgBranch);
                    FrmPRD.Show();
                    FrmPRD.Activate();
                }                        
                
            }
            else
            {
                string strCGSHID = null;
                for (int i = 0; i < selection.SelectedCount; ++i)
                {
                    int RowIndex = selection.GetSelectedRowIndex(i);
                    int RowHandle = gridView1.GetRowHandle(RowIndex);

                    string strTemp = gridView1.GetRowCellDisplayText(RowHandle, colCGSHID);                   
                    strCGSHID += "[CGSHID] = \'" + strTemp + "\' Or ";
                }

                int index = strCGSHID.LastIndexOf("'");
                strCGSHID = strCGSHID.Substring(0, index + 1).Trim();

                FrmPurchaseReceiveDetail FrmPRD = new FrmPurchaseReceiveDetail(m_fgBranch, strCGSHID);                
                FrmPRD.Show();
                FrmPRD.Activate();
            }
            
        }

        private void btnConfirm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strCGSHID = "";
            if (selection.SelectedCount == 0)
            {
                MessageBox.Show("请先选择需要确认的记录");
            }
            else
            {
                for (int i = 0; i < selection.SelectedCount; ++i)
                {
                    int RowIndex = selection.GetSelectedRowIndex(i);
                    int RowHandle = gridView1.GetRowHandle(RowIndex);

                    string strZT = gridView1.GetRowCellValue(RowHandle, colZT).ToString();

                    if (strZT == "02")
                    {
                        string strTemp = gridView1.GetRowCellDisplayText(RowHandle, colCGSHID);
                        strCGSHID += "\'" + strTemp + "\', ";
                    }
                    else
                    {
                        strCGSHID = "";
                        MessageBox.Show("所选记录已被确认，请重新选择！");
                        break;
                    }

                }

                selection.ClearSelection();
                vClearSelectSummary();

                if (!String.IsNullOrEmpty(strCGSHID))
                {
                    using (OracleConnection connection = new OracleConnection(FrmLogin.strCon))
                    {
                        connection.Open();
                        OracleCommand command = connection.CreateCommand();
                        OracleTransaction transaction = connection.BeginTransaction();
                        command.Connection = connection;
                        command.Transaction = transaction;

                        int index = strCGSHID.LastIndexOf("'");
                        strCGSHID = strCGSHID.Substring(0, index + 1).Trim();

                        try
                        {
                            string strSQL = "update jt_g_cgsh set zt = '15', czrq = sysdate where CGSHID in (" + strCGSHID + ")";
                            command.CommandText = strSQL;

                            command.ExecuteNonQuery();
                            transaction.Commit();

                            unitOfWork1.DropIdentityMap();
                            xpServerCollectionSource1.Reload();
                            MessageBox.Show("所选记录已确认成功");
                        }
                        catch (Exception exception)
                        {
                            transaction.Rollback();
                            MessageBox.Show(exception.ToString());
                        }
                        finally
                        {
                            connection.Close();
                        }
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
                if ((hitInfo.Column != null) && (hitInfo.Column == colCGSHDH))
                {
                    string strTemp = view.GetRowCellDisplayText(hitInfo.RowHandle, colCGSHID);
                    string strCGSHID = "[CGSHID] = \'" + strTemp + "\'";
                    if (fc["FrmPurchaseReceiveDetail"] != null)
                    {
                        fc["FrmPurchaseReceiveDetail"].Close();
                    }            
                    FrmPurchaseReceiveDetail FrmPRD = new FrmPurchaseReceiveDetail(m_fgBranch, strCGSHID);
                    FrmPRD.Show();
                    FrmPRD.Activate();
                }
                else if ((hitInfo.Column != null) && (hitInfo.Column == colSHHZDH))
                {
                    string strTemp = view.GetRowCellDisplayText(hitInfo.RowHandle, colSHHZDID);
                    string strSHHZDH = view.GetRowCellDisplayText(hitInfo.RowHandle, colSHHZDH);
                    if (!String.IsNullOrEmpty(strSHHZDH))
                    {
                        string strSHHZDID = "[SHHZDID] = \'" + strTemp + "\'";
                        if (FrmLogin.getZTID == "2314" || FrmLogin.getZTID == "2312" || FrmLogin.getZTID == "306")
                        {
                            if (fc["FrmPurchaseReceiveTotal"] != null)
                            {
                                fc["FrmPurchaseReceiveTotal"].Close();
                            }
                            FrmPurchaseReceiveTotal FrmPRT = new FrmPurchaseReceiveTotal(m_fgBranch, strSHHZDID);
                            FrmPRT.Show();
                            FrmPRT.Activate();
                        }
                        else
                        {
                            if (fc["FrmPurchaseReceiveTotalBranch"] != null)
                            {
                                fc["FrmPurchaseReceiveTotalBranch"].Close();
                            }
                            FrmPurchaseReceiveTotalBranch FrmPRTB = new FrmPurchaseReceiveTotalBranch(m_fgBranch, strSHHZDID);
                            FrmPRTB.Show();
                            FrmPRTB.Activate();
                        }
                    }                    
                }
                else if ((hitInfo.Column != null) && (hitInfo.Column == colSHPZDH))
                {
                    string strTemp = view.GetRowCellDisplayText(hitInfo.RowHandle, colSHPZID);
                    string strSHPZDH = view.GetRowCellDisplayText(hitInfo.RowHandle, colSHPZDH);
                    if (!String.IsNullOrEmpty(strSHPZDH))
                    {
                        string strSHPZID = "[VOUCHERID] = \'" + strTemp + "\'";
                        if (fc["FrmPurchaseReveiveVoucherNote"] != null)
                        {
                            fc["FrmPurchaseReveiveVoucherNote"].Close();
                        }
                        FrmPurchaseReveiveVoucherNote FrmPRVN = new FrmPurchaseReveiveVoucherNote(strSHPZID);
                        FrmPRVN.Show();
                        FrmPRVN.Activate();
                    }
                }
               
                
            }

            
        }


        private void btnSummarize_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (selection.SelectedCount == 0)
            {
                MessageBox.Show("请先选择需要汇总的记录");
            }
            else
            {
                using (OracleConnection connection = new OracleConnection(FrmLogin.strCon))
                {
                    connection.Open();

                    OracleCommand command = connection.CreateCommand();
                    OracleTransaction transaction;

                    // Start a local transaction
                    transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);
                    // Assign transaction object for a pending local transaction
                    command.Transaction = transaction;

                    try
                    {
                        const string message = "确定汇总吗?";
                        const string caption = "汇总?";
                        var result = MessageBox.Show(message, caption,
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            bool fgSummarizeStop = false;
                            for (int i = 0; i < selection.SelectedCount; ++i)
                            {
                                int RowIndex = selection.GetSelectedRowIndex(i);
                                int RowHandle = gridView1.GetRowHandle(RowIndex);

                                int i4Status = Convert.ToInt32(gridView1.GetRowCellDisplayText(RowHandle, colZT));
                                if (i4Status < 15)
                                {
                                    fgSummarizeStop = true;
                                    MessageBox.Show("所选记录未被审核，请重新选择！");
                                    break;
                                }

                                string strCGSHID = gridView1.GetRowCellDisplayText(RowHandle, colCGSHID);
                                command.CommandText = "INSERT INTO TEMP_SAVE_ID (TEMPID, ID) Values (temp_id_seq.nextval, '" + strCGSHID + "')";
                                command.ExecuteNonQuery();
                            }

                            selection.ClearSelection();
                            vClearSelectSummary();

                            if (!fgSummarizeStop)
                            {
                                command.CommandType = CommandType.StoredProcedure;
                                if (m_fgBranch)
                                {
                                    command.CommandText = "JT_G_CGSH_TO_SHHZD_JC";
                                }
                                else
                                {
                                    command.CommandText = "JT_G_CGSH_TO_SHHZD";
                                }
                                command.Parameters.Add("Userid", OracleType.VarChar).Value = FrmLogin.getUserID;

                                command.Parameters.Add("Departmentid", OracleType.VarChar).Value = FrmLogin.getDeptID;
                                command.Parameters.Add("Ls_Ztid", OracleType.VarChar).Value = FrmLogin.getZTID;

                                command.Parameters.Add("Descerr", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
                                command.Parameters.Add("Message", OracleType.VarChar, 255).Direction = ParameterDirection.Output;

                                command.ExecuteNonQuery();
                                transaction.Commit();

                                unitOfWork1.DropIdentityMap();

                                xpServerCollectionSource1.Reload();
                                
                                MessageBox.Show(command.Parameters["Message"].Value.ToString());
                            }
                        }
            
                    }
                    catch (Exception exception)
                    {
                        transaction.Rollback();
                        MessageBox.Show(exception.ToString());                        
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
                
            }
        }

        private void btnVoucher_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (selection.SelectedCount == 0)
            {
                MessageBox.Show("请先选择需要产生收货凭证的记录");
            }
            else
            {
                using (OracleConnection connection = new OracleConnection(FrmLogin.strCon))
                {
                    connection.Open();

                    OracleCommand command = connection.CreateCommand();
                    OracleTransaction transaction;

                    // Start a local transaction
                    transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);
                    // Assign transaction object for a pending local transaction
                    command.Transaction = transaction;

                    try
                    {
                        const string message = "确定产生凭证吗?";
                        const string caption = "产生凭证?";
                        var result = MessageBox.Show(message, caption,
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            bool fgVoucherStop = false;
                            for (int i = 0; i < selection.SelectedCount; ++i)
                            {
                                int RowIndex = selection.GetSelectedRowIndex(i);
                                int RowHandle = gridView1.GetRowHandle(RowIndex);

                                string strSHHZDH = gridView1.GetRowCellDisplayText(RowHandle, colSHHZDH);
                                if (String.IsNullOrEmpty(strSHHZDH))
                                {
                                    fgVoucherStop = true;
                                    MessageBox.Show("所选记录未被汇总，请重新选择！");
                                    break;
                                }

                                string strCGSHID = gridView1.GetRowCellDisplayText(RowHandle, colCGSHID);
                                command.CommandText = "INSERT INTO TEMP_SAVE_ID (TEMPID, ID) Values (temp_id_seq.nextval, '" + strCGSHID + "')";
                                command.ExecuteNonQuery();
                            }

                            selection.ClearSelection();
                            vClearSelectSummary();

                            if (!fgVoucherStop)
                            {
                                command.CommandType = CommandType.StoredProcedure;
                                command.CommandText = "JT_G_CGSH_TO_CGSHPZ";

                                
                                command.Parameters.Add("Userid", OracleType.VarChar).Value = FrmLogin.getUserID;

                                command.Parameters.Add("Departmentid", OracleType.VarChar).Value = FrmLogin.getDeptID;
                                command.Parameters.Add("Ls_Ztid", OracleType.VarChar).Value = FrmLogin.getZTID;

                                command.Parameters.Add("Descerr", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
                                command.Parameters.Add("Message", OracleType.VarChar, 255).Direction = ParameterDirection.Output;

                                command.ExecuteNonQuery();
                                transaction.Commit();

                                unitOfWork1.DropIdentityMap();

                                xpServerCollectionSource1.Reload();
                                
                                MessageBox.Show(command.Parameters["Message"].Value.ToString());
                            }
                        }

                    }
                    catch (Exception exception)
                    {
                        transaction.Rollback();
                        MessageBox.Show(exception.ToString());
                    }
                    finally
                    {
                        connection.Close();
                    }
                }

            }
        }

        private void btnCorrection_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (selection.SelectedCount == 0)
            {
                MessageBox.Show("请先选择需要更正的记录");
            }
            else if (selection.SelectedCount > 1)
            {
                MessageBox.Show("每次只能更正一条记录，请重新选择！");
            }
            else
            {
                using (OracleConnection connection = new OracleConnection(FrmLogin.strCon))
                {
                    connection.Open();

                    OracleCommand command = connection.CreateCommand();
                    OracleTransaction transaction;

                    // Start a local transaction
                    transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);
                    // Assign transaction object for a pending local transaction
                    command.Transaction = transaction;

                    try
                    {
                        int RowIndex = selection.GetSelectedRowIndex(0);
                        int RowHandle = gridView1.GetRowHandle(RowIndex);

                        string strCGSHID = gridView1.GetRowCellDisplayText(RowHandle, colCGSHID);
                        string strGYSMC = gridView1.GetRowCellDisplayText(RowHandle, colGYSMC);


                        FrmSupplierCorrection FrmSC = new FrmSupplierCorrection(connection, transaction, strGYSMC);
                        if (FrmSC.ShowDialog() == DialogResult.OK)
                        {
                            bool fgCorrectStop = false;                        
                            

                            selection.ClearSelection();
                            vClearSelectSummary();

                            if (!fgCorrectStop)
                            {
                                command.CommandType = CommandType.StoredProcedure;
                                command.CommandText = "JT_G_CGSH_GYS_GZ";


                                command.Parameters.Add("ls_cgshid", OracleType.VarChar).Value = strCGSHID;

                                command.Parameters.Add("ls_gysid", OracleType.VarChar).Value = FrmSC.getSupplierID();
                                command.Parameters.Add("Userid", OracleType.VarChar).Value = FrmLogin.getUserID;

                                command.Parameters.Add("Descerr", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
                                command.Parameters.Add("Message", OracleType.VarChar, 255).Direction = ParameterDirection.Output;

                                command.ExecuteNonQuery();
                                transaction.Commit();

                                unitOfWork1.DropIdentityMap();

                                xpServerCollectionSource1.Reload();

                                MessageBox.Show(command.Parameters["Message"].Value.ToString());
                            }
                        }

                    }
                    catch (Exception exception)
                    {
                        transaction.Rollback();
                        MessageBox.Show(exception.ToString());
                    }
                    finally
                    {
                        connection.Close();
                    }
                }

            }
        }

        private void btnShowErrNote_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (selection.SelectedCount == 0)
            {
                MessageBox.Show("请先选择需要显示差错的记录");
            }
            else
            {
                string strCGSHID = null;
                for (int i = 0; i < selection.SelectedCount; ++i)
                {
                    int RowIndex = selection.GetSelectedRowIndex(i);
                    int RowHandle = gridView1.GetRowHandle(RowIndex);

                    string strTemp = gridView1.GetRowCellDisplayText(RowHandle, colCGSHID);
                    strCGSHID += "[CCDID] = \'" + strTemp + "\' Or ";
                }

                int index = strCGSHID.LastIndexOf("'");
                strCGSHID = strCGSHID.Substring(0, index + 1).Trim();

                FrmPurchaseReceiveErrNote FrmPREN = new FrmPurchaseReceiveErrNote(strCGSHID);
                FrmPREN.Show();
                FrmPREN.Activate();
            }
        }

      

        private void gridView1_CustomDrawFooterCell(object sender, FooterCellCustomDrawEventArgs e)
        {            
            FrmLogin.vDrawFootCell(e, colSTATUSMC, "选计：");
            FrmLogin.vDrawFootCell(e, colSSZMY, dSSZMY.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colSSZSY, dSSZSY.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colYDZMY, dYDZMY.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colYDZSY, dYDZSY.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colYFSY, dYFSY.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colYFMY, dYFMY.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colZPZSY, dZPZSY.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colZPZMY, dZPZMY.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colZZSY, dZZSY.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colZZMY, dZZMY.ToString("F2"));
            FrmLogin.vDrawFootCell(e, colSSZPZ, i8SSZPZ.ToString());
            FrmLogin.vDrawFootCell(e, colSSZSL, i8SSZSL.ToString());
            FrmLogin.vDrawFootCell(e, colYDZPZ, i8YDZPZ.ToString());
            FrmLogin.vDrawFootCell(e, colYDZSL, i8YDZSL.ToString());
            FrmLogin.vDrawFootCell(e, colYFSL, i8YFSL.ToString());
            FrmLogin.vDrawFootCell(e, colZPZSL, i8ZPZSL.ToString());
            FrmLogin.vDrawFootCell(e, colZZSL, i8ZZSL.ToString());

            
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
                        double.TryParse(colSSZMY.SummaryText, out dSSZMY);
                        double.TryParse(colSSZSY.SummaryText, out dSSZSY);
                        double.TryParse(colYDZMY.SummaryText, out dYDZMY);
                        double.TryParse(colYDZSY.SummaryText, out dYDZSY);
                        double.TryParse(colYFMY.SummaryText, out dYFMY);
                        double.TryParse(colYFSY.SummaryText, out dYFSY);
                        double.TryParse(colZPZMY.SummaryText, out dZPZMY);
                        double.TryParse(colZPZSY.SummaryText, out dZPZSY);
                        double.TryParse(colZZMY.SummaryText, out dZZMY);
                        double.TryParse(colZZSY.SummaryText, out dZZSY);
                        Int64.TryParse(colSSZSL.SummaryText, out i8SSZSL);
                        Int64.TryParse(colSSZPZ.SummaryText, out i8SSZPZ);
                        Int64.TryParse(colZZSL.SummaryText, out i8ZZSL);
                        Int64.TryParse(colZPZSL.SummaryText, out i8ZPZSL);
                        Int64.TryParse(colYDZSL.SummaryText, out i8YDZSL);
                        Int64.TryParse(colYDZPZ.SummaryText, out i8YDZPZ);
                        Int64.TryParse(colYFSL.SummaryText, out i8YFSL);
                    }
                    else
                    {
                        dSSZMY = 0;
                        dSSZSY = 0;
                        dYDZMY = 0;
                        dYDZSY = 0;
                        dYFMY = 0;
                        dYFSY = 0;
                        dZPZMY = 0;
                        dZPZSY = 0;
                        dZZMY = 0;
                        dZZSY = 0;
                        i8SSZPZ = 0;
                        i8SSZSL = 0;
                        i8YDZPZ = 0;
                        i8YDZSL = 0;
                        i8YFSL = 0;
                        i8ZPZSL = 0;
                        i8ZZSL = 0; 
                    }

                }
                if (hitInfo.InRowCell)
                {
                    if (selection.IsRowSelected(hitInfo.RowHandle))
                    {
                        dYDZMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colYDZMY));
                        dSSZMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colSSZMY));
                        dSSZSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colSSZSY));
                        dYDZSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colYDZSY));
                        dYFMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colYFMY));
                        dYFSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colYFSY));
                        dZPZMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZPZMY));
                        dZPZSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZPZSY));
                        dZZMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZZMY));
                        dZZSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZZSY));
                        i8SSZPZ += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colSSZPZ));
                        i8SSZSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colSSZSL));
                        i8YDZPZ += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colYDZPZ));
                        i8YDZSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colYDZSL));
                        i8YFSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colYFSL));
                        i8ZPZSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colZPZSL));
                        i8ZZSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colZZSL));
                    }
                    else
                    {
                        dYDZMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colYDZMY));
                        dSSZMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colSSZMY));
                        dSSZSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colSSZSY));
                        dYDZSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colYDZSY));
                        dYFMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colYFMY));
                        dYFSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colYFSY));
                        dZPZMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZPZMY));
                        dZPZSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZPZSY));
                        dZZMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZZMY));
                        dZZSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZZSY));
                        i8SSZPZ -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colSSZPZ));
                        i8SSZSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colSSZSL));
                        i8YDZPZ -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colYDZPZ));
                        i8YDZSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colYDZSL));
                        i8YFSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colYFSL));
                        i8ZPZSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colZPZSL));
                        i8ZZSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colZZSL));
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

        private void btnPrintDetailNote_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strCGSHID = "";
            if (selection.SelectedCount == 0)
            {
                MessageBox.Show("请先选择需要打印的记录");
            }
            else
            {
                for (int i = 0; i < selection.SelectedCount; ++i)
                {
                    int RowIndex = selection.GetSelectedRowIndex(i);
                    int RowHandle = gridView1.GetRowHandle(RowIndex);

                    string strTemp = gridView1.GetRowCellDisplayText(RowHandle, colCGSHID);
                    strCGSHID += "\'" + strTemp + "\', ";
                }

                int index = strCGSHID.LastIndexOf("'");
                strCGSHID = strCGSHID.Substring(0, index + 1).Trim();

                CGSHReport report = new CGSHReport(strCGSHID);
                report.ShowPreviewDialog();
            }
            
        }

        private void btnExportGrid_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.DataRowCount > FrmLogin.MAXROWCOUNT)
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

        private void btnExportDetailNote_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (selection.SelectedCount == 0)
            {
                MessageBox.Show("请先选择需要导出明细的记录");
            }
            else
            {
                string strCGSHID = null;
                for (int i = 0; i < selection.SelectedCount; ++i)
                {
                    int RowIndex = selection.GetSelectedRowIndex(i);
                    int RowHandle = gridView1.GetRowHandle(RowIndex);

                    string strTemp = gridView1.GetRowCellDisplayText(RowHandle, colCGSHID);
                    strCGSHID += "[CGSHID] = \'" + strTemp + "\' Or ";
                }

                int index = strCGSHID.LastIndexOf("'");
                strCGSHID = strCGSHID.Substring(0, index + 1).Trim();

                FrmPurchaseReceiveDetail FrmPRD = new FrmPurchaseReceiveDetail(m_fgBranch, strCGSHID);
                FrmPRD.btnExportGrid_ItemClick(sender, e);
            }
        }
                                  
                      
    }
    
}