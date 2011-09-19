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
    public partial class MenuEdit : Form
    {
        public MenuEdit(string current_id)
        {
            InitializeComponent();
            this.textBox4.Tag = current_id.ToString();
        }
        private OracleConnection MyConn = null;
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
                string str2 = "select id,MODELNAME,PARENTMODEL,MODEL_DLL,DBTYPE,SYSTYPE from SYS_MODEL where ID='" + this.textBox4.Tag.ToString() + "'";
                OracleCommand comm2 = new OracleCommand(str2, MyConn);
                OracleDataReader reader2 = comm2.ExecuteReader();
                while (reader2.Read())
                {
                    this.combParentModel.Tag = reader2.GetValue(2).ToString();
                    this.txtModelName.Tag = reader2.GetValue(0).ToString();
                    this.txtModelName.Text = reader2.GetValue(1).ToString();
                    this.txtModelFrom.Text = reader2.GetValue(3).ToString();
                    this.txtModelSortno.Text = reader2.GetValue(4).ToString();
                    this.combSystem.Tag = reader2.GetValue(5).ToString();
                }
                bool flag;
                if (this.combParentModel.Tag.ToString() == "0")
                { flag = true; }
                else
                { flag = false; }
                //显示当前父模块
                if (flag)
                {
                    this.combParentModel.Text = "根节点";

                }
                else
                {
                    string select_fathermoudle = "select MODELNAME from SYS_MODEL where ID='" + this.combParentModel.Tag.ToString() + "'";
                    OracleCommand comm5 = new OracleCommand(select_fathermoudle, MyConn);
                    OracleDataReader reader5 = comm5.ExecuteReader();
                    while (reader5.Read())
                    {
                        this.combParentModel.Text = reader5.GetValue(0).ToString();
                    }
                }
                //显示系统类型
                string str3 = "select * from BASE_SYSTYPE ";
                OracleDataAdapter adp3 = new OracleDataAdapter();
                OracleCommand comm3 = new OracleCommand(str3, MyConn);
                adp3.SelectCommand = comm3;
                adp3.Fill(ds1, "BASE_SYSTYPE");

                string select_systype = "select TYPENAME from base_systype where TYPEID='" + this.combSystem.Tag.ToString() + "'";
                OracleCommand comm4 = new OracleCommand(select_systype, MyConn);
                OracleDataReader reader4 = comm4.ExecuteReader();
                while (reader4.Read())
                {
                    this.combSystem.Text = reader4.GetValue(0).ToString();
                }


            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            finally
            { this.sClose(); }

        }
        private void SystemShow()
        {
            try
            {
                this.Open();
                string str1 = "select * from BASE_SYSTYPE ";
                OracleDataAdapter adp1 = new OracleDataAdapter();
                OracleCommand comm1 = new OracleCommand(str1, MyConn);
                adp1.SelectCommand = comm1;
                DataSet ds1 = new DataSet();
                adp1.Fill(ds1, "BASE_SYSTYPE");
                string select_systype = "select TYPEID,TYPENAME from base_systype";
                OracleCommand comm2 = new OracleCommand(select_systype, MyConn);
                OracleDataReader reader2 = comm2.ExecuteReader();
                while (reader2.Read())
                {
                    if (!this.combSystem.Items.Contains(reader2.GetString(1)))
                    {
                        this.combSystem.Items.Add(reader2.GetString(1));
                        // m_Dict.Add(reder1.GetString(1), reder1.GetString(0));
                        this.combSystem.Tag = reader2.GetString(0).ToString();
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
        private void FatherMoudleShow()
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
                string select_moudle = "select ID,MODELNAME from SYS_MODEL";
                OracleCommand comm2 = new OracleCommand(select_moudle, MyConn);
                OracleDataReader reader2 = comm2.ExecuteReader();
                this.combParentModel.Items.Add("根节点");
                this.combParentModel.Tag = "0";
                while (reader2.Read())
                {
                    if (!this.combParentModel.Items.Contains(reader2.GetValue(1)))
                    {
                        this.combParentModel.Items.Add(reader2.GetValue(1));
                        // m_Dict.Add(reder1.GetString(1), reder1.GetString(0));
                        this.combParentModel.Tag = reader2.GetValue(0).ToString();

                    }
                    if (this.combParentModel.Items.Count != 0)
                    {
                        this.combParentModel.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            finally
            { this.sClose(); }
        }
        private void AleartMenu()
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
                string str2 = "update SYS_MODEL set MODELNAME='" + this.txtModelName.Text.Trim().ToString() + "',MODEL_DLL='" + this.txtModelFrom.Text.Trim().ToString() + "',DBTYPE='" + this.txtModelSortno.Text.Trim().ToString() + "',SYSTYPE='" + this.combSystem.Tag.ToString() + "',PARENTMODEL='" + this.combParentModel.Tag.ToString() + "' where id='" + this.textBox4.Tag + "'";
                adp1.UpdateCommand = new OracleCommand(str2, MyConn);
                adp1.UpdateCommand.ExecuteNonQuery();
                adp1.Update(ds1, "SYS_MODEL");

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            finally
            { this.sClose(); }

        }
        private void MenuEdit_Load(object sender, EventArgs e)
        {
            SystemShow();
            FatherMoudleShow();
            InitializeCurrent();
        }





        private void btnExit_Click(object sender, EventArgs e)
        {
            this.sClose();
            this.Close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            SystemShow();
            FatherMoudleShow();
            InitializeCurrent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要保存这个菜单吗", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (this.txtModelName.Text == "")
                {
                    MessageBox.Show("菜单名称为空", "提示", MessageBoxButtons.OK);
                }
                else
                {
                    if (this.txtModelFrom.Text == "")
                    { MessageBox.Show("菜单模块名称为空", "提示", MessageBoxButtons.OK); }
                    else
                    {
                        AleartMenu();
                        this.sClose();
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
        }
    }
}
