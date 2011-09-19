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
    public partial class XtraReportCGJSD : DevExpress.XtraReports.UI.XtraReport
    {

        public XtraReportCGJSD()
        {
            InitializeComponent();
            
        }
        public XtraReportCGJSD(DataSet ds,string[] strArray)
          {
            InitializeComponent();
            this.xrLabelZTMC.Text=strArray[0];
            this.txtGYS.Text=strArray[1];
            this.txtJSDH.Text=strArray[2];
            this.txtJSFS.Text=strArray[3];
            this.txtJSR.Text = strArray[4];
            this.txtZDR.Text=strArray[5];
            this.txtJSRQ.Text = strArray[6];
            this.DataSource = ds.Tables[0];
            SetDataBind(ds);

        }
        private void SetDataBind(DataSet ds)
        {



           this.xrTableCell6.DataBindings.Add("Text", this.DataSource, "shdh");

     //           //   this.xrTableCell2.Text = "Ʒ����";
           this.xrTableCell7.DataBindings.Add("Text", this.DataSource, "pzs");

                //     this.xrTableCell3.Text = "�ջ�����";
            this.xrTableCell10.DataBindings.Add("Text", this.DataSource, "shsl");

                //    this.xrTableCell4.Text = "�ջ�����";
            this.xrTableCell8.DataBindings.Add("Text", this.DataSource, "shsy");

                //     this.xrTableCell5.Text = "�ջ�ʵ��";
            this.xrTableCell9.DataBindings.Add("Text", this.DataSource, "shmy");



           // this.xrTable1.DataBindings
          //  this.xrTableCell1.Text = "�ջ�����";
         




 
        }
        
    }
}
