using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;
using TestFramework.Framework.Windows;

namespace TestFramework.Framework.Elements
{
    class Text : BaseElement
    {
        public Text(BaseWindow baseWindow, AutomationProperty autProperty, string automationPropValue) : base(baseWindow, autProperty, automationPropValue)
        {
        }

        public ValuePattern GetValuePattern()
        {
            return this.element.GetCurrentPattern(ValuePattern.Pattern) as ValuePattern;
        }

        public string GetValueText()
        {
            ValuePattern valPat = GetValuePattern();
            return valPat.Current.Value;
        }
    }
}
