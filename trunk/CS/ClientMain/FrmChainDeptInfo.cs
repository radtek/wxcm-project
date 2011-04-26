using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Sybase.Data.AseClient;
using System.Data.OracleClient;
using DevExpress.XtraGrid.Views.Grid;

namespace ClientMain
{
    public partial class FrmChainDeptInfo : DevExpress.XtraEditors.XtraForm
    {
        IDbConnection DbCon = null;
        DbDataAdapter DbAda = null;
        string strConnect = null;
        DataSet ds;

        public FrmChainDeptInfo()
        {
            InitializeComponent();
        }

        public FrmChainDeptInfo(string strDBType, string strServer, string strDbName, string strUser, string strPass)
        {
            InitializeComponent();
            SelectDBConnect(strDBType, strServer, strDbName, strUser, strPass);
        }

        private void SelectDBConnect(string strDBType, string strServer, string strDbName, string strUser, string strPass)
        {
            int index = strServer.LastIndexOf(":");
            string strSvrAddress = strServer.Substring(0, index).Trim();
            string strPort = strServer.Substring(index + 1).Trim();

            string strSQL = "select F_BMBH,F_BMMC from C_MSBM";
            

            switch (strDBType)
            {
                case "1":
                    strConnect = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=" + strSvrAddress + ")(PORT="
                               + strPort + ")))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=" + strDbName + ")));User Id=" + strUser 
                               + ";Password=" + strPass + ";Integrated Security=no;";
                    DbCon = new OracleConnection(strConnect);
                    DbAda = new OracleDataAdapter(strSQL, strConnect);                    
                    break;
                case "2":
                    strConnect = "Data Source='" + strSvrAddress + "';Port='" + strPort 
                               + "';Database='" + strDbName + "';Uid='" + strUser + "';Pwd='" + strPass + "';";
                    DbCon = new AseConnection(strConnect);
                    DbAda = new AseDataAdapter(strSQL, strConnect);                    
                    break;
                default:
                    break;

            }
        }

        private void FrmChainDeptInfo_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = bindingSource1;

            ds = new DataSet();
            DbAda.Fill(ds, "C_MSBM");

            bindingSource1.DataSource = ds;
            bindingSource1.DataMember = "C_MSBM";

           

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //string temp = gridView1.GetFocusedRowCellDisplayText("F_BMMC");
            this.Close();
        }

        private void btnExport2PDF_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            GridView View = gridControl1.MainView as GridView;
            if (View != null)
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "PDF文件|*.pdf";
                saveDialog.Title = "导出PDF文件";
                saveDialog.DefaultExt = "pdf";
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    View.ExportToPdf(saveDialog.FileName);
                    MessageBox.Show("导出PDF成功！");
                }
            }
           
        }

        private void btnExport2XLS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GridView View = gridControl1.MainView as GridView;
            if (View != null)
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "XLS文件|*.xls";
                saveDialog.Title = "导出Excel文件";
                saveDialog.DefaultExt = "xls";
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    View.ExportToXls(saveDialog.FileName);
                    MessageBox.Show("导出XLS成功！");
                }
            }
           
        }

        private void btnPrintPreview_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControl1.ShowPrintPreview();
        }

        private void btnPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControl1.Print();
        }

        
    }
}