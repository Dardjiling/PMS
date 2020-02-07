using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PMS.Framework.Services
{
    public interface IEntityService<T>
    {
        Task Create(T entity);
        Task Update(T entity);
        Task<T> GetById(int id);
        Task Delete(T entity);
    }
}
