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
    public partial class FrmPurchaseStageJTAdd : Form
    {
        GridCheckMarksSelection selection;
        const int MAXROWCOUNT = 50000;
        // private string StrCon = FrmLogin.strCon;
        private string StrCon = FrmLogin.strDataCent;
        private string JSLX = "整单";
        //选计
        private double dSHSY = 0;
        private double dSHMY = 0;
        private Int64 iSHSL = 0;
        public FrmPurchaseStageJTAdd(string strCGJSDID)
        {
            InitializeComponent();
            //  XpoDefault.ConnectionString = OracleConnectionProvider.GetConnectionString("XINHUA", "xxb", "pass");
            XpoDefault.ConnectionString = FrmLogin.xpoDataCentStr;
            selection = new GridCheckMarksSelection(gridView1);
            selection.CheckMarkColumn.VisibleIndex = 0;

            this.txtJSDH.Tag = strCGJSDID;
            xpServerCollectionSource1.FixedFilterString = "[CGJSDID] = \'" + this.txtJSDH.Tag.ToString() + "\' AND [ZTID]=\'" + FrmLogin.getZTID + "\'";
        }

        private string GetXDtag(string tagtext)//传递选单的TAG
        {
            string tagname = "";
            if (tagtext == "JT_CGJSD_ZDJS_ADD" || tagtext == "JT_CGJSD_ZDJS_ALTER")
            {
                tagname = "JT_CGJSD_ZDJS_XD";
            }
            else if (tagtext == "JT_CGJSD_SXSJ_ADD" || tagtext == "JT_CGJSD_SXSJ_ALTER")
            {
                tagname = "JT_CGJSD_SXSJ_XD";
            }

            return tagname;
 
        }
        private string GetJSFSID(string text)//依据选择的付款方式反选ID
        {
            string id = "";
            OracleConnection conn = new OracleConnection(StrCon);
            string strselect = "select JSFSID from JT_J_JSFS where JSFSMC='" + text + "'";
            OracleCommand comm = new OracleCommand(strselect, conn);
            OracleDataReader reader;
            try
            {
                conn.Open();
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    id = reader.GetValue(0).ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return id;
        }
       // private void LoadGridView_ZD()
      //  {
      //      this.colSPXXMC.Visible = false;
      //      this.colSPBH.Visible = false;
      //      this.colZDDM.Visible = false;
      //      this.colDJ.Visible = false;
      //      this.colJJ.Visible = false;
      //      this.colJZ.Visible = false;
      //  }
     //   private void LoadGridView_SX()
     //   {
    //        this.colDWMC.Visible = false;
    //    }
        private void LoadControl_ADD()
        {
            this.btnSave.Visible = true;
            this.btnReload.Visible = true;
            this.btnExit.Visible = true;
            this.btnSelectCase.Visible = true;
            this.btnDeleteCase.Visible = true;
            this.btnAlter.Visible = false;

        }
        private void LoadContent_ADD()
        {

            this.txtJSDH.Text = "";
            this.txtPJZK.Text = "0.0";
            this.txtZKE.Text = "0.0";
            this.txtPZS.Text = "0";
            this.txtSHSL.Text = "0";
            this.txtSHMY.Text = "0.0";
            this.txtSHSY.Text = "0.0";
            this.txtJSHJ.Text = "0.0";
            this.txtSE.Text = "0.0";
            this.txtWSJE.Text = "0.0";
            this.txtZT.Text = "录入";
            this.txtZT.Tag = "01";
            txtBM.Text = FrmLogin.getDeptName.ToString();
            txtBM.Tag = FrmLogin.getDeptID.ToString();
            txtZTID.Text = FrmLogin.getAccount.ToString();
            this.txtZTID.Tag = FrmLogin.getZTID.ToString();
            this.txtCZY.Tag = FrmLogin.getUserID.ToString();
            LoadtxtCZY();
            LoadComboxJSFS();
            xpServerCollectionSource1.FixedFilterString = "[CGJSDID] = \'" + this.txtJSDH.Tag.ToString() + "\' AND [ZTID]=\'" + FrmLogin.getZTID + "\'";
        }
        private void LoadControl_ALTER()
        {
            this.btnSave.Visible = false;
            this.btnReload.Visible = false;
            this.btnExit.Visible = true;
            this.btnSelectCase.Visible = true;
            this.btnDeleteCase.Visible = true;
            this.btnAlter.Visible = true;
            this.btnReload.Visible = true;
 
        }
        private void LoadContent_ALTER()
        {
            LoadComboxJSFS();
            LoadInitializeLook();
            xpServerCollectionSource1.FixedFilterString = "[CGJSDID] = \'" + this.txtJSDH.Tag.ToString() + "\' AND [ZTID]=\'" + FrmLogin.getZTID + "\'";

        }
        private void LoadControl_LOOK()
        {
            this.btnSave.Visible = false;
            this.btnReload.Visible = false;
            this.btnExit.Visible = false;
            this.btnSelectCase.Visible = false;
            this.btnDeleteCase.Visible =false;
            this.btnAlter.Visible = false;
            this.comboxSL.Enabled = false;
            this.ComboxJSFS.Enabled = false;
            this.txtJSR.ReadOnly = true;
            this.txtBZ.ReadOnly = true;
            this.btnDWselect.Enabled = false;
 
        }
        private void LoadContent_LOOK()
        {
            LoadComboxJSFS();
            LoadInitializeLook();
            xpServerCollectionSource1.FixedFilterString = "[CGJSDID] = \'" + this.txtJSDH.Tag.ToString() + "\' AND [ZTID]=\'" + FrmLogin.getZTID + "\'";
        }
        private void selectcountclear()
        {
        dSHSY = 0;
        dSHMY = 0;
       iSHSL = 0;
        }

        
        //初始化采购单整单结算增加采购单模块的界面供查看用
        private void LoadInitializeLook()
        {
            string strselect = "select CGJSDH,CWBMID,CWBMMC,ZTID,ZTIDMC,CZYID,CZRMC,CZRQ,ZDRQ,JSR,JSFSID,JSFSMC,GYSID,DWMC,SL,BZ,PJDJ,PJZK,ZKE,PZS,SHSL,SHSY,SHMY,JSHJ,SE,WSJE,ZT,ZTMC from VIEW_JT_C_CGJSD  where CGJSDID='" + this.txtJSDH.Tag.ToString() + "'";
            OracleConnection conn = new OracleConnection(StrCon);
            try
            {
                conn.Open();
                OracleCommand comm = new OracleCommand(strselect, conn);
                OracleDataReader reader;
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    this.txtJSDH.Text = reader["CGJSDH"].ToString();//单号

                    this.txtBM.Tag = reader["CWBMID"].ToString();//财务部门ID
                    this.txtBM.Text = reader["CWBMMC"].ToString();//财务部门名称
                    this.txtZTID.Tag = reader["ZTID"].ToString();//帐套ID
                    this.txtZTID.Text = reader["ZTIDMC"].ToString();//帐套名称
                    this.txtCZY.Tag = reader["CZYID"].ToString();// 操作员ID
                    this.txtCZY.Text = reader["CZRMC"].ToString();//操作员名称
                    this.dateTimePicker1.Text = reader["CZRQ"].ToString();//操作日期
                    this.dateTimePicker2.Text = reader["ZDRQ"].ToString(); //制单日期
                    this.txtJSR.Text = reader["JSR"].ToString();//结算人名称
                    this.ComboxJSFS.Tag = reader["JSFSID"].ToString();//结算方式ID
                    this.ComboxJSFS.Text = reader["JSFSMC"].ToString();//结算方式名称
                    this.txtGHDW.Tag = reader["GYSID"].ToString();//购货单位ID
                    this.txtGHDW.Text = reader["DWMC"].ToString();//购货单位名称
                    this.comboxSL.Text = reader["SL"].ToString();//税率
                    this.txtBZ.Text = reader["BZ"].ToString();//备注
                    this.txtPJDJ.Text = reader["PJDJ"].ToString();//平均单价
                    this.txtPJZK.Text = reader["PJZK"].ToString();//平均折扣
                    this.txtZKE.Text = reader["ZKE"].ToString();//折扣额
                    this.txtPZS.Text = reader["PZS"].ToString();//品种数
                    this.txtSHSL.Text = reader["SHSL"].ToString();//实收数量
                    this.txtSHSY.Text = reader["SHSY"].ToString();//实收实洋
                    this.txtSHMY.Text = reader["SHMY"].ToString();//实收码洋
                    this.txtJSHJ.Text = reader["JSHJ"].ToString();//价税合计
                    this.txtSE.Text = reader["SE"].ToString();//税额
                    this.txtWSJE.Text = reader["WSJE"].ToString();//无税金额
                    this.txtZT.Tag = reader["ZT"].ToString();//状态ID          
                    this.txtZT.Text = reader["ZTMC"].ToString();//状态名称


                }

            }
            catch (OracleException ex)
            { MessageBox.Show(ex.Message); }
            finally
            { conn.Close(); }
            xpServerCollectionSource1.FixedFilterString = "[CGJSDID] = \'" + this.txtJSDH.Tag.ToString() + "\' AND [ZTID]=\'" + FrmLogin.getZTID + "\'";
            gridView1.BestFitColumns();

        }

        //取操作员姓名
        private void LoadtxtCZY()
        {
            OracleConnection conn = new OracleConnection(FrmLogin.strCon);
            string selectempname = "select NAME from SYS_EMPLOYEES where EMPLOYEEID='" + this.txtCZY.Tag + "'";
            OracleCommand mycomm = new OracleCommand(selectempname, conn);
            OracleDataReader myreader;
            try
            {
                conn.Open();
                myreader = mycomm.ExecuteReader();

                while (myreader.Read())
                {
                    this.txtCZY.Text = myreader.GetValue(0).ToString();
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString()); }
            finally
            { conn.Close(); }


        }
        //结账方式COMBOX赋值
        private void LoadComboxJSFS()
        {
            OracleConnection conn = new OracleConnection(StrCon);
            try
            {
                conn.Open();
                string selectfplx = "select JSFSMC from JT_J_JSFS";
                OracleDataAdapter adp = new OracleDataAdapter(selectfplx, conn);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                DataTable table = new DataTable();
                table = ds.Tables[0];
                foreach (DataRow myrow in table.Rows)
                { this.ComboxJSFS.Items.Add(myrow["JSFSMC"].ToString().Trim()); }

            }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString()); }
            finally
            {
                conn.Close();
            }

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
            vDrawFootCell(e, colSJLX, "选计：");
            vDrawFootCell(e, colSSSY, dSHSY.ToString("F2"));
            vDrawFootCell(e, colSSMY, dSHMY.ToString("F2"));
            vDrawFootCell(e, colSSSL, iSHSL.ToString());


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
                        dSHSY = Convert.ToDouble(colSSSY.SummaryText);
                        dSHMY = Convert.ToDouble(colSSMY.SummaryText);
                        iSHSL = Convert.ToInt64(colSSSL.SummaryText);

                    }
                    else
                    {
                        dSHSY = 0;
                        dSHMY = 0;
                        iSHSL = 0;
                    }

                }
                if (hitInfo.InRowCell)
                {
                    if (selection.IsRowSelected(hitInfo.RowHandle))
                    {
                    dSHSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colSSSY));
                    dSHMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colSSMY));
                    iSHSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colSSSL));
                    }
                    else
                    {
                       dSHSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colSSSY));
                        dSHMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colSSMY));
                        iSHSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colSSSL));

                    }
                }
            }

        }
        private void btnDWselect_Click(object sender, EventArgs e)
        {

            FrmSelectDW from = new FrmSelectDW();
            from.Tag = "ZHENGCHANG";
            if (from.ShowDialog() == DialogResult.OK)
            {
                this.txtGHDW.Tag = FrmSelectDW.ghdwid.ToString();
                this.txtGHDW.Text = FrmSelectDW.ghdwmc.ToString();

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            bool check = true;
            if (this.comboxSL.Text == "")
            { check = false; MessageBox.Show("税率没有选择"); }
            else if (this.ComboxJSFS.Text == "")
            { check = false; MessageBox.Show("结算方式没有选择"); }
            else if (this.txtGHDW.Text == "")
            { check = false; MessageBox.Show("单位没有选择"); }
            else
            { check = true; }
            if (check == true)
            {   
                if(this.txtJSDH.Text=="")
                {

                    using (OracleConnection connection = new OracleConnection(StrCon))
                    {

                     try
                        {
                            connection.Open();
                            OracleCommand cmd = connection.CreateCommand();
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.CommandText = "Jt_C_CGJSD_insert";
                            cmd.Parameters.Add("ls_CWBMID", OracleType.VarChar).Value = this.txtBM.Tag.ToString();
                            cmd.Parameters.Add("ls_ZTID", OracleType.VarChar).Value = this.txtZTID.Tag.ToString();
                            cmd.Parameters.Add("ls_GYSID", OracleType.VarChar).Value = this.txtGHDW.Tag.ToString();
                            cmd.Parameters.Add("ls_JSLX", OracleType.VarChar).Value = JSLX;
                            cmd.Parameters.Add("ls_JSFSID", OracleType.VarChar).Value = GetJSFSID(this.ComboxJSFS.Text.ToString().Trim());
                            cmd.Parameters.Add("ls_JSR", OracleType.VarChar).Value = this.txtJSR.Text.ToString().Trim();
                            cmd.Parameters.Add("ls_CZYID", OracleType.VarChar).Value = this.txtCZY.Tag.ToString().Trim();
                            cmd.Parameters.Add("ls_SL", OracleType.VarChar).Value = this.comboxSL.Text.ToString().Trim();
                            cmd.Parameters.Add("ls_ZT", OracleType.VarChar).Value = "02";
                            cmd.Parameters.Add("ls_BZ", OracleType.VarChar).Value = this.txtBZ.Text.ToString().Trim();
                            cmd.Parameters.Add("LS_CGJSDid", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
                            cmd.Parameters.Add("LS_CGJSDH", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
                            cmd.Parameters.Add("DescErr", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
                            cmd.Parameters.Add("Message", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
                            cmd.ExecuteNonQuery();
                            this.txtJSDH.Tag = cmd.Parameters["LS_CGJSDid"].Value.ToString();
                            this.txtJSDH.Text = cmd.Parameters["LS_CGJSDH"].Value.ToString();
                        
                            unitOfWork1.DropIdentityMap();
                            xpServerCollectionSource1.Reload();
                            gridView1.BestFitColumns();
                            MessageBox.Show(cmd.Parameters["DescErr"].Value.ToString() + cmd.Parameters["Message"].Value.ToString());

                        }
                        catch (OracleException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            connection.Close();
                            this.btnDWselect.Enabled = false;
                            this.comboxSL.Enabled = false;
                            this.ComboxJSFS.Enabled = false;
                            this.txtJSR.ReadOnly = true;
                            this.txtBZ.ReadOnly = true;
                            this.txtZT.Text = "存盘";
                            this.txtZT.Tag = "02";
                        }
                    }
                }
                else
                {

                    using (OracleConnection connection = new OracleConnection(StrCon))
                    {

                        try
                        {
                            connection.Open();
                            OracleCommand cmd = connection.CreateCommand();
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.CommandText = "Jt_C_CGJSD_update";
                            cmd.Parameters.Add("LS_CGJSDid", OracleType.VarChar).Value = this.txtJSDH.Tag.ToString();
                            cmd.Parameters.Add("ls_GYSID", OracleType.VarChar).Value = this.txtGHDW.Tag.ToString();
                            cmd.Parameters.Add("ls_JSR", OracleType.VarChar).Value = this.txtJSR.Text.ToString().Trim();
                            cmd.Parameters.Add("ls_JSFSID", OracleType.VarChar).Value = GetJSFSID(this.ComboxJSFS.Text.ToString().Trim());
                            cmd.Parameters.Add("ls_SL", OracleType.VarChar).Value = this.comboxSL.Text.ToString().Trim();
                            cmd.Parameters.Add("ls_ZT", OracleType.VarChar).Value = "02";
                            cmd.Parameters.Add("ls_BZ", OracleType.VarChar).Value = this.txtBZ.Text.ToString().Trim();
                            cmd.Parameters.Add("DescErr", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
                            cmd.Parameters.Add("Message", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
                            cmd.ExecuteNonQuery();
                            xpServerCollectionSource1.FixedFilterString = "[CGJSDID] = \'" + this.txtJSDH.Tag.ToString() + "\'";
                            unitOfWork1.DropIdentityMap();
                            xpServerCollectionSource1.Reload();
                            gridView1.BestFitColumns();
                            MessageBox.Show(cmd.Parameters["DescErr"].Value.ToString() + cmd.Parameters["Message"].Value.ToString());

                        }
                        catch (OracleException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            connection.Close();
                            this.btnDWselect.Enabled = false;
                            this.comboxSL.Enabled = false;
                            this.ComboxJSFS.Enabled = false;
                            this.txtJSR.ReadOnly = true;
                            this.txtBZ.ReadOnly = true;
                            this.txtZT.Text = "存盘";
                            this.txtZT.Tag = "02";
                        }
                    }
                }

               
             
            }
          
        }
        private string GetCountMX(string jsdid)//获取结算单明细数量
        {
            string num = "0";
            OracleConnection conn = new OracleConnection(StrCon);
            string selectunm = "select count(0) from JT_C_CGJSDMX where CGJSDID='" + jsdid + "'";
            OracleCommand mycomm = new OracleCommand(selectunm, conn);
            OracleDataReader myreader;
            try
            {
                conn.Open();
                myreader = mycomm.ExecuteReader();

                while (myreader.Read())
                {
                    num = myreader.GetValue(0).ToString();
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString()); }
            finally
            { conn.Close(); }

            return num;
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            if (txtJSDH.Text == "")
            { 
                LoadControl_ADD();
                LoadContent_ADD();
                
            }
            else if (GetCountMX(this.txtJSDH.Tag.ToString())=="0")
            {
                this.btnDWselect.Enabled = true;
                this.comboxSL.Enabled=true;
                this.ComboxJSFS.Enabled = true;
                this.txtBZ.ReadOnly = false;
                this.txtJSR.ReadOnly = false;
                this.txtBZ.Text = "";
                this.comboxSL.Text = "";
                LoadComboxJSFS();
                this.txtGHDW.Text = "";
                this.txtJSR.Text = "";
            }
            else if(GetCountMX(this.txtJSDH.Tag.ToString())!="0")
            {
                this.txtJSR.ReadOnly = false;
                this.txtBZ.ReadOnly = false;
                this.txtBZ.Text = "";
                this.txtJSR.Text = "";

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAlter_Click(object sender, EventArgs e)
        {
            bool check = true;
            if (this.comboxSL.Text == "")
            { check = false; MessageBox.Show("税率没有选择"); }
            else if (this.ComboxJSFS.Text == "")
            { check = false; MessageBox.Show("结算方式没有选择"); }
            else if (this.txtGHDW.Text == "")
            { check = false; MessageBox.Show("单位没有选择"); }
            else
            { check = true; }
            if (check == true)
            {
                using (OracleConnection connection = new OracleConnection(StrCon))
                {

                    try
                    {
                        connection.Open();
                        OracleCommand cmd = connection.CreateCommand();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "Jt_C_CGJSD_update";
                        cmd.Parameters.Add("LS_CGJSDid", OracleType.VarChar).Value = this.txtJSDH.Tag.ToString();
                        cmd.Parameters.Add("ls_GYSID", OracleType.VarChar).Value = this.txtGHDW.Tag.ToString();
                        cmd.Parameters.Add("ls_JSR", OracleType.VarChar).Value = this.txtJSR.Text.ToString().Trim();
                        cmd.Parameters.Add("ls_JSFSID", OracleType.VarChar).Value = GetJSFSID(this.ComboxJSFS.Text.ToString().Trim());
                        cmd.Parameters.Add("ls_SL", OracleType.VarChar).Value = this.comboxSL.Text.ToString().Trim();
                        cmd.Parameters.Add("ls_ZT", OracleType.VarChar).Value = "02";
                        cmd.Parameters.Add("ls_BZ", OracleType.VarChar).Value = this.txtBZ.Text.ToString().Trim();
                        cmd.Parameters.Add("DescErr", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("Message", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
                        cmd.ExecuteNonQuery();
                        xpServerCollectionSource1.FixedFilterString = "[CGJSDID] = \'" + this.txtJSDH.Tag.ToString() + "\'";
                        unitOfWork1.DropIdentityMap();
                        xpServerCollectionSource1.Reload();
                        gridView1.BestFitColumns();
                        MessageBox.Show(cmd.Parameters["DescErr"].Value.ToString() + cmd.Parameters["Message"].Value.ToString());

                    }
                    catch (OracleException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                        this.btnDWselect.Enabled = false;
                        this.comboxSL.Enabled = false;
                        this.ComboxJSFS.Enabled = false;
                        this.txtJSR.ReadOnly = true;
                        this.txtBZ.ReadOnly = true;
                        this.txtZT.Text = "存盘";
                        this.txtZT.Tag = "02";
                    }
                }



            }

        }

        private void btnSelectCase_Click(object sender, EventArgs e)
        {     
            if (this.txtJSDH.Text != "")
            {

                FrmPurchaseStageSelectCase from = new FrmPurchaseStageSelectCase(this.txtJSDH.Tag.ToString(), this.comboxSL.Text.ToString(), this.txtGHDW.Tag.ToString(),this.txtZTID.Tag.ToString());

                //集团采购结算单选单
                from.Tag = GetXDtag(this.Tag.ToString());
                from.Text = "集团——采购结算单——选单";
                if (from.ShowDialog() == DialogResult.OK)
                {
                    this.btnDWselect.Enabled = false;
                    this.comboxSL.Enabled = false;
                    this.ComboxJSFS.Enabled = true;
                    this.txtBZ.ReadOnly = false;
                    unitOfWork1.DropIdentityMap();
                    LoadInitializeLook();
                    xpServerCollectionSource1.Reload();
                    gridView1.BestFitColumns();
                }
            }
            else
            {
                MessageBox.Show("您必须先新增采购单", "警告");
            }
        }

        private void btnDeleteCase_Click(object sender, EventArgs e)
        {

            if (selection.SelectedCount == 0)
            {
                MessageBox.Show("请先选择需要减单的采购单");
            }
            else
            {
                if (this.Tag.ToString() == "JT_CGJSD_ZDJS_ADD" || this.Tag.ToString() == "JT_CGJSD_ZDJS_ALTER")
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
                            for (int i = 0; i < selection.SelectedCount; ++i)
                            {
                                int RowIndex = selection.GetSelectedRowIndex(i);
                                int RowHandle = gridView1.GetRowHandle(RowIndex);
                                string strCGSHID = gridView1.GetRowCellValue(RowHandle, colCGSHID).ToString();
                                string strSJLX = gridView1.GetRowCellValue(RowHandle, colSJLX).ToString();
                               cmd.CommandText = "INSERT INTO TEMP_SAVE_ID (TEMPID,ID,WLBMID) Values (temp_save_id_seq.nextval, '" + strCGSHID + "','" + strSJLX + "')";
                                cmd.ExecuteNonQuery();
                            }
                            selection.ClearSelection();
                            selectcountclear(); 
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.CommandText = "jT_C_CGJS_ZDJD";
                                cmd.Parameters.Add("LS_CGJSDid", OracleType.VarChar).Value = this.txtJSDH.Tag.ToString();

                                cmd.Parameters.Add("DescErr", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
                                cmd.Parameters.Add("Message", OracleType.VarChar, 255).Direction = ParameterDirection.Output;

                                cmd.ExecuteNonQuery();
                                transaction.Commit();

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

                            LoadInitializeLook();
                            connection.Close();
                        }

                    }
                }
                else if (this.Tag.ToString() == "JT_CGJSD_SXSJ_ADD" || this.Tag.ToString() == "JT_CGJSD_SXSJ_ALTER")
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
                            for (int i = 0; i < selection.SelectedCount; ++i)
                            {
                                int RowIndex = selection.GetSelectedRowIndex(i);
                                int RowHandle = gridView1.GetRowHandle(RowIndex);
                            //    string strCGJSDMXID = gridView1.GetRowCellValue(RowHandle, colCGJSDMXID).ToString();
                             //   cmd.CommandText = "INSERT INTO TEMP_SAVE_ID (TEMPID, ID) Values (temp_save_id_seq.nextval, '" + strCGJSDMXID + "')";
                                cmd.ExecuteNonQuery();
                            }
                                selection.ClearSelection();
                                selectcountclear();
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.CommandText = "jT_C_CGJS_SXJD";
                                cmd.Parameters.Add("LS_CGJSDid", OracleType.VarChar).Value = this.txtJSDH.Tag.ToString();

                                cmd.Parameters.Add("DescErr", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
                                cmd.Parameters.Add("Message", OracleType.VarChar, 255).Direction = ParameterDirection.Output;

                                cmd.ExecuteNonQuery();
                                transaction.Commit();

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

                            LoadInitializeLook();
                            connection.Close();
                        }

                    }
                }
               

              


            }
        }

        private void FrmPurchaseStageJTAdd_Load(object sender, EventArgs e)
        {
            if (this.Tag.ToString() == "JT_CGJSD_ZDJS_ADD")
            {
                LoadControl_ADD();
                LoadContent_ADD();
           //     LoadGridView_ZD();
                JSLX = "整单";
            }
            else if (this.Tag.ToString() == "JT_CGJSD_SXSJ_ADD")
            {
                LoadControl_ADD();
                LoadContent_ADD();
          //      LoadGridView_SX();
                JSLX = "实销实结";
            }
            else if (this.Tag.ToString() == "JT_CGJSD_ZDJS_ALTER")
            {
                LoadControl_ALTER();
                LoadContent_ALTER();
            //    LoadGridView_ZD();
                JSLX = "整单";

            }
            else if (this.Tag.ToString() == "JT_CGJSD_SXSJ_ALTER")
            {
                LoadControl_ALTER();
                LoadContent_ALTER();
            //    LoadGridView_ZD();
                JSLX = "实销实结";

            }
            else if (this.Tag.ToString() == "JT_CGJSD_ZDJS_LOOK")
            {
                LoadControl_LOOK();
                LoadContent_LOOK();
             //   LoadGridView_ZD();
                JSLX = "整单";
            }
            else if (this.Tag.ToString() == "JT_CGJSD_SXSJ_LOOK")
            {
                LoadControl_LOOK();
                LoadContent_LOOK();
             //   LoadGridView_SX();
                JSLX = "实销实结";
            }
        }

        private void btnPrintTable_Click(object sender, EventArgs e)
        {
            gridView1.Columns["CheckMarkSelection"].Visible = false;

            gridView1.SelectAll();
            gridControl1.ShowPrintPreview();

            gridView1.Columns["CheckMarkSelection"].Visible = true;
            gridView1.Columns["CheckMarkSelection"].VisibleIndex = 0;
        }

        private void btnExportGrid_Click(object sender, EventArgs e)
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

  

       

  

       
        

        
    }
}
