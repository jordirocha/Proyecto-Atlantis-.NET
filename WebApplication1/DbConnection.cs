using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class DbConnection
    {
        private static SqlConnection conexion = null;

        public SqlConnection Conexion { get => conexion; set => conexion = value; }

        public DbConnection()
        {
            conexion = new SqlConnection("Server=161.22.42.238,54321;Database=Atlantis;User Id=sa;Password=123456789Net3;");
            conexion.Open();
        }
        public static void CerrarConexion()
        {
            if (conexion != null)
                conexion.Close();
        }
    }
}
