using System;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Datos.Funciones_Generales
{
    public class Producto
    {
        public DataTable ObtenerLista()
        {
            SqlCommand comando = Metodos.CrearComando();
            comando.CommandText = "SELECT * FROM producto";
            return Metodos.EjecutarComandoSelect(comando);
        }
        public DataTable ObtenerVista()
        {
            SqlCommand comando = Metodos.CrearComando();
            comando.CommandText = "SELECT * FROM producto";
            return Metodos.EjecutarComandoSelect(comando);
        }

        public EProducto ObtenerProducto(int idProducto)
        {
            SqlCommand comando = Metodos.CrearComando();
            comando.CommandText = "SELECT* FROM Producto WHERE id_producto = " + idProducto;
            DataTable tabla = Metodos.EjecutarComandoSelect(comando);
            if (tabla.Rows.Count <= 0) return null;
            var row = tabla.Rows[0];
            return new EProducto
            {
                Id = idProducto,
                Codigo = row["codigo"].ToString(),
                TipoProducto = Convert.ToInt32(row["tipo"]),
                Nombre = row["nombre"].ToString(),
                Descripcion = row["descripcion"].ToString(),
                CostoManoObra = Convert.ToDecimal(row["costo_mo"]),
                UtilidadPorcentaje = Convert.ToInt32(row["utilidad_porcentaje"]),
                PrecioVenta = Convert.ToDecimal(row["precio_venta"])
            };
        }


        public void Insertar(EProducto producto, EProductoArticulo[] articulos)
        {

            SqlCommand comando = Metodos.CrearComando();
            const string sqlQuery = "INSERT INTO Producto VALUES (@codigo,@tipo,nombre,@descripcion,@costo_mo,@utilidad_porcentaje,@precio_venta)";
            comando.CommandText = sqlQuery;
            comando.Parameters.AddWithValue("@codigo",producto.Codigo);
            comando.Parameters.AddWithValue("@tipo", producto.TipoProducto);
            comando.Parameters.AddWithValue("@nombre", producto.Nombre);
            comando.Parameters.AddWithValue("@descripcion", producto.Descripcion);
            comando.Parameters.AddWithValue("@costo_mo", producto.CostoManoObra);
            comando.Parameters.AddWithValue("@utilidad_porcentaje", producto.UtilidadPorcentaje);
            comando.Parameters.AddWithValue("@precio_venta", producto.PrecioVenta);

            Metodos.EjecutarComando(comando);
            int maxId = TraerIdMaximo();
            foreach (var articulo in articulos)
                LigarArticulos(maxId, articulo.IdArticulo, articulo.Cantidad);

        }

        public void Actualizar(EProducto producto, EProductoArticulo[] articulos)
        {
            SqlCommand comando = Metodos.CrearComando();
            const string sqlQuery = "UPDATE Producto SET [codigo]=@codigo,[tipo]=@tipo,[nombre]=nombre[descripcion]=@descripcion,[costo_mo]=@costo_mo,[utilidad_porcentaje]=@utilidad_porcentaje,[precio_venta]=@precio_venta";
            comando.CommandText = sqlQuery;
            comando.Parameters.AddWithValue("@codigo", producto.Codigo);
            comando.Parameters.AddWithValue("@tipo", producto.TipoProducto);
            comando.Parameters.AddWithValue("@nombre", producto.Nombre);
            comando.Parameters.AddWithValue("@descripcion", producto.Descripcion);
            comando.Parameters.AddWithValue("@costo_mo", producto.CostoManoObra);
            comando.Parameters.AddWithValue("@utilidad_porcentaje", producto.UtilidadPorcentaje);
            comando.Parameters.AddWithValue("@precio_venta", producto.PrecioVenta);
       
            BorrarArticulos(producto.Id);
            Metodos.EjecutarComando(comando);
            foreach (var articulo in articulos)
                LigarArticulos(producto.Id, articulo.IdArticulo, articulo.Cantidad);
        }

        public void Eliminar(int idProducto)
        {
            SqlCommand comando = Metodos.CrearComando();
            BorrarArticulos(idProducto);
            string sqlQuery = string.Format("DELETE FROM Producto WHERE id_producto={0}", idProducto);
            comando.CommandText = sqlQuery;
            Metodos.EjecutarComando(comando);
        }


        private static int TraerIdMaximo()
        {
            SqlCommand comando = Metodos.CrearComando();
            comando.CommandText = @"SELECT MAX(id_producto)FROM Producto";
            return Convert.ToInt32(Metodos.EjecutarComandoSelect(comando).Rows[0].ItemArray[0]);

        }

        private static void LigarArticulos(int idProducto, int idArticulo, decimal cantidad)
        {
            SqlCommand comando = Metodos.CrearComando();
            string sqlQuery = string.Format("INSERT INTO txtb_producto_articulos VALUES({0},{1},{2})", idProducto,
                idArticulo, cantidad);
            comando.CommandText = sqlQuery;
            Metodos.EjecutarComando(comando);
        }

        private static void BorrarArticulos(int idProducto)
        {
            SqlCommand comando = Metodos.CrearComando();
            string sqlQuery = string.Format("DELETE FROM txtb_producto_articulos WHERE id_producto={0}", idProducto);
            comando.CommandText = sqlQuery;
            Metodos.EjecutarComando(comando);
        }

        public DataTable TraerArticulos(int idProducto)
        {
            SqlCommand comando = Metodos.CrearComando();
            comando.CommandText =
               @"select a.id_articulo, a.nombre,ts.cantidad ,a.precio as precio_unitario,(a.precio * ts.cantidad) as total"+
                 " from txtb_producto_articulos ts"+
				 " full  join producto p on ts.id_producto = p.id_producto"+
				 " full join articulo a on a.id_articulo = ts.articulo"+
				 " where ts.id_producto = " + idProducto;

            return Metodos.EjecutarComandoSelect(comando);
        }
    }
}
