using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Content
{
    public partial class PanelEventos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["rol"] == null || Session["rol"].ToString() != "admin")
            {
                Response.Redirect("Default.aspx");
            }
        }

        protected void ButAnyadirNuevoEvento(object sender, EventArgs e)
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


        protected void EventoEliminado(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values[0]);
        }

   
    }
}