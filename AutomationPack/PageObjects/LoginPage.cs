namespace Com.Test.Mani.PageObjects
{
    using Com.Test.Mani.Helpers;
    using Com.Test.Mani.PageObjects;

    using OpenQA.Selenium;

    using SeleniumExtras.PageObjects;

     public class LoginPage : BasePage
    {
        private DriverFacade _driverFacade;
        private IWebDriver _driver;

        public LoginPage(DriverFacade driverFacade) :base(driverFacade)
        {
            _driverFacade = driverFacade;
            
        }

        [FindsBy(How = How.Id, Using = "email")]
        protected IWebElement UsernameTxtBox { get; set; }

        [FindsBy(How = How.Id, Using = "passwd")]
        protected IWebElement PasswordTxtBox { get; set; }

        [FindsBy(How = How.Id, Using = "Sign in")]
        protected IWebElement LoginBtn { get; set; }

        public void TypeName(string name)
        {
            UsernameTxtBox.SendKeys(name);
        }
        public void TypePassword(string password)
        {
            PasswordTxtBox.SendKeys(password);
        }
        public void ClickLoginButton()
        {
            LoginBtn.Click();
        }
     
        public void Login(string name, string password)
        {
            TypeName(name);
            TypePassword(password);
            ClickLoginButton();
        }
    }
}
