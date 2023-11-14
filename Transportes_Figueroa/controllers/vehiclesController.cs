using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transportes_Figueroa.models;
using Transportes_Figueroa.Models;

namespace Transportes_Figueroa.controllers
{
    internal class vehiclesController
    {
        SqlConnection connection = new SqlConnection();

        public vehiclesController(string connectionString)
        {
            this.connection.ConnectionString = connectionString;
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

        public List<Vehicle> GetAllCars()
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            try
            {
                OpenConnection();
                string query = "SELECT * FROM vehiculos";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Vehicle vehicle = new Vehicle();

                        vehicle.Id = (int)reader["id_vehiculo"];
                        vehicle.Matricula = reader["matricula"].ToString();
                        vehicle.CapacidadPeso = (double)reader["capacidad_peso"];
                        vehicle.CapacidadPersonas = (int)reader["capacidad_personas"];
                        vehicle.Kilometraje = (double)reader["kilometraje"];
                        vehicle.Costo = (decimal)reader["costo"];
                        vehicle.Anio = (int)reader["anio"];
                        vehicle.TipoVehiculoId = (int)reader["id_tipo_vehiculo"];
                        vehicle.ModeloId = (int)reader["id_modelo"];
                        vehicle.Disponibilidad = (string)reader["disponibilidad"];

                        if (reader["imagen"] != DBNull.Value)
                        {
                            vehicle.Imagen = (byte[])reader["imagen"];
                        }
                        else
                        {
                            vehicle.Imagen = null; // Si la imagen es NULL en la base de datos
                        }

                        vehicles.Add(vehicle);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error al obtener vehículos: {ex.Message}");
            }
            finally
            {
                CloseConnection();
            }

            return vehicles;
        }

        public List<CarModel> GetAllModels()
        {
            try
            {
                List<CarModel> modelos = new List<CarModel>();
                DataTable carModelsFromDB = new DataTable();
                OpenConnection();
                string query = $"select * from modelos;";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(carModelsFromDB);

                    foreach (DataRow carModelFromDB in carModelsFromDB.Rows)
                    {
                        CarModel modelo = new CarModel();

                        modelo.Id = (int)carModelFromDB["id_Modelo"];
                        modelo.Modelo = (string)carModelFromDB["nombre_modelo"];
                        modelo.MarcaId = (int)carModelFromDB["id_marca"];

                        modelos.Add(modelo);
                    }
                }

                return modelos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al recuperar los modelos: " + ex.Message);
                return new List<CarModel>();
            }
            finally
            {
                CloseConnection();
            }
        }

        public List<CarBrand> GetAllBrands()
        {
            try
            {
                List<CarBrand> brands = new List<CarBrand>();
                DataTable carModelsFromDB = new DataTable();
                OpenConnection();
                string query = $"select * from marcas;";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(carModelsFromDB);

                    foreach (DataRow carModelFromDB in carModelsFromDB.Rows)
                    {
                        CarBrand brand = new CarBrand();

                        brand.Id = (int)carModelFromDB["id_marca"];
                        brand.Marca = (string)carModelFromDB["nombre_marca"];

                        brands.Add(brand);
                    }
                }

                return brands;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al recuperar las marcas: " + ex.Message);
                return new List<CarBrand>();
            }
            finally
            {
                CloseConnection();
            }
        }


        public List<VehicleType> GetAllVehicleTypes()
        {
            try
            {
                List<VehicleType> vehicleTypes = new List<VehicleType>();
                DataTable vehicleTypesFromDB = new DataTable();
                OpenConnection();
                string query = $"select * from tipo_vehiculo;";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(vehicleTypesFromDB);

                    foreach (DataRow vehicleTypeFromDB in vehicleTypesFromDB.Rows)
                    {
                        VehicleType vehicleType = new VehicleType();

                        vehicleType.Id = (int)vehicleTypeFromDB["id_tipo_vehiculo"];
                        vehicleType.Nombre = (string)vehicleTypeFromDB["nombre_tipo"];

                        vehicleTypes.Add(vehicleType);
                    }
                }

                return vehicleTypes;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al recuperar los tipos de vehiculo: " + ex.Message);
                return new List<VehicleType>();
            }
            finally
            {
                CloseConnection();
            }
        }
        public int AddCar(Vehicle vehiculo)
        {
            string query = "INSERT INTO vehiculos (matricula, kilometraje, anio, capacidad_personas, capacidad_peso, costo, id_tipo_vehiculo, id_modelo, imagen) " +
                           "VALUES (@Matricula, @Kilometraje, @Anio, @CapacidadPersonas, @CapacidadPeso, @Costo, @TipoID, @ModeloID, @Imagen);";

            try
            {
                using (SqlCommand command = new SqlCommand(query, this.connection))
                {
                    OpenConnection();

                    command.Parameters.AddWithValue("@Matricula", vehiculo.Matricula);
                    command.Parameters.AddWithValue("@Kilometraje", vehiculo.Kilometraje);
                    command.Parameters.AddWithValue("@Anio", vehiculo.Anio);
                    command.Parameters.AddWithValue("@CapacidadPersonas", vehiculo.CapacidadPersonas);
                    command.Parameters.AddWithValue("@CapacidadPeso", vehiculo.CapacidadPeso);
                    command.Parameters.AddWithValue("@Costo", vehiculo.Costo);
                    command.Parameters.AddWithValue("@TipoID", vehiculo.TipoVehiculoId);

                    // Para el campo de imagen (VARBINARY), asegúrate de usar el tipo SqlDbType.VarBinary
                    command.Parameters.Add("@Imagen", SqlDbType.VarBinary).Value = vehiculo.Imagen;

                    command.Parameters.AddWithValue("@ModeloID", vehiculo.ModeloId);

                    return command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar vehículo: " + ex.Message);
                return 0;
            }
            finally
            {
                CloseConnection();
            }
        }

        public int AddCarModel(CarModel modelo)
        {
            string query = "INSERT INTO modelos (nombre_modelo, id_marca) VALUES (@Modelo, @MarcaID);";
            try
            {
                OpenConnection();
                using (SqlCommand command = new SqlCommand(query, this.connection))
                {

                    command.Parameters.AddWithValue("@Modelo", modelo.Modelo);
                    command.Parameters.AddWithValue("@MarcaID", modelo.MarcaId);

                    return command.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al insertar modelo: " + ex.Message);
                return 0;
            }
            finally
            {
                CloseConnection();
            }
        }

        public int AddCarBrand(CarBrand marca)
        {
            string query = "INSERT INTO marcas (nombre_marca) VALUES (@Marca);";
            
            try
            {
                OpenConnection();
                using (SqlCommand command = new SqlCommand(query, this.connection))
                {

                    command.Parameters.AddWithValue("@Marca", marca.Marca);

                    return command.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al insertar marca: " + ex.Message);
                return 0;
            }
            finally
            {
                CloseConnection();
            }
        }

        public Vehicle GetCarById(int vehiculoID)
        {
            Vehicle vehiculo = new Vehicle();
            DataTable vehicleFromDB = new DataTable();
            try
            {
                OpenConnection();

                string query = "select * from vehiculos where id_vehiculo = @VehiculoID;";

                using(SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@VehiculoID", vehiculoID);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(vehicleFromDB);

                        foreach (DataRow vehiculoDB in vehicleFromDB.Rows)
                        {
                            Vehicle vehicle = new Vehicle();

                            vehicle.Id = (int)vehiculoDB["id_vehiculo"];
                            vehicle.Matricula = (string)vehiculoDB["matricula"];
                            vehicle.CapacidadPeso = (double)vehiculoDB["capacidad_peso"];
                            vehicle.CapacidadPersonas = (int)vehiculoDB["capacidad_personas"];
                            vehicle.Kilometraje = (double)vehiculoDB["kilometraje"];
                            vehicle.Costo = (decimal)vehiculoDB["costo"];
                            vehicle.Anio = (int)vehiculoDB["anio"];
                            vehicle.TipoVehiculoId = (int)vehiculoDB["id_tipo_vehiculo"];
                            vehicle.ModeloId = (int)vehiculoDB["id_modelo"];
                            vehicle.Disponibilidad = (string)vehiculoDB["disponibilidad"];


                        }
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return vehiculo;
        }

        public CarModel GetCarModelById(int modeloID)
        {
            CarModel model = new CarModel();
            DataTable modelFromDB = new DataTable();
            try
            {
                OpenConnection();

                string query = "select * from vehiculos where id_vehiculo = @ModeloID;";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ModeloID", modeloID);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(modelFromDB);

                        foreach (DataRow vehiculoDB in modelFromDB.Rows)
                        {

                            model.Id = (int)vehiculoDB["id_vehiculo"];
                            model.Modelo = (string)vehiculoDB["nombre_modelo"];
                            model.MarcaId = (int)vehiculoDB["id_marca"];

                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return model;
        }

        public int DeleteById(int vehiculoID)
        {
            try
            {
                int affectedRows;
                OpenConnection();

                string query = "delete from vehiculos where id_vehiculo = @VehiculoID;";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@VehiculoID", vehiculoID);

                    return affectedRows = cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al eliminar vehiculo:\n" +
                    "El vehiculo tiene servicios relacionados a él por lo que es imposible realizar la acción.",
                    "Error al eliminar el vehiculo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return 0;
            }
            finally
            {
                CloseConnection();
            }
        }

        public int DeleteBrandById(int marcaID)
        {
            try
            {
                int affectedRows;
                OpenConnection();

                string query = "delete from marcas where id_marca = @MarcaID;";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@MarcaID", marcaID);

                    return  affectedRows = cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
            finally
            {
                CloseConnection();
            }
        }

        public int DeleteModelById(int modeloID)
        {
            try
            {
                int affectedRows;
                OpenConnection();

                string query = "delete from modelos where id_modelo = @ModeloID;";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ModeloID", modeloID);

                    return affectedRows = cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
            finally
            {
                CloseConnection();
            }
        }


        public int UpdeteCar(Vehicle vehiculo)
        {
            try
            {
                OpenConnection();

                string query = "update vehiculos set imagen = @Imagen, kilometraje = @Kilometraje, capacidad_peso = @CapacidadPeso, costo = @Costo, id_tipo_vehiculo = @TipoID where id_vehiculo = @VehiculoID;";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@VehiculoID", vehiculo.Id);
                    cmd.Parameters.AddWithValue("@Kilometraje", vehiculo.Kilometraje);
                    cmd.Parameters.AddWithValue("@CapacidadPeso", vehiculo.CapacidadPeso);
                    cmd.Parameters.AddWithValue("@Costo", vehiculo.Costo);
                    cmd.Parameters.AddWithValue("@TipoID", vehiculo.TipoVehiculoId);
                    cmd.Parameters.AddWithValue("@Imagen", vehiculo.Imagen);

                    return cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
            finally
            {
                CloseConnection();
            }
        }

        public int ChangeAvailability(Vehicle vehiculo)
        {
            try
            {
                OpenConnection();

                string query = "update vehiculos set disponibilidad = @Disponibilidad where id_vehiculo = @VehiculoID;";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@VehiculoID", vehiculo.Id);
                    cmd.Parameters.AddWithValue("@Disponibilidad", vehiculo.Disponibilidad);

                    return cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
