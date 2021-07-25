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

        public void InsertarEvento()
        {

        }

    }
}