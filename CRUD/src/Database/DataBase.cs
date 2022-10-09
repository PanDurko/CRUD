using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp;

namespace CRUD.Database
{
    public class DataBase
    {
        private IFirebaseConfig _config;
        private IFirebaseClient _client;

        public DataBase()
        {
            _config = new FirebaseConfig()
            {
                AuthSecret = "YDxzaYAzEPbXK6VbZOmoXdweheeExpbfeVBvppJJ",
                BasePath = "https://crud-f45e1-default-rtdb.firebaseio.com/"
            };

            _client = new FirebaseClient(_config);
        }

        public IFirebaseClient GetClient()
        {
            return _client; 
        }
    }
}
