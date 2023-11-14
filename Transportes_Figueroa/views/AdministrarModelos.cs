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
    public partial class AdministrarModelos : Form
    {
        private VehicleManager VehicleDBManager = new VehicleManager();
        private List<CarBrand> _brands;
        private List<CarModel> _models;
        private DataTable _VehicleModelsToShow = new DataTable();
        public AdministrarModelos()
        {
            InitializeComponent();
        }
        private void ShowVehicleModels(List<CarModel> models)
        {
            _VehicleModelsToShow.Columns.Clear();
            _VehicleModelsToShow.Columns.Add("ID");
            _VehicleModelsToShow.Columns.Add("Marca");
            _VehicleModelsToShow.Columns.Add("Modelo");

            _VehicleModelsToShow.Rows.Clear();

            foreach (CarModel model in models)
            {
                DataRow fila = _VehicleModelsToShow.NewRow();

                fila["ID"] = model.Id;
                fila["Marca"] = _brands.FirstOrDefault(brand => brand.Id == model.MarcaId).Marca;
                fila["Modelo"] = model.Modelo;

                _VehicleModelsToShow.Rows.Add(fila);
            }

            DataGridModelos.DataSource = _VehicleModelsToShow;
            DataGridModelos.Refresh();
        }


        private void AgregarModelo_Click(object sender, EventArgs e)
        {

            string modelo = txtModelo.Text.Trim();

            if (string.IsNullOrEmpty(modelo) || modelo.Length < 3)
            {
                MessageBox.Show("El campo modelo debe tener al menos 3 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ListaMarcas_modelos.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un modelo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int marcaID = _brands.FirstOrDefault(brand => brand.Marca == ListaMarcas_modelos.SelectedItem.ToString()).Id;

            int affectedRows = VehicleDBManager.AddVehicleModel(modelo, marcaID);

            if (affectedRows == 0)
            {
                MessageBox.Show("No se ha podido hacer el registro del modelo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Registro exitoso.", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            _models = VehicleDBManager.GetAllVehicleModels();

            ShowVehicleModels(_models);

            return;
        }

        private void EliminarModelo_Click(object sender, EventArgs e)
        {
            List<int> modelosAEliminar = new List<int>();

            foreach (DataGridViewRow row in DataGridModelos.Rows)
            {
                DataGridViewCheckBoxCell cell = row.Cells["IDAccionAgregarModelo"] as DataGridViewCheckBoxCell;

                if (cell != null)
                {
                    bool isChecked = (bool)cell.EditedFormattedValue;

                    if (isChecked)
                    {
                        if (row.Cells["ID"].Value != null && int.TryParse(row.Cells["ID"].Value.ToString(), out int modeloID))
                        {
                            modelosAEliminar.Add(modeloID);
                        }
                    }
                }
            }

            if (modelosAEliminar.Count > 0)
            {
                if (MessageBox.Show("¿Está seguro de que desea eliminar los modelos seleccionados?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foreach (int modeloID in modelosAEliminar)
                    {
                        VehicleDBManager.DeleteVehicleModel(modeloID);
                    }

                    _models = VehicleDBManager.GetAllVehicleModels();

                    ShowVehicleModels(_models);
                }
            }
        }

        private void AdministrarModelos_Load(object sender, EventArgs e)
        {
            _models = VehicleDBManager.GetAllVehicleModels();
            _brands = VehicleDBManager.GetAllVehicleBrands();

            ShowVehicleModels(_models);

            foreach (CarBrand brand in _brands)
            {
                ListaMarcas_modelos.Items.Add(brand.Marca);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListaMarcas_modelos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
