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

        public User Read(int targetId)
        {
            var targetUserData = _client.Get($"Users/{targetId}");
            User outputUser = targetUserData.ResultAs<User>();
            return outputUser;
        }
    }
}
