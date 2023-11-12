using System;
using System.Collections.Generic;
using Transportes_Figueroa.controllers;
using Transportes_Figueroa.models;
using Transportes_Figueroa.Models;

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

        public List<User> GetAllUsers()
        {
            return UsersDataManager.GetAll();
        }

        public List<UserType> GetAllUserTypes()
        {
            return UsersDataManager.GetAllUserTypes();
        }

        public void  AddUser(Guid userID, string correo, string contrasenia, int tipoUsuario)
        {
            User nuevoUsuario = new User() { Id = userID, Correo = correo, Contrasenia = contrasenia, TipoUsuarioId = tipoUsuario };

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

        public User GerUserByEmail(string correo)
        {
            return UsersDataManager.GetByEmail(correo);
        }

        public int ChangeUserPassword(Guid userID, string password)
        {
            return UsersDataManager.ChangePassword(userID, password);
        }

        public int ChangeUserRol(Guid userID, int tipoUsuario)
        {
            return UsersDataManager.ChangeRol(userID, tipoUsuario);
        }
    }
}
