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
    public partial class FrmFaXingFenLei : Form
    {
        private static string fxflwid = "";
        private static string fxflwmc = "";
        public static string fxflID
        {
            get
            {
                return fxflwid;
            }
            set
            {
                fxflwid = value;
            }
        }
        public static string fxflMC
        {
            get
            {
                return fxflwmc;
            }
            set
            {
                fxflwmc = value;
            }
        }
        string StrCon = FrmLogin.strDataCent;
        public FrmFaXingFenLei(string fxflmxc)
        {
            InitializeComponent();
            label1.Tag = fxflmxc;
            dataGridView1.KeyDown += new KeyEventHandler(dataGridView1_KeyDown); 
        }
        private void GetData(string selectCommand)
        {
            try
            {
                OracleConnection Myconn = new OracleConnection(StrCon);
                DataSet ds = new DataSet();
                OracleDataAdapter dataAdapter = new OracleDataAdapter(selectCommand, Myconn);
                dataAdapter.Fill(ds, "JT_J_FXFLMC");
                dataGridView1.DataSource = ds.Tables[0];
                this.dataGridView1.Columns["FXFLID"].HeaderText = " 出版分类ID ";
                this.dataGridView1.Columns["FXFLBH"].HeaderText = " 分类编号  ";
                this.dataGridView1.Columns["FXFLMC"].HeaderText = " 出版分类 ";
                this.dataGridView1.Columns["FXFLJC"].HeaderText = " 分类简称 ";
                this.dataGridView1.Columns["ZJM"].HeaderText = " 助记码 ";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void FrmFaXingFenLei_Load(object sender, EventArgs e)
        {
            string StrFaXingFenLei_null = "select FXFLID,FXFLBH,FXFLMC,FXFLJC,ZJM from JT_J_FXFL where zt='启用'";
            string StrFaXingFenLei_exist = "select FXFLID,FXFLBH,FXFLMC,FXFLJC,ZJM from JT_J_FXFL where zt='启用' AND FXFLJC  LIKE '%" + label1.Tag.ToString() + "%'";
            if (string.IsNullOrEmpty(label1.Tag.ToString()))
            {
                GetData(StrFaXingFenLei_null);
            }
            else
            {
                GetData(StrFaXingFenLei_exist);
            }
        }
        private void dataGridView1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if ((e.Alt && (e.KeyCode == Keys.Z))||(e.KeyCode==Keys.Enter))
            {
                int c;
                c = this.dataGridView1.CurrentRow.Index;
                fxflwid = this.dataGridView1["FXFLID", c].Value.ToString();
                fxflwmc = this.dataGridView1["FXFLMC", c].Value.ToString();
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
