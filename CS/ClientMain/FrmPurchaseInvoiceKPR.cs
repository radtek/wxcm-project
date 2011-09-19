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
    public partial class FrmPurchaseInvoiceKPR : Form
    {
        public FrmPurchaseInvoiceKPR()
        {
            InitializeComponent();
        }
        private OracleConnection MyConn = null;
        DataSet ds;
        public string cgfp_operatorid="";//选中的操作员ID号
   //     public string cgfp_operaorname = "";//选中的操作员姓名
        //定义数据库连接
        private void Open()
        {
            string StrCon = ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString;
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
            this.dataGridView1.Columns["OPERATORID"].HeaderText = "ID";
            this.dataGridView1.Columns["operatorno"].HeaderText = "员工编号";
            this.dataGridView1.Columns["operatorname"].HeaderText = "员工姓名";
            this.dataGridView1.Columns["fastcode"].HeaderText = "助记符";

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
                dataAdapter.Fill(ds, "base_operator");
                dtInfo = ds.Tables["base_operator"];
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
                dataAdapter.Fill(ds, "base_operator");
                dtInfo = ds.Tables["base_operator"];
                bindingSource1.DataSource = dtInfo;
                dataGridView1.DataSource = bindingSource1;
                this.dataGridView1.Columns["OPERATORID"].HeaderText = "ID";
                this.dataGridView1.Columns["operatorno"].HeaderText = "员工编号";
                this.dataGridView1.Columns["operatorname"].HeaderText = "员工姓名";
                this.dataGridView1.Columns["fastcode"].HeaderText = "助记符";
            }
            catch (OracleException)
            {
                MessageBox.Show("To run this example, replace the value of the " +
                    "connectionString variable with a connection string that is " +
                    "valid for your system.");
            }
        }
        private void FrmPurchaseInvoiceKPR_Load(object sender, EventArgs e)
        {
            GetData("select OPERATORID,operatorno,operatorname,fastcode from base_operator");
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
            this.txtOperatorName.Text = "";
            this.txtOperatorNo.Text = "";
            this.txtFastcode.Text = "";
            GetData("select OPERATORID,operatorno,operatorname,fastcode from base_operator");
            this.dataGridView1.ClearSelection();//使dataGridView失去焦点
            this.dataGridView1.TabStop = false;
            this.btnlastpage.Visible = true;
            this.btnnextpage.Visible = true;


        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            int c;
            c = this.dataGridView1.CurrentRow.Index;
            cgfp_operatorid = this.dataGridView1[0, c].Value.ToString();
           // cgfp_operaorname = this.dataGridView1[2, c].Value.ToString();
            this.DialogResult = DialogResult.OK;
            this.sClose();
            this.Close();
            
        }

        private void btnLook_Click(object sender, EventArgs e)
        {
            if(this.txtOperatorNo.Text.Trim()!="")
            {
                string strselect="select OPERATORID,operatorno,operatorname,fastcode from base_operator where operatorno LIKE'"+this.txtOperatorNo.Text.Trim().ToString()+"%'";
                GetSelectData(strselect);
                this.dataGridView1.ClearSelection();//使dataGridView失去焦点
                this.dataGridView1.TabStop = false;
                this.btnnextpage.Visible = false;
                this.btnlastpage.Visible = false;

            }
            else if(this.txtOperatorName.Text.Trim()!="")
            {
                string strselect = "select OPERATORID,operatorno,operatorname,fastcode from base_operator where operatorname LIKE'" + this.txtOperatorName.Text.Trim().ToString() + "%'";
                GetSelectData(strselect);
                this.dataGridView1.ClearSelection();//使dataGridView失去焦点
                this.dataGridView1.TabStop = false;
                this.btnnextpage.Visible = false;
                this.btnlastpage.Visible = false;
            }
            else if (this.txtFastcode.Text.Trim() != "")
            {
                string strselect = "select OPERATORID,operatorno,operatorname,fastcode from base_operator where fastcode LIKE'" + this.txtFastcode.Text.Trim().ToString() + "%'";
                GetSelectData(strselect);
                this.dataGridView1.ClearSelection();//使dataGridView失去焦点
                this.dataGridView1.TabStop = false;
                this.btnnextpage.Visible = false;
                this.btnlastpage.Visible = false;
            }
            else
            {
                MessageBox.Show("您没有选择任何查询条件","系统提示");
            }



        }

        private void btnCanncelExit_Click(object sender, EventArgs e)
        {   
            cgfp_operatorid = "";
           // cgfp_operaorname = "";
            this.sClose();
            this.Close(); 
        }



    }
}
