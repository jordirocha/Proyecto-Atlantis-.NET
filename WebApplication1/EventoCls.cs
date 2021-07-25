using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class EventoCls
    {
        private int idEvento;
        private string nombreEvento;
        private string descripcion;
        private DateTime fecha;
        private int puntosRequeridos;
        private string ubicacion;
        private int aforo;
        private byte[] fotoEvento;

        public EventoCls(int idEvento, string nombreEvento, string descripcion, DateTime fecha, 
            int puntosRequeridos, string ubicacion, int aforo, byte[] fotoEvento)
        {
            this.idEvento = idEvento;
            this.nombreEvento = nombreEvento;
            this.descripcion = descripcion;
            this.fecha = fecha;
            this.puntosRequeridos = puntosRequeridos;
            this.ubicacion = ubicacion;
            this.aforo = aforo;
            this.fotoEvento = fotoEvento;
        }

        public EventoCls()
        {
        }

        public int IdEvento
        {
            set { idEvento = value; }
            get { return idEvento; }
        }

        public string NombreEvento
        {
            set { nombreEvento = value; }
            get { return nombreEvento; }
        }
        public string Descripcion
        {
            set { descripcion = value; }
            get { return descripcion; }
        }

        public DateTime Fecha
        {
            set { fecha = value; }
            get { return fecha; }
        }
        public int PuntosRequeridos
        {
            set { puntosRequeridos = value; }
            get { return puntosRequeridos; }
        }
        public string Ubicacion
        {
            set { ubicacion = value; }
            get { return ubicacion; }
        }
        public int Aforo
        {
            set { aforo = value; }
            get { return aforo; }
        }

        public byte[] FotoEvento
        {
            set { fotoEvento = value; }
            get { return fotoEvento; }
        }
    }
}