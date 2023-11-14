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
using Transportes_Figueroa.views;

namespace Transportes_Figueroa
{
    public partial class MainForm : Form
    {
        private string _userType;
        private Employee _employee;
        private User _user;
        private Form _activeForm = null;
        public MainForm(string userType, Employee employee, User user)
        {
            InitializeComponent();
            this._userType = userType;
            this._employee = employee;
            this._user = user;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AdministrarRolesEmpleados administrarRolesEmpleadosForm = new AdministrarRolesEmpleados();

            OpenChildForm(administrarRolesEmpleadosForm);
        }

        private void ContentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CustomizePanelsDesign();
        }

        private void CustomizePanelsDesign()
        {
            PanelGestionClientes.Visible = false;
            PanelConfiguracion.Visible = false;
            PanelGestionServicios.Visible = false;
            PanelGestionEmpleados.Visible = false;
            PanelGestionVehiculos.Visible = false;
        }

        private void HideSubMenu()
        {
            PanelGestionClientes.Visible = false;
            PanelConfiguracion.Visible = false;
            PanelGestionServicios.Visible = false;
            PanelGestionEmpleados.Visible = false;
            PanelGestionVehiculos.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu == null) return; 

            if(subMenu.Visible == false)
            {
                HideSubMenu();

                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnGestionEmpleados_Click(object sender, EventArgs e)
        {
            ShowSubMenu(PanelGestionEmpleados);
        }

        private void btnGestionClientes_Click(object sender, EventArgs e)
        {
            ShowSubMenu(PanelGestionClientes);
        }

        private void btnGestionVehiculos_Click(object sender, EventArgs e)
        {
            ShowSubMenu(PanelGestionVehiculos);

        }

        private void btnGestionServicios_Click(object sender, EventArgs e)
        {
            ShowSubMenu(PanelGestionServicios);

        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            ShowSubMenu(PanelConfiguracion);
        }

        private void OpenChildForm(Form ChildForm)
        {
            if (_activeForm != null)
                _activeForm.Close();

            _activeForm = ChildForm;

            ChildForm.TopLevel = false;
            ChildForm.Dock = DockStyle.Fill;
            ChildFormContainer.Controls.Add(ChildForm);
            ChildFormContainer.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CreacionCliente clientsForm = new CreacionCliente();

            OpenChildForm(clientsForm);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            GenerarServicio serviceForm = new GenerarServicio(_userType, _employee);

            OpenChildForm(serviceForm);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Perfil perfilForm = new Perfil(_employee, _user);

            OpenChildForm(perfilForm);
        }

        private void btnAdministrarEmpleados_Click(object sender, EventArgs e)
        {
            CrearEmpleado employeesForm = new CrearEmpleado();

            OpenChildForm(employeesForm);
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            CrearVehiculo vehiclesForm = new CrearVehiculo();

            OpenChildForm(vehiclesForm);
        }

        private void btnAdministrarMarcas_Click(object sender, EventArgs e)
        {
            AdministrarMarcas administraraMarcasForm = new AdministrarMarcas();

            OpenChildForm(administraraMarcasForm);
        }

        private void btnAdministrarModelos_Click(object sender, EventArgs e)
        {
            AdministrarModelos administrarModelosForm = new AdministrarModelos();

            OpenChildForm(administrarModelosForm);
        }

        private void btnAdministrarEstadoVehiculo_Click(object sender, EventArgs e)
        {
            AdministrarEstadoVehiculos administrarEstadoVehiculos = new AdministrarEstadoVehiculos();

            OpenChildForm(administrarEstadoVehiculos);
        }
    }
}
