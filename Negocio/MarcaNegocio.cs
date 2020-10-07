using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;

namespace Negocio
{
    public class MarcaNegocio
    {
        public List<Marca> listar()
        {
            List<Marca> lista = new List<Marca>();
            SqlConnection conexion = new SqlConnection();
            SqlDataReader reader;
            SqlCommand comando = new SqlCommand();

            //comentamos y descomentamos para poder usar la base de datos local de cada uno
            //conexion.ConnectionString = "data source=ALE\\SQLEXPRESS; initial catalog = CATALOGO_DB; integrated security = sspi";
            conexion.ConnectionString = "Data Source= DESKTOP-3EDAK3V\\SQLEXPRESS; initial catalog= CATALOGO_DB;integrated security= sspi";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "select * from MARCAS";
            comando.Connection = conexion;

            conexion.Open();
            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                lista.Add(new Marca((int)reader["id"],(string)reader["Descripcion"]));
            }
            
            reader.Close();
            conexion.Close();
            return lista;
        }
    }
}
