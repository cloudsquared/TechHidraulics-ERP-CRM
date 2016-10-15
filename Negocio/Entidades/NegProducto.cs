using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Funciones_Generales;
using Entidades;

namespace Negocio.Entidades
{
    public class NegProducto
    {
        public readonly StringBuilder StringBuilder = new StringBuilder();
        private readonly Producto _producto = new Producto();

        public void Registrar(EProducto producto , EProductoArticulo[] idsProductos)
        {
            StringBuilder.Clear();
            if (!Validar(producto)) return;
            if (producto.Id <= 0)
                _producto.Insertar(producto, idsProductos);
            else
                _producto.Actualizar(producto , idsProductos);

        }

        public EProducto TraerPorId(int idProducto)
        {
            StringBuilder.Clear();

            if (idProducto < 0) StringBuilder.Append("Por favor proporcione un valor de Id valido");

            return StringBuilder.Length == 0 ? (EProducto)_producto.ObtenerProducto(idProducto) : null;
        }


        public DataTable Registros()
        {
            return _producto.ObtenerLista();
        }
        public DataTable Registros_Vista()
        {
            return _producto.ObtenerVista();
        }


        public void Eliminar(int idProducto)
        {
            StringBuilder.Clear();

            if (idProducto == 0) StringBuilder.Append("Por favor proporcione un valor de Id valido");

            if (StringBuilder.Length == 0)
            {
                _producto.Eliminar(idProducto);
            }
        }



        private bool Validar(EProducto producto)
        {
            StringBuilder.Clear();
            if (string.IsNullOrEmpty(producto.Nombre)) StringBuilder.Append("El campo Nombre es obligatorio");
            if (string.IsNullOrEmpty(producto.Codigo)) StringBuilder.Append(Environment.NewLine + "El codigo del Producto es requerido");
            if (producto.PrecioVenta <= 0) StringBuilder.Append(Environment.NewLine + "El campo Precio no puede ser 0 o menor");
            return StringBuilder.Length == 0;
        }

    }
}
