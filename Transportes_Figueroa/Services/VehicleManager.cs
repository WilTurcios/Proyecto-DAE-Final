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
    internal class VehicleManager
    {
        string connectionString = "Data Source=DESKTOP-NFDMETJ; Initial Catalog=TransportesDB; Integrated Security=true";
        vehiclesController VehiclesDataManager = null;

        public VehicleManager(string connectionString)
        {
            VehiclesDataManager = new vehiclesController(connectionString);
        }
    }
}
