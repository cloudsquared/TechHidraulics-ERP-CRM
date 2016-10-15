using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Datos.Funciones_Generales
{
   public class Cliente 
    {

        public void Insertar(object objCliente, ArrayList empresas)
        {
            var cliente = (ECliente) objCliente;
            SqlCommand comando = Metodos.CrearComando();
            const string sqlQuery ="INSERT INTO Cliente VALUES (@nombre ,@razon_social,@direccion,@telefono" +
                                   ",@estatus,@descripcion,@correo,@codigo,@dias_credito,@sector,@pagina_web" +
                                   ",@contacto_nombre,@contacto_telefono,@contacto_movil,@descuento,@calle," +
                                   "@colonia,@ciudad,@codigo_postal,@contacto_email)";
            comando.CommandText = sqlQuery;
            comando.Parameters.AddWithValue("@nombre", cliente.Nombre);
            comando.Parameters.AddWithValue("@razon_social", cliente.RazonSocial);
            comando.Parameters.AddWithValue("@direccion", cliente.Direccion);
            comando.Parameters.AddWithValue("@telefono", cliente.Telefono);
            comando.Parameters.AddWithValue("@estatus", cliente.Estatus);
            comando.Parameters.AddWithValue("@descripcion", cliente.Descripcion);
            comando.Parameters.AddWithValue("@correo", cliente.Correo);
            comando.Parameters.AddWithValue("@codigo", cliente.Codigo);
            comando.Parameters.AddWithValue("@dias_credito", cliente.DiasCredito);
            comando.Parameters.AddWithValue("@sector", cliente.Sector);
            comando.Parameters.AddWithValue("@pagina_web", cliente.PaginaWeb);
            comando.Parameters.AddWithValue("@contacto_nombre", cliente.ContactoNombre);
            comando.Parameters.AddWithValue("@contacto_telefono", cliente.ContactoTelefono);
            comando.Parameters.AddWithValue("@contacto_movil", cliente.ContactoMovil);
            comando.Parameters.AddWithValue("@descuento", cliente.Descuento);
            comando.Parameters.AddWithValue("@calle", cliente.Calle);
            comando.Parameters.AddWithValue("@colonia", cliente.Colonia);
            comando.Parameters.AddWithValue("@ciudad", cliente.Ciudad);
            comando.Parameters.AddWithValue("@codigo_postal", cliente.CodigoPostal);
            comando.Parameters.AddWithValue("@contacto_email", cliente.ContactoEmail);
            Metodos.EjecutarComando(comando);

            BorrarEmpresas(cliente.Id);
            int maxId = TraerIdMaximo();
            foreach (int index in empresas)
                LigarEmpresas(maxId,index);
            
        }

        public void Actualizar(object objCliente, ArrayList empresas)
        {
            var cliente = (ECliente)objCliente;

            SqlCommand comando = Metodos.CrearComando();
            const string sqlQuery = "UPDATE Cliente SET [nombre]=@nombre ,[razon_social]=@razon_social,[direccion]=@direccion,[telefono]=@telefono" +
                                   ",[estatus]=@estatus,[descripcion]=@descripcion,[correo]=@correo,[codigo]=@codigo,[dias_credito]=@dias_credito,[sector]=@sector,[pagina_web]=@pagina_web" +
                                   ",[contacto_nombre]=@contacto_nombre,[contacto_telefono]=@contacto_telefono,[contacto_movil]=@contacto_movil,[descuento]=@descuento,[calle]=@calle," +
                                   "[colonia]=@colonia,[ciudad]=@ciudad,[codigo_postal]=@codigo_postal,[contacto_email]=@contacto_email WHERE [id_cliente]=@id_cliente";
            comando.CommandText = sqlQuery;
            comando.Parameters.AddWithValue("@id_cliente", cliente.Id);
            comando.Parameters.AddWithValue("@nombre", cliente.Nombre);
            comando.Parameters.AddWithValue("@razon_social", cliente.RazonSocial);
            comando.Parameters.AddWithValue("@direccion", cliente.Direccion);
            comando.Parameters.AddWithValue("@telefono", cliente.Telefono);
            comando.Parameters.AddWithValue("@estatus", cliente.Estatus);
            comando.Parameters.AddWithValue("@descripcion", cliente.Descripcion);
            comando.Parameters.AddWithValue("@correo", cliente.Correo);
            comando.Parameters.AddWithValue("@codigo", cliente.Codigo);
            comando.Parameters.AddWithValue("@dias_credito", cliente.DiasCredito);
            comando.Parameters.AddWithValue("@sector", cliente.Sector);
            comando.Parameters.AddWithValue("@pagina_web", cliente.PaginaWeb);
            comando.Parameters.AddWithValue("@contacto_nombre", cliente.ContactoNombre);
            comando.Parameters.AddWithValue("@contacto_telefono", cliente.ContactoTelefono);
            comando.Parameters.AddWithValue("@contacto_movil", cliente.ContactoMovil);
            comando.Parameters.AddWithValue("@descuento", cliente.Descuento);
            comando.Parameters.AddWithValue("@calle", cliente.Calle);
            comando.Parameters.AddWithValue("@colonia", cliente.Colonia);
            comando.Parameters.AddWithValue("@ciudad", cliente.Ciudad);
            comando.Parameters.AddWithValue("@codigo_postal", cliente.CodigoPostal);
            comando.Parameters.AddWithValue("@contacto_email", cliente.ContactoEmail);
            Metodos.EjecutarComando(comando);

            BorrarEmpresas(cliente.Id);
            foreach (int index in empresas)
                LigarEmpresas(cliente.Id, index);

        }

        public void Eliminar(int idCliente)
        {
            string sqlQuery = "DELETE FROM Cliente WHERE id_cliente=" + idCliente;
            SqlCommand comando = Metodos.CrearComando();
            comando.CommandText = sqlQuery;
            Metodos.EjecutarComando(comando);

        }



        public ArrayList Empresas(int idCliente)
        {
            var array = new ArrayList();
            SqlCommand comando = Metodos.CrearComando();
            comando.CommandText = @"SELECT id_empresa FROM txtb_cliente_empresa WHERE id_cliente ="+idCliente;
            DataTable table = Metodos.EjecutarComandoSelect(comando);
           foreach (DataRow index in table.Rows)
               array.Add(index["id_empresa"]);
           return array;
        }


        private static int TraerIdMaximo()
        {
            SqlCommand comando = Metodos.CrearComando();
            comando.CommandText = @"SELECT MAX(id_cliente)FROM Cliente";
            return Convert.ToInt32(Metodos.EjecutarComandoSelect(comando).Rows[0].ItemArray[0]);

        }

        private static void LigarEmpresas(int idCliente, int idEmpresa)
        {
            SqlCommand comando = Metodos.CrearComando();
            string sqlQuery = string.Format("INSERT INTO txtb_cliente_empresa VALUES({0},{1})", idCliente,
                idEmpresa);
            comando.CommandText = sqlQuery;
            Metodos.EjecutarComando(comando);
        }
        private static void BorrarEmpresas(int idCliente)
        {
            SqlCommand comando = Metodos.CrearComando();
            string sqlQuery = string.Format("DELETE FROM txtb_cliente_empresa WHERE id_cliente={0}", idCliente);
            comando.CommandText = sqlQuery;
            Metodos.EjecutarComando(comando);
        }



        public object ObtenerPorId(int idCliente)
        {
            SqlCommand comando = Metodos.CrearComando();
            comando.CommandText = "SELECT* FROM Cliente WHERE id_cliente = " + idCliente;
            DataTable tabla = Metodos.EjecutarComandoSelect(comando);
            if (tabla.Rows.Count <= 0) return null;
            DataRow row = tabla.Rows[0];
            return new ECliente()
            {
                Id = Convert.ToInt32(row["id_cliente"]),
                Nombre = row["nombre"].ToString(),
                RazonSocial = row["razon_social"].ToString(),
                Direccion = row["direccion"].ToString(),
                Telefono = row["telefono"].ToString(),
                Estatus = Convert.ToInt32(row["estatus"]),
                Descripcion = row["descripcion"].ToString(),
                Correo = row["correo"].ToString(),
                Codigo = row["codigo"].ToString(),
                DiasCredito = Convert.ToInt32(row["dias_credito"]),
                Sector = row["sector"].ToString(),
                PaginaWeb = row["pagina_web"].ToString(),
                ContactoNombre = row["contacto_nombre"].ToString(),
                ContactoTelefono = row["contacto_telefono"].ToString(),
                ContactoMovil = row["contacto_movil"].ToString(),
                Descuento = Convert.ToInt32(row["descuento"]),
                Calle = row["calle"].ToString(),
                Colonia = row["colonia"].ToString(),
                Ciudad = row["ciudad"].ToString(),
                CodigoPostal = !row.IsNull("codigo_postal") ? Convert.ToInt32(row["codigo_postal"]): 0,
                ContactoEmail = row["contacto_email"].ToString(),
    };
        }
        
        public DataTable ObtenerLista()
        {
            SqlCommand comando = Metodos.CrearComando();
            comando.CommandText = "SELECT * FROM Cliente";
            DataTable tabla = Metodos.EjecutarComandoSelect(comando);
            return tabla;
        }
        public DataTable ObtenerVista()
        {
            SqlCommand comando = Metodos.CrearComando();
            comando.CommandText = "SELECT * FROM Cliente";
            DataTable tabla = Metodos.EjecutarComandoSelect(comando);
            return tabla;
        }
    }
}
