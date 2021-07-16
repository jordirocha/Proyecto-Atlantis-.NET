using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Usuario
    {
        int id;
        string nombre;
        string email;
        string tipoPermiso;

        public int Id { get => id; set => id = value; }
        public string TipoPermiso { get => tipoPermiso; set => tipoPermiso = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Email { get => email; set => email = value; }
    }
}