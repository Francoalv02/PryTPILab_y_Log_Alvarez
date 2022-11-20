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
    public partial class frmListadoPorBarrio : Form
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();


        private string cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Base de Datos IEFI.2.mdb";
        public frmListadoPorBarrio()
        {
            InitializeComponent();
        }

        private void frmListadoPorBarrio_Load(object sender, EventArgs e)
        {
            ClsBarrio Barr = new ClsBarrio();
            Barr.ListarBarrio(cbBarrio);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            if (cbBarrio.Text != "")
            {
                try
                {
                    int id = 0;

                    OleDbConnection conexionDB;
                    conexionDB = new OleDbConnection(cadenaConexion);
                    conexionDB.Open();

                    OleDbCommand comandoCiudad = new OleDbCommand();
                    comandoCiudad.Connection = conexionDB;
                    comandoCiudad.CommandType = CommandType.TableDirect;
                    comandoCiudad.CommandText = "SELECT * FROM Cod_Barrio WHERE Detalle='" + cbBarrio.Text + "'";
                    OleDbDataReader readerActividades = comandoCiudad.ExecuteReader();

                    while (readerActividades.Read())
                    {
                        id = int.Parse(readerActividades["Cod_Barrio"].ToString());
                    }

                    //Buscando el codigo identificador
                    OleDbCommand comandoRegistroPrincipal = new OleDbCommand();
                    comandoRegistroPrincipal.Connection = conexionDB;
                    comandoRegistroPrincipal.CommandType = CommandType.TableDirect;
                    comandoRegistroPrincipal.CommandText = "SELECT * FROM Registro_Principal WHERE Cod_Barrio=" + id + " ORDER BY Dni";
                    OleDbDataReader readerClientes = comandoRegistroPrincipal.ExecuteReader();

                    //Buscar los Nombre de los Clientes de ese Barrio
                    while (readerClientes.Read())
                    {
                        dgwLisBarrio.Rows.Add(readerClientes["Dni"], readerClientes["Nom_Apellido"]);
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
            dgwLisBarrio.Rows.Clear();
            btnListar.Enabled = true;
        }
    }
}
