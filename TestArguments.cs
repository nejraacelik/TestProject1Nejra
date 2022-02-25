﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TestProject1Nejra
{
    public class TestArguments
    {
        public string browser { get; set; }
        public string url { get; set; }

        public TestArguments()
        {
            string configFilePath = @"C://Test Configuration\config.xml";

            if (!File.Exists(configFilePath))
                throw new FileNotFoundException("Specified test configuration file does not exist.");

            //Load configuration xml file

            XmlDocument doc = new XmlDocument();
            doc.Load(configFilePath);

            string driverValue = doc.DocumentElement.SelectSingleNode("//testconfiguration//browser").InnerText;
            string urlValue = doc.DocumentElement.SelectSingleNode("//testconfiguration//url").InnerText;

            if (string.IsNullOrWhiteSpace(driverValue) || string.IsNullOrWhiteSpace(urlValue))
            {
                throw new ArgumentNullException("test parameters from configuration XML file are not valid.please check configuration xml file");
            }
            else
            {
                this.browser = driverValue;
                this.url = urlValue;
            }
        }
    }
}
        