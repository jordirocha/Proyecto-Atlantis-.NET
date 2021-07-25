﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;


namespace WebApplication1
{
	/// <summary>
	/// Summary description for ActividadCls
	/// </summary>
	public class ActividadCls
	{
        private int idActividad;
        private string nombreActividad;
        private string descripcionActividad;
        public DateTime fechaActividad;
        private string ubicacionactividad;
        private int puntosActividad;
        private int aforoActividad;
        private byte[] imagen;
        private string tituloImagen;

        public ActividadCls(int idActividad, string nombreActividad, string descripcionActividad, DateTime fechaActividad, 
                            string ubicacionactividad, int puntosActividad, int aforoActividad, byte[] imagen, string tituloImagen)
        {
            this.idActividad = idActividad;
            this.nombreActividad = nombreActividad;
            this.fechaActividad = fechaActividad;
            this.descripcionActividad = descripcionActividad;
            this.ubicacionactividad = ubicacionactividad;
            this.puntosActividad = puntosActividad;
            this.aforoActividad = aforoActividad;
            this.imagen = imagen;
            this.tituloImagen = tituloImagen;
        }

        public ActividadCls()
        {
        }

        public int IdActividad
        {
            set { idActividad = value; }
            get { return idActividad; }
        }
        public string NombreActividad
        {
            set { nombreActividad = value; }
            get { return nombreActividad; }
        }
        public string DescripcionActividad
        {
            set { descripcionActividad = value; }
            get { return descripcionActividad; }
        }
        public DateTime FechaActividad
        {
            set { fechaActividad = value; }
            get { return fechaActividad; }
        }
        public string Ubicacionactividad
        {
            set { ubicacionactividad = value; }
            get { return ubicacionactividad; }
        }
        public int PuntosActividad
        {
            set { puntosActividad = value; }
            get { return puntosActividad; }
        }
        public int AforoActividad
        {
            set { aforoActividad = value; }
            get { return aforoActividad; }
        }

        public byte[] Imagen
        {
            set { imagen = value; }
            get { return imagen; }
        }

        public string TituloImagen
        {
            set { tituloImagen = value; }
            get { return tituloImagen; }
        }

    }
}