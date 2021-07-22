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

        public DataTable seleccionarEventos()
        {
            SqlDataAdapter da = new SqlDataAdapter("select nombre as Evento," +
                "ubicacion as Ubicación," +
                "fecha as Fecha," +
                "puntosRequeridos as Puntos," +
                 "descripcion as Descripcion," +
                "aforo as Aforo from evento", con.Conexion);
            DataTable table = new DataTable();
            da.Fill(table);
            return table;
        }

    }
}