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
    public partial class frm_deposito : Form
    {
        public frm_deposito()
        {
            InitializeComponent();
        }

        private void frm_deposito_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Today;
            long Carnet=long.Parse(txtCarnet.Text);
            long NumeroCarnet = long.Parse(txtNumeroCuenta.Text);
            float deposito = float.Parse(txtDeposito.Text);
            Estatica.cuentas.Deposito(NumeroCarnet, deposito,Carnet);


        }

        private void txtNumeroCuenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCarnet_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtDeposito_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
