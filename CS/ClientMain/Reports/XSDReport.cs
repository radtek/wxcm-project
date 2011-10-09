using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using System.Data.OracleClient;

namespace ClientMain
{
    public partial class XSDReport : DevExpress.XtraReports.UI.XtraReport
    {
        public XSDReport(string strXSDID)
        {
            InitializeComponent();
            OracleConnection con = new OracleConnection(FrmLogin.strDataCent);
            string sql = "select a.xsdid, a.ztmc, a.xsdh, a.zdrq, a.jsfsmc, a.wlbmmc, a.xsbmmc, a.khmc, a.fhdz, a.czyxm, a.czrq, a.bz, a.pzs, "
                       + "a.xssl as xszsl, a.xssy as xszsy, a.xsmy as xszmy, b.pm, b.spbh, b.dj, b.xj, b.xz, b.xssl, b.xsmy, b.xssy from view_jt_x_xsd a "
                       + "left join view_jt_x_xsdmx b on a.xsdid = b.xsdid where a.xsdid in (" + strXSDID + ")";
            OracleDataAdapter Ada = new OracleDataAdapter(sql, con);
            DataSet ds = new DataSet();
            Ada.Fill(ds);

            this.DataAdapter = Ada;
            this.DataSource = ds;

            GroupField groupField = new GroupField("XSDID");
            GroupHeader1.GroupFields.Add(groupField);

            this.xrLabel4.Text = FrmLogin.getUserName;

            this.xrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "ztmc",  "{0} ���۵�")});

            this.xrTableCell1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "xsdh", "���ţ�{0}")});

            this.xrTableCell2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "zdrq", "�������ڣ�{0}")});

            this.xrTableCell3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "jsfsmc", "���㷽ʽ��{0}")});

            this.xrTableCell4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "wlbmmc", "�������ţ�{0}")});

            this.xrTableCell5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "xsbmmc", "���۲��ţ�{0}")});

            this.xrTableCell6.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "khmc", "�ͻ����ƣ�{0}")});

            this.xrTableCell7.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "fhdz", "������ַ��{0}")});

            this.xrTableCell8.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "czyxm", "����Ա��{0}")});

            this.xrTableCell9.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "czrq", "�������ڣ�{0}")});

            this.xrTableCell10.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "bz", "��ע��{0}")});

            this.xrTableCell11.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "pzs", "����Ʒ�֣�{0}")});

            this.xrTableCell12.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "xszsl", "����������{0}")});

            this.xrTableCell13.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "xszsy", "����ʵ��{0:c2}")});

            this.xrTableCell14.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "xszmy", "��������{0:c2}")});

            this.xrTableCell23.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "spbh")});

            this.xrTableCell24.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "pm")});

            this.xrTableCell25.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "dj", "{0:c2}")});

            this.xrTableCell26.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "xj", "{0:c2}")});

            this.xrTableCell27.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "xz")});

            this.xrTableCell28.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "xssl")});

            this.xrTableCell29.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "xsmy", "{0:c2}")});

            this.xrTableCell30.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "xssy", "{0:c2}")});
        }

    }
}
