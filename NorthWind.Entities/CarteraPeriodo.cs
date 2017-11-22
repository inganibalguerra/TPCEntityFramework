using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models.General
{
    public abstract class CarteraPeriodo
    {
        [Key]
        public long CarteraPeriodoId { get; set; }
   
        public int? PeriodoId { get; set; }
        public int? VigenciaId { get; set; }
        public int? PreiodoTributarioId { get; set; }
        public int? ClaseDeclaracionId { get; set; }
        public abstract List<CarteraConcepto> CarterasConceptos();

        public virtual long CarteraSujetoImpuestoId { get; }
    }

    public class CarteraPeriodoPredial : CarteraPeriodo
    {
        public long CarteraSujetoImpuestoPredialId { get; set; }
        public override long CarteraSujetoImpuestoId { get { return CarteraSujetoImpuestoPredialId; } }
        public CarteraPeriodoPredial()
        {
            CarterasConceptosPredial = new HashSet<CarteraConceptoPredial>();
        }
        public override List<CarteraConcepto> CarterasConceptos()
        {
                return CarterasConceptosPredial as List<CarteraConcepto>;
        }
        [ForeignKey("CarteraSujetoImpuestoPredialId")]
        public virtual CarteraSujetoImpuestoPredial CarteraSujetoImpuesto { get; set; }
        public virtual ICollection<CarteraConceptoPredial> CarterasConceptosPredial { get; set; }

    }
    public class CarteraPeriodoIca : CarteraPeriodo
    {
        public long CarteraSujetoImpuestoIcaId { get; set; }
        public override long CarteraSujetoImpuestoId { get { return CarteraSujetoImpuestoIcaId; } }
        public CarteraPeriodoIca()
        {
            CarterasConceptosIca = new HashSet<CarteraConceptoIca>();
        }
        public override List<CarteraConcepto> CarterasConceptos()
        {
            return CarterasConceptosIca as List<CarteraConcepto>;
        }
        [ForeignKey("CarteraSujetoImpuestoIcaId")]
        public virtual CarteraSujetoImpuestoIca CarteraSujetoImpuesto { get; set; }
        public virtual ICollection<CarteraConceptoIca> CarterasConceptosIca { get; set; }

    }
    public class CarteraPeriodoOtro : CarteraPeriodo
    {
        public long CarteraSujetoImpuestoOtroId { get; set; }
        public override long CarteraSujetoImpuestoId { get { return CarteraSujetoImpuestoOtroId; } }
        public CarteraPeriodoOtro()
        {
            CarterasConceptosOtro = new HashSet<CarteraConceptoOtro>();
        }
        public override List<CarteraConcepto> CarterasConceptos()
        {
            return CarterasConceptosOtro as List<CarteraConcepto>;
        }

        [ForeignKey("CarteraSujetoImpuestoOtroId")]
        public virtual CarteraSujetoImpuestoOtro CarteraSujetoImpuesto { get; set; }
        public virtual ICollection<CarteraConceptoOtro> CarterasConceptosOtro { get; set; }

    }
}