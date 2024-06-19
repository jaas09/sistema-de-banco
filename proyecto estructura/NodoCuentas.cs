using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_estructura
{
    class NodoCuentas
    {
      
        float[] saldo;
        long[] numero_cuenta;
        string[] tipo_cuenta;
        long Numero_carnet;
        NodoCuentas enlacesiguiente;
        NodoCuentas enlaceAnterior;

        public long Numero_carnet1 { get => Numero_carnet; set => Numero_carnet = value; }
        internal NodoCuentas Enlacesiguiente { get => enlacesiguiente; set => enlacesiguiente = value; }
        internal NodoCuentas EnlaceAnterior { get => enlaceAnterior; set => enlaceAnterior = value; }

        public NodoCuentas(long numero_carnet, long[] numero_cuenta, string[] tipo_cuenta, float[] saldo)
        {
            Numero_carnet = numero_carnet;
            this.numero_cuenta = numero_cuenta;
            this.tipo_cuenta = tipo_cuenta;
            this.enlacesiguiente = null;
            this.enlaceAnterior = null;
            this.saldo = saldo;
        }

        public void SetTodo(long[] numero_cuenta, string[] Tipo_cuenta, float[] saldo)
        {
            this.numero_cuenta = numero_cuenta;
            this.tipo_cuenta = Tipo_cuenta;
            this.saldo = saldo;
        }

        public long[] GetNumerosCuenta()
        {
            return numero_cuenta;
        }

        public string[] GetTiposCuenta()
        {
            return tipo_cuenta;
        }

        public float[] GetSaldos()
        {
            return saldo;
        }
        public void MostrarTodasLasCuentas()
        {
            for (int i = 0; i < numero_cuenta.Length; i++)
            {
                Console.WriteLine($"Cuenta {i + 1}:");
                Console.WriteLine($"Número de cuenta: {numero_cuenta[i]}");
                Console.WriteLine($"Tipo de cuenta: {tipo_cuenta[i]}");
                Console.WriteLine($"Saldo: {saldo[i]}");
                Console.WriteLine();
            }
        }
        public int BuscarNumeroCuenta(long numeroCuenta)
        {
            for (int i = 0; i < numero_cuenta.Length; i++)
            {
                if (numero_cuenta[i] == numeroCuenta)
                {
                    return i; // Retorna el índice de la cuenta encontrada
                }
            }
            return -1; // Retorna -1 si la cuenta no se encuentra
        }
        
        }
    } 






   
