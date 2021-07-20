namespace WebApplication1
{
    internal class Usuario
    {

        int id;
        string nombre;
        string email;
        string tipoPermiso;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Email { get => email; set => email = value; }
        public string TipoPermiso { get => tipoPermiso; set => tipoPermiso = value; }
    }
}