using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace WebDriverTest
{
    public class UnitTest1
    {
        IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.ukr.net/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void TestMethod1()
        {
            string windowHandle = driver.CurrentWindowHandle;

            Console.WriteLine(windowHandle);

            IWebElement element = driver
                .FindElement(By.CssSelector("test ccs"));

            var elements = driver
                .FindElements(By.CssSelector("test multi ccs"));

            var allWindowHandles = driver.WindowHandles;

            driver.SwitchTo().Window(windowHandle);

        }
    }
}
