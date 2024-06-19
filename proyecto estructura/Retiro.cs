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
    public partial class FrmRetito : Form
    {
        public FrmRetito()
        {
            InitializeComponent();
        }

        private void btnRetiro_Click(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Today;
            long Carnet = long.Parse(txtCarnet.Text);
            long NumeroCarnet = long.Parse(txtNumeroCuenta.Text);
            float retiro = float.Parse(txtDeposito.Text);
            Estatica.cuentas.Retiro(NumeroCarnet, retiro, Carnet);

        }

        private void Retiro_Load(object sender, EventArgs e)
        {

        }
    }
}
