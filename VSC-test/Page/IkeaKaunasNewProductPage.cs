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
    public class IkeaKaunasNewProductPage : BasePage
    {
        private const string addressUrl = "https://www.ikea.lt/lt/immediate-take-away-kaunas";
        //private IWebElement okCookieButton => Driver.FindElement(By.Id("CybotCookiebotDialogBodyLevelButtonAccept"));

        private IWebElement button => Driver.FindElement(By.CssSelector("#newFilters > label:nth-child(2) > div > span > div > ins"));

        private IWebElement resultElement => Driver.FindElement(By.CssSelector(".col-6.col-sm-4.col-lg-auto.mr-lg-4.my-auto"));


        public IkeaKaunasNewProductPage(IWebDriver webdriver) : base(webdriver) { }

        public void NavigateToPage()
        {
                Driver.Url = addressUrl;
        }

        //public void CloseCookie()
        //{
        //    WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
        //    wait.Until(_driver => _driver.FindElement(By.Id("CybotCookiebotDialogBodyLevelButtonAccept")).Displayed);
        //    okCookieButton.Click();
        //}

        public void ClickButton()
        {
            button.Click();
        }
        public void CheckResult(string result)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementExists(By.XPath("//h5[contains(text(), 'Prekių iš viso')]")));
            Assert.IsTrue(resultElement.Text.Contains(result), $"Result is not correct, expected {result}, but was {resultElement.Text}");
        }
    }
}
