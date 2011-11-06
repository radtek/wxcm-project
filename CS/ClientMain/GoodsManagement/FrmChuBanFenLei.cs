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
    public partial class FrmChuBanFenLei : Form
    {
        private static string cbflwid = "";
        private static string cbflwmc = "";
        public static string cbflid
        {
            get
            {
                return cbflwid;
            }
            set
            {
                cbflwid = value;
            }
        }
        public static string cbflmc
        {
            get
            {
                return cbflwmc;
            }
            set
            {
                cbflwmc = value;
            }
        }
        string StrCon = FrmLogin.strDataCent;
        public FrmChuBanFenLei(string cbflmc)
        {
            InitializeComponent();
            label1.Tag = cbflmc;
            dataGridView1.KeyDown += new KeyEventHandler(dataGridView1_KeyDown); 
        }
        private void GetData(string selectCommand)
        {
            try
            {
                OracleConnection Myconn = new OracleConnection(StrCon);
                DataSet ds = new DataSet();
                OracleDataAdapter dataAdapter = new OracleDataAdapter(selectCommand, Myconn);
                dataAdapter.Fill(ds, "JT_J_CBFL");
                dataGridView1.DataSource = ds.Tables[0];
                this.dataGridView1.Columns["CBFLID"].HeaderText = " 出版分类ID ";
                this.dataGridView1.Columns["FLBH"].HeaderText = " 分类编号 ";
                this.dataGridView1.Columns["CBFL"].HeaderText = " 出版分类 ";
                this.dataGridView1.Columns["FLJC"].HeaderText = " 分类简称 ";
                this.dataGridView1.Columns["ZJM"].HeaderText = " 助记码 ";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void FrmChuBanFenLei_Load(object sender, EventArgs e)
        {
            string StrChuBanFenLei_null = "select CBFLID,FLBH,CBFL,FLJC,ZJM from JT_J_CBFL where zt='启用'";
            string StrChuBanFenLei_exist = "select CBFLID,FLBH,CBFL,FLJC,ZJM from JT_J_CBFL where zt='启用' AND KBMC  LIKE '%" + label1.Tag.ToString() + "%'";
            if (string.IsNullOrEmpty(label1.Tag.ToString()))
            {
                GetData(StrChuBanFenLei_null);
            }
            else
            {
                GetData(StrChuBanFenLei_null);
            }
        }
        private void dataGridView1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if ((e.Alt && (e.KeyCode == Keys.Z))||(e.KeyCode==Keys.Enter))
            {
                int c;
                c = this.dataGridView1.CurrentRow.Index;
                cbflwid = this.dataGridView1["CBFLID", c].Value.ToString();
                cbflwmc = this.dataGridView1["CBFL", c].Value.ToString();
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
