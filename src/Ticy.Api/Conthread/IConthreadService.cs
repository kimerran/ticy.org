using System.Collections.Generic;
using Ticy.Domain.Models;

namespace Ticy.Api.Conthread
{
    public interface IConthreadService
    {
        IEnumerable<ConthreadEntity> GetAll();
        ConthreadEntity GetById(int id);
        int Save(ConthreadEntity entity);
    }
}
