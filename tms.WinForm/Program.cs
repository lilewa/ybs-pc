using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.LookAndFeel;

namespace tms.WinForm
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Access the Default LookAndFeel. 
            UserLookAndFeel defaultLF = UserLookAndFeel.Default;
            // Ensure that the Office2003 painting scheme will be used. 
            defaultLF.UseWindowsXPTheme = false;
            defaultLF.Style = LookAndFeelStyle.Skin;
              defaultLF.SkinName = "Office 2010 Blue"; 



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Login form = new Login();
            if (form.ShowDialog() == DialogResult.Cancel)
                return;

            //当窗口需要访问items.xml配置文件时，调试时需要从 MainFrame启动后转入调试窗口。因为配置文件是在 MainFrame 中初始化的
            Application.Run(new MainFrame());
           //  Application.Run(new Sample.SampleHwManager());
            // Application.Run(new Sample.PKSearch());

        }
    }
}
