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
    public class IkeaLikeProductPage : BasePage
    {

        private const string addressUrl = "https://www.ikea.lt/lt/products/miegamasis/patalyne/antklodziu-uzvalkalai/varbracka-antklodes-uzv-ir-2-pagalv-uzv-smeline-balta-art-90412596";

        private IWebElement okCookieButton => Driver.FindElement(By.Id("CybotCookiebotDialogBodyLevelButtonAccept"));

        private IWebElement button => Driver.FindElement(By.CssSelector("#contentWrapper > div > div > div > div.row.item_detail_information > div.col-12.col-sm-12.col-md-5.col-lg-5.col-xl-4 > div > div.itemActionBlock > div.itemButtons > button.addFavorites.btn.btn-block.btn-icon > span.icon-addfav"));

        //private IWebElement resultElement => Driver.FindElement(By.CssSelector("#headerMainToggler > div > div.container.headerMenuProducts > div.d-none.d-lg-block.ml-4.favourites-notification > a > span.icon.icon-fav"));

        private IWebElement resultElement => Driver.FindElement(By.XPath("//*[@id='headerMainToggler']/div/div[2]/div[2]/a/span[2]"));

        public IkeaLikeProductPage(IWebDriver webdriver) : base(webdriver) { }

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

        public void ClickButton()
        {
            button.Click();
        }

        //public void VerifyThatItemWasAddedSuccessfully() 
        //{

        //}

        public void CheckResult()
        {
            //Assert.IsTrue(resultElement.Text.Contains(result), $"Result is not correct, expected {result}, but was {resultElement.Text}");
            Assert.IsTrue("(1)".Equals(resultElement.Text), "Liked item does not equal 1");
        }
    }
}
