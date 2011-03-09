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
    public partial class FrmClientTypeMt : DevExpress.XtraEditors.XtraForm
    {
        OracleConnection Con;
        OracleDataAdapter Adapter;
        DataSet ds;
        OracleCommandBuilder cb;
        DataTable dt;
        OracleCommand cmd;

        Dictionary<string, string> m_dtStatus = new Dictionary<string, string>();

        public FrmClientTypeMt()
        {
            InitializeComponent();

            m_dtStatus.Add("0", "录入");
            m_dtStatus.Add("1", "启用");
            m_dtStatus.Add("2", "停用");
            m_dtStatus.Add("录入", "0");
            m_dtStatus.Add("启用", "1");
            m_dtStatus.Add("停用", "2");
            m_dtStatus.Add("", "");
        }

        private void FrmClientTypeMt_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingSource1;

            string strCon = "Data Source=XINHUA;User Id=xxb;Password=pass;Integrated Security=no;";
            Con = new OracleConnection(strCon);

            string strSQL = "select KHLXID, KHLXBH, KHLXMC, ZT from JT_J_KHLX";
            Adapter = new OracleDataAdapter(strSQL, Con);
            cb = new OracleCommandBuilder(Adapter);

            ds = new DataSet();
            Adapter.Fill(ds, "JT_J_KHLX");

            dt = ds.Tables["JT_J_KHLX"];

            foreach (DataRow theRow in dt.Rows)
            {
                theRow["ZT"] = m_dtStatus[theRow["ZT"].ToString()];
            }

            bindingSource1.DataSource = ds;
            bindingSource1.DataMember = "JT_J_KHLX";
            dataGridView1.Columns["KHLXID"].Visible = false;
            dataGridView1.Columns["KHLXID"].HeaderText = "客户类型ID";
            dataGridView1.Columns["KHLXBH"].HeaderText = "类型编号";
            dataGridView1.Columns["KHLXMC"].HeaderText = "客户类型";
            dataGridView1.Columns["ZT"].HeaderText = "状态";

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

        }

        private void barbtnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDeptTypeMtChild frmAdd = new FrmDeptTypeMtChild();
            frmAdd.Text = "增加客户类型";
            frmAdd.lbName.Text = "客户类型";

            if (frmAdd.ShowDialog() == DialogResult.OK)
            {
                string strIns = @"INSERT INTO JT_J_KHLX (KHLXID, KHLXBH, KHLXMC, ZT) VALUES (JT_J_KHLX_SEQ.nextval, :KHLXBH, :KHLXMC, :ZT)";

                cmd = new OracleCommand(strIns, Con);
                Adapter.InsertCommand = cmd;
                Adapter.InsertCommand.Parameters.Add(new OracleParameter("KHLXMC", OracleType.VarChar, 80, "KHLXMC"));
                Adapter.InsertCommand.Parameters.Add(new OracleParameter("KHLXBH", OracleType.VarChar, 10, "KHLXBH"));
                Adapter.InsertCommand.Parameters.Add(new OracleParameter("ZT", OracleType.VarChar, 4, "ZT"));

                DataRow newRow = dt.NewRow();
                newRow["KHLXMC"] = frmAdd.getName();
                newRow["KHLXBH"] = frmAdd.getNum();
                newRow["ZT"] = frmAdd.getStatus();

                dt.Rows.Add(newRow);

                foreach (DataRow theRow in dt.Rows)
                {
                    theRow["ZT"] = m_dtStatus[theRow["ZT"].ToString()];
                }

                Adapter.Update(ds, "JT_J_KHLX");

                this.FrmClientTypeMt_Load(sender, e);
            }
        }

        private void barbtnDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

                Adapter.Update(ds, "JT_J_KHLX");

                this.FrmClientTypeMt_Load(sender, e);
            }
        }

        private void barbtnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strName = dataGridView1.CurrentRow.Cells["KHLXMC"].Value.ToString();
            string strNum = dataGridView1.CurrentRow.Cells["KHLXBH"].Value.ToString();
            string strZT = dataGridView1.CurrentRow.Cells["ZT"].Value.ToString();

            FrmDeptTypeMtChild frmUpdate = new FrmDeptTypeMtChild(strName, strNum, strZT);
            frmUpdate.Text = "修改客户类型";
            frmUpdate.lbName.Text = "客户类型";
            
            if (frmUpdate.ShowDialog() == DialogResult.OK)
            {
                dt.Rows[dataGridView1.CurrentRow.Index]["KHLXMC"] = frmUpdate.getName();
                dt.Rows[dataGridView1.CurrentRow.Index]["KHLXBH"] = frmUpdate.getNum();
                dt.Rows[dataGridView1.CurrentRow.Index]["ZT"] = frmUpdate.getStatus();

                foreach (DataRow theRow in dt.Rows)
                {
                    theRow["ZT"] = m_dtStatus[theRow["ZT"].ToString()];
                }

                Adapter.Update(ds, "JT_J_KHLX");

                FrmClientTypeMt_Load(sender, e);
                
            }
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
    }
}