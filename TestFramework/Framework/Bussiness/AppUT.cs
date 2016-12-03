using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestFramework.Framework.Windows.Calc;

namespace TestFramework
{
    class AppUT : IDisposable
    {
        private readonly static string APP_PATH = "Calc.exe";

        public static void Main() { }
        public void StartApp()
        {
            appProcess = Process.Start(APP_PATH);
        }

        public void Dispose()
        {
            Close();
            appProcess.Dispose();
        }

        private void Close()
        {
            CalcMainWindow calc = new CalcMainWindow();
            calc.CloseMainWindow();
        }

        private Process appProcess;
    }
}
