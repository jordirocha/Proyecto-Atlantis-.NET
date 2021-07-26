using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class PanelActividades : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["rol"] == null || Session["rol"].ToString() != "ong")
            {
                Response.Redirect("Default.aspx");
            }
        }

   /*     protected void ActivdadEliminado(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values[0]);
        }
   */
        protected void ButAnyadirNuevoAct(object sender, EventArgs e)
        {
            HttpPostedFile postedFile = FotoAct.PostedFile;
            Stream stream = postedFile.InputStream;
            BinaryReader binaryReader = new BinaryReader(stream);
            byte[] bytesFoto = binaryReader.ReadBytes((int)stream.Length);

            ActividadDAL act = new ActividadDAL();

            act.InsertarEvento(TxtNomAct.Text,
                TxtDesc.Text,
                DateTime.Parse(TxtFechaAct.Text),
                int.Parse(TxtPuntos.Text),
                TxtUbicacion.Text,
                int.Parse(TxtAforo.Text),
                bytesFoto,
                int.Parse(Session["id"].ToString()));

            Response.Redirect("PanelActividades.aspx");
        }

        protected void ActividadEliminada(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values[0]);
        }
    }
}