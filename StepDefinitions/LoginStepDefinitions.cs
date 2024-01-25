using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using System.Security.Policy;
using NUnit.Framework;

namespace My_First_spec_flow_project.StepDefinitions
{
    [Binding]
    public class Login
    {

        public IWebDriver driver;
        public WebDriverWait wait;
        string Url = "https://opensource-demo.orangehrmlive.com/web/index.php/auth/login";
        string Username = "Admin";
        string Password = "admin123";
        string Title = "OrangeHRM";

        [Given(@"\[The user have Valid URl,User Name and Password]")]
        public void GivenTheUserHaveValidURlUserNameAndPassword()
        {

        }

        [When(@"\[the user Enters URL in the the browser and redirects to the Login page]")]
        public void WhenTheUserEntersURLInTheTheBrowserAndRedirectsToTheLoginPage()
        {

            driver = new ChromeDriver();
            driver.Manage().Window.Minimize();
            driver.Navigate().GoToUrl(Url);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        [When(@"\[Enters the User Name and Password in the respective fields]")]
        public void WhenEntersTheUserNameAndPasswordInTheRespectiveFields()
        {
           
           wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//input[@name='username']")));
            driver.FindElement(By.XPath("//input[@name='username']")).SendKeys(Username);
            driver.FindElement(By.XPath("//input[@name='password']")).SendKeys(Password);
        }

        [When(@"\[clicking the Login Button]")]
        public void WhenClickingTheLoginButton()
        {
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
        }

        [Then(@"\[User should be able to see the Home Page]")]
        public void ThenUserShouldBeAbleToSeeTheHomePage()
        {
            string title = driver.Title;
            Console.WriteLine(title);
            Assert.AreEqual(title, Title);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(".oxd-brand-banner")));
            bool bannerisdisplayed = driver.FindElement(By.CssSelector(".oxd-brand-banner")).Displayed;
            Assert.IsTrue(bannerisdisplayed);
        }
    }
}
