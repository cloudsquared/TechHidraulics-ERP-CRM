using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Funciones_Generales;
using Entidades;

namespace Negocio.Entidades
{
    public class NegCliente
    {
        public readonly StringBuilder StringBuilder = new StringBuilder();
        private readonly Cliente _cliente = new Cliente();

        public void Registrar(ECliente cliente,ArrayList empresas)
        {
            StringBuilder.Clear();
            if (!Validar(cliente)) return;
            if (cliente.Id <= 0)
                _cliente.Insertar(cliente, empresas);
            else
                _cliente.Actualizar(cliente, empresas);
            
        }

        public ECliente TraerPorId(int idCliente)
        {
            StringBuilder.Clear();

            if (idCliente < 0) StringBuilder.Append("Por favor proporcione un valor de Id valido");

            return StringBuilder.Length == 0 ? (ECliente)_cliente.ObtenerPorId(idCliente) : null;
        }


        public DataTable Registros()
        {
            return _cliente.ObtenerLista();
        }
        public DataTable Registros_Vista()
        {
            return _cliente.ObtenerVista();
        }


        public void Eliminar(int idCliente)
        {
            StringBuilder.Clear();

            if (idCliente == 0) StringBuilder.Append("Por favor proporcione un valor de Id valido");

            if (StringBuilder.Length == 0)
            {
                _cliente.Eliminar(idCliente);
            }
        }

        public ArrayList TraerEmpresas(int idCliente)
        {
              return _cliente.Empresas(idCliente);
        }



        private bool Validar(ECliente cliente)
        {
            StringBuilder.Clear();
            if (string.IsNullOrEmpty(cliente.Nombre)) StringBuilder.Append("El campo Nombre es obligatorio");
            if (string.IsNullOrEmpty(cliente.Codigo)) StringBuilder.Append(Environment.NewLine + "El codigo del Cliente es requerido");
            // if (articulo.Precio <= 0) StringBuilder.Append(Environment.NewLine + "El campo Precio es obligatorio");
            return StringBuilder.Length == 0;
        }
    }
}
