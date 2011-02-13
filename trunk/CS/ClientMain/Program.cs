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


            Application.Run(new rolemanger());
// 暂时注释掉
//            FrmLogin fLogin = new FrmLogin();
 //           if (fLogin.ShowDialog() == DialogResult.OK)
 //           {
  //              Application.Run(new FrmClientMain(fLogin.getAccount(), fLogin.getUser(), fLogin.getDepartment()));
  //       }
            //暂时注释掉 
        }
    }
}
