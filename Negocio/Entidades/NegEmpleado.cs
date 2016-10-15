using System;
using System.Text;
using Entidades;
using System.Data;
using Datos.Funciones_Generales;

namespace Negocio.Entidades
{
    
    public class NegEmpleado
    {
        public readonly StringBuilder StringBuilder = new StringBuilder();
        private readonly Empleado _empleadoDatos = new Empleado();
        


        public void Registrar(EEmpleado empleado)
        {

            if (!Validar(empleado)) return;
            if (!_empleadoDatos.EmpleadoExistente(empleado.Id) || empleado.Id == 0)
            {
                _empleadoDatos.Insertar(empleado);
            }
            else
            {
                if (empleado.Id > 0)
                    _empleadoDatos.Actualizar(empleado);
            }
        }

        public EEmpleado TraerPorId(int idEmpleado)
        {
            StringBuilder.Clear();

            if (idEmpleado == 0) StringBuilder.Append("Por favor proporcione un valor de Id valido");

            return StringBuilder.Length == 0 ? (EEmpleado)_empleadoDatos.ObtenerPorId(idEmpleado) : null;
        }


        public DataTable Registros()
        {
            return _empleadoDatos.ObtenerLista();
        }


        public void Eliminar(int idEmpleado)
        {
            StringBuilder.Clear();

            if (idEmpleado == 0) StringBuilder.Append("Por favor proporcione un valor de Id valido");

            if (StringBuilder.Length == 0)
            {
                _empleadoDatos.Eliminar(idEmpleado);
            }
        }



        private bool Validar(EEmpleado empleado)
        {
            StringBuilder.Clear();

            if (string.IsNullOrEmpty(empleado.Nombre)) StringBuilder.Append("El campo Nombre es obligatorio");
            if (string.IsNullOrEmpty(empleado.Apellido)) StringBuilder.Append(Environment.NewLine + "El Apellido es obligatorio");
            if (string.IsNullOrEmpty(empleado.Rfc)) StringBuilder.Append(Environment.NewLine + "Proporcione un RFC");
            if (string.IsNullOrEmpty(empleado.Curp)) StringBuilder.Append(Environment.NewLine + "Proporcione la CURP");
            if (string.IsNullOrEmpty(empleado.NumeroEmpleado)) StringBuilder.Append(Environment.NewLine + "El numero de empleado es obligatorio");
            if (string.IsNullOrEmpty(empleado.Puesto)) StringBuilder.Append(Environment.NewLine + "Seleccione un puesto para el empleado");
            if (empleado.FechaNacimiento == DateTime.MinValue) StringBuilder.Append(Environment.NewLine + "Inique la fecha de nacimiento");
            if (empleado.FechaContratacion == DateTime.MinValue) StringBuilder.Append(Environment.NewLine + "Inique la fecha de contratacion");
            return StringBuilder.Length == 0;
        }

    }
}
