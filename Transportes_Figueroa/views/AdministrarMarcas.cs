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
    public partial class AdministrarMarcas : Form
    {
        private VehicleManager VehicleDBManager = new VehicleManager();
        private List<CarBrand> _brands;
        private DataTable _VehicleBrandsToShow = new DataTable();
        public AdministrarMarcas()
        {
            InitializeComponent();
        }

        private void ShowVehicleBrands(List<CarBrand> brands)
        {
            _VehicleBrandsToShow.Columns.Clear();

            _VehicleBrandsToShow.Columns.Add("ID");
            _VehicleBrandsToShow.Columns.Add("Marca");

            _VehicleBrandsToShow.Rows.Clear();

            foreach (CarBrand brand in brands)
            {
                DataRow fila = _VehicleBrandsToShow.NewRow();

                fila["ID"] = brand.Id;
                fila["Marca"] = brand.Marca;

                _VehicleBrandsToShow.Rows.Add(fila);
            }

            DataGridMarcas.DataSource = _VehicleBrandsToShow;
            DataGridMarcas.Refresh();
        }

        private void AgregarMarca_Click(object sender, EventArgs e)
        {
            string marca = txtMarca.Text.Trim();

            if (string.IsNullOrEmpty(marca) || marca.Length < 3)
            {
                MessageBox.Show("El campo marca debe tener al menos 3 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int affectedRows = VehicleDBManager.AddVehicleBrand(marca);

            if (affectedRows == 0)
            {
                MessageBox.Show("No se ha podido hacer el registro de la marca.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Registro exitoso.", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            _brands = VehicleDBManager.GetAllVehicleBrands();

            ShowVehicleBrands(_brands);
            return;
        }

        private void EliminarMarca_Click(object sender, EventArgs e)
        {
            List<int> marcasAEliminar = new List<int>();

            foreach (DataGridViewRow row in DataGridMarcas.Rows)
            {
                DataGridViewCheckBoxCell cell = row.Cells["IDAccionAgregarMarca"] as DataGridViewCheckBoxCell;

                if (cell != null)
                {
                    bool isChecked = (bool)cell.EditedFormattedValue;

                    if (isChecked)
                    {
                        if (row.Cells["ID"].Value != null && int.TryParse(row.Cells["ID"].Value.ToString(), out int marcaID))
                        {
                            marcasAEliminar.Add(marcaID);
                        }
                    }
                }
            }

            if (marcasAEliminar.Count > 0)
            {
                if (MessageBox.Show("¿Está seguro de que desea eliminar los modelos seleccionados?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foreach (int marcaID in marcasAEliminar)
                    {
                        VehicleDBManager.DeleteVehicleBrand(marcaID);
                    }

                    _brands = VehicleDBManager.GetAllVehicleBrands();

                    ShowVehicleBrands(_brands);
                }
            }
        }

        private void AdministrarMarcas_Load(object sender, EventArgs e)
        {
            _brands = VehicleDBManager.GetAllVehicleBrands();

            ShowVehicleBrands(_brands);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
