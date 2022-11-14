using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryTPILab_y_Log_Alvarez
{
    public partial class frmBusquedaCliente : Form
    {
        public frmBusquedaCliente()
        {
            InitializeComponent();
        }

        private void gbCargaDeDatos_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCargarCliente_Click(object sender, EventArgs e)
        {
            Int32 DniCliente = Convert.ToInt32(txtBusquedaDni.Text);
            Class objCliente = new Class();
            objCliente.BuscarCliente(DniCliente);
            if (objCliente.Dni == 0)
            {
                lblResultadoNombreCliente.Text = "";
                lblResultadoDeuda.Text = ("");
                lblResultadoCiudad.Text = "";
                txtBusquedaDni.Text = "";
                MessageBox.Show("El Dni ingresado no corresponde a ningun Cliente");
            }
            else
            {
                lblResultadoNombreCliente.Text = objCliente.Nom_Apellido;
                lblResultadoDeuda.Text = objCliente.Saldo.ToString();
                lblResultadoCiudad.Text = objCliente.Cod_Ciudad.ToString();
                lblLimite.Text = objCliente.Limite_deuda.ToString();
            }
            
        }
    }
}