using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace facebooklogin
{
    [TestFixture]
    class test
    {
        IWebDriver wd;

        [OneTimeSetUp]
        public void setup()
        {
            var options = new ChromeOptions();
            options.AddArguments("--disable-notifications");

            wd = new ChromeDriver(options);
            wd.Manage().Window.Maximize();
        }

     
        public void OpenBrowser()
        {
            wd.Navigate().GoToUrl("https://www.facebook.com/");
             
        }

        [Obsolete]//case 4
        public void verifylogin()
        {
            OpenBrowser();
            var email = wd.FindElement(By.Id("email"));
            email.SendKeys("manis076@hotmail.com");
            var pwd = wd.FindElement(By.Id("pass"));
            pwd.SendKeys("Manishdeepika123");
        
            wd.FindElement(By.XPath("//*[@id='u_0_2']")).Click();
            

            Thread.Sleep(3000);
        }

        [Test]//case 13
        public void verifyfriendslist()
        {
          
           
            int expectedfriendslist = 678;
            verifylogin();
            Thread.Sleep(2000);

            wd.FindElement(By.XPath("//a[@title='Profile']")).Click();
            Thread.Sleep(2000);
            wd.FindElement(By.XPath("//a[@data-tab-key='friends']")).Click();
            Thread.Sleep(2000);

            bool loop = true;
            while (loop)
            {
                IJavaScriptExecutor js = (IJavaScriptExecutor)wd;
                js.ExecuteScript("window.scrollBy(0,1000)");
                try
                {
                    var more = wd.FindElement(By.XPath("//h3[text()='More About You']"));
                    if (more.Text != null)
                    {
                        loop = false;
                        break;
                    }
                }
                catch (NoSuchElementException e)
                {
                    loop = true;
                    Console.WriteLine(e);
                }
            }

            var nameElements = wd.FindElements(By.XPath("//div[@class='fsl fwb fcb']/a"));

            foreach (var nameElement in nameElements)
            {
                Console.WriteLine(nameElement.Text);
            }
            Assert.AreEqual(expectedfriendslist, nameElements.Count);
        }

        [OneTimeTearDown]
        public void Closebrowser()
        {
            wd.Quit();
        }

        
    }

}

    

