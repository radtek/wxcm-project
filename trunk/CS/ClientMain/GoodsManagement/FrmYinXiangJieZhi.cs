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
    public partial class FrmYinXiangJieZhi : Form
    {
        private static string yxjzwid = "";
        private static string yxjzwmc = "";
        public static string yxjzID
        {
            get
            {
                return yxjzwid;
            }
            set
            {
                yxjzwid = value;
            }
        }
        public static string yxjzMC
        {
            get
            {
                return yxjzwmc;
            }
            set
            {
                yxjzwmc = value;
            }
        }
        string StrCon = FrmLogin.strDataCent;
        public FrmYinXiangJieZhi(string yxjzmc)
        {
            InitializeComponent();
            label1.Tag = yxjzmc;
            dataGridView1.KeyDown += new KeyEventHandler(dataGridView1_KeyDown); 
        }
        private void GetData(string selectCommand)
        {
            try
            {
                OracleConnection Myconn = new OracleConnection(StrCon);
                DataSet ds = new DataSet();
                OracleDataAdapter dataAdapter = new OracleDataAdapter(selectCommand, Myconn);
                dataAdapter.Fill(ds, "JT_J_YXJZ");
                dataGridView1.DataSource = ds.Tables[0];
                this.dataGridView1.Columns["YXJZID"].HeaderText = " 音像介质ID ";
                this.dataGridView1.Columns["YXJZBH"].HeaderText = " 介质编号  ";
                this.dataGridView1.Columns["YXJZMC"].HeaderText = " 介质名称 ";
                this.dataGridView1.Columns["JC"].HeaderText = " 简称";
                this.dataGridView1.Columns["ZJM"].HeaderText = " 助记码 ";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void FrmYinXiangJieZhi_Load(object sender, EventArgs e)
        {
            string StrYinXiangJieZhi_null = "select YXJZID,YXJZBH,YXJZMC,JC,ZJM from JT_J_YXJZ where zt='启用'";
            string StrYinXiangJieZhi_exist = "select YXJZID,YXJZBH,YXJZMC,JC,ZJM from JT_J_YXJZ where zt='启用' AND YXJZMC  LIKE '%" + label1.Tag.ToString() + "%'";
            if (string.IsNullOrEmpty(label1.Tag.ToString()))
            {
                GetData(StrYinXiangJieZhi_null);
            }
            else
            {
                GetData(StrYinXiangJieZhi_exist);
            }
        }
        private void dataGridView1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if ((e.Alt && (e.KeyCode == Keys.Z)) || (e.KeyCode == Keys.Enter))
            {
                int c;
                c = this.dataGridView1.CurrentRow.Index;
                yxjzwid = this.dataGridView1["YXJZID", c].Value.ToString();
                yxjzwmc = this.dataGridView1["YXJZMC", c].Value.ToString();
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
