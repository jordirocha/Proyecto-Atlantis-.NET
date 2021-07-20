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
            if (Response.Cookies["correo"].Value != null && Response.Cookies["password"].Value != null)
            {
                DALUsuario dalUser = new DALUsuario();
                Usuario user = dalUser.VerificarUsuario(Response.Cookies["correo"].Value);
                Session["nombre"] = user.Nombre;
                Session["rol"] = user.TipoPermiso;
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
                if (CheckCookies.Checked)
                {
                    HttpCookie cookie1 = new HttpCookie("correo", TextEmail.Text);
                    cookie1.Expires = DateTime.Now.AddMinutes(1);
                    Response.Cookies.Add(cookie1);

                    HttpCookie cookie2 = new HttpCookie("password", TextPass.Text);
                    cookie2.Expires = DateTime.Now.AddMinutes(1);
                    Response.Cookies.Add(cookie2);
                    /* Response.Cookies["email"].Value = TextEmail.Text;
                     Response.Cookies["password"].Value = TextPass.Text;
                     Response.Cookies["email"].Expires = DateTime.Now.AddMinutes(1);
                     Response.Cookies["password"].Expires = DateTime.Now.AddMinutes(1);*/
                }
                Response.Redirect("Default.aspx");
            }
            else
            {
                TxtLogInFailed.Text = "Datos incorrectos, inténtalo de nuevo";
            }
        }

        protected void CheckRecordar(object sender, EventArgs e)
        {

        }
    }
}