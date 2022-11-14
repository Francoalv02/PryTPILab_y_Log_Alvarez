using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace PryTPILab_y_Log_Alvarez
{
    internal class ClsCiudad
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();


        private string cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Base de Datos IEFI.2.mdb";
        private string Tabla = "Cod_Ciudad";

        public void Listar(DataGridView grilla)
        {
            try
            {
                conexion.ConnectionString = cadenaConexion;//conecto
                conexion.Open();//abro

                comando.Connection = conexion;//cual e sla conexion que se utiliza
                comando.CommandType = CommandType.TableDirect;//trabaja directo con la tabla
                comando.CommandText = Tabla;//nombre de la tabla

                adaptador = new OleDbDataAdapter(comando);//convierte los datos a un .net entendible
                DataSet Ds = new DataSet();
                adaptador.Fill(Ds);


                grilla.DataSource = Ds.Tables[0];//mostrar datos



                conexion.Close();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Convert.ToString( Error));
            }
            

        }

        public void Listar(ComboBox combo)
        {
            try
            {
                conexion.ConnectionString = cadenaConexion;//conecto
                conexion.Open();//abro

                comando.Connection = conexion;//cual e sla conexion que se utiliza
                comando.CommandType = CommandType.TableDirect;//trabaja directo con la tabla
                comando.CommandText = Tabla;//nombre de la tabla

                adaptador = new OleDbDataAdapter(comando);//convierte los datos a un .net entendible
                DataSet Ds = new DataSet();
                adaptador.Fill(Ds, Tabla);


                combo.DataSource = Ds.Tables[Tabla];//mostrar datos
                combo.DisplayMember = "Detalle"; //el nombre de la columna para mostrar
                combo.ValueMember = "Cod_Ciudad";//indicador del nombre

                conexion.Close();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Convert.ToString(Error));
            }

        }
    }
}