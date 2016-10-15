using System;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Datos.Funciones_Generales
{
    public class Servicio
    {
        public DataTable ObtenerListaServicios()
        {
            SqlCommand comando = Metodos.CrearComando();
            comando.CommandText = "SELECT * FROM Servicio";
            return  Metodos.EjecutarComandoSelect(comando);
        }
        public DataTable ObtenerListaServiciosVista()
        {
            SqlCommand comando = Metodos.CrearComando();
            comando.CommandText = "SELECT * FROM vw_servicio";
            return Metodos.EjecutarComandoSelect(comando);
        }

        public EServicio ObtenerServicio(int idServicio)
        {
            SqlCommand comando = Metodos.CrearComando();
            comando.CommandText = "SELECT* FROM Servicio WHERE id_servicio = " + idServicio;
            DataTable tabla = Metodos.EjecutarComandoSelect(comando);
            if (tabla.Rows.Count <= 0) return null;
            var row = tabla.Rows[0];
            return new EServicio
            {
                Id = Convert.ToInt32(row["id_servicio"]),
                Nombre = Convert.ToString(row["nombre"]),
                CostoManoObra = Convert.ToDecimal(row["costo_mo"])
            };
        }


        public void Insertar(EServicio servicio, EServicioArticulo[] articulos)
        {

            SqlCommand comando = Metodos.CrearComando();
            string sqlQuery = string.Format("INSERT INTO Servicio VALUES ('{0}',{1})",
                servicio.Nombre, servicio.CostoManoObra);
            comando.CommandText = sqlQuery;
            Metodos.EjecutarComando(comando);
            int maxId = TraerIdMaximo();
            foreach (var articulo in articulos)
                LigarArticulos(maxId, articulo.IdArticulo, articulo.Cantidad);

        }

        public void Actualizar(EServicio servicio, EServicioArticulo[] articulos)
        {
            SqlCommand comando = Metodos.CrearComando();
            string sqlQuery = string.Format("UPDATE Servicio SET nombre='{0}',costo_mo={1} WHERE id_servicio={2}",
                servicio.Nombre, servicio.CostoManoObra,servicio.Id);
            comando.CommandText = sqlQuery;
            Metodos.EjecutarComando(comando);
            BorrarArticulos(servicio.Id);
            foreach (var articulo in articulos)
                LigarArticulos(servicio.Id, articulo.IdArticulo, articulo.Cantidad);

        }

        public void Eliminar(int idServicio)
        {
            SqlCommand comando = Metodos.CrearComando();
            BorrarArticulos(idServicio);
            string sqlQuery = string.Format("DELETE FROM Servicio WHERE id_servicio={0}", idServicio);
            comando.CommandText = sqlQuery;
            Metodos.EjecutarComando(comando);
        }


        private static int TraerIdMaximo()
        {
            SqlCommand comando = Metodos.CrearComando();
            comando.CommandText = @"SELECT MAX(id_servicio)FROM Servicio";
            return Convert.ToInt32(Metodos.EjecutarComandoSelect(comando).Rows[0].ItemArray[0]); 
            
        }

        private static void LigarArticulos(int idServicio, int idArticulo, decimal cantidad)
        {
            SqlCommand comando = Metodos.CrearComando();
            string sqlQuery = string.Format("INSERT INTO txtb_servicio_articulos VALUES({0},{1},{2})", idServicio,
                idArticulo, cantidad);
            comando.CommandText = sqlQuery;
            Metodos.EjecutarComando(comando);
        }

        private static void BorrarArticulos(int idServicio)
        {
            SqlCommand comando = Metodos.CrearComando();
            string sqlQuery = string.Format("DELETE FROM txtb_servicio_articulos WHERE id_servicio={0}", idServicio);
            comando.CommandText = sqlQuery;
            Metodos.EjecutarComando(comando);
        }

        public DataTable TraerArticulos(int idServicio)
        {
            SqlCommand comando = Metodos.CrearComando();
            comando.CommandText =
                "select a.id_articulo, a.nombre,ts.cantidad ,a.precio as precio_unitario,(a.precio * ts.cantidad) as total" +
                " from txtb_servicio_articulos ts full join servicio s on ts.id_servicio = s.id_servicio full" +
                " join articulo a on a.id_articulo = ts.articulo where ts.id_servicio = " + idServicio;
            return Metodos.EjecutarComandoSelect(comando);
        }


    }
}
