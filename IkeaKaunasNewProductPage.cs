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
        private IWebElement button => Driver.FindElement(By.CssSelector("#newFilters > label:nth-child(2) > div > span > div > ins"));

        private IWebElement resultElement => Driver.FindElement(By.CssSelector("#contentWrapper > div.container-fluid.px-0 > div > div > div:nth-child(1) > div > div > div > div.col-6.col-sm-4.col-lg-auto.mr-lg-4.my-auto > h5"));

        public IkeaKaunasNewProductPage(IWebDriver webdriver) : base(webdriver) { }

        public void NavigateToPage()
        {
                Driver.Url = addressUrl;
        }


        public void ClickButton()
        {
            button.Click();
        }
        public void CheckResult(string result)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(_driver => _driver.FindElement(By.CssSelector("#contentWrapper > div.container-fluid.px-0 > div > div > div:nth-child(1) > div > div > div > div.col-6.col-sm-4.col-lg-auto.mr-lg-4.my-auto > h5")).Displayed);
            Assert.IsTrue(resultElement.Text.Contains(result), $"Result is not correct, expected {result}, but was {resultElement.Text}");
        }
    }
}
