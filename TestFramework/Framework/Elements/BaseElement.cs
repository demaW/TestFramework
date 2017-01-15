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
        internal AutomationElement element;

        public BaseElement(BaseWindow baseWindow, AutomationProperty autProperty, string automationPropValue)
        {
            int ct = 0;
            do
            {
                element = baseWindow.GetAutomationElement().FindFirst(TreeScope.Descendants, new PropertyCondition(autProperty, automationPropValue));
                ct++;
                Thread.Sleep(100);
            } while (element == null && ct < 50);

            if (element == null)
            {
                throw new Exception(String.Format("Element was not found. Automation Property: {0} , Value: {1}", autProperty.ToString(), automationPropValue));
            }

        }

        public InvokePattern GetInvokePattern()
        {
            return this.element.GetCurrentPattern(InvokePattern.Pattern) as InvokePattern;
        }

        public string GetNameProperty()
        {
            return this.element.Current.Name;
        }

    }
}
