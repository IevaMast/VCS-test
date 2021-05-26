using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VCStest.Page;

namespace VCStest.Test
{
    public class IkeaSearchTest : BaseTest
    {
      
        [TestCase("sofa", "sofa", TestName = "sofa")]
        [TestCase("lėkštė", "lėkštė", TestName = "lėkštė")]
        public static void IkeaTest(string searchText, string result)

        {
            _ikeaSearchPage.NavigateToPage();
            _ikeaSearchPage.InsertTextToSearch(searchText);
            _ikeaSearchPage.ClickButton();
            _ikeaSearchPage.CheckResult(result);
        }
    }
}
