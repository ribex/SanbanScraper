using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SanbanScraper
{
    [TestFixture]
    public class NUnitTest : TestBase
    {
        [Test]
        public void OpenAppVerifyTitleTest()
        {
            driver.Url = "https://finance.yahoo.com";
            Console.WriteLine("Opened Yahoo Finance page");
            var title = driver.Title;
            Assert.AreEqual("Yahoo Finance - Business Finance, Stock Market, Quotes, News", title);
            Console.WriteLine("Confirmed title match");
        }

        //[Test]
        //public void TestName()
        //{
        //}

    }
}
