using System.Data.SqlClient;

namespace WebApplication1
{
    internal class DbConnection
    {
        SqlConnection conexion = null;

        public SqlConnection Conexion { get => conexion; set => conexion = value; }

        public DbConnection()
        {
            conexion = new SqlConnection();
            this.conexion = new SqlConnection("Server=161.22.42.238,54321;Database=Atlantis;User Id=sa;Password=123456789Net3;");
            conexion.Open();
        }
    }
}