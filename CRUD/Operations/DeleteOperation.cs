using FireSharp.Interfaces;

namespace CRUD.Operations
{
    public class DeleteOperation
    {
        private IFirebaseClient _client;

        public DeleteOperation(IFirebaseClient client)
        {
            _client = client;
        }

        public void Delete(int id)
        {
            _client.Delete($"Users/{id}");
        }
    }
}
