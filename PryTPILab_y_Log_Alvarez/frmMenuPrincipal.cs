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
    public partial class frmMenuPrincipal : Form
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();


         string cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Base de Datos IEFI.2.mdb";
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

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        public string functTransformIDIntoString(string table, string column_id, string column_detalle, int inputID)
        {
            string detalleResultado = "";

            try
            {
                OleDbConnection conexionDB;

                conexionDB = new OleDbConnection(cadenaConexion);
                conexionDB.Open();

                OleDbCommand command = new OleDbCommand();

                command.Connection = conexionDB;
                command.CommandType = CommandType.TableDirect;
                command.CommandText = "SELECT * FROM " + table;

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (int.Parse(reader[column_id].ToString()) == inputID)
                    {
                        detalleResultado = reader[column_detalle].ToString();
                    }
                }

                conexionDB.Close();
                reader.Close();
            }
            catch
            {
                MessageBox.Show("Error en la función functTransformIdIntoString!");
            }

            return detalleResultado;
        }
    }
}
