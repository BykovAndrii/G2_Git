using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverTest
{
    static class Helper
    {
        public static void SetText(IWebElement element, string text)
        {
            element.SendKeys(text);
        }
    }
}
