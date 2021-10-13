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
            
            IWebElement search_results = driver.FindElement(By.XPath("//*[@id='result-stats']"));

            string searchResults = search_results.Text;
            string result = searchResults.Remove(searchResults.LastIndexOf("("));
            Console.WriteLine(result);

            IWebElement time_spent_results = driver.FindElement(By.TagName("nobr"));
            Console.WriteLine(time_spent_results.Text);

            IWebElement second_header = driver.FindElement(By.XPath("//*[@id='rso']/div[2]//h3"));
            Console.WriteLine(second_header.Text);
            
            driver.Close();
        }
    }
}