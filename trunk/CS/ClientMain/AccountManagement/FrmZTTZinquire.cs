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
    public partial class FrmZTTZinquire : Form
    {
        GridCheckMarksSelection selection1;
        GridCheckMarksSelection selection2;
        GridCheckMarksSelection selection3;
        GridCheckMarksSelection selection4;
        GridCheckMarksSelection selection5;
        const int MAXROWCOUNT = 50000;
        //定义帐套台账的选计
        Int64 iQCKC = 0;
        double dQCMY = 0;
        double dQCSY = 0;

        Int64 iJHSL = 0;
        double dJHMY = 0;
        double dJHSY = 0;

        Int64 iXTSL = 0;
        double dXTMY = 0;
        double dXTSY = 0;

        Int64 iDRSL = 0;
        double dDRMY = 0;
        double dDRSY = 0;

        Int64 iJRSL = 0;
        double dJRMY = 0;
        double dJRSY = 0;

        Int64 iXSSL = 0;
        double dXSMY = 0;
        double dXSSY = 0;

        Int64 iJTSL = 0;
        double dJTMY = 0;
        double dJTSY = 0;

        Int64 iDCSL = 0;
        double dDCMY = 0;
        double dDCSY = 0;

        Int64 iJCSL = 0;
        double dJCMY = 0;
        double dJCSY = 0;

        Int64 iBFSL = 0;
        double dBFMY = 0;
        double dBFSY = 0;

        Int64 iSYSL = 0;
        double dSYMY = 0;
        double dSYSY = 0;

        Int64 iQMKC = 0;
        double dQMMY = 0;
        double dQMSY = 0;

        Int64 iZRSL = 0;
        double dZRMY = 0;
        double dZRSY = 0;

        Int64 iZCSL = 0;
        double dZCMY = 0;
        double dZCSY = 0;
//_________________________________________
        Int64 iPFSL = 0;
        double dPFMY = 0;
        double dPFSY = 0;

        Int64 iYTSL = 0;
        double dYTSY = 0;
        double dYTMY = 0;


        double dDJ = 0;




        public FrmZTTZinquire()
        {
            InitializeComponent();
            XpoDefault.ConnectionString = OracleConnectionProvider.GetConnectionString("XINHUA", "xxb", "pass");
            selection1 = new GridCheckMarksSelection(gridView1);
            selection1.CheckMarkColumn.VisibleIndex = 0;
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            this.gridView1.CustomDrawFooterCell += new DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventHandler(this.gridView1_CustomDrawFooterCell);
            this.gridView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gridView1_MouseUp);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);

            selection2 = new GridCheckMarksSelection(gridView2);
            selection2.CheckMarkColumn.VisibleIndex = 0;
            this.gridView2.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView2_CustomDrawRowIndicator);
            this.gridView2.CustomDrawFooterCell += new DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventHandler(this.gridView2_CustomDrawFooterCell);
            this.gridView2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gridView2_MouseUp);
            this.gridView2.DoubleClick += new System.EventHandler(this.gridView2_DoubleClick);


            selection3 = new GridCheckMarksSelection(gridView3);
            selection3.CheckMarkColumn.VisibleIndex = 0;
            this.gridView3.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView3_CustomDrawRowIndicator);
            this.gridView3.CustomDrawFooterCell += new DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventHandler(this.gridView3_CustomDrawFooterCell);
            this.gridView3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gridView3_MouseUp);
            this.gridView3.DoubleClick += new System.EventHandler(this.gridView3_DoubleClick);

            selection4 = new GridCheckMarksSelection(gridView4);
            selection4.CheckMarkColumn.VisibleIndex = 0;
            this.gridView4.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView4_CustomDrawRowIndicator);
            this.gridView4.CustomDrawFooterCell += new DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventHandler(this.gridView4_CustomDrawFooterCell);
            this.gridView4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gridView4_MouseUp);
            this.gridView4.DoubleClick += new System.EventHandler(this.gridView4_DoubleClick);

            selection5 = new GridCheckMarksSelection(gridView5);
            selection5.CheckMarkColumn.VisibleIndex = 0;
            this.gridView4.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView4_CustomDrawRowIndicator);
            this.gridView4.CustomDrawFooterCell += new DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventHandler(this.gridView4_CustomDrawFooterCell);
            this.gridView4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gridView4_MouseUp);

        }
        private bool SPorKF = true;//控制按商品显示还是按照库房显示
        private OracleConnection MyConn = null;

        //定义数据库连接
        private void Open()
        {
            string StrCon = FrmLogin.strCon;
            MyConn = new OracleConnection(StrCon);
            if (MyConn.State.ToString() != "Open")
                MyConn.Open();
        }
        //定义数据库关闭
        private void sClose()
        {
            //   if (ds != null)
            //    { ds.Dispose(); }
            if (MyConn != null & MyConn.State.ToString() != "Closed")
            { MyConn.Close(); }
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
            vDrawFootCell(e, colZTIDMC, "选计：");
            vDrawFootCell(e, colQCKC, iQCKC.ToString());
            vDrawFootCell(e, colQCMY, dQCMY.ToString("F2"));
            vDrawFootCell(e, colQCSY, dQCSY.ToString("F2"));

            vDrawFootCell(e, colJHSL, iJHSL.ToString());
            vDrawFootCell(e, colJHMY, dJHMY.ToString("F2"));
            vDrawFootCell(e, colJHSY, dJHSY.ToString("F2"));

            vDrawFootCell(e, colXTSL, iXTSL.ToString());
            vDrawFootCell(e, colXTMY, dXTMY.ToString("F2"));
            vDrawFootCell(e, colXTSY, dXTSY.ToString("F2"));

            vDrawFootCell(e, colDRSL, iDRSL.ToString());
            vDrawFootCell(e, colDRMY, dDRMY.ToString("F2"));
            vDrawFootCell(e, colDRSY, dDRSY.ToString("F2"));

            vDrawFootCell(e, colJRSL, iJRSL.ToString());
            vDrawFootCell(e, colJRMY, dJRMY.ToString("F2"));
            vDrawFootCell(e, colJRSY, dJRSY.ToString("F2"));

            vDrawFootCell(e, colXSSL, iXSSL.ToString());
            vDrawFootCell(e, colXSMY, dXSMY.ToString("F2"));
            vDrawFootCell(e, colXSSY, dXSSY.ToString("F2"));

            vDrawFootCell(e, colJTSL, iJTSL.ToString());
            vDrawFootCell(e, colJTMY, dJTMY.ToString("F2"));
            vDrawFootCell(e, colJTSY, dJTSY.ToString("F2"));

            vDrawFootCell(e, colDCSL, iDCSL.ToString());
            vDrawFootCell(e, colDCMY, dDCMY.ToString("F2"));
            vDrawFootCell(e, colDCSY, dDCSY.ToString("F2"));

            vDrawFootCell(e, colJCSL, iJCSL.ToString());
            vDrawFootCell(e, colJCMY, dJCMY.ToString("F2"));
            vDrawFootCell(e, colJCSY, dJCSY.ToString("F2"));

            vDrawFootCell(e, colBFSL, iBFSL.ToString());
            vDrawFootCell(e, colBFMY, dBFMY.ToString("F2"));
            vDrawFootCell(e, colBFSY, dBFSY.ToString("F2"));

            vDrawFootCell(e, colSYSL, iSYSL.ToString());
            vDrawFootCell(e, colSYMY, dSYMY.ToString("F2"));
            vDrawFootCell(e, colSYSY, dSYSY.ToString("F2"));

            vDrawFootCell(e, colQMKC, iQMKC.ToString());
            vDrawFootCell(e, colQMMY, dQMMY.ToString("F2"));
            vDrawFootCell(e, colQMSY, dQMSY.ToString("F2"));

            vDrawFootCell(e, colZRSL, iZRSL.ToString());
            vDrawFootCell(e, colZRMY, dZRMY.ToString("F2"));
            vDrawFootCell(e, colZRSY, dZRSY.ToString("F2"));

            vDrawFootCell(e, colZCSL, iZCSL.ToString());
            vDrawFootCell(e, colZCMY, dZCMY.ToString("F2"));
            vDrawFootCell(e, colZCSY, dZCSY.ToString("F2"));

            

        }
        private void gridView1_MouseUp(object sender, MouseEventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));
            if ((hitInfo.Column != null) && (hitInfo.Column.GetCaption() == "选择"))
            {
                if (hitInfo.InColumn)
                {
                    if (selection1.SelectedCount == view.DataRowCount)
                    {
                        iQCKC = Convert.ToInt64(colQCKC.SummaryText);
                        dQCMY = Convert.ToDouble(colQCMY.SummaryText);
                        dQCSY = Convert.ToDouble(colQCSY.SummaryText);

                        iJHSL = Convert.ToInt64(colJHSL.SummaryText);
                        dJHMY = Convert.ToDouble(colJHMY.SummaryText);
                        dJHSY = Convert.ToDouble(colJHSY.SummaryText);

                        iXTSL = Convert.ToInt64(colXTSL.SummaryText);
                        dXTMY = Convert.ToDouble(colXTMY.SummaryText);
                        dXTSY = Convert.ToDouble(colXTSY.SummaryText);

                        iDRSL = Convert.ToInt64(colDRSL.SummaryText);
                        dDRMY = Convert.ToDouble(colDRMY.SummaryText);
                        dDRSY = Convert.ToDouble(colDRSY.SummaryText);

                        iJRSL = Convert.ToInt64(colJRSL.SummaryText);
                        dJRMY = Convert.ToDouble(colJRMY.SummaryText);
                        dJRSY = Convert.ToDouble(colJRSY.SummaryText);

                        iXSSL = Convert.ToInt64(colXSSL.SummaryText);
                        dXSMY = Convert.ToDouble(colXSMY.SummaryText);
                        dXSSY = Convert.ToDouble(colXSSY.SummaryText);

                        iJTSL = Convert.ToInt64(colJTSL.SummaryText);
                        dJTMY = Convert.ToDouble(colJTMY.SummaryText);
                        dJTSY = Convert.ToDouble(colJTSY.SummaryText);

                        iDCSL = Convert.ToInt64(colDCSL.SummaryText);
                        dDCMY = Convert.ToDouble(colDCMY.SummaryText);
                        dDCSY = Convert.ToDouble(colDCSY.SummaryText);

                        iJCSL = Convert.ToInt64(colJCSL.SummaryText);
                        dJCMY = Convert.ToDouble(colJCMY.SummaryText);
                        dJCSY = Convert.ToDouble(colJCSY.SummaryText);

                        iBFSL = Convert.ToInt64(colBFSL.SummaryText);
                        dBFMY = Convert.ToDouble(colBFMY.SummaryText);
                        dBFSY = Convert.ToDouble(colBFSY.SummaryText);

                        iSYSL = Convert.ToInt64(colSYSL.SummaryText);
                        dSYMY = Convert.ToDouble(colSYMY.SummaryText);
                        dSYSY = Convert.ToDouble(colSYSY.SummaryText);

                        iQMKC = Convert.ToInt64(colQMKC.SummaryText);
                        dQMMY = Convert.ToDouble(colQMMY.SummaryText);
                        dQMSY = Convert.ToDouble(colQMSY.SummaryText);

                        iQCKC = Convert.ToInt64(colQCKC.SummaryText);
                        dQCMY = Convert.ToDouble(colQCMY.SummaryText);
                        dQCSY = Convert.ToDouble(colQCSY.SummaryText);

                        iZRSL = Convert.ToInt64(colZRSL.SummaryText);
                        dZRMY = Convert.ToDouble(colZRMY.SummaryText);
                        dZRSY = Convert.ToDouble(colZRSY.SummaryText);

                        iZCSL = Convert.ToInt64(colZCSL.SummaryText);
                        dZCMY = Convert.ToDouble(colZCMY.SummaryText);
                        dZCSY = Convert.ToDouble(colZCSY.SummaryText);
                    }
                    else
                    {
                         iQCKC = 0;
                         dQCMY = 0;
                         dQCSY = 0;

                         iJHSL = 0;
                         dJHMY = 0;
                         dJHSY = 0;

                         iXTSL = 0;
                         dXTMY = 0;
                         dXTSY = 0;

                         iDRSL = 0;
                         dDRMY = 0;
                         dDRSY = 0;

                         iJRSL = 0;
                         dJRMY = 0;
                         dJRSY = 0;

                         iXSSL = 0;
                         dXSMY = 0;
                         dXSSY = 0;

                         iJTSL = 0;
                         dJTMY = 0;
                         dJTSY = 0;

                         iDCSL = 0;
                         dDCMY = 0;
                         dDCSY = 0;

                         iJCSL = 0;
                         dJCMY = 0;
                         dJCSY = 0;

                         iBFSL = 0;
                         dBFMY = 0;
                         dBFSY = 0;

                         iSYSL = 0;
                         dSYMY = 0;
                         dSYSY = 0;

                         iQMKC = 0;
                         dQMMY = 0;
                         dQMSY = 0;

                         iZRSL = 0;
                         dZRMY = 0;
                         dZRSY = 0;

                         iZCSL = 0;
                         dZCMY = 0;
                         dZCSY = 0;
                    }

                }
                if (hitInfo.InRowCell)
                {
                    if (selection1.IsRowSelected(hitInfo.RowHandle))
                    {
                        iQCKC += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colQCKC));
                        dQCMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colQCMY));
                        dQCSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colQCSY));

                        iJHSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colJHSL));
                        dJHMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJHMY));
                        dJHSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJHSY));

                        iXTSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colXTSL));
                        dXTMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colXTMY));
                        dXTSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colXTSY));

                        iDRSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colDRSL));
                        dDRMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colDRMY));
                        dDRSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colDRSY));

                        iJRSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colJRSL));
                        dJRMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJRMY));
                        dJRSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJRSY));

                        iXSSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colXSSL));
                        dXSMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colXSMY));
                        dXSSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colXSSY));

                        iJTSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colJTSL));
                        dJTMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJTMY));
                        dJTSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJTSY));

                        iDCSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colDCSL));
                        dDCMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colDCMY));
                        dDCSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colDCSY));

                        iJCSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colJCSL));
                        dJCMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJCMY));
                        dJCSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJCSY));

                        iBFSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colBFSL));
                        dBFMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colBFMY));
                        dBFSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colBFSY));

                        iSYSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colSYSL));
                        dSYMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colSYMY));
                        dSYSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colSYSY));

                        iQMKC += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colQMKC));
                        dQMMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colQMMY));
                        dQMSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colQMSY));

                        iZRSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colZRSL));
                        dZRMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZRMY));
                        dZRSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZRSY));

                        iZCSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colZCSL));
                        dZCMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZCMY));
                        dZCSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZCSY));

                    }
                    else
                    {
                        iQCKC -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colQCKC));
                        dQCMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colQCMY));
                        dQCSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colQCSY));

                        iJHSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colJHSL));
                        dJHMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJHMY));
                        dJHSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJHSY));

                        iXTSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colXTSL));
                        dXTMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colXTMY));
                        dXTSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colXTSY));

                        iDRSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colDRSL));
                        dDRMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colDRMY));
                        dDRSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colDRSY));

                        iJRSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colJRSL));
                        dJRMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJRMY));
                        dJRSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJRSY));

                        iXSSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colXSSL));
                        dXSMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colXSMY));
                        dXSSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colXSSY));

                        iJTSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colJTSL));
                        dJTMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJTMY));
                        dJTSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJTSY));

                        iDCSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colDCSL));
                        dDCMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colDCMY));
                        dDCSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colDCSY));

                        iJCSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colJCSL));
                        dJCMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJCMY));
                        dJCSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJCSY));

                        iBFSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colBFSL));
                        dBFMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colBFMY));
                        dBFSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colBFSY));

                        iSYSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colSYSL));
                        dSYMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colSYMY));
                        dSYSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colSYSY));

                        iQMKC -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colQMKC));
                        dQMMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colQMMY));
                        dQMSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colQMSY));

                        iZRSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colZRSL));
                        dZRMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZRMY));
                        dZRSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZRSY));

                        iZCSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colZCSL));
                        dZCMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZCMY));
                        dZCSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZCSY));
                    }
                }
            }

        }
        private void gridView2_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator & e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString().Trim();
            }
        }
        private void gridView2_CustomDrawFooterCell(object sender, FooterCellCustomDrawEventArgs e)
        {
            vDrawFootCell(e, colBMMC1, "选计：");
            vDrawFootCell(e, colQCKC1, iQCKC.ToString());
            vDrawFootCell(e, colQCMY1, dQCMY.ToString("F2"));
            vDrawFootCell(e, colQCSY1, dQCSY.ToString("F2"));

            vDrawFootCell(e, colJHSL1, iJHSL.ToString());
            vDrawFootCell(e, colJHMY1, dJHMY.ToString("F2"));
            vDrawFootCell(e, colJHSY1, dJHSY.ToString("F2"));

            vDrawFootCell(e, colXTSL1, iXTSL.ToString());
            vDrawFootCell(e, colXTMY1, dXTMY.ToString("F2"));
            vDrawFootCell(e, colXTSY1, dXTSY.ToString("F2"));

            vDrawFootCell(e, colDRSL1, iDRSL.ToString());
            vDrawFootCell(e, colDRMY1, dDRMY.ToString("F2"));
            vDrawFootCell(e, colDRSY1, dDRSY.ToString("F2"));

            vDrawFootCell(e, colJRSL1, iJRSL.ToString());
            vDrawFootCell(e, colJRMY1, dJRMY.ToString("F2"));
            vDrawFootCell(e, colJRSY1, dJRSY.ToString("F2"));

            vDrawFootCell(e, colXSSL1, iXSSL.ToString());
            vDrawFootCell(e, colXSMY1, dXSMY.ToString("F2"));
            vDrawFootCell(e, colXSSY1, dXSSY.ToString("F2"));

            vDrawFootCell(e, colJTSL1, iJTSL.ToString());
            vDrawFootCell(e, colJTMY1, dJTMY.ToString("F2"));
            vDrawFootCell(e, colJTSY1, dJTSY.ToString("F2"));

            vDrawFootCell(e, colDCSL1, iDCSL.ToString());
            vDrawFootCell(e, colDCMY1, dDCMY.ToString("F2"));
            vDrawFootCell(e, colDCSY1, dDCSY.ToString("F2"));

            vDrawFootCell(e, colJCSL1, iJCSL.ToString());
            vDrawFootCell(e, colJCMY1, dJCMY.ToString("F2"));
            vDrawFootCell(e, colJCSY1, dJCSY.ToString("F2"));

            vDrawFootCell(e, colBFSL1, iBFSL.ToString());
            vDrawFootCell(e, colBFMY1, dBFMY.ToString("F2"));
            vDrawFootCell(e, colBFSY1, dBFSY.ToString("F2"));

            vDrawFootCell(e, colSYSL1, iSYSL.ToString());
            vDrawFootCell(e, colSYMY1, dSYMY.ToString("F2"));
            vDrawFootCell(e, colSYSY1, dSYSY.ToString("F2"));

            vDrawFootCell(e, colQMKC1, iQMKC.ToString());
            vDrawFootCell(e, colQMMY1, dQMMY.ToString("F2"));
            vDrawFootCell(e, colQMSY1, dQMSY.ToString("F2"));

            vDrawFootCell(e, colZRSL1, iZRSL.ToString());
            vDrawFootCell(e, colZRMY1, dZRMY.ToString("F2"));
            vDrawFootCell(e, colZRSY1, dZRSY.ToString("F2"));

            vDrawFootCell(e, colZCSL1, iZCSL.ToString());
            vDrawFootCell(e, colZCMY1, dZCMY.ToString("F2"));
            vDrawFootCell(e, colZCSY1, dZCSY.ToString("F2"));



        }
        private void gridView2_MouseUp(object sender, MouseEventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));
            if ((hitInfo.Column != null) && (hitInfo.Column.GetCaption() == "选择"))
            {
                if (hitInfo.InColumn)
                {
                    if (selection2.SelectedCount == view.DataRowCount)
                    {
                        iQCKC = Convert.ToInt64(colQCKC1.SummaryText);
                        dQCMY = Convert.ToDouble(colQCMY1.SummaryText);
                        dQCSY = Convert.ToDouble(colQCSY1.SummaryText);

                        iJHSL = Convert.ToInt64(colJHSL1.SummaryText);
                        dJHMY = Convert.ToDouble(colJHMY1.SummaryText);
                        dJHSY = Convert.ToDouble(colJHSY1.SummaryText);

                        iXTSL = Convert.ToInt64(colXTSL1.SummaryText);
                        dXTMY = Convert.ToDouble(colXTMY1.SummaryText);
                        dXTSY = Convert.ToDouble(colXTSY1.SummaryText);

                        iDRSL = Convert.ToInt64(colDRSL1.SummaryText);
                        dDRMY = Convert.ToDouble(colDRMY1.SummaryText);
                        dDRSY = Convert.ToDouble(colDRSY1.SummaryText);

                        iJRSL = Convert.ToInt64(colJRSL1.SummaryText);
                        dJRMY = Convert.ToDouble(colJRMY1.SummaryText);
                        dJRSY = Convert.ToDouble(colJRSY1.SummaryText);

                        iXSSL = Convert.ToInt64(colXSSL1.SummaryText);
                        dXSMY = Convert.ToDouble(colXSMY1.SummaryText);
                        dXSSY = Convert.ToDouble(colXSSY1.SummaryText);

                        iJTSL = Convert.ToInt64(colJTSL1.SummaryText);
                        dJTMY = Convert.ToDouble(colJTMY1.SummaryText);
                        dJTSY = Convert.ToDouble(colJTSY1.SummaryText);

                        iDCSL = Convert.ToInt64(colDCSL1.SummaryText);
                        dDCMY = Convert.ToDouble(colDCMY1.SummaryText);
                        dDCSY = Convert.ToDouble(colDCSY1.SummaryText);

                        iJCSL = Convert.ToInt64(colJCSL1.SummaryText);
                        dJCMY = Convert.ToDouble(colJCMY1.SummaryText);
                        dJCSY = Convert.ToDouble(colJCSY1.SummaryText);

                        iBFSL = Convert.ToInt64(colBFSL1.SummaryText);
                        dBFMY = Convert.ToDouble(colBFMY1.SummaryText);
                        dBFSY = Convert.ToDouble(colBFSY1.SummaryText);

                        iSYSL = Convert.ToInt64(colSYSL1.SummaryText);
                        dSYMY = Convert.ToDouble(colSYMY1.SummaryText);
                        dSYSY = Convert.ToDouble(colSYSY1.SummaryText);

                        iQMKC = Convert.ToInt64(colQMKC1.SummaryText);
                        dQMMY = Convert.ToDouble(colQMMY1.SummaryText);
                        dQMSY = Convert.ToDouble(colQMSY1.SummaryText);

                        iQCKC = Convert.ToInt64(colQCKC1.SummaryText);
                        dQCMY = Convert.ToDouble(colQCMY1.SummaryText);
                        dQCSY = Convert.ToDouble(colQCSY1.SummaryText);

                        iZRSL = Convert.ToInt64(colZRSL1.SummaryText);
                        dZRMY = Convert.ToDouble(colZRMY1.SummaryText);
                        dZRSY = Convert.ToDouble(colZRSY1.SummaryText);

                        iZCSL = Convert.ToInt64(colZCSL1.SummaryText);
                        dZCMY = Convert.ToDouble(colZCMY1.SummaryText);
                        dZCSY = Convert.ToDouble(colZCSY1.SummaryText);
                    }
                    else
                    {
                        iQCKC = 0;
                        dQCMY = 0;
                        dQCSY = 0;

                        iJHSL = 0;
                        dJHMY = 0;
                        dJHSY = 0;

                        iXTSL = 0;
                        dXTMY = 0;
                        dXTSY = 0;

                        iDRSL = 0;
                        dDRMY = 0;
                        dDRSY = 0;

                        iJRSL = 0;
                        dJRMY = 0;
                        dJRSY = 0;

                        iXSSL = 0;
                        dXSMY = 0;
                        dXSSY = 0;

                        iJTSL = 0;
                        dJTMY = 0;
                        dJTSY = 0;

                        iDCSL = 0;
                        dDCMY = 0;
                        dDCSY = 0;

                        iJCSL = 0;
                        dJCMY = 0;
                        dJCSY = 0;

                        iBFSL = 0;
                        dBFMY = 0;
                        dBFSY = 0;

                        iSYSL = 0;
                        dSYMY = 0;
                        dSYSY = 0;

                        iQMKC = 0;
                        dQMMY = 0;
                        dQMSY = 0;

                        iZRSL = 0;
                        dZRMY = 0;
                        dZRSY = 0;

                        iZCSL = 0;
                        dZCMY = 0;
                        dZCSY = 0;
                    }

                }
                if (hitInfo.InRowCell)
                {
                    if (selection2.IsRowSelected(hitInfo.RowHandle))
                    {
                        iQCKC += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colQCKC1));
                        dQCMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colQCMY1));
                        dQCSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colQCSY1));

                        iJHSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colJHSL1));
                        dJHMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJHMY1));
                        dJHSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJHSY1));

                        iXTSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colXTSL1));
                        dXTMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colXTMY1));
                        dXTSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colXTSY1));

                        iDRSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colDRSL1));
                        dDRMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colDRMY1));
                        dDRSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colDRSY1));

                        iJRSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colJRSL1));
                        dJRMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJRMY1));
                        dJRSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJRSY1));

                        iXSSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colXSSL1));
                        dXSMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colXSMY1));
                        dXSSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colXSSY1));

                        iJTSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colJTSL1));
                        dJTMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJTMY1));
                        dJTSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJTSY1));

                        iDCSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colDCSL1));
                        dDCMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colDCMY1));
                        dDCSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colDCSY1));

                        iJCSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colJCSL1));
                        dJCMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJCMY1));
                        dJCSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJCSY1));

                        iBFSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colBFSL1));
                        dBFMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colBFMY1));
                        dBFSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colBFSY1));

                        iSYSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colSYSL1));
                        dSYMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colSYMY1));
                        dSYSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colSYSY1));

                        iQMKC += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colQMKC1));
                        dQMMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colQMMY1));
                        dQMSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colQMSY1));

                        iZRSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colZRSL1));
                        dZRMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZRMY1));
                        dZRSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZRSY1));

                        iZCSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colZCSL1));
                        dZCMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZCMY1));
                        dZCSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZCSY1));

                    }
                    else
                    {
                        iQCKC -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colQCKC1));
                        dQCMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colQCMY1));
                        dQCSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colQCSY1));

                        iJHSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colJHSL1));
                        dJHMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJHMY1));
                        dJHSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJHSY1));

                        iXTSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colXTSL1));
                        dXTMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colXTMY1));
                        dXTSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colXTSY1));

                        iDRSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colDRSL1));
                        dDRMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colDRMY1));
                        dDRSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colDRSY1));

                        iJRSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colJRSL1));
                        dJRMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJRMY1));
                        dJRSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJRSY1));

                        iXSSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colXSSL1));
                        dXSMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colXSMY1));
                        dXSSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colXSSY1));

                        iJTSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colJTSL1));
                        dJTMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJTMY1));
                        dJTSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJTSY1));

                        iDCSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colDCSL1));
                        dDCMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colDCMY1));
                        dDCSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colDCSY1));

                        iJCSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colJCSL1));
                        dJCMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJCMY1));
                        dJCSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJCSY1));

                        iBFSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colBFSL1));
                        dBFMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colBFMY1));
                        dBFSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colBFSY1));

                        iSYSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colSYSL1));
                        dSYMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colSYMY1));
                        dSYSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colSYSY1));

                        iQMKC -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colQMKC1));
                        dQMMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colQMMY1));
                        dQMSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colQMSY1));

                        iZRSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colZRSL1));
                        dZRMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZRMY1));
                        dZRSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZRSY1));

                        iZCSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colZCSL1));
                        dZCMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZCMY1));
                        dZCSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZCSY1));
                    }
                }
            }

        }
        private void gridView3_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator & e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString().Trim();
            }
        }
        private void gridView3_CustomDrawFooterCell(object sender, FooterCellCustomDrawEventArgs e)
        {
            vDrawFootCell(e, colSPMC2, "选计：");
            vDrawFootCell(e, colQCKC2, iQCKC.ToString());
            vDrawFootCell(e, colQCMY2, dQCMY.ToString("F2"));
            vDrawFootCell(e, colQCSY2, dQCSY.ToString("F2"));

            vDrawFootCell(e, colJHSL2, iJHSL.ToString());
            vDrawFootCell(e, colJHMY2, dJHMY.ToString("F2"));
            vDrawFootCell(e, colJHSY2, dJHSY.ToString("F2"));

            vDrawFootCell(e, colXTSL2, iXTSL.ToString());
            vDrawFootCell(e, colXTMY2, dXTMY.ToString("F2"));
            vDrawFootCell(e, colXTSY2, dXTSY.ToString("F2"));

            vDrawFootCell(e, colDRSL2, iDRSL.ToString());
            vDrawFootCell(e, colDRMY2, dDRMY.ToString("F2"));
            vDrawFootCell(e, colDRSY2, dDRSY.ToString("F2"));

            vDrawFootCell(e, colJRSL2, iJRSL.ToString());
            vDrawFootCell(e, colJRMY2, dJRMY.ToString("F2"));
            vDrawFootCell(e, colJRSY2, dJRSY.ToString("F2"));

            vDrawFootCell(e, colXSSL2, iXSSL.ToString());
            vDrawFootCell(e, colXSMY2, dXSMY.ToString("F2"));
            vDrawFootCell(e, colXSSY2, dXSSY.ToString("F2"));

            vDrawFootCell(e, colJTSL2, iJTSL.ToString());
            vDrawFootCell(e, colJTMY2, dJTMY.ToString("F2"));
            vDrawFootCell(e, colJTSY2, dJTSY.ToString("F2"));

            vDrawFootCell(e, colDCSL2, iDCSL.ToString());
            vDrawFootCell(e, colDCMY2, dDCMY.ToString("F2"));
            vDrawFootCell(e, colDCSY2, dDCSY.ToString("F2"));

            vDrawFootCell(e, colJCSL2, iJCSL.ToString());
            vDrawFootCell(e, colJCMY2, dJCMY.ToString("F2"));
            vDrawFootCell(e, colJCSY2, dJCSY.ToString("F2"));

            vDrawFootCell(e, colBFSL2, iBFSL.ToString());
            vDrawFootCell(e, colBFMY2, dBFMY.ToString("F2"));
            vDrawFootCell(e, colBFSY2, dBFSY.ToString("F2"));

            vDrawFootCell(e, colSYSL2, iSYSL.ToString());
            vDrawFootCell(e, colSYMY2, dSYMY.ToString("F2"));
            vDrawFootCell(e, colSYSY2, dSYSY.ToString("F2"));

            vDrawFootCell(e, colQMKC2, iQMKC.ToString());
            vDrawFootCell(e, colQMMY2, dQMMY.ToString("F2"));
            vDrawFootCell(e, colQMSY2, dQMSY.ToString("F2"));

            vDrawFootCell(e, colZRSL2, iZRSL.ToString());
            vDrawFootCell(e, colZRMY2, dZRMY.ToString("F2"));
            vDrawFootCell(e, colZRSY2, dZRSY.ToString("F2"));

            vDrawFootCell(e, colZCSL2, iZCSL.ToString());
            vDrawFootCell(e, colZCMY2, dZCMY.ToString("F2"));
            vDrawFootCell(e, colZCSY2, dZCSY.ToString("F2"));



        }
        private void gridView3_MouseUp(object sender, MouseEventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));
            if ((hitInfo.Column != null) && (hitInfo.Column.GetCaption() == "选择"))
            {
                if (hitInfo.InColumn)
                {
                    if (selection3.SelectedCount == view.DataRowCount)
                    {
                        iQCKC = Convert.ToInt64(colQCKC2.SummaryText);
                        dQCMY = Convert.ToDouble(colQCMY2.SummaryText);
                        dQCSY = Convert.ToDouble(colQCSY2.SummaryText);

                        iJHSL = Convert.ToInt64(colJHSL2.SummaryText);
                        dJHMY = Convert.ToDouble(colJHMY2.SummaryText);
                        dJHSY = Convert.ToDouble(colJHSY2.SummaryText);

                        iXTSL = Convert.ToInt64(colXTSL2.SummaryText);
                        dXTMY = Convert.ToDouble(colXTMY2.SummaryText);
                        dXTSY = Convert.ToDouble(colXTSY2.SummaryText);

                        iDRSL = Convert.ToInt64(colDRSL2.SummaryText);
                        dDRMY = Convert.ToDouble(colDRMY2.SummaryText);
                        dDRSY = Convert.ToDouble(colDRSY2.SummaryText);

                        iJRSL = Convert.ToInt64(colJRSL2.SummaryText);
                        dJRMY = Convert.ToDouble(colJRMY2.SummaryText);
                        dJRSY = Convert.ToDouble(colJRSY2.SummaryText);

                        iXSSL = Convert.ToInt64(colXSSL2.SummaryText);
                        dXSMY = Convert.ToDouble(colXSMY2.SummaryText);
                        dXSSY = Convert.ToDouble(colXSSY2.SummaryText);

                        iJTSL = Convert.ToInt64(colJTSL2.SummaryText);
                        dJTMY = Convert.ToDouble(colJTMY2.SummaryText);
                        dJTSY = Convert.ToDouble(colJTSY2.SummaryText);

                        iDCSL = Convert.ToInt64(colDCSL2.SummaryText);
                        dDCMY = Convert.ToDouble(colDCMY2.SummaryText);
                        dDCSY = Convert.ToDouble(colDCSY2.SummaryText);

                        iJCSL = Convert.ToInt64(colJCSL2.SummaryText);
                        dJCMY = Convert.ToDouble(colJCMY2.SummaryText);
                        dJCSY = Convert.ToDouble(colJCSY2.SummaryText);

                        iBFSL = Convert.ToInt64(colBFSL2.SummaryText);
                        dBFMY = Convert.ToDouble(colBFMY2.SummaryText);
                        dBFSY = Convert.ToDouble(colBFSY2.SummaryText);

                        iSYSL = Convert.ToInt64(colSYSL2.SummaryText);
                        dSYMY = Convert.ToDouble(colSYMY2.SummaryText);
                        dSYSY = Convert.ToDouble(colSYSY2.SummaryText);

                        iQMKC = Convert.ToInt64(colQMKC2.SummaryText);
                        dQMMY = Convert.ToDouble(colQMMY2.SummaryText);
                        dQMSY = Convert.ToDouble(colQMSY2.SummaryText);

                        iQCKC = Convert.ToInt64(colQCKC2.SummaryText);
                        dQCMY = Convert.ToDouble(colQCMY2.SummaryText);
                        dQCSY = Convert.ToDouble(colQCSY2.SummaryText);

                        iZRSL = Convert.ToInt64(colZRSL2.SummaryText);
                        dZRMY = Convert.ToDouble(colZRMY2.SummaryText);
                        dZRSY = Convert.ToDouble(colZRSY2.SummaryText);

                        iZCSL = Convert.ToInt64(colZCSL2.SummaryText);
                        dZCMY = Convert.ToDouble(colZCMY2.SummaryText);
                        dZCSY = Convert.ToDouble(colZCSY2.SummaryText);
                    }
                    else
                    {
                        iQCKC = 0;
                        dQCMY = 0;
                        dQCSY = 0;

                        iJHSL = 0;
                        dJHMY = 0;
                        dJHSY = 0;

                        iXTSL = 0;
                        dXTMY = 0;
                        dXTSY = 0;

                        iDRSL = 0;
                        dDRMY = 0;
                        dDRSY = 0;

                        iJRSL = 0;
                        dJRMY = 0;
                        dJRSY = 0;

                        iXSSL = 0;
                        dXSMY = 0;
                        dXSSY = 0;

                        iJTSL = 0;
                        dJTMY = 0;
                        dJTSY = 0;

                        iDCSL = 0;
                        dDCMY = 0;
                        dDCSY = 0;

                        iJCSL = 0;
                        dJCMY = 0;
                        dJCSY = 0;

                        iBFSL = 0;
                        dBFMY = 0;
                        dBFSY = 0;

                        iSYSL = 0;
                        dSYMY = 0;
                        dSYSY = 0;

                        iQMKC = 0;
                        dQMMY = 0;
                        dQMSY = 0;

                        iZRSL = 0;
                        dZRMY = 0;
                        dZRSY = 0;

                        iZCSL = 0;
                        dZCMY = 0;
                        dZCSY = 0;
                    }

                }
                if (hitInfo.InRowCell)
                {
                    if (selection3.IsRowSelected(hitInfo.RowHandle))
                    {
                        iQCKC += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colQCKC2));
                        dQCMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colQCMY2));
                        dQCSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colQCSY2));

                        iJHSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colJHSL2));
                        dJHMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJHMY2));
                        dJHSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJHSY2));

                        iXTSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colXTSL2));
                        dXTMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colXTMY2));
                        dXTSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colXTSY2));

                        iDRSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colDRSL2));
                        dDRMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colDRMY2));
                        dDRSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colDRSY2));

                        iJRSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colJRSL2));
                        dJRMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJRMY2));
                        dJRSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJRSY2));

                        iXSSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colXSSL2));
                        dXSMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colXSMY2));
                        dXSSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colXSSY2));

                        iJTSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colJTSL2));
                        dJTMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJTMY2));
                        dJTSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJTSY2));

                        iDCSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colDCSL2));
                        dDCMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colDCMY2));
                        dDCSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colDCSY2));

                        iJCSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colJCSL2));
                        dJCMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJCMY2));
                        dJCSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJCSY2));

                        iBFSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colBFSL2));
                        dBFMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colBFMY2));
                        dBFSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colBFSY2));

                        iSYSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colSYSL2));
                        dSYMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colSYMY2));
                        dSYSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colSYSY2));

                        iQMKC += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colQMKC2));
                        dQMMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colQMMY2));
                        dQMSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colQMSY2));

                        iZRSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colZRSL2));
                        dZRMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZRMY2));
                        dZRSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZRSY2));

                        iZCSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colZCSL2));
                        dZCMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZCMY2));
                        dZCSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZCSY2));

                    }
                    else
                    {
                        iQCKC -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colQCKC2));
                        dQCMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colQCMY2));
                        dQCSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colQCSY2));

                        iJHSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colJHSL2));
                        dJHMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJHMY2));
                        dJHSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJHSY2));

                        iXTSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colXTSL2));
                        dXTMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colXTMY2));
                        dXTSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colXTSY2));

                        iDRSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colDRSL2));
                        dDRMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colDRMY2));
                        dDRSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colDRSY2));

                        iJRSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colJRSL2));
                        dJRMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJRMY2));
                        dJRSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJRSY2));

                        iXSSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colXSSL2));
                        dXSMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colXSMY2));
                        dXSSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colXSSY2));

                        iJTSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colJTSL2));
                        dJTMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJTMY2));
                        dJTSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJTSY2));

                        iDCSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colDCSL2));
                        dDCMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colDCMY2));
                        dDCSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colDCSY2));

                        iJCSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colJCSL2));
                        dJCMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJCMY2));
                        dJCSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJCSY2));

                        iBFSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colBFSL2));
                        dBFMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colBFMY2));
                        dBFSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colBFSY2));

                        iSYSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colSYSL2));
                        dSYMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colSYMY2));
                        dSYSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colSYSY2));

                        iQMKC -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colQMKC2));
                        dQMMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colQMMY2));
                        dQMSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colQMSY2));

                        iZRSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colZRSL2));
                        dZRMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZRMY2));
                        dZRSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZRSY2));

                        iZCSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colZCSL2));
                        dZCMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZCMY2));
                        dZCSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZCSY2));
                    }
                }
            }

        }
        private void gridView4_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator & e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString().Trim();
            }
        }
        private void gridView4_CustomDrawFooterCell(object sender, FooterCellCustomDrawEventArgs e)
        {
            vDrawFootCell(e, colWLBMMC3, "选计：");
            vDrawFootCell(e, colQCKC3, iQCKC.ToString());
            vDrawFootCell(e, colQCMY3, dQCMY.ToString("F2"));
            vDrawFootCell(e, colQCSY3, dQCSY.ToString("F2"));

            vDrawFootCell(e, colJHSL3, iJHSL.ToString());
            vDrawFootCell(e, colJHMY3, dJHMY.ToString("F2"));
            vDrawFootCell(e, colJHSY3, dJHSY.ToString("F2"));

            vDrawFootCell(e, colXTSL3, iXTSL.ToString());
            vDrawFootCell(e, colXTMY3, dXTMY.ToString("F2"));
            vDrawFootCell(e, colXTSY3, dXTSY.ToString("F2"));

            vDrawFootCell(e, colDRSL3, iDRSL.ToString());
            vDrawFootCell(e, colDRMY3, dDRMY.ToString("F2"));
            vDrawFootCell(e, colDRSY3, dDRSY.ToString("F2"));

            vDrawFootCell(e, colJRSL3, iJRSL.ToString());
            vDrawFootCell(e, colJRMY3, dJRMY.ToString("F2"));
            vDrawFootCell(e, colJRSY3, dJRSY.ToString("F2"));

            vDrawFootCell(e, colXSSL3, iXSSL.ToString());
            vDrawFootCell(e, colXSMY3, dXSMY.ToString("F2"));
            vDrawFootCell(e, colXSSY3, dXSSY.ToString("F2"));

            vDrawFootCell(e, colJTSL3, iJTSL.ToString());
            vDrawFootCell(e, colJTMY3, dJTMY.ToString("F2"));
            vDrawFootCell(e, colJTSY3, dJTSY.ToString("F2"));

            vDrawFootCell(e, colDCSL3, iDCSL.ToString());
            vDrawFootCell(e, colDCMY3, dDCMY.ToString("F2"));
            vDrawFootCell(e, colDCSY3, dDCSY.ToString("F2"));

            vDrawFootCell(e, colJCSL3, iJCSL.ToString());
            vDrawFootCell(e, colJCMY3, dJCMY.ToString("F2"));
            vDrawFootCell(e, colJCSY3, dJCSY.ToString("F2"));

            vDrawFootCell(e, colBFSL3, iBFSL.ToString());
            vDrawFootCell(e, colBFMY3, dBFMY.ToString("F2"));
            vDrawFootCell(e, colBFSY3, dBFSY.ToString("F2"));

            vDrawFootCell(e, colSYSL3, iSYSL.ToString());
            vDrawFootCell(e, colSYMY3, dSYMY.ToString("F2"));
            vDrawFootCell(e, colSYSY3, dSYSY.ToString("F2"));

            vDrawFootCell(e, colQMKC3, iQMKC.ToString());
            vDrawFootCell(e, colQMMY3, dQMMY.ToString("F2"));
            vDrawFootCell(e, colQMSY3, dQMSY.ToString("F2"));

            vDrawFootCell(e, colZRSL3, iZRSL.ToString());
            vDrawFootCell(e, colZRMY3, dZRMY.ToString("F2"));
            vDrawFootCell(e, colZRSY3, dZRSY.ToString("F2"));

            vDrawFootCell(e, colZCSL3, iZCSL.ToString());
            vDrawFootCell(e, colZCMY3, dZCMY.ToString("F2"));
            vDrawFootCell(e, colZCSY3, dZCSY.ToString("F2"));

            vDrawFootCell(e, colPFSL3, iPFSL.ToString());
            vDrawFootCell(e, colPFMY3, dPFMY.ToString("F2"));
            vDrawFootCell(e, colPFSY3, dPFSY.ToString("F2"));

            vDrawFootCell(e, colYTSL3, iYTSL.ToString());
            vDrawFootCell(e, colYTSY3, dYTSY.ToString("F2"));
            vDrawFootCell(e, colYTMY3, dYTMY.ToString("F2"));

            vDrawFootCell(e, colDJ3, dDJ.ToString("F2"));



        }
        private void gridView4_MouseUp(object sender, MouseEventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));
            if ((hitInfo.Column != null) && (hitInfo.Column.GetCaption() == "选择"))
            {
                if (hitInfo.InColumn)
                {
                    if (selection4.SelectedCount == view.DataRowCount)
                    {
                        iQCKC = Convert.ToInt64(colQCKC3.SummaryText);
                        dQCMY = Convert.ToDouble(colQCMY3.SummaryText);
                        dQCSY = Convert.ToDouble(colQCSY3.SummaryText);

                        iJHSL = Convert.ToInt64(colJHSL3.SummaryText);
                        dJHMY = Convert.ToDouble(colJHMY3.SummaryText);
                        dJHSY = Convert.ToDouble(colJHSY3.SummaryText);

                        iXTSL = Convert.ToInt64(colXTSL3.SummaryText);
                        dXTMY = Convert.ToDouble(colXTMY3.SummaryText);
                        dXTSY = Convert.ToDouble(colXTSY3.SummaryText);

                        iDRSL = Convert.ToInt64(colDRSL3.SummaryText);
                        dDRMY = Convert.ToDouble(colDRMY3.SummaryText);
                        dDRSY = Convert.ToDouble(colDRSY3.SummaryText);

                        iJRSL = Convert.ToInt64(colJRSL3.SummaryText);
                        dJRMY = Convert.ToDouble(colJRMY3.SummaryText);
                        dJRSY = Convert.ToDouble(colJRSY3.SummaryText);

                        iXSSL = Convert.ToInt64(colXSSL3.SummaryText);
                        dXSMY = Convert.ToDouble(colXSMY3.SummaryText);
                        dXSSY = Convert.ToDouble(colXSSY3.SummaryText);

                        iJTSL = Convert.ToInt64(colJTSL3.SummaryText);
                        dJTMY = Convert.ToDouble(colJTMY3.SummaryText);
                        dJTSY = Convert.ToDouble(colJTSY3.SummaryText);

                        iDCSL = Convert.ToInt64(colDCSL3.SummaryText);
                        dDCMY = Convert.ToDouble(colDCMY3.SummaryText);
                        dDCSY = Convert.ToDouble(colDCSY3.SummaryText);

                        iJCSL = Convert.ToInt64(colJCSL3.SummaryText);
                        dJCMY = Convert.ToDouble(colJCMY3.SummaryText);
                        dJCSY = Convert.ToDouble(colJCSY3.SummaryText);

                        iBFSL = Convert.ToInt64(colBFSL3.SummaryText);
                        dBFMY = Convert.ToDouble(colBFMY3.SummaryText);
                        dBFSY = Convert.ToDouble(colBFSY3.SummaryText);

                        iSYSL = Convert.ToInt64(colSYSL3.SummaryText);
                        dSYMY = Convert.ToDouble(colSYMY3.SummaryText);
                        dSYSY = Convert.ToDouble(colSYSY3.SummaryText);

                        iQMKC = Convert.ToInt64(colQMKC3.SummaryText);
                        dQMMY = Convert.ToDouble(colQMMY3.SummaryText);
                        dQMSY = Convert.ToDouble(colQMSY3.SummaryText);

                        iQCKC = Convert.ToInt64(colQCKC3.SummaryText);
                        dQCMY = Convert.ToDouble(colQCMY3.SummaryText);
                        dQCSY = Convert.ToDouble(colQCSY3.SummaryText);

                        iZRSL = Convert.ToInt64(colZRSL3.SummaryText);
                        dZRMY = Convert.ToDouble(colZRMY3.SummaryText);
                        dZRSY = Convert.ToDouble(colZRSY3.SummaryText);

                        iZCSL = Convert.ToInt64(colZCSL3.SummaryText);
                        dZCMY = Convert.ToDouble(colZCMY3.SummaryText);
                        dZCSY = Convert.ToDouble(colZCSY3.SummaryText);

                        iPFSL = Convert.ToInt64(colPFSL3.SummaryText);
                        dPFMY = Convert.ToDouble(colPFMY3.SummaryText);
                        dPFSY = Convert.ToDouble(colPFSY3.SummaryText);

                        iYTSL = Convert.ToInt64(colYTSL3.SummaryText);
                        dYTSY = Convert.ToDouble(colYTSY3.SummaryText);
                        dYTMY = Convert.ToDouble(colYTMY3.SummaryText);

                        dDJ = Convert.ToDouble(colDJ3.SummaryText);


                    }
                    else
                    {
                        iQCKC = 0;
                        dQCMY = 0;
                        dQCSY = 0;

                        iJHSL = 0;
                        dJHMY = 0;
                        dJHSY = 0;

                        iXTSL = 0;
                        dXTMY = 0;
                        dXTSY = 0;

                        iDRSL = 0;
                        dDRMY = 0;
                        dDRSY = 0;

                        iJRSL = 0;
                        dJRMY = 0;
                        dJRSY = 0;

                        iXSSL = 0;
                        dXSMY = 0;
                        dXSSY = 0;

                        iJTSL = 0;
                        dJTMY = 0;
                        dJTSY = 0;

                        iDCSL = 0;
                        dDCMY = 0;
                        dDCSY = 0;

                        iJCSL = 0;
                        dJCMY = 0;
                        dJCSY = 0;

                        iBFSL = 0;
                        dBFMY = 0;
                        dBFSY = 0;

                        iSYSL = 0;
                        dSYMY = 0;
                        dSYSY = 0;

                        iQMKC = 0;
                        dQMMY = 0;
                        dQMSY = 0;

                        iZRSL = 0;
                        dZRMY = 0;
                        dZRSY = 0;

                        iZCSL = 0;
                        dZCMY = 0;
                        dZCSY = 0;
                    }

                }
                if (hitInfo.InRowCell)
                {
                    if (selection4.IsRowSelected(hitInfo.RowHandle))
                    {
                        iQCKC += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colQCKC3));
                        dQCMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colQCMY3));
                        dQCSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colQCSY3));

                        iJHSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colJHSL3));
                        dJHMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJHMY3));
                        dJHSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJHSY3));

                        iXTSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colXTSL3));
                        dXTMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colXTMY3));
                        dXTSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colXTSY3));

                        iDRSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colDRSL3));
                        dDRMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colDRMY3));
                        dDRSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colDRSY3));

                        iJRSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colJRSL3));
                        dJRMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJRMY3));
                        dJRSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJRSY3));

                        iXSSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colXSSL3));
                        dXSMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colXSMY3));
                        dXSSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colXSSY3));

                        iJTSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colJTSL3));
                        dJTMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJTMY3));
                        dJTSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJTSY3));

                        iDCSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colDCSL3));
                        dDCMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colDCMY3));
                        dDCSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colDCSY3));

                        iJCSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colJCSL3));
                        dJCMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJCMY3));
                        dJCSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJCSY3));

                        iBFSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colBFSL3));
                        dBFMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colBFMY3));
                        dBFSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colBFSY3));

                        iSYSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colSYSL3));
                        dSYMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colSYMY3));
                        dSYSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colSYSY3));

                        iQMKC += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colQMKC3));
                        dQMMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colQMMY3));
                        dQMSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colQMSY3));

                        iZRSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colZRSL3));
                        dZRMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZRMY3));
                        dZRSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZRSY3));

                        iZCSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colZCSL3));
                        dZCMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZCMY3));
                        dZCSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZCSY3));

                        iPFSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colPFSL3));
                        dPFMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colPFMY3));
                        dPFSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colPFSY3));

                        iYTSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colYTSL3));
                        dYTSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colYTSY3));
                        dYTMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colYTMY3));

                        dDJ += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colDJ3));


                    }
                    else
                    {
                        iQCKC -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colQCKC3));
                        dQCMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colQCMY3));
                        dQCSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colQCSY3));

                        iJHSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colJHSL3));
                        dJHMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJHMY3));
                        dJHSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJHSY3));

                        iXTSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colXTSL3));
                        dXTMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colXTMY3));
                        dXTSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colXTSY3));

                        iDRSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colDRSL3));
                        dDRMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colDRMY3));
                        dDRSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colDRSY3));

                        iJRSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colJRSL3));
                        dJRMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJRMY3));
                        dJRSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJRSY3));

                        iXSSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colXSSL3));
                        dXSMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colXSMY3));
                        dXSSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colXSSY3));

                        iJTSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colJTSL3));
                        dJTMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJTMY3));
                        dJTSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJTSY3));

                        iDCSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colDCSL3));
                        dDCMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colDCMY3));
                        dDCSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colDCSY3));

                        iJCSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colJCSL3));
                        dJCMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJCMY3));
                        dJCSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJCSY3));

                        iBFSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colBFSL3));
                        dBFMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colBFMY3));
                        dBFSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colBFSY3));

                        iSYSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colSYSL3));
                        dSYMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colSYMY3));
                        dSYSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colSYSY3));

                        iQMKC -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colQMKC3));
                        dQMMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colQMMY3));
                        dQMSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colQMSY3));

                        iZRSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colZRSL3));
                        dZRMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZRMY3));
                        dZRSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZRSY3));

                        iZCSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colZCSL3));
                        dZCMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZCMY3));
                        dZCSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZCSY3));

                        iPFSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colPFSL3));
                        dPFMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colPFMY3));
                        dPFSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colPFSY3));

                        iYTSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colYTSL3));
                        dYTSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colYTSY3));
                        dYTMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colYTMY3));

                        dDJ -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colDJ3));
                    }
                }
            }

        }

        private void gridView5_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator & e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString().Trim();
            }
        }
        private void gridView5_CustomDrawFooterCell(object sender, FooterCellCustomDrawEventArgs e)
        {
            vDrawFootCell(e, colWLBMMC4, "选计：");
            vDrawFootCell(e, colQCKC4, iQCKC.ToString());
            vDrawFootCell(e, colQCMY4, dQCMY.ToString("F2"));
            vDrawFootCell(e, colQCSY4, dQCSY.ToString("F2"));

            vDrawFootCell(e, colJHSL4, iJHSL.ToString());
            vDrawFootCell(e, colJHMY4, dJHMY.ToString("F2"));
            vDrawFootCell(e, colJHSY4, dJHSY.ToString("F2"));

            vDrawFootCell(e, colXTSL4, iXTSL.ToString());
            vDrawFootCell(e, colXTMY4, dXTMY.ToString("F2"));
            vDrawFootCell(e, colXTSY4, dXTSY.ToString("F2"));

            vDrawFootCell(e, colDRSL4, iDRSL.ToString());
            vDrawFootCell(e, colDRMY4, dDRMY.ToString("F2"));
            vDrawFootCell(e, colDRSY4, dDRSY.ToString("F2"));

            vDrawFootCell(e, colJRSL4, iJRSL.ToString());
            vDrawFootCell(e, colJRMY4, dJRMY.ToString("F2"));
            vDrawFootCell(e, colJRSY4, dJRSY.ToString("F2"));

            vDrawFootCell(e, colXSSL4, iXSSL.ToString());
            vDrawFootCell(e, colXSMY4, dXSMY.ToString("F2"));
            vDrawFootCell(e, colXSSY4, dXSSY.ToString("F2"));

            vDrawFootCell(e, colJTSL4, iJTSL.ToString());
            vDrawFootCell(e, colJTMY4, dJTMY.ToString("F2"));
            vDrawFootCell(e, colJTSY4, dJTSY.ToString("F2"));

            vDrawFootCell(e, colDCSL4, iDCSL.ToString());
            vDrawFootCell(e, colDCMY4, dDCMY.ToString("F2"));
            vDrawFootCell(e, colDCSY4, dDCSY.ToString("F2"));

            vDrawFootCell(e, colJCSL4, iJCSL.ToString());
            vDrawFootCell(e, colJCMY4, dJCMY.ToString("F2"));
            vDrawFootCell(e, colJCSY4, dJCSY.ToString("F2"));

            vDrawFootCell(e, colBFSL4, iBFSL.ToString());
            vDrawFootCell(e, colBFMY4, dBFMY.ToString("F2"));
            vDrawFootCell(e, colBFSY4, dBFSY.ToString("F2"));

            vDrawFootCell(e, colSYSL4, iSYSL.ToString());
            vDrawFootCell(e, colSYMY4, dSYMY.ToString("F2"));
            vDrawFootCell(e, colSYSY4, dSYSY.ToString("F2"));

            vDrawFootCell(e, colQMKC4, iQMKC.ToString());
            vDrawFootCell(e, colQMMY4, dQMMY.ToString("F2"));
            vDrawFootCell(e, colQMSY4, dQMSY.ToString("F2"));

            vDrawFootCell(e, colZRSL4, iZRSL.ToString());
            vDrawFootCell(e, colZRMY4, dZRMY.ToString("F2"));
            vDrawFootCell(e, colZRSY4, dZRSY.ToString("F2"));

            vDrawFootCell(e, colZCSL4, iZCSL.ToString());
            vDrawFootCell(e, colZCMY4, dZCMY.ToString("F2"));
            vDrawFootCell(e, colZCSY4, dZCSY.ToString("F2"));

            vDrawFootCell(e, colPFSL4, iPFSL.ToString());
            vDrawFootCell(e, colPFMY4, dPFMY.ToString("F2"));
            vDrawFootCell(e, colPFSY4, dPFSY.ToString("F2"));

            vDrawFootCell(e, colYTSL4, iYTSL.ToString());
            vDrawFootCell(e, colYTSY4, dYTSY.ToString("F2"));
            vDrawFootCell(e, colYTMY4, dYTMY.ToString("F2"));

          



        }
        private void gridView5_MouseUp(object sender, MouseEventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));
            if ((hitInfo.Column != null) && (hitInfo.Column.GetCaption() == "选择"))
            {
                if (hitInfo.InColumn)
                {
                    if (selection4.SelectedCount == view.DataRowCount)
                    {
                        iQCKC = Convert.ToInt64(colQCKC4.SummaryText);
                        dQCMY = Convert.ToDouble(colQCMY4.SummaryText);
                        dQCSY = Convert.ToDouble(colQCSY4.SummaryText);

                        iJHSL = Convert.ToInt64(colJHSL4.SummaryText);
                        dJHMY = Convert.ToDouble(colJHMY4.SummaryText);
                        dJHSY = Convert.ToDouble(colJHSY4.SummaryText);

                        iXTSL = Convert.ToInt64(colXTSL4.SummaryText);
                        dXTMY = Convert.ToDouble(colXTMY4.SummaryText);
                        dXTSY = Convert.ToDouble(colXTSY4.SummaryText);

                        iDRSL = Convert.ToInt64(colDRSL4.SummaryText);
                        dDRMY = Convert.ToDouble(colDRMY4.SummaryText);
                        dDRSY = Convert.ToDouble(colDRSY4.SummaryText);

                        iJRSL = Convert.ToInt64(colJRSL4.SummaryText);
                        dJRMY = Convert.ToDouble(colJRMY4.SummaryText);
                        dJRSY = Convert.ToDouble(colJRSY4.SummaryText);

                        iXSSL = Convert.ToInt64(colXSSL4.SummaryText);
                        dXSMY = Convert.ToDouble(colXSMY4.SummaryText);
                        dXSSY = Convert.ToDouble(colXSSY4.SummaryText);

                        iJTSL = Convert.ToInt64(colJTSL4.SummaryText);
                        dJTMY = Convert.ToDouble(colJTMY4.SummaryText);
                        dJTSY = Convert.ToDouble(colJTSY4.SummaryText);

                        iDCSL = Convert.ToInt64(colDCSL4.SummaryText);
                        dDCMY = Convert.ToDouble(colDCMY4.SummaryText);
                        dDCSY = Convert.ToDouble(colDCSY4.SummaryText);

                        iJCSL = Convert.ToInt64(colJCSL4.SummaryText);
                        dJCMY = Convert.ToDouble(colJCMY4.SummaryText);
                        dJCSY = Convert.ToDouble(colJCSY4.SummaryText);

                        iBFSL = Convert.ToInt64(colBFSL4.SummaryText);
                        dBFMY = Convert.ToDouble(colBFMY4.SummaryText);
                        dBFSY = Convert.ToDouble(colBFSY4.SummaryText);

                        iSYSL = Convert.ToInt64(colSYSL4.SummaryText);
                        dSYMY = Convert.ToDouble(colSYMY4.SummaryText);
                        dSYSY = Convert.ToDouble(colSYSY4.SummaryText);

                        iQMKC = Convert.ToInt64(colQMKC4.SummaryText);
                        dQMMY = Convert.ToDouble(colQMMY4.SummaryText);
                        dQMSY = Convert.ToDouble(colQMSY4.SummaryText);

                        iQCKC = Convert.ToInt64(colQCKC4.SummaryText);
                        dQCMY = Convert.ToDouble(colQCMY4.SummaryText);
                        dQCSY = Convert.ToDouble(colQCSY4.SummaryText);

                        iZRSL = Convert.ToInt64(colZRSL4.SummaryText);
                        dZRMY = Convert.ToDouble(colZRMY4.SummaryText);
                        dZRSY = Convert.ToDouble(colZRSY4.SummaryText);

                        iZCSL = Convert.ToInt64(colZCSL4.SummaryText);
                        dZCMY = Convert.ToDouble(colZCMY4.SummaryText);
                        dZCSY = Convert.ToDouble(colZCSY4.SummaryText);

                        iPFSL = Convert.ToInt64(colPFSL4.SummaryText);
                        dPFMY = Convert.ToDouble(colPFMY4.SummaryText);
                        dPFSY = Convert.ToDouble(colPFSY4.SummaryText);

                        iYTSL = Convert.ToInt64(colYTSL4.SummaryText);
                        dYTSY = Convert.ToDouble(colYTSY4.SummaryText);
                        dYTMY = Convert.ToDouble(colYTMY4.SummaryText);

                   

                    }
                    else
                    {
                        iQCKC = 0;
                        dQCMY = 0;
                        dQCSY = 0;

                        iJHSL = 0;
                        dJHMY = 0;
                        dJHSY = 0;

                        iXTSL = 0;
                        dXTMY = 0;
                        dXTSY = 0;

                        iDRSL = 0;
                        dDRMY = 0;
                        dDRSY = 0;

                        iJRSL = 0;
                        dJRMY = 0;
                        dJRSY = 0;

                        iXSSL = 0;
                        dXSMY = 0;
                        dXSSY = 0;

                        iJTSL = 0;
                        dJTMY = 0;
                        dJTSY = 0;

                        iDCSL = 0;
                        dDCMY = 0;
                        dDCSY = 0;

                        iJCSL = 0;
                        dJCMY = 0;
                        dJCSY = 0;

                        iBFSL = 0;
                        dBFMY = 0;
                        dBFSY = 0;

                        iSYSL = 0;
                        dSYMY = 0;
                        dSYSY = 0;

                        iQMKC = 0;
                        dQMMY = 0;
                        dQMSY = 0;

                        iZRSL = 0;
                        dZRMY = 0;
                        dZRSY = 0;

                        iZCSL = 0;
                        dZCMY = 0;
                        dZCSY = 0;
                    }

                }
                if (hitInfo.InRowCell)
                {
                    if (selection4.IsRowSelected(hitInfo.RowHandle))
                    {
                        iQCKC += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colQCKC4));
                        dQCMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colQCMY4));
                        dQCSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colQCSY4));

                        iJHSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colJHSL4));
                        dJHMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJHMY4));
                        dJHSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJHSY4));

                        iXTSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colXTSL4));
                        dXTMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colXTMY4));
                        dXTSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colXTSY4));

                        iDRSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colDRSL4));
                        dDRMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colDRMY4));
                        dDRSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colDRSY4));

                        iJRSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colJRSL4));
                        dJRMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJRMY4));
                        dJRSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJRSY4));

                        iXSSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colXSSL4));
                        dXSMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colXSMY4));
                        dXSSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colXSSY4));

                        iJTSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colJTSL4));
                        dJTMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJTMY4));
                        dJTSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJTSY4));

                        iDCSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colDCSL4));
                        dDCMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colDCMY4));
                        dDCSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colDCSY4));

                        iJCSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colJCSL4));
                        dJCMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJCMY4));
                        dJCSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJCSY4));

                        iBFSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colBFSL4));
                        dBFMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colBFMY4));
                        dBFSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colBFSY4));

                        iSYSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colSYSL4));
                        dSYMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colSYMY4));
                        dSYSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colSYSY4));

                        iQMKC += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colQMKC4));
                        dQMMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colQMMY4));
                        dQMSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colQMSY4));

                        iZRSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colZRSL4));
                        dZRMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZRMY4));
                        dZRSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZRSY4));

                        iZCSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colZCSL4));
                        dZCMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZCMY4));
                        dZCSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZCSY4));

                        iPFSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colPFSL4));
                        dPFMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colPFMY4));
                        dPFSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colPFSY4));

                        iYTSL += Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colYTSL4));
                        dYTSY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colYTSY4));
                        dYTMY += Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colYTMY4));

     
                    }
                    else
                    {
                        iQCKC -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colQCKC4));
                        dQCMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colQCMY4));
                        dQCSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colQCSY4));

                        iJHSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colJHSL4));
                        dJHMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJHMY4));
                        dJHSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJHSY4));

                        iXTSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colXTSL4));
                        dXTMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colXTMY4));
                        dXTSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colXTSY4));

                        iDRSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colDRSL4));
                        dDRMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colDRMY4));
                        dDRSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colDRSY4));

                        iJRSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colJRSL4));
                        dJRMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJRMY4));
                        dJRSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJRSY4));

                        iXSSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colXSSL4));
                        dXSMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colXSMY4));
                        dXSSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colXSSY4));

                        iJTSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colJTSL4));
                        dJTMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJTMY4));
                        dJTSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJTSY4));

                        iDCSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colDCSL4));
                        dDCMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colDCMY4));
                        dDCSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colDCSY4));

                        iJCSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colJCSL4));
                        dJCMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJCMY4));
                        dJCSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colJCSY4));

                        iBFSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colBFSL4));
                        dBFMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colBFMY4));
                        dBFSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colBFSY4));

                        iSYSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colSYSL4));
                        dSYMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colSYMY4));
                        dSYSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colSYSY4));

                        iQMKC -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colQMKC4));
                        dQMMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colQMMY4));
                        dQMSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colQMSY4));

                        iZRSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colZRSL4));
                        dZRMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZRMY4));
                        dZRSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZRSY4));

                        iZCSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colZCSL4));
                        dZCMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZCMY4));
                        dZCSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colZCSY4));

                        iPFSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colPFSL4));
                        dPFMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colPFMY4));
                        dPFSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colPFSY4));

                        iYTSL -= Convert.ToInt64(view.GetRowCellValue(hitInfo.RowHandle, colYTSL4));
                        dYTSY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colYTSY4));
                        dYTMY -= Convert.ToDouble(view.GetRowCellValue(hitInfo.RowHandle, colYTMY4));

                      
                    }
                }
            }

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));

            FormCollection fc = Application.OpenForms;

            if (hitInfo.HitTest == GridHitTest.RowCell)
            {
                if ((hitInfo.Column != null) && (hitInfo.Column == colZTIDMC))
                {
                    string strTemp = view.GetRowCellDisplayText(hitInfo.RowHandle, colZTTZID);
                //    string strCGSHID = "[CGSHID] = \'" + strTemp + "\'";
                    if (fc["FrmPurchaseReceiveDetail"] != null)
                    {
                        fc["FrmPurchaseReceiveDetail"].Close();
                    }
                    this.Tag = "2";
                
                    xpServerCollectionSource2.FixedFilterString = " [ZTTZID] = \'" + strTemp + "\'";
                    gridView2.BestFitColumns();
                    ZTBMZT_Load();

                }
                
      
            }


        }
        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));

            FormCollection fc = Application.OpenForms;

            if (hitInfo.HitTest == GridHitTest.RowCell)
            {
                if ((hitInfo.Column != null) && (hitInfo.Column == colBMMC1))
                {
                    string strTemp = view.GetRowCellDisplayText(hitInfo.RowHandle, colZTBMTZID1);
                    //    string strCGSHID = "[CGSHID] = \'" + strTemp + "\'";
                    if (fc["FrmPurchaseReceiveDetail"] != null)
                    {
                        fc["FrmPurchaseReceiveDetail"].Close();
                    }
                    if(this.comboxBMTZselect.Text.ToString()=="按照商品查看")
                    {SPorKF=true;}
                    else if (this.comboxBMTZselect.Text.ToString() == "按照库房查看")
                    { SPorKF = false; }
                    else
                    {}
                    
                    this.Tag = "3";
                
                    xpServerCollectionSource3.FixedFilterString = " [ZTBMTZID] = \'" + strTemp + "\'";
                    gridView3.BestFitColumns();
                    ZTBMSPTZ_Load();
 
                }




            }


        }
        private void gridView3_DoubleClick(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));

            FormCollection fc = Application.OpenForms;

            if (hitInfo.HitTest == GridHitTest.RowCell)
            {
                if ((hitInfo.Column != null) && (hitInfo.Column == colSPMC2))
                {
                    string strTemp = view.GetRowCellDisplayText(hitInfo.RowHandle, colZTBMSPTZID2);
                    //    string strCGSHID = "[CGSHID] = \'" + strTemp + "\'";
                    if (fc["FrmPurchaseReceiveDetail"] != null)
                    {
                        fc["FrmPurchaseReceiveDetail"].Close();
                    }


                    this.Tag = "4";

                    xpServerCollectionSource4.FixedFilterString =" [ZTBMSPTZID] = \'" + strTemp + "\'";
                    gridView4.BestFitColumns();
                    ZTBMSPKF_Load();


                }




            }


        }
        private void gridView4_DoubleClick(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));

            FormCollection fc = Application.OpenForms;

            if (hitInfo.HitTest == GridHitTest.RowCell)
            {
                if ((hitInfo.Column != null) && (hitInfo.Column == colSPMC3))
                {
                    string strTemp = view.GetRowCellDisplayText(hitInfo.RowHandle, colZTBMSPKFTZID3);
                    //    string strCGSHID = "[CGSHID] = \'" + strTemp + "\'";
                    if (fc["FrmPurchaseReceiveDetail"] != null)
                    {
                        fc["FrmPurchaseReceiveDetail"].Close();
                    }


                    this.Tag = "5";
                    if (SPorKF == true)
                    { xpServerCollectionSource5.FixedFilterString = " [ZTBMSPKFTZID] = \'" + strTemp + "\'"; }
                    else
                    { xpServerCollectionSource5.FixedFilterString = " [ZTBMSPKFTZID] = \'" + strTemp + "\'"; }
                   
                    gridView5.BestFitColumns();
                    ZTBMSPMX_Load();


                }




            }


        }


        private void ZTTZ_Load()
        {
            selection1.ClearSelection();
            selection2.ClearSelection();
            selection3.ClearSelection();
            selection4.ClearSelection();
            selection5.ClearSelection();

            this.btn_ZTTZinquire.BackColor = SystemColors.ControlDark;
            this.btn_BMTZinquire.BackColor = SystemColors.Control;
            this.btnKFMXinquire.BackColor = SystemColors.Control;
            this.btnKFTZinquire.BackColor = SystemColors.Control;
            this.btnSPTZinquire.BackColor = SystemColors.Control;
            this.Text = "您当前在帐套台账界面";
            this.gridControl1.Visible = true;
            gridControl1.Dock = DockStyle.Fill;
            xpServerCollectionSource1.FixedFilterString = " [ZTID] = \'" + FrmLogin.getZTID + "\'"; 
            gridView1.BestFitColumns();
            xpServerCollectionSource2.Dispose();
            gridControl2.Visible = false;
            xpServerCollectionSource3.Dispose();
            gridControl3.Visible = false;
            xpServerCollectionSource4.Dispose();
            gridControl4.Visible = false;
            xpServerCollectionSource5.Dispose();
            gridControl5.Visible = false;
            this.comboxBMTZselect.Visible = false;
      

 
        }
        private void ZTBMZT_Load()
        {
            selection1.ClearSelection();
            selection2.ClearSelection();
            selection3.ClearSelection();
            selection4.ClearSelection();
            selection5.ClearSelection();


            this.btn_BMTZinquire.BackColor = SystemColors.ControlDark;
            this.btn_ZTTZinquire.BackColor = SystemColors.Control;
            this.btnKFMXinquire.BackColor = SystemColors.Control;
            this.btnKFTZinquire.BackColor = SystemColors.Control;
            this.btnSPTZinquire.BackColor = SystemColors.Control;
            this.Text = "您当前在部门台账界面";
            this.gridControl2.Visible = true;
            gridControl2.Dock = DockStyle.Fill;
          //  xpServerCollectionSource2.FixedFilterString = " [ZTID] = \'" + FrmLogin.getZTID + "\'";
            gridView2.BestFitColumns();
            xpServerCollectionSource1.Dispose();
            gridControl1.Visible = false;
            xpServerCollectionSource3.Dispose();
            gridControl3.Visible = false;
            xpServerCollectionSource4.Dispose();
            gridControl4.Visible = false;
            xpServerCollectionSource5.Dispose();
            gridControl5.Visible = false;
            this.comboxBMTZselect.Visible = true;
            this.comboxBMTZselect.Text = "按照商品查看";
        }
        private void ZTBMSPTZ_Load()
        {
            selection1.ClearSelection();
            selection2.ClearSelection();
            selection3.ClearSelection();
            selection4.ClearSelection();
            selection5.ClearSelection();


            this.btnSPTZinquire.BackColor = SystemColors.ControlDark;
            this.btn_ZTTZinquire.BackColor = SystemColors.Control;
            this.btnKFMXinquire.BackColor = SystemColors.Control;
            this.btnKFTZinquire.BackColor = SystemColors.Control;
            this.btn_BMTZinquire.BackColor = SystemColors.Control;

            this.Text = "您当前在商品台账界面";
            this.gridControl3.Visible = true;
            gridControl3.Dock = DockStyle.Fill;
       //     xpServerCollectionSource3.FixedFilterString = " [ZTID] = \'" + FrmLogin.getZTID + "\'";
            gridView1.BestFitColumns();
            xpServerCollectionSource2.Dispose();
            gridControl2.Visible = false;
            xpServerCollectionSource1.Dispose();
            gridControl1.Visible = false;
            xpServerCollectionSource4.Dispose();
            gridControl4.Visible = false;
            xpServerCollectionSource5.Dispose();
            gridControl5.Visible = false;
            this.comboxBMTZselect.Visible = false;
        }
        private void ZTBMSPKF_Load()
        {

            selection1.ClearSelection();
            selection2.ClearSelection();
            selection3.ClearSelection();
            selection4.ClearSelection();
            selection5.ClearSelection();

            this.btnKFTZinquire.BackColor = SystemColors.ControlDark;
            this.btn_ZTTZinquire.BackColor = SystemColors.Control;
            this.btnKFMXinquire.BackColor = SystemColors.Control;
            this.btnSPTZinquire.BackColor = SystemColors.Control;
            this.btn_BMTZinquire.BackColor = SystemColors.Control;

            this.Text = "您当前在库房台账界面";
            this.gridControl4.Visible = true;
            gridControl4.Dock = DockStyle.Fill;
          //  xpServerCollectionSource4.FixedFilterString = " [ZTID] = \'" + FrmLogin.getZTID + "\'";
            gridView1.BestFitColumns();
            xpServerCollectionSource2.Dispose();
            gridControl2.Visible = false;
            xpServerCollectionSource3.Dispose();
            gridControl3.Visible = false;
            xpServerCollectionSource1.Dispose();
            gridControl1.Visible = false;
            xpServerCollectionSource5.Dispose();
            gridControl5.Visible = false;
            this.comboxBMTZselect.Visible = false;
        }
        private void ZTBMSPMX_Load()
        {

            selection1.ClearSelection();
            selection2.ClearSelection();
            selection3.ClearSelection();
            selection4.ClearSelection();
            selection5.ClearSelection();

            this.btnKFMXinquire.BackColor = SystemColors.ControlDark;
            this.btn_ZTTZinquire.BackColor = SystemColors.Control;
            this.btnKFTZinquire.BackColor = SystemColors.Control;
            this.btnSPTZinquire.BackColor = SystemColors.Control;
            this.btn_BMTZinquire.BackColor = SystemColors.Control;

            this.Text = "您当前在库房明细界面";
            this.gridControl5.Visible = true;
            gridControl5.Dock = DockStyle.Fill;
            xpServerCollectionSource5.FixedFilterString = " [ZTID] = \'" + FrmLogin.getZTID + "\'";
            gridView1.BestFitColumns();
            xpServerCollectionSource2.Dispose();
            gridControl2.Visible = false;
            xpServerCollectionSource3.Dispose();
            gridControl3.Visible = false;
            xpServerCollectionSource1.Dispose();
            gridControl1.Visible = false;
            xpServerCollectionSource1.Dispose();
            gridControl1.Visible = false;
            this.comboxBMTZselect.Visible = false;
        }
        private void From_Load()
        {
            if(this.Tag.ToString()=="1")
            {
                ZTTZ_Load();
            }
            else if(this.Tag.ToString()=="2")
            {
                ZTBMZT_Load();
            }
            else if(this.Tag.ToString()=="3")
            {
                ZTBMSPTZ_Load();
            }
            else if(this.Tag.ToString()=="4")
            {
                ZTBMSPKF_Load();
            }
            else if (this.Tag.ToString() == "5")
            {
                ZTBMSPMX_Load();
            }
            else
            {}
        }
        private void FrmZTTZinquire_Load(object sender, EventArgs e)
        {
            From_Load();
        }

        private void btn_ZTTZinquire_Click(object sender, EventArgs e)
        {

            selection1.ClearSelection();
            gridView1.ShowFilterEditor(gridView1.FocusedColumn);

            if (!String.IsNullOrEmpty(gridView1.ActiveFilterString))
            {
                this.Tag = "1";
                ZTTZ_Load();
                xpServerCollectionSource1.FixedFilterString = gridView1.ActiveFilterString + " And [ZTID] = \'" + FrmLogin.getZTID + "\'";
               
                gridView1.BestFitColumns();
                
            }
        }

        private void btn_BMTZinquire_Click(object sender, EventArgs e)
        {
            this.Tag = "2";
       //     selection2.ClearSelection();
            gridView2.ShowFilterEditor(gridView2.FocusedColumn);

            if (!String.IsNullOrEmpty(gridView2.ActiveFilterString))
            {
                ZTBMZT_Load();
                xpServerCollectionSource2.FixedFilterString = gridView2.ActiveFilterString + " And [ZTID] = \'" + FrmLogin.getZTID + "\'";
               
                gridView2.BestFitColumns();
                
            }
        }

        private void btnSPTZinquire_Click(object sender, EventArgs e)
        {

            this.Tag = "3";
            gridView3.ShowFilterEditor(gridView3.FocusedColumn);

            if (!String.IsNullOrEmpty(gridView3.ActiveFilterString))
            {
                ZTBMSPTZ_Load();
                xpServerCollectionSource3.FixedFilterString = gridView3.ActiveFilterString + " And [ZTID] = \'" + FrmLogin.getZTID + "\'";
               
                gridView3.BestFitColumns();
            }
        }

        private void btnKFTZinquire_Click(object sender, EventArgs e)
        {
            this.Tag = "4";
            gridView4.ShowFilterEditor(gridView4.FocusedColumn);

            if (!String.IsNullOrEmpty(gridView4.ActiveFilterString))
            {
                ZTBMSPKF_Load();
                xpServerCollectionSource4.FixedFilterString = gridView4.ActiveFilterString + " And [ZTID] = \'" + FrmLogin.getZTID + "\'";
                
                gridView4.BestFitColumns();
            }
        }

        private void btnKFMXinquire_Click(object sender, EventArgs e)
        {
            this.Tag = "5";
            gridView5.ShowFilterEditor(gridView5.FocusedColumn);

            if (!String.IsNullOrEmpty(gridView5.ActiveFilterString))
            {
                ZTBMSPMX_Load();
                xpServerCollectionSource5.FixedFilterString = gridView5.ActiveFilterString + " And [ZTID] = \'" + FrmLogin.getZTID + "\'";
                
                gridView5.BestFitColumns();
            }
        }

        private void btnPrintGrid_Click(object sender, EventArgs e)
        {
            if (this.Tag.ToString() == "1")
            {
                gridView1.Columns["CheckMarkSelection"].Visible = false;

                gridView1.SelectAll();
                gridControl1.ShowPrintPreview();

                gridView1.Columns["CheckMarkSelection"].Visible = true;
                gridView1.Columns["CheckMarkSelection"].VisibleIndex = 0;
            }
            else if (this.Tag.ToString() == "2")
            {
                gridView2.Columns["CheckMarkSelection"].Visible = false;

                gridView2.SelectAll();
                gridControl2.ShowPrintPreview();

                gridView2.Columns["CheckMarkSelection"].Visible = true;
                gridView2.Columns["CheckMarkSelection"].VisibleIndex = 0;
            }
            else if (this.Tag.ToString() == "3")
            {
                gridView3.Columns["CheckMarkSelection"].Visible = false;

                gridView3.SelectAll();
                gridControl1.ShowPrintPreview();

                gridView3.Columns["CheckMarkSelection"].Visible = true;
                gridView3.Columns["CheckMarkSelection"].VisibleIndex = 0;
            }
            else if (this.Tag.ToString() == "4")
            {
                gridView4.Columns["CheckMarkSelection"].Visible = false;

                gridView4.SelectAll();
                gridControl1.ShowPrintPreview();

                gridView4.Columns["CheckMarkSelection"].Visible = true;
                gridView4.Columns["CheckMarkSelection"].VisibleIndex = 0;
            }
            else if (this.Tag.ToString() == "5")
            {
                gridView5.Columns["CheckMarkSelection"].Visible = false;

                gridView5.SelectAll();
                gridControl1.ShowPrintPreview();

                gridView5.Columns["CheckMarkSelection"].Visible = true;
                gridView5.Columns["CheckMarkSelection"].VisibleIndex = 0;
            }
            else
            { }
        }

        private void btnExportGrid_Click(object sender, EventArgs e)
        {
            if (this.Tag.ToString() == "1")
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
            else if (this.Tag.ToString() == "2")
            {
                if (gridView2.DataRowCount > MAXROWCOUNT)
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
                        gridView2.Columns["CheckMarkSelection"].Visible = false;

                        gridView2.SelectAll();
                        gridView2.ExportToXls(saveDialog.FileName);

                        gridView2.Columns["CheckMarkSelection"].Visible = true;
                        gridView2.Columns["CheckMarkSelection"].VisibleIndex = 0;

                        MessageBox.Show("导出成功！");

                    }
                }
            }
            else if (this.Tag.ToString() == "3")
            {
                if (gridView3.DataRowCount > MAXROWCOUNT)
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
                        gridView3.Columns["CheckMarkSelection"].Visible = false;

                        gridView3.SelectAll();
                        gridView3.ExportToXls(saveDialog.FileName);

                        gridView3.Columns["CheckMarkSelection"].Visible = true;
                        gridView3.Columns["CheckMarkSelection"].VisibleIndex = 0;

                        MessageBox.Show("导出成功！");

                    }
                }
            }
            else if (this.Tag.ToString() == "4")
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
                        gridView4.Columns["CheckMarkSelection"].Visible = false;

                        gridView4.SelectAll();
                        gridView4.ExportToXls(saveDialog.FileName);

                        gridView4.Columns["CheckMarkSelection"].Visible = true;
                        gridView4.Columns["CheckMarkSelection"].VisibleIndex = 0;

                        MessageBox.Show("导出成功！");

                    }
                }
            }
            else if (this.Tag.ToString() == "5")
            {
                if (gridView5.DataRowCount > MAXROWCOUNT)
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
                        gridView5.Columns["CheckMarkSelection"].Visible = false;

                        gridView5.SelectAll();
                        gridView5.ExportToXls(saveDialog.FileName);

                        gridView5.Columns["CheckMarkSelection"].Visible = true;
                        gridView5.Columns["CheckMarkSelection"].VisibleIndex = 0;

                        MessageBox.Show("导出成功！");

                    }
                }
            }
            else
            { }
        }




        
     




    }
}
