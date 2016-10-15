
namespace Datos
{
    public class Configuracion
    {
     //   static string Servidor = "192.168.1.155";
        public static string Servidor { get; } = Config.Default.Servidor;
        private static string Instancia = Config.Default.Instancia;
        private const string BaseDatos = "TH";
        private const string Usuario = "th_admin";
        private const string Contrasena = "th_admin";

        // static string cadenaConexion = string.Format("Data Source={0};Initial Catalog={1};User id={2};Password={3};", new object[]

        public static string CadenaConexion { get; } = string.Format("Data Source={0};Initial Catalog={1};Trusted_Connection=True", Instancia, BaseDatos, Usuario, Contrasena);
    }
}
