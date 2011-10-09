using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System.IO;
using System.Data.OracleClient;

namespace ClientMain
{
    public partial class FrmCarryoverCostVoucherNote : DevExpress.XtraEditors.XtraForm
    {
        GridCheckMarksSelection selection;

        public FrmCarryoverCostVoucherNote(string strVOUCHERID = null)
        {
            XpoDefault.ConnectionString = FrmLogin.xpoDataCentStr;

            InitializeComponent();

            if (String.IsNullOrEmpty(strVOUCHERID))
            {
                xpServerCollectionSource1.FixedFilterString = "[VOUCHERID] Is Null";
            }
            else
            {
                xpServerCollectionSource1.FixedFilterString = strVOUCHERID;
            }
            selection = new GridCheckMarksSelection(gridView1);
            selection.CheckMarkColumn.VisibleIndex = 0;

            gridView1.BestFitColumns();
        }

        private void btnMasterQuery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            gridView1.ShowFilterEditor(colVOUCHER_ID);

            if (!String.IsNullOrEmpty(gridView1.ActiveFilterString))
            {
                selection.ClearSelection();
                xpServerCollectionSource1.FixedFilterString = gridView1.ActiveFilterString + " And [ZTID] = \'" + FrmLogin.getZTID + "\'";
                gridView1.BestFitColumns();
            }
        }

        private void gridView1_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator & e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString().Trim();
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));

            FormCollection fc = Application.OpenForms;

            if (hitInfo.HitTest == GridHitTest.RowCell)
            {
                if ((hitInfo.Column != null) && (hitInfo.Column == colVOUCHER_ID))
                {
                    string strTemp = view.GetRowCellDisplayText(hitInfo.RowHandle, colVOUCHERID);
                    string strVOUCHERID = "[VOUCHERID] = \'" + strTemp + "\'";
                    if (fc["FrmCarryoverCostVoucherDetail"] != null)
                    {
                        fc["FrmCarryoverCostVoucherDetail"].Close();
                    }
                    FrmCarryoverCostVoucherDetail FrmCCVD = new FrmCarryoverCostVoucherDetail(strVOUCHERID);
                    FrmCCVD.Show();
                    FrmCCVD.Activate();

                }
            }
        }

        private void btnDetailQuery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (selection.SelectedCount == 0)
            {
                //const string message = "没有勾选主单进行的详单查询时间会比较久（3分钟左右），继续么？";
                //const string caption = "详单查询?";
                //var result = MessageBox.Show(message, caption,
                //                             MessageBoxButtons.YesNo,
                //                             MessageBoxIcon.Question);
                //if (result == DialogResult.Yes)
                //{
                FrmCarryoverCostVoucherDetail FrmCCVD = new FrmCarryoverCostVoucherDetail();
                FrmCCVD.Show();
                FrmCCVD.Activate();
                //}

            }
            else
            {
                string strVOUCHERID = null;
                for (int i = 0; i < selection.SelectedCount; ++i)
                {
                    int RowIndex = selection.GetSelectedRowIndex(i);
                    int RowHandle = gridView1.GetRowHandle(RowIndex);

                    string strTemp = gridView1.GetRowCellDisplayText(RowHandle, colVOUCHERID);
                    strVOUCHERID += "[VOUCHERID] = \'" + strTemp + "\' Or ";
                }

                int index = strVOUCHERID.LastIndexOf("'");
                strVOUCHERID = strVOUCHERID.Substring(0, index + 1).Trim();

                FrmCarryoverCostVoucherDetail FrmCCVD = new FrmCarryoverCostVoucherDetail(strVOUCHERID);
                FrmCCVD.Show();
                FrmCCVD.Activate();
            }
        }

        private void btnColCustomize_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.ShowCustomization();
        }

        private void btnSaveLayout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strLayout = FrmLogin.getUser + "_CarryoverCostVoucherNoteLayout.xml";
            FileStream stream = new FileStream(strLayout, FileMode.Create);
            gridView1.SaveLayoutToStream(stream);
            stream.Close();
        }

        private void btnLoadLayout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strLayout = FrmLogin.getUser + "_CarryoverCostVoucherNoteLayout.xml";
            if (File.Exists(strLayout))
            {
                gridView1.RestoreLayoutFromXml(strLayout);
                MessageBox.Show("载入视图成功！");
            }
            else
            {
                MessageBox.Show("未发现视图保存文件，请确认是否曾经保存！");
            }
        }

        private bool fgMakeXML(string strVOUCHERID)
        {
            StringBuilder sbXML = new StringBuilder();

            using (OracleConnection connection = new OracleConnection(FrmLogin.strDataCent))
            {
                connection.Open();

                OracleCommand command = connection.CreateCommand();
                OracleTransaction transaction = connection.BeginTransaction();
                command.Connection = connection;
                command.Transaction = transaction;

                try
                {
                    string sqlPZ = "select voucherid,voucher_id,pzlxid,company,voucher_type,fiscal_year,"
                                 + "accounting_period,attachment_number,prepareddate,enter,cashier,"
                                 + "signature,checker,posting_date,posting_person,voucher_making_system,"
                                 + "memo1,memo2,reserve1,reserve2,ztid "
                                 + "from jt_c_jzcbpz t where t.voucherid='" + strVOUCHERID + "'";

                    string sqlPZMX = "select * from jt_c_jzcbpzmx where VOUCHERID='" + strVOUCHERID + "'";

                    DataSet ds = new DataSet();
                    OracleDataAdapter adaPZ = new OracleDataAdapter(sqlPZ, connection);
                    adaPZ.SelectCommand.Transaction = transaction;
                    adaPZ.Fill(ds, "jt_c_jzcbpz");
                    foreach (DataRowView theRow in ds.Tables["jt_c_jzcbpz"].DefaultView)
                    {
                        sbXML.Append("<?xml version=\"1.0\" encoding=\"gb2312\" ?> \n");
                        sbXML.Append("<ufinterface roottag=\"voucher\" billtype=\"gl\" replace=\"N\" receiver=\"");
                        sbXML.Append(theRow.Row["company"].ToString());
                        sbXML.Append("-0002\" sender=\"1101\" isexchange=\"Y\" filename=\"XHPZ.xml\" proc=\"add\" operation=\"req\">\n");
                        sbXML.Append("<voucher id=\"");
                        sbXML.Append(theRow.Row["voucherid"].ToString());
                        sbXML.Append("\">\n");
                        sbXML.Append("<voucher_head>\n");
                        sbXML.Append("<company>");
                        sbXML.Append(theRow.Row["company"].ToString());
                        sbXML.Append("</company>\n");
                        sbXML.Append("<voucher_type>");
                        sbXML.Append(theRow.Row["voucher_type"].ToString());
                        sbXML.Append("</voucher_type>\n");
                        sbXML.Append("<fiscal_year>");
                        sbXML.Append(theRow.Row["fiscal_year"].ToString());
                        sbXML.Append("</fiscal_year>\n");
                        sbXML.Append("<accounting_period>");
                        sbXML.Append(theRow.Row["accounting_period"].ToString());
                        sbXML.Append("</accounting_period>\n");
                        sbXML.Append("<voucher_id>0</voucher_id>\n");
                        sbXML.Append("<attachment_number>");
                        sbXML.Append(theRow.Row["attachment_number"].ToString());
                        sbXML.Append("</attachment_number>\n");
                        sbXML.Append("<prepareddate>");
                        if (!String.IsNullOrEmpty(theRow.Row["prepareddate"].ToString()))
                        {
                            sbXML.Append(theRow.Row["prepareddate"].ToString().Substring(0, theRow.Row["prepareddate"].ToString().IndexOf(" ")));
                        }
                        sbXML.Append("</prepareddate>\n");
                        sbXML.Append("<enter>");
                        sbXML.Append(theRow.Row["enter"].ToString());
                        sbXML.Append("</enter>\n");
                        sbXML.Append("<cashier>");
                        sbXML.Append(theRow.Row["cashier"].ToString());
                        sbXML.Append("</cashier>\n");
                        sbXML.Append("<signature>");
                        sbXML.Append(theRow.Row["signature"].ToString());
                        sbXML.Append("</signature>\n");
                        sbXML.Append("<checker>");
                        sbXML.Append(theRow.Row["checker"].ToString());
                        sbXML.Append("</checker>\n");
                        sbXML.Append("<posting_date>");
                        if (!String.IsNullOrEmpty(theRow.Row["posting_date"].ToString()))
                        {
                            sbXML.Append(theRow.Row["posting_date"].ToString().Substring(0, theRow.Row["posting_date"].ToString().IndexOf(" ")));
                        }
                        sbXML.Append("</posting_date>\n");
                        sbXML.Append("<posting_person>");
                        sbXML.Append(theRow.Row["posting_person"].ToString());
                        sbXML.Append("</posting_person>\n");
                        sbXML.Append("<voucher_making_system>");
                        sbXML.Append(theRow.Row["voucher_making_system"].ToString());
                        sbXML.Append("</voucher_making_system>\n");
                        sbXML.Append("<memo1>");
                        sbXML.Append(theRow.Row["memo1"].ToString());
                        sbXML.Append("</memo1>\n");
                        sbXML.Append("<memo2>");
                        sbXML.Append(theRow.Row["memo2"].ToString());
                        sbXML.Append("</memo2>\n");
                        sbXML.Append("<reserve1>");
                        sbXML.Append(theRow.Row["reserve1"].ToString());
                        sbXML.Append("</reserve1>\n");
                        sbXML.Append("<reserve2>");
                        sbXML.Append(theRow.Row["reserve2"].ToString());
                        sbXML.Append("</reserve2>\n");
                        sbXML.Append("</voucher_head>\n");
                    }

                    sbXML.Append("<voucher_body>\n");
                    OracleDataAdapter adaPZMX = new OracleDataAdapter(sqlPZMX, connection);
                    adaPZMX.SelectCommand.Transaction = transaction;
                    adaPZMX.Fill(ds, "jt_c_jzcbpzmx");
                    foreach (DataRowView theRow in ds.Tables["jt_c_jzcbpzmx"].DefaultView)
                    {
                        sbXML.Append("<entry>\n");
                        sbXML.Append("<entry_id>");
                        sbXML.Append(theRow.Row["entry_id"].ToString());
                        sbXML.Append("</entry_id>\n");
                        sbXML.Append("<account_code>");
                        sbXML.Append(theRow.Row["account_code"].ToString());
                        sbXML.Append("</account_code>\n");
                        sbXML.Append("<abstract>");
                        sbXML.Append(theRow.Row["abstract"].ToString());
                        sbXML.Append("</abstract>\n");
                        sbXML.Append("<settlement>");
                        sbXML.Append(theRow.Row["settlement"].ToString());
                        sbXML.Append("</settlement>\n");
                        sbXML.Append("<document_id>");
                        sbXML.Append(theRow.Row["document_id"].ToString());
                        sbXML.Append("</document_id>\n");
                        sbXML.Append("<document_date>");      
                        if(!String.IsNullOrEmpty(theRow.Row["document_date"].ToString()))
                        {
                            sbXML.Append(theRow.Row["document_date"].ToString().Substring(0, theRow.Row["document_date"].ToString().IndexOf(" ")));
                        }
                        sbXML.Append("</document_date>\n");
                        sbXML.Append("<currency>");
                        sbXML.Append(theRow.Row["currency"].ToString());
                        sbXML.Append("</currency>\n");
                        sbXML.Append("<unit_price>");
                        sbXML.Append(theRow.Row["unit_price"].ToString());
                        sbXML.Append("</unit_price>\n");
                        sbXML.Append("<exchange_rate1>");
                        sbXML.Append(theRow.Row["exchange_rate1"].ToString());
                        sbXML.Append("</exchange_rate1>\n");
                        sbXML.Append("<exchange_rate2>");
                        sbXML.Append(theRow.Row["exchange_rate2"].ToString());
                        sbXML.Append("</exchange_rate2>\n");
                        sbXML.Append("<debit_quantity>");
                        sbXML.Append(theRow.Row["debit_quantity"].ToString());
                        sbXML.Append("</debit_quantity>\n");
                        sbXML.Append("<primary_debit_amount>");
                        sbXML.Append(theRow.Row["primary_debit_amount"].ToString());
                        sbXML.Append("</primary_debit_amount>\n");
                        sbXML.Append("<secondary_debit_amount>");
                        sbXML.Append(theRow.Row["secondary_debit_amount"].ToString());
                        sbXML.Append("</secondary_debit_amount>\n");
                        sbXML.Append("<natural_debit_currency>");
                        sbXML.Append(theRow.Row["natural_debit_currency"].ToString());
                        sbXML.Append("</natural_debit_currency>\n");
                        sbXML.Append("<credit_quantity>");
                        sbXML.Append(theRow.Row["credit_quantity"].ToString());
                        sbXML.Append("</credit_quantity>\n");
                        sbXML.Append("<primary_credit_amount>");
                        sbXML.Append(theRow.Row["primary_credit_amount"].ToString());
                        sbXML.Append("</primary_credit_amount>\n");
                        sbXML.Append("<secondary_credit_amount>");
                        sbXML.Append(theRow.Row["secondary_credit_amount"].ToString());
                        sbXML.Append("</secondary_credit_amount>\n");
                        sbXML.Append("<natural_credit_currency>");
                        sbXML.Append(theRow.Row["natural_credit_currency"].ToString());
                        sbXML.Append("</natural_credit_currency>\n");
                        sbXML.Append("<bill_type>");
                        sbXML.Append(theRow.Row["bill_type"].ToString());
                        sbXML.Append("</bill_type>\n");
                        sbXML.Append("<bill_id>");
                        sbXML.Append(theRow.Row["bill_id"].ToString());
                        sbXML.Append("</bill_id>\n");
                        sbXML.Append("<bill_date>");
                        if (!String.IsNullOrEmpty(theRow.Row["bill_date"].ToString()))
                        {
                            sbXML.Append(theRow.Row["bill_date"].ToString().Substring(0, theRow.Row["bill_date"].ToString().IndexOf(" ")));
                        }
                        sbXML.Append("</bill_date>\n");
                        if (!String.IsNullOrEmpty(theRow.Row["AUXILIARY_ACCOUNTING_ITEM1"].ToString()) || !String.IsNullOrEmpty(theRow.Row["AUXILIARY_ACCOUNTING_ITEM2"].ToString())
                            || !String.IsNullOrEmpty(theRow.Row["AUXILIARY_ACCOUNTING_ITEM3"].ToString()) || !String.IsNullOrEmpty(theRow.Row["AUXILIARY_ACCOUNTING_ITEM4"].ToString())
                            || !String.IsNullOrEmpty(theRow.Row["AUXILIARY_ACCOUNTING_ITEM5"].ToString()))
                        {
                            sbXML.Append("<auxiliary_accounting>\n");
                            if (!String.IsNullOrEmpty(theRow.Row["AUXILIARY_ACCOUNTING_ITEM1"].ToString()))
                            {
                                sbXML.Append("<item name=\"部门档案\">");
                                sbXML.Append(theRow.Row["AUXILIARY_ACCOUNTING_ITEM1"].ToString());
                                sbXML.Append("</item>\n");
                            }
                            if (!String.IsNullOrEmpty(theRow.Row["AUXILIARY_ACCOUNTING_ITEM2"].ToString()))
                            {
                                sbXML.Append("<item name=\"客商辅助核算\">");
                                sbXML.Append(theRow.Row["AUXILIARY_ACCOUNTING_ITEM2"].ToString());
                                sbXML.Append("</item>\n");
                            }
                            if (!String.IsNullOrEmpty(theRow.Row["AUXILIARY_ACCOUNTING_ITEM3"].ToString()))
                            {
                                sbXML.Append("<item name=\"增值税税率\">");
                                sbXML.Append(theRow.Row["AUXILIARY_ACCOUNTING_ITEM3"].ToString());
                                sbXML.Append("</item>\n");
                            }
                            if (!String.IsNullOrEmpty(theRow.Row["AUXILIARY_ACCOUNTING_ITEM4"].ToString()))
                            {
                                sbXML.Append("<item name=\"现金流量项目\">");
                                sbXML.Append(theRow.Row["AUXILIARY_ACCOUNTING_ITEM4"].ToString());
                                sbXML.Append("</item>\n");
                            }
                            if (!String.IsNullOrEmpty(theRow.Row["AUXILIARY_ACCOUNTING_ITEM5"].ToString()))
                            {
                                sbXML.Append("<item name=\"商品分类项目\">");
                                sbXML.Append(theRow.Row["AUXILIARY_ACCOUNTING_ITEM5"].ToString());
                                sbXML.Append("</item>\n");
                            }
                            sbXML.Append("</auxiliary_accounting>\n");
                        }
                        sbXML.Append("<detail/>\n");
                        sbXML.Append("<free1/>\n");
                        sbXML.Append("</entry>\n");
                    }

                    sbXML.Append("</voucher_body>\n");
                    sbXML.Append("</voucher>\n");
                    sbXML.Append("</ufinterface>\n");

                    string sqlDel = "delete from jt_c_jzcbpz_xml where CGSHPZID='" + strVOUCHERID + "'";
                    command.CommandText = sqlDel;
                    command.ExecuteNonQuery();

                    string sqlXML = "insert into jt_c_jzcbpz_xml values('" + strVOUCHERID + "',:pXML)";
                    command.CommandText = sqlXML;
                    OracleParameter pXML = new OracleParameter("pXML", OracleType.Clob);
                    pXML.Value = sbXML.ToString();
                    command.Parameters.Add(pXML);
                    command.ExecuteNonQuery();

                    transaction.Commit();

                    return true;
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
            return false;
        }

        private void btnConfirm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strVOUCHERID = "";
            if (selection.SelectedCount == 0)
            {
                MessageBox.Show("请先选择需要确认的记录");
            }
            else
            {
                for (int i = 0; i < selection.SelectedCount; ++i)
                {
                    int RowIndex = selection.GetSelectedRowIndex(i);
                    int RowHandle = gridView1.GetRowHandle(RowIndex);

                    string strZT = gridView1.GetRowCellValue(RowHandle, colZT).ToString();

                    if (strZT == "02")
                    {
                        string strTemp = gridView1.GetRowCellDisplayText(RowHandle, colVOUCHERID);
                        if (fgMakeXML(strTemp))
                        {
                            strVOUCHERID += "\'" + strTemp + "\', ";
                        }
                        else
                        {
                            strVOUCHERID = "";
                        }
                    }
                    else
                    {
                        strVOUCHERID = "";
                        MessageBox.Show("所选记录已被确认，请重新选择！");
                        break;
                    }

                }

                selection.ClearSelection();

                if (!String.IsNullOrEmpty(strVOUCHERID))
                {
                    using (OracleConnection connection = new OracleConnection(FrmLogin.strDataCent))
                    {
                        connection.Open();
                        OracleCommand command = connection.CreateCommand();
                        OracleTransaction transaction = connection.BeginTransaction();
                        command.Connection = connection;
                        command.Transaction = transaction;

                        int index = strVOUCHERID.LastIndexOf("'");
                        strVOUCHERID = strVOUCHERID.Substring(0, index + 1).Trim();

                        try
                        {
                            string strSQL = "update jt_c_jzcbpz set zt = '15', czrq = sysdate where VOUCHERID in (" + strVOUCHERID + ")";
                            command.CommandText = strSQL;

                            command.ExecuteNonQuery();
                            transaction.Commit();

                            unitOfWork1.DropIdentityMap();
                            xpServerCollectionSource1.Reload();
                            MessageBox.Show("所选记录已确认成功");
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
        }
    }
}