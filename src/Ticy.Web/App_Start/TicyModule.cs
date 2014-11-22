using Autofac;
using Likja.DataAccess.Common;
using System.Data.Entity;
using Ticy.Api.Conthread;
using Ticy.DataAccess;
using Ticy.DataAccess.Conthread;

namespace Ticy.Web
{
    public class TicyModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // services
            builder.RegisterType<ConthreadService>().As<IConthreadService>();

            // repositories
            builder.RegisterType<ConthreadRepository>().As<IConthreadRepository>();

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();
            builder.RegisterType<TicyDb>().As<DbContext>();
        }
    }
}