using CRUD.Core;
using FireSharp.Interfaces;

namespace CRUD.Operations
{
    public class CreateOperation
    {
        private IFirebaseClient _client; 

        public CreateOperation(IFirebaseClient client)
        {
            _client = client;
        }

        public void Create(int targetId, string firstName, string lastName)
        {
            User newUser = new User()
            {
                FirstName = firstName,
                LastName = lastName
            };

            _client.Set($"Users/{targetId}", newUser);
        }
    }
}
