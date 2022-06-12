using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using eShopOnContainers.Core.Models;
using eShopOnContainers.Core.ViewModels.Helpers;
using Java.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopOnContainers.Droid.Dependencies
{
    class Firestore : IFirestore
    {
        public Task<bool> DeleteSubscription(Subscription subscription)
        {
            throw new NotImplementedException();
        }

        public bool InsertSubscription(Subscription subscription)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Subscription>> ReadSubscription()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateSubscription(Subscription subscription)
        {
            throw new NotImplementedException();
        }

       
    }
}