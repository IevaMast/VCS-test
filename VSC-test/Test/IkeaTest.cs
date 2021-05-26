using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCStest.Test
{
    public class IkeaTest : BaseTest
    {

        [Test]
        public static void TestIkeaCookie()
        {
            _ikeaPage.Navigate();
            _ikeaPage.CloseCookie();
        }
    }
}