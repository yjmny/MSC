using DWLib.Data.Generic;
using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace DoMeasureMSC
{
    internal static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [MTAThread]
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

                    Application.Run(new MainWindow(Measure.mbid));
                }
            }catch(Exception exc)
            {
                System.Windows.Forms.MessageBox.Show(exc.ToString(), "DoMeasureMSC");
            }
        }
        static bool IsExistProcessMutex(string processName)
        {
            // 신규인경우는 true를반환한다.
            Mutex mutex = new Mutex(true, processName, out bool createdNew);
            mutex.Close();
            if (createdNew == true)
                return false;
            else
                return true;

        }
    }
}
