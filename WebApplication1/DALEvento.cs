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

        public void InsertarEvento()
        {

        }

    }
}