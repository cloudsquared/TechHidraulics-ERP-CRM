using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EServicio
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal CostoManoObra { get; set; }
    }

    public class EServicioArticulo
    {
        public int IdArticulo { get; set; }
        public decimal Cantidad { get; set; }
    }
}
