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

        public void Create(int id, string firstName, string lastName)
        {
            User user = new User()
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName
            };

            _client.Set($"Users/{id}", user);
        }
    }
}
