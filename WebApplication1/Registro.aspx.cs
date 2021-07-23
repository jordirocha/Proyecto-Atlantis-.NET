using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ClickRegistrarse(object sender, EventArgs e)
        {
            RegistroUser user = new RegistroUser();
            if (!user.ComprobarCampos(TxtName.Text, TxtEmail.Text, TxtPass.Text, DateTime.Parse(TextFecha.Text)))
            {
                if (!user.ExisteEmail(TxtEmail.Text) && user.ComprobarPasswords(TxtPass.Text, TxtPass2.Text) == 0)
                {
                    Usuario usuario = new Usuario();
                    usuario.Nombre = TxtName.Text;
                    usuario.Email = TxtEmail.Text;
                    usuario.Contrasenya = TxtPass.Text;
                    usuario.FechaNacimiento = DateTime.Parse(TextFecha.Text);
                    user.Registro(usuario);
                    Response.Redirect("Default.aspx");
                }
                else { 
                    Label1.Text = "Existe email o contraseñas no coinciden"; 
                }

            }
            else
            {
                Label1.Text = "Campos erroneos";
            }
        }
    }
}