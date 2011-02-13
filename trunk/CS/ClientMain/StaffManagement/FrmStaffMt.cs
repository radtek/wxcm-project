﻿using System;
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
        OracleCommandBuilder cb;
        DataTable dt;
        OracleCommand cmd;

        Dictionary<string, string> m_dictIC = new Dictionary<string, string>();
        Dictionary<string, string> m_dictCI = new Dictionary<string, string>();

        public FrmStaffMt()
        {
            InitializeComponent();
            
            m_dictIC.Add("0", "女");
            m_dictIC.Add("1", "男");
            m_dictIC.Add("", "");

            m_dictCI.Add("女", "0");
            m_dictCI.Add("男", "1");
            m_dictCI.Add("", "");
        }

        private void FrmStaffMt_Load(object sender, EventArgs e)
        {
            string strCon = "Data Source=XINHUA;User Id=xxb;Password=pass;Integrated Security=no;";
            Con = new OracleConnection(strCon);

            string strSQL = "select * from SYS_EMPLOYEES";
            Adapter = new OracleDataAdapter(strSQL, Con);
            cb = new OracleCommandBuilder(Adapter);

            ds = new DataSet();
            Adapter.Fill(ds, "SYS_EMPLOYEES");

            dt = ds.Tables["SYS_EMPLOYEES"];
            foreach (DataRow theRow in dt.Rows)
            {
                theRow["SEX"] = m_dictIC[theRow["SEX"].ToString()];
            }
            dataGridView1.DataSource = bindingSource1;
            bindingSource1.DataSource = ds;
            bindingSource1.DataMember = "SYS_EMPLOYEES";

            dataGridView1.AutoGenerateColumns = true;
            

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmStaffMtChild frmAdd = new FrmStaffMtChild();
            frmAdd.Text = "增加员工";

            if (frmAdd.ShowDialog() == DialogResult.OK)
            {
                string strIns = @"INSERT INTO SYS_EMPLOYEES (EMPLOYEEID, NAME, EMPLOYEENO, FASTCODE, SEX, BIRTHDAY, EMAIL, TXDZ, TELEPHONE, MOBILETELEPHONE) VALUES (seq_sys_employees_employeeid.nextval, :NAME, :EMPLOYEENO, :FASTCODE, :SEX, :BIRTHDAY, :EMAIL, :TXDZ, :TELEPHONE, :MOBILETELEPHONE)";

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

                DataRow newRow = dt.NewRow();

                dt.Columns["EMPLOYEEID"].Unique = true;
                newRow["NAME"] = frmAdd.getName();
                newRow["EMPLOYEENO"] = frmAdd.getNum();
                newRow["FASTCODE"] = frmAdd.getFastCode();
                newRow["SEX"] = frmAdd.getGender();
                newRow["BIRTHDAY"] = frmAdd.getBirth();
                newRow["EMAIL"] = frmAdd.getEmail();
                newRow["TXDZ"] = frmAdd.getAddress();
                newRow["TELEPHONE"] = frmAdd.getTel();
                newRow["MOBILETELEPHONE"] = frmAdd.getMobile();
                dt.Rows.Add(newRow);

                foreach (DataRow theRow in dt.Rows)
                {
                    theRow["SEX"] = m_dictCI[theRow["SEX"].ToString()];
                }

                Adapter.Update(ds, "SYS_EMPLOYEES");

                this.FrmStaffMt_Load(sender, e);
            }
            
        }

        private void btnDel_Click(object sender, EventArgs e)
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
                    theRow["SEX"] = m_dictCI[theRow["SEX"].ToString()];
                }

                dt.Rows[dataGridView1.CurrentRow.Index].Delete();

                Adapter.Update(ds, "SYS_EMPLOYEES");

                this.FrmStaffMt_Load(sender, e);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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

            FrmStaffMtChild frmUpdate = new FrmStaffMtChild(strStaffNum, strStaffName, strFastCode, strGender, strBirth, 
                                                            strEmail, strAddress, strTel, strMobile);
            frmUpdate.Text = "修改员工";
            if (frmUpdate.ShowDialog() == DialogResult.OK)
            {
                dt.Columns["EMPLOYEEID"].Unique = true;
                dt.Rows[dataGridView1.CurrentRow.Index]["NAME"] = frmUpdate.getName();
                dt.Rows[dataGridView1.CurrentRow.Index]["EMPLOYEENO"] = frmUpdate.getNum();
                dt.Rows[dataGridView1.CurrentRow.Index]["FASTCODE"] = frmUpdate.getFastCode();
                dt.Rows[dataGridView1.CurrentRow.Index]["SEX"] = frmUpdate.getGender();
                dt.Rows[dataGridView1.CurrentRow.Index]["BIRTHDAY"] = frmUpdate.getBirth();
                dt.Rows[dataGridView1.CurrentRow.Index]["EMAIL"] = frmUpdate.getEmail();
                dt.Rows[dataGridView1.CurrentRow.Index]["TXDZ"] = frmUpdate.getAddress();
                dt.Rows[dataGridView1.CurrentRow.Index]["TELEPHONE"] = frmUpdate.getTel();
                dt.Rows[dataGridView1.CurrentRow.Index]["MOBILETELEPHONE"] = frmUpdate.getMobile();

                foreach (DataRow theRow in dt.Rows)
                {
                    theRow["SEX"] = m_dictCI[theRow["SEX"].ToString()];
                }

                Adapter.Update(ds, "SYS_EMPLOYEES");

                this.FrmStaffMt_Load(sender, e);
            }
            
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            FrmStaffQuery frmQuery = new FrmStaffQuery();
            if (frmQuery.ShowDialog() == DialogResult.OK)
            {
                dt.DefaultView.RowFilter = "NAME like '%" + frmQuery.getName() + "%'";
                dataGridView1.DataSource = dt.DefaultView;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.FrmStaffMt_Load(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
