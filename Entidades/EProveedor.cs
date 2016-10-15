
namespace Entidades
{
    public class EProveedor
    {
        public int Id { get; set; }
        public string CodigoProveedor{ get; set; }
        public string Nombre{ get; set; }
        public string Telefono{ get; set; }
        public string Atencion{ get; set; }
        public string Direccion{ get; set; }
        public string Sector{ get; set; }
        public string CorreoElectronico{ get; set; }
        public string PaginaWeb{ get; set; }
        public string Observaciones{ get; set; }
        public string ContactoNombre{ get; set; }
        public string ContactoTelefono{ get; set; }
        public string ContactoDireccion{ get; set; }
        public string ContactoNombre2{ get; set; }
        public string ContactoTelefono2{ get; set; }
        public string ContactoDireccion2{ get; set; }

        //Update 0.15
        public string Calle{ get; set; }
        public string Colonia{ get; set; }
        public string Ciudad{ get; set; }
        public int CodigoPostal{ get; set; }
        public string ContactoEmail{ get; set; }
        public string ContactoEmail2{ get; set; }
        
    }
}
