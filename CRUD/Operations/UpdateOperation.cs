using CRUD.Core;
using FireSharp.Interfaces;

namespace CRUD.Operations
{
    public class UpdateOperation
    {
        private IFirebaseClient _client;

        public UpdateOperation(IFirebaseClient client)
        {
            _client = client;
        }

        public void Update(int targetId, int newId, string firstName, string lastName)
        {
            User user = new User()
            {
                Id = newId,
                FirstName = firstName,
                LastName = lastName
            };

            _client.Delete($"Users/{targetId}");
            _client.Set($"Users/{newId}", user);
        }
    }
}
