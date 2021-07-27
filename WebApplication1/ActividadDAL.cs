using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WebApplication1
{
    public class ActividadDAL
    {
        public DbConnection cnx;

        public ActividadDAL()
        {
            cnx = new DbConnection();
        }

        public void InsertActividad(ActividadCls act)
        {
            try
            {
                string sql = @"INSERT INTO Actividad 
                    (nombre, descripcion, fecha, puntosAdquiridos, ubicacion, aforo, imagenActividad)
                    VALUES (@pNombre,
                        @pDescripcion,
                        @pFecha,
                        @pPuntosAdquiridos,
                        @pUbicacion, 
                        @pAforo,
                        @pImagen)";
                SqlCommand cmd = new SqlCommand(sql, cnx.Conexion);

                SqlParameter pNombre = new SqlParameter("@pNombre", System.Data.SqlDbType.NVarChar, 50);
                pNombre.Value = act.NombreActividad;
                SqlParameter pDescripcion = new SqlParameter("@pDescripcion", System.Data.SqlDbType.NVarChar, 100);
                pDescripcion.Value = act.DescripcionActividad;
                SqlParameter pFecha = new SqlParameter("@pFecha", act.FechaActividad);
                SqlParameter pPuntosActividad = new SqlParameter("@pPuntosAdquiridos", act.PuntosActividad);
                SqlParameter pUbicacion = new SqlParameter("@pUbicacion", System.Data.SqlDbType.NVarChar, 50);
                pUbicacion.Value = act.Ubicacionactividad;
                SqlParameter pAforo = new SqlParameter("@pAforo", act.AforoActividad);
                SqlParameter pImagen = new SqlParameter("@pImagen", System.Data.SqlDbType.Image);
                pImagen.Value = act.Imagen;
                SqlParameter pTituloImagen = new SqlParameter("@pTituloImagen", System.Data.SqlDbType.NVarChar, 100);
                pTituloImagen.Value = act.TituloImagen;

                cmd.Parameters.Add(pNombre);
                cmd.Parameters.Add(pDescripcion);
                cmd.Parameters.Add(pFecha);
                cmd.Parameters.Add(pPuntosActividad);
                cmd.Parameters.Add(pUbicacion);
                cmd.Parameters.Add(pAforo);
                cmd.Parameters.Add(pImagen);
                cmd.Parameters.Add(pTituloImagen);

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en Insert: " + ex.Message);
            }
        }

        public DataTable SeleccionarEventos()
        {
            SqlDataAdapter da = new SqlDataAdapter("select idActividad as ID, nombre as Actividad," +
                "ubicacion as Ubicación," +
                "fecha as Fecha," +
                "puntosAdquiridos as Puntos," +
                 "descripcion as Descripcion," +
                "aforo as Aforo," +
                "imagenActividad from Actividad", cnx.Conexion);
            DataTable table = new DataTable();
            da.Fill(table);
            return table;
        }

        public ActividadCls SelectActividadById(int id)
        {
            ActividadCls act = null;

            try
            {
                string sql = "SELECT * FROM Actividad WHERE idActividad=@pId";
                SqlCommand cmd = new SqlCommand(sql, cnx.Conexion);
                SqlParameter pId = new SqlParameter("@pId", id);
                cmd.Parameters.Add(pId);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    act = new ActividadCls();
                    act.IdActividad = (int)dr["idActividad"];
                    act.NombreActividad = (string)dr["nombre"];
                    act.DescripcionActividad = (string)dr["descripcion"];
                    act.fechaActividad = (DateTime)dr["fecha"];
                    act.PuntosActividad = (int)dr["puntosAdquiridos"];
                    act.Ubicacionactividad = (string)dr["ubicacion"];
                    act.AforoActividad = (int)dr["aforo"];
                }
                dr.Close();
            }
            catch
            {
            }
            return act;
        }
        public List<ActividadCls> SelectActividad()
        {
            List<ActividadCls> acts = new List<ActividadCls>();
            ActividadCls act;

            try
            {
                string sql = "SELECT idActividad, nombre, descripcion, fecha, puntosAdquiridos, ubicacion, aforo, imagenActividad  FROM Actividad" +
                    " ORDER BY fecha";
                SqlCommand cmd = new SqlCommand(sql, cnx.Conexion);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    act = new ActividadCls();

                    act.IdActividad = (int)dr["idActividad"];
                    act.NombreActividad = (string)dr["nombre"];
                    act.DescripcionActividad = (string)dr["descripcion"];
                    act.fechaActividad = (DateTime)dr["fecha"];
                    act.PuntosActividad = (int)dr["puntosAdquiridos"];
                    act.Ubicacionactividad = (string)dr["ubicacion"];
                    act.AforoActividad = (int)dr["aforo"];
                    act.Imagen = (byte[])dr["imagenActividad"];

                    acts.Add(act);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
            }
            return acts;
        }

        public void UpdateActividad(ActividadCls act)
        {
            try
            {
                string sql = "UPDATE Actividad " +
                             "SET nombre = @pNombre," +
                             "descripcion = @pDescripcion," +
                             "fecha = @pFecha," +
                             "puntosAdquiridos = @pPuntos," +
                             "ubicacion = @pUbicacion," +
                             "aforo = @Aforo" +
                             "imagenActividad from Actividad" +
                             "WHERE idActividad = @pId";

                SqlCommand cmd = new SqlCommand(sql, cnx.Conexion);
                SqlParameter pId = new SqlParameter("pId", act.IdActividad);
                SqlParameter pNombre = new SqlParameter("pNombre", System.Data.SqlDbType.NVarChar, 50);
                SqlParameter pDescripcion = new SqlParameter("pDescripcion", System.Data.SqlDbType.NVarChar, 100);
                SqlParameter pFecha = new SqlParameter("pFecha", act.FechaActividad);
                SqlParameter pPuntos = new SqlParameter("pPuntos", act.PuntosActividad);
                SqlParameter pUbicacion = new SqlParameter("pUbicacion", System.Data.SqlDbType.NVarChar, 50);
                SqlParameter pAforo = new SqlParameter("pAforo", act.AforoActividad);
                SqlParameter pFoto = new SqlParameter("@imagenActividad", act.Imagen);


                cmd.Parameters.Add(pNombre);
                cmd.Parameters.Add(pDescripcion);
                cmd.Parameters.Add(pFecha);
                cmd.Parameters.Add(pPuntos);
                cmd.Parameters.Add(pUbicacion);
                cmd.Parameters.Add(pAforo);
                cmd.Parameters.Add(pFoto);
                cmd.Parameters.Add(pId);

                pNombre.Value = act.NombreActividad;
                pDescripcion.Value = act.DescripcionActividad;
                pFecha.Value = act.FechaActividad;
                pPuntos.Value = act.FechaActividad;
                pUbicacion.Value = act.Ubicacionactividad;
                pAforo.Value = act.AforoActividad;

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
            }
        }

        public void DeleteActividad(int id)
        {
            try
            {
                string sql = "DELETE FROM Actividad WHERE idActividad = @pId";
                SqlCommand cmd = new SqlCommand(sql, cnx.Conexion);

                SqlParameter pId = new SqlParameter("@pId", id);
                cmd.Parameters.Add(pId);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }

        public void InsertarActividad(string actividad, string desc, DateTime fecha, int puntos, string ubicacion, int aforo, byte[] foto, int idUser)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insertarActividad", cnx.Conexion);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter pNombre = new SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 100);
                pNombre.Value = actividad;
                cmd.Parameters.Add(pNombre);

                SqlParameter pDesc = new SqlParameter("@descripcion", System.Data.SqlDbType.VarChar);
                pDesc.Value = desc;
                cmd.Parameters.Add(pDesc);

                SqlParameter pfecha = new SqlParameter("@fecha", fecha);
                cmd.Parameters.Add(pfecha);

                SqlParameter pPuntos = new SqlParameter("@puntosAdquiridos", puntos);
                cmd.Parameters.Add(pPuntos);

                SqlParameter pUbicacion = new SqlParameter("@ubicacion", System.Data.SqlDbType.VarChar, 100);
                pUbicacion.Value = ubicacion;
                cmd.Parameters.Add(pUbicacion);

                SqlParameter pAforo = new SqlParameter("@aforo", aforo);
                cmd.Parameters.Add(pAforo);

                SqlParameter pFoto = new SqlParameter("@imagenActividad", foto);
                cmd.Parameters.Add(pFoto);

                SqlParameter pId = new SqlParameter("@idOng", idUser);
                cmd.Parameters.Add(pId);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                // throw;
            }


        }
        public void ConcederPuntosUsuario(int idUsuario, int puntos)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ConcederPuntosUsuario", cnx.Conexion);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter pNombre = new SqlParameter("@idUser", idUsuario);
                cmd.Parameters.Add(pNombre);

                SqlParameter pPuntos = new SqlParameter("@puntosAct", puntos);
                cmd.Parameters.Add(pPuntos);

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                // throw;
            }
        }

        public bool usuarioApuntadoActividad(int idActividad, int idUsuario)
        {
            bool apuntado = false;

            string query = "Select FkIdActividad, FkIdUsuario " +
                "FROM AccedeActividad " +
                "WHERE FkIdActividad=@idActividad AND FkIdUsuario=@idUsuario";
            SqlCommand cmd = new SqlCommand(query, cnx.Conexion);
            cmd.Parameters.AddWithValue("@idActividad", idActividad);
            cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

            apuntado = Convert.ToInt32(cmd.ExecuteScalar()) > 0;

            return apuntado;
        }

        public void usuarioApuntarse(int idActividad, int idUsuario, DateTime fecha)
        {

            string query = "Insert into AccedeActividad " +
                "values(@idActividad,@idUsuario,@fecha)";

            SqlCommand cmd = new SqlCommand(query, cnx.Conexion);
            cmd.Parameters.AddWithValue("@idActividad", idActividad);
            cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
            cmd.Parameters.AddWithValue("@fecha", fecha);

            cmd.ExecuteNonQuery();

        }


    }
}