using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;
using TestFramework.Framework.Elements;

namespace TestFramework.Framework.Windows.Calc
{
    class CalcMainWindow : BaseWindow
    {
        private static readonly String MAIN_WINDOW_ID = "Calculator";
        private static readonly AutomationProperty PROP = AutomationElement.NameProperty;
        private static readonly String CLOSE_WINDOW_ID = "Close";

        public CalcMainWindow() : base(PROP, MAIN_WINDOW_ID)
        {
        }

        internal void CloseMainWindow()
        {
            Button closeButton = new Button(this, CLOSE_WINDOW_ID);
            closeButton.Click();
        }
    }
}
