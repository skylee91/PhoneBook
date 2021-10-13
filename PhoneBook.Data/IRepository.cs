using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Data
{
    public interface IRepository<TEntity>
    {
        TEntity Create(TEntity entity);

        IEnumerable<TEntity> GetAll();

        TEntity FindById(int id);

        bool Update(TEntity entity);

        bool Delete(int id);
    }
}
