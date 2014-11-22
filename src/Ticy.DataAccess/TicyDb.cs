using System.Data.Entity;
using Ticy.Domain.Models;

namespace Ticy.DataAccess
{
    public class TicyDb : DbContext
    {
        public DbSet<ConthreadEntity> Conthreads { get; set; }
        public TicyDb() : base("TicyDb") { }
    }
}
