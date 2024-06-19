using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_estructura
{

    class Nodo_listas_dobles
    {
        string nombre;
        string apellido;
        string gmail;
        long ci;
        long telefono;
        DateTime Fecha;
        
        
        Nodo_listas_dobles Enlaceanterior;
        Nodo_listas_dobles Enlacesiguiente;

        
        public Nodo_listas_dobles(string nombre,string apellido, string gmail, long ci, long telefono, DateTime fecha )
        {
          
            this.nombre = nombre;
            this.apellido = apellido;
            this.gmail = gmail;
            this.ci = ci;
            this.telefono = telefono;
            this.Fecha = fecha;
        
            Enlaceanterior =    null; Enlacesiguiente=null;
        }

       public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Gmail { get => gmail; set => gmail = value; }
        public long Ci { get => ci; set => ci = value; }
        public long Telefono { get => telefono; set => telefono = value; }
        public DateTime Fecha1 { get => Fecha; set => Fecha = value; }
        internal Nodo_listas_dobles Enlace_anterior { get => Enlaceanterior; set => Enlaceanterior = value; }
        internal Nodo_listas_dobles Enlace_siguiente { get => Enlacesiguiente; set => Enlacesiguiente = value; }
    }
}
