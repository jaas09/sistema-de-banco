using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_estructura
{
    public partial class frmPrestamo : Form
    {
        public frmPrestamo()
        {
            InitializeComponent();
        }
        long carnet;
        private void Btn_Verificar_Click(object sender, EventArgs e)
        {
            long carnet;

            if (long.TryParse(Txt_Carnet.Text, out carnet))
            {
                Nodo_listas_dobles aux1 = Estatica.llamar.BuscarNodo(carnet);
                NodoCuentas aux2 = Estatica.cuentas.BuscarNodo(carnet);

                if (aux1 != null && aux2 != null)
                {
                    DateTime fechaRegistro = aux1.Fecha1;
                    DateTime fechaActual = DateTime.Now;
                    TimeSpan antiguedad = fechaActual - fechaRegistro;

                    if (antiguedad.TotalDays >= 365)
                    {
                        MessageBox.Show("Puede acceder a préstamos.");
                    }
                    else
                    {
                        MessageBox.Show("No puede acceder a préstamos. La cuenta no tiene la antigüedad requerida.");
                    }
                }
                else
                {
                    MessageBox.Show("Cuenta no encontrada.");
                }
            }
            else
            {
                MessageBox.Show("Número de carnet no válido.");
            }
        }

        private void Btn_Permiso_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(Txt_Monto.Text, out decimal monto) && !string.IsNullOrWhiteSpace(Cbx_Garantia.Text))
            {
                string garantia = Cbx_Garantia.Text.ToLower();
                string Tarjeta = Txt_TipoTarjeta.Text.ToLower();

                decimal interes = 0;

                // Determinar el porcentaje de interés basado en el tipo de tarjeta
                if (Tarjeta == "credito")
                {
                    interes = 0.05m; // 5% de interés para tarjetas de crédito
                }
                else if (Tarjeta == "debito")
                {
                    interes = 0.06m; // 6% de interés para tarjetas de débito
                }
                else
                {
                    MessageBox.Show("Tipo de tarjeta no válido.");
                    return; // Salir del método si el tipo de tarjeta no es válido
                }

                decimal montoTotal = monto * (1 + interes); // Calcular el monto total con interés

                if ((monto <= 10000 && garantia == "terreno") ||
                    (monto <= 30000 && garantia == "auto") ||
                    (monto <= 50000 && garantia == "casa") ||
                    (monto > 50000 && garantia == "mansion"))
                {
                    MessageBox.Show($"Préstamo exitoso {monto} Monto total a pagar con intereses: {montoTotal}");
                }
                else
                {
                    MessageBox.Show("La garantía ofrecida no cubre el préstamo solicitado.");
                }
            }
            else
            {
                MessageBox.Show("Monto del préstamo o garantía no válida.");
            }
        }

        private void frmPrestamo_Load(object sender, EventArgs e)
        {

        }
    }
}
