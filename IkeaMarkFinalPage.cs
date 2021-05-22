using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class IkeaMarkFinalPage
    {

        [Test]
        public static void IkeaMark()
        {
            IWebDriver chrome = new ChromeDriver();
            chrome.Url = "https://www.ikea.lt/lt/products/miegamasis/patalyne/antklodes";
            chrome.Manage().Window.Maximize();

            WebDriverWait waitCookie = new WebDriverWait(chrome, TimeSpan.FromSeconds(10));
            waitCookie.Until(_chrome => chrome.FindElement(By.CssSelector("#CybotCookiebotDialogBodyLevelButtonAccept")).Displayed); //cookie
            chrome.FindElement(By.CssSelector("#CybotCookiebotDialogBodyLevelButtonAccept")).Click();

            IWebElement productTitle = chrome.FindElement(By.CssSelector("#contentWrapper > div > div > div.products_list.w-100.d-flex.flex-wrap > div:nth-child(4) > div > div.card-body > div > a > div > h6"));
            string myTextProduct = "FJÄLLARNIKA";
            productTitle.SendKeys(myTextProduct);

            IWebElement quickReviewButton = chrome.FindElement(By.CssSelector("#contentWrapper > div > div > div.products_list.w-100.d-flex.flex-wrap > div:nth-child(4) > div > div.card-footer > button > span:nth-child(2)"));
            quickReviewButton.Click();

            IWebElement addToCart = chrome.FindElement(By.CssSelector("#sidenav > div > div.card-body > div > div > div:nth-child(2) > div > div.itemActionBlock > div.itemButtons > button.addToCart.btn.btn-yellow.btn-block.btn-icon.text-white > span.shopping-cart-buy"));
            addToCart.Click();

            IWebElement reviewCart = chrome.FindElement(By.CssSelector("#modal > div > div > div.modal-footer.d-block > div.row.m-0 > div > div > button.goToCart.btn.btn-yellow.btn-icon.text-white > span:nth-child(1)"));
            reviewCart.Click();

            IWebElement deleteCartItem = chrome.FindElement(By.CssSelector("#cart > div.shoppingcart-list.available-list > div > div.d-flex.flex-wrap.align-items-center.justify-content-md-end.justify-content-between.mt-4 > div.remove.d-none.d-md-block.order-4 > button > span"));
            deleteCartItem.Click();

            IWebElement result = chrome.FindElement(By.CssSelector("#cart > div.row.mt-5 > div > p"));
            Assert.AreEqual("Jūsų pirkinių krepšelis tuščias. Jūs neturite prekių pirkinių krepšelyje.", result.Text, "Result not right if cart is not empty");

            chrome.Quit();

        }
    }
}
