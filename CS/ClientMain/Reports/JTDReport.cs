using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using System.Data.OracleClient;

namespace ClientMain
{
    public partial class JTDReport : DevExpress.XtraReports.UI.XtraReport
    {
        public JTDReport(string strJTDID)
        {
            InitializeComponent();
            OracleConnection con = new OracleConnection(FrmLogin.strCon);
            string sql = "select a.jtdid, a.ztmc, a.jtdh, a.zdrq, a.ywyxm, a.statusmc, a.czyxm, a.czrq, a.gysmc, a.bz, a.jtpzs, a.jtzsl, a.jtzmy, "
                       + "a.jtbmmc, b.pm, b.spbh, b.dj, b.bz, b.jtsl, b.jtmy from view_jt_g_jtd a "
                       + "left join view_jt_g_jtdmx b on a.jtdid = b.jtdid where a.jtdid in (" + strJTDID + ")";
            OracleDataAdapter Ada = new OracleDataAdapter(sql, con);
            DataSet ds = new DataSet();
            Ada.Fill(ds);

            this.DataAdapter = Ada;
            this.DataSource = ds;

            GroupField groupField = new GroupField("JTDID");
            GroupHeader1.GroupFields.Add(groupField);

            this.xrLabel4.Text = FrmLogin.getUserName;

            this.xrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "ztmc",  "{0} ���˵�")});

            this.xrTableCell7.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "dj", "{0:c2}")});

            this.xrTableCell12.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "jtmy", "{0:c2}")});

            this.xrTableCell10.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "spbh")});

            this.xrTableCell11.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "pm")});

            this.xrTableCell8.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "jtsl")});

            this.xrTableCell9.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "bz")});

            this.xrTableCell13.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "jtdh", "���ţ�{0}")});

            this.xrTableCell14.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "zdrq", "�������ڣ�{0}")});

            this.xrTableCell16.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "ywyxm", "ҵ��Ա��{0}")});

            this.xrTableCell15.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "statusmc", "״̬��{0}")});

            this.xrTableCell21.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "czyxm", "����Ա��{0}")});

            this.xrTableCell22.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "czrq", "�������ڣ�{0}")});

            this.xrTableCell23.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "gysmc", "��Ӧ�̣�{0}")});

            this.xrTableCell24.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "bz", "��ע��{0}")});

            this.xrTableCell17.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "jtpzs", "����Ʒ�֣�{0}")});

            this.xrTableCell18.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "jtzsl", "����������{0}")});

            this.xrTableCell19.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "jtzmy", "��������{0:c2}")});

            this.xrTableCell20.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "jtbmmc", "���˲��ţ�{0}")});
        }

    }
}
