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

        public List<Rol> GetRols()
        {
            return EmployeesDataManager.GetRoles();
        }

        public int AddEmployee(
            Guid empleadoID,
            string nombres,
            string apellidoPaterno, 
            string apellidoMaterno,
            string telefono,
            string codigoAFP,
            string codigoSeguro,
            byte[] imagen,
            string departamento,
            string municipio,
            string ubicacion,
            string calle,
            string codigoCasa,
            Guid usuarioID,
            int rolID,
            string duiEmpleado
        )
        {
            Employee employee = new Employee()
            {
                Id = empleadoID,
                Nombres = nombres,
                ApellidoMaterno = apellidoMaterno,
                ApellidoPaterno = apellidoPaterno,
                NumeroTelefonico = telefono,
                CodigoAFP = codigoAFP,
                CodigoSeguro = codigoSeguro,
                Imagen = imagen,
                Departamento = departamento,
                Municipio = municipio,
                Ubicacion = ubicacion,
                Calle = calle,
                CodigoCasa = codigoCasa,
                IdUsuario = usuarioID,
                RolId = rolID,
                DUI = duiEmpleado
            };

            return EmployeesDataManager.Add(employee);
        }

        public int AddEmployeeRol(string nombreRol, decimal sueldoHora)
        {
            Rol rol = new Rol()
            {
                SueldoHora = sueldoHora,
                Nombre = nombreRol
            };

            return EmployeesDataManager.AddRol(rol);
        }

        public int UpdateEmployeeRol(int rolID, decimal sueldoHora)
        {
            Rol rol = new Rol()
            {
                SueldoHora = sueldoHora,
                Id = rolID
            };

            return EmployeesDataManager.UpdateRol(rol);
        }

        public int DeleteEmployeeRol(int rolID)
        {

            return EmployeesDataManager.DeleteRol(rolID);
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
            byte[] imagen,
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
                Imagen = imagen,
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
