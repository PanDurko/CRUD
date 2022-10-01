﻿using CRUD.Core;
using CRUD.Database;
using FireSharp;
using FireSharp.Interfaces;

namespace CRUD.Crud
{
    public class CrudOperations
    {
        private DataBase _dataBase;
        private IFirebaseClient _client;

        public CrudOperations()
        {
            _dataBase = new DataBase();
            _client = _dataBase.GetClient();
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

        public User Read(int id)
        {
            var data = _client.Get($"Users/{id}");
            User user = data.ResultAs<User>();
            return user;
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

        public void Delete(int id)
        {
            _client.Delete($"Users/{id}");
        }
    }
}
