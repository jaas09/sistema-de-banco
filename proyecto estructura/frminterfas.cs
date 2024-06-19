using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
namespace proyecto_estructura
{
    public partial class frm_inicio : Form
    {
        private static IconMenuItem menuActivo = null;
        private static Form formularioActivo = null;
        private System.Windows.Forms.Panel panelContenedor;
        public long numCarnet;
        public frm_inicio(long numCarnet)
        {
            InitializeComponent();
            this.numCarnet = numCarnet; 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frm_inicio_Load(object sender, EventArgs e)
        {

        }

        private void iconMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_2(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip2_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_3(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void qweqwToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void AbrirFormulario(IconMenuItem menu,Form formulario)
        {
            if(menuActivo!=null)
            {
                menuActivo.BackColor = Color.White;
            }
            menu.BackColor = Color.Silver;
            menuActivo = menu;
            if(formularioActivo!=null)
            {
                formularioActivo.Close();
            }
            formularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.SteelBlue;
            contenedor.Controls.Add(formularioActivo);
            formulario.Show();
           
        }
        private void menuusuarios_Click(object sender, EventArgs e)
        {
            Nodo_listas_dobles nodo = Estatica.llamar.BuscarNodo(numCarnet);

            NodoCuentas nodoCuentas = Estatica.cuentas.BuscarNodo(numCarnet);
            string cuento = nodoCuentas.GetTiposCuenta()[0];
            long numero = nodoCuentas.GetNumerosCuenta()[0];
            float Saldo = nodoCuentas.GetSaldos()[0];

            AbrirFormulario((IconMenuItem)sender, new USUARIO(nodo.Nombre, nodo.Apellido, nodo.Gmail, nodo.Ci, nodo.Telefono, cuento , Saldo, numero));
        }

        private void contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menudepositos_Click(object sender, EventArgs e)
        {
            Nodo_listas_dobles nodo = Estatica.llamar.BuscarNodo(numCarnet);

            AbrirFormulario((IconMenuItem)sender, new frm_deposito());
        }

        private void iconMenuItem1_Click(object sender, EventArgs e)
        {
            Nodo_listas_dobles nodo = Estatica.llamar.BuscarNodo(numCarnet);

            AbrirFormulario((IconMenuItem)sender, new FrmRetito());
        }

        private void PRESTAMOS_Click(object sender, EventArgs e)
        {
            Nodo_listas_dobles nodo = Estatica.llamar.BuscarNodo(numCarnet);
            AbrirFormulario((IconMenuItem)sender, new frmTracsacion());
        
    }

        private void iNFORMEGENERALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInforme_General form = new  frmInforme_General();
            form.Show();
            this.Hide();
            form.FormClosing += cerrarformulario;
        }

        private void pRESTAMOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrestamo form = new frmPrestamo();
            form.Show();
            this.Hide();
            form.FormClosing += cerrarformulario;
        }
        private void cerrarformulario(object sender, EventArgs e)
        {
            this.Show();
        }

        private void BTNNUEVOUSUARIO_Click(object sender, EventArgs e)
        {
            NuevoUsuario form = new NuevoUsuario();
            form.Show();
            this.Hide();
            form.FormClosing += cerrarformulario;
        }
    }
}
