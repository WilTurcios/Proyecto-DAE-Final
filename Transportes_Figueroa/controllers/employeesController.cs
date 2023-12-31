﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Transportes_Figueroa.models;
using Transportes_Figueroa.Models;

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
                string query = $"SELECT * FROM empleados E INNER JOIN roles R ON E.id_rol = R.id_rol;";

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
                        employee.Calle = (string)employeeFromDB["calle"];
                        employee.Departamento = (string)employeeFromDB["departamento"];
                        employee.Municipio = (string)employeeFromDB["municipio"];
                        employee.Ubicacion = (string)employeeFromDB["ubicacion"];
                        employee.CodigoCasa = (string)employeeFromDB["cod_casa"];
                        employee.CodigoAFP = (string)employeeFromDB["cod_AFP"];
                        employee.CodigoSeguro = (string)employeeFromDB["cod_seguro"];
                        employee.Imagen = (byte[])employeeFromDB["imagen"];
                        employee.CodigoAFP = (string)employeeFromDB["nombre_rol"];
                        employee.CodigoAFP = (string)employeeFromDB["cod_AFP"];
                        employee.IdUsuario = (Guid)employeeFromDB["id_usuario"];
                        employee.RolId = (int)employeeFromDB["id_rol"];
                        employee.DUI = (string)employeeFromDB["dui_empleado"];

                        employees.Add(employee);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al recuperar los empleados: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return employees;
        }

        public List<Driver> GetAllDrivers()
        {
            List<Driver> drivers = new List<Driver>();

            try
            {
                OpenConnection();
                string query = "SELECT * FROM conductores";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        Driver driver = new Driver();
                        driver.Id = (int)reader["id_conductor"]; // A esta técnica de parseo se le llama CASTING
                        driver.EmpleadoID = (Guid)reader["id_empleado"];
                        driver.Disponibilidad = (string)reader["disponibilidad"];

                        drivers.Add(driver);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al obtener los conductores: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return drivers;
        }

        public int ChangeDriverAvailability(int driverID, string availability)
        {
            try
            {
                OpenConnection();

                string query = "update conductores set disponibilidad = @Disponibilidad where id_conductor = @ConductorID;";
                using(SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ConductorID", driverID);
                    cmd.Parameters.AddWithValue("@Disponibilidad", availability);

                    return cmd.ExecuteNonQuery();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al cambiar la disponibilidad del conductor: " + ex.Message);
                return 0;
            }
            finally
            {
                CloseConnection();
            }
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
                    command.Parameters.AddWithValue("@ApellidoMaterno", employee.ApellidoMaterno);
                    command.Parameters.AddWithValue("@ApellidoPaterno", employee.ApellidoPaterno);
                    command.Parameters.AddWithValue("@TelefonoEmpleado", employee.NumeroTelefonico);
                    command.Parameters.AddWithValue("@CodigoAFP", employee.CodigoAFP);
                    command.Parameters.AddWithValue("@CodigoSeguro", employee.CodigoSeguro);
                    command.Parameters.AddWithValue("@Imagen", employee.Imagen);
                    command.Parameters.AddWithValue("@Departamento", employee.Departamento);
                    command.Parameters.AddWithValue("@Municipio", employee.Municipio);
                    command.Parameters.AddWithValue("@Ubicacion", employee.Ubicacion);
                    command.Parameters.AddWithValue("@Calle", employee.Calle);
                    command.Parameters.AddWithValue("@CodigoCasa", employee.CodigoCasa);
                    command.Parameters.AddWithValue("@UsuarioID", employee.IdUsuario);
                    command.Parameters.AddWithValue("@RolID", employee.RolId);
                    command.Parameters.AddWithValue("@DuiEmpleado", employee.DUI);

                    affectedRows = command.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar empleado: " + ex.Message);
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

                string query = $"SELECT * FROM empleados E INNER JOIN roles R ON E.id_rol = R.id_rol WHERE E.id_cliente = @EmployeeID;";
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
                            employee.Imagen = (byte[])infoEmpleado["imagen"];
                            employee.Nombres = (string)infoEmpleado["nombres"];
                            employee.ApellidoPaterno = (string)infoEmpleado["apellido_paterno"];
                            employee.ApellidoMaterno = (string)infoEmpleado["apellido_materno"];
                            employee.NumeroTelefonico = (string)infoEmpleado["telefono_cliente"];
                            employee.Departamento = (string)infoEmpleado["departamento"];
                            employee.Municipio = (string)infoEmpleado["municipio"];
                            employee.Calle = (string)infoEmpleado["calle"];
                            employee.Ubicacion = (string)infoEmpleado["ubicacion"];
                            employee.CodigoCasa = (string)infoEmpleado["cod_casa"];
                            employee.DUI = (string)infoEmpleado["dui_empleado"];

                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocurrio un error al obtener el empleado por ID: " + ex.Message);
            }
            finally
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
                MessageBox.Show(
                    $"Ocurrió un error al eliminar el empleado: \n\n" +
                    $"El empleado tiene servicios relacionados a el, por lo que no puede ser eliminado\n" +
                    $"Para poder eliminarlo se deben eliminar los servicios relacionados a él."
                );
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
                    command.Parameters.AddWithValue("@Imagen", employee.Imagen);
                    command.Parameters.AddWithValue("@Departamento", employee.Departamento);
                    command.Parameters.AddWithValue("@Municipio", employee.Municipio);
                    command.Parameters.AddWithValue("@Ubicacion", employee.Ubicacion);
                    command.Parameters.AddWithValue("@Calle", employee.Calle);
                    command.Parameters.AddWithValue("@CodigoCasa", employee.CodigoCasa);
                    command.Parameters.AddWithValue("@RolID", employee.RolId);

                    affectedRows = command.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error al actualizar el empleado: {ex.Message}");
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

                string query = "SELECT * FROM roles;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Rol rol = new Rol();

                            rol.Id = (int)reader["id_rol"];
                            rol.Nombre = (string)reader["nombre_rol"];
                            rol.SueldoHora = reader.GetDecimal(reader.GetOrdinal("sueldo_hora"));

                            roles.Add(rol);
                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la obtención de roles: "+ ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return roles;
        } 

        public int AddRol(Rol rol)
        {
            try
            {
                OpenConnection();
                string query = "insert into roles (nombre_rol, sueldo_hora) values (@Rol, @SueldoHora);";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@Rol", rol.Nombre);
                    command.Parameters.AddWithValue("@SueldoHora", rol.SueldoHora);

                    return command.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al intentar añadir el rol: " + ex.Message);
                return 0;
            }
            finally
            {
                CloseConnection();
            }
        }

        public int DeleteRol(int rolID)
        {
            try
            {
                OpenConnection();
                string query = "delete from roles where id_rol = @RolID;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@RolID", rolID);

                    return command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al intentar eliminar el rol: " + ex.Message);
                return 0;
            }
            finally
            {
                CloseConnection();
            }
        }

        public int UpdateRol(Rol rol)
        {
            try
            {
                OpenConnection();
                string query = "update roles set sueldo_hora = @SueldoHora where id_rol = @RolID;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@RolID", rol.Id);
                    command.Parameters.AddWithValue("@SueldoHora", rol.SueldoHora);

                    return command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al intentar actualizar el rol: " + ex.Message);
                return 0;
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
