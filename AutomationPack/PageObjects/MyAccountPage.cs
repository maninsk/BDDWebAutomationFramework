namespace Com.Test.Mani.PageObjects
{
    using Com.Test.Mani.Helpers;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;
    using SeleniumExtras.PageObjects;

    public class MyAccountPage
    {
        private DriverFacade _driverFacade;

        private WebDriverWait wait;

        private IWebDriver driver;


        public MyAccountPage(DriverFacade driverFacade)
        {

            _driverFacade = driverFacade;

        }


        [FindsBy(How = How.XPath, Using = "//*[@id='center_column']/div/div[1]/ul/li[1]/a/span")]
        protected IWebElement OrderHistoryAndDetailsBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='center_column']/div/div[1]/ul/li[4]/a/span")]
        protected IWebElement MyPersonalInformationBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "")]
        protected IWebElement FirstNameTxtBox { get; set; }

        [FindsBy(How = How.XPath, Using = "")]
        protected IWebElement SaveBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "")]
        protected IWebElement SaveSuccessfullMsg { get; set; }

        public void OrderHistoryAndDetailsButton()
        {
            OrderHistoryAndDetailsBtn.Click();
        }

        public void MyPersonalInformationButton()
        {
            MyPersonalInformationBtn.Click();
        }

        public void ClickOnSaveButton()
        {
            SaveBtn.Click();
        }

        public void UpdateFirstName(string name)
        {
            MyPersonalInformationButton();
            EnterFirstName(name);
            ClickOnSaveButton();
        }

        public void VerifySave()
        {
            true.Equals(SaveSuccessfullMsg);
        }

        public void EnterFirstName(string name)
        {
            FirstNameTxtBox.SendKeys(name);
        }
    }
}
