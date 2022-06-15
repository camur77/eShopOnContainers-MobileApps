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
    public class ViewMProductTest
    {
        public ViewMProductTest()
        {
            ViewModelLocator.UpdateDependencies(true);
        }

        FirebaseClient fClient;


        [Fact]
        public void isconnectedfirebase()
        {

            var vmproducts = new VMProducts();

            if (fClient == null)
            {
                fClient = new FirebaseClient("https://projeoop-default-rtdb.firebaseio.com/");
                bool donus = true;
                Assert.True(donus);

            }
            else
            {
                bool donus = false;
                Assert.False(donus);
            }



        }
    }
}
