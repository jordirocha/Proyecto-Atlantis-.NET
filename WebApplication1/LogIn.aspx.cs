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
            DALUsuario dalUser = new DALUsuario();
            
            if (checkCookie != null)
            {
                if (dalUser.InciarSesionCookies(checkCookie["email"], checkCookie["pass"]))
                {
                    Usuario user = dalUser.VerificarUsuario(checkCookie["email"]);
                    Session["nombre"] = user.Nombre;
                    Session["rol"] = user.TipoPermiso;
                    Session["puntos"] = user.Puntos;
                    Response.Redirect("Default.aspx");
                }
                
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
                Session["puntos"] = user.Puntos;
                if (CheckCookies.Checked)
                {
                    HttpCookie cookie = new HttpCookie("userInfo");
                    cookie["email"] = TextEmail.Text;
                    cookie["pass"] = user.Contrasenya;
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