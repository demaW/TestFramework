using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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
            
        }

        [TearDown]
        public void TearDown()
        {
            AppProvider.Instance.Dispose();
        }
    }
}
