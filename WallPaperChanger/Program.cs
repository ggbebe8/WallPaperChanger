using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WallPaperChanger
{
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Main());
            }
            else if (args.Length == 1)
            {
                CmdMain CM = new CmdMain(args[0]);
            }
        }
    }
}