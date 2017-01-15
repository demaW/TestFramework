using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestFramework.Framework.Bussiness.CalculatorBO;
using TestFramework.Framework.Core;

namespace TestFramework.Test
{
    [TestFixture]
    class SomeTest
    {
        
        [SetUp]
        public void SetUp()
        {
            AppProvider.Instance.StartApp();
        }

        [Test]
        public void OpenTest()
        {
            Thread.Sleep(2000);
            
        }

        [Test]
        public void CalculateTest()
        {
            StandartCalculatorBO scBO = new StandartCalculatorBO();
            double result = scBO.Add(58.3, 3.3);
            Assert.AreEqual(61.6, result);
        }

        [TearDown]
        public void TearDown()
        {
            AppProvider.Instance.Dispose();
        }
    }
}
