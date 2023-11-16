using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Transportes_Figueroa.models;
using Transportes_Figueroa.Services;
using Transportes_Figueroa.Utils;

namespace Transportes_Figueroa.views
{
    public partial class AdministrarClientes : Form
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
        public AdministrarClientes()
        {
            InitializeComponent();
        }

        private void ShowClients(List<Client> clientesDB)
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
            clientes.Columns.Add("correo");

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
                fila["correo"] = cliente.Email;

                clientes.Rows.Add(fila);
            }

            DataGridClientes.DataSource = clientes;

            DataGridClientes.Refresh();
        }

        private void CreacionCliente_Load(object sender, EventArgs e)
        {
            _clients = ClientDBManager.GetAllClients();
            ShowClients(_clients);

            foreach (string departamento in municipiosPorDepartamento.Keys)
            {
                ListaDepartamentos.Items.Add(departamento);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text.Trim();
            if (string.IsNullOrEmpty(correo) || !Validator.IsValidEmail(correo))
            {
                MessageBox.Show("Ingrese un correo electrónico válido.");
                return;
            }

            string nombres = txtNombres.Text.Trim();
            string apellidoPaterno = txtApellidoPaterno.Text.Trim();
            string apellidoMaterno = txtApellidoMaterno.Text.Trim();
            if (string.IsNullOrEmpty(nombres) || string.IsNullOrEmpty(apellidoPaterno) || string.IsNullOrEmpty(apellidoMaterno))
            {
                MessageBox.Show("Ingrese nombres y apellidos válidos.");
                return;
            }

            string telefono = txtTelefono.Text.Trim();
            if (string.IsNullOrEmpty(telefono) || !Validator.IsValidPhoneNumber(telefono))
            {
                MessageBox.Show("Ingrese un número de teléfono válido.");
                return;
            }

            string departamento = ListaDepartamentos.SelectedItem?.ToString().Trim();
            string municipio = ListaMunicipios.SelectedItem?.ToString().Trim();
            if (string.IsNullOrEmpty(departamento) || string.IsNullOrEmpty(municipio))
            {
                MessageBox.Show(
                    "Seleccione un departamento y municipio.",
                    "Departamento o municipio inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            string ubicacion = txtUbicacion.Text;
            string calle = txtCalle.Text;
            string codigoCasa = txtCodCasa.Text;
            string duiCliente = txtDUI.Text;
            if (string.IsNullOrEmpty(ubicacion) || string.IsNullOrEmpty(calle) || string.IsNullOrWhiteSpace(codigoCasa))
            {
                MessageBox.Show(
                    "Ingrese todos los detalles de dirección.",
                    "Detalles de dirección inválidos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            if (!Validator.IsValidDUI(duiCliente))
            {
                MessageBox.Show(
                    "Ingrese un DUI válido.",
                    "DUI inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                 );
                return;
            }
            
            Guid empleadoID = Guid.NewGuid();

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
            ShowClients(_clients);

            return;
        }

        private void ListaDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListaMunicipios.Items.Clear();
            ListaMunicipios.SelectedIndex = -1;

            if (ListaDepartamentos.SelectedIndex == -1) return;

            string departamento = ListaDepartamentos.SelectedItem.ToString();

            foreach (string municipio in municipiosPorDepartamento[departamento])
            {
                ListaMunicipios.Items.Add(municipio);
            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            bool alMenosUnaCeldaSeleccionada = false;

            // Eliminar un vehiculo
            foreach (DataGridViewRow row in DataGridClientes.Rows)
            {
                DataGridViewCheckBoxCell cell = row.Cells["IDAccion"] as DataGridViewCheckBoxCell;

                if (cell != null)
                {
                    bool isChecked = (bool)cell.EditedFormattedValue;

                    if (isChecked)
                    {
                        alMenosUnaCeldaSeleccionada = true;



                        if (row.Cells["ID"].Value != null && Guid.TryParse(row.Cells["ID"].Value.ToString(), out Guid vehiculoID))
                        {
                            if (MessageBox.Show("¿Está seguro de que desea eliminar el cliente seleccionado?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                ClientDBManager.DeleteClient(vehiculoID);

                                _clients = ClientDBManager.GetAllClients();

                                ShowClients(_clients);
                            }
                        }
                    }
                }
            }

            if (!alMenosUnaCeldaSeleccionada)
            {
                MessageBox.Show("Seleccione al menos una celda antes de eliminar un cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            int selectedRows = 0;
            string telefono = txtTelefono.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            MessageBox.Show(correo);
            string departamento = ListaDepartamentos.SelectedItem?.ToString();
            string municipio = ListaMunicipios.SelectedItem?.ToString();
            string ubicacion = txtUbicacion.Text.Trim();
            string calle = txtCalle.Text.Trim();
            string codigoCasa = txtCodCasa.Text.Trim();

            Guid clienteID = Guid.Empty;

            foreach (DataGridViewRow row in DataGridClientes.Rows)
            {
                DataGridViewCheckBoxCell cell = row.Cells["IDAccion"] as DataGridViewCheckBoxCell;

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

                        if (row.Cells["ID"].Value != null)
                        {
                            if (Guid.TryParse(row.Cells["ID"].Value.ToString(), out clienteID))
                            {
                                break;
                            }
                            else
                            {
                                MessageBox.Show("El ID del cliente no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                }
            }

            if (!Validator.IsValidPhoneNumber(telefono))
            {
                MessageBox.Show("Asegurate de insertar un número telefónico válido.", "Teléfono inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Validator.IsValidEmail(correo))
            {
                MessageBox.Show("Asegurate de insertar un correo electrónico válido", "Email inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(departamento) || string.IsNullOrEmpty(municipio) || string.IsNullOrEmpty(ubicacion) || string.IsNullOrEmpty(calle) || string.IsNullOrEmpty(codigoCasa))
            {
                MessageBox.Show("Todos los campos de dirección son obligatorios.\n Asegurate de llenarlos correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            if (selectedRows == 0)
            {
                MessageBox.Show("Selecciona al menos un registro para actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int affectedRows = 0;
            Client cliente = _clients.FirstOrDefault(client => client.Id == clienteID);

            if (cliente != null)
            {
                affectedRows = ClientDBManager.UpdateClient(
                        cliente.Id,
                        telefono,
                        correo,
                        cliente.DireccionId,
                        departamento,
                        municipio,
                        ubicacion,
                        calle,
                        codigoCasa
                    );
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error al actualizar el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (affectedRows == 0)
            {
                MessageBox.Show("No se ha actualizado ningún registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show($"Se ha actualizado {affectedRows} registros.", "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
            _clients = ClientDBManager.GetAllClients();

            ShowClients(_clients);
        }

        private void DataGridClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DataGridClientes.Columns["IDAccion"].Index && e.RowIndex >= 0)
            {
                // Desmarcar todas las demás filas excepto la seleccionada
                foreach (DataGridViewRow row in DataGridClientes.Rows)
                {
                    if (row.Index != e.RowIndex)
                    {
                        DataGridViewCheckBoxCell celda = row.Cells["IDAccion"] as DataGridViewCheckBoxCell;

                        if (celda != null && (bool)celda.EditedFormattedValue)
                        {
                            celda.Value = false;
                        }
                    }
                }

                DataGridViewRow selectedRow = DataGridClientes.Rows[e.RowIndex];
                DataGridViewCheckBoxCell cell = selectedRow.Cells["IDAccion"] as DataGridViewCheckBoxCell;

                if (cell != null)
                {
                    bool isChecked = (bool)cell.EditedFormattedValue;

                    // Habilitar o deshabilitar los controles según la casilla de verificación marcada
                    txtNombres.Enabled = !isChecked;
                    txtApellidoMaterno.Enabled = !isChecked;
                    txtApellidoPaterno.Enabled = !isChecked;
                    txtDUI.Enabled = !isChecked;

                    if (isChecked)
                    {
                        // Si la casilla está marcada, se reflejan los datos de la fila seleccionada en los controles.

                        txtNombres.Text = selectedRow.Cells["Nombres"].Value.ToString();
                        txtApellidoMaterno.Text = selectedRow.Cells["ApellidoMaterno"].Value.ToString();
                        txtApellidoPaterno.Text = selectedRow.Cells["ApellidoPaterno"].Value.ToString();
                        txtDUI.Text = selectedRow.Cells["DUI"].Value.ToString();
                        txtUbicacion.Text = selectedRow.Cells["Ubicacion"].Value.ToString();
                        txtCalle.Text = selectedRow.Cells["Calle"].Value.ToString();
                        txtTelefono.Text = selectedRow.Cells["Telefono"].Value.ToString();
                        txtCorreo.Text = selectedRow.Cells["Correo"].Value.ToString();
                        txtCodCasa.Text = selectedRow.Cells["CodigoCasa"].Value.ToString();
                        ListaDepartamentos.SelectedItem = selectedRow.Cells["Departamento"].Value.ToString();
                        ListaMunicipios.SelectedItem = selectedRow.Cells["Municipio"].Value.ToString();

                    }
                    else
                    {
                        // Si la casilla no está marcada, se ponen los valores predeterminados en los controles.
                        txtNombres.Text = string.Empty;
                        txtApellidoMaterno.Text = string.Empty;
                        txtApellidoPaterno.Text = string.Empty;
                        txtDUI.Text = string.Empty;
                        txtUbicacion.Text = string.Empty;
                        txtCalle.Text = string.Empty;
                        txtTelefono.Text = string.Empty;
                        txtCorreo.Text = string.Empty;
                        txtCodCasa.Text = string.Empty;
                        ListaDepartamentos.SelectedIndex = -1 ;
                        ListaMunicipios.SelectedIndex = -1;

                        // Borra o reinicia otros controles según las necesidades.
                    }
                }
            }
        }
    }
}
