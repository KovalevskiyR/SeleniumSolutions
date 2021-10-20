using System;
using System.Linq;
using NUnit.Framework;
using OpenQA.Selenium;

namespace TestProject2.PageObjects
{
    class GooglePage
    {
        private IWebDriver driver;
        public int preferableSearchCount = 100;
      
        private readonly By searchInput = By.CssSelector(".gLFyf.gsfi");
        private readonly By searchResults = By.XPath("//*[@id='result-stats']");

        public GooglePage(IWebDriver driver)
        {
            this.driver = driver;         
        }

        public GooglePage goToGooglePage()
        {
            driver.Navigate().GoToUrl("https://google.com/");
            return new GooglePage(driver);
        }

        public GooglePage inputSearch(string text)
        {
            driver.FindElement(searchInput).SendKeys(text);
            return new GooglePage(driver);
        }

        public GooglePage performSearch()
        {
            driver.FindElement(searchInput).SendKeys(Keys.Enter);
            return new GooglePage(driver);
        }

        public GooglePage showSearchResult()
        {
            string text = driver.FindElement(searchResults).Text;
            TestContext.Progress.WriteLine(text);
            return new GooglePage(driver);
        }
        public int countResults()
        {
            string text = driver.FindElement(searchResults).Text;
            string foundResults = text.Remove(text.LastIndexOf("("));
            string result = new String(foundResults.Where(Char.IsDigit).ToArray());
            int count_results = Convert.ToInt32(result);
            return count_results;
        }
    }
}
