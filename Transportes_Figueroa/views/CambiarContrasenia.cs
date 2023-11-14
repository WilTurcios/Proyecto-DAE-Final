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
using Transportes_Figueroa.Services;
using Transportes_Figueroa.Utils;

namespace Transportes_Figueroa.views
{
    public partial class CambiarContrasenia : Form
    {
        private User _user;
        public string _newPassword;
        private UserManager UserDB = new UserManager();
        private PasswordEncryptor passwordEncryptor = new PasswordEncryptor("M1$Gz@jRq9T#pK&3wFvS!xU4nW8zZ*Cb");
        public CambiarContrasenia(User user)
        {
            InitializeComponent();
            this._user = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // verificar que la contraseña nueva no sea igual que la anterior

            string prevPassword = txtContraseniaPrevia.Text.Trim();
            string newPassword = txtNuevaContrasenia.Text.Trim();

            if(prevPassword == newPassword)
            {
                MessageBox.Show(
                    "La nueva contraseña no puede ser igual a la actual, por favor intenta de nuevo",
                    "Contraseña invalida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            string encryptedPassword = passwordEncryptor.EncryptPassword(newPassword);
            int affectedRows = UserDB.ChangeUserPassword(_user.Id, encryptedPassword);

            if(affectedRows > 0)
            {
                MessageBox.Show(
                    "Contraseña actualizada con éxito",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                _newPassword = newPassword;
                this.Close();

                return;
            }
            else
            {
                MessageBox.Show(
                    "Error al cambiar la contraseña, por favor intentalo de nuevo.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // comporbar si la contraseña es correcta
            string password = txtContraseniaPrevia.Text;
            string currentPassword = passwordEncryptor.DecryptPassword(_user.Contrasenia);


            if (currentPassword == password)
            {
                txtNuevaContrasenia.Enabled = true;
                Aceptar.Enabled = true;
                return;
            }
            else
            {
                MessageBox.Show(
                    "La contraseña insertada no es correcta, por favor intenta de nuevo",
                    "Contraseña incorrecta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                txtNuevaContrasenia.Enabled = false;
                Aceptar.Enabled = false;

                return;
            }

        }

        private void ConfirmarContrasenia_Load(object sender, EventArgs e)
        {
            txtNuevaContrasenia.Enabled = false;
            Aceptar.Enabled = false;
        }
    }
}
