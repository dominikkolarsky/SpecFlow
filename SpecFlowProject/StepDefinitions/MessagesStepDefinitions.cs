using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject.StepDefinitions {
    [Binding]
    public class MessagesStepDefinitions {
        IWebDriver? driver;
        IWebElement? linkMessages;
        private IWebElement? tbName;
        private IWebElement? tbContent;
        private IWebElement? tbEmail;
        private IWebElement? buttonCreate;
        private IWebElement? succesInfoLabel;
        private IWebElement? messageNumberLabel;

        [BeforeScenario]
        public void Before() {
            driver = new ChromeDriver();
        }


        [Given(@"I Have opened the website")]
        public void GivenIHaveOpenedTheWebsite() {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://certicon-testing.azurewebsites.net/");
            linkMessages = driver.FindElement(By.LinkText("Messages"));
            linkMessages.Click();
        }

        [Given(@"I have entered a name")]
        public void GivenIHaveEnteredAName() {
            tbName = driver.FindElement(By.Id("Name"));
            tbName.SendKeys("Karel");
        }

        [Given(@"I have entered a correct email")]
        public void GivenIHaveEnteredACorrectEmail() {
            tbEmail = driver.FindElement(By.Id("Email"));
            tbEmail.SendKeys("Karel@mail.com");
        }

        [Given(@"I have entered some message")]
        public void GivenIHaveEnteredSomeMessage() {
            tbContent = driver.FindElement(By.Id("Content"));
            tbContent.SendKeys("Just another test fellas.");
        }

        [When(@"I click the Creat button")]
        public void WhenIClickTheCreatButton() {
            buttonCreate = driver.FindElement(By.Id("buttonCreate"));
            buttonCreate.Click();
        }

        [Then(@"The success message should be displayed")]
        public void ThenTheSuccessMessageShouldBeDisplayed() {
            succesInfoLabel = driver.FindElement(By.Id("success"));
            Assert.AreEqual("The message has been saved", succesInfoLabel.Text);
            messageNumberLabel = driver.FindElement(By.Id("messageNumber"));
            Assert.AreEqual("You have 1 messages", messageNumberLabel.Text);
        }

        [AfterScenario]
        public void CleanUp() {
            driver.Close();
        }
    }
}
