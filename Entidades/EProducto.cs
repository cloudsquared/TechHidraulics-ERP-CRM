using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EProducto
    {

        public int Id { get; set; }
        public string Codigo { get; set; }
        public int TipoProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal CostoManoObra { get; set; }
        public int UtilidadPorcentaje { get; set; }
        public decimal PrecioVenta { get; set; }
    }

    public class EProductoArticulo
    {
        public int IdArticulo { get; set; }
        public decimal Cantidad { get; set; }
    }
}
