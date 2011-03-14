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
    public partial class EmpoeeTable : Form
    {
        public EmpoeeTable()
        {
            InitializeComponent();
        }
        private OracleConnection MyConn = null;
        private OracleCommand MyComm;
        private DataSet ds;
        public static string userwatch;
        public static bool i=false;
        

        //定义数据库连接
        private void Open()
        {
            MyConn = new OracleConnection("Data Source=XINHUA;User Id=xxb;Password=pass;Integrated Security=no;");
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
        private void GetData(string selectCommand)
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
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;

                // Resize the DataGridView columns to fit the newly loaded content.
                dataGridView1.AutoResizeColumns(
                    DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                
               
               
               // dataGridView1.Columns[2].HeaderCell.Value = "是否锁定";
              //  dataGridView1.Columns[4].HeaderCell.Value = "用户描述";
               // dataGridView1.Columns[5].HeaderCell.Value = "开始时间";
               // dataGridView1.Columns[6].HeaderCell.Value = "结束时间";
               // dataGridView1.Columns[7].HeaderCell.Value = "权限ID";

            }
            catch (OracleException)
            {
                MessageBox.Show("To run this example, replace the value of the " +
                    "connectionString variable with a connection string that is " +
                    "valid for your system.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lastname = null;
            lastcode = null;
            this.Close();
        }

        public static string lastname;//最终的用户名
        public static string lastcode;//最终的用户ID
        private void EmpoeeTable_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingSource1;
            GetData("select * from SYS_EMPLOYEES");
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a;
            a = this.dataGridView1.CurrentRow.Index;
            string code = this.dataGridView1[0, a].Value.ToString();
            lastcode = code;
            this.Open();
            string str1 = "select * from SYS_EMPLOYEES ";
            OracleDataAdapter adp1 = new OracleDataAdapter();
            OracleCommand comm3 = new OracleCommand(str1, MyConn);
            adp1.SelectCommand = comm3;
            DataSet ds1 = new DataSet();
            adp1.Fill(ds1, "SYS_EMPLOYEES");
            DataTable dt1 = ds1.Tables["SYS_EMPLOYEES"];
            DataView dv1 = new DataView(dt1);
            dv1.RowFilter = "EMPLOYEEID='" + code + "'";
            foreach (DataRowView dr in dv1)
            {
                string Currname = dr.Row["NAME"].ToString();
                lastname = Currname;
            }
            this.textBox1.Text = lastname;


        }
        private void NameClear()
        {
            this.textBox1.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.NameClear();
        }
        //获得当前窗体的用户名的值 
        private string getname()
        {
            return this.textBox1.Text.Trim();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (getname() == "")
            {
                MessageBox.Show("您没有选择员工，请重选或者直接退出", "警告");
            }
            else
            {
                i = true;
                this.Close();
            }
            
        }
    }
}
