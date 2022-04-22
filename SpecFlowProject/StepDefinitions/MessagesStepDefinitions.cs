using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public class MessagesStepDefinitions
    {
        IWebDriver? driver;
        IWebElement? linkMessages;

        [Given(@"I Have opened the website")]
        public void GivenIHaveOpenedTheWebsite()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://certicon-testing.azurewebsites.net/");
            linkMessages = driver.FindElement(By.LinkText("Messages"));
            linkMessages.Click();
        }

        [Given(@"I have entered a name")]
        public void GivenIHaveEnteredAName()
        {
            throw new PendingStepException();
        }

        [Given(@"I have entered a correct email")]
        public void GivenIHaveEnteredACorrectEmail()
        {
            throw new PendingStepException();
        }

        [Given(@"I have entered some message")]
        public void GivenIHaveEnteredSomeMessage()
        {
            throw new PendingStepException();
        }

        [When(@"I click the Creat button")]
        public void WhenIClickTheCreatButton()
        {
            throw new PendingStepException();
        }

        [Then(@"The success message should be displayed")]
        public void ThenTheSuccessMessageShouldBeDisplayed()
        {
            throw new PendingStepException();
        }
    }
}
