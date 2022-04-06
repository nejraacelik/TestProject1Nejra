using Microsoft.VisualStudio.TestTools.UnitTesting;
using QATest.Setup;
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
        private string filePath = @"C:\Test Configuration\LogFile.txt";


        [TestInitialize]

        public void Init()
        {
            var downloadDirectory = @"C:\Files";
            var driverDirectory = @"C:\Drivers\";
            var configFilePath = @"C://Test Configuration\config.xml";

            Functions.WriteInto(filePath, "Start of init");
            parameters = new TestArguments(configFilePath);
            Driver.Initiliaze(driverDirectory, downloadDirectory, parameters.Browser);
            Functions.WriteInto(filePath, "End of init");

        }
        [TestMethod]
        public void PHPGoogleSearchMethod()
        {
            string URL = parameters.Url;
            string subject = "";
            Url.GoTo(URL);
            //string test = "";

            string messagePHPTravel  = PHPSearch.GooglePHP("PHPtravel");

            Assert.AreEqual(messagePHPTravel, "passed");
        }

        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }
    }
}




