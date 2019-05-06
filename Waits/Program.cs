using OpenQA.Selenium;
using System;
using WaitHelpers = SeleniumExtras.WaitHelpers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace Waits
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = null;
            IWebElement element = null;

            driver.JavaScriptClick(element);

            driver.SetImplicitWait(10);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));

            wait.Until(WaitHelpers.ExpectedConditions.ElementToBeClickable(element));

            CustomWaits.WaitForElementIsClickable(driver, element, 3);

        }
    }
}
