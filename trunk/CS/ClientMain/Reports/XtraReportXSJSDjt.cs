using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data.OracleClient;
using System.Configuration;
using System.Data;

namespace ClientMain
{
    public partial class XtraReportXSJSDjt : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReportXSJSDjt()
        {
            InitializeComponent();
        }
        public XtraReportXSJSDjt(string id)
        {
             InitializeComponent();
            ReportTitle_Load(id);
            this.DataSource = Setds(id).Tables[0];
            SetDataBind(Setds(id));

        }

        private void ReportTitle_Load(string jsdid)
        {
             string StrCon = ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString;
            OracleConnection connection = new OracleConnection(StrCon);
            string str = "select ztidmc,GHDWMC,XSJSDH,jsfsmc,jsr,czrmc,ZHJSRQ from VIEW_JT_C_XSJSD where XSJSDID='"+jsdid+"'";
            OracleCommand comm = new OracleCommand(str,connection);
  
            try
            {
                connection.Open();
                OracleDataReader reader = comm.ExecuteReader();
                while(reader.Read())
                {
                   this.txtGHDW.Text=reader["GHDWMC"].ToString();
                    this.txtZTIDMC.Text=reader["ztidmc"].ToString();
                    this.txtJSFS.Text=reader["jsfsmc"].ToString();
                    this.txtJSDH.Text=reader["XSJSDH"].ToString();
                    this.txtJSR.Text=reader["jsr"].ToString();
                    this.txtZDR.Text=reader["czrmc"].ToString();
                    this.txtJSRQ.Text=reader["ZHJSRQ"].ToString();

            
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

        }
        private DataSet Setds(string jsdid)
        {
            DataSet ds = new DataSet();
             string StrCon = ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString;
            OracleConnection connection = new OracleConnection(StrCon);
            try
            {
                connection.Open();
                string str = "select a.XSDH,a.xssl,a.xssy,a.xsmy,(select b.CGJSDH from jc_c_cgjsd b where b.GYSID=a.KHID)KH,(select b.pzs from jc_c_cgjsd b where b.GYSID=a.KHID)PZS from view_jt_c_xsjsdmx a where a.XSJSDID='" + jsdid + "'";
                OracleDataAdapter adp = new OracleDataAdapter(str, connection);
                adp.Fill(ds);
                
            }
            catch(Exception ex)
            {
                throw ex;
            }
                finally
            {
                connection.Close();
            }

               return ds;
        }
        private void SetDataBind(DataSet ds)
        {
            this.xrTableCell12.DataBindings.Add("Text", this.DataSource, "XSDH");

            this.xrTableCell7.DataBindings.Add("Text", this.DataSource, "KH");

            this.xrTableCell10.DataBindings.Add("Text", this.DataSource, "PZS");

            this.xrTableCell8.DataBindings.Add("Text", this.DataSource, "xssl");

            this.xrTableCell9.DataBindings.Add("Text", this.DataSource, "xssy");
            this.xrTableCell11.DataBindings.Add("Text", this.DataSource, "xsmy");
 
        }
        
    }
}
