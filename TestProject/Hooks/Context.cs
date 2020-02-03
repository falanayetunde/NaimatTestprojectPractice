using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace TestProject.Hooks
{
    public class Context
    {
        public IWebDriver driver;
        public string baseUrl = "http://automationpractice.com/index.php";

        public void LaunchAnApplication()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(baseUrl);
        }

        public void CloseAnApplication()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}
