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
    public partial class FrmYuZhong : Form
    {
        private static string yzwid = "";
        private static string yzwmc = "";
        public static string yzid
        {
            get
            {
                return yzwid;
            }
            set
            {
                yzwid = value;
            }
        }
        public static string yzmc
        {
            get
            {
                return yzwmc;
            }
            set
            {
                yzwmc = value;
            }
        }
        string StrCon = FrmLogin.strDataCent;
        public FrmYuZhong(string yzmc)
        {
            InitializeComponent();
            label1.Tag = yzmc;
            dataGridView1.KeyDown += new KeyEventHandler(dataGridView1_KeyDown); 
        }
        private void GetData(string selectCommand)
        {
            try
            {
                OracleConnection Myconn = new OracleConnection(StrCon);
                DataSet ds = new DataSet();
                OracleDataAdapter dataAdapter = new OracleDataAdapter(selectCommand, Myconn);
                dataAdapter.Fill(ds, "JT_J_YZBM");
                dataGridView1.DataSource = ds.Tables[0];
                this.dataGridView1.Columns["YZID"].HeaderText = " 语种ID ";
                this.dataGridView1.Columns["YZBH"].HeaderText = " 编号  ";
                this.dataGridView1.Columns["YZMC"].HeaderText = " 语种 ";
                this.dataGridView1.Columns["YZJC"].HeaderText = " 简称 ";
                this.dataGridView1.Columns["ZJM"].HeaderText = " 助记码 ";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void FrmYuZhong_Load(object sender, EventArgs e)
        {
            string StrYuZhong_null = "select YZID,YZBH,YZMC,YZJC,ZJM from JT_J_YZBM ";
            string StrYuZhong_exist = "select YZID,YZBH,YZMC,YZJC,ZJM from JT_J_YZBM where YZMC LIKE '%" + label1.Tag.ToString() + "%'";
            if (string.IsNullOrEmpty(label1.Tag.ToString()))
            {
                GetData(StrYuZhong_null);
            }
            else
            {
                GetData(StrYuZhong_exist);
            }
        }
        private void dataGridView1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if ((e.Alt && (e.KeyCode == Keys.Z)) || (e.KeyCode == Keys.Enter))
            {
                int c;
                c = this.dataGridView1.CurrentRow.Index;
                yzwid = this.dataGridView1["YZID", c].Value.ToString();
                yzwmc = this.dataGridView1["YZMC", c].Value.ToString();
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
