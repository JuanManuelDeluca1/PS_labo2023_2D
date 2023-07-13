using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public static class BaseDatocConect
    {
        static string connectinBaseString;
        static SqlCommand command;
        static SqlConnection connection;

        static BaseDatocConect()
        {
            connectinBaseString = @"Data Source= .;Initial Catalog=CARNICERIA;Integrated Security=True";
            command = new SqlCommand();
            connection = new SqlConnection(connectinBaseString);
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
        }

        public static void GurdarCarne(string corte, float precio, int stock)
        {
            try
            {
                connection.Open();
                command.CommandText = $"INSERT INTO Carne (CORTE, PRECIO_KG, STOCK) VALUES ('{corte}', {precio}, {stock})";
                int rows = command.ExecuteNonQuery();
            }
            catch (MisExepciones)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static void EliminarCarne(string corte)
        {

            try
            {
                connection.Open();
                command.CommandText = $"DELETE FROM Carne WHERE CORTE = {corte}";
                int rows = command.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static List<Carne> LeerCarne()
        {
            List<Carne> carne = new List<Carne>();
            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM Carne";
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        carne.Add(new Carne(reader["CORTE"].ToString(), Convert.ToDouble(reader["PRECIO_KG"]), Convert.ToInt32(reader["STOCK"])));
                    }
                }
                return carne;
            }
            catch
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static Carne LeerUnCorte(string corte)
        {
            Carne carne = null;
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"SELECT * FROM Carne WHERE CORTE = @CORTE";
                command.Parameters.AddWithValue("@CORTE", corte);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        carne = new Carne(reader["Nombre"].ToString(), Convert.ToDouble(reader["PRECIO_KG"]), Convert.ToInt32(reader["STOCK"]));
                    }
                }
                return carne;
            }
            catch
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static void ModificarCarneStock(string corte, int stock)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"UPDATE Carne SET STOCK = '{stock}' WHERE CORTE = @CORTE ";
                command.Parameters.AddWithValue("@CORTE", corte);
                int rows = command.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static void ModificarCarnePrecio(string corte, float precio)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"UPDATE Carne SET PRECIO_KG = '{precio}' WHERE CORTE = @CORTE ";
                command.Parameters.AddWithValue("@CORTE", corte);
                int rows = command.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static void GurdarEmpleado(string mail, string contraseña, int id)
        {
            try
            {
                connection.Open();
                command.CommandText = $"INSERT INTO Empleados (MAIL, CONTRASEÑA, ID) VALUES ('{mail}', '{contraseña}', {id})";
                int rows = command.ExecuteNonQuery();
            }
            catch (MisExepciones)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static void EliminarEmpleado(int id)
        {

            try
            {
                connection.Open();
                command.CommandText = $"DELETE FROM Empleados WHERE ID = {id}";
                int rows = command.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static List<Empleado> LeerEmpleado()
        {
            List<Empleado> empleados = new List<Empleado>();
            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM Empleados";
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        empleados.Add(new Empleado(reader["MAIL"].ToString(), reader["CONTRASEÑA"].ToString(), Convert.ToInt32(reader["ID"])));
                    }
                }
                return empleados;
            }
            catch
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static Empleado LeerUnEmpleado(string id)
        {
            Empleado empleado = null;
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"SELECT * FROM Empleados WHERE ID = @ID";
                command.Parameters.AddWithValue("@ID", id);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        empleado = new Empleado(reader["MAIL"].ToString(), reader["CONTRASEÑA"].ToString(), Convert.ToInt32(reader["ID"]));
                    }
                }
                return empleado;
            }
            catch
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static void GurdarCliente(string mail, string contraseña, string metodoPago, float monto)
        {
            try
            {
                connection.Open();
                command.CommandText = $"INSERT INTO Cliente (MAIL, CONTRASEÑA, METODO_DE_PAGO, MONTO) VALUES ('{mail}', '{contraseña}', '{metodoPago}', {monto})";
                int rows = command.ExecuteNonQuery();

            }
            catch (MisExepciones)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static void EliminarCliente(string mail)
        {

            try
            {
                connection.Open();
                command.CommandText = $"DELETE FROM Cliente WHERE MAIL = '{mail}'";
                int rows = command.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static List<Cliente> LeerClientes()
        {
            List<Cliente> clientes = new List<Cliente>();
            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM Cliente";
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        clientes.Add(new Cliente(reader["MAIL"].ToString(), reader["CONTRASEÑA"].ToString(), reader["METODO_DE_PAGO"].ToString(), Convert.ToDouble(reader["MONTO"])));
                    }
                }
                return clientes;
            }
            catch
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static Cliente LeerUnCliente(string mail)
        {
            Cliente cliente = null;
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"SELECT * FROM Cliente WHERE MAIL = @MAIL";
                command.Parameters.AddWithValue("@MAIL", mail);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cliente = new Cliente(reader["MAIL"].ToString(), reader["CONTRASEÑA"].ToString(), reader["MONTO_DE_PAGO"].ToString(), Convert.ToDouble(reader["MONTO"]));
                    }
                }
                return cliente;
            }
            catch
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static void ModificarClienteMonto(string mail, float monto, string metodoPago)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"UPDATE Cliente SET MONTO = '{monto}' WHERE MAIL = @MAIL ";
                command.Parameters.AddWithValue("@MAIL", mail);
                int rows = command.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static void ModificarClienteMetodoPago(string mail, string metodoPago)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"UPDATE Cliente SET METODO_DE_PAGO = '{metodoPago}' WHERE MAIL = @MAIL ";
                command.Parameters.AddWithValue("@MAIL", mail);
                int rows = command.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static List<Publicidad> ObtenerPublicidad()
        {
            List<Publicidad> listP = new List<Publicidad>();
            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM Publicidad";
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string code = (reader["CODE"].ToString()); 
                        string path = (reader["PATH"].ToString());
                        Publicidad p = new Publicidad();
                        p.code = code;
                        p.path = path;
                        listP.Add(p);
                    }
                }
                return listP;
            }
            catch
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
