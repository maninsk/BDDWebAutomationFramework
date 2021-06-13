
using TechTalk.SpecFlow;
using Com.Test.Mani.Helpers;

namespace Com.Test.Mani.StepDefinition
{
    [Binding]
    public class OrderHistorySteps
    {
        private DriverFacade _driverFacade;
        private Pages _pages;
        private Logger _logger;

        public OrderHistorySteps(Pages pages, DriverFacade driverFacade)
        {
            _driverFacade = driverFacade;
            _pages = pages;
            _logger = new Logger();
        }

        [When(@"the product (.*) order placed sucessfully")]
        public void WhenTheProductT_ShirtOrderPlacedSucessfully(string item)
        {
            _pages.HomePage.PlacesuccessfulOrder();

        }
        
        [Then(@"the oder (.*) should be available in orderhistory and details")]
        public void ThenTheOderT_ShirtShouldBeAvailableInOrderhistoryAndDetails(string item)
        {
            _pages.HomePage.VerifyTheSuccessfulOrder(item);
        }
    }
}
