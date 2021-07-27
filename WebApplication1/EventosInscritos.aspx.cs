using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class EventosInscritos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["rol"] == null || Session["rol"].ToString() != "user")
            {
                Response.Redirect("Default.aspx");
            }
        }

        protected void CancelarEvento(object sender, EventArgs e)
        {
            // var id = int.Parse(GridView1.SelectedRow.Cells[0].Text);
            var puntos = GridView1.SelectedRow.Cells[0].Text;
            int id = int.Parse(Session["id"].ToString());
            DALUsuario usu = new DALUsuario();
            usu.CancelarEvento(id, puntos);
            Response.Redirect("EventosInscritos.aspx");
        }
    }
}