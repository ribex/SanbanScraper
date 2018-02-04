using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SanbanScraper
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var portfolio = new Portfolio { Name = "DaydreamsCanComeTrue" };
            Console.WriteLine("Getting Portfolio " + portfolio.Name);

            var chrDr = new Driver();

            // go to Yahoo Finance
            chrDr.Url = "https://finance.yahoo.com/";

            Credentials.Login("ribexy@gmail.com", "ChromeDriver2018", chrDr);

            // go to portfolio
            chrDr.Url = "https://finance.yahoo.com/portfolio/p_1/view/v1";

            var table = DataManipulator.GetTable(chrDr);

            DataManipulator.ParseTable(table, chrDr);
        }
    }


}
