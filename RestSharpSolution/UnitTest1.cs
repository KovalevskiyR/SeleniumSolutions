using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TestProject2.PageObjects;

namespace TestProject2
{
    public class Tests
    {
        private IWebDriver driver;

        [OneTimeSetUp]
        public void Setup()
        {
            driver = new ChromeDriver(@"C:\QaLearning");
            driver.Manage().Window.Maximize();
        }

        [SetUp]
        public void StartTest()
        {
            TestContext.Progress.WriteLine("Test Started");
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void TestGoogleSearch()
        {
            GooglePage page = new GooglePage(driver);
            page
                .goToGooglePage()
                .inputSearch("It Craft")
                .performSearch()
                .showSearchResult();
            Assert.That(page.countResults(), Is.GreaterThan(page.preferableSearchCount), "Result count is more than 100");
        }

        [Test]
        public void TestScroll()
        {
            ItCraftPage page = new ItCraftPage(driver);
            page.goToItCraftPage();
            page.ScrollDown();
        }
    }
}