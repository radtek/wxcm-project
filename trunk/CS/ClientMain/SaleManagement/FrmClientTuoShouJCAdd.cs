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
    public partial class FrmClientTuoShouJCAdd : Form
    {
        GridCheckMarksSelection selection;
        const int MAXROWCOUNT = 50000;
        // private string StrCon = FrmLogin.strCon;
        private string StrCon = FrmLogin.strDataCent;
        private Int64 iSL = 0;
        private double WSJE = 0;
        private double SE = 0;
        private double JSHJ = 0;
        public FrmClientTuoShouJCAdd(string id)
        {
            InitializeComponent();
            //  XpoDefault.ConnectionString = OracleConnectionProvider.GetConnectionString("XINHUA", "xxb", "pass");
            XpoDefault.ConnectionString = FrmLogin.xpoDataCentStr;
            selection = new GridCheckMarksSelection(gridView1);
            selection.CheckMarkColumn.VisibleIndex = 0;
            this.txtTSDH.Tag = id;
            xpServerCollectionSource1.FixedFilterString = "[XSTSDID] = \'" + this.txtTSDH.Tag.ToString() + "\'";
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
        private void gridView1_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator & e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString().Trim();
            }
        }
        private void gridView1_CustomDrawFooterCell(object sender, FooterCellCustomDrawEventArgs e)
        {
            vDrawFootCell(e, colXSTSDH, "选计：");
            vDrawFootCell(e, colSL, iSL.ToString());
            vDrawFootCell(e, colWSJE, WSJE.ToString("F2"));
            vDrawFootCell(e, colSE, SE.ToString("F2"));
            vDrawFootCell(e, colJSHJ, JSHJ.ToString("F2"));

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
                        iSL = Convert.ToInt64(colSL.SummaryText);
                        WSJE = Convert.ToDouble(colWSJE.SummaryText);
                        SE = Convert.ToDouble(colSE.SummaryText);
                        JSHJ = Convert.ToDouble(colJSHJ.SummaryText);


                    }
                    else
                    {
                        iSL = 0;
                        WSJE = 0;
                        SE = 0;

                        JSHJ = 0;

                    }

                }
                if (hitInfo.InRowCell)
                {
                    if (selection.IsRowSelected(hitInfo.RowHandle))
                    {
                        iSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colSL));
                        WSJE += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colWSJE));
                        SE += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colSE));
                        JSHJ += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJSHJ));

                    }
                    else
                    {
                        iSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colSL));
                        WSJE -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colWSJE));
                        SE -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colSE));
                        JSHJ -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJSHJ));
                    }
                }
            }

        }
        private void SelectCountClear()
        {
            iSL = 0;
            WSJE = 0;
            SE = 0;
            JSHJ = 0;
        }
        private string LoadtxtCZY(string id)
        {
            string name = "";
            OracleConnection conn = new OracleConnection(FrmLogin.strCon);
            string selectempname = "select NAME from SYS_EMPLOYEES where EMPLOYEEID='" + id + "'";
            OracleCommand mycomm = new OracleCommand(selectempname, conn);
            OracleDataReader myreader;
            try
            {
                conn.Open();
                myreader = mycomm.ExecuteReader();

                while (myreader.Read())
                {
                    name = myreader.GetValue(0).ToString();
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString()); }
            finally
            { conn.Close(); }
            return name;

        }
        private int GetMXCount(string id)// 计算明细个数
        {
            int i = 0;
            OracleConnection conn = new OracleConnection(StrCon);
            string selectempname = "select count(*) from JC_C_XSTSDMX where XSTSDID='" + id + "'";
            OracleCommand mycomm = new OracleCommand(selectempname, conn);
            OracleDataReader myreader;
            try
            {
                conn.Open();
                myreader = mycomm.ExecuteReader();

                while (myreader.Read())
                {
                    i = Convert.ToInt32(myreader.GetValue(0).ToString());
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString()); }
            finally
            { conn.Close(); }
            return i;
        }
        private void InitializeLOOK(string id)
        {
            string strselect = "select XSTSDH,YWBMID,CWBMMC,ZTID,ZTIDMC,KHID,KHMC,SH,DZ,KHYH,ZH,DH,KXNRID,KXNRBH,TSPJMCID,TSPJMCH,SPFYQKID,SPFYQKDH,ZDR,ZDRMC,TSJE,BZ,XSHTID,CZYID,CZRMC,ZT,ZTMC,XSFPID,SJPH,CZRQ,ZDRQ from VIEW_JC_C_XSTSD  where XSTSDID='" + id + "'";
            OracleConnection conn = new OracleConnection(StrCon);
            try
            {
                conn.Open();
                OracleCommand comm = new OracleCommand(strselect, conn);
                OracleDataReader reader;
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    this.txtTSDH.Text = reader["XSTSDH"].ToString();
                    this.txtCWBM.Tag = reader["YWBMID"].ToString();
                    this.txtCWBM.Text = reader["CWBMMC"].ToString();
                    this.txtZTID.Tag = reader["ZTID"].ToString();
                    this.txtZTID.Text = reader["ZTIDMC"].ToString();
                    this.txtGHDW.Tag = reader["KHID"].ToString();
                    this.txtGHDW.Text = reader["KHMC"].ToString();
                    this.txtSH.Text = reader["SH"].ToString();
                    this.txtDZ.Text = reader["DZ"].ToString();
                    this.txtKHYH.Text = reader["KHYH"].ToString();
                    this.txtZH.Text = reader["ZH"].ToString();
                    this.txtDH.Text = reader["DH"].ToString();
                    this.txtKXNR.Tag = reader["KXNRID"].ToString();
                    this.txtKXNR.Text = reader["KXNRBH"].ToString();
                    this.txtTSPZ.Tag = reader["TSPJMCID"].ToString();
                    this.txtTSPZ.Text = reader["TSPJMCH"].ToString();
                    this.txtSPYF.Tag = reader["SPFYQKID"].ToString();
                    this.txtSPYF.Text = reader["SPFYQKDH"].ToString();
                    this.txtZDR.Tag = reader["ZDR"].ToString();
                    this.txtZDR.Text = reader["ZDRMC"].ToString();
                    this.txtTSJE.Text = reader["TSJE"].ToString();
                    this.txtBZ.Text = reader["BZ"].ToString();
                    this.txtHTH.Text = reader["XSHTID"].ToString();
                    this.txtCZY.Tag = reader["CZYID"].ToString();
                    this.txtCZY.Text = reader["CZRMC"].ToString();
                    this.txtZT.Tag = reader["ZT"].ToString();
                    this.txtZT.Text = reader["ZTMC"].ToString();
                    this.txtXSFP.Tag = reader["XSFPID"].ToString();
                    this.txtXSFP.Text = reader["SJPH"].ToString();
                    this.dateTimePickerCZRQ.Text = reader["CZRQ"].ToString();
                    this.dateTimePickerZDRQ.Text = reader["ZDRQ"].ToString();

                }

            }
            catch (OracleException ex)
            { MessageBox.Show(ex.Message); }
            finally
            { conn.Close(); }
            xpServerCollectionSource1.FixedFilterString = "[XSTSDID] = \'" + this.txtTSDH.Tag.ToString() + "\'";
            gridView1.BestFitColumns();
        }
        private void GetDWXX(string id)
        {
            OracleConnection conn = new OracleConnection(StrCon);
            string selectempname = "select SH,TXDZ,KHYH,ZH,DH from JT_J_DWXX where DWID='" + id + "'";
            OracleCommand mycomm = new OracleCommand(selectempname, conn);
            OracleDataReader myreader;
            try
            {
                conn.Open();
                myreader = mycomm.ExecuteReader();

                while (myreader.Read())
                {
                    this.txtSH.Text = myreader["SH"].ToString();
                    this.txtDZ.Text = myreader["TXDZ"].ToString();
                    this.txtKHYH.Text = myreader["KHYH"].ToString();
                    this.txtZH.Text = myreader["ZH"].ToString();
                    this.txtDH.Text = myreader["DH"].ToString();
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString()); }
            finally
            { conn.Close(); }

        }
        private void LoadControl_ADD()
        {
            this.btnSave.Visible = true;
            this.btnExit.Visible = true;
            this.btnReload.Visible = true;
            this.btnAlter.Visible = false;
            this.btnSelectCase.Visible = true;
            this.btnDeleteCase.Visible = true;

        }
        private void LoadContent_ADD()
        {
            this.txtCWBM.Text = FrmLogin.getDeptName.ToString();
            this.txtCWBM.Tag = FrmLogin.getDeptID.ToString();
            this.txtZTID.Text = FrmLogin.getAccount.ToString();
            this.txtZTID.Tag = FrmLogin.getZTID.ToString();
            this.txtZDR.Tag = FrmLogin.getUserID.ToString();
            this.txtZDR.Text = LoadtxtCZY(txtZDR.Tag.ToString());
            this.txtCZY.Tag = FrmLogin.getUserID.ToString();
            this.txtCZY.Text = LoadtxtCZY(txtCZY.Tag.ToString());
            this.txtKXNR.Tag = "";
            this.txtSPYF.Tag = "";
            this.txtTSPZ.Tag = "";
            this.txtHTH.Text = "";
        }
        private void LoadControl_ALTER()
        {
            this.btnSave.Visible = false;
            this.btnExit.Visible = true;
            this.btnReload.Visible = true;
            this.btnAlter.Visible = true;
            this.btnSelectCase.Visible = true;
            this.btnDeleteCase.Visible = true;
            if (GetMXCount(this.txtTSDH.Tag.ToString()) == 0)
            { this.btnSelectDW.Enabled = false; }
            else
            {
                this.btnSelectDW.Enabled = true;
            }
        }
        private void LoadContent_ALTER()
        {
            InitializeLOOK(this.txtTSDH.Tag.ToString());

        }
        private void LoadControl_LOOK()
        {
            this.btnSave.Visible = false;
            this.btnExit.Visible = true;
            this.btnReload.Visible = false;
            this.btnAlter.Visible = false;
            this.btnSelectCase.Visible = false;
            this.btnDeleteCase.Visible = false;
            this.btnSelectDW.Visible = false;
            this.btnSelectKXNR.Visible = false;
            this.btnSelectTSPZ.Visible = false;
            this.btnSPFY.Visible = false;
        }
        private void LoadContent_LOOK()
        {
            InitializeLOOK(this.txtTSDH.Tag.ToString());
        }
        private void FrmClientTuoShouJCAdd_Load(object sender, EventArgs e)
        {
            if (this.Tag.ToString() == "JC_KHTSD_ADD")
            {
                LoadControl_ADD();
                LoadContent_ADD();
            }
            else if (this.Tag.ToString() == "JC_KHTSD_ALTER")
            {
                LoadControl_ALTER();
                LoadContent_ALTER();


            }
            else if (this.Tag.ToString() == "JC_KHTSD_LOOK")
            {
                LoadControl_LOOK();
                LoadContent_LOOK();


            }
        }

        private void btnSelectDW_Click(object sender, EventArgs e)
        {
            FrmSelectDW from = new FrmSelectDW();
            from.Tag = "ZHENGCHANG";
            if (from.ShowDialog() == DialogResult.OK)
            {
                this.txtGHDW.Tag = FrmSelectDW.ghdwid.ToString();
                this.txtGHDW.Text = FrmSelectDW.ghdwmc.ToString();
                GetDWXX(this.txtGHDW.Tag.ToString());

            }
        }

        private void btnSelectKXNR_Click(object sender, EventArgs e)
        {
            FrmSelectKXNR from = new FrmSelectKXNR();
            if (from.ShowDialog() == DialogResult.OK)
            {
                this.txtKXNR.Tag = FrmSelectKXNR.KXNR_id.ToString();
                this.txtKXNR.Text = FrmSelectKXNR.KXNR_NRBH.ToString();

            }
        }

        private void btnSelectTSPZ_Click(object sender, EventArgs e)
        {
            FrmSelectTSPJ from = new FrmSelectTSPJ();
            if (from.ShowDialog() == DialogResult.OK)
            {
                this.txtTSPZ.Tag = FrmSelectTSPJ.TSPJ_id.ToString();
                this.txtTSPZ.Text = FrmSelectTSPJ.TSPJ_PJBH.ToString();


            }
        }

        private void btnSPFY_Click(object sender, EventArgs e)
        {
            FrmSelectFYQK from = new FrmSelectFYQK();
            if (from.ShowDialog() == DialogResult.OK)
            {
                this.txtSPYF.Tag = FrmSelectFYQK.FYQK_id.ToString();
                this.txtSPYF.Text = FrmSelectFYQK.FYQK_bh.ToString();


            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool checktxtghdw = false;
            if (this.txtGHDW.Text == "")
            { checktxtghdw = false; MessageBox.Show("单位没有选择"); }
            else
            {
                checktxtghdw = true;
            }
            if (checktxtghdw == true)
            {
                if (this.txtTSDH.Text == "")
                {
                    OracleConnection connection = new OracleConnection(StrCon);

                    try
                    {
                        connection.Open();
                        OracleCommand cmd = connection.CreateCommand();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "Jc_C_XSTSD_insert";
                        cmd.Parameters.Add("LS_YWBMID", OracleType.VarChar).Value = FrmLogin.getDeptID.ToString();
                        cmd.Parameters.Add("ls_ZTID", OracleType.VarChar).Value = FrmLogin.getZTID.ToString();
                        cmd.Parameters.Add("LS_KHID", OracleType.VarChar).Value = this.txtGHDW.Tag.ToString();
                        cmd.Parameters.Add("LS_KHMC", OracleType.VarChar).Value = this.txtGHDW.Text.ToString();

                        cmd.Parameters.Add("LS_SH", OracleType.VarChar).Value = this.txtSH.Text.ToString();
                        cmd.Parameters.Add("LS_DZ", OracleType.VarChar).Value = this.txtDZ.Text.ToString();

                        cmd.Parameters.Add("LS_KHYH", OracleType.VarChar).Value = this.txtKHYH.Text.ToString();

                        cmd.Parameters.Add("LS_ZH", OracleType.VarChar).Value = this.txtZH.Text.ToString().Trim();

                        cmd.Parameters.Add("LS_DH", OracleType.VarChar).Value = this.txtDH.Text.ToString().Trim();
                        cmd.Parameters.Add("LS_KXNRID", OracleType.VarChar).Value = this.txtKXNR.Tag.ToString().Trim();

                        cmd.Parameters.Add("LS_TSPJMCID", OracleType.VarChar).Value = this.txtTSPZ.Tag.ToString().Trim();
                        cmd.Parameters.Add("LS_SPFYQKID", OracleType.VarChar).Value = this.txtSPYF.Tag.ToString().Trim();
                        cmd.Parameters.Add("LS_XSHTID", OracleType.VarChar).Value = this.txtHTH.Text.ToString();
                        cmd.Parameters.Add("LS_ZDR", OracleType.VarChar, 255).Value = FrmLogin.getUserID.ToString();

                        cmd.Parameters.Add("LS_CZYID", OracleType.VarChar, 255).Value = FrmLogin.getUserID.ToString();
                        cmd.Parameters.Add("ls_BZ", OracleType.VarChar, 255).Value = this.txtBZ.Text.ToString();




                        cmd.Parameters.Add("LS_XSTSDid", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("LS_XSTSDH", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("DescErr", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("Message", OracleType.VarChar, 255).Direction = ParameterDirection.Output;


                        cmd.ExecuteNonQuery();
                        this.txtTSDH.Tag = cmd.Parameters["LS_XSTSDid"].Value.ToString();
                        this.txtTSDH.Text = cmd.Parameters["LS_XSTSDH"].Value.ToString();
                        unitOfWork1.DropIdentityMap();
                        xpServerCollectionSource1.Reload();

                        MessageBox.Show(cmd.Parameters["DescErr"].Value.ToString() + cmd.Parameters["Message"].Value.ToString());

                    }
                    catch (OracleException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                        this.txtZT.Text = "存盘";
                        this.txtZT.Tag = "02";
                    }
                }
                else
                {
                    OracleConnection connection = new OracleConnection(StrCon);

                    try
                    {
                        connection.Open();
                        OracleCommand cmd = connection.CreateCommand();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "JC_C_XSTSD_update";
                        cmd.Parameters.Add("LS_XSTSDid", OracleType.VarChar).Value = this.txtTSDH.Tag.ToString();
                        cmd.Parameters.Add("LS_KHID", OracleType.VarChar).Value = this.txtGHDW.Tag.ToString();
                        cmd.Parameters.Add("LS_KHMC", OracleType.VarChar).Value = this.txtGHDW.Text.ToString();
                        cmd.Parameters.Add("LS_SH", OracleType.VarChar).Value = this.txtSH.Text.ToString();
                        cmd.Parameters.Add("LS_DZ", OracleType.VarChar).Value = this.txtDZ.Text.ToString();
                        cmd.Parameters.Add("LS_KHYH", OracleType.VarChar).Value = this.txtKHYH.Text.ToString();
                        cmd.Parameters.Add("LS_ZH", OracleType.VarChar).Value = this.txtZH.Text.ToString().Trim();
                        cmd.Parameters.Add("LS_DH", OracleType.VarChar).Value = this.txtDH.Text.ToString().Trim();
                        cmd.Parameters.Add("LS_KXNRID", OracleType.VarChar).Value = this.txtKXNR.Tag.ToString().Trim();
                        cmd.Parameters.Add("LS_TSPJMCID", OracleType.VarChar).Value = this.txtTSPZ.Tag.ToString().Trim();
                        cmd.Parameters.Add("LS_SPFYQKID", OracleType.VarChar).Value = this.txtSPYF.Tag.ToString().Trim();
                        cmd.Parameters.Add("LS_XSHTID", OracleType.VarChar).Value = this.txtHTH.Text.ToString();
                        cmd.Parameters.Add("LS_ZDR", OracleType.VarChar, 255).Value = this.txtZDR.Tag.ToString();
                        cmd.Parameters.Add("ls_BZ", OracleType.VarChar, 255).Value = this.txtBZ.Text.ToString();

                        cmd.Parameters.Add("DescErr", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("Message", OracleType.VarChar, 255).Direction = ParameterDirection.Output;


                        cmd.ExecuteNonQuery();
                        unitOfWork1.DropIdentityMap();
                        xpServerCollectionSource1.Reload();
                        MessageBox.Show(cmd.Parameters["DescErr"].Value.ToString() + cmd.Parameters["Message"].Value.ToString());

                    }
                    catch (OracleException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }

                }
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            if (txtTSDH.Text == "")
            {
                LoadControl_ADD();
                LoadContent_ADD();
            }
            else if (GetMXCount(this.txtTSDH.Tag.ToString()) == 0)
            {
                this.btnSelectDW.Enabled = true;
                this.btnSelectKXNR.Enabled = true;
                this.btnSelectTSPZ.Enabled = true;
                this.btnSPFY.Enabled = true;
            }
            else if (GetMXCount(this.txtTSDH.Tag.ToString()) > 0)
            {
                this.btnSelectDW.Enabled = false;
                this.btnSelectKXNR.Enabled = false;
                this.btnSelectTSPZ.Enabled = false;
                this.btnSPFY.Enabled = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAlter_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要进行修改操作", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                bool checktxtghdw = false;
                if (this.txtGHDW.Text == "")
                { checktxtghdw = false; MessageBox.Show("单位没有选择"); }
                else
                {
                    checktxtghdw = true;
                }
                if (checktxtghdw == true)
                {
                    OracleConnection connection = new OracleConnection(StrCon);

                    try
                    {
                        connection.Open();
                        OracleCommand cmd = connection.CreateCommand();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "JC_C_XSTSD_update";
                        cmd.Parameters.Add("LS_XSTSDid", OracleType.VarChar).Value = this.txtTSDH.Tag.ToString();
                        cmd.Parameters.Add("LS_KHID", OracleType.VarChar).Value = this.txtGHDW.Tag.ToString();
                        cmd.Parameters.Add("LS_KHMC", OracleType.VarChar).Value = this.txtGHDW.Text.ToString();
                        cmd.Parameters.Add("LS_SH", OracleType.VarChar).Value = this.txtSH.Text.ToString();
                        cmd.Parameters.Add("LS_DZ", OracleType.VarChar).Value = this.txtDZ.Text.ToString();
                        cmd.Parameters.Add("LS_KHYH", OracleType.VarChar).Value = this.txtKHYH.Text.ToString();
                        cmd.Parameters.Add("LS_ZH", OracleType.VarChar).Value = this.txtZH.Text.ToString().Trim();
                        cmd.Parameters.Add("LS_DH", OracleType.VarChar).Value = this.txtDH.Text.ToString().Trim();
                        cmd.Parameters.Add("LS_KXNRID", OracleType.VarChar).Value = this.txtKXNR.Tag.ToString().Trim();
                        cmd.Parameters.Add("LS_TSPJMCID", OracleType.VarChar).Value = this.txtTSPZ.Tag.ToString().Trim();
                        cmd.Parameters.Add("LS_SPFYQKID", OracleType.VarChar).Value = this.txtSPYF.Tag.ToString().Trim();
                        cmd.Parameters.Add("LS_XSHTID", OracleType.VarChar).Value = this.txtHTH.Text.ToString();
                        cmd.Parameters.Add("LS_ZDR", OracleType.VarChar, 255).Value = this.txtZDR.Tag.ToString();
                        cmd.Parameters.Add("ls_BZ", OracleType.VarChar, 255).Value = this.txtBZ.Text.ToString();

                        cmd.Parameters.Add("DescErr", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("Message", OracleType.VarChar, 255).Direction = ParameterDirection.Output;


                        cmd.ExecuteNonQuery();
                        unitOfWork1.DropIdentityMap();
                        xpServerCollectionSource1.Reload();
                        MessageBox.Show(cmd.Parameters["DescErr"].Value.ToString() + cmd.Parameters["Message"].Value.ToString());

                    }
                    catch (OracleException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void btnSelectCase_Click(object sender, EventArgs e)
        {
            if (this.txtTSDH.Text != "")
            {
                FrmClientTuoShouJCSelectCase frm = new FrmClientTuoShouJCSelectCase(this.txtTSDH.Tag.ToString(), this.txtGHDW.Tag.ToString());
                frm.Tag = "JC_C_KHTSD_XD";
                frm.Text = "销售管理——市县客户托收单选单";
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    this.xpServerCollectionSource1.FixedFilterString = "[XSTSDID] = \'" + this.txtTSDH.Tag.ToString() + "\'";
                    unitOfWork1.DropIdentityMap();
                    xpServerCollectionSource1.Reload();
                    gridView1.BestFitColumns();

                }

            }
            else
            {
                MessageBox.Show("您必须先新增采购单", "警告");
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

        private void btnDeleteCase_Click(object sender, EventArgs e)
        {
            bool fgcheckJD = false;
            if (this.txtTSDH.Text.ToString() == "")
            {
                fgcheckJD = false;
                MessageBox.Show("您还没有保存结算单，请保存后再进行选单减单操作");
            }
            else if (selection.SelectedCount == 0)
            {
                fgcheckJD = false;
                MessageBox.Show("选择要减去的单据");
            }
            else
            {
                fgcheckJD = true;
            }
            if (fgcheckJD == true)
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
                            string strXSTSDMXID = gridView1.GetRowCellDisplayText(RowHandle, colXSTSDMXID).ToString();
                            cmd.CommandText = "INSERT INTO TEMP_SAVE_ID (TEMPID, ID) Values (temp_id_seq.nextval, '" + strXSTSDMXID + "')";
                            cmd.ExecuteNonQuery();
                        }

                        selection.ClearSelection();
                        SelectCountClear();


                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "Jc_c_XSTSD_JD";
                        cmd.Parameters.Add("LS_XSTSDid", OracleType.VarChar).Value = this.txtTSDH.Tag.ToString().Trim();
                        cmd.Parameters.Add("Descerr", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("Message", OracleType.VarChar, 255).Direction = ParameterDirection.Output;

                        cmd.ExecuteNonQuery();
                        transaction.Commit();
                        unitOfWork1.DropIdentityMap();
                        xpServerCollectionSource1.Reload();
                        MessageBox.Show(cmd.Parameters["Message"].Value.ToString());

                    }
                    catch (Exception ex)
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
        }

  


    }
}
