using System;
using System.Text;
using System.Data;
using Datos.Funciones_Generales;
using Entidades;

namespace Negocio.Entidades
{
   public class NegArticulo
    {
        public readonly StringBuilder StringBuilder = new StringBuilder();
        private readonly Articulo  _articuloDatos = new Articulo();

        public void Registrar(EArticulo producto)
        {
            StringBuilder.Clear();
            if (!ValidarProducto(producto)) return;
            if ( producto.Id <= 0)
            {
                _articuloDatos.Insertar(producto);
            }
            else
                _articuloDatos.Actualizar(producto);
            
        }

        public EArticulo TraerPorId(int idArticulo)
        {
            StringBuilder.Clear();

            if (idArticulo <0) StringBuilder.Append("Por favor proporcione un valor de Id valido");

            return StringBuilder.Length == 0 ?(EArticulo)_articuloDatos.ObtenerPorId(idArticulo) : null;
        }


        public DataTable Registros()
        {
            return _articuloDatos.ObtenerLista();
        }
        public DataTable Registros_Vista()
        {
            return _articuloDatos.ObtenerVista();
        }


        public void Eliminar(int idArticulo)
        {
            StringBuilder.Clear();

            if (idArticulo == 0) StringBuilder.Append("Por favor proporcione un valor de Id valido");

            if (StringBuilder.Length == 0)
            {
                _articuloDatos.Eliminar(idArticulo);
            }
        }



        private bool ValidarProducto(EArticulo articulo)
        {
            StringBuilder.Clear();
            if (string.IsNullOrEmpty(articulo.Nombre)) StringBuilder.Append("El campo Nombre es obligatorio");
            if (string.IsNullOrEmpty(articulo.Codigo)) StringBuilder.Append(Environment.NewLine + "El codigo del articulo es requerido");
           // if (articulo.Precio <= 0) StringBuilder.Append(Environment.NewLine + "El campo Precio es obligatorio");
            return StringBuilder.Length == 0;
        }


     

    }
}
