using System.Data;
using System.Data.SqlClient;


namespace Datos
{
    public class AccesoDatos
    {
        public static bool VerificarUsuario(string usuario, string pass)
        {
            SqlCommand comando = Metodos.CrearComando();
            comando.CommandText = "SELECT nombre FROM empleado WHERE nombre_usuario = '" + usuario+ "' AND contrasena = '" + pass+"'";
            return Metodos.EjecutarComandoSelect(comando).Rows.Count == 1;
        }

        public static DataRow DatosUsuario(string usuario)
        {
            SqlCommand comando = Metodos.CrearComando();
            comando.CommandText = "SELECT * FROM empleado WHERE nombre_usuario = '" + usuario + "'";
            return Metodos.EjecutarComandoSelect(comando).Rows[0];
        }
    }
}
