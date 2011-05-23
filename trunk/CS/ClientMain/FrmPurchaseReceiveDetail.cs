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
using DevExpress.XtraGrid.Views.Grid;
using System.IO;



namespace ClientMain
{
    public partial class FrmPurchaseReceiveDetail : DevExpress.XtraEditors.XtraForm
    {
        const int MAXROWCOUNT = 50000;

        GridCheckMarksSelection selection;

        public FrmPurchaseReceiveDetail()
        {
            XpoDefault.ConnectionString = OracleConnectionProvider.GetConnectionString("XINHUA", "xxb", "pass");

            InitializeComponent();

            this.xpServerCollectionSource1.FixedFilterString = "[ZTID] = \'" + FrmLogin.getZTID + "\'";

            selection = new GridCheckMarksSelection(gridView1);
            selection.CheckMarkColumn.VisibleIndex = 0;
        }

        private void FrmPurchaseReceiveDetail_Load(object sender, EventArgs e)
        {
            gridView1.BestFitColumns();
        }

        private void gridView1_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator & e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString().Trim();
            }
        }

        private void btnColCustomize_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.ShowCustomization();
        }

        private void btnSaveLayout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strLayout = FrmLogin.getUser + "_PRNDetailLayout.xml";
            FileStream stream = new FileStream(strLayout, FileMode.Create);
            gridView1.SaveLayoutToStream(stream);
            stream.Close();
        }

        private void btnLoadLayout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strLayout = FrmLogin.getUser + "_PRNDetailLayout.xml";
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

        private void btnDetailQuery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.ShowFilterEditor(gridView1.FocusedColumn);
        }


    }
}