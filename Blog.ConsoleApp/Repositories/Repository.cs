using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace Blog.ConsoleApp.Repositories
{
    public abstract class Repository<T> where T : class
    {
        private readonly SqlConnection _connection;

        public Repository(SqlConnection connection) => _connection = connection;

        public T Get(int id) => _connection.Get<T>(id);

        public IEnumerable<T> Get() => _connection.GetAll<T>();

        public void Create(T model) => _connection.Insert(model);

        public void Update(T model) => _connection.Update(model);

        public void Delete(T model) => _connection.Delete(model);

        public void Delete(int id)
        {
            if (id == 0)
                return;

            var model = _connection.Get<T>(id);
            _connection.Delete(model);
        }
    }
}
