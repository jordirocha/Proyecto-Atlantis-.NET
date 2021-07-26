using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButFormContacto(object sender, EventArgs e)
        {
            TxtFormEnviado.Text = "";
            TxtFormEnviado2.Text = "";

            if (string.IsNullOrEmpty(TextEmail.Text) || string.IsNullOrEmpty(TextAsunto.Text) || string.IsNullOrEmpty(TextMensaje.Text))
            {
                TextEmail.Text = "";
                TextAsunto.Text = "";
                TextMensaje.Text = "";
                TxtFormEnviado2.Text = "No has completado todos los campos. Inténtalo de nuevo.";
            }
            else
                TxtFormEnviado.Text = "¡Formulario enviado con éxito!";
  
        }

        protected void ButSuscripcionEmail(object sender, EventArgs e)
        {
            TxtSuscripcionEnviada.Text = "";
            TxtSuscripcionEnviada2.Text = "";
            if (!string.IsNullOrEmpty(TextEmail2.Text))
                TxtSuscripcionEnviada.Text = "¡Suscripción realizada!";
            else
                TxtSuscripcionEnviada2.Text = "Ingresa un email válido.";
        }


    }
}