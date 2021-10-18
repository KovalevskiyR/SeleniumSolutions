using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CookiesHandlingPage105
{
    class Program
    {
        static void Main(string[] args)
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("start-maximized");
            IWebDriver driver = new ChromeDriver(@"C:\QaLearning", options);
            driver.Navigate().GoToUrl("https://itechcraft.com/");
            var cookie = driver.Manage().Cookies.GetCookieNamed("__cf_bm");
            string cookie_value = cookie.Value;
            Console.WriteLine();
            Console.WriteLine($"Cookie value is: {cookie_value}");
            Console.WriteLine();
            driver.Quit();
        }
    }
}
