using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Configuration;
using System.Data.OracleClient;
using System.Globalization;



namespace ClientMain
{
    public partial class FrmUnusualStockInputAdd : DevExpress.XtraEditors.XtraForm
    {
        private string yckc_id;//接受的异常库存ID
        public FrmUnusualStockInputAdd()
        {
            InitializeComponent();
            this.txtSPBH.Focus();
            this.txtSPBH.Validating += new System.ComponentModel.CancelEventHandler(this.txtSPBH_Validating);

        }
        public FrmUnusualStockInputAdd(string yckcid)
        {
            InitializeComponent();
            yckc_id = yckcid;
        }
        private int getCountspidNum()
        {
            int i = 0;
            string StrCon = FrmLogin.strCon;
            string strselect = "select count(SPXXID) from JT_J_SPXX where SPBH='" + txtSPBH.Text.Trim() + "'";
            OracleConnection conn = new OracleConnection(StrCon);
            OracleCommand comm = new OracleCommand(strselect, conn);
            OracleDataReader reader;
            try
            {
                conn.Open();
                reader = comm.ExecuteReader();
                while(reader.Read())
                {
                    i = Convert.ToInt32(reader.GetValue(0).ToString());
                }

            }
            catch(OracleException ex)
            {
                throw ex;
               
            }
            finally
            {
                conn.Close();
 
            }

            return i;
        }
        private void getSPXX(string spbh)
        {
            string StrCon = FrmLogin.strCon;
            OracleConnection conn = new OracleConnection(StrCon);
            string strselect = "select SPXXID,PM,DJ from JT_J_SPXX where SPBH='" + txtSPBH.Text.Trim() + "'";
            OracleCommand comm = new OracleCommand(strselect, conn);
            OracleDataReader reader;
            try
            {
                conn.Open();
                reader = comm.ExecuteReader();
                while(reader.Read())
                {
                    this.txtSPBH.Tag = reader["SPXXID"].ToString();
                    this.txtDJ.Text = reader["DJ"].ToString();
                    this.txtPM.Text = reader["PM"].ToString();
                }
            }
            catch(OracleException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }


 
        }
        private void txtSPBH_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string errorMsg;
            this.txtPM.Clear();
            this.txtDJ.Clear();
            if (string.IsNullOrEmpty(txtSPBH.Text.Trim()))
            {
                errorMsg = "请输入商品编号";
                this.txtSPBH.Focus();
                this.txtPM.Clear();
                this.txtDJ.Clear();
                MessageBox.Show(errorMsg);

            }
            else
            {
                int i = getCountspidNum();//对输入的商品信息编号进行确认
                if(i==0)
                {
                     MessageBox.Show("您输入的商品编号为空号，请到商品信息里确认该编号是否存在");
                    
                }
                    else if(i==1)
                {
                        getSPXX(this.txtSPBH.Text.ToString().Trim());

                }
                else if(i>1)
                {
                    FrmSPXXSelect from=new FrmSPXXSelect(this.txtSPBH.Text.ToString().Trim());
                    if(from.ShowDialog()==DialogResult.OK)
                    {
                        this.txtSPBH.Tag=FrmSPXXSelect.YCspxxds[0].ToString();
                        this.txtPM.Text=FrmSPXXSelect.YCspxxds[1].ToString();
                        this.txtDJ.Text = FrmSPXXSelect.YCspxxds[2].ToString();

                    }

                }



            }



        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void load_ADD()
        {
            this.txtSPBH.Text = "";
            this.txtPM.Text = "";
            this.txtDJ.Text = "";
            this.txtECCS.Text = "";
            this.dateTimePicker1.Value = System.DateTime.Now;
            this.txtZTIDMC.Text = FrmLogin.getAccount.ToString();
            this.txtZTIDMC.Tag = FrmLogin.getZTID.ToString();
            this.txtCZYMC.Text = getczyxm();
            this.txtCZYMC.Tag = FrmLogin.getUserID.ToString();
           // this.txtCZYMC.Text = FrmLogin.getUserID.ToString();
            
 
        }
        private void load_Alter()
        {
            string strconn = FrmLogin.strCon;
            OracleConnection conn = new OracleConnection(strconn);
            string strselect = "select SPXXID,ZTID,YCCS,CZYID,CZRQ,CLZT,ZTIDMC,CZYMC,SPBH,DJ,SPMC from VIEW_JC_C_YCKC where YCKCID='" + yckc_id + "'";
            OracleCommand comm = new OracleCommand(strselect, conn);
            OracleDataReader reader;
            try
            {
                conn.Open();
                reader = comm.ExecuteReader();
                while(reader.Read())
                {
                    this.txtSPBH.Tag = reader["SPXXID"].ToString();
                    this.txtSPBH.Text = reader["SPBH"].ToString();
                    this.txtECCS.Text = reader["YCCS"].ToString();
                    this.txtZTIDMC.Tag = reader["ZTID"].ToString();
                    this.txtZTIDMC.Text = reader["ZTIDMC"].ToString();
                    this.txtDJ.Text = reader["DJ"].ToString();
                    this.txtPM.Text = reader["SPMC"].ToString();
                    this.txtCZYMC.Tag = reader["CZYID"].ToString();
                    this.txtCZYMC.Text = reader["CZYMC"].ToString();
                    this.dateTimePicker1.Value = DateTime.Parse(reader["CZRQ"].ToString());
                }
            }
            catch(OracleException ex)
            { throw ex; }
            finally
            {
                conn.Close();
            }


 
        }
        private void btnControl_LOOK()
        {
            this.btnReset.Visible = false;
            this.btnSaveExit.Visible = false;
            this.btnSaveGoon.Visible = false;
            this.btnAlterExit.Visible = false;
            this.btnReload.Visible = false;
 
 
        }
        private void btnControl_ALTER()
        {
            this.btnReset.Visible = false;
            this.btnSaveExit.Visible = false;
            this.btnSaveGoon.Visible = false;
            this.btnAlterExit.Visible = true;
            this.btnReload.Visible = true;
 
        }
        private void btnControl_ADD()
        {
            this.btnReset.Visible = true;
            this.btnSaveExit.Visible = true;
            this.btnSaveGoon.Visible = true;
            this.btnAlterExit.Visible = false;
            this.btnReload.Visible = false;
        }
        private string getczyxm()
        {
            string czyxm = "";
            string strconn = FrmLogin.strCon;
            string strselect = "select operatorname from base_operator where operatorid='" + FrmLogin.getUserID.ToString() + "'";
            OracleConnection conn = new OracleConnection(strconn);
            OracleCommand comm = new OracleCommand(strselect,conn);
            OracleDataReader reader;
            try
            {
                conn.Open();
                reader = comm.ExecuteReader();
                while(reader.Read())
                {
                    czyxm = reader.GetValue(0).ToString();
                }

            }
            catch(Exception ex)
            {
                throw ex;
            }
                finally
            {
                conn.Close();
            }

            return czyxm;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            load_ADD();

        }
        private void InserintoYCKC()
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
                    string sttime = this.dateTimePicker1.Value.ToShortDateString();
                    string zt="0";
                    cmd.CommandText = "INSERT INTO JC_C_YCKC (YCKCID,SPXXID,ZTID,YCCS,CZYID,CZRQ,CLZT) Values(YCKC_SEQ.nextval," + this.txtSPBH.Tag.ToString() + "," + FrmLogin.getZTID.ToString() + "," + Convert.ToInt32(this.txtECCS.Text.ToString()) + "," + FrmLogin.getUserID.ToString() + ",TO_DATE('" + sttime + "','YYYY-MM-DD ')," + zt + ")";
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
        private void UpdataYCKC()
        {
            string strconn = FrmLogin.strCon;
            OracleConnection conn = new OracleConnection(strconn);
            string sttime = this.dateTimePicker1.Value.ToShortDateString();
            string strupdata = "UPDATE   JC_C_YCKC SET SPXXID='" + this.txtSPBH.Tag.ToString() + "',YCCS=" + Convert.ToInt32(this.txtECCS.Text.ToString().Trim()) + ",CZRQ=TO_DATE('" + sttime + "','YYYY-MM-DD ') where YCKCID='" + yckc_id + "'";
            OracleCommand comm = new OracleCommand(strupdata, conn);
            try
            {
                conn.Open();
                comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
             finally
            {
                conn.Close();
            }

           
 
        }
        private int GetCountExit()
        {
            int i = 0;
            string strconn = FrmLogin.strCon;
            OracleConnection conn = new OracleConnection(strconn);
            string strselect = "select count(*)   JC_C_YCKC where SPXXID='" + this.txtSPBH.Tag.ToString() + "AND CZYID='"+FrmLogin.getUserID.ToString()+"'";
            OracleCommand comm = new OracleCommand(strselect, conn);
            try
            {
                conn.Open();
                OracleDataReader reader = comm.ExecuteReader();
                while(reader.Read())
                {
                    i = Convert.ToInt32(reader.GetValue(0).ToString());
                }

            }
            catch(OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return i;
        }
        private void btnSaveGoon_Click(object sender, EventArgs e)
        {
            bool fgcheck = false;
            if (this.txtSPBH.Text == "")
            {
                fgcheck = false;
                MessageBox.Show("您还没有输入商品编号");
            }
            else if (this.txtECCS.Text == "")
            {
                fgcheck = false;
                MessageBox.Show("您还没有输入可退册数");
            }
            else
            {
                fgcheck = true;
            }
            if (fgcheck == true)
            {
                InserintoYCKC();
                load_ADD();
            }


            
        }

        private void FrmUnusualStockInputAdd_Load(object sender, EventArgs e)
        {
            if(this.Tag.ToString()=="JC_C_YCKC_ADD")
            {
                load_ADD();
                btnControl_ADD();
            }
            else if(this.Tag.ToString()=="JC_C_YCKC_EDIT")
            {
                load_Alter();
                btnControl_ALTER();
            }

            else if (this.Tag.ToString() == "JC_C_YCKC_LOOK")
            {
                load_Alter();
                btnControl_LOOK();

            }

        }

        private void btnSaveExit_Click(object sender, EventArgs e)
        {

            bool fgcheck=false;
            if(this.txtSPBH.Text=="")
            {
                fgcheck = false;
                MessageBox.Show("您还没有输入商品编号");
            }
            else if (this.txtECCS.Text == "")
            {
                fgcheck = false;
                MessageBox.Show("您还没有输入可退册数");
            }
            else
            {
                fgcheck = true;
            }
            if (fgcheck == true)
            {
                if(GetCountExit()>0)
                {
                    MessageBox.Show("您输入的商品信息已经存在，请更改你的信息");
                    UpdataYCKC();
                }
                else
                {
                    InserintoYCKC();
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
 
            }


        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            load_Alter();

        }

        private void btnAlterExit_Click(object sender, EventArgs e)
        {
            UpdataYCKC();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}