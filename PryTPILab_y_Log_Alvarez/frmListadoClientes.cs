﻿using System;
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
    public partial class frmListadoClientes : Form
    {
        public frmListadoClientes()
        {
            InitializeComponent();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            dgwTodosClientes.Columns.Clear();
        }

        private void btnMostrarListado_Click(object sender, EventArgs e)
        {
            Class objCliente = new Class();
            objCliente.Listar(dgwTodosClientes);
        }
    }
}
