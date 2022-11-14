using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace PryTPILab_y_Log_Alvarez
{
    public partial class frmCargar_Nuevo_Cliente : Form
    {
        public frmCargar_Nuevo_Cliente()
        {
            InitializeComponent();
        }
        


        private void btnCargarCliente_Click(object sender, EventArgs e)
        {
            Class objCliente = new Class();
            objCliente.Nom_Apellido = txtNombreApellido.Text;
            objCliente.Dni = Convert.ToInt32(txtDni.Text);
            objCliente.Cod_Ciudad = Convert.ToInt32(cbCiudad.SelectedIndex);
            objCliente.Saldo = Convert.ToInt32(txtSaldo.Text);
            objCliente.Cod_Barrio = Convert.ToString( cbBarrio.SelectedIndex);
            objCliente.Cod_Actividad = Convert.ToString(cbActividad.SelectedIndex);
            objCliente.Limite_deuda = Convert.ToDecimal(txtDeuda.Text);
            objCliente.Deuda = Convert.ToDecimal(txtDeuda.Text);

            objCliente.NuevoCliente();

            MessageBox.Show("Datos Grabados Correctamente");
            txtDni.Text = "";
            txtNombreApellido.Text = "";
            txtLimiteDeCredito.Text = "";
            txtDeuda.Text = "";
            txtSaldo.Text = "";
            cbActividad.SelectedIndex = 0;
            cbBarrio.SelectedIndex = 0;
            cbCiudad.SelectedIndex = 0;

        }

        private void frmCargar_Nuevo_Cliente_Load(object sender, EventArgs e)
        {
            ClsCiudad objCliente = new ClsCiudad();
            objCliente.Listar(cbCiudad);

            ClsBarrio Barr = new ClsBarrio();
            Barr.ListarBarrio(cbBarrio);

            ClsActividad Act = new ClsActividad();
            Act.ListarActividad(cbActividad);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
