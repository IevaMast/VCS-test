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
    public class IkeaNewsPage : BasePage
    {
        private const string addressUrl = "https://www.ikea.lt/lt/page/newitems";
        private IWebElement markElement => Driver.FindElement(By.CssSelector("#contentWrapper > div.container.customPages > div.row.navigation > div > h1"));
        private IWebElement okCookieButton => Driver.FindElement(By.Id("CybotCookiebotDialogBodyLevelButtonAccept"));

        private IWebElement buttonPrice => Driver.FindElement(By.CssSelector("#filterSelectors > div > div > nav > div > div.filterContainerMultiple > div:nth-child(1) > div"));

        private IWebElement buttonSelect => Driver.FindElement(By.CssSelector("#Mažiau-nei-50-€"));

        private IWebElement selectElement => Driver.FindElement(By.CssSelector("#contentWrapper > div.container-fluid.px-0 > div > div > div.products_list.w-100.d-flex.flex-wrap > div:nth-child(1) > div > div.card-body > div > a > div > h6"));

        private IWebElement addToCart => Driver.FindElement(By.CssSelector("#contentWrapper > div > div > div > div.row.item_detail_information > div.col-12.col-sm-12.col-md-5.col-lg-5.col-xl-4 > div > div.itemActionBlock > div.itemButtons > button.addToCart.btn.btn-yellow.btn-block.btn-icon.text-white > span.icon-addcart"));

        private IWebElement resultElement => Driver.FindElement(By.CssSelector("#modal > div > div > div.modal-header > p"));


        public IkeaNewsPage(IWebDriver webdriver) : base(webdriver) { }

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

        //public void CloseCookie()
        //{
        //    WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
        //    wait.Until(_driver => _driver.FindElement(By.Id("CybotCookiebotDialogBodyLevelButtonAccept")).Displayed);
        //    Driver.FindElement(By.Id("CybotCookiebotDialogBodyLevelButtonAccept")).Click();
        //}

        public void MarkElement()
        {
            markElement.Click();
        }

        public void ClickButton()
        {
            buttonPrice.Click();
        }

        public void ClickButton2()
        {
            buttonSelect.Click();
        }

        public void SelectProduct()
        {
            selectElement.Click();
        }

        public void AddToCart()
        {
            addToCart.Click();
        }


        public void CheckResult(string result)
        {
            Assert.IsTrue(resultElement.Text.Contains(result), $"Result is not correct, expected {result}, but was {resultElement.Text}");
        }
    }
}

