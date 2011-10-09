using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using System.Data.OracleClient;

namespace ClientMain
{
    public partial class SHHZDReport : DevExpress.XtraReports.UI.XtraReport
    {
        public SHHZDReport(string strSHHZDID, bool fgBranch)
        {
            string sql = "";
            InitializeComponent();
            if (fgBranch)
            {
                sql = "select a.shhzdid, a.shhzdh, a.cgbmmc, a.fxflsl1, a.fxflje1, a.fxflsl2, a.fxflje2, a.fxflsl3, a.fxflje3, "
                    + "a.fxflsl4, a.fxflje4, a.fxflsl5, a.fxflje5, a.fxflsl6, a.fxflje6, a.fxflsl7, a.fxflje7, a.fxflsl8, a.fxflje8, "
                    + "a.fxflsl9, a.fxflje9, a.fxflsl10, a.fxflje10, a.hjsl, a.hjje, a.jxcajsl, a.jxcjje, a.jshj,"
                    + " a.czyxm, a.zdrq from VIEW_JC_C_SHHZD a where a.shhzdid in (" + strSHHZDID + ")";
            }
            else
            {
                sql = "select a.shhzdid, a.shhzdh, a.cgbmmc, a.fxflsl1, a.fxflje1, a.fxflsl2, a.fxflje2, a.fxflsl3, a.fxflje3, "
                    + "a.fxflsl4, a.fxflje4, a.fxflsl5, a.fxflje5, a.fxflsl6, a.fxflje6, a.fxflsl7, a.fxflje7, a.fxflsl8, a.fxflje8, "
                    + "a.fxflsl9, a.fxflje9, a.fxflsl10, a.fxflje10, a.hjsl, a.hjje, a.jxcajsl, a.jxcjje, a.jshj,"
                    + " a.czyxm, a.zdrq from VIEW_JT_C_SHHZD a where a.shhzdid in (" + strSHHZDID + ")";
            }

            OracleConnection con = new OracleConnection(FrmLogin.strDataCent);
            OracleDataAdapter Ada = new OracleDataAdapter(sql, con);
            DataSet ds = new DataSet();
            Ada.Fill(ds);

            this.DataAdapter = Ada;
            this.DataSource = ds;

            GroupField groupField = new GroupField("SHHZDID");
            GroupHeader1.GroupFields.Add(groupField);

            xrTableCell1.Text = FrmLogin.getZTMC;

            xrTableCell3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "cgbmmc", "部门：{0}")});

            xrTableCell5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "zdrq", "时间：{0}")});

            xrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "shhzdh")});

            xrTableCell63.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "czyxm", "制单人：{0}")});

            xrTableCell11.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "fxflsl1")});

            xrTableCell12.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "fxflje1", "{0:c2}")});

            xrTableCell15.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "fxflsl2")});

            xrTableCell16.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "fxflje2", "{0:c2}")});

            xrTableCell19.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "fxflsl3")});

            xrTableCell20.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "fxflje3", "{0:c2}")});

            xrTableCell23.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "fxflsl4")});

            xrTableCell24.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "fxflje4", "{0:c2}")});

            xrTableCell27.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "fxflsl5")});

            xrTableCell28.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "fxflje5", "{0:c2}")});

            xrTableCell31.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "fxflsl6")});

            xrTableCell32.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "fxflje6", "{0:c2}")});

            xrTableCell35.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "fxflsl7")});

            xrTableCell36.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "fxflje7", "{0:c2}")});

            xrTableCell39.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "fxflsl8")});

            xrTableCell40.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "fxflje8", "{0:c2}")});

            xrTableCell43.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "fxflsl9")});

            xrTableCell44.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "fxflje9", "{0:c2}")});

            xrTableCell47.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "fxflsl10")});

            xrTableCell48.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "fxflje10", "{0:c2}")});

            xrTableCell51.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "hjsl")});

            xrTableCell52.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "hjje", "{0:c2}")});

            xrTableCell55.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "jxcajsl")});

            xrTableCell56.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "jxcjje", "{0:c2}")});

            xrTableCell60.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "jshj", "{0:c2}")});
        }

    }
}
