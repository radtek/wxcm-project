using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClientMain
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            DevExpress.Utils.AppearanceObject.DefaultFont = new System.Drawing.Font("宋体", 9);  
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            FrmLogin fLogin = new FrmLogin();
            if (fLogin.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new FrmClientMain(FrmLogin.getAccount, FrmLogin.getUser, FrmLogin.getDeptName, FrmLogin.getDeptID, FrmLogin.getZTID));
            }
            
        }
    }
}
