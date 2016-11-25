using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Windows.Forms;

namespace TELECOM_RTD_System_1._0
{
    class Conexiones
    
    {
        string SQLCON = "Data Source=RAUL-ZEPEDA\\SQLEXPRESS;Initial Catalog=TelecomRTD_DB;Integrated Security=True;";
        SqlConnection mycon;
        public Conexiones()
        {
            mycon = new SqlConnection(SQLCON);
 
        }
        
        public bool Login(string Usuario, string Pass)
        {
            string[] Consul = new string[2];
            bool Resultado = false;
            SqlCommand Consulta = new SqlCommand(
                "SELECT Usuario, Password FROM Logins WHERE Usuario=@Usuario AND Password=@Password", mycon);
            Consulta.Parameters.AddWithValue("Usuario", Usuario);
            Consulta.Parameters.AddWithValue("Password", Pass);
            mycon.Open();
            SqlDataReader reader = Consulta.ExecuteReader();
            if (reader.Read())
            {
                Resultado = true;
            }
            else
            {
                MessageBox.Show("Error\nDatos no encontrados");

            }

            mycon.Close();
            return Resultado;
        }
        public void InsertaEmpleado(int idEmpleado, string Nombre, string Paterno, string Materno, string Sexo, string CURP, string RFC, string IMSS, int Año, string Telefono, string Direccion, string Puesto,int sueldo)
        {
            int Edad = Convert.ToInt32(DateTime.Today.Year.ToString()) - Año;
            SqlCommand AltaEmpleado = new SqlCommand("dbo.Alta_Empleado", mycon);
            try
            {
                
                AltaEmpleado.CommandType = CommandType.StoredProcedure;

                AltaEmpleado.Parameters.AddWithValue("idEmpleado", idEmpleado);
                AltaEmpleado.Parameters.AddWithValue("NomEmp", Nombre);
                AltaEmpleado.Parameters.AddWithValue("ApPaterno", Paterno);
                AltaEmpleado.Parameters.AddWithValue("APMaterno", Materno);
                AltaEmpleado.Parameters.AddWithValue("Sexo", Sexo);
                AltaEmpleado.Parameters.AddWithValue("CURP", CURP);
                AltaEmpleado.Parameters.AddWithValue("RFC", RFC);
                AltaEmpleado.Parameters.AddWithValue("IMSS", IMSS);
                AltaEmpleado.Parameters.AddWithValue("Edad", idEmpleado);
                AltaEmpleado.Parameters.AddWithValue("Telefono", idEmpleado);
                AltaEmpleado.Parameters.AddWithValue("Direccion", idEmpleado);
                AltaEmpleado.Parameters.AddWithValue("Puesto", Puesto);
                AltaEmpleado.Parameters.AddWithValue("SuelDiario", sueldo);
                mycon.Open();
                AltaEmpleado.ExecuteNonQuery();
                mycon.Close();
                MessageBox.Show("Registro exitoso", "Registro");
                
            }
            catch (SqlException SQL)
            {
                MessageBox.Show(SQL.Message, "error ");
            }
            finally
            {
                mycon.Dispose();
            }
        }
        public DataTable MostrarContacto()
        {
            SqlCommand MostrarEmpleados = new SqlCommand("dbo.Consultar_Empleadoo", mycon);
            MostrarEmpleados.CommandType = CommandType.StoredProcedure;
            try
            {
                SqlDataAdapter D = new SqlDataAdapter(MostrarEmpleados);
                DataTable DT = new DataTable();
                D.Fill(DT);
                return DT;
            }
            catch (SqlException SQL)
            {
                throw new Exception (SQL.Message);
                
            }
            finally
            {
                //mycon.Dispose();
                //MostrarEmpleados.Dispose();
            }
        }


        public DataTable MostrarObras()
        {
            SqlCommand Mostrar = new SqlCommand(
                "SELECT Obras.idObras, PEP, NomObra, RBS, Logins.Usuario FROM Obras INNER JOIN Logins ON	Obras.idLogin = Logins.idLogin", mycon);
            SqlDataAdapter DataAdapter = new SqlDataAdapter(Mostrar);
            DataTable DT = new DataTable();
            DataAdapter.Fill(DT);
            return DT;
        }


        //micagadero
        public DataTable MostrarAvanzes()
        {
            SqlCommand Avanzes = new SqlCommand(
                "SELECT Avances.idObras, FecIni, FecFin, Avance FROM Avances INNER JOIN Obras ON Avances.idObras = Obras.idObras", mycon);
            SqlDataAdapter DataAdapter = new SqlDataAdapter(Avanzes);
            DataTable DT = new DataTable();
            DataAdapter.Fill(DT);
            return DT;
        }



        public void InsertarObra(string PEP, string NomObr, string RSB, int idLogin)
        {
            SqlCommand AltaObra = new SqlCommand(
                "insert into Obras Values (@PEP, @NomObra, @RBS, @idLogin)", mycon);  /*dbo.Alta_Obras*/
            //AltaObra.CommandType = CommandType.StoredProcedure;
            
                AltaObra.Parameters.AddWithValue("PEP", PEP);
                AltaObra.Parameters.AddWithValue("NomObra", NomObr);
                AltaObra.Parameters.AddWithValue("RBS", RSB);
                AltaObra.Parameters.AddWithValue("idLogin", idLogin);
                mycon.Open();
                AltaObra.ExecuteNonQuery();
                mycon.Close();
                MessageBox.Show("Se a registrado la obra con exito!", "Alta");
            
            
        }
        public void EliminarObra(int idObra)
        {
            SqlCommand BorrarObra = new SqlCommand(
                "DELETE FROM Obras WHERE Obras.idObras = @idObras ", mycon);
            
                BorrarObra.Parameters.AddWithValue("idObras", idObra);
                mycon.Open();
                BorrarObra.ExecuteNonQuery();
                mycon.Close();
                MessageBox.Show("Se ah dado de baja la obra con exito!");
           
        }

        public void EliminarAvance(int idObra)
        {
            SqlCommand BorrarObra = new SqlCommand(
                "DELETE FROM Avances WHERE Avances.idObras = @idObras ", mycon);

            BorrarObra.Parameters.AddWithValue("idObras", idObra);
            mycon.Open();
            BorrarObra.ExecuteNonQuery();
            mycon.Close();
        }

        public void AltaAvance(string FecIni, string FecFin, int idObra, string Avance)
        {
            SqlCommand AltaAvance = new SqlCommand(
                "insert into Avances values(@idObras,@FecIni,@FecFin,@Avance)", mycon);
            AltaAvance.Parameters.AddWithValue("idObras", idObra);
            AltaAvance.Parameters.AddWithValue("FecIni", FecIni);
            AltaAvance.Parameters.AddWithValue("FecFin", FecFin);
            AltaAvance.Parameters.AddWithValue("Avance", Avance);
            mycon.Open();
            AltaAvance.ExecuteNonQuery();
            mycon.Close();
            
        }

        public void AltaObraAutos(int idObras, string Desc)
        {
            //codigo antiguo
            SqlCommand AltaProducto = new SqlCommand(
                "Update Autos SET idObras=@idObras WHERE Descripcion=@Descripcion", mycon);
            AltaProducto.Parameters.AddWithValue("idObras", idObras);
            AltaProducto.Parameters.AddWithValue("Descripcion", Desc);
            mycon.Open();
            AltaProducto.ExecuteNonQuery();
            mycon.Close();
        }

        public void AgregarObraEmpleado(int idObras, int idEmpleado)
        {
            SqlCommand AltaObrEmp = new SqlCommand(
                "Update Empleados SET idObras=@idObras WHERE idEmpleado=@idEmpleado", mycon);
            AltaObrEmp.Parameters.AddWithValue("idObras", idObras);
            AltaObrEmp.Parameters.AddWithValue("idEmpleado", idEmpleado);
            mycon.Open();
            AltaObrEmp.ExecuteNonQuery();
            mycon.Close();
        }

        public void AgregarObraUser(int idObras, string Usuario)
        {
            SqlCommand AltaObrUser = new SqlCommand(
                "Update Logins SET idObras=@idObras WHERE Usuario=@Usuario", mycon);
            AltaObrUser.Parameters.AddWithValue("idObras", idObras);
            AltaObrUser.Parameters.AddWithValue("Usuario", Usuario);
            mycon.Open();
            AltaObrUser.ExecuteNonQuery();
            mycon.Close();
        }

        
        
        public void BajaAutoObra(int idObras)
        {
            SqlCommand AltaProducto = new SqlCommand(
                "Update Autos SET idObras=NULL WHERE idObras=@idObras", mycon);
            AltaProducto.Parameters.AddWithValue("idObras", idObras);
            mycon.Open();
            AltaProducto.ExecuteNonQuery();
            mycon.Close();
        }
        
        public void BajaEmpleado(int idEmpleado)
        {
            SqlCommand Baja_Empleado = new SqlCommand(
                "dbo.Baja_Empleado", mycon);
            Baja_Empleado.CommandType = CommandType.StoredProcedure;
            Baja_Empleado.Parameters.AddWithValue("idEmpleado", idEmpleado);
            mycon.Open();
            Baja_Empleado.ExecuteNonQuery();
            mycon.Close();
            MessageBox.Show("Baja exitosa", "Baja");
        }
               
        public DataTable Autos()
        {
            SqlCommand MostrarAutos = new SqlCommand(
                "select Descripcion FROM Autos", mycon);
            try
            {
                SqlDataAdapter D = new SqlDataAdapter(MostrarAutos);
                DataTable DT = new DataTable();
                D.Fill(DT);
                return DT;
            }
            catch (SqlException SQL)
            {
                throw new Exception(SQL.Message);

            }
            finally
            {
                //mycon.Dispose();
                //MostrarAutos.Dispose();
            }
        }
        
    }
}


