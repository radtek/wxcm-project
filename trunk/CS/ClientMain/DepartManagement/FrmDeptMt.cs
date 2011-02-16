

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


        public FrmDeptMt()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmDeptMt_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingSource1;
            
            string strCon = "Data Source=XINHUA;User Id=xxb;Password=pass;Integrated Security=no;";
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

            this.dataGridView1.Columns["DEPARTMENTID"].HeaderText = "部门ID";
            this.dataGridView1.Columns["DEPARTMENTNAME"].HeaderText = "部门名称";
            this.dataGridView1.Columns["DESCRIPTION"].HeaderText = "部门描述";
            this.dataGridView1.Columns["ZTID"].HeaderText = "账套ID";
            this.dataGridView1.Columns["DEPARTMENTNO"].HeaderText = "部门编号";
            this.dataGridView1.Columns["SFZT"].HeaderText = "是否账套";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDeptMtChild frmAdd = new FrmDeptMtChild();
            frmAdd.Text = "增加部门";
            
            if (frmAdd.ShowDialog() == DialogResult.OK)
            {
                string strIns = @"INSERT INTO SYS_DEPARTMENT (DEPARTMENTID, DEPARTMENTNAME, DESCRIPTION, ZTID, DEPARTMENTNO, SFZT) VALUES (seq_sys_user_userid.nextval, :DEPARTMENTNAME, :DESCRIPTION, :ZTID, :DEPARTMENTNO, :SFZT)";

                cmd = new OracleCommand(strIns, Con);
                Adapter.InsertCommand = cmd;
                Adapter.InsertCommand.Parameters.Add(new OracleParameter("DEPARTMENTNAME", OracleType.VarChar, 64, "DEPARTMENTNAME"));
                Adapter.InsertCommand.Parameters.Add(new OracleParameter("DESCRIPTION", OracleType.VarChar, 120, "DESCRIPTION"));
                Adapter.InsertCommand.Parameters.Add(new OracleParameter("DEPARTMENTNO", OracleType.VarChar, 16, "DEPARTMENTNO"));
                Adapter.InsertCommand.Parameters.Add(new OracleParameter("SFZT", OracleType.VarChar, 2, "SFZT"));
                Adapter.InsertCommand.Parameters.Add(new OracleParameter("ZTID", OracleType.VarChar, 16, "ZTID"));
                

                DataRow newRow = dt.NewRow();
                newRow["DEPARTMENTNAME"] = frmAdd.getDeptName();
                newRow["DESCRIPTION"] = frmAdd.getDeptDesc();
                newRow["ZTID"] = frmAdd.getZTID();
                newRow["DEPARTMENTNO"] = frmAdd.getDeptNum();
                newRow["SFZT"] = frmAdd.getISZT();

                dt.Rows.Add(newRow);

                foreach (DataRow theRow in dt.Rows)
                {
                    theRow["ZTID"] = FrmLogin.getDictName2ID[theRow["ZTID"].ToString()];
                }

                Adapter.Update(ds, "SYS_DEPARTMENT");

                this.FrmDeptMt_Load(sender, e);
            }
            
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            string strDeptName = dataGridView1.CurrentRow.Cells["DEPARTMENTNAME"].Value.ToString();
            string strDeptDesc = dataGridView1.CurrentRow.Cells["DESCRIPTION"].Value.ToString();
            string strZTID = dataGridView1.CurrentRow.Cells["ZTID"].Value.ToString();
            string strDeptNum = dataGridView1.CurrentRow.Cells["DEPARTMENTNO"].Value.ToString();
            string strSFZT = dataGridView1.CurrentRow.Cells["SFZT"].Value.ToString();

            FrmDeptMtChild frmUpdate = new FrmDeptMtChild(strDeptName, strDeptDesc, strZTID, strDeptNum, strSFZT);
            frmUpdate.Text = "修改部门";
            if (frmUpdate.ShowDialog() == DialogResult.OK)
            {
                dt.Rows[dataGridView1.CurrentRow.Index]["DEPARTMENTNAME"] = frmUpdate.getDeptName();
                dt.Rows[dataGridView1.CurrentRow.Index]["DESCRIPTION"] = frmUpdate.getDeptDesc();
                dt.Rows[dataGridView1.CurrentRow.Index]["ZTID"] = frmUpdate.getZTID();
                dt.Rows[dataGridView1.CurrentRow.Index]["DEPARTMENTNO"] = frmUpdate.getDeptNum();
                dt.Rows[dataGridView1.CurrentRow.Index]["SFZT"] = frmUpdate.getISZT();

                foreach (DataRow theRow in dt.Rows)
                {
                    theRow["ZTID"] = FrmLogin.getDictName2ID[theRow["ZTID"].ToString()];
                }

                Adapter.Update(ds, "SYS_DEPARTMENT");
         
                this.FrmDeptMt_Load(sender, e);
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            const string message = "确定删除吗?";       
            const string caption = "删除?";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
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

        private void button4_Click(object sender, EventArgs e)
        {
            FrmDeptQuery frmQuery = new FrmDeptQuery();
            if (frmQuery.ShowDialog() == DialogResult.OK)
            {
                dt.DefaultView.RowFilter = "DEPARTMENTNAME like '%" + frmQuery.getDeptName() + "%'";
                bindingSource1.DataSource = dt.DefaultView;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.FrmDeptMt_Load(sender, e);
        }
    }
}
