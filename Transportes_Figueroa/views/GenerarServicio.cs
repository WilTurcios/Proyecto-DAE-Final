using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transportes_Figueroa.controllers;
using Transportes_Figueroa.models;
using Transportes_Figueroa.Models;
using Transportes_Figueroa.Services;

namespace Transportes_Figueroa.views
{
    public partial class GenerarServicio : Form
    {
        private string _userType;
        private Guid _employeeID;
        private ClientManager ClientDB = new ClientManager();
        private EmployeeManager EmployeeDB = new EmployeeManager();
        private VehicleManager VehicleDB = new VehicleManager();
        private ServiceManager ServiceDB = new ServiceManager();
        private List<Client> _clients = new List<Client>();
        private List<Employee> _employees = new List<Employee>();
        private List<Employee> _drivers = new List<Employee>();
        private List<ServiceType> _serviceTypes = new List<ServiceType>();
        private List<Vehicle> _vehicles = new List<Vehicle>();
        private List<CarBrand> _brands = new List<CarBrand>();
        private List<CarModel> _models = new List<CarModel>();
        private List<Service> _services = new List<Service>();
        private List<Rol> _employeeRols = new List<Rol>();
        private Client _selectedClient = new Client();
        private Vehicle _selectedVehicle = new Vehicle();
        private List<Service> _clientServices = new List<Service>();

        public GenerarServicio(string userType, Guid employeeID)
        {
            InitializeComponent();
            this._employeeID = employeeID;
            this._userType = userType;
        }

        private void GenerarServicio_Load(object sender, EventArgs e)
        {

            ListaConductores.Enabled = false;

            _clients = ClientDB.GetAllClients();
            _employees = EmployeeDB.GetAllEmployees();
            _employeeRols = EmployeeDB.GetRols();
            _serviceTypes = ServiceDB.GetAllServiceTypes();
            _vehicles = VehicleDB.GetAllVehicles();
            _brands = VehicleDB.GetAllVehicleBrands();
            _models = VehicleDB.GetAllVehicleModels();
            _services = ServiceDB.GetAllServices();

            _drivers = _employees.Where(employee => employee.RolId == 2).ToList();

            ListaVehiculos.View = View.Details;
            ListaClientes.View = View.Details;

            foreach (ServiceType tipoServicio in _serviceTypes)
            {
                ListaTipoServicios.Items.Add(tipoServicio.NombreServicio);
            }

            foreach (Employee driver in _drivers)
            {
                string nombreCompleto = driver.Nombres + " " + driver.ApellidoPaterno + " " + driver.ApellidoMaterno;
                ListaConductores.Items.Add(nombreCompleto);
            }

            foreach (CarBrand marca in _brands)
            {
                ListaMarcas.Items.Add(marca.Marca);
            }

            ShowClients(_clients);
            ShowVehicles(_vehicles, "Todos");
        }

        private void ShowClients(List<Client> clients)
        {
            ListaClientes.Items.Clear();
            foreach (Client client in clients)
            {
                string nombreCompleto = client.Nombres + " " + client.ApellidoPaterno + " " + client.ApellidoMaterno;
                ListViewItem cliente = new ListViewItem(nombreCompleto);
                cliente.SubItems.Add(client.DUI);
                cliente.SubItems.Add(client.Id.ToString("D"));


                ListaClientes.Items.Add(cliente);
            }
        }

        private void ShowVehicles(List<Vehicle> vehicles, string filtro)
        {
            List<Vehicle> filteredVehicles = new List<Vehicle>();

            switch (filtro)
            {
                case "Todos":
                    filteredVehicles = vehicles;
                    break;
                case "Marca":
                    if (ListaMarcas.SelectedIndex != -1 && ListaModelos.SelectedIndex == -1)
                    {
                        string selectedMarca = ListaMarcas.SelectedItem.ToString();
                        CarBrand selectedBrand = _brands.FirstOrDefault(b => b.Marca == selectedMarca);
                        if (selectedBrand != null)
                        {
                            List<int> ListOfModelIds = _models
                                .Where(m => m.MarcaId == selectedBrand.Id)
                                .Select(m => m.Id)
                                .ToList();

                            if (ListOfModelIds.Count > 0)
                            {
                                filteredVehicles = vehicles
                                    .Where(v => ListOfModelIds.Contains(v.ModeloId))
                                    .ToList();
                            }
                            else
                            {
                                MessageBox.Show(
                                    "No se encontraron registros.",
                                    "No encontrado",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information
                                );
                                filteredVehicles = vehicles;
                            }
                        }
                        else
                        {
                            MessageBox.Show(
                                "No se encontraron registros.",
                                "No encontrado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );
                            filteredVehicles = vehicles;
                        }
                    }
                    break;
                case "Modelo":
                    if (ListaMarcas.SelectedIndex != -1 && ListaModelos.SelectedIndex != -1)
                    {
                        string selectedModelo = ListaModelos.SelectedItem.ToString();
                        CarModel selectedModel = _models.FirstOrDefault(m => m.Modelo == selectedModelo);
                        if (selectedModel != null)
                        {
                            filteredVehicles = vehicles
                                .Where(v => v.ModeloId == selectedModel.Id)
                                .ToList();
                        }
                    }

                    if (filteredVehicles.Count == 0)
                    {
                        MessageBox.Show(
                            "No se encontraron coincidencias.",
                            "No encontrado",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                        filteredVehicles = vehicles;
                    }
                    break;
            }

            ListaVehiculos.Items.Clear(); // Clear existing items before adding new ones

            foreach (Vehicle vehicle in filteredVehicles)
            {
                CarModel modelo = _models.FirstOrDefault(model => model.Id == vehicle.ModeloId);
                string marca = _brands.FirstOrDefault(brand => brand.Id == modelo.MarcaId).Marca;

                ListViewItem vehiculo = new ListViewItem(vehicle.Id.ToString());
                vehiculo.SubItems.Add(marca);
                vehiculo.SubItems.Add(modelo.Modelo);
                vehiculo.SubItems.Add(vehicle.Costo.ToString("0.00"));

                ListaVehiculos.Items.Add(vehiculo);
            }
        }

        private void ShowClientServices(List<Service> services, Guid clientID)
        {
            DataTable clientServices = new DataTable();

            clientServices.Columns.Add("id_servicio");
            clientServices.Columns.Add("tipo_servicio");
            clientServices.Columns.Add("fecha_solicitud");
            clientServices.Columns.Add("fecha_devolucion");
            clientServices.Columns.Add("monto");

            foreach(Service service in services.Where(serv => serv.ClienteId == clientID).ToList())
            {
                DataRow fila = clientServices.NewRow();
                decimal monto = (Convert.ToDecimal(service.ValorMedido) * _vehicles.FirstOrDefault(v => v.Id == service.VehiculoId).Costo);
                fila["id_servicio"] = service.Id.ToString();
                fila["fecha_solicitud"] = service.FechaSolicitud.ToString();
                fila["fecha_devolucion"] = service.FechaDevolucion.ToString();
                fila["tipo_servicio"] = _serviceTypes.FirstOrDefault(type => type.Id == service.TipoServicioId).NombreServicio;
                fila["monto"] = monto.ToString("0.00");

                clientServices.Rows.Add(fila);
            }

            DataGridServiciosCliente.DataSource = clientServices;
            DataGridServiciosCliente.Refresh();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if(DataGridServiciosCliente.Rows.Count > 0)
            {
                foreach(DataGridViewRow servicio in DataGridServiciosCliente.Rows)
                {
                    bool isChecked = Convert.ToBoolean(servicio.Cells["IDAccionServicio"].Value);

                    if (isChecked)
                    {
                        int servicioID = Convert.ToInt32(servicio.Cells["IDServicio"].Value);

                        int affectedRows = ServiceDB.GenerateInvoice(servicioID, _employeeID);

                        if(affectedRows > 0)
                        {
                            MessageBox.Show(
                                "La factura ha sido creada correctamente.",
                                "Éxito", 
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );
                        }
                        else
                        {
                            MessageBox.Show(
                                "Ha ocurrido un error al crear la factura.",
                                "Éxito",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );
                        }
                    }
                }
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            if (DataGridServiciosCliente.Rows.Count > 0)
            {
                foreach (DataGridViewRow servicio in DataGridServiciosCliente.Rows)
                {
                    bool isChecked = Convert.ToBoolean(servicio.Cells["IDAccionServicio"].Value);

                    if (isChecked)
                    {
                        int servicioID = Convert.ToInt32(servicio.Cells["IDServicio"].Value);

                        Service serviceToCancel = _clientServices.FirstOrDefault(service => service.Id == servicioID);

                        if (DateTime.Now >= serviceToCancel.FechaDevolucion)
                        {
                            MessageBox.Show(
                                "La factura no puede cancelarse ya que el plazo de devolución se ha cumplido.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );
                        }
                        else
                        {
                            ServiceDB.ChangeServiceState("Cancelado", serviceToCancel.Id);

                            MessageBox.Show(
                                "El servicio ha sido cancelado exitosamente.",
                                "Éxito",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );
                        }
                    }
                }
            }
        }

        private void AgregarServicio_Click(object sender, EventArgs e)
        {
            DateTime fechaSolicitud = txtFechaSolicitud.Value;
            DateTime fechaDevolucion = txtFechaDevolucion.Value;
            double valorMedido = (double)txtValorMedido.Value;

            int selectedDriverIndex = ListaConductores.SelectedIndex;
            Guid? driverID = null;

            if (selectedDriverIndex != -1)
            {
                string selectedDriverName = ListaConductores.SelectedItem.ToString();

                driverID =  _drivers.FirstOrDefault(driver => selectedDriverName.Contains(driver.Nombres + " " + driver.ApellidoPaterno)).Id;
            }

            int tipoServicioID = _serviceTypes.FirstOrDefault(type => type.NombreServicio == ListaTipoServicios.SelectedItem.ToString()).Id;

            int affectedRows = ServiceDB.AddService(fechaSolicitud, fechaDevolucion, valorMedido, tipoServicioID, _selectedVehicle.Id, _selectedClient.Id, driverID);

            if(affectedRows == 0)
            {
                MessageBox.Show(
                    "Ha ocurrido un error al añadir registro, intentelo de nuevo.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }


            _services = ServiceDB.GetAllServices();
            _clientServices = ServiceDB.GetAllServicesByClientId(_selectedClient.Id);
            ShowClientServices(_services, _selectedClient.Id);

            MessageBox.Show(
                    "El servicio ha sido añadido correctamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
             );

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListaModelos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowVehicles(_vehicles, "Modelo");
        }

        private void ListaMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int marcaID = _brands.FirstOrDefault(brand => brand.Marca == ListaMarcas.SelectedItem.ToString()).Id;
            
            foreach(CarModel model in _models)
            {
                if(model.MarcaId == marcaID)
                {
                    ListaModelos.Items.Add(model.Modelo);
                }
            }

            ShowVehicles(_vehicles, "Marca");
        }

        private void ListaTipoServicios_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipoServicio = ListaTipoServicios.SelectedItem.ToString();

            if(tipoServicio == "Transporte de cargas")
            {
                ListaConductores.Enabled = true;
            }
            else
            {
                ListaConductores.Enabled = false;
                ListaConductores.SelectedIndex = -1;
            }
        }

        private void ListaVehiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void SeleccionarVehiculo_Click(object sender, EventArgs e)
        {
            bool isItemSelected = Convert.ToBoolean(ListaVehiculos.SelectedItems.Count);

            if (!isItemSelected)
            {
                MessageBox.Show("Por favor seleccione un vehiculo de la lista antes de clicar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int selectedVehicleID = Convert.ToInt32(ListaVehiculos.SelectedItems[0].Text);

            _selectedVehicle = _vehicles.FirstOrDefault(vehicle => vehicle.Id == selectedVehicleID);
        }

        private void SeleccionarCliente_Click(object sender, EventArgs e)
        {
            bool isItemSelected = Convert.ToBoolean(ListaClientes.SelectedItems.Count);

            if (!isItemSelected)
            {
                MessageBox.Show(
                    "Por favor seleccione un cliente de la lista antes de clicar.", 
                    "Error", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error
                );
                return;
            }

            string idToParse = ListaClientes.SelectedItems[0].SubItems[2].Text.ToString();

            if (Guid.TryParseExact(idToParse, "D", out Guid selectedClientID))
            {

                _selectedClient = _clients.FirstOrDefault(client => client.Id == selectedClientID);

                return;
            }
            else
            {
                MessageBox.Show(
                    "Ha ocurrido un error, intentelo de nuevo." +
                    "\nSi el error persiste comuniquelo de inmediato a su superior.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }



        }

        private void ListaClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                if (ListaClientes.SelectedItems[0] == null || ListaClientes.SelectedItems[0].SubItems[2] == null) return;

                string idToParse = ListaClientes.SelectedItems[0].SubItems[2].Text.ToString();

                if (Guid.TryParseExact(idToParse, "D", out Guid selectedClientID))
                {

                    _selectedClient = _clients.FirstOrDefault(client => client.Id == selectedClientID);

                    _clientServices = ServiceDB.GetAllServicesByClientId(_selectedClient.Id);

                    ShowClientServices(_services, _selectedClient.Id);
                    return;
                }
                else
                {
                    MessageBox.Show(
                        "Ha ocurrido un error, intentelo de nuevo." +
                        "\nSi el error persiste comuniquelo de inmediato a su superior.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }
            }
            catch
            {
                return;
            }
            
        }

        private void QuitarSeleccionVehiculo_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in ListaVehiculos.SelectedItems)
            {
                item.Selected = false;
            }
        }

        private void QuitarSeleccionCliente_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in ListaClientes.SelectedItems)
            {
                item.Selected = false;
            }

            DataTable emptyServicesTable = new DataTable();
            
            emptyServicesTable.Columns.Add("id_servicio");
            emptyServicesTable.Columns.Add("tipo_servicio");
            emptyServicesTable.Columns.Add("fecha_solicitud");
            emptyServicesTable.Columns.Add("fecha_devolucion");
            emptyServicesTable.Columns.Add("monto");
            DataGridServiciosCliente.DataSource = emptyServicesTable;

            DataGridServiciosCliente.Refresh();
        }
    }
}
