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
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            FrmLogin fLogin = new FrmLogin();
            if (fLogin.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new FrmClientMain(FrmLogin.getAccount, FrmLogin.getUser, FrmLogin.getDepartment));
            }
            
        }
    }
}
