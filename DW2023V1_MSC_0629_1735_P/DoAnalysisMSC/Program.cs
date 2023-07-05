using DwLib.Data.Generic;
using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace DoAnalysisMSC
{
    internal static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                if (IsExistProcessMutex(Process.GetCurrentProcess().ProcessName))
                {
                    MessageBox.Show("이미실행중입니다.");
                }
                else
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);

                    Application.Run(new MainWindow(Analysis.mbid));
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
        }

        static bool IsExistProcessMutex(string processName)
        {
            // createdNew  : processName로 이미 명명된 뮤텍스가 있을경우 false반환
            // 신규인경우는 true를반환한다.
            var mutex = new Mutex(true, processName, out bool createdNew);
            bool isFail = true;
            if (mutex == null) { return isFail; }

            if (createdNew == true) return false;
            else return isFail;

        }
    }
}
