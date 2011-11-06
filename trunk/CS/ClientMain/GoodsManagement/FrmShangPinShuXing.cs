using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;
namespace ClientMain
{
    public partial class FrmShangPinShuXing : Form
    {
        private static string spsxwid = "";
        private static string spsxwmc = "";
        public static string spsxID
        {
            get
            {
                return spsxwid;
            }
            set
            {
                spsxwid = value;
            }
        }
        public static string spsxMC
        {
            get
            {
                return spsxwmc;
            }
            set
            {
                spsxwmc = value;
            }
        }
        string StrCon = FrmLogin.strDataCent;
        public FrmShangPinShuXing(string spsxmc)
        {
            InitializeComponent();
            label1.Tag = spsxmc;
            dataGridView1.KeyDown += new KeyEventHandler(dataGridView1_KeyDown); 
        }
        private void GetData(string selectCommand)
        {
            try
            {
                OracleConnection Myconn = new OracleConnection(StrCon);
                DataSet ds = new DataSet();
                OracleDataAdapter dataAdapter = new OracleDataAdapter(selectCommand, Myconn);
                dataAdapter.Fill(ds, "JT_J_SPSX");
                dataGridView1.DataSource = ds.Tables[0];
                this.dataGridView1.Columns["SPSXID"].HeaderText = " 商品属性ID ";
                this.dataGridView1.Columns["BH"].HeaderText = " 编号  ";
                this.dataGridView1.Columns["MC"].HeaderText = " 开本名称 ";
                this.dataGridView1.Columns["JC"].HeaderText = " 开本简称 ";
                this.dataGridView1.Columns["ZJM"].HeaderText = " 助记码 ";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void FrmShangPinShuXing_Load(object sender, EventArgs e)
        {
            string StrKaiBen_null = "select SPSXID,BH,MC,JC,ZJM from JT_J_SPSX where zt='启用'";
            string StrKaiBen_exist = "select SPSXID,BH,MC,JC,ZJM from JT_J_SPSX where zt='启用' AND MC  LIKE '%" + label1.Tag.ToString() + "%'";
            if (string.IsNullOrEmpty(label1.Tag.ToString()))
            {
                GetData(StrKaiBen_null);
            }
            else
            {
                GetData(StrKaiBen_exist);
            }
        }
        private void dataGridView1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if ((e.Alt && (e.KeyCode == Keys.Z)) || (e.KeyCode == Keys.Enter))
            {
                int c;
                c = this.dataGridView1.CurrentRow.Index;
                spsxwid = this.dataGridView1["SPSXID", c].Value.ToString();
                spsxwmc = this.dataGridView1["MC", c].Value.ToString();
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
    }
}
