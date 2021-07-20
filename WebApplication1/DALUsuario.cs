using System;
using System.Data.SqlClient;

namespace WebApplication1
{
    internal class DALUsuario
    {
        DbConnection conn = null;
        public DALUsuario()
        {
            conn = new DbConnection();
        }
        public bool IniciarSesion(string email, string pass)
        {
            string sqlLogIn = @"SELECT email, contraseña from USUARIO
            WHERE email = @pEmail and contraseña = @pPasswd";

            SqlCommand cmd = new SqlCommand(sqlLogIn, conn.Conexion);
            SqlParameter pEmail = new SqlParameter("@pEmail", System.Data.SqlDbType.VarChar, 50);
            pEmail.Value = email;
            SqlParameter pPass = new SqlParameter("@pPasswd", System.Data.SqlDbType.VarChar, 50);
            pPass.Value = pass;
            cmd.Parameters.Add(pEmail);
            cmd.Parameters.Add(pPass);
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.Read())
            {
                registro.Close();
                return true;
            }
            return false;
        }

        public Usuario VerificarUsuario(string email)
        {
            Usuario user = null;
            try
            {
                string sqlLogIn = @"SELECT * from USUARIO
            WHERE email = @pEmail";

                SqlCommand cmd = new SqlCommand(sqlLogIn, conn.Conexion);
                SqlParameter pEmail = new SqlParameter("@pEmail", email);
                cmd.Parameters.Add(pEmail);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    user = new Usuario();
                    user.Id = (int)dr["idUsuario"];
                    user.Nombre = (string)dr["nombre"];
                    user.Email = (string)dr["email"];
                    user.TipoPermiso = (string)dr["tipoUsuario"];
                }
                dr.Close();
            }
            catch (Exception ex)
            {
               // MessageBox.Show("Error en select: " + ex.Message);
            }

            return user;
        }
    }
}