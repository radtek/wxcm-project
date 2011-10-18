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
using System.Configuration;
using System.Data.OracleClient;
using System.Data.OleDb;
using System.IO;



namespace ClientMain
{
    public partial class FrmUnusualStockInput : Form
    {
        GridCheckMarksSelection selection;
        const int MAXROWCOUNT = 50000;
        Int64 YCCS = 0;
        Int64 KTCS = 0;
        Int64 YTCS = 0;
        double DJ = 0;

        // private string StrCon = FrmLogin.strCon;
        private string StrCon = FrmLogin.strDataCent;
        public FrmUnusualStockInput()
        {
            InitializeComponent();
            //  XpoDefault.ConnectionString = OracleConnectionProvider.GetConnectionString("XINHUA", "xxb", "pass");
            XpoDefault.ConnectionString = FrmLogin.xpoDataCentStr;
            selection = new GridCheckMarksSelection(gridView1);
            selection.CheckMarkColumn.VisibleIndex = 0;
            xpServerCollectionSource1.FixedFilterString = "[YCKCID] Is Null";
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
            vDrawFootCell(e, colSPBH, "选计：");
            vDrawFootCell(e, colYCCS, YCCS.ToString());
            vDrawFootCell(e, colKTCS, KTCS.ToString());
            vDrawFootCell(e, colYTCS, YTCS.ToString());
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
                        YCCS = Convert.ToInt64(colYCCS.SummaryText);
                        KTCS = Convert.ToInt64(colKTCS.SummaryText);
                        YTCS = Convert.ToInt64(colYTCS.SummaryText);
                        DJ = Convert.ToDouble(colDJ.SummaryText);
                    
                    }
                    else
                    {
                       DJ=0;
                       YCCS=0;
                       KTCS = 0;
                       YTCS = 0;
                     
                    }

                }
                if (hitInfo.InRowCell)
                {
                    if (selection.IsRowSelected(hitInfo.RowHandle))
                    {
                        YCCS += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colYCCS));
                        KTCS += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colKTCS));
                        YTCS += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colYTCS));

                        DJ += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colDJ));
                     

                    }
                    else
                    {
                        YCCS -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colYCCS));
                        KTCS -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colKTCS));
                        YTCS -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colYTCS));

                        DJ -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colDJ));
                     
                    }
                }
            }

        }
        private void btnADD_Click(object sender, EventArgs e)
        {
            FrmUnusualStockInputAdd frm = new FrmUnusualStockInputAdd();
            frm.Tag = "JC_C_YCKC_ADD";
            if(frm.ShowDialog()==DialogResult.OK)
            {
                xpServerCollectionSource1.FixedFilterString = "[ZTID] = \'" + FrmLogin.getZTID + "\'";
                unitOfWork1.DropIdentityMap();
                xpServerCollectionSource1.Reload();

            }
        }
        private void SetCZLXMC()
        {
            int i = this.gridView1.RowCount;
            for (int j = 0; j < i; j++)
            {
                if (this.gridView1.GetRowCellDisplayText(j, colCLZT).ToString() == "0")
                {
                   // this.Text = gridView1.GetRowCellDisplayText(j, colCLZT).ToString();
                    this.gridView1.SetRowCellValue(j, colCLZTMC, "录入");
                    
                }
                else if (this.gridView1.GetRowCellDisplayText(j, colCLZT).ToString() == "1")
                {
                    this.gridView1.SetRowCellValue(j, colCLZTMC, "确认");
                }
            }
        }
        private void btnAlter_Click(object sender, EventArgs e)
        {
            bool fgcheck=false;
            string strid = "";
            if (selection.SelectedCount != 1)
            {
                fgcheck = false;
                MessageBox.Show("每次必须且只能选一个修改");
            }
            else
            {
                int RowIndex = selection.GetSelectedRowIndex(0);
                int RowHandle = gridView1.GetRowHandle(RowIndex);
                string strZT = gridView1.GetRowCellDisplayText(RowHandle, colCLZT).ToString().Trim();
                strid = gridView1.GetRowCellDisplayText(RowHandle, colYCKCID).ToString().Trim();

                if (strZT=="1")
                {
                    fgcheck = false;
                    MessageBox.Show("已经确认无法再修改");
                }
                else if (strZT == "0")
                {
                    fgcheck = true;

                }
                else
                {
                    fgcheck = false;
                    MessageBox.Show("请确认你选的单子");

                }
            }
            if(fgcheck==true)
            {
                FrmUnusualStockInputAdd frm = new FrmUnusualStockInputAdd(strid);
                frm.Tag = "JC_C_YCKC_EDIT";
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    selection.ClearSelection();

                    unitOfWork1.DropIdentityMap();
                    xpServerCollectionSource1.Reload();
                    SetCZLXMC();

                }
            }
         
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("确定要进行删除操作", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (selection.SelectedCount == 0)
                {
                    MessageBox.Show("你还没有选择要删除的单子");
                }
                else
                {
                     bool fgConfirmStop = false;
                     for (int i = 0; i < selection.SelectedCount; ++i)
                     {
                         int RowIndex = selection.GetSelectedRowIndex(i);
                         int RowHandle = gridView1.GetRowHandle(RowIndex);

                         string strCZYID = gridView1.GetRowCellDisplayText(RowHandle, colCZYID).ToString();
                         string strCLZT = gridView1.GetRowCellDisplayText(RowHandle, colCLZT).ToString();

                         if(strCZYID!=FrmLogin.getUserID.ToString())
                         {
                             fgConfirmStop = false;
                             MessageBox.Show("你只能删除自己创建的录入");

                         }
                         else if (strCLZT=="1")
                         {
                             fgConfirmStop = false;
                             MessageBox.Show("你不能删除自已经确认的录入单");

                         }
                         else
                         {
                             fgConfirmStop = true;
                         }
 
                     }
                     if (fgConfirmStop==true)
                         
                    {


                        for (int i = 0; i < selection.SelectedCount;i++ )
                        {
                            int RowIndex = selection.GetSelectedRowIndex(0);
                            int RowHandle = gridView1.GetRowHandle(RowIndex);
                            string strYCKCID = gridView1.GetRowCellDisplayText(RowHandle, colYCKCID).ToString();
                            OracleConnection conn = new OracleConnection(StrCon);
                            string deleteds = "delete from JC_C_YCKC where YCKCID='" + strYCKCID + "'";
                            OracleCommand comm = new OracleCommand(deleteds,conn);
                          try 
                            {
                                conn.Open();
                                comm.ExecuteNonQuery();
                                    
    
                            }
                            catch(OracleException ex)
                            { throw ex; }
                            finally
                            {
                                conn.Close();
                            }

                        }

                        unitOfWork1.DropIdentityMap();
                        xpServerCollectionSource1.Reload();
                        SetCZLXMC();
                         

                    }


                }
 
            }
          


        }

        private void btnInquire_Click(object sender, EventArgs e)
        {
            selection.ClearSelection();
            gridView1.ShowFilterEditor(colSPBH);

            if (!String.IsNullOrEmpty(gridView1.ActiveFilterString))
            {
               //  xpServerCollectionSource1.FixedFilterString = gridView1.ActiveFilterString;
                xpServerCollectionSource1.FixedFilterString = gridView1.ActiveFilterString + " And [ZTID] = \'" + FrmLogin.getZTID + "\'";
              
                gridView1.BestFitColumns();
                SetCZLXMC();

            }
        }
        private string GYSid()
        {
            string gysid = "";

            return gysid;
        }
        private void btnCirfrom_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要进行确认操作", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (selection.SelectedCount == 0)
                {
                    MessageBox.Show("你还没有选择要确认的单子");
                }
                else
                { 
                      bool fgConfirmStop = false;
                      for (int i = 0; i < selection.SelectedCount; ++i)
                      {
                          int RowIndex = selection.GetSelectedRowIndex(i);
                          int RowHandle = gridView1.GetRowHandle(RowIndex);

                          string strZTID = gridView1.GetRowCellDisplayText(RowHandle, colZTID).ToString();
                          string strCLZT = gridView1.GetRowCellDisplayText(RowHandle, colCLZT).ToString();
                          if (strZTID != FrmLogin.getZTID.ToString())
                          {
                              fgConfirmStop = false;
                              MessageBox.Show("你只能确认本帐套的单子");

                          }
                          else if (strCLZT == "1")
                          {
                              fgConfirmStop = false;
                              MessageBox.Show("该单已经确认过了");

                          }
                          else
                          {
                              fgConfirmStop = true;
                          }

                      }
                      if (fgConfirmStop ==true)
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

                                string strYCKCID = gridView1.GetRowCellDisplayText(RowHandle, colYCKCID).ToString();
                                string strGYSID = gridView1.GetRowCellDisplayText(RowHandle, colGYSID).ToString();
                                string strBDWID = gridView1.GetRowCellDisplayText(RowHandle, colBDWID).ToString();

                                cmd.CommandText = "INSERT INTO TEMP_SAVE_ID (tempid，id,wlbmid,ztid) Values (temp_save_id_seq.nextval, '" + strYCKCID + "','" + strGYSID + "','" + strBDWID + "')";
                                cmd.ExecuteNonQuery();


                               }
                                 selection.ClearSelection();
                                 cmd.CommandType = CommandType.StoredProcedure;
                                 cmd.CommandText = "SP_EWB_YCKCHG_JC";
                                 cmd.Parameters.Add("Ls_Ztid", OracleType.VarChar).Value = FrmLogin.getZTID;
                                 cmd.ExecuteNonQuery();
                                 transaction.Commit();

                                 unitOfWork1.DropIdentityMap();

                                 xpServerCollectionSource1.Reload();
                                 SetCZLXMC();

                             MessageBox.Show(cmd.Parameters["Message"].Value.ToString());
                            }
                            catch(OracleException ex)
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
                    gridView1.Columns["SPXXID"].Visible=true;

                    gridView1.SelectAll();
                    gridView1.ExportToXls(saveDialog.FileName);

                    gridView1.Columns["SPXXID"].Visible = false;
                    gridView1.Columns["CheckMarkSelection"].Visible = true;
                    gridView1.Columns["CheckMarkSelection"].VisibleIndex = 0;

                    MessageBox.Show("导出成功！");

                }
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

        private void btnLook_Click(object sender, EventArgs e)
        {
              
              if (selection.SelectedCount != 1)
              {
                  MessageBox.Show("每次必须且只能选一个查看");
              }
              else
              {
                  int RowIndex = selection.GetSelectedRowIndex(0);
                  int RowHandle = gridView1.GetRowHandle(RowIndex);
                  string strid = gridView1.GetRowCellDisplayText(RowHandle, colYCKCID).ToString().Trim();
                  FrmUnusualStockInputAdd frm = new FrmUnusualStockInputAdd(strid);
                  frm.Tag = "JC_C_YCKC_LOOK";
                  frm.ShowDialog();
              }
        }
       
        private void btnInput_Click(object sender, EventArgs e)
        {
            string LoadFile = null;
            OpenFileDialog openexcle = new OpenFileDialog();
            openexcle.Filter = "excel files (*.xls)|*.xls";
            openexcle.ShowHelp = true;
            if(openexcle.ShowDialog()==DialogResult.OK)
            {
                LoadFile = openexcle.FileName.ToString();
                if (!string.IsNullOrEmpty(LoadFile))
                {
                    FrmUnusualStockImporCheck from = new FrmUnusualStockImporCheck(LoadFile);
                    from.Tag = "JC_C_YCKC_CHECK";
                    from.Text = "非正常库存导入EXCEL数据检测";
                    if (from.ShowDialog()==DialogResult.OK)
                    {
                        xpServerCollectionSource1.FixedFilterString = "[CZYID] =\'" + FrmLogin.getUserID + "\'";
                        this.unitOfWork1.DropIdentityMap();
                        xpServerCollectionSource1.Reload();
                        SetCZLXMC();
                        this.gridView1.BestFitColumns();
                    }
                  //  CheckInputData(LoadFile);
                }
                else
                {
                    MessageBox.Show("你还没有加载文件");
                }
               
                
            }
        }

        private void FrmUnusualStockInput_Load(object sender, EventArgs e)
        {
            SetCZLXMC();
        }

        private void btnOutputMod_Click(object sender, EventArgs e)
        {
            string primitivefilepath = System.Windows.Forms.Application.StartupPath;
            string primitivefilename = primitivefilepath + "\\notNormal_report.xls";
            FolderBrowserDialog Fbd = new FolderBrowserDialog();
            if (Fbd.ShowDialog() == DialogResult.OK)
            {
                string loadpath = Fbd.SelectedPath;
                string loadfilename = loadpath + "\\notNormal_report.xls";
                try
                { File.Copy(primitivefilename, loadfilename, true); }
                catch(Exception ex)
                { throw ex; }
                finally
                { MessageBox.Show("导出完毕"); }

            }
        }




    }
}
