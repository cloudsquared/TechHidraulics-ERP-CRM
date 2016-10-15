using System;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Datos.Funciones_Generales
{
   public class Empleado :ICatalogo
    {
     
        public void Insertar(object objEmpleado)
        {
            var empleado = (EEmpleado) objEmpleado;
            SqlCommand comando = Metodos.CrearComando();
            const string sqlQuery = "INSERT INTO Empleado VALUES(@nombre,@apellido,@telefono,@direccion," +
                                    "@puesto,@estatus,@nombre_usuario,@contrasena, @numero_empleado,@rfc,@estatura,@peso," +
                                    "@referencia,@contacto_personal,@tipo_sangre,@fecha_contratacion,@genero, @departamento,@fecha_terminacion," +
                                    "@fecha_nacimiento, @administrador,@calle, @colonia, @ciudad, @codigo_postal,@curp,"+
                                    "@numero_afiliacion,@credito_infonavit)";
            comando.CommandText = sqlQuery;
            comando.Parameters.AddWithValue("@nombre", empleado.Nombre);
            comando.Parameters.AddWithValue("@apellido", empleado.Apellido);
            comando.Parameters.AddWithValue("@telefono", empleado.Telefono);
            comando.Parameters.AddWithValue("@direccion", empleado.Direccion);
            comando.Parameters.AddWithValue("@puesto", empleado.Puesto);
            comando.Parameters.AddWithValue("@estatus", empleado.Estatus);
            comando.Parameters.AddWithValue("@nombre_usuario", empleado.NombreUsuario);
            comando.Parameters.AddWithValue("@contrasena", empleado.Contrasena);
            comando.Parameters.AddWithValue("@numero_empleado", empleado.NumeroEmpleado);
            comando.Parameters.AddWithValue("@rfc", empleado.Rfc);
            comando.Parameters.AddWithValue("@estatura", empleado.Estatura);
            comando.Parameters.AddWithValue("@peso", empleado.Peso);
            comando.Parameters.AddWithValue("@referencia", empleado.Referencia);
            comando.Parameters.AddWithValue("@contacto_personal", empleado.ContactoPersonal);
            comando.Parameters.AddWithValue("@tipo_sangre", empleado.TipoSangre);
            comando.Parameters.AddWithValue("@fecha_contratacion", empleado.FechaContratacion);
            comando.Parameters.AddWithValue("@genero", empleado.Genero);
            comando.Parameters.AddWithValue("@departamento", empleado.Departamento);

            if (empleado.FechaTerminacion != DateTime.MinValue)
                comando.Parameters.AddWithValue("@fecha_terminacion", empleado.FechaTerminacion);
            else
                comando.Parameters.AddWithValue("@fecha_terminacion", DBNull.Value);

            if (empleado.FechaNacimiento != DateTime.MinValue)
                comando.Parameters.AddWithValue("@fecha_nacimiento", empleado.FechaNacimiento);
            else
                comando.Parameters.AddWithValue("@fecha_nacimiento", DBNull.Value);

            comando.Parameters.AddWithValue("@administrador", empleado.Administrador);
            comando.Parameters.AddWithValue("@calle", empleado.Calle);
            comando.Parameters.AddWithValue("@colonia", empleado.Colonia);
            comando.Parameters.AddWithValue("@ciudad", empleado.Ciudad);
            comando.Parameters.AddWithValue("@codigo_postal", empleado.CodigoPostal);
            comando.Parameters.AddWithValue("@curp", empleado.Curp);
            comando.Parameters.AddWithValue("@numero_afiliacion", empleado.NumeroAfiliacion);
            comando.Parameters.AddWithValue("@credito_infonavit", empleado.CreditoInfonavit);
            Metodos.EjecutarComando(comando);
        }

        public void Actualizar(object objEmpleado)
        {
            var empleado = (EEmpleado)objEmpleado;
            SqlCommand comando = Metodos.CrearComando();
            const string sqlQuery = "UPDATE  Empleado SET [nombre]=@nombre,[apellido]=@apellido,[telefono]=@telefono,[direccion]=@direccion," +
                                    "[puesto]=@puesto,[estatus]=@estatus,[nombre_usuario]=@nombre_usuario,[contrasena]=@contrasena,[numero_empleado]=@numero_empleado,[rfc]=@rfc,[estatura]=@estatura,[peso]=@peso," +
                                    "[referencia]=@referencia,[contacto_personal]=@contacto_personal,[tipo_sangre]=@tipo_sangre,[fecha_contratacion]=@fecha_contratacion,[genero]=@genero,[departamento]= @departamento,[fecha_terminacion]=@fecha_terminacion," +
                                    "[fecha_nacimiento]=@fecha_nacimiento,[administrador]=@administrador,[calle]=@calle, [colonia]=@colonia, [ciudad]=@ciudad, [codigo_postal]=@codigo_postal,[curp]=@curp," +
                                    "[numero_afiliacion]=@numero_afiliacion,[credito_infonavit]=@credito_infonavit WHERE [id_empleado]=@id_empleado";
            comando.CommandText = sqlQuery;
            comando.Parameters.AddWithValue("@id_empleado", empleado.Id);
            comando.Parameters.AddWithValue("@nombre", empleado.Nombre);
            comando.Parameters.AddWithValue("@apellido", empleado.Apellido);
            comando.Parameters.AddWithValue("@telefono", empleado.Telefono);
            comando.Parameters.AddWithValue("@direccion", empleado.Direccion);
            comando.Parameters.AddWithValue("@puesto", empleado.Puesto);
            comando.Parameters.AddWithValue("@estatus", empleado.Estatus);
            comando.Parameters.AddWithValue("@nombre_usuario", empleado.NombreUsuario);
            comando.Parameters.AddWithValue("@contrasena", empleado.Contrasena);
            comando.Parameters.AddWithValue("@numero_empleado", empleado.NumeroEmpleado);
            comando.Parameters.AddWithValue("@rfc", empleado.Rfc);
            comando.Parameters.AddWithValue("@estatura", empleado.Estatura);
            comando.Parameters.AddWithValue("@peso", empleado.Peso);
            comando.Parameters.AddWithValue("@referencia", empleado.Referencia);
            comando.Parameters.AddWithValue("@contacto_personal", empleado.ContactoPersonal);
            comando.Parameters.AddWithValue("@tipo_sangre", empleado.TipoSangre);
            comando.Parameters.AddWithValue("@fecha_contratacion", empleado.FechaContratacion);
            comando.Parameters.AddWithValue("@genero", empleado.Genero);
            comando.Parameters.AddWithValue("@departamento", empleado.Departamento);
            if (empleado.FechaTerminacion != DateTime.MinValue)
                comando.Parameters.AddWithValue("@fecha_terminacion", empleado.FechaTerminacion);
            else
                comando.Parameters.AddWithValue("@fecha_terminacion", DBNull.Value);

            if (empleado.FechaNacimiento != DateTime.MinValue)
                comando.Parameters.AddWithValue("@fecha_nacimiento", empleado.FechaNacimiento);
            else
                comando.Parameters.AddWithValue("@fecha_nacimiento", DBNull.Value);

            comando.Parameters.AddWithValue("@administrador", empleado.Administrador);
            comando.Parameters.AddWithValue("@calle", empleado.Calle);
            comando.Parameters.AddWithValue("@colonia", empleado.Colonia);
            comando.Parameters.AddWithValue("@ciudad", empleado.Ciudad);
            comando.Parameters.AddWithValue("@codigo_postal", empleado.CodigoPostal);
            comando.Parameters.AddWithValue("@curp", empleado.Curp);
            comando.Parameters.AddWithValue("@numero_afiliacion", empleado.NumeroAfiliacion);
            comando.Parameters.AddWithValue("@credito_infonavit", empleado.CreditoInfonavit);
            Metodos.EjecutarComando(comando);
        }

        public void Eliminar(int idEmpleado)
        {
            string sqlQuery = "DELETE FROM Empleado WHERE id_empleado="+ idEmpleado;
            SqlCommand comando = Metodos.CrearComando();
            comando.CommandText = sqlQuery;
            Metodos.EjecutarComando(comando);

        }



       public object ObtenerPorId(int idEmpleado)
       {
           SqlCommand comando = Metodos.CrearComando();
           comando.CommandText = "SELECT* FROM Empleado WHERE id_empleado = " + idEmpleado;
           DataTable tabla = Metodos.EjecutarComandoSelect(comando);
           if (tabla.Rows.Count <= 0) return null;
            var row = tabla.Rows[0];
           EEmpleado empleado = new EEmpleado();
            empleado.Id = Convert.ToInt32(row["id_empleado"]);
            empleado.Nombre = Convert.ToString(row["nombre"]);
            empleado.Apellido = Convert.ToString(row["apellido"]);
            empleado.Telefono = Convert.ToString(row["telefono"]);
            empleado.Direccion = Convert.ToString(row["direccion"]);
            empleado.Puesto = Convert.ToString(row["puesto"]);
            empleado.Estatus = Convert.ToInt32(row["estatus"]);
            empleado.NombreUsuario = Convert.ToString(row["nombre_usuario"]);
            empleado.Contrasena = Convert.ToString(row["contrasena"]);
            empleado.NumeroEmpleado = Convert.ToString(row["numero_empleado"]);
            empleado.Rfc = Convert.ToString(row["rfc"]);
            empleado.Estatura = Convert.ToString(row["estatura"]);
            empleado.Peso = Convert.IsDBNull(row["peso"]) ? 0 : Convert.ToInt32(row["peso"]);
            empleado.Referencia = Convert.ToString(row["referencia"]);
            empleado.ContactoPersonal = Convert.ToString(row["contacto_personal"]);
            empleado.TipoSangre = Convert.ToString(row["tipo_sangre"]);
            empleado.FechaContratacion = Convert.IsDBNull(row["fecha_contratacion"]) ? DateTime.MinValue : Convert.ToDateTime(row["fecha_contratacion"]);
            empleado.FechaTerminacion = Convert.IsDBNull(row["fecha_terminacion"]) ? DateTime.MinValue : Convert.ToDateTime(row["fecha_terminacion"]);
            empleado.FechaNacimiento = Convert.IsDBNull(row["fecha_nacimiento"]) ? DateTime.MinValue : Convert.ToDateTime(row["fecha_nacimiento"]);
            empleado.Genero = Convert.IsDBNull(row["genero"]) ? 'N' : Convert.ToChar(row["genero"]);
            empleado.Departamento = Convert.IsDBNull(row["departamento"]) ? 0 : Convert.ToInt32(row["departamento"]);
            empleado.Administrador = Convert.IsDBNull(row["administrador"]) ? 0 : Convert.ToInt32(row["administrador"]);
            empleado.Calle = row["calle"].ToString();
            empleado.Colonia = row["colonia"].ToString();
            empleado.Ciudad = row["ciudad"].ToString();
            empleado.CodigoPostal = Convert.IsDBNull(row["codigo_postal"]) ? 0 : Convert.ToInt32(row["codigo_postal"]);
            empleado.Curp =row["curp"].ToString();
            empleado.NumeroAfiliacion = row["numero_afiliacion"].ToString();
            empleado.CreditoInfonavit = row["credito_infonavit"].ToString();
           return empleado;
           
       }

       public DataTable ObtenerLista()
        {
            SqlCommand comando = Metodos.CrearComando();
            comando.CommandText = "SELECT * FROM Empleado";
            DataTable tabla = Metodos.EjecutarComandoSelect(comando);
            return tabla;
        }
        public DataTable ObtenerVista()
        {
            SqlCommand comando = Metodos.CrearComando();
            comando.CommandText = "SELECT * FROM vw_Empleado";
            DataTable tabla = Metodos.EjecutarComandoSelect(comando);
            return tabla;
        }

        
        public bool EmpleadoExistente(int idEmpleado)
        {
            SqlCommand comando = Metodos.CrearComando();
            comando.CommandText = "SELECT * FROM Empleado WHERE id_empleado = " + idEmpleado;
            DataTable tabla = Metodos.EjecutarComandoSelect(comando);
            return tabla.Rows.Count > 0;
        }
    }
}
