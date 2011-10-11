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
    public partial class FrmSPXXSelect : Form
    {
        public FrmSPXXSelect()
        {
            InitializeComponent();
        }
        
        public FrmSPXXSelect(string  hm)
        {
            InitializeComponent();
            spbh = hm;
        }
        private static string[] ycspxxds=new string[3];
        public static string[] YCspxxds
        {
            get
            {
                return ycspxxds;
            }
            set
            {
                ycspxxds = value;
            }
        }
        private OracleConnection MyConn = null;
        DataSet ds;
        private void Open()
        {
            string StrCon = FrmLogin.strDataCent;
            MyConn = new OracleConnection(StrCon);
            if (MyConn.State.ToString() != "Open")
                MyConn.Open();
        }
        //定义数据库关闭
        private void sClose()
        {
            if (ds != null)
            { ds.Dispose(); }
            if (MyConn != null & MyConn.State.ToString() != "Closed")
            { MyConn.Close(); }
        }
        private string spbh;
        private void GetData(string selectCommand)
        {
            try
            {
                this.Open();

                OracleDataAdapter dataAdapter = new OracleDataAdapter(selectCommand, MyConn);
                OracleCommandBuilder commandBuilder = new OracleCommandBuilder(dataAdapter);
                ds = new DataSet();
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;
                this.dataGridView1.DataSource = bindingSource1;
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                this.dataGridView1.Columns["SPXXID"].HeaderText = "商品ID";
               this.dataGridView1.Columns["SPBH"].HeaderText = "商品编号";
                this.dataGridView1.Columns["PM"].HeaderText = "商品名称";
                this.dataGridView1.Columns["DJ"].HeaderText = "商品定价";
                this.dataGridView1.Columns["DWMC"].HeaderText = "出版社名称";
                this.dataGridView1.Columns["ZZ"].HeaderText = "作者";
                this.dataGridView1.Columns["CBNY"].HeaderText = "出版年月";
                this.dataGridView1.Columns["BC"].HeaderText = "版次";
                this.dataGridView1.Columns["YSSJ"].HeaderText = "印刷时间";

            }
            catch(OracleException ex)
            {
                throw ex;
            }
                finally
            {
               // this.sClose();
            }
           

        }
        private void FrmSPXXSelect_Load(object sender, EventArgs e)
        {
            GetData("select a.SPXXID,a.SPBH,a.PM,a.DJ,b.DWMC,a.ZZ,a.CBNY,a.BC,a.YSSJ from JT_J_SPXX a , JT_J_DWXX b where  a.CBSID=b.DWID and  a.SPBH='" + spbh + "'");
            this.dataGridView1.ClearSelection();//使dataGridView失去焦点
            this.dataGridView1.TabStop = false;

        }

        private void btnSelectCheck_Click(object sender, EventArgs e)
        {
            int c;
            c = this.dataGridView1.CurrentRow.Index;
            ycspxxds[0] = this.dataGridView1[0, c].Value.ToString();
            ycspxxds[1] = this.dataGridView1[2, c].Value.ToString();
            ycspxxds[2] = this.dataGridView1[3, c].Value.ToString();
            this.DialogResult = DialogResult.OK;
            this.sClose();
            this.Close();
        }

    }
}
