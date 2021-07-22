using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void mostrarRegistros()
        {
            DbConnection cnx;
            cnx = new DbConnection();

            string sql = @"SELECT count(*)
                            FROM dbo.Usuario";
            SqlCommand cmd = new SqlCommand(sql, cnx.Conexion);
            MostrarRegistros.Text = cmd.ExecuteScalar().ToString();

        }

        protected void MostrarActividades()
        {

        }

        protected void MostrarEventos()
        {

        }
    }
}