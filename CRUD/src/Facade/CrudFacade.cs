using CRUD.Database;
using CRUD.Operations;
using FireSharp.Interfaces;

namespace CRUD.Facade
{
    public class CrudFacade
    {
        public CreateOperation CreateOperation { get; private set; }
        public ReadOperation ReadOperation { get; private set; }
        public UpdateOperation UpdateOperation { get; private set; }
        public DeleteOperation DeleteOperation { get; private set; }

        private DataBase _dataBase;
        private IFirebaseClient _client;

        public CrudFacade()
        {
            _dataBase = new DataBase();
            _client = _dataBase.GetClient();
        }

        public void Init()
        {
            CreateOperation = new CreateOperation(_client);
            ReadOperation = new ReadOperation(_client);
            UpdateOperation = new UpdateOperation(_client);
            DeleteOperation = new DeleteOperation(_client);
        }
    }
}
