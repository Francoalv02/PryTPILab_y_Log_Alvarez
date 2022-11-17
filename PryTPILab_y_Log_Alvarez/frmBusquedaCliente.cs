using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
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
            Class objCliente = new Class();
            
            if (txtBusquedaDni.Text != "")
            {
                Int32 DniCliente = Convert.ToInt32(txtBusquedaDni.Text);
                objCliente.BuscarCliente(DniCliente);
                lblResultadoNombreCliente.Text = objCliente.Nom_Apellido;
                lblResultadoDeuda.Text = objCliente.Deuda.ToString();
                lblResultadoSaldo.Text = objCliente.Saldo.ToString();
                txtLimiteDeuda.Text = objCliente.Limite_deuda.ToString();
            }
            else
            {
                lblResultadoNombreCliente.Text = "";
                lblResultadoDeuda.Text = ("");
                lblResultadoSaldo.Text = "";
                txtBusquedaDni.Text = "";
                MessageBox.Show("Ingrese un dato");
            }
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            txtLimiteDeuda.Enabled = true;
            btnEliminar.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Int32 dni = Convert.ToInt32(txtBusquedaDni.Text);
            Class nv = new Class();
            nv.Limite_deuda = Convert.ToDecimal(txtLimiteDeuda.Text);
            nv.ModificarCliente(dni);
            MessageBox.Show("Dato Modificado Correctamente");
            LimpiarTexto();
            btnEliminar.Enabled=true;
        }
        public void LimpiarTexto()
        {
            txtBusquedaDni.Text = "";
            txtLimiteDeuda.Text = "";
            lblResultadoSaldo.Text = "";
            lblResultadoDeuda.Text = "";
            lblResultadoNombreCliente.Text = "";

        }
        private void frmBusquedaCliente_Load(object sender, EventArgs e)
        {

        }
    }
}