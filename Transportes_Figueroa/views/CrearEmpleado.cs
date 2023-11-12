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

namespace Transportes_Figueroa.views
{
    public partial class CrearEmpleado : Form
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
        private DataTable InfoEmpleados = new DataTable();
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
        private Guid _selectedEmployee;

        public CrearEmpleado()
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

        private void ShowEmployees(List<Employee> employees)
        {
            ListaEmpleados.Items.Clear();
            foreach (Employee employee in employees)
            {
                ListViewItem empleado = new ListViewItem(employee.Nombres);
                empleado.SubItems.Add(employee.Id.ToString("D"));


                ListaEmpleados.Items.Add(empleado);
            }
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
                fila["sueldo_hora"] = rol.SueldoHora;

                infoRoles.Rows.Add(fila);
            }

            DataGridRolesEmpleados.DataSource = infoRoles;
            DataGridRolesEmpleados.Refresh();
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
            ShowEmployeeRols(_employeeRols);


            foreach (string departamento in municipiosPorDepartamento.Keys)
            {
                ListaDepartamentos.Items.Add(departamento);
            }

        }     

        private void EliminarEmpleado_Click_1(object sender, EventArgs e)
        {
            if (_selectedEmployee != null)
            {
                int affectedRows = EmployeeDBManager.DeleteEmployee(_selectedEmployee);

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
                    return;
                }
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error al eliminar el empleado. \n\nAsegurese de seleccinar un empleado a eliminar", "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AgregarRolEmpleado_Click(object sender, EventArgs e)
        {
            string nombreRol = txtNombreRol.Text;
            decimal sueldoHora = txtRolSueldo.Value;

            int affectedRows = EmployeeDBManager.AddEmployeeRol(nombreRol, sueldoHora);


            _employeeRols = EmployeeDBManager.GetRols();

            ShowEmployeeRols(_employeeRols);

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            PanelDatosGenerales.Visible = !PanelDatosGenerales.Visible;

            if (_button1Image1IsVisible)
            {
                button6.Image = Transportes_Figueroa.Properties.Resources.down_arrow;
                _button1Image1IsVisible = !_button1Image1IsVisible;
            }
            else
            {
                button6.Image = Transportes_Figueroa.Properties.Resources.right_arrow;
                _button1Image1IsVisible = !_button1Image1IsVisible;
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            PanelDatosUsuario.Visible = !PanelDatosUsuario.Visible;

            if (_button2Image1IsVisible)
            {
                button5.Image = Transportes_Figueroa.Properties.Resources.down_arrow;
                _button2Image1IsVisible = !_button2Image1IsVisible;
            }
            else
            {
                button5.Image = Transportes_Figueroa.Properties.Resources.right_arrow;
                _button2Image1IsVisible = !_button2Image1IsVisible;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PanelRol.Visible = !PanelRol.Visible;

            if (_button3Image1IsVisible)
            {
                button7.Image = Transportes_Figueroa.Properties.Resources.down_arrow;
                _button3Image1IsVisible = !_button3Image1IsVisible;
            }
            else
            {
                button7.Image = Transportes_Figueroa.Properties.Resources.right_arrow;
                _button3Image1IsVisible = !_button3Image1IsVisible;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PanelDireccion.Visible = !PanelDireccion.Visible;

            if (_button4Image1IsVisible)
            {
                button8.Image = Transportes_Figueroa.Properties.Resources.down_arrow;
                _button4Image1IsVisible = !_button4Image1IsVisible;
            }
            else
            {
                button8.Image = Transportes_Figueroa.Properties.Resources.right_arrow;
                _button4Image1IsVisible = !_button4Image1IsVisible;
            }
        }

        private void QuitarSeleccion_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in ListaEmpleados.SelectedItems)
            {
                item.Selected = false;
            }
        }

        private void AgregarFotoEmpleado_Click_1(object sender, EventArgs e)
        {
            var result = ImageHandler.GetImageData();

            _imagen = result.datosBinarios;

            FotoEmpleado.Image = Image.FromFile(result.rutaImagen);
        }

        private void ActualizarEmpleado_Click(object sender, EventArgs e)
        {


            MessageBox.Show(_selectedEmployee.ToString());

            Employee empleado = _employees.FirstOrDefault(employee => employee.Id == _selectedEmployee);
            Guid usuarioID = _users.FirstOrDefault(user => user.Id == empleado.IdUsuario).Id;
            string telefono = txtTelefono.Text;
            string contrasenia = passwordEncryptor.EncryptPassword(txtContrasenia.Text);
            int tipoUsuario = _userTypes[ListaRolesUsuario.SelectedIndex].Id;
            int rolID = _employeeRols[ListaRolesEmpleado.SelectedIndex].Id;
            string departamento = ListaDepartamentos.SelectedItem.ToString();
            string municipio = ListaMunicipios.SelectedItem.ToString();
            string ubicacion = txtUbicacion.Text;
            string calle = txtCalle.Text;
            string codCasa = txtCodCasa.Text;
            string codigoSeguro = txtCodSeguro.Text;

            UserDBManager.ChangeUserPassword(usuarioID, contrasenia);
            UserDBManager.ChangeUserRol(usuarioID, tipoUsuario);

            EmployeeDBManager.UpdateEmployee(
                _selectedEmployee,
                codigoSeguro,
                _imagen,
                telefono,
                departamento,
                municipio,
                calle,
                codCasa,
                ubicacion,
                rolID
            );

            _employees = EmployeeDBManager.GetAllEmployees();
            _users = UserDBManager.GetAllUsers();

            ShowEmployees(_employees);
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
                }

                if (usuario != null)
                {
                    txtCorreo.Text = usuario.Correo;
                    txtContrasenia.Text = passwordEncryptor.DecryptPassword(usuario.Contrasenia);
                    ListaRolesUsuario.SelectedItem = _userTypes.FirstOrDefault(type => type.Id == usuario.TipoUsuarioId).Tipo;
                }

                if (empleado != null)
                {
                    _selectedEmployee = empleado.Id;
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


                txtNombres.Enabled = !isSelected;
                txtApellidoMaterno.Enabled = !isSelected;
                txtApellidoPaterno.Enabled = !isSelected;
                txtDUI.Enabled = !isSelected;
                txtCodAFP.Enabled = !isSelected;
                txtCodSeguro.Enabled = !isSelected;

                txtCorreo.Enabled = !isSelected;

                AgregarEmpleado.Enabled = !isSelected;

                FotoEmpleado.Image = null;
            }
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

        private void AgregarEmpleado_Click(object sender, EventArgs e)
        {
            Guid userID = Guid.NewGuid();
            Guid empleadoID = Guid.NewGuid();
            string contrasenia = passwordEncryptor.EncryptPassword(txtContrasenia.Text);
            string correo = txtCorreo.Text;
            string nombres = txtNombres.Text;
            string apellidoPaterno = txtApellidoPaterno.Text;
            string apellidoMaterno = txtApellidoMaterno.Text;
            string telefono = txtTelefono.Text;
            int rolID = _employeeRols.FirstOrDefault(rol => rol.Nombre == ListaRolesEmpleado.SelectedItem.ToString()).Id;
            string departamento = ListaDepartamentos.SelectedItem.ToString();
            string municipio = ListaMunicipios.SelectedItem.ToString();
            string ubicacion = txtUbicacion.Text;
            string calle = txtCalle.Text;
            string codigoCasa = txtCodCasa.Text;
            string codigoAFP = txtCodAFP.Text;
            string codigoSeguro = txtCodSeguro.Text;
            string duiEmpleado = txtDUI.Text;
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

        private void EliminarRolEmpleado_Click(object sender, EventArgs e)
        {
            // Crear una lista de IDs de registros a eliminar
            List<int> idsToDelete = new List<int>();

            foreach (DataGridViewRow row in DataGridRolesEmpleados.Rows)
            {
                DataGridViewCheckBoxCell checkBox = row.Cells["IDAccionRolEmpleado"] as DataGridViewCheckBoxCell;

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

                if (affectedRows ==  0)
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

        private void DataGridRolesEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0) // Verifica si se hizo clic en una casilla de verificación (columna 0) en una fila válida.
            {
                DataGridViewCheckBoxCell checkboxCell = DataGridRolesEmpleados["IDAccionRolEmpleado", e.RowIndex] as DataGridViewCheckBoxCell;

                if (Convert.ToBoolean(checkboxCell.Value))
                {
                }
                else
                {
                }
            }
        }

        private void ListaEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
