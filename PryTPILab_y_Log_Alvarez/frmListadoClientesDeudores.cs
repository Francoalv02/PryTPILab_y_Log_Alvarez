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
    public partial class frmListadoClientesDeudores : Form
    {
        public frmListadoClientesDeudores()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Class objCliente = new Class();
            objCliente.ListarDeudores(dgwGrillaDeudores);
            lblResultadoCantidad.Text = objCliente.CantidadTotal.ToString();
            lblResultadoDeuda.Text = objCliente.TotaldelaDeuda.ToString("0,00");
            lblResultadoPromedio.Text = objCliente.PromedioTotal.ToString("0,00");

        }

        private void lblResultadoDeuda_Click(object sender, EventArgs e)
        {

        }

        private void frmListadoClientesDeudores_Load(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            dgwGrillaDeudores.Rows.Clear();
            lblResultadoCantidad.Text = "";
            lblResultadoDeuda.Text = "";
            lblResultadoPromedio.Text = "";
        }
    }
}
