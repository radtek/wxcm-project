using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using System.Data.OracleClient;

namespace ClientMain
{
    public partial class SHHZDTotalReport : DevExpress.XtraReports.UI.XtraReport
    {
        public SHHZDTotalReport(string strSHHZDID, string strSHHZDH, bool fgBranch)
        {
            string sql = "";
            string sqlMinor = "";
            InitializeComponent();
            if (fgBranch)
            {
                sql = "select sum(a.fxflsl1) as sumfxflsl1, sum(a.fxflje1) as sumfxflje1, "
                    + "sum(a.fxflsl2) as sumfxflsl2, sum(a.fxflje2) as sumfxflje2, sum(a.fxflsl3) as sumfxflsl3, sum(a.fxflje3) as sumfxflje3, "
                    + "sum(a.fxflsl4) as sumfxflsl4, sum(a.fxflje4) as sumfxflje4, sum(a.fxflsl5) as sumfxflsl5, sum(a.fxflje5) as sumfxflje5, "
                    + "sum(a.fxflsl6) as sumfxflsl6, sum(a.fxflje6) as sumfxflje6, sum(a.fxflsl7) as sumfxflsl7, sum(a.fxflje7) as sumfxflje7, "
                    + "sum(a.fxflsl8) as sumfxflsl8, sum(a.fxflje8) as sumfxflje8, sum(a.fxflsl9) as sumfxflsl9, sum(a.fxflje9) as sumfxflje9, "
                    + "sum(a.fxflsl10) as sumfxflsl10, sum(a.fxflje10) as sumfxflje10, sum(a.hjsl) as sumhjsl, "
                    + "sum(a.hjje) as sumhjje, sum(a.jxcajsl) as sumjxcajsl, sum(a.jxcjje) as sumjxcjje, sum(a.jshj) as sumjshj "
                    + "from VIEW_JC_C_SHHZD a where a.shhzdid in (" + strSHHZDID + ")";

                sqlMinor = "select a.cgbmmc, a.czyxm, a.zdrq from VIEW_JC_C_SHHZD a where a.shhzdid in (" + strSHHZDID + ")";
            }
            else
            {
                sql = "select sum(a.fxflsl1) as sumfxflsl1, sum(a.fxflje1) as sumfxflje1, "
                    + "sum(a.fxflsl2) as sumfxflsl2, sum(a.fxflje2) as sumfxflje2, sum(a.fxflsl3) as sumfxflsl3, sum(a.fxflje3) as sumfxflje3, "
                    + "sum(a.fxflsl4) as sumfxflsl4, sum(a.fxflje4) as sumfxflje4, sum(a.fxflsl5) as sumfxflsl5, sum(a.fxflje5) as sumfxflje5, "
                    + "sum(a.fxflsl6) as sumfxflsl6, sum(a.fxflje6) as sumfxflje6, sum(a.fxflsl7) as sumfxflsl7, sum(a.fxflje7) as sumfxflje7, "
                    + "sum(a.fxflsl8) as sumfxflsl8, sum(a.fxflje8) as sumfxflje8, sum(a.fxflsl9) as sumfxflsl9, sum(a.fxflje9) as sumfxflje9, "
                    + "sum(a.fxflsl10) as sumfxflsl10, sum(a.fxflje10) as sumfxflje10, sum(a.hjsl) as sumhjsl, "
                    + "sum(a.hjje) as sumhjje, sum(a.jxcajsl) as sumjxcajsl, sum(a.jxcjje) as sumjxcjje, sum(a.jshj) as sumjshj "
                    + "from VIEW_JT_C_SHHZD a where a.shhzdid in (" + strSHHZDID + ")";

                sqlMinor = "select a.cgbmmc, a.czyxm, a.zdrq from VIEW_JT_C_SHHZD a where a.shhzdid in (" + strSHHZDID + ")";
            }

            OracleConnection con = new OracleConnection(FrmLogin.strCon);
            OracleDataAdapter Ada = new OracleDataAdapter(sql, con);
            DataSet ds = new DataSet();
            Ada.Fill(ds);

            this.DataAdapter = Ada;
            this.DataSource = ds;

            OracleDataAdapter adaMinor = new OracleDataAdapter(sqlMinor, con);
            DataSet dsMinor = new DataSet();
            adaMinor.Fill(dsMinor);
            string strCGBMMC = dsMinor.Tables[0].Rows[0]["CGBMMC"].ToString();
            string strCZYXM = dsMinor.Tables[0].Rows[0]["CZYXM"].ToString();
            string strCZRQ = dsMinor.Tables[0].Rows[0]["ZDRQ"].ToString();

            xrTableCell1.Text = FrmLogin.getZTMC;

            xrTableCell3.Text = "部门：" + strCGBMMC;
            xrTableCell5.Text = "时间：" + strCZRQ;
            xrTableCell63.Text = "制单人：" + strCZYXM;

            xrLabel1.Text = strSHHZDH;            

            xrTableCell11.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "sumfxflsl1")});

            xrTableCell12.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "sumfxflje1", "{0:c2}")});

            xrTableCell15.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "sumfxflsl2")});

            xrTableCell16.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "sumfxflje2", "{0:c2}")});

            xrTableCell19.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "sumfxflsl3")});

            xrTableCell20.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "sumfxflje3", "{0:c2}")});

            xrTableCell23.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "sumfxflsl4")});

            xrTableCell24.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "sumfxflje4", "{0:c2}")});

            xrTableCell27.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "sumfxflsl5")});

            xrTableCell28.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "sumfxflje5", "{0:c2}")});

            xrTableCell31.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "sumfxflsl6")});

            xrTableCell32.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "sumfxflje6", "{0:c2}")});

            xrTableCell35.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "sumfxflsl7")});

            xrTableCell36.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "sumfxflje7", "{0:c2}")});

            xrTableCell39.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "sumfxflsl8")});

            xrTableCell40.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "sumfxflje8", "{0:c2}")});

            xrTableCell43.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "sumfxflsl9")});

            xrTableCell44.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "sumfxflje9", "{0:c2}")});

            xrTableCell47.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "sumfxflsl10")});

            xrTableCell48.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "sumfxflje10", "{0:c2}")});

            xrTableCell51.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "sumhjsl")});

            xrTableCell52.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "sumhjje", "{0:c2}")});

            xrTableCell55.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "sumjxcajsl")});

            xrTableCell56.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "sumjxcjje", "{0:c2}")});

            xrTableCell60.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "sumjshj", "{0:c2}")});
        }

    }
}
