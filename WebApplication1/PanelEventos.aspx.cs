using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class PanelEventos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarEventos();
            
        }
     
        protected void ButInsertEvento(object sender, EventArgs e)
        {
            HttpPostedFile postedFile = FotoEvento.PostedFile;
            Stream stream = postedFile.InputStream;
            BinaryReader binaryReader = new BinaryReader(stream);
            byte[] bytes = binaryReader.ReadBytes((int)stream.Length);
            // Insert nuevo evento
            DbConnection con = new DbConnection();
            SqlCommand cmd = new SqlCommand("insertarEvento", con.Conexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter pNombre = new SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 100);
            pNombre.Value = TxtNomEvento.Text;
            cmd.Parameters.Add(pNombre);

            SqlParameter pDesc = new SqlParameter("@descripcion", System.Data.SqlDbType.VarChar);
            pDesc.Value = TxtDesc.Text;
            cmd.Parameters.Add(pDesc);

            SqlParameter pfecha = new SqlParameter("@fecha", DateTime.Parse(TxtFechaEvento.Text));
            cmd.Parameters.Add(pfecha);

            SqlParameter pPuntos = new SqlParameter("@puntos", TxtPuntos.Text);
            cmd.Parameters.Add(pPuntos);

            SqlParameter pUbicacion = new SqlParameter("@ubicacion", System.Data.SqlDbType.VarChar, 100);
            pUbicacion.Value = TxtUbicacion.Text;
            cmd.Parameters.Add(pUbicacion);

            SqlParameter pAforo = new SqlParameter("@limite", TxtAforo.Text);
            cmd.Parameters.Add(pAforo);

            SqlParameter pFoto = new SqlParameter("@foto", bytes);
            cmd.Parameters.Add(pFoto);

            cmd.ExecuteNonQuery();
            CargarEventos();

            Response.Redirect("PanelEventos.aspx");
        }

        public void CargarEventos()
        {
            DALEvento eventos = new DALEvento();
            GridView1.DataSource = eventos.SeleccionarEventos();
            GridView1.DataBind();
        }
    }
}