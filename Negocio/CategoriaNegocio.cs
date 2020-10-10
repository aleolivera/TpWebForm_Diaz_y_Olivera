using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> listar()
        {
            SqlDataReader lector;
            List<Categoria> lista= new List<Categoria>();
            SqlCommand comando = new SqlCommand();
            SqlConnection conexion = new SqlConnection();

            //comentamos y descomentamos para poder usar la base de datos local de cada uno
            conexion.ConnectionString= "data source=ALE\\SQLEXPRESS; initial catalog = CATALOGO_DB; integrated security = sspi";
            //conexion.ConnectionString = "Data Source= DESKTOP-3EDAK3V\\SQLEXPRESS; initial catalog= CATALOGO_DB;integrated security= sspi";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "select * from CATEGORIAS";
            comando.Connection = conexion;

            conexion.Open();
            lector = comando.ExecuteReader();

            while (lector.Read())
            {
                lista.Add(new Categoria ((int)lector["id"],(string)lector["Descripcion"]));

            }
            lector.Close();
            conexion.Close();
            return lista;
        }

    }
}
