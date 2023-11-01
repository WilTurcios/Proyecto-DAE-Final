using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transportes_Figueroa.models;
using Transportes_Figueroa.Models;
using Transportes_Figueroa.Services;
using Transportes_Figueroa.Utils;

namespace Transportes_Figueroa.views
{
    public partial class CrearVehiculo : Form
    {
        VehicleManager VehicleDBManager = new VehicleManager();
        private byte[] _imagen;
        private List<Vehicle> _vehicles;
        private List<CarBrand> _brands;
        private List<CarModel> _models;
        private List<VehicleType> _vehicleTypes;
        private DataTable _VehiclesToShow = new DataTable();
        private DataTable _VehicleBrandsToShow = new DataTable();
        private DataTable _VehicleModelsToShow = new DataTable();

        public CrearVehiculo()
        {
            
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ShowVehicles()
        {
            _VehiclesToShow.Columns.Add("ID");
            _VehiclesToShow.Columns.Add("Matricula");
            _VehiclesToShow.Columns.Add("Marca");
            _VehiclesToShow.Columns.Add("Modelo");
            _VehiclesToShow.Columns.Add("Tipo de vehiculo");
            _VehiclesToShow.Columns.Add("Año");
            _VehiclesToShow.Columns.Add("Capacidad de personas");
            _VehiclesToShow.Columns.Add("Limite de peso");
            _VehiclesToShow.Columns.Add("Costo");

            foreach(Vehicle vehicle in _vehicles)
            {
                DataRow fila = _VehiclesToShow.NewRow();

                fila["ID"] = vehicle.Id;
                fila["Matricula"] = vehicle.Matricula;
                fila["Marca"] = (from model in _models join brand in _brands on model.MarcaId equals brand.Id where model.Id == vehicle.ModeloId select new { BrandName = brand.Marca }).FirstOrDefault().BrandName;
                fila["Modelo"] = _models.FirstOrDefault(model => model.Id == vehicle.ModeloId).Modelo;
                fila["Tipo de vehiculo"] = _vehicleTypes.FirstOrDefault(type => type.Id == vehicle.TipoVehiculoId).Nombre;
                fila["Año"] = vehicle.Anio;
                fila["Capacidad de personas"] = vehicle.CapacidadPersonas;
                fila["Limite de peso"] = vehicle.CapacidadPeso;
                fila["Costo"] = vehicle.Costo;

                _VehiclesToShow.Rows.Add(fila);

            }

            DataGridVehiculos.DataSource = _VehiclesToShow;
            DataGridVehiculos.Refresh();
        }

        private void ShowVehicleBrands()
        {
            _VehicleBrandsToShow.Columns.Add("ID");
            _VehicleBrandsToShow.Columns.Add("Marca");

            foreach(CarBrand brand in _brands)
            {
                DataRow fila = _VehicleBrandsToShow.NewRow();

                fila["ID"] = brand.Id;
                fila["Marca"] = brand.Marca;

                _VehicleBrandsToShow.Rows.Add(fila);
            }

            DataGridMarcas.DataSource = _VehicleBrandsToShow;
            DataGridMarcas.Refresh();
        }

        private void ShowVehicleModels()
        {
            _VehicleModelsToShow.Columns.Add("ID");
            _VehicleModelsToShow.Columns.Add("Marca");
            _VehicleModelsToShow.Columns.Add("Modelo");

            foreach (CarModel model in _models)
            {
                DataRow fila = _VehicleModelsToShow.NewRow();

                fila["ID"] = model.Id;
                fila["Marca"] = _brands.FirstOrDefault(brand => brand.Id == model.MarcaId).Marca;
                fila["Modelo"] = model.Modelo;

                _VehicleModelsToShow.Rows.Add(fila);
            }

            DataGridModelos1.DataSource = _VehicleModelsToShow;
            DataGridModelos.Refresh();
        }


        private void CrearVehiculo_Load(object sender, EventArgs e)
        {
            _brands = VehicleDBManager.GetAllVehicleBrands();
            _models = VehicleDBManager.GetAllVehicleModels();
            _vehicles = VehicleDBManager.GetAllVehicles();
            _vehicleTypes = VehicleDBManager.GetAllVehicleTypes();

            ShowVehicles();
            ShowVehicleBrands();
            ShowVehicleModels();

            foreach (CarBrand brand in _brands){
                ListaMarcas_modelos.Items.Add(brand.Marca);
                ListaMarcas_vehiculos.Items.Add(brand.Marca);
            }

            foreach(VehicleType vehicleType in _vehicleTypes)
            {
                ListaTipoVehiculos.Items.Add(vehicleType.Nombre);
            }


        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            var ImageData = ImageHandler.GetImageData();

            _imagen = ImageData.datosBinarios;

            pictureBox1.Image = Image.FromFile(ImageData.rutaImagen);
        }

        private void AgregarVehiculo_Click(object sender, EventArgs e)
        {

        }

        private void ListaMarcas_vehiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string currentBrand = ListaMarcas_vehiculos.SelectedItem.ToString();
            int currentBrandID = _brands.FirstOrDefault(brand => brand.Marca == currentBrand)?.Id ?? 0;

            ListaModelos.Items.Clear();

            if (currentBrandID != 0)
            {
                var modelosDeMarca = _models.Where(model => model.MarcaId == currentBrandID).Select(model => model.Modelo);
                ListaModelos.Items.AddRange(modelosDeMarca.ToArray());
            }
        }
    }
}
