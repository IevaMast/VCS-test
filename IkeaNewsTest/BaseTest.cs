using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VCStest.Drivers;
using VCStest.Page;
using VCStest.Tools;

namespace VCStest.Test
{
    public class BaseTest
    {
        protected static IWebDriver _driver;
        public static IkeaKaunasNewProductPage _ikeaKaunasPage;
        public static IkeaSearchPage _ikeaSearchPage;
        public static IkeaLikeProductPage _ikeaLikePage;
        public static IkeaNewsPage _ikeaNewsPage;
        public static IkeaNotValidProductPage _ikeaNotValidProductPage;
        public static IkeaPage _ikeaPage;
        public static IkeaContactSafetyPolicyPage _ikeaContactSafetyPage;

        [OneTimeSetUp]
        public static void OneTimeSetUp()
        {
            _driver = CustomDriver.GetChromeDriver();
            _ikeaKaunasPage = new IkeaKaunasNewProductPage(_driver);
            _ikeaSearchPage = new IkeaSearchPage(_driver);
            _ikeaLikePage = new IkeaLikeProductPage(_driver);
            _ikeaNewsPage = new IkeaNewsPage(_driver);
            _ikeaNotValidProductPage = new IkeaNotValidProductPage(_driver);
            _ikeaPage = new IkeaPage(_driver);
            _ikeaContactSafetyPage = new IkeaContactSafetyPolicyPage(_driver);
        }

        [TearDown]
        public static void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                MyScreenshot.MakeScreenshot(_driver);
            }
        }

        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            _driver.Quit();
        }
    }
}
