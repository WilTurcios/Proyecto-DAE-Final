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
                using (SqlDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        Service service = new Service();
                        service.Id = (int)reader["id_servicio"];
                        service.FechaSolicitud = (DateTime)reader["fecha_solicitud"];
                        service.FechaDevolucion = (DateTime)reader["fecha_devolucion"];
                        service.ClienteId = (Guid)reader["id_cliente"];

                        if (reader["id_conductor"] != DBNull.Value)
                        {
                            service.ConductorID = (int)reader["id_conductor"];
                        }
                        service.VehiculoId = (int)reader["id_vehiculo"];
                        service.ValorMedido = (double)reader["valor_medido"];
                        service.TipoServicioId = (int)reader["id_tipo_servicio"];
                        service.Estado = (string)reader["estado"];

                        services.Add(service);
                    }
                }
            }
            catch (Exception ex)
            {
                // Se supone que debe ir a un servicio externo de la empresa o de algun servicio
                MessageBox.Show("Ocurrió un error al recuperar los servicios: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return services;
        }


        public List<ServiceType> GetAllServiceTypes()
        {
            List<ServiceType> serviceTypes = new List<ServiceType>();

            try
            {
                OpenConnection();
                string query = "SELECT * FROM tipo_servicios;";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ServiceType serviceType = new ServiceType();

                        serviceType.Id = (int)reader["id_tipo_servicio"]; // A esta técnica de parseo se le llama CASTING
                        serviceType.NombreServicio = (string)reader["tipo_servicio"];

                        serviceTypes.Add(serviceType);

                    }
                }
            }
            catch (Exception ex)
            {
                // Se supone que debe ir a un servicio externo de la empresa o de algun servicio
                MessageBox.Show("Ocurrió un error al recuperar los tipos de servicios: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return serviceTypes;
        }

        public List<Service> GetAllServicesByClientId(Guid clientID)
        {
            List<Service> services = new List<Service>();

            try
            {
                OpenConnection();
                string query = $"SELECT * FROM servicios WHERE id_cliente = @ClienteID;";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ClienteID", clientID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            Service service = new Service();
                            service.Id = (int)reader["id_servicio"];
                            service.FechaSolicitud = (DateTime)reader["fecha_solicitud"];
                            service.FechaDevolucion = (DateTime)reader["fecha_devolucion"];
                            service.ClienteId = (Guid)reader["id_cliente"];

                            if (reader["id_conductor"] != DBNull.Value)
                            {
                                service.ConductorID = (int)reader["id_conductor"];
                            }
                            service.VehiculoId = (int)reader["id_vehiculo"];
                            service.ValorMedido = (double)reader["valor_medido"];
                            service.TipoServicioId = (int)reader["id_tipo_servicio"];
                            service.Estado = (string)reader["estado"];

                            services.Add(service);
                        }
                    }
                
                }
            }
            catch (Exception ex)
            {
                // Se supone que debe ir a un servicio externo de la empresa o de algun servicio
                MessageBox.Show("Ocurrió un error al recuperar los servicios: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return services;
        }

        public int Add(Service service)
        {
            int affectedRows = 0;
            try
            {
                OpenConnection();
                string parametters = "(fecha_solicitud, fecha_devolucion, id_cliente, id_conductor, id_vehiculo, valor_medido, id_tipo_servicio)";
                string values = "(@FechaSolicitud, @FechaDevolucion, @ClienteID, @ConductorID, @VehiculoID, @ValorMedido, @TipoServicioID)";
                string query = $"insert into servicios {parametters} VALUES  {values}"; 
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@FechaSolicitud", service.FechaSolicitud);
                    command.Parameters.AddWithValue("@FechaDevolucion", service.FechaDevolucion);
                    command.Parameters.AddWithValue("@ClienteID", service.ClienteId);
                    command.Parameters.AddWithValue("@VehiculoID", service.VehiculoId);
                    command.Parameters.AddWithValue("@ConductorID",(Object)service.ConductorID ?? DBNull.Value);
                    command.Parameters.AddWithValue("@ValorMedido", service.ValorMedido);
                    command.Parameters.AddWithValue("@TipoServicioID", service.TipoServicioId);

                    affectedRows = command.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al insertar el servicio: " + ex.Message);
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

            try
            {
                OpenConnection();

                string query = $"SELECT * FROM servicios WHERE id_servicio = @SevicioID;";
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@SevicioID", servicioID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            service.Id = (int)reader["id_servicio"]; // A esta técnica de parseo se le llama CASTING
                            service.FechaSolicitud = (DateTime)reader["fecha_solicitud"];
                            service.FechaDevolucion = (DateTime)reader["fecha_devolucion"];
                            service.ClienteId = (Guid)reader["id_cliente"];
                            if (reader["id_conductor"] != DBNull.Value)
                            {
                                service.ConductorID = (int)reader["id_empleado"];
                            }
                            service.VehiculoId = (int)reader["id_vehiculo"];
                            service.ValorMedido = (double)reader["valor_medido"];
                            service.TipoServicioId = (int)reader["id_tipo_servicio"];
                            service.Estado = (string)reader["estado"];
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocurrió un error al recuperar el servicio: " + ex.Message);
            }
            finally
            {
                CloseConnection();

            }

            return service;
        }

        public int Delete(int serviceID)
        {
            int affectedRows = 0;
            try
            {
                OpenConnection();
                string query = "DELETE FROM servicios WHERE id_servicio = @ServiceID;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ServiceID", serviceID);
                    affectedRows = command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al elimiar el servicio: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return affectedRows;
        }

        public int Updete(Service service)
        {
            int affectedRows = 0;
            try
            {
                OpenConnection();
                string query = "update services set " +
                               "fecha_solicitud = @FechaSolicitud, fecha_devolucion = @FechaDevolucion, " +
                               "id_vehiculo = @VehiculoID, valor_medido = @ValorMedido " +
                               "where id_servicio = @ServicioID;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@ServicioID", service.Id);
                    command.Parameters.AddWithValue("@FechaSolicitud", service.FechaSolicitud);
                    command.Parameters.AddWithValue("@FechaDevolucion", service.FechaDevolucion);
                    command.Parameters.AddWithValue("@VehiculoID", service.VehiculoId);
                    command.Parameters.AddWithValue("@ValorMedido", service.ValorMedido);

                    affectedRows = command.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al actualizar el servicio: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return affectedRows;
        }

        public int ChangeState(string newState, int serviceID)
        {
            int affectedRows = 0;
            try
            {
                OpenConnection();
                string query = "update servicios set estado = @Estado " +
                               "where id_servicio = @ServicioID;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Estado", newState);
                    command.Parameters.AddWithValue("@ServicioID", serviceID);

                    affectedRows = command.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al actualizar el estado del servicio: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return affectedRows;
        }
    }
}
