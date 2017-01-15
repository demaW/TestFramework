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
        private static readonly string NUM0_BUTTON_ID = "num0Button";
        private static readonly string NUM1_BUTTON_ID = "num1Button";
        private static readonly string NUM2_BUTTON_ID = "num2Button";
        private static readonly string NUM3_BUTTON_ID = "num3Button";
        private static readonly string NUM4_BUTTON_ID = "num4Button";
        private static readonly string NUM5_BUTTON_ID = "num5Button";
        private static readonly string NUM6_BUTTON_ID = "num6Button";
        private static readonly string NUM7_BUTTON_ID = "num7Button";
        private static readonly string NUM8_BUTTON_ID = "num8Button";
        private static readonly string NUM9_BUTTON_ID = "num9Button";
        private static readonly string DEC_SEPARATOR_ID = "decimalSeparatorButton";

        private static readonly string PLUS_BUTTON_ID = "plusButton";
        private static readonly string MINUS_BUTTON_ID = "minusButton";
        private static readonly string MULTIPY_BUTTON_ID = "multiplyButton";
        private static readonly string DIVIDE_BUTTON_ID = "divideButton";

        private static readonly string EQUAL_BUTTON_ID = "equalButton";

        private static readonly string CALC_RESULTS_ID = "CalculatorResults";

        private static readonly string MAIN_WINDOW_ID = "Calculator";
        private static readonly string CLOSE_WINDOW_ID = "Close";

        private static readonly AutomationProperty NAME_PROP = AutomationElement.NameProperty;
        private static readonly AutomationProperty ID_PROP = AutomationElement.AutomationIdProperty;

        public CalcMainWindow() : base(NAME_PROP, MAIN_WINDOW_ID)
        {
        }

        internal void PressOperation(char operand)
        {
            switch (operand)
            {
                case '+':
                    new Button(this, ID_PROP, PLUS_BUTTON_ID).Click();
                    break;
                case '-':
                    new Button(this, ID_PROP, MINUS_BUTTON_ID).Click();
                    break;
                case '/':
                    new Button(this, ID_PROP, DIVIDE_BUTTON_ID).Click();
                    break;
                case '*':
                    new Button(this, ID_PROP, MULTIPY_BUTTON_ID).Click();
                    break;
            }
        }


        public void PressEquals()
        {
            new Button(this, ID_PROP, EQUAL_BUTTON_ID).Click();
        }

        public void InputByClickNumberButton(double number)
        {
            char[] numbChar = number.ToString().ToCharArray();
            foreach (char sybm in numbChar)
            {
                pressNumberButton(sybm);
            }
        }

        private void pressNumberButton(char sybm)
        {
            switch (sybm)
            {
                case '0':
                    new Button(this, ID_PROP, NUM0_BUTTON_ID).Click();
                    break;
                case '1':
                    new Button(this, ID_PROP, NUM1_BUTTON_ID).Click();
                    break;
                case '2':
                    new Button(this, ID_PROP, NUM2_BUTTON_ID).Click();
                    break;
                case '3':
                    new Button(this, ID_PROP, NUM3_BUTTON_ID).Click();
                    break;
                case '4':
                    new Button(this, ID_PROP, NUM4_BUTTON_ID).Click();
                    break;
                case '5':
                    new Button(this, ID_PROP, NUM5_BUTTON_ID).Click();
                    break;
                case '6':
                    new Button(this, ID_PROP, NUM6_BUTTON_ID).Click();
                    break;
                case '7':
                    new Button(this, ID_PROP, NUM7_BUTTON_ID).Click();
                    break;
                case '8':
                    new Button(this, ID_PROP, NUM8_BUTTON_ID).Click();
                    break;
                case '9':
                    new Button(this, ID_PROP, NUM9_BUTTON_ID).Click();
                    break;
                case '.':
                    new Button(this, ID_PROP, DEC_SEPARATOR_ID).Click();
                    break;
            }
        }

        public double GetResutAsDouble()
        {
            string resultText = new Text(this, ID_PROP, CALC_RESULTS_ID).GetNameProperty();
            resultText = resultText.Substring("Display is ".Length).Trim(' ');
            return Double.Parse(resultText);
        }

        internal void CloseMainWindow()
        {
            Button closeButton = new Button(this, ID_PROP, CLOSE_WINDOW_ID);
            closeButton.Click();
        }
    }
}
