using Ninject.Modules;
using ThreeTierArchitecture.DAL.Interfaces;
using ThreeTierArchitecture.DAL.Repositories;

namespace ThreeTierArchitecture.BLL.Infrastructure
{
    public class ServiceModule : NinjectModule
    {
        private string connectionString;
        public ServiceModule(string connection)
        {
            connectionString = connection;
        }
        public override void Load()
        {
            Bind<IUnitOfWork>().To<EFUnitOfWork>().WithConstructorArgument(connectionString);
        }
    }
}
