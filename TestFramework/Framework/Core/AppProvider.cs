using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework.Framework.Core
{
    internal sealed class AppProvider
    {
        private static AppUT instance;
        private AppProvider() { }

        internal static AppUT Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AppUT();
                }

                return instance;
            }
        }
    }
}
