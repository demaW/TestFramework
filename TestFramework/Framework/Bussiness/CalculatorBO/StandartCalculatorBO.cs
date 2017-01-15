using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestFramework.Framework.Windows.Calc;

namespace TestFramework.Framework.Bussiness.CalculatorBO
{
    class StandartCalculatorBO
    {
        internal double Add(double v1, double v2)
        {
            CalcMainWindow calcMain = new CalcMainWindow();
            calcMain.InputByClickNumberButton(v1);
            calcMain.PressOperation('+');
            calcMain.InputByClickNumberButton(v2);
            calcMain.PressEquals();
            double result = calcMain.GetResutAsDouble();
            return result;
        }
    }
}
