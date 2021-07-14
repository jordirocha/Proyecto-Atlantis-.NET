using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace WebApplication1
{
    public class DALUsuario
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
            return registro.Read();
        }
    }
}