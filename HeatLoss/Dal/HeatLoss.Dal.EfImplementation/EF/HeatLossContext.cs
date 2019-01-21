using System.Data.Entity;
using System.Reflection;
using HeatLoss.Dal.Common.Entity.OvergroundLaying.CanalLaying;
using HeatLoss.Dal.Common.Entity.UndergroundLaying;

namespace HeatLoss.Dal.EfImplementation.EF
{
    public class HeatLossContext : DbContext
    {
        public HeatLossContext(string connectionString) : base(connectionString)
        {
            Database.SetInitializer(new HeatLossInitializer());
        }

        public virtual DbSet<UndergroundLaying> UndergroundLaying { get; set; }
        public virtual DbSet<OvergroundCanalLaying> OvergroundCanalLaying { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }
    }
}