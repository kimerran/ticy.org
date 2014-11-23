using System.Data.Entity;
using Ticy.Domain.Models;

namespace Ticy.DataAccess
{
    public class TicyDb : DbContext
    {
        public DbSet<CodeThread> Conthreads { get; set; }
        public DbSet<UserEntity> Users { get; set; }
        public TicyDb() : base("TicyDb") { }
    }
}
