
using System.Data;
using System.Text;
using Datos.Funciones_Generales;
using Entidades;

namespace Negocio.Entidades
{
    public class NegOrdenServicio
    {
        public readonly StringBuilder StringBuilder = new StringBuilder();
        private readonly OrdenServicio _ordenServiciosDatos = new OrdenServicio();

        public DataTable Registros()
        {
            return _ordenServiciosDatos.Registros();
        }

        public DataTable RegistrosVista()
        {
            return _ordenServiciosDatos.VistaRegistros();
        }

        public EOrdenServicio TraerPorId(int idOrdenServicio)
        {
            return _ordenServiciosDatos.ObtenerOrdenServicio(idOrdenServicio);
        }

        public void Registrar(EOrdenServicio orden, int[] idsServicios)
        {
            if (!Validar(orden)) return;
            if (orden.Id == 0)
                _ordenServiciosDatos.Insertar(orden, idsServicios);
            else
                _ordenServiciosDatos.Actualizar(orden, idsServicios);
        }
        public void Eliminar(int idServicio)
        {
            _ordenServiciosDatos.Eliminar(idServicio);
        }


        private bool Validar(EOrdenServicio orden)
        {
            StringBuilder.Clear();
            if ((orden.NumeroOrden)<= 0) StringBuilder.Append("El Numero de Orden es obligatorio");
            return StringBuilder.Length == 0;
        }

        public DataTable TraerServicios(int idOrdenServicio)
        {
            return _ordenServiciosDatos.TraerServicios(idOrdenServicio);
        }
    }
}
