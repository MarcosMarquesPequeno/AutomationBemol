using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace AutomationBemol.Trivago
{
    [TestClass]
    public class AutomationTrivago
    {
        private IWebDriver driver;
        private String baseUrl;

        public AutomationTrivago()
        {
            driver = new ChromeDriver();
            baseUrl = "https://www.trivago.com.br/";
        }

        [TestMethod]
        public void Hoteis()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(baseUrl);
            driver.FindElement(By.Id("input-auto-complete")).SendKeys("Manaus");
            Thread.Sleep(3 * 1000);

            int clicks = 0;
            while (clicks < 3)
            {
                driver.FindElement(By.XPath("//span[contains(text(),'Pesquisar')]")).Click();
                Thread.Sleep(2 * 1000);
                clicks++;
            }

            Thread.Sleep(5 * 1000);
            driver.FindElement(By.XPath("//select[@id='sorting-selector']")).Click();
            Thread.Sleep(5 * 1000);
            driver.FindElement(By.XPath("//option[contains(text(),'Avaliação e sugestões')]")).Click();
        }
    }
}
