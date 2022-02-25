using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject1Nejra
{
    [TestClass]
    public class FirstTest
    {
        private const string Word = "Academy387";
        private object openUrl;
        private TestArguments parameters;
        private object subject;
        private object body;

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
        public void GoogleSearchMethod()
        {
            string URL = parameters.url;
            string subject = "";
            OpenUrl.GoTo(URL);
            //string test = "";

            string pretraga = GoogleSearch.SearchParameter("academy387");
            string predavaci = GoogleSearch.Lecturer("Nemanja Pušara");
            string dogadjaji = GoogleSearch.Events("Dogadjaji");
            string klijenti = GoogleSearch.Clients("Klijenti");
            string kontakt = GoogleSearch.Contacts("Kontakti");
            string pretraziKurseve = GoogleSearch.PretraziKurseve("PretraziKurseve");
            if (!pretraga.Contains("ERROR") && (!predavaci.Contains("ERROR")))
                    {
                subject = "Passed!!!" + subject;
                            }
            else
            {
                subject = "failed!!!" + subject;
            }

            Assert.AreEqual("ok", pretraga);
            Assert.IsFalse(subject.Contains("false"));
            Functions.WriteInto("Test ended" + DateTime.Now.ToString("(dd_MMMM_hh_mm_ss_tt)"));

            Functions.SendEmailAttachment(subject, body);
           Assert.IsTrue(subject.Contains("passed"));
            Assert.IsFalse(subject.Contains("failed"));

            Functions.WriteInto("Test ended" + DateTime.Now.ToString());

        }
        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }


        //[DataTestMethod]
        //[DataRow("2", "https://www.klix.ba")]
        //public void DataTestMethod(string browser, string url)
        //{
            //int a = int.Parse(browser);
            //Driver.Initiliaze(a);
            //OpenUrl.GoTo(url);

        //}


        //
        //[DataTestMethod]
        //[DataRow("https://www.klix.ba/", "")]
        // [DataRow("https://www.olx.ba", "")]
        //public void TestMethod2(string url, string result)
        //{
        // OpenUrl.GoTo(url);
        // string test = "";
        //}

    }
}