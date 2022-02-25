using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1Nejra
{
    public class Functions
    {
        public static void WriteInto(string readText)
        {

            string filePath = @"C:\Test Configuration\LogFile.txt";

            File.AppendAllText(filePath, readText + Environment.NewLine);

        }

        public static void TakeScreenShot()
        {
            Random r = new Random();
            ((ITakesScreenshot)Driver.Instance).GetScreenshot().SaveAsFile("C:/ScreenShot/" + "/ScreenShot" + r.Next(0, 100000) + DateTime.Now.ToString("(dd_MMM_hh_mm_ss_tt)") + ".jpeg", ScreenshotImageFormat.Jpeg);
        }

        internal static void SendEmailAttachment(string subject, object body)
        {
            throw new NotImplementedException();
        }
    }

   
}
