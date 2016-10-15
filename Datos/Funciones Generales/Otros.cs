using System.Data;
using System.Data.SqlClient;

namespace Datos.Funciones_Generales
{
    public class Otros
    {
        public static DataTable ObtenerEmpleados()
        {
            SqlCommand comando = Metodos.CrearComando();
            comando.CommandText = "select * from empleado order by nombre asc";
            return Metodos.EjecutarComandoSelect(comando);
        }

        public static DataTable ObtenerClientes()
        {
            SqlCommand comando = Metodos.CrearComando();
            comando.CommandText = "select * from cliente  order by nombre asc";
            return Metodos.EjecutarComandoSelect(comando);
        }

        public static DataTable ObtenerArticulos()
        {
            SqlCommand comando = Metodos.CrearComando();
            comando.CommandText = "select * from articulo  order by nombre asc";
            return Metodos.EjecutarComandoSelect(comando);
        }

        public static DataTable ObtenerProveedores()
        {
            SqlCommand comando = Metodos.CrearComando();
            comando.CommandText = "select * from proveedor  order by nombre asc";
            return Metodos.EjecutarComandoSelect(comando);
        }

        public static DataTable ObtenerCategorias()
        {
            SqlCommand comando = Metodos.CrearComando();
            comando.CommandText = "select * from categoria_articulo";
            return Metodos.EjecutarComandoSelect(comando);
        }

        public static DataTable ObtenerSubcategorias()
        {
            SqlCommand comando = Metodos.CrearComando();
            comando.CommandText = "select * from tipo_articulo";
            return Metodos.EjecutarComandoSelect(comando);
        }

        public static DataTable ObtenerMedidas()
        {
            SqlCommand comando = Metodos.CrearComando();
            comando.CommandText = "select * from tipo_unidad";
            return Metodos.EjecutarComandoSelect(comando);
        }

        public static DataTable ObtenerDepartamentos()
        {
            SqlCommand comando = Metodos.CrearComando();
            comando.CommandText = "select * from departamento";
            return Metodos.EjecutarComandoSelect(comando);
        }

        public static DataTable ObtenerPuestos()
        {
            SqlCommand comando = Metodos.CrearComando();
            comando.CommandText = "select * from puesto";
            return Metodos.EjecutarComandoSelect(comando);

        }

        public static DataTable ObtenerSectores()
        {
            SqlCommand comando = Metodos.CrearComando();
            comando.CommandText = "select * from sector";
            return Metodos.EjecutarComandoSelect(comando);

        }
    }
}