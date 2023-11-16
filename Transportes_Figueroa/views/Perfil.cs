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
    public partial class Perfil : Form
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
        private Employee _employee = new Employee();
        private List<Rol> _employeeRols = new List<Rol>();
        private User _user = new User();
        private byte[] _imagen;
        private EmployeeManager EmployeesDB = new EmployeeManager();
        private PasswordEncryptor passwordEncryptor = new PasswordEncryptor("M1$Gz@jRq9T#pK&3wFvS!xU4nW8zZ*Cb");

        public Perfil(Employee employee, User user)
        {
            InitializeComponent();
            this._employee = employee;
            this._user = user;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void Configuracion_Load(object sender, EventArgs e)
        {
            _employeeRols = EmployeesDB.GetRols();
            FotoEmpleado.Image = ImageHandler.ConvertToImage(_employee.Imagen);


            ListaDepartamentos.Items.AddRange(municipiosPorDepartamento.Keys.ToArray());

            foreach (Rol rol in _employeeRols)
            {
                ListaRolesEmpleado.Items.Add(rol.Nombre);

            }

            txtNombre.Text = $"{_employee.Nombres} {_employee.ApellidoPaterno} {_employee.ApellidoMaterno}";
            txtDUI.Text = _employee.DUI;
            txtTelefono.Text = _employee.NumeroTelefonico;
            txtContrasenia.Text = passwordEncryptor.DecryptPassword(_user.Contrasenia);
            txtCorreo.Text = _user.Correo;
            txtUbicacion.Text = _employee.Ubicacion;
            txtCalle.Text = _employee.Calle;
            txtCodCasa.Text = _employee.CodigoCasa;
            ListaDepartamentos.SelectedItem = _employee.Departamento;
            ListaMunicipios.SelectedItem = _employee.Municipio;
            ListaRolesEmpleado.SelectedItem = _employeeRols.FirstOrDefault(r => r.Id == _employee.RolId).Nombre;
            

            txtNombre.Enabled = false;
            txtDUI.Enabled = false;
            txtCorreo.Enabled = false;
            txtContrasenia.Enabled = false;
            ListaRolesEmpleado.Enabled = false;


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

        private void CambiarFoto_Click(object sender, EventArgs e)
        {
            var result = ImageHandler.GetImageData();

            _imagen = result.datosBinarios;
            FotoEmpleado.Image = Image.FromFile(result.rutaImagen);

        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            byte[] imagen;

            string telefono = txtTelefono.Text;

            if (Validator.IsValidPhoneNumber(telefono))
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

            if (_imagen != null && _imagen.Length > 0)
            {
                imagen = _imagen;
            }
            else
            {
                imagen = _employee.Imagen;
            }

            int affectedRows = EmployeesDB.UpdateEmployee(
                                    _employee.Id,
                                    _employee.CodigoSeguro,
                                    imagen,
                                    telefono,
                                    departamento,
                                    municipio,
                                    calle, 
                                    codigoCasa,
                                    ubicacion,
                                    _employee.RolId
                               );

            if(affectedRows > 0)
            {
                MessageBox.Show(
                    "Tu perfil ha sido actualizado con éxito.",
                    "Perfil actualizado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                return;
            }
            else
            {
                MessageBox.Show(
                    "Ha ocurrido un error al actualizar el perfil, por favor intentalo de nuevo.",
                    "Error al actualizar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // cambiar la contraseña de usuario 

            CambiarContrasenia changePasswordForm = new CambiarContrasenia(_user);

            changePasswordForm.Show();

            txtContrasenia.Text = changePasswordForm._newPassword;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
