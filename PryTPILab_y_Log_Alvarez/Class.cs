﻿using System;
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

        private Int32 DniCliente;
        private string Nombre;
        private decimal Deudaa;
        private decimal Limite;
        private Int32 Ciudad;
        private Int32 Sueldoo;
        private string Barrio;
        private string Actividad;


        public Int32 Dni
        {
            get { return DniCliente; }
            set { DniCliente = value; }
        }
        public Int32 Saldo
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
            set { DniCliente = Convert.ToInt32 (value); }
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
        public void BuscarCliente(Int32 DniClientes)
        {
            try
            {
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();//apertura de la base

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = "Registro_Principal";

                OleDbDataReader DR = comando.ExecuteReader();//leer
                DniCliente = 0;
                if (DR.HasRows)
                {
                    while (DR.Read())//mientras hay datos leer
                    {
                        if (DR.GetInt32(4) == DniClientes)
                        {
                            DniCliente = DR.GetInt32(4);
                            Nombre = DR.GetString(0);
                            Ciudad = DR.GetInt32(1);
                            Deuda = DR.GetDecimal(7);
                            Limite = DR.GetDecimal(6);
                        }
                    }
                }
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

                   fila["Dni"] = DniCliente;
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
    }   
}
