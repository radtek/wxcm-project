using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace ClientMain
{
    public partial class FrmGoodsAdd : Form
    {
        private string[] strnum_13 = new string[13];//13位书号
        private string[] strnum_10 = new string[10];//10位书号
        private bool fgCheckTXM = false;//判断输入条形码是否正确
        private string CBSBMid = "";//根据条形码判断出来的出版社编码ID
        private string StrCon = FrmLogin.strDataCent;
        public FrmGoodsAdd()
        {
            InitializeComponent();
            this.Tag = "";
        }
        public FrmGoodsAdd(string spid)
        {
            InitializeComponent();
            this.Tag = spid;
        }
        private string GetYXBZID(string text)
        {
            string yxztid="0";
            if (text == "正常")
            {
                yxztid = "0";
            }
            else if (text == "异型")
            {
                yxztid = "1";
            }
            return yxztid;
 
        }
        private string GetYXBZMC(string yxztid)
        {
            string text = "正常";
            if (yxztid == "0")
            {
                text = "正常";
            }
            else if (yxztid == "1")
            {
                text = "异型";
            }
            return text;

        }
        private decimal GetCBNY(string str)
       {
            decimal a=0;
            if (string.IsNullOrEmpty(str))
            {
                a=0;
            }
                else
            {
                a = Convert.ToDecimal(str);
            }
            return a;

       }
        private decimal GetDJ(string str)
        {
             decimal a=0;
             if (string.IsNullOrEmpty(str))
            {
                a=0;
            }
                else
            {
                a = Convert.ToDecimal(str);
            }
            return a;
        }
        private decimal GetYZS(string str)
        {
            decimal a = 0;
            if (string.IsNullOrEmpty(str))
            {
                a = 0;
            }
            else
            {
                a = Convert.ToDecimal(str);
            }
            return a;
        }
        private void Alter_Load(string spxxid)
        {
            OracleConnection Mycon = new OracleConnection(StrCon);
            string StrSpxxSelect = "select TXM,SPBH,DJ,CBSID,CBSMC,BBID,BBMC,PM,ZT,KBID,KBMC,ZZID,ZZMC,YZS,YZID,YZMC,CBNY,YSSJ,BC,YC,CBFLID,CBFLMC,FXFLID,FXFLMC,ZZ,BZ,YZ,SPSXID,SPSXMC,YXJZID,YXJZMC,SL,GG,HD,ZL,XH,YXBZ,BEIZ from VIEW_JT_J_SPXX where SPXXID='" + spxxid + "'";
            try
            {
                Mycon.Open();
                OracleCommand Comm = new OracleCommand(StrSpxxSelect, Mycon);
                OracleDataReader reader = Comm.ExecuteReader();
                while (reader.Read())
                {
                    txtTXM.Text = reader["TXM"].ToString();
                    txtSPBH.Text = reader["SPBH"].ToString();
                    txtDJ.Text = reader["DJ"].ToString();
                    txtCBS.Tag = reader["CBSID"].ToString();
                    txtCBS.Text = reader["CBSMC"].ToString();
                    txtBB.Tag = reader["BBID"].ToString();
                    txtBB.Text = reader["BBMC"].ToString();
                    txtPM.Text = reader["PM"].ToString();
                    comZT.Text = reader["ZT"].ToString();
                    txtKB.Tag = reader["KBID"].ToString();
                    txtKB.Text = reader["KBMC"].ToString();
                    txtZZID.Text = reader["ZZMC"].ToString();
                    txtZZID.Tag = reader["ZZID"].ToString();
                    txtYZS.Text = reader["YZS"].ToString();
                    txtYZID.Text = reader["YZMC"].ToString();
                    txtYZID.Tag = reader["YZID"].ToString();
                    txtCBNY.Text = reader["CBNY"].ToString();
                    txtYSSJ.Text = reader["YSSJ"].ToString();
                    txtBC.Text = reader["BC"].ToString();
                    txtYC.Text = reader["YC"].ToString();
                    txtCBFLID.Tag = reader["CBFLID"].ToString();
                    txtCBFLID.Text = reader["CBFLMC"].ToString();
                    txtFXFLID.Text = reader["FXFLMC"].ToString();
                    txtFXFLID.Tag = reader["FXFLID"].ToString();
                    txtZZ.Text = reader["ZZ"].ToString();
                    txtBZ.Text = reader["BZ"].ToString();
                    txtYZ.Text = reader["YZ"].ToString();
                    txtSPSXID.Tag = reader["SPSXID"].ToString();
                    txtSPSXID.Text = reader["SPSXMC"].ToString();
                    txtYXJZID.Tag = reader["YXJZID"].ToString();
                    txtYXJZID.Text = reader["YXJZMC"].ToString();
                    comSL.Text = reader["SL"].ToString();
                    txtGG.Text = reader["GG"].ToString();
                    txtHD.Text = reader["HD"].ToString();
                    txtZL.Text = reader["ZL"].ToString();
                    txtXH.Text = reader["XH"].ToString();
                    comYXBZ.Text = GetYXBZMC(reader["YXBZ"].ToString()); 
                    txtBEIZ.Text = reader["BEIZ"].ToString();

                }
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Mycon.Close();
            }
 
        }
        private void None_Load()
        {
            txtTXM.Text = "";
            txtSPBH.Text = "";
            txtDJ.Text = "";
            txtCBS.Text = "";
            txtCBS.Tag = "";
            txtBB.Text = "";
            txtBB.Tag = "";
            txtPM.Text = "";
            comZT.Text = "录入";
            comZT.Enabled = false;
            txtKB.Text = "";
            txtKB.Tag = "";
            txtZZID.Text = "";
            txtZZID.Tag = "";
            txtYZS.Text = "";
            txtYZID.Text = "";
            txtYZID.Tag = "";
            txtCBNY.Text = "";
            txtYSSJ.Text = "";
            txtBC.Text = "";
            txtYC.Text = "";
            txtCBFLID.Text = "";
            txtCBFLID.Tag = "";
            txtFXFLID.Text = "";
            txtFXFLID.Tag = "";
            txtZZ.Text = "";
            txtBZ.Text = "";
            txtYZ.Text = "";
            txtSPSXID.Text = "";
            txtSPSXID.Tag = "";
            txtYXJZID.Text = "";
            txtYXJZID.Tag = "";
            comSL.Text = "";
            txtGG.Text = "";
            txtHD.Text = "";
            txtZL.Text = "";
            txtXH.Text = "";
            comYXBZ.Text = "";
            txtBEIZ.Text = "";
            
        }
        private bool Check()
        {
            bool CheckTerms = false;
            if(txtTXM.Text==""||txtSPBH.Text==""||txtCBS.Text==""||txtDJ.Text==""||txtBB.Text==""||txtPM.Text==""||comZT.Text==""||txtCBNY.Text==""||txtFXFLID.Text=="")
            {
                CheckTerms = false;
            }
            else
            {
                CheckTerms = true;
            }
            return CheckTerms;
        }
        private void UpdataSpxx()
        {

                OracleConnection Myconn = new OracleConnection(StrCon);
                string strUpdate = "UPDATE JT_J_SPXX SET TXM = '" + txtTXM.Text.Trim() + "',SPBH='" + txtSPBH.Text.Trim() + "',DJ='" + GetDJ(txtDJ.Text.Trim()) + "',CBSID='" + txtCBS.Tag.ToString() + "',BBID='" + txtBB.Tag.ToString() + "',PM='" + txtPM.Text.Trim() + "',ZT='" + comZT.Text.Trim() + "',KBID='" + txtKB.Tag.ToString() + "',ZZID='" + txtZZID.Tag.ToString() + "',YZS='" + GetYZS(txtYZS.Text.Trim()) + "',YZID='" + txtYZID.Tag.ToString() + "',CBNY='" + GetCBNY(txtCBNY.Text.Trim()) + "',YSSJ='" + txtYSSJ.Text.Trim() + "',BC='" + txtBC.Text.Trim() + "',YC='" + txtYC.Text.Trim() + "',CBFLID='" + txtCBFLID.Tag.ToString() + "',FXFLID='" + txtFXFLID.Tag.ToString() + "',ZZ='" + txtZZ.Text.Trim() + "',BZ='" + txtBZ.Text.Trim() + "',YZ='" + txtYZ.Text.Trim() + "',SPSXID='" + txtSPSXID.Tag.ToString() + "',YXJZID='" + txtYXJZID.Tag.ToString() + "',SL='" + comSL.Text.Trim() + "',GG='" + txtGG.Text.Trim() + "',HD='" + txtHD.Text.Trim() + "',ZL='" + txtZL.Text.Trim() + "',XH='" + txtXH.Text.Trim() + "',YXBZ='" + GetYXBZID(comYXBZ.Text.Trim()) + "',BEIZ='" + txtBEIZ.Text.Trim() + "',XGRYID='" + FrmLogin.getUserID + "',CZRQ=sysdate WHERE SPXXID ='" + this.Tag.ToString() + "'";
                try 
                {
                    Myconn.Open();
                    OracleCommand Comm = new OracleCommand(strUpdate,Myconn);
                    Comm.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Myconn.Close();
                }
        }
        private void InsertSpxx()
        {
            OracleConnection Myconn = new OracleConnection(StrCon);
            string strInsert = "INSERT INTO JT_J_SPXX (SPXXID,TXM,SPBH,DJ,CBSID,BBID,PM,ZT,KBID,ZZID,YZS,YZID,CBNY,YSSJ,BC,YC,CBFLID,FXFLID,ZZ,BZ,YZ,SPSXID,YXJZID,SL,GG,HD,ZL,XH,YXBZ,BEIZ,LRRY,LRRQ) values(JT_J_SPXX_SEQ.NEXTVAL,'" + txtTXM.Text.Trim() +
                               "','" + txtSPBH.Text.Trim() + "','" + GetDJ(txtDJ.Text.Trim()) + "','" + txtCBS.Tag.ToString() + "','" + txtBB.Tag.ToString() + "','" + txtPM.Text.Trim() + "','" + comZT.Text.Trim() +
                               "','" + txtKB.Tag.ToString() + "','" + txtZZID.Tag.ToString() + "','" + GetYZS(txtYZS.Text.Trim()) + "','" + txtYZID.Tag.ToString() + "','" + GetCBNY(txtCBNY.Text.Trim()) +
                               "','" + txtYSSJ.Text.Trim() + "','" + txtBC.Text.Trim() + "','" + txtYC.Text.Trim() + "','" + txtCBFLID.Tag.ToString() + "','" + txtFXFLID.Tag.ToString() + "','" + txtZZ.Text.Trim() +
                               "','" + txtBZ.Text.Trim() + "','" + txtYZ.Text.Trim() + "','" + txtSPSXID.Tag.ToString() + "','" + txtYXJZID.Tag.ToString() + "','" + comSL.Text.Trim() + "','" + txtGG.Text.Trim() +
                               "','" + txtHD.Text.Trim() + "','" + txtZL.Text.Trim() + "','" + txtXH.Text.Trim() + "','" + GetYXBZID(comYXBZ.Text.Trim()) + "','" + txtBEIZ.Text.Trim() + "','"+FrmLogin.getUserID+"',sysdate)";
            try
            {
                Myconn.Open();
                OracleCommand Comm = new OracleCommand(strInsert, Myconn);
                Comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Myconn.Close();
            }
        }
        private void FrmGoodsAdd_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.Tag.ToString()))
            {
                Alter_Load(this.Tag.ToString());
            }
            else
            {
                None_Load();
            }

        }

        private void btnSelectOperator_Click(object sender, EventArgs e)
        {
            FrmChuBanShe from = new FrmChuBanShe(txtCBS.Text.Trim());
            if (from.ShowDialog() == DialogResult.OK)
            {
                txtCBS.Text = FrmChuBanShe.cbsmc;
                txtCBS.Tag = FrmChuBanShe.cbsid;
            }

        }

        private void btnBanBie_Click(object sender, EventArgs e)
        {
            FrmBanBie from = new FrmBanBie(txtBB.Text.Trim());
            if (from.ShowDialog() == DialogResult.OK)
            {
                txtBB.Text = FrmBanBie.bbmc;
                txtBB.Tag = FrmBanBie.bbid; 
            }
        }

        private void btnKB_Click(object sender, EventArgs e)
        {
            FrmKaiBen from = new FrmKaiBen(txtKB.Text.Trim());
            if (from.ShowDialog() == DialogResult.OK)
            {
                txtKB.Text = FrmKaiBen.KBMC;
                txtKB.Tag = FrmKaiBen.KBID;
            }
        }

        private void btnZZID_Click(object sender, EventArgs e)
        {
            FrmZhuangZhen from = new FrmZhuangZhen(txtZZID.Text.Trim());
            if (from.ShowDialog() == DialogResult.OK)
            {
                txtZZID.Text = FrmZhuangZhen.ZZMC;
                txtZZID.Tag = FrmZhuangZhen.ZZID;
                
            }
        }

        private void btnYZID_Click(object sender, EventArgs e)
        {
            FrmYuZhong from = new FrmYuZhong(txtYZID.Text.Trim());
            if(from.ShowDialog()==DialogResult.OK)
            {
                txtYZID.Text = FrmYuZhong.yzmc;
                txtYZID.Tag = FrmYuZhong.yzid;
            }
        }

        private void btnCBFLID_Click(object sender, EventArgs e)
        {
            FrmChuBanFenLei from = new FrmChuBanFenLei(txtCBFLID.Text);
            if(from.ShowDialog()==DialogResult.OK)
            {
                txtCBFLID.Text = FrmChuBanFenLei.cbflmc;
                txtCBFLID.Tag = FrmChuBanFenLei.cbflid;
            }

        }

        private void btnFXFLID_Click(object sender, EventArgs e)
        {
            FrmFaXingFenLei from = new FrmFaXingFenLei(txtFXFLID.Text.Trim());
            if(from.ShowDialog()==DialogResult.OK)
            {
                txtFXFLID.Text = FrmFaXingFenLei.fxflMC;
                txtFXFLID.Tag = FrmFaXingFenLei.fxflID;
            }
        }

        private void btnSPSXID_Click(object sender, EventArgs e)
        {
            FrmShangPinShuXing from = new FrmShangPinShuXing(txtSPSXID.Text.Trim());
            if(from.ShowDialog()==DialogResult.OK)
            {
                txtSPSXID.Text = FrmShangPinShuXing.spsxMC;
                txtSPSXID.Tag = FrmShangPinShuXing.spsxID;
            }
        }

        private void btnYXJZID_Click(object sender, EventArgs e)
        {
            FrmYinXiangJieZhi from = new FrmYinXiangJieZhi(txtYXJZID.Text.Trim());
            if(from.ShowDialog()==DialogResult.OK)
            {
                txtYXJZID.Text=FrmYinXiangJieZhi.yxjzMC;
                txtYXJZID.Tag=FrmYinXiangJieZhi.yxjzID;
            }
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.Tag.ToString()))
            {
                Alter_Load(this.Tag.ToString());
            }
            else
            {
                None_Load();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.Tag.ToString()))
            {
                if (Check() == true)
                {
                    UpdataSpxx();
                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }
                else
                {
                    MessageBox.Show("条形码，品名，商品编号，定价，发行类型，出版社，出版年月，状态，版别不能为空", "提示");
                }
                


            }
            else
            {
                if (Check() == true)
                {
                    InsertSpxx();
                    None_Load();
                    txtTXM.Focus();
                }
                else
                {
                    MessageBox.Show("条形码，品名，商品编号，定价，发行类型，出版社，出版年月，状态，版别不能为空", "提示");
                }

            }
        }
        private void txtTXM_TextChanged(object sender, EventArgs e)

        {
            txtSPBH.Text = txtTXM.Text;
        }
        private void txtTXM_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckTXM(txtTXM.Text.Trim());//判断是否合法
                if (fgCheckTXM == true)//根据合法值将出版社编号ID赋予TXTCBS的TAG上
                {
                    if(txtTXM.Text.Trim().Length==10)
                    {
                        string lastTXM = "978" + txtTXM.Text.Trim();
                        if (Convert.ToInt32(lastTXM.Substring(3, 1)) >= 0 && Convert.ToInt32(lastTXM.Substring(3, 2)) <= 7)
                        {
                            GetCBSid(lastTXM, 4);
                        }
                        else if (Convert.ToInt32(lastTXM.Substring(3, 2)) >= 80 && Convert.ToInt32(lastTXM.Substring(3, 2)) <= 94)
                        {
                            GetCBSid(lastTXM, 5);
                        }
                        else if (Convert.ToInt32(lastTXM.Substring(3, 3)) >= 950 && Convert.ToInt32(lastTXM.Substring(3, 2)) <= 995)
                        {
                            GetCBSid(lastTXM, 6);
                        }
                        else if (Convert.ToInt32(lastTXM.Substring(3, 4)) >= 9960 && Convert.ToInt32(lastTXM.Substring(3, 4)) <= 9989)
                        {
                            GetCBSid(lastTXM, 7);
                        }
                        else if (Convert.ToInt32(lastTXM.Substring(3, 5)) >= 99900 && Convert.ToInt32(lastTXM.Substring(3, 4)) <= 99999)
                        {
                            GetCBSid(lastTXM, 8);
                        }

                    }
                    else if (txtTXM.Text.Trim().Length == 13)
                    {
                        string lastTXM = txtTXM.Text.Trim();
                        if (Convert.ToInt32(lastTXM.Substring(3, 1)) >= 0 && Convert.ToInt32(lastTXM.Substring(3, 2)) <= 7)
                        {
                            GetCBSid(lastTXM,4);
                        }
                        else if (Convert.ToInt32(lastTXM.Substring(3, 2)) >= 80 && Convert.ToInt32(lastTXM.Substring(3, 2)) <= 94)
                        {
                            GetCBSid(lastTXM,5);
                        }
                        else if (Convert.ToInt32(lastTXM.Substring(3, 3)) >= 950 && Convert.ToInt32(lastTXM.Substring(3, 2)) <= 995)
                        {
                            GetCBSid(lastTXM,6);
                        }
                        else if (Convert.ToInt32(lastTXM.Substring(3, 4)) >= 9960 && Convert.ToInt32(lastTXM.Substring(3, 4)) <= 9989)
                        {
                            GetCBSid(lastTXM,7);
                        }
                        else if (Convert.ToInt32(lastTXM.Substring(3, 5)) >= 99900 && Convert.ToInt32(lastTXM.Substring(3, 4)) <= 99999)
                        {
                            GetCBSid(lastTXM,8);
                        }
                    }
                    //开始从数据库提取相关
                    GetCBSXX(CBSBMid);
                }
                else
                {
                    MessageBox.Show("您输入的条形码非法1111","警告");
                }
            }
        }
        private void CheckTXM(string str)
        {
            
            if (GetIsExitChar(str.Trim()) == true)
            {
                if (str.Length == 10)
                {
                    int sum = 0;
                    for (int i = 0; i < str.Length; i++)
                    {
                        strnum_10[i] = str.Substring(i, 1);
                        if ((i % 2) == 0)
                        {
                            sum = Convert.ToInt32(strnum_10[i]) * 3+sum;
                        }
                        else
                        {
                            sum = Convert.ToInt32(strnum_10[i]) * 1+sum;
                        }
                    }
                    if (10 - (sum % 10) == Convert.ToInt32(strnum_10[9]))
                    {
                        fgCheckTXM = true;
                    }
                    else
                    {
                        fgCheckTXM = false;
                    }
                }
                else if (str.Length == 13)
                {
                    int sum = 0;
                    for(int i=0;i<str.Length;i++)
                    {
                        strnum_13[i] = str.Substring(i,1);
                        if ((i % 2) == 0)
                        {
                            sum = Convert.ToInt32(strnum_13[i])*1+sum;
                        }
                        else
                        {
                            sum = Convert.ToInt32(strnum_13[i]) * 3+sum;
                        }
                    }
                    if (10 - (sum % 10) == Convert.ToInt32(strnum_13[12]) || (10 - (sum % 10))==10)
                    {
                        fgCheckTXM = true;
                    }
                    else
                    {
                        fgCheckTXM = false;
                    }
           
                }
                else
                {
                    MessageBox.Show("条形码必须是十三位或者十位", "警告");
                    txtTXM.Text = "";
                    txtSPBH.Text = "";
                    txtTXM.Focus();
                }
            }
            else
            {
                MessageBox.Show("您输入的编号不是纯数字","警告 ");
                txtTXM.Text = "";
                txtSPBH.Text = "";
                txtTXM.Focus();
            }
        }//判断条形码是否合法算法
        private bool GetIsExitChar(string strchar)
        {
            try { Convert.ToInt64(strchar); return true; }
            catch(Exception ex)
            {
                if (!string.IsNullOrEmpty(ex.Message.ToString()))
                { return false; }
                else
                { return true; }
            }
        }//判断是否输入的条形码全是数字字符
        private void GetCBSid(string strtxm,int i)
        {
            if(Convert.ToInt32(strtxm.Substring(i,2)) >= 0 && Convert.ToInt32(strtxm.Substring(i,2)) <= 9)
            {
                CBSBMid = strtxm.Substring(i, 2);
            }
            else if (Convert.ToInt32(strtxm.Substring(i, 3)) >= 100 && Convert.ToInt32(strtxm.Substring(i, 3)) <= 499)
            {
                CBSBMid = strtxm.Substring(i, 3);
            }
            else if (Convert.ToInt32(strtxm.Substring(i, 4)) >= 5000 && Convert.ToInt32(strtxm.Substring(i, 4)) <= 7999)
            {
                CBSBMid = strtxm.Substring(i, 4);
            }
            else if (Convert.ToInt32(strtxm.Substring(i, 5)) >= 80000 && Convert.ToInt32(strtxm.Substring(i, 5)) <= 89999)
            {
                CBSBMid = strtxm.Substring(i, 5);
            }
            else if (Convert.ToInt32(strtxm.Substring(i, 6)) >= 900000 && Convert.ToInt32(strtxm.Substring(i, 6)) <= 989999)
            {
                CBSBMid = strtxm.Substring(i, 6);
            }
            else if (Convert.ToInt32(strtxm.Substring(i, 7)) >= 9900000 && Convert.ToInt32(strtxm.Substring(i, 7)) <= 9999999)
            {
                CBSBMid = strtxm.Substring(i, 7);
            }
        }
        private void GetCBSXX(string id)
        {
            OracleConnection Mycon = new OracleConnection(StrCon);
            string StrSpxxSelect = "select DJ,CBSID,CBSMC,BBID,BBMC,PM,ZT,KBID,KBMC,ZZID,ZZMC,YZS,YZID,YZMC,CBNY,YSSJ,BC,YC,CBFLID,CBFLMC,FXFLID,FXFLMC,ZZ,BZ,YZ,SPSXID,SPSXMC,YXJZID,YXJZMC,SL,GG,HD,ZL,XH,YXBZ,BEIZ from VIEW_JT_J_SPXX where TXM='" + txtTXM.Text.Trim() + "'";
            try
            {
                Mycon.Open();
                OracleCommand Comm = new OracleCommand(StrSpxxSelect, Mycon);
                OracleDataReader reader = Comm.ExecuteReader();
                while (reader.Read())
                {
               //     txtTXM.Text = reader["TXM"].ToString();
                //    txtSPBH.Text = reader["SPBH"].ToString();
                    txtDJ.Text = reader["DJ"].ToString();
                    txtCBS.Tag = reader["CBSID"].ToString();
                    txtCBS.Text = reader["CBSMC"].ToString();
                    txtBB.Tag = reader["BBID"].ToString();
                    txtBB.Text = reader["BBMC"].ToString();
                    txtPM.Text = reader["PM"].ToString();
                    comZT.Text = reader["ZT"].ToString();
                    txtKB.Tag = reader["KBID"].ToString();
                    txtKB.Text = reader["KBMC"].ToString();
                    txtZZID.Text = reader["ZZMC"].ToString();
                    txtZZID.Tag = reader["ZZID"].ToString();
                    txtYZS.Text = reader["YZS"].ToString();
                    txtYZID.Text = reader["YZMC"].ToString();
                    txtYZID.Tag = reader["YZID"].ToString();
                    txtCBNY.Text = reader["CBNY"].ToString();
                    txtYSSJ.Text = reader["YSSJ"].ToString();
                    txtBC.Text = reader["BC"].ToString();
                    txtYC.Text = reader["YC"].ToString();
                    txtCBFLID.Tag = reader["CBFLID"].ToString();
                    txtCBFLID.Text = reader["CBFLMC"].ToString();
                    txtFXFLID.Text = reader["FXFLMC"].ToString();
                    txtFXFLID.Tag = reader["FXFLID"].ToString();
                    txtZZ.Text = reader["ZZ"].ToString();
                    txtBZ.Text = reader["BZ"].ToString();
                    txtYZ.Text = reader["YZ"].ToString();
                    txtSPSXID.Tag = reader["SPSXID"].ToString();
                    txtSPSXID.Text = reader["SPSXMC"].ToString();
                    txtYXJZID.Tag = reader["YXJZID"].ToString();
                    txtYXJZID.Text = reader["YXJZMC"].ToString();
                    comSL.Text = reader["SL"].ToString();
                    txtGG.Text = reader["GG"].ToString();
                    txtHD.Text = reader["HD"].ToString();
                    txtZL.Text = reader["ZL"].ToString();
                    txtXH.Text = reader["XH"].ToString();
                    comYXBZ.Text = GetYXBZMC(reader["YXBZ"].ToString());
                    txtBEIZ.Text = reader["BEIZ"].ToString();

                }
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Mycon.Close();
            }
            if(string.IsNullOrEmpty(txtPM.Text.Trim()))//如果品名为空，则只带出出版社与版别
            {
                string StrCBSXXselect = "select a.DWMC,a.DWID from JT_J_DWXX a  where a.DWBH='"+id+"'";
                string StrCBBBXXselect = "select a.BB,a.BBBMID from JT_J_BBBM a where a.BBBH='" + id + "'";
                try
                {
                  Mycon.Open();
                 OracleCommand Comm = new OracleCommand(StrCBSXXselect, Mycon);
                OracleDataReader reader = Comm.ExecuteReader();
                while (reader.Read())
                {
                    txtCBS.Text = reader["DWMC"].ToString();
                    txtCBS.Tag = reader["DWID"].ToString();
                }
                reader.Close();
                OracleCommand Comm1 = new OracleCommand(StrCBBBXXselect, Mycon);
                OracleDataReader reader1 = Comm1.ExecuteReader();
                while (reader1.Read())
                {
                    txtBB.Text = reader["BB"].ToString();
                    txtBB.Tag = reader["BBBMID"].ToString();
                }
                reader1.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Mycon.Close();
                }
            }
        }

      

       

      

      
       


    }
}
