using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace WebDriverTest
{
    class TestingActions
    {
        [Test]
        public void TestingActionsAndAction()
        {
            IWebDriver driver = null;
            IWebElement element = null;
            IWebElement targetElement = null;

            Actions actions = new Actions(driver);

            IAction action = actions.Click().MoveByOffset(4, 5).Click().Build();

            actions.MoveToElement(element).ClickAndHold()
                .MoveToElement(targetElement).Release().Perform();
        }
    }
}
