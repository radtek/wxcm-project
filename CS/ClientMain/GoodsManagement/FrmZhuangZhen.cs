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
    public partial class FrmZhuangZhen : Form
    {
        private static string zzwid = "";
        private static string zzwmc = "";
        public static string ZZID
        {
            get
            {
                return zzwid;
            }
            set
            {
                zzwid = value;
            }
        }
        public static string ZZMC
        {
            get
            {
                return zzwmc;
            }
            set
            {
                zzwmc = value;
            }
        }
        string StrCon = FrmLogin.strDataCent;
        public FrmZhuangZhen(string ZZMC)
        {
            InitializeComponent();
            label1.Tag = ZZMC;
            dataGridView1.KeyDown += new KeyEventHandler(dataGridView1_KeyDown); 
        }
        private void GetData(string selectCommand)
        {
            try
            {
                OracleConnection Myconn = new OracleConnection(StrCon);
                DataSet ds = new DataSet();
                OracleDataAdapter dataAdapter = new OracleDataAdapter(selectCommand, Myconn);
                dataAdapter.Fill(ds, "JT_J_ZZBM");
                dataGridView1.DataSource = ds.Tables[0];
                this.dataGridView1.Columns["ZZID"].HeaderText = " 装帧ID ";
                this.dataGridView1.Columns["ZZBH"].HeaderText = " 编号  ";
                this.dataGridView1.Columns["ZZMC"].HeaderText = " 装帧 ";
                this.dataGridView1.Columns["ZZJC"].HeaderText = " 简称 ";
                this.dataGridView1.Columns["ZJM"].HeaderText = " 助记码 ";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void FrmZhuangZhen_Load(object sender, EventArgs e)
        {
            string StrZhuangZhen_null = "select ZZID,ZZBH,ZZMC,ZZJC,ZJM from JT_J_ZZBM where zt='启用'";
            string StrZhuangZhen_exist = "select ZZID,ZZBH,ZZMC,ZZJC,ZJM from JT_J_ZZBM where zt='启用' AND ZZMC  LIKE '%" + label1.Tag.ToString() + "%'";
            if (string.IsNullOrEmpty(label1.Tag.ToString()))
            {
                GetData(StrZhuangZhen_null);
            }
            else
            {
                GetData(StrZhuangZhen_exist);
            }
        }
        private void dataGridView1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if ((e.Alt && (e.KeyCode == Keys.Z)) || (e.KeyCode == Keys.Enter))
            {
                int c;
                c = this.dataGridView1.CurrentRow.Index;
                zzwid = this.dataGridView1["ZZID", c].Value.ToString();
                zzwmc = this.dataGridView1["ZZMC", c].Value.ToString();
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
