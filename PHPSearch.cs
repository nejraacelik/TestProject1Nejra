using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using QATest.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestProject1Nejra
{
    public class PHPSearch
    {
        private static object functions;
        

        public static string GooglePHP(string word)
        {
            string message = ";";

            try
            {
                var findText = Driver.Instance.FindElement(By.Name("q")); //pronadjen search element
                findText.SendKeys(word); //PHPposlato
                //Thread.Sleep(500);

                Actions builder = new Actions(Driver.Instance); //kreira akciju
                builder.SendKeys(Keys.Enter).Perform(); // akcija enter key (perform-odradi)
                                                        //Thread.Sleep(1000);

                //

                var pHPTravels = Driver.Instance.FindElement(By.CssSelector("#rso > div:nth-child(1) > div > div > div > div > div > div.yuRUbf > a > h3"));
                //klik na prvi ponudjeni
                pHPTravels.Click(); //otvara novu stranicu
                                    //  Thread.Sleep(1000)

                var company = Driver.Instance.FindElement(By.CssSelector("body  nav .lvl-0.dropdown.headerLang span"));
                company.Click();

                var companyBlog = Driver.Instance.FindElement(By.CssSelector("body nav .lvl-0.dropdown.headerLang div a:nth-child(1)"));
                companyBlog.Click();

                var blogSearchByName = Driver.Instance.FindElement(By.CssSelector("body > section.hero > div > div > div:nth-child(2) > span"));
                blogSearchByName.Click();
                var blogSearchByNameField = Driver.Instance.FindElement(By.CssSelector("body > span > span > span.select2-search.select2-search--dropdown > input"));
                blogSearchByNameField.SendKeys("PHPTRAVELS new opportunity");
             
                Thread.Sleep(500);

                var phpTravelsCompanyBlogFieldResult = Driver.Instance.FindElement(By.XPath("/html/body/span/span/span[2]/ul/li/div/a"));
                phpTravelsCompanyBlogFieldResult.Click();
                Thread.Sleep(500);

                Functions.TakeScreenShot();

                message = "passed";

               
            }
            catch (Exception e)
            {
                message += "ERROR!!!" + e.Message;
            }

            return message;
        }

    }
}
