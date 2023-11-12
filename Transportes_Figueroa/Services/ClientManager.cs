using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transportes_Figueroa.controllers;
using Transportes_Figueroa.models;

namespace Transportes_Figueroa.Services
{
    internal class ClientManager
    {
        string connectionString = "Data Source=DESKTOP-NFDMETJ; Initial Catalog=TransportesDB; Integrated Security=true";
        clientsController ClientsDataManager = null; 

        public ClientManager()
        {
            ClientsDataManager = new clientsController(connectionString);
        }

        public List<Client> GetAllClients()
        {
            return ClientsDataManager.GetAll();
        }

        public Client GetClientById(Guid clientID)
        {
            return ClientsDataManager.GetById(clientID);
        }

        public Client GetClientByName(string name)
        {
            return ClientsDataManager.GetByName(name);
        }


        public int AddClient(
            Guid clienteID,
            string nombres,
            string apellidoPaterno, 
            string apellidoMatero,
            string telefono, 
            string correo, 
            string departamento,
            string municipio,
            string ubicacion, 
            string calle, 
            string codigoCasa,
            string duiCliente
        )
        {
            Client cliente = new Client() {
                Id = clienteID,
                Nombres = nombres,
                ApellidoPaterno = apellidoPaterno,
                ApellidoMaterno = apellidoMatero,
                NumeroTelefonico = telefono,
                Email = correo,
                Departamento = departamento,
                Municipio = municipio,
                Ubicacion = ubicacion,
                Calle = calle,
                CodigoCasa = codigoCasa,
                DUI = duiCliente
            };

            return ClientsDataManager.Add(cliente);
        }

        public int UpdateClient(
            Guid clienteID,
            string telefono,
            string correo,
            int direccionID,
            string departamento,
            string municipio, 
            string ubicacion,
            string calle,
            string codigoCasa
        )
        {
            Client cliente = new Client()
            {
                Id = clienteID,
                NumeroTelefonico = telefono,
                Email = correo,
                DireccionId = direccionID,
                Departamento = departamento,
                Municipio = municipio,
                Ubicacion = ubicacion,
                Calle = calle,
                CodigoCasa = codigoCasa
            };

            return ClientsDataManager.Add(cliente);
        }
    }
}
