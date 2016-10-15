using System;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Datos.Funciones_Generales
{
    public class OrdenServicio
    {
        public DataTable Registros()
        {
            SqlCommand comando = Metodos.CrearComando();
            comando.CommandText = "SELECT * FROM Orden_Servicio";
            return Metodos.EjecutarComandoSelect(comando);
        }
        public DataTable VistaRegistros()
        {
            SqlCommand comando = Metodos.CrearComando();
            comando.CommandText = "SELECT * FROM vw_orden";
            return Metodos.EjecutarComandoSelect(comando);
        }

        public EOrdenServicio ObtenerOrdenServicio(int idOrdenServicio)
        {
            SqlCommand comando = Metodos.CrearComando();
            comando.CommandText = "SELECT* FROM Orden_Servicio WHERE id_orden = " + idOrdenServicio;
            DataTable tabla = Metodos.EjecutarComandoSelect(comando);
            if (tabla.Rows.Count <= 0) return null;
            var row = tabla.Rows[0];
            EOrdenServicio orden = new EOrdenServicio();
            orden.Id = Convert.ToInt32(row["id_orden"]);
            orden.NumeroOrden = Convert.ToInt32(row["numero_orden"]);
            orden.FechaElaboracion = Convert.ToDateTime(row["fecha_elaboracion"]);
            orden.FechaAprobacion = row.IsNull("fecha_aprobacion") ? DateTime.MinValue : Convert.ToDateTime(row["fecha_aprobacion"]);
            orden.FechaCompromiso = row.IsNull("fecha_compromiso") ? DateTime.MinValue : Convert.ToDateTime(row["fecha_compromiso"]);
            orden.Concepto = row["concepto"].ToString();
            orden.AutorOrder = row.IsNull("autor_order") ? 0 : Convert.ToInt32(row["autor_order"]);
            orden.Responsable = row.IsNull("responsable") ? 0 : Convert.ToInt32(row["responsable"]);
            orden.Vehiculo = row.IsNull("vehiculo") ? 0 : Convert.ToInt32(row["vehiculo"]);
            orden.DiasCredito = row.IsNull("dias_credito") ? 0 : Convert.ToInt32(row["dias_credito"]);
            orden.Estatus = Convert.ToInt32(row["estatus"]);
            orden.Utilidad = row.IsNull("dias_credito") ? 0 : Convert.ToDecimal(row["utilidad"]);
            orden.Cliente = row.IsNull("dias_credito") ? 0 : Convert.ToInt32(row["cliente"]);

            return orden;
        }   


        public void Insertar(EOrdenServicio orden, int[] idservicios)
        {

            SqlCommand comando = Metodos.CrearComando();
            const string query = "INSERT INTO orden_servicio VALUES (@numero_orden,@fecha_elaboracion,@fecha_aprobacion,@fecha_compromiso,@concepto,@autor_order,@responsable,@vehiculo,"
           +"@dias_credito, @estatus, @utilidad, @cliente)";
            comando.CommandText = query;
            comando.Parameters.AddWithValue("@numero_orden", orden.NumeroOrden);
            comando.Parameters.AddWithValue("@fecha_elaboracion", orden.FechaElaboracion);

            if(orden.FechaAprobacion == DateTime.MinValue)
                comando.Parameters.AddWithValue("@fecha_aprobacion", DBNull.Value);
            else
                comando.Parameters.AddWithValue("@fecha_aprobacion", orden.FechaAprobacion);

            if (orden.FechaCompromiso == DateTime.MinValue)
                comando.Parameters.AddWithValue("@fecha_compromiso", DBNull.Value);
            else
                comando.Parameters.AddWithValue("@fecha_compromiso", orden.FechaCompromiso);


            comando.Parameters.AddWithValue("@concepto", orden.Concepto);
            comando.Parameters.AddWithValue("@autor_order", orden.AutorOrder);
            comando.Parameters.AddWithValue("@responsable", orden.Responsable);
            comando.Parameters.AddWithValue("@vehiculo", orden.Vehiculo);
            comando.Parameters.AddWithValue("@dias_credito", orden.DiasCredito);
            comando.Parameters.AddWithValue("@estatus", orden.Estatus);
            comando.Parameters.AddWithValue("@utilidad", orden.Utilidad);
            comando.Parameters.AddWithValue("@cliente", orden.Cliente);
            Metodos.EjecutarComando(comando);
            var maxId = TraerIdMaximo();
            foreach (var idServicio in idservicios)
                LigarServicios(maxId, idServicio);

        }

        public void Actualizar(EOrdenServicio orden, int[] idservicios)
        {
            SqlCommand comando = Metodos.CrearComando();
            const string query = "UPDATE orden_servicio SET numero_orden=@numero_orden, fecha_elaboracion=@fecha_elaboracion, fecha_aprobacion=@fecha_aprobacion,fecha_compromiso =@fecha_compromiso, concepto= @concepto, autor_order =@autor_order, responsable =@responsable, vehiculo=@vehiculo,"
         + "dias_credito =@dias_credito, estatus= @estatus, utilidad=@utilidad, cliente= @cliente WHERE id_orden=@id_orden";
            comando.CommandText = query;
            comando.Parameters.AddWithValue("@id_orden", orden.Id);
            comando.Parameters.AddWithValue("@numero_orden", orden.NumeroOrden);
            comando.Parameters.AddWithValue("@fecha_elaboracion", orden.FechaElaboracion);

            if(orden.FechaAprobacion == DateTime.MinValue)
                comando.Parameters.AddWithValue("@fecha_aprobacion", DBNull.Value);
            else
                comando.Parameters.AddWithValue("@fecha_aprobacion",orden.FechaAprobacion);

            if (orden.FechaCompromiso == DateTime.MinValue)
                comando.Parameters.AddWithValue("@fecha_compromiso", DBNull.Value);
            else
                comando.Parameters.AddWithValue("@fecha_compromiso", orden.FechaCompromiso);
            

            comando.Parameters.AddWithValue("@concepto", orden.Concepto);
            comando.Parameters.AddWithValue("@autor_order", orden.AutorOrder);
            comando.Parameters.AddWithValue("@responsable", orden.Responsable);

            if (orden.Vehiculo == -1)
                comando.Parameters.AddWithValue("@vehiculo", DBNull.Value);
            else
                comando.Parameters.AddWithValue("@vehiculo", orden.Vehiculo);


            comando.Parameters.AddWithValue("@dias_credito", orden.DiasCredito);
            comando.Parameters.AddWithValue("@estatus", orden.Estatus);
            comando.Parameters.AddWithValue("@utilidad", orden.Utilidad);
            comando.Parameters.AddWithValue("@cliente", orden.Cliente);
            Metodos.EjecutarComando(comando);
            BorrarServicios(orden.Id);
            foreach (var idServicio in idservicios)
                LigarServicios(orden.Id, idServicio);
        }

        public void Eliminar(int idServicio)
        {
            SqlCommand comando = Metodos.CrearComando();
            BorrarServicios(idServicio);
            string sqlQuery = string.Format("DELETE FROM Orden_Servicio WHERE id_orden={0}", idServicio);
            comando.CommandText = sqlQuery;
            Metodos.EjecutarComando(comando);
        }


        private static int TraerIdMaximo()
        {
            SqlCommand comando = Metodos.CrearComando();
            comando.CommandText = @"SELECT MAX(id_orden)FROM Orden_Servicio";
            return Convert.ToInt32(Metodos.EjecutarComandoSelect(comando).Rows[0].ItemArray[0]);

        }

        private static void LigarServicios(int idOrdenServicio, int idServicio)
        {
            SqlCommand comando = Metodos.CrearComando();
            string sqlQuery = string.Format("INSERT INTO txtb_orden_servicio VALUES({0},{1},1)", idOrdenServicio,
                idServicio);
            comando.CommandText = sqlQuery;
            Metodos.EjecutarComando(comando);
        }

        private static void BorrarServicios(int idOrden)
        {
            SqlCommand comando = Metodos.CrearComando();
            string sqlQuery = string.Format("DELETE FROM txtb_orden_servicio WHERE id_orden={0}", idOrden);
            comando.CommandText = sqlQuery;
            Metodos.EjecutarComando(comando);
        }

        public DataTable TraerServicios(int idServicio)
        {
            SqlCommand comando = Metodos.CrearComandoProc("SP_SERVICIOS_DE_ORDEN");
            comando.Parameters.AddWithValue("@id_orden",idServicio);
            return Metodos.EjecutarComandoSelect(comando);
        }

    }
}
