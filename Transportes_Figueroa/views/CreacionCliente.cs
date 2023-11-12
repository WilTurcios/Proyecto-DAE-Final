using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Transportes_Figueroa.models;
using Transportes_Figueroa.Services;

namespace Transportes_Figueroa.views
{
    public partial class CreacionCliente : Form
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
            // Agregar más departamentos y municipios aquí
        };
        private ClientManager ClientDBManager = new ClientManager();
        private DataTable InfoClientes = new DataTable();
        private List<Client> _clients = new List<Client>();
        public CreacionCliente()
        {
            InitializeComponent();
        }

        private void ShowEmployees(List<Client> clientesDB)
        {
            DataTable clientes = new DataTable();

            clientes.Columns.Clear();
            clientes.Rows.Clear();

            clientes.Columns.Add("id_cliente");
            clientes.Columns.Add("nombres");
            clientes.Columns.Add("apellido_paterno");
            clientes.Columns.Add("apellido_materno");
            clientes.Columns.Add("departamento");
            clientes.Columns.Add("municipio");
            clientes.Columns.Add("ubicacion");
            clientes.Columns.Add("calle");
            clientes.Columns.Add("cod_casa");
            clientes.Columns.Add("telefono");
            clientes.Columns.Add("dui");

            foreach (Client cliente in clientesDB)
            {
                DataRow fila = clientes.NewRow();

                fila["id_cliente"] = cliente.Id;
                fila["nombres"] = cliente.Nombres;
                fila["apellido_paterno"] = cliente.ApellidoPaterno;
                fila["apellido_materno"] = cliente.ApellidoMaterno;
                fila["departamento"] = cliente.Departamento;
                fila["municipio"] = cliente.Municipio;
                fila["ubicacion"] = cliente.Ubicacion;
                fila["calle"] = cliente.Calle;
                fila["cod_casa"] = cliente.CodigoCasa;
                fila["telefono"] = cliente.NumeroTelefonico;
                fila["dui"] = cliente.DUI;

                clientes.Rows.Add(fila);
            }

            dataGridView1.DataSource = clientes;

            dataGridView1.Refresh();
        }

        private void CreacionCliente_Load(object sender, EventArgs e)
        {
            _clients = ClientDBManager.GetAllClients();
            ShowEmployees(_clients);

            foreach (string departamento in municipiosPorDepartamento.Keys)
            {
                ListaDepartamentos.Items.Add(departamento);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Guid empleadoID = Guid.NewGuid();
            string correo = txtCorreo.Text;
            string nombres = txtNombres.Text;
            string apellidoPaterno = txtApellidoPaterno.Text;
            string apellidoMaterno = txtApellidoMaterno.Text;
            string telefono = txtTelefono.Text;
            string departamento = ListaDepartamentos.SelectedItem.ToString();
            string municipio = ListaMunicipios.SelectedItem.ToString();
            string ubicacion = txtUbicacion.Text;
            string calle = txtCalle.Text;
            string codigoCasa = txtCodCasa.Text;
            string duiCliente = txtDUI.Text;

            ClientDBManager.AddClient(
                empleadoID,
                nombres,
                apellidoPaterno,
                apellidoMaterno,
                telefono,
                correo,
                departamento,
                municipio,
                ubicacion,
                calle,
                codigoCasa,
                duiCliente
           );


            _clients = ClientDBManager.GetAllClients();
            ShowEmployees(_clients);

            return;
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

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
