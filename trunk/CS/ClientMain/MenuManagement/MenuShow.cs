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
    public partial class MenuShow : Form
    {
        public MenuShow(string current_menuid)
        {
            InitializeComponent();
            this.textBox1.Tag = current_menuid.ToString();
        }
        private OracleConnection MyConn = null;
        // DataSet ds;
        //定义数据库连接
        private void Open()
        {
            string StrCon = FrmLogin.strCon;
            MyConn = new OracleConnection(StrCon);
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
        private void InitializeCurrent()
        {
            try
            {
                this.Open();
                string str1 = "select * from SYS_MODEL ";
                OracleDataAdapter adp1 = new OracleDataAdapter();
                OracleCommand comm1 = new OracleCommand(str1, MyConn);
                adp1.SelectCommand = comm1;
                DataSet ds1 = new DataSet();
                adp1.Fill(ds1, "SYS_MODEL");
                string str2 = "select id,MODELNAME,PARENTMODEL,MODEL_DLL,DBTYPE,SYSTYPE from SYS_MODEL where ID='" + this.textBox1.Tag.ToString() + "'";
                OracleCommand comm2 = new OracleCommand(str2, MyConn);
                OracleDataReader reader2 = comm2.ExecuteReader();
                while (reader2.Read())
                {
                    this.txtParentModel.Tag = reader2.GetValue(2).ToString();
                    this.txtModelName.Text = reader2.GetValue(1).ToString();
                    this.txtModelFrom.Text = reader2.GetValue(3).ToString();
                    this.txtModelSortno.Text = reader2.GetValue(4).ToString();
                    this.txtSystem.Tag = reader2.GetValue(5).ToString();
                }
                bool flag;
                if (this.txtParentModel.Tag.ToString() == "0")
                { flag = true; }
                else
                { flag = false; }
                //显示当前父模块
                if (flag)
                {
                    this.txtParentModel.Text = "根节点";

                }
                else
                {
                    string select_fathermoudle = "select MODELNAME from SYS_MODEL where ID='" + this.txtParentModel.Tag.ToString() + "'";
                    OracleCommand comm5 = new OracleCommand(select_fathermoudle, MyConn);
                    OracleDataReader reader5 = comm5.ExecuteReader();
                    while (reader5.Read())
                    {
                        this.txtParentModel.Text = reader5.GetValue(0).ToString();
                    }
                }
                //显示系统类型
                string str3 = "select * from BASE_SYSTYPE ";
                OracleDataAdapter adp3 = new OracleDataAdapter();
                OracleCommand comm3 = new OracleCommand(str3, MyConn);
                adp3.SelectCommand = comm3;
                adp3.Fill(ds1, "BASE_SYSTYPE");

                string select_systype = "select TYPENAME from base_systype where TYPEID='" + this.txtSystem.Tag.ToString() + "'";
                OracleCommand comm4 = new OracleCommand(select_systype, MyConn);
                OracleDataReader reader4 = comm4.ExecuteReader();
                while (reader4.Read())
                {
                    this.txtSystem.Text = reader4.GetValue(0).ToString();
                }


            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }
        private void MenuShow_Load(object sender, EventArgs e)
        {
            InitializeCurrent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.sClose();
            this.Close();
        }


    }
}
