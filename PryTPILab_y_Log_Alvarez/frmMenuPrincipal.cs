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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void actualizaciónDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCargar_Nuevo_Cliente nv = new frmCargar_Nuevo_Cliente();
            nv.ShowDialog();
        }

        private void buscarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBusquedaCliente nv = new frmBusquedaCliente();
            nv.ShowDialog();
        }

        private void todosLosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoClientes nv = new frmListadoClientes();
            nv.ShowDialog();
        }

        private void clientesDeudoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoClientesDeudores nv = new frmListadoClientesDeudores();
            nv.ShowDialog();
        }

        private void porActividadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoPorActividad nv = new frmListadoPorActividad();
            nv.ShowDialog();
        }

        private void porCiudadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoPorUnaCiudad nv = new frmListadoPorUnaCiudad();
            nv.ShowDialog();
        }

        private void porBarrioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoPorBarrio nv = new frmListadoPorBarrio();
            nv.ShowDialog();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenidos a PowerGYM,esperamos que Disfruten de nuestras Maquinas y Personal.");
        }
    }
}
