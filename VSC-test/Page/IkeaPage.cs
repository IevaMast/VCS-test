using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCStest.Page
{
    public class IkeaPage : BasePage
    {
        private const string addressUrl = "https://www.ikea.lt/lt";
        private IWebElement okCookieButton => Driver.FindElement(By.Id("CybotCookiebotDialogBodyLevelButtonAccept"));
        public IkeaPage(IWebDriver webdriver) : base(webdriver) { }

        public void Navigate()
        {
            Driver.Url = addressUrl;
        }

        public void CloseCookie()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(_driver => _driver.FindElement(By.Id("CybotCookiebotDialogBodyLevelButtonAccept")).Displayed);
            okCookieButton.Click();
        }
    }
}