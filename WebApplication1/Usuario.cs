using System;

namespace WebApplication1
{
    public class Usuario
    {

        int id;
        string nombre;
        string email;
        string contrasenya;
        DateTime fechaNacimiento;
        string tipoPermiso;

        public Usuario()
        {
        }

        public Usuario(string nombre, string email, string contrasenya, DateTime fechaNacimiento)
        {
            this.nombre = nombre;
            this.email = email;
            this.contrasenya = contrasenya;
            this.fechaNacimiento = fechaNacimiento;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Email { get => email; set => email = value; }
        public string TipoPermiso { get => tipoPermiso; set => tipoPermiso = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Contrasenya { get => contrasenya; set => contrasenya = value; }
    }
}