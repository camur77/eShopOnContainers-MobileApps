using eShopOnContainers.Core.Services.Settings;
using eShopOnContainers.Core.ViewModels;
using eShopOnContainers.Core.ViewModels.Base;
using eShopOnContainers.UnitTests.Mocks;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Firebase.Database;
using Newtonsoft.Json;

namespace eShopOnContainers.UnitTests.ViewModels
{
    public class ViewMLoginTest
    {
        [Fact]
        public void canLogintest()
        {
            _ = new LoginVM();

            string Email = "deneme";
            string Password = "deneme12";

            bool CanLogin()
            {
                return !string.IsNullOrEmpty(Email) && !string.IsNullOrEmpty(Password);
            }


            Assert.True(CanLogin());

        }


        [Fact]
        public void canRegistertest()
        {
            _ = new LoginVM();

            string Email = "deneme";
            string Password = "deneme12";
            string ConfirmPassword = "deneme12";
            string Name = "yavuz";

            bool CanLogin()
            {
                return !string.IsNullOrEmpty(Email) && !string.IsNullOrEmpty(Password) && !string.IsNullOrEmpty(ConfirmPassword) && !string.IsNullOrEmpty(Name);
            }


            Assert.True(CanLogin());

        }

        [Fact]
        public void confirmpasswordtest()
        {
            _ = new LoginVM();

            string confirmPassword = "dddd";
            string password = "dddd";

            if (confirmPassword != password)
            {
                Assert.NotSame(confirmPassword, password);
            }
            else
            {
                Assert.Same(confirmPassword, password);
            }
        }
    }
}
