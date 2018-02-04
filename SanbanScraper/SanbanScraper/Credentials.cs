using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SanbanScraper
{
    public class Credentials
    {
        private readonly string _username;
        private readonly string _password;

        public Credentials(string username, string password)
        {
            _username = username;
            _password = password;
        }

        // log in to site
        public static void Login(string username, string password, ChromeDriver driver)
        {
            // send email address
            Thread.Sleep((3000));
            driver.FindElement(By.Id("uh-signedin")).Click();
            Thread.Sleep((3000));
            driver.FindElement(By.Id("login-username")).Click();
            driver.Keyboard.SendKeys(username);
            driver.FindElement(By.Id("login-signin")).Click();
            // send password
            Thread.Sleep((3000));
            driver.FindElement(By.Id("login-passwd")).Click();
            driver.Keyboard.SendKeys(password);
            driver.FindElement(By.Id("login-signin")).Click();
        }
    }
}