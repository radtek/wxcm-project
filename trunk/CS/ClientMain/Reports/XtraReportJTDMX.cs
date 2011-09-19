using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports;
using DevExpress.XtraReports.UserDesigner;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.Parameters;
using System.Data.OracleClient;
using System.Data;

namespace ClientMain
{
    public partial class XtraReportJTDMX : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReportJTDMX()
        {
            InitializeComponent();
        }
        public XtraReportJTDMX(DataSet ds, string[] strArray)
        {
            InitializeComponent();
            this.txtHYDW.Text = strArray[0];
            this.txtTHDH.Text = strArray[1];
            this.txtTHDW.Text = strArray[2];
            this.txtTHSJ.Text = strArray[3];
            this.txtZPZ.Text = strArray[4];
            this.txtZCS.Text = strArray[5];
            this.txtZMY.Text = strArray[6];
            this.txtZSY.Text = strArray[7];
            this.txtBJS.Text = strArray[8];
            this.DataSource = ds.Tables[0];
            SetDataBind(ds);
          
        }
        private void SetDataBind(DataSet ds)
        {


        //    this.xrTable1.DataBindings=ds.Tables[0];
            this.xrTableCell9.DataBindings.Add("Text", this.DataSource, "SPBH");


            this.xrTableCell12.DataBindings.Add("Text", this.DataSource, "SPMC");


            this.xrTableCell10.DataBindings.Add("Text", this.DataSource, "GYSMC");


            this.xrTableCell13.DataBindings.Add("Text", this.DataSource, "DJ");


            this.xrTableCell11.DataBindings.Add("Text", this.DataSource, "JTSL");
            this.xrTableCell14.DataBindings.Add("Text", this.DataSource, "JZ");
            this.xrTableCell15.DataBindings.Add("Text", this.DataSource, "JTSY");
            this.tacelBH.DataBindings.Add("Text", this.DataSource, "JTSL");



        }
    }
}
