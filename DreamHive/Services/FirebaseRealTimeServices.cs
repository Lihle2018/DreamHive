using DreamHive.Models;
using Firebase.Database;
using Firebase.Database.Query;

namespace DreamHive.Services
{
    public class FirebaseRealTimeServices
    {
       private  FirebaseClient firebase;
        public FirebaseRealTimeServices()
        {
            firebase = new FirebaseClient("https://dreamhive-33043-default-rtdb.firebaseio.com/");
        }
        public async Task<bool> AddSubscription(Subscription subscription)
        {
            var sub = await firebase.Child(nameof(Subscription))
                .PostAsync(subscription);
            if (sub != null)
                return true;
            return false;
        }
        public async Task<bool> SaveMessage(Contact message)
        {
            var _message = await firebase.Child("Messages")
                .PostAsync(message);
            if (_message != null)
                return true;
            return false;
        }
    }
}
