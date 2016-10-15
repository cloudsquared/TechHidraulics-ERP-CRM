
using System.Data;
namespace Datos.Funciones_Generales
{
    internal interface ICatalogo
    {
        void Insertar(object obj);

        void Actualizar(object obj);

        void Eliminar(int id);

        object ObtenerPorId(int id);

        DataTable ObtenerLista();

        DataTable ObtenerVista();
    }
    
}