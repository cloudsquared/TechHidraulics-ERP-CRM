
using System.Data;
using Datos.Funciones_Generales;

namespace Negocio
{
    public class DatosGenerales
    {
        public static DataTable ObtenerClientes()
        {
            return Otros.ObtenerClientes();
        }

        public static DataTable ObtenerEmpleados()
        {
            return Otros.ObtenerEmpleados();
        }

        public static DataTable ObtenerProveedores()
        {
            return Otros.ObtenerProveedores();
        }

        public static DataTable ObtenerSubcategorias()
        {
            return Otros.ObtenerSubcategorias();
        }
        public static DataTable ObtenerCategorias()
        {
            return Otros.ObtenerCategorias();
        }
        public static DataTable ObtenerMedidas()
        {
            return Otros.ObtenerMedidas();
        }
        public static DataTable ObtenerPuestos()
        {
            return Otros.ObtenerPuestos();
        }
        public static DataTable ObtenerDepartamentos()
        {
            return Otros.ObtenerDepartamentos();
        }

        public static DataTable ObtenerArticulos()
        {
            return Otros.ObtenerArticulos();
        }
        public static DataTable ObtenerSectores()
        {
            return Otros.ObtenerSectores();
        }
    }
}
