
using System;
using System.Data;
using System.Text;
using Datos.Funciones_Generales;
using Entidades;

namespace Negocio.Entidades
{
    public class NegServicios
    {

        public readonly StringBuilder StringBuilder = new StringBuilder();
        private readonly Servicio _serviciosDatos = new Servicio();

        public DataTable TempTable = new DataTable();

        public NegServicios()
        {
            TempTable.Columns.Add("id_articulo", typeof(int));
            TempTable.Columns.Add("nombre", typeof(string));
            TempTable.Columns.Add("cantidad", typeof(int));
            TempTable.Columns.Add("precio_unitario", typeof(double));
            TempTable.Columns.Add("total", typeof(double));
        }

        public DataTable Registros()
        {
            return _serviciosDatos.ObtenerListaServicios();
        }

        public DataTable RegistrosVista()
        {
            return _serviciosDatos.ObtenerListaServiciosVista();
        }

        public EServicio TraerPorId(int idServicio)
        {
            return _serviciosDatos.ObtenerServicio(idServicio);
        }

        public void Registrar(EServicio servicio , EServicioArticulo[] articulos )
        {
            if (!ValidarServicio(servicio)) return;
            if(servicio.Id ==0)
                _serviciosDatos.Insertar(servicio,articulos);
            else
                _serviciosDatos.Actualizar(servicio, articulos);
        }
        public void Eliminar(int idServicio)
        {
            _serviciosDatos.Eliminar(idServicio);
        }


        private bool ValidarServicio(EServicio servicio)
        {
            StringBuilder.Clear();
            if (string.IsNullOrEmpty(servicio.Nombre)) StringBuilder.Append("El Nombre del servicio es obligatorio");
            return StringBuilder.Length == 0;
        }

        public DataTable TraerArticulos(int idServicio)
        {
            return _serviciosDatos.TraerArticulos(idServicio);
        }
    }
}
