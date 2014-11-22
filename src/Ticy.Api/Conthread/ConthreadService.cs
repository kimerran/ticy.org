using System.Collections.Generic;
using Ticy.DataAccess.Conthread;
using Ticy.Domain.Models;

namespace Ticy.Api.Conthread
{
    public class ConthreadService : IConthreadService
    {
        private IConthreadRepository _conthreadRepository;

        public ConthreadService(IConthreadRepository conthreadRepository)
        {
            _conthreadRepository = conthreadRepository;
        }

        public IEnumerable<ConthreadEntity> GetAll()
        {
            return _conthreadRepository.FindAll();
        }

        public ConthreadEntity GetById(int id)
        {
            return _conthreadRepository.FindById(id);
        }

        public int Save(ConthreadEntity entity)
        {
           return _conthreadRepository.Add(entity);
        }
    }
}
