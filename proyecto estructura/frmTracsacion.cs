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
    public partial class frmTracsacion : Form
    {
        public frmTracsacion()
        {
            InitializeComponent();
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Today;
            long NumeroCuenta2 = long.Parse(txtCarnet.Text);
            long numerocuenta1 = long.Parse(txtNumeroCuenta.Text);
            float deposito = float.Parse(txtDeposito.Text);
            Estatica.cuentas.Transaccion(numerocuenta1,NumeroCuenta2,deposito);
        }
    }
}
