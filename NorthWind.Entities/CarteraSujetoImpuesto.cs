using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models.General
{
    public abstract class CarteraSujetoImpuesto 
    {
        [Key]
        public long CarteraSujetoImpuestoId { get; set; }
        public int? ClaseDeclaracionId { get; set; }
        public string Nit { get; set; }

        public abstract List<CarteraPeriodo> CarterasPeriodos();
    }

    public class CarteraSujetoImpuestoPredial: CarteraSujetoImpuesto
    {
        public override List<CarteraPeriodo> CarterasPeriodos()
        {
                return CarterasPeriodosPredial as List<CarteraPeriodo>;
        }
        public CarteraSujetoImpuestoPredial()
        {
            CarterasPeriodosPredial = new HashSet<CarteraPeriodoPredial>();
        }
        public virtual ICollection<CarteraPeriodoPredial> CarterasPeriodosPredial { get; set; }
    }

    public class CarteraSujetoImpuestoIca : CarteraSujetoImpuesto
    {
        public override List<CarteraPeriodo> CarterasPeriodos()
        {
            return CarterasPeriodosIca as List<CarteraPeriodo>;
        }
        public CarteraSujetoImpuestoIca()
        {
            CarterasPeriodosIca = new HashSet<CarteraPeriodoIca>();
        }
        public virtual ICollection<CarteraPeriodoIca> CarterasPeriodosIca { get; set; }
    }
    public class CarteraSujetoImpuestoOtro : CarteraSujetoImpuesto
    {
        public override List<CarteraPeriodo> CarterasPeriodos()
        {
            return CarterasPeriodosOtro as List<CarteraPeriodo>;
        }
        public CarteraSujetoImpuestoOtro()
        {
            CarterasPeriodosOtro = new HashSet<CarteraPeriodoOtro>();
        }
        public virtual ICollection<CarteraPeriodoOtro> CarterasPeriodosOtro { get; set; }
    }

}