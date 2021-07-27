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
            /* string sqlLogIn = @"SELECT email, contrasenya from USUARIO
             WHERE email = @pEmail and contrasenya = @pPasswd";

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
             return false;*/
            string contrasenya = "";
            string sqlLogIn = @"SELECT contrasenya from USUARIO
            WHERE email = @pEmail";

            SqlCommand cmd = new SqlCommand(sqlLogIn, conn.Conexion);
            SqlParameter pEmail = new SqlParameter("@pEmail", System.Data.SqlDbType.VarChar, 50);
            pEmail.Value = email;
            cmd.Parameters.Add(pEmail);
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

        internal void CancelarActividad(int id, string actividad)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SalirActividad", conn.Conexion);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter pId = new SqlParameter("@idUser", id);
                cmd.Parameters.Add(pId);

                SqlParameter pAct = new SqlParameter("@nombreAct", System.Data.SqlDbType.VarChar);
                pAct.Value = actividad;
                cmd.Parameters.Add(pAct);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                //  throw;
            }
        }

        public bool InciarSesionCookies(string email, string passEncriptado)
        {
            string contrasenya = "";
            string passDescifrado = Descifrar(passEncriptado);
            string sqlLogIn = @"SELECT contrasenya from USUARIO
            WHERE email = @pEmail";

            SqlCommand cmd = new SqlCommand(sqlLogIn, conn.Conexion);
            SqlParameter pEmail = new SqlParameter("@pEmail", System.Data.SqlDbType.VarChar, 50);
            pEmail.Value = email;
            cmd.Parameters.Add(pEmail);
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.Read())
            {
                registro.Close();
                contrasenya = (string)cmd.ExecuteScalar();
                contrasenya = Descifrar(contrasenya);
                if (contrasenya.CompareTo(passDescifrado) == 0)
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
                    user.Contrasenya = (string)dr["contrasenya"];
                    user.Email = (string)dr["email"];
                    user.TipoPermiso = (string)dr["tipoUsuario"];
                    user.Puntos = (int)dr["puntos"];
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

        public int MostrarPuntosUsuario(int id)
        {
            string sql = @"Select  puntosActuales FROM Usuario where idUsuario = @idUser";

            SqlCommand cmd = new SqlCommand(sql, conn.Conexion);

            SqlParameter idUsuario = new SqlParameter("@idUser", id);
            cmd.Parameters.Add(idUsuario);
            int puntos = (int)cmd.ExecuteScalar();

            return puntos;
        }

        public void CancelarEvento(int id, string evento)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SalirEvento", conn.Conexion);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter pId = new SqlParameter("@idUser", id);
                cmd.Parameters.Add(pId);

                SqlParameter pEvento = new SqlParameter("@nombreEvento", System.Data.SqlDbType.VarChar);
                pEvento.Value = evento;
                cmd.Parameters.Add(pEvento);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

              //  throw;
            }
        }

    }
}