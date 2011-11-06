using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics; 
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;



namespace ClientMain
{
    public partial class FrmChuBanShe : Form
    {
        private static string cbsdwid="";
        private static string cbsdwmc="";
        public static string cbsid
        {
            get
            {
                return cbsdwid;
            }
            set
            {
                cbsdwid = value;
            }
        }
        public static string cbsmc
        {
            get
            {
                return cbsdwmc;
            }
            set
            {
                cbsdwmc = value;
            }
        }
        string StrCon = FrmLogin.strDataCent;
        public FrmChuBanShe(string dwmc)
        {
            InitializeComponent();
            label1.Tag = dwmc;
            dataGridView1.KeyDown += new KeyEventHandler(dataGridView1_KeyDown); 

 
        }
        private void GetData(string selectCommand)
        {
            try
            {
                OracleConnection Myconn = new OracleConnection(StrCon);
                DataSet ds = new DataSet();
                OracleDataAdapter dataAdapter = new OracleDataAdapter(selectCommand, Myconn);
                dataAdapter.Fill(ds, "view_jt_j_dwxx");
                dataGridView1.DataSource=ds.Tables[0];
                this.dataGridView1.Columns["DWID"].HeaderText = " 单位ID ";
                this.dataGridView1.Columns["DWMC"].HeaderText = " 单位名称  ";
                this.dataGridView1.Columns["DWBH"].HeaderText = " 单位编号 ";
                this.dataGridView1.Columns["ZJM"].HeaderText = " 助记码 ";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void FrmChuBanShe_Load(object sender, EventArgs e)
        {
            string StrChubanshe_null = "select DWID,DWMC,DWBH,ZJM from view_jt_j_dwxx where cbslxid in(1,2)";
            string StrChubanshe_exist = "select DWID,DWMC,DWBH,ZJM from view_jt_j_dwxx where cbslxid in(1,2) AND DWMC  LIKE '%"+label1.Tag.ToString()+"%'";
            if(string.IsNullOrEmpty(label1.Tag.ToString()))
            {
                GetData(StrChubanshe_null);
            }
                else
            {
                GetData(StrChubanshe_exist);
            }
        }
        private void dataGridView1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.Alt && (e.KeyCode == Keys.Z) || (e.KeyCode == Keys.Enter))
            {
                int c;
                c = this.dataGridView1.CurrentRow.Index;
                cbsdwid = this.dataGridView1["DWID", c].Value.ToString();
                cbsdwmc = this.dataGridView1["DWMC", c].Value.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            if (e.Alt && (e.KeyCode == Keys.X))
            {
                this.Close();
            }
            if (e.Alt && (e.KeyCode == Keys.S))
            {
                this.dataGridView1.ClearSelection();//使dataGridView失去焦点
                this.dataGridView1.TabStop = false;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int c;
            c = this.dataGridView1.CurrentRow.Index;
            this.dataGridView1[0, c].Selected = true;
        } 


    }
}
