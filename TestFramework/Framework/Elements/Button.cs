using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestFramework.Framework.Windows;

namespace TestFramework.Framework.Elements
{
    class Button : BaseElement
    {
        public Button(BaseWindow baseWindow, string automationId) : base(baseWindow, automationId)
        {
        }

        public void Click()
        {
            this.GetInvokePattern().Invoke();
        }
    }
}
