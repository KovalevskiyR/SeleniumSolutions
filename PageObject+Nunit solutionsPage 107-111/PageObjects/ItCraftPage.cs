using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using NUnit.Framework;

namespace TestProject2.PageObjects
{
    class ItCraftPage
    {
        private IWebDriver driver;

        public ItCraftPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void goToItCraftPage()
        {
            driver.Navigate().GoToUrl("https://itechcraft.com/");
        }

        public void ScrollDown()
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,document.body.scrollHeight)");
        }
    }
}
