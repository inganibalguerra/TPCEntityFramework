using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace DAL.Models.General.Map
{
    internal class CarteraConceptoPredialMap : EntityTypeConfiguration<CarteraConceptoPredial>
    {
        public CarteraConceptoPredialMap()
        {
            Property(x => x.CarteraConceptoId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            HasKey(x => x.CarteraConceptoId);
            Map(x =>
            {
                x.MapInheritedProperties();
                x.ToTable("CarteraConceptoPredial");
            });
        }
    }
    internal class CarteraConceptoIcaMap : EntityTypeConfiguration<CarteraConceptoIca>
    {
        public CarteraConceptoIcaMap()
        {
            Property(x => x.CarteraConceptoId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            HasKey(x => x.CarteraConceptoId);
            Map(x =>
            {   
                x.MapInheritedProperties();
                x.ToTable("CarteraConceptoIca");
            });
        }
    }
    internal class CarteraConceptoOtrosMap : EntityTypeConfiguration<CarteraConceptoOtro>
    {
        public CarteraConceptoOtrosMap()
        {
            Property(x => x.CarteraConceptoId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            HasKey(x => x.CarteraConceptoId);
            Map(x =>
            {
                x.MapInheritedProperties();
                x.ToTable("CarteraConceptoOtro");

            });
        }
    }
}
