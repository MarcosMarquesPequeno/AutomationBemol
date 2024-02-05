using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace AutomationBemol.Correios
{
    [TestClass]
    public class AutomationCorreios
    {
        private IWebDriver driver;
        private string baseUrl;

        public AutomationCorreios()
        {
            driver = new ChromeDriver();
            baseUrl = "https://buscacepinter.correios.com.br/app/endereco/index.php";

        }

        [TestMethod]
        public void ShearchCEP()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(baseUrl);
            driver.FindElement(By.Name("endereco")).SendKeys("69005-040");
            Thread.Sleep(2 * 1000);
            driver.FindElement(By.Name("btn_pesquisar")).Click();
            Thread.Sleep(5 * 1000);

            driver.Quit();

        }

        [TestMethod]
        public void ShearchBemolStore()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(baseUrl);
            driver.FindElement(By.Name("endereco")).SendKeys("Lojas Bemol");
            Thread.Sleep(2 * 1000);
            driver.FindElement(By.Name("btn_pesquisar")).Click();
            Thread.Sleep(5 * 1000);

            driver.Quit();

        }
    }
}
