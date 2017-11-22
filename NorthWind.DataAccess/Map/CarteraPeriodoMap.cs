using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace DAL.Models.General.Map
{
    internal class CarteraPeriodoPredialMap : EntityTypeConfiguration<CarteraPeriodoPredial>
    {
     
        public CarteraPeriodoPredialMap()
        {
            Property(x => x.CarteraPeriodoId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            HasKey(x => x.CarteraPeriodoId);
            Map(x =>
            {
                x.MapInheritedProperties();
                x.ToTable("CarteraPeriodoPredial");
            });
        }
    }
    internal class CarteraPeriodoIcaMap : EntityTypeConfiguration<CarteraPeriodoIca>
    {
        public CarteraPeriodoIcaMap()
        {
            Property(x => x.CarteraPeriodoId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            HasKey(x => x.CarteraPeriodoId);
            Map(x =>
            {
                x.MapInheritedProperties();
                x.ToTable("CarteraPeriodoIca");
            });
        }
    }
    internal class CarteraPeriodoOtrosMap : EntityTypeConfiguration<CarteraPeriodoOtro>
    {
        public CarteraPeriodoOtrosMap()
        {
            Property(x => x.CarteraPeriodoId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            HasKey(x => x.CarteraPeriodoId);
            Map(x =>
            {
                x.MapInheritedProperties();
                x.ToTable("CarteraPeriodoOtros");
            });
        }
    }
}
