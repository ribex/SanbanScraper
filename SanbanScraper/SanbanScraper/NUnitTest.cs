using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SanbanScraper
{
    [TestFixture]
    class NUnitTest
    {
        IWebDriver driver;

        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

        }

        [Test]
        public void OpenAppTest()
        {


            driver.Url = "https://finance.yahoo.com";
        }

        [TearDown]
        public void EndTest()
        {
            driver.Close();
        }
    }
}
