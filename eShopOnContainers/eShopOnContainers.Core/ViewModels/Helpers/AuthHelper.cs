using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace eShopOnContainers.Core.ViewModels.Helpers
{
    public interface Iauth
    {
        Task<bool> RegisterUser(string name, string email, string password);
        Task<bool> AuthenticateUser(string email, string password);
        bool IsAuthenticated();
        string GetCurrentUserId();
    }

    public class Auth
    {

        private static Iauth auth = DependencyService.Get<Iauth>();

        public static async Task<bool> RegisterUser(string name, string email, string password)
        {
              return await auth.RegisterUser(name,email,password);
        }

    public static async Task<bool> AuthenticateUser( string email, string password)
        {
              return await auth.AuthenticateUser(email,password);
        }

        public static bool IsAuthenticated()
        {
            return auth.IsAuthenticated();
        }
        public static string GetCurrentUserUd()
        {
            return auth.GetCurrentUserId();
        }
    }
}
