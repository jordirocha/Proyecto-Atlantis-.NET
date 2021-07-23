using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace WebApplication1
{
    public class DALUsuario
    {
        static string clave = "cadenadecifrado"; // Clave de cifrado.   

        DbConnection conn = null;
        public DALUsuario()
        {
            conn = new DbConnection();
        }
        public bool IniciarSesion(string email, string pass)
        {
            string contrasenya = "";
            string sqlLogIn = @"SELECT contrasenya from USUARIO
            WHERE email = @pEmail";

            SqlCommand cmd = new SqlCommand(sqlLogIn, conn.Conexion);
            SqlParameter pEmail = new SqlParameter("@pEmail", System.Data.SqlDbType.VarChar, 50);
            pEmail.Value = email;
            cmd.Parameters.Add(pEmail);
            /* SqlParameter pPass = new SqlParameter("@pPasswd", System.Data.SqlDbType.VarChar, 50);
             pPass.Value = pass;
             cmd.Parameters.Add(pEmail);
             cmd.Parameters.Add(pPass);*/
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.Read())
            {
                registro.Close();
                contrasenya = (string)cmd.ExecuteScalar();
                contrasenya = Descifrar(contrasenya);
                if (contrasenya.CompareTo(pass) == 0)
                {
                    return true;
                }
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

        public string Descifrar(string cadena)
        {
            byte[] claveEncriptacion;

            // Arreglo donde guardaremos la cadena descovertida.
            byte[] conCifrado = Convert.FromBase64String(cadena);

            // Ciframos utilizando el Algoritmo MD5.
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            claveEncriptacion = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(clave));
            md5.Clear();

            //Desciframos utilizando el Algoritmo 3DES.
            TripleDESCryptoServiceProvider tripledes = new TripleDESCryptoServiceProvider();
            tripledes.Key = claveEncriptacion;
            tripledes.Mode = CipherMode.ECB;
            tripledes.Padding = PaddingMode.PKCS7;
            ICryptoTransform convertidor = tripledes.CreateDecryptor();

            byte[] descifrado = convertidor.TransformFinalBlock(conCifrado, 0, conCifrado.Length);
            tripledes.Clear();

            string cadena_descifrada = UTF8Encoding.UTF8.GetString(descifrado);

            return cadena_descifrada;
        }

    }
}