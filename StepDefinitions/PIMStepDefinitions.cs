using My_First_spec_flow_project.StepDefinitions;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Security.Policy;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class PIMStepDefinitions
    {
        public  IWebDriver driver;
        public WebDriverWait wait;
        string Url = "https://opensource-demo.orangehrmlive.com/web/index.php/auth/login";
        string PIM_Exp_Title = "PIM";
        string Perform_Exp_Title = "Performance\r\nManage Reviews";
        string Time_Exp_Title = "Time\r\nTimesheets";
        string Leave_Exp_Title = "Leave";
        string Username = "Admin";
        string Password = "admin123";
        string Title = "OrangeHRM";
        [Given(@"\[the User is on Home Page ]")]
        public void GivenTheUserIsOnHomePage()  // This is give in the back ground key word so it will be executed before each scenario
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Minimize();
            driver.Navigate().GoToUrl(Url);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//input[@name='username']")));
            driver.FindElement(By.XPath("//input[@name='username']")).SendKeys(Username);
            driver.FindElement(By.XPath("//input[@name='password']")).SendKeys(Password);
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();

        }

        [When(@"\[Clicking the PIM Module from the side Menu ]")]
        public void WhenClickingThePIMModuleFromTheSideMenu()
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//ul[@class='oxd-main-menu']//li[2]")));
            driver.FindElement(By.XPath("//ul[@class='oxd-main-menu']//li[2]")).Click();
        }

        [Then(@"\[PIM Module page should be Displayed]")]
        public void ThenPIMModulePageShouldBeDisplayed()
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@class='oxd-topbar-header-title']")));

            string PIM_Act_title = driver.FindElement(By.XPath("//*[@class='oxd-topbar-header-title']")).Text;
            Assert.AreEqual(PIM_Exp_Title, PIM_Act_title);
        }
      

        [When(@"\[Clicking the Performance Module from the side Menu ]")]
        public void WhenClickingThePerformanceModuleFromTheSideMenu()
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//ul[@class='oxd-main-menu']//li[7]")));
            driver.FindElement(By.XPath("//ul[@class='oxd-main-menu']//li[7]")).Click();
        }


        [Then(@"\[Performance Module page should be Displayed]")]
        public void ThenPerformanceModulePageShouldBeDisplayed()
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@class='oxd-topbar-header-title']")));
            string Perform_Act_title = driver.FindElement(By.XPath("//*[@class='oxd-topbar-header-title']")).Text;
            Assert.AreEqual(Perform_Exp_Title, Perform_Act_title);
        }
        [When(@"\[Clicking the Leave Module from the side Menu ]")]
        public void WhenClickingTheLeaveModuleFromTheSideMenu()
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//ul[@class='oxd-main-menu']//li[3]")));
            driver.FindElement(By.XPath("//ul[@class='oxd-main-menu']//li[3]")).Click();
        }

        [Then(@"\[Leave Module page should be Displayed]")]
        public void ThenLeaveModulePageShouldBeDisplayed()
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@class='oxd-topbar-header-title']")));
            string Leave_Act_title = driver.FindElement(By.XPath("//*[@class='oxd-topbar-header-title']")).Text;
            Assert.AreEqual(Leave_Exp_Title, Leave_Act_title);
        }
        [When(@"\[Clicking the Time Module from the side Menu ]")]
        public void WhenClickingTheTimeModuleFromTheSideMenu()
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//ul[@class='oxd-main-menu']//li[4]")));
            driver.FindElement(By.XPath("//ul[@class='oxd-main-menu']//li[4]")).Click();
        }

        [Then(@"\[Time Module page should be Displayed]")]
        public void ThenTimeModulePageShouldBeDisplayed()
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@class='oxd-topbar-header-title']")));
            string Time_Act_title3 = driver.FindElement(By.XPath("//*[@class='oxd-topbar-header-title']")).Text;
            Assert.AreEqual(Time_Exp_Title, Time_Act_title3);
        }



    }
}
