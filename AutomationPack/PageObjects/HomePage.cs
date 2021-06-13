namespace Com.Test.Mani.PageObjects
{
    using System;

    using Com.Test.Mani.Helpers;

    using OpenQA.Selenium;

    using OpenQA.Selenium.Support.UI;

    using SeleniumExtras.PageObjects;

    public class HomePage 
    {
        private DriverFacade _driverFacade;

        private WebDriverWait wait;

        private IWebDriver driver;

       
        public HomePage(DriverFacade driverFacade) 
        {
            
            _driverFacade = driverFacade;

        }

       
        [FindsBy(How = How.XPath, Using = "//*[@id='search_query_top']")]
        protected IWebElement SearchElement { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='center_column']/ul/li/a/span")]
        protected IWebElement HomeElement { get; set; }

             
        public void IsHomeTabEnabled()
        {

            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(driver => !driver.FindElement(By.XPath("")).Displayed);
        }

        public void PlacesuccessfulOrder()
        {
            // Need to implement below functionality
            // SearchAndAddProduct(); 
            // CheckoutAndShippingDetails();
            // PaymentAndPlaceOrder();
            // GetAndStoreOrderId();
        }

        public void VerifyTheSuccessfulOrder(string orderId)
        {
            true.Equals(orderId);
        }

    }
}
