using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using HeatLoss.Dal.Common.Entity;

namespace HeatLoss.Dal.EfImplementation.EF.Configuration
{
    public class RoomConfiguration : EntityTypeConfiguration<RoomLaying>
    {
        public RoomConfiguration()
        {
            ToTable("RoomBefore1994Coefficients");
            HasKey(k => k.Id);
            Property(p => p.Id).HasColumnName("Id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.D).HasColumnName("D").IsRequired();
            Property(p => p.Q35).HasColumnName("Q35");
            Property(p => p.Q85).HasColumnName("Q85");
            Property(p => p.Q185).HasColumnName("Q185");
            Property(p => p.Q285).HasColumnName("Q285");
            Property(p => p.Q385).HasColumnName("Q385");

        }
    }
}