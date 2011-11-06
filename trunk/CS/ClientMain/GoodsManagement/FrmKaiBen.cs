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
    public partial class FrmKaiBen : Form
    {
        private static string kbwid = "";
        private static string kbwmc = "";
        public static string KBID
        {
            get
            {
                return kbwid;
            }
            set
            {
                kbwid = value;
            }
        }
        public static string KBMC
        {
            get
            {
                return kbwmc;
            }
            set
            {
                kbwmc = value;
            }
        }
        string StrCon = FrmLogin.strDataCent;
        public FrmKaiBen(string kkmc)
        {
            InitializeComponent();
            label1.Tag = kkmc;
            dataGridView1.KeyDown += new KeyEventHandler(dataGridView1_KeyDown); 
        }
        private void GetData(string selectCommand)
        {
            try
            {
                OracleConnection Myconn = new OracleConnection(StrCon);
                DataSet ds = new DataSet();
                OracleDataAdapter dataAdapter = new OracleDataAdapter(selectCommand, Myconn);
                dataAdapter.Fill(ds, "JT_J_KBBM");
                dataGridView1.DataSource = ds.Tables[0];
                this.dataGridView1.Columns["KBID"].HeaderText = " 开本ID ";
                this.dataGridView1.Columns["KBBH"].HeaderText = " 开本编号  ";
                this.dataGridView1.Columns["KBMC"].HeaderText = " 开本名称 ";
                this.dataGridView1.Columns["KBJC"].HeaderText = " 开本简称 ";
                this.dataGridView1.Columns["ZJM"].HeaderText = " 助记码 ";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void FrmKaiBen_Load(object sender, EventArgs e)
        {
            string StrKaiBen_null = "select KBID,KBBH,KBMC,KBJC,ZJM from JT_J_KBBM where zt='启用'";
            string StrKaiBen_exist = "select KBID,KBBH,KBMC,KBJC,ZJM from JT_J_KBBM where zt='启用' AND KBMC  LIKE '%" + label1.Tag.ToString() + "%'";
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
                kbwid = this.dataGridView1["KBID", c].Value.ToString();
                kbwmc = this.dataGridView1["KBMC", c].Value.ToString();
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
