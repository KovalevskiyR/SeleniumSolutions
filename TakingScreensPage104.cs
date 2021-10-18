using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TakingScreenshotsPage104
{
    class Program
    {
        static void Main(string[] args)
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("start-maximized");
            IWebDriver driver = new ChromeDriver(@"C:\QaLearning", options);
            ITakesScreenshot screenShotTaker = (ITakesScreenshot)driver;
            driver.Navigate().GoToUrl("https://google.com/");
            screenShotTaker.GetScreenshot().SaveAsFile(@"googleScreenshot.png");
            screenShotTaker.GetScreenshot().SaveAsFile(@"googleScreenshot.jpeg");
            driver.Quit();

        }
    }
}
