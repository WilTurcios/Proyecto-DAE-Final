using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transportes_Figueroa.views;

namespace Transportes_Figueroa
{
    public partial class main : Form
    {
        private string _userType;
        private Guid _employeeID;
        public main(string userType, Guid employeeID)
        {
            InitializeComponent();
            this._userType = userType;
            this._employeeID = employeeID;
        }

        private void crearEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearEmpleado EmpleadoForm = new CrearEmpleado();
            EmpleadoForm.MdiParent = this;

            EmpleadoForm.Show();

        }

        private void gestionarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreacionCliente formClientes = new CreacionCliente();
            formClientes.MdiParent = this;

            formClientes.Show();
        }

        private void gestiónDeVehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void crearVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearVehiculo VehiclesForm = new CrearVehiculo();
            VehiclesForm.MdiParent = this;

            VehiclesForm.Show();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void generarNuevoServicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerarServicio serviceForm = new GenerarServicio(_userType, _employeeID);
            serviceForm.MdiParent = this;

            serviceForm.Show();
        }
    }
}
