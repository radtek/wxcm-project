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
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports;
using DevExpress.XtraPrinting.Localization; 

namespace ClientMain
{
    public partial class FrmGoodsInformation : Form
    {
        GridCheckMarksSelection selection;
        private string StrCon = FrmLogin.strDataCent;
       

        public FrmGoodsInformation()
        {
            InitializeComponent();
            XpoDefault.ConnectionString = FrmLogin.xpoDataCentStr;
            selection = new GridCheckMarksSelection(gridView1);
            selection.CheckMarkColumn.VisibleIndex = 0;
           xpServerCollectionSource1.FixedFilterString = "[SPXXID] Is Null";
        }

        private void FrmGoodsInformation_Load(object sender, EventArgs e)
        {
            txtBarcode.Text = "";
            txtGoodsName.Text = "";
            txtNum.Text = "";
            txtOperator.Text = "";
            comboxStauta.Text = "";
        }

        private void btnSelectOperator_Click(object sender, EventArgs e)
        {
            FrmPurchaseInvoiceKPR FrmPurchaseInvoiceKPR = new FrmPurchaseInvoiceKPR();
            if (FrmPurchaseInvoiceKPR.ShowDialog() == DialogResult.OK)
            {
                this.txtOperator.Tag = FrmPurchaseInvoiceKPR.cgfp_operatorid.ToString();

                OracleConnection MyConn = new OracleConnection(StrCon);
                try
                {
                    MyConn.Open();
                    string str = "select OPERATORNAME from BASE_OPERATOR where OPERATORID='" + this.txtOperator.Tag.ToString() + "'";
                    OracleCommand comm = new OracleCommand(str, MyConn);
                    OracleDataReader reader = comm.ExecuteReader();
                    while (reader.Read())
                    {
                        this.txtOperator.Text = reader.GetValue(0).ToString();
                    }
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
                finally
                {
                    MyConn.Close();
                }


            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtBarcode.Text = "";
            this.txtGoodsName.Text = "";
            this.txtNum.Text = "";
            this.txtOperator.Tag = "";
            this.txtOperator.Text = "";
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
             string PublicSelect =null;
            if (txtBarcode.Text!="" && string.IsNullOrEmpty(PublicSelect))
            {
                PublicSelect = "[TXM] LIKE '%" + txtBarcode.Text + "%'";
            }
            else if (txtBarcode.Text != "" && !string.IsNullOrEmpty(PublicSelect))
            {
                PublicSelect = PublicSelect + "AND [TXM] LIKE '%" + txtBarcode.Text + "%'";
            }
            else if (txtGoodsName.Text!="" && !string.IsNullOrEmpty(PublicSelect))
            {
                PublicSelect = PublicSelect + "AND [PM] Like'%" + txtGoodsName.Text.Trim() + "%'";
            }
            else if (txtGoodsName.Text != "" && string.IsNullOrEmpty(PublicSelect))
            {
                PublicSelect = "[PM] Like '%" + txtGoodsName.Text.Trim() + "%'";
            }
            else if (comboxStauta.Text!="" && !string.IsNullOrEmpty(PublicSelect))
            {
                PublicSelect = PublicSelect + "AND [ZT]=\'" + comboxStauta.Text.Trim() + "\'";
            }
            else if (comboxStauta.Text != "" && string.IsNullOrEmpty(PublicSelect))
            {
                PublicSelect = "[ZT]=\'" + comboxStauta.Text.Trim() + "\'";
            }
            else if (txtNum.Text!="" && !string.IsNullOrEmpty(PublicSelect))
            {
                PublicSelect = PublicSelect + "AND [SPBH]=\'" + txtNum.Text.Trim() + "\'";
            }
            else if (txtNum.Text != "" && string.IsNullOrEmpty(PublicSelect))
            {
                PublicSelect = "[SPBH]=\'" + txtGoodsName.Text.Trim() + "\'";
            }
            else if (txtOperator.Text!="" && !string.IsNullOrEmpty(PublicSelect))
            {
                PublicSelect = PublicSelect + "AND [LRRY]=\'" + txtNum.Text.Trim().Trim() + "\'";
            }
            else if (txtOperator.Text != "" && string.IsNullOrEmpty(PublicSelect))
            {
                PublicSelect = "[LRRY]=\'" + txtNum.Text.Trim().Trim() + "\'";
            }
            else
            {
                PublicSelect = null;

            }
            if (string.IsNullOrEmpty(PublicSelect))
            {
                MessageBox.Show( "你还没有选择条件查询","通知");
            }
            else
            {
           
                xpServerCollectionSource1.FixedFilterString = PublicSelect;
                xpServerCollectionSource1.Reload();
                gridView1.BestFitColumns();
            }
                


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmGoodsAdd from = new FrmGoodsAdd();
            if (from.ShowDialog() == DialogResult.OK)
            {
                unitOfWork1.DropIdentityMap();
                xpServerCollectionSource1.Reload();

            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要进行删除操作", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (selection.SelectedCount == 0)
                {
                    MessageBox.Show("请先选择需要删除的采购单");
                }
                else
                {
                    string Arrayid = null;
                    bool Check = false;
                    for (int i = 0; i < selection.SelectedCount; ++i)
                    {
                        int RowIndex = selection.GetSelectedRowIndex(i);
                        int RowHandle = gridView1.GetRowHandle(RowIndex);
                        string strSPXXID = gridView1.GetRowCellDisplayText(RowHandle, colSPXXID).ToString().Trim();
                        string strPM = gridView1.GetRowCellDisplayText(RowHandle, colPM).ToString().Trim();
                        string strZT = gridView1.GetRowCellDisplayText(RowHandle, colZT).ToString().Trim();
                        if (strZT == "录入")
                        {
                            if (string.IsNullOrEmpty(Arrayid))
                            { Arrayid = strSPXXID; }
                            else
                            {
                                Arrayid = strSPXXID + "," + Arrayid;
                            }
                           
                            Check = true;
                        }
                        else
                        {
                            MessageBox.Show("状态"+strPM+"的只有录入状态的商品才可以删除", "通知");
                            selection.ClearSelection();
                            Check = false;
                            break;
                        }


                    }
                    if (!string.IsNullOrEmpty(Arrayid)&&Check==true)
                    {
                        OracleConnection MyConn = new OracleConnection(StrCon);
                        string StrDelete = "DELETE FROM JT_J_SPXX WHERE SPXXID in (" + Arrayid + ")";
                        try
                        {
                            selection.ClearSelection();
                            MyConn.Open();
                            OracleCommand Comm = new OracleCommand(StrDelete, MyConn);
                            Comm.ExecuteNonQuery();
 
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            MyConn.Close();
                            unitOfWork1.DropIdentityMap();
                            xpServerCollectionSource1.Reload();
                        }
                    }

                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (selection.SelectedCount == 0)
            {
                MessageBox.Show("请先选择需要启用的的商品");
            }
            else
            { 
                    string Arrayid = null;
                    bool Check = false;
                    for (int i = 0; i < selection.SelectedCount; ++i)
                    {
                        int RowIndex = selection.GetSelectedRowIndex(i);
                        int RowHandle = gridView1.GetRowHandle(RowIndex);
                        string strSPXXID = gridView1.GetRowCellDisplayText(RowHandle, colSPXXID).ToString().Trim();
                        string strPM = gridView1.GetRowCellDisplayText(RowHandle, colPM).ToString().Trim();
                        string strZT = gridView1.GetRowCellDisplayText(RowHandle, colZT).ToString().Trim();
                        if (strZT != "启用")
                        {
                            if (string.IsNullOrEmpty(Arrayid))
                            { Arrayid = strSPXXID; }
                            else
                            {
                                Arrayid = strSPXXID + "," + Arrayid;
                            }
                           
                            Check = true;
                        }
                        else
                        {
                            MessageBox.Show("品名"+strPM+"已经有启用状态的商品", "通知");
                            selection.ClearSelection();
                            Check = false;
                            break;
                        }


                    }
                    if (!string.IsNullOrEmpty(Arrayid)&&Check==true)
                    {
                        OracleConnection MyConn = new OracleConnection(StrCon);
                        string StrUpdate = "UPDATE JT_J_SPXX SET ZT = '启用' WHERE SPXXID in (" + Arrayid + ")";
                        try
                        {
                            selection.ClearSelection();
                            MyConn.Open();
                            OracleCommand Comm = new OracleCommand(StrUpdate, MyConn);
                            Comm.ExecuteNonQuery();
 
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            MyConn.Close();
                            unitOfWork1.DropIdentityMap();
                            xpServerCollectionSource1.Reload();
                        }
                    }

 
            }

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (selection.SelectedCount == 0)
            {
                MessageBox.Show("请先选择需要停用的商品");
            }
            else
            {
                string Arrayid = null;
                bool Check = false;
                for (int i = 0; i < selection.SelectedCount; ++i)
                {
                    int RowIndex = selection.GetSelectedRowIndex(i);
                    int RowHandle = gridView1.GetRowHandle(RowIndex);
                    string strSPXXID = gridView1.GetRowCellDisplayText(RowHandle, colSPXXID).ToString().Trim();
                    string strPM = gridView1.GetRowCellDisplayText(RowHandle, colPM).ToString().Trim();
                    string strZT = gridView1.GetRowCellDisplayText(RowHandle, colZT).ToString().Trim();
                    if (strZT != "停用")
                    {
                        if (string.IsNullOrEmpty(Arrayid))
                        { Arrayid = strSPXXID; }
                        else
                        {
                            Arrayid = strSPXXID + "," + Arrayid;
                        }

                        Check = true;
                    }
                    else
                    {
                        MessageBox.Show("品名" + strPM + "已经有停用状态的商品", "通知");
                        selection.ClearSelection();
                        Check = false;
                        break;
                    }


                }
                if (!string.IsNullOrEmpty(Arrayid) && Check == true)
                {
                    OracleConnection MyConn = new OracleConnection(StrCon);
                    string StrUpdate = "UPDATE JT_J_SPXX SET ZT = '停用',TYRQ=sysdate,TYRY='"+FrmLogin.getUser+"' WHERE SPXXID in (" + Arrayid + ")";
                    try
                    {
                        selection.ClearSelection();
                        MyConn.Open();
                        OracleCommand Comm = new OracleCommand(StrUpdate, MyConn);
                        Comm.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        MyConn.Close();
                        unitOfWork1.DropIdentityMap();
                        xpServerCollectionSource1.Reload();
                    }
                }


            }
        }

        private void btnAlter_Click(object sender, EventArgs e)
        {
            if (selection.SelectedCount == 1)
            {
                int RowIndex = selection.GetSelectedRowIndex(0);
                int RowHandle = gridView1.GetRowHandle(RowIndex);
                string strSPXXID = gridView1.GetRowCellDisplayText(RowHandle, colSPXXID).ToString().Trim();
                selection.ClearSelection();
                FrmGoodsAdd from = new FrmGoodsAdd(strSPXXID);
                if (from.ShowDialog() == DialogResult.OK)
                {
                    unitOfWork1.DropIdentityMap();
                    xpServerCollectionSource1.Reload();

                }

            }
            else
            {
                MessageBox.Show("请先选择一个要修改的商品");
            }
        }
    }
}
