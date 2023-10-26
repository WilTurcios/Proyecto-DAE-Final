using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportes_Figueroa.models;
using Microsoft.SqlServer.Server;
using System.Windows.Forms;
using Transportes_Figueroa.Models;
using System.Security.Permissions;

namespace Transportes_Figueroa.controllers
{
    internal class employeesController
    {

        SqlConnection connection = new SqlConnection();
        public employeesController(string connectionString)
        {
            connection.ConnectionString = connectionString;
        }

        private void OpenConnection()
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
        }

        private void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public List<Employee> GetAll()
        {
            List<Employee> employees = new List<Employee>();
            DataTable employeesFromDB = new DataTable();

            try
            {
                OpenConnection();
                string query = $"SELECT * FROM empleados E INNER JOIN direcciones D ON E.id_direccion = D.id_direccion INNER JOIN roles R ON E.id_rol = R.id_rol;";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(employeesFromDB);

                    foreach (DataRow employeeFromDB in employeesFromDB.Rows)
                    {
                        User usuarioDeEmpleado = new User();
                        Employee employee = new Employee();
                        employee.Id = (Guid)employeeFromDB["id_empleado"]; // A esta técnica de parseo se le llama CASTING
                        employee.Nombres = (string)employeeFromDB["nombres"];
                        employee.ApellidoPaterno = (string)employeeFromDB["apellido_paterno"];
                        employee.ApellidoMaterno = (string)employeeFromDB["apellido_materno"];
                        employee.NumeroTelefonico = (string)employeeFromDB["telefono"];
                        employee.DireccionId = (int)employeeFromDB["id_direccion"];
                        employee.Calle = (string)employeeFromDB["calle"];
                        employee.Departamento = (string)employeeFromDB["departamento"];
                        employee.Municipio = (string)employeeFromDB["municipio"];
                        employee.Ubicacion = (string)employeeFromDB["ubicacion"];
                        employee.CodigoCasa = (string)employeeFromDB["cod_casa"];
                        employee.CodigoAFP = (string)employeeFromDB["cod_AFP"];
                        employee.CodigoSeguro = (string)employeeFromDB["cod_seguro"];
                        employee.ImagenURL = (string)employeeFromDB["img_URL"];
                        employee.CodigoAFP = (string)employeeFromDB["nombre_rol"];
                        employee.CodigoAFP = (string)employeeFromDB["cod_AFP"];

                        employees.Add(employee);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                CloseConnection();
            }

            return employees;
        }

        public int Add(Employee employee)
        {
            int affectedRows = 0;
            try
            {
                OpenConnection();
                using (SqlCommand command = new SqlCommand("InsertarEmpleado", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@EmpleadoID", employee.Id);
                    command.Parameters.AddWithValue("@NombresEmpleado", employee.Nombres);
                    command.Parameters.AddWithValue("@ApelldioMaterno", employee.ApellidoMaterno);
                    command.Parameters.AddWithValue("@ApelldioPaterno", employee.ApellidoPaterno);
                    command.Parameters.AddWithValue("@TelefonoEmpleado", employee.NumeroTelefonico);
                    command.Parameters.AddWithValue("@CodigoAFP", employee.CodigoAFP);
                    command.Parameters.AddWithValue("@CodigoSeguro", employee.CodigoSeguro);
                    command.Parameters.AddWithValue("@ImagenURL", employee.ImagenURL);
                    command.Parameters.AddWithValue("@DepartamentoDireccion", employee.Departamento);
                    command.Parameters.AddWithValue("@MunicipioDireccion", employee.Municipio);
                    command.Parameters.AddWithValue("@UbicacionDireccion", employee.Ubicacion);
                    command.Parameters.AddWithValue("@CalleDireccion", employee.Calle);
                    command.Parameters.AddWithValue("@CodigoCasa", employee.CodigoCasa);
                    command.Parameters.AddWithValue("@UsuarioID", employee.IdUsuario);
                    command.Parameters.AddWithValue("@RolID", employee.RolId);

                    affectedRows = command.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                CloseConnection();
            }

            return affectedRows;
        }

        public Employee GetById(Guid employeeID)
        {
            Employee employee = new Employee();
            DataTable employeeFromDB = new DataTable();

            try
            {
                OpenConnection();

                string query = $"SELECT * FROM empleados E INNER JOIN direcciones D ON E.id_direccion = D.id_direccion INNER JOIN roles R ON E.id_rol = R.id_rol WHERE E.id_cliente = @EmployeeID;";
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@EmployeeID", employeeID);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(employeeFromDB);

                        foreach (DataRow infoEmpleado in employeeFromDB.Rows)
                        {
                            employee.Id = (Guid)infoEmpleado["id_empleado"];
                            employee.IdUsuario = (Guid)infoEmpleado["id_usuario"];
                            employee.RolId = (int)infoEmpleado["id_rol"];
                            employee.CodigoAFP = (string)infoEmpleado["cod_AFP"];
                            employee.CodigoSeguro = (string)infoEmpleado["cod_seguro"];
                            employee.CodigoSeguro = (string)infoEmpleado["img_URL"];
                            employee.Nombres = (string)infoEmpleado["nombres"];
                            employee.ApellidoPaterno = (string)infoEmpleado["apellido_paterno"];
                            employee.ApellidoMaterno = (string)infoEmpleado["apellido_materno"];
                            employee.NumeroTelefonico = (string)infoEmpleado["telefono_cliente"];
                            employee.DireccionId = (int)infoEmpleado["id_direccion"];
                            employee.Departamento = (string)infoEmpleado["departamento"];
                            employee.Municipio = (string)infoEmpleado["municipio"];
                            employee.Calle = (string)infoEmpleado["calle"];
                            employee.Ubicacion = (string)infoEmpleado["ubicacion"];
                            employee.CodigoCasa = (string)infoEmpleado["cod_casa"];

                        }
                    }
                }
            }
            catch
            {
                CloseConnection();
            }

            return employee;
        }

        public Employee GetByName(string name)
        {
            Employee employee = new Employee();
            DataTable employeeFromDB = new DataTable();

            try
            {
                OpenConnection();

                string query = $"SELECT * FROM empleados E INNER JOIN direcciones D ON E.id_direccion = D.id_direccion INNER JOIN roles R ON E.id_rol = R.id_rol WHERE E.nombres LIKE @Name OR E.apellido_paterno LIKE @Name OR E.apellido_materno LIKE @Name ;";
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@Name", "'%" + name + "%'");

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(employeeFromDB);

                        foreach (DataRow infoEmpleado in employeeFromDB.Rows)
                        {
                            employee.Id = (Guid)infoEmpleado["id_empleado"];
                            employee.IdUsuario = (Guid)infoEmpleado["id_usuario"];
                            employee.RolId = (int)infoEmpleado["id_rol"];
                            employee.CodigoAFP = (string)infoEmpleado["cod_AFP"];
                            employee.CodigoSeguro = (string)infoEmpleado["cod_seguro"];
                            employee.CodigoSeguro = (string)infoEmpleado["img_URL"];
                            employee.Nombres = (string)infoEmpleado["nombres"];
                            employee.ApellidoPaterno = (string)infoEmpleado["apellido_paterno"];
                            employee.ApellidoMaterno = (string)infoEmpleado["apellido_materno"];
                            employee.NumeroTelefonico = (string)infoEmpleado["telefono_cliente"];
                            employee.DireccionId = (int)infoEmpleado["id_direccion"];
                            employee.Departamento = (string)infoEmpleado["departamento"];
                            employee.Municipio = (string)infoEmpleado["municipio"];
                            employee.Calle = (string)infoEmpleado["calle"];
                            employee.Ubicacion = (string)infoEmpleado["ubicacion"];
                            employee.CodigoCasa = (string)infoEmpleado["cod_casa"];
                        }
                    }
                }
            }
            catch
            {
                CloseConnection();
            }

            return employee;
        }

        public int Delete(Guid employeeID)
        {
            int affectedRows = 0;
            try
            {
                OpenConnection();
                string query = "DELETE FROM empleados WHERE id_empleado = @EmployeeID;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EmployeeID", employeeID);
                    affectedRows = command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Excepción: {ex.Message}");
            }
            finally
            {
                CloseConnection();
            }
            return affectedRows;
        }

        public int Updete(Employee employee)
        {
            int affectedRows = 0;
            try
            {
                OpenConnection();
                using (SqlCommand command = new SqlCommand("ActualizarEmpleado", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@EmpleadoID", employee.Id);
                    command.Parameters.AddWithValue("@TelefonoEmpleado", employee.NumeroTelefonico);
                    command.Parameters.AddWithValue("@CodigoSeguro", employee.CodigoSeguro);
                    command.Parameters.AddWithValue("@ImagenURL", employee.ImagenURL);
                    command.Parameters.AddWithValue("@DepartamentoDireccion", employee.Departamento);
                    command.Parameters.AddWithValue("@MunicipioDireccion", employee.Municipio);
                    command.Parameters.AddWithValue("@UbicacionDireccion", employee.Ubicacion);
                    command.Parameters.AddWithValue("@CalleDireccion", employee.Calle);
                    command.Parameters.AddWithValue("@CodigoCasa", employee.CodigoCasa);
                    command.Parameters.AddWithValue("@RolID", employee.RolId);

                    affectedRows = command.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ha ocurrido una excepción: {ex.Message}");
            }
            finally
            {
                CloseConnection();
            }

            return affectedRows;
        }

        public List<Rol> GetRoles()
        {
            List<Rol> roles = new List<Rol>();
            try
            {
                OpenConnection();

                DataTable rolesFromDB = new DataTable();
                string query = "SELECT * FROM roles;";

                using(SqlCommand command = new SqlCommand(query, connection))
                using(SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(rolesFromDB);

                    foreach(DataRow rolFromDB in rolesFromDB.Rows)
                    {
                        Rol rol = new Rol();

                        rol.Id = (int)rolFromDB["id_rol"];
                        rol.Nombre = (string)rolFromDB["nombre_rol"];
                        rol.SueldoHora = (double)rolFromDB["sueldo_hora"];

                        roles.Add(rol);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return roles;
        } 

        public int AddRol(Rol rol)
        {
            string query = "insert into roles (nombre_rol, sueldo_hora) values (@Rol, @SueldoHora); SELECT SCOPE_IDENTITY();";

            using (SqlCommand command = new SqlCommand(query, connection))
            {

                command.Parameters.AddWithValue("@Rol", rol.Nombre);
                command.Parameters.AddWithValue("@SueldoHora", rol.SueldoHora);

                return (int)command.ExecuteScalar();
            }
        }
    }
}
