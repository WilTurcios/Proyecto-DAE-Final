using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transportes_Figueroa.models;
using Transportes_Figueroa.Models;

namespace Transportes_Figueroa.Controllers
{
    internal class servicesController
    {
        private SqlConnection connection = new SqlConnection();
        public servicesController(string connectionString)
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

        public List<Service> GetAll()
        {
            List<Service> services = new List<Service>();
            DataTable servicesFromDB = new DataTable();

            try
            {
                OpenConnection();
                string query = $"SELECT * FROM servicios;";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(servicesFromDB);

                    foreach (DataRow serviceFromDB in servicesFromDB.Rows)
                    {
                        Service service = new Service();
                        service.Id = (int)serviceFromDB["id_servicio"]; // A esta técnica de parseo se le llama CASTING
                        service.FechaSolicitud = (DateTime)serviceFromDB["fecha_solicitud"];
                        service.FechaDevolucion = (DateTime)serviceFromDB["fecha_devolucion"];
                        service.ClienteId = (Guid)serviceFromDB["id_cliente"];
                        service.EmpleadoId = (Guid)serviceFromDB["id_empleado"];
                        service.VehiculoId = (int)serviceFromDB["id_vehiculo"];
                        service.ValorMedido = (double)serviceFromDB["valor_medido"];
                        service.TipoServicioId = (int)serviceFromDB["id_tipo_servicio"];

                        services.Add(service);
                    }
                }
            }
            catch (Exception ex)
            {
                // Se supone que debe ir a un servicio externo de la empresa o de algun servicio
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return services;
        }

        public int Add(Client client)
        {
            int affectedRows = 0;
            try
            {
                OpenConnection();
                using (SqlCommand command = new SqlCommand("InsertarClienteConDireccion", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@ClienteID", client.Id);
                    command.Parameters.AddWithValue("@NombresCliente", client.Nombres);
                    command.Parameters.AddWithValue("@ApelldioMaterno", client.ApellidoMaterno);
                    command.Parameters.AddWithValue("@ApelldioPaterno", client.ApellidoPaterno);
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

            }
            finally
            {
                CloseConnection();
            }

            return affectedRows;
        }

        public Service GetById(int servicioID)
        {
            Service service = new Service();
            DataTable servicesFromDB = new DataTable();

            try
            {
                OpenConnection();

                string query = $"SELECT * FROM servicios WHERE id_servicio = @SevicioID;";
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@SevicioID", servicioID);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(servicesFromDB);

                        foreach (DataRow serviceFromDB in servicesFromDB.Rows)
                        {
                            service.Id = (int)serviceFromDB["id_servicio"]; // A esta técnica de parseo se le llama CASTING
                            service.FechaSolicitud = (DateTime)serviceFromDB["fecha_solicitud"];
                            service.FechaDevolucion = (DateTime)serviceFromDB["fecha_devolucion"];
                            service.ClienteId = (Guid)serviceFromDB["id_cliente"];
                            service.EmpleadoId = (Guid)serviceFromDB["id_empleado"];
                            service.VehiculoId = (int)serviceFromDB["id_vehiculo"];
                            service.ValorMedido = (double)serviceFromDB["valor_medido"];
                            service.TipoServicioId = (int)serviceFromDB["id_tipo_servicio"];
                        }
                    }
                }
            }
            catch
            {
                CloseConnection();
            }

            return service;
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
                Console.WriteLine($"Excepción: {ex.Message}");
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
                using (SqlCommand command = new SqlCommand("ActualizarClienteConDireccion", connection))
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
                Console.WriteLine($"Ha ocurrido una excepción: {ex.Message}");
            }
            finally
            {
                CloseConnection();
            }

            return affectedRows;
        }
    }
}
