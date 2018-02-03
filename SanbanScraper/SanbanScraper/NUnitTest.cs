using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SanbanScraper
{
    class NUnitTest
    {

        IWebDriver driver;

        public void Initialize()
        {
            driver = new ChromeDriver();
        }

        public void OpenAppTest()
        {
            driver.Url = "https://finance.yahoo.com";
        }

        public void EndTest()
        {
            driver.Close();
        }
    }
}
