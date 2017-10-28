using DAL.Interfaces;
using DAL.Repositories;
using Ninject.Modules;

namespace BLL.Infrastructure
{
    public class ServiceModule:NinjectModule
    {
        private string connectionString;

        public ServiceModule(string conString)
        {
            connectionString = conString;
        }
        public override void Load()
        {
            Bind<IUnitOfWork>().To<UnitOfWork>().WithConstructorArgument(connectionString);
        }
    }
}
