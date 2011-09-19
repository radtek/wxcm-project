using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
 
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;
using System.Configuration;

namespace ClientMain
{
    public partial class FrmInvoiceAlter : Form
    {
        public FrmInvoiceAlter(string AlterCgfpid, string AlterKprmc, string AlterFplxmc,string AlterSjph, string AlterKprid)
        {
            InitializeComponent();
            this.txtKPR.Text = AlterKprmc.ToString();
            this.txtKPR.Tag = AlterKprid.ToString();
            this.comboBoxFPLX.Text = AlterFplxmc;
            this.txtSJPH.Text = AlterSjph;
            this.txtSJPH.Tag = AlterCgfpid;
        }
        private OracleConnection MyConn = null;
        DataSet ds;
        //定义数据库连接
        private void Open()
        {
            string StrCon = ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString;
            MyConn = new OracleConnection(StrCon);
            if (MyConn.State.ToString() != "Open")
                MyConn.Open();
        }
        //定义数据库关闭
        private void sClose()
        {
            //  if (ds != null)
            //  { ds.Dispose(); }
            if (MyConn != null & MyConn.State.ToString() != "Closed")
            { MyConn.Close(); }
        }
        private static string strInvoiceSJPH = "";
        private static string strInvoiceKPRID = "";
        private static string strInvoiceFPLXID = "";
        private static string strInvoiceFPMC = "";
        private static string strInvoiceKPRMC = "";
        public static string getInvoiceSJPH
        {
            get
            {
                return strInvoiceSJPH;
            }
            set
            {
                strInvoiceSJPH = value;
            }
        }
        public static string getInvoiceKPRID
        {
            get
            {
                return strInvoiceKPRID;
            }
            set
            {
                strInvoiceKPRID = value;
            }
        }
        public static string getInvoiceFPLXID
        {
            get
            {
                return strInvoiceFPLXID;
            }
            set
            {
                strInvoiceFPLXID = value;
            }
        }
        public static string getInvoiceKPRMC
        {
            get
            {
                return strInvoiceKPRMC;
            }
            set
            {
                strInvoiceKPRMC = value;
            }
        }
        public static string getInvoiceFPMC
        {
            get
            {
                return strInvoiceFPMC;
            }
            set
            {
                strInvoiceFPMC = value;
            }
        }

        private void Load_comboBoxFPLX()//绑定发票类型
        {
            try
            {
                this.Open();
                string selectfplx = "select * from JT_J_FPLX";
                OracleDataAdapter adp = new OracleDataAdapter(selectfplx, MyConn);
                ds = new DataSet();
                adp.Fill(ds, "JT_J_FPLX");
                DataTable table = new DataTable();
                table = ds.Tables["JT_J_FPLX"];
                foreach (DataRow myrow in table.Rows)
                { this.comboBoxFPLX.Items.Add(myrow["FPLXMC"].ToString().Trim()); }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            finally
            { this.sClose(); }
        }
        private string GetFPLXId(string text)
        {
            string id = "1";
            try
            {
                this.Open();
                string selectid = "select FPLXID from JT_J_FPLX where FPLXMC='"+text+"'";
                OracleCommand comm = new OracleCommand(selectid,MyConn);
                OracleDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    id = reader.GetValue(0).ToString();
                    
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Close();
            }
            return id;
        }
        private void btncanncle_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.sClose();
            this.Close();
        }

        private void btnSELECT_Click(object sender, EventArgs e)
        {
            FrmPurchaseInvoiceKPR FrmPurchaseInvoiceKPR = new FrmPurchaseInvoiceKPR();
            if (FrmPurchaseInvoiceKPR.ShowDialog() == DialogResult.OK)
            {
                this.txtKPR.Tag = FrmPurchaseInvoiceKPR.cgfp_operatorid.ToString();

                
                try
                {
                    this.Open();
                    string str = "select OPERATORNAME from BASE_OPERATOR where OPERATORID='" + this.txtKPR.Tag.ToString() + "'";
                    OracleCommand comm = new OracleCommand(str,MyConn);
                    OracleDataReader reader = comm.ExecuteReader();
                    while(reader.Read())
                    {
                        this.txtKPR.Text = reader.GetValue(0).ToString();
                    }
                }
                catch(Exception ex)
                {MessageBox.Show(ex.Message);}
                finally
                {
                    this.sClose();
                }


            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(this.txtSJPH.Text.Trim()=="")
            {
                MessageBox.Show("系统提示","请输入实际票号");
            }
                else if(this.comboBoxFPLX.Text=="")
            {
                MessageBox.Show("系统提示", "请选择发票类型");
            }
            else if (this.txtKPR.Text == "")
            {
                MessageBox.Show("系统提示", "请选择开票人");
            }
            else
            {

                strInvoiceSJPH = this.txtSJPH.Text.ToString().Trim();
                strInvoiceFPLXID = GetFPLXId(this.comboBoxFPLX.Text.ToString());
                strInvoiceKPRID = this.txtKPR.Tag.ToString();
                strInvoiceKPRMC = this.txtKPR.Text.ToString().Trim();


                    
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        private void FrmInvoiceAlter_Load(object sender, EventArgs e)
        {
            Load_comboBoxFPLX();
        }

       
    }
}
