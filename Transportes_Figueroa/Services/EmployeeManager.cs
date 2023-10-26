using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transportes_Figueroa.controllers;
using Transportes_Figueroa.models;
using Transportes_Figueroa.Models;

namespace Transportes_Figueroa.Services
{
    internal class EmployeeManager
    {
        private string connectionString = "Data Source=DESKTOP-NFDMETJ; Initial Catalog=TransportesDB; Integrated Security=true";
        private employeesController EmployeesDataManager = null;

        public EmployeeManager()
        {
            this.EmployeesDataManager = new employeesController(connectionString);
        }

        public List<Employee> GetAllEmployees()
        {
            return this.EmployeesDataManager.GetAll();
        }

        public Employee GetEmployeeById(Guid empleadoID)
        {
            Employee empleado = new Employee();
            if(empleadoID.ToString().Trim().Length < 10)
            {
                MessageBox.Show("");
            }
            else
            {
                empleado = this.EmployeesDataManager.GetById(empleadoID);
            }
            return empleado;
        }
        public Employee GetEmployeeByName(string nombre)
        {
            return EmployeesDataManager.GetByName(nombre);
        }

        public int DeleteEmployee(Guid empleadoID)
        {
            return EmployeesDataManager.Delete(empleadoID);
        }

        public int UpdateEmployee(
            Guid empleadoID,
            string codigoSeguro,
            string imagen,
            string telefono,
            string departamento,
            string municipio,
            string calle,
            string codigoCasa,
            string ubicacion,
            int rolID
        )
        {
            Employee empledoActualizado = new Employee() { 
                Id = empleadoID,
                NumeroTelefonico = telefono,
                CodigoSeguro = codigoSeguro,
                ImagenURL = imagen,
                Departamento = departamento,
                Municipio = municipio,
                Ubicacion = ubicacion,
                Calle = calle,
                CodigoCasa = codigoCasa,
                RolId = rolID
            };

            return EmployeesDataManager.Updete(empledoActualizado);
        }
    }
}
