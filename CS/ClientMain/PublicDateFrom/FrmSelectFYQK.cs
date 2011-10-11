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
    public partial class FrmSelectFYQK : Form
    {
        public FrmSelectFYQK()
        {
            InitializeComponent();
        }
        private OracleConnection MyConn = null;
        DataSet ds;
        private static string JT_J_FYQK_id = "";//选中的购货单位ID号
        private static string JT_J_FYQK_bh = "";//选中的购货单位名称
        public static string FYQK_id 
        {
            get
            {
                return JT_J_FYQK_id;
            }
            set
            {
                JT_J_FYQK_id = value;
            }
        }
        public static string FYQK_bh
        {
            get
            {
                return JT_J_FYQK_bh;
            }
            set
            {
                JT_J_FYQK_bh = value;
            }
        }
        //定义数据库连接
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
        //定义翻页使用的几个公共数据
        int pageSize = 10;     //每页显示行数
        int nMax = 0;         //总记录数
        int pageCount = 0;    //页数＝总记录数/每页显示行数
        int pageCurrent = 0;   //当前页号
        int nCurrent = 0;      //当前记录行
        DataTable dtInfo = new DataTable();
        DataTable dtTemp = new DataTable();
        private void InitDataSet()
        {



            pageSize = 40;
            //设置页面行数
            nMax = dtInfo.Rows.Count;

            pageCount = (nMax / pageSize);    //计算出总页数

            if ((nMax % pageSize) > 0) pageCount++;

            pageCurrent = 1;    //当前页数从1开始
            nCurrent = 0;       //当前记录数从0开始

            LoadData();
        }
        private void LoadData()
        {
            int nStartPos = 0;   //当前页面开始记录行
            int nEndPos = 0;     //当前页面结束记录行

            DataTable dtTemp = dtInfo.Clone();   //克隆DataTable结构框架

            if (pageCurrent == pageCount)
                nEndPos = nMax;
            else
                nEndPos = pageSize * pageCurrent;

            nStartPos = nCurrent;

            txtTotalPage.Text = pageCount.ToString();
            txtCurrentPage.Text = Convert.ToString(pageCurrent);

            //从元数据源复制记录行
            for (int i = nStartPos; i < nEndPos; i++)
            {
                dtTemp.ImportRow(dtInfo.Rows[i]);
                nCurrent++;
            }

            bindingSource1.DataSource = dtTemp;
            dataGridView1.DataSource = bindingSource1;
            this.dataGridView1.Columns["FYQKID"].HeaderText = "ID";
            this.dataGridView1.Columns["BH"].HeaderText = "运送情况编号";
            this.dataGridView1.Columns["FYQK"].HeaderText = "运输情况";
            this.dataGridView1.Columns["ZJM"].HeaderText = "助记码";
        }
        private void GetData(string selectCommand)
        {
            try
            {

                this.Open();

                OracleDataAdapter dataAdapter = new OracleDataAdapter(selectCommand, MyConn);
                OracleCommandBuilder commandBuilder = new OracleCommandBuilder(dataAdapter);
                ds = new DataSet();
                dtInfo.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(ds, "JT_J_FYQK");
                dtInfo = ds.Tables["JT_J_FYQK"];
                InitDataSet();


            }
            catch (OracleException)
            {
                MessageBox.Show("To run this example, replace the value of the " +
                    "connectionString variable with a connection string that is " +
                    "valid for your system.");
            }
        }
        private void GetSelectData(string selectCommand)
        {
            try
            {
                this.Open();
                OracleDataAdapter dataAdapter = new OracleDataAdapter(selectCommand, MyConn);
                OracleCommandBuilder commandBuilder = new OracleCommandBuilder(dataAdapter);
                ds = new DataSet();
                dtInfo.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(ds, "JT_J_FYQK");
                dtInfo = ds.Tables["JT_J_FYQK"];
                bindingSource1.DataSource = dtInfo;
                dataGridView1.DataSource = bindingSource1;
                this.dataGridView1.Columns["FYQKID"].HeaderText = "ID";
                this.dataGridView1.Columns["BH"].HeaderText = "运送情况编号";
                this.dataGridView1.Columns["FYQK"].HeaderText = "运输情况";
                this.dataGridView1.Columns["ZJM"].HeaderText = "助记码";
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnLook_Click(object sender, EventArgs e)
        {
            if (this.txtNo.Text.Trim() != "")
            {
                string strselect = "select FYQKID,BH,FYQK,ZJM from JT_J_FYQK where DWID LIKE'" + this.txtNo.Text.Trim().ToString() + "%'";
                GetSelectData(strselect);
                this.dataGridView1.ClearSelection();//使dataGridView失去焦点
                this.dataGridView1.TabStop = false;
                this.btnnextpage.Visible = false;
                this.btnlastpage.Visible = false;

            }
            else if (this.txtBH.Text.Trim() != "")
            {
                string strselect = "select FYQKID,BH,FYQK,ZJM from JT_J_FYQK where BH LIKE'" + this.txtBH.Text.Trim().ToString() + "%'";
                GetSelectData(strselect);
                this.dataGridView1.ClearSelection();//使dataGridView失去焦点
                this.dataGridView1.TabStop = false;
                this.btnnextpage.Visible = false;
                this.btnlastpage.Visible = false;
            }
            else if (this.txtFastcode.Text.Trim() != "")
            {
                string strselect = "select FYQKID,BH,FYQK,ZJM from JT_J_FYQK where ZJM LIKE'" + this.txtFastcode.Text.Trim().ToString() + "%'";
                GetSelectData(strselect);
                this.dataGridView1.ClearSelection();//使dataGridView失去焦点
                this.dataGridView1.TabStop = false;
                this.btnnextpage.Visible = false;
                this.btnlastpage.Visible = false;
            }
            else
            {
                MessageBox.Show("您没有选择任何查询条件", "系统提示");
            }

        }
        private int GetDatacount(string tablename)
        {
            int i = 0;
            string selectcomm = "select count(1) from " + tablename;
            this.Open();
            OracleCommand comm = new OracleCommand(selectcomm, MyConn);
            OracleDataReader reader = comm.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    i = Convert.ToInt16(reader.GetValue(0).ToString());



                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            finally
            {
                this.sClose();
            }
            return i;
        }
        private void GetData_nothing(string selectCommand)
        {
            try
            {
                // Specify a connection string. Replace the given value with a  valid connection string for a Northwind SQL Server sample database accessible to your system.
                this.Open();
                // Create a new data adapter based on the specified query.
                OracleDataAdapter dataAdapter = new OracleDataAdapter(selectCommand, MyConn);
                // Create a command builder to generate SQL update, insert, and delete commands based on selectCommand. These are used to update the database.
                OracleCommandBuilder commandBuilder = new OracleCommandBuilder(dataAdapter);
                // Populate a new data table and bind it to the BindingSource.
                ds = new DataSet();

                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(ds, "JT_J_FYQK");
                table = ds.Tables["JT_J_FYQK"];

                bindingSource1.DataSource = table;
                //   bindingSource1.DataMember = "SYS_ROLE";

                dataGridView1.DataSource = bindingSource1;
                this.dataGridView1.Columns["FYQKID"].HeaderText = "ID";
                this.dataGridView1.Columns["BH"].HeaderText = "运送情况编号";
                this.dataGridView1.Columns["FYQK"].HeaderText = "运输情况";
                this.dataGridView1.Columns["ZJM"].HeaderText = "助记码";
            }
            catch (OracleException)
            {
                MessageBox.Show("To run this example, replace the value of the " +
                    "connectionString variable with a connection string that is " +
                    "valid for your system.");
            }

        }
        private void FrmSelectFYQK_Load(object sender, EventArgs e)
        {
            if (GetDatacount("JT_J_FYQK") > 0)
            {
                GetData("select FYQKID,BH,FYQK,ZJM from JT_J_FYQK");
            }
            else
            {
                GetData_nothing("select FYQKID,BH,FYQK,ZJM from JT_J_FYQK");

            }

            this.dataGridView1.ClearSelection();//使dataGridView失去焦点
            this.dataGridView1.TabStop = false;
        }
        private void btnlastpage_Click(object sender, EventArgs e)
        {
            pageCurrent--;
            if (pageCurrent <= 0)
            {
                MessageBox.Show("已经是第一页，请点击“下一页”查看！");
                return;
            }
            else
            {
                nCurrent = pageSize * (pageCurrent - 1);
            }

            LoadData();
        }

        private void btnnextpage_Click(object sender, EventArgs e)
        {
            pageCurrent++;
            if (pageCurrent > pageCount)
            {
                MessageBox.Show("已经是最后一页，请点击“上一页”查看！");
                return;
            }
            else
            {
                nCurrent = pageSize * (pageCurrent - 1);
            }
            LoadData();
        }

        private void btnCanncle_Click(object sender, EventArgs e)
        {
            this.txtBH.Text = "";
            this.txtNo.Text = "";
            this.txtFastcode.Text = "";
            GetData("select FYQKID,BH,FYQK,ZJM from JT_J_FYQK");
            this.dataGridView1.ClearSelection();//使dataGridView失去焦点
            this.dataGridView1.TabStop = false;
            this.btnlastpage.Visible = true;
            this.btnnextpage.Visible = true;
        }

        private void btnCanncelExit_Click(object sender, EventArgs e)
        {
            JT_J_FYQK_id = "";
            this.sClose();
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int c;
            c = this.dataGridView1.CurrentRow.Index;
            JT_J_FYQK_id = this.dataGridView1[0, c].Value.ToString();
            JT_J_FYQK_bh = this.dataGridView1[2, c].Value.ToString();
            this.DialogResult = DialogResult.OK;
            this.sClose();
            this.Close();
        }

        private void btnCanncelExit_Click_1(object sender, EventArgs e)
        {
            JT_J_FYQK_id = "";
            this.sClose();
            this.Close(); 

        }
    }
}
