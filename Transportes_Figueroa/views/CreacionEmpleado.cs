﻿using System;
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
    public partial class CreacionEmpleado : Form
    { 
        private Dictionary<int, string> _roles = new Dictionary<int,string>();
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
            // Agregar más departamentos y municipios aquí
        };
        private UserManager UserDBManager = new UserManager();
        private EmployeeManager EmployeeDBManager = new EmployeeManager();
        private DataTable InfoEmpleados = new DataTable();
        private List<Employee> _employees = new List<Employee>();
        

        public CreacionEmpleado()
        {
            InitializeComponent();
        }

        private DataTable CargarEmpleados(List<Employee> empleadosDB)
        {
            DataTable empleados = new DataTable();

            empleados.Columns.Add("id_empleado");
            empleados.Columns.Add("nombres");
            empleados.Columns.Add("apellido_paterno");
            empleados.Columns.Add("apellido_materno");
            empleados.Columns.Add("cod_afp");
            empleados.Columns.Add("cod_seguro");
            empleados.Columns.Add("departamento");
            empleados.Columns.Add("municipio");
            empleados.Columns.Add("ubicacion");
            empleados.Columns.Add("calle");
            empleados.Columns.Add("cod_casa");
            empleados.Columns.Add("telefono");
            empleados.Columns.Add("rol");
            empleados.Columns.Add("id_usuario");

            foreach (Employee empleado in empleadosDB)
            {
                DataRow fila = empleados.NewRow();

                fila["id_empleado"] = empleado.Id;
                fila["nombres"] = empleado.Nombres;
                fila["apellido_paterno"] = empleado.ApellidoPaterno;
                fila["apellido_materno"] = empleado.ApellidoMaterno;
                fila["cod_afp"] = empleado.CodigoAFP;
                fila["cod_seguro"] = empleado.CodigoSeguro;
                fila["departamento"] = empleado.Departamento;
                fila["municipio"] = empleado.Municipio;
                fila["ubicacion"] = empleado.Ubicacion;
                fila["calle"] = empleado.Calle;
                fila["cod_casa"] = empleado.CodigoCasa;
                fila["telefono"] = empleado.NumeroTelefonico;

                // Obtener el rol correspondiente desde _roles (suponiendo que _roles es un diccionario)
                if (_roles.TryGetValue(empleado.RolId, out string rolNombre))
                {
                    fila["rol"] = rolNombre;
                }
                else
                {
                    fila["rol"] = string.Empty; // Otra acción si el rol no se encuentra
                }

                fila["id_usuario"] = empleado.IdUsuario;
                empleados.Rows.Add(fila);
            }

            return empleados;
        }

        private void CreacionEmpleado_Load(object sender, EventArgs e)
        {
            _employees = EmployeeDBManager.GetAllEmployees();

            // Si _roles no se ha inicializado previamente como un diccionario, inicialízalo
            if (_roles == null)
            {
                _roles = new Dictionary<int, string>(); // Suponiendo que el valor clave de rol sea de tipo int
            }

            foreach (Rol rol in EmployeeDBManager.GetRols())
            {
                if (!_roles.ContainsKey(rol.Id))
                {
                    _roles[rol.Id] = rol.Nombre;
                    ListaRoles.Items.Add(rol.Nombre);
                }
            }

            dataGridView1.DataSource = CargarEmpleados(_employees);
            dataGridView1.Refresh();

            foreach (string departamento in municipiosPorDepartamento.Keys)
            {
                ListaDepartamentos.Items.Add(departamento);
            }

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Guid userID = Guid.NewGuid();
            Guid empleadoID = Guid.NewGuid();
            string contrasenia = txtContrasenia.Text;
            string correo = txtCorreo.Text;
            string nombres = txtNombres.Text;
            string apellidoPaterno = txtApellidoPaterno.Text;
            string apellidoMaterno = txtApellidoMaterno.Text;
            string telefono = txtTelefono.Text;
            int rolID = _roles.FirstOrDefault(kv => kv.Value == ListaRoles.SelectedItem.ToString()).Key;
            string departamento = ListaDepartamentos.SelectedItem.ToString();
            string municipio = ListaMunicipios.SelectedItem.ToString();
            string ubicacion = txtUbicacion.Text;
            string calle = txtCalle.Text;
            string codigoCasa = txtCodCasa.Text;
            string codigoAFP = txtCodAFP.Text;
            string codigoSeguro = txtCodSeguro.Text;
            byte[] imagen = new byte[5];


            UserDBManager.AddUser(userID, correo, contrasenia);

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
                rolID 
           );

            InfoEmpleados.Columns.Clear();
            _employees = EmployeeDBManager.GetAllEmployees();
            dataGridView1.DataSource = CargarEmpleados(_employees);
        }

        private void ListaDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListaMunicipios.Items.Clear();

            string departamento = ListaDepartamentos.SelectedItem.ToString();

            foreach (string municipio in municipiosPorDepartamento[departamento])
            {
                ListaMunicipios.Items.Add(municipio);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
