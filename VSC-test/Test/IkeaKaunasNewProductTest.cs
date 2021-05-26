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
    public class IkeaKaunasNewProductTest : BaseTest
    {

        [Test]
        public static void TestIkeaKaunas()

        {
            _ikeaKaunasPage.NavigateToPage();
            _ikeaPage.CloseCookie();
            _ikeaKaunasPage.ClickButton();
            _ikeaKaunasPage.CheckResult("Prekių iš viso 2");
        }


    }
}
