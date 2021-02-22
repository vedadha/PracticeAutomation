
using System;

namespace ThisIsMyWebSite
{
    public static class Config
    {
        public static string baseURL = "http://automationpractice.com/index.php";

        public static string alertMessage = "Added to your wishlist.";

        public static string alertMessageInvalidUser = "User Id should not be empty / length be between 5 to 12";
        public static string alertMessageInvalidPassword = "Password should not be empty / length be between 5 to 12";

        public static string lightGreen = "rgba(144, 238, 144, 1)";

        public static class Credidentials
        {
            public static class Valid
            {
                public static string userName= "Test1234@test.com";
                public static string password= "Test123$";
                public static string repeatPassword= "Test123$";
            }

            public static class UserInformations
            {
                public static string FirstName = "Test";
                public static string LastName = "Test";
                public static string Email = "Test@Test.com";
                public static string Password = "Test123$";
                public static string Address = "Test";
                public static string City = "Test";
                public static string PostalCode = "00000";
                public static string Mobile = "085465512";
                public static string AddressAlias = "test";
            }

            public static string newEmail()
            {
                Random randNumb = new Random();
                string email = "example" + randNumb.Next(1000) + "@example.com";
                return email;
            }


            public static class Invalid
            {
                public static string invalidEmail = "invalidEmail@email.com";
                public static string invalidPassword = "invalidPassword";

            }
            
            
        }

    }
}
