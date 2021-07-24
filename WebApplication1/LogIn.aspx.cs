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
            HttpCookie checkCookie = Request.Cookies["userInfo"];
            if (checkCookie != null)
            {
                DALUsuario dalUser = new DALUsuario();
                Usuario user = dalUser.VerificarUsuario(checkCookie["email"]);
                Session["nombre"] = user.Nombre;
                Session["rol"] = user.TipoPermiso;
                Session["id"] = user.Id;
                Response.Redirect("Default.aspx");
               
            }
        }
        protected void ButIniciarSesion(object sender, EventArgs e)
        {
            DALUsuario dalUser = new DALUsuario();

            if (dalUser.IniciarSesion(TextEmail.Text, TextPass.Text))
            {
                Usuario user = dalUser.VerificarUsuario(TextEmail.Text);
                Session["nombre"] = user.Nombre;
                Session["rol"] = user.TipoPermiso;
                Session["id"] = user.Id;
                if (CheckCookies.Checked)
                {
                    HttpCookie cookie = new HttpCookie("userInfo");
                    cookie["email"] = TextEmail.Text;
                    cookie["pass"] = TextPass.Text;
                    cookie.Expires = DateTime.Now.AddDays(1);
                    Response.Cookies.Add(cookie);
                }
                Response.Redirect("Default.aspx");
            }
            else
            {
                TxtLogInFailed.Text = "Datos incorrectos, inténtalo de nuevo";
            }
        }

     
    }
}