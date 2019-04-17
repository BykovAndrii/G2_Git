using NUnit.Framework;
using System;

namespace JenkinsProject
{
    public class UT
    {
        [Test]
        public void TestMethod1()
        {
            Console.WriteLine("For testing run from Jenkins 11");
        }

        [Test]
        public void TestMethod2()
        {
            //Assert.True(false);
            Console.WriteLine("For testing run from Jenkins 22");
        }
    }
}
