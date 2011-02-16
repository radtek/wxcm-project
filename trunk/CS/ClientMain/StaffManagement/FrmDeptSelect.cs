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
    public partial class FrmDeptSelect : Form
    {
        string m_strEmpID;

        OracleConnection Con;
        OracleDataAdapter Adapter;
        OracleDataAdapter AdaDeptEmp;

        DataSet ds;
       
        OracleCommandBuilder cb;
        OracleCommand cmd;

        public FrmDeptSelect()
        {
            InitializeComponent();
        }

        public FrmDeptSelect(string strEmpID)
        {
            InitializeComponent();
            m_strEmpID = strEmpID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ds.Tables["DEPARTMENT"].DefaultView.RowFilter = "DEPARTMENTNAME like '%" + textBox1.Text + "%'";
            bindingSource1.DataSource = ds.Tables["DEPARTMENT"].DefaultView;                
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            string strIns = @"INSERT INTO SYS_EMPEE_DEPARTMENT (ID, EMPLOYEEID, DEPARTMENTID) VALUES (seq_sys_empee_department_id.nextval, :EMPLOYEEID, :DEPARTMENTID)";
            cmd = new OracleCommand(strIns, Con);

            AdaDeptEmp.InsertCommand = cmd;
            AdaDeptEmp.InsertCommand.Parameters.Add(new OracleParameter("EMPLOYEEID", OracleType.VarChar, 16, "EMPLOYEEID"));
            AdaDeptEmp.InsertCommand.Parameters.Add(new OracleParameter("DEPARTMENTID", OracleType.VarChar, 16, "DEPARTMENTID"));

            foreach(DataGridViewRow dr in this.dataGridView1.Rows)
            {
                DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)dr.Cells["CheckBoxes"];
                if (Convert.ToBoolean(checkCell.EditedFormattedValue))                
                {
                    DataRow newRow = ds.Tables["SYS_EMPEE_DEPARTMENT"].NewRow();
                    newRow["EMPLOYEEID"] = m_strEmpID;
                    newRow["DEPARTMENTID"] = dr.Cells["DEPARTMENTID"].Value.ToString();
                    ds.Tables["SYS_EMPEE_DEPARTMENT"].Rows.Add(newRow);    
                }             
            }
            AdaDeptEmp.Update(ds, "SYS_EMPEE_DEPARTMENT");

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmDeptSelect_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingSource1;

            string strCon = "Data Source=XINHUA;User Id=xxb;Password=pass;Integrated Security=no;";
            Con = new OracleConnection(strCon);

            string strSqlDept = "select a.DEPARTMENTID, a.DEPARTMENTNAME, a.DEPARTMENTNO, b.ZTMC from SYS_DEPARTMENT a  left join sys_ztbm b on a.ztid = b.ztid where a.DEPARTMENTID not in(select distinct departmentid from sys_empee_department where employeeid='" + m_strEmpID +"')";
            Adapter = new OracleDataAdapter(strSqlDept, Con);

            string strSqlEmpDept = "select * From SYS_EMPEE_DEPARTMENT";
            AdaDeptEmp = new OracleDataAdapter(strSqlEmpDept, Con);

            ds = new DataSet();
            Adapter.Fill(ds, "DEPARTMENT");
            AdaDeptEmp.Fill(ds, "SYS_EMPEE_DEPARTMENT");

            cb = new OracleCommandBuilder(AdaDeptEmp);

            bindingSource1.DataSource = ds;
            bindingSource1.DataMember = "DEPARTMENT";

            this.dataGridView1.Columns["DEPARTMENTID"].HeaderText = "部门ID";
            this.dataGridView1.Columns["DEPARTMENTNAME"].HeaderText = "部门名称";
            this.dataGridView1.Columns["DEPARTMENTNO"].HeaderText = "部门编号";
            this.dataGridView1.Columns["ZTMC"].HeaderText = "账套名称";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex != -1)//点击的是第1列时才执行
            {
                DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)this.dataGridView1.Rows[e.RowIndex].Cells[0];
                checkCell.Value = (Convert.ToBoolean(checkCell.EditedFormattedValue)) ? false : true;
            }
        }
    }
}
