using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCStest.Test
{
    public class IkeaLikeProductTest : BaseTest
    {

        [Test]
        public static void IkeaTest()
        {
            _ikeaLikePage.NavigateToPage();
            _ikeaLikePage.CloseCookie();
            _ikeaLikePage.ClickButton();
            _ikeaLikePage.CheckResult();
        }
    }
}

