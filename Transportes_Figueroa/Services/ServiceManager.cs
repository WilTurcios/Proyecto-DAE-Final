using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportes_Figueroa.Controllers;
using Transportes_Figueroa.Models;

namespace Transportes_Figueroa.Services
{
    internal class ServiceManager
    {
        private string connectionString = "Data Source=DESKTOP-NFDMETJ; Initial Catalog=TransportesDB; Integrated Security=true";

        private servicesController ServicesDataManager = null;
        private invoicesController InvoicesDataManager = null;

        public ServiceManager()
        {
            ServicesDataManager = new servicesController(connectionString);
            InvoicesDataManager = new invoicesController(connectionString);
        }

        public List<Service> GetAllServices()
        {
            return ServicesDataManager.GetAll();
        }

        public List<Service> GetAllServicesByClientId(Guid clientID)
        {
            return ServicesDataManager.GetAllServicesByClientId(clientID);
        }

        public List<ServiceType> GetAllServiceTypes()
        {
            return ServicesDataManager.GetAllServiceTypes();
        }


        public int AddService(
            DateTime fechaSolicitud,
            DateTime fechaDevolucion, 
            double valorMedido, 
            int tipoServicioID,
            int vehiculoID, 
            Guid clienteID,
            int? conductorID = null
        )
        {

            Service servicio = new Service()
            {
                FechaSolicitud = fechaSolicitud,
                FechaDevolucion = fechaDevolucion,
                ValorMedido = valorMedido,
                TipoServicioId = tipoServicioID,
                VehiculoId = vehiculoID,
                ClienteId = clienteID,
                ConductorID = conductorID
            };
            return ServicesDataManager.Add(servicio);
        }


        public int DeleteService(int servicioID)
        {
            return ServicesDataManager.Delete(servicioID);
        }

        public int ChangeServiceState(string nuevoEstado, int servicioID)
        {
            return ServicesDataManager.ChangeState(nuevoEstado, servicioID);
        }

        public List<Invoice> GetAllInvoices()
        {
            return InvoicesDataManager.GetAll();
        }

        public List<Invoice> GetAllInvoicesByClientId(Guid clientID)
        {
            return InvoicesDataManager.GetInvoicesByClientId(clientID);
        }

        public int GenerateInvoice(int servicioID, Guid empleadoID)
        {
            Invoice invoice = new Invoice() { ServicioId = servicioID, EmpleadoId=empleadoID };
            return InvoicesDataManager.Add(invoice);
        }


    }
}
