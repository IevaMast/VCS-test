using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCStest.Test
{
    public class IkeaNewsTest : BaseTest
    {
        [Test]
        public static void IkeaTest()
        {
            _ikeaNewsPage.NavigateToPage();
            _ikeaNewsPage.CloseCookie(); 
            _ikeaNewsPage.MarkElement();
            _ikeaNewsPage.ClickButton();
            _ikeaNewsPage.ClickButton2();
            _ikeaNewsPage.SelectProduct();
            _ikeaNewsPage.AddToCart();
            _ikeaNewsPage.CheckResult("Įdėjote 1 prekę(-ių) į krepšelį");
        }
    }
}
