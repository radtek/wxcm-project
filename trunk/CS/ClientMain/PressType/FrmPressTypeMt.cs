﻿using System;
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
    public partial class FrmPressTypeMt : DevExpress.XtraEditors.XtraForm
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

        public FrmPressTypeMt(bool fgAdd, bool fgDel, bool fgUpdate, bool fgQuery)
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

        private void FrmPressTypeMt_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingSource1;

            string strCon = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.8.222)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XINHUA)));User Id=xxb;Password=pass;Integrated Security=no;";
            Con = new OracleConnection(strCon);

            string strSQL = "select CBSLXID, LXBH, CBSLX, ZT from JT_J_CBSLX";
            Adapter = new OracleDataAdapter(strSQL, Con);
            cb = new OracleCommandBuilder(Adapter);

            ds = new DataSet();
            Adapter.Fill(ds, "JT_J_CBSLX");

            dt = ds.Tables["JT_J_CBSLX"];

            foreach (DataRow theRow in dt.Rows)
            {
                theRow["ZT"] = m_dtStatus[theRow["ZT"].ToString()];
            }

            bindingSource1.DataSource = ds;
            bindingSource1.DataMember = "JT_J_CBSLX";
            dataGridView1.Columns["CBSLXID"].Visible = false;
            dataGridView1.Columns["CBSLXID"].HeaderText = "出版社类型ID";
            dataGridView1.Columns["LXBH"].HeaderText = "类型编号";
            dataGridView1.Columns["CBSLX"].HeaderText = "出版社类型";
            dataGridView1.Columns["ZT"].HeaderText = "状态";

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
            //    barbtnQuery.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            //}
            //else
            //{
            //    barbtnQuery.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            //}
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDeptTypeMtChild frmAdd = new FrmDeptTypeMtChild();
            frmAdd.Text = "增加出版社类型";
            frmAdd.lbName.Text = "出版社类型";

            if (frmAdd.ShowDialog() == DialogResult.OK)
            {
                string strIns = @"INSERT INTO JT_J_CBSLX (CBSLXID, LXBH, CBSLX, ZT) VALUES (JT_J_CBSLX_SEQ.nextval, :LXBH, :CBSLX, :ZT)";

                cmd = new OracleCommand(strIns, Con);
                Adapter.InsertCommand = cmd;
                Adapter.InsertCommand.Parameters.Add(new OracleParameter("CBSLX", OracleType.VarChar, 80, "CBSLX"));
                Adapter.InsertCommand.Parameters.Add(new OracleParameter("LXBH", OracleType.VarChar, 2, "LXBH"));
                Adapter.InsertCommand.Parameters.Add(new OracleParameter("ZT", OracleType.VarChar, 4, "ZT"));

                DataRow newRow = dt.NewRow();
                newRow["CBSLX"] = frmAdd.getName();
                newRow["LXBH"] = frmAdd.getNum();
                newRow["ZT"] = frmAdd.getStatus();

                dt.Rows.Add(newRow);

                foreach (DataRow theRow in dt.Rows)
                {
                    theRow["ZT"] = m_dtStatus[theRow["ZT"].ToString()];
                }

                Adapter.Update(ds, "JT_J_CBSLX");

                this.FrmPressTypeMt_Load(sender, e);
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
                    theRow["ZT"] = m_dtStatus[theRow["ZT"].ToString()];
                }

                dt.Rows[dataGridView1.CurrentRow.Index].Delete();

                Adapter.Update(ds, "JT_J_CBSLX");

                this.FrmPressTypeMt_Load(sender, e);
            }
        }

        private void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strName = dataGridView1.CurrentRow.Cells["CBSLX"].Value.ToString();
            string strNum = dataGridView1.CurrentRow.Cells["LXBH"].Value.ToString();
            string strZT = dataGridView1.CurrentRow.Cells["ZT"].Value.ToString();

            FrmDeptTypeMtChild frmUpdate = new FrmDeptTypeMtChild(strName, strNum, strZT);
            frmUpdate.Text = "修改出版社类型";
            frmUpdate.lbName.Text = "出版社类型";

            if (frmUpdate.ShowDialog() == DialogResult.OK)
            {
                dt.Rows[dataGridView1.CurrentRow.Index]["CBSLX"] = frmUpdate.getName();
                dt.Rows[dataGridView1.CurrentRow.Index]["LXBH"] = frmUpdate.getNum();
                dt.Rows[dataGridView1.CurrentRow.Index]["ZT"] = frmUpdate.getStatus();

                foreach (DataRow theRow in dt.Rows)
                {
                    theRow["ZT"] = m_dtStatus[theRow["ZT"].ToString()];
                }

                Adapter.Update(ds, "JT_J_CBSLX");

                FrmPressTypeMt_Load(sender, e);

            }
        }

        private void btnQuit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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