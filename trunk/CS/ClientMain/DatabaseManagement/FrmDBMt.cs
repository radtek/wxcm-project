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
    public partial class FrmDBMt : DevExpress.XtraEditors.XtraForm
    {
        bool m_fgAdd;
        bool m_fgDel;
        bool m_fgUpdate;
        bool m_fgQuery;

        OracleConnection Con;
        OracleDataAdapter Adapter;
        OracleDataAdapter adaGridview;
        DataSet ds;
        //OracleCommandBuilder cb;
        DataTable dt;
        OracleCommand cmd;

        public FrmDBMt(bool fgAdd, bool fgDel, bool fgUpdate, bool fgQuery)
        {
            InitializeComponent();

            m_fgAdd = fgAdd;
            m_fgDel = fgDel;
            m_fgQuery = fgQuery;
            m_fgUpdate = fgUpdate;
        }

        private void FrmDBMt_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = bindingSource1;

            string strCon = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.8.222)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XINHUA)));User Id=xxb;Password=pass;Integrated Security=no;";
            Con = new OracleConnection(strCon);

            string strSQL = "select * from BASE_ZT_DB";
            Adapter = new OracleDataAdapter(strSQL, Con);
            //cb = new OracleCommandBuilder(Adapter);            

            string strGridView = "select (select a.ztmc from sys_ztbm a where a.ztid = t.ztid) as 账套名称, "
                               + "(select b.typename from base_systype b where b.typeid = t.systype) as 系统类型, "
                               + "(select c.typename from base_dbtype c where c.typeid = t.dbtype) as 数据库类型, "
                               + "server as 主机名, username as 用户名, password as 密码 , dbname as 数据库名称 from base_zt_db t";
            adaGridview = new OracleDataAdapter(strGridView, Con);

            ds = new DataSet();
            Adapter.Fill(ds, "BASE_ZT_DB");
            adaGridview.Fill(ds, "DATAGRIDVIEW");

            dt = ds.Tables["BASE_ZT_DB"];

            bindingSource1.DataSource = ds;
            bindingSource1.DataMember = "DATAGRIDVIEW";

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            if (m_fgAdd)
            {
                btnAdd.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else
            {
                btnAdd.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }

            if (m_fgDel)
            {
                btnDel.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else
            {
                btnDel.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }

            if (m_fgUpdate)
            {
                btnUpdate.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else
            {
                btnUpdate.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }

            //if (m_fgQuery)
            //{
            //    btnQuery.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            //}
            //else
            //{
            //    btnQuery.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            //}
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {            
            FrmDBMtChild frmAdd = new FrmDBMtChild();
            frmAdd.Text = "增加数据库";

            if (frmAdd.ShowDialog() == DialogResult.OK)
            {
                string strIns = "INSERT INTO BASE_ZT_DB (ZTID, SYSTYPE, DBTYPE, SERVER, USERNAME, PASSWORD, DBNAME) VALUES "
                          + "(:ZTID, :SYSTYPE, :DBTYPE, :SERVER, :USERNAME, :PASSWORD, :DBNAME)";

                cmd = new OracleCommand(strIns, Con);
                Adapter.InsertCommand = cmd;
                Adapter.InsertCommand.Parameters.Add(new OracleParameter("ZTID", OracleType.VarChar, 20, "ZTID"));
                Adapter.InsertCommand.Parameters.Add(new OracleParameter("SYSTYPE", OracleType.VarChar, 20, "SYSTYPE"));
                Adapter.InsertCommand.Parameters.Add(new OracleParameter("DBTYPE", OracleType.VarChar, 100, "DBTYPE"));
                Adapter.InsertCommand.Parameters.Add(new OracleParameter("SERVER", OracleType.VarChar, 20, "SERVER"));
                Adapter.InsertCommand.Parameters.Add(new OracleParameter("USERNAME", OracleType.VarChar, 20, "USERNAME"));
                Adapter.InsertCommand.Parameters.Add(new OracleParameter("PASSWORD", OracleType.VarChar, 20, "PASSWORD"));
                Adapter.InsertCommand.Parameters.Add(new OracleParameter("DBNAME", OracleType.VarChar, 100, "DBNAME"));


                DataRow newRow = dt.NewRow();
                newRow["ZTID"] = frmAdd.getZT();
                newRow["SYSTYPE"] = frmAdd.getSysType();
                newRow["DBTYPE"] = frmAdd.getDBType();
                newRow["SERVER"] = frmAdd.getServer();
                newRow["USERNAME"] = frmAdd.getUser();
                newRow["PASSWORD"] = frmAdd.getPass();
                newRow["DBNAME"] = frmAdd.getDBName();

                dt.Rows.Add(newRow);

                Adapter.Update(ds, "BASE_ZT_DB");

                this.FrmDBMt_Load(sender, e);
            }
        }

        private void btnDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            const string message = "确定删除吗?";
            const string caption = "删除?";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string strDel = "DELETE FROM BASE_ZT_DB where ZTID = :ZTID and SYSTYPE = :SYSTYPE";

                cmd = new OracleCommand(strDel, Con);
                Adapter.DeleteCommand = cmd;
                Adapter.DeleteCommand.Parameters.Add(new OracleParameter("ZTID", OracleType.VarChar, 20, "ZTID"));
                Adapter.DeleteCommand.Parameters.Add(new OracleParameter("SYSTYPE", OracleType.VarChar, 20, "SYSTYPE"));

                dt.Rows[dataGridView1.CurrentRow.Index].Delete();

                Adapter.Update(ds, "BASE_ZT_DB");

                this.FrmDBMt_Load(sender, e);
            }
        }

        private void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strZTID = dataGridView1.CurrentRow.Cells["账套名称"].Value.ToString();
            string strSysType = dataGridView1.CurrentRow.Cells["系统类型"].Value.ToString();
            string strDBType = dataGridView1.CurrentRow.Cells["数据库类型"].Value.ToString();
            string strServer = dataGridView1.CurrentRow.Cells["主机名"].Value.ToString();
            string strUser = dataGridView1.CurrentRow.Cells["用户名"].Value.ToString();
            string strPass = dataGridView1.CurrentRow.Cells["密码"].Value.ToString();
            string strDBName = dataGridView1.CurrentRow.Cells["数据库名称"].Value.ToString();

            FrmDBMtChild frmUpdate = new FrmDBMtChild(strZTID, strSysType, strDBType, strServer, strUser, strPass, strDBName);
            frmUpdate.Text = "修改数据库";
            frmUpdate.cbAccount.Enabled = false;
            frmUpdate.cbSysType.Enabled = false;

            if (frmUpdate.ShowDialog() == DialogResult.OK)
            {
                string strUpdate = "UPDATE BASE_ZT_DB Set DBTYPE = :DBTYPE, SERVER = :SERVER, "
                                 + "USERNAME = :USERNAME, PASSWORD = :PASSWORD, DBNAME = :DBNAME where ZTID = :ZTID and SYSTYPE = :SYSTYPE";

                cmd = new OracleCommand(strUpdate, Con);
                Adapter.UpdateCommand = cmd;
                Adapter.UpdateCommand.Parameters.Add(new OracleParameter("ZTID", OracleType.VarChar, 20, "ZTID"));
                Adapter.UpdateCommand.Parameters.Add(new OracleParameter("SYSTYPE", OracleType.VarChar, 20, "SYSTYPE"));
                Adapter.UpdateCommand.Parameters.Add(new OracleParameter("DBTYPE", OracleType.VarChar, 100, "DBTYPE"));
                Adapter.UpdateCommand.Parameters.Add(new OracleParameter("SERVER", OracleType.VarChar, 20, "SERVER"));
                Adapter.UpdateCommand.Parameters.Add(new OracleParameter("USERNAME", OracleType.VarChar, 20, "USERNAME"));
                Adapter.UpdateCommand.Parameters.Add(new OracleParameter("PASSWORD", OracleType.VarChar, 20, "PASSWORD"));
                Adapter.UpdateCommand.Parameters.Add(new OracleParameter("DBNAME", OracleType.VarChar, 100, "DBNAME"));

                //dt.Rows[dataGridView1.CurrentRow.Index]["ZTID"] = frmUpdate.getZT();
                //dt.Rows[dataGridView1.CurrentRow.Index]["SYSTYPE"] = frmUpdate.getSysType();
                dt.Rows[dataGridView1.CurrentRow.Index]["DBTYPE"] = frmUpdate.getDBType();
                dt.Rows[dataGridView1.CurrentRow.Index]["SERVER"] = frmUpdate.getServer();
                dt.Rows[dataGridView1.CurrentRow.Index]["USERNAME"] = frmUpdate.getUser();
                dt.Rows[dataGridView1.CurrentRow.Index]["PASSWORD"] = frmUpdate.getPass();
                dt.Rows[dataGridView1.CurrentRow.Index]["DBNAME"] = frmUpdate.getDBName();

                Adapter.Update(ds, "BASE_ZT_DB");

                this.FrmDBMt_Load(sender, e);
            }

        }

        private void btnQuit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}