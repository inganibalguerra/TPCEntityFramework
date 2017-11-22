using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models.General
{
    public abstract  class CarteraConcepto 
    {
        public long CarteraConceptoId { get; set; }

        public int? ConceptoId { get; set; }
        public int? VigenciaId { get; set; }
        public int? PreiodoTributarioId { get; set; }
        public int? ClaseDeclaracionId { get; set; }
        public string Nit { get; set; }
        public int Vigencia { get; set; }
        public int Periodo { get; set; }
        public virtual long CarteraPeriodoId { get; }
    }

    public class CarteraConceptoPredial : CarteraConcepto
    {
        public long CarteraPeriodoPredialId { get; set; }

        [ForeignKey("CarteraPeriodoPredialId")]
        public virtual CarteraPeriodoPredial CarteraPeriodo { get; set; }
    }

    public class CarteraConceptoIca : CarteraConcepto
    {
        public long CarteraPeriodoIcaId { get; set; }
        [ForeignKey("CarteraPeriodoIcaId")]
        public virtual CarteraPeriodoIca CarteraPeriodo { get; set; }
    }

    public class CarteraConceptoOtro : CarteraConcepto
    {
       public long CarteraPeriodoOtroId { get; set; }

       [ForeignKey("CarteraPeriodoOtroId")]
       public virtual CarteraPeriodoOtro CarteraPeriodo { get; set; }
    }
}