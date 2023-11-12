using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportes_Figueroa.models;
using System.Data.SqlClient;
using System.Windows.Forms;
using Transportes_Figueroa.Models;

namespace Transportes_Figueroa.controllers
{
    internal class usersController
    {

        private SqlConnection connection = new SqlConnection();
        public usersController(string connectionString)
        {
            this.connection.ConnectionString = connectionString;
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
        
        public List<User> GetAll()
        {
            List<User> users = new List<User>();
            DataTable usersFromDB = new DataTable();

            try
            {
                OpenConnection();
                string query = $"select * from usuarios;";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(usersFromDB);

                    foreach (DataRow userFromDB in usersFromDB.Rows)
                    {
                        User user = new User();
                        user.Id = (Guid)userFromDB["id_usuario"]; // A esta técnica de parseo se le llama CASTING
                        user.Correo = (string)userFromDB["correo_usuario"];
                        user.Contrasenia = (string)userFromDB["contrasenia"];

                        user.TipoUsuarioId = (int)userFromDB["id_tipo_usuario"];


                        users.Add(user);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los usuarios: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return users;
        }

        public List<UserType> GetAllUserTypes()
        {
            List<UserType> userTypes = new List<UserType>();
            try
            {
                OpenConnection();

                string query = "SELECT * FROM tipo_usuarios;";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        UserType userType = new UserType();

                        var id = reader["id_tipo_usuario"];

                        userType.Id = (int)id;
                        userType.Tipo = (string)reader["tipo_usuario"];


                        userTypes.Add(userType);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al obtener los tipos de usuarios: " + ex.Message);
                throw; // Lanzar la excepción nuevamente para que sea manejada o registrada en otro lugar.
            }
            finally
            {
                CloseConnection();
            }

            return userTypes;
        }

        public void Add(User user)
        {
           try
            {
                using (SqlCommand command = new SqlCommand("INSERT INTO usuarios (id_usuario, correo_usuario, contrasenia, id_tipo_usuario) VALUES (@UsuarioID, @CorreoUsuario, @ContraseniaUsuario, @TipoUsuario);", this.connection))
                {
                    OpenConnection();

                    command.Parameters.AddWithValue("@CorreoUsuario", user.Correo);
                    command.Parameters.AddWithValue("@UsuarioID", user.Id);
                    command.Parameters.AddWithValue("@ContraseniaUsuario", user.Contrasenia);
                    command.Parameters.AddWithValue("@TipoUsuario", user.TipoUsuarioId);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al insertar el empleado: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }


        public User GetById(Guid userID)
        {
            User user = new User();
            DataTable userFromDB = new DataTable();

            try
            {
                OpenConnection();

                string query = $"SELECT * FROM user WHERE id_usuario = @UserID;";
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@UserID", userID);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(userFromDB);

                        foreach (DataRow infoUsuario in userFromDB.Rows)
                        {
                            user.Id = (Guid)infoUsuario["id_usuario"];
                            user.Correo= (string)infoUsuario["correo_usuario"];
                            user.Contrasenia = (string)infoUsuario["contrasenia"];
                        }
                    }
                }
            }
            catch
            {
                CloseConnection();
            }

            return user;
        }

        public User GetByEmail(string email)
        {
            User user = new User();

            try
            {
                OpenConnection();

                string query = $"SELECT * FROM usuarios WHERE correo_usuario = @Correo;";
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@Correo", email);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            user.Id = (Guid)reader["id_usuario"];
                            user.Correo = (string)reader["correo_usuario"];
                            user.Contrasenia = (string)reader["contrasenia"];
                            user.TipoUsuarioId = (int)reader["id_tipo_usuario"];
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al recuperar el usuario: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return user;
        }

        public int Delete(Guid userID)
        {
            int affectedRows = 0;
            try
            {
                OpenConnection();
                string query = "DELETE FROM usuarios WHERE id_usuario = @UserID;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userID);
                    affectedRows = command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar usuario: {ex.Message}");
            }
            finally
            {
                CloseConnection();
            }
            return affectedRows;
        }

        public int ChangePassword(Guid userID, string password)
        {
            int affectedRows = 0;
            try
            {
                OpenConnection();
                string query = "UPDATE usuarios SET contrasenia = @Contrasenia  WHERE id_usuario = @UserID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userID);
                    command.Parameters.AddWithValue("@Contrasenia", password);

                    affectedRows = command.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido una excepción al cambiar la contraseña: {ex.Message}");
            }
            finally
            {
                CloseConnection();
            }

            return affectedRows;
        }

        public int ChangeRol(Guid userID, int tipoUsuario)
        {
            int affectedRows = 0;
            try
            {
                OpenConnection();
                string query = "UPDATE usuarios SET id_tipo_usuario = @TipoUsuario  WHERE id_usuario = @UserID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userID);
                    command.Parameters.AddWithValue("@TipoUsuario", tipoUsuario);

                    affectedRows = command.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido una excepción al cambiar el rol del usuario: {ex.Message}");
            }
            finally
            {
                CloseConnection();
            }

            return affectedRows;
        }
    }
}
