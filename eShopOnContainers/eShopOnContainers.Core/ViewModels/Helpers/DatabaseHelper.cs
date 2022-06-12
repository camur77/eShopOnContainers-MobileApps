using eShopOnContainers.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopOnContainers.Core.ViewModels.Helpers
{

    public interface IFirestore
    {
        bool InsertSubscription(Subscription subscription);
        Task<bool> DeleteSubscription(Subscription subscription);
        Task<bool> UpdateSubscription(Subscription subscription);
        Task<IList<Subscription>> ReadSubscription();
    }
    public class DatabaseHelper
    {
        
        private static IFirestore firestore;

        public bool InsertSubscription(Subscription subscription)
        {
            return firestore.InsertSubscription(subscription);
        }

        public Task<bool> DeleteSubscription(Subscription subscription)
        {
            return firestore.DeleteSubscription(subscription);
        }

        public Task<bool> UpdateSubscription(Subscription subscription)
        {
            return firestore.UpdateSubscription(subscription);
        }

        public Task<IList<Subscription>> ReadSubscription()
        {
            return firestore.ReadSubscription();
        }
    }
    
}
