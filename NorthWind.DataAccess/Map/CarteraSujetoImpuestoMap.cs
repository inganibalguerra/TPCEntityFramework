using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace DAL.Models.General.Map
{
    internal class CarteraSujetoImpuestoPredialMap : EntityTypeConfiguration<CarteraSujetoImpuestoPredial>
    {
        public CarteraSujetoImpuestoPredialMap()
        {
            Property(x => x.CarteraSujetoImpuestoId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            HasKey(x => x.CarteraSujetoImpuestoId);
            Map(x =>
            {
                x.MapInheritedProperties();
                x.ToTable("CarteraSujetoImpuestoPredial");
            });
        }
    }
    internal class CarteraSujetoImpuestoIcaMap : EntityTypeConfiguration<CarteraSujetoImpuestoIca>
    {
        public CarteraSujetoImpuestoIcaMap()
        {
            Property(x => x.CarteraSujetoImpuestoId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            HasKey(x => x.CarteraSujetoImpuestoId);
            Map(x =>
            {
                x.MapInheritedProperties();
                x.ToTable("CarteraSujetoImpuestoIca");
            });
        }
    }
    internal class CarteraSujetoImpuestoOtroMap : EntityTypeConfiguration<CarteraSujetoImpuestoOtro>
    {
        public CarteraSujetoImpuestoOtroMap()
        {
            Property(x => x.CarteraSujetoImpuestoId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            HasKey(x => x.CarteraSujetoImpuestoId);
            Map(x =>
            {
                x.MapInheritedProperties();
                x.ToTable("CarteraSujetoImpuestoOtro");
            });
        }
    }
}
