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
    public partial class FrmSaleStageSelectcase : Form
    {
        GridCheckMarksSelection selection;
        private string khid;//购货单位
        private string csl;//税率
        private string xsjsdid;//采购结算单ID
        private string cztid;//传递的帐套ID
        private string StrCon = FrmLogin.strCon;
        //选计
        private double dXSMY = 0;
        private double dXSSY = 0;
        private Int64 iXSSL = 0;
        private double dYSMY = 0;
        private double dYSSY = 0;
        private Int64 iYSSL = 0;
        private Int64 iPZS = 0;
        public FrmSaleStageSelectcase(string id, string sl, string ghdwid, string ztid)
        {
            InitializeComponent();
            XpoDefault.ConnectionString = OracleConnectionProvider.GetConnectionString("XINHUA", "xxb", "pass");
            xpServerCollectionSource1.FixedFilterString = "[ZTID] = \'" + ztid + "\' AND [KHID] = \'" + ghdwid + "\' AND [SL]=\'" + sl + "\'";
            selection = new GridCheckMarksSelection(gridView1);
            selection.CheckMarkColumn.VisibleIndex = 0;
            gridView1.BestFitColumns();


            xsjsdid = id;
            khid = ghdwid;
            csl = sl;
            cztid = ztid;

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
            vDrawFootCell(e, colSJLX, "选计：");
            vDrawFootCell(e, colXSMY, dXSMY.ToString("F2"));
            vDrawFootCell(e, colXSSY, dXSSY.ToString("F2"));
            vDrawFootCell(e, colXSSL, iXSSL.ToString());
            vDrawFootCell(e, colYSMY, dYSMY.ToString("F2"));
            vDrawFootCell(e, colYSSY, dYSSY.ToString("F2"));
            vDrawFootCell(e, colYSSL, iYSSL.ToString());
            vDrawFootCell(e, colPZS, iPZS.ToString());


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
                        dXSSY = Convert.ToDouble(colXSSY.SummaryText);
                        dXSMY = Convert.ToDouble(colXSMY.SummaryText);
                        iXSSL = Convert.ToInt64(colXSSL.SummaryText);
                        dYSSY = Convert.ToDouble(colYSSY.SummaryText);
                        dYSMY = Convert.ToDouble(colYSMY.SummaryText);
                        iYSSL = Convert.ToInt64(colYSSL.SummaryText);
                        iPZS = Convert.ToInt64(colPZS.SummaryText);

                    }
                    else
                    {
                        dXSSY = 0;
                        dXSMY = 0;
                        iXSSL = 0;
                        dYSSY = 0;
                        dYSMY = 0;
                        iYSSL = 0;
                        iPZS = 0;
                    }

                }
                if (hitInfo.InRowCell)
                {
                    if (selection.IsRowSelected(hitInfo.RowHandle))
                    {
                        dXSMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colXSMY));
                        dXSSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colXSSY));
                        iXSSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colXSSL));
                        dYSMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colYSMY));
                        dYSSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colYSSY));
                        iYSSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colYSSL));
                        iPZS += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colPZS));
                    }
                    else
                    {
                        dXSMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colXSMY));
                        dXSSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colXSSY));
                        iXSSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colXSSL));
                        dYSMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colYSMY));
                        dYSSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colYSSY));
                        iYSSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colYSSL));
                        iPZS -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colPZS));

                    }
                }
            }

        }
        private void JCZDselectCase()
        {
            if (selection.SelectedCount == 0)
            {
                MessageBox.Show("您还没有选择任何单子");
            }
            else
            {

                using (OracleConnection connection = new OracleConnection(StrCon))
                {
                    connection.Open();

                    OracleCommand command = connection.CreateCommand();
                    OracleTransaction transaction;
                    transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);
                    command.Transaction = transaction;
                    try
                    {

                        for (int i = 0; i < selection.SelectedCount; ++i)
                        {
                            int RowIndex = selection.GetSelectedRowIndex(i);
                            int RowHandle = gridView1.GetRowHandle(RowIndex);

                            string strXSDID = gridView1.GetRowCellDisplayText(RowHandle, colXSDID).Trim();
                            string strSJLX = gridView1.GetRowCellDisplayText(RowHandle, colSJLX).Trim();
                            command.CommandText = "insert into Temp_Save_Id(id,wlbmid,tempid) values ('" + strXSDID + "','" + strSJLX + "',temp_id_seq.nextval)";

                            command.ExecuteNonQuery();

                        }

                        selection.ClearSelection();

                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "jc_C_XSJS_ZDXD";


                        command.Parameters.Add("LS_XSJSDid", OracleType.VarChar).Value = xsjsdid;

                        command.Parameters.Add("DescErr", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
                        command.Parameters.Add("Message", OracleType.VarChar, 255).Direction = ParameterDirection.Output;

                        command.ExecuteNonQuery();
                        transaction.Commit();

                        unitOfWork1.DropIdentityMap();

                        xpServerCollectionSource1.Reload();

                        MessageBox.Show(command.Parameters["Message"].Value.ToString());
                    }
                    catch (OracleException ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        connection.Close();

                        this.DialogResult = DialogResult.OK;
                        this.Close();

                    }
                }

            }
        }
        private void JCSXselectCase()
        {
            if (selection.SelectedCount == 0)
            {
                MessageBox.Show("您还没有选择任何单子");
            }
            else
            {

                using (OracleConnection connection = new OracleConnection(StrCon))
                {
                    connection.Open();

                    OracleCommand command = connection.CreateCommand();
                    OracleTransaction transaction;
                    transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);
                    command.Transaction = transaction;
                    try
                    {

                        for (int i = 0; i < selection.SelectedCount; ++i)
                        {
                            int RowIndex = selection.GetSelectedRowIndex(i);
                            int RowHandle = gridView1.GetRowHandle(RowIndex);

                            string strXSDID = gridView1.GetRowCellDisplayText(RowHandle, colXSDID).Trim();
                            string strSJLX = gridView1.GetRowCellDisplayText(RowHandle, colSJLX).Trim();
                            command.CommandText = "insert into Temp_Save_Id(id,wlbmid,tempid) values ('" + strXSDID + "','" + strSJLX + "',temp_id_seq.nextval)";

                            command.ExecuteNonQuery();

                        }

                        selection.ClearSelection();

                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "JC_c_XSJS_SXXD";


                        command.Parameters.Add("LS_XSJSDID", OracleType.VarChar).Value = xsjsdid;

                        command.Parameters.Add("DescErr", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
                        command.Parameters.Add("Message", OracleType.VarChar, 255).Direction = ParameterDirection.Output;

                        command.ExecuteNonQuery();
                        transaction.Commit();

                        unitOfWork1.DropIdentityMap();

                        xpServerCollectionSource1.Reload();

                        MessageBox.Show(command.Parameters["Message"].Value.ToString());
                    }
                    catch (OracleException ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        connection.Close();

                        this.DialogResult = DialogResult.OK;
                        this.Close();

                    }
                }

            }
        }
        private void ZDselectCase()
        {
            if (selection.SelectedCount == 0)
            {
                MessageBox.Show("您还没有选择任何单子");
            }
            else
            {

                using (OracleConnection connection = new OracleConnection(StrCon))
                {
                    connection.Open();

                    OracleCommand command = connection.CreateCommand();
                    OracleTransaction transaction;
                    transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);
                    command.Transaction = transaction;
                    try
                    {

                        for (int i = 0; i < selection.SelectedCount; ++i)
                        {
                            int RowIndex = selection.GetSelectedRowIndex(i);
                            int RowHandle = gridView1.GetRowHandle(RowIndex);

                            string strXSDID = gridView1.GetRowCellDisplayText(RowHandle, colXSDID).Trim();
                            string strSJLX = gridView1.GetRowCellDisplayText(RowHandle, colSJLX).Trim();
                            command.CommandText = "insert into Temp_Save_Id(id,wlbmid,tempid) values ('" + strXSDID + "','" + strSJLX + "',temp_id_seq.nextval)";

                            command.ExecuteNonQuery();

                        }

                        selection.ClearSelection();

                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "Jt_c_XSJS_ZDXD";


                        command.Parameters.Add("LS_XSJSDid", OracleType.VarChar).Value = xsjsdid;

                        command.Parameters.Add("DescErr", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
                        command.Parameters.Add("Message", OracleType.VarChar, 255).Direction = ParameterDirection.Output;

                        command.ExecuteNonQuery();
                        transaction.Commit();

                        unitOfWork1.DropIdentityMap();

                        xpServerCollectionSource1.Reload();

                        MessageBox.Show(command.Parameters["Message"].Value.ToString());
                    }
                    catch (OracleException ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        connection.Close();

                        this.DialogResult = DialogResult.OK;
                        this.Close();

                    }
                }

            }
        }
        private void SXselectCase()
        {
            if (selection.SelectedCount == 0)
            {
                MessageBox.Show("您还没有选择任何单子");
            }
            else
            {
                using (OracleConnection connection = new OracleConnection(StrCon))
                {
                    connection.Open();

                    OracleCommand command = connection.CreateCommand();
                    OracleTransaction transaction;
                    transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);
                    command.Transaction = transaction;
                    try
                    {

                        if (selection.SelectedCount != 0)
                        {
                            for (int i = 0; i < selection.SelectedCount; ++i)
                            {
                                int RowIndex = selection.GetSelectedRowIndex(i);
                                int RowHandle = gridView1.GetRowHandle(RowIndex);
                                string strXSDID = gridView1.GetRowCellDisplayText(RowHandle, colXSDID).Trim();
                                string strSJLX = gridView1.GetRowCellDisplayText(RowHandle, colSJLX).Trim();
                                command.CommandText = "insert into Temp_Save_Id(id,wlbmid,tempid) values ('" + strXSDID + "','" + strSJLX + "',temp_id_seq.nextval)";

                                command.ExecuteNonQuery();

                            }

                        }


                        selection.ClearSelection();

                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "JT_c_XSJS_SXXD";


                        command.Parameters.Add("LS_XSJSDID", OracleType.VarChar).Value = xsjsdid;

                        command.Parameters.Add("DescErr", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
                        command.Parameters.Add("Message", OracleType.VarChar, 255).Direction = ParameterDirection.Output;

                        command.ExecuteNonQuery();
                        transaction.Commit();

                        unitOfWork1.DropIdentityMap();

                        xpServerCollectionSource1.Reload();

                        MessageBox.Show(command.Parameters["Message"].Value.ToString());



                    }
                    catch (OracleException ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        connection.Close();

                        this.DialogResult = DialogResult.OK;
                        this.Close();

                    }
                }

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            selection.ClearSelection();
        }

        private void btniuquire_Click(object sender, EventArgs e)
        {
            selection.ClearSelection();
            gridView1.ShowFilterEditor(gridView1.FocusedColumn);

            if (!String.IsNullOrEmpty(gridView1.ActiveFilterString))
            {
                xpServerCollectionSource1.FixedFilterString = gridView1.ActiveFilterString + " And [ZTID] = \'" + cztid + "\' AND [KHID] = \'" + khid + "\' AND [SL]=\'" + csl + "\'";
                gridView1.BestFitColumns();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (this.Tag.ToString() == "JT_XSJSD_ZDJS_XD")
            {
                ZDselectCase();

            }
            else if (this.Tag.ToString() == "JT_XSJSD_SXSJ_XD")
            {
                SXselectCase();
            }
            else if (this.Tag.ToString() == "JC_XSJSD_ZDJS_XD")
            {
                JCZDselectCase();
            }
            else if (this.Tag.ToString() == "JC_XSJSD_SXSJ_XD")
            {
                JCSXselectCase();
            }
        }

    }
}
