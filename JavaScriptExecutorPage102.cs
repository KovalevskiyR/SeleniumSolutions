using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;


namespace BrowserNavigationSolutionPage95
{
    class Program
    {
        static void Main(string[] args)
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("start-maximized");
            IWebDriver driver = new ChromeDriver(@"C:\QaLearning", options);
         
            driver.Navigate().GoToUrl("https://google.com/");

            IWebElement input_search = driver.FindElement(By.CssSelector(".gLFyf.gsfi"));
            input_search.SendKeys("It Craft");
            input_search.SendKeys(Keys.Enter);

            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,document.body.scrollHeight)");

            /*driver.Close();*/
        }
    }
}