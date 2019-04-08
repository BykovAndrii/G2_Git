using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace WebDriverTest
{
    public class OldQaLightPage
    {
        private const string nameFieldId = "z_text1";

        public IWebDriver driver;
        
        public OldQaLightPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "[name=_7c8289bf6b8e80c1749ef54ab01b92b8]")]
        public IWebElement course;

        [FindsBy(How = How.Id, Using = "z_sender0")]
        public IWebElement surnameField;

        [CacheLookup]
        [FindsBy(How = How.Id, Using = "z_text1")]
        public IWebElement NameField { get; private set; }

        public IWebElement NameField1
        {
            get
            {
                return driver.FindElement(By.Id("z_text1"));
            }
        }

        public void SetTextIntoNameFiled(string text)
        {
            driver.FindElement(By.Id(nameFieldId)).SendKeys(text);
        }

        public void SetTextIntoNameFiled1(string text)
        {
            Helper.SetText(NameField, text);
        }

        public string GetTextIntoNameFiled()
        {
           return driver.FindElement(By.Id(nameFieldId)).GetAttribute("value");
        }

        [FindsBy(How = How.CssSelector, Using = "[type=submit]")]
        public IWebElement submitButton;

        [FindsBy(How = How.CssSelector, Using = ".alert.alert-error")]
        public IWebElement errorRegistrationPopup;
    }
}
