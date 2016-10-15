using System.Drawing;
using System.IO;

namespace Negocio
{
    public static class Imagenes
    {
        public enum Categoria
        {
            Clientes,
            Articulos,
            Empleados
        }

        public static Image ObtenerImagen(Categoria categoria, int id)
        {
            var path = "";
            switch (categoria)
            {
                case Categoria.Empleados: path = AccesoCarpetas.ObtenerDireccionCarpeta(Carpetas.Empleados);break;
                case Categoria.Clientes: path = AccesoCarpetas.ObtenerDireccionCarpeta(Carpetas.Clientes);break;
                case Categoria.Articulos: path = AccesoCarpetas.ObtenerDireccionCarpeta(Carpetas.Articulos);break;
            }
            var imagen = path + id + ".jpg";
            return new FileInfo(imagen).Exists ? new Bitmap(imagen, true) : null;
        }

    }
}