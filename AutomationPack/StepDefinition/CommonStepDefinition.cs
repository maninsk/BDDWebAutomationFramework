namespace Com.Test.Mani.StepDefinition
{

    using Com.Test.Mani.Helpers;
    using Com.Test.Mani.PageObjects;
    

    using TechTalk.SpecFlow;

    [Binding]
    public sealed class CommonStepDefinition
    {
        private DriverFacade _driverFacade;

        private Pages _pages;

        private Logger _logger;

        public CommonStepDefinition(Pages page)
        {
            _pages = page;
        }

        [BeforeScenario]
        public void Before()
        {
            _driverFacade = new DriverFacade();
            _pages.SignUpPage = new SignUpPage(_driverFacade);
            _pages.LoginPage = new LoginPage(_driverFacade);
            _pages.HomePage = new HomePage(_driverFacade);
        }

        [Given(@"the user successfully logged in with valid (.*) and (.*)")]
        public void GivenTheRegisteredUserWithValid(string username, string password)
        {
            _pages.LoginPage.GoToSite();
            _pages.LoginPage.Login(username, password);
            _pages.LoginPage.ClickLoginButton();
            _logger.Info("Login button clicked successfully");
            _pages.HomePage.IsHomeTabEnabled();

        }

        [AfterScenario()]
        public void After()
        {
            if (_driverFacade != null)
            {
                _driverFacade.Quit();
            }
        }
    }
}
