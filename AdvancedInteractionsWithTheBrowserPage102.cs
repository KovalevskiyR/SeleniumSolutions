using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace BrowserNavigationSolutionPage95
{
    class Program
    {
        static void Main(string[] args)
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("start-maximized");         
            IWebDriver driver = new ChromeDriver(@"C:\QaLearning", options);
            Actions action = new Actions(driver);
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));

            driver.Navigate().GoToUrl("https://google.com/");

            IWebElement logo_is_presented = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector("img.lnXdpd")));

            IWebElement logo = driver.FindElement(By.CssSelector("img.lnXdpd"));
            IWebElement search_input = driver.FindElement(By.XPath("//input[@class='gLFyf gsfi']"));

            action.DragAndDrop(logo, search_input).Build().Perform();

            driver.Close();
        }
    }
}