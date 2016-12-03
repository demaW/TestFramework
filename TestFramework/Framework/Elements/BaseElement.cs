using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Automation;
using TestFramework.Framework.Windows;

namespace TestFramework.Framework.Elements
{
    class BaseElement
    {
        AutomationElement element;

        public BaseElement(BaseWindow baseWindow, string automationId)
        {
            int ct = 0;
            do
            {
                element = baseWindow.GetAutomationElement().FindFirst(TreeScope.Descendants, new PropertyCondition(AutomationElement.AutomationIdProperty, automationId));
                ct++;
                Thread.Sleep(100);
            } while (element == null && ct < 50);

        }

        public InvokePattern GetInvokePattern()
        {
            return this.element.GetCurrentPattern(InvokePattern.Pattern) as InvokePattern;
        }

    }
}
