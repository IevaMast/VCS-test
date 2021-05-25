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
        //public static CheckboxPage _checkboxPage;
        //public static VartuTechnikaPage _vartuTechnika;
        //public static DropdownPage _dropdownPage;
        //public static IkeaPage _ikeaPage;
        public static IkeaKaunasNewProductPage _ikeaKaunasPage;
        public static IkeaSearchPage _ikeaSearchPage;

        [OneTimeSetUp]
        public static void OneTimeSetUp()
        {
            _driver = CustomDriver.GetChromeDriver();
            //_checkboxPage = new CheckboxPage(_driver);
            //_vartuTechnika = new VartuTechnikaPage(_driver);
            //_dropdownPage = new DropdownPage(_driver);
            //_ikeaPage = new IkeaPage(_driver);
            _ikeaKaunasPage = new IkeaKaunasNewProductPage(_driver);
            _ikeaSearchPage = new IkeaSearchPage(_driver);

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
