using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public enum Carpetas
    {
        Clientes,
        Articulos,
        Empleados,
        Facturas,
        OrdenesServicio
    }

    public static class AccesoCarpetas
    {

        public static string ObtenerDireccionCarpeta(Carpetas carpeta)
        {
            switch (carpeta)
            {
                case Carpetas.Clientes: return @"\\Desktop-adnd2h2\th_erp\clientes\";
                case Carpetas.Empleados: return @"\\Desktop-adnd2h2\th_erp\empleados\";
                case Carpetas.Articulos: return @"\\Desktop-adnd2h2\th_erp\articulos\";
            }
            return null;
        }
        
    }

   
}
