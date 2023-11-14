using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transportes_Figueroa.models;
using Transportes_Figueroa.Models;
using Transportes_Figueroa.Services;

namespace Transportes_Figueroa.views
{
    public partial class AdministrarEstadoVehiculos : Form
    {
        private VehicleManager VehicleDBManager = new VehicleManager();
        private byte[] _imagen = null;
        private List<Vehicle> _vehicles;
        private List<CarBrand> _brands;
        private List<CarModel> _models;
        private List<VehicleType> _vehicleTypes;
        private DataTable _VehiclesToShow = new DataTable();
        public AdministrarEstadoVehiculos()
        {
            InitializeComponent();
        }

        private void AdministrarEstadoVehiculos_Load(object sender, EventArgs e)
        {
            _brands = VehicleDBManager.GetAllVehicleBrands();
            _models = VehicleDBManager.GetAllVehicleModels();
            _vehicles = VehicleDBManager.GetAllVehicles();
            _vehicleTypes = VehicleDBManager.GetAllVehicleTypes();

            ShowVehicles(_vehicles);
        }

        private void ShowVehicles(List<Vehicle> vehicles)
        {
            _VehiclesToShow.Columns.Clear();

            _VehiclesToShow.Columns.Add("ID");
            _VehiclesToShow.Columns.Add("Matricula");
            _VehiclesToShow.Columns.Add("Marca");
            _VehiclesToShow.Columns.Add("Modelo");
            _VehiclesToShow.Columns.Add("Tipo de vehiculo");
            _VehiclesToShow.Columns.Add("Disponibilidad");

            _VehiclesToShow.Rows.Clear();

            foreach (Vehicle vehicle in vehicles)
            {
                DataRow fila = _VehiclesToShow.NewRow();

                fila["ID"] = vehicle.Id;
                fila["Matricula"] = vehicle.Matricula;
                fila["Marca"] = (from model in _models join brand in _brands on model.MarcaId equals brand.Id where model.Id == vehicle.ModeloId select new { BrandName = brand.Marca }).FirstOrDefault().BrandName;
                fila["Modelo"] = _models.FirstOrDefault(model => model.Id == vehicle.ModeloId).Modelo;
                fila["Tipo de vehiculo"] = _vehicleTypes.FirstOrDefault(type => type.Id == vehicle.TipoVehiculoId).Nombre;
                fila["Disponibilidad"] = vehicle.Disponibilidad;

                _VehiclesToShow.Rows.Add(fila);

            }

            DataGridVehiculos.DataSource = _VehiclesToShow;
            DataGridVehiculos.Refresh();
        }

        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            int selectedRows = 0;
            int vehiculoID = 0;
            string availability = ListaEstados.SelectedItem?.ToString();

            foreach (DataGridViewRow row in DataGridVehiculos.Rows)
            {
                DataGridViewCheckBoxCell cell = row.Cells["IDAccion"] as DataGridViewCheckBoxCell;

                if (cell != null)
                {
                    bool isChecked = (bool)cell.EditedFormattedValue;

                    if (isChecked)
                    {
                        selectedRows += 1;

                        if (selectedRows > 1)
                        {
                            MessageBox.Show("No puedes actualizar dos registros a la vez.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return; // Salir del evento si se seleccionan más de una fila
                        }

                        if (row.Cells["ID"].Value != null && int.TryParse(row.Cells["ID"].Value.ToString(), out vehiculoID))
                        {
                            break;
                        }
                        else
                        {
                            MessageBox.Show("El ID del vehículo no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return; // Salir del evento si el ID no es válido
                        }
                    }
                }
            }

            if(selectedRows == 0)
            {
                MessageBox.Show("Debes seleccionar al menos un registro para realizar esta acción.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int affectedRows = 0;
            var vehiculo = _vehicles.FirstOrDefault(vehicle => vehicle.Id == vehiculoID);


            if (vehiculo != null)
            {
                if(vehiculo.Disponibilidad == availability)
                {
                    MessageBox.Show("El estado del vehiculo no puede ser igual al que ya tenía anteriormente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                affectedRows = VehicleDBManager.ChangeVehicleAvailability(vehiculoID, availability);
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error al actualizar el estado del vehículo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (affectedRows == 0)
            {
                MessageBox.Show("No se ha actualizado ningún registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show($"Se ha actualizado {affectedRows} registro.", "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

            _vehicles = VehicleDBManager.GetAllVehicles();

            ShowVehicles(_vehicles);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
