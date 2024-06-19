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
    public partial class login : Form
    {
        Metodos_listasDobles llamar;
        public login()
        {
            InitializeComponent();
            llamar = new Metodos_listasDobles();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private bool datosCargados = false;

        private void login_Load(object sender, EventArgs e)
        {
            Estatica.llamar.crear_lista("jesus", "Arias", "extrañoamiex@example.com", 1, 9876543210, new DateTime(2015, 1, 15));
            Estatica.llamar.crear_lista("cristian", "Quispe", "email2@example.com", 2, 9876543211, new DateTime(2024, 2, 25));
            Estatica.cuentas.CrearLista(1, "debito", 1000);
            Estatica.cuentas.CrearLista(2, "credito", 500);
        }



        private void BTN_INGRESAR_Click(object sender, EventArgs e)
        {


            long carnet;
            if (long.TryParse(txtnumeroCarnet.Text, out carnet))
            {
                Nodo_listas_dobles llamar = Estatica.llamar.BuscarNodo(carnet);

                if (llamar != null)
                {
                    frm_inicio form = new frm_inicio(carnet);
                    form.Show();
                    this.Hide();
                    form.FormClosing += cerrarformulario;
                }
                else
                {
                    MessageBox.Show("Usuario no registrado");
                }
            }
            else
            {
                MessageBox.Show("Número de carnet no válido");
            }
        }

        private void cerrarformulario(object sender, EventArgs e)
        {
            txtnumeroCarnet.Text = "";
            this.Show();
        }

        private void BTNNUEVOUSUARIO_Click(object sender, EventArgs e)
        {
            NuevoUsuario form = new NuevoUsuario();
            form.Show();
            this.Hide();
            form.FormClosing += cerrarformulario;
        }

        private void txtnumeroCarnet_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }
    }
}
