using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Threading;

namespace BrowserNavigationSolutionPage95
{
    class Program
    {
        static void Main(string[] args)
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("start-maximized");
            IWebDriver driver = new ChromeDriver(@"C:\QaLearning", options);
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 15));

            driver.Navigate().GoToUrl("https://google.com/");
            string firstTab = driver.CurrentWindowHandle;

            ((IJavaScriptExecutor)driver).ExecuteScript("window.open('https://itechcraft.com/');");
   
            driver.SwitchTo().Window(firstTab);
            
            IWebElement logo_is_presented = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector("img.lnXdpd")));

            driver.Close();
        }
    }
}