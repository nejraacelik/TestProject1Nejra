using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using StructureMap.Pipeline;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1Nejra
{
    public class Driver
    {
        public static IWebDriver Instance { get; set; }

      //default constructor

    public static void Inilialize()
    {
        Instance = new ChromeDriver();
        Instance.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(5));
            Instance.Manage().Window.Maximize();

    }
        public static void Initiliaze(int n)
        {
            if (n == 1)
            {

            }
            else if (n == 2)
            {
                var downloadDirectory = @"C:\Files";
                ChromeOptions options = new ChromeOptions();

                options.AddUserProfilePreference("download.default_directory", downloadDirectory);
                options.AddUserProfilePreference("download.prompt_for_directory", false);
                options.AddUserProfilePreference("disable-popup-blocking", "true");
                options.AddUserProfilePreference("plugins.plugins_disable", new[] {
                "Adobe Flash Player",
                "Chrome PDF Viewer"
                });

                Instance = new ChromeDriver(@"C:\Drivers\", options);
                Instance.Manage().Window.Maximize();

            }
        }
        public static void Close()
        {
            Instance.Close();
        }

        
    }
}
