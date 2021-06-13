namespace Com.Test.Mani.PageObjects
{
    using System.Configuration;

    using Com.Test.Mani.Helpers;

    using OpenQA.Selenium;

    using SeleniumExtras.PageObjects;
    public class SignUpPage
    {
        private DriverFacade _driverFacade;

        private IWebDriver _driver;

        public  SignUpPage(DriverFacade driverFacade)
        {
            _driverFacade = driverFacade;
        }
    }
}
