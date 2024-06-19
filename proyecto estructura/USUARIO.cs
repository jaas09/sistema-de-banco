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
    public partial class USUARIO : Form
    {
        // Asegúrate de que estos campos sean del tipo ListBox
        private string nombre;
        private string apellido;
        private string correo;
        private long telefono;
        private string tipo_cuenta;
        private float saldo;
        private long numero_cuenta;
        private long numeroCarnet;

        public USUARIO(string nombre,string apellido ,string correo,long carnet,long telefono,string tipo_cuenta,float saldo ,long numero_cuenta)
        {
            InitializeComponent();
            numeroCarnet = carnet; 
            this.nombre = nombre;
            this.correo = correo;
            this.telefono = telefono;
            this.tipo_cuenta = tipo_cuenta;
            this.saldo = saldo;
            this.numero_cuenta=numero_cuenta;
            this.apellido = apellido;
        }

        private void USUARIO_Load(object sender, EventArgs e)
        {
            lst_cacrnet.Items.Add(numeroCarnet);
            lst_apellido.Items.Add(apellido);
            lst_nombre.Items.Add(nombre);
            lst_correo.Items.Add(correo);
            lst_numeroCuenta.Items.Add(numero_cuenta);
            lst_saldo.Items.Add(saldo);
            lst_telefono.Items.Add(telefono);
            lst_targeta.Items.Add(tipo_cuenta);

            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    } }