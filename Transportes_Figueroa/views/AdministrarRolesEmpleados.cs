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
    public partial class AdministrarRolesEmpleados : Form
    {
        private EmployeeManager EmployeeDBManager = new EmployeeManager();
        private List<Rol> _employeeRols = new List<Rol>();
        private int _selectedDataGridIndex;
        public AdministrarRolesEmpleados()
        {
            InitializeComponent();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowEmployeeRols(List<Rol> employeeRols)
        {
            DataTable infoRoles = new DataTable();

            infoRoles.Columns.Clear();
            infoRoles.Rows.Clear();

            infoRoles.Columns.Add("id_rol");
            infoRoles.Columns.Add("rol");
            infoRoles.Columns.Add("sueldo_hora");

            foreach (Rol rol in employeeRols)
            {
                DataRow fila = infoRoles.NewRow();

                fila["id_rol"] = rol.Id;
                fila["rol"] = rol.Nombre;
                fila["sueldo_hora"] = rol.SueldoHora.ToString("0.00");

                infoRoles.Rows.Add(fila);
            }

            DataGridRolesEmpleados.DataSource = infoRoles;
            DataGridRolesEmpleados.Refresh();
        }

        private void AgregarRolEmpleado_Click(object sender, EventArgs e)
        {
            string nombreRol = txtNombreRol.Text;
            decimal salario = txtRolSueldo.Value;

            if (string.IsNullOrEmpty(nombreRol) || nombreRol.Length < 3)
            {
                MessageBox.Show(
                    "Asegurate de insertar un nombre válido para el rol a agregar.\n" +
                    "\nEl nombre debe tener tres o más caracteres",
                    "Nombre inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            if (!decimal.TryParse(txtRolSueldo.Value.ToString(), out salario))
            {
                MessageBox.Show(
                    "Ingrese una valor válido en el campo de salario.\n",
                    "Salario inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            if (salario <= 0)
            {
                MessageBox.Show(
                    "El salario no puede ser de cero.\n",
                    "Salario inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            int affectedRows = EmployeeDBManager.AddEmployeeRol(nombreRol, salario);


            _employeeRols = EmployeeDBManager.GetRols();

            ShowEmployeeRols(_employeeRols);
        }

        private void EliminarRolEmpleado_Click(object sender, EventArgs e)
        {
            // Crear una lista de IDs de registros a eliminar
            List<int> idsToDelete = new List<int>();

            foreach (DataGridViewRow row in DataGridRolesEmpleados.Rows)
            {
                DataGridViewCheckBoxCell checkBox = row.Cells["IDAccion"] as DataGridViewCheckBoxCell;

                if (Convert.ToBoolean(checkBox.Value))
                {
                    int rolID = Convert.ToInt32(row.Cells[1].Value);
                    idsToDelete.Add(rolID);
                }
            }

            if (idsToDelete.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione al menos un registro para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (int rolID in idsToDelete)
            {
                int affectedRows = EmployeeDBManager.DeleteEmployeeRol(rolID);

                if (affectedRows == 0)
                {
                    MessageBox.Show("No se pudo realizar la eliminación del rol con ID " + rolID + ", por favor intente de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }

            // Actualiza la fuente de datos o realiza cualquier otra acción necesaria después de la eliminación
            _employeeRols = EmployeeDBManager.GetRols();
            ShowEmployeeRols(_employeeRols);

            MessageBox.Show("Registros eliminados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AdministrarRolesEmpleados_Load(object sender, EventArgs e)
        {
            _employeeRols = EmployeeDBManager.GetRols();

            ShowEmployeeRols(_employeeRols);
        }

        private void ActualizarRolEmpleado_Click(object sender, EventArgs e)
        {
            int selectedRows = 0;
            int rolID = 0;
            string nombreRol = txtNombreRol.Text.Trim();
            decimal salario = 0;


            if (string.IsNullOrEmpty(nombreRol) || nombreRol.Length < 3)
            {
                MessageBox.Show(
                    "Asegurate de insertar un nombre válido para el rol a agregar.\n" +
                    "\nEl nombre debe tener tres o más caracteres",
                    "Nombre inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            if(!decimal.TryParse(txtRolSueldo.Value.ToString(), out  salario))
            {
                MessageBox.Show(
                    "Ingrese una valor válido en el campo de salario.\n",
                    "Salario inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            if (salario <= 0)
            {
                MessageBox.Show(
                    "El salario no puede ser de cero.\n",
                    "Salario inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            // Validar que se haya seleccionado exactamente una fila
            foreach (DataGridViewRow row in DataGridRolesEmpleados.Rows)
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

                        if (row.Cells["IDRol"].Value != null && int.TryParse(row.Cells["IDRol"].Value.ToString(), out rolID))
                        {
                            break;
                        }
                        else
                        {
                            MessageBox.Show("El ID del rol no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return; // Salir del evento si el ID no es válido
                        }
                    }
                }
            }

            int affectedRows = 0;
            var employeeRol = _employeeRols.FirstOrDefault(rol => rol.Id == rolID);

            if (employeeRol != null)
            {
                affectedRows = EmployeeDBManager.UpdateEmployeeRol(rolID, salario);
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error al actualizar el rol de empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (affectedRows == 0)
            {
                MessageBox.Show("No se ha actualizado ningún registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show($"Se ha actualizado {affectedRows} registro.", "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

            _employeeRols = EmployeeDBManager.GetRols();

            ShowEmployeeRols(_employeeRols);
        }

        private void DataGridRolesEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DataGridRolesEmpleados.Columns["IDAccion"].Index && e.RowIndex >= 0)
            {
                // Desmarcar todas las demás filas excepto la seleccionada
                foreach (DataGridViewRow row in DataGridRolesEmpleados.Rows)
                {
                    if (row.Index != e.RowIndex)
                    {
                        DataGridViewCheckBoxCell celda = row.Cells["IDAccion"] as DataGridViewCheckBoxCell;

                        if (celda != null && (bool)celda.EditedFormattedValue)
                        {
                            celda.Value = false;
                        }
                    }
                }

                DataGridViewRow selectedRow = DataGridRolesEmpleados.Rows[e.RowIndex];
                DataGridViewCheckBoxCell cell = selectedRow.Cells["IDAccion"] as DataGridViewCheckBoxCell;

                if (cell != null)
                {
                    bool isChecked = (bool)cell.EditedFormattedValue;

                    // Habilitar o deshabilitar los controles según la casilla de verificación marcada
                    txtNombreRol.Enabled = !isChecked;
                    AgregarRolEmpleado.Enabled = !isChecked;

                    if (isChecked)
                    {
                        // Si la casilla está marcada, se reflejan los datos de la fila seleccionada en los controles
                        txtNombreRol.Text = selectedRow.Cells["RolEmpleado"].Value.ToString();
                        txtRolSueldo.Value = Convert.ToDecimal(selectedRow.Cells["SalarioEmpleado"].Value);
                    }
                    else
                    {
                        // Si la casilla no está marcada, se borran o reiniciar los datos en los controles.
                        txtNombreRol.Text = string.Empty;
                        txtRolSueldo.Value = 0;
                        txtNombreRol.Enabled = true;
                        AgregarRolEmpleado.Enabled = true;
                    }
                }
            }
        }

        private void btnQuitarSeleccion_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DataGridRolesEmpleados.Rows)
            {
                DataGridViewCheckBoxCell celda = row.Cells["IDAccion"] as DataGridViewCheckBoxCell;
                celda.Value = false;
            }

            txtNombreRol.Text = string.Empty;
            txtRolSueldo.Value = 0;

            AgregarRolEmpleado.Enabled = true;
            txtNombreRol.Enabled = true;
        }
    }
}
