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
    public partial class Form1 : Form
    {
        bool m_fgAdd;
        bool m_fgDel;
        bool m_fgUpdate;
        bool m_fgQuery;

        public Form1(bool fgAdd, bool fgDel, bool fgUpdate, bool fgQuery)
        {
            InitializeComponent();

            m_fgAdd = fgAdd;
            m_fgDel = fgDel;
            m_fgQuery = fgQuery;
            m_fgUpdate = fgUpdate;
        }
        private OracleConnection MyConn = null;
        private OracleCommand MyComm;
        private DataSet ds;
        public static string userwatch;
        string sourname;
        public static string rolemangerroid;
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
            //  if (ds != null)
            //  { ds.Dispose(); }
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
               // dataGridView1.AutoResizeColumns(
               //     DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                dataGridView1.Columns[0].HeaderCell.Value = "角色ID";
                dataGridView1.Columns[0].Width = 100;
                dataGridView1.Columns[1].HeaderCell.Value = "角色名称";
                dataGridView1.Columns[1].Width = 200;
                dataGridView1.Columns[2].Visible = false;
                //dataGridView1.Columns[2].Width = 80;
                dataGridView1.Columns[3].HeaderCell.Value = "角色描述 ";
                dataGridView1.Columns[3].Width = 300;
                dataGridView1.Columns[4].HeaderCell.Value = "角色状态";
                dataGridView1.Columns[4].Width = 100;
                dataGridView1.Columns[5].HeaderCell.Value = "结束时间";
                dataGridView1.Columns[5].Width = 100;
               // dataGridView1.Columns[5].HeaderCell.Value = "结束时间";
               // dataGridView1.Columns[5].Width = 180;
               // dataGridView1.Columns[5].HeaderCell.Value = "结束时间";
               // dataGridView1.Columns[5].Width = 180;



            }
            catch (OracleException)
            {
                MessageBox.Show("To run this example, replace the value of the " +
                    "connectionString variable with a connection string that is " +
                    "valid for your system.");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingSource1;
            GetData("select * from SYS_ROLE");

            if (m_fgAdd)
            {
                toolStripButton1.Visible = true;
            }
            else
            {
                toolStripButton1.Visible = false;
            }

            if (m_fgDel)
            {
                toolStripButton3.Visible = true;
            }
            else
            {
                toolStripButton3.Visible = false;
            }

            if (m_fgUpdate)
            {
                toolStripButton2.Visible = true;
            }
            else
            {
                toolStripButton2.Visible = false;
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingSource1;
            GetData("select * from SYS_ROLE");
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要删除这个角色吗？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                //删除所选的角色行
                try
                {
                    int a;
                    a = this.dataGridView1.CurrentRow.Index;
                    //删除选定的列
                    string code = this.dataGridView1[0, a].Value.ToString();
                    string roledel = "delete  from sys_role where role_id='" + code + "'";
                    this.Open();
                    string str1 = "select * from SYS_ROLE";
                    OracleDataAdapter adp1 = new OracleDataAdapter();
                    OracleCommand comm1 = new OracleCommand(str1, MyConn);
                    adp1.SelectCommand = comm1;
                    DataSet ds1 = new DataSet();
                    adp1.Fill(ds1, "SYS_ROLE");
                    adp1.DeleteCommand = new OracleCommand(roledel, MyConn);
                    adp1.DeleteCommand.ExecuteNonQuery();
                    adp1.Update(ds1, "SYS_ROLE");

                    string str2 = "select * from SYS_ROLE_MODULE";
                    OracleDataAdapter adp2 = new OracleDataAdapter();
                    OracleCommand comm2 = new OracleCommand(str2, MyConn);
                    adp2.SelectCommand = comm2;
                   // DataSet ds1 = new DataSet();
                    adp2.Fill(ds1, "SYS_ROLE_MODULE");
                    string rolemoudle = "delete  from SYS_ROLE_MODULE where role_id='" + code + "'";
                    adp2.DeleteCommand = new OracleCommand(rolemoudle, MyConn);
                    adp2.DeleteCommand.ExecuteNonQuery();
                    adp2.Update(ds1, "SYS_ROLE_MODULE");

                    string str3 = "select * from SYS_ROLE_MODULE_ACTION";
                    OracleDataAdapter adp3 = new OracleDataAdapter();
                    OracleCommand comm3 = new OracleCommand(str3, MyConn);
                    adp3.SelectCommand = comm3;
                    // DataSet ds1 = new DataSet();
                    adp3.Fill(ds1, "SYS_ROLE_MODULE_ACTION");
                    string rolemoudleaction = "delete  from SYS_ROLE_MODULE_ACTION where role_id='" + code + "'";
                    adp3.DeleteCommand = new OracleCommand(rolemoudleaction, MyConn);
                    adp3.DeleteCommand.ExecuteNonQuery();
                    adp3.Update(ds1, "SYS_ROLE_MODULE_ACTION");
                   
                    dataGridView1.DataSource = bindingSource1;
                    GetData("select * from SYS_ROLE");
                }
                catch(Exception ex)
                { MessageBox.Show(ex.Message); }
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要修改这个角色吗？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int c;
                c = this.dataGridView1.CurrentRow.Index;
                string code = this.dataGridView1[0, c].Value.ToString();
                rolemangerroid = code;

                RoleEdit RoleEdit = new RoleEdit();
                RoleEdit.Show();
                this.sClose();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            RoleAdd roleadd = new RoleAdd();
            roleadd.Show();
            this.sClose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {

        }

    
    }
}
