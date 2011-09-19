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
  
        //����ΪСд������д����ת��
        private string ConvertMoney(Decimal Money)
        {
            //���ת������
            string MoneyNum = "";//��¼Сд����ַ���[�������]
            string MoneyStr = "";//��¼��д����ַ���[�������]
            string BNumStr = "��Ҽ��������½��ƾ�";//ģ
            string UnitStr = "��Ǫ��ʰ��Ǫ��ʰ��Ǫ��ʰԲ�Ƿ�";//ģ

            MoneyNum = ((long)(Money * 100)).ToString();
            for (int i = 0; i < MoneyNum.Length; i++)
            {
                string DVar = "";//��¼���ɵĵ����ַ�(��д)
                string UnitVar = "";//��¼��ȡ�ĵ�λ
                for (int n = 0; n < 10; n++)
                {
                    //�ԱȺ����ɵ����ַ�(��д)
                    if (Convert.ToInt32(MoneyNum.Substring(i, 1)) == n)
                    {
                        DVar = BNumStr.Substring(n, 1);//ȡ��������д�ַ�
                        //�����ɵĵ�����д�ַ��ӵ�λ
                        UnitVar = UnitStr.Substring(15 - (MoneyNum.Length)).Substring(i, 1);
                        n = 10;//�˳�ѭ��
                    }
                }
                //���ɴ�д����ַ���
                MoneyStr = MoneyStr + DVar + UnitVar;
            }
            //���δ����д����ַ���
            MoneyStr = MoneyStr + "��";
            while (MoneyStr.Contains("���") || MoneyStr.Contains("���") || MoneyStr.Contains("���") || MoneyStr.Contains("��Ǫ")
                || MoneyStr.Contains("����") || MoneyStr.Contains("����") || MoneyStr.Contains("����") || MoneyStr.Contains("��Բ")
                || MoneyStr.Contains("����") || MoneyStr.Contains("����") || MoneyStr.Contains("����"))
            {
                MoneyStr = MoneyStr.Replace("���", "��");
                MoneyStr = MoneyStr.Replace("���", "��");
                MoneyStr = MoneyStr.Replace("��ʰ", "��");
                MoneyStr = MoneyStr.Replace("���", "��");
                MoneyStr = MoneyStr.Replace("��Ǫ", "��");
                MoneyStr = MoneyStr.Replace("����", "��");
                MoneyStr = MoneyStr.Replace("����", "��");
                MoneyStr = MoneyStr.Replace("����", "��");
                MoneyStr = MoneyStr.Replace("����", "��");
                MoneyStr = MoneyStr.Replace("��Բ", "Բ��");
                MoneyStr = MoneyStr.Replace("����", "��");
                MoneyStr = MoneyStr.Replace("����", "��");
            }
            if (MoneyStr == "��")
            {
                MoneyStr = "��Ԫ��";
            }
            return MoneyStr;
        }
        //����Ϊ����Сд�ַ�����ʽ
        private string ConverDouble(string str)
        {
            string returnstr = str.Replace(".", "");//ȡ������
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
