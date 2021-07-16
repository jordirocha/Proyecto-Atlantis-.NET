using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class LogIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButIniciarSesion(object sender, EventArgs e)
        {
            DALUsuario dalUser = new DALUsuario();

            if (dalUser.IniciarSesion(TextBox1.Text, TextBox2.Text))
            {
                Usuario user = dalUser.VerificarUsuario(TextBox1.Text);
                Session["nombre"] = user.Nombre;
                Response.Redirect("Default.aspx");
            }
            else
            {
                TxtLogInFailed.Text = "Datos incorrectos, inténtalo de nuevo";
            }
        }
    }
}