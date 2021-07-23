using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace WebApplication1
{
    public class RegistroUser 
    {
        static string clave = "cadenadecifrado"; // Clave de cifrado.   

        DbConnection conn = null;

        public RegistroUser()
        {
            conn = new DbConnection();
        }

        public bool ControlRegistro(string email)
        {
            SqlDataReader registro = null;
            try
            {
                string existUser = "SELECT * FROM Usuario WHERE email = @pEmail";
                SqlCommand cmd = new SqlCommand(existUser, conn.Conexion);
                SqlParameter pEmail = new SqlParameter("@pEmail", System.Data.SqlDbType.VarChar, 100);
                pEmail.Value = email;

                cmd.Parameters.Add(pEmail);

                registro = cmd.ExecuteReader();
                if (registro.Read())
                {
                    registro.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                registro.Close();
                Console.WriteLine(ex.ToString());
            }
            registro.Close();
            return false;
        }

        public bool ExisteEmail(string email)
        {
            SqlDataReader dr = null;
            try
            {
                string sqlEmail = "SELECT * FROM Usuario WHERE email = @pEmail";

                SqlCommand cmd = new SqlCommand(sqlEmail, conn.Conexion);
                SqlParameter pEmail = new SqlParameter("@pEmail", System.Data.SqlDbType.VarChar, 100);
                pEmail.Value = email;
                cmd.Parameters.Add(pEmail);

                 dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    dr.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                dr.Close();
            }

            dr.Close();
            return false;
        }


        public int ComprobarPasswords(string pass1, string pass2)
        {
            return pass1.CompareTo(pass2);
        }

        public bool ComprobarCampos(string nombre, string email, string pass, DateTime fechaNacimiento)
        {
            return nombre == null || email == null || pass == null || fechaNacimiento == null;
        }

        public void Registro(Usuario usuario)
        {
            try
            {
                string sqlInsertUsuario = "INSERT INTO  Usuario (nombre,email,contrasenya,fechaNacimiento,tipoUsuario) Values (@pNombre,@pEmail,@pContrasenya,@pFechaNacimiento,@pRol)";
                SqlCommand cmd = new SqlCommand(sqlInsertUsuario, conn.Conexion);

                SqlParameter pNombre = new SqlParameter("@pNombre", System.Data.SqlDbType.NVarChar, 100);
                pNombre.Value = usuario.Nombre;

                SqlParameter pEmail = new SqlParameter("@pEmail", System.Data.SqlDbType.NVarChar, 100);
                pEmail.Value = usuario.Email;

                SqlParameter pContrasenya = new SqlParameter("@pContrasenya", System.Data.SqlDbType.NVarChar, 100);
                pContrasenya.Value = Cifrar(usuario.Contrasenya);

                SqlParameter pFechaNacimiento = new SqlParameter("@pFechaNacimiento", System.Data.SqlDbType.Date);
                pFechaNacimiento.Value = usuario.FechaNacimiento.Date;

                SqlParameter pRol = new SqlParameter("@pRol", System.Data.SqlDbType.NVarChar, 20);
                pRol.Value = "user";

                cmd.Parameters.Add(pNombre);
                cmd.Parameters.Add(pEmail);
                cmd.Parameters.Add(pContrasenya);
                cmd.Parameters.Add(pFechaNacimiento);
                cmd.Parameters.Add(pRol);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        // Función para cifrar una cadena.
        public string Cifrar(string cadena)
        {

            //Arreglo donde guardaremos la llave para el cifrado 3DES
            byte[] claveEncriptacion;

            //Arreglo donde guardaremos la cadena descifrada
            byte[] sinCifrar = UTF8Encoding.UTF8.GetBytes(cadena);

            // Ciframos utilizando el Algoritmo MD5.
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            claveEncriptacion = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(clave));
            md5.Clear();

            //Ciframos utilizando el Algoritmo 3DES.
            TripleDESCryptoServiceProvider tripledes = new TripleDESCryptoServiceProvider();
            tripledes.Key = claveEncriptacion;
            tripledes.Mode = CipherMode.ECB;
            tripledes.Padding = PaddingMode.PKCS7;

            // Iniciamos la conversión de la cadena
            ICryptoTransform convertidor = tripledes.CreateEncryptor();

            //Arreglo de bytes donde guardaremos la cadena cifrada
            byte[] conCifrado = convertidor.TransformFinalBlock(sinCifrar, 0, sinCifrar.Length);
            tripledes.Clear();

            // Convertimos la cadena a Base64 y la devolvemos
            return Convert.ToBase64String(conCifrado, 0, conCifrado.Length);
        }

    }
}