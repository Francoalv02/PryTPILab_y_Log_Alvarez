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
    public partial class frmListadoPorBarrio : Form
    {
        public frmListadoPorBarrio()
        {
            InitializeComponent();
        }

        private void frmListadoPorBarrio_Load(object sender, EventArgs e)
        {
            ClsBarrio Barr = new ClsBarrio();
            Barr.ListarBarrio(cbBarrio);
        }
    }
}
