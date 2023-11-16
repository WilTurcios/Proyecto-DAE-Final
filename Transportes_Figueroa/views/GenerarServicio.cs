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
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System.IO;
using System.Net.Mail;
using System.Net;
using System.Diagnostics;

namespace Transportes_Figueroa.views
{
    public partial class GenerarServicio : Form
    {
        private string _userType;
        private Employee _employee;
        private ClientManager ClientDB = new ClientManager();
        private EmployeeManager EmployeeDB = new EmployeeManager();
        private VehicleManager VehicleDB = new VehicleManager();
        private ServiceManager ServiceDB = new ServiceManager();
        private List<Client> _clients = new List<Client>();
        private List<Employee> _employees = new List<Employee>();
        private List<Driver> _drivers = new List<Driver>();
        private List<ServiceType> _serviceTypes = new List<ServiceType>();
        private List<Vehicle> _vehicles = new List<Vehicle>();
        private List<CarBrand> _brands = new List<CarBrand>();
        private List<CarModel> _models = new List<CarModel>();
        private List<Service> _services = new List<Service>();
        private List<Rol> _employeeRols = new List<Rol>();
        private Client _selectedClient = new Client();
        private Vehicle _selectedVehicle = new Vehicle();
        private List<Service> _clientServices = new List<Service>();
        private Dictionary<string, int> _driversNamesAndIDs = new Dictionary<string, int>();

        public GenerarServicio(string userType, Employee employee)
        {
            if (string.IsNullOrEmpty(userType))
            {
                throw new ArgumentException($"'{nameof(userType)}' no puede ser nulo ni estar vacío.", nameof(userType));
            }

            InitializeComponent();
            this._employee = employee ?? throw new ArgumentNullException(nameof(employee));
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

            _drivers = EmployeeDB.GetAllDrivers();

            ResetVehiclesAndDriversAvailability(_vehicles, _drivers);

            ListaVehiculos.View = View.Details;
            ListaClientes.View = View.Details;

            foreach (ServiceType tipoServicio in _serviceTypes)
            {
                ListaTipoServicios.Items.Add(tipoServicio.NombreServicio);
            }



            foreach (Driver driver in _drivers.Where(c => c.Disponibilidad == "Disponible"))
            {
                Employee employee = _employees.FirstOrDefault(emp => emp.Id == driver.EmpleadoID);

                if (employee != null)
                {
                    string nombreCompleto = $"{employee.Nombres} {employee.ApellidoPaterno} {employee.ApellidoMaterno}";

                    if (!_driversNamesAndIDs.ContainsKey(nombreCompleto))
                    {
                        _driversNamesAndIDs[nombreCompleto] = driver.Id;
                    }

                    ListaConductores.Items.Add(nombreCompleto);
                }
            }

            foreach (CarBrand marca in _brands)
            {
                ListaMarcas.Items.Add(marca.Marca);
            }

            List<Vehicle> vehiclesToShow = _vehicles.Where(v => v.Disponibilidad == "Disponible").ToList();
            ShowClients(_clients, "Todos");
            ShowVehicles(vehiclesToShow, "Todos");

        }

        private void ResetVehiclesAndDriversAvailability(List<Vehicle> vehicles, List<Driver> drivers)
        {
            if (_services.Count == 0 || vehicles.Count == 0 || drivers.Count == 0)
                return;

            bool changeDrivers = drivers.Any(d => d.Disponibilidad != "Disponible");
            bool changeVehicles = vehicles.Any(v => v.Disponibilidad != "Disponible");

            foreach (Service service in _services)
            {
                if (service.FechaDevolucion.Hour <= DateTime.Now.Hour && service.FechaDevolucion.Date <= DateTime.Now.Date)
                {
                    if (changeDrivers)
                    {
                        string serviceType = _serviceTypes.First(type => type.Id == service.TipoServicioId).NombreServicio;

                        if (serviceType.ToLower() == "transporte de cargas")
                            ChangeDriverAvailability(drivers, (int)service.ConductorID);
                    }

                    if (changeVehicles)
                        ChangeVehicleAvailability(vehicles, service.VehiculoId);
                }
            }
        }

        private void ChangeDriverAvailability(List<Driver> drivers, int driverId)
        {
            Driver assignDriver = drivers.First(d => d.Id == driverId);
            EmployeeDB.ChangeDriverAvailability(assignDriver.Id, "Disponible");
        }

        private void ChangeVehicleAvailability(List<Vehicle> vehicles, int vehicleId)
        {
            Vehicle assignVehicle = vehicles.First(v => v.Id == vehicleId);
            VehicleDB.ChangeVehicleAvailability(assignVehicle.Id, "Disponible");
        }


        private void ShowClients(List<Client> clients, string filtro, string valor = null)
        {
            ListaClientes.Items.Clear();
            List<Client> filteredClients = clients; // Establecer la lista filtrada como la lista completa por defecto

            if (filtro == "DUI")
            {
                filteredClients = clients.Where(c => c.DUI == valor).ToList();
            }
            else if (filtro == "Nombre")
            {
                filteredClients = clients.Where(c => (c.Nombres + " " + c.ApellidoPaterno + " " + c.ApellidoMaterno).Contains(valor)).ToList();
            }

            if (filteredClients.Count == 0)
            {
                filteredClients = clients;

                MessageBox.Show(
                    "No se encontraron registros.",
                    "No encontrado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }

            foreach (Client client in filteredClients)
            {
                string nombreCompleto = client.Nombres + " " + client.ApellidoPaterno + " " + client.ApellidoMaterno;
                ListViewItem cliente = new ListViewItem(nombreCompleto);
                cliente.SubItems.Add(client.DUI);
                cliente.SubItems.Add(client.Id.ToString("D"));

                ListaClientes.Items.Add(cliente);
            }
        }

        private void ShowVehicles(List<Vehicle> vehicles, string filtro, string valor = null)
        {
            List<Vehicle> filteredVehicles = vehicles;

            if (filtro.ToLower() == "marca")
            {
                CarBrand selectedBrand = _brands.FirstOrDefault(b => b.Marca == valor);
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

            if (filtro.ToLower() == "modelo")
            {
                CarModel selectedModel = _models.FirstOrDefault(m => m.Modelo == valor);
                if (selectedModel != null)
                {
                    filteredVehicles = vehicles
                        .Where(v => v.ModeloId == selectedModel.Id)
                        .ToList();
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

            foreach (Service service in services.Where(serv => serv.ClienteId == clientID).ToList())
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
            if (DataGridServiciosCliente.Rows.Count > 0)
            {
                foreach (DataGridViewRow servicio in DataGridServiciosCliente.Rows)
                {
                    bool isChecked = Convert.ToBoolean(servicio.Cells["IDAccionServicio"].Value);

                    if (isChecked)
                    {
                        int servicioID = Convert.ToInt32(servicio.Cells["IDServicio"].Value);

                        int affectedRows = ServiceDB.GenerateInvoice(servicioID, _employee.Id);

                        Invoice insertedInvoice = ServiceDB.GetInviceByServiceID(servicioID);
                        Service service = _services.First(s => s.Id == insertedInvoice.ServicioId);
                        Client client = _clients.First(c => c.Id == service.ClienteId);
                        Vehicle vehicle = _vehicles.First(v => v.Id == service.VehiculoId);
                        string serviceType = _serviceTypes.First(type => type.Id == service.TipoServicioId).NombreServicio;
                        string clientName = $"{client.Nombres} {client.ApellidoPaterno} {client.ApellidoMaterno}";

                        if (affectedRows > 0)
                        {
                            PrevisualizacionFactura prevFactura = new PrevisualizacionFactura(insertedInvoice, service, vehicle, serviceType, clientName, client.Email);

                            prevFactura.Show();
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
                            DialogResult confirmation = MessageBox.Show(
                                "¿Está seguro que deseea cancelar este servicio?",
                                "Confirmación",
                                MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Information
                            );

                            if (confirmation == DialogResult.Cancel) return;
                            
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

            ResetVehiclesAndDriversAvailability(_vehicles, _drivers);
            this.Refresh();
        }

        private void AgregarServicio_Click(object sender, EventArgs e)
        {
            ResetVehiclesAndDriversAvailability(_vehicles, _drivers);

            // Validación de la fecha de devolución
            if (txtFechaDevolucion.Value < txtFechaSolicitud.Value)
            {
                MessageBox.Show("La fecha de devolución debe ser posterior a la fecha de solicitud.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtFechaSolicitud.Value < DateTime.Now)
            {
                MessageBox.Show("La fecha de solicitud no puede ser una fecha que ya ha pasado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime fechaSolicitud = txtFechaSolicitud.Value;
            DateTime fechaDevolucion = txtFechaDevolucion.Value;


            // Validación del valor medido
            if (txtValorMedido.Value <= 0)
            {
                MessageBox.Show("El valor medido debe ser mayor que cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double valorMedido = (double)txtValorMedido.Value;

            // Validación del conductor seleccionado
            string selectedDriverName = ListaConductores.SelectedItem?.ToString() ?? "no existe";

            int? driverID = null;


            if (_driversNamesAndIDs.ContainsKey(selectedDriverName))
            {
                driverID = _driversNamesAndIDs[selectedDriverName];
            }

            // Validación del tipo de servicio seleccionado
            string selectedServiceType = ListaTipoServicios.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedServiceType) || _serviceTypes.All(type => type.NombreServicio != selectedServiceType))
            {
                MessageBox.Show("Debe seleccionar un tipo de servicio válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int tipoServicioID = _serviceTypes.First(type => type.NombreServicio == selectedServiceType).Id;


            int affectedRows = ServiceDB.AddService(fechaSolicitud, fechaDevolucion, valorMedido, tipoServicioID, _selectedVehicle.Id, _selectedClient.Id, driverID);

            if (driverID != null) EmployeeDB.ChangeDriverAvailability((int)driverID, "No disponible");

            

            if(_selectedVehicle != null) VehicleDB.ChangeVehicleAvailability(_selectedVehicle.Id, "No disponible");

            _vehicles = VehicleDB.GetAllVehicles();
            _drivers = EmployeeDB.GetAllDrivers();

            foreach (Driver driver in _drivers.Where(c => c.Disponibilidad == "Disponible"))
            {
                Employee employee = _employees.FirstOrDefault(emp => emp.Id == driver.EmpleadoID);

                if (employee != null)
                {
                    string nombreCompleto = $"{employee.Nombres} {employee.ApellidoPaterno} {employee.ApellidoMaterno}";

                    if (!_driversNamesAndIDs.ContainsKey(nombreCompleto))
                    {
                        _driversNamesAndIDs[nombreCompleto] = driver.Id;
                    }

                    ListaConductores.Items.Add(nombreCompleto);
                }
            }

            List<Vehicle> vehiclesToShow = _vehicles.Where(v => v.Disponibilidad == "Disponible").ToList();
            ShowVehicles(vehiclesToShow, "Todos");

            if (affectedRows == 0)
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
            string selectedModel = ListaModelos.SelectedItem.ToString().Trim();
            int selectedModelIndex = ListaModelos.SelectedIndex;

            if (string.IsNullOrEmpty(selectedModel) || selectedModelIndex == -1)
            {
                MessageBox.Show(
                    "Por favor, selecciona una marca para aplicar el respectivo filtro",
                    "Selecciona un item",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                return;
            }

            ShowVehicles(_vehicles, "Modelo", selectedModel);
        }

        private void ListaMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedBrand = ListaMarcas.SelectedItem.ToString().Trim();
            int selectedBrandIndex = ListaMarcas.SelectedIndex;

            if (string.IsNullOrEmpty(selectedBrand) || selectedBrandIndex == -1)
            {
                MessageBox.Show(
                    "Por favor, selecciona una marca para aplicar el respectivo filtro",
                    "Selecciona un item",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                return;
            }
            int marcaID = _brands.FirstOrDefault(brand => brand.Marca == selectedBrand).Id;

            foreach (CarModel model in _models)
            {
                if (model.MarcaId == marcaID)
                {
                    ListaModelos.Items.Add(model.Modelo);
                }
            }

            ShowVehicles(_vehicles, "marca", selectedBrand);
        }

        private void ListaTipoServicios_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipoServicio = ListaTipoServicios.SelectedItem.ToString();

            if (tipoServicio == "Transporte de cargas")
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
            foreach (ListViewItem item in ListaVehiculos.SelectedItems)
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

        private void btnFiltrarCliente_Click(object sender, EventArgs e)
        {
            if (ListaFiltrosCliente.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Debes seleccionar un item de la lista de filtros antes de clicar este botón",
                    "Selecciona un filtro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }
            string filtro = ListaFiltrosCliente.SelectedItem.ToString();


            string valor = txtFiltroCliente.Text.Trim();

            if (string.IsNullOrEmpty(valor))
            {
                MessageBox.Show(
                    "Asegurate de escribir el valor correcto.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            ShowClients(_clients, filtro, valor);
        }

        private void btnQuitarFiltros_Click(object sender, EventArgs e)
        {
            ShowVehicles(_vehicles, "Todos");
            ShowClients(_clients, "Todos");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtFechaDevolucion.Value < txtFechaSolicitud.Value)
            {
                MessageBox.Show("La fecha de devolución debe ser posterior a la fecha de solicitud.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtFechaSolicitud.Value < DateTime.Now)
            {
                MessageBox.Show("La fecha de solicitud no puede ser una fecha que ya ha pasado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime fechaSolicitud = txtFechaSolicitud.Value;
            DateTime fechaDevolucion = txtFechaDevolucion.Value;


            // Validación del valor medido
            if (txtValorMedido.Value <= 0)
            {
                MessageBox.Show("El valor medido debe ser mayor que cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double valorMedido = (double)txtValorMedido.Value;

            // Validación del conductor seleccionado
            string selectedDriverName = ListaConductores.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedDriverName))
            {
                MessageBox.Show("Debe seleccionar un conductor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int? driverID = null;
            if (ListaConductores.SelectedIndex != -1)
            {
                if (_driversNamesAndIDs.ContainsKey(selectedDriverName))
                {
                    driverID = _driversNamesAndIDs[selectedDriverName];
                }


                // Validación del tipo de servicio seleccionado
                string selectedServiceType = ListaTipoServicios.SelectedItem?.ToString();
                if (string.IsNullOrEmpty(selectedServiceType) || _serviceTypes.All(type => type.NombreServicio != selectedServiceType))
                {
                    MessageBox.Show("Debe seleccionar un tipo de servicio válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int selectedRows = 0;
                int servicioID = 0;
                int tipoServicioID = _serviceTypes.First(type => type.NombreServicio == selectedServiceType).Id;

                foreach (DataGridViewRow row in DataGridServiciosCliente.Rows)
                {
                    DataGridViewCheckBoxCell cell = row.Cells["IDAccionServicio"] as DataGridViewCheckBoxCell;

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

                            if (row.Cells["IDServicio"].Value != null && int.TryParse(row.Cells["IDServicio"].Value.ToString(), out servicioID))
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


                int affectedRows = ServiceDB.UpdateService(fechaSolicitud, fechaDevolucion, valorMedido, tipoServicioID, _selectedVehicle.Id, servicioID, driverID);

                if (affectedRows == 0)
                {
                    MessageBox.Show(
                        "Ha ocurrido un error al actualizar el servicio, intentelo de nuevo.",
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
                        "El servicio ha sido actualizado correctamente.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                 );
            }

            ResetVehiclesAndDriversAvailability(_vehicles, _drivers);
            this.Refresh();
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            ResetVehiclesAndDriversAvailability(_vehicles, _drivers);

            foreach (Driver driver in _drivers.Where(c => c.Disponibilidad == "Disponible"))
            {
                Employee employee = _employees.FirstOrDefault(emp => emp.Id == driver.EmpleadoID);

                if (employee != null)
                {
                    string nombreCompleto = $"{employee.Nombres} {employee.ApellidoPaterno} {employee.ApellidoMaterno}";

                    if (!_driversNamesAndIDs.ContainsKey(nombreCompleto))
                    {
                        _driversNamesAndIDs[nombreCompleto] = driver.Id;
                    }

                    ListaConductores.Items.Add(nombreCompleto);
                }
            }

            foreach (CarBrand marca in _brands)
            {
                ListaMarcas.Items.Add(marca.Marca);
            }

            List<Vehicle> vehiclesToShow = _vehicles.Where(v => v.Disponibilidad == "Disponible").ToList();
            ShowVehicles(vehiclesToShow, "Todos");

            this.Refresh();

        }
    }
}
