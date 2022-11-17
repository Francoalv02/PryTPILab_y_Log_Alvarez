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
    public partial class frmListadoPorUnaCiudad : Form
    {
        public frmListadoPorUnaCiudad()
        {
            InitializeComponent();
        }

        private void frmListadoPorUnaCiudad_Load(object sender, EventArgs e)
        {
            ClsCiudad Barr = new ClsCiudad();
            Barr.Listar(cbCiudad);
        }
    }
}
