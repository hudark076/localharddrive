using NUnit.Framework;

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automationsumrows
{
    [TestFixture]
    class automationsumtest
    {
        IWebDriver wd;
        
        [OneTimeSetUp]
        public void Setup()
        {

            wd = new FirefoxDriver();
        }

        [Test,Order(1)]
        public void OpenBrowser()
        {
            wd.Navigate().GoToUrl("https://www.w3schools.com/sql/sql_count_avg_sum.asp");
        }

        [Test, Order(2)]
        public void Verifysumoftables()
        {
            OpenBrowser();
            var expectedsum = 90.35;
            double sum = 0.0;

            var tableROWS = wd.FindElements(By.XPath("//*[@id='main']/div[6]/table/tbody/tr/td[6]"));
            foreach (IWebElement row in tableROWS)
            {
                //double no = Convert.ToInt32(row.Text);
                double no = double.Parse(row.Text);
                sum = sum + no;
            }
            Assert.AreEqual(expectedsum, sum);
        }
        [OneTimeTearDown]
        public void CloseBrowser()
        {
            wd.Quit();
        }
    }
}
