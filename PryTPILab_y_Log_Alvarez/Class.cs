using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.IO;


namespace PryTPILab_y_Log_Alvarez
{
    internal class Class
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();


        private string cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Base de Datos IEFI.2.mdb";
        private string Tabla = "Registro_Principal";
        private string TablaCiudad = "Cod_Ciudad";
        private string Detalle = "Detalle";



        private int varCantidad;
        private decimal varDeuda;

        private Int32 IdCliente;
        private string Nombre;
        private decimal Deudaa;
        private decimal Limite;
        private Int32 Ciudad;
        private Decimal Sueldoo;
        private string Barrio;
        private string Actividad;


        public Int32 Dni
        {
            get { return IdCliente; }
            set { IdCliente = value; }
        }
        public Decimal Saldo
        {
            get { return Sueldoo; }
            set { Sueldoo = value; }
        }
        public string Cod_Barrio
        {
            get { return Barrio; }
            set { Barrio = value; }
        }
        public string Cod_Actividad
        {
            get { return Actividad; }
            set { Actividad = value; }
        }

        public string Nom_Apellido
        {    
            get { return Nombre; }
            set { Nombre = value; }
        }

        public decimal Deuda
        {
            get { return Deudaa; }
            set { IdCliente = Convert.ToInt32 (value); }
        }

        public decimal Limite_deuda
        {
            get { return Limite; }
            set { Limite = value; }
        }

        public Int32 Cod_Ciudad
        {
            get { return Ciudad; }
            set { Ciudad = value; }
        }

        public decimal TotaldelaDeuda
        {
            get { return varDeuda; }
        }
        public int CantidadTotal
        {
            get { return varCantidad; }
        }
        public decimal PromedioTotal
        {
            get { return varDeuda/varCantidad; }
        }



        public void Listar(DataGridView grilla)
        {
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();

            comando.Connection = conexion;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = Tabla;

            adaptador = new OleDbDataAdapter(comando);
            DataSet Ds = new DataSet();
            adaptador.Fill(Ds);


            grilla.DataSource = Ds.Tables[0];



            conexion.Close();

        }

        public void ListarDeudores(DataGridView dgwGrillaDeudores)
        {
            try
            {
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();//apertura de la base

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = "Registro_Principal";

                OleDbDataReader DR = comando.ExecuteReader(); ;
                varCantidad = 0;
                varDeuda = 0;

                while (DR.Read())
                {
                    if (DR.GetDecimal(7) > 0 )
                    {
                        dgwGrillaDeudores.Rows.Add(DR.GetInt32(4), DR.GetString(0), DR.GetDecimal(7));
                        varCantidad++;
                        varDeuda = varDeuda + DR.GetDecimal(7);

                    }
                    
                }

                conexion.Close();//cierre de la base
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.ToString());
            }
            
        }
        public void BuscarCliente(Int32 DniCliente)
        {
            try
            {
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();//apertura de la base

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = "Registro_Principal";

                OleDbDataReader DR = comando.ExecuteReader();//leer
                
                if (DR.HasRows)//si hay filas
                {
                    while (DR.Read())//mientras hay datos leer
                    {
                        if (DR.GetInt32(4) == DniCliente)
                        {
                            IdCliente = DR.GetInt32(4);
                            Nombre = DR.GetString(0);
                            Sueldoo = DR.GetDecimal(2);
                            Deuda = DR.GetDecimal(7);
                            Limite = DR.GetDecimal(6);

                        }
                    }
                }
                conexion.Close();
            }   
            catch (Exception error)
            {

                MessageBox.Show(Convert.ToString(error));
            }

            
        }
        public void NuevoCliente()
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
                adaptador.Fill(Ds,Tabla);


                DataTable tabla = Ds.Tables[Tabla];//-tabla1-
                DataRow fila = tabla.NewRow();//nueva fila de la -tabla1-

                   fila["Dni"] = IdCliente;
                   fila["Nom_Apellido"] = Nombre;
                   fila["Deuda"] = Deudaa;
                   fila["Limite_deuda"] = Limite;
                   fila["Cod_Ciudad"] = Ciudad;
                   fila["Saldo"] = Sueldoo;
                   fila["Cod_Barrio"] = Barrio;
                   fila["Cod_Actividad"] = Actividad;

                tabla.Rows.Add(fila);
                OleDbCommandBuilder Confirmacion = new OleDbCommandBuilder(adaptador);//concilia los cambios
                adaptador.Update(Ds, Tabla);//realiza el cambio

                conexion.Close();
            }
            catch (Exception Error)
            {

                MessageBox.Show(Convert.ToString(Error));

            }

        }


        public void FuncionTranformarString_a_Id(string tablaCiudad, string Cod_Ciudad, string Detalle, string input)
        {
            int id = 0;

            try
            {
                OleDbConnection conexionDB;

                conexionDB = new OleDbConnection(tablaCiudad);
                conexionDB.Open();

                OleDbCommand command = new OleDbCommand();

                command.Connection = conexionDB;
                command.CommandType = CommandType.TableDirect;
                command.CommandText = "SELECT * FROM " + tablaCiudad;

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader[Detalle].ToString() == input)
                    {
                        id = int.Parse(reader[Cod_Ciudad].ToString());
                    }
                }
                conexionDB.Close();
                reader.Close();
            }
            catch
            {
                MessageBox.Show("Error en la función");
            }

            //return id;
        }

        public void ModificarCliente(Int32 IDCliente)
        {
            try
            {
                OleDbConnection conexionDB;
                conexionDB = new OleDbConnection(cadenaConexion);
                conexionDB.Open();
                using (System.Data.OleDb.OleDbCommand commandUpdate = new System.Data.OleDb.OleDbCommand(
                    "UPDATE Registro_Principal SET [Limite_deuda]=@limite WHERE [Dni]=@dni", conexionDB))
                {
                    commandUpdate.Parameters.Add(new System.Data.OleDb.OleDbParameter("@limite", Convert.ToDecimal(Limite.ToString())));
                    commandUpdate.Parameters.Add(new System.Data.OleDb.OleDbParameter("@dni", int.Parse(IDCliente.ToString())));
                    commandUpdate.ExecuteNonQuery();
                }
                conexionDB.Close();

            }
            catch (Exception error)
            {

                MessageBox.Show(Convert.ToString( error));
            }
        }

        public void EliminarCliente(Int32 IDCliente)
        {
            try
            {
                OleDbConnection conexionDB;
                conexionDB = new OleDbConnection(cadenaConexion);
                conexionDB.Open();
                using (System.Data.OleDb.OleDbCommand commandUpdate = new System.Data.OleDb.OleDbCommand(
                    "DELETE * FROM UPDATE Registro_Principal SET[Limite_deuda] = @limite WHERE[Dni] = @dni" , conexionDB))
                {
                    commandUpdate.Parameters.Add(new System.Data.OleDb.OleDbParameter("@limite", Convert.ToDecimal(Limite.ToString())));
                    commandUpdate.Parameters.Add(new System.Data.OleDb.OleDbParameter("@dni", int.Parse(IDCliente.ToString())));
                    commandUpdate.ExecuteNonQuery();
                }
                conexionDB.Close();

            }
            catch (Exception error)
            {

                MessageBox.Show(Convert.ToString(error));
            }
        }

        public void GenerarReporte()
        {
            try
            {
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();//apertura de la base

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = "Registro_Principal";

                OleDbDataReader DR = comando.ExecuteReader();

                StreamWriter AD = new StreamWriter("ReportesDeClientes.csv", false);
                AD.WriteLine("Listado de Clientes");
                AD.WriteLine("Dni;Nombre;Deuda");
                    
                varCantidad = 0;
                varDeuda = 0;

                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        AD.Write(DR.GetInt32(4));
                        AD.Write(";");
                        AD.Write(DR.GetString(0));
                        AD.Write(";");
                        AD.WriteLine(DR.GetDecimal(7));
                        varCantidad++;
                        varDeuda = varDeuda + DR.GetDecimal(7);
                    }
                    AD.Write("Cantidadde Clientes:;");
                    AD.WriteLine(varCantidad);
                    AD.Write("Cantidadde Clientes:");
                    AD.WriteLine(Deuda);
                    
                }
                conexion.Close();//cierre de la base
                AD.Close();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.ToString());
            }
        }
    }   
}
