
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

        [When(@"the product (.*) order placed successfully")]
        public void WhenTheProductT_ShirtOrderPlacedSuccessfully(string item)
        {
            _pages.HomePage.PlacesuccessfulOrder();

        }
        
        [Then(@"the order (.*) should be available in order history and details")]
        public void ThenTheOderT_ShirtShouldBeAvailableInOrderhistoryAndDetails(string item)
        {
            _pages.HomePage.VerifyTheSuccessfulOrder(item);
        }
    }
}
