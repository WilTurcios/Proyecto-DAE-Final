using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transportes_Figueroa.models;
using Transportes_Figueroa.Models;
using Transportes_Figueroa.Services;
using Transportes_Figueroa.Utils;

namespace Transportes_Figueroa.views
{
    public partial class AdministrarVehiculos : Form
    {
        private VehicleManager VehicleDBManager = new VehicleManager();
        private byte[] _imagen = null;
        private List<Vehicle> _vehicles;
        private List<CarBrand> _brands;
        private List<CarModel> _models;
        private List<VehicleType> _vehicleTypes;
        private DataTable _VehiclesToShow = new DataTable();

        public AdministrarVehiculos()
        {
            
            InitializeComponent();
        }

        private void ShowVehicles(List<Vehicle> vehicles)
        {
            _VehiclesToShow.Columns.Clear();

            _VehiclesToShow.Columns.Add("ID");
            _VehiclesToShow.Columns.Add("Matricula");
            _VehiclesToShow.Columns.Add("Marca");
            _VehiclesToShow.Columns.Add("Modelo");
            _VehiclesToShow.Columns.Add("Tipo de vehiculo");
            _VehiclesToShow.Columns.Add("Año");
            _VehiclesToShow.Columns.Add("Capacidad de personas");
            _VehiclesToShow.Columns.Add("Limite de peso");
            _VehiclesToShow.Columns.Add("Costo");

            _VehiclesToShow.Rows.Clear();

            foreach(Vehicle vehicle in vehicles)
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


        private void CrearVehiculo_Load(object sender, EventArgs e)
        {
            _brands = VehicleDBManager.GetAllVehicleBrands();
            _models = VehicleDBManager.GetAllVehicleModels();
            _vehicles = VehicleDBManager.GetAllVehicles();
            _vehicleTypes = VehicleDBManager.GetAllVehicleTypes();

            ShowVehicles(_vehicles);

            foreach (CarBrand brand in _brands){
                ListaMarcas.Items.Add(brand.Marca);
            }

            foreach(VehicleType vehicleType in _vehicleTypes)
            {
                ListaTipoVehiculos.Items.Add(vehicleType.Nombre);
            }


        }

        private void btnSubirImagen_Click(object sender, EventArgs e)
        {
            var result = ImageHandler.GetImageData();

            if (result.rutaImagen == null) return;

            _imagen = result.datosBinarios;


            try
            {
                pictureBox1.Image = Image.FromFile(result.rutaImagen);
            }
            catch (OutOfMemoryException ex)
            {
                MessageBox.Show("La imagen es demasiado grande, por favor optimice la imagen antes de cargarla.", "Error: Archivo demasiado grande", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void AgregarVehiculo_Click(object sender, EventArgs e)
        {
            // Agregar un nuevo vehiculo

            string matricula = txtMatricula.Text;
            int anio = 0;
            decimal costo = 0;
            double kilometraje = 0;
            int capacidadPersonas = (int)txtCapacidadPersonas.Value;
            double capacidadPeso = (double)txtCapacidadPersonas.Value;
            byte[] imagen;

            if (!double.TryParse(txtKilometraje.Value.ToString(), out kilometraje))
            {
                MessageBox.Show(
                    "Ingrese un número válido en el campo de kilometraje.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            if (kilometraje <= 0)
            {
                MessageBox.Show(
                    "El kilometraje no puede ser cero o un número negativo.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            if (!int.TryParse(txtAnio.Value.ToString(), out anio))
            {
                MessageBox.Show(
                    "Ingrese un número válido en el año del vehículo.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            if (anio <= 0)
            {
                MessageBox.Show(
                    "El año no puede ser cero o un número negativo.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            if (!decimal.TryParse(txtCosto.Value.ToString(), out costo))
            {
                MessageBox.Show(
                    "Ingrese un número válido en el campo de costo.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            if (costo <= 0)
            {
                MessageBox.Show(
                    "El costo no puede ser cero o un número negativo.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Debe seleccionar una imagen antes de continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            imagen = _imagen;

            if (ListaMarcas.SelectedIndex == -1)
            {
                MessageBox.Show("Debes asegurarte de seleccionar una marca de vehiculo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var marcaID = _brands.FirstOrDefault(brand => brand.Marca == ListaMarcas.SelectedItem.ToString()).Id;

            if (ListaModelos.SelectedIndex == -1)
            {
                MessageBox.Show("Debes asegurarte de seleccionar una marca de vehiculo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var modeloID = _models.FirstOrDefault(model => model.Modelo == ListaModelos.SelectedItem.ToString()).Id;

            if (ListaTipoVehiculos.SelectedIndex == -1)
            {
                MessageBox.Show("Debes asegurarte de seleccionar una marca de vehiculo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var tipoVehiculoID = _vehicleTypes.FirstOrDefault(type => type.Nombre == ListaTipoVehiculos.SelectedItem.ToString()).Id;


            int affectedRows = VehicleDBManager.AddVehicle(matricula, kilometraje, anio, capacidadPersonas, capacidadPeso, costo, imagen, tipoVehiculoID, modeloID);

            _vehicles = VehicleDBManager.GetAllVehicles();

            ShowVehicles(_vehicles);

        }

        private void ActualizarVehiculo_Click(object sender, EventArgs e)
        {
            int selectedRows = 0;
            int vehiculoID = 0;
            double kilometraje = 0;
            decimal costo = 0;
            double capacidadPeso = (double)txtCapacidadPeso.Value;

            if(ListaTipoVehiculos.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Asegurese de seleccionar un tipo de vehiculo.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            int tipoVehiculoID = _vehicleTypes.FirstOrDefault(type => type.Nombre == ListaTipoVehiculos.SelectedItem.ToString()).Id;

            if(!double.TryParse(txtKilometraje.Value.ToString(), out kilometraje))
            {
                MessageBox.Show(
                    "Ingrese un número válido en el campo de kilometraje.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            if(kilometraje <= 0)
            {
                MessageBox.Show(
                    "El kilometraje no puede ser cero o un número negativo.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            if (!decimal.TryParse(txtCosto.Value.ToString(), out costo))
            {
                MessageBox.Show(
                    "Ingrese un número válido en el campo de costo.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            if (costo <= 0)
            {
                MessageBox.Show(
                    "El costo no puede ser cero o un número negativo.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }
            // Validar que se haya seleccionado exactamente una fila
            foreach (DataGridViewRow row in DataGridVehiculos.Rows)
            {
                DataGridViewCheckBoxCell cell = row.Cells["IDAccionAgregarVehiculo"] as DataGridViewCheckBoxCell;

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

            int affectedRows = 0;
            var vehiculo = _vehicles.FirstOrDefault(vehicle => vehicle.Id == vehiculoID);

            if (vehiculo != null)
            {
                byte[] imagen = (_imagen != null && _imagen.Length != 0) ? _imagen : vehiculo.Imagen;
                affectedRows = VehicleDBManager.UpdateVehicle(vehiculoID, kilometraje, capacidadPeso, costo, tipoVehiculoID, imagen);
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error al actualizar el vehículo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void EliminarVehiculo_Click(object sender, EventArgs e)
        {
            bool alMenosUnaCeldaSeleccionada = false;

            // Eliminar un vehiculo
            foreach (DataGridViewRow row in DataGridVehiculos.Rows)
            {
                DataGridViewCheckBoxCell cell = row.Cells["IDAccionAgregarVehiculo"] as DataGridViewCheckBoxCell;

                if (cell != null)
                {
                    bool isChecked = (bool)cell.EditedFormattedValue;

                    if (isChecked)
                    {
                        alMenosUnaCeldaSeleccionada = true;

                        if (row.Cells["ID"].Value != null && int.TryParse(row.Cells["ID"].Value.ToString(), out int vehiculoID))
                        {
                            if (MessageBox.Show("¿Está seguro de que desea eliminar el vehiculo seleccionado?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                VehicleDBManager.DeleteVehicle(vehiculoID);

                                _vehicles = VehicleDBManager.GetAllVehicles();

                                ShowVehicles(_vehicles);
                            }
                        }
                    }
                }
            }

            if (!alMenosUnaCeldaSeleccionada)
            {
                MessageBox.Show("Seleccione al menos una celda antes de eliminar un vehículo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridVehiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DataGridVehiculos.Columns["IDAccionAgregarVehiculo"].Index && e.RowIndex >= 0)
            {
                // Desmarcar todas las demás filas excepto la seleccionada
                foreach (DataGridViewRow row in DataGridVehiculos.Rows)
                {
                    if (row.Index != e.RowIndex)
                    {
                        DataGridViewCheckBoxCell celda = row.Cells["IDAccionAgregarVehiculo"] as DataGridViewCheckBoxCell;

                        if (celda != null && (bool)celda.EditedFormattedValue)
                        {
                            celda.Value = false;
                        }
                    }
                }

                DataGridViewRow selectedRow = DataGridVehiculos.Rows[e.RowIndex];
                DataGridViewCheckBoxCell cell = selectedRow.Cells["IDAccionAgregarVehiculo"] as DataGridViewCheckBoxCell;

                if (cell != null)
                {
                    bool isChecked = (bool)cell.EditedFormattedValue;

                    // Habilitar o deshabilitar los controles según la casilla de verificación marcada
                    txtMatricula.Enabled = !isChecked;
                    ListaMarcas.Enabled = !isChecked;
                    ListaModelos.Enabled = !isChecked;
                    txtAnio.Enabled = !isChecked;

                    if (isChecked)
                    {
                        // Si la casilla está marcada, puedes reflejar los datos de la fila seleccionada en los controles.
                        if (selectedRow.Cells["ID"].Value != null && int.TryParse(selectedRow.Cells["ID"].Value.ToString(), out int vehiculoID))
                        {
                            byte[] imagen = _vehicles.FirstOrDefault(vehicle => vehicle.Id == vehiculoID).Imagen;
                            pictureBox1.Image = ImageHandler.ConvertToImage(imagen);
                        }
                        txtMatricula.Text = selectedRow.Cells["Matricula"].Value.ToString();
                        ListaMarcas.SelectedItem = selectedRow.Cells["Marca"].Value.ToString();
                        ListaModelos.SelectedItem = selectedRow.Cells["Modelo"].Value.ToString();
                        ListaTipoVehiculos.SelectedItem = selectedRow.Cells["Tipo de vehiculo"].Value.ToString();
                        if (selectedRow.Cells["Capacidad de personas"].Value != null && decimal.TryParse(selectedRow.Cells["Capacidad de personas"].Value.ToString(), out decimal capacidadPersonas))
                        {
                            txtCapacidadPersonas.Value = capacidadPersonas;
                        }

                        if (selectedRow.Cells["Limite de peso"].Value != null && decimal.TryParse(selectedRow.Cells["Limite de peso"].Value.ToString(), out decimal capacidadPeso))
                        {
                            txtCapacidadPeso.Value = capacidadPeso;
                        }

                        if (selectedRow.Cells["Costo"].Value != null && decimal.TryParse(selectedRow.Cells["Costo"].Value.ToString(), out decimal costo))
                        {
                            txtCosto.Value = costo;

                        }

                        if (selectedRow.Cells["Año"].Value != null && int.TryParse(selectedRow.Cells["Año"].Value.ToString(), out int anio))
                        {
                            txtAnio.Value = anio;
                        }

                    }
                    else
                    {
                        // Si la casilla no está marcada, puedes borrar o reiniciar los datos en los controles.
                        txtMatricula.Text = string.Empty;
                        ListaMarcas.SelectedIndex = -1;
                        ListaModelos.SelectedIndex = -1;
                        ListaTipoVehiculos.SelectedIndex = -1;
                        txtCapacidadPersonas.Value = 0;
                        txtCapacidadPeso.Value = 0;
                        txtCosto.Value = 0;
                        txtAnio.Value = 1900;
                        pictureBox1.Image = null;

                        // Borra o reinicia otros controles según las necesidades.
                    }
                }
            }
        }

        private void ListaMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListaMarcas.SelectedIndex == -1) return;

            string currentBrand = ListaMarcas.SelectedItem.ToString();
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
