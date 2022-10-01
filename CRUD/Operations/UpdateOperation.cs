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

        public void Update(int targetId, string firstName, string lastName)
        {
            User updatedUser = new User()
            {
                Id = targetId,
                FirstName = firstName,
                LastName = lastName
            };

            _client.Update($"Users/{targetId}", updatedUser);
        }
    }
}
