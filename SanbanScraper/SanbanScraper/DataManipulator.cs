using System;
using System.Collections.Generic;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SanbanScraper
{
    public class DataManipulator
    {
        public static IWebElement GetTable(ChromeDriver driver)
        {
            // get the table
            Thread.Sleep(3000);
            var table = driver.FindElement(By.XPath("//table[@data-test=\"contentTable\"]/tbody"));
            return table;
        }

        public static void ParseTable(IWebElement table, Driver driver)
        {
            // get current date time and apply to symbols
            var timeNow = DateTime.Now;

            // get all the rows
            var rows = table.FindElements(By.TagName("tr"));

            var rowCount = rows.Count;
            // Console.WriteLine("Row count: " + rowCount);

            var symbolList = new List<Symbol>();

            for (var i = 1; i <= rowCount; i++)
            {
                var rowIndex = $"//tr[{i}]/";

                var symbol = new Symbol
                {
                    SymbolName = table.FindElement(By.XPath(rowIndex + "td[1]/span/a")).Text,
                    LastPrice = Convert.ToDouble(table.FindElement(By.XPath(rowIndex + "td[2]/span")).Text),
                    Change = Convert.ToDouble(table.FindElement(By.XPath(rowIndex + "td[3]/span")).Text),
                    PercentChange = table.FindElement(By.XPath(rowIndex + "td[4]/span")).Text,
                    Currency = table.FindElement(By.XPath(rowIndex + "td[5]")).Text,
                    MarketTime = timeNow,
                    //MarketTime = table.FindElement(By.XPath(rowIndex + "td[6]/span")).Text,
                    Volume = table.FindElement(By.XPath(rowIndex + "td[7]/span")).Text,
                    Shares = Convert.ToDouble(table.FindElement(By.XPath(rowIndex + "td[8]")).Text),
                    AvgVol3Mon = table.FindElement(By.XPath(rowIndex + "td[9]")).Text,
                    MarketCap = table.FindElement(By.XPath(rowIndex + "td[13]/span")).Text
                };

                symbolList.Add(symbol);
            }
            Symbol.SymbolPrint(symbolList);
        }
    }
}