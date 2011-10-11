using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;
using System.Configuration;
using DevExpress.XtraEditors;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System.IO;
 

namespace ClientMain
{
    public partial class FrmUnusualStockReturnsAdd : Form
    {
        GridCheckMarksSelection selection;
        const int MAXROWCOUNT = 50000;
        Int64 JTSL = 0;
        double JTMY = 0;
        double JTSY = 0;
        double DJ = 0;
        // private string StrCon = FrmLogin.strCon;
        private string StrCon = FrmLogin.strDataCent;
        public FrmUnusualStockReturnsAdd()
        {
            InitializeComponent();
            //  XpoDefault.ConnectionString = OracleConnectionProvider.GetConnectionString("XINHUA", "xxb", "pass");
            XpoDefault.ConnectionString = FrmLogin.xpoDataCentStr;
            selection = new GridCheckMarksSelection(gridView1);
            selection.CheckMarkColumn.VisibleIndex = 0;
            xpServerCollectionSource1.FixedFilterString = "[JTDMXID] Is Null";
            
            this.txtSH.Validating += new System.ComponentModel.CancelEventHandler(this.txtSH_Validating);
          //  this.txtCS.GotFocus+=new EventHandler(txtCS_GotFocus);
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            this.gridView1.CustomDrawFooterCell += new DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventHandler(this.gridView1_CustomDrawFooterCell);
            this.gridView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gridView1_MouseUp);
            
        }

        public FrmUnusualStockReturnsAdd(string jtdid)
        {
            InitializeComponent();
            //  XpoDefault.ConnectionString = OracleConnectionProvider.GetConnectionString("XINHUA", "xxb", "pass");
            XpoDefault.ConnectionString = FrmLogin.xpoDataCentStr;
            selection = new GridCheckMarksSelection(gridView1);
            selection.CheckMarkColumn.VisibleIndex = 0;
            xpServerCollectionSource1.FixedFilterString = "[JTDID] = \'" + jtdid + "\'";
            this.txtJTDH.Tag = jtdid;

            this.txtSH.Validating += new System.ComponentModel.CancelEventHandler(this.txtSH_Validating);
            //  this.txtCS.GotFocus+=new EventHandler(txtCS_GotFocus);
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            this.gridView1.CustomDrawFooterCell += new DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventHandler(this.gridView1_CustomDrawFooterCell);
            this.gridView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gridView1_MouseUp);
        }
        private void gridView1_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator & e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString().Trim();
            }
        }
        private void vDrawFootCell(FooterCellCustomDrawEventArgs e, DevExpress.XtraGrid.Columns.GridColumn col, string strSum)
        {
            if (e.Column == col)
            {
                e.Painter.DrawObject(e.Info);
                Rectangle r = e.Info.Bounds;
                string text = e.Info.DisplayText;
                e.Info.Bounds = new Rectangle(e.Info.Bounds.Left, e.Info.Bounds.Bottom + 1, e.Info.Bounds.Width, e.Info.Bounds.Height);
                e.Info.DisplayText = strSum;
                e.Painter.DrawObject(e.Info);
                e.Handled = true;
                e.Info.Bounds = r;
                e.Info.DisplayText = text;
            }
        }
        private void gridView1_CustomDrawFooterCell(object sender, FooterCellCustomDrawEventArgs e)
        {
            vDrawFootCell(e, colJTDHZTMC, "选计：");
            vDrawFootCell(e, colJTSL, JTSL.ToString());
            vDrawFootCell(e, colJTMY, JTMY.ToString("F2"));
            vDrawFootCell(e, colJTSY, JTSY.ToString("F2"));
            vDrawFootCell(e, colDJ, DJ.ToString("F2"));


        }
        private void gridView1_MouseUp(object sender, MouseEventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));
            if ((hitInfo.Column != null) && (hitInfo.Column.GetCaption() == "选择"))
            {
                if (hitInfo.InColumn)
                {
                    if (selection.SelectedCount == view.DataRowCount)
                    {
                        JTSL = Convert.ToInt64(colJTSL.SummaryText);
                        JTMY = Convert.ToDouble(colJTMY.SummaryText);
                        JTSY = Convert.ToDouble(colJTSY.SummaryText);
                        DJ = Convert.ToDouble(colDJ.SummaryText);

                    }
                    else
                    {
                        DJ = 0;
                        JTSL = 0;
                        JTMY = 0;
                        JTSY = 0;

                    }

                }
                if (hitInfo.InRowCell)
                {
                    if (selection.IsRowSelected(hitInfo.RowHandle))
                    {
                        JTSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colJTSL));
                        JTMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJTMY));
                        JTSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJTSY));

                        DJ += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colDJ));


                    }
                    else
                    {
                        JTSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colJTSL));
                        JTMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJTMY));
                        JTSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJTSY));

                        DJ -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colDJ));

                    }
                }
            }

        }
        private string getczyxm()
        {
            string czyxm = "";
            string strselect = "select operatorname from base_operator where operatorid='" + FrmLogin.getUserID.ToString() + "'";
            OracleConnection conn = new OracleConnection(StrCon);
            OracleCommand comm = new OracleCommand(strselect, conn);
            OracleDataReader reader;
            try
            {
                conn.Open();
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    czyxm = reader.GetValue(0).ToString();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }

            return czyxm;
        }
        private void Load_Content_ADD()
        {
            this.txtBZ.Text = "";
            this.txtCS.Text = "";
            this.txtJTDH.Text = "";
            this.txtSH.Text = "";
            this.txtSM.Text = "";

            this.txtPZS.Text = "0";
            this.txtZSL.Text = "0";
            this.txtZSY.Text = "0.00";
            this.txtZMY.Text = "0.00";

            this.txtZTID.Text = FrmLogin.getAccount.ToString();
            this.txtZTID.Tag = FrmLogin.getZTID.ToString();
            this.txtCZY.Text = getczyxm();
            this.txtCZY.Tag = FrmLogin.getUserID.ToString();
            this.txtJTBM.Text = FrmLogin.getDeptName.ToString();
            this.txtJTBM.Tag = FrmLogin.getDeptID.ToString();
            this.txtGYS.Text = "安徽新华图书音像连锁有限公司";
            this.txtGYS.Tag = "306";
            this.txtZT.Text = "录入";
            this.txtZT.Tag="02";
            this.comboxSL.Text = "13";



            


        }
        private void Load_Control_Add()
        {
            this.btnDeleteDir.Visible = false;
            this.btnSaveGoonExit.Visible = false;

        }
        private void Load_Control_Edit()
        {
            this.btnSaveExit.Visible = false;
            this.btnSaveGoonExit.Visible = true;
            this.btnDeleteDir.Visible = true;
            this.btnSaveGoon.Visible = false;
            this.txtBZ.ReadOnly = false;
        }
        private void Load_Content_Edit()
        {
            string strselect = "select JTDH,GYSID,GYSMC,CZYID,CZYMC,JTPZS,JTZSL,JTZMY,JTZSY,ZTID,ZTIDMC,SL,ZT,ZTMC,JTBMID,JTBMMC,BZ from view_jc_g_jtd where JTDID='" + this.txtJTDH.Tag.ToString() + "'";
            OracleConnection conn = new OracleConnection(StrCon);
            OracleCommand comm = new OracleCommand(strselect, conn);
            OracleDataReader reader;
            try
            {
                conn.Open();
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    this.txtJTDH.Text = reader["JTDH"].ToString();
                    this.txtGYS.Tag = reader["GYSID"].ToString();
                    this.txtGYS.Text = reader["GYSMC"].ToString();
                    this.txtCZY.Tag = reader["CZYID"].ToString();
                    this.txtCZY.Text = reader["CZYMC"].ToString();
                    this.txtPZS.Text = reader["JTPZS"].ToString();
                    this.txtZSL.Text = reader["JTZSL"].ToString();
                    this.txtZMY.Text = reader["JTZMY"].ToString();
                    this.txtZSY.Text = reader["JTZSY"].ToString();
                    this.txtZTID.Tag = reader["ZTID"].ToString();
                    this.txtZTID.Text = reader["ZTIDMC"].ToString();
                    this.comboxSL.Text=reader["SL"].ToString();
                    this.txtZT.Tag = reader["ZT"].ToString();
                    this.txtZT.Text = reader["ZTMC"].ToString();
                    this.txtJTBM.Tag = reader["JTBMID"].ToString();
                    this.txtJTBM.Text = reader["JTBMMC"].ToString();
                    this.txtBZ.Text=reader["BZ"].ToString();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }

            this.gridView1.BestFitColumns();

             
        }
        private void Load_Control_LOOK()
        {
            this.btnBillReset.Visible = false;
            this.btnDeleteDir.Visible = false;
            this.btnDirReset.Visible = false;
            this.btnDirSaveGoon.Visible = false;
            this.btnSaveExit.Visible = false;
            this.btnSelectDepar.Visible = false;
            this.txtBZ.ReadOnly = true;
            this.btnSaveExit.Visible = false;
            this.btnSaveGoon.Visible = false;
            this.btnSaveGoonExit.Visible = false;
            this.txtSH.ReadOnly = true;
            this.txtCS.ReadOnly = true;
           
        }
        private void Load_Content_LOOK()
        {
            Load_Content_Edit();
        }

        private void FrmUnusualStockReturnsAdd_Load(object sender, EventArgs e)
        {
            if(this.Tag.ToString()=="JC_G_JTD_ADD")
            {
                Load_Content_ADD();
                Load_Control_Add();
            }
            else if (this.Tag.ToString() == "JC_G_JTD_EDIT")
            {
                Load_Control_Edit();
                Load_Content_Edit();
            }
            else if (this.Tag.ToString() == "JC_G_JTD_LOOK")
            {
                Load_Control_LOOK();
                Load_Content_LOOK();
            }
        }

        private void btnSaveExit_Click(object sender, EventArgs e)
        {
            using (OracleConnection connection = new OracleConnection(StrCon))
            {
                OracleCommand cmd = connection.CreateCommand();
                OracleTransaction transaction;
                connection.Open();
                transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);
                cmd.Transaction = transaction;
                try 
                {


                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "jc_g_jtd_insert";

                    cmd.Parameters.Add("LS_GYSID", OracleType.VarChar).Value = this.txtGYS.Tag.ToString();
                    cmd.Parameters.Add("LS_JTBMID", OracleType.VarChar).Value = this.txtJTBM.Tag.ToString();
                    cmd.Parameters.Add("LS_CZYID", OracleType.VarChar).Value = this.txtCZY.Tag.ToString();
                    cmd.Parameters.Add("LS_ZTID", OracleType.VarChar).Value = this.txtZTID.Tag.ToString();
                    cmd.Parameters.Add("LS_SL", OracleType.VarChar).Value = this.comboxSL.Text.ToString();
                    cmd.Parameters.Add("LS_BZ", OracleType.VarChar).Value = this.txtBZ.Text.ToString();

                    cmd.Parameters.Add("LS_JTDID", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("LS_JTDH", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Descerr", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Message", OracleType.VarChar, 255).Direction = ParameterDirection.Output;


                    cmd.ExecuteNonQuery();
                    transaction.Commit();


                    this.txtJTDH.Tag = cmd.Parameters["LS_JTDID"].Value.ToString();
                    this.txtJTDH.Text = cmd.Parameters["LS_JTDH"].Value.ToString();

                    xpServerCollectionSource1.FixedFilterString = "[JTDID] = \'" + this.txtJTDH.Tag.ToString() + "\'";
                    unitOfWork1.DropIdentityMap();

                    xpServerCollectionSource1.Reload();

                    MessageBox.Show(cmd.Parameters["Message"].Value.ToString());
                }
                catch (OracleException ex)
                {
                  transaction.Rollback();
                  MessageBox.Show(ex.Message); 
                }
                finally
                {
                    connection.Close();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    
                }

            }

        }

        private void btnSaveGoon_Click(object sender, EventArgs e)
        {
            using (OracleConnection connection = new OracleConnection(StrCon))
            {
                OracleCommand cmd = connection.CreateCommand();
                OracleTransaction transaction;
                connection.Open();
                transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);
                cmd.Transaction = transaction;
                try
                {


                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "jc_g_jtd_insert";

                    cmd.Parameters.Add("LS_GYSID", OracleType.VarChar).Value = this.txtGYS.Tag.ToString();
                    cmd.Parameters.Add("LS_JTBMID", OracleType.VarChar).Value = this.txtJTBM.Tag.ToString();
                    cmd.Parameters.Add("LS_CZYID", OracleType.VarChar).Value = this.txtCZY.Tag.ToString();
                    cmd.Parameters.Add("LS_ZTID", OracleType.VarChar).Value = this.txtZTID.Tag.ToString();
                    cmd.Parameters.Add("LS_SL", OracleType.VarChar).Value = this.comboxSL.Text.ToString();
                    cmd.Parameters.Add("LS_BZ", OracleType.VarChar).Value = this.txtBZ.Text.ToString();

                    cmd.Parameters.Add("LS_JTDID", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("LS_JTDH", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Descerr", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Message", OracleType.VarChar, 255).Direction = ParameterDirection.Output;


                    cmd.ExecuteNonQuery();
                    transaction.Commit();


                    this.txtJTDH.Tag = cmd.Parameters["LS_JTDID"].Value.ToString();
                    this.txtJTDH.Text = cmd.Parameters["LS_JTDH"].Value.ToString();

                    xpServerCollectionSource1.FixedFilterString = "[JTDID] = \'" + this.txtJTDH.Tag.ToString() + "\'";
                    unitOfWork1.DropIdentityMap();

                    xpServerCollectionSource1.Reload();

                    MessageBox.Show(cmd.Parameters["Message"].Value.ToString());
                }
                catch (OracleException ex)
                {
                    transaction.Rollback();
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                    this.btnSaveGoonExit.Visible = true;
                    this.btnSaveExit.Visible = false;
                    this.btnSaveGoon.Visible = false;
                    this.btnDeleteDir.Visible = true;
                    this.txtBZ.ReadOnly = true;
                  //  this.comboxSL.SuspendLayout();

                }

            }
        }
        private int getCountspidNum()
        {
            int i = 0;
            string strselect = "select count(SPXXID) from JT_J_SPXX where SPBH='" + txtSH.Text.Trim() + "'";
            OracleConnection conn = new OracleConnection(StrCon);
            OracleCommand comm = new OracleCommand(strselect, conn);
            OracleDataReader reader;
            try
            {
                conn.Open();
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    i = Convert.ToInt32(reader.GetValue(0).ToString());
                }

            }
            catch (OracleException ex)
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
            OracleConnection conn = new OracleConnection(StrCon);
            string strselect = "select SPXXID,PM from JT_J_SPXX where SPBH='" + txtSH.Text.Trim() + "'";
            OracleCommand comm = new OracleCommand(strselect, conn);
            OracleDataReader reader;
            try
            {
                conn.Open();
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    this.txtSH.Tag = reader["SPXXID"].ToString();
                    this.txtSM.Text = reader["PM"].ToString();
                }
            }
            catch (OracleException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }



        }//从商品编号获取商品ID
        private void txtSH_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
          //  string errorMsg;
            this.txtSM.Text = "";
            this.txtCS.Text="";
       //     if (string.IsNullOrEmpty(txtSH.Text.Trim()))
       //     {
      //          errorMsg = "请输入商品编号";
             //   this.txtSH.Focus();
      //          this.txtSM.Clear();
      //          this.txtCS.Clear();
       //         MessageBox.Show(errorMsg);
//
      //      }
     //       else
      //      {
    
            
                int i = getCountspidNum();//对输入的商品信息编号进行确认
                if (i == 0)
                {
                    this.txtSM.Tag = "error";
                   // MessageBox.Show("您输入的商品编号为空号，请到商品信息里确认该编号是否存在");

                }
                else if (i == 1)
                {
                    getSPXX(this.txtSH.Text.ToString().Trim());
                    this.txtSM.Tag = "right";
                }
                else if (i > 1)
                {
                    FrmSPXXSelect from = new FrmSPXXSelect(this.txtSH.Text.ToString().Trim());
                    if (from.ShowDialog() == DialogResult.OK)
                    {
                        this.txtSM.Tag = "right";
                        this.txtSH.Tag = FrmSPXXSelect.YCspxxds[0].ToString();
                        this.txtSM.Text = FrmSPXXSelect.YCspxxds[1].ToString();
                        // this.txtDJ.Text = FrmSPXXSelect.YCspxxds[2].ToString();

                    }

                }

            
              


         //   }



        }
   //     private void txtCS_GotFocus(object sender, EventArgs e)
      //  {
     //       if (this.txtSM.Tag.ToString() == "error")
      //      {
      //          if (MessageBox.Show("您所输入的商品编号不存在，请重新输入", "提示", MessageBoxButtons.OK) == DialogResult.OK)
       //         {
                    
       //             this.txtSH.Focus();
      //          }
      //      }
      //  }

        private void btnDirReset_Click(object sender, EventArgs e)
        {
            this.txtSH.Clear();
            this.txtSM.Clear();
            this.txtCS.Clear();
        }
        private void TxtAlter()
        {
            OracleConnection connection = new OracleConnection(StrCon);
            string select = "select JTPZS,JTZSL,JTZMY,JTZSY  from  JC_G_JTD  where JTDID='" + this.txtJTDH.Tag.ToString() + "'";
            OracleCommand comm = new OracleCommand(select,connection);
            OracleDataReader reader;
            try
            {
                connection.Open();
                    reader=comm.ExecuteReader();
                while(reader.Read())
                {
                    this.txtPZS.Text = reader["JTPZS"].ToString();
                    this.txtZSL.Text = reader["JTZSL"].ToString();
                    this.txtZMY.Text = reader["JTZMY"].ToString();
                    this.txtZSY.Text = reader["JTZSY"].ToString();

                }

            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
                finally
            {
                connection.Close();
            }


 
        }//将明细单的价格数量传递给面板上的文本控件
        private void btnDirSaveGoon_Click(object sender, EventArgs e)
        {
            bool fgChecck = false;
            bool fgCheckNum = true;
            try
            {
                Convert.ToInt32(this.txtCS.Text.ToString());
            }
             catch(Exception ex)
            {
                fgCheckNum = false;
                MessageBox.Show("册数请输入数字"+ex.Message);

            }

            if (this.txtSM.Tag.ToString() == "error")
            {
                fgChecck = false;
                MessageBox.Show("你输入的图书编号有错误");
            }
            else if (string.IsNullOrEmpty(this.txtJTDH.Text))
            {
                fgChecck = false;
                MessageBox.Show("你还没有输入进退单");

            }
            else
            {
                fgChecck = true;
            }
            if(fgChecck==true&&fgCheckNum==true)
            {
                using (OracleConnection connection = new OracleConnection(StrCon))
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

                        cmd.Parameters.Add("LS_JTDID", OracleType.VarChar).Value = this.txtJTDH.Tag.ToString();
                        cmd.Parameters.Add("LS_SPXXID", OracleType.VarChar).Value = this.txtSH.Tag.ToString();
                        cmd.Parameters.Add("LS_JTSL", OracleType.Number).Value = Convert.ToInt32(this.txtCS.Text.ToString());

                        cmd.Parameters.Add("Descerr", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("Message", OracleType.VarChar, 255).Direction = ParameterDirection.Output;


                        cmd.ExecuteNonQuery();
                        transaction.Commit();


                        xpServerCollectionSource1.FixedFilterString = "[JTDID] = \'" + this.txtJTDH.Tag.ToString() + "\'";
                        unitOfWork1.DropIdentityMap();

                        xpServerCollectionSource1.Reload();
                        this.gridView1.BestFitColumns();
                        MessageBox.Show(cmd.Parameters["Message"].Value.ToString());
                    }
                    catch (OracleException ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                        this.btnSaveGoonExit.Visible = true;
                        this.btnSaveExit.Visible = false;
                        this.btnSaveGoon.Visible = false;
                        this.btnDeleteDir.Visible = true;
                        this.txtBZ.ReadOnly = true;
                        //  this.comboxSL.SuspendLayout();
                        TxtAlter();

                    }

                }
            }

        }
        private void UpdataJTD()
        {
            OracleConnection conn = new OracleConnection(StrCon);
            string strupdata = "UPDATE JC_G_JTD SET GYSID='"+this.txtGYS.Tag.ToString()+"',SL='"+this.comboxSL.Text.ToString()+"',BZ='"+this.txtBZ.Text.ToString()+"' WHERE JTDID='"+this.txtJTDH.Tag.ToString()+"'";
            OracleCommand comm = new OracleCommand(strupdata, conn);
            try
            {
                conn.Open();
                comm.ExecuteNonQuery();
            }
            catch(OracleException ex )
            {
                throw ex;
            }
                finally
            {
                conn.Close();
            }
 
        }
        private void btnSaveGoonExit_Click(object sender, EventArgs e)
        {
            if (this.Tag.ToString() == "JC_G_JTD_EDIT")
            {
                UpdataJTD();
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBillReset_Click(object sender, EventArgs e)
        {
            if (this.Tag.ToString() == "JC_G_JTD_ADD")
            {
                if (!string.IsNullOrEmpty(this.txtJTDH.Text))
                {
                    MessageBox.Show("已经生成了进退单无法重置");
                }
                else
                {
                    Load_Content_ADD();
                    Load_Control_Add();
 
                }
            }
            else if (this.Tag.ToString() == "JC_G_JTD_EDIT")
            {
                Load_Control_Edit();
                Load_Content_Edit();
            }
        }

        private void btnExportTable_Click(object sender, EventArgs e)
        {
            if (gridView1.DataRowCount > MAXROWCOUNT)
            {
                MessageBox.Show("记录数超过50000条，请缩小查找范围后再导出！");
            }
            else
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "XLS文件|*.xls";
                saveDialog.Title = "导出Excel文件";
                saveDialog.DefaultExt = "xls";
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    gridView1.Columns["CheckMarkSelection"].Visible = false;

                    gridView1.SelectAll();
                    gridView1.ExportToXls(saveDialog.FileName);

                    gridView1.Columns["CheckMarkSelection"].Visible = true;
                    gridView1.Columns["CheckMarkSelection"].VisibleIndex = 0;

                    MessageBox.Show("导出成功！");

                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            gridView1.Columns["CheckMarkSelection"].Visible = false;

            gridView1.SelectAll();
            gridControl1.ShowPrintPreview();

            gridView1.Columns["CheckMarkSelection"].Visible = true;
            gridView1.Columns["CheckMarkSelection"].VisibleIndex = 0;
        }

        private void btnDeleteDir_Click(object sender, EventArgs e)
        {
            if (selection.SelectedCount == 0)
            {
                MessageBox.Show("还没有选择明细单");
            }
            else
            {
                using (OracleConnection connection = new OracleConnection(StrCon))
                {
                    connection.Open();
                    string alarm = "0";
                    for (int i = 0; i < selection.SelectedCount; ++i)
                    {
                        OracleTransaction transaction;
                        OracleCommand cmd = connection.CreateCommand();
                        transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);
                        cmd.Transaction = transaction;

                        int RowIndex = selection.GetSelectedRowIndex(i);
                        int RowHandle = gridView1.GetRowHandle(RowIndex);
                        try
                        {
                            string strJTDMXID = gridView1.GetRowCellDisplayText(RowHandle, colJTDMXID).ToString();
                            string strJTDID = gridView1.GetRowCellDisplayText(RowHandle, colJTDID).ToString();
                            string strSPMC = gridView1.GetRowCellDisplayText(RowHandle, colSPMC).ToString();
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.CommandText = "jc_g_jtdmx_delete";
                            cmd.Parameters.Add("LS_JTDMXID", OracleType.VarChar).Value = strJTDMXID;
                            cmd.Parameters.Add("LS_JTDID", OracleType.VarChar).Value = strJTDID;
                            cmd.Parameters.Add("DescErr", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
                            cmd.Parameters.Add("Message", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
                            cmd.ExecuteNonQuery();
                            transaction.Commit();
                            alarm = cmd.Parameters["DescErr"].Value.ToString();
                            if (alarm == "1")
                            {
                                MessageBox.Show("品名为" + strSPMC + cmd.Parameters["Message"].Value.ToString());
                                break;
                            }


                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        { }


                    }
                    selection.ClearSelection();
                    unitOfWork1.DropIdentityMap();
                    xpServerCollectionSource1.Reload();
                    TxtAlter();
                    if (alarm == "0")
                    { MessageBox.Show("全部减单成功"); }
                    connection.Close();
                            

                }

            }
           
        }

        private void btnSelectDepar_Click(object sender, EventArgs e)
        {
            FrmSelectDW from = new FrmSelectDW(235674,306,3120);
            from.Tag = "YICHANG";
            if (from.ShowDialog() == DialogResult.OK)
            {
                this.txtGYS.Tag = FrmSelectDW.ghdwid.ToString();
                this.txtGYS.Text = FrmSelectDW.ghdwmc.ToString();

            }
        }

 




       

    }
}
