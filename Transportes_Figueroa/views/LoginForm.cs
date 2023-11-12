using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transportes_Figueroa.models;
using Transportes_Figueroa.Models;
using Transportes_Figueroa.Services;
using Transportes_Figueroa.Utils;

namespace Transportes_Figueroa.views
{
    public partial class LoginForm : Form
    {
        private List<UserType> _userTypes = new List<UserType>();
        private List<Employee> _employees = new List<Employee>();
        private UserManager UsersDBManager = new UserManager();
        private EmployeeManager EmployeesDBManager = new EmployeeManager();
        private PasswordEncryptor passwordEncryptor = new PasswordEncryptor("M1$Gz@jRq9T#pK&3wFvS!xU4nW8zZ*Cb");
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Ingresar_Click(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text;
            string contrasenia = txtContrasenia.Text;

            User usuario = UsersDBManager.GerUserByEmail(correo);

            if (usuario != null)
            {
                string userType = _userTypes.FirstOrDefault(type => type.Id == usuario.TipoUsuarioId)?.Tipo;
                Guid employeeID = _employees.FirstOrDefault(employee => employee.IdUsuario == usuario.Id).Id;

                if (passwordEncryptor.DecryptPassword(usuario.Contrasenia) == contrasenia)
                {
                    if (!string.IsNullOrEmpty(userType))
                    {
                        main mainForm = new main(userType, employeeID);
                        mainForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("El tipo de usuario no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("La contraseña es incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El correo o contraseña son incorrectos. Asegúrate de escribir los datos solicitados correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            _userTypes = UsersDBManager.GetAllUserTypes();
            _employees = EmployeesDBManager.GetAllEmployees();
        }
    }
}
