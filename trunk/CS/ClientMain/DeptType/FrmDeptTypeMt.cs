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
    public partial class FrmDeptTypeMt : DevExpress.XtraEditors.XtraForm
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

        Dictionary<string, string> m_dtStatus = new Dictionary<string, string>();

        public FrmDeptTypeMt(bool fgAdd, bool fgDel, bool fgUpdate, bool fgQuery)
        {
            InitializeComponent();
            
            m_fgAdd = fgAdd;
            m_fgDel = fgDel;
            m_fgQuery = fgQuery;
            m_fgUpdate = fgUpdate;

            m_dtStatus.Add("0", "录入");
            m_dtStatus.Add("1", "启用");
            m_dtStatus.Add("2", "停用");
            m_dtStatus.Add("录入", "0");
            m_dtStatus.Add("启用", "1");
            m_dtStatus.Add("停用", "2");
            m_dtStatus.Add("", "");
        }

        private void FrmDeptTypeMt_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingSource1;

            string strCon = "Data Source=XINHUA;User Id=xxb;Password=pass;Integrated Security=no;";
            Con = new OracleConnection(strCon);

            string strSQL = "select DEPARTTYPEID, DEPARTTYPENO, DEPARTTYPENAME, ZT from BASE_DEPARTTYPE";
            Adapter = new OracleDataAdapter(strSQL, Con);
            cb = new OracleCommandBuilder(Adapter);

            ds = new DataSet();
            Adapter.Fill(ds, "BASE_DEPARTTYPE");

            dt = ds.Tables["BASE_DEPARTTYPE"];

            foreach (DataRow theRow in dt.Rows)
            {
                theRow["ZT"] = m_dtStatus[theRow["ZT"].ToString()];
            }

            bindingSource1.DataSource = ds;
            bindingSource1.DataMember = "BASE_DEPARTTYPE";
            dataGridView1.Columns["DEPARTTYPEID"].Visible = false;
            dataGridView1.Columns["DEPARTTYPEID"].HeaderText = "部门类型ID";
            dataGridView1.Columns["DEPARTTYPENO"].HeaderText = "部门类型编号";
            dataGridView1.Columns["DEPARTTYPENAME"].HeaderText = "部门类型名称";
            dataGridView1.Columns["ZT"].HeaderText = "状态";

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            if (m_fgAdd)
            {
                barbtnAdd.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else
            {
                barbtnAdd.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }

            if (m_fgDel)
            {
                barbtDel.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else
            {
                barbtDel.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }

            if (m_fgUpdate)
            {
                barbtnUpdate.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else
            {
                barbtnUpdate.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }

            //if (m_fgQuery)
            //{
            //    barbtnQuery.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            //}
            //else
            //{
            //    barbtnQuery.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            //}

        }

        private void barbtnQuit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            const string message = "确定退出吗?";
            const string caption = "退出?";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void barbtnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strDeptName = dataGridView1.CurrentRow.Cells["DEPARTTYPENAME"].Value.ToString();
            string strDeptNo = dataGridView1.CurrentRow.Cells["DEPARTTYPENO"].Value.ToString();
            string strZT = dataGridView1.CurrentRow.Cells["ZT"].Value.ToString();

            FrmDeptTypeMtChild frmUpdate = new FrmDeptTypeMtChild(strDeptName, strDeptNo, strZT);
            frmUpdate.Text = "修改部门类型";
            frmUpdate.lbName.Text = "部门类型";
            
            if (frmUpdate.ShowDialog() == DialogResult.OK)
            {
                dt.Rows[dataGridView1.CurrentRow.Index]["DEPARTTYPENAME"] = frmUpdate.getName();
                dt.Rows[dataGridView1.CurrentRow.Index]["DEPARTTYPENO"] = frmUpdate.getNum();
                dt.Rows[dataGridView1.CurrentRow.Index]["ZT"] = frmUpdate.getStatus();
                
                foreach (DataRow theRow in dt.Rows)
                {
                    theRow["ZT"] = m_dtStatus[theRow["ZT"].ToString()];
                }

                Adapter.Update(ds, "BASE_DEPARTTYPE");

                this.FrmDeptTypeMt_Load(sender, e);
            }
        }

        private void barbtDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
                    theRow["ZT"] = m_dtStatus[theRow["ZT"].ToString()];
                }

                dt.Rows[dataGridView1.CurrentRow.Index].Delete();

                Adapter.Update(ds, "BASE_DEPARTTYPE");

                this.FrmDeptTypeMt_Load(sender, e);
            }
        }

        private void barbtnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDeptTypeMtChild frmAdd = new FrmDeptTypeMtChild();
            frmAdd.Text = "增加部门类型";
            frmAdd.lbName.Text = "部门类型";
            
            if (frmAdd.ShowDialog() == DialogResult.OK)
            {
                string strIns = @"INSERT INTO BASE_DEPARTTYPE (DEPARTTYPEID, DEPARTTYPENAME, DEPARTTYPENO, ZT) VALUES (BASE_DEPARTMENTTYPE_SEQ.nextval, :DEPARTTYPENAME, :DEPARTTYPENO, :ZT)";

                cmd = new OracleCommand(strIns, Con);
                Adapter.InsertCommand = cmd;
                Adapter.InsertCommand.Parameters.Add(new OracleParameter("DEPARTTYPENAME", OracleType.VarChar, 80, "DEPARTTYPENAME"));
                Adapter.InsertCommand.Parameters.Add(new OracleParameter("DEPARTTYPENO", OracleType.VarChar, 10, "DEPARTTYPENO"));
                Adapter.InsertCommand.Parameters.Add(new OracleParameter("ZT", OracleType.VarChar, 2, "ZT")); 

                DataRow newRow = dt.NewRow();
                newRow["DEPARTTYPENAME"] = frmAdd.getName();
                newRow["DEPARTTYPENO"] = frmAdd.getNum();
                newRow["ZT"] = frmAdd.getStatus();
               
                dt.Rows.Add(newRow);

                foreach (DataRow theRow in dt.Rows)
                {
                    theRow["ZT"] = m_dtStatus[theRow["ZT"].ToString()];
                }

                Adapter.Update(ds, "BASE_DEPARTTYPE");

                this.FrmDeptTypeMt_Load(sender, e);
            }
        }

      
    }
}