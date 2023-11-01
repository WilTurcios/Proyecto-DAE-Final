using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Transportes_Figueroa.models;
using System.Collections;
using System.Runtime.Remoting;
using System.Windows.Forms;

namespace Transportes_Figueroa.controllers
{
    internal class clientsController
    {
        private SqlConnection connection = new SqlConnection();
        public clientsController(string connectionString) 
        {
            connection.ConnectionString = connectionString;
        }

        private void OpenConnection()
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
        }

        private void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public List<Client> GetAll()
        {
            List<Client> clients = new List<Client> ();
            DataTable clientsFromDB = new DataTable();

            try
            {
                OpenConnection();
                string query = "SELECT * FROM clientes C INNER JOIN direcciones D ON C.id_direccion = D.id_direccion;";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(clientsFromDB);

                    foreach (DataRow clientFromDB in clientsFromDB.Rows)
                    {
                        Client client = new Client();
                        client.Id = (Guid)clientFromDB["id_cliente"]; // A esta técnica de parseo se le llama CASTING
                        client.Nombres = (string)clientFromDB["nombres"];
                        client.ApellidoPaterno = (string)clientFromDB["apellido_paterno"];
                        client.ApellidoMaterno = (string)clientFromDB["apellido_materno"];
                        client.NumeroTelefonico = (string)clientFromDB["telefono_cliente"];
                        client.Email = (string)clientFromDB["correo_cliente"];
                        client.DireccionId = (int)clientFromDB["id_direccion"];
                        client.Calle = (string)clientFromDB["calle"];
                        client.Departamento = (string)clientFromDB["departamento"];
                        client.Municipio = (string)clientFromDB["municipio"];
                        client.Ubicacion = (string)clientFromDB["ubicacion"];
                        client.CodigoCasa = (string)clientFromDB["cod_casa"];

                        clients.Add(client);
                    }
                }
            }
            catch (Exception ex)
            {
                // Se supone que debe ir a un servicio externo de la empresa o de algun servicio
                MessageBox.Show("Error al obtener clientes: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return clients;
        }

        public int Add(Client client)
        {
            int affectedRows = 0;
            try
            {
                OpenConnection();
                using(SqlCommand command = new SqlCommand("InsertarCliente", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@ClienteID", client.Id);
                    command.Parameters.AddWithValue("@NombreCliente", client.Nombres);
                    command.Parameters.AddWithValue("@ApellidoMaterno", client.ApellidoMaterno);
                    command.Parameters.AddWithValue("@ApellidoPaterno", client.ApellidoPaterno);
                    command.Parameters.AddWithValue("@TelefonoCliente", client.NumeroTelefonico);
                    command.Parameters.AddWithValue("@CorreoCliente", client.Email);
                    command.Parameters.AddWithValue("@CalleDireccion", client.Calle);
                    command.Parameters.AddWithValue("@DepartamentoDireccion", client.Departamento);
                    command.Parameters.AddWithValue("@MunicipioDireccion", client.Municipio);
                    command.Parameters.AddWithValue("@UbicacionDireccion", client.Ubicacion);
                    command.Parameters.AddWithValue("@CodigoCasa", client.CodigoCasa);

                    affectedRows = command.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar cliente: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return affectedRows;
        }

        public Client GetById(Guid clientID)
        {
            Client client = new Client();
            DataTable clientFromDB = new DataTable();

            try
            {
                OpenConnection();

                string query = $"SELECT * FROM clientes INNER JOIN direcciones ON clientes.id_direccion = direcciones.id_direccion WHERE clientes.id_cliente = @ClientID;";
                using (SqlCommand command = new SqlCommand(query, connection)) {

                    command.Parameters.AddWithValue("@ClientID", clientID);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(clientFromDB);

                        foreach(DataRow infoCliente in clientFromDB.Rows)
                        {
                            client.Id = (Guid)infoCliente["id_cliente"];
                            client.Nombres = (string)infoCliente["nombres"];
                            client.ApellidoPaterno = (string)infoCliente["apellido_paterno"];
                            client.ApellidoMaterno = (string)infoCliente["apellido_materno"];
                            client.NumeroTelefonico = (string)infoCliente["telefono_cliente"];
                            client.Email = (string)infoCliente["correo_cliente"];
                            client.Departamento = (string)infoCliente["departamento"];
                            client.Municipio = (string)infoCliente["municipio"];
                            client.Calle = (string)infoCliente["calle"];
                            client.Ubicacion = (string)infoCliente["ubicacion"];
                            client.CodigoCasa = (string)infoCliente["cod_casa"];

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener empleado: {ex.Message}");
            }
            finally
            {
                CloseConnection();
            }

            return client;
        }

        public Client GetByName(string name)
        {
            Client client = new Client();
            DataTable clientFromDB = new DataTable();

            try
            {
                OpenConnection();

                string query = "SELECT * FROM clientes INNER JOIN direcciones ON clientes.id_direccion = direcciones.id_direccion WHERE clientes.names LIKE @Name OR clientes.apellido_paterno LIKE @Name OR clientes.apellido_materno LIKE @Name;";
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@Name","'%" + name + "%'");

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(clientFromDB);

                        foreach (DataRow infoCliente in clientFromDB.Rows)
                        {
                            client.Id = (Guid)infoCliente["id_cliente"];
                            client.Nombres = (string)infoCliente["nombres"];
                            client.ApellidoPaterno = (string)infoCliente["apellido_paterno"];
                            client.ApellidoMaterno = (string)infoCliente["apellido_materno"];
                            client.NumeroTelefonico = (string)infoCliente["telefono_cliente"];
                            client.Email = (string)infoCliente["correo_cliente"];
                            client.Departamento = (string)infoCliente["departamento"];
                            client.Municipio = (string)infoCliente["municipio"];
                            client.Calle = (string)infoCliente["calle"];
                            client.Ubicacion = (string)infoCliente["ubicacion"];
                            client.CodigoCasa = (string)infoCliente["cod_casa"];

                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error al obtener empleado: {ex.Message}");
            }
            finally
            {
                CloseConnection();
            }

            return client;
        }

        public int Delete(Guid clientID)
        {
            int affectedRows = 0;
            try
            {
                OpenConnection();
                string query = "DELETE FROM clientes WHERE id_cliente = @ClientID;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ClientID", clientID);
                    affectedRows = command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Excepción al eliminar empleado: {ex.Message}");
            }
            finally
            {
                CloseConnection();
            }
            return affectedRows;
        }

        public int Updete(Client client)
        {
            int affectedRows = 0;
            try
            {
                OpenConnection();
                using (SqlCommand command = new SqlCommand("ActualizarCliente", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@ClienteID", client.Id);
                    command.Parameters.AddWithValue("@TelefonoCliente", client.NumeroTelefonico);
                    command.Parameters.AddWithValue("@DireccionID", client.DireccionId);
                    command.Parameters.AddWithValue("@CorreoCliente", client.Email);
                    command.Parameters.AddWithValue("@CalleDireccion", client.Calle);
                    command.Parameters.AddWithValue("@DepartamentoDireccion", client.Departamento);
                    command.Parameters.AddWithValue("@MunicipioDireccion", client.Municipio);
                    command.Parameters.AddWithValue("@UbicacionDireccion", client.Ubicacion);
                    command.Parameters.AddWithValue("@CodigoCasa", client.CodigoCasa);

                    affectedRows = command.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido una excepción al actualizar empleado: {ex.Message}");
            }
            finally
            {
                CloseConnection();
            }

            return affectedRows;
        }
    }
}
