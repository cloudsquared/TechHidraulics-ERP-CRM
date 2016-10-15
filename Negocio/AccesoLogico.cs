using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class AccesoLogico
    {
        
        public static bool VerificarUsuario(string usuario, string pass)
        {
            return AccesoDatos.VerificarUsuario(usuario, pass);
        }

        public static DataRow DatosUsuario(string usuario)
        {
            return AccesoDatos.DatosUsuario(usuario);
        }
    }
}
