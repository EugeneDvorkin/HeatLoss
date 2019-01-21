using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using HeatLoss.Dal.Common.Entity.OvergroundLaying.CanalLaying;

namespace HeatLoss.Dal.EfImplementation.EF.Configuration
{
    public class OvergroundCanalConfiguration: EntityTypeConfiguration<OvergroundCanalLaying>
    {
        public OvergroundCanalConfiguration()
        {
            ToTable("OvergroundCanalBefore1994Coefficients");
            HasKey(k => k.Id);
            Property(p => p.Id).HasColumnName("Id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.D).HasColumnName("D").IsRequired();
            Property(p => p.Q10).HasColumnName("Q10");
            Property(p => p.Q60).HasColumnName("Q60");
            Property(p => p.Q160).HasColumnName("Q195");
            Property(p => p.Q260).HasColumnName("Q260");
            Property(p => p.Q360).HasColumnName("Q360");
        }
    }
}