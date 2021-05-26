using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCStest.Page
{
    public class IkeaNotValidProductPage : BasePage
    {
        private const string addressUrl = "https://www.ikea.lt/lt/customerservice/product-recalls";

        private IWebElement findElement => Driver.FindElement(By.CssSelector("#contentWrapper > div > div.row > div.col-12.col-lg-10.aboutContents > div > div.container.px-0 > div > div:nth-child(1) > div.mb-4.text-wrap > h4"));
        private IWebElement button => Driver.FindElement(By.CssSelector("#headerMainToggler > div > div.container.headerMenuProducts > div.d-none.d-lg-block.m-0.searcher > div > div > button"));
        private IWebElement resultElement => Driver.FindElement(By.CssSelector("#contentWrapper > div.container-fluid > div > div > h2"));

        public IkeaNotValidProductPage(IWebDriver webdriver) : base(webdriver) { }

        public void NavigateToPage()
        {
            Driver.Url = addressUrl;
        }

        public void FindProduct(string searchText)
        {
            findElement.Clear();
            findElement.SendKeys(searchText);
        }

        public void ClickButton()
        {
            button.Click();
        }


        public void CheckResult(string result)
        {
            Assert.IsTrue(resultElement.Text.Contains(result), $"Result is not correct, expected {result}, but was {resultElement.Text}");
        }
    }
}
