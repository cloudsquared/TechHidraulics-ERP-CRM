
using System.Data;

namespace Negocio.Entidades
{
    
        internal interface ICatalogoLogico
        {
            void Registrar(object obj);

            object TraerPorId(int id);

            void Eliminar(int id);

            DataTable Registros();

            bool Validar();
        }
    
}
