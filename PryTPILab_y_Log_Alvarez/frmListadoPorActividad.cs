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
    public partial class frmListadoPorActividad : Form
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();


        private string cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Base de Datos IEFI.2.mdb";


        public frmListadoPorActividad()
        {
            InitializeComponent();
        }

        private void frmListadoPorActividad_Load(object sender, EventArgs e)
        {
            ClsActividad Barr = new ClsActividad();
            Barr.ListarActividad(cbActividad);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            if (cbActividad.Text != "")
            {
                try
                {
                    
                    dgwLisActividad.Rows.Clear();

                    int id = 0;

                    OleDbConnection conexionDB;
                    conexionDB = new OleDbConnection(cadenaConexion);
                    conexionDB.Open();

                    OleDbCommand comandoActividades = new OleDbCommand();
                    comandoActividades.Connection = conexionDB;
                    comandoActividades.CommandType = CommandType.TableDirect;
                    comandoActividades.CommandText = "SELECT * FROM Cod_Actividad WHERE Detalle='" + cbActividad.Text + "'";
                    OleDbDataReader readerActividades = comandoActividades.ExecuteReader();

                    while (readerActividades.Read())
                    {
                        id = int.Parse(readerActividades["Cod_Actividad"].ToString());
                    }

                    //Buscando el codigo identificador
                    OleDbCommand comandoClientes = new OleDbCommand();
                    comandoClientes.Connection = conexionDB;
                    comandoClientes.CommandType = CommandType.TableDirect;
                    comandoClientes.CommandText = "SELECT * FROM Registro_Principal WHERE Cod_Actividad=" + id + " ORDER BY Dni";
                    OleDbDataReader readerClientes = comandoClientes.ExecuteReader();

                    //Buscar los Nombre de los Clientes de esa Actividad
                    while (readerClientes.Read())
                    {
                        dgwLisActividad.Rows.Add(readerClientes["Dni"], readerClientes["Nom_Apellido"]);
                    }

                    readerClientes.Close();
                    conexionDB.Close();

                    btnListar.Enabled = false;
                    btnBorrar.Enabled = true;
                    
                }

                catch
                {
                    MessageBox.Show("ERROR");
                }
            }
            else
            {
                MessageBox.Show("Eliga una opción de la Lista Desplegable");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            btnListar.Enabled = true;
            dgwLisActividad.Rows.Clear();
        }
    }
    
}
