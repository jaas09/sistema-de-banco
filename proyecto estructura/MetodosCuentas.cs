using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace proyecto_estructura
{
    class MetodosCuentas
    {

        long ultimoNumeroCuenta = 10;
        NodoCuentas cabeza, nuevo;
        public MetodosCuentas()
        {
            cabeza = null;
            nuevo = null;
        }
        public void CrearLista(long NumeroCarnet, string TipoCuenta, float saldo)
        {
            NodoCuentas aux;
            long[] num = GenerarNuevoNumeroCuenta();
            string[] cuenta = { TipoCuenta };
            float[] Saldo = { saldo };

            nuevo = new NodoCuentas(NumeroCarnet, num, cuenta, Saldo);

            nuevo.Numero_carnet1 = NumeroCarnet;
            nuevo.SetTodo(num, cuenta, Saldo);
            nuevo.Numero_carnet1 = NumeroCarnet;
            if (cabeza == null)
            {
                cabeza = nuevo;
            }
            else
            {
                aux = cabeza;
                while (aux.Enlacesiguiente != null)
                {
                    aux = aux.Enlacesiguiente;
                }
                nuevo.EnlaceAnterior = aux;
                aux.Enlacesiguiente = nuevo;
            }



        }
        public bool Deposito(long NumeroCuenta, float deposito, long Carnet)
        {
            Nodo_listas_dobles a;
            long ab;
            NodoCuentas aux;
           
            aux = BuscarNodo(Carnet);
            if (aux != null)
            {
                for (int i = 0; i < aux.GetNumerosCuenta().Length; i++)
                {
                    if (aux.GetNumerosCuenta()[i] == NumeroCuenta)
                    {
                        aux.GetSaldos()[i] = aux.GetSaldos()[i] + deposito;
                        MessageBox.Show("usuario encontrado deposito exitoso" + " " + aux.GetSaldos()[i]);
                        return  true;
                    }
                }
               
            }
            else MessageBox.Show("usuario no registrado");
           return   false;
        }
        public bool Retiro(long NumeroCuenta, float retiro, long Carnet)
        {
            Nodo_listas_dobles a;
            NodoCuentas aux;
            aux = BuscarNodo(Carnet);
            if (aux != null)
            {
                for (int i = 0; i < aux.GetNumerosCuenta().Length; i++)
                {
                    if (aux.GetNumerosCuenta()[i] == NumeroCuenta)
                    {
                        if (aux.GetSaldos()[i] > retiro)
                        {
                            aux.GetSaldos()[i] = aux.GetSaldos()[i] - retiro;
                            MessageBox.Show("usuario encontrado retiro exitoso" + " " + aux.GetSaldos()[i]);
                            return true;
                        }
                        else MessageBox.Show("saldo insuficiente");
                        return false;

                    }
                }

            }
           
            else MessageBox.Show("usuario no registrado");
            return false;
        }





        public NodoCuentas BuscarNodo(long Carnet)
        {
            NodoCuentas aux = cabeza;
            while (aux != null)
            {
                if (aux.Numero_carnet1 == Carnet) // Asegúrate de que estás comparando con el campo correcto
                {
                    return aux;
                }
                aux = aux.Enlacesiguiente;
            }
            return null;
        }
        public long[] GenerarNuevoNumeroCuenta()
        {
           
            ultimoNumeroCuenta++;
            return new long[] { ultimoNumeroCuenta };
        }

        public bool Transaccion(long numeroCuenta1, long numeroCuenta2, float monto)
        {
            // Buscar las cuentas involucradas en la transacción
            NodoCuentas cuentaOrigen = Buscarcuenta(numeroCuenta1);
            NodoCuentas cuentaDestino = Buscarcuenta(numeroCuenta2);

            // Verificar si ambas cuentas existen
            if (cuentaOrigen == null)
            {
                MessageBox.Show($"La cuenta {numeroCuenta1} no existe.");
                return false;
            }

            if (cuentaDestino == null)
            {
                MessageBox.Show($"La cuenta {numeroCuenta2} no existe.");
                return false;
            }

            // Intentar realizar el retiro de la cuenta de origen
            bool retiroExitoso = Retiro(numeroCuenta1, monto, cuentaOrigen.Numero_carnet1);

            if (!retiroExitoso)
            {
                MessageBox.Show($"Saldo insuficiente en la cuenta {numeroCuenta1} para realizar la transacción.");
                return false;
            }

            // Realizar el depósito en la cuenta destino
            Deposito(numeroCuenta2, monto, cuentaDestino.Numero_carnet1);

            // Mostrar mensaje de transacción exitosa
            MessageBox.Show($"Transacción exitosa. Se transfirieron {monto} de la cuenta {numeroCuenta1} a la cuenta {numeroCuenta2}.");

            return true;
        }

        public NodoCuentas Buscarcuenta(long numeroCarnet)
        {
            NodoCuentas aux = cabeza;
            while (aux != null)
            {
                for (int i = 0; i < aux.GetNumerosCuenta().Length; i++)
                {
                    if (aux.GetNumerosCuenta()[i] == numeroCarnet) // Compara correctamente con el carnet
                    {
                        return aux;
                    }
                }
                aux = aux.Enlacesiguiente; // Mueve al siguiente nodo después de revisar todas las cuentas en el nodo actual
            }
            return null; // Devuelve null si no se encontró la cuenta
        }

    }
}
    





