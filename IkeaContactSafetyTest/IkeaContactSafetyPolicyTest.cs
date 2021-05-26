using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCStest.Test
{
    public class IkeaContactSafetyPolicyTest : BaseTest
    {     
        [Test]
        public static void IkeaTest()
    {
            _ikeaContactSafetyPage.NavigateToPage();
            _ikeaContactSafetyPage.CloseCookie();
            _ikeaContactSafetyPage.ClickButtonContact();
            _ikeaContactSafetyPage.ClickButtonKlaipeda();
            _ikeaContactSafetyPage.ClickButtonSafety();
            _ikeaContactSafetyPage.CheckResult("Saugumas svarbiausia");
        }
}
}
