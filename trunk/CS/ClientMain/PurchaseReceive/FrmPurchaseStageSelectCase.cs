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
    public partial class FrmPurchaseStageSelectCase : Form
    {
        GridCheckMarksSelection selection;
        private string cghdwid;//购货单位
        private string csl;//税率
        private string chjsdid;//采购结算单ID
        private string cztid;//传递的帐套ID
        private string StrCon = FrmLogin.strCon;
        //选计
        private double dSSMY = 0;
        private double dSSSY = 0;
        private Int64 iSSSL= 0;
        private  double dYFMY = 0;
         private double dYFSY = 0;
         private Int64 iYFSL= 0;
         private Int64 iSSPZ= 0;


        public FrmPurchaseStageSelectCase(string id,string sl, string ghdwid,string ztid)
        {
            InitializeComponent();
            xpServerCollectionSource1.FixedFilterString = "[ZTID] = \'" + ztid + "\' AND [GYSID] = \'" + ghdwid + "\' AND [SL]=\'" + sl + "\'";
            selection = new GridCheckMarksSelection(gridView1);
            selection.CheckMarkColumn.VisibleIndex = 0;
            gridView1.BestFitColumns();
      

            chjsdid = id;
            cghdwid = ghdwid;
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
            vDrawFootCell(e, colSSMY, dSSMY.ToString("F2"));
            vDrawFootCell(e, colSSSY, dSSSY.ToString("F2"));
            vDrawFootCell(e, colSSSL, iSSSL.ToString());
            vDrawFootCell(e, colYFMY, dYFMY.ToString("F2"));
            vDrawFootCell(e, colYFSY, dYFSY.ToString("F2"));
            vDrawFootCell(e, colYFSL, iYFSL.ToString());
            vDrawFootCell(e, colSSPZ, iSSPZ.ToString());


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
                        dSSSY = Convert.ToDouble(colSSSY.SummaryText);
                        dSSMY = Convert.ToDouble(colSSMY.SummaryText);
                        iSSSL = Convert.ToInt64(colSSSL.SummaryText);
                        dYFSY = Convert.ToDouble(colYFSY.SummaryText);
                        dYFMY = Convert.ToDouble(colYFMY.SummaryText);
                        iYFSL = Convert.ToInt64(colYFSL.SummaryText);
                        iSSPZ = Convert.ToInt64(colSSPZ.SummaryText);

                    }
                    else
                    {
                        dSSSY = 0;
                        dSSMY = 0;
                        iSSSL = 0;
                        dYFSY = 0;
                        dYFMY = 0;
                        iYFSL = 0;
                        iSSPZ =0;
                    }

                }
                if (hitInfo.InRowCell)
                {
                    if (selection.IsRowSelected(hitInfo.RowHandle))
                    {
                        dSSMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colSSMY));
                        dSSSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colSSSY));
                        iSSSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colSSSL));
                        dYFMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colYFMY));
                        dYFSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colYFSY));
                        iYFSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colYFSL));
                        iSSPZ += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colSSPZ));
                    }
                    else
                    {
                        dSSMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colSSMY));
                        dSSSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colSSSY));
                        iSSSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colSSSL));
                        dYFMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colYFMY));
                        dYFSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colYFSY));
                        iYFSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colYFSL));
                        iSSPZ -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colSSPZ));

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

                            string strSHDID = gridView1.GetRowCellDisplayText(RowHandle, colCGSHID).Trim();
                            string strSJLX = gridView1.GetRowCellDisplayText(RowHandle, colSJLX).Trim();
                            command.CommandText = "insert into Temp_Save_Id(id,wlbmid,tempid) values ('" + strSHDID + "','" + strSJLX + "',temp_id_seq.nextval)";

                            command.ExecuteNonQuery();

                        }

                        selection.ClearSelection();

                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "jc_C_CGJS_ZDXD";


                        command.Parameters.Add("LS_CGJSDid", OracleType.VarChar).Value = chjsdid;

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

                            string strSHDID = gridView1.GetRowCellDisplayText(RowHandle, colCGSHID).Trim();
                            string strSJLX = gridView1.GetRowCellDisplayText(RowHandle, colSJLX).Trim();
                            command.CommandText = "insert into Temp_Save_Id(id,wlbmid,tempid) values ('" + strSHDID + "','" + strSJLX + "',temp_id_seq.nextval)";

                            command.ExecuteNonQuery();

                        }

                        selection.ClearSelection();

                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "JC_c_CGJS_SXXD";


                        command.Parameters.Add("LS_CGJSDid", OracleType.VarChar).Value = chjsdid;

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
            if (selection.SelectedCount == 0 )
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

                                string strSHDID = gridView1.GetRowCellDisplayText(RowHandle, colCGSHID).Trim();
                                 string strSJLX = gridView1.GetRowCellDisplayText(RowHandle, colSJLX).Trim();
                                 command.CommandText = "insert into Temp_Save_Id(id,wlbmid,tempid) values ('" + strSHDID + "','" + strSJLX + "',temp_id_seq.nextval)";

                                command.ExecuteNonQuery();

                            }

                        selection.ClearSelection();
                    
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "Jt_c_CGJS_ZDXD";


                        command.Parameters.Add("LS_CGJSDid", OracleType.VarChar).Value = chjsdid;

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
            if (selection.SelectedCount == 0 )
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
                                string strSHDID = gridView1.GetRowCellDisplayText(RowHandle, colCGSHID).Trim();
                                string strSJLX = gridView1.GetRowCellDisplayText(RowHandle, colSJLX).Trim();

                                command.CommandText = "insert into Temp_Save_Id(id,wlbmid,tempid) values ('" + strSHDID + "','" + strSJLX + "',temp_id_seq.nextval)";

                                command.ExecuteNonQuery();

                            }

                        }
                       

                        selection.ClearSelection();

                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "Jt_c_CGJS_SXXD";


                        command.Parameters.Add("LS_CGJSDid", OracleType.VarChar).Value = chjsdid;

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
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (this.Tag.ToString() == "JT_CGJSD_ZDJS_XD")
            {
                ZDselectCase();

            }
            else if (this.Tag.ToString() == "JT_CGJSD_SXSJ_XD")
            {
                SXselectCase();
            }
            else if (this.Tag.ToString() == "JC_CGJSD_ZDJS_XD")
            {
                JCZDselectCase();
            }
            else if (this.Tag.ToString() == "JC_CGJSD_SXSJ_XD")
            {
                JCSXselectCase();
            }




        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            selection.ClearSelection();
          
        }

        private void btnJHinquire_Click(object sender, EventArgs e)
        {
            selection.ClearSelection();
            gridView1.ShowFilterEditor(gridView1.FocusedColumn);

            if (!String.IsNullOrEmpty(gridView1.ActiveFilterString))
            {
                xpServerCollectionSource1.FixedFilterString = gridView1.ActiveFilterString + " And [ZTID] = \'" + cztid + "\' AND [GYSID] = \'" + cghdwid + "\' AND [SL]=\'" + csl + "\'";
                gridView1.BestFitColumns();
            }
        }

        private void FrmPurchaseStageSelectCase_Load(object sender, EventArgs e)
        {

        }

      

       
    }
}
