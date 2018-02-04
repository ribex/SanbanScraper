using System;
using NUnit.Framework;
using OpenQA.Selenium;

namespace SanbanScraper
{
    [TestFixture]
    public class NUnitTest : TestBase
    {
        [Test]
        public void OpenAppVerifyTitleTest()
        {
            Driver.Url = "https://finance.yahoo.com";
            Console.WriteLine("Opened Yahoo Finance page");
            var title = Driver.Title;
            Assert.AreEqual("Yahoo Finance - Business Finance, Stock Market, Quotes, News", title);
            Console.WriteLine("Confirmed title match");
        }

        //[Test]
        //public void TestName()
        //{
        //}

    }
}
