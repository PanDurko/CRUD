using CRUD.Core;
using FireSharp.Interfaces;

namespace CRUD.Operations
{
    public class ReadOperation
    {
        private IFirebaseClient _client;

        public ReadOperation(IFirebaseClient client)
        {
            _client = client;
        }

        public User Read(int id)
        {
            var data = _client.Get($"Users/{id}");
            User user = data.ResultAs<User>();
            return user;
        }
    }
}
