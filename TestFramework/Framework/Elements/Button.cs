using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;
using TestFramework.Framework.Windows;

namespace TestFramework.Framework.Elements
{
    class Button : BaseElement
    {
        public Button(BaseWindow baseWindow, AutomationProperty autProperty, string automationPropVal) : base(baseWindow, autProperty, automationPropVal)
        {
        }

        public void Click()
        {
            this.GetInvokePattern().Invoke();
        }
    }
}
