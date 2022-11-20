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
    public partial class frmListadoPorUnaCiudad : Form
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();


        private string cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Base de Datos IEFI.2.mdb";
        public frmListadoPorUnaCiudad()
        {
            InitializeComponent();
        }

        private void frmListadoPorUnaCiudad_Load(object sender, EventArgs e)
        {
            ClsCiudad Barr = new ClsCiudad();
            Barr.Listar(cbCiudad);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            if (cbCiudad.Text != "")
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
                    comandoCiudad.CommandText = "SELECT * FROM Cod_Ciudad WHERE Detalle='" + cbCiudad.Text + "'";
                    OleDbDataReader readerActividades = comandoCiudad.ExecuteReader();

                    while (readerActividades.Read())
                    {
                        id = int.Parse(readerActividades["Cod_Ciudad"].ToString());
                    }

                    //Buscando el codigo identificador
                    OleDbCommand comandoRegistroPrincipal = new OleDbCommand();
                    comandoRegistroPrincipal.Connection = conexionDB;
                    comandoRegistroPrincipal.CommandType = CommandType.TableDirect;
                    comandoRegistroPrincipal.CommandText = "SELECT * FROM Registro_Principal WHERE Cod_Ciudad=" + id + " ORDER BY Dni";
                    OleDbDataReader readerClientes = comandoRegistroPrincipal.ExecuteReader();

                    //Buscar los Nombre de los Clientes de esa Ciudad
                    while (readerClientes.Read())
                    {
                        dgwLisCiudad.Rows.Add(readerClientes["Dni"], readerClientes["Nom_Apellido"]);
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
            dgwLisCiudad.Rows.Clear();
            btnListar.Enabled = true ;
        }
    }
}
