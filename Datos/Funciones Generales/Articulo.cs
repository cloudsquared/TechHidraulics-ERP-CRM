using System;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Datos.Funciones_Generales
{
    public class Articulo:ICatalogo
    {

        public void Insertar(object objArticulo)
        {
            var articulo = (EArticulo)objArticulo;

            SqlCommand comando = Metodos.CrearComando();
            string sqlQuery = string.Format("INSERT INTO Articulo VALUES ('{0}','{1}',{2},{3},{4},{5},{6},{7},{8},'{9}','{10}',{11})",
            articulo.Nombre, articulo.Descripcion, articulo.CantidadExistencia, articulo.CantidadMinima, articulo.Precio, articulo.Estatus,
            articulo.TipoUnidad, articulo.Categoria, articulo.Subcategoria, articulo.Marca, articulo.Codigo, articulo.ProductoRelacionado);
            comando.CommandText = sqlQuery;
            Metodos.EjecutarComando(comando);
            
        }

        public void Actualizar(object objArticulo)
        {
            var articulo = (EArticulo)objArticulo;

            SqlCommand comando = Metodos.CrearComando();
            string sqlQuery = string.Format("UPDATE Articulo SET [nombre] = '{0}',[descripcion] ='{1}',[cantidad_existencia] ={2},[cantidad_minima] ={3},[precio] ={4},[estatus]={5},[tipo_unidad] ={6},[categoria] ={7},[subcategoria] ={8},[marca] ='{9}',[codigo] ='{10}',[id_producto]=null WHERE id_articulo={11}",
            articulo.Nombre, articulo.Descripcion, articulo.CantidadExistencia, articulo.CantidadMinima, articulo.Precio, articulo.Estatus,
            articulo.TipoUnidad, articulo.Categoria, articulo.Subcategoria, articulo.Marca, articulo.Codigo,articulo.Id);
            comando.CommandText = sqlQuery;
            Metodos.EjecutarComando(comando);
        }

        public void Eliminar(int idArticulo)
        {
            string sqlQuery = "DELETE FROM Articulo WHERE id_articulo="+ idArticulo;
            SqlCommand comando = Metodos.CrearComando();
            comando.CommandText = sqlQuery;
            Metodos.EjecutarComando(comando);
            
        }



        public object ObtenerPorId(int idArticulo)
        {
            SqlCommand comando = Metodos.CrearComando();
            EArticulo articulo=null;
            comando.CommandText = "SELECT* FROM Articulo WHERE id_articulo = " + idArticulo;
            DataTable tabla = Metodos.EjecutarComandoSelect(comando);
            if (tabla.Rows.Count > 0)
            {
                var row = tabla.Rows[0];
                articulo = new EArticulo
                {
                    Id = Convert.ToInt32(row["id_articulo"]),
                    Nombre = Convert.ToString(row["nombre"]),
                    Descripcion = Convert.ToString(row["descripcion"]),
                    CantidadExistencia = Convert.ToDecimal(row["cantidad_existencia"]),
                    CantidadMinima = Convert.ToDecimal(row["cantidad_minima"]),
                    Precio = Convert.ToDecimal(row["precio"]),
                    Estatus = Convert.ToInt32(row["estatus"]),
                    TipoUnidad = Convert.ToInt32(row["tipo_unidad"]),
                    Categoria = Convert.ToInt32(row["categoria"]),
                    Subcategoria = Convert.ToInt32(row["subcategoria"]),
                    Marca = Convert.ToString(row["marca"]),
                    Codigo = Convert.ToString(row["codigo"]),
                    ProductoRelacionado = 0
                };
            }
            return articulo;
        }

        public DataTable ObtenerLista()
        {
            SqlCommand comando = Metodos.CrearComando();
            comando.CommandText = "SELECT * FROM Articulo";
            DataTable tabla = Metodos.EjecutarComandoSelect(comando);
            return tabla;
        }
        public DataTable ObtenerVista()
        {
            SqlCommand comando = Metodos.CrearComando();
            comando.CommandText = "SELECT * FROM vw_articulo";
            DataTable tabla = Metodos.EjecutarComandoSelect(comando);
            return tabla;
        }

        


        public bool ArticuloExistente(int idArticulo)
        {
            SqlCommand comando = Metodos.CrearComando();
            comando.CommandText = "SELECT * FROM Articulo WHERE id_articulo = " + idArticulo;
            DataTable tabla = Metodos.EjecutarComandoSelect(comando);
            if (tabla.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }


    }
}
