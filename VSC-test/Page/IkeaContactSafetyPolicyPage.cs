using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCStest.Page
{
    public class IkeaContactSafetyPolicyPage : BasePage
    {
        private const string addressUrl = "https://www.ikea.lt/lt";

        private IWebElement okCookieButton => Driver.FindElement(By.Id("CybotCookiebotDialogBodyLevelButtonAccept"));

        private IWebElement buttonContact => Driver.FindElement(By.CssSelector("#hideOnScroll > ul.navbar.navbar-nav.servicesList.mr-lg-auto.ml-lg-auto.py-0.px-0.align-items-start > li:nth-child(7) > a"));

        private IWebElement buttonKlaipeda => Driver.FindElement(By.CssSelector("#contentWrapper > div.container.customPages > div:nth-child(2) > div > nav > div > span:nth-child(3) > a"));

        private IWebElement buttonSafety => Driver.FindElement(By.CssSelector("#img_container_7741 > img"));

        private IWebElement resultElement => Driver.FindElement(By.CssSelector("#contentWrapper > div.container.customPages > div.container.px-0 > div > div:nth-child(3) > div > div > strong"));

        public IkeaContactSafetyPolicyPage(IWebDriver webdriver) : base(webdriver) { }

        public void NavigateToPage()
        {
            Driver.Url = addressUrl;
        }

        public void CloseCookie()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(_driver => _driver.FindElement(By.Id("CybotCookiebotDialogBodyLevelButtonAccept")).Displayed);
            okCookieButton.Click();
        }

        public void ClickButtonContact()
        {
            buttonContact.Click();
        }

        public void ClickButtonKlaipeda()
        {
            buttonKlaipeda.Click();
        }

        public void ClickButtonSafety()
        {
            buttonSafety.Click();
        }


        public void CheckResult(string result)
        {
            //Assert.IsTrue(resultElement.Text.Contains(result), $"Result is not correct, expected {result}, but was {resultElement.Text}");
            //Assert.IsTrue("(1)".Equals(resultElement.Text), "Liked item does not equal 1");
            Assert.IsTrue(resultElement.Text.Contains(result), $"Result is not correct, expected {result}, but was {resultElement.Text}");

        }
    }
}
