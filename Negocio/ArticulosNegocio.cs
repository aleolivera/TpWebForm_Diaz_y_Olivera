using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;


namespace Negocio
{
    public class ArticulosNegocio
    {
        public List<Articulos> listar()
        {
            //SqlConnection conexion = new SqlConnection();
            //SqlCommand comando = new SqlCommand();
            //SqlDataReader lector;
            List<Articulos> lista = new List<Articulos>();


           // //comentamos y descomentamos para poder usar la base de datos local de cada uno
           //conexion.ConnectionString = "Data Source= ALE\\SQLEXPRESS; initial catalog= CATALOGO_DB;integrated security= sspi";
           // //conexion.ConnectionString = "Data Source= DESKTOP-3EDAK3V\\SQLEXPRESS; initial catalog= CATALOGO_DB;integrated security= sspi";
           // comando.CommandType = System.Data.CommandType.Text;
           //// comando.CommandText = "Select A.ID,A.Codigo,A.Nombre, A.Descripcion, A.ImagenUrl, A.Precio, M.Descripcion Marcas From ARTICULOS A, MARCAS M where A.IdMarca= M.Id";
           // comando.CommandText = "Select A.ID,A.Codigo,A.Nombre,A.Descripcion,A.ImagenUrl,A.Precio, m.Descripcion Marcas, isnull(c.Descripcion,'Sin definir') Categoria from ARTICULOS A left join MARCAS m on m.Id=a.IdMarca left join CATEGORIAS c on c.Id=a.IdCategoria";


            AccesoDatos datos = new AccesoDatos();
            datos.setearQuery("Select A.ID,A.Codigo,A.Nombre,A.Descripcion,A.ImagenUrl,A.Precio, m.Descripcion Marcas, isnull(c.Descripcion,'Sin definir') Categoria from ARTICULOS A left join MARCAS m on m.Id=a.IdMarca left join CATEGORIAS c on c.Id=a.IdCategoria");
            datos.ejecutarLector();
            while (datos.reader.Read())
            {
                Articulos aux = new Articulos();
                aux.Id = (int)datos.reader["ID"];
                aux.Codigo = datos.reader.GetString(1);
                aux.Nombre = datos.reader.GetString(2);
                aux.Descripcion = datos.reader.GetString(3);
                aux.ImagenUrl = (string)datos.reader["ImagenUrl"];
                aux.Precio = datos.reader.GetSqlMoney(5);

                aux.marca = new Marca();
                aux.marca.descripcion = (string)datos.reader["Marcas"];
                aux.categoria = new Categoria();
                aux.categoria.descripcion = (string)datos.reader["Categoria"];
                lista.Add(aux);

            }
            datos.cerrarConexion();
            
            
            //comando.Connection = conexion;

            //conexion.Open();
            //lector = comando.ExecuteReader();

            //while (lector.Read())
            //{
            //    Articulos aux = new Articulos();
            //    aux.Id = (int)lector["ID"];
            //    aux.Codigo = lector.GetString(1);
            //    aux.Nombre = lector.GetString(2);
            //    aux.Descripcion = lector.GetString(3);
            //    aux.ImagenUrl = (string)lector["ImagenUrl"];
            //    aux.Precio = lector.GetSqlMoney(5);

            //    aux.marca = new Marca();
            //    // aux.marca.ID =(int)lector["IdMarca"];
            //    aux.marca.descripcion = (string)lector["Marcas"];
            //    aux.categoria = new Categoria();
            //    //aux.categoria.ID = (int)lector["IdCategoria"];
            //    aux.categoria.descripcion = (string)lector["Categoria"];

            //    lista.Add(aux);

            //}

            //conexion.Close();
            return lista;
        }
        
        public void Agregar(Articulos nuevo)
        {

            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.setearQuery("Insert into ARTICULOS(Codigo, Nombre, Descripcion, ImagenUrl,Precio,IdMarca, IdCategoria) values(@Codigo, @Nombre, @Descripcion, @imagenUrl,@Precio,@IdMarca, @IdCategoria)");
                
                conexion.agregarParametro("@Codigo", nuevo.Codigo);
                conexion.agregarParametro("@Nombre", nuevo.Nombre);
                conexion.agregarParametro("@Descripcion", nuevo.Descripcion);
                conexion.agregarParametro("@ImagenUrl", nuevo.ImagenUrl);
                conexion.agregarParametro("@Precio", nuevo.Precio);
                conexion.agregarParametro("@IdMarca", nuevo.marca.ID);
                conexion.agregarParametro("@IdCategoria", nuevo.categoria.ID);// MODIFICADO
                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        
        }

        public bool buscar(string codigo)
        {
            bool encontrado;
            //SqlConnection conexion = new SqlConnection();
            //SqlCommand comando = new SqlCommand();
            //SqlDataReader reader;

            ////comentamos y descomentamos para poder usar la base de datos local de cada uno
            //conexion.ConnectionString = "Data Source= ALE\\SQLEXPRESS; initial catalog= CATALOGO_DB;integrated security= sspi";
            ////conexion.ConnectionString = "Data Source= DESKTOP-3EDAK3V\\SQLEXPRESS; initial catalog= CATALOGO_DB;integrated security= sspi";
            //comando.CommandType = System.Data.CommandType.Text;
            //comando.CommandText = "Select A.ID,A.Codigo,A.Nombre,A.Descripcion,A.ImagenUrl,A.Precio, m.Descripcion Marcas, isnull(c.Descripcion,'Sin definir') Categoria from ARTICULOS A left join MARCAS m on m.Id=a.IdMarca left join CATEGORIAS c on c.Id=a.IdCategoria where a.Codigo='" + codigo + "'";
            //comando.Connection = conexion;

            AccesoDatos datos = new AccesoDatos();
            datos.setearQuery("Select A.ID,A.Codigo,A.Nombre,A.Descripcion,A.ImagenUrl,A.Precio, m.Descripcion Marcas, isnull(c.Descripcion,'Sin definir') Categoria from ARTICULOS A left join MARCAS m on m.Id=a.IdMarca left join CATEGORIAS c on c.Id=a.IdCategoria where a.Codigo='@codigo'");
            datos.agregarParametro("@codigo", codigo);
            datos.ejecutarLector();


            //conexion.Open();
            //reader = comando.ExecuteReader();
            
            encontrado = datos.reader.Read();
            //conexion.Close();
            //reader.Close();
            return encontrado;
        }
        public Articulos cargar(string codigo)
        {
            
            //SqlConnection conexion = new SqlConnection();
            //SqlCommand comando = new SqlCommand();
            //SqlDataReader lector;

            ////comentamos y descomentamos para poder usar la base de datos local de cada uno
            //conexion.ConnectionString = "Data Source= ALE\\SQLEXPRESS; initial catalog= CATALOGO_DB;integrated security= sspi";
            ////conexion.ConnectionString = "Data Source= DESKTOP-3EDAK3V\\SQLEXPRESS; initial catalog= CATALOGO_DB;integrated security= sspi";
            //comando.CommandType = System.Data.CommandType.Text;
            //comando.CommandText = "Select A.ID,A.Codigo,A.Nombre,A.Descripcion,A.ImagenUrl,A.Precio, m.Descripcion Marcas, isnull(c.Descripcion,'Sin definir') Categoria from ARTICULOS A left join MARCAS m on m.Id=a.IdMarca left join CATEGORIAS c on c.Id=a.IdCategoria where a.Codigo='" + codigo + "'";
            //comando.Connection = conexion;

            AccesoDatos datos = new AccesoDatos();
            datos.setearQuery("Select A.ID,A.Codigo,A.Nombre,A.Descripcion,A.ImagenUrl,A.Precio, m.Descripcion Marcas, isnull(c.Descripcion,'Sin definir') Categoria from ARTICULOS A left join MARCAS m on m.Id=a.IdMarca left join CATEGORIAS c on c.Id=a.IdCategoria where a.Codigo='@codigo'");
            datos.agregarParametro("@codigo", codigo);
            //conexion.Open();
            //lector = comando.ExecuteReader();


            Articulos aux = new Articulos();
            while (datos.reader.Read())
            {
                aux.Id= (int)datos.reader["ID"];
                aux.Codigo = datos.reader.GetString(1);

                aux.Nombre = datos.reader.GetString(2);
                aux.Descripcion = datos.reader.GetString(3);
                aux.ImagenUrl = (string)datos.reader["ImagenUrl"];
                aux.Precio = datos.reader.GetSqlMoney(5);
                aux.marca = new Marca();
                aux.marca.descripcion = (string)datos.reader["Marcas"];
                aux.categoria = new Categoria();
                aux.categoria.descripcion = (string)datos.reader["Categoria"];

            }
            datos.cerrarConexion();
            //conexion.Close();
            return aux;

        }
        
        public void modificar (Articulos nuevo)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.setearQuery("Update ARTICULOS set Codigo=@Codigo, Nombre= @Nombre, Descripcion= @Descripcion,ImagenUrl=@ImagenUrl, Precio= @Precio, IdMarca=@IdMarca, IdCategoria=@IdCategoria where Id=@Id");
                conexion.agregarParametro("@Id", nuevo.Id);
                conexion.agregarParametro("@Codigo",nuevo.Codigo);
                conexion.agregarParametro("@Nombre", nuevo.Nombre);
                conexion.agregarParametro("@Descripcion", nuevo.Descripcion);
                conexion.agregarParametro("@ImagenUrl", nuevo.ImagenUrl);
                conexion.agregarParametro("@Precio", nuevo.Precio);
                conexion.agregarParametro("@IdMarca", nuevo.marca.ID);
                conexion.agregarParametro("@IdCategoria", nuevo.categoria.ID);
                conexion.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }     
            

        }

        public bool eliminar(string codigo) 
        {
            //SqlConnection conexion = new SqlConnection();
            //SqlCommand comando = new SqlCommand();

            ////comentamos y descomentamos para poder usar la base de datos local de cada uno
            //conexion.ConnectionString = "Data Source= ALE\\SQLEXPRESS; initial catalog= CATALOGO_DB;integrated security= sspi";
            ////conexion.ConnectionString = "Data Source= DESKTOP-3EDAK3V\\SQLEXPRESS; initial catalog= CATALOGO_DB;integrated security= sspi";
            //comando.CommandType = System.Data.CommandType.Text;
            //comando.CommandText = "delete from ARTICULOS where Codigo='"+codigo+"'";
            //comando.Connection = conexion;

            AccesoDatos datos = new AccesoDatos();
            datos.setearQuery("delete from ARTICULOS where Codigo='@codigo'");
            datos.agregarParametro("@codigo",codigo);

            try 
            {
                datos.ejecutarAccion();
                datos.cerrarConexion();
                //conexion.Open();
                //comando.ExecuteNonQuery();
                //conexion.Close();
                //comando.Dispose();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
            
            
        }


    }
}
