using System;
using Transportes_Figueroa.controllers;
using Transportes_Figueroa.models;

namespace Transportes_Figueroa.Services
{
    internal class UserManager
    {
        string connectionString = "Data Source=DESKTOP-NFDMETJ; Initial Catalog=TransportesDB; Integrated Security=true";
        usersController UsersDataManager = null;

        public UserManager()
        {
            UsersDataManager = new usersController(connectionString);
        }

        public void  AddUser(Guid userID, string correo, string contrasenia)
        {
            User nuevoUsuario = new User() { Id = userID, Correo = correo, Contrasenia = contrasenia };

            UsersDataManager.Add(nuevoUsuario);
        }

        public int DeleteUser(Guid userID)
        {
            return UsersDataManager.Delete(userID);
        }

        public User GetUser(Guid userID)
        {
            return UsersDataManager.GetById(userID);
        }

        public int ChangeUserPassword(Guid userID, string password)
        {
            return UsersDataManager.ChangePassword(userID, password);
        }
    }
}
