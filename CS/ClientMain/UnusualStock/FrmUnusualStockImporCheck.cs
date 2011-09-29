using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
 
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using System.Data.OracleClient;
using System.Configuration;

namespace ClientMain
{
    public partial class FrmUnusualStockImporCheck : Form
    {
        private string InputFileName;
        private string InputJTDID;
        public FrmUnusualStockImporCheck()
        {
            InitializeComponent();
        }
        public FrmUnusualStockImporCheck(string filename,string jtdid)
        {
            InitializeComponent();
            InputFileName = filename;
            InputJTDID = jtdid;
        }
        public FrmUnusualStockImporCheck(string filename)
        {
            InitializeComponent();
            InputFileName = filename;
        }
        private DataTable dt;
        private void Crontrol()
        {
            this.txtErroeNum.Text = "";
            this.txtEuuarNum.Text = "";
            this.txtTotalNum.Text = "";
            this.progressBar1.Value = 0;

        }
        private void FrmUnusualStockImporCheck_Load(object sender, EventArgs e)
        {
            Rectangle ScreenArea = System.Windows.Forms.Screen.GetWorkingArea(this);
            int width1 = ScreenArea.Width; //屏幕宽度 
            int height1 = ScreenArea.Height; //屏幕高度
            this.Height = height1;
            Crontrol();
                if(this.Tag.ToString()=="JC_C_YCKC_CHECK")
                  {
                      CheckInputData(InputFileName);
                      LookInputData(InputFileName);
                }
                 else if (this.Tag.ToString() == "JC_G_JTD_CHECK")
               {
                   CheckInputDataJTD(InputFileName);
                   LookInputDataJTD(InputFileName);

                 }

        }
        private int CheckNum(string id)
        {
            int i=0;
            string StrCon = FrmLogin.strCon;
            OracleConnection conn = new OracleConnection(StrCon);
            string count = "select count(0) from JT_J_SPXX where SPXXID='" + id + "'";
            OracleCommand comm = new OracleCommand(count,conn);
            OracleDataReader reader;
            try
            {
                conn.Open();
                reader = comm.ExecuteReader();
                while(reader.Read())
                {
                    i = reader.GetInt32(0);
                }
            }
                catch(Exception ex)
            { throw ex; }
            finally
            { conn.Close(); }
            return i;

        }
        private void WriteExcel(string id,string zt)
        {
            if (!string.IsNullOrEmpty(InputFileName))
            {
                string str = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+InputFileName+";Extended Properties='Excel 8.0;HDR=Yes;IMEX=2;'";
                OleDbConnection OleDbConnectionconn = new OleDbConnection(str);
                
                try 
                {
                    OleDbConnectionconn.Open();
                    OleDbCommand upCmd = new OleDbCommand("update [第一页$] set 检查='" + zt + "'  where 商品信息ID=" + id + "", OleDbConnectionconn);
                    upCmd.ExecuteNonQuery();

                }
                catch(Exception ex)
                { throw ex; }
                    finally
                {
                    OleDbConnectionconn.Close();
                }
            }

            else
            {
                MessageBox.Show("请检查你是不是打开了EXCLE文件或者移动了EXCEL文件");
            }
        }
        private void WriteExcelJTD(string id, string zt)
        {
            if (!string.IsNullOrEmpty(InputFileName))
            {
                string str = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + InputFileName + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=2;'";
                OleDbConnection OleDbConnectionconn = new OleDbConnection(str);

                try
                {
                    OleDbConnectionconn.Open();
                    OleDbCommand upCmd = new OleDbCommand("update [Sheet1$] set 检查='" + zt + "'  where 商品信息ID=" + id + "", OleDbConnectionconn);
                    upCmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                { throw ex; }
                finally
                {
                    OleDbConnectionconn.Close();
                }
            }

            else
            {
                MessageBox.Show("请检查你是不是打开了EXCLE文件或者移动了EXCEL文件");
            }
        }
        private void CheckInputData(string LoadFile)
        {
            string str = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + LoadFile + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=2;'";
            OleDbConnection OleDbConnectionconn = new OleDbConnection(str);
      //      OleDbCommand selectid;
      //      if(this.Tag.ToString()=="JC_C_YCKC_CHECK")
      //      {
       //         selectid = new OleDbCommand("SELECT 商品信息ID FROM [第一页$] where 商品信息ID is not null", OleDbConnectionconn);
       //     }
       //     else if (this.Tag.ToString() == "JC_G_JTD_CHECK")
        //    {
        //        selectid = new OleDbCommand("SELECT 商品信息ID FROM [Sheet1$] where 商品信息ID is not null", OleDbConnectionconn);

       //     }
            OleDbCommand selectid = new OleDbCommand("SELECT 商品信息ID FROM [第一页$] where 商品信息ID is not null", OleDbConnectionconn);
            OleDbDataReader reader;

            try
            {
                OleDbConnectionconn.Open();
                reader = selectid.ExecuteReader();
                while (reader.Read())
                {
                  
                    
                        string inputid = reader.GetValue(0).ToString();
                        if (CheckNum(inputid) == 1)
                        {
                            WriteExcel(inputid, "确认");

                        }
                        else if (CheckNum(inputid) == 0)
                        {
                            WriteExcel(inputid, "错误");
                        }
                    
                   

                }

 
            }
            catch(Exception ex)
            { throw ex; }
            finally
            { OleDbConnectionconn.Close(); }
        }
        private void CheckInputDataJTD(string LoadFile)
        {
            string str = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + LoadFile + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=2;'";
            OleDbConnection OleDbConnectionconn = new OleDbConnection(str);
            //      OleDbCommand selectid;
            //      if(this.Tag.ToString()=="JC_C_YCKC_CHECK")
            //      {
            //         selectid = new OleDbCommand("SELECT 商品信息ID FROM [第一页$] where 商品信息ID is not null", OleDbConnectionconn);
            //     }
            //     else if (this.Tag.ToString() == "JC_G_JTD_CHECK")
            //    {
            //        selectid = new OleDbCommand("SELECT 商品信息ID FROM [Sheet1$] where 商品信息ID is not null", OleDbConnectionconn);

            //     }
            OleDbCommand selectid = new OleDbCommand("SELECT 商品信息ID FROM [Sheet1$] where 商品信息ID is not null", OleDbConnectionconn);
            OleDbDataReader reader;

            try
            {
                OleDbConnectionconn.Open();
                reader = selectid.ExecuteReader();
                while (reader.Read())
                {


                    string inputid = reader.GetValue(0).ToString();
                    if (CheckNum(inputid) == 1)
                    {
                        WriteExcelJTD(inputid, "确认");

                    }
                    else if (CheckNum(inputid) == 0)
                    {
                        WriteExcelJTD(inputid, "错误");
                    }



                }


            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            finally
            { OleDbConnectionconn.Close(); }
        }
        private void LookInputData(string LoadFile)
        {
            string str = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + LoadFile + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1;'";
            OleDbConnection OleDbConnectionconn = new OleDbConnection(str);

            OleDbDataAdapter myCommand = new OleDbDataAdapter("SELECT * FROM [第一页$] where 商品信息ID is not null", str);
            DataSet myDataSet = new DataSet();
            try
            {
                OleDbConnectionconn.Open(); 
                myCommand.Fill(myDataSet);
                dt= new DataTable();
                dt = myDataSet.Tables[0];
           //     this.bindingSource1.DataSource = ;
                this.dataGridView1.DataSource = dt;
                this.txtTotalNum.Text = (this.dataGridView1.RowCount-1).ToString();
                int error = 0;
                for (int i = 0; i < this.dataGridView1.RowCount-1;i++ )
               {
                   if (dt.Rows[i].ItemArray[2].ToString().Equals("错误"))
                  {  
                        this.dataGridView1.Rows[i].Cells[2].Style.BackColor = Color.Red;
                        error = error + 1;
                  }
                }
                this.txtErroeNum.Text = error.ToString();
                this.txtEuuarNum.Text = (Convert.ToInt32(txtTotalNum.Text) - Convert.ToInt32(txtErroeNum.Text)).ToString();
                this.progressBar1.Maximum = Convert.ToInt32(txtTotalNum.Text);
                this.progressBar1.Value = Convert.ToInt32(txtEuuarNum.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                OleDbConnectionconn.Close();
            }
        }
        private void LookInputDataJTD(string LoadFile)
        {
            string str = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + LoadFile + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1;'";
            OleDbConnection OleDbConnectionconn = new OleDbConnection(str);

            OleDbDataAdapter myCommand = new OleDbDataAdapter("SELECT * FROM [Sheet1$] where 商品信息ID is not null", str);
            DataSet myDataSet = new DataSet();
            try
            {
                OleDbConnectionconn.Open();
                myCommand.Fill(myDataSet);
                dt = new DataTable();
                dt = myDataSet.Tables[0];
                //     this.bindingSource1.DataSource = ;
                this.dataGridView1.DataSource = dt;
                this.txtTotalNum.Text = (this.dataGridView1.RowCount - 1).ToString();
                int error = 0;
                for (int i = 0; i < this.dataGridView1.RowCount - 1; i++)
                {
                    if (dt.Rows[i].ItemArray[2].ToString().Equals("错误"))
                    {
                        this.dataGridView1.Rows[i].Cells[2].Style.BackColor = Color.Red;
                        error = error + 1;
                    }
                }
                this.txtErroeNum.Text = error.ToString();
                this.txtEuuarNum.Text = (Convert.ToInt32(txtTotalNum.Text) - Convert.ToInt32(txtErroeNum.Text)).ToString();
                this.progressBar1.Maximum = Convert.ToInt32(txtTotalNum.Text);
                this.progressBar1.Value = Convert.ToInt32(txtEuuarNum.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                OleDbConnectionconn.Close();
            }
        }
        private void InserintoYCKC(string id,int num)
        {
            string strconn = FrmLogin.strCon;
            using (OracleConnection connection = new OracleConnection(strconn))
            {
                OracleCommand cmd = connection.CreateCommand();
                OracleTransaction transaction;
                connection.Open();
                transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);
                cmd.Transaction = transaction;
                try
                {
                    
                    string zt = "0";
                    cmd.CommandText = "INSERT INTO JC_C_YCKC (YCKCID,SPXXID,ZTID,YCCS,CZYID,CZRQ,CLZT) Values(YCKC_SEQ.nextval," + id + "," + FrmLogin.getZTID.ToString() + "," + num + "," + FrmLogin.getUserID.ToString() + ",sysdate," + zt + ")";
                    cmd.ExecuteNonQuery();
                    transaction.Commit();

                }
                catch (OracleException ex)
                {
                    transaction.Rollback();
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();


                }
            }





        }
        private void InserintoJTD(string id, int num)
        {
            string strconn = FrmLogin.strCon;
            using (OracleConnection connection = new OracleConnection(strconn))
            {
                OracleCommand cmd = connection.CreateCommand();
                OracleTransaction transaction;
                connection.Open();
                transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);
                cmd.Transaction = transaction;
                try
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "jc_g_jtdmx_insert";

                    cmd.Parameters.Add("LS_JTDID", OracleType.VarChar).Value = InputJTDID;
                    cmd.Parameters.Add("LS_SPXXID", OracleType.VarChar).Value = id;
                    cmd.Parameters.Add("LS_JTSL", OracleType.Number).Value = num;

                    cmd.Parameters.Add("Descerr", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Message", OracleType.VarChar, 255).Direction = ParameterDirection.Output;

                    cmd.ExecuteNonQuery();
                    transaction.Commit();

                    string alarm = cmd.Parameters["DescErr"].Value.ToString();
                    string mess = cmd.Parameters["Message"].Value.ToString();
                  
                }
                catch (OracleException ex)
                {
                    transaction.Rollback();
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();


                }
            }





        }
        private void btnInport_Click(object sender, EventArgs e)
        {
            if (this.Tag.ToString() == "JC_C_YCKC_CHECK")
            {
                try
                {

                    DataRow[] rows;
                    rows = dt.Select("检查='确认'");
                    foreach (DataRow row in rows)
                    {
                        string id = row.ItemArray[0].ToString();
                        int num;
                        if (row.ItemArray[1] == null)
                        {
                            num = 0;
                        }
                        else
                        {
                            num = Convert.ToInt32(row.ItemArray[1].ToString());
                        }

                        InserintoYCKC(id, num);


                    }
                    MessageBox.Show("已经将正确数据输入完毕");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
            else if (this.Tag.ToString() == "JC_G_JTD_CHECK")
            {
                try
                {

                    DataRow[] rows;
                    rows = dt.Select("检查='确认'");
                     string alarm = "0";
                    foreach (DataRow row in rows)
                    {
                       
                        string id = row.ItemArray[0].ToString();
                        int num;
                        if (row.ItemArray[1] == null)
                        {
                            num = 0;
                        }
                        else
                        {
                            num = Convert.ToInt32(row.ItemArray[1].ToString());
                        }

                        string strconn = FrmLogin.strCon;
                        using (OracleConnection connection = new OracleConnection(strconn))
                        {
                            OracleCommand cmd = connection.CreateCommand();
                            OracleTransaction transaction;
                            connection.Open();
                            transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);
                            cmd.Transaction = transaction;
                            try
                            {

                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.CommandText = "jc_g_jtdmx_insert";

                                cmd.Parameters.Add("LS_JTDID", OracleType.VarChar).Value = InputJTDID;
                                cmd.Parameters.Add("LS_SPXXID", OracleType.VarChar).Value = id;
                                cmd.Parameters.Add("LS_JTSL", OracleType.Number).Value = num;

                                cmd.Parameters.Add("Descerr", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
                                cmd.Parameters.Add("Message", OracleType.VarChar, 255).Direction = ParameterDirection.Output;

                                cmd.ExecuteNonQuery();
                                transaction.Commit();

                                alarm = cmd.Parameters["DescErr"].Value.ToString();
                                string mess = cmd.Parameters["Message"].Value.ToString();
                                if(alarm=="1")
                                {
                                    MessageBox.Show("请检查商品信息ID为" + id + "的输入"+mess);
                                    break;
                                }

                            }
                            catch (OracleException ex)
                            {
                                transaction.Rollback();
                                MessageBox.Show(ex.Message);
                            }
                            finally
                            {
                                connection.Close();


                            }

                        }


                    }
                    if(alarm=="0")
                    {
                        MessageBox.Show("已经将正确数据输入完毕");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }

                    
                }
                catch (Exception ex)
                {
                    throw ex;
                }


            }
          

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
