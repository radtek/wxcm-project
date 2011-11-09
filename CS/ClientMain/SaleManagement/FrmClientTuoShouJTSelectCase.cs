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
    public partial class FrmClientTuoShouJTSelectCase : Form
    {
        GridCheckMarksSelection selection;
        // private string StrCon = FrmLogin.strCon;
        private string StrCon = FrmLogin.strDataCent;

        public FrmClientTuoShouJTSelectCase(string id, string khid)
        {
            InitializeComponent();
            //  XpoDefault.ConnectionString = OracleConnectionProvider.GetConnectionString("XINHUA", "xxb", "pass");
            XpoDefault.ConnectionString = FrmLogin.xpoDataCentStr;
            xpServerCollectionSource1.FixedFilterString = "[ZTID] = \'" + FrmLogin.getZTID.ToString() + "\' AND [ZT] > \'" + "14" + "\' AND [JSFSID]=\'" + "1" + "\'AND [GHDWID]=\'" + khid + "\'";
            selection = new GridCheckMarksSelection(gridView1);
            selection.CheckMarkColumn.VisibleIndex = 0;
            gridView1.BestFitColumns();

            this.btnConfirm.Tag = id.ToString();//将销售结算单的ID值赋予确定按钮的TAG
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            selection.ClearSelection();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (selection.SelectedCount == 0)
            {
                MessageBox.Show("没有选择单据");
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
                              string strXSJSDID = gridView1.GetRowCellValue(RowHandle, colXSJSDID).ToString();
                              command.CommandText = "insert into Temp_Save_Id (tempid,id) Values (TEMP_SAVE_ID_SEQ.nextval,'" + strXSJSDID +  "')";
                              command.ExecuteNonQuery();
                          }

                          selection.ClearSelection();
                          command.CommandType = CommandType.StoredProcedure;
                          command.CommandText = "JT_C_XSTSD_XD";
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

        private void FrmClientTuoShouSelectCaseXS_Load(object sender, EventArgs e)
        {

        }

        private void btniuquire_Click(object sender, EventArgs e)
        {
            selection.ClearSelection();
            gridView1.ShowFilterEditor(colZTMC);

            if (!String.IsNullOrEmpty(gridView1.ActiveFilterString))
            {
                xpServerCollectionSource1.FixedFilterString = gridView1.ActiveFilterString + " And [ZTID] = \'" + FrmLogin.getZTID.ToString() + "\' AND [ZT] > \'" + "14" + "\' AND [JSFSID]=\'" + "1" + "\'AND [GHDWID]=\'" + this.btnConfirm.Tag.ToString() + "\'";
                gridView1.BestFitColumns();
            }
        }

        private void btnColCustomize_Click(object sender, EventArgs e)
        {
            gridView1.ShowCustomization();
        }

        private void btnSaveLayout_Click(object sender, EventArgs e)
        {
            string strLayout = FrmLogin.getUser + "_FrmClientTuoShouJTSelectCaseLayout.xml";
            FileStream stream = new FileStream(strLayout, FileMode.Create);
            gridView1.SaveLayoutToStream(stream);
            stream.Close();
        }

        private void btnLoadLayout_Click(object sender, EventArgs e)
        {
            string strLayout = FrmLogin.getUser + "_FrmClientTuoShouJTSelectCaseLayout.xml";
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
    }
}
