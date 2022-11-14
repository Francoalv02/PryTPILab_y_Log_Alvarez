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
    public partial class frmPrinipal : Form
    {
        public frmPrinipal()
        {
            InitializeComponent();
        }

        private void frmPrinipal_Load(object sender, EventArgs e)
        {

        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregarNuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCargar_Nuevo_Cliente nv = new frmCargar_Nuevo_Cliente();
            nv.ShowDialog();
        }

        private void buscarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBusquedaCliente nv = new frmBusquedaCliente();
            nv.ShowDialog();
        }

        private void consultaDeUnClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void listadoDeTodsLosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoClientes nv = new frmListadoClientes ();
            nv.ShowDialog();
        }

        private void listadoDeClientesDeudoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoClientesDeudores nv = new frmListadoClientesDeudores();
            nv.ShowDialog();
        }

        private void listadoDeClientesDeUnaCiudadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoClienteDeUnaCiudad nv = new frmListadoClienteDeUnaCiudad();
            nv.ShowDialog();
        }

        private void sistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenidos a GrandGym,esperamos disfrute nuestros locales ,maquinas y profesores ");
        }
    }
}
