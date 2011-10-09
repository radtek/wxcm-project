using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using System.Data.OracleClient;

namespace ClientMain
{
    public partial class XTDReport : DevExpress.XtraReports.UI.XtraReport
    {
        public XTDReport(string strXTDID)
        {
            InitializeComponent();
            OracleConnection con = new OracleConnection(FrmLogin.strDataCent);
            string sql = "select a.xtdid, a.ztmc, a.xtdh, a.zdrq, a.jsfsmc, a.shdwid, a.wlmc, a.khmc, a.xsbmmc, a.czyxm, a.czrq, a.bz, a.pzs, "
                       + "a.xtsl as xtzsl, a.xtsy as xtzsy, a.xtmy as xtzmy, b.pm, b.spbh, b.dj, b.xj, b.xz, b.xtsl, b.xtmy, b.xtsy from view_jt_x_xtd a "
                       + "left join view_jt_x_xtdmx b on a.xtdid = b.xtdid where a.xtdid in (" + strXTDID + ")";
            OracleDataAdapter Ada = new OracleDataAdapter(sql, con);
            DataSet ds = new DataSet();
            Ada.Fill(ds);

            this.DataAdapter = Ada;
            this.DataSource = ds;

            GroupField groupField = new GroupField("XTDID");
            GroupHeader1.GroupFields.Add(groupField);

            this.xrLabel4.Text = FrmLogin.getUserName;

            this.xrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "ztmc",  "{0} ���˵�")});

            this.xrTableCell1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "xtdh", "���ţ�{0}")});

            this.xrTableCell2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "zdrq", "�������ڣ�{0}")});

            this.xrTableCell3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "jsfsmc", "���㷽ʽ��{0}")});

            this.xrTableCell4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "shdwid", "���䲿�ţ�{0}")});

            this.xrTableCell5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "wlmc", "�ջ����ţ�{0}")});

            this.xrTableCell6.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "khmc", "�ͻ����ƣ�{0}")});

            this.xrTableCell7.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "xsbmmc", "ҵ���ţ�{0}")});

            this.xrTableCell8.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "czyxm", "����Ա��{0}")});

            this.xrTableCell9.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "czrq", "�������ڣ�{0}")});

            this.xrTableCell10.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "bz", "��ע��{0}")});

            this.xrTableCell11.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "pzs", "����Ʒ�֣�{0}")});

            this.xrTableCell12.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "xtzsl", "����������{0}")});

            this.xrTableCell13.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "xtzsy", "����ʵ��{0:c2}")});

            this.xrTableCell14.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "xtzmy", "��������{0:c2}")});

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
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "xtsl")});

            this.xrTableCell29.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "xtmy", "{0:c2}")});

            this.xrTableCell30.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "xtsy", "{0:c2}")});
        }

    }
}
