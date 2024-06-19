using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace proyecto_estructura
{
     class PILA_DEPOSITOS
    {
        long numero_cuenta2;
        float saldo;
        long numero_cuenta;
        string tipo_cuenta;
        long Numero_carnet;
        private PILA_DEPOSITOS enlace;
        private PILA_DEPOSITOS cima;

        public PILA_DEPOSITOS(float saldo, long numero_cuenta, string tipo_cuenta, long numero_carnet)
        {
            this.saldo = saldo;
            this.numero_cuenta = numero_cuenta;
            this.tipo_cuenta = tipo_cuenta;
            Numero_carnet = numero_carnet;
            this.enlace = null;
            this.cima = null;
        }
        public PILA_DEPOSITOS(float saldo, long numero_cuenta,long numeroCuenta2, string tipo_cuenta, long numero_carnet)
        {
            this.saldo = saldo;
            this.numero_cuenta = numero_cuenta;
            this.numero_cuenta2 = numeroCuenta2;
            this.tipo_cuenta = tipo_cuenta;
            Numero_carnet = numero_carnet;
            this.enlace = null;
            this.cima = null;
        }


        public float Saldo { get => saldo; set => saldo = value; }
        public long Numero_cuenta { get => numero_cuenta; set => numero_cuenta = value; }
        public string Tipo_cuenta { get => tipo_cuenta; set => tipo_cuenta = value; }
        public long Numero_carnet1 { get => Numero_carnet; set => Numero_carnet = value; }
        internal PILA_DEPOSITOS Enlace { get => enlace; set => enlace = value; }
        internal PILA_DEPOSITOS Cima { get => cima; set => cima = value; }

        public void ApilarDeposito(float monto, long numero_cuenta, string tipo_cuenta, long numero_carnet)
        {
            PILA_DEPOSITOS nuevoNodo = new PILA_DEPOSITOS(monto, numero_cuenta, tipo_cuenta, numero_carnet);
            if (cima == null)
            {
                cima = nuevoNodo;
            }
            else
            {
                nuevoNodo.Enlace = cima;
                cima = nuevoNodo;
            }
        }
        public PILA_DEPOSITOS Desapilar()
        {
            if (cima == null)
            {
                MessageBox.Show("La pila está vacía.");
                return null;
            }
            else
            {
                PILA_DEPOSITOS nodoDesapilado = cima;
                cima = cima.Enlace;
                nodoDesapilado.Enlace = null;
                return nodoDesapilado;
            }
        }

    }

}
