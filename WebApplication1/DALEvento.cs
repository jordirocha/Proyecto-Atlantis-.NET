using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class DALEvento
    {
        DbConnection con = null;

        public DALEvento()
        {
            con = new DbConnection();
        }

        public void InsertarEvento(string evento, string desc, DateTime fecha, int puntos, string ubicacion, int aforo, byte[] foto, int idUser)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insertarEvento", con.Conexion);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter pNombre = new SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 100);
                pNombre.Value = evento;
                cmd.Parameters.Add(pNombre);

                SqlParameter pDesc = new SqlParameter("@descripcion", System.Data.SqlDbType.VarChar);
                pDesc.Value = desc;
                cmd.Parameters.Add(pDesc);

                SqlParameter pfecha = new SqlParameter("@fecha", fecha);
                cmd.Parameters.Add(pfecha);

                SqlParameter pPuntos = new SqlParameter("@puntos", puntos);
                cmd.Parameters.Add(pPuntos);

                SqlParameter pUbicacion = new SqlParameter("@ubicacion", System.Data.SqlDbType.VarChar, 100);
                pUbicacion.Value = ubicacion;
                cmd.Parameters.Add(pUbicacion);

                SqlParameter pAforo = new SqlParameter("@limite", aforo);
                cmd.Parameters.Add(pAforo);

                SqlParameter pFoto = new SqlParameter("@foto", foto);
                cmd.Parameters.Add(pFoto);

                SqlParameter pId = new SqlParameter("@idUsuario", idUser);
                 cmd.Parameters.Add(pId);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                // throw;
            }

        }

    }
}