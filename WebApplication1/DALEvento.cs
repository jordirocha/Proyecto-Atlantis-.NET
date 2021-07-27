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

        public DataTable SeleccionarEventos()
        {
            SqlDataAdapter da = new SqlDataAdapter("select idEvento as ID, nombre as Evento," +
                "ubicacion as Ubicación," +
                "fecha as Fecha," +
                "puntosRequeridos as Puntos," +
                 "descripcion as Descripcion," +
                "aforo as Aforo," +
                "fotoEvento from evento", con.Conexion);
            DataTable table = new DataTable();
            da.Fill(table);
            return table;
        }

        public List<EventoCls> SelectActividad()
        {
            List<EventoCls> eventos = new List<EventoCls>();
            EventoCls ev;

            try
            {
                string sql = "select idEvento, nombre, ubicacion, fecha, puntosRequeridos, " +
                 "descripcion, aforo, fotoEvento from evento";
                SqlCommand cmd = new SqlCommand(sql, con.Conexion);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ev = new EventoCls();

                    ev.IdEvento = (int)dr["idEvento"];
                    ev.NombreEvento = (string)dr["nombre"];
                    ev.Descripcion = (string)dr["descripcion"];
                    ev.Fecha = (DateTime)dr["fecha"];
                    ev.PuntosRequeridos = (int)dr["puntosRequeridos"];
                    ev.Ubicacion = (string)dr["ubicacion"];
                    ev.Aforo = (int)dr["aforo"];
                    ev.FotoEvento = (byte[])dr["fotoEvento"];

                    eventos.Add(ev);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
            }
            return eventos;
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
        public bool usuarioApuntadoEvento(int idActividad, int idUsuario)
        {
            bool apuntado = false;

            string query = "Select FkIdEvento, FkIdUsuario " +
                "FROM AccedeEvento " +
                "WHERE FkIdEvento=@idEvento AND FkIdUsuario=@idUsuario";
            SqlCommand cmd = new SqlCommand(query, con.Conexion);
            cmd.Parameters.AddWithValue("@idEvento", idActividad);
            cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

            apuntado = Convert.ToInt32(cmd.ExecuteScalar()) > 0;

            return apuntado;
        }

        public bool usuarioPuntosEvento(int idEvento, int idUsuario)
        {
            string query = "Select puntosActuales " +
                "FROM Usuario " +
                "WHERE idUsuario = @idUsuario";
            SqlCommand cmd = new SqlCommand(query, con.Conexion);
            cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

            int puntosUser = cmd.ExecuteNonQuery();

            string query2 = "Select puntosRequeridos " +
               "FROM Evento " +
               "WHERE idEvento = @idEvento";
            SqlCommand cmd2 = new SqlCommand(query2, con.Conexion);
            cmd2.Parameters.AddWithValue("@idEvento", idEvento);

            int puntosRequeridos = cmd2.ExecuteNonQuery();

            if (puntosUser >= puntosRequeridos)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void usuarioApuntarse(int idEvento, int idUsuario, DateTime fecha)
        {

            string query = "Insert into AccedeEvento " +
                "values(@idEvento,@idUsuario,@fecha)";

            SqlCommand cmd = new SqlCommand(query, con.Conexion);
            cmd.Parameters.AddWithValue("@idEvento", idEvento);
            cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
            cmd.Parameters.AddWithValue("@fecha", fecha);

            cmd.ExecuteNonQuery();

        }

    }
}