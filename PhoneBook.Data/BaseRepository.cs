using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Data
{
    public class BaseRepository<TEntity> : IRepository<TEntity>
    {
        //private readonly ILiteDatabase _database; //DI is not supported
        private readonly ILiteCollection<TEntity> _collection;
        private readonly string _connectionString = "PhoneBook.db";

        public BaseRepository()
        {
            var database = new LiteDatabase(_connectionString);
            _collection = database.GetCollection<TEntity>();
        }

        public TEntity Create(TEntity entity)
        {
            var newId = _collection.Insert(entity);
            return _collection.FindById(newId.AsInt32);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _collection.FindAll();
        }

        public TEntity FindById(int id)
        {
            return _collection.FindById(id);
        }

        public bool Update(TEntity entity)
        {
            return _collection.Update(entity);
        }

        public bool Delete(int id)
        {
            return _collection.Delete(id);
        }
       
    }
}
