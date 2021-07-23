using System;
using System.Collections.Generic;
using System.Data;
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

            mostrarRegistros();
            mostrarActividades();
            mostrarEventos();
        }

        protected void mostrarRegistros()
        {
            DbConnection cnx;
            cnx = new DbConnection();
            
            string sql = @"SELECT count(*) as totalregistros
                            FROM Usuario";
            SqlCommand cmd = new SqlCommand(sql, cnx.Conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            registrostotal.Text = dt.Rows[0]["totalregistros"].ToString();
           
            cnx.Conexion.Close();

        }

        protected void mostrarActividades()
        {
            DbConnection cnx;
            cnx = new DbConnection();

            string sql = @"SELECT count(*) as totalactividades
                            FROM dbo.Actividad";
            SqlCommand cmd = new SqlCommand(sql, cnx.Conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            actividadestotal.Text = dt.Rows[0]["totalactividades"].ToString();

            cnx.Conexion.Close();
        }

        protected void mostrarEventos()
        {
            DbConnection cnx;
            cnx = new DbConnection();

            string sql = @"SELECT count(*) as totaleventos
                            FROM dbo.Evento";
            SqlCommand cmd = new SqlCommand(sql, cnx.Conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            eventostotal.Text = dt.Rows[0]["totaleventos"].ToString();

            cnx.Conexion.Close();
        }
    }
}