using System;
using System.Text;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers; 

namespace BrowserNavigationSolutionPage95
{
    class Program
    {
        static void Main(string[] args)
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("start-maximized");
            IWebDriver driver = new ChromeDriver(@"C:\QaLearning", options);
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            
            driver.Navigate().GoToUrl("https://google.com/");

            IWebElement input_search = driver.FindElement(By.CssSelector(".gLFyf.gsfi"));
            input_search.SendKeys("It Craft");
            input_search.SendKeys(Keys.Enter);

            IWebElement search_value_is_presented = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//div/input[@value='It Craft']")));
            Console.WriteLine("Search value is presented");

            IWebElement logo_is_presented = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(".logo img")));
            Console.WriteLine("Logo is presented");

            IWebElement tool_tab_is_clickable = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector("#hdtb-tls")));
            Console.WriteLine("Tool tab is presented and clickable");

            IWebElement search_results = driver.FindElement(By.XPath("//*[@id='result-stats']"));
            StringBuilder sb = new StringBuilder(search_results.Text);
            sb.Remove(36, 12);
            string search_result = sb.ToString();
            Console.WriteLine(search_result);
                   
            IWebElement time_spent_results = driver.FindElement(By.TagName("nobr"));
            Console.WriteLine(time_spent_results.Text);

            IWebElement second_header = driver.FindElement(By.XPath("//h3[(text()) = 'IT Craft.']"));
            Console.WriteLine(second_header.Text);

            driver.Close();
        }
    }
}