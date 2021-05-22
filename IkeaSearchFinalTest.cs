using ClassLibrary.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Test
{
    public class IkeaSearchFinalTest
    {
            private static IWebDriver _driver;

        [OneTimeSetUp]
            public static void OneTimeSetUp()
            {
                _driver = new ChromeDriver();
                _driver.Url = "https://www.ikea.lt/lt";
                _driver.Manage().Window.Maximize();
                //_driver.FindElement(By.Id("")).Click(); // esant cookies panaudoti (yra psl. bet nuėmiau ir nebepasirodo)
            }

            [OneTimeTearDown]
            public static void OneTimeTearDown()
            {
                _driver.Quit();
            }

        [TestCase("sofa", "sofa", TestName = "sofa")]
        [TestCase("lėkštė", "lėkštė", TestName = "lėkštė")]
        public static void IkeaTest(string searchText, string result)

            {
                IkeaSearchFinalPage _page = new IkeaSearchFinalPage(_driver);
                _page.InsertTextToSearch(searchText);
                _page.ClickButton(); 
                _page.CheckResult(result);
            }
        }
    }


