using System;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Datos.Funciones_Generales
{
    public class Proveedor :ICatalogo
    {
        public void Insertar(object objProveedor)
        {
            var proveedor = (EProveedor)objProveedor;
            SqlCommand comando = Metodos.CrearComando();
            const string sqlQuery = "INSERT INTO Proveedor VALUES(@codigo_proveedor,@nombre,@telefono,@atencion,@direccion"+
                ",@sector,@correo_electronico,@pagina_web,@observaciones,@contacto_nombre,@contacto_telefono,@contacto_direccion"+
                ",@contacto_nombre2,@contacto_telefono2,@contacto_direccion2,@calle,@colonia,@ciudad,@codigo_postal,@contacto_email,@contacto_email2)";
       
            comando.CommandText = sqlQuery;
            comando.Parameters.AddWithValue("@codigo_proveedor", proveedor.CodigoProveedor);
            comando.Parameters.AddWithValue("@nombre", proveedor.Nombre);
            comando.Parameters.AddWithValue("@telefono", proveedor.Telefono);
            comando.Parameters.AddWithValue("@atencion", proveedor.Atencion);
            comando.Parameters.AddWithValue("@direccion", proveedor.Calle);
            comando.Parameters.AddWithValue("@sector", proveedor.Sector);
            comando.Parameters.AddWithValue("@correo_electronico", proveedor.CorreoElectronico);
            comando.Parameters.AddWithValue("@pagina_web", proveedor.PaginaWeb);
            comando.Parameters.AddWithValue("@observaciones", proveedor.Observaciones);
            comando.Parameters.AddWithValue("@contacto_nombre", proveedor.ContactoNombre);
            comando.Parameters.AddWithValue("@contacto_telefono", proveedor.ContactoTelefono);
            comando.Parameters.AddWithValue("@contacto_direccion", proveedor.ContactoDireccion);
            comando.Parameters.AddWithValue("@contacto_nombre2", proveedor.ContactoNombre2);
            comando.Parameters.AddWithValue("@contacto_telefono2", proveedor.ContactoTelefono2);
            comando.Parameters.AddWithValue("@contacto_direccion2", proveedor.ContactoDireccion2);
            comando.Parameters.AddWithValue("@calle", proveedor.Calle);
            comando.Parameters.AddWithValue("@ciudad", proveedor.Ciudad);
            comando.Parameters.AddWithValue("@codigo_postal", proveedor.CodigoPostal);
            comando.Parameters.AddWithValue("@contacto_email", proveedor.ContactoEmail);
            comando.Parameters.AddWithValue("@contacto_email2", proveedor.ContactoEmail2);

            Metodos.EjecutarComando(comando);
        }

        public void Actualizar(object objProveedor)
        {
            var proveedor = (EProveedor)objProveedor;

            SqlCommand comando = Metodos.CrearComando();
            const string sqlQuery =
                "UPDATE Proveedor SET VALUES [codigo_proveedor]=@codigo_proveedor,[nombre]= @nombre,[telefono]= @telefono,[atencion]= @atencion,[direccion]= @direccion" +
                ",[sector]= @sector,[correo_electronico]= @correo_electronico,[pagina_web]= @pagina_web,[observaciones]= @observaciones,[contacto_nombre]= @contacto_nombre,[contacto_telefono]= @contacto_telefono,[contacto_direccion]= @contacto_direccion" +
                ",[contacto_nombre2]= @contacto_nombre2,[contacto_telefono2]= @contacto_telefono2,[contacto_direccion2]= @contacto_direccion2,[calle]= @calle,[colonia]= @colonia,[ciudad]= @ciudad,[codigo_postal]= @codigo_postal,[contacto_email]= @contacto_email,[contacto_email2]= @contacto_email2" +
                " WHERE id_proveedor = id_proveedor";
            comando.CommandText = sqlQuery;
            comando.Parameters.AddWithValue("@codigo_proveedor", proveedor.CodigoProveedor);
            comando.Parameters.AddWithValue("@nombre", proveedor.Nombre);
            comando.Parameters.AddWithValue("@telefono", proveedor.Telefono);
            comando.Parameters.AddWithValue("@atencion", proveedor.Atencion);
            comando.Parameters.AddWithValue("@direccion", proveedor.Calle);
            comando.Parameters.AddWithValue("@sector", proveedor.Sector);
            comando.Parameters.AddWithValue("@correo_electronico", proveedor.CorreoElectronico);
            comando.Parameters.AddWithValue("@pagina_web", proveedor.PaginaWeb);
            comando.Parameters.AddWithValue("@observaciones", proveedor.Observaciones);
            comando.Parameters.AddWithValue("@contacto_nombre", proveedor.ContactoNombre);
            comando.Parameters.AddWithValue("@contacto_telefono", proveedor.ContactoTelefono);
            comando.Parameters.AddWithValue("@contacto_direccion", proveedor.ContactoDireccion);
            comando.Parameters.AddWithValue("@contacto_nombre2", proveedor.ContactoNombre2);
            comando.Parameters.AddWithValue("@contacto_telefono2", proveedor.ContactoTelefono2);
            comando.Parameters.AddWithValue("@contacto_direccion2", proveedor.ContactoDireccion2);
            comando.Parameters.AddWithValue("@calle", proveedor.Calle);
            comando.Parameters.AddWithValue("@ciudad", proveedor.Ciudad);
            comando.Parameters.AddWithValue("@codigo_postal", proveedor.CodigoPostal);
            comando.Parameters.AddWithValue("@contacto_email", proveedor.ContactoEmail);
            comando.Parameters.AddWithValue("@contacto_email2", proveedor.ContactoEmail2);
            comando.Parameters.AddWithValue("@id_proveedor", proveedor.Id);
            Metodos.EjecutarComando(comando);
        }

        public void Eliminar(int idProveedor)
        {
            string sqlQuery = "DELETE FROM Proveedor WHERE id_proveedor=" + idProveedor;
            SqlCommand comando = Metodos.CrearComando();
            comando.CommandText = sqlQuery;
            Metodos.EjecutarComando(comando);

        }



        public object ObtenerPorId(int idProveedor)
        {
            SqlCommand comando = Metodos.CrearComando();
            comando.CommandText = "SELECT* FROM Proveedor WHERE id_proveedor = " + idProveedor;
            DataTable tabla = Metodos.EjecutarComandoSelect(comando);
            if (tabla.Rows.Count <= 0) return null;
            var row = tabla.Rows[0];
            return new EProveedor()
            {
                Id = Convert.ToInt32(row["Id"]),
                CodigoProveedor = row["codigo_proveedor"].ToString(),
                Nombre = row["nombre"].ToString(),
                Telefono = row["telefono"].ToString(),
                Atencion = row["atencion"].ToString(),
                Direccion = row["direccion"].ToString(),
                Sector = row["sector"].ToString(),
                CorreoElectronico = row["correo_electronico"].ToString(),
                PaginaWeb = row["pagina_web"].ToString(),
                Observaciones = row["observaciones"].ToString(),
                ContactoNombre = row["contacto_nombre"].ToString(),
                ContactoTelefono = row["contacto_telefono"].ToString(),
                ContactoDireccion = row["contacto_direccion"].ToString(),
                ContactoNombre2 = row["contacto_nombre2"].ToString(),
                ContactoTelefono2 = row["contacto_telefono2"].ToString(),
                ContactoDireccion2 = row["contacto_direccion2"].ToString(),
                Calle = row["calle"].ToString(),
                Colonia = row["colonia"].ToString(),
                Ciudad = row["ciudad"].ToString(),
                CodigoPostal = Convert.ToInt32(row["codigo_postal"]),
                ContactoEmail = row["contacto_email"].ToString(),
                ContactoEmail2 = row["contacto_email2"].ToString()
            };
        }

        public DataTable ObtenerLista()
        {
            SqlCommand comando = Metodos.CrearComando();
            comando.CommandText = "SELECT * FROM Proveedor";
            DataTable tabla = Metodos.EjecutarComandoSelect(comando);
            return tabla;
        }
        public DataTable ObtenerVista()
        {
            SqlCommand comando = Metodos.CrearComando();
            comando.CommandText = "SELECT * FROM Proveedor";
            DataTable tabla = Metodos.EjecutarComandoSelect(comando);
            return tabla;
        }
    }
}
