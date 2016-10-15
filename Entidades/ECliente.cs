
namespace Entidades
{
    public class ECliente
    {
        public int Id { get; set; }
           public string Nombre{ get; set; }
           public string RazonSocial { get; set; }
           public string Direccion { get; set; }
           public string Telefono { get; set; }
           public int Estatus{ get; set; }
           public string Descripcion { get; set; }
           public string Correo { get; set; }
           public string Codigo { get; set; }
           public int DiasCredito{ get; set; }
           public string Sector { get; set; }
           public string PaginaWeb { get; set; }
           public string ContactoNombre { get; set; }
           public string ContactoTelefono { get; set; }
           public string ContactoMovil { get; set; }
           public double Descuento{ get; set; }

           //Update 0.15
           public string Calle { get; set; }
           public string Colonia { get; set; }
           public string Ciudad { get; set; }
           public int CodigoPostal{ get; set; }
           public string ContactoEmail { get; set; }
    }
}
