using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.OracleClient;

namespace ClientMain
{
    public partial class FrmDeptChild : DevExpress.XtraEditors.XtraForm
    {
        structDWXX m_sDWXX;

        public FrmDeptChild(structDWXX sDWXX)
        {
            InitializeComponent();

            m_sDWXX = sDWXX;
        }

        private void FrmDeptChild_Load(object sender, EventArgs e)
        {
            OracleConnection Con = new OracleConnection(FrmLogin.strDataCent);
            DataSet ds = new DataSet();

            Dictionary<string, string> dictSFZT = new Dictionary<string, string>();
            dictSFZT.Add("false", "否");
            dictSFZT.Add("true", "是");
            bsSFZT.DataSource = dictSFZT;
            cbSFZT.DisplayMember = "Value";
            cbSFZT.ValueMember = "Key";

            string sqlDWSX = "select dwsxid, dwsx from jt_j_dwsx where zt = '启用'";
            OracleDataAdapter adaDWSX = new OracleDataAdapter(sqlDWSX, Con);
            adaDWSX.Fill(ds, "jt_j_dwsx");
            cbDWSX.DataSource = ds.Tables["jt_j_dwsx"];
            cbDWSX.DisplayMember = "dwsx";
            cbDWSX.ValueMember = "dwsxid";

            string sqlBMLX = "select departtypeid, departtypename from base_departtype";
            OracleDataAdapter adaBMLX = new OracleDataAdapter(sqlBMLX, Con);
            adaBMLX.Fill(ds, "base_departtype");
            cbBMLX.DataSource = ds.Tables["base_departtype"];
            cbBMLX.DisplayMember = "departtypename";
            cbBMLX.ValueMember = "departtypeid";

            string sqlGYSLX = "select gyslxid, gyslx from jt_j_gyslx where zt = '启用'";
            OracleDataAdapter adaGYSLX = new OracleDataAdapter(sqlGYSLX, Con);
            adaGYSLX.Fill(ds, "jt_j_gyslx");
            cbGYSLX.DataSource = ds.Tables["jt_j_gyslx"];
            cbGYSLX.DisplayMember = "gyslx";
            cbGYSLX.ValueMember = "gyslxid";

            string sqlKHLX = "select khlxid, khlxmc from jt_j_khlx where zt = '启用'";
            OracleDataAdapter adaKHLX = new OracleDataAdapter(sqlKHLX, Con);
            adaKHLX.Fill(ds, "jt_j_khlx");
            cbKHLX.DataSource = ds.Tables["jt_j_khlx"];
            cbKHLX.DisplayMember = "khlxmc";
            cbKHLX.ValueMember = "khlxid";

            string sqlKFLX = "select kflxid, kflx from jt_j_kflx where zt = '启用'";
            OracleDataAdapter adaKFLX = new OracleDataAdapter(sqlKFLX, Con);
            adaKFLX.Fill(ds, "jt_j_kflx");
            cbKFLX.DataSource = ds.Tables["jt_j_kflx"];
            cbKFLX.DisplayMember = "kflx";
            cbKFLX.ValueMember = "kflxid";

            string sqlYSCLX = "select ysclxid, yscdwlx from jt_j_ysclx where zt = '启用'";
            OracleDataAdapter adaYSCLX = new OracleDataAdapter(sqlYSCLX, Con);
            adaYSCLX.Fill(ds, "jt_j_ysclx");
            cbYSCLX.DataSource = ds.Tables["jt_j_ysclx"];
            cbYSCLX.DisplayMember = "yscdwlx";
            cbYSCLX.ValueMember = "ysclxid";

            string sqlCBSLX = "select lxid, dwlx from jt_j_cbslx where zt = '启用'";
            OracleDataAdapter adaCBSLX = new OracleDataAdapter(sqlCBSLX, Con);
            adaCBSLX.Fill(ds, "jt_j_cbslx");
            cbCBSLX.DataSource = ds.Tables["jt_j_cbslx"];
            cbCBSLX.DisplayMember = "dwlx";
            cbCBSLX.ValueMember = "lxid";

            string sqlYSDWLX = "select ysdwlxid, ysdwlx from jt_j_ysdwlx where zt = '启用'";
            OracleDataAdapter adaYSDWLX = new OracleDataAdapter(sqlYSDWLX, Con);
            adaYSDWLX.Fill(ds, "jt_j_ysdwlx");
            cbYSDWLX.DataSource = ds.Tables["jt_j_ysdwlx"];
            cbYSDWLX.DisplayMember = "ysdwlx";
            cbYSDWLX.ValueMember = "ysdwlxid";

            string sqlYSFS = "select ysfsid, ysfs from jt_j_ysfs where zt = '启用'";
            OracleDataAdapter adaYSFS = new OracleDataAdapter(sqlYSFS, Con);
            adaYSFS.Fill(ds, "jt_j_ysfs");
            cbYSFS.DataSource = ds.Tables["jt_j_ysfs"];
            cbYSFS.DisplayMember = "ysfs";
            cbYSFS.ValueMember = "ysfsid";

            string sqlDWXX = "select DWID, DWMC, DWBH, ZJM from JT_J_DWXX";
            OracleDataAdapter AdaDWXX = new OracleDataAdapter(sqlDWXX, Con);
            AdaDWXX.Fill(ds, "JT_J_DWXX");
            bsDWXX.DataSource = ds;
            bsDWXX.DataMember = "JT_J_DWXX";

            string sqlZTBM = "select ZTID, ZTMC, ZTBH, ZTPY from JT_J_ZTBM";
            OracleDataAdapter AdaZTBM = new OracleDataAdapter(sqlZTBM, Con);
            AdaZTBM.Fill(ds, "JT_J_ZTBM");
            bsZTBM.DataSource = ds;
            bsZTBM.DataMember = "JT_J_ZTBM";

            string sqlSFBM = "select SFBMID, SFMC, SFBH, ZJM from JT_J_SFBM";
            OracleDataAdapter AdaSFBM = new OracleDataAdapter(sqlSFBM, Con);
            AdaSFBM.Fill(ds, "JT_J_SFBM");
            bsSFBM.DataSource = ds;
            bsSFBM.DataMember = "JT_J_SFBM";

            string sqlDQ = "select DQID, DQMC, DQBH, ZJM from JT_J_DQ";
            OracleDataAdapter AdaDQ = new OracleDataAdapter(sqlDQ, Con);
            AdaDQ.Fill(ds, "JT_J_DQ");
            bsDQ.DataSource = ds;
            bsDQ.DataMember = "JT_J_DQ";

            if (this.Text == "修改单位")
            {
                btnSaveContinue.Visible = false;

                cbBMLX.SelectedValue = m_sDWXX.strBMLXID;
                cbCBSLX.SelectedValue = m_sDWXX.strCBSLXID;
                cbDWSX.SelectedValue = m_sDWXX.strDWSX;
                cbeZT.SelectedItem = m_sDWXX.strZT;
                cbGYSLX.SelectedValue = m_sDWXX.strGYSLXID;
                cbKFLX.SelectedValue = m_sDWXX.strKFLXID;
                cbKHLX.SelectedValue = m_sDWXX.strKHLXID;
                cbSFZT.SelectedValue = m_sDWXX.strSFZT;
                cbYSCLX.SelectedValue = m_sDWXX.strYINSDWLXID;
                cbYSDWLX.SelectedValue = m_sDWXX.strYSDWLXID;
                cbYSFS.SelectedValue = m_sDWXX.strYSFSID;

            }
            else if (this.Text == "增加单位")
            {
                cbeZT.SelectedIndex = 0;
                //cbBMLX.SelectedIndex = 0;
                //cbCBSLX.SelectedIndex = 0;
                //cbDWSX.SelectedIndex = 0;                
                //cbGYSLX.SelectedIndex = 0;
                //cbKFLX.SelectedIndex = 0;
                //cbKHLX.SelectedIndex = 0;
                //cbSFZT.SelectedIndex = 0;
                //cbYSCLX.SelectedIndex = 0;
                //cbYSDWLX.SelectedIndex = 0;
                //cbYSFS.SelectedIndex = 0;
            }

            if (sleDQ.Handle != IntPtr.Zero)
            {
                sleDQ.EditValue = m_sDWXX.strDQID;
            }
            if (sleDWXX.Handle != IntPtr.Zero)
            {
                sleDWXX.EditValue = m_sDWXX.strSJDWID;
            }
            if (sleZTBM.Handle != IntPtr.Zero)
            {
                sleZTBM.EditValue = m_sDWXX.strBMZTID;
            }
            if (sleSFBM.Handle != IntPtr.Zero)
            {
                sleSFBM.EditValue = m_sDWXX.strSFID;
            }
            if (sleJSDW.Handle != IntPtr.Zero)
            {
                sleJSDW.EditValue = m_sDWXX.strJSDWID;
            }

            cbeDJSDBZ.SelectedItem = m_sDWXX.strDJSDBZ;
            cbeTSJSDBZ.SelectedItem = m_sDWXX.strTSJSDBZ;

            teBZ.Text = m_sDWXX.strBZ;
            teCGJSYXJ.Text = m_sDWXX.strCGJSYXJB;
            teCGJSZQ.Text = m_sDWXX.strCGJSZQ;
            teCGYXJ.Text = m_sDWXX.strCGYXJB;
            teCZ.Text = m_sDWXX.strCZ;
            teDH.Text = m_sDWXX.strDH;
            teDWBH.Text = m_sDWXX.strDWBH;
            teDWFR.Text = m_sDWXX.strDWFR;
            teDWJB.Text = m_sDWXX.strDWJB;
            teDWJC.Text = m_sDWXX.strDWJC;
            teDWMC.Text = m_sDWXX.strDWMC;
            teEMAIL.Text = m_sDWXX.strEMAIL;
            teEZDBH.Text = m_sDWXX.strEZDBH;
            teJSFS.Text = m_sDWXX.strJSFSID;
            teJTYXJ.Text = m_sDWXX.strJTYXJB;
            teKFDZ.Text = m_sDWXX.strKFDZ;
            teKHYH.Text = m_sDWXX.strKHYH;
            teKJDZ.Text = m_sDWXX.strKJDZ;
            teLXR.Text = m_sDWXX.strLXR;
            teMJDZ.Text = m_sDWXX.strMJDZ;
            tePHYXJ.Text = m_sDWXX.strPHYXJB;
            teSDSX.Text = m_sDWXX.strSDSX;
            teSDXX.Text = m_sDWXX.strSDXX;
            teSH.Text = m_sDWXX.strSH;
            teSHDZ.Text = m_sDWXX.strSHDZ;
            teTJBH.Text = m_sDWXX.strDWTJBH;
            teTSSX.Text = m_sDWXX.strTSSX;
            teTSXX.Text = m_sDWXX.strTSXX;
            teTTDYZS.Text = m_sDWXX.strTDYZS;
            teTXDZ.Text = m_sDWXX.strTXDZ;
            teWEBMM.Text = m_sDWXX.strWEBMM;
            teWEBYH.Text = m_sDWXX.strWEBYH;
            teWZ.Text = m_sDWXX.strWZ;
            teXSJSYXJ.Text = m_sDWXX.strXSJSYXJB;
            teXSJSZQ.Text = m_sDWXX.strTSJSZQ;
            teXTYXJ.Text = m_sDWXX.strXTYXJB;
            teYSFX.Text = m_sDWXX.strYSFXID;
            teYZBM.Text = m_sDWXX.strYZBM;
            teYZDBH.Text = m_sDWXX.strYZDBH;
            teZH.Text = m_sDWXX.strZH;
            teZJM.Text = m_sDWXX.strZJM;
            teZKSX.Text = m_sDWXX.strZKSX;
            teZKXX.Text = m_sDWXX.strZKXX;
            teZZBZFBZ.Text = m_sDWXX.strKHZZBZFBZ;
            teZZDBZ.Text = m_sDWXX.strZZDBZ;
            teZZQTFYBZ.Text = m_sDWXX.strKHZZQTFYBZ;
            teZZYFBZ.Text = m_sDWXX.strKHZZYFBZ;
        }

        private void vAddDepart(OracleCommand command, OracleTransaction transaction)
        {
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "jt_j_dwxx_insert";

            command.Parameters.Add("ls_DWBH", OracleType.VarChar).Value = teDWBH.Text;
            command.Parameters.Add("ls_DWMC", OracleType.VarChar).Value = teDWMC.Text;
            command.Parameters.Add("ls_DWJC", OracleType.VarChar).Value = teDWJC.Text;
            command.Parameters.Add("ls_ZJM", OracleType.VarChar).Value = teZJM.Text;
            command.Parameters.Add("ls_SJDWID", OracleType.VarChar).Value = sleDWXX.EditValue ?? "";
            command.Parameters.Add("ls_DWSX", OracleType.VarChar).Value = cbDWSX.SelectedValue;
            command.Parameters.Add("ls_BMLXID", OracleType.VarChar).Value = cbBMLX.SelectedValue;
            command.Parameters.Add("ls_GYSLXID", OracleType.VarChar).Value = cbGYSLX.SelectedValue;
            command.Parameters.Add("ls_KHLXID", OracleType.VarChar).Value = cbKHLX.SelectedValue;
            command.Parameters.Add("ls_KFLXID", OracleType.VarChar).Value = cbKFLX.SelectedValue;
            command.Parameters.Add("ls_YINSDWLXID", OracleType.VarChar).Value = cbYSCLX.SelectedValue;
            command.Parameters.Add("ls_CBSLXID", OracleType.VarChar).Value = cbCBSLX.SelectedValue;
            command.Parameters.Add("ls_YSDWLXID", OracleType.VarChar).Value = cbYSDWLX.SelectedValue;
            command.Parameters.Add("ls_BMZTID", OracleType.VarChar).Value = sleZTBM.EditValue ?? "";
            command.Parameters.Add("ls_GZLID", OracleType.VarChar).Value = "";
            command.Parameters.Add("ls_DWJB", OracleType.Number).Value = teDWJB.EditValue ?? 0;
            command.Parameters.Add("ls_DWFR", OracleType.VarChar).Value = teDWFR.Text;
            command.Parameters.Add("ls_SFID", OracleType.VarChar).Value = sleSFBM.EditValue ?? "";
            command.Parameters.Add("ls_DQID", OracleType.VarChar).Value = sleDQ.EditValue ?? "";
            command.Parameters.Add("ls_YZBM", OracleType.VarChar).Value = teYZBM.Text;
            command.Parameters.Add("ls_TXDZ", OracleType.VarChar).Value = teTXDZ.Text;
            command.Parameters.Add("ls_DH", OracleType.VarChar).Value = teDH.Text;
            command.Parameters.Add("ls_CZ", OracleType.VarChar).Value = teCZ.Text;
            command.Parameters.Add("ls_LXR", OracleType.VarChar).Value = teLXR.Text;
            command.Parameters.Add("ls_KHYH", OracleType.VarChar).Value = teKHYH.Text;
            command.Parameters.Add("ls_ZH", OracleType.VarChar).Value = teZH.Text;
            command.Parameters.Add("ls_SH", OracleType.VarChar).Value = teSH.Text;
            command.Parameters.Add("ls_EMAIL", OracleType.VarChar).Value = teEMAIL.Text;
            command.Parameters.Add("ls_WZ", OracleType.VarChar).Value = teWZ.Text;
            command.Parameters.Add("ls_JSFSID", OracleType.VarChar).Value = teJSFS.Text;
            command.Parameters.Add("ls_TSSX", OracleType.Number).Value = teTSSX.EditValue ?? 0;
            command.Parameters.Add("ls_TSXX", OracleType.Number).Value = teTSXX.EditValue ?? 0;
            command.Parameters.Add("ls_SDSX", OracleType.Number).Value = teSDSX.EditValue ?? 0;
            command.Parameters.Add("ls_SDXX", OracleType.Number).Value = teSDXX.EditValue ?? 0;
            command.Parameters.Add("ls_ZKSX", OracleType.Number).Value = teZKSX.EditValue ?? 0;
            command.Parameters.Add("ls_ZKXX", OracleType.Number).Value = teZKXX.EditValue ?? 0;
            command.Parameters.Add("ls_JSDWID", OracleType.VarChar).Value = sleJSDW.EditValue ?? "";
            command.Parameters.Add("ls_DJSDBZ", OracleType.VarChar).Value = cbeDJSDBZ.Text;
            command.Parameters.Add("ls_TSJSDBZ", OracleType.VarChar).Value = cbeTSJSDBZ.Text;
            command.Parameters.Add("ls_KHZZYFBZ", OracleType.Number).Value = teZZYFBZ.EditValue ?? 0;
            command.Parameters.Add("ls_KHZZBZFBZ", OracleType.Number).Value = teZZBZFBZ.EditValue ?? 0;
            command.Parameters.Add("ls_KHZZQTFYBZ", OracleType.Number).Value = teZZQTFYBZ.EditValue ?? 0;
            command.Parameters.Add("ls_CGJSZQ", OracleType.Number).Value = teCGJSZQ.EditValue ?? 0;
            command.Parameters.Add("ls_TSJSZQ", OracleType.Number).Value = teXSJSZQ.EditValue ?? 0;
            command.Parameters.Add("ls_SHDZ", OracleType.VarChar).Value = teSHDZ.Text;
            command.Parameters.Add("ls_KJDZ", OracleType.VarChar).Value = teKJDZ.Text;
            command.Parameters.Add("ls_MJDZ", OracleType.VarChar).Value = teMJDZ.Text;
            command.Parameters.Add("ls_YSFSID", OracleType.VarChar).Value = cbYSFS.SelectedValue;
            command.Parameters.Add("ls_YSFXID", OracleType.VarChar).Value = teYSFX.Text;
            command.Parameters.Add("ls_ZZDBZ", OracleType.VarChar).Value = teZZDBZ.Text;
            command.Parameters.Add("ls_YZDBH", OracleType.VarChar).Value = teYZDBH.Text;
            command.Parameters.Add("ls_EZDBH", OracleType.VarChar).Value = teEZDBH.Text;
            command.Parameters.Add("ls_KFDZ", OracleType.VarChar).Value = teKFDZ.Text;
            command.Parameters.Add("ls_TDYZS", OracleType.Number).Value = teTTDYZS.EditValue ?? 0;
            command.Parameters.Add("ls_DWTJBH", OracleType.VarChar).Value = teTJBH.Text;
            command.Parameters.Add("ls_CGJSYXJB", OracleType.Number).Value = teCGJSYXJ.EditValue ?? 0;
            command.Parameters.Add("ls_XSJSYXJB", OracleType.Number).Value = teXSJSYXJ.EditValue ?? 0;
            command.Parameters.Add("ls_PHYXJB", OracleType.Number).Value = tePHYXJ.EditValue ?? 0;
            command.Parameters.Add("ls_XTYXJB", OracleType.Number).Value = teXTYXJ.EditValue ?? 0;
            command.Parameters.Add("ls_JTYXJB", OracleType.Number).Value = teJTYXJ.EditValue ?? 0;
            command.Parameters.Add("ls_CGYXJB", OracleType.Number).Value = teCGYXJ.EditValue ?? 0;
            command.Parameters.Add("ls_WEBYH", OracleType.VarChar).Value = teWEBYH.Text;
            command.Parameters.Add("ls_WEBMM", OracleType.VarChar).Value = teWEBMM.Text;
            command.Parameters.Add("ls_ZT", OracleType.VarChar).Value = cbeZT.Text;
            command.Parameters.Add("ls_CJR", OracleType.VarChar).Value = FrmLogin.getUserName;
            command.Parameters.Add("ls_TYR", OracleType.VarChar).Value = "";
            command.Parameters.Add("ls_BZ", OracleType.VarChar).Value = teBZ.Text;
            command.Parameters.Add("ls_SFZT", OracleType.VarChar).Value = cbSFZT.SelectedValue;
            command.Parameters.Add("ls_CWXTID", OracleType.VarChar).Value = "";

            command.Parameters.Add("descerr", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
            command.Parameters.Add("Message", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
            command.Parameters.Add("ls_DWID", OracleType.VarChar, 255).Direction = ParameterDirection.Output;

            command.ExecuteNonQuery();

            transaction.Commit();
            MessageBox.Show(command.Parameters["Message"].Value.ToString());
        }

        private void vUpdateDepart(OracleCommand command, OracleTransaction transaction)
        {
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "jt_j_dwxx_update";

            command.Parameters.Add("ls_DWID", OracleType.VarChar).Value = m_sDWXX.strDWID;
            command.Parameters.Add("ls_DWBH", OracleType.VarChar).Value = teDWBH.Text;
            command.Parameters.Add("ls_DWMC", OracleType.VarChar).Value = teDWMC.Text;
            command.Parameters.Add("ls_DWJC", OracleType.VarChar).Value = teDWJC.Text;
            command.Parameters.Add("ls_ZJM", OracleType.VarChar).Value = teZJM.Text;
            command.Parameters.Add("ls_SJDWID", OracleType.VarChar).Value = sleDWXX.EditValue ?? "";
            command.Parameters.Add("ls_DWSX", OracleType.VarChar).Value = cbDWSX.SelectedValue;
            command.Parameters.Add("ls_BMLXID", OracleType.VarChar).Value = cbBMLX.SelectedValue;
            command.Parameters.Add("ls_GYSLXID", OracleType.VarChar).Value = cbGYSLX.SelectedValue;
            command.Parameters.Add("ls_KHLXID", OracleType.VarChar).Value = cbKHLX.SelectedValue;
            command.Parameters.Add("ls_KFLXID", OracleType.VarChar).Value = cbKFLX.SelectedValue;
            command.Parameters.Add("ls_YINSDWLXID", OracleType.VarChar).Value = cbYSCLX.SelectedValue;
            command.Parameters.Add("ls_CBSLXID", OracleType.VarChar).Value = cbCBSLX.SelectedValue;
            command.Parameters.Add("ls_YSDWLXID", OracleType.VarChar).Value = cbYSDWLX.SelectedValue;
            command.Parameters.Add("ls_BMZTID", OracleType.VarChar).Value = sleZTBM.EditValue ?? "";
            command.Parameters.Add("ls_GZLID", OracleType.VarChar).Value = "";
            command.Parameters.Add("ls_DWJB", OracleType.Number).Value = teDWJB.EditValue ?? 0;
            command.Parameters.Add("ls_DWFR", OracleType.VarChar).Value = teDWFR.Text;
            command.Parameters.Add("ls_SFID", OracleType.VarChar).Value = sleSFBM.EditValue ?? "";
            command.Parameters.Add("ls_DQID", OracleType.VarChar).Value = sleDQ.EditValue ?? "";
            command.Parameters.Add("ls_YZBM", OracleType.VarChar).Value = teYZBM.Text;
            command.Parameters.Add("ls_TXDZ", OracleType.VarChar).Value = teTXDZ.Text;
            command.Parameters.Add("ls_DH", OracleType.VarChar).Value = teDH.Text;
            command.Parameters.Add("ls_CZ", OracleType.VarChar).Value = teCZ.Text;
            command.Parameters.Add("ls_LXR", OracleType.VarChar).Value = teLXR.Text;
            command.Parameters.Add("ls_KHYH", OracleType.VarChar).Value = teKHYH.Text;
            command.Parameters.Add("ls_ZH", OracleType.VarChar).Value = teZH.Text;
            command.Parameters.Add("ls_SH", OracleType.VarChar).Value = teSH.Text;
            command.Parameters.Add("ls_EMAIL", OracleType.VarChar).Value = teEMAIL.Text;
            command.Parameters.Add("ls_WZ", OracleType.VarChar).Value = teWZ.Text;
            command.Parameters.Add("ls_JSFSID", OracleType.VarChar).Value = teJSFS.Text;
            command.Parameters.Add("ls_TSSX", OracleType.Number).Value = teTSSX.EditValue ?? 0;
            command.Parameters.Add("ls_TSXX", OracleType.Number).Value = teTSXX.EditValue ?? 0;
            command.Parameters.Add("ls_SDSX", OracleType.Number).Value = teSDSX.EditValue ?? 0;
            command.Parameters.Add("ls_SDXX", OracleType.Number).Value = teSDXX.EditValue ?? 0;
            command.Parameters.Add("ls_ZKSX", OracleType.Number).Value = teZKSX.EditValue ?? 0;
            command.Parameters.Add("ls_ZKXX", OracleType.Number).Value = teZKXX.EditValue ?? 0;
            command.Parameters.Add("ls_JSDWID", OracleType.VarChar).Value = sleJSDW.EditValue ?? "";
            command.Parameters.Add("ls_DJSDBZ", OracleType.VarChar).Value = cbeDJSDBZ.Text;
            command.Parameters.Add("ls_TSJSDBZ", OracleType.VarChar).Value = cbeTSJSDBZ.Text;
            command.Parameters.Add("ls_KHZZYFBZ", OracleType.Number).Value = teZZYFBZ.EditValue ?? 0;
            command.Parameters.Add("ls_KHZZBZFBZ", OracleType.Number).Value = teZZBZFBZ.EditValue ?? 0;
            command.Parameters.Add("ls_KHZZQTFYBZ", OracleType.Number).Value = teZZQTFYBZ.EditValue ?? 0;
            command.Parameters.Add("ls_CGJSZQ", OracleType.Number).Value = teCGJSZQ.EditValue ?? 0;
            command.Parameters.Add("ls_TSJSZQ", OracleType.Number).Value = teXSJSZQ.EditValue ?? 0;
            command.Parameters.Add("ls_SHDZ", OracleType.VarChar).Value = teSHDZ.Text;
            command.Parameters.Add("ls_KJDZ", OracleType.VarChar).Value = teKJDZ.Text;
            command.Parameters.Add("ls_MJDZ", OracleType.VarChar).Value = teMJDZ.Text;
            command.Parameters.Add("ls_YSFSID", OracleType.VarChar).Value = cbYSFS.SelectedValue;
            command.Parameters.Add("ls_YSFXID", OracleType.VarChar).Value = teYSFX.Text;
            command.Parameters.Add("ls_ZZDBZ", OracleType.VarChar).Value = teZZDBZ.Text;
            command.Parameters.Add("ls_YZDBH", OracleType.VarChar).Value = teYZDBH.Text;
            command.Parameters.Add("ls_EZDBH", OracleType.VarChar).Value = teEZDBH.Text;
            command.Parameters.Add("ls_KFDZ", OracleType.VarChar).Value = teKFDZ.Text;
            command.Parameters.Add("ls_TDYZS", OracleType.Number).Value = teTTDYZS.EditValue ?? 0;
            command.Parameters.Add("ls_DWTJBH", OracleType.VarChar).Value = teTJBH.Text;
            command.Parameters.Add("ls_CGJSYXJB", OracleType.Number).Value = teCGJSYXJ.EditValue ?? 0;
            command.Parameters.Add("ls_XSJSYXJB", OracleType.Number).Value = teXSJSYXJ.EditValue ?? 0;
            command.Parameters.Add("ls_PHYXJB", OracleType.Number).Value = tePHYXJ.EditValue ?? 0;
            command.Parameters.Add("ls_XTYXJB", OracleType.Number).Value = teXTYXJ.EditValue ?? 0;
            command.Parameters.Add("ls_JTYXJB", OracleType.Number).Value = teJTYXJ.EditValue ?? 0;
            command.Parameters.Add("ls_CGYXJB", OracleType.Number).Value = teCGYXJ.EditValue ?? 0;
            command.Parameters.Add("ls_WEBYH", OracleType.VarChar).Value = teWEBYH.Text;
            command.Parameters.Add("ls_WEBMM", OracleType.VarChar).Value = teWEBMM.Text;
            command.Parameters.Add("ls_ZT", OracleType.VarChar).Value = cbeZT.Text;
            command.Parameters.Add("ls_CJR", OracleType.VarChar).Value = FrmLogin.getUserName;
            command.Parameters.Add("ls_TYR", OracleType.VarChar).Value = "";
            command.Parameters.Add("ls_BZ", OracleType.VarChar).Value = teBZ.Text;
            command.Parameters.Add("ls_SFZT", OracleType.VarChar).Value = cbSFZT.SelectedValue;
            command.Parameters.Add("ls_CWXTID", OracleType.VarChar).Value = "";

            command.Parameters.Add("descerr", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
            command.Parameters.Add("Message", OracleType.VarChar, 255).Direction = ParameterDirection.Output;

            command.ExecuteNonQuery();

            transaction.Commit();
            MessageBox.Show(command.Parameters["Message"].Value.ToString());
        }

        private void btnSaveContinue_Click(object sender, EventArgs e)
        {
            if (teDWBH.Text == "")
            {
                MessageBox.Show("请输入单位编号");
                teDWBH.Focus();
            }
            else if (teDWMC.Text == "")
            {
                MessageBox.Show("请输入单位名称");
                teDWMC.Focus();
            }
            else if (teWEBMM.Text == "")
            {
                MessageBox.Show("请输入WEB密码");
                teWEBMM.Focus();
            }
            else if (teWEBYH.Text == "")
            {
                MessageBox.Show("请输入WEB用户");
                teWEBYH.Focus();
            }
            else if (cbYSFS.Text == "")
            {
                MessageBox.Show("请输入运输方式");
                cbYSFS.Focus();
            }
            else if (cbDWSX.Text == "")
            {
                MessageBox.Show("请输入单位属性");
                cbDWSX.Focus();
            }
            else if (cbBMLX.Text == "")
            {
                MessageBox.Show("请输入部门类型");
                cbBMLX.Focus();
            }
            else if (cbGYSLX.Text == "")
            {
                MessageBox.Show("请输入供应商类型");
                cbGYSLX.Focus();
            }
            else if (cbKHLX.Text == "")
            {
                MessageBox.Show("请输入客户类型");
                cbKHLX.Focus();
            }
            else if (cbKFLX.Text == "")
            {
                MessageBox.Show("请输入库房类型");
                cbKFLX.Focus();
            }
            else if (cbYSCLX.Text == "")
            {
                MessageBox.Show("请输入印刷厂类型");
                cbYSCLX.Focus();
            }
            else if (cbCBSLX.Text == "")
            {
                MessageBox.Show("请输入出版社类型");
                cbCBSLX.Focus();
            }
            else if (cbYSDWLX.Text == "")
            {
                MessageBox.Show("请输入运输单位类型");
                cbYSDWLX.Focus();
            }
            else
            {
                using (OracleConnection connection = new OracleConnection(FrmLogin.strDataCent))
                {
                    connection.Open();
                    OracleCommand command = connection.CreateCommand();
                    OracleTransaction transaction = connection.BeginTransaction();
                    command.Connection = connection;
                    command.Transaction = transaction;
                    try
                    {
                        if (this.Text == "增加单位")
                        {
                            vAddDepart(command, transaction);
                            btnClear_Click(sender, e);
                        }
                        else if (this.Text == "修改单位")
                        {
                            vUpdateDepart(command, transaction);
                            btnClear_Click(sender, e);
                        }
                    }
                    catch (Exception exception)
                    {
                        transaction.Rollback();
                        MessageBox.Show(exception.ToString());
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void btnSaveEnd_Click(object sender, EventArgs e)
        {
            if (teDWBH.Text == "")
            {
                MessageBox.Show("请输入单位编号");
                teDWBH.Focus();
            }
            else if (teDWMC.Text == "")
            {
                MessageBox.Show("请输入单位名称");
                teDWMC.Focus();
            }
            else if (teWEBMM.Text == "")
            {
                MessageBox.Show("请输入WEB密码");
                teWEBMM.Focus();
            }
            else if (teWEBYH.Text == "")
            {
                MessageBox.Show("请输入WEB用户");
                teWEBYH.Focus();
            }
            else if (cbYSFS.Text == "")
            {
                MessageBox.Show("请输入运输方式");
                cbYSFS.Focus();
            }
            else if (cbDWSX.Text == "")
            {
                MessageBox.Show("请输入单位属性");
                cbDWSX.Focus();
            }
            else if (cbBMLX.Text == "")
            {
                MessageBox.Show("请输入部门类型");
                cbBMLX.Focus();
            }
            else if (cbGYSLX.Text == "")
            {
                MessageBox.Show("请输入供应商类型");
                cbGYSLX.Focus();
            }
            else if (cbKHLX.Text == "")
            {
                MessageBox.Show("请输入客户类型");
                cbKHLX.Focus();
            }
            else if (cbKFLX.Text == "")
            {
                MessageBox.Show("请输入库房类型");
                cbKFLX.Focus();
            }
            else if (cbYSCLX.Text == "")
            {
                MessageBox.Show("请输入印刷厂类型");
                cbYSCLX.Focus();
            }
            else if (cbCBSLX.Text == "")
            {
                MessageBox.Show("请输入出版社类型");
                cbCBSLX.Focus();
            }
            else if (cbYSDWLX.Text == "")
            {
                MessageBox.Show("请输入运输单位类型");
                cbYSDWLX.Focus();
            }
            else
            {
                using (OracleConnection connection = new OracleConnection(FrmLogin.strDataCent))
                {
                    connection.Open();
                    OracleCommand command = connection.CreateCommand();
                    OracleTransaction transaction = connection.BeginTransaction();
                    command.Connection = connection;
                    command.Transaction = transaction;
                    try
                    {
                        if (this.Text == "增加单位")
                        {
                            vAddDepart(command, transaction);
                            this.Close();
                        }
                        else if (this.Text == "修改单位")
                        {
                            vUpdateDepart(command, transaction);
                            this.Close();
                        }

                    }
                    catch (Exception exception)
                    {
                        transaction.Rollback();
                        MessageBox.Show(exception.ToString());
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            teBZ.Text = "";
            teCGJSYXJ.Text = "";
            teCGJSZQ.Text = "";
            teCGYXJ.Text = "";
            teCZ.Text = "";
            teDH.Text = "";
            teDWBH.Text = "";
            teDWFR.Text = "";
            teDWJB.Text = "";
            teDWJC.Text = "";
            teDWMC.Text = "";
            teEMAIL.Text = "";
            teEZDBH.Text = "";
            teJSFS.Text = "";
            teJTYXJ.Text = "";
            teKFDZ.Text = "";
            teKHYH.Text = "";
            teKJDZ.Text = "";
            teLXR.Text = "";
            teMJDZ.Text = "";
            tePHYXJ.Text = "";
            teSDSX.Text = "";
            teSDXX.Text = "";
            teSH.Text = "";
            teSHDZ.Text = "";
            teTJBH.Text = "";
            teTSSX.Text = "";
            teTSXX.Text = "";
            teTTDYZS.Text = "";
            teTXDZ.Text = "";
            teWEBMM.Text = "";
            teWEBYH.Text = "";
            teWZ.Text = "";
            teXSJSYXJ.Text = "";
            teXSJSZQ.Text = "";
            teXTYXJ.Text = "";
            teYSFX.Text = "";
            teYZBM.Text = "";
            teYZDBH.Text = "";
            teZH.Text = "";
            teZJM.Text = "";
            teZKSX.Text = "";
            teZKXX.Text = "";
            teZZBZFBZ.Text = "";
            teZZDBZ.Text = "";
            teZZQTFYBZ.Text = "";
            teZZYFBZ.Text = "";
            sleDQ.Text = "";
            sleDWXX.Text = "";
            sleJSDW.Text = "";
            sleSFBM.Text = "";
            sleZTBM.Text = "";
            cbBMLX.SelectedIndex = 0;
            cbCBSLX.SelectedIndex = 0;
            cbDWSX.SelectedIndex = 0;
            cbeZT.SelectedIndex = 0;
            cbGYSLX.SelectedIndex = 0;
            cbKFLX.SelectedIndex = 0;
            cbKHLX.SelectedIndex = 0;
            cbSFZT.SelectedIndex = 0;
            cbYSCLX.SelectedIndex = 0;
            cbYSDWLX.SelectedIndex = 0;
            cbYSFS.SelectedIndex = 0;
            cbeDJSDBZ.Text = "";
            cbeTSJSDBZ.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}