using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1Nejra
{

    [TestClass]
    public class FinalTest
    {
        private const string Word = "PHP travels";
        private object openUrl;
        private TestArguments parameters;
        private object subject;

        [TestInitialize]

        public void Init()
        {

            Functions.WriteInto("Start of init");
            parameters = new TestArguments();
            int a = int.Parse(parameters.browser);
            Driver.Initiliaze(a);
            Functions.WriteInto("End of init");

        }
        [TestMethod]
        public void PHPGoogleSearchMethod()
        {
            string URL = parameters.url;
            string subject = "";
            OpenUrl.GoTo(URL);
            //string test = "";

            string messagePHPTravel  = PHPSearch.GooglePHP("PHPtravel");


        }

        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }
    }
}




