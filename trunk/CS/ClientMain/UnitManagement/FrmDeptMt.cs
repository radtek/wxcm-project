

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClientMain
{
    public partial class FrmDeptMt : Form
    {
        OracleConnection Con;
        OracleDataAdapter Adapter;
        DataSet ds;
        OracleCommandBuilder cb;
        DataTable dt;
        OracleCommand cmd;

        bool m_fgAdd;
        bool m_fgDel;
        bool m_fgUpdate;
        bool m_fgQuery;

        public FrmDeptMt(bool fgAdd, bool fgDel, bool fgUpdate, bool fgQuery)
        {
            InitializeComponent();

            m_fgAdd = fgAdd;
            m_fgDel = fgDel;
            m_fgQuery = fgQuery;
            m_fgUpdate = fgUpdate;
        }

        private void FrmDeptMt_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingSource1;

            string strCon = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.8.222)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XINHUA)));User Id=xxb;Password=pass;Integrated Security=no;";
            Con = new OracleConnection(strCon);

            string strSQL = "select * from SYS_DEPARTMENT";
            Adapter = new OracleDataAdapter(strSQL, Con);
            cb = new OracleCommandBuilder(Adapter);
           
            ds = new DataSet();
            Adapter.Fill(ds, "SYS_DEPARTMENT");

            dt = ds.Tables["SYS_DEPARTMENT"];

            foreach (DataRow theRow in dt.Rows)
            {
                theRow["ZTID"] = FrmLogin.getDictID2Name[theRow["ZTID"].ToString()];
            }
            
            bindingSource1.DataSource = ds;
            bindingSource1.DataMember = "SYS_DEPARTMENT";

            this.dataGridView1.Columns["DEPARTMENTID"].Visible = false;
            this.dataGridView1.Columns["DWSX"].Visible = false;
            this.dataGridView1.Columns["BMLXID"].Visible = false;
            this.dataGridView1.Columns["KHLXID"].Visible = false;
            this.dataGridView1.Columns["GYSLXID"].Visible = false;
            this.dataGridView1.Columns["CBSLXID"].Visible = false;
            this.dataGridView1.Columns["YSCLXID"].Visible = false;
            this.dataGridView1.Columns["KFLXID"].Visible = false;
            this.dataGridView1.Columns["YSBMLXID"].Visible = false;
            this.dataGridView1.Columns["SJDWID"].Visible = false;
            this.dataGridView1.Columns["KHDNO"].Visible = false;
            this.dataGridView1.Columns["JCJCNO"].Visible = false; 
            this.dataGridView1.Columns["YTHNO"].Visible = false;

            this.dataGridView1.Columns["DEPARTMENTID"].HeaderText = "部门ID";
            this.dataGridView1.Columns["DEPARTMENTNAME"].HeaderText = "部门名称";
            this.dataGridView1.Columns["DESCRIPTION"].HeaderText = "部门描述";
            this.dataGridView1.Columns["ZTID"].HeaderText = "账套ID";
            this.dataGridView1.Columns["DEPARTMENTNO"].HeaderText = "部门编号";
            this.dataGridView1.Columns["SFZT"].HeaderText = "是否账套";

        
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

            if (m_fgQuery)
            {
                btnQuery.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else
            {
                btnQuery.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDeptMtChild frmAdd = new FrmDeptMtChild();
            frmAdd.Text = "增加单位";

            if (frmAdd.ShowDialog() == DialogResult.OK)
            {
                string strIns = "INSERT INTO SYS_DEPARTMENT (DEPARTMENTID, DEPARTMENTNAME, DESCRIPTION, ZTID, DEPARTMENTNO, SFZT, "
                              + "SJDWID, DWSX, BMLXID, KHLXID, GYSLXID, CBSLXID, YSCLXID, YSBMLXID, KFLXID, KHDNO, JCJCNO, YTHNO) "
                              + "VALUES (seq_sys_user_userid.nextval, :DEPARTMENTNAME, :DESCRIPTION, :ZTID, :DEPARTMENTNO, :SFZT, "
                              + ":SJDWID, :DWSX, :BMLXID, :KHLXID, :GYSLXID, :CBSLXID, :YSCLXID, :YSBMLXID, :KFLXID, :KHDNO, :JCJCNO, :YTHNO)";

                cmd = new OracleCommand(strIns, Con);
                Adapter.InsertCommand = cmd;
                Adapter.InsertCommand.Parameters.Add(new OracleParameter("DEPARTMENTNAME", OracleType.VarChar, 64, "DEPARTMENTNAME"));
                Adapter.InsertCommand.Parameters.Add(new OracleParameter("DESCRIPTION", OracleType.VarChar, 120, "DESCRIPTION"));
                Adapter.InsertCommand.Parameters.Add(new OracleParameter("DEPARTMENTNO", OracleType.VarChar, 16, "DEPARTMENTNO"));
                Adapter.InsertCommand.Parameters.Add(new OracleParameter("SFZT", OracleType.VarChar, 2, "SFZT"));
                Adapter.InsertCommand.Parameters.Add(new OracleParameter("ZTID", OracleType.VarChar, 16, "ZTID"));
                Adapter.InsertCommand.Parameters.Add(new OracleParameter("SJDWID", OracleType.VarChar, 16, "SJDWID"));
                Adapter.InsertCommand.Parameters.Add(new OracleParameter("DWSX", OracleType.VarChar, 5, "DWSX"));
                Adapter.InsertCommand.Parameters.Add(new OracleParameter("BMLXID", OracleType.VarChar, 16, "BMLXID"));
                Adapter.InsertCommand.Parameters.Add(new OracleParameter("KHLXID", OracleType.VarChar, 16, "KHLXID"));
                Adapter.InsertCommand.Parameters.Add(new OracleParameter("GYSLXID", OracleType.VarChar, 16, "GYSLXID"));
                Adapter.InsertCommand.Parameters.Add(new OracleParameter("CBSLXID", OracleType.VarChar, 16, "CBSLXID"));
                Adapter.InsertCommand.Parameters.Add(new OracleParameter("YSCLXID", OracleType.VarChar, 16, "YSCLXID"));
                Adapter.InsertCommand.Parameters.Add(new OracleParameter("YSBMLXID", OracleType.VarChar, 16, "YSBMLXID"));
                Adapter.InsertCommand.Parameters.Add(new OracleParameter("KFLXID", OracleType.VarChar, 16, "KFLXID"));
                Adapter.InsertCommand.Parameters.Add(new OracleParameter("KHDNO", OracleType.VarChar, 16, "KHDNO"));
                Adapter.InsertCommand.Parameters.Add(new OracleParameter("JCJCNO", OracleType.VarChar, 16, "JCJCNO"));
                Adapter.InsertCommand.Parameters.Add(new OracleParameter("YTHNO", OracleType.VarChar, 16, "YTHNO"));


                DataRow newRow = dt.NewRow();
                newRow["DEPARTMENTNAME"] = frmAdd.getDeptName();
                newRow["DESCRIPTION"] = frmAdd.getDeptDesc();
                newRow["ZTID"] = frmAdd.getZTID();
                newRow["DEPARTMENTNO"] = frmAdd.getDeptNum();
                newRow["SFZT"] = frmAdd.getISZT();
                newRow["SJDWID"] = frmAdd.getSuperUnit();
                newRow["DWSX"] = frmAdd.getUnitProp();
                newRow["BMLXID"] = frmAdd.getDeptType();
                newRow["KHLXID"] = frmAdd.getClientType();
                newRow["GYSLXID"] = frmAdd.getSupType();
                newRow["CBSLXID"] = frmAdd.getPressType();
                newRow["YSCLXID"] = frmAdd.getFacType();
                newRow["YSBMLXID"] = frmAdd.getTransType();
                newRow["KFLXID"] = frmAdd.getWareType();
                newRow["KHDNO"] = frmAdd.getKHDNum();
                newRow["JCJCNO"] = frmAdd.getJCJCNum();
                newRow["YTHNO"] = frmAdd.getYTHNum();

                dt.Rows.Add(newRow);

                foreach (DataRow theRow in dt.Rows)
                {
                    theRow["ZTID"] = FrmLogin.getDictName2ID[theRow["ZTID"].ToString()];
                }

                Adapter.Update(ds, "SYS_DEPARTMENT");

                this.FrmDeptMt_Load(sender, e);
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
                foreach (DataRow theRow in dt.Rows)
                {
                    theRow["ZTID"] = FrmLogin.getDictName2ID[theRow["ZTID"].ToString()];
                }

                dt.Rows[dataGridView1.CurrentRow.Index].Delete();

                Adapter.Update(ds, "SYS_DEPARTMENT");

                this.FrmDeptMt_Load(sender, e);
            }
        }

        private void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strDeptName = dataGridView1.CurrentRow.Cells["DEPARTMENTNAME"].Value.ToString();
            string strDeptDesc = dataGridView1.CurrentRow.Cells["DESCRIPTION"].Value.ToString();
            string strZTID = dataGridView1.CurrentRow.Cells["ZTID"].Value.ToString();
            string strDeptNum = dataGridView1.CurrentRow.Cells["DEPARTMENTNO"].Value.ToString();
            string strSFZT = dataGridView1.CurrentRow.Cells["SFZT"].Value.ToString();
            string strUnitProp = dataGridView1.CurrentRow.Cells["DWSX"].Value.ToString();
            string strDeptType = dataGridView1.CurrentRow.Cells["BMLXID"].Value.ToString();
            string strClientType = dataGridView1.CurrentRow.Cells["KHLXID"].Value.ToString();
            string strSupType = dataGridView1.CurrentRow.Cells["GYSLXID"].Value.ToString();
            string strPressType = dataGridView1.CurrentRow.Cells["CBSLXID"].Value.ToString();
            string strFacType = dataGridView1.CurrentRow.Cells["YSCLXID"].Value.ToString();
            string strWareType = dataGridView1.CurrentRow.Cells["KFLXID"].Value.ToString();
            string strTransType = dataGridView1.CurrentRow.Cells["YSBMLXID"].Value.ToString();
            string strSuperUnit = dataGridView1.CurrentRow.Cells["SJDWID"].Value.ToString();
            string strYTH = dataGridView1.CurrentRow.Cells["YTHNO"].Value.ToString();
            string strJCJC = dataGridView1.CurrentRow.Cells["JCJCNO"].Value.ToString();
            string strKHD = dataGridView1.CurrentRow.Cells["KHDNO"].Value.ToString();

            FrmDeptMtChild frmUpdate = new FrmDeptMtChild(strDeptName, strDeptDesc, strZTID, strDeptNum, strSFZT, strUnitProp, strDeptType,
                                                          strClientType, strSupType, strPressType, strFacType, strWareType, strTransType, 
                                                          strSuperUnit, strKHD, strJCJC, strYTH);
            frmUpdate.Text = "修改单位";
            if (frmUpdate.ShowDialog() == DialogResult.OK)
            {
                dt.Rows[dataGridView1.CurrentRow.Index]["DEPARTMENTNAME"] = frmUpdate.getDeptName();
                dt.Rows[dataGridView1.CurrentRow.Index]["DESCRIPTION"] = frmUpdate.getDeptDesc();
                dt.Rows[dataGridView1.CurrentRow.Index]["ZTID"] = frmUpdate.getZTID();
                dt.Rows[dataGridView1.CurrentRow.Index]["DEPARTMENTNO"] = frmUpdate.getDeptNum();
                dt.Rows[dataGridView1.CurrentRow.Index]["SFZT"] = frmUpdate.getISZT();
                dt.Rows[dataGridView1.CurrentRow.Index]["SJDWID"] = frmUpdate.getSuperUnit();
                dt.Rows[dataGridView1.CurrentRow.Index]["DWSX"] = frmUpdate.getUnitProp();
                dt.Rows[dataGridView1.CurrentRow.Index]["BMLXID"] = frmUpdate.getDeptType();
                dt.Rows[dataGridView1.CurrentRow.Index]["KHLXID"] = frmUpdate.getClientType();
                dt.Rows[dataGridView1.CurrentRow.Index]["GYSLXID"] = frmUpdate.getSupType();
                dt.Rows[dataGridView1.CurrentRow.Index]["CBSLXID"] = frmUpdate.getPressType();
                dt.Rows[dataGridView1.CurrentRow.Index]["YSCLXID"] = frmUpdate.getFacType();
                dt.Rows[dataGridView1.CurrentRow.Index]["YSBMLXID"] = frmUpdate.getTransType();
                dt.Rows[dataGridView1.CurrentRow.Index]["KFLXID"] = frmUpdate.getWareType();
                dt.Rows[dataGridView1.CurrentRow.Index]["KHDNO"] = frmUpdate.getWareType();
                dt.Rows[dataGridView1.CurrentRow.Index]["YTHNO"] = frmUpdate.getWareType();
                dt.Rows[dataGridView1.CurrentRow.Index]["JCJCNO"] = frmUpdate.getWareType();

                foreach (DataRow theRow in dt.Rows)
                {
                    theRow["ZTID"] = FrmLogin.getDictName2ID[theRow["ZTID"].ToString()];
                }

                Adapter.Update(ds, "SYS_DEPARTMENT");

                this.FrmDeptMt_Load(sender, e);
            }
        }

        private void btnQuery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDeptQuery frmQuery = new FrmDeptQuery();
            if (frmQuery.ShowDialog() == DialogResult.OK)
            {
                dt.DefaultView.RowFilter = "DEPARTMENTNAME like '%" + frmQuery.getDeptName() + "%'";
                bindingSource1.DataSource = dt.DefaultView;
            }
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.FrmDeptMt_Load(sender, e);
        }

        private void btnQuit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
