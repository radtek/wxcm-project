using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace ClientMain
{
    public partial class FrmStaffMt : Form
    {
        OracleConnection Con;
        OracleDataAdapter Adapter;
        DataSet ds;        
        DataTable dt;
        OracleCommandBuilder cb;
        OracleCommand cmd;

        bool m_fgAdd;
        bool m_fgDel;
        bool m_fgUpdate;
        bool m_fgQuery;

        Dictionary<string, string> m_dictGender = new Dictionary<string, string>();        

        public FrmStaffMt(bool fgAdd, bool fgDel, bool fgUpdate, bool fgQuery)
        {
            InitializeComponent();

            m_dictGender.Add("0", "女");
            m_dictGender.Add("1", "男");
            m_dictGender.Add("", "");
            m_dictGender.Add("女", "0");
            m_dictGender.Add("男", "1");

            m_fgAdd = fgAdd;
            m_fgDel = fgDel;
            m_fgQuery = fgQuery;
            m_fgUpdate = fgUpdate;
         
        }

        private void FrmStaffMt_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingSource1;
            
            string strCon = "Data Source=XINHUA;User Id=xxb;Password=pass;Integrated Security=no;";
            Con = new OracleConnection(strCon);

            string strSQLEmp = "select EMPLOYEEID, SJDWID, NAME, EMPLOYEENO, FASTCODE, SEX, BIRTHDAY, EMAIL, TXDZ, TELEPHONE, MOBILETELEPHONE from SYS_EMPLOYEES";
            Adapter = new OracleDataAdapter(strSQLEmp, Con);

            ds = new DataSet();
            Adapter.Fill(ds, "SYS_EMPLOYEES");           
            
            cb = new OracleCommandBuilder(Adapter);
            
            
            dt = ds.Tables["SYS_EMPLOYEES"];
            foreach (DataRow theRow in dt.Rows)
            {
                theRow["SEX"] = m_dictGender[theRow["SEX"].ToString()];
            }
            
            bindingSource1.DataSource = ds;
            bindingSource1.DataMember = "SYS_EMPLOYEES";

            this.dataGridView1.Columns["EMPLOYEEID"].Visible = false;            
            this.dataGridView1.Columns["EMPLOYEEID"].HeaderText = "员工ID";
            this.dataGridView1.Columns["SJDWID"].Visible = false;
            this.dataGridView1.Columns["SJDWID"].HeaderText = "上级单位ID";
            this.dataGridView1.Columns["NAME"].HeaderText = "员工姓名";
            this.dataGridView1.Columns["EMPLOYEENO"].HeaderText = "员工编号";
            this.dataGridView1.Columns["FASTCODE"].Visible = false;
            this.dataGridView1.Columns["FASTCODE"].HeaderText = "助记码";
            this.dataGridView1.Columns["SEX"].HeaderText = "性别";
            this.dataGridView1.Columns["BIRTHDAY"].HeaderText = "出生年月";
            this.dataGridView1.Columns["EMAIL"].HeaderText = "电子邮箱";
            this.dataGridView1.Columns["TXDZ"].HeaderText = "通讯地址";
            this.dataGridView1.Columns["TELEPHONE"].HeaderText = "电话";
            this.dataGridView1.Columns["MOBILETELEPHONE"].HeaderText = "移动电话";

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
            FrmStaffMtChild frmAdd = new FrmStaffMtChild();
            frmAdd.Text = "增加员工";

            if (frmAdd.ShowDialog() == DialogResult.OK)
            {
                string strIns = "INSERT INTO SYS_EMPLOYEES (EMPLOYEEID, NAME, EMPLOYEENO, FASTCODE, SEX, BIRTHDAY, EMAIL, TXDZ, TELEPHONE, "
                              + "MOBILETELEPHONE, SJDWID) VALUES (seq_sys_employees_employeeid.nextval, :NAME, :EMPLOYEENO, :FASTCODE, :SEX, "
                              + ":BIRTHDAY, :EMAIL, :TXDZ, :TELEPHONE, :MOBILETELEPHONE, :SJDWID)";

                cmd = new OracleCommand(strIns, Con);
                Adapter.InsertCommand = cmd;
                Adapter.InsertCommand.Parameters.Add(new OracleParameter("NAME", OracleType.VarChar, 16, "NAME"));
                Adapter.InsertCommand.Parameters.Add(new OracleParameter("EMPLOYEENO", OracleType.VarChar, 10, "EMPLOYEENO"));
                Adapter.InsertCommand.Parameters.Add(new OracleParameter("FASTCODE", OracleType.VarChar, 10, "FASTCODE"));
                Adapter.InsertCommand.Parameters.Add(new OracleParameter("SEX", OracleType.VarChar, 2, "SEX"));
                Adapter.InsertCommand.Parameters.Add(new OracleParameter("BIRTHDAY", OracleType.DateTime, 11, "BIRTHDAY"));
                Adapter.InsertCommand.Parameters.Add(new OracleParameter("EMAIL", OracleType.VarChar, 50, "EMAIL"));
                Adapter.InsertCommand.Parameters.Add(new OracleParameter("TXDZ", OracleType.VarChar, 100, "TXDZ"));
                Adapter.InsertCommand.Parameters.Add(new OracleParameter("TELEPHONE", OracleType.VarChar, 15, "TELEPHONE"));
                Adapter.InsertCommand.Parameters.Add(new OracleParameter("MOBILETELEPHONE", OracleType.VarChar, 15, "MOBILETELEPHONE"));
                Adapter.InsertCommand.Parameters.Add(new OracleParameter("SJDWID", OracleType.VarChar, 16, "SJDWID"));

                DataRow newRow = dt.NewRow();

                newRow["NAME"] = frmAdd.getName();
                newRow["EMPLOYEENO"] = frmAdd.getNum();
                newRow["FASTCODE"] = frmAdd.getFastCode();
                newRow["SEX"] = frmAdd.getGender();
                newRow["BIRTHDAY"] = frmAdd.getBirth();
                newRow["EMAIL"] = frmAdd.getEmail();
                newRow["TXDZ"] = frmAdd.getAddress();
                newRow["TELEPHONE"] = frmAdd.getTel();
                newRow["MOBILETELEPHONE"] = frmAdd.getMobile();
                newRow["SJDWID"] = frmAdd.getSuperUnit();
                dt.Rows.Add(newRow);

                foreach (DataRow theRow in dt.Rows)
                {
                    theRow["SEX"] = m_dictGender[theRow["SEX"].ToString()];
                }

                Adapter.Update(ds, "SYS_EMPLOYEES");

                this.FrmStaffMt_Load(sender, e);
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
                    theRow["SEX"] = m_dictGender[theRow["SEX"].ToString()];
                }

                dt.Rows[dataGridView1.CurrentRow.Index].Delete();

                Adapter.Update(ds, "SYS_EMPLOYEES");

                this.FrmStaffMt_Load(sender, e);
            }
        }

        private void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strStaffName = dataGridView1.CurrentRow.Cells["NAME"].Value.ToString();
            string strStaffNum = dataGridView1.CurrentRow.Cells["EMPLOYEENO"].Value.ToString();
            string strFastCode = dataGridView1.CurrentRow.Cells["FASTCODE"].Value.ToString();
            string strGender = dataGridView1.CurrentRow.Cells["SEX"].Value.ToString();
            string strBirth = dataGridView1.CurrentRow.Cells["BIRTHDAY"].Value.ToString();
            string strEmail = dataGridView1.CurrentRow.Cells["EMAIL"].Value.ToString();
            string strAddress = dataGridView1.CurrentRow.Cells["TXDZ"].Value.ToString();
            string strTel = dataGridView1.CurrentRow.Cells["TELEPHONE"].Value.ToString();
            string strMobile = dataGridView1.CurrentRow.Cells["MOBILETELEPHONE"].Value.ToString();
            string strSuperUnit = dataGridView1.CurrentRow.Cells["SJDWID"].Value.ToString();

            FrmStaffMtChild frmUpdate = new FrmStaffMtChild(strStaffNum, strStaffName, strFastCode, strGender, strBirth,
                                                            strEmail, strAddress, strTel, strMobile, strSuperUnit);
            frmUpdate.Text = "修改员工";
            if (frmUpdate.ShowDialog() == DialogResult.OK)
            {
                dt.Rows[dataGridView1.CurrentRow.Index]["NAME"] = frmUpdate.getName();
                dt.Rows[dataGridView1.CurrentRow.Index]["EMPLOYEENO"] = frmUpdate.getNum();
                dt.Rows[dataGridView1.CurrentRow.Index]["FASTCODE"] = frmUpdate.getFastCode();
                dt.Rows[dataGridView1.CurrentRow.Index]["SEX"] = frmUpdate.getGender();
                dt.Rows[dataGridView1.CurrentRow.Index]["BIRTHDAY"] = frmUpdate.getBirth();
                dt.Rows[dataGridView1.CurrentRow.Index]["EMAIL"] = frmUpdate.getEmail();
                dt.Rows[dataGridView1.CurrentRow.Index]["TXDZ"] = frmUpdate.getAddress();
                dt.Rows[dataGridView1.CurrentRow.Index]["TELEPHONE"] = frmUpdate.getTel();
                dt.Rows[dataGridView1.CurrentRow.Index]["MOBILETELEPHONE"] = frmUpdate.getMobile();
                dt.Rows[dataGridView1.CurrentRow.Index]["SJDWID"] = frmUpdate.getSuperUnit();

                foreach (DataRow theRow in dt.Rows)
                {
                    theRow["SEX"] = m_dictGender[theRow["SEX"].ToString()];
                }

                Adapter.Update(ds, "SYS_EMPLOYEES");

                this.FrmStaffMt_Load(sender, e);
            }
        }

        private void btnQuery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmStaffQuery frmQuery = new FrmStaffQuery();
            if (frmQuery.ShowDialog() == DialogResult.OK)
            {
                dt.DefaultView.RowFilter = "NAME like '%" + frmQuery.getName() + "%'";
                bindingSource1.DataSource = dt.DefaultView;
            }
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.FrmStaffMt_Load(sender, e);
        }

        private void btnQuit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

    }
}
