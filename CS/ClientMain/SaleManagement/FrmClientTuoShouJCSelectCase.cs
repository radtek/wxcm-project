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
    public partial class FrmClientTuoShouJCSelectCase : Form
    {
        GridCheckMarksSelection selection;
        public FrmClientTuoShouJCSelectCase(string id, string khid)
        {
            InitializeComponent();
            XpoDefault.ConnectionString = OracleConnectionProvider.GetConnectionString("XINHUA", "xxb", "pass");
            xpServerCollectionSource1.FixedFilterString = "[ZTID] = \'" + FrmLogin.getZTID.ToString() + "\' AND [ZT] > \'" + "15" + "\' AND [JSFSID]=\'" + "01" + "\'AND [GHDWID]=\'" + khid + "\'";
            selection = new GridCheckMarksSelection(gridView1);
            selection.CheckMarkColumn.VisibleIndex = 0;
            gridView1.BestFitColumns();

            this.btnConfirm.Tag = id.ToString();//将销售结算单的ID值赋予确定按钮的TAG
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (selection.SelectedCount == 0)
            {
                MessageBox.Show("没有选择单据");
            }
            else
            {
                string StrCon = FrmLogin.strCon;
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
                            string strXSJSDID = gridView1.GetRowCellValue(RowHandle, colXSJSDID).ToString();
                            command.CommandText = "insert into Temp_Save_Id (tempid,id) Values (TEMP_SAVE_ID_SEQ.nextval,'" + strXSJSDID + "')";
                            command.ExecuteNonQuery();
                        }

                        selection.ClearSelection();
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "JC_C_XSTSD_XD";
                        command.Parameters.Add("LS_XSTSDid", OracleType.VarChar).Value = this.btnConfirm.Tag.ToString();
                        command.Parameters.Add("DescErr", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
                        command.Parameters.Add("Message", OracleType.VarChar, 255).Direction = ParameterDirection.Output;

                        command.ExecuteNonQuery();
                        transaction.Commit();
                        string mess = command.Parameters["Message"].Value.ToString();
                        string alarm = command.Parameters["DescErr"].Value.ToString();
                        MessageBox.Show(mess + alarm);

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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btniuquire_Click(object sender, EventArgs e)
        {
            selection.ClearSelection();
            gridView1.ShowFilterEditor(gridView1.FocusedColumn);

            if (!String.IsNullOrEmpty(gridView1.ActiveFilterString))
            {
                xpServerCollectionSource1.FixedFilterString = gridView1.ActiveFilterString + " And [ZTID] = \'" + FrmLogin.getZTID.ToString() + "\' AND [ZT] > \'" + "15" + "\' AND [JSFSID]=\'" + "01" + "\'AND [GHDWID]=\'" + this.btnConfirm.Tag.ToString() + "\'";
                gridView1.BestFitColumns();
            }
        }
    }
}
