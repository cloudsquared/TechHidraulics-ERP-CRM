using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EArticulo
    {
       
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal CantidadExistencia { get; set; }
        public decimal CantidadMinima { get; set; }
        public decimal Precio { get; set; }
        public int Estatus { get; set; }
        public int TipoUnidad { get; set; }
        public int Categoria { get; set; }
        public int Subcategoria { get; set; }
        public string Marca { get; set; }
        public string Codigo { get; set; }
        public int ProductoRelacionado { get; set; }
    }
}
