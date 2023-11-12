using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transportes_Figueroa.controllers;
using Transportes_Figueroa.models;
using Transportes_Figueroa.Models;

namespace Transportes_Figueroa.Services
{
    internal class VehicleManager
    {
        string connectionString = "Data Source=DESKTOP-NFDMETJ; Initial Catalog=TransportesDB; Integrated Security=true";
        vehiclesController VehiclesDataManager = null;

        public VehicleManager()
        {
            VehiclesDataManager = new vehiclesController(connectionString);
        }

        public List<Vehicle> GetAllVehicles()
        {
            return VehiclesDataManager.GetAllCars();
        }

        public List<CarBrand> GetAllVehicleBrands()
        {
            return VehiclesDataManager.GetAllBrands();
        }

        public List<CarModel> GetAllVehicleModels()
        {
            return VehiclesDataManager.GetAllModels();
        }

        public List<VehicleType> GetAllVehicleTypes()
        {
            return VehiclesDataManager.GetAllVehicleTypes();
        }

        public int AddVehicle(
            string matricula, 
            double kilometraje, 
            int anio,
            int capacidadPersonas, 
            double capacidadPeso,
            decimal costo,
            byte[] imagen,
            int tipoVehiculoID,
            int modeloID
        )
        {
            Vehicle vehicle = new Vehicle() {
                Matricula = matricula, 
                Kilometraje = kilometraje,
                Anio = anio,
                CapacidadPersonas = capacidadPersonas,
                CapacidadPeso = capacidadPeso,
                Costo = costo,
                Imagen = imagen,
                TipoVehiculoId = tipoVehiculoID,
                ModeloId = modeloID
            };

            return VehiclesDataManager.AddCar(vehicle);
        }

        public int AddVehicleModel(string modelo, int marcaID)
        {
            CarModel model = new CarModel() { Modelo = modelo, MarcaId = marcaID };

            return VehiclesDataManager.AddCarModel(model);
        }

        public int AddVehicleBrand(string marca)
        {
            CarBrand brand = new CarBrand() { Marca = marca };

            return VehiclesDataManager.AddCarBrand(brand);
        }

        public int DeleteVehicle(int vehiculoID)
        {
            return VehiclesDataManager.DeleteById(vehiculoID);
        }

        public int DeleteVehicleBrand(int marcaID)
        {
            return VehiclesDataManager.DeleteBrandById(marcaID);
        }

        public int DeleteVehicleModel(int modeloID)
        {
            return VehiclesDataManager.DeleteModelById(modeloID);
        }

        public int UpdateVehicle(int vehiculoID, double kilometraje, double capacidadPeso, decimal costo, int tipoVehiculoID, byte[] imagen)
        {
            Vehicle vehiculo = new Vehicle()
            {
                Id = vehiculoID,
                Kilometraje = kilometraje,
                CapacidadPeso = capacidadPeso,
                Costo = costo,
                TipoVehiculoId = tipoVehiculoID,
                Imagen = imagen
            };

            return VehiclesDataManager.UpdeteCar(vehiculo);
        }

        public int ChangeVehicleAvailability(int vehiculoID, string disponibilidad)
        {
            Vehicle vehiculo = new Vehicle()
            {
                Id = vehiculoID,
                Disponibilidad = disponibilidad
            };

            return VehiclesDataManager.ChangeAvailability(vehiculo);
        }

    }
}