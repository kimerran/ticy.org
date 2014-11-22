using Likja.DataAccess.Common;
using Ticy.Domain.Models;

namespace Ticy.DataAccess.Conthread
{
    public class ConthreadRepository : BaseRepository<ConthreadEntity>, IConthreadRepository
    {
        private IUnitOfWork _uow;
        public ConthreadRepository(IUnitOfWork uow) : base(uow)
        {
            _uow = uow;
        }
    }
}
