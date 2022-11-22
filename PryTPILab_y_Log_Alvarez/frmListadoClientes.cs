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
    public partial class frmListadoClientes : Form
    {
        public frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal();

        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();


        private string cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Base de Datos IEFI.2.mdb";
        public frmListadoClientes()
        {
           
            InitializeComponent();
            
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            dgwTodosClientes.Rows.Clear();
            btnMostrarListado.Enabled = true;
        }

        private void btnMostrarListado_Click(object sender, EventArgs e)
        {
            dgwTodosClientes.Rows.Clear();

            OleDbConnection conexionDB;

            conexionDB = new OleDbConnection(cadenaConexion);
            conexionDB.Open();

            OleDbCommand comando = new OleDbCommand();

            comando.Connection = conexionDB;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "SELECT * FROM Registro_Principal ORDER BY Dni";
            OleDbDataReader reader = comando.ExecuteReader();

            //transformo los id_profesor, id_barrio en strings en la grilla
            while (reader.Read())
            {
                string strBarrio = frmMenuPrincipal.functTransformIDIntoString("Cod_Barrio", "Cod_Barrio", "Detalle", int.Parse(reader["Cod_Barrio"].ToString()));
                string strCiudad = frmMenuPrincipal.functTransformIDIntoString("Cod_Ciudad", "Cod_Ciudad", "Detalle", int.Parse(reader["Cod_Ciudad"].ToString()));
                string strActividad = frmMenuPrincipal.functTransformIDIntoString("Cod_Actividad", "Cod_actividad", "Detalle", int.Parse(reader["Cod_Actividad"].ToString()));

                dgwTodosClientes.Rows.Add(reader["Dni"], reader["Nom_Apellido"], "$" + reader["Deuda"], strBarrio, strCiudad,
                 strActividad, reader["Saldo"], reader["Limite_deuda"]);


            }

            reader.Close();
            conexionDB.Close();

            btnMostrarListado.Enabled = false;
            btnBorrar.Enabled = true;



        }

        private void frmListadoClientes_Load(object sender, EventArgs e)
        {
            
            
        }
    }
}
