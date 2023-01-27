using Autofac;
using Bussiness.Abstract;
using Bussiness.Managers;
using DataAccess.Classlar;
using DataAccess.Interfaceler;

namespace Bussiness.DependencyResolvers
{
    public class AutoFacBussinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CustomerManager>().As<ICustomerService>();
            builder.RegisterType<EfCustomerDal>().As<ICustomerDal>();

        }
    }
}
