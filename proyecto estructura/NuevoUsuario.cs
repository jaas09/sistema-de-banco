    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
using System.Windows.Navigation;

namespace proyecto_estructura
{
    public partial class NuevoUsuario : Form
    {
        
        public NuevoUsuario()
        {
            InitializeComponent();
        }

        private void NuevoUsuario_Load(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
        private bool validar_campo(string nombre, string apellido, string carnetStr,  string telefonoStr,string saldo,string tipo_cuenta ,string gmail)
        {



            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Falta Colocar Nombre");
                return false;
            }
            if (string.IsNullOrWhiteSpace(gmail))
            {
                MessageBox.Show("Falta Colocar Gmail");
                return false;
            }
            if (string.IsNullOrWhiteSpace(saldo) || !long.TryParse(saldo, out long sald))
            {
                MessageBox.Show("Falta Colocar Contraseña");
                return false;
            }
            if (string.IsNullOrWhiteSpace(telefonoStr) || !long.TryParse(telefonoStr, out long tele))
            {
                MessageBox.Show("Falta Colocar Telefono");
                return false;
            }
            if (string.IsNullOrWhiteSpace(carnetStr) || !long.TryParse(carnetStr, out long carnet))
            {
                MessageBox.Show("Falta Colocar Carnet");
                return false;
            }
            if (string.IsNullOrWhiteSpace(tipo_cuenta))
            {
                MessageBox.Show("Falta Colocar Apellido");
                return false;
            }
            if (string.IsNullOrWhiteSpace(apellido))
            {
                MessageBox.Show("Falta Colocar Apellido");
                return false;
            }

            return true;
        }

        private void BTN_SALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tn_registrar_Click(object sender, EventArgs e)
        {
            long telefono, ci,Saldo;
            string nombre = txtNombre.Text;
            string apellido = txt_apellido.Text;
            string carnetStr=txt_Carnet.Text;
            string telefonoStr=txt_telefono.Text;
            string  saldo = TXT_CONTRASEÑA.Text;
            string gmail = TXT_CORREO.Text;
            string tipo_cuenta=cbnTipoCuenta.Text;
            DateTime fechaRegistro = DateTime.Now;
            while (validar_campo(nombre, apellido, carnetStr, telefonoStr, saldo,gmail,tipo_cuenta) == true)
            {
                if (validar_campo(nombre, apellido, carnetStr, telefonoStr, saldo,gmail,tipo_cuenta) != false)
                {
                
                    telefono =long.Parse(telefonoStr);
                    ci=long.Parse(carnetStr) ;
                    Saldo=long.Parse(saldo) ;
                    Estatica.llamar.crear_lista(nombre, apellido, gmail, ci, telefono,  fechaRegistro);
                    Estatica.cuentas.CrearLista(ci,tipo_cuenta,Saldo);
                    MessageBox.Show("Usuario Registrado");
                    this.Close();
                }
                break;  
            }
           

        }
        private void cerrarformulario(object sender, EventArgs e)
        {
            this.Show();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}