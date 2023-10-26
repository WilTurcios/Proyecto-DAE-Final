using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportes_Figueroa.models;
using System.Data.SqlClient;
using System.Windows.Forms;

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

                        users.Add(user);
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

            return users;
        }

        public Guid Add(User user)
        {
            using (SqlCommand command = new SqlCommand("INSERT INTO usuarios (id_usuario, correo_usuario, contrasenia) VALUES (@UsuarioID, @CorreoUsuario, @ContraseniaUsuario); SELECT SCOPE_IDENTITY();", this.connection))
            {

                command.Parameters.AddWithValue("@CorreoUsuario", user.Correo);
                command.Parameters.AddWithValue("@UsuarioID", user.Id);
                command.Parameters.AddWithValue("@ContraseniaUsuario", user.Contrasenia);

                return (Guid)command.ExecuteScalar();
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
                Console.WriteLine($"Excepción: {ex.Message}");
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
                string query = "UPDATE usuarios SET contrasenia = @Contrasenia WHERE id_usuario = @UserID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userID);
                    command.Parameters.AddWithValue("@Contrasenia", password);

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
    }
}
