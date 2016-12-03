using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Automation;

namespace TestFramework.Framework.Windows
{
    abstract class BaseWindow
    {
        private AutomationElement locatableElement;

        public BaseWindow(AutomationProperty property, string propertyValue)
        {
            int ct = 0;
            do
            {
                locatableElement = AutomationElement.RootElement.FindFirst(TreeScope.Children, new PropertyCondition(property, propertyValue));
                ct++;
                Thread.Sleep(100);
            } while (locatableElement == null && ct < 50);
        }

        public AutomationElement GetAutomationElement()
        {
            return locatableElement;
        }
    }
}
