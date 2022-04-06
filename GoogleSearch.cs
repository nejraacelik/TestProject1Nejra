using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using QATest.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestProject1Nejra
{
    public class GoogleSearch
        
    {
        private static object functions;

        public static string SearchParameter(string word)
        {
            string message = ";";
            string qa = "qa";

            try
            {
                var findText = Driver.Instance.FindElement(By.Name("q")); //pronadjen search element
                findText.SendKeys(word); //academy387poslato
                //Thread.Sleep(500);

                Actions builder = new Actions(Driver.Instance); //kreira akciju
                builder.SendKeys(Keys.Enter).Perform(); // akcija enter key (perform-odradi)
               //Thread.Sleep(1000);

                //

                var academy387 = Driver.Instance.FindElement(By.CssSelector("#rso > div:nth-child(1) > div > div > div > div > div > div.yuRUbf > a")); //klik na prvi ponudjeni
                academy387.Click(); //otvara novu stranicu
              //  Thread.Sleep(1000);

                var academy387SearchField = Driver.Instance.FindElement(By.Id("main-search-input")); //pronalazi search na novoj stranici
                academy387SearchField.SendKeys(qa); //ukucava qa
               // Thread.Sleep(500);

                builder.SendKeys(Keys.Enter).Perform(); //klik
                //Thread.Sleep(1000);

                //#category_id
                var category = Driver.Instance.FindElement(By.Id("category_id"));
                var categoryElement = new SelectElement(category); //napravit objekat i proslijedit category
                categoryElement.SelectByValue("it-skills"); //selectuje opciju by value
                Thread.Sleep(1000);

                var predavac = Driver.Instance.FindElement(By.Id("lecturer_id"));
                var teacherElement=new SelectElement(predavac);
                teacherElement.SelectByText("Nemanja Pušara");
                Thread.Sleep(1000);

                var osvjeziButton = Driver.Instance.FindElement(By.XPath("/html/body/div[3]/div/div/div/div[1]/form/input[2]"));

                osvjeziButton.Click();

                //mora biti samo 1 rezultat
                // var results = Driver.Instance.FindElements(By.XPath("/html/body/div[3]/div/div/div/div[2]/div[2]/div"));
                
                var results = Driver.Instance.FindElements(By.CssSelector("div[class='col-xs-6 col-md-4 program-col']")); 
                
                if (results.Count==1)
                {
                    message = "ok";
                }

            }
            catch (Exception e)
            {
                message += "ERROR!!!" + e.Message;
            }

            return message;

        }

        public static string PretraziKurseve(string PretraziKurseve)
        {
            string message = "";
            try
            {
                var pretraziKurseve = Driver.Instance.FindElement(By.Id("main-search-input"));
                pretraziKurseve.SendKeys("QA");
                Thread.Sleep(500);
                Functions.TakeScreenShot();
               
            }
            catch (Exception e)
            {
                message += "Error" + e.Message;
            }
            return message;
        }

        public static string Contacts(string Kontakti)
        {
            string message = "";
            try
            {
                var kontakti = Driver.Instance.FindElement(By.CssSelector("#bs-example-navbar-collapse-1 > ul.nav.navbar-nav.navbar-right > li:nth-child(5)"));
                kontakti.Click();
                Thread.Sleep(500);
                Functions.TakeScreenShot();

            }
            catch (Exception e)
            {
                message += "ERROR" + e.Message;
            }
            return message;

        }

        public static string Clients(string Klijenti)
        {
            string message = "";

            try
            {
                var klijenti = Driver.Instance.FindElement(By.CssSelector("#bs-example-navbar-collapse-1 > ul.nav.navbar-nav.navbar-right > li:nth-child(4)"));
                klijenti.Click();
                Thread.Sleep(500);
                Functions.TakeScreenShot();

            }
            catch (Exception e)
            {
                message = "ERROR" + e.Message;
            }
            return message;
        }

        public static string Events(string Dogadjaji)
        {
            string message = "";

            try
            {
                var dogadjaji = Driver.Instance.FindElement(By.CssSelector("#bs-example-navbar-collapse-1 > ul.nav.navbar-nav.navbar-right > li:nth-child(3)"));
                dogadjaji.Click();
                Thread.Sleep(500);
                Functions.TakeScreenShot();

            }
            catch (Exception e)
            {
                message = "ERROR" + e.Message;
            }
            return message;
        }


            public static string Lecturer(string lecturer)
        {
            string message = "";

            try
            {
                var predavaci = Driver.Instance.FindElement(By.CssSelector("#bs-example-navbar-collapse-1 > ul.nav.navbar-nav.navbar-right > li:nth-child(2) > a"));
                predavaci.Click();
                Thread.Sleep(500);
                Functions.TakeScreenShot();


                var predavaciSlovo = Driver.Instance.FindElement(By.CssSelector(".page-content div:nth-child(1) .col-xs-12.hidden-xs.hidden-sm li:nth-child(14) a"));
                predavaciSlovo.Click();
                Thread.Sleep(500);
                Functions.TakeScreenShot();


                var predavaciSlovoNemanja = Driver.Instance.FindElement(By.CssSelector("#lecturers-container > div > div:nth-child(1) > div > a > div.lecturer-image.text-center"));
                predavaciSlovoNemanja.Click();
                Thread.Sleep(500);
                Functions.TakeScreenShot();


            }

            catch (Exception e)
            {
                message = "ERROR" + e.Message;
            }
            return message;
        }
    }


}
