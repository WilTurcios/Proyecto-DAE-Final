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
            DataTable vehiclesFromDB = new DataTable();

            try
            {
                OpenConnection();
                string query = $"select * from vehiculos;";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(vehiclesFromDB);

                    foreach (DataRow vehicleFromDB in vehiclesFromDB.Rows)
                    {
                        Vehicle vehicle = new Vehicle();

                        vehicle.Id = (int)vehicleFromDB["id_vehiculo"];
                        vehicle.Matricula = (string)vehicleFromDB["matricula"];
                        vehicle.CapacidadPeso = (double)vehicleFromDB["capacidad_peso"];
                        vehicle.CapacidadPersonas = (int)vehicleFromDB["capacidad_personas"];
                        vehicle.Kilometraje = (double)vehicleFromDB["kilometraje"];
                        vehicle.Costo = (double)vehicleFromDB["costo"];
                        vehicle.Anio = (int)vehicleFromDB["anio"];
                        vehicle.TipoVehiculoId = (int)vehicleFromDB["id_tipo_vehiculo"];
                        vehicle.ModeloId = (int)vehicleFromDB["id_modelo"];

                        vehicles.Add(vehicle);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return vehicles;
        }

        public List<CarBrand> GetAllCarBrands()
        {
            List<CarBrand> vehicleBrands = new List<CarBrand>();
            DataTable vehicleBrandsFromDB = new DataTable();

            try
            {
                OpenConnection();
                string query = $"select * from marcas;";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(vehicleBrandsFromDB);

                    foreach (DataRow brandFromDB in vehicleBrandsFromDB.Rows)
                    {
                        CarBrand vehicleBrand = new CarBrand();

                        vehicleBrand.Id = (int)brandFromDB["id_marca"];
                        vehicleBrand.Marca = (string)brandFromDB["nombre_marca"];

                        vehicleBrands.Add(vehicleBrand);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return vehicleBrands;
        }

        public List<CarModel> GetAllCarModels()
        {
            List<CarModel> vehicleBrands = new List<CarModel>();
            DataTable carModelsFromDB = new DataTable();

            try
            {
                OpenConnection();
                string query = $"select * from modelos;";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(carModelsFromDB);

                    foreach (DataRow carModelFromDB in carModelsFromDB.Rows)
                    {
                        CarModel vehicleModel = new CarModel();

                        vehicleModel.Id = (int)carModelFromDB["id_modelo"];
                        vehicleModel.Modelo = (string)carModelFromDB["nombre_modelo"];
                        vehicleModel.MarcaId = (int)carModelFromDB["id_marca"];

                        vehicleBrands.Add(vehicleModel);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return vehicleBrands;
        }

        public int AddCar(Vehicle vehiculo)
        {
            string query = "INSERT INTO vehiculos (matricula, kilometraje, anio, capacidad_personas, capacidad_peso, costo, id_tipo_vehiculo, id_modelo ) VALUES (@Matricula, @Kilometraje, @Anio, @CapacidadPersonas, @CapacidadPeso, @Costo, @TipoID, @ModeloID); SELECT SCOPE_IDENTITY();";
            using (SqlCommand command = new SqlCommand(query, this.connection))
            {

                command.Parameters.AddWithValue("@Matricula", vehiculo.Matricula);
                command.Parameters.AddWithValue("@Kilometraje", vehiculo.Kilometraje);
                command.Parameters.AddWithValue("@Anio", vehiculo.Anio);
                command.Parameters.AddWithValue("@CapacidadPersonas", vehiculo.CapacidadPersonas);
                command.Parameters.AddWithValue("@CapacidadPeso", vehiculo.CapacidadPeso);
                command.Parameters.AddWithValue("@Costo", vehiculo.Matricula);
                command.Parameters.AddWithValue("@TipoID", vehiculo.TipoVehiculoId);
                command.Parameters.AddWithValue("@ModeloID", vehiculo.ModeloId);

                return (int)command.ExecuteScalar();
            }
        }

        public int AddCarModel(CarModel modelo)
        {
            string query = "INSERT INTO modelos (nombre_modelo, id_marca) VALUES (@Modelo, @MarcaID); SELECT SCOPE_IDENTITY();";
            using (SqlCommand command = new SqlCommand(query, this.connection))
            {

                command.Parameters.AddWithValue("@Modelo", modelo.Modelo);
                command.Parameters.AddWithValue("@MarcaID", modelo.MarcaId);

                return (int)command.ExecuteScalar();
            }
        }

        public int AddCarBrand(CarBrand marca)
        {
            string query = "INSERT INTO marcas (nombre_marca) VALUES (@Marca); SELECT SCOPE_IDENTITY();";
            using (SqlCommand command = new SqlCommand(query, this.connection))
            {

                command.Parameters.AddWithValue("@Marca", marca.Marca);

                return (int)command.ExecuteScalar();
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
                            vehicle.Costo = (double)vehiculoDB["costo"];
                            vehicle.Anio = (int)vehiculoDB["anio"];
                            vehicle.TipoVehiculoId = (int)vehiculoDB["id_tipo_vehiculo"];
                            vehicle.ModeloId = (int)vehiculoDB["id_modelo"];

                            
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

        public void DeleteById(int vehiculoID)
        {
            try
            {
                OpenConnection();

                string query = "delete from vehiculos where id_vehiculo = @VehiculoID;";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@VehiculoID", vehiculoID);

                    cmd.ExecuteNonQuery();
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
        }

        public void DeleteBrandById(int marcaID)
        {
            try
            {
                OpenConnection();

                string query = "delete from marcas where id_marca = @MarcaID;";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@MarcaID", marcaID);

                    cmd.ExecuteNonQuery();
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
        }

        public void DeleteModelById(int modeloID)
        {
            try
            {
                OpenConnection();

                string query = "delete from modelos where id_modelo = @ModeloID;";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ModeloID", modeloID);

                    cmd.ExecuteNonQuery();
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
        }


        public void UpdeteCar(Vehicle vehiculo)
        {
            try
            {
                OpenConnection();

                string query = "update vehiculos set matricula = @Matricula, kilometraje = @Kilometraje, anio = @Anio, capacidad_personas = @CapacidadPersonas, capacidad_peso = @CapacidadPeso, costo = @Costo, id_tipo_vehiculo = @TipoID, id_modelo = @ModeloID where id_vehiculo = @VehiculoID;";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@VehiculoID", vehiculo.Id);
                    cmd.Parameters.AddWithValue("@Matricula", vehiculo.Matricula);
                    cmd.Parameters.AddWithValue("@Kilometraje", vehiculo.Kilometraje);
                    cmd.Parameters.AddWithValue("@Anio", vehiculo.Anio);
                    cmd.Parameters.AddWithValue("@CapacidadPersonas", vehiculo.CapacidadPersonas);
                    cmd.Parameters.AddWithValue("@CapacidadPeso", vehiculo.CapacidadPeso);
                    cmd.Parameters.AddWithValue("@Costo", vehiculo.Matricula);
                    cmd.Parameters.AddWithValue("@TipoID", vehiculo.TipoVehiculoId);
                    cmd.Parameters.AddWithValue("@ModeloID", vehiculo.ModeloId);

                    cmd.ExecuteNonQuery();
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
        }

        
    }
}
