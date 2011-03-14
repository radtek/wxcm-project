using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;
//using FrmLogin;


namespace ClientMain
{
    public partial class rolemanger : Form
    {

        //定义窗体公用的数据库连接参数
        private OracleConnection role_cnn = null;
      //  private OracleCommand MyComm;
      //  private OracleDataAdapter myAdapter;
       // private OracleDataReader myReader;
      //  private OracleCommandBuilder myCommandBuilder;
     //   private DataSet ds;
     //   private DataTable dt;
      //  private DataRow dr;

        //需要修改的角色的ID传值
        string a = rolemanger.rolemangerroid;
        //定义数据库连接
        private void Open()
        {
            role_cnn = new OracleConnection("Data Source=XINHUA;User Id=xxb;Password=pass;Integrated Security=no;");
            if (role_cnn.State.ToString() != "Open")
                role_cnn.Open();
        }
      //  this.Label1.text=getcount();
      //  this.Label2.text=getUser();
      //  this.Label3.text=getDepartment();
        public rolemanger()
        {
            InitializeComponent();
        }
        public static string rolemangerroid;
        public string get()
        {
            return rolemangerroid;
        }
        private void rolemanger_Load(object sender, EventArgs e)
        {
            string strCon = "Data Source=XINHUA;User Id=xxb;Password=pass;Integrated Security=no;";
            role_cnn = new OracleConnection();
            role_cnn.ConnectionString = strCon;
            String sqlstring1 = "select * from SYS_ROLE";
            DataSet roledataset1 = new DataSet();
            System.Data.OracleClient.OracleDataAdapter roleadapter = new System.Data.OracleClient.OracleDataAdapter(sqlstring1,role_cnn);

            
            try
            {
                role_cnn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            roleadapter.Fill(roledataset1, "SYS_ROLE");
            roledataGridView1.DataSource = roledataset1.Tables["SYS_ROLE"];



        }
        private void roleexitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    //    private void rolemanger_Load(object sender, EventArgs e)
    //    {
    //        // TODO: 这行代码将数据加载到表“dateSet1.SYS_ROLE”中。您可以根据需要移动或删除它。
     //       this.sYS_ROLETableAdapter.Fill(this.dateSet1.SYS_ROLE);

    //    }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void roledelebtn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("确定要删除这个角色吗？","提示",MessageBoxButtons.OKCancel)==DialogResult.OK)
            {
                //删除所选的角色行
                int a;
                a = this.roledataGridView1.CurrentRow.Index;
              //  roledataGridView1.BindingContext[roledataGridView1.DataSource,roledataGridView1.DataMember].RemoveAt(a);
               // DataSet roledataset2 = new DataSet();
              
              //删除选定的列
                string code=this.roledataGridView1[0,a].Value.ToString();

                string roledel = "delete  from sys_role where role_id='" + code + "'";
                OracleCommand command = new OracleCommand(roledel,role_cnn);
                //command.Connection.Open();
                command.ExecuteNonQuery();
               //更新当前数据控件的显示
                String sqlstring1 = "select * from SYS_ROLE";
                System.Data.OracleClient.OracleDataAdapter roleadapter = new System.Data.OracleClient.OracleDataAdapter(sqlstring1, role_cnn);
                DataSet roledataset1 = new DataSet();
                roleadapter.Fill(roledataset1, "SYS_ROLE");
                roledataGridView1.DataSource = roledataset1.Tables["SYS_ROLE"];
              //  String sqlstring1 = "select * from SYS_ROLE";
              //  DataSet roledataset1 = new DataSet();
               // System.Data.OracleClient.OracleDataAdapter roleadapter = new System.Data.OracleClient.OracleDataAdapter(sqlstring1, role_cnn);






                


            }
            
        }

        private void roleadbtn_Click(object sender, EventArgs e)
        {
            RoleAdd roleadd=new RoleAdd();
            roleadd.Show();
            role_cnn.Close();
            

        }

        private void rolecreatebtn_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("确定要创建类似个角色吗？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                //获取选中行的特定值
                int a;
                a = this.roledataGridView1.CurrentRow.Index;
                string code = this.roledataGridView1[0, a].Value.ToString();
                string rolecreate_1 = "select *  from sys_role where role_id='" + code + "'";
                OracleCommand rolect=new OracleCommand(rolecreate_1,role_cnn);
                OracleDataReader roleread;
                roleread = rolect.ExecuteReader();
                int cols = roleread.FieldCount;
                Object[] valuses=new object[cols];
          //      int col_count = roleread.GetValues(valuses);
                DataSet dataset1=new DataSet();
              //  OracleDataAdapter adapter1 = new OracleDataAdapter();
             //   adapter1.Fill(dataset1, "SYS_ROLE");
                //DataRow newrow = new DataRow();
                DataTable  table1=new DataTable();
                //newrow = table1.NewRow();
                //创建新的数组并把特定行的所有值赋予这个数组里
                string[] rolestring;
                rolestring=new string[cols];

                
                while  (roleread.Read())
               

                {
                    for (int i = 0; i < cols; i++)
                    {
                        rolestring[i] = roleread.GetValue(i).ToString();


                    }
                    //绑定要插入的特殊字段数据
                    string rolename = rolestring[1]+"副本";
                    string description=rolestring[3];
                    string likecreate = "insert into sys_role (role_id,role_name,super_id,description) values (seq_sys_role_role_id.nextval,'" + rolename + "','0','" + description + "')";
                    OracleCommand command2 = new OracleCommand(likecreate,role_cnn);
                    command2.ExecuteNonQuery();

                   // command2.ExecuteOracleNonQuery();
                   
                    //role_cnn.Close();

                }
                   roleread.Close();


                   //更新当前数据控件的显示
                   String sqlstring1 = "select * from SYS_ROLE";
                   System.Data.OracleClient.OracleDataAdapter roleadapter = new System.Data.OracleClient.OracleDataAdapter(sqlstring1, role_cnn);
                   DataSet roledataset1 = new DataSet();
                   roleadapter.Fill(roledataset1, "SYS_ROLE");
                   roledataGridView1.DataSource = roledataset1.Tables["SYS_ROLE"];








            }

        }

        private void roleeditbrn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("确定要修改这个角色吗？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int c;
                c = this.roledataGridView1.CurrentRow.Index;
                string code = this.roledataGridView1[0, c].Value.ToString();
                rolemangerroid = code;
               
            RoleEdit RoleEdit = new RoleEdit();
            RoleEdit.Show();
            role_cnn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Open();
            String sqlstring1 = "select * from SYS_ROLE";
            System.Data.OracleClient.OracleDataAdapter roleadapter = new System.Data.OracleClient.OracleDataAdapter(sqlstring1, role_cnn);
            DataSet roledataset1 = new DataSet();
            roleadapter.Fill(roledataset1, "SYS_ROLE");
            roledataGridView1.DataSource = roledataset1.Tables["SYS_ROLE"];

        }
    }
}
