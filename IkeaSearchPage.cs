using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCStest.Page
{
    public class IkeaSearchPage : BasePage
    {
        private const string addressUrl = "https://www.ikea.lt/lt";
        private IWebElement SearchInputField => Driver.FindElement(By.Id("header_searcher_desktop_input"));
        private IWebElement button => Driver.FindElement(By.CssSelector("#headerMainToggler > div > div.container.headerMenuProducts > div.d-none.d-lg-block.m-0.searcher > div > div > button"));

        private IWebElement resultElement => Driver.FindElement(By.CssSelector("#contentWrapper > div.container-fluid > div > div > h2"));

        public IkeaSearchPage(IWebDriver webdriver) : base(webdriver) { }

        public void NavigateToPage()
        {
            Driver.Url = addressUrl;
        }

        public void InsertTextToSearch(string searchText)
        {
            SearchInputField.Clear();
            SearchInputField.SendKeys(searchText);
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
