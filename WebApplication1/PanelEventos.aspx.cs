using System;
using System.Collections.Generic;
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
            Evento eventos = new Evento();
            GridView1.DataSource = eventos.seleccionarEventos();
            GridView1.DataBind();
        }
    }
}