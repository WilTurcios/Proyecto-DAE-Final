using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transportes_Figueroa.models;
using Transportes_Figueroa.Models;
using Transportes_Figueroa.Services;
using Transportes_Figueroa.Utils;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Transportes_Figueroa.views
{
    public partial class AdministrarEmpleados : Form
    {
       
        private Dictionary<string, List<string>> municipiosPorDepartamento = new Dictionary<string, List<string>>
        {
            { "Ahuachapán", new List<string>
                {
                    "Ahuachapán",
                    "Apaneca",
                    "Atiquizaya",
                    "Concepción de Ataco",
                    "El Refugio",
                    "Guaymango",
                    "Jujutla",
                    "San Francisco Menéndez",
                    "San Lorenzo",
                    "San Pedro Puxtla",
                    "Tacuba",
                    "Turín"
                }
            },
            { "Cabañas", new List<string>
                {
                    "Cinquera",
                    "Dolores",
                    "Guacotecti",
                    "Ilobasco",
                    "Jutiapa",
                    "Sensuntepeque",
                    "Tejutepeque",
                    "Victoria"
                }
            },
            { "Chalatenango", new List<string>
                {
                    "Agua Caliente",
                    "Arcatao",
                    "Azacualpa",
                    "Chalatenango",
                    "Citalá",
                    "Comalapa",
                    "Concepción Quezaltepeque",
                    "Dulce Nombre de María",
                    "El Carrizal",
                    "El Paraíso",
                    "La Laguna",
                    "La Palma",
                    "La Reina",
                    "Las Vueltas",
                    "Nueva Concepción",
                    "Nueva Trinidad",
                    "Ojos de Agua",
                    "Potonico",
                    "San Antonio de la Cruz",
                    "San Antonio Los Ranchos",
                    "San Fernando",
                    "San Francisco Lempa",
                    "San Francisco Morazán",
                    "San Ignacio",
                    "San Isidro Labrador",
                    "San José Cancasque",
                    "San José Las Flores",
                    "San Luis del Carmen",
                    "San Miguel de Mercedes",
                    "San Rafael",
                    "Santa Rita",
                    "Tejutla"
                }
            },
            { "Cuscatlán", new List<string>
                {
                    "Cojutepeque",
                    "Candelaria",
                    "El Carmen",
                    "El Rosario",
                    "Monte San Juan",
                    "Oratorio de Concepción",
                    "San Bartolomé Perulapía",
                    "San Cristóbal",
                    "San José Guayabal",
                    "San Pedro Perulapán",
                    "San Rafael Cedros",
                    "San Ramón",
                    "Santa Cruz Analquito",
                    "Santa Cruz Michapa",
                    "Suchitoto",
                    "Tenancingo"
                }
            },
            { "La Libertad", new List<string>
                {
                    "Antiguo Cuscatlán",
                    "Chiltiupán",
                    "Ciudad Arce",
                    "Colón",
                    "Comasagua",
                    "Huizúcar",
                    "Jayaque",
                    "Jicalapa",
                    "La Libertad",
                    "Nuevo Cuscatlán",
                    "Opico",
                    "Quezaltepeque",
                    "Sacacoyo",
                    "San José Villanueva",
                    "San Matías",
                    "San Pablo Tacachico",
                    "Santa Tecla",
                    "Talnique",
                    "Tamanique",
                    "Teotepeque",
                    "Tepecoyo",
                    "Zaragoza"
                }
            },
            { "La Paz", new List<string>
                {
                    "Cuyultitán",
                    "El Rosario",
                    "Jerusalén",
                    "Mercedes La Ceiba",
                    "Olocuilta",
                    "Paraíso de Osorio",
                    "San Antonio Masahuat",
                    "San Emigdio",
                    "San Francisco Chinameca",
                    "San Juan Nonualco",
                    "San Juan Talpa",
                    "San Juan Tepezontes",
                    "San Luis La Herradura",
                    "San Luis Talpa",
                    "San Miguel Tepezontes",
                    "San Pedro Masahuat",
                    "San Pedro Nonualco",
                    "San Rafael Obrajuelo",
                    "Santa María Ostuma",
                    "Santiago Nonualco",
                    "Tapalhuaca"
                }
            },
            { "La Unión", new List<string>
                {
                    "Anamorós",
                    "Bolívar",
                    "Concepción de Oriente",
                    "Conchagua",
                    "El Carmen",
                    "El Sauce",
                    "Intipucá",
                    "La Unión",
                    "Lislique",
                    "Meanguera del Golfo",
                    "Nueva Esparta",
                    "Pasaquina",
                    "Polorós",
                    "San Alejo",
                    "San José",
                    "Santa Rosa de Lima",
                    "Yayantique"
                }
            },
            { "Morazán", new List<string>
                {
                    "Cacaopera",
                    "Corinto",
                    "Delicias de Concepción",
                    "El Divisadero",
                    "El Rosario",
                    "Gualococti",
                    "Guatajiagua",
                    "Joateca",
                    "Jocoaitique",
                    "Lolotiquillo",
                    "Meanguera",
                    "Osicala",
                    "Perquín",
                    "San Carlos",
                    "San Fernando",
                    "San Francisco Gotera",
                    "San Isidro",
                    "San Simón",
                    "Sensembra",
                    "Sociedad",
                    "Torola",
                    "Yamabal",
                    "Yoloaiquín"
                }
            },
            { "San Miguel", new List<string>
                {
                    "Carolina",
                    "Chapeltique",
                    "Chinameca",
                    "Chirilagua",
                    "Ciudad Barrios",
                    "Comacarán",
                    "El Tránsito",
                    "Lolotique",
                    "Moncagua",
                    "Nueva Guadalupe",
                    "Nuevo Edén de San Juan",
                    "Quelepa",
                    "San Antonio",
                    "San Gerardo",
                    "San Jorge",
                    "San Luis de la Reina",
                    "San Miguel",
                    "San Rafael Oriente",
                    "Sesori",
                    "Uluazapa",
                    "Uluazapa"
                }
            },
            { "San Salvador", new List<string>
                {
                    "Aguilares",
                    "Apopa",
                    "Ayutuxtepeque",
                    "Cuscatancingo",
                    "Delgado",
                    "El Paisnal",
                    "Guazapa",
                    "Ilopango",
                    "Mejicanos",
                    "Nejapa",
                    "Panchimalco",
                    "Rosario de Mora",
                    "San Marcos",
                    "San Martín",
                    "San Salvador",
                    "Santiago Texacuangos",
                    "Santo Tomás",
                    "Soyapango",
                    "Tonacatepeque"
                }
            },
            { "San Vicente", new List<string>
                {
                    "Apastepeque",
                    "Guadalupe",
                    "San Cayetano Istepeque",
                    "San Esteban Catarina",
                    "San Ildefonso",
                    "San Lorenzo",
                    "San Sebastián",
                    "San Vicente",
                    "Santa Clara",
                    "Santo Domingo"
                }
            },
            { "Santa Ana", new List<string>
                {
                    "Candelaria de la Frontera",
                    "Chalchuapa",
                    "Coatepeque",
                    "El Congo",
                    "El Porvenir",
                    "Masahuat",
                    "Metapán",
                    "San Antonio Pajonal",
                    "San Sebastián Salitrillo",
                    "Santa Ana",
                    "Santa Rosa Guachipilín",
                    "Santiago de la Frontera",
                    "Texistepeque"
                }
            },
            { "Sonsonate", new List<string>
                {
                    "Acajutla",
                    "Armenia",
                    "Caluco",
                    "Cuisnahuat",
                    "Izalco",
                    "Juayúa",
                    "Nahuizalco",
                    "Nahulingo",
                    "Salcoatitán",
                    "San Antonio del Monte",
                    "San Julián",
                    "Santa Catarina Masahuat",
                    "Santa Isabel Ishuatán",
                    "Santo Domingo de Guzmán",
                    "Sonsonate",
                    "Sonzacate"
                }
            },
            { "Usulután", new List<string>
                {
                    "Alegría",
                    "Berlín",
                    "California",
                    "Concepción Batres",
                    "El Triunfo",
                    "Ereguayquín",
                    "Estanzuelas",
                    "Jiquilisco",
                    "Jucuapa",
                    "Jucuarán",
                    "Mercedes Umaña",
                    "Nueva Granada",
                    "Ozatlán",
                    "Puerto El Triunfo",
                    "San Agustín",
                    "San Buenaventura",
                    "San Dionisio",
                    "San Francisco Javier",
                    "Santa Elena",
                    "Santa María",
                    "Santiago de María",
                    "Tecapán",
                    "Usulután"
                }
            }
        };
        private UserManager UserDBManager = new UserManager();
        private EmployeeManager EmployeeDBManager = new EmployeeManager();
        private PasswordEncryptor passwordEncryptor = new PasswordEncryptor("M1$Gz@jRq9T#pK&3wFvS!xU4nW8zZ*Cb");
        private List<Employee> _employees = new List<Employee>(); 
        private List<Rol> _employeeRols = new List<Rol>();
        private List<User> _users = new List<User>();
        private List<UserType> _userTypes = new List<UserType>();
        private bool _button1Image1IsVisible = true;
        private bool _button2Image1IsVisible = true;
        private bool _button3Image1IsVisible = true;
        private bool _button4Image1IsVisible = true;
        private byte[] _imagen;
        private Employee _selectedEmployee = new Employee();

        public AdministrarEmpleados()
        {
            InitializeComponent();
            CostumizeInformationPanels();
        }

        private void CostumizeInformationPanels()
        {
            PanelDatosGenerales.Visible = false;
            PanelDatosUsuario.Visible = false;
            PanelDireccion.Visible = false;
            PanelRol.Visible = false;
        }

        private void ShowEmployees(List<Employee> employees, string rol = null)
        {
            ListaEmpleados.Items.Clear();
            

            List<Employee> filteredEmployees = employees; 

            if (rol != null)
            {
                int rolID = _employeeRols.FirstOrDefault(r => r.Nombre == rol).Id;
                filteredEmployees = employees.Where(emp => emp.RolId == rolID).ToList();
            }
            
            if (filteredEmployees.Count == 0)
            {
                filteredEmployees = employees;

                MessageBox.Show(
                    "No se encontraron registros.",
                    "No encontrado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                FiltroPorRol.SelectedIndex = -1;
            }

            foreach (Employee employee in filteredEmployees)
            {
                ListViewItem empleado = new ListViewItem(employee.Nombres);
                empleado.SubItems.Add(employee.Id.ToString("D"));


                ListaEmpleados.Items.Add(empleado);
            }
        }

        private void CreacionEmpleado_Load(object sender, EventArgs e)
        {
            _employees = EmployeeDBManager.GetAllEmployees();
            _users = UserDBManager.GetAllUsers();
            _userTypes = UserDBManager.GetAllUserTypes();
            _employeeRols = EmployeeDBManager.GetRols();

            ListaEmpleados.View = View.Details;



            // Si _roles no se ha inicializado previamente como un diccionario, inicialízalo
            if (_employeeRols != null)
            {
                foreach (Rol rol in _employeeRols)
                {
                    ListaRolesEmpleado.Items.Add(rol.Nombre);
                    FiltroPorRol.Items.Add(rol.Nombre);
                }
            }

            if(_userTypes != null)
            {
                foreach (UserType userType in _userTypes)
                {
                    ListaRolesUsuario.Items.Add(userType.Tipo);
                }
            }

            ShowEmployees(_employees);


            foreach (string departamento in municipiosPorDepartamento.Keys)
            {
                ListaDepartamentos.Items.Add(departamento);
            }

        }

        private void btnMostrarDatosGenerales_Click(object sender, EventArgs e)
        {
            PanelDatosGenerales.Visible = !PanelDatosGenerales.Visible;

            if (_button1Image1IsVisible)
            {
                btnMostrarDatosGenerales.Image = Transportes_Figueroa.Properties.Resources.down_arrow;
                _button1Image1IsVisible = !_button1Image1IsVisible;
            }
            else
            {
                btnMostrarDatosGenerales.Image = Transportes_Figueroa.Properties.Resources.right_arrow;
                _button1Image1IsVisible = !_button1Image1IsVisible;
            }
        }

        private void btnMostrarDatosUsuario_Click(object sender, EventArgs e)
        {
            PanelDatosUsuario.Visible = !PanelDatosUsuario.Visible;

            if (_button2Image1IsVisible)
            {
                btnMostrarDatosUsuario.Image = Transportes_Figueroa.Properties.Resources.down_arrow;
                _button2Image1IsVisible = !_button1Image1IsVisible;
            }
            else
            {
                btnMostrarDatosUsuario.Image = Transportes_Figueroa.Properties.Resources.right_arrow;
                _button2Image1IsVisible = !_button1Image1IsVisible;
            }
        }

        private void btnMostrarRolEmpleado_Click(object sender, EventArgs e)
        {
            PanelRol.Visible = !PanelRol.Visible;

            if (_button3Image1IsVisible)
            {
                btnMostrarRolEmpleado.Image = Transportes_Figueroa.Properties.Resources.down_arrow;
                _button3Image1IsVisible = !_button1Image1IsVisible;
            }
            else
            {
                btnMostrarRolEmpleado.Image = Transportes_Figueroa.Properties.Resources.right_arrow;
                _button3Image1IsVisible = !_button1Image1IsVisible;
            }
        }

        private void btnMostrarDireccion_Click(object sender, EventArgs e)
        {
            PanelDireccion.Visible = !PanelDireccion.Visible;

            if (_button4Image1IsVisible)
            {
                btnMostrarDireccion.Image = Properties.Resources.down_arrow;
                _button4Image1IsVisible = !_button1Image1IsVisible;
            }
            else
            {
                btnMostrarDireccion.Image = Properties.Resources.right_arrow;
                _button4Image1IsVisible = !_button1Image1IsVisible;
            }
        }
  

        private void EliminarEmpleado_Click(object sender, EventArgs e)
        {
            if (_selectedEmployee.Id != null)
            {
                int affectedRows = EmployeeDBManager.DeleteEmployee(_selectedEmployee.Id);

                if (affectedRows == 0)
                {
                    MessageBox.Show("Ha ocurrido un error al eliminar el empleado, por favor, intente de nuevo", "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _employees = EmployeeDBManager.GetAllEmployees();

                    ShowEmployees(_employees);

                    return;
                }
                else
                {
                    MessageBox.Show("La eliminación del empleado ha sido exitosa", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetControls();
                    _selectedEmployee = new Employee();
                    return;
                }


            }
            else
            {
                MessageBox.Show("Ha ocurrido un error al eliminar el empleado. \n Asegurese de seleccionar el empleado a eliminar. \n\nAsegurese de seleccinar un empleado a eliminar", "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void QuitarSeleccion_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in ListaEmpleados.SelectedItems)
            {
                item.Selected = false;
            }

            _selectedEmployee = new Employee();
        }

        private void ActualizarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                Employee empleado = _employees.FirstOrDefault(employee => employee.Id == _selectedEmployee.Id);



                if (empleado == null || empleado.IdUsuario == null)
                {
                    MessageBox.Show(
                        "Seleccione un empleado y asegurese de rellenar los datos solicitados.",
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                Guid usuarioID = _users.FirstOrDefault(user => user.Id == empleado.IdUsuario).Id;


                if (txtContrasenia.Text.Trim().Length < 3)
                {
                    MessageBox.Show(

                        "La contraseña tiene que contener como mínimo 3 caracteres.",
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }
                string contrasenia = passwordEncryptor.EncryptPassword(txtContrasenia.Text);

                string correo = txtCorreo.Text.ToLower();

                if (!Validator.IsValidEmail(correo))
                {
                    MessageBox.Show(
                        "El formato del correo es incorrecto. \n\n Asegurese de que sea un correo electrónico válido",
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }
                string nombres = txtNombres.Text.Trim();

                if (nombres.Length < 4)
                {
                    MessageBox.Show(
                        "El nombre no puede ir vacío y tiene que tener como mínimo 4 caracteres.",
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }
                string apellidoPaterno = txtApellidoPaterno.Text.Trim();
                string apellidoMaterno = txtApellidoMaterno.Text.Trim();

                if (apellidoMaterno.Length < 4 && apellidoPaterno.Length < 4)
                {
                    MessageBox.Show(
                        "Los apellidos no pueden ir vacíos y tienen que tener como mínimo 4 caracteres.",
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }
                string telefono = txtTelefono.Text;

                if (!Validator.IsValidPhoneNumber(telefono))
                {
                    MessageBox.Show(
                        "El teléfono tiene que tener un formato válido.",
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                if (ListaRolesEmpleado.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "Debe seleccionar un rol para el empleado",
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }
                int rolID = _employeeRols.FirstOrDefault(rol => rol.Nombre == ListaRolesEmpleado.SelectedItem.ToString()).Id;
                string departamento = ListaDepartamentos.SelectedItem.ToString();

                if (ListaDepartamentos.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "Debe seleccionar un departamento para el empleado",
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                if (ListaMunicipios.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "Debe seleccionar un municipio para el empleado",
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }
                string municipio = ListaMunicipios.SelectedItem.ToString();

                string ubicacion = txtUbicacion.Text;
                string calle = txtCalle.Text;
                string codigoCasa = txtCodCasa.Text;
                string codigoAFP = txtCodAFP.Text;
                string codigoSeguro = txtCodSeguro.Text;

                if (string.IsNullOrEmpty(ubicacion) && string.IsNullOrEmpty(calle) && string.IsNullOrEmpty(codigoCasa))
                {
                    MessageBox.Show(
                        "Asegurese de que todos los datos de la dirección estén rellenados.",
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }
                UserDBManager.ChangeUserPassword(usuarioID, contrasenia);

                int affectedRows = EmployeeDBManager.UpdateEmployee(
                                        _selectedEmployee.Id,
                                        codigoSeguro,
                                        _imagen,
                                        telefono,
                                        departamento,
                                        municipio,
                                        calle,
                                        codigoCasa,
                                        ubicacion,
                                        rolID
                                    );

                if (affectedRows > 0)
                {
                    MessageBox.Show(
                        "El empleado ha sido actualizado exitosamente",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                else
                {
                    MessageBox.Show(
                        "Ha ocurrido un error al actualizar el empleado",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    return;
                }

                _employees = EmployeeDBManager.GetAllEmployees();
                _users = UserDBManager.GetAllUsers();

                ShowEmployees(_employees);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                        "Asegurese de seleccionar un empleado antes de actualizar.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                _selectedEmployee = new Employee();
            }

            
        }

        private void ListaEmpleados_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            bool isSelected = e.IsSelected;

            if (isSelected)
            {
                Employee empleado = new Employee();
                User usuario = new User();



                if (Guid.TryParse(ListaEmpleados.SelectedItems[0].SubItems[1].Text, out Guid empleadoID))
                {
                    empleado = _employees.FirstOrDefault(employee => employee.Id == empleadoID);
                    usuario = _users.FirstOrDefault(user => user.Id == empleado.IdUsuario);
                    _imagen = empleado.Imagen;
                }

                if (usuario != null)
                {
                    txtCorreo.Text = usuario.Correo;
                    txtContrasenia.Text = passwordEncryptor.DecryptPassword(usuario.Contrasenia);
                    ListaRolesUsuario.SelectedItem = _userTypes.FirstOrDefault(type => type.Id == usuario.TipoUsuarioId).Tipo;
                }

                if (empleado != null)
                {
                    _selectedEmployee = empleado;
                    txtNombres.Text = empleado.Nombres;
                    txtApellidoMaterno.Text = empleado.ApellidoMaterno;
                    txtApellidoPaterno.Text = empleado.ApellidoPaterno;
                    txtTelefono.Text = empleado.NumeroTelefonico;
                    txtDUI.Text = empleado.DUI;
                    txtCodAFP.Text = empleado.CodigoAFP;
                    txtCodSeguro.Text = empleado.CodigoSeguro;

                    if (_employeeRols.FirstOrDefault(rol => rol.Id == empleado.RolId) != null)
                    {
                        ListaRolesEmpleado.SelectedItem = _employeeRols.FirstOrDefault(rol => rol.Id == empleado.RolId).Nombre;
                    }

                    ListaDepartamentos.SelectedItem = empleado.Departamento;
                    ListaMunicipios.SelectedItem = empleado.Municipio;
                    txtUbicacion.Text = empleado.Ubicacion;
                    txtCalle.Text = empleado.Calle;
                    txtCodCasa.Text = empleado.CodigoCasa;

                    FotoEmpleado.Image = ImageHandler.ConvertToImage(empleado.Imagen);
                }

                txtNombres.Enabled = !isSelected;
                txtApellidoMaterno.Enabled = !isSelected;
                txtApellidoPaterno.Enabled = !isSelected;
                txtDUI.Enabled = !isSelected;
                txtCodAFP.Enabled = !isSelected;
                txtCodSeguro.Enabled = !isSelected;

                txtCorreo.Enabled = !isSelected;

                AgregarEmpleado.Enabled = !isSelected;
            }
            else
            {
                ResetControls();
            }
        }

        private void ResetControls()
        {
            txtNombres.Text = string.Empty;
            txtApellidoMaterno.Text = string.Empty;
            txtApellidoPaterno.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtDUI.Text = string.Empty;
            txtCodAFP.Text = string.Empty;
            txtCodSeguro.Text = string.Empty;

            txtCorreo.Text = string.Empty;
            txtContrasenia.Text = string.Empty;
            ListaRolesUsuario.SelectedIndex = -1;

            ListaRolesEmpleado.SelectedIndex = -1;

            ListaDepartamentos.SelectedIndex = -1;
            ListaMunicipios.SelectedIndex = -1;
            txtUbicacion.Text = string.Empty;
            txtCalle.Text = string.Empty;
            txtCodCasa.Text = string.Empty;
            FotoEmpleado.Image = null;

            txtNombres.Enabled = true;
            txtApellidoMaterno.Enabled = true;
            txtApellidoPaterno.Enabled = true;
            txtDUI.Enabled = true;
            txtCodAFP.Enabled = true;
            txtCodSeguro.Enabled = true;

            txtCorreo.Enabled = true;

            AgregarEmpleado.Enabled = true;
        }


        private void AgregarEmpleado_Click(object sender, EventArgs e)
        {
            Guid userID = Guid.NewGuid();
            Guid empleadoID = Guid.NewGuid();

            if(txtContrasenia.Text.Trim().Length < 3)
            {
                MessageBox.Show(

                    "La contraseña tiene que contener como mínimo 3 caracteres.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            string contrasenia = passwordEncryptor.EncryptPassword(txtContrasenia.Text);

            string correo = txtCorreo.Text.ToLower();

            if (!Validator.IsValidEmail(correo))
            {
                MessageBox.Show(
                    "El formato del correo es incorrecto. \n\n Asegurese de que sea un correo electrónico válido",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            string nombres = txtNombres.Text.Trim();

            if (nombres.Length < 4)
            {
                MessageBox.Show(
                    "El nombre no puede ir vacío y tiene que tener como mínimo 4 caracteres.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            string apellidoPaterno = txtApellidoPaterno.Text.Trim();
            string apellidoMaterno = txtApellidoMaterno.Text.Trim();

            if (apellidoMaterno.Length < 4 && apellidoPaterno.Length < 4)
            {
                MessageBox.Show(
                    "Los apellidos no pueden ir vacíos y tienen que tener como mínimo 4 caracteres.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            string telefono = txtTelefono.Text;

            if (!Validator.IsValidPhoneNumber(telefono))
            {
                MessageBox.Show(
                    "El teléfono tiene que tener un formato válido.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if(ListaRolesEmpleado.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Debe seleccionar un rol para el empleado",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            int rolID = _employeeRols.FirstOrDefault(rol => rol.Nombre == ListaRolesEmpleado.SelectedItem.ToString()).Id;
            string departamento = ListaDepartamentos.SelectedItem.ToString();

            if (ListaDepartamentos.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Debe seleccionar un departamento para el empleado",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (ListaMunicipios.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Debe seleccionar un municipio para el empleado",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            string municipio = ListaMunicipios.SelectedItem.ToString();

            string ubicacion = txtUbicacion.Text;
            string calle = txtCalle.Text;
            string codigoCasa = txtCodCasa.Text;
            string codigoAFP = txtCodAFP.Text;
            string codigoSeguro = txtCodSeguro.Text;

            if (string.IsNullOrEmpty(ubicacion) && string.IsNullOrEmpty(calle) && string.IsNullOrEmpty(codigoCasa))
            {
                MessageBox.Show(
                    "Asegurese de que todos los datos de la dirección estén rellenados.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            string duiEmpleado = txtDUI.Text;

            if (!Validator.IsValidDUI(duiEmpleado))
            {
                MessageBox.Show(
                    "Asegurese de que el DUI del empleado tenga un formato válido.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if(ListaRolesUsuario.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Debe seleccionar un rol de usuario para el empleado.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            int tipoUsuario = _userTypes.FirstOrDefault(type => type.Tipo == ListaRolesUsuario.SelectedItem.ToString()).Id;

            if (FotoEmpleado.Image == null)
            {
                MessageBox.Show("Por favor, agrega la fotografía del empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            byte[] imagen = _imagen;


            UserDBManager.AddUser(userID, correo, contrasenia, tipoUsuario);

            EmployeeDBManager.AddEmployee(
                empleadoID,
                nombres,
                apellidoPaterno,
                apellidoMaterno,
                telefono,
                codigoAFP,
                codigoSeguro,
                imagen,
                departamento,
                municipio,
                ubicacion,
                calle,
                codigoCasa,
                userID,
                rolID,
                duiEmpleado
           );

            _employees = EmployeeDBManager.GetAllEmployees();
            _users = UserDBManager.GetAllUsers();

            ShowEmployees(_employees);
        }

        private void ListaEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void ListaDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListaMunicipios.Items.Clear();

            if (ListaDepartamentos.SelectedItem == null) return;

            string departamento = ListaDepartamentos.SelectedItem.ToString();



            foreach (string municipio in municipiosPorDepartamento[departamento])
            {
                ListaMunicipios.Items.Add(municipio);
            }
        }

        private void FiltroPorRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(FiltroPorRol.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Selecciona un rol para filtrar a los empleados.",
                    "Elige un rol",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                return;
            }

            string selectedRol = FiltroPorRol.SelectedItem.ToString();
            ShowEmployees(_employees, selectedRol);
        }

        private void MostrarTodosLosEmpleados_Click(object sender, EventArgs e)
        {
            ShowEmployees(_employees);
        }

        private void AgregarFotoEmpleado_Click(object sender, EventArgs e)
        {
            var result = ImageHandler.GetImageData();

            if (result.rutaImagen == null) return;

            _imagen = result.datosBinarios;


            FotoEmpleado.Image = Image.FromFile(result.rutaImagen);
        }
    }
}
