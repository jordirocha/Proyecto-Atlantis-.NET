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
            // CargarEventos();
            // SqlDataSource1.SelectParameters["@IdUsu"].DefaultValue = /*Session["id"].ToString();*/ "14";
            // GridView1.DataBind();
            if (Session["rol"] == null || Session["rol"].ToString() != "admin")
            {
                Response.Redirect("Default.aspx");
            }
        }

        protected void ButInsertEvento(object sender, EventArgs e)
        {
            HttpPostedFile postedFile = FotoEvento.PostedFile;
            Stream stream = postedFile.InputStream;
            BinaryReader binaryReader = new BinaryReader(stream);
            byte[] bytesFoto = binaryReader.ReadBytes((int)stream.Length);

            DALEvento evento = new DALEvento();

            evento.InsertarEvento(TxtNomEvento.Text,
                TxtDesc.Text,
                DateTime.Parse(TxtFechaEvento.Text),
                int.Parse(TxtPuntos.Text),
                TxtUbicacion.Text,
                int.Parse(TxtAforo.Text),
                bytesFoto,
                int.Parse(Session["id"].ToString()));

            Response.Redirect("PanelEventos.aspx");
        }

        /*public void CargarEventos()
        {
            DALEvento eventos = new DALEvento();
            GridView1.DataSource = eventos.SeleccionarEventos();
            GridView1.DataBind();
        }*/
    }
}