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
    public partial class MenuFirstDegreeAdd : Form
    {
        public MenuFirstDegreeAdd()
        {
            InitializeComponent();
        }
        private OracleConnection MyConn = null;
        // DataSet ds;
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
            //  if (ds != null)
            //  { ds.Dispose(); }
            if (MyConn != null & MyConn.State.ToString() != "Closed")
            { MyConn.Close(); }
        }
        private string GetFormName()
        {
            string str1 = ".cs";
            string str2 = txtModelFrom.Text.Trim().ToString();
            string str = str2 + str1;
            return str;
        }//构造模块名称
        private void AddMenu()
        {
            try
            {
                this.Open();
                string sql_insetmenu = "insert into SYS_MODEL (ID,MODELNAME,PARENTMODEL,MODEL_DLL,DBTYPE,SYSTYPE) values(MENU_SEQ.nextval,'" + txtModelName.Text.Trim().ToString() + "','" + 0 + "','" + GetFormName() + "','" + this.txtModelSortno.Text.Trim().ToString() + "','" + this.combSystem.Tag.ToString() + "')";
                string str1 = "select * from SYS_MODEL ";
                OracleDataAdapter adp1 = new OracleDataAdapter();
                OracleCommand comm3 = new OracleCommand(str1, MyConn);
                adp1.SelectCommand = comm3;
                DataSet ds1 = new DataSet();
                adp1.Fill(ds1, "SYS_MODEL");
                adp1.InsertCommand = new OracleCommand(sql_insetmenu, MyConn);
                adp1.InsertCommand.ExecuteNonQuery();
                adp1.Update(ds1, "SYS_MODEL");




            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            finally
            { this.sClose(); }

        }
        private void MenuFirstDegreeAdd_Load(object sender, EventArgs e)
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
                string str2 = "select * from BASE_SYSTYPE ";
                OracleDataAdapter adp2 = new OracleDataAdapter();
                OracleCommand comm2 = new OracleCommand(str2, MyConn);
                adp2.SelectCommand = comm2;
                adp2.Fill(ds1, "BASE_SYSTYPE");
                string select_systype = "select TYPEID,TYPENAME from base_systype";
                OracleCommand comm4 = new OracleCommand(select_systype, MyConn);
                OracleDataReader reader4 = comm4.ExecuteReader();
                while (reader4.Read())
                {
                    if (!this.combSystem.Items.Contains(reader4.GetString(1)))
                    {
                        this.combSystem.Items.Add(reader4.GetString(1));
                        // m_Dict.Add(reder1.GetString(1), reder1.GetString(0));
                        this.combSystem.Tag = reader4.GetString(0).ToString();
                    }
                    if (this.combSystem.Items.Count != 0)
                    {
                        this.combSystem.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            finally
            { this.sClose(); }
        }




        private void btnExit_Click(object sender, EventArgs e)
        {
            this.sClose();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要保存这个菜单吗", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                bool check = true;
                if (this.txtModelName.Text == "")
                {
                    MessageBox.Show("菜单名称为空", "提示", MessageBoxButtons.OK);
                    check = false;

                }
                else if (this.txtModelFrom.Text == "")
                {
                    MessageBox.Show("菜单模块名称为空", "提示", MessageBoxButtons.OK);
                    check = false;

                }
                else
                {
                    check = true;
                }
                if (check == true)
                {
                    AddMenu();
                    this.sClose();
                    this.Close();
                    this.DialogResult = DialogResult.OK;

                }

            }
        }
    }
}
