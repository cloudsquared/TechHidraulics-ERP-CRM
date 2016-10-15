
using System;

namespace Entidades
{
   public class EOrdenServicio
    {
        public int Id { get; set; }
        public int NumeroOrden { get; set; }
        public DateTime FechaElaboracion { get; set; }
        public DateTime? FechaAprobacion { get; set; }
        public DateTime? FechaCompromiso { get; set; }
        public string Concepto { get; set; }
        public int AutorOrder { get; set; }
        public int Responsable { get; set; }
        public int? Vehiculo { get; set; }
        public int DiasCredito { get; set; }
        public int Estatus { get; set; }
        public decimal Utilidad { get; set; }
        public int Cliente { get; set; }
    }
}
