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
    public partial class FrmBanBie : Form
    {
        private static string bbwid = "";
        private static string bbwmc = "";
        public static string bbid
        {
            get
            {
                return bbwid;
            }
            set
            {
                bbwid = value;
            }
        }
        public static string bbmc
        {
            get
            {
                return bbwmc;
            }
            set
            {
                bbwmc = value;
            }
        }
        string StrCon = FrmLogin.strDataCent;
        public FrmBanBie(string bbname)
        {
            InitializeComponent();
            label1.Tag = bbname;
            dataGridView1.KeyDown += new KeyEventHandler(dataGridView1_KeyDown); 
        }
        private void GetData(string selectCommand)
        {
            try
            {
                OracleConnection Myconn = new OracleConnection(StrCon);
                DataSet ds = new DataSet();
                OracleDataAdapter dataAdapter = new OracleDataAdapter(selectCommand, Myconn);
                dataAdapter.Fill(ds, "JT_J_BBBM");
                dataGridView1.DataSource = ds.Tables[0];
                this.dataGridView1.Columns["BBBMID"].HeaderText = " 版别ID ";
                this.dataGridView1.Columns["BBBH"].HeaderText = " 版别编号  ";
                this.dataGridView1.Columns["BB"].HeaderText = " 版别 ";
                this.dataGridView1.Columns["JC"].HeaderText = " 简称 ";
                this.dataGridView1.Columns["ZJM"].HeaderText = " 助记码 ";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void FrmBanBie_Load(object sender, EventArgs e)
        {
            string StrBanBie_null = "select BBBMID,BBBH,BB,JC,ZJM from JT_J_BBBM ";
            string StrBanBie_exist = "select BBBMID,BBBH,BB,JC,ZJM from JT_J_BBBM where BB  LIKE '%" + label1.Tag.ToString() + "%'";
            if (string.IsNullOrEmpty(label1.Tag.ToString()))
            {
                GetData(StrBanBie_null);
            }
            else
            {
                GetData(StrBanBie_exist);
            }
        }
        private void dataGridView1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if ((e.Alt && (e.KeyCode == Keys.Z)) || (e.KeyCode == Keys.Enter))
            {
                int c;
                c = this.dataGridView1.CurrentRow.Index;
                bbwid = this.dataGridView1["BBBMID", c].Value.ToString();
                bbwmc = this.dataGridView1["BB", c].Value.ToString();
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
