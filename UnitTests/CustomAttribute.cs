using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Interfaces;

namespace UnitTests
{
    class CustomAttribute : Attribute, ITestAction
    {
        public ActionTargets Targets
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void AfterTest(ITest test)
        {
            throw new NotImplementedException();
        }

        public void BeforeTest(ITest test)
        {
            throw new NotImplementedException();
        }
    }
}
