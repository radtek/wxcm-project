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
    public partial class UserManger : Form
    {
        bool m_fgAdd;
        bool m_fgDel;
        bool m_fgUpdate;
        bool m_fgQuery;

        public UserManger(bool fgAdd, bool fgDel, bool fgUpdate, bool fgQuery)
        {
            InitializeComponent();

            m_fgAdd = fgAdd;
            m_fgDel = fgDel;
            m_fgQuery = fgQuery;
            m_fgUpdate = fgUpdate;
        }
        
        private OracleConnection MyConn = null;
    //    private OracleCommand MyComm;
    //    private DataSet ds;
        public static string userwatch;//传递到其他模块的当前用户的ID
        public static string user_watch_name;//传递到其他模块的当前用户的名称
        public static string user_watch_emplyid;//传递到其他模块的当前用户所帮定的员工的姓名ID
        string sourname;
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
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.sClose();
            this.Close();
        }
        //数据绑定
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
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[0].HeaderCell.Value = "用户ID";
                dataGridView1.Columns[0].Width = 80;
                dataGridView1.Columns[1].HeaderCell.Value = "用户名称";
                dataGridView1.Columns[1].Width = 100;
                dataGridView1.Columns[2].HeaderCell.Value = "是否锁定";
                dataGridView1.Columns[2].Width = 90;
                dataGridView1.Columns[4].HeaderCell.Value = "用户描述";
                dataGridView1.Columns[4].Width = 200;
                dataGridView1.Columns[5].HeaderCell.Value = "开始时间";
                dataGridView1.Columns[5].Width = 150;
                dataGridView1.Columns[6].HeaderCell.Value = "结束时间";
                dataGridView1.Columns[6].Width = 150;
                dataGridView1.Columns[7].HeaderCell.Value = "权限ID";
                dataGridView1.Columns[7].Width = 80;
               // dataGridView1.RowCount = 10;
               //dataGridView1.Columns[8].HeaderCell.Value = "其余的备注信息"; 

            }
            catch (OracleException)
            {
                MessageBox.Show("To run this example, replace the value of the " +
                    "connectionString variable with a connection string that is " +
                    "valid for your system.");
            }
        }


        private void UserManger_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingSource1;
            GetData("select * from SYS_USER");

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
                toolStripButton4.Visible = true;
            }
            else
            {
                toolStripButton4.Visible = false;
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

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            if (bindingSource1.Position + 1 < bindingSource1.Count)
                 bindingSource1.MoveNext();

               // Otherwise, move back to the first item.
            else
                bindingSource1.MoveFirst();

            // Force the form to repaint.
               this.Invalidate();
}

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingSource1;
            GetData("select * from SYS_USER");
           // dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells); 

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要删除这个用户吗？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    int a;
                    a = this.dataGridView1.CurrentRow.Index;
                    string code = this.dataGridView1[0, a].Value.ToString();
                    string select_username = this.dataGridView1[1, a].Value.ToString();
                    this.Open();
                    string str1 = "select * from SYS_USER";
                    OracleDataAdapter adp1 = new OracleDataAdapter();
                    OracleCommand comm1 = new OracleCommand(str1, MyConn);
                    adp1.SelectCommand = comm1;
                    DataSet ds1 = new DataSet();
                    adp1.Fill(ds1, "SYS_USER");
                    //删除员工表
                    adp1.DeleteCommand = new OracleCommand("delete from SYS_USER where USERID='" + code + "'", MyConn);
                    adp1.DeleteCommand.ExecuteNonQuery();
                    adp1.Update(ds1, "SYS_USER");
                    dataGridView1.DataSource = bindingSource1;
                    GetData("select * from SYS_USER");
                    //删除员工和部门对照表
                    string str2 = "select * from SYS_USER_DEPARTMENT";
                    OracleDataAdapter adp2 = new OracleDataAdapter();
                    OracleCommand comm2 = new OracleCommand(str2, MyConn);
                    adp2.SelectCommand = comm2;
                    adp2.Fill(ds1, "SYS_USER_DEPARTMENT");
                    adp2.DeleteCommand = new OracleCommand("delete from SYS_USER_DEPARTMENT where USERNAME='" + select_username + "'", MyConn);
                    adp2.DeleteCommand.ExecuteNonQuery();
                    adp2.Update(ds1, "SYS_USER_DEPARTMENT");
                    //删除员工与角色对照表
                    string str3 = "select * from SYS_USER_ROLE";
                    OracleDataAdapter adp3 = new OracleDataAdapter();
                    OracleCommand comm3 = new OracleCommand(str3, MyConn);
                    adp3.SelectCommand = comm3;
                    adp3.Fill(ds1, "SYS_USER_ROLE");
                    adp3.DeleteCommand = new OracleCommand("delete from SYS_USER_ROLE where USERNAME='" + select_username + "'", MyConn);
                    adp3.DeleteCommand.ExecuteNonQuery();
                    adp3.Update(ds1, "SYS_USER_ROLE");
                }
                catch(Exception ex)
                { MessageBox.Show(ex.Message); }
            }

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            int a;
            a = this.dataGridView1.CurrentRow.Index;
            string code = this.dataGridView1[0, a].Value.ToString();
            userwatch = code;
            user_watch_name = this.dataGridView1[1, a].Value.ToString();
            user_watch_emplyid = this.dataGridView1[7, a].Value.ToString();
            UserWatch UserWatch = new UserWatch();
            UserWatch.ShowDialog();
            this.sClose();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            int a;
            a = this.dataGridView1.CurrentRow.Index;
            string code = this.dataGridView1[0, a].Value.ToString();
            sourname=this.dataGridView1[1,a].Value.ToString();
            userwatch = code;
            UserEdit UserEdit = new UserEdit(sourname);
            UserEdit.ShowDialog();
            //this.Show();
          //  this.sClose();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            UserAdd UserAdd = new UserAdd();
            UserAdd.ShowDialog();
            //this.Show();

       
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        }
    }

