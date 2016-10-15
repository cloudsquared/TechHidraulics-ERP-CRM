
using System;
using System.Data;
using System.Text;
using Datos.Funciones_Generales;
using Entidades;

namespace Negocio.Entidades
{
    public class NegProveedor
    {
        public readonly StringBuilder StringBuilder = new StringBuilder();
        private readonly Proveedor _proveedor = new Proveedor();

        public void Registrar(EProveedor proveedor)
        {
            StringBuilder.Clear();
            if (!Validar(proveedor)) return;
            if (proveedor.Id <= 0)
                _proveedor.Insertar(proveedor);
            else
                _proveedor.Actualizar(proveedor);

        }

        public EProveedor TraerPorId(int idProveedor)
        {
            StringBuilder.Clear();

            if (idProveedor < 0) StringBuilder.Append("Por favor proporcione un valor de Id valido");

            return StringBuilder.Length == 0 ? (EProveedor)_proveedor.ObtenerPorId(idProveedor) : null;
        }


        public DataTable Registros()
        {
            return _proveedor.ObtenerLista();
        }
        public DataTable Registros_Vista()
        {
            return _proveedor.ObtenerVista();
        }


        public void Eliminar(int idProveedor)
        {
            StringBuilder.Clear();

            if (idProveedor == 0) StringBuilder.Append("Por favor proporcione un valor de Id valido");

            if (StringBuilder.Length == 0)
            {
                _proveedor.Eliminar(idProveedor);
            }
        }



        private bool Validar(EProveedor cliente)
        {
            StringBuilder.Clear();
            if (string.IsNullOrEmpty(cliente.Nombre)) StringBuilder.Append("El campo Nombre es obligatorio");
            if (string.IsNullOrEmpty(cliente.CodigoProveedor)) StringBuilder.Append(Environment.NewLine + "El codigo del Proveedor es requerido");
            return StringBuilder.Length == 0;
        }
    }
}
