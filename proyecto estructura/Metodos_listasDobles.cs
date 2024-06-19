    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace proyecto_estructura
{
    class Metodos_listasDobles
    {
        Nodo_listas_dobles cabeza, nuevo;
        public Metodos_listasDobles()
        {
            cabeza = null;
            nuevo = null;
            // Crear las listas solo si los datos no han sido cargados previamente


        }
        public void CrearNodo(string nombre, string apellido, string gmail, long ci, long telefono, DateTime fecha)
        {
            nuevo = new Nodo_listas_dobles(nombre, apellido, gmail, ci, telefono,fecha);
            nuevo.Nombre = nombre;
            nuevo.Apellido = apellido;
             nuevo.Ci = ci;
            nuevo.Telefono = telefono;
          
            nuevo.Gmail = gmail;
            nuevo.Fecha1 = fecha;
          
            nuevo.Enlace_anterior = null;
            nuevo.Enlace_siguiente = null;
        }
        public void crear_lista(string nombre, string apellido, string gmail, long ci, long telefono,DateTime fecha)
        {
            
            Nodo_listas_dobles aux;
            CrearNodo(nombre, apellido, gmail, ci, telefono,fecha);
            ;
            if (cabeza == null)
            {
                cabeza = nuevo;
            }
            else
            {
                aux = cabeza;
                while (aux.Enlace_siguiente != null)
                {
                    aux = aux.Enlace_siguiente;
                }
                nuevo.Enlace_anterior = aux;
                aux.Enlace_siguiente = nuevo;
            }

        }
        
        public Nodo_listas_dobles BuscarNodo(long ci)
        {
            Nodo_listas_dobles aux = cabeza;
            while (aux != null)
            {
                if (aux.Ci == ci) // Asegúrate de que estás comparando con el campo correcto
                {
                    return aux;
                }
                aux = aux.Enlace_siguiente;
            }
            return null;
        }
        
      

    }
}
