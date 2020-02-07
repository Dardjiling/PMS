using PMS.Framework.Models;
using PMS.Framework.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PMS.Framework.Services
{
    public class EntityService<T> : IEntityService<T> where T : BaseEntity
    {
        private readonly IEfRepository<T> _efRepository;

        public EntityService(IEfRepository<T> efRepository)
        {
            _efRepository = efRepository;
        }

        public async Task Create(T entity)
        {
            await _efRepository.Create(entity);
        }

        public Task Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
