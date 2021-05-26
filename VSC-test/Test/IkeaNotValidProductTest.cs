using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCStest.Test
{
    public class IkeaNotValidProductTest : BaseTest
    {
        [TestCase("IKEA iš rinkos atšaukia indus HEROISK ir TALRIKA", "IKEA iš rinkos atšaukia indus HEROISK ir TALRIKA", TestName = "HEROISK, TALRIKA")]
        [TestCase("IKEA atšaukia iš rinkos trapucius KNÄCKEBRÖD FLERKORN", "IKEA atšaukia iš rinkos trapucius KNÄCKEBRÖD FLERKORN", TestName = "KNÄCKEBRÖD FLERKORN")]
        [TestCase("IKEA atšaukia iš rinkos dali kelioniniu puodeliu TROLIGTVIS", "IKEA atšaukia iš rinkos dali kelioniniu puodeliu TROLIGTVIS", TestName = "TROLIGTVIS")]
        [TestCase("IKEA iš rinkos atšaukia dali seilinuku MATVRÅ", "IKEA iš rinkos atšaukia dali seilinuku MATVRÅ", TestName = "MATVRÅ")]
        [TestCase("IKEA ragina patikrinti, ar SUNDVIK vystymo stalus–komodas surinkote tinkamai", "IKEA ragina patikrinti, ar SUNDVIK vystymo stalus–komodas surinkote tinkamai", TestName = "SUNDVIK")]
        [TestCase("IKEA del netiksliai pažymeto pieno alergeno iš rinkosatšaukia zefyrus SÖTSAK SKUMTOP", "IKEA del netiksliai pažymeto pieno alergeno iš rinkosatšaukia zefyrus SÖTSAK SKUMTOP", TestName = "SÖTSAK SKUMTOP")]
        [TestCase("IKEA atšaukia iš rinkos dali stalu GLIVARP", "IKEA atšaukia iš rinkos dali stalu GLIVARP", TestName = "GLIVARP")]
        [TestCase("IKEA atšaukia iš rinkos dali lubiniu šviestuvu CALYPSO", "IKEA atšaukia iš rinkos dali lubiniu šviestuvu CALYPSO", TestName = "CALYPSO")]

        public static void IkeaTest(string searchText, string result)

        {
            _ikeaNotValidProductPage.NavigateToPage();
            _ikeaNotValidProductPage.CheckResult(result);
        }
    }
}
