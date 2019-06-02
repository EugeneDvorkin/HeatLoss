using System.Configuration;
using Autofac;
using HeatLoss.Dal.Common.IRepository;
using HeatLoss.Dal.Common.IRepository.Laying;
using HeatLoss.Dal.EfImplementation;
using HeatLoss.Dal.EfImplementation.EF;
using HeatLoss.Dal.EfImplementation.Repository;
using HeatLoss.Service.Common.IService;
using HeatLoss.Service.Implementation;

namespace DependencyResolver
{
    public static class Kernel
    {
        public static void Configure(ContainerBuilder builder)
        {
            builder.RegisterType<HeatLossContext>().WithParameter("connectionString", ConfigurationManager.ConnectionStrings["UserContext"].ConnectionString);
            //var context = new HeatLossContext(ConfigurationManager.ConnectionStrings["UserContext"].ConnectionString);
            builder.RegisterType<OvergroundCanalRepository>().As<IOvergroundCanalRepository>();
            builder.RegisterType<RoomRepository>().As<IRoomRepository>();
            builder.RegisterType<UndergroundRepository>().As<IUndergroundRepository>();
            builder.RegisterType<Logger>().As<ILogger>();
            builder.RegisterType<HeatLossCalculation>().As<IHeatLoosCalculation>();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();
        }
    }
}
