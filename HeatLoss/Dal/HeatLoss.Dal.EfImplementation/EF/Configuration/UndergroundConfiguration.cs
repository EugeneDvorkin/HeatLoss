using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using HeatLoss.Dal.Common.Entity.UndergroundLaying;

namespace HeatLoss.Dal.EfImplementation.EF.Configuration
{
    internal sealed class UndergroundConfiguration : EntityTypeConfiguration<UndergroundLaying>
    {
        public UndergroundConfiguration()
        {
            ToTable("UndergroundBefore1994Coefficients");
            HasKey(k => k.Id);
            Property(p => p.Id).HasColumnName("Id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Dp).HasColumnName("D_SteamLine").IsRequired();
            Property(p => p.Dk).HasColumnName("D_CondensateLine").IsRequired();
            Property(p => p.Qk).HasColumnName("Q_cl");
            Property(p => p.Q110).HasColumnName("Q110");
            Property(p => p.Q145).HasColumnName("Q145");
            Property(p => p.Q195).HasColumnName("Q195");
            Property(p => p.Q245).HasColumnName("Q245");
            Property(p => p.Q295).HasColumnName("Q295");
            Property(p => p.Q345).HasColumnName("Q345");
            Property(p => p.Q395).HasColumnName("Q395");
            Property(p => p.Q445).HasColumnName("Q445");
        }
    }
}