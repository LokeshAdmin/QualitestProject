using System.Xml.Linq;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SpecFlowProjectForQT.StepDefinitions
{
    [Binding]
    public sealed class LoginStepDefinitions
    {
        private IWebDriver driver;
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        [Given(@"open the browser")]
        public void GivenOpenTheBrowser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
             
        }

        [When(@"Enter the URL")]
        public void WhenEnterTheURL()
        {
            driver.Url = "https://opensource-demo.orangehrmlive.com/web/index.php/auth/login";
            Thread.Sleep(5000);
           
        }

        [When(@"Enter the login Credentials")]
        public void WhenEnterTheLoginCredentials()
        {
            driver.FindElement(By.Name("username")).SendKeys("Admin");
            driver.FindElement(By.Name("password")).SendKeys("admin123");
            driver.FindElement(By.TagName("button")).Click();
            Thread.Sleep(5000);
        }

        [Then(@"user on home page")]
        public void ThenUserOnHomePage()
        {
            Boolean homePage= driver.FindElement(By.XPath("//p[@class='oxd-userdropdown-name']")).Displayed;
           

            if (homePage == true)
            {
                Console.WriteLine("on home page");
            }
            else {
                Console.WriteLine("Failed to launch the page");
            }
            driver.Quit();
            
        }

    }
}
