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
    public partial class EmpoeeTable : Form
    {
        private GridCheckMarksSelection selection;
        public EmpoeeTable()
        {
            InitializeComponent();
            XpoDefault.ConnectionString = OracleConnectionProvider.GetConnectionString("XINHUA", "xxb", "pass");
            selection = new GridCheckMarksSelection(gridView1);
            selection.CheckMarkColumn.VisibleIndex = 0;

        }
        private static  string employid = "";
        private static  string employname = "";
        public static string GetEmployid
        {
            get
            {
                return employid;
            }
            set
            {
                employid = value;
            }
        }
        public static string GetEmployname
        {
            get
            {
                return employname;
            }
            set
            {
               
                employname = value;
            }
        }

        private void EmpoeeTable1_Load(object sender, EventArgs e)
        {

        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            selection.ClearSelection();
            gridView1.ShowFilterEditor(gridView1.FocusedColumn);
            xpServerCollectionSource1.Reload();
            if (!String.IsNullOrEmpty(gridView1.ActiveFilterString))
            {
                xpServerCollectionSource1.FixedFilterString = gridView1.ActiveFilterString;
                gridView1.BestFitColumns();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCanncle_Click(object sender, EventArgs e)
        {
            selection.ClearSelection();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(selection.SelectedCount!=1)
            {
                MessageBox.Show("必须选择一个员工");
            }
            else
            {
                int RowIndex = selection.GetSelectedRowIndex(0);
                int RowHandle = gridView1.GetRowHandle(RowIndex);
                employid = this.gridView1.GetRowCellDisplayText(RowHandle, "EMPLOYEEID");
                employname = this.gridView1.GetRowCellDisplayText(RowHandle, "NAME");
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
        }


    }
}
