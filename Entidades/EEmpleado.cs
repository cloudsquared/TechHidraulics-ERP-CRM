using System;

namespace Entidades
{
    public class EEmpleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Puesto { get; set; }
        public int Estatus { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public string NumeroEmpleado { get; set; }
        public string Rfc { get; set; }
        public string Estatura { get; set; }
        public double Peso { get; set; }
        public string Referencia { get; set; }
        public string ContactoPersonal { get; set; }
        public string TipoSangre { get; set; }
        public DateTime FechaContratacion { get; set; }
        public char Genero { get; set; }
        public int Departamento { get; set; }
        public DateTime FechaTerminacion { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Administrador { get; set; }

        //Update 0.15
        public string Calle { get; set; }
        public string Colonia { get; set; }
        public string Ciudad { get; set; }
        public int CodigoPostal { get; set; }
        public string Curp { get; set; }
        public string NumeroAfiliacion { get; set; }
        public string CreditoInfonavit { get; set; }
    
    }
}