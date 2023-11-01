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
        public main()
        {
            InitializeComponent();
        }

        private void crearEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreacionEmpleado EmpleadoForm = new CreacionEmpleado();
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
    }
}
