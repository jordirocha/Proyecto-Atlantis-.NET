using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
	public partial class PanelDarPuntos : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            if (Session["rol"] == null || Session["rol"].ToString() != "ong")
            {
                Response.Redirect("Default.aspx");
            }
        }

        protected void FilaSeleccionada(object sender, EventArgs e)
        {
            int id = int.Parse(GridView1.SelectedRow.Cells[0].Text);
            int puntos = int.Parse(GridView1.SelectedRow.Cells[5].Text);
            ActividadDAL actividad = new ActividadDAL();
            actividad.ConcederPuntosUsuario(id, puntos);
            Response.Redirect("PanelDarPuntos.aspx");
        }
    }
}