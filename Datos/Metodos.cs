using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class Metodos
    {
        
        /// <summary>
        /// Inicializa un SQLCOMMAND usando la configuracion de la clase Configuracion
        /// </summary>
        /// <returns>SQLCOMMAND Configurado para su uso en varias clases. </returns>
        public static SqlCommand CrearComando()
        {
            string cadenaConexion = Configuracion.CadenaConexion;
            SqlConnection conexion = new SqlConnection {ConnectionString = cadenaConexion};
            var comando = conexion.CreateCommand();
            comando.CommandType = CommandType.Text;
            return comando;
        }
        
        /// <summary>
        /// Inicicializa un SQLCOMMAND con tipo CommandType.StoredProcedure  con la configuracion de la clase Configuracion
        /// </summary>
        /// <param name="proc">Nombre del procedimiento almacenado</param>
        /// <returns>SQLCOMMAND Configurado para su uso en varias clases</returns>
        public static SqlCommand CrearComandoProc(string proc)
        {
            string cadenaConexion = Configuracion.CadenaConexion;
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand comando = new SqlCommand(proc, conexion) {CommandType = CommandType.StoredProcedure};
            return comando;
        }

        /// <summary>
        /// Ejecuta un comando en la instancia de la base de datos establecida.
        /// </summary>
        /// <param name="comando">SQLCOMMAND a ejecutar</param>
        /// <returns>Numero de filas afectadas</returns>
        public static int EjecutarComando(SqlCommand comando)
        {
            try
            {
                comando.Connection.Open();
                return comando.ExecuteNonQuery();
            }
            finally
            {
                comando.Connection.Dispose();
                comando.Connection.Close();
            }
        }

        /// <summary>
        /// Ejecuta un comando en la instancia de la base de datos establecida.
        /// </summary>
        /// <param name="comando">SQLCOMMAND a ejecutar</param>
        /// <returns>DataTable con los datos resultantes</returns>
        public static DataTable EjecutarComandoSelect(SqlCommand comando)
        {
            DataTable tabla = new DataTable();
            try
            {
                comando.Connection.Open();
                SqlDataAdapter adaptador = new SqlDataAdapter {SelectCommand = comando};
                adaptador.Fill(tabla);
            }
            finally
            {
                comando.Connection.Close();
            }
            return tabla;
        }



    }
}
