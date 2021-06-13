namespace AutomationPack.core.web.acceptancetest
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class TestData
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public TestData()
        {
            FirstName = "Test";
            LastName = "Test@123";
            Email = "Test@gmail.com";
        }
    }
}
