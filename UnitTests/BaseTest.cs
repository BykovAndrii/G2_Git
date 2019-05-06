using NUnit.Framework;
using System;

namespace UnitTests
{
    public class BaseTest
    {
        [OneTimeSetUp]
        [Custom]
        public void BeforeAllTest()
        {
            Console.WriteLine("BeforeAllTest");
        }

        [OneTimeTearDown]
        public void AfterAllTest()
        {
            Console.WriteLine("AfterAllTest");
        }

        [SetUp]
        public void BeforeEveryTest()
        {
            Console.WriteLine("BeforeEveryTest");
        }

        [TearDown]
        public void AfterEveryTest()
        {
            Console.WriteLine("AfterEveryTest");
        }
    }
}
