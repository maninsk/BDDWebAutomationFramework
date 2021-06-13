namespace Com.Test.Mani.StepDefinition
{

    using TechTalk.SpecFlow;
    using Com.Test.Mani.Helpers;


    [Binding]
    public class MyaccountSteps
    {
        private DriverFacade _driverFacade;
        private Pages _pages;
        private Logger _logger;

        public MyaccountSteps(Pages pages, DriverFacade driverFacade)
        {
            _driverFacade = driverFacade;
            _pages = pages;
            _logger = new Logger();
        }

        [When(@"the user update (.*)")]
        public void WhenTheUserUpdateMani(string firstName)
        {
            _pages.MyAccountPage.UpdateFirstName(firstName);
            
        }
        
        [Then(@"the (.*) should be updated in myaccount")]
        public void ThenTheManiShouldBeUpdatedInMyaccount(string firstName)
        {
            _pages.MyAccountPage.VerifySave();
        }
    }
}
