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
    public partial class FrmStaffMtChild : DevExpress.XtraEditors.XtraForm
    {
        structStaff m_sStaff;

        public FrmStaffMtChild(structStaff sStaff)
        {  
            InitializeComponent();

            m_sStaff = sStaff;
        }

        private void vUpdateStaff(OracleCommand command, OracleTransaction transaction)
        {
            string strUpdate = "update BASE_OPERATOR set OPERATORNO = :OPERATORNO, OPERATORNAME = :OPERATORNAME, "
                             + "FASTCODE = :FASTCODE, SEX = :SEX, BIRTHDAY = :BIRTHDAY, EMAIL = :EMAIL, CONTACTADDRESS = :CONTACTADDRESS, "
                             + "TELEPHONE = :TELEPHONE, MOBILETELEPHONE = :MOBILETELEPHONE, DEPARTID = :DEPARTID "
                             + "where OPERATORID = '" + m_sStaff.strOPERATORID + "'";

            command.CommandText = strUpdate;
            command.Parameters.Add(new OracleParameter("OPERATORNAME", OracleType.VarChar)).Value = tbName.Text;
            command.Parameters.Add(new OracleParameter("OPERATORNO", OracleType.VarChar)).Value = tbStaffNum.Text;
            command.Parameters.Add(new OracleParameter("FASTCODE", OracleType.VarChar)).Value = tbFastCode.Text;
            command.Parameters.Add(new OracleParameter("SEX", OracleType.VarChar)).Value = cbGender.Text;
            command.Parameters.Add(new OracleParameter("BIRTHDAY", OracleType.DateTime)).Value = dateTimePicker1.Value.ToString();
            command.Parameters.Add(new OracleParameter("EMAIL", OracleType.VarChar)).Value = tbEmail.Text;
            command.Parameters.Add(new OracleParameter("CONTACTADDRESS", OracleType.VarChar)).Value = tbAddress.Text;
            command.Parameters.Add(new OracleParameter("TELEPHONE", OracleType.VarChar)).Value = tbTel.Text;
            command.Parameters.Add(new OracleParameter("MOBILETELEPHONE", OracleType.VarChar)).Value = tbMobile.Text;
            command.Parameters.Add(new OracleParameter("DEPARTID", OracleType.VarChar)).Value = sleDepart.EditValue ?? "";

            command.ExecuteNonQuery();
            transaction.Commit();
            MessageBox.Show("修改成功！");
        }

        private void vAddStaff(OracleCommand command, OracleTransaction transaction)
        {
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "BASE_OPERATOR_INSERT";
            
            command.Parameters.Add("ls_OPERATORNO", OracleType.VarChar).Value = tbStaffNum.Text;
            command.Parameters.Add("ls_OPERATORNAME", OracleType.VarChar).Value = tbName.Text;
            command.Parameters.Add("ls_FASTCODE", OracleType.VarChar).Value = tbFastCode.Text;
            command.Parameters.Add("ls_SEX", OracleType.VarChar).Value = cbGender.Text;
            command.Parameters.Add("ls_BIRTHDAY", OracleType.VarChar).Value = dateTimePicker1.Value.ToString();
            command.Parameters.Add("ls_EMAIL", OracleType.VarChar).Value = tbEmail.Text;
            command.Parameters.Add("ls_CONTACTADDRESS", OracleType.VarChar).Value = tbAddress.Text;
            command.Parameters.Add("ls_TELEPHONE", OracleType.VarChar).Value = tbTel.Text;
            command.Parameters.Add("ls_MOBILETELEPHONE", OracleType.VarChar).Value = tbMobile.Text;
            command.Parameters.Add("ls_DEPARTID", OracleType.VarChar).Value = sleDepart.EditValue ?? "";

            command.Parameters.Add("descerr", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
            command.Parameters.Add("Message", OracleType.VarChar, 255).Direction = ParameterDirection.Output;
            command.Parameters.Add("ls_OPTID", OracleType.VarChar, 255).Direction = ParameterDirection.Output;

            command.ExecuteNonQuery();

            transaction.Commit();
            MessageBox.Show(command.Parameters["Message"].Value.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || tbStaffNum.Text == "")
            {
                if (MessageBox.Show("员工姓名和编号不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Stop) == DialogResult.OK)
                {
                    tbStaffNum.Focus();
                }
            }
            else
            {
                using (OracleConnection connection = new OracleConnection(FrmLogin.strDataCent))
                {
                    connection.Open();
                    OracleCommand command = connection.CreateCommand();
                    OracleTransaction transaction = connection.BeginTransaction();
                    command.Connection = connection;
                    command.Transaction = transaction;
                    try
                    {
                        if (this.Text == "增加员工")
                        {
                            vAddStaff(command, transaction);
                            this.Close();
                        }
                        else if (this.Text == "修改员工")
                        {
                            vUpdateStaff(command, transaction);
                            this.Close();
                        }
                        
                    }
                    catch (Exception exception)
                    {
                        transaction.Rollback();
                        MessageBox.Show(exception.ToString());
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveContinue_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || tbStaffNum.Text == "")
            {
                if (MessageBox.Show("员工姓名和编号不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Stop) == DialogResult.OK)
                {
                    tbStaffNum.Focus();
                }
            }
            else
            {
                using (OracleConnection connection = new OracleConnection(FrmLogin.strDataCent))
                {
                    connection.Open();
                    OracleCommand command = connection.CreateCommand();
                    OracleTransaction transaction = connection.BeginTransaction();
                    command.Connection = connection;
                    command.Transaction = transaction;
                    try
                    {
                        if (this.Text == "增加员工")
                        {
                            vAddStaff(command, transaction);
                            btnClear_Click(sender, e);
                        }
                        else if (this.Text == "修改员工")
                        {
                            vUpdateStaff(command, transaction);
                            btnClear_Click(sender, e);
                        }
                    }
                    catch (Exception exception)
                    {
                        transaction.Rollback();
                        MessageBox.Show(exception.ToString());
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbAddress.Text = "";
            tbEmail.Text = "";
            tbFastCode.Text = "";
            tbMobile.Text = "";
            tbName.Text = "";
            tbStaffNum.Text = "";
            tbTel.Text = "";
            sleDepart.Text = "";
            cbGender.SelectedIndex = 0;
        }

        private void FrmStaffMtChild_Load(object sender, EventArgs e)
        {
            OracleConnection Con = new OracleConnection(FrmLogin.strDataCent);
            string sqlSuperUnit = "select DWID, DWMC, DWBH, ZJM from JT_J_DWXX";
            OracleDataAdapter AdaSuperUnit = new OracleDataAdapter(sqlSuperUnit, Con);
            DataSet ds = new DataSet();
            AdaSuperUnit.Fill(ds, "JT_J_DWXX");
            jTJDWXXBindingSource.DataSource = ds;
            jTJDWXXBindingSource.DataMember = "JT_J_DWXX";

            cbGender.Items.Add("女");
            cbGender.Items.Add("男");
            if (this.Text == "增加员工")
            {
                cbGender.SelectedIndex = 0;
            }
            else if (this.Text == "修改员工")
            {
                cbGender.SelectedItem = m_sStaff.strSEX;
                btnSaveContinue.Visible = false;
            }


            tbAddress.Text = m_sStaff.strCONTACTADDRESS;
            tbEmail.Text = m_sStaff.strEMAIL;
            tbFastCode.Text = m_sStaff.strFASTCODE;
            tbMobile.Text = m_sStaff.strMOBILETELEPHONE;
            tbName.Text = m_sStaff.strOPERATORNAME;
            tbStaffNum.Text = m_sStaff.strOPERATORNO;
            tbTel.Text = m_sStaff.strTELEPHONE;
            dateTimePicker1.Text = m_sStaff.strBIRTHDAY;

            if (sleDepart.Handle != IntPtr.Zero)
            {
                sleDepart.EditValue = m_sStaff.strDEPARTID;
            }            
        }
    }
}
