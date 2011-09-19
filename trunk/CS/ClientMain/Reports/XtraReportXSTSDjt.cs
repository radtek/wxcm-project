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
    public partial class XtraReportXSTSDjt : DevExpress.XtraReports.UI.XtraReport
    {
        private string cwbmid = "";
        private string fpid = "";
        public XtraReportXSTSDjt()
        {
            InitializeComponent();
        }
        public XtraReportXSTSDjt(string id)
        {
            InitializeComponent();
            ReportTitle_Load(id);
            ReportCWBM_Load();
            

        }
        private void ReportTitle_Load(string tsdid)
        {
            string StrCon = ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString;
            OracleConnection connection = new OracleConnection(StrCon);
            string str = "select YWBMID,KHMC,DZ,KHYH,ZH,XSFPID,TSJE from JT_C_XSTSD where XSTSDID='" + tsdid + "'";
            OracleCommand comm = new OracleCommand(str, connection);

            try
            {
                connection.Open();
                OracleDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    cwbmid = reader["YWBMID"].ToString();
                    this.txtKH.Text = reader["KHMC"].ToString();
                    this.txtDZ.Text = reader["DZ"].ToString();
                    this.txtKHH.Text = reader["KHYH"].ToString();
                    this.txtKHZH.Text = reader["ZH"].ToString();
                    fpid = reader["XSFPID"].ToString();
                    this.txtJE.Text = ConverDouble(reader["TSJE"].ToString());
                    this.txtHK.Text=ConvertMoney(Convert.ToDecimal(this.txtJE.Text.Trim()));


                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

        }
        private void ReportCWBM_Load()
        {
            string StrCon = ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString;
            OracleConnection connection = new OracleConnection(StrCon);
            string str = "select DWMC,ZH,TXDZ,KHYH from JT_J_DWXX where DWID='" + cwbmid + "'";
            OracleCommand comm = new OracleCommand(str, connection);

            try
            {
                connection.Open();
                OracleDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    this.txtDW.Text = reader["DWMC"].ToString();
                    this.txtDWDZ.Text = reader["TXDZ"].ToString();
                    this.txtDWZH.Text = reader["ZH"].ToString();
                    this.txtDWKHH.Text = reader["KHYH"].ToString();

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
  
        //以下为小写金额与大写金额的转换
        private string ConvertMoney(Decimal Money)
        {
            //金额转换程序
            string MoneyNum = "";//记录小写金额字符串[输入参数]
            string MoneyStr = "";//记录大写金额字符串[输出参数]
            string BNumStr = "零壹贰叁肆伍陆柒捌玖";//模
            string UnitStr = "万仟佰拾亿仟佰拾万仟佰拾圆角分";//模

            MoneyNum = ((long)(Money * 100)).ToString();
            for (int i = 0; i < MoneyNum.Length; i++)
            {
                string DVar = "";//记录生成的单个字符(大写)
                string UnitVar = "";//记录截取的单位
                for (int n = 0; n < 10; n++)
                {
                    //对比后生成单个字符(大写)
                    if (Convert.ToInt32(MoneyNum.Substring(i, 1)) == n)
                    {
                        DVar = BNumStr.Substring(n, 1);//取出单个大写字符
                        //给生成的单个大写字符加单位
                        UnitVar = UnitStr.Substring(15 - (MoneyNum.Length)).Substring(i, 1);
                        n = 10;//退出循环
                    }
                }
                //生成大写金额字符串
                MoneyStr = MoneyStr + DVar + UnitVar;
            }
            //二次处理大写金额字符串
            MoneyStr = MoneyStr + "整";
            while (MoneyStr.Contains("零分") || MoneyStr.Contains("零角") || MoneyStr.Contains("零佰") || MoneyStr.Contains("零仟")
                || MoneyStr.Contains("零万") || MoneyStr.Contains("零亿") || MoneyStr.Contains("零零") || MoneyStr.Contains("零圆")
                || MoneyStr.Contains("亿万") || MoneyStr.Contains("零整") || MoneyStr.Contains("分整"))
            {
                MoneyStr = MoneyStr.Replace("零分", "零");
                MoneyStr = MoneyStr.Replace("零角", "零");
                MoneyStr = MoneyStr.Replace("零拾", "零");
                MoneyStr = MoneyStr.Replace("零佰", "零");
                MoneyStr = MoneyStr.Replace("零仟", "零");
                MoneyStr = MoneyStr.Replace("零万", "万");
                MoneyStr = MoneyStr.Replace("零亿", "亿");
                MoneyStr = MoneyStr.Replace("亿万", "亿");
                MoneyStr = MoneyStr.Replace("零零", "零");
                MoneyStr = MoneyStr.Replace("零圆", "圆零");
                MoneyStr = MoneyStr.Replace("零整", "整");
                MoneyStr = MoneyStr.Replace("分整", "分");
            }
            if (MoneyStr == "整")
            {
                MoneyStr = "零元整";
            }
            return MoneyStr;
        }
        //以下为处理小写字符串格式
        private string ConverDouble(string str)
        {
            string returnstr = str.Replace(".", "");//取消符号
            string laststr = "";
            string[] strbuf = new string[returnstr.Length];
            for (int i = 0; i < returnstr.Length; i++)
            {
                strbuf[i] = returnstr.Substring(i, 1);
            }
            for (int i = 0; i < returnstr.Length; i++)
            {
                laststr = laststr + " " + strbuf[i];
            }
            return laststr;
        }
        
    }
}
