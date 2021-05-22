using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Page
{
    class IkeaSearchFinalPage : BasePage
    {
        private static IWebDriver webdriver;

        //private static IWebDriver _driver;

        private IWebElement SearchInputField => Driver.FindElement(By.Id("header_searcher_desktop_input"));
        private IWebElement button => Driver.FindElement(By.CssSelector("#headerMainToggler > div > div.container.headerMenuProducts > div.d-none.d-lg-block.m-0.searcher > div > div > button"));

        private IWebElement resultElement => Driver.FindElement(By.CssSelector("#contentWrapper > div.container-fluid > div > div > h2"));

        //public IkeaSearchFinalPage(IWebDriver webdriver)
        //{
        //    _driver = webdriver;
        //}

        
        public IkeaSearchFinalPage(IWebDriver webdriver) : base(webdriver) { }


        public void InsertTextToSearch(string searchText)
        {
            SearchInputField.Clear();
            SearchInputField.SendKeys(searchText);
        }

        internal void InsertTextToSearch(object searchText)
        {
            throw new NotImplementedException();
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
