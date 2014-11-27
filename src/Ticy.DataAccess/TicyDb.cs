using System.Data.Entity;
using Ticy.Domain.Models;

namespace Ticy.DataAccess
{
    public class TicyDb : DbContext
    {
        public DbSet<CodeThread> Conthreads { get; set; }
        public DbSet<Domain.Models.User> Users { get; set; }
        public TicyDb() : base("TicyDb") { }
    }
}
