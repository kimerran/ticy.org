using Autofac;
using Likja.Conthread;
using Likja.DataAccess.Common;
using System.Data.Entity;
using Ticy.DataAccess;
using Ticy.Domain.Models;

namespace Ticy.Web
{
    public class TicyModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // services
            builder.RegisterType<ConthreadService<CodeThread>>()
                .As<IConthreadService<CodeThread>>();

            // repositories
            builder.RegisterType<ConthreadRepository<CodeThread>>()
                .As<IConthreadRepository<CodeThread>>();

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();
            builder.RegisterType<TicyDb>().As<DbContext>();
        }
    }
}