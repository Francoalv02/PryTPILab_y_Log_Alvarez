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
    public partial class frmListadoPorActividad : Form
    {
        public frmListadoPorActividad()
        {
            InitializeComponent();
        }

        private void frmListadoPorActividad_Load(object sender, EventArgs e)
        {
            ClsActividad objCliente = new ClsActividad();
            objCliente.ListarActividad(cbActividad);
        }
    }
}
