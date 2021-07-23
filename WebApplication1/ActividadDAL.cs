using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WebApplication1
{
    public class ActividadDAL
    {
        DbConnection cnx = null;

        public ActividadDAL()
        {
            cnx = new DbConnection();
        }

        public void InsertActividad(ActividadCls act)
        {
            try
            {
                string sql = @"INSERT INTO Actividad 
                    (nombre, descripcion, fecha, puntosAdquiridos, ubicacion, aforo)
                    VALUES (@pNombre,
                        @pDescripcion,
                        @pFecha,
                        @pPuntosAdquiridos,
                        @pUbicacion, 
                        @pAforo)";
                SqlCommand cmd = new SqlCommand(sql, cnx.Conexion);

                SqlParameter pNombre = new SqlParameter("@pNombre", System.Data.SqlDbType.NVarChar, 50);
                pNombre.Value = act.NombreActividad;
                SqlParameter pDescripcion = new SqlParameter("@pDescripcion", System.Data.SqlDbType.NVarChar, 50);
                pDescripcion.Value = act.DescripcionActividad;
                SqlParameter pFecha = new SqlParameter("@pFecha", act.FechaActividad);
                SqlParameter pPuntosActividad = new SqlParameter("@pPuntosAdquiridos", act.PuntosActividad);
                SqlParameter pUbicacion = new SqlParameter("@pUbicacion", System.Data.SqlDbType.NVarChar,50);
                pUbicacion.Value = act.Ubicacionactividad;
                SqlParameter pAforo = new SqlParameter("@pAforo", act.AforoActividad);

                cmd.Parameters.Add(pNombre);
                cmd.Parameters.Add(pDescripcion);
                cmd.Parameters.Add(pFecha);
                cmd.Parameters.Add(pPuntosActividad);
                cmd.Parameters.Add(pUbicacion);
                cmd.Parameters.Add(pAforo);

                cmd.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en Insert: " + ex.Message);
            }
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
                string sql = "SELECT idActividad, nombre, descripcion, fecha, puntosAdquiridos, ubicacion, aforo  FROM Actividad" +
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
                             "WHERE idActividad = @pId " ;

                SqlCommand cmd = new SqlCommand(sql, cnx.Conexion);
                SqlParameter pId = new SqlParameter("pId", act.IdActividad);
                SqlParameter pNombre = new SqlParameter("pNombre", System.Data.SqlDbType.NVarChar, 50);
                SqlParameter pDescripcion = new SqlParameter("pDescripcion", System.Data.SqlDbType.NVarChar, 50);
                SqlParameter pFecha = new SqlParameter("pFecha", act.FechaActividad);
                SqlParameter pPuntos = new SqlParameter("pPuntos", act.PuntosActividad);
                SqlParameter pUbicacion = new SqlParameter("pUbicacion", System.Data.SqlDbType.NVarChar, 50);
                SqlParameter pAforo = new SqlParameter("pAforo", act.AforoActividad);

                cmd.Parameters.Add(pNombre);
                cmd.Parameters.Add(pDescripcion);
                cmd.Parameters.Add(pFecha);
                cmd.Parameters.Add(pPuntos);
                cmd.Parameters.Add(pUbicacion);
                cmd.Parameters.Add(pAforo);

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

    }
}