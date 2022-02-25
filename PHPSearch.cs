using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

                var blogSearchByName = Driver.Instance.FindElement(By.CssSelector("#select2-9a8x-container > span"));
                blogSearchByName.Click();
                blogSearchByName.SendKeys("PHPTRAVELS new opportunity");
                var phptravelsnewoportunity = Driver.Instance.FindElement(By.CssSelector("#select2-nse8-results > li > div > a > div.select2-result-repository__meta > div.select2-result-repository__title"));

                phptravelsnewoportunity.Click();
            }
            catch (Exception e)
            {
                message += "ERROR!!!" + e.Message;
            }

            return message;
        }

    }
}
